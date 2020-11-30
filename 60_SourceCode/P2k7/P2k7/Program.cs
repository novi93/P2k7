using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using P2k7.Core.Extension;
using P2k7.Data;
using P2k7.View;
using System;
using System.Linq;
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

            string[] TransientNamespace = { "P2k7.View", "P2k7.VM","P2k7.ViewModel", "P2k7.Model" };
            string[] SingletonNamespace = { "P2k7.Data" };
            string[] AssemblyName = {Assembly.GetExecutingAssembly().GetName().Name };
            services.RegisterTransientNamespace(AssemblyName,TransientNamespace);
            services.RegisterSingletonNamespace(AssemblyName,SingletonNamespace);


            services.AddSingleton<MySettings>();
            services.AddSingleton<ProjectRepository>();

            // auto mapper
            services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>(),
                                       AppDomain.CurrentDomain.GetAssemblies());
        }
        public static void RegisterNameSpace(IServiceCollection services, string[] Assemblies, string @NameSpace)
        {
            foreach (var a in Assemblies)
            {
                Assembly loadedAss = Assembly.Load(a);

                var q = from t in loadedAss.GetTypes()
                        where t.IsClass && !t.Name.Contains("<") && t.Namespace.EndsWith(@NameSpace)
                        select t;

                foreach (var t in q.ToList())
                {
                    Type.GetType(t.Name);
                    services.AddTransient(Type.GetType(t.FullName), Type.GetType(t.FullName));
                }
            }
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
