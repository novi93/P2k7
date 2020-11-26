
using Microsoft.VisualBasic.CompilerServices;
using P2k7.Core.Behavior.DB_SQLServer;
using P2k7.CustomfieldsWebSvc;
using P2k7.Data;
using P2k7.Entities.Enum;
using P2k7.Entities.Structs;
using P2k7.LookuptableWebSvc;
using P2k7.ProjectWebSvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace P2k7.Core.Behavior
{
    public class FjsSumaryEffortBehabior
    {

        public FjsSumaryEffortBehabior(ProjectRepository repo)
        {
            SummaryDataSource = new DataSet();
            Repo = repo;
        }
        public DataSet SummaryDataSource { get; private set; }
        public bool SumManWrkItem { get; private set; } = true;
        public bool SumDevWrkItem { get; private set; } = true;
        public bool SumFixWrkItem { get; private set; } = true;
        public bool SumOtherWrkItem { get; private set; } = true;
        public ProjectRepository Repo { get; }

        private void SettingListColumn()
        {
            this.SummaryDataSource = new DataSet();
            DataTable dataTable = SummaryDataSource.Tables.Add("SubProject");
            DataTable dataTable2 = SummaryDataSource.Tables.Add("Member");
            DataTable dataTable3 = SummaryDataSource.Tables.Add("Phase");
            //this.SubProjectGridView.ViewCaption = "Tổng kết từ " + Conversions.ToDate(this.StartDateItem.EditValue).ToString("yyyy/MM/dd") + " đến " + Conversions.ToDate(this.EndDateItem.EditValue).ToString("yyyy/MM/dd");

            dataTable.Columns.Add("Sub project", typeof(string));
            dataTable.Columns.Add("Baselined Effort", typeof(decimal));
            dataTable.Columns.Add("Scheduled Effort", typeof(decimal));
            dataTable.Columns.Add("Actual Effort", typeof(decimal));
            dataTable.Columns.Add("Overtime Effort", typeof(decimal));
            dataTable2.Columns.Add("Sub project", typeof(string));
            dataTable2.Columns.Add("Account", typeof(string));
            dataTable2.Columns.Add("Baselined", typeof(decimal));
            dataTable2.Columns.Add("Actual", typeof(decimal));
            dataTable2.Columns.Add("Overtime", typeof(decimal));
            dataTable3.Columns.Add("Account", typeof(string));
            dataTable3.Columns.Add("Phase", typeof(string));
            dataTable3.Columns.Add("Baselined", typeof(decimal));
            dataTable3.Columns.Add("Actual", typeof(decimal));
            dataTable3.Columns.Add("Overtime", typeof(decimal));
            dataTable3.Columns.Add("Sub project", typeof(string));
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("ParrentId", typeof(string));
            SummaryDataSource.Relations.Add("DetailMember", dataTable.Columns["Sub project"], dataTable2.Columns["Sub project"]);
            SummaryDataSource.Relations.Add("DetailPhases", new DataColumn[]
            {
                dataTable2.Columns["Sub project"],
                dataTable2.Columns["Account"]
            }, new DataColumn[]
            {
                dataTable3.Columns["Sub project"],
                dataTable3.Columns["Account"]
            });
            //this.ResultList.DataSource = dataTable;
            //this.ResultList.ForceInitialize();
            //this.SubProjectGridView.Columns["Sub project"].Width = 200;
            //this.SubProjectGridView.Columns["Sub project"].Fixed = FixedStyle.Left;
            //this.SubProjectGridView.Columns["Sub project"].Summary.Add(SummaryItemType.Count, this.SubProjectGridView.Columns["Sub project"].FieldName);
            //this.SubProjectGridView.Columns["Sub project"].ColumnEdit = cls_CM_Function.CreateMultiLineCellGridColumn();
            //this.SubProjectGridView.Columns["Baselined Effort"].Width = 150;
            //this.SubProjectGridView.Columns["Baselined Effort"].DisplayFormat.FormatType = FormatType.Numeric;
            //this.SubProjectGridView.Columns["Baselined Effort"].DisplayFormat.FormatString = "#,##0.00";
            //this.SubProjectGridView.Columns["Baselined Effort"].Summary.Add(SummaryItemType.Sum, this.SubProjectGridView.Columns["Baselined Effort"].FieldName);
            //this.SubProjectGridView.Columns["Scheduled Effort"].Width = 150;
            //this.SubProjectGridView.Columns["Scheduled Effort"].DisplayFormat.FormatType = FormatType.Numeric;
            //this.SubProjectGridView.Columns["Scheduled Effort"].DisplayFormat.FormatString = "#,##0.00";
            //this.SubProjectGridView.Columns["Scheduled Effort"].Summary.Add(SummaryItemType.Sum, this.SubProjectGridView.Columns["Scheduled Effort"].FieldName);
            //this.SubProjectGridView.Columns["Actual Effort"].Width = 150;
            //this.SubProjectGridView.Columns["Actual Effort"].DisplayFormat.FormatType = FormatType.Numeric;
            //this.SubProjectGridView.Columns["Actual Effort"].DisplayFormat.FormatString = "#,##0.00";
            //this.SubProjectGridView.Columns["Actual Effort"].Summary.Add(SummaryItemType.Sum, this.SubProjectGridView.Columns["Actual Effort"].FieldName);
            //this.SubProjectGridView.Columns["Overtime Effort"].Width = 150;
            //this.SubProjectGridView.Columns["Overtime Effort"].DisplayFormat.FormatType = FormatType.Numeric;
            //this.SubProjectGridView.Columns["Overtime Effort"].DisplayFormat.FormatString = "#,##0.00";
            //this.SubProjectGridView.Columns["Overtime Effort"].Summary.Add(SummaryItemType.Sum, this.SubProjectGridView.Columns["Overtime Effort"].FieldName);
            //this.SubProjectGridView.OptionsCustomization.AllowRowSizing = true;
            //this.SubProjectGridView.OptionsView.RowAutoHeight = true;
            //this.SubProjectGridView.OptionsView.ShowFooter = true;
            //this.SubProjectGridView.OptionsView.ShowGroupPanel = false;
            //this.SubProjectGridView.OptionsBehavior.ReadOnly = true;
            //this.SubProjectGridView.OptionsDetail.ShowDetailTabs = false;
            //this.SubProjectGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            //this.MemberGridView.OptionsView.ShowGroupPanel = false;
            //this.MemberGridView.OptionsDetail.ShowDetailTabs = false;
            //this.MemberGridView.OptionsBehavior.ReadOnly = true;
            //this.PhaseGridView.OptionsView.ShowGroupPanel = false;
            //this.PhaseGridView.OptionsDetail.ShowDetailTabs = false;
            //this.PhaseGridView.OptionsBehavior.ReadOnly = true;
            //this.MemberGridView.PopulateColumns(dataTable2);
            //this.PhaseGridView.PopulateColumns(dataTable3);
            //this.MemberGridView.Columns["Sub project"].Visible = false;
            //this.PhaseGridView.Columns["Account"].Visible = false;
            //this.PhaseGridView.Columns["Sub project"].Visible = false;
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
                                //ptr = ref subProjectPhaseInfo2.ActualEffort;
                                //subProjectPhaseInfo2.ActualEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["ActualWork"], 60000m)));
                                //ptr = ref subProjectPhaseInfo2.BaselinedEffort;
                                //subProjectPhaseInfo2.BaselinedEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["BaselineWork"], 60000m)));
                                //ptr = ref subProjectPhaseInfo2.OvertimeEffort;
                                //subProjectPhaseInfo2.OvertimeEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["ActualOvertimeWork"], 60000m)));
                                //ptr = ref subProjectPhaseInfo2.ScheduleEffort;
                                //subProjectPhaseInfo2.ScheduleEffort = Conversions.ToDecimal(Operators.AddObject(ptr, Operators.DivideObject(aRow["Work"], 60000m)));
                                //subProjectStaffInfo.PhaseInfo[l] = subProjectPhaseInfo2;
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
        public DataSet SummaryEffort_ItemClick(cls_CM_ProjectSchedule2007 _selectedSchedule,
                                             DateTime StartDate,
                                             DateTime ToDate)
        {
            
            SettingListColumn();
            this.SummaryDataSource.Tables[2].Rows.Clear();
            this.SummaryDataSource.Tables[1].Rows.Clear();
            this.SummaryDataSource.Tables[0].Rows.Clear();
            var taskSummaryTimephasedData = GetTaskSummaryTimephasedData(_selectedSchedule,
                                                                                                    StartDate,
                                                                                                    ToDate,
                                                                                                    DataStoreEnum.PublishedStore);
            var list = this.SummaryBySubProject(taskSummaryTimephasedData,
                                                this.SumManWrkItem,
                                                this.SumDevWrkItem,
                                                this.SumFixWrkItem,
                                                this.SumOtherWrkItem);
            checked
            {
                int num = list.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    DataRow dataRow = this.SummaryDataSource.Tables[0].Rows.Add(new object[0]);
                    subProjectInfo subProjectInfo = list[i];
                    dataRow["Sub project"] = subProjectInfo.SubProjectID + "\r\n" + subProjectInfo.SubProjectName;
                    dataRow["Baselined Effort"] = Math.Round(subProjectInfo.BaselinedEffort, 2);
                    dataRow["Scheduled Effort"] = Math.Round(subProjectInfo.ScheduleEffort, 2);
                    dataRow["Actual Effort"] = Math.Round(subProjectInfo.ActualEffort, 2);
                    dataRow["Overtime Effort"] = Math.Round(subProjectInfo.OvertimeEffort, 2);
                    dataRow["Id"] = subProjectInfo.SubProjectID;
                    dataRow["ParrentId"] = _selectedSchedule.ID;
                    bool flag = subProjectInfo.StaffInfo.Count > 0;
                    if (flag)
                    {
                        int num2 = subProjectInfo.StaffInfo.Count - 1;
                        for (int j = 0; j <= num2; j++)
                        {
                            DataRow dataRow2 = this.SummaryDataSource.Tables[1].Rows.Add(new object[0]);
                            object obj = subProjectInfo.StaffInfo[j];
                            subProjectStaffInfo subProjectStaffInfo = (obj != null) ? ((subProjectStaffInfo)obj) : default(subProjectStaffInfo);
                            dataRow2["Actual"] = Math.Round(subProjectStaffInfo.ActualEffort, 2);
                            dataRow2["Baselined"] = Math.Round(subProjectStaffInfo.BaselinedEffort, 2);
                            dataRow2["Overtime"] = Math.Round(subProjectStaffInfo.OvertimeEffort, 2);
                            dataRow2["Account"] = subProjectStaffInfo.ResourceAccount;
                            dataRow2["Sub project"] = RuntimeHelpers.GetObjectValue(dataRow[0]);
                            int num3 = subProjectStaffInfo.PhaseInfo.Count - 1;
                            for (int k = 0; k <= num3; k++)
                            {
                                object obj2 = subProjectStaffInfo.PhaseInfo[k];
                                subProjectPhaseInfo subProjectPhaseInfo = (obj2 != null) ? ((subProjectPhaseInfo)obj2) : default(subProjectPhaseInfo);
                                DataRow dataRow3 = this.SummaryDataSource.Tables[2].Rows.Add(new object[]
                                {
                                    subProjectStaffInfo.ResourceAccount,
                                    Enum.GetName(typeof(TaskPhase), subProjectPhaseInfo.Phase),
                                    Math.Round(subProjectPhaseInfo.BaselinedEffort, 2),
                                    Math.Round(subProjectPhaseInfo.ActualEffort, 2),
                                    Math.Round(subProjectPhaseInfo.OvertimeEffort, 2),
                                    dataRow[0]
                                });
                            }
                        }
                    }
                }
                //this.SubProjectGridView.ViewCaption = "Tổng kết từ " + Conversions.ToDate(this.StartDateItem.EditValue).ToString("yyyy/MM/dd") + " đến " + Conversions.ToDate(this.EndDateItem.EditValue).ToString("yyyy/MM/dd");
                GC.Collect();
            }
            return SummaryDataSource;
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
                        List<string> list = new List<string>();
                        list = cls_CM_ProjectSchedule2007.GetScheduleList(project.ScheduleIDList);
                        int num = list.Count - 1;
                        for (int i = 0; i <= num; i++)
                        {
                            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
                            List<cls_CM_ProjectSchedule2007> projectScheduleList = cls_CM_ProjectSchedule.GetProjectScheduleList(new Guid(list[i]), "", null, false, DataStoreEnum.PublishedStore);
                            bool flag3 = projectScheduleList == null || projectScheduleList.Count == 0;
                            if (!flag3)
                            {
                                return projectScheduleList;
                                //cls_CM_ProjectSchedule = projectScheduleList[0];
                                //cls_CM_ComboItem item = new cls_CM_ComboItem(cls_CM_ProjectSchedule, cls_CM_ProjectSchedule.Name);
                                //bool flag4 = false;
                                //try
                                //{
                                //    foreach (object obj in ScheduleListItemCombo.Items)
                                //    {
                                //        cls_CM_ComboItem cls_CM_ComboItem = (cls_CM_ComboItem)obj;
                                //        bool flag5 = Operators.CompareString(cls_CM_ComboItem.Text, cls_CM_ProjectSchedule.Name, false) == 0;
                                //        if (flag5)
                                //        {
                                //            flag4 = true;
                                //            break;
                                //        }
                                //    }
                                //}
                                //finally
                                //{
                                //    //IEnumerator enumerator;
                                //    //if (enumerator is IDisposable)
                                //    //{
                                //    //    (enumerator as IDisposable).Dispose();
                                //    //}
                                //    if (this is IDisposable)
                                //    {
                                //        (this as IDisposable).Dispose();
                                //    }
                                //}
                                //bool flag6 = !flag4;
                                //if (flag6)
                                //{
                                //    ScheduleListItemCombo.Items.Add(item);
                                //}
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

            // todo dummy for tesst
            //var scheduleId = new Guid("59f00468-145a-4d16-afa1-42e415237bf3");

            // get raw data
            var projectDataSet = Repo.project.ReadProjectEntities(schedule.ID, 74, whereToGet);
            var customFieldDS = Repo.customFields.ReadCustomFields("", false);
            var lookupTableDataSet= Repo.lookupTable.ReadLookupTables("", false, 0);
            var resourceWebSvc = Repo.resource;
            var resourceDS = resourceWebSvc.ReadResources("", false);

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
