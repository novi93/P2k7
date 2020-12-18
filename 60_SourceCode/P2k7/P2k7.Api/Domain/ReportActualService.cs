
using P2k7.Api.Data;
using System;


using PSLib = Microsoft.Office.Project.Server.Library;

namespace P2k7.Api.Service
{
    public class ReportActualService : BaseService
    {
        public ReportActualService(MySettings mySettings,
            ProjectRepository PrjRepo,
            TaskRepository TskRepo)
        {
            this.MySettings = mySettings;
            this.PrjRepo = PrjRepo;
            this.TskRepo = TskRepo;

        }

        public Guid projectGuid { get; set; } = Guid.NewGuid();

        public MySettings MySettings { get; }
        public ProjectRepository PrjRepo { get; }
        public TaskRepository TskRepo { get; }
        public string ssVersion { get; internal set; }
        public string tsUserName { get; private set; }

        public void WriteLog(string LogString)
        {
            //lblStatus = LogString + "\r\n" + lblStatus;

            //Application.DoEvents();
        }

        private ProjectWebSvc.ProjectDataSet GetPrj()
        {
            ProjectWebSvc.ProjectDataSet projectList = new ProjectWebSvc.ProjectDataSet();
            // Get only project types that are usable.
            projectList.Merge(PrjRepo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                -1));

            projectList.Merge(PrjRepo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.Project));

            projectList.Merge(PrjRepo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.LightWeightProject));

            projectList.Merge(PrjRepo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.MasterProject));

            projectList.Merge(PrjRepo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.InsertedProject));
            return projectList;
        }

        private void RefreshProjectGrid()
        {

            PSLib.DataStoreEnum dataStoreEnum = PSLib.DataStoreEnum.WorkingStore;

            ProjectWebSvc.ProjectDataSet readProjectDataSet = new ProjectWebSvc.ProjectDataSet();

            readProjectDataSet = PrjRepo.ReadProject(projectGuid, (ProjectWebSvc.DataStoreEnum)dataStoreEnum);

        }
    }
}
