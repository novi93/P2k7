using P2k7.Data;
using System;
using System.Data;
using System.Net;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using PSLib = Microsoft.Office.Project.Server.Library;

namespace P2k7.ViewModel
{
    public class ProjectVM
    {
        public ProjectVM(ProjectRepository loginRepo, MySettings mySettings)
        {
            LoginRepo = loginRepo;
            MySettings = mySettings;
            SourcedgProjList = new BindingSource();
        }

        public ProjectRepository LoginRepo { get; }
        public MySettings MySettings { get; }
        public string ssVersion { get; set; }
        public string lblStatus { get; set; }
        public string tsUserName { get; private set; }
        //public DataView dgProjListDataSource { get; private set; }
        public BindingSource  SourcedgProjList { get; internal set; }

        public void WriteLog(string LogString)
        {
            lblStatus = LogString + "\r\n" + lblStatus;

            //Application.DoEvents();
        }
  

        public void ReadProjectsList()
        {
            try
            {
                //this.Cursor = Cursors.WaitCursor;
                SetUserNameToDisplay();
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
                    SourcedgProjList = null;
                    RefreshDgProjList();
                    WriteLog("No projects are available on Project Server");
                    return;
                }
                DataView dataView = new DataView(projectList.Project);
                dataView.Sort = "PROJ_LAST_SAVED DESC";
                dataView.RowFilter = @"PROJ_UID <> '00000000-0000-0000-0000-000000000000'";
                SourcedgProjList.DataSource = dataView;
                //foreach (DataGridViewColumn col in dgProjList.Columns)
                //foreach (DataGridViewColumn col in SourcedgProjList.DataSource.Table.Columns)
                //{
                //    if (col.Name == "PROJ_CHECKOUTBY")
                //        col.DisplayIndex = 3;
                //    if (col.Name == "PROJ_CHECKOUTBY_NAME")
                //        col.DisplayIndex = 4;
                //    if (col.Name == "PROJ_CHECKOUTDATE")
                //        col.DisplayIndex = 5;
                //    if (col.Name == "PROJ_SESSION_UID")
                //        col.DisplayIndex = 6;
                //    if (col.Name == "PROJ_SESSION_DESCRIPTION")
                //        col.DisplayIndex = 7;
                //    if (col.Name == "PROJ_LAST_SAVED")
                //        col.DisplayIndex = 8;
                //    if (col.Name == "PROJ_STATUS")
                //        col.DisplayIndex = 9;
                //}
                //todo
                //dgProjList.Columns[0].Frozen = true;
                //dgProjList.Columns[1].Frozen = true;

                WriteLog("ReadProjectsList call successful");
            }
            catch (Exception ex)
            {
                RefreshDgProjList();
                WriteLog("ReadProjectsList call failed. Error message: " + ex.Message);
            }
            finally
            {
                //this.Cursor = Cursors.Default;
            }
        }

        private void RefreshDgProjList()
        {
            //throw new NotImplementedException();
            //todo
        }

        private void SetUserNameToDisplay()
        {
            if (MySettings.isImpersonated)
            {
                this.tsUserName = "Impersonated user: " + MySettings.impersonatedUserName;
                return;
            }
            if (MySettings.IsWindowsAuth)
            {
                this.tsUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
            else
            {
                this.tsUserName = MySettings.UserName;
            }
        }
    } //class
} //namespace
