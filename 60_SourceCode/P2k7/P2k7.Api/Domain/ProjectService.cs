using P2k7.Api.Data;
using System;
using System.Data;
using System.Net;
using System.Web.Services.Protocols;
using PSLib = Microsoft.Office.Project.Server.Library;

namespace P2k7.Api.Service
{
    public class ProjectService :BaseService
    {
        public ProjectService(ProjectRepository loginRepo, MySettings mySettings)
        {
            LoginRepo = loginRepo;
            MySettings = mySettings;
        }

        public ProjectRepository LoginRepo { get; }
        public MySettings MySettings { get; }
        public string ssVersion { get; set; }
        public string lblStatus { get; set; }
        public string tsUserName { get; private set; }

        public void ReadProjectsList()
        {
                ProjectWebSvc.ProjectDataSet projectList = new ProjectWebSvc.ProjectDataSet();
                // Get only project types that are usable.
                projectList.Merge(LoginRepo.project.ReadProjectStatus(Guid.Empty,
                    ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                    -1));

                projectList.Merge(LoginRepo.project.ReadProjectStatus(Guid.Empty,
                    ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                    (int)PSLib.Project.ProjectType.Project));

                projectList.Merge(LoginRepo.project.ReadProjectStatus(Guid.Empty,
                    ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                    (int)PSLib.Project.ProjectType.LightWeightProject));

                projectList.Merge(LoginRepo.project.ReadProjectStatus(Guid.Empty,
                    ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                    (int)PSLib.Project.ProjectType.MasterProject));

                projectList.Merge(LoginRepo.project.ReadProjectStatus(Guid.Empty,
                    ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                    (int)PSLib.Project.ProjectType.InsertedProject));

                if (projectList.Tables.Count == 0)
                {
                    throw new Exception("Data Not Found");
                }
                DataView dataView = new DataView(projectList.Project);
                dataView.Sort = "PROJ_LAST_SAVED DESC";
                dataView.RowFilter = @"PROJ_UID <> '00000000-0000-0000-0000-000000000000'";

        }

    } //class
} //namespace
