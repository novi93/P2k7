using P2k7.Api.Data;
using P2k7.Entities;
using System;

namespace P2k7.Api.Service
{
    public class LoginService : BaseService
    {

        public LoginService(MySettings  mySettings, ProjectRepository LoginRepo)
        {
            this.mySettings = mySettings;
            this.repository = LoginRepo;
        }

        public ProjectRepository repository { get; }
        public MySettings mySettings { get; }

        public void SaveSettings(MySettings Model)
        {
            mySettings.ProjectServerURL = Model.ProjectServerURL;
            mySettings.UserName = Model.UserName;
            mySettings.PassWord = Model.PassWord;
            mySettings.IsWindowsAuth = Model.IsWindowsAuth;
            if (Model.IsWindowsAuth)
            {
                mySettings.WindowsPort = new Uri(Model.ProjectServerURL).Port;
            }
            else
            {
                mySettings.FormsPort = new Uri(Model.ProjectServerURL).Port;
            }

        }

        internal string GetToken(string userName)
        {
            throw new NotImplementedException();
        }

        public LoginEntity Login(LoginEntity model)
        {
            return repository.Login(model);
        }
    }
}
