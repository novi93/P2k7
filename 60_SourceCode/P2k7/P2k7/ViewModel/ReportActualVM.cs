//using FujinetWMSDLL;
//using FujinetWMSDLL.Common;
using P2k7.Data;
using P2k7.Model;
using System;
using System.Web.Services.Protocols;
using System.Windows.Forms;

using PSLib = Microsoft.Office.Project.Server.Library;

namespace P2k7.ViewModel
{
    public class ReportActualVM
    {
        public ReportActualVM(MySettings mySettings,
            ProjectRepository PrjRepo,
            TaskRepository TskRepo,
            ReportActualModel model)
        {
            this.MySettings = mySettings;
            this.PrjRepo = PrjRepo;
            this.TskRepo = TskRepo;
            Model = model;
            InitHeader();

            SourcedTree = new BindingSource();
        }

        public Guid projectGuid { get; set; } = Guid.NewGuid();

        public MySettings MySettings { get; }
        public ProjectRepository PrjRepo { get; }
        public TaskRepository TskRepo { get; }
        public ReportActualModel Model { get; }
        public string ssVersion { get; internal set; }
        public string tsUserName { get; private set; }
        public BindingSource SourcedTree { get; internal set; }

        public void WriteLog(string LogString)
        {
            //lblStatus = LogString + "\r\n" + lblStatus;

            //Application.DoEvents();
        }
        public void InitHeader()
        {
            var now = DateTime.Now;
            // todo process month
            Model.DateFrom = new DateTime(2020, 10, 21);
            Model.DateTo = new DateTime(2020, 11, 20);
        }

        internal void ShowReport()
        {
            var PRJ_ID = new Guid("59f00468-145a-4d16-afa1-42e415237bf3");
            var startDate = new DateTime(2020, 09, 26);
            var endDate = new DateTime(2020, 10, 25);
            var rs = TskRepo.SummaryEffortTree(PRJ_ID, startDate, endDate);
            SourcedTree.DataSource = rs;
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
            try
            {
                //this.Cursor = Cursors.WaitCursor;
                //resetDataGrids();
                try
                {
                    PSLib.DataStoreEnum dataStoreEnum = PSLib.DataStoreEnum.WorkingStore;

                    //if (cbCompare.Checked && rbPublished.Checked)
                    //{
                    //    dataStoreEnum = PSLib.DataStoreEnum.WorkingStore;
                    //}
                    //else if (rbPublished.Checked)
                    //{
                    //    beforeUpdateProjectDataSet = null;
                    //    dataStoreEnum = PSLib.DataStoreEnum.PublishedStore;
                    //}
                    ProjectWebSvc.ProjectDataSet readProjectDataSet = new ProjectWebSvc.ProjectDataSet();

                    readProjectDataSet = PrjRepo.ReadProject(projectGuid, (ProjectWebSvc.DataStoreEnum)dataStoreEnum);
                    //this.Text = readProjectDataSet.Project[0].PROJ_NAME + " - Project Details...";
                }
                catch (SoapException ex)
                {
                    //ShowMessages(Program.CatchSoapException(ex));
                    throw;
                }
                //BindDataGrids();

                //if (beforeUpdateProjectDataSet != null)
                //{
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.Project,
                //        beforeUpdateProjectDataSet.Project, dgProj);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.Task,
                //        beforeUpdateProjectDataSet.Task, dgTask);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.Assignment,
                //        beforeUpdateProjectDataSet.Assignment, dgAssignment);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.Dependency,
                //        beforeUpdateProjectDataSet.Dependency, dgDependency);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.ProjectResource,
                //        beforeUpdateProjectDataSet.ProjectResource, dgProjectResources);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.ProjectCustomFields,
                //        beforeUpdateProjectDataSet.ProjectCustomFields, dgProjectCF);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.TaskCustomFields,
                //        beforeUpdateProjectDataSet.TaskCustomFields, dgTaskCF);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.AssignmentCustomFields,
                //        beforeUpdateProjectDataSet.AssignmentCustomFields, dgAssignmentCF);
                //    ProjTool.Program.CompareDataTable(readProjectDataSet.ProjectResourceCustomFields,
                //        beforeUpdateProjectDataSet.ProjectResourceCustomFields, dgProjectResourceCF);

                //    beforeUpdateProjectDataSet = new ProjectWebSvc.ProjectDataSet();
                //    beforeUpdateProjectDataSet = (ProjectWebSvc.ProjectDataSet)readProjectDataSet.Copy();
                //}
                //else
                //{
                //    beforeUpdateProjectDataSet = new ProjectWebSvc.ProjectDataSet();
                //    beforeUpdateProjectDataSet = (ProjectWebSvc.ProjectDataSet)readProjectDataSet.Copy();
                //}

            }
            catch (IndexOutOfRangeException)
            {
                // ReadProject might return an empty dataset. Ignore this error 
                // while trying to access the row zero.
            }
            catch (Exception ex)
            {
                //ShowMessages(ex.Message);
                throw;
            }
            finally
            {
                //SetCurrentTabPage();
                //txtFind_TextChanged(txtFind, new EventArgs());
                //this.Cursor = Cursors.Default;
            }
        }
    }
}
