using System.Configuration;

namespace P2k7
{
    public class MySettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValueAttribute("http://LocalHost/PWA/")]
        public string ProjectServerURL
        {
            get { return (string)this["ProjectServerURL"]; }
            set { this["ProjectServerURL"] = value; }
        }
        [UserScopedSetting()]
        [DefaultSettingValueAttribute("FormsAdmin")]
        public string UserName
        {
            get { return (string)this["UserName"]; }
            set { this["UserName"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("pass@word1")]
        public string PassWord
        {
            get { return (string)this["PassWord"]; }
            set { this["PassWord"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("true")]
        public bool IsWindowsAuth
        {
            get { return (bool)this["IsWindowsAuth"]; }
            set { this["IsWindowsAuth"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("80")]
        public int WindowsPort
        {
            get { return (int)this["WindowsPort"]; }
            set { this["WindowsPort"] = value; }
        } 

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("81")]
        public int FormsPort
        {
            get { return (int)this["FormsPort"]; }
            set { this["FormsPort"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("56737")]
        public int ImpersonationPort
        {
            get { return (int)this["ImpersonationPort"]; }
            set { this["ImpersonationPort"] = value; }
        }


        [UserScopedSetting()]
        [DefaultSettingValueAttribute("true")]
        public bool WaitForQueue
        {
            get { return (bool)this["WaitForQueue"]; }
            set { this["WaitForQueue"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("false")]
        public bool waitForIndividualQueue
        {
            get { return (bool)this["waitForIndividualQueue"]; }
            set { this["waitForIndividualQueue"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("false")]
        public bool AutoLogin
        {
            get { return (bool)this["AutoLogin"]; }
            set { this["AutoLogin"] = value; }
        }


        [UserScopedSetting()]
        [DefaultSettingValueAttribute("1C5EEFEE-B59E-4F4D-BF7D-A8A021944E36")]
        public string ImpersonationSiteID
        {
            get { return (string)this["ImpersonationSiteID"]; }
            set { this["ImpersonationSiteID"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValueAttribute("SharedServices1")]
        public string ImpersonationSite
        {
            get { return (string)this["ImpersonationSite"]; }
            set { this["ImpersonationSite"] = value; }
        }
        //public int WindowsPort = 80;
        //public int FormsPort = 81;
        //public int ImpersonationPort = 56737;
        //public bool waitForQueue = true;
        //public bool waitForIndividualQueue = false;
        //public bool AutoLogin = false;

        public int loginStatus = 0;
        public bool isImpersonated = false;
        public string impersonatedUserName = "";
    }
}
