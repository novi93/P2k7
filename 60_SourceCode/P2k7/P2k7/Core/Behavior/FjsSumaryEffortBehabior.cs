
using Microsoft.VisualBasic.CompilerServices;
using P2k7.Core.Behavior.DB_SQLServer;
using P2k7.Data;
using P2k7.Entities;
using P2k7.Entities.Enum;
using P2k7.Entities.Structs;
using P2k7.LookuptableWebSvc;
using P2k7.ProjectWebSvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace P2k7.Core.Behavior
{
    public class FjsSumaryEffortBehabior
    {

        public FjsSumaryEffortBehabior(ProjectRepository proJectRepo, CustomFieldRepository cfRepo)
        {
            SummaryDataSource = new DataSet();
            this.ProJectRepo = proJectRepo;
            this.CfRepo = cfRepo;
        }
        public DataSet SummaryDataSource { get; private set; }
        public bool SumManWrkItem { get; private set; } = true;
        public bool SumDevWrkItem { get; private set; } = true;
        public bool SumFixWrkItem { get; private set; } = true;
        public bool SumOtherWrkItem { get; private set; } = true;
        public ProjectRepository ProJectRepo { get; }
        public CustomFieldRepository CfRepo { get; }

        private void SettingListColumn()
        {
            this.SummaryDataSource = new DataSet();
            DataTable dataTable4 = SummaryDataSource.Tables.Add("Novi");

            dataTable4.Columns.Add("Id", typeof(string));
            dataTable4.Columns.Add("ParentId", typeof(string));
            dataTable4.Columns.Add("Name", typeof(string));
            dataTable4.Columns.Add("DD", typeof(decimal));
            dataTable4.Columns.Add("PG", typeof(decimal));
            dataTable4.Columns.Add("SUM", typeof(decimal));
        }
        public List<subProjectInfo> SummaryBySubProject(List<Task2007Info> taskList,
                                                        bool countManagement,
                                                        bool countDevelopment,
                                                        bool countFixBug,
                                                        bool countOthers)
        {
            SettingListColumn();
            var list = new List<subProjectInfo>();
            // todo
            //cls_CM_ComboItem cls_CM_ComboItem = new cls_CM_ComboItem();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TaskUniqueID", typeof(Guid));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("ModuleName", typeof(string));
            dataTable.Columns.Add("WPROJ_ID", typeof(Guid));
            dataTable.Columns.Add("BaselineWork", typeof(decimal));
            dataTable.Columns.Add("Work", typeof(decimal));
            dataTable.Columns.Add("ActualWork", typeof(decimal));
            dataTable.Columns.Add("ActualOvertimeWork", typeof(decimal));
            dataTable.Columns.Add("SubPrjId", typeof(string));
            dataTable.Columns.Add("SubPrjName", typeof(string));
            dataTable.Columns.Add("TaskClass", typeof(short));
            dataTable.Columns.Add("Account", typeof(string));
            dataTable.Columns.Add("Phase", typeof(short));
            checked
            {
                int num = taskList.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    //todo
                    //cls_CM_ComboItem = new cls_CM_ComboItem();
                    //cls_CM_ComboItem = (cls_CM_ComboItem)this.ScheduleListItem.EditValue;
                    bool flag = Operators.CompareString(taskList[i].SubPrjName, "", false) == 0;
                    if (!flag)
                    {
                        DataRow dataRow = dataTable.Rows.Add(new object[0]);
                        dataRow["TaskUniqueID"] = taskList[i].ID;
                        dataRow["Name"] = taskList[i].Name;
                        dataRow["ModuleName"] = taskList[i].ModuleName;
                        dataRow["WPROJ_ID"] = taskList[i].ProjectID;
                        dataRow["BaselineWork"] = taskList[i].BaselinedEffort;
                        dataRow["Work"] = taskList[i].ScheduleEffort;
                        dataRow["ActualWork"] = taskList[i].ActualEffort;
                        dataRow["ActualOvertimeWork"] = taskList[i].OvertimeEffort;
                        dataRow["SubPrjId"] = taskList[i].ID;
                        dataRow["SubPrjName"] = taskList[i].SubPrjName;
                        dataRow["TaskClass"] = taskList[i].TaskPart;
                        dataRow["Phase"] = taskList[i].Phase;
                        dataRow["Account"] = taskList[i].ResourceNTAccount;
                    }
                }
                int num2 = dataTable.Rows.Count - 1;
                for (int j = 0; j <= num2; j++)
                {
                    bool flag2 = false;
                    int num3 = list.Count - 1;
                    for (int k = 0; k <= num3; k++)
                    {
                        bool flag3 = Operators.ConditionalCompareObjectEqual(list[k].SubProjectName, dataTable.Rows[j]["SubPrjName"], false);
                        if (flag3)
                        {
                            flag2 = true;
                            break;
                        }
                    }
                    bool flag4 = !flag2;
                    if (flag4)
                    {
                        list.Add(new subProjectInfo
                        {
                            SubProjectID = dataTable.Rows[j]["SubPrjId"].ToString(),
                            SubProjectName = Conversions.ToString(dataTable.Rows[j]["SubPrjName"]),
                            BaselinedEffort = 0m,
                            ScheduleEffort = 0m,
                            ActualEffort = 0m,
                            OvertimeEffort = 0m,
                            StaffInfo = new ArrayList()
                        });
                    }
                }
                try
                {
                    foreach (object obj in dataTable.Rows)
                    {
                        DataRow dataRow2 = (DataRow)obj;
                        int num4 = list.Count - 1;
                        for (int l = 0; l <= num4; l++)
                        {
                            bool flag5 = Operators.ConditionalCompareObjectEqual(dataRow2["SubPrjName"], list[l].SubProjectName, false);
                            if (flag5)
                            {
                                object left = dataRow2["TaskClass"];
                                bool flag6 = Operators.ConditionalCompareObjectEqual(left, TaskClass.ManagementTask, false);
                                if (flag6)
                                {
                                    if (countManagement)
                                    {
                                        subProjectInfo value = default(subProjectInfo);
                                        value = list[l];
                                        ref decimal ptr = ref value.BaselinedEffort;
                                        value.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["BaselineWork"], 60000m)));
                                        ptr = ref value.ScheduleEffort;
                                        value.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["Work"], 60000m)));
                                        ptr = ref value.ActualEffort;
                                        value.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualWork"], 60000m)));
                                        ptr = ref value.OvertimeEffort;
                                        value.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualOvertimeWork"], 60000m)));
                                        this.AddDataToResourceInfoList(ref value.StaffInfo, dataRow2);
                                        list[l] = value;
                                    }
                                }
                                else
                                {
                                    flag6 = Operators.ConditionalCompareObjectEqual(left, TaskClass.DevelopmentTask, false);
                                    if (flag6)
                                    {
                                        if (countDevelopment)
                                        {
                                            subProjectInfo value2 = default(subProjectInfo);
                                            value2 = list[l];
                                            ref decimal ptr = ref value2.BaselinedEffort;
                                            value2.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["BaselineWork"], 60000m)));
                                            ptr = ref value2.ScheduleEffort;
                                            value2.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["Work"], 60000m)));
                                            ptr = ref value2.ActualEffort;
                                            value2.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualWork"], 60000m)));
                                            ptr = ref value2.OvertimeEffort;
                                            value2.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualOvertimeWork"], 60000m)));
                                            this.AddDataToResourceInfoList(ref value2.StaffInfo, dataRow2);
                                            list[l] = value2;
                                        }
                                    }
                                    else
                                    {
                                        flag6 = Operators.ConditionalCompareObjectEqual(left, TaskClass.FixBugTask, false);
                                        if (flag6)
                                        {
                                            if (countFixBug)
                                            {
                                                subProjectInfo value3 = default(subProjectInfo);
                                                value3 = list[l];
                                                ref decimal ptr = ref value3.BaselinedEffort;
                                                value3.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["BaselineWork"], 60000m)));
                                                ptr = ref value3.ScheduleEffort;
                                                value3.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["Work"], 60000m)));
                                                ptr = ref value3.ActualEffort;
                                                value3.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualWork"], 60000m)));
                                                ptr = ref value3.OvertimeEffort;
                                                value3.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualOvertimeWork"], 60000m)));
                                                this.AddDataToResourceInfoList(ref value3.StaffInfo, dataRow2);
                                                list[l] = value3;
                                            }
                                        }
                                        else
                                        {
                                            flag6 = Operators.ConditionalCompareObjectEqual(left, TaskClass.OtherTasks, false);
                                            if (flag6)
                                            {
                                                if (countOthers)
                                                {
                                                    subProjectInfo value4 = default(subProjectInfo);
                                                    value4 = list[l];
                                                    ref decimal ptr = ref value4.BaselinedEffort;
                                                    value4.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["BaselineWork"], 60000m)));
                                                    ptr = ref value4.ScheduleEffort;
                                                    value4.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["Work"], 60000m)));
                                                    ptr = ref value4.ActualEffort;
                                                    value4.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualWork"], 60000m)));
                                                    ptr = ref value4.OvertimeEffort;
                                                    value4.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(dataRow2["ActualOvertimeWork"], 60000m)));
                                                    this.AddDataToResourceInfoList(ref value4.StaffInfo, dataRow2);
                                                    list[l] = value4;
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
                finally
                {
                    //IEnumerator enumerator;
                    //if (enumerator is IDisposable)
                    //{
                    //    (enumerator as IDisposable).Dispose();
                    //}
                    if (this is IDisposable)
                    {
                        (this as IDisposable).Dispose();
                    }
                }
                return list;
            }
        }

        public void AddDataToResourceInfoList(ref ArrayList resourceList, DataRow aRow)
        {
            bool flag = false;
            checked
            {
                int num = resourceList.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    object obj = resourceList[i];
                    subProjectStaffInfo subProjectStaffInfo = (obj != null) ? ((subProjectStaffInfo)obj) : default(subProjectStaffInfo);
                    bool flag2 = Operators.ConditionalCompareObjectEqual(subProjectStaffInfo.ResourceAccount, aRow["Account"], false);
                    if (flag2)
                    {
                        flag = true;
                        break;
                    }
                }
                bool flag3 = !flag;
                if (flag3)
                {
                    subProjectStaffInfo subProjectStaffInfo2 = default(subProjectStaffInfo);
                    subProjectStaffInfo2.PhaseInfo = new ArrayList();
                    subProjectStaffInfo2.ResourceAccount = Conversions.ToString(aRow["Account"]);
                    resourceList.Add(subProjectStaffInfo2);
                }
                int num2 = resourceList.Count - 1;
                for (int j = 0; j <= num2; j++)
                {
                    object obj2 = resourceList[j];
                    subProjectStaffInfo subProjectStaffInfo = (obj2 != null) ? ((subProjectStaffInfo)obj2) : default(subProjectStaffInfo);
                    bool flag4 = Operators.ConditionalCompareObjectEqual(subProjectStaffInfo.ResourceAccount, aRow["Account"], false);
                    if (flag4)
                    {
                        ref decimal ptr = ref subProjectStaffInfo.BaselinedEffort;
                        subProjectStaffInfo.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["BaselineWork"], 60000m)));
                        ptr = ref subProjectStaffInfo.ScheduleEffort;
                        subProjectStaffInfo.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["Work"], 60000m)));
                        ptr = ref subProjectStaffInfo.ActualEffort;
                        subProjectStaffInfo.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["ActualWork"], 60000m)));
                        ptr = ref subProjectStaffInfo.OvertimeEffort;
                        subProjectStaffInfo.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["ActualOvertimeWork"], 60000m)));
                        bool flag5 = false;
                        int num3 = subProjectStaffInfo.PhaseInfo.Count - 1;
                        for (int k = 0; k <= num3; k++)
                        {
                            object obj3 = subProjectStaffInfo.PhaseInfo[k];
                            bool flag6 = Operators.ConditionalCompareObjectEqual(((obj3 != null) ? ((subProjectPhaseInfo)obj3) : default(subProjectPhaseInfo)).Phase, aRow["Phase"], false);
                            if (flag6)
                            {
                                flag5 = true;
                                break;
                            }
                        }
                        bool flag7 = !flag5;
                        if (flag7)
                        {
                            subProjectPhaseInfo subProjectPhaseInfo = default(subProjectPhaseInfo);
                            subProjectPhaseInfo.Phase = (TaskPhase)Conversions.ToInteger(aRow["Phase"]);
                            subProjectStaffInfo.PhaseInfo.Add(subProjectPhaseInfo);
                        }
                        int num4 = subProjectStaffInfo.PhaseInfo.Count - 1;
                        for (int l = 0; l <= num4; l++)
                        {
                            object obj4 = subProjectStaffInfo.PhaseInfo[l];
                            subProjectPhaseInfo subProjectPhaseInfo2 = (obj4 != null) ? ((subProjectPhaseInfo)obj4) : default(subProjectPhaseInfo);
                            bool flag8 = Operators.ConditionalCompareObjectEqual(subProjectPhaseInfo2.Phase, aRow["Phase"], false);
                            if (flag8)
                            {
                                ptr = subProjectPhaseInfo2.ActualEffort;
                                subProjectPhaseInfo2.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["ActualWork"], 60000m)));
                                ptr = subProjectPhaseInfo2.BaselinedEffort;
                                subProjectPhaseInfo2.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["BaselineWork"], 60000m)));
                                ptr = subProjectPhaseInfo2.OvertimeEffort;
                                subProjectPhaseInfo2.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["ActualOvertimeWork"], 60000m)));
                                ptr = subProjectPhaseInfo2.ScheduleEffort;
                                subProjectPhaseInfo2.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["Work"], 60000m)));
                                subProjectStaffInfo.PhaseInfo[l] = subProjectPhaseInfo2;
                                break;
                            }
                        }
                        resourceList[j] = subProjectStaffInfo;
                        break;
                    }
                }
            }
        }

        // Token: 0x06002905 RID: 10501 RVA: 0x0015B930 File Offset: 0x00159B30
        public IEnumerable SummaryEffort_ItemClick(cls_CM_ProjectSchedule2007 _selectedSchedule,
                                             DateTime StartDate,
                                             DateTime ToDate)
        {
            SettingListColumn();
            this.SummaryDataSource.Tables[0].Rows.Clear();

            // list task trong ky han
            var taskSummaryTimephasedData = GetTaskSummaryTimephasedDataNew(_selectedSchedule,
                                                                         StartDate,
                                                                         ToDate,
                                                                         DataStoreEnum.PublishedStore);

            var rs = taskSummaryTimephasedData.Select(x =>
            new
            {
                Id = x.Task.TASK_UID.ToString(),
                ParentId = (x.Task.TASK_UID == x.Task.TASK_PARENT_UID) ? "0" : x.Task.TASK_PARENT_UID.ToString(),
                Name = x.Task.TASK_NAME,
                TaskClass = x.TaskClass.LT_VALUE_TEXT,
                TaskClassName = x.TaskClass.LT_VALUE_DESC,
                DD = 16m,
                PG = 24m,
                isSubPrj = !(x.Task.TASK_UID == x.Task.TASK_PARENT_UID)
            });

            //rs.Add(new ActualData()
            //{
            //    Id = x.ParentId,
            //    ParentId = "0",
            //    Name = string.Concat("★★★　", _selectedSchedule.Name),
            //    DD = arr.Sum(e => e.DD),
            //    PG = arr.Sum(e => e.PG)
            //});
            return rs;
        }

        public List<cls_CM_ProjectSchedule2007> LoadProjectScheduleList(cls_CM_Project project)
        {
            bool flag = project.ScheduleID == cls_CM_ProjectSchedule2007.SCHEDULE_NOT_SET;
            checked
            {
                if (!flag)
                {
                    bool flag2 = Operators.CompareString(project.ScheduleIDList,
                                                         cls_DB_ProjectSchedule.ChangeGUIDToID(cls_CM_ProjectSchedule2007.SCHEDULE_NOT_SET),
                                                         false) == 0;
                    if (!flag2)
                    {
                        List<string> list = cls_CM_ProjectSchedule2007.GetScheduleList(project.ScheduleIDList);
                        int num = list.Count - 1;
                        for (int i = 0; i <= num; i++)
                        {
                            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
                            List<cls_CM_ProjectSchedule2007> projectScheduleList = cls_CM_ProjectSchedule.GetProjectScheduleList(new Guid(list[i]), "", null, false, DataStoreEnum.PublishedStore);
                            bool flag3 = projectScheduleList == null || projectScheduleList.Count == 0;
                            if (!flag3)
                            {
                                return projectScheduleList;
                            }
                        }
                    }
                }
            }
            return null;
        }

        public List<Task2007Info> GetTaskSummaryTimephasedData(cls_CM_ProjectSchedule2007 schedule, DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore)
        {
            List<Task2007Info> list = new List<Task2007Info>();
            cls_CM_Function.OverrideCertificateValidation();

            // truncate time
            StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0);
            EndDate = new DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 23, 59, 59);

            // get raw data
            var projectDataSet = ProJectRepo.project.ReadProjectEntities(schedule.ID, 74, whereToGet);
            var customFieldDS = ProJectRepo.customFields.ReadCustomFields("", false);
            var lookupTableDataSet = ProJectRepo.lookupTable.ReadLookupTables("", false, 0);
            var resourceDS = ProJectRepo.resource.ReadResources("", false);

            // get by out param:   fixbugWBS(FIXCUSDEF) devWBS(SD) manWBS(PM) | 1 = YES , -1 = NO
            cls_CM_ProjectSchedule2007.GetWBSTaskClass(projectDataSet,
                                                       out string fixbugWBS,
                                                       out string devWBS,
                                                       out string manWBS);


            // get by out param :   list of subprj (NAME, WBS)
            cls_CM_ProjectSchedule2007.GetSubPrjListWBS(projectDataSet,
                                                        out List<string> subPrjWBS,
                                                        out List<string> subPrjName,
                                                        lookupTableDataSet);

            var cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule2007();
            try
            {
                foreach (ProjectDataSet.AssignmentRow assignmentRow in projectDataSet.Assignment)
                {
                    Task2007Info task2007Info = default(Task2007Info);
                    ProjectDataSet.TaskRow taskRow = projectDataSet.Task.FindByTASK_UIDPROJ_UID(assignmentRow.TASK_UID, assignmentRow.PROJ_UID);
                    task2007Info.ID = assignmentRow.TASK_UID;
                    task2007Info.Name = taskRow.TASK_NAME;
                    task2007Info.ModuleName = Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b40031f"), taskRow));
                    task2007Info.ProjectID = assignmentRow.PROJ_UID;
                    if (taskRow.IsTASK_WBSNull())
                    {
                        task2007Info.WBS = "";
                    }
                    else
                    {
                        task2007Info.WBS = taskRow.TASK_WBS;
                    }
                    task2007Info.TaskPart = cls_CM_ProjectSchedule2007.GetTaskPart(task2007Info.WBS, fixbugWBS, devWBS, manWBS);
                    task2007Info.SubPrjName = cls_CM_ProjectSchedule2007.GetSubPrjOfTask(task2007Info.WBS, subPrjWBS, subPrjName);
                    cls_CM_ProjectSchedule2007.GetResourceInfo(assignmentRow.RES_UID, ref task2007Info.ResourceName, ref task2007Info.ResourceNTAccount, resourceDS);
                    task2007Info.BaselinedEffort = cls_DB_ProjectSchedule.GetSumBaselineWork(schedule, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
                    task2007Info.OvertimeEffort = cls_DB_ProjectSchedule.GetSumOvertimeWork(schedule, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
                    task2007Info.ActualEffort = cls_DB_ProjectSchedule.GetSumActualWork(schedule, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
                    string text = Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400322"), taskRow));
                    bool flag2 = Conversions.ToBoolean(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400293"), taskRow));
                    //bool flag3 = !(-(flag2 > false));
                    bool flag3 = !flag2;
                    if (flag3)
                    {
                        task2007Info.Phase = TaskPhase.Others;
                    }
                    else
                    {
                        //bool flag4 = -(flag2 > false);
                        bool flag4 = flag2;
                        if (flag4)
                        {
                            task2007Info.Phase = TaskPhase.Training;
                        }
                    }
                    bool flag5 = Operators.CompareString(text, "", false) == 0;
                    checked
                    {
                        if (flag5)
                        {
                            task2007Info.Phase = TaskPhase.Others;
                        }
                        else
                        {
                            task2007Info.Phase = TaskPhase.Others;
                            int num = cls_CM_Function.TaskPhaseShortName.Length - 1;
                            for (int i = 0; i <= num; i++)
                            {
                                bool flag6 = Operators.CompareString(cls_CM_Function.TaskPhaseShortName[i], text, false) == 0;
                                if (flag6)
                                {
                                    task2007Info.Phase = (TaskPhase)i;
                                    break;
                                }
                            }
                        }
                        decimal num2 = Conversions.ToDecimal(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002ca"), taskRow));
                        bool flag7 = decimal.Compare(num2, 0m) == 0;
                        if (flag7)
                        {
                            task2007Info.Difficulty = 1m;
                        }
                        else
                        {
                            task2007Info.Difficulty = num2;
                        }
                        bool flag8 = task2007Info.Phase == TaskPhase.DeductedEffort;
                        if (flag8)
                        {
                            task2007Info.BaselinedEffort = decimal.Negate(task2007Info.BaselinedEffort);
                        }
                        list.Add(task2007Info);
                    }
                }
            }
            finally
            {
                // dispose
            }
            return list;
            ;
        }
        
    } // classs
} // namespace
