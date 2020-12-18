
namespace P2k7.Entities
{
    public class LoginEntity
    {
        public string ProjectServerURL { get; set; }
        public int WindowsPort { get; set; }
        public int FormsPort { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public bool IsWindowsAuth { get; set; }

        public string ImpersonationSite { get; set; }
        public int ImpersonationPort { get; set; }
        public string impersonatedUserName { get; set; }
        public bool isImpersonated { get; set; }
    }
}