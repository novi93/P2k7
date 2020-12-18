using P2k7.Api.Utils;
using P2k7.Entities;
using System;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Services.Protocols;

namespace P2k7.Api.Data
{
    public class PsiWrapper
    {

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

        public void SetCookies(CookieContainer cookies)
        {
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

        public void SetUrl(string baseUrl, string addUrl)
        {
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
        }

        public string SetPortforImpersonation(string psUrl, int ImpersonationPort)
        {
            var ServerUri = new Uri(psUrl);

            psUrl = Regex.Replace(psUrl, ServerUri.Authority, ServerUri.Host + ":"
                + ImpersonationPort, RegexOptions.IgnoreCase);
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

        public string SetPortforForms(string psUrl, int FormsPort)
        {
            var ServerUri = new Uri(psUrl);
            if (ServerUri.Port != FormsPort)
            {
                if (ServerUri.Port == 80)
                {
                    psUrl = Regex.Replace(psUrl, ServerUri.Authority, ServerUri.Host + ":"
                        + FormsPort, RegexOptions.IgnoreCase);
                }
                else
                {
                    psUrl = Regex.Replace(psUrl, ":" + ServerUri.Port, ":"
                        + FormsPort, RegexOptions.IgnoreCase);
                }
            }
            return AppendToUrl(psUrl);
        }

        public string SetPortforWindows(string psUrl, int WindowsPort)
        {
            var ServerUri = new Uri(psUrl);
            if (ServerUri.Port != WindowsPort)
            {
                if (WindowsPort == 80)
                {
                    psUrl = Regex.Replace(psUrl, ":" + ServerUri.Port, "", RegexOptions.IgnoreCase);
                }
                else
                {
                    psUrl = Regex.Replace(psUrl, ":" + ServerUri.Port, ":" + WindowsPort, RegexOptions.IgnoreCase);
                }
            }
            return AppendToUrl(psUrl);
        }

        public string ProjectServerVersion()
        {
            string major, minor, build, revision;
            string version;

            try
            {
                DataSet dsInfo = admin.ReadServerVersion();

                DataRow row = dsInfo.Tables["ServerVersion"].Rows[0];
                major = row["WADMIN_VERSION_MAJOR"].ToString();
                minor = row["WADMIN_VERSION_MINOR"].ToString();
                build = row["WADMIN_VERSION_BUILD"].ToString();
                revision = row["WADMIN_VERSION_REVISION"].ToString();

                build = build.Insert(build.Length - 4, ".");

                version = major + "." +
                    minor + "." +
                    build + ", rev. " +
                    revision;
            }
            catch (SoapException ex)
            {
                version = "Error - SOAP exception in ProjectServerVersion." + "\n\n" + ex.Message.ToString();
            }
            catch (WebException ex)
            {
                version = "Error - Web Exception in ProjectServerVersion" + "\n\n" + ex.Message.ToString();
            }
            return version;
        }

    }
}
