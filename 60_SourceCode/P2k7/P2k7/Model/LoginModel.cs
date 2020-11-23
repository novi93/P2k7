namespace P2k7.Model
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ProjectServerUrl { get; set; }
        public LoginMode LoginMode { get; set; } = LoginMode.WindowsAuth;
        public bool IsWindowsAuth
        {
            get
            {
                return LoginMode == LoginMode.WindowsAuth;
            }
        }
    }

    public enum LoginMode
    {
        WindowsAuth,
        FormAuth
    }
}
