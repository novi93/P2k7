﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using P2k7.Core.Behavior;
using P2k7.Data;
using P2k7.Model;
using P2k7.View;
using P2k7.ViewModel;
using System;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace P2k7
{
    static class Program
    {

      

        private static bool isNew;
        private static Mutex objmutex;
        public static readonly string AppName = "P2k7";
        public static string CopyRight = "　®Created by Novi";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);

            objmutex = new Mutex(true, AppName, out isNew);
            if (isNew)
            {
                using (ServiceProvider serviceProvider = services.BuildServiceProvider())
                {
                    var FrmStartup = serviceProvider.GetRequiredService<FrmReportActual>();
                    Application.Run(FrmStartup);
                }
            }
            else
            {
                MessageBox.Show("Application is already running.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FrmLogin>();
            services.AddTransient<LoginVM>();
            services.AddTransient<LoginModel>();

            services.AddTransient<FrmProject>();
            services.AddTransient<ProjectVM>();

            services.AddTransient<FrmReportActual>();
            services.AddTransient<ReportActualVM>();
            services.AddTransient<ReportActualModel>();
            services.AddTransient<FjsSumaryEffortBehabior>();

            services.AddSingleton<MySettings>();
            services.AddSingleton<ProjectRepository>();

            // auto mapper
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>(),
                                       AppDomain.CurrentDomain.GetAssemblies());
        }

        public static string VersionLabel()
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                return string.Format("{4} [{0}.{1}.{2}.{3}]", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
            }
            else
            {
                var ver = Assembly.GetExecutingAssembly().GetName().Version;
                return string.Format("{4} [{0}.{1}.{2}.{3}]", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
            }
        }


    }
}
