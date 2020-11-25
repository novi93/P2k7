using FujinetWMSDLL;
using FujinetWMSDLL.Common;
using P2k7.Core.Behavior;
using P2k7.Core.Extension;
using P2k7.Data;
using P2k7.Entities;
using P2k7.Model;
using System;
using System.Data;
using System.Web.Services.Protocols;
using System.Windows.Forms;

using PSLib = Microsoft.Office.Project.Server.Library;
namespace P2k7.ViewModel
{
    public class ReportActualVM
    {
        public ReportActualVM(MySettings mySettings,
            ProjectRepository loginRepo,
            ReportActualModel model,
            FjsSumaryEffortBehabior FjsSumaryEffortBehabior)
        {
            this.MySettings = mySettings;
            Repo = loginRepo;
            Model = model;
            this.FjsSumaryEffortBehabior = FjsSumaryEffortBehabior;
            InitHeader();

            SourcedTree = new BindingSource();
        }

        public Guid projectGuid { get; set; } = Guid.NewGuid();

        public MySettings MySettings { get; }
        public ProjectRepository Repo { get; }
        public ReportActualModel Model { get; }
        public FjsSumaryEffortBehabior FjsSumaryEffortBehabior { get; }
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

        public void GetData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("ParentId", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("DD", typeof(decimal));
            dt.Columns.Add("PG", typeof(decimal));

            var r1 = dt.NewRow();
            r1["Id"] = 1;
            r1["ParentId"] = 0;
            r1["Name"] = "node1";
            r1["DD"] = 10.1;
            r1["PG"] = 12.1;

            var r2 = dt.NewRow();
            r2["Id"] = 2;
            r2["ParentId"] = 1;
            r2["Name"] = "node2";
            r2["DD"] = 10.1;
            r2["PG"] = 12.1;

            var r3 = dt.NewRow();
            r3["Id"] = 3;
            r3["ParentId"] = 1;
            r3["Name"] = "node3";
            r3["DD"] = 10.1;
            r3["PG"] = 12.1;

            dt.Rows.Add(r1);
            dt.Rows.Add(r2);
            dt.Rows.Add(r3);

            SourcedTree.DataSource = dt;
        }

        internal void ShowReport()
        {
            //var a = GetPrj();
            var Prjid = new Guid("59f00468-145a-4d16-afa1-42e415237bf3");
            //var b = Repo.ReadProject(Prjid, (ProjectWebSvc.DataStoreEnum)PSLib.DataStoreEnum.PublishedStore);

            //var c = b.Tables["Task"];
            //var d = c.AsEnumerable().Select(x => new ReportActualDetail()
            //{
            //    Id = Convert.ToInt32(x["TASK_UID"]),
            //    //ParentId = x["TASK_IS_SUMMARY"].ToString() == "true" ? x["TASK_PARENT_UID"] : x["PROJ_UID"],
            //    ParentId =  Convert.ToInt32(x["TASK_IS_SUMMARY"].ToString() == "True" ? 0 : x["TASK_PARENT_UID"]),
            //    Name = x["TASK_NAME"].ToString(),
            //    Actual =  Convert.ToDecimal(x["TASK_ACT_WORK"])
            //}
            //);
            //var e = d.ToDataTable();


            //var c11 = Repo.test(Prjid, (ProjectWebSvc.DataStoreEnum)PSLib.DataStoreEnum.PublishedStore);
                        
            var startDate = new DateTime(2020,09,26);
            var endDate = new DateTime(2020,10,25);
            var userID = "VIET-BN";
            var projectIDOrName = "";
			//var projectList = cls_CM_Project.FilterProjects(userID, projectIDOrName, startDate, endDate, statusList);
			cls_CM_Function.OverrideCertificateValidation();
            
			cls_CM_Project cls_CM_Project = new cls_CM_Project();
			//var projectList = cls_CM_Project.fncG_PJ_ListActiveProjectWithBasicInfo(userID, true, true, true, true, true, true);

            var project = new cls_CM_Project();
            project.ID = "59f00468-145a-4d16-afa1-42e415237bf3";
            project.ScheduleID = new Guid("59f00468-145a-4d16-afa1-42e415237bf3");
            project.ScheduleIDList = "59f00468-145a-4d16-afa1-42e415237bf3";
            var scheduleList = FjsSumaryEffortBehabior.LoadProjectScheduleList(project);


            var selectedscheduleList = scheduleList[3];
            var rs = FjsSumaryEffortBehabior.SummaryEffort_ItemClick(selectedscheduleList,startDate,endDate);

            var i = 1;
            i = 9;
            //SourcedTree.DataSource = d;
        }

        private ProjectWebSvc.ProjectDataSet GetPrj()
        {
            ProjectWebSvc.ProjectDataSet projectList = new ProjectWebSvc.ProjectDataSet();
            // Get only project types that are usable.
            projectList.Merge(Repo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                -1));

            projectList.Merge(Repo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.Project));

            projectList.Merge(Repo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.LightWeightProject));

            projectList.Merge(Repo.project.ReadProjectStatus(Guid.Empty,
                ProjectWebSvc.DataStoreEnum.WorkingStore, "",
                (int)PSLib.Project.ProjectType.MasterProject));

            projectList.Merge(Repo.project.ReadProjectStatus(Guid.Empty,
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

                    readProjectDataSet = Repo.ReadProject(projectGuid, (ProjectWebSvc.DataStoreEnum)dataStoreEnum);
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
