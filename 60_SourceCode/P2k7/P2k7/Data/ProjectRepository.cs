using P2k7.Utils;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace P2k7.Data
{
    public class ProjectRepository
    {
        //public string ProjectServerUrl = "";
        //public string UserName = "";
        //public string Password = "";
        //public bool IsWindowsAuth = true;
        //public int WindowsPort = 80;
        //public int FormsPort = 81;
        //public int ImpersonationPort = 56737;
        //public bool waitForQueue = true;
        //public bool waitForIndividualQueue = false;
        //public bool AutoLogin = false;

        public Guid jobGuid;
        //public Guid projectGuid = new Guid();

        public AdminDerived admin = new AdminDerived();
        public ArchiveDerived archive = new ArchiveDerived();
        public CalenderDerived calendar = new CalenderDerived();
        public CustomFieldsDerived customFields = new CustomFieldsDerived();
        public EventsDerived events = new EventsDerived();
        public LoginFormsDerived loginForms = new LoginFormsDerived();
        public LoginWindowsDerived loginWindows = new LoginWindowsDerived();
        public LookUpTableDerived lookupTable = new LookUpTableDerived();
        public ProjectDerived project = new ProjectDerived();
        public QueueSystemDerived queueSystem = new QueueSystemDerived();
        public ResourceDerived resource = new ResourceDerived();
        public SecurityDerived security = new SecurityDerived();
        public StatusingDerived statusing = new StatusingDerived();
        public TimesheetDerived timesheet = new TimesheetDerived();

        private String ContextString = String.Empty;
        private readonly MySettings mySettings;

        public ProjectRepository(MySettings mySettings)
        {
            this.mySettings = mySettings;
        }


        public bool P12Login()
        {
            try
            {
                CookieContainer cookies = new CookieContainer();

                String baseUrl = mySettings.ProjectServerURL;
                string addUrl = "/_vti_bin/psi/";

                if (mySettings.isImpersonated)
                {
                    baseUrl = SetPortforImpersonation(baseUrl);
                    addUrl = mySettings.ImpersonationSite + "/PSI/";
                }
                else
                {
                    if (mySettings.IsWindowsAuth == true)
                    {
                        SetDefaultCredentials();
                    }
                    else
                    {
                        loginForms.Url = (SetPortforForms(baseUrl) + "/_vti_bin/psi/LoginForms.asmx");
                        loginForms.CookieContainer = cookies;
                        if (!loginForms.Login(mySettings.UserName, mySettings.PassWord))
                            return false;

                        admin.CookieContainer = cookies;
                        archive.CookieContainer = cookies;
                        calendar.CookieContainer = cookies;
                        customFields.CookieContainer = cookies;
                        events.CookieContainer = cookies;
                        lookupTable.CookieContainer = cookies;
                        project.CookieContainer = cookies;
                        queueSystem.CookieContainer = cookies;
                        resource.CookieContainer = cookies;
                        security.CookieContainer = cookies;
                        statusing.CookieContainer = cookies;
                        timesheet.CookieContainer = cookies;
                    }
                }

                admin.Url = (baseUrl + addUrl + "Admin.asmx");
                archive.Url = (baseUrl + addUrl + "Archive.asmx");
                calendar.Url = (baseUrl + addUrl + "Calendar.asmx");
                customFields.Url = (baseUrl + addUrl + "CustomFields.asmx");
                events.Url = (baseUrl + addUrl + "Events.asmx");
                lookupTable.Url = (baseUrl + addUrl + "LookupTable.asmx");
                project.Url = (baseUrl + addUrl + "Project.asmx");
                queueSystem.Url = (baseUrl + addUrl + "QueueSystem.asmx");
                resource.Url = (baseUrl + addUrl + "Resource.asmx");
                security.Url = (baseUrl + addUrl + "Security.asmx");
                statusing.Url = (baseUrl + addUrl + "Statusing.asmx");
                timesheet.Url = (baseUrl + addUrl + "Timesheet.asmx");

                return true;
            }
            catch (Exception ex)
            {
               return false;
            }
        }

        public string SetPortforImpersonation(string psUrl)
        {
            Uri ServerUri = new Uri(psUrl);

            psUrl = Regex.Replace(psUrl, ServerUri.Authority, ServerUri.Host + ":"
                + mySettings.ImpersonationPort, RegexOptions.IgnoreCase);
            psUrl = Regex.Replace(psUrl, ServerUri.LocalPath, "", RegexOptions.IgnoreCase);
            return AppendToUrl(psUrl);
        }
        public string AppendToUrl(string psUrl)
        {
            if (!psUrl.EndsWith("/"))
            {
                psUrl += "/";
            }
            return psUrl;
        }

        public void SetDefaultCredentials()
        {
            admin.Credentials = CredentialCache.DefaultCredentials;
            archive.Credentials = CredentialCache.DefaultCredentials;
            calendar.Credentials = CredentialCache.DefaultCredentials;
            customFields.Credentials = CredentialCache.DefaultCredentials;
            events.Credentials = CredentialCache.DefaultCredentials;
            loginForms.Credentials = CredentialCache.DefaultCredentials;
            lookupTable.Credentials = CredentialCache.DefaultCredentials;
            project.Credentials = CredentialCache.DefaultCredentials;
            queueSystem.Credentials = CredentialCache.DefaultCredentials;
            resource.Credentials = CredentialCache.DefaultCredentials;
            security.Credentials = CredentialCache.DefaultCredentials;
            statusing.Credentials = CredentialCache.DefaultCredentials;
            timesheet.Credentials = CredentialCache.DefaultCredentials;
        }

        public void ClearFormsCookies()
        {
            admin.CookieContainer = null;
            archive.CookieContainer = null;
            calendar.CookieContainer = null;
            customFields.CookieContainer = null;
            events.CookieContainer = null;
            lookupTable.CookieContainer = null;
            project.CookieContainer = null;
            queueSystem.CookieContainer = null;
            resource.CookieContainer = null;
            security.CookieContainer = null;
            statusing.CookieContainer = null;
            timesheet.CookieContainer = null;
        }

        public void SetImpersonation(bool isWindowsAccount, string userNTAccount, Guid resourceGuid, Guid siteId)
        {
            Guid trackingGuid = Guid.NewGuid();
            string lcid = "1033";

            AdminDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            ArchiveDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            CalenderDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            CustomFieldsDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            EventsDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            LoginFormsDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            LoginWindowsDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            LookUpTableDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            ProjectDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            QueueSystemDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            ResourceDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            SecurityDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            StatusingDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);
            TimesheetDerived.SetImpersonationContext(isWindowsAccount, userNTAccount, resourceGuid, trackingGuid, siteId, lcid);

            mySettings.impersonatedUserName = userNTAccount;
            mySettings.isImpersonated = true;
        }

        public void ClearImpersonation()
        {
            ContextString = string.Empty;
            mySettings.isImpersonated = false;
        }

                public  string SetPortforForms(string psUrl)
        {
            Uri ServerUri = new Uri(psUrl);
            if (ServerUri.Port != mySettings.FormsPort)
            {
                if (ServerUri.Port == 80)
                {
                    psUrl = Regex.Replace(psUrl, ServerUri.Authority, ServerUri.Host + ":" 
                        + mySettings.FormsPort, RegexOptions.IgnoreCase);
                }
                else
                {
                    psUrl = Regex.Replace(psUrl, ":" + ServerUri.Port, ":" 
                        + mySettings.FormsPort, RegexOptions.IgnoreCase);
                }
            }
            return AppendToUrl(psUrl);
        }

        public  string SetPortforWindows(string psUrl)
        {
            Uri ServerUri = new Uri(psUrl);
            if (ServerUri.Port != mySettings.WindowsPort)
            {
                if (mySettings.WindowsPort == 80)
                {
                    psUrl = Regex.Replace(psUrl, ":" + ServerUri.Port, "", RegexOptions.IgnoreCase);
                }
                else
                {
                    psUrl = Regex.Replace(psUrl, ":" + ServerUri.Port, ":" + mySettings.WindowsPort, RegexOptions.IgnoreCase);
                }
            }
            return AppendToUrl(psUrl);
        }

    }
}
