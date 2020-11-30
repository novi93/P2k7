using P2k7.Data;
using P2k7.Model;
using System;

namespace P2k7.ViewModel
{
    public class LoginVM
    {

        public LoginVM(LoginModel model,MySettings  mySettings, ProjectRepository LoginRepo)
        {
            this.Model = model;
            this.mySettings = mySettings;
            this.LoginRepo = LoginRepo;
            Model.ProjectServerUrl = mySettings.ProjectServerURL;
        }

        public ProjectRepository LoginRepo { get; }
        public LoginModel Model { get; }
        public MySettings mySettings { get; }

        public void SaveSettings()
        {
            mySettings.ProjectServerURL = Model.ProjectServerUrl;
            mySettings.UserName = Model.UserName;
            mySettings.PassWord = Model.Password;
            mySettings.IsWindowsAuth = Model.IsWindowsAuth;
            if (Model.IsWindowsAuth)
            {
                mySettings.WindowsPort = new Uri(Model.ProjectServerUrl).Port;
            }
            else
            {
                mySettings.FormsPort = new Uri(Model.ProjectServerUrl).Port;
            }
            mySettings.Save();

        }

    }
}
