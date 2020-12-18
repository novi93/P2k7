using iProject.Core;
using iProject.Core.Extension;
using iProject.Model;
using iProject.View;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using P2k7;
using P2k7.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Web;

namespace iProject.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private readonly ISnackbarMessageQueue _snackbarMessageQueue;

        public LoginViewModel(ISnackbarMessageQueue snackbarMessageQueue)
        {
            _snackbarMessageQueue =  snackbarMessageQueue ?? throw new ArgumentNullException(nameof(snackbarMessageQueue)); 
            Init();
            LoginCommand = new AnotherCommandImplementation(Login,
                _ => !string.IsNullOrWhiteSpace(ServerUri) );
        }

        public void Init()
        {
            mySettings = new MySettings();
            LoginRepo = new PsiRepository(mySettings);
        }
        public PsiRepository LoginRepo { get; set; }
        public MySettings mySettings { get; set; }

        public string ServerUri { get; set; }
        public AnotherCommandImplementation LoginCommand { get;  }
        private void Login(object obj)
        {
            try
            {
                SaveSettings();
                LoginRepo.ClearImpersonation();
                if (LoginRepo.P12Login())
                {
                    mySettings.loginStatus = 0;
                    _snackbarMessageQueue.Enqueue("Login Success!");
                }
            }
            //catch (SoapException se)
            //{
            //    _snackbarMessageQueue.Enqueue(se.Message);
            //    mySettings.loginStatus = 1;
            //    //this.txtProjectServerUrl.Focus();

            //}
            catch (Exception ex)
            {
                _snackbarMessageQueue.Enqueue(ex.Message);
                mySettings.loginStatus = 1;

            }
        }

        private void SaveSettings()
        {
            mySettings.ProjectServerURL = ServerUri;
            mySettings.UserName = string.Empty;
            mySettings.PassWord = string.Empty;
            mySettings.IsWindowsAuth = true;
            if (mySettings.IsWindowsAuth)
            {
                mySettings.WindowsPort = new Uri(mySettings.ProjectServerURL).Port;
            }
            else
            {
                mySettings.FormsPort = new Uri(mySettings.ProjectServerURL).Port;
            }
            mySettings.Save();

        }
    }
}
