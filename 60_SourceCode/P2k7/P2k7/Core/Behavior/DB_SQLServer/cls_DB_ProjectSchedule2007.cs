using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using P2k7.Entities.Enum;
using P2k7.Entities.Structs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;

namespace P2k7.Core.Behavior.DB_SQLServer
{
    public class cls_DB_ProjectSchedule2007
    {
        // Token: 0x06000DFF RID: 3583 RVA: 0x00057DC4 File Offset: 0x00055FC4
        public decimal GetSumBaselineWork(cls_CM_ProjectSchedule2007 Project, DateTime StartDate, DateTime EndDate, Guid AssignmentUID, Guid TaskUID)
        {
             return 9.3m;
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.AppendLine(" SELECT      SUM([AssignmentBaselineWork]) AS [AssignmentBaselineWork]     ");
            stringBuilder.AppendLine("   FROM [MSP_EpmAssignmentBaselineByDay]     ");
            stringBuilder.AppendLine("   WHERE ");
            stringBuilder.AppendLine("     (1 = 1) ");
            stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),[TimeByDay],112) >= @StartDate) ");
            stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),[TimeByDay],112) <= @EndDate) ");
            stringBuilder.AppendLine("     AND (BaselineNumber = 0) ");
            mod_WMS_Declare.rwl.EnterWriteLock();
            cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer2007.Parameters;
            parameters.Clear();
            if (Project != null)
            {
                stringBuilder.AppendLine("     AND (ProjectUID = @ProjectUID) ");
                parameters.Add(new SqlParameter("@ProjectUID", SqlDbType.NVarChar)).Value = Project.ID.ToString();
            }
            if (AssignmentUID != Guid.Empty)
            {
                stringBuilder.AppendLine("     AND (AssignmentUID = @AssignmentUID) ");
                parameters.Add(new SqlParameter("@AssignmentUID", SqlDbType.NVarChar)).Value = AssignmentUID.ToString();
            }
            if (TaskUID != Guid.Empty)
            {
                stringBuilder.AppendLine("     AND (TaskUID = @TaskUID) ");
                parameters.Add(new SqlParameter("@TaskUID", SqlDbType.NVarChar)).Value = TaskUID.ToString();
            }
            parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = StartDate.ToString("yyyyMMdd");
            parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = EndDate.ToString("yyyyMMdd");

            cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer2007.DBCreateDynaset(stringBuilder.ToString(), false, false);
            mod_WMS_Declare.rwl.ExitWriteLock();

            if (cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0)
            {
                using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
                {
                    IEnumerator enumerator = dataTable.Rows.GetEnumerator();
                    try
                    {
                        if (enumerator.MoveNext())
                        {
                            DataRow dataRow = (DataRow)enumerator.Current;
                            return Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentBaselineWork"])) ? 0 : Operators.MultiplyObject(dataRow["AssignmentBaselineWork"], 60000m));
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }
            }
            return 0m;
        }

        // Token: 0x06000E00 RID: 3584 RVA: 0x00058094 File Offset: 0x00056294
        public decimal GetSumActualWork(cls_CM_ProjectSchedule2007 Project, DateTime StartDate, DateTime EndDate, Guid AssignmentUID, Guid TaskUID)
        {
            return 8.2m;
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.AppendLine(" SELECT      SUM([AssignmentActualWork]) AS [AssignmentActualWork]     ");
            stringBuilder.AppendLine("   FROM [MSP_EpmAssignmentByDay]     ");
            stringBuilder.AppendLine("   WHERE ");
            stringBuilder.AppendLine("     (1 = 1) ");
            stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),[TimeByDay],112) >= @StartDate) ");
            stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),[TimeByDay],112) <= @EndDate) ");
            mod_WMS_Declare.rwl.EnterWriteLock();
            cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer2007.Parameters;
            parameters.Clear();
            bool flag = Project != null;
            if (flag)
            {
                stringBuilder.AppendLine("     AND (ProjectUID = @ProjectUID) ");
                parameters.Add(new SqlParameter("@ProjectUID", SqlDbType.NVarChar)).Value = Project.ID.ToString();
            }
            bool flag2 = AssignmentUID != Guid.Empty;
            if (flag2)
            {
                stringBuilder.AppendLine("     AND (AssignmentUID = @AssignmentUID) ");
                parameters.Add(new SqlParameter("@AssignmentUID", SqlDbType.NVarChar)).Value = AssignmentUID.ToString();
            }
            bool flag3 = TaskUID != Guid.Empty;
            if (flag3)
            {
                stringBuilder.AppendLine("     AND (TaskUID = @TaskUID) ");
                parameters.Add(new SqlParameter("@TaskUID", SqlDbType.NVarChar)).Value = TaskUID.ToString();
            }
            parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = StartDate.ToString("yyyyMMdd");
            parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = EndDate.ToString("yyyyMMdd");
            cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer2007.DBCreateDynaset(stringBuilder.ToString(), false, false);
            mod_WMS_Declare.rwl.ExitWriteLock();
            bool flag4 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
            if (flag4)
            {
                using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
                {
                    IEnumerator enumerator = dataTable.Rows.GetEnumerator();
                    try
                    {
                        if (enumerator.MoveNext())
                        {
                            DataRow dataRow = (DataRow)enumerator.Current;
                            return Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentActualWork"])) ? 0 : Operators.MultiplyObject(dataRow["AssignmentActualWork"], 60000m));
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }
            }
            return 0m;
        }

        // Token: 0x06000E01 RID: 3585 RVA: 0x00058358 File Offset: 0x00056558
        public decimal GetSumOvertimeWork(cls_CM_ProjectSchedule2007 Project, DateTime StartDate, DateTime EndDate, Guid AssignmentUID, Guid TaskUID)
        {
             return 1.4m;
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.AppendLine(" SELECT      SUM([AssignmentActualOvertimeWork]) AS [AssignmentActualOvertimeWork]     ");
            stringBuilder.AppendLine("   FROM [MSP_EpmAssignmentByDay]     ");
            stringBuilder.AppendLine("   WHERE ");
            stringBuilder.AppendLine("     (1 = 1) ");
            stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),[TimeByDay],112) >= @StartDate) ");
            stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),[TimeByDay],112) <= @EndDate) ");
            mod_WMS_Declare.rwl.EnterWriteLock();
            cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer2007.Parameters;
            parameters.Clear();
            bool flag = Project != null;
            if (flag)
            {
                stringBuilder.AppendLine("     AND (ProjectUID = @ProjectUID) ");
                parameters.Add(new SqlParameter("@ProjectUID", SqlDbType.NVarChar)).Value = Project.ID.ToString();
            }
            bool flag2 = AssignmentUID != Guid.Empty;
            if (flag2)
            {
                stringBuilder.AppendLine("     AND (AssignmentUID = @AssignmentUID) ");
                parameters.Add(new SqlParameter("@AssignmentUID", SqlDbType.NVarChar)).Value = AssignmentUID.ToString();
            }
            bool flag3 = TaskUID != Guid.Empty;
            if (flag3)
            {
                stringBuilder.AppendLine("     AND (TaskUID = @TaskUID) ");
                parameters.Add(new SqlParameter("@TaskUID", SqlDbType.NVarChar)).Value = TaskUID.ToString();
            }
            parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = StartDate.ToString("yyyyMMdd");
            parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = EndDate.ToString("yyyyMMdd");
            cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer2007.DBCreateDynaset(stringBuilder.ToString(), false, false);
            mod_WMS_Declare.rwl.ExitWriteLock();
            bool flag4 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
            if (flag4)
            {
                using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
                {
                    IEnumerator enumerator = dataTable.Rows.GetEnumerator();
                    try
                    {
                        if (enumerator.MoveNext())
                        {
                            DataRow dataRow = (DataRow)enumerator.Current;
                            return Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentActualOvertimeWork"])) ? 0 : Operators.MultiplyObject(dataRow["AssignmentActualOvertimeWork"], 60000m));
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }
            }
            return 0m;
        }

        //// Token: 0x06000E02 RID: 3586 RVA: 0x0005861C File Offset: 0x0005681C
        //public List<Task2007Info> GetTaskDetailTimephasedData(DateTime StartDate, DateTime EndDate, cls_CM_ProjectSchedule2007 Project = null, cls_CM_ResourceOnServer2007 Resource = null)
        //{
        //    List<Task2007Info> list = new List<Task2007Info>();
        //    cls_CM_Staff_Abridged cls_CM_Staff_Abridged = new cls_CM_Staff_Abridged();
        //    StringBuilder stringBuilder = new StringBuilder("");
        //    stringBuilder.AppendLine(" SELECT      ASSNDAY.[AssignmentBaseline0Work] AS [AssignmentBaselineWork]     ");
        //    stringBuilder.AppendLine(" ,      ASSNDAY.[AssignmentWork] AS [AssignmentWork]     ");
        //    stringBuilder.AppendLine(" ,      ASSNDAY.[AssignmentActualWork] AS [AssignmentActualWork]     ");
        //    stringBuilder.AppendLine(" ,      ASSNDAY.[AssignmentActualOvertimeWork] AS [AssignmentActualOvertimeWork]     ");
        //    stringBuilder.AppendLine(" ,      ASSN.[TaskUID] AS [TaskUID]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[Module ID] AS [Module ID]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[TaskName] AS [TaskName]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[TaskWBS] AS [TaskWBS]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[ProjectUID] AS [ProjectUID]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[Is Non-Project Effort] AS [Is Non-Project Effort]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[Do kho cong viec] AS [TaskDifficulty]     ");
        //    stringBuilder.AppendLine(" ,      TSK.[TaskClass] AS [TaskClass]     ");
        //    stringBuilder.AppendLine(" ,      RES.[ResourceNTAccount] AS [ResourceNTAccount]     ");
        //    stringBuilder.AppendLine(" ,      CONVERT(nvarchar(MAX),ASSNDAY.[TimeByDay],112) AS [AssignmentTimeStart]     ");
        //    stringBuilder.AppendLine(" ,      CONVERT(nvarchar(MAX),ASSNDAY.[TimeByDay],112) AS [AssignmentTimeFinish]     ");
        //    stringBuilder.AppendLine("   FROM PS2007_ProjectServer_Farm_Reporting.dbo.[MSP_EpmAssignmentByDay_UserView]   ASSNDAY  ");
        //    stringBuilder.AppendLine("   , PS2007_ProjectServer_Farm_Reporting.dbo.[MSP_EpmAssignment_UserView]   ASSN  ");
        //    stringBuilder.AppendLine("   , PS2007_ProjectServer_Farm_Reporting.dbo.[MSP_EpmTask_UserView]   TSK  ");
        //    stringBuilder.AppendLine("   , PS2007_ProjectServer_Farm_Reporting.dbo.[MSP_EpmResource_UserView]   RES  ");
        //    stringBuilder.AppendLine("   WHERE ");
        //    stringBuilder.AppendLine("     (1 = 1) ");
        //    stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),ASSNDAY.[TimeByDay],112) >= @StartDate) ");
        //    stringBuilder.AppendLine("     AND (CONVERT(nvarchar(MAX),ASSNDAY.[TimeByDay],112) <= @EndDate) ");
        //    stringBuilder.AppendLine("     AND ASSN.AssignmentUID = ASSNDAY.AssignmentUID ");
        //    stringBuilder.AppendLine("     AND ASSN.ProjectUID = ASSNDAY.ProjectUID ");
        //    stringBuilder.AppendLine("     AND TSK.TaskUID = ASSN.TaskUID ");
        //    stringBuilder.AppendLine("     AND TSK.ProjectUID = ASSN.ProjectUID ");
        //    stringBuilder.AppendLine("     AND ASSN.ResourceUID = RES.ResourceUID ");
        //    stringBuilder.AppendLine("     AND ASSN.ProjectUID = @ProjectUID ");
        //    mod_WMS_Declare.rwl.EnterWriteLock();
        //    cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //    parameters.Clear();
        //    bool flag = Project != null;
        //    if (flag)
        //    {
        //        parameters.Add(new SqlParameter("@ProjectUID", SqlDbType.NVarChar)).Value = Project.ID.ToString();
        //    }
        //    bool flag2 = Resource != null;
        //    if (flag2)
        //    {
        //        stringBuilder.AppendLine("     AND ASSN.ResourceUID = @ResourceUID ");
        //        parameters.Add(new SqlParameter("@ResourceUID", SqlDbType.NVarChar)).Value = Resource.ID.ToString();
        //    }
        //    parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = StartDate.ToString("yyyyMMdd");
        //    parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = EndDate.ToString("yyyyMMdd");
        //    stringBuilder.AppendLine("     ORDER BY ");
        //    stringBuilder.AppendLine("         TaskUID ");
        //    cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //    mod_WMS_Declare.rwl.ExitWriteLock();
        //    bool flag3 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //    checked
        //    {
        //        if (flag3)
        //        {
        //            using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //            {
        //                try
        //                {
        //                    foreach (object obj in dataTable.Rows)
        //                    {
        //                        DataRow dataRow = (DataRow)obj;
        //                        Task2007Info task2007Info = default(Task2007Info);
        //                        object obj2 = dataRow["TaskUID"];
        //                        task2007Info.ID = ((obj2 != null) ? ((Guid)obj2) : default(Guid));
        //                        task2007Info.Name = Conversions.ToString(dataRow["TaskName"]);
        //                        task2007Info.ModuleName = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Module ID"])) ? "" : dataRow["Module ID"]);
        //                        object obj3 = dataRow["ProjectUID"];
        //                        task2007Info.ProjectID = ((obj3 != null) ? ((Guid)obj3) : default(Guid));
        //                        task2007Info.ResourceNTAccount = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ResourceNTAccount"])) ? 0 : dataRow["ResourceNTAccount"]);
        //                        string[] array = task2007Info.ResourceNTAccount.Split(new char[]
        //                        {
        //                            '\\'
        //                        });
        //                        bool flag4 = array != null && array.Length == 2;
        //                        if (flag4)
        //                        {
        //                            ArrayList arrayList = cls_CM_Staff_Abridged.fncG_CM_GetStaffList("", array[1], "", "", "", "", false, "", false);
        //                            bool flag5 = arrayList != null && arrayList.Count > 0;
        //                            if (flag5)
        //                            {
        //                                task2007Info.ResourceName = Conversions.ToString(NewLateBinding.LateGet(arrayList[0], null, "FullName", new object[0], null, null, null));
        //                            }
        //                            else
        //                            {
        //                                task2007Info.ResourceName = Conversions.ToString(dataRow["ResourceName"]);
        //                            }
        //                        }
        //                        else
        //                        {
        //                            task2007Info.ResourceName = Conversions.ToString(dataRow["ResourceName"]);
        //                        }
        //                        task2007Info.BaselinedEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentBaselineWork"])) ? 0 : dataRow["AssignmentBaselineWork"]);
        //                        task2007Info.ScheduleEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentWork"])) ? 0 : dataRow["AssignmentWork"]);
        //                        task2007Info.ActualEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentActualWork"])) ? 0 : dataRow["AssignmentActualWork"]);
        //                        task2007Info.OvertimeEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentActualOvertimeWork"])) ? 0 : dataRow["AssignmentActualOvertimeWork"]);
        //                        task2007Info.StartDate = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeStart"])) ? 0 : dataRow["AssignmentTimeStart"]);
        //                        task2007Info.FinishDate = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeFinish"])) ? 0 : dataRow["AssignmentTimeFinish"]);
        //                        bool flag6 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Is Non-Project Effort"])) || Operators.ConditionalCompareObjectEqual(dataRow["Is Non-Project Effort"], 0, false);
        //                        if (flag6)
        //                        {
        //                            task2007Info.Phase = TaskPhase.Others;
        //                        }
        //                        else
        //                        {
        //                            bool flag7 = Operators.ConditionalCompareObjectEqual(dataRow["Is Non-Project Effort"], 1, false);
        //                            if (flag7)
        //                            {
        //                                task2007Info.Phase = TaskPhase.Training;
        //                            }
        //                        }
        //                        bool flag8 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaskDifficulty"])) || Operators.ConditionalCompareObjectEqual(dataRow["TaskDifficulty"], 0, false);
        //                        if (flag8)
        //                        {
        //                            task2007Info.Difficulty = 1m;
        //                        }
        //                        else
        //                        {
        //                            task2007Info.Difficulty = Conversions.ToDecimal(dataRow["TaskDifficulty"]);
        //                        }
        //                        task2007Info.WBS = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaskWBS"])) ? "" : dataRow["TaskWBS"]);
        //                        task2007Info.TaskPart = cls_DB_ProjectSchedule2007.GetTaskPart(task2007Info);
        //                        bool flag9 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaskClass"])) || Operators.ConditionalCompareObjectEqual(dataRow["TaskClass"], "", false);
        //                        if (flag9)
        //                        {
        //                            task2007Info.Phase = TaskPhase.Others;
        //                        }
        //                        else
        //                        {
        //                            task2007Info.Phase = TaskPhase.Others;
        //                            int num = cls_CM_Function.TaskPhaseShortName.Length - 1;
        //                            for (int i = 0; i <= num; i++)
        //                            {
        //                                bool flag10 = Operators.ConditionalCompareObjectEqual(cls_CM_Function.TaskPhaseShortName[i], dataRow["TaskClass"], false);
        //                                if (flag10)
        //                                {
        //                                    task2007Info.Phase = (TaskPhase)i;
        //                                    break;
        //                                }
        //                            }
        //                        }
        //                        list.Add(task2007Info);
        //                    }
        //                }
        //                finally
        //                {
        //                    //IEnumerator enumerator;
        //                    //if (enumerator is IDisposable)
        //                    //{
        //                    //	(enumerator as IDisposable).Dispose();
        //                    //}
        //                }
        //            }
        //        }
        //        return list;
        //    }
        //}

        //// Token: 0x06000E03 RID: 3587 RVA: 0x00058E6C File Offset: 0x0005706C
        //public static string GetTaskWBS(Task2007Info task, string moduleID, string taskName)
        //{
        //    string result = "";
        //    cls_CM_Staff_Abridged cls_CM_Staff_Abridged = new cls_CM_Staff_Abridged();
        //    StringBuilder stringBuilder = new StringBuilder("");
        //    stringBuilder.AppendLine(" SELECT     ");
        //    stringBuilder.AppendLine("       TSK.[TaskWBS] AS [TaskWBS]     ");
        //    stringBuilder.AppendLine("   FROM   ");
        //    stringBuilder.AppendLine("    PS2007_ProjectServer_Farm_Reporting.dbo.[MSP_EpmTask_UserView]   TSK  ");
        //    stringBuilder.AppendLine("   WHERE ");
        //    stringBuilder.AppendLine("     (1 = 1) ");
        //    stringBuilder.AppendLine("     AND TSK.ProjectUID = @ProjectUID ");
        //    mod_WMS_Declare.rwl.EnterWriteLock();
        //    cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //    parameters.Clear();
        //    parameters.Add(new SqlParameter("@ProjectUID", SqlDbType.NVarChar)).Value = task.ProjectID.ToString();
        //    bool flag = Operators.CompareString(moduleID, "", false) != 0;
        //    if (flag)
        //    {
        //        stringBuilder.AppendLine("     AND TSK.[Module ID] = @ModuleID ");
        //        parameters.Add(new SqlParameter("@ModuleID", SqlDbType.NVarChar)).Value = moduleID;
        //    }
        //    bool flag2 = Operators.CompareString(taskName, "", false) != 0;
        //    if (flag2)
        //    {
        //        stringBuilder.AppendLine("     AND TSK.[TaskName] = @TaskName ");
        //        parameters.Add(new SqlParameter("@TaskName", SqlDbType.NVarChar)).Value = taskName;
        //    }
        //    cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //    mod_WMS_Declare.rwl.ExitWriteLock();
        //    bool flag3 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //    if (flag3)
        //    {
        //        using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //        {
        //            bool flag4 = dataTable.Rows.Count > 0;
        //            if (flag4)
        //            {
        //                result = Conversions.ToString(dataTable.Rows[0]["TaskWBS"]);
        //            }
        //        }
        //    }
        //    return result;
        //}

        //// Token: 0x06000E04 RID: 3588 RVA: 0x00059068 File Offset: 0x00057268
        //public static TaskClass GetTaskPart(Task2007Info task)
        //{
        //    string taskWBS = GetTaskWBS(task, "FIXCUSDEF", "Fix customer's defects");
        //    string taskWBS2 = GetTaskWBS(task, "PM", "Project Management");
        //    string taskWBS3 = GetTaskWBS(task, "SD", "Software Development");
        //    TaskClass result = TaskClass.OtherTasks;
        //    bool flag = task.WBS.StartsWith(taskWBS + ".");
        //    if (flag)
        //    {
        //        result = TaskClass.FixBugTask;
        //    }
        //    else
        //    {
        //        bool flag2 = task.WBS.StartsWith(taskWBS2 + ".");
        //        if (flag2)
        //        {
        //            result = TaskClass.ManagementTask;
        //        }
        //        else
        //        {
        //            bool flag3 = task.WBS.StartsWith(taskWBS3 + ".");
        //            if (flag3)
        //            {
        //                result = TaskClass.DevelopmentTask;
        //            }
        //        }
        //    }
        //    return result;
        //}
    } // cls
} // ns
