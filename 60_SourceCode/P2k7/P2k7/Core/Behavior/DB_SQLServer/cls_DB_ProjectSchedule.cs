using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2k7.Core.Behavior.DB_SQLServer
{
	public class cls_DB_ProjectSchedule
	{
        // Token: 0x06001023 RID: 4131 RVA: 0x0006DE50 File Offset: 0x0006C050
        //public ArrayList GetProjectScheduleList(int intID = -2147483648, string strName = "", cls_CM_ResourceOnServer2007 objManager = null, bool OngoingProjectsOnly = true)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT          ");
        //	stringBuilder.AppendLine("     P.PROJ_NAME        AS C1 ");
        //	stringBuilder.AppendLine("     , RES_NAME       AS C2 ");
        //	stringBuilder.AppendLine("     , WRES_NT_ACCOUNT    AS C3 ");
        //	stringBuilder.AppendLine("     , WPROJ_ID           AS C4 ");
        //	stringBuilder.AppendLine("\t , ProjectEnterpriseOutlineCode1ID           AS C5");
        //	stringBuilder.AppendLine("\t , PROJ_CHECKEDOUT           AS C6");
        //	stringBuilder.AppendLine("  FROM          ");
        //	stringBuilder.AppendLine("     (SELECT ");
        //	stringBuilder.AppendLine("WP.WPROJ_ID, WP.PROJ_NAME, WP.WRES_ID, EP.ProjectEnterpriseOutlineCode1ID, PJ.PROJ_ID, PJ.PROJ_NAME AS ENT_PROJ_NAME, PJ.PROJ_CHECKEDOUT");
        //	stringBuilder.AppendLine("FROM MSP_WEB_PROJECTS WP, MSP_VIEW_PROJ_PROJECTS_ENT EP, MSP_PROJECTS PJ");
        //	stringBuilder.AppendLine("WHERE ");
        //	stringBuilder.AppendLine("\t(1 = 1)");
        //	stringBuilder.AppendLine("\tAND WP.PROJ_ID = PJ.PROJ_ID");
        //	stringBuilder.AppendLine("\tAND EP.WPROJ_ID = WP.WPROJ_ID");
        //	if (OngoingProjectsOnly)
        //	{
        //		stringBuilder.AppendLine("          AND ProjectEnterpriseOutlineCode1ID <> @CancelledOutlineCode                                 ");
        //		stringBuilder.AppendLine("          AND ProjectEnterpriseOutlineCode1ID <> @CompletedOutlineCode                                 ");
        //	}
        //	stringBuilder.AppendLine(") P          ");
        //	stringBuilder.AppendLine("     , MSP_WEB_RESOURCES R          ");
        //	stringBuilder.AppendLine("  WHERE          ");
        //	stringBuilder.AppendLine("        1 = 1          ");
        //	stringBuilder.AppendLine("  AND   P.WRES_ID = R.WRES_ID          ");
        //	stringBuilder.AppendLine("  AND   P.WPROJ_ID <> 1           ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	bool flag = Operators.CompareString(strName, "", false) != 0;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("          AND P.PROJ_NAME = @PROJ_NAME                                 ");
        //		parameters.Add(new SqlParameter("@PROJ_NAME", SqlDbType.NVarChar)).Value = strName;
        //	}
        //	bool flag2 = objManager != null;
        //	if (flag2)
        //	{
        //		stringBuilder.AppendLine("          AND R.WRES_NT_ACCOUNT = @WRES_NT_ACCOUNT                                 ");
        //		parameters.Add(new SqlParameter("@WRES_NT_ACCOUNT", SqlDbType.NVarChar)).Value = objManager.Account;
        //	}
        //	bool flag3 = intID != int.MinValue;
        //	if (flag3)
        //	{
        //		stringBuilder.AppendLine("          AND P.WPROJ_ID = @WPROJ_ID                                 ");
        //		parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = intID;
        //	}
        //	if (OngoingProjectsOnly)
        //	{
        //		parameters.Add(new SqlParameter("@CancelledOutlineCode", SqlDbType.Int)).Value = ScheduleStatus.Cancelled;
        //		parameters.Add(new SqlParameter("@CompletedOutlineCode", SqlDbType.Int)).Value = ScheduleStatus.Completed;
        //	}
        //	stringBuilder.AppendLine("  ORDER BY          ");
        //	stringBuilder.AppendLine("     PROJ_NAME,          ");
        //	stringBuilder.AppendLine("     RES_NAME          ");
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	cls_CM_Function.OverrideCertificateValidation();
        //	ResourceDataSet resourceDS = new ResourceDataSet();
        //	resourceDS = new Resource
        //	{
        //		Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx",
        //		Credentials = cls_CM_Function.GetCredentials(false)
        //	}.ReadResources("", false);
        //	bool flag4 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag4)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					cls_CM_ProjectSchedule cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule();
        //					cls_CM_ProjectSchedule.Name = Conversions.ToString(dataRow["C1"]);
        //					bool flag5 = Operators.ConditionalCompareObjectNotEqual(dataRow["C3"], "", false);
        //					if (flag5)
        //					{
        //						List<cls_CM_ResourceOnServer2007> list = new List<cls_CM_ResourceOnServer2007>();
        //						list = cls_CM_ProjectSchedule.Manager.GetResourceInfo(resourceDS, Guid.Empty, Conversions.ToString(dataRow["C3"]));
        //						bool flag6 = list.Count != 0;
        //						if (flag6)
        //						{
        //							cls_CM_ProjectSchedule.Manager = list[0];
        //						}
        //					}
        //					else
        //					{
        //						cls_CM_ProjectSchedule.Manager = new cls_CM_ResourceOnServer2007();
        //					}
        //					cls_CM_ProjectSchedule.ID = Conversions.ToInteger(dataRow["C4"]);
        //					cls_CM_ProjectSchedule.Status = (ScheduleStatus)Conversions.ToInteger(dataRow["C5"]);
        //					cls_CM_ProjectSchedule.IsCheckout = Conversions.ToBoolean(dataRow["C6"]);
        //					arrayList.Add(cls_CM_ProjectSchedule);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        //// Token: 0x06001024 RID: 4132 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
        //public ArrayList GetNonApproveScheduleList()
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT [ScheduleName]   ");
        //	stringBuilder.AppendLine("    FROM [PRJ_Effort]   ");
        //	stringBuilder.AppendLine("    WHERE [IsConfirmed]= 'False'   ");
        //	stringBuilder.AppendLine("    GROUP BY [ScheduleName]   ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					arrayList.Add(RuntimeHelpers.GetObjectValue(dataRow["ScheduleName"]));
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        // Token: 0x06001025 RID: 4133 RVA: 0x0006E42C File Offset: 0x0006C62C
        public static string ChangeGUIDToID(Guid scheduleID)
        {
            bool flag = Guid.Empty == scheduleID;
            string result;
            if (flag)
            {
                result = "0";
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder("");
                stringBuilder.AppendLine("  SELECT [ID2003]   ");
                stringBuilder.AppendLine("    FROM [PRJ_MSP20032007Map]   ");
                stringBuilder.AppendLine("    WHERE [ID2007]= @ID2007   ");
                mod_WMS_Declare.rwl.EnterWriteLock();
                cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
                parameters.Clear();
                parameters.Add(new SqlParameter("@ID2007", SqlDbType.NVarChar)).Value = scheduleID.ToString();
                cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
                mod_WMS_Declare.rwl.ExitWriteLock();
                bool flag2 = cls_DB_Dynaset != null;
                if (flag2)
                {
                    using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
                    {
                        try
                        {
                            IEnumerator enumerator = dataTable.Rows.GetEnumerator();
                            if (enumerator.MoveNext())
                            {
                                DataRow dataRow = (DataRow)enumerator.Current;
                                return Conversions.ToString(dataRow["ID2003"]);
                            }
                        }
                        finally
                        {
                            //IEnumerator enumerator;
                            //if (enumerator is IDisposable)
                            //{
                            //    (enumerator as IDisposable).Dispose();
                            //}
                        }
                    }
                }
                result = scheduleID.ToString();
            }
            return result;
        }

        // Token: 0x06001026 RID: 4134 RVA: 0x0006E5A4 File Offset: 0x0006C7A4
        public static string ChangeIDToGUID(string scheduleID)
        {
            bool flag = Operators.CompareString("0", scheduleID, false) == 0;
            string result;
            if (flag)
            {
                result = Guid.Empty.ToString();
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder("");
                stringBuilder.AppendLine("  SELECT [ID2007]   ");
                stringBuilder.AppendLine("    FROM [PRJ_MSP20032007Map]   ");
                stringBuilder.AppendLine("    WHERE [ID2003]= @ID2003   ");
                mod_WMS_Declare.rwl.EnterWriteLock();
                cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
                parameters.Clear();
                parameters.Add(new SqlParameter("@ID2003", SqlDbType.Int)).Value = scheduleID;
                cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
                mod_WMS_Declare.rwl.ExitWriteLock();
                bool flag2 = cls_DB_Dynaset != null;
                if (flag2)
                {
                    using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
                    { 
                        var enumerator = dataTable.Rows.GetEnumerator();
                        try
                        {
                            if (enumerator.MoveNext())
                            {
                                DataRow dataRow = (DataRow)enumerator.Current;
                                return Conversions.ToString(dataRow["ID2007"]);
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
                result = Guid.Empty.ToString();
            }
            return result;
        }

        //// Token: 0x06001027 RID: 4135 RVA: 0x0006E728 File Offset: 0x0006C928
        //public List<ProjectStaffEffort> GetStaffEffortList(string projectName)
        //{
        //	List<ProjectStaffEffort> list = new List<ProjectStaffEffort>();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT [ID]  AS C1 ");
        //	stringBuilder.AppendLine("        ,[Project]   AS C2 ");
        //	stringBuilder.AppendLine("        ,[StartDate]   AS C3 ");
        //	stringBuilder.AppendLine("        ,[EndDate]   AS C4 ");
        //	stringBuilder.AppendLine("        ,[CustomerEffort]   AS C5 ");
        //	stringBuilder.AppendLine("        ,[AutoCal]   AS C6 ");
        //	stringBuilder.AppendLine("        ,[HowToConv]   AS C7 ");
        //	stringBuilder.AppendLine("        ,[RegUser]   AS C8 ");
        //	stringBuilder.AppendLine("        ,[RegDate]   AS C9 ");
        //	stringBuilder.AppendLine("        ,[ModUser]   AS C10 ");
        //	stringBuilder.AppendLine("        ,[ModDate]   AS C11 ");
        //	stringBuilder.AppendLine("        ,[IsConfirmed]   AS C12 ");
        //	stringBuilder.AppendLine("        ,[ConfirmedBy]   AS C13 ");
        //	stringBuilder.AppendLine("        ,[ConfirmDate]   AS C14 ");
        //	stringBuilder.AppendLine("        ,[LeaderRate]   AS C15 ");
        //	stringBuilder.AppendLine("        ,[IsPM]   AS C16 ");
        //	stringBuilder.AppendLine("        ,[ProjectEffortNotes]   AS C17 ");
        //	stringBuilder.AppendLine("        ,[Notes]   AS C18 ");
        //	stringBuilder.AppendLine("        ,[CheckUpdate]   AS C19 ");
        //	stringBuilder.AppendLine("        ,[DataFromNippo]   AS C20 ");
        //	stringBuilder.AppendLine("    FROM [PRJ_Effort]   ");
        //	stringBuilder.AppendLine("  WHERE          ");
        //	stringBuilder.AppendLine("        1 = 1          ");
        //	stringBuilder.AppendLine("  AND   [ScheduleName] = @Project          ");
        //	stringBuilder.AppendLine("  ORDER BY          ");
        //	stringBuilder.AppendLine("     [StartDate]        ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Project", SqlDbType.NVarChar)).Value = projectName;
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					ProjectStaffEffort projectStaffEffort = default(ProjectStaffEffort);
        //					projectStaffEffort.ID = string.Format("{0:0000000000}", RuntimeHelpers.GetObjectValue(dataRow["C1"]));
        //					projectStaffEffort.StartDate = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C3"]));
        //					projectStaffEffort.EndDate = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C4"]));
        //					projectStaffEffort.CustomerEffort = Conversions.ToDecimal(dataRow["C5"]);
        //					projectStaffEffort.AutoCal = Conversions.ToBoolean(dataRow["C6"]);
        //					projectStaffEffort.HowToConv = Conversions.ToInteger(dataRow["C7"]);
        //					projectStaffEffort.RegUser = Conversions.ToString(dataRow["C8"]);
        //					projectStaffEffort.RegDate = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C9"]));
        //					projectStaffEffort.ModUser = Conversions.ToString(dataRow["C10"]);
        //					projectStaffEffort.ModDate = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C11"]));
        //					projectStaffEffort.IsConfirmed = Conversions.ToBoolean((dataRow["C12"] == DBNull.Value) ? false : dataRow["C12"]);
        //					projectStaffEffort.ConfirmBy = Conversions.ToString((dataRow["C13"] == DBNull.Value) ? "" : dataRow["C13"]);
        //					projectStaffEffort.ConfirmDate = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C14"]));
        //					projectStaffEffort.LeaderRate = Conversions.ToDecimal((dataRow["C15"] == DBNull.Value) ? 100 : dataRow["C15"]);
        //					projectStaffEffort.IsPM = Conversions.ToBoolean((dataRow["C16"] == DBNull.Value) ? false : dataRow["C16"]);
        //					projectStaffEffort.ProjectEffortNotes = Conversions.ToString((dataRow["C17"] == DBNull.Value) ? "" : dataRow["C17"]);
        //					projectStaffEffort.Notes = Conversions.ToString((dataRow["C18"] == DBNull.Value) ? "" : dataRow["C18"]);
        //					projectStaffEffort.CheckUpdate = (Array)((dataRow["C19"] == DBNull.Value) ? "" : dataRow["C19"]);
        //					projectStaffEffort.Detail = this.GetStaffEffortDetailList(projectStaffEffort, ref projectStaffEffort.AllowApprove);
        //					projectStaffEffort.ProjectDetail = this.GetProjectEffortDetailList(projectStaffEffort.ID);
        //					projectStaffEffort.SupportEffortList = this.GetSupportList(projectStaffEffort.ID);
        //					projectStaffEffort.DataFromNippo = Conversions.ToBoolean((dataRow["C20"] == DBNull.Value) ? false : dataRow["C20"]);
        //					list.Add(projectStaffEffort);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return list;
        //}

        //// Token: 0x06001028 RID: 4136 RVA: 0x0006ECA4 File Offset: 0x0006CEA4
        //public List<EffortSupportRate> GetSupportList(string staffEffortID)
        //{
        //	cls_DB_ProjectSchedule._Closure$__6-0 CS$<>8__locals1 = new cls_DB_ProjectSchedule._Closure$__6-0(CS$<>8__locals1);
        //	List<EffortSupportRate> list = new List<EffortSupportRate>();
        //	FJN_WMSEntities fjn_WMSEntities = new FJN_WMSEntities();
        //	CS$<>8__locals1.$VB$Local_ID = long.Parse(staffEffortID);
        //	IQueryable<PRJ_EffortSupportList> queryable = from x in fjn_WMSEntities.PRJ_EffortSupportList
        //	where (bool)(x.EffortID == checked((long?)CS$<>8__locals1.$VB$Local_ID))
        //	select x;
        //	bool flag = queryable != null && queryable.Any<PRJ_EffortSupportList>();
        //	if (flag)
        //	{
        //		try
        //		{
        //			foreach (PRJ_EffortSupportList prj_EffortSupportList in queryable)
        //			{
        //				EffortSupportRate effortSupportRate = new EffortSupportRate
        //				{
        //					ID = checked((int)prj_EffortSupportList.ID),
        //					Member = new cls_CM_Staff_Abridged()
        //				};
        //				ArrayList arrayList = effortSupportRate.Member.fncG_CM_GetStaffList("", prj_EffortSupportList.UserName, "", "", "", "", false, "", false);
        //				bool flag2 = arrayList != null && arrayList.Count == 1;
        //				if (flag2)
        //				{
        //					effortSupportRate.Member = (cls_CM_Staff_Abridged)arrayList[0];
        //				}
        //				effortSupportRate.Rate = prj_EffortSupportList.SupportRate.Value;
        //				effortSupportRate.Note = prj_EffortSupportList.Note;
        //				effortSupportRate.Type = (SupportType)prj_EffortSupportList.SupportType.Value;
        //				list.Add(effortSupportRate);
        //			}
        //		}
        //		finally
        //		{
        //			IEnumerator<PRJ_EffortSupportList> enumerator;
        //			if (enumerator != null)
        //			{
        //				enumerator.Dispose();
        //			}
        //		}
        //	}
        //	return list;
        //}

        //// Token: 0x06001029 RID: 4137 RVA: 0x0006EE90 File Offset: 0x0006D090
        //public Array GetCheckUpdate(long ID, int length)
        //{
        //	Array result = Array.CreateInstance(typeof(byte), length);
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT [CheckUpdate]   AS C19 ");
        //	stringBuilder.AppendLine("    FROM [PRJ_Effort]   ");
        //	stringBuilder.AppendLine("  WHERE          ");
        //	stringBuilder.AppendLine("        1 = 1          ");
        //	stringBuilder.AppendLine("  AND   [ID] = @ID          ");
        //	stringBuilder.AppendLine("  ORDER BY          ");
        //	stringBuilder.AppendLine("     [StartDate]        ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt)).Value = ID;
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					result = (Array)((dataRow["C19"] == DBNull.Value) ? "" : dataRow["C19"]);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return result;
        //}

        //// Token: 0x0600102A RID: 4138 RVA: 0x0006F038 File Offset: 0x0006D238
        //public List<ProjectStaffEffortDetail> GetStaffEffortDetailList(ProjectStaffEffort effort, ref bool allowApprove)
        //{
        //	List<ProjectStaffEffortDetail> list = new List<ProjectStaffEffortDetail>();
        //	cls_CM_Staff_Abridged cls_CM_Staff_Abridged = new cls_CM_Staff_Abridged();
        //	allowApprove = true;
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   SELECT [ID]                 AS  C1 ");
        //	stringBuilder.AppendLine("         ,[Effort]              AS  C2 ");
        //	stringBuilder.AppendLine("         ,[Member]             AS  C3 ");
        //	stringBuilder.AppendLine("         ,[ScheduleEffort]     AS  C4 ");
        //	stringBuilder.AppendLine("         ,[TrainingEffort]         AS  C5 ");
        //	stringBuilder.AppendLine("         ,[QualityPer]         AS  C6 ");
        //	stringBuilder.AppendLine("         ,[ScheduleWithQuality]    AS  C7 ");
        //	stringBuilder.AppendLine("         ,[ConvQuality]        AS  C8 ");
        //	stringBuilder.AppendLine("         ,[ModQuality]         AS  C9 ");
        //	stringBuilder.AppendLine("         ,[CusEffortConv]      AS  C10 ");
        //	stringBuilder.AppendLine("         ,[KeepLaborEff]       AS  C11 ");
        //	stringBuilder.AppendLine("         ,[PrjEffectiveEff]    AS  C12 ");
        //	stringBuilder.AppendLine("         ,[PrjBonusEff]        AS  C13 ");
        //	stringBuilder.AppendLine("         ,[Notes]              AS  C14 ");
        //	stringBuilder.AppendLine("         ,[RegUser]    AS  C15 ");
        //	stringBuilder.AppendLine("         ,[RegDate]    AS  C16 ");
        //	stringBuilder.AppendLine("         ,[ModUser]    AS  C17 ");
        //	stringBuilder.AppendLine("         ,[ModDate]    AS  C18 ");
        //	stringBuilder.AppendLine("         ,[NTAccount]             AS  C19 ");
        //	stringBuilder.AppendLine("         ,[ProjectActualEffort]             AS  C20 ");
        //	stringBuilder.AppendLine("         ,[TrainingActualEffort]             AS  C21 ");
        //	stringBuilder.AppendLine("         ,[IsKeptlabor]       AS  C22 ");
        //	stringBuilder.AppendLine("         ,[OriginalScheduleEffort]       AS  C23 ");
        //	stringBuilder.AppendLine("         ,[ExchangedScheduleEffort]       AS  C24 ");
        //	stringBuilder.AppendLine("         ,[OriginalActualEffort]       AS  C25 ");
        //	stringBuilder.AppendLine("         ,[ExchangedActualEffort]       AS  C26 ");
        //	stringBuilder.AppendLine("         ,[TotalEffortWithBonus]       AS  C27 ");
        //	stringBuilder.AppendLine("         ,[IsConvQuality]        AS  C28 ");
        //	stringBuilder.AppendLine("     FROM [PRJ_EffortDetail]    ");
        //	stringBuilder.AppendLine("  WHERE          ");
        //	stringBuilder.AppendLine("        1 = 1          ");
        //	stringBuilder.AppendLine("  AND   [Effort] = @Effort          ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(effort.ID);
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					ProjectStaffEffortDetail projectStaffEffortDetail = default(ProjectStaffEffortDetail);
        //					projectStaffEffortDetail.ID = string.Format("{0:0000000000}", RuntimeHelpers.GetObjectValue(dataRow["C1"]));
        //					projectStaffEffortDetail.ProjectEffortID = string.Format("{0:0000000000}", RuntimeHelpers.GetObjectValue(dataRow["C2"]));
        //					ArrayList arrayList = cls_CM_Staff_Abridged.fncG_CM_GetStaffList(Conversions.ToString(dataRow["C3"]), "", "", "", "", "", true, "", false);
        //					bool flag2 = arrayList == null || arrayList.Count == 0;
        //					if (flag2)
        //					{
        //						projectStaffEffortDetail.Member = RuntimeHelpers.GetObjectValue(dataRow["C3"]);
        //					}
        //					else
        //					{
        //						projectStaffEffortDetail.Member = RuntimeHelpers.GetObjectValue(arrayList[0]);
        //					}
        //					object objectValue = RuntimeHelpers.GetObjectValue(dataRow["C23"]);
        //					ref decimal ptr = ref projectStaffEffortDetail.OriginalScheduleEffort;
        //					object value = projectStaffEffortDetail.OriginalScheduleEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow["C24"]);
        //					ptr = ref projectStaffEffortDetail.ExchangedScheduleEffort;
        //					value = projectStaffEffortDetail.ExchangedScheduleEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue2, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue3 = RuntimeHelpers.GetObjectValue(dataRow["C25"]);
        //					ptr = ref projectStaffEffortDetail.OriginalActualEffort;
        //					value = projectStaffEffortDetail.OriginalActualEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue3, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue4 = RuntimeHelpers.GetObjectValue(dataRow["C26"]);
        //					ptr = ref projectStaffEffortDetail.ExchangedActualEffort;
        //					value = projectStaffEffortDetail.ExchangedActualEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue4, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue5 = RuntimeHelpers.GetObjectValue(dataRow["C27"]);
        //					ptr = ref projectStaffEffortDetail.TotalEffortWithBonus;
        //					value = projectStaffEffortDetail.TotalEffortWithBonus;
        //					cls_CM_Function.SetDBFieldData(objectValue5, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					bool flag3 = dataRow["C23"] == DBNull.Value && dataRow["C24"] == DBNull.Value && dataRow["C25"] == DBNull.Value && dataRow["C26"] == DBNull.Value;
        //					if (flag3)
        //					{
        //						object objectValue6 = RuntimeHelpers.GetObjectValue(dataRow["C4"]);
        //						ptr = ref projectStaffEffortDetail.OriginalScheduleEffort;
        //						value = projectStaffEffortDetail.OriginalScheduleEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue6, ref value);
        //						ptr = Conversions.ToDecimal(value);
        //						object objectValue7 = RuntimeHelpers.GetObjectValue(dataRow["C4"]);
        //						ptr = ref projectStaffEffortDetail.ExchangedScheduleEffort;
        //						value = projectStaffEffortDetail.ExchangedScheduleEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue7, ref value);
        //						ptr = Conversions.ToDecimal(value);
        //						object objectValue8 = RuntimeHelpers.GetObjectValue(dataRow["C7"]);
        //						ptr = ref projectStaffEffortDetail.TotalEffortWithBonus;
        //						value = projectStaffEffortDetail.TotalEffortWithBonus;
        //						cls_CM_Function.SetDBFieldData(objectValue8, ref value);
        //						ptr = Conversions.ToDecimal(value);
        //						object objectValue9 = RuntimeHelpers.GetObjectValue(dataRow["C20"]);
        //						ptr = ref projectStaffEffortDetail.OriginalActualEffort;
        //						value = projectStaffEffortDetail.OriginalActualEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue9, ref value);
        //						ptr = Conversions.ToDecimal(value);
        //						object objectValue10 = RuntimeHelpers.GetObjectValue(dataRow["C20"]);
        //						ptr = ref projectStaffEffortDetail.ExchangedActualEffort;
        //						value = projectStaffEffortDetail.ExchangedActualEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue10, ref value);
        //						ptr = Conversions.ToDecimal(value);
        //						decimal num = 0m;
        //						decimal num2 = 0m;
        //						object objectValue11 = RuntimeHelpers.GetObjectValue(dataRow["C5"]);
        //						value = num;
        //						cls_CM_Function.SetDBFieldData(objectValue11, ref value);
        //						num = Conversions.ToDecimal(value);
        //						object objectValue12 = RuntimeHelpers.GetObjectValue(dataRow["C21"]);
        //						value = num2;
        //						cls_CM_Function.SetDBFieldData(objectValue12, ref value);
        //						num2 = Conversions.ToDecimal(value);
        //						ptr = ref projectStaffEffortDetail.OriginalActualEffort;
        //						projectStaffEffortDetail.OriginalActualEffort = decimal.Add(ptr, num2);
        //						ptr = ref projectStaffEffortDetail.ExchangedActualEffort;
        //						projectStaffEffortDetail.ExchangedActualEffort = decimal.Add(ptr, num2);
        //						projectStaffEffortDetail.ExchangedScheduleEffort = decimal.Add(decimal.Subtract(projectStaffEffortDetail.ExchangedScheduleEffort, num), decimal.Multiply(num, 0.6m));
        //						allowApprove = false;
        //					}
        //					object objectValue13 = RuntimeHelpers.GetObjectValue(dataRow["C7"]);
        //					ptr = ref projectStaffEffortDetail.ScheduleWithQuality;
        //					value = projectStaffEffortDetail.ScheduleWithQuality;
        //					cls_CM_Function.SetDBFieldData(objectValue13, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue14 = RuntimeHelpers.GetObjectValue(dataRow["C8"]);
        //					ptr = ref projectStaffEffortDetail.ConversionQualityEffort;
        //					value = projectStaffEffortDetail.ConversionQualityEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue14, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue15 = RuntimeHelpers.GetObjectValue(dataRow["C9"]);
        //					ptr = ref projectStaffEffortDetail.ModifiedQualityEffort;
        //					value = projectStaffEffortDetail.ModifiedQualityEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue15, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue16 = RuntimeHelpers.GetObjectValue(dataRow["C10"]);
        //					ptr = ref projectStaffEffortDetail.CustomerEffortConversion;
        //					value = projectStaffEffortDetail.CustomerEffortConversion;
        //					cls_CM_Function.SetDBFieldData(objectValue16, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue17 = RuntimeHelpers.GetObjectValue(dataRow["C11"]);
        //					ptr = ref projectStaffEffortDetail.KeepLaborEffort;
        //					value = projectStaffEffortDetail.KeepLaborEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue17, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue18 = RuntimeHelpers.GetObjectValue(dataRow["C12"]);
        //					ptr = ref projectStaffEffortDetail.PrjEffectiveEff;
        //					value = projectStaffEffortDetail.PrjEffectiveEff;
        //					cls_CM_Function.SetDBFieldData(objectValue18, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue19 = RuntimeHelpers.GetObjectValue(dataRow["C13"]);
        //					ptr = ref projectStaffEffortDetail.PrjBonusEff;
        //					value = projectStaffEffortDetail.PrjBonusEff;
        //					cls_CM_Function.SetDBFieldData(objectValue19, ref value);
        //					ptr = Conversions.ToDecimal(value);
        //					object objectValue20 = RuntimeHelpers.GetObjectValue(dataRow["C14"]);
        //					ref string ptr2 = ref projectStaffEffortDetail.Notes;
        //					value = projectStaffEffortDetail.Notes;
        //					cls_CM_Function.SetDBFieldData(objectValue20, ref value);
        //					ptr2 = Conversions.ToString(value);
        //					object objectValue21 = RuntimeHelpers.GetObjectValue(dataRow["C15"]);
        //					ptr2 = ref projectStaffEffortDetail.RegUser;
        //					value = projectStaffEffortDetail.RegUser;
        //					cls_CM_Function.SetDBFieldData(objectValue21, ref value);
        //					ptr2 = Conversions.ToString(value);
        //					object dbobj = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C16"]));
        //					ref DateTime ptr3 = ref projectStaffEffortDetail.RegDate;
        //					value = projectStaffEffortDetail.RegDate;
        //					cls_CM_Function.SetDBFieldData(dbobj, ref value);
        //					ptr3 = Conversions.ToDate(value);
        //					object objectValue22 = RuntimeHelpers.GetObjectValue(dataRow["C17"]);
        //					ptr2 = ref projectStaffEffortDetail.ModUser;
        //					value = projectStaffEffortDetail.ModUser;
        //					cls_CM_Function.SetDBFieldData(objectValue22, ref value);
        //					ptr2 = Conversions.ToString(value);
        //					object dbobj2 = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["C18"]));
        //					ptr3 = ref projectStaffEffortDetail.ModDate;
        //					value = projectStaffEffortDetail.ModDate;
        //					cls_CM_Function.SetDBFieldData(dbobj2, ref value);
        //					ptr3 = Conversions.ToDate(value);
        //					object objectValue23 = RuntimeHelpers.GetObjectValue(dataRow["C19"]);
        //					ptr2 = ref projectStaffEffortDetail.NTAccount;
        //					value = projectStaffEffortDetail.NTAccount;
        //					cls_CM_Function.SetDBFieldData(objectValue23, ref value);
        //					ptr2 = Conversions.ToString(value);
        //					object objectValue24 = RuntimeHelpers.GetObjectValue(dataRow["C22"]);
        //					ref bool ptr4 = ref projectStaffEffortDetail.IsKeptLabor;
        //					value = projectStaffEffortDetail.IsKeptLabor;
        //					cls_CM_Function.SetDBFieldData(objectValue24, ref value);
        //					ptr4 = Conversions.ToBoolean(value);
        //					object objectValue25 = RuntimeHelpers.GetObjectValue(dataRow["C28"]);
        //					ptr4 = ref projectStaffEffortDetail.IsConvQuality;
        //					value = projectStaffEffortDetail.IsConvQuality;
        //					cls_CM_Function.SetDBFieldData(objectValue25, ref value);
        //					ptr4 = Conversions.ToBoolean(value);
        //					projectStaffEffortDetail.PhaseDetailEffort = this.GetDetailPhaseEffort(effort, projectStaffEffortDetail);
        //					list.Add(projectStaffEffortDetail);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return list;
        //}

        //// Token: 0x0600102B RID: 4139 RVA: 0x0006FAF8 File Offset: 0x0006DCF8
        //private ArrayList GetDetailPhaseEffort(ProjectStaffEffort effort, ProjectStaffEffortDetail staffEffortDetail)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   SELECT [ID] ");
        //	stringBuilder.AppendLine("         ,[DetailID] ");
        //	stringBuilder.AppendLine("         ,[PhaseID] ");
        //	stringBuilder.AppendLine("         ,[OriginalBaselinedEffort] ");
        //	stringBuilder.AppendLine("         ,[OriginalScheduleEffort] ");
        //	stringBuilder.AppendLine("         ,[OriginalActualEffort] ");
        //	stringBuilder.AppendLine("         ,[OriginalOvertimeEffort] ");
        //	stringBuilder.AppendLine("         ,[ExchangedBaselinedEffort] ");
        //	stringBuilder.AppendLine("         ,[ExchangedScheduleEffort] ");
        //	stringBuilder.AppendLine("         ,[ExchangedActualEffort] ");
        //	stringBuilder.AppendLine("         ,[ExchangedOvertimeEffort] ");
        //	stringBuilder.AppendLine("         ,[ExchangedRate] ");
        //	stringBuilder.AppendLine("         ,[QualityPercent] ");
        //	stringBuilder.AppendLine("         ,[EffortWithBonus] ");
        //	stringBuilder.AppendLine("     FROM [PRJ_EffortDetailByPhases] ");
        //	stringBuilder.AppendLine("  WHERE          ");
        //	stringBuilder.AppendLine("        1 = 1          ");
        //	stringBuilder.AppendLine("  AND   [DetailID] = @DetailID          ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@DetailID", SqlDbType.BigInt)).Value = long.Parse(staffEffortDetail.ID);
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null;
        //	if (flag)
        //	{
        //		ArrayList phaseExchangeList = this.GetPhaseExchangeList((TaskPhase)(-1), "", null, null);
        //		cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					EffortByPhaseData effortByPhaseData = default(EffortByPhaseData);
        //					object objectValue = RuntimeHelpers.GetObjectValue(dataRow["PhaseID"]);
        //					ref TaskPhase ptr = ref effortByPhaseData.EffortPhase;
        //					object value = effortByPhaseData.EffortPhase;
        //					cls_CM_Function.SetDBFieldData(objectValue, ref value);
        //					ptr = (TaskPhase)Conversions.ToInteger(value);
        //					object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow["OriginalBaselinedEffort"]);
        //					ref decimal ptr2 = ref effortByPhaseData.OriginalBaselinedEffort;
        //					value = effortByPhaseData.OriginalBaselinedEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue2, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue3 = RuntimeHelpers.GetObjectValue(dataRow["OriginalScheduleEffort"]);
        //					ptr2 = ref effortByPhaseData.OriginalScheduleEffort;
        //					value = effortByPhaseData.OriginalScheduleEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue3, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue4 = RuntimeHelpers.GetObjectValue(dataRow["OriginalActualEffort"]);
        //					ptr2 = ref effortByPhaseData.OriginalActualEffort;
        //					value = effortByPhaseData.OriginalActualEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue4, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue5 = RuntimeHelpers.GetObjectValue(dataRow["OriginalOvertimeEffort"]);
        //					ptr2 = ref effortByPhaseData.OriginalOvertimeEffort;
        //					value = effortByPhaseData.OriginalOvertimeEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue5, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue6 = RuntimeHelpers.GetObjectValue(dataRow["ExchangedBaselinedEffort"]);
        //					ptr2 = ref effortByPhaseData.ExchangedBaselinedEffort;
        //					value = effortByPhaseData.ExchangedBaselinedEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue6, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue7 = RuntimeHelpers.GetObjectValue(dataRow["ExchangedScheduleEffort"]);
        //					ptr2 = ref effortByPhaseData.ExchangedScheduleEffort;
        //					value = effortByPhaseData.ExchangedScheduleEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue7, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue8 = RuntimeHelpers.GetObjectValue(dataRow["ExchangedActualEffort"]);
        //					ptr2 = ref effortByPhaseData.ExchangedActualEffort;
        //					value = effortByPhaseData.ExchangedActualEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue8, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue9 = RuntimeHelpers.GetObjectValue(dataRow["ExchangedOvertimeEffort"]);
        //					ptr2 = ref effortByPhaseData.ExchangedOvertimeEffort;
        //					value = effortByPhaseData.ExchangedOvertimeEffort;
        //					cls_CM_Function.SetDBFieldData(objectValue9, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					object objectValue10 = RuntimeHelpers.GetObjectValue(dataRow["EffortWithBonus"]);
        //					ptr2 = ref effortByPhaseData.EffortWithBonus;
        //					value = effortByPhaseData.EffortWithBonus;
        //					cls_CM_Function.SetDBFieldData(objectValue10, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					PhaseExchange phaseExchangeRate = cls_CM_ProjectSchedule.GetPhaseExchangeRate(effortByPhaseData.EffortPhase, phaseExchangeList, effort.EndDate.ToString("yyyyMM"));
        //					effortByPhaseData.BonusEffortRate = phaseExchangeRate.BonusEffortRate;
        //					effortByPhaseData.EffortExchangedRate = phaseExchangeRate.EffortExchangeRate;
        //					object objectValue11 = RuntimeHelpers.GetObjectValue(dataRow["QualityPercent"]);
        //					ptr2 = ref effortByPhaseData.QualityPercent;
        //					value = effortByPhaseData.QualityPercent;
        //					cls_CM_Function.SetDBFieldData(objectValue11, ref value);
        //					ptr2 = Conversions.ToDecimal(value);
        //					arrayList.Add(effortByPhaseData);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        //// Token: 0x0600102C RID: 4140 RVA: 0x00070018 File Offset: 0x0006E218
        //public List<ProjectEffortDetail> GetProjectEffortDetailList(string StaffEffortID)
        //{
        //	List<ProjectEffortDetail> list = new List<ProjectEffortDetail>();
        //	cls_CM_Staff_Abridged cls_CM_Staff_Abridged = new cls_CM_Staff_Abridged();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   SELECT [ID]                 AS  C1 ");
        //	stringBuilder.AppendLine("         ,[Effort]              AS  C2 ");
        //	stringBuilder.AppendLine("         ,[Leader]             AS  C3 ");
        //	stringBuilder.AppendLine("         ,[ManagementRate]     AS  C4 ");
        //	stringBuilder.AppendLine("         ,[Notes]         AS  C5 ");
        //	stringBuilder.AppendLine("         ,[SharedManagementRate]         AS  C6 ");
        //	stringBuilder.AppendLine("         ,[LeaderWorkingPercent]         AS  C7 ");
        //	stringBuilder.AppendLine("         ,[ActualManagementEffort]         AS  C8 ");
        //	stringBuilder.AppendLine("     FROM [PRJ_EffortProjectDetail]    ");
        //	stringBuilder.AppendLine("  WHERE          ");
        //	stringBuilder.AppendLine("        1 = 1          ");
        //	stringBuilder.AppendLine("  AND   [Effort] = @Effort          ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(StaffEffortID);
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					ProjectEffortDetail item = default(ProjectEffortDetail);
        //					item.ID = string.Format("{0:0000000000}", RuntimeHelpers.GetObjectValue(dataRow["C1"]));
        //					item.StaffEffortID = string.Format("{0:0000000000}", RuntimeHelpers.GetObjectValue(dataRow["C2"]));
        //					ArrayList arrayList = cls_CM_Staff_Abridged.fncG_CM_GetStaffList(Conversions.ToString(dataRow["C3"]), "", "", "", "", "", true, "", false);
        //					bool flag2 = arrayList == null || arrayList.Count != 0;
        //					if (flag2)
        //					{
        //						item.Leader = (cls_CM_Staff_Abridged)arrayList[0];
        //					}
        //					item.SharedManagementRate = Conversions.ToDecimal(dataRow["C6"]);
        //					item.LeaderWorkingPercent = Conversions.ToDecimal(dataRow["C7"]);
        //					item.ActualManagementEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C8"])) ? 0 : dataRow["C8"]);
        //					item.Notes = Conversions.ToString(dataRow["C5"]);
        //					list.Add(item);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return list;
        //}

        //// Token: 0x0600102D RID: 4141 RVA: 0x0007034C File Offset: 0x0006E54C
        //public ArrayList GetScheduleOfUser(string strUserName)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("\tSELECT  DISTINCT    \t                                        ");
        //	stringBuilder.AppendLine("\t       A1.[WPROJ_ID]  \t                                            ");
        //	stringBuilder.AppendLine("\t       , R1.PROJ_NAME                                          ");
        //	stringBuilder.AppendLine("   FROM                                                         ");
        //	stringBuilder.AppendLine("\t       [ProjectServer].[dbo].[MSP_VIEW_PROJ_ASSN_STD] A1  \t        ");
        //	stringBuilder.AppendLine("\t        ,[ProjectServer].[dbo].MSP_WEB_PROJECTS R1    ");
        //	stringBuilder.AppendLine("\t        ,[ProjectServer].[dbo].MSP_VIEW_PROJ_RES_STD R2  \t        ");
        //	stringBuilder.AppendLine("   WHERE                                                         ");
        //	stringBuilder.AppendLine("\t       (1=1)  \t                                                    ");
        //	stringBuilder.AppendLine("\t        and A1.ResourceEnterpriseUniqueID = R2.ResourceEnterpriseUniqueID \t");
        //	stringBuilder.AppendLine("\t        and A1.WPROJ_ID = R1.WPROJ_ID \t");
        //	stringBuilder.AppendLine("\t        and A1.WPROJ_ID = R2.WPROJ_ID \t");
        //	stringBuilder.AppendLine("\t        and A1.ResourceEnterpriseUniqueID <> -1  \t                    ");
        //	stringBuilder.AppendLine("\t        and convert(nvarchar(max),R2.ResourceNTAccount) =@ResourceNTAccount");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@ResourceNTAccount", SqlDbType.NVarChar)).Value = strUserName;
        //	stringBuilder.AppendLine("  ORDER BY          ");
        //	stringBuilder.AppendLine("     PROJ_NAME          ");
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
        //					cls_CM_ProjectSchedule.Name = Conversions.ToString(dataRow["PROJ_NAME"]);
        //					cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule2 = cls_CM_ProjectSchedule;
        //					object obj2 = dataRow["WPROJ_ID"];
        //					cls_CM_ProjectSchedule2.ID = ((obj2 != null) ? ((Guid)obj2) : default(Guid));
        //					arrayList.Add(cls_CM_ProjectSchedule);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        //// Token: 0x0600102E RID: 4142 RVA: 0x0007058C File Offset: 0x0006E78C
        //public bool SaveProjectStaffEffort(ref cls_CM_ProjectSchedule2007 projectEffort, ref string activeID = "", bool isInsertEmptyMember = true)
        //{
        //	checked
        //	{
        //		int num = projectEffort.ListEffort.Count - 1;
        //		for (int i = 0; i <= num; i++)
        //		{
        //			bool flag = projectEffort.ListEffort[i].IsConfirmed && Operators.CompareString(projectEffort.ListEffort[i].ConfirmBy, mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.ID, false) != 0;
        //			if (!flag)
        //			{
        //				bool flag2 = Operators.CompareString(projectEffort.ListEffort[i].ID, activeID, false) != 0;
        //				if (!flag2)
        //				{
        //					Array array = Array.CreateInstance(typeof(byte), projectEffort.ListEffort[i].CheckUpdate.Length);
        //					bool flag3 = Operators.CompareString(projectEffort.ListEffort[i].ID, "", false) != 0;
        //					bool result;
        //					if (flag3)
        //					{
        //						bool flag4 = this.UpdateStaffEffort(projectEffort.ListEffort[i], ref array, isInsertEmptyMember);
        //						array.CopyTo(projectEffort.ListEffort[i].CheckUpdate, 0);
        //						result = flag4;
        //					}
        //					else
        //					{
        //						List<ProjectStaffEffort> listEffort;
        //						int index;
        //						ProjectStaffEffort value = (listEffort = projectEffort.ListEffort)[index = i];
        //						bool flag5 = this.InsertStaffEffort(ref value, ref array, projectEffort.ID, projectEffort.Name, ref activeID, isInsertEmptyMember);
        //						listEffort[index] = value;
        //						bool flag6 = flag5;
        //						array.CopyTo(projectEffort.ListEffort[i].CheckUpdate, 0);
        //						result = flag6;
        //					}
        //					return result;
        //				}
        //			}
        //		}
        //		return false;
        //	}
        //}

        //// Token: 0x0600102F RID: 4143 RVA: 0x00070718 File Offset: 0x0006E918
        //public bool UpdateStaffEffort(ProjectStaffEffort OneEffort, ref Array CheckUpdate, bool isInsertEmptyMember)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine(" UPDATE [PRJ_Effort]   ");
        //	stringBuilder.AppendLine("      SET [StartDate] = @StartDate ");
        //	stringBuilder.AppendLine("         ,[EndDate] = @EndDate ");
        //	stringBuilder.AppendLine("         ,[CustomerEffort] = @CustomerEffort ");
        //	stringBuilder.AppendLine("         ,[AutoCal] = @AutoCal ");
        //	stringBuilder.AppendLine("         ,[HowToConv] = @HowToConv ");
        //	stringBuilder.AppendLine("         ,[ModUser] = @ModUser ");
        //	stringBuilder.AppendLine("         ,[ModDate] = @ModDate ");
        //	stringBuilder.AppendLine("         ,[IsConfirmed] = @IsConfirmed ");
        //	stringBuilder.AppendLine("         ,[ConfirmedBy] = @ConfirmedBy ");
        //	stringBuilder.AppendLine("         ,[ConfirmDate] = @ConfirmDate ");
        //	stringBuilder.AppendLine("         ,[LeaderRate] = @LeaderRate ");
        //	stringBuilder.AppendLine("         ,[IsPM] = @IsPM ");
        //	stringBuilder.AppendLine("         ,[ProjectEffortNotes] = @ProjectEffortNotes ");
        //	stringBuilder.AppendLine("         ,[TrainingEffort] = @TrainingEffort ");
        //	stringBuilder.AppendLine("         ,[Notes] = @Notes ");
        //	stringBuilder.AppendLine("    WHERE  ");
        //	stringBuilder.AppendLine("         (1 = 1)  ");
        //	stringBuilder.AppendLine("         AND (ID = @ID)  ");
        //	stringBuilder.AppendLine("\t      AND CheckUpdate = @rowversion ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt)).Value = long.Parse(OneEffort.ID);
        //	parameters.Add(new SqlParameter("@rowversion", SqlDbType.Timestamp)).Value = OneEffort.CheckUpdate;
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(OneEffort.StartDate);
        //	parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(OneEffort.EndDate);
        //	parameters.Add(new SqlParameter("@CustomerEffort", SqlDbType.Decimal)).Value = OneEffort.CustomerEffort;
        //	parameters.Add(new SqlParameter("@AutoCal", SqlDbType.Bit)).Value = OneEffort.AutoCal;
        //	parameters.Add(new SqlParameter("@HowToConv", SqlDbType.TinyInt)).Value = OneEffort.HowToConv;
        //	parameters.Add(new SqlParameter("@ModUser", SqlDbType.NVarChar)).Value = OneEffort.ModUser;
        //	parameters.Add(new SqlParameter("@ModDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(OneEffort.ModDate);
        //	parameters.Add(new SqlParameter("@IsConfirmed", SqlDbType.Bit)).Value = OneEffort.IsConfirmed;
        //	parameters.Add(new SqlParameter("@ConfirmedBy", SqlDbType.NVarChar)).Value = OneEffort.ConfirmBy;
        //	parameters.Add(new SqlParameter("@ConfirmDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(OneEffort.ConfirmDate);
        //	parameters.Add(new SqlParameter("@LeaderRate", SqlDbType.Decimal)).Value = OneEffort.LeaderRate;
        //	parameters.Add(new SqlParameter("@IsPM", SqlDbType.Bit)).Value = OneEffort.IsPM;
        //	parameters.Add(new SqlParameter("@ProjectEffortNotes", SqlDbType.NVarChar)).Value = OneEffort.ProjectEffortNotes;
        //	parameters.Add(new SqlParameter("@Notes", SqlDbType.NVarChar)).Value = OneEffort.Notes;
        //	decimal num = 0m;
        //	decimal num2 = 0m;
        //	decimal num3 = 0m;
        //	this.SumTrainingEffort(OneEffort, ref num, ref num2, ref num3);
        //	parameters.Add(new SqlParameter("@TrainingEffort", SqlDbType.Decimal)).Value = num;
        //	mod_WMS_Declare.gvObj_Database.DBBeginTrans(IsolationLevel.Serializable);
        //	int num4 = checked((int)mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false));
        //	bool flag = num4 > 0;
        //	bool result;
        //	if (flag)
        //	{
        //		this.DeleteStaffEffortDetail(OneEffort);
        //		this.DeleteProjectEffortDetail(OneEffort);
        //		this.DeleteSupportMembers(OneEffort);
        //		this.InsertStaffEffortDetail(OneEffort, isInsertEmptyMember);
        //		this.InsertProjectEffortDetail(OneEffort);
        //		mod_WMS_Declare.gvObj_Database.DBCommitTrans();
        //		mod_WMS_Declare.rwl.ExitWriteLock();
        //		this.InsertSupportMembers(OneEffort);
        //		result = true;
        //	}
        //	else
        //	{
        //		result = false;
        //	}
        //	CheckUpdate = this.GetCheckUpdate(Conversions.ToLong(OneEffort.ID), OneEffort.CheckUpdate.Length);
        //	return result;
        //}

        //// Token: 0x06001030 RID: 4144 RVA: 0x00070B54 File Offset: 0x0006ED54
        //public bool InsertStaffEffort(ref ProjectStaffEffort oneProjectStaffEffort, ref Array CheckUpdate, Guid scheduleID, string scheduleName, ref string newID, bool isInsertEmptyMember)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   INSERT INTO [PRJ_Effort] ");
        //	stringBuilder.AppendLine("              (  ");
        //	stringBuilder.AppendLine("                ");
        //	stringBuilder.AppendLine("              [Project]  ");
        //	stringBuilder.AppendLine("              ,[StartDate]  ");
        //	stringBuilder.AppendLine("              ,[EndDate]  ");
        //	stringBuilder.AppendLine("              ,[CustomerEffort]  ");
        //	stringBuilder.AppendLine("              ,[AutoCal]  ");
        //	stringBuilder.AppendLine("              ,[HowToConv]  ");
        //	stringBuilder.AppendLine("              ,[RegUser]  ");
        //	stringBuilder.AppendLine("              ,[RegDate]  ");
        //	stringBuilder.AppendLine("              ,[ModUser]  ");
        //	stringBuilder.AppendLine("              ,[ModDate]  ");
        //	stringBuilder.AppendLine("              ,[IsConfirmed]  ");
        //	stringBuilder.AppendLine("              ,[ConfirmedBy]  ");
        //	stringBuilder.AppendLine("              ,[ConfirmDate]  ");
        //	stringBuilder.AppendLine("              ,[LeaderRate]  ");
        //	stringBuilder.AppendLine("              ,[IsPM]  ");
        //	stringBuilder.AppendLine("              ,[ProjectEffortNotes]  ");
        //	stringBuilder.AppendLine("              ,[TrainingEffort]  ");
        //	stringBuilder.AppendLine("              ,[Notes]  ");
        //	stringBuilder.AppendLine("              ,[ScheduleName]  ");
        //	stringBuilder.AppendLine("              ,[DataFromNippo]  ");
        //	stringBuilder.AppendLine("              )  ");
        //	stringBuilder.AppendLine("        VALUES  ");
        //	stringBuilder.AppendLine("              (  ");
        //	stringBuilder.AppendLine("                ");
        //	stringBuilder.AppendLine("              @Project  ");
        //	stringBuilder.AppendLine("              ,@StartDate  ");
        //	stringBuilder.AppendLine("              ,@EndDate  ");
        //	stringBuilder.AppendLine("              ,@CustomerEffort  ");
        //	stringBuilder.AppendLine("              ,@AutoCal  ");
        //	stringBuilder.AppendLine("              ,@HowToConv  ");
        //	stringBuilder.AppendLine("              ,@RegUser  ");
        //	stringBuilder.AppendLine("              ,@RegDate  ");
        //	stringBuilder.AppendLine("              ,@ModUser  ");
        //	stringBuilder.AppendLine("              ,@ModDate   ");
        //	stringBuilder.AppendLine("              ,@IsConfirmed  ");
        //	stringBuilder.AppendLine("              ,@ConfirmedBy  ");
        //	stringBuilder.AppendLine("              ,@ConfirmDate   ");
        //	stringBuilder.AppendLine("              ,@LeaderRate  ");
        //	stringBuilder.AppendLine("              ,@IsPM  ");
        //	stringBuilder.AppendLine("              ,@ProjectEffortNotes   ");
        //	stringBuilder.AppendLine("              ,@TrainingEffort   ");
        //	stringBuilder.AppendLine("              ,@Notes   ");
        //	stringBuilder.AppendLine("              ,@ScheduleName  ");
        //	stringBuilder.AppendLine("              ,@DataFromNippo  ");
        //	stringBuilder.AppendLine("              )   ");
        //	stringBuilder.AppendLine("              ;SELECT SCOPE_IDENTITY();   ");
        //	string value = cls_DB_ProjectSchedule.ChangeGUIDToID(scheduleID);
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	mod_WMS_Declare.gvObj_Database.DBBeginTrans(IsolationLevel.ReadCommitted);
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Project", SqlDbType.NVarChar)).Value = value;
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(oneProjectStaffEffort.StartDate);
        //	parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(oneProjectStaffEffort.EndDate);
        //	parameters.Add(new SqlParameter("@CustomerEffort", SqlDbType.Decimal)).Value = oneProjectStaffEffort.CustomerEffort;
        //	parameters.Add(new SqlParameter("@AutoCal", SqlDbType.Bit)).Value = oneProjectStaffEffort.AutoCal;
        //	parameters.Add(new SqlParameter("@HowToConv", SqlDbType.TinyInt)).Value = oneProjectStaffEffort.HowToConv;
        //	parameters.Add(new SqlParameter("@RegUser", SqlDbType.NVarChar)).Value = oneProjectStaffEffort.RegUser;
        //	parameters.Add(new SqlParameter("@RegDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(oneProjectStaffEffort.RegDate);
        //	parameters.Add(new SqlParameter("@ModUser", SqlDbType.NVarChar)).Value = oneProjectStaffEffort.ModUser;
        //	parameters.Add(new SqlParameter("@ModDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(oneProjectStaffEffort.ModDate);
        //	parameters.Add(new SqlParameter("@IsConfirmed", SqlDbType.Bit)).Value = oneProjectStaffEffort.IsConfirmed;
        //	parameters.Add(new SqlParameter("@ConfirmedBy", SqlDbType.NVarChar)).Value = oneProjectStaffEffort.ConfirmBy;
        //	parameters.Add(new SqlParameter("@ConfirmDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(oneProjectStaffEffort.ConfirmDate);
        //	parameters.Add(new SqlParameter("@LeaderRate", SqlDbType.Decimal)).Value = oneProjectStaffEffort.LeaderRate;
        //	parameters.Add(new SqlParameter("@IsPM", SqlDbType.Bit)).Value = oneProjectStaffEffort.IsPM;
        //	parameters.Add(new SqlParameter("@ProjectEffortNotes", SqlDbType.NVarChar)).Value = oneProjectStaffEffort.ProjectEffortNotes;
        //	parameters.Add(new SqlParameter("@Notes", SqlDbType.NVarChar)).Value = oneProjectStaffEffort.Notes;
        //	parameters.Add(new SqlParameter("@ScheduleName", SqlDbType.NVarChar)).Value = scheduleName;
        //	decimal num = 0m;
        //	decimal num2 = 0m;
        //	decimal num3 = 0m;
        //	this.SumTrainingEffort(oneProjectStaffEffort, ref num, ref num2, ref num3);
        //	parameters.Add(new SqlParameter("@TrainingEffort", SqlDbType.Decimal)).Value = num;
        //	parameters.Add(new SqlParameter("@DataFromNippo", SqlDbType.Bit)).Value = oneProjectStaffEffort.DataFromNippo;
        //	long num4 = mod_WMS_Declare.gvObj_Database.DBExecuteSQLReturnID(stringBuilder.ToString(), false);
        //	bool flag = num4 > 0L;
        //	bool result;
        //	if (flag)
        //	{
        //		oneProjectStaffEffort.ID = string.Format("{0:0000000000}", num4);
        //		newID = oneProjectStaffEffort.ID;
        //		this.InsertStaffEffortDetail(oneProjectStaffEffort, isInsertEmptyMember);
        //		this.InsertProjectEffortDetail(oneProjectStaffEffort);
        //		result = true;
        //		CheckUpdate = this.GetCheckUpdate(Conversions.ToLong(oneProjectStaffEffort.ID), oneProjectStaffEffort.CheckUpdate.Length);
        //		mod_WMS_Declare.gvObj_Database.DBCommitTrans();
        //		mod_WMS_Declare.rwl.ExitWriteLock();
        //		this.InsertSupportMembers(oneProjectStaffEffort);
        //	}
        //	else
        //	{
        //		result = false;
        //	}
        //	return result;
        //}

        //// Token: 0x06001031 RID: 4145 RVA: 0x0007116C File Offset: 0x0006F36C
        //public bool InsertSupportMembers(ProjectStaffEffort oneProjectStaffEffort)
        //{
        //	bool result = false;
        //	FJN_WMSEntities fjn_WMSEntities = new FJN_WMSEntities();
        //	long value = long.Parse(oneProjectStaffEffort.ID);
        //	try
        //	{
        //		foreach (EffortSupportRate effortSupportRate in oneProjectStaffEffort.SupportEffortList)
        //		{
        //			PRJ_EffortSupportList entity = new PRJ_EffortSupportList
        //			{
        //				EffortID = new long?(value),
        //				UserName = effortSupportRate.Member.UserName,
        //				SupportRate = new decimal?(effortSupportRate.Rate),
        //				Note = effortSupportRate.Note,
        //				SupportType = new short?(checked((short)effortSupportRate.Type))
        //			};
        //			fjn_WMSEntities.PRJ_EffortSupportList.Add(entity);
        //			result = true;
        //		}
        //	}
        //	finally
        //	{
        //		List<EffortSupportRate>.Enumerator enumerator;
        //		((IDisposable)enumerator).Dispose();
        //	}
        //	fjn_WMSEntities.SaveChanges();
        //	return result;
        //}

        //// Token: 0x06001032 RID: 4146 RVA: 0x0007125C File Offset: 0x0006F45C
        //public bool DeleteSupportMembers(ProjectStaffEffort oneProjectStaffEffort)
        //{
        //	bool flag = false;
        //	FJN_WMSEntities fjn_WMSEntities = new FJN_WMSEntities();
        //	long ID = long.Parse(oneProjectStaffEffort.ID);
        //	IQueryable<PRJ_EffortSupportList> queryable = from x in fjn_WMSEntities.PRJ_EffortSupportList
        //	where (bool)(x.EffortID == checked((long?)ID))
        //	select x;
        //	bool flag2 = queryable == null || !queryable.Any<PRJ_EffortSupportList>();
        //	bool result;
        //	if (flag2)
        //	{
        //		result = flag;
        //	}
        //	else
        //	{
        //		fjn_WMSEntities.PRJ_EffortSupportList.RemoveRange(queryable);
        //		fjn_WMSEntities.SaveChanges();
        //		result = flag;
        //	}
        //	return result;
        //}

        //// Token: 0x06001033 RID: 4147 RVA: 0x0007134C File Offset: 0x0006F54C
        //public bool DeleteStaffEffortDetail(ProjectStaffEffort oneProjectStaffEffort)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  DELETE FROM [PRJ_EffortDetail]  ");
        //	stringBuilder.AppendLine("    WHERE  ");
        //	stringBuilder.AppendLine("         (1 = 1)  ");
        //	stringBuilder.AppendLine("         AND (Effort = @Effort)  ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(oneProjectStaffEffort.ID);
        //	mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	return true;
        //}

        //// Token: 0x06001034 RID: 4148 RVA: 0x00071404 File Offset: 0x0006F604
        //public bool InsertStaffEffortDetail(ProjectStaffEffort oneStaffEffort, bool isInsertEmptyMember)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   INSERT INTO [PRJ_EffortDetail] ");
        //	stringBuilder.AppendLine("              (  ");
        //	stringBuilder.AppendLine("              [Effort]  ");
        //	stringBuilder.AppendLine("              ,[Member]  ");
        //	stringBuilder.AppendLine("              ,[NTAccount]  ");
        //	stringBuilder.AppendLine("              ,[ScheduleEffort]  ");
        //	stringBuilder.AppendLine("              ,[TrainingEffort]  ");
        //	stringBuilder.AppendLine("              ,[ProjectActualEffort]  ");
        //	stringBuilder.AppendLine("              ,[TrainingActualEffort]  ");
        //	stringBuilder.AppendLine("              ,[QualityPer]  ");
        //	stringBuilder.AppendLine("              ,[ScheduleWithQuality]  ");
        //	stringBuilder.AppendLine("              ,[ConvQuality]  ");
        //	stringBuilder.AppendLine("              ,[IsConvQuality]  ");
        //	stringBuilder.AppendLine("              ,[ModQuality]  ");
        //	stringBuilder.AppendLine("              ,[CusEffortConv]  ");
        //	stringBuilder.AppendLine("              ,[KeepLaborEff]  ");
        //	stringBuilder.AppendLine("              ,[IsKeptlabor]  ");
        //	stringBuilder.AppendLine("              ,[PrjEffectiveEff]  ");
        //	stringBuilder.AppendLine("              ,[PrjBonusEff]  ");
        //	stringBuilder.AppendLine("              ,[Notes]  ");
        //	stringBuilder.AppendLine("              ,[RegUser]  ");
        //	stringBuilder.AppendLine("              ,[RegDate]  ");
        //	stringBuilder.AppendLine("              ,[ModUser]  ");
        //	stringBuilder.AppendLine("              ,[ModDate]  ");
        //	stringBuilder.AppendLine("              ,[OriginalScheduleEffort]  ");
        //	stringBuilder.AppendLine("              ,[ExchangedScheduleEffort]  ");
        //	stringBuilder.AppendLine("              ,[OriginalActualEffort]  ");
        //	stringBuilder.AppendLine("              ,[ExchangedActualEffort]  ");
        //	stringBuilder.AppendLine("              ,[TotalEffortWithBonus]  ");
        //	stringBuilder.AppendLine("       ) VALUES ( ");
        //	stringBuilder.AppendLine("                ");
        //	stringBuilder.AppendLine("              @Effort  ");
        //	stringBuilder.AppendLine("              ,@Member  ");
        //	stringBuilder.AppendLine("              ,@NTAccount  ");
        //	stringBuilder.AppendLine("              ,@ScheduleEffort  ");
        //	stringBuilder.AppendLine("              ,@TrainingEffort  ");
        //	stringBuilder.AppendLine("              ,@ProjectActualEffort  ");
        //	stringBuilder.AppendLine("              ,@TrainingActualEffort  ");
        //	stringBuilder.AppendLine("              ,@QualityPer  ");
        //	stringBuilder.AppendLine("              ,@ScheduleWithQuality  ");
        //	stringBuilder.AppendLine("              ,@ConvQuality  ");
        //	stringBuilder.AppendLine("              ,@IsConvQuality  ");
        //	stringBuilder.AppendLine("              ,@ModQuality  ");
        //	stringBuilder.AppendLine("              ,@CusEffortConv  ");
        //	stringBuilder.AppendLine("              ,@KeepLaborEff  ");
        //	stringBuilder.AppendLine("              ,@IsKeptlabor  ");
        //	stringBuilder.AppendLine("              ,@PrjEffectiveEff  ");
        //	stringBuilder.AppendLine("              ,@PrjBonusEff  ");
        //	stringBuilder.AppendLine("              ,@Notes  ");
        //	stringBuilder.AppendLine("              ,@RegUser  ");
        //	stringBuilder.AppendLine("              ,@RegDate  ");
        //	stringBuilder.AppendLine("              ,@ModUser  ");
        //	stringBuilder.AppendLine("              ,@ModDate  ");
        //	stringBuilder.AppendLine("              ,@OriginalScheduleEffort  ");
        //	stringBuilder.AppendLine("              ,@ExchangedScheduleEffort  ");
        //	stringBuilder.AppendLine("              ,@OriginalActualEffort  ");
        //	stringBuilder.AppendLine("              ,@ExchangedActualEffort  ");
        //	stringBuilder.AppendLine("              ,@TotalEffortWithBonus  ");
        //	stringBuilder.AppendLine("              )  ");
        //	stringBuilder.AppendLine("              ;SELECT SCOPE_IDENTITY();   ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	checked
        //	{
        //		int num = oneStaffEffort.Detail.Count - 1;
        //		int i = 0;
        //		while (i <= num)
        //		{
        //			ProjectStaffEffortDetail projectStaffEffortDetail = oneStaffEffort.Detail[i];
        //			bool flag = !isInsertEmptyMember;
        //			if (!flag)
        //			{
        //				goto IL_339;
        //			}
        //			bool flag2 = decimal.Compare(projectStaffEffortDetail.TotalEffortWithBonus, 0m) == 0;
        //			if (!flag2)
        //			{
        //				goto IL_339;
        //			}
        //			IL_7E8:
        //			i++;
        //			continue;
        //			IL_339:
        //			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //			parameters.Clear();
        //			parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(oneStaffEffort.ID);
        //			bool flag3 = projectStaffEffortDetail.Member is cls_CM_Staff_Abridged;
        //			if (flag3)
        //			{
        //				parameters.Add(new SqlParameter("@Member", SqlDbType.NVarChar)).Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(projectStaffEffortDetail.Member, null, "ID", new object[0], null, null, null));
        //			}
        //			else
        //			{
        //				bool flag4 = projectStaffEffortDetail.Member is string;
        //				if (flag4)
        //				{
        //					parameters.Add(new SqlParameter("@Member", SqlDbType.NVarChar)).Value = RuntimeHelpers.GetObjectValue(projectStaffEffortDetail.Member);
        //				}
        //				else
        //				{
        //					parameters.Add(new SqlParameter("@Member", SqlDbType.NVarChar)).Value = "";
        //				}
        //			}
        //			parameters.Add(new SqlParameter("@NTAccount", SqlDbType.NVarChar)).Value = projectStaffEffortDetail.NTAccount;
        //			decimal num2 = 0m;
        //			decimal num3 = 0m;
        //			decimal num4 = 0m;
        //			this.SumTrainingEffort(projectStaffEffortDetail, ref num2, ref num3, ref num4);
        //			parameters.Add(new SqlParameter("@ScheduleEffort", SqlDbType.Decimal)).Value = projectStaffEffortDetail.OriginalScheduleEffort;
        //			parameters.Add(new SqlParameter("@TrainingEffort", SqlDbType.Decimal)).Value = num2;
        //			parameters.Add(new SqlParameter("@ProjectActualEffort", SqlDbType.Decimal)).Value = decimal.Subtract(projectStaffEffortDetail.OriginalActualEffort, num3);
        //			parameters.Add(new SqlParameter("@TrainingActualEffort", SqlDbType.Decimal)).Value = num3;
        //			parameters.Add(new SqlParameter("@QualityPer", SqlDbType.Decimal)).Value = 100;
        //			parameters.Add(new SqlParameter("@OriginalScheduleEffort", SqlDbType.Decimal)).Value = projectStaffEffortDetail.OriginalScheduleEffort;
        //			parameters.Add(new SqlParameter("@ExchangedScheduleEffort", SqlDbType.Decimal)).Value = projectStaffEffortDetail.ExchangedScheduleEffort;
        //			parameters.Add(new SqlParameter("@TotalEffortWithBonus", SqlDbType.Decimal)).Value = projectStaffEffortDetail.TotalEffortWithBonus;
        //			parameters.Add(new SqlParameter("@OriginalActualEffort", SqlDbType.Decimal)).Value = projectStaffEffortDetail.OriginalActualEffort;
        //			parameters.Add(new SqlParameter("@ExchangedActualEffort", SqlDbType.Decimal)).Value = projectStaffEffortDetail.ExchangedActualEffort;
        //			parameters.Add(new SqlParameter("@ScheduleWithQuality", SqlDbType.Decimal)).Value = projectStaffEffortDetail.ScheduleWithQuality;
        //			parameters.Add(new SqlParameter("@ConvQuality", SqlDbType.Decimal)).Value = projectStaffEffortDetail.ConversionQualityEffort;
        //			parameters.Add(new SqlParameter("@IsConvQuality", SqlDbType.Bit)).Value = projectStaffEffortDetail.IsConvQuality;
        //			parameters.Add(new SqlParameter("@ModQuality", SqlDbType.Decimal)).Value = projectStaffEffortDetail.ModifiedQualityEffort;
        //			parameters.Add(new SqlParameter("@CusEffortConv", SqlDbType.Decimal)).Value = projectStaffEffortDetail.CustomerEffortConversion;
        //			parameters.Add(new SqlParameter("@KeepLaborEff", SqlDbType.Decimal)).Value = projectStaffEffortDetail.KeepLaborEffort;
        //			parameters.Add(new SqlParameter("@IsKeptlabor", SqlDbType.Bit)).Value = projectStaffEffortDetail.IsKeptLabor;
        //			parameters.Add(new SqlParameter("@PrjEffectiveEff", SqlDbType.Decimal)).Value = projectStaffEffortDetail.PrjEffectiveEff;
        //			parameters.Add(new SqlParameter("@PrjBonusEff", SqlDbType.Decimal)).Value = projectStaffEffortDetail.PrjBonusEff;
        //			parameters.Add(new SqlParameter("@Notes", SqlDbType.NVarChar)).Value = projectStaffEffortDetail.Notes;
        //			parameters.Add(new SqlParameter("@RegUser", SqlDbType.NVarChar)).Value = projectStaffEffortDetail.RegUser;
        //			parameters.Add(new SqlParameter("@RegDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(projectStaffEffortDetail.RegDate);
        //			parameters.Add(new SqlParameter("@ModUser", SqlDbType.NVarChar)).Value = projectStaffEffortDetail.ModUser;
        //			parameters.Add(new SqlParameter("@ModDate", SqlDbType.NVarChar)).Value = cls_CM_Function.ConvertDateStrAndDate(projectStaffEffortDetail.ModDate);
        //			long value = mod_WMS_Declare.gvObj_Database.DBExecuteSQLReturnID(stringBuilder.ToString(), false);
        //			projectStaffEffortDetail.ID = Conversions.ToString(value);
        //			this.InsertPhaseDetailEffort(projectStaffEffortDetail);
        //			goto IL_7E8;
        //		}
        //		mod_WMS_Declare.rwl.ExitWriteLock();
        //		return true;
        //	}
        //}

        //// Token: 0x06001035 RID: 4149 RVA: 0x00071C1C File Offset: 0x0006FE1C
        //public bool DeletePhaseDetailEffort(ProjectStaffEffort oneStaffEffort)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   DELETE FROM [PRJ_EffortDetailByPhases]  ");
        //	stringBuilder.AppendLine("         WHERE [DetailID] IN (SELECT ID  ");
        //	stringBuilder.AppendLine("                              FROM [PRJ_EffortDetail]  ");
        //	stringBuilder.AppendLine("                              WHERE (1 = 1) ");
        //	stringBuilder.AppendLine("                                    AND ( Effort = @Effort )) ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(oneStaffEffort.ID);
        //	mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	return true;
        //}

        //// Token: 0x06001036 RID: 4150 RVA: 0x00071CE0 File Offset: 0x0006FEE0
        //public bool InsertPhaseDetailEffort(ProjectStaffEffortDetail oneProjectStaffEffortDetail)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   \tINSERT INTO [PRJ_EffortDetailByPhases]\t  ");
        //	stringBuilder.AppendLine("   \t           (\t  ");
        //	stringBuilder.AppendLine("   \t           \t  ");
        //	stringBuilder.AppendLine("   \t           [DetailID]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[PhaseID]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[OriginalBaselinedEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[OriginalScheduleEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[OriginalActualEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[OriginalOvertimeEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[ExchangedBaselinedEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[ExchangedScheduleEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[ExchangedActualEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[ExchangedOvertimeEffort]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[ExchangedRate]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[EffortWithBonus]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[EffortExchangeRate]\t  ");
        //	stringBuilder.AppendLine("   \t           ,[QualityPercent]\t  ");
        //	stringBuilder.AppendLine("   \t    ) VALUES\t(  ");
        //	stringBuilder.AppendLine("   \t           ");
        //	stringBuilder.AppendLine("   \t           @DetailID");
        //	stringBuilder.AppendLine("   \t           ,@PhaseID");
        //	stringBuilder.AppendLine("   \t           ,@OriginalBaselinedEffort");
        //	stringBuilder.AppendLine("   \t           ,@OriginalScheduleEffort");
        //	stringBuilder.AppendLine("   \t           ,@OriginalActualEffort");
        //	stringBuilder.AppendLine("   \t           ,@OriginalOvertimeEffort");
        //	stringBuilder.AppendLine("   \t           ,@ExchangedBaselinedEffort");
        //	stringBuilder.AppendLine("   \t           ,@ExchangedScheduleEffort");
        //	stringBuilder.AppendLine("   \t           ,@ExchangedActualEffort");
        //	stringBuilder.AppendLine("   \t           ,@ExchangedOvertimeEffort");
        //	stringBuilder.AppendLine("   \t           ,@ExchangedRate");
        //	stringBuilder.AppendLine("   \t           ,@EffortWithBonus");
        //	stringBuilder.AppendLine("   \t           ,@EffortExchangeRate");
        //	stringBuilder.AppendLine("   \t           ,@QualityPercent");
        //	stringBuilder.AppendLine("   \t           )     ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	checked
        //	{
        //		int num = oneProjectStaffEffortDetail.PhaseDetailEffort.Count - 1;
        //		for (int i = 0; i <= num; i++)
        //		{
        //			object obj = oneProjectStaffEffortDetail.PhaseDetailEffort[i];
        //			EffortByPhaseData effortByPhaseData = (obj != null) ? ((EffortByPhaseData)obj) : default(EffortByPhaseData);
        //			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //			parameters.Clear();
        //			parameters.Add(new SqlParameter("@DetailID", SqlDbType.NVarChar)).Value = oneProjectStaffEffortDetail.ID;
        //			parameters.Add(new SqlParameter("@PhaseID", SqlDbType.SmallInt)).Value = effortByPhaseData.EffortPhase;
        //			parameters.Add(new SqlParameter("@OriginalBaselinedEffort", SqlDbType.Decimal)).Value = effortByPhaseData.OriginalBaselinedEffort;
        //			parameters.Add(new SqlParameter("@OriginalScheduleEffort", SqlDbType.Decimal)).Value = effortByPhaseData.OriginalScheduleEffort;
        //			parameters.Add(new SqlParameter("@OriginalActualEffort", SqlDbType.Decimal)).Value = effortByPhaseData.OriginalActualEffort;
        //			parameters.Add(new SqlParameter("@OriginalOvertimeEffort", SqlDbType.Decimal)).Value = effortByPhaseData.OriginalOvertimeEffort;
        //			parameters.Add(new SqlParameter("@ExchangedBaselinedEffort", SqlDbType.Decimal)).Value = effortByPhaseData.ExchangedBaselinedEffort;
        //			parameters.Add(new SqlParameter("@EffortWithBonus", SqlDbType.Decimal)).Value = effortByPhaseData.EffortWithBonus;
        //			parameters.Add(new SqlParameter("@ExchangedScheduleEffort", SqlDbType.Decimal)).Value = effortByPhaseData.ExchangedScheduleEffort;
        //			parameters.Add(new SqlParameter("@ExchangedActualEffort", SqlDbType.Decimal)).Value = effortByPhaseData.ExchangedActualEffort;
        //			parameters.Add(new SqlParameter("@ExchangedOvertimeEffort", SqlDbType.Decimal)).Value = effortByPhaseData.ExchangedOvertimeEffort;
        //			parameters.Add(new SqlParameter("@ExchangedRate", SqlDbType.Decimal)).Value = effortByPhaseData.BonusEffortRate;
        //			parameters.Add(new SqlParameter("@EffortExchangeRate", SqlDbType.Decimal)).Value = effortByPhaseData.EffortExchangedRate;
        //			parameters.Add(new SqlParameter("@QualityPercent", SqlDbType.Int)).Value = effortByPhaseData.QualityPercent;
        //			mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //		}
        //		mod_WMS_Declare.rwl.ExitWriteLock();
        //		return true;
        //	}
        //}

        //// Token: 0x06001037 RID: 4151 RVA: 0x00072118 File Offset: 0x00070318
        //public bool DeleteProjectEffortDetail(ProjectStaffEffort OneEffort)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  DELETE FROM [PRJ_EffortProjectDetail] ");
        //	stringBuilder.AppendLine("    WHERE  ");
        //	stringBuilder.AppendLine("         (1 = 1)  ");
        //	stringBuilder.AppendLine("         AND (Effort = @Effort)  ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(OneEffort.ID);
        //	mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	return true;
        //}

        //// Token: 0x06001038 RID: 4152 RVA: 0x000721D0 File Offset: 0x000703D0
        //public bool InsertProjectEffortDetail(ProjectStaffEffort OneEffort)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   INSERT INTO [PRJ_EffortProjectDetail]");
        //	stringBuilder.AppendLine("              (  ");
        //	stringBuilder.AppendLine("              [Effort]  ");
        //	stringBuilder.AppendLine("              ,[Leader]  ");
        //	stringBuilder.AppendLine("              ,[ManagementRate]  ");
        //	stringBuilder.AppendLine("              ,[Notes]  ");
        //	stringBuilder.AppendLine("              ,[SharedManagementRate]  ");
        //	stringBuilder.AppendLine("              ,[LeaderWorkingPercent]  ");
        //	stringBuilder.AppendLine("              ,[ActualManagementEffort]  ");
        //	stringBuilder.AppendLine("       ) VALUES ( ");
        //	stringBuilder.AppendLine("               ");
        //	stringBuilder.AppendLine("              @Effort  ");
        //	stringBuilder.AppendLine("              ,@Leader  ");
        //	stringBuilder.AppendLine("              ,@ManagementRate  ");
        //	stringBuilder.AppendLine("              ,@Notes  ");
        //	stringBuilder.AppendLine("              ,@SharedManagementRate  ");
        //	stringBuilder.AppendLine("              ,@LeaderWorkingPercent  ");
        //	stringBuilder.AppendLine("              ,@ActualManagementEffort  ");
        //	stringBuilder.AppendLine("              )  ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	bool flag = OneEffort.ProjectDetail != null && OneEffort.ProjectDetail.Count > 0;
        //	checked
        //	{
        //		if (flag)
        //		{
        //			int num = OneEffort.ProjectDetail.Count - 1;
        //			for (int i = 0; i <= num; i++)
        //			{
        //				cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //				parameters.Clear();
        //				parameters.Add(new SqlParameter("@Effort", SqlDbType.BigInt)).Value = long.Parse(OneEffort.ID);
        //				parameters.Add(new SqlParameter("@Leader", SqlDbType.NVarChar)).Value = OneEffort.ProjectDetail[i].Leader.ID;
        //				parameters.Add(new SqlParameter("@ManagementRate", SqlDbType.Decimal)).Value = decimal.Multiply(OneEffort.ProjectDetail[i].SharedManagementRate, decimal.Divide(decimal.Subtract(100m, OneEffort.ProjectDetail[i].LeaderWorkingPercent), 100m));
        //				parameters.Add(new SqlParameter("@Notes", SqlDbType.NVarChar)).Value = OneEffort.ProjectDetail[i].Notes;
        //				parameters.Add(new SqlParameter("@SharedManagementRate", SqlDbType.Decimal)).Value = OneEffort.ProjectDetail[i].SharedManagementRate;
        //				parameters.Add(new SqlParameter("@LeaderWorkingPercent", SqlDbType.Decimal)).Value = OneEffort.ProjectDetail[i].LeaderWorkingPercent;
        //				parameters.Add(new SqlParameter("@ActualManagementEffort", SqlDbType.Decimal)).Value = OneEffort.ProjectDetail[i].ActualManagementEffort;
        //				mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //			}
        //		}
        //		mod_WMS_Declare.rwl.ExitWriteLock();
        //		return true;
        //	}
        //}

        //// Token: 0x06001039 RID: 4153 RVA: 0x000724D0 File Offset: 0x000706D0
        //public bool DeleteStaffEffort(ProjectStaffEffort OneBonus)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("   DELETE FROM [PRJ_Effort] ");
        //	stringBuilder.AppendLine("    WHERE  ");
        //	stringBuilder.AppendLine("         (1 = 1)  ");
        //	stringBuilder.AppendLine("         AND (ID = @ID)  ");
        //	stringBuilder.AppendLine("         AND (IsConfirmed = 0)  ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@ID", SqlDbType.BigInt)).Value = long.Parse(OneBonus.ID);
        //	mod_WMS_Declare.gvObj_Database.DBBeginTrans(IsolationLevel.Serializable);
        //	mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //	mod_WMS_Declare.gvObj_Database.DBCommitTrans();
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	return true;
        //}

        //// Token: 0x0600103A RID: 4154 RVA: 0x000725B0 File Offset: 0x000707B0
        //public string MakeGetTaskInfoSQL()
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT  ");
        //	stringBuilder.AppendLine("  \tET1.[TaskEnterpriseText1] [Modules]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseDate1] [ScheduleDeliveryDate]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseDate2] [ActualDeliveryDate]  ");
        //	stringBuilder.AppendLine("  \t,T1.TaskUniqueID ");
        //	stringBuilder.AppendLine("  \t,T1.TaskID ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskName]  ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskStart] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskFinish] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskWork]/60000 [TaskWork] -- (h)");
        //	stringBuilder.AppendLine("  \t,T1.[TaskDuration]/4800 [TaskDuration] -- (days) ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskBaselineStart] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskBaselineFinish] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskBaselineWork]/60000 [TaskBaselineWork] -- (h)");
        //	stringBuilder.AppendLine("  \t,T1.[TaskActualStart] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskActualFinish] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskActualWork]/60000 [TaskActualWork] -- (h)");
        //	stringBuilder.AppendLine("  \t,T1.[TaskActualOvertimeWorkProtected]/60000 [TaskActualOvertimeWork] -- (h)");
        //	stringBuilder.AppendLine("  \t,T1.[TaskActualDuration]/4800 [TaskActualDuration] -- (days)");
        //	stringBuilder.AppendLine("  \t,T1.[TaskPercentWorkComplete] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskRemainingWork]/60000 [TaskRemainingWork] -- (h)");
        //	stringBuilder.AppendLine("  \t,T1.[TaskSummary] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskParentUID] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskOutlineLevel] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskOutlineNumber] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskWBS] ");
        //	stringBuilder.AppendLine("  \t,T1.[TaskStop] ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseText3] [PercentEffortVariance]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseText2] [PercentScheduleVariance]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber1] [LOC_New_Estimate]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber4] [LOC_New_Actual]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber8] [LOC_Reuse_Estimate]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber5] [LOC_Reuse_Actual]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber13] [LOC_Comment]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber10] [TestCase_Estimate]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber6] [TestCase_Actual]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber7] [Defect_SelfTest]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber2] [QnA_SendToCus]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber3] [QnA_InAccurate]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseText4] [TaskClass]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber14] [DesignNoOfPageEstimate]  ");
        //	stringBuilder.AppendLine("  \t,ET1.[TaskEnterpriseNumber15] [DesignNoOfPageActual]  ");
        //	stringBuilder.AppendLine("  FROM  ");
        //	stringBuilder.AppendLine("  \t[MSP_VIEW_PROJ_TASKS_STD] T1 ");
        //	stringBuilder.AppendLine("  \t, [MSP_VIEW_PROJ_TASKS_ENT] ET1 ");
        //	stringBuilder.AppendLine("  WHERE  ");
        //	stringBuilder.AppendLine("  \t(1=1) ");
        //	return stringBuilder.ToString();
        //}

        //// Token: 0x0600103B RID: 4155 RVA: 0x00072808 File Offset: 0x00070A08
        //public static string RemovePercent(string InputStr)
        //{
        //	bool flag = InputStr == null || InputStr == DBNull.Value;
        //	string result;
        //	if (flag)
        //	{
        //		result = "0";
        //	}
        //	else
        //	{
        //		int num = InputStr.IndexOf("%");
        //		bool flag2 = num != -1;
        //		if (flag2)
        //		{
        //			result = InputStr.Remove(num, 1);
        //		}
        //		else
        //		{
        //			result = "0";
        //		}
        //	}
        //	return result;
        //}

        //// Token: 0x0600103C RID: 4156 RVA: 0x00072868 File Offset: 0x00070A68
        //public ArrayList GetTimephasedData(cls_CM_ProjectSchedule2007 Project, DateTime StartDate, DateTime EndDate, cls_CM_ResourceOnServer2007 Resource = null)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT DISTINCT           ");
        //	stringBuilder.AppendLine("    TP.PROJ_NAME                            AS C1  ");
        //	stringBuilder.AppendLine("    ,ENTRES.ResourceName                    AS C2  ");
        //	stringBuilder.AppendLine("    ,TASK.TaskName                          AS C3  ");
        //	stringBuilder.AppendLine("    ,TP1.[ProjectUniqueID]                  AS C4  ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentUniqueID]               AS C5  ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeStart]              AS C6  ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeFinish]             AS C7  ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeActualOvertimeWork] AS C9  ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeActualWork]         AS C10 ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeBaselineWork]       AS C12 ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeWork]               AS C19 ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeActualOvertimeWorkProtected]  AS C21 ");
        //	stringBuilder.AppendLine("  FROM          ");
        //	stringBuilder.AppendLine("    ( SELECT DISTINCT          ");
        //	stringBuilder.AppendLine("    TP.[WPROJ_ID]          ");
        //	stringBuilder.AppendLine("    ,TP.[ProjectUniqueID]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentUniqueID]          ");
        //	stringBuilder.AppendLine("       /* ,TP.[AssignmentTimeStart]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeFinish]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualOvertimeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeBaselineWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeCumulativeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeOvertimeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeRegularWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualWorkProtected]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualOvertimeWorkProtected]*/          ");
        //	stringBuilder.AppendLine("  \tFROM [MSP_VIEW_PROJ_ASSN_TP_BY_DAY]    TP          ");
        //	stringBuilder.AppendLine("  \tWHERE           ");
        //	stringBuilder.AppendLine("    1 = 1          ");
        //	stringBuilder.AppendLine("        , TP.[WPROJ_ID] = @WPROJ_ID        ");
        //	stringBuilder.AppendLine("    )\tTEMP1          ");
        //	stringBuilder.AppendLine("    , MSP_VIEW_PROJ_ASSN_STD    \tASS          ");
        //	stringBuilder.AppendLine("    , MSP_VIEW_PROJ_RES_STD      ENTRES          ");
        //	stringBuilder.AppendLine("    , MSP_VIEW_PROJ_TASKS_STD    \tTASK          ");
        //	stringBuilder.AppendLine("    , MSP_WEB_PROJECTS      \tWEBPJ          ");
        //	stringBuilder.AppendLine("    ,[MSP_VIEW_PROJ_ASSN_TP_BY_DAY]    TP1          ");
        //	stringBuilder.AppendLine("  WHERE           ");
        //	stringBuilder.AppendLine("  \t1 = 1          ");
        //	stringBuilder.AppendLine("  \tAND ASS.AssignmentUniqueID = TEMP1.AssignmentUniqueID          ");
        //	stringBuilder.AppendLine("  \tAND ASS.WPROJ_ID = TEMP1.WPROJ_ID          ");
        //	stringBuilder.AppendLine("  \tAND ENTRES.ResourceEnterpriseUniqueID = ASS.ResourceEnterpriseUniqueID           ");
        //	stringBuilder.AppendLine("  \tAND TASK.TaskUniqueID = ASS.TaskUniqueID          ");
        //	stringBuilder.AppendLine("  \tAND TP.WPROJ_ID = TEMP1.WPROJ_ID           ");
        //	stringBuilder.AppendLine("  \tAND TASK.[TaskUniqueID] = ASS.[TaskUniqueID]          ");
        //	stringBuilder.AppendLine("  \tAND TASK.WPROJ_ID = ASS.WPROJ_ID          ");
        //	stringBuilder.AppendLine("  \tAND TP1.[WPROJ_ID] = TEMP1.[WPROJ_ID]          ");
        //	stringBuilder.AppendLine("  \tAND TP1.[AssignmentUniqueID] = TEMP1.[AssignmentUniqueID]          ");
        //	stringBuilder.AppendLine("  \tAND TP1.[AssignmentTimeStart] >= @StartDate         ");
        //	stringBuilder.AppendLine("  \tAND TP1.[AssignmentTimeStart] <= @EndDate         ");
        //	bool flag = Resource != null;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("  \tAND ENTRES.ResourceEnterpriseUniqueID = @ResourceEnterpriseUniqueID          ");
        //	}
        //	stringBuilder.AppendLine("  --\tAND TEMP1.[AssignmentTimeBaselineWork] IS NOT NULL          ");
        //	stringBuilder.AppendLine("  ORDER BY 1,2,3,4,5,6,7,8          ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = Project.ID;
        //	bool flag2 = Resource != null;
        //	if (flag2)
        //	{
        //		parameters.Add(new SqlParameter("@ResourceEnterpriseUniqueID", SqlDbType.Int)).Value = Resource.EnterpriseID;
        //	}
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.Int)).Value = Project.ID;
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.Int)).Value = Project.ID;
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag3 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag3)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer = new cls_CM_ResourceOnServer2007();
        //					cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer2 = cls_CM_ResourceOnServer;
        //					object obj2 = dataRow["C1"];
        //					cls_CM_ResourceOnServer2.ID = ((obj2 != null) ? ((Guid)obj2) : default(Guid));
        //					cls_CM_ResourceOnServer.Name = Conversions.ToString(dataRow["C2"]);
        //					cls_CM_ResourceOnServer.Account = Conversions.ToString(dataRow["C3"]);
        //					arrayList.Add(cls_CM_ResourceOnServer);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        //// Token: 0x0600103D RID: 4157 RVA: 0x00072D24 File Offset: 0x00070F24
        //public ArrayList GetSummaryTimephasedData(cls_CM_ProjectSchedule2007 Project, DateTime StartDate, DateTime EndDate, cls_CM_ResourceOnServer2007 Resource = null)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT         ");
        //	stringBuilder.AppendLine("    TEMP2.PROJ_NAME                            AS C1  ");
        //	stringBuilder.AppendLine("    ,TEMP2.ResourceName                    AS C2  ");
        //	stringBuilder.AppendLine("    ,TEMP2.[ProjectUniqueID]                  AS C4  ");
        //	stringBuilder.AppendLine("    ,SUM(TEMP2.[AssignmentTimeActualWork])         AS C10 ");
        //	stringBuilder.AppendLine("    ,SUM(TEMP2.[AssignmentTimeBaselineWork])       AS C12 ");
        //	stringBuilder.AppendLine("    ,SUM(TEMP2.[AssignmentTimeWork])               AS C19 ");
        //	stringBuilder.AppendLine("    ,SUM(TEMP2.[AssignmentTimeActualOvertimeWorkProtected])  AS C21 ");
        //	stringBuilder.AppendLine("    ,TEMP2.ResourceEnterpriseUniqueID           AS C22 ");
        //	stringBuilder.AppendLine("  FROM          ");
        //	stringBuilder.AppendLine(" ( SELECT DISTINCT        ");
        //	stringBuilder.AppendLine("    WEBPJ.PROJ_NAME                      ");
        //	stringBuilder.AppendLine("    ,ENTRES.ResourceName                   ");
        //	stringBuilder.AppendLine("    ,TP1.[ProjectUniqueID]                    ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentUniqueID]              ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeStart]             ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeFinish]            ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeActualWork]         ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeBaselineWork]       ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeWork]               ");
        //	stringBuilder.AppendLine("    ,TP1.[AssignmentTimeActualOvertimeWorkProtected]  ");
        //	stringBuilder.AppendLine("    ,ENTRES.ResourceEnterpriseUniqueID           ");
        //	stringBuilder.AppendLine("  FROM          ");
        //	stringBuilder.AppendLine("    ( SELECT DISTINCT          ");
        //	stringBuilder.AppendLine("    TP.[WPROJ_ID]          ");
        //	stringBuilder.AppendLine("    ,TP.[ProjectUniqueID]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentUniqueID]          ");
        //	stringBuilder.AppendLine("       /* ,TP.[AssignmentTimeStart]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeFinish]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualOvertimeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeBaselineWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeCumulativeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeOvertimeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeRegularWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeWork]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualWorkProtected]          ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualOvertimeWorkProtected]*/          ");
        //	stringBuilder.AppendLine("  \tFROM [MSP_VIEW_PROJ_ASSN_TP_BY_DAY]    TP          ");
        //	stringBuilder.AppendLine("  \tWHERE           ");
        //	stringBuilder.AppendLine("    1 = 1          ");
        //	bool flag = Project != null;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("        AND TP.[WPROJ_ID] = @WPROJ_ID        ");
        //	}
        //	stringBuilder.AppendLine("    )\tTEMP1          ");
        //	stringBuilder.AppendLine("    , MSP_VIEW_PROJ_ASSN_STD    \tASS          ");
        //	stringBuilder.AppendLine("    , MSP_VIEW_PROJ_RES_STD      ENTRES          ");
        //	stringBuilder.AppendLine("    , MSP_VIEW_PROJ_TASKS_STD    \tTASK          ");
        //	stringBuilder.AppendLine("    , MSP_WEB_PROJECTS      \tWEBPJ          ");
        //	stringBuilder.AppendLine("    ,[MSP_VIEW_PROJ_ASSN_TP_BY_DAY]    TP1          ");
        //	stringBuilder.AppendLine("  WHERE           ");
        //	stringBuilder.AppendLine("  \t1 = 1          ");
        //	stringBuilder.AppendLine("  \tAND ASS.AssignmentUniqueID = TEMP1.AssignmentUniqueID          ");
        //	stringBuilder.AppendLine("  \tAND ASS.WPROJ_ID = TEMP1.WPROJ_ID          ");
        //	stringBuilder.AppendLine("  \tAND ENTRES.ResourceEnterpriseUniqueID = ASS.ResourceEnterpriseUniqueID           ");
        //	stringBuilder.AppendLine("  \tAND ASS.ResourceEnterpriseUniqueID <> -1          ");
        //	stringBuilder.AppendLine("  \tAND TASK.TaskUniqueID = ASS.TaskUniqueID          ");
        //	stringBuilder.AppendLine("  \tAND WEBPJ.WPROJ_ID = TEMP1.WPROJ_ID           ");
        //	stringBuilder.AppendLine("  \tAND TASK.[TaskUniqueID] = ASS.[TaskUniqueID]          ");
        //	stringBuilder.AppendLine("  \tAND TASK.WPROJ_ID = ASS.WPROJ_ID          ");
        //	stringBuilder.AppendLine("  \tAND TP1.[WPROJ_ID] = TEMP1.[WPROJ_ID]          ");
        //	stringBuilder.AppendLine("  \tAND TP1.[AssignmentUniqueID] = TEMP1.[AssignmentUniqueID]          ");
        //	stringBuilder.AppendLine("  \tAND TP1.[AssignmentTimeStart] >= @StartDate         ");
        //	stringBuilder.AppendLine("  \tAND TP1.[AssignmentTimeStart] <= @EndDate         ");
        //	bool flag2 = Resource != null;
        //	if (flag2)
        //	{
        //		stringBuilder.AppendLine("  \tAND ENTRES.ResourceEnterpriseUniqueID = @ResourceEnterpriseUniqueID          ");
        //	}
        //	stringBuilder.AppendLine("  --\tAND TEMP1.[AssignmentTimeBaselineWork] IS NOT NULL          ");
        //	stringBuilder.AppendLine("  ) TEMP2  ");
        //	stringBuilder.AppendLine("  \tGROUP BY          ");
        //	stringBuilder.AppendLine("    TEMP2.PROJ_NAME  ");
        //	stringBuilder.AppendLine("    ,TEMP2.[ProjectUniqueID]    ");
        //	stringBuilder.AppendLine("    ,TEMP2.ResourceEnterpriseUniqueID    ");
        //	stringBuilder.AppendLine("    ,TEMP2.ResourceName   ");
        //	stringBuilder.AppendLine("  \tORDER BY          ");
        //	stringBuilder.AppendLine("    TEMP2.PROJ_NAME  ");
        //	stringBuilder.AppendLine("    ,TEMP2.ResourceName   ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	bool flag3 = Project != null;
        //	if (flag3)
        //	{
        //		parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = Project.ID;
        //	}
        //	bool flag4 = Resource != null;
        //	if (flag4)
        //	{
        //		parameters.Add(new SqlParameter("@ResourceEnterpriseUniqueID", SqlDbType.Int)).Value = Resource.EnterpriseID;
        //	}
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.DateTime)).Value = StartDate.ToString("yyy-MM-dd 00:00:00");
        //	parameters.Add(new SqlParameter("@EndDate", SqlDbType.DateTime)).Value = EndDate.ToString("yyy-MM-dd 00:00:00");
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag5 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag5)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer = new cls_CM_ResourceOnServer2007();
        //					cls_CM_ResourceOnServer.Name = Conversions.ToString(dataRow["C2"]);
        //					cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer2 = cls_CM_ResourceOnServer;
        //					object obj2 = dataRow["C22"];
        //					cls_CM_ResourceOnServer2.EnterpriseID = ((obj2 != null) ? ((Guid)obj2) : default(Guid));
        //					cls_CM_ResourceOnServer.BaselinedEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C12"])) ? 0 : dataRow["C12"]);
        //					cls_CM_ResourceOnServer.ScheduleEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C19"])) ? 0 : dataRow["C19"]);
        //					cls_CM_ResourceOnServer.ActualEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C10"])) ? 0 : dataRow["C10"]);
        //					cls_CM_ResourceOnServer.OvertimeEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C21"])) ? 0 : dataRow["C21"]);
        //					arrayList.Add(cls_CM_ResourceOnServer);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        //// Token: 0x0600103E RID: 4158 RVA: 0x000733B8 File Offset: 0x000715B8
        //public ArrayList GetTaskSummaryTimephasedData(cls_CM_ProjectSchedule2007 Project, DateTime StartDate, DateTime EndDate, cls_CM_ResourceOnServer2007 Resource = null)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT      ");
        //	stringBuilder.AppendLine("  \tTEMP.[WPROJ_ID]             C1 ");
        //	stringBuilder.AppendLine("  \t,TEMP.[TaskUniqueID]        C2 ");
        //	stringBuilder.AppendLine("  \t,TEMP.[ResourceName]        C3 ");
        //	stringBuilder.AppendLine("  \t,SUM(ISNULL(TEMP.[AssignmentTimeBaselineWork],0))       C4 ");
        //	stringBuilder.AppendLine("  \t,SUM(ISNULL(TEMP.[AssignmentTimeWork],0))               C5 ");
        //	stringBuilder.AppendLine("  \t,SUM(ISNULL(TEMP.[AssignmentTimeActualWork],0))         C6 ");
        //	stringBuilder.AppendLine("  \t,SUM(ISNULL(TEMP.[AssignmentTimeActualOvertimeWork],0)) C7 ");
        //	stringBuilder.AppendLine("  \t,TEMP.[ResourceNTAccount]        C8 ");
        //	stringBuilder.AppendLine("  \t,TEMP.[IsNonProjectEffort]        C9 ");
        //	stringBuilder.AppendLine("  \t,TEMP.[TaskClass]        C10 ");
        //	stringBuilder.AppendLine("  \t,TEMP.[TaskDifficulty]        C11 ");
        //	stringBuilder.AppendLine("  FROM      ");
        //	stringBuilder.AppendLine("  --Lay thong tin Assignment      ");
        //	stringBuilder.AppendLine("  (      ");
        //	stringBuilder.AppendLine(this.GetTaskDetailTimephasedDataSQL(Project).ToString());
        //	bool flag = Resource != null;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("  \tAND ENT_RES.ResourceEnterpriseUniqueID = @ResourceEnterpriseUniqueID          ");
        //	}
        //	stringBuilder.AppendLine("  ) TEMP      ");
        //	stringBuilder.AppendLine("  GROUP BY       ");
        //	stringBuilder.AppendLine("  \tTEMP.[WPROJ_ID]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[TaskUniqueID]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[ResourceName]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[ResourceNTAccount]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[IsNonProjectEffort]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[TaskClass]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[TaskDifficulty]      ");
        //	stringBuilder.AppendLine("  ORDER BY       ");
        //	stringBuilder.AppendLine("  \tTEMP.[TaskUniqueID]      ");
        //	stringBuilder.AppendLine("  \t,TEMP.[ResourceName]      ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	bool flag2 = Project != null;
        //	if (flag2)
        //	{
        //		parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = Project.ID;
        //	}
        //	bool flag3 = Resource != null;
        //	if (flag3)
        //	{
        //		parameters.Add(new SqlParameter("@ResourceEnterpriseUniqueID", SqlDbType.Int)).Value = Resource.EnterpriseID;
        //	}
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.DateTime)).Value = StartDate.ToString("yyy-MM-dd 00:00:00");
        //	parameters.Add(new SqlParameter("@EndDate", SqlDbType.DateTime)).Value = EndDate.ToString("yyy-MM-dd 00:00:00");
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag4 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	checked
        //	{
        //		if (flag4)
        //		{
        //			using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //			{
        //				try
        //				{
        //					foreach (object obj in dataTable.Rows)
        //					{
        //						DataRow dataRow = (DataRow)obj;
        //						TaskInfo taskInfo = default(TaskInfo);
        //						taskInfo.ID = Conversions.ToInteger(dataRow["C2"]);
        //						taskInfo.ProjectID = Conversions.ToInteger(dataRow["C1"]);
        //						taskInfo.ResourceName = Conversions.ToString(dataRow["C3"]);
        //						taskInfo.BaselinedEffort = Conversions.ToDecimal(dataRow["C4"]);
        //						taskInfo.ScheduleEffort = Conversions.ToDecimal(dataRow["C5"]);
        //						taskInfo.ActualEffort = Conversions.ToDecimal(dataRow["C6"]);
        //						taskInfo.OvertimeEffort = Conversions.ToDecimal(dataRow["C7"]);
        //						taskInfo.ResourceNTAccount = Conversions.ToString(dataRow["C8"]);
        //						bool flag5 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C9"])) || Operators.ConditionalCompareObjectEqual(dataRow["C9"], 0, false);
        //						if (flag5)
        //						{
        //							taskInfo.Phase = TaskPhase.Others;
        //						}
        //						else
        //						{
        //							bool flag6 = Operators.ConditionalCompareObjectEqual(dataRow["C9"], 1, false);
        //							if (flag6)
        //							{
        //								taskInfo.Phase = TaskPhase.Training;
        //							}
        //						}
        //						bool flag7 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C10"])) || Operators.ConditionalCompareObjectEqual(dataRow["C10"], "", false);
        //						if (flag7)
        //						{
        //							taskInfo.Phase = TaskPhase.Others;
        //						}
        //						else
        //						{
        //							taskInfo.Phase = TaskPhase.Others;
        //							int num = cls_CM_Function.TaskPhaseShortName.Length - 1;
        //							for (int i = 0; i <= num; i++)
        //							{
        //								bool flag8 = Operators.ConditionalCompareObjectEqual(cls_CM_Function.TaskPhaseShortName[i], dataRow["C10"], false);
        //								if (flag8)
        //								{
        //									taskInfo.Phase = (TaskPhase)i;
        //									break;
        //								}
        //							}
        //						}
        //						bool flag9 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["C11"])) || Operators.ConditionalCompareObjectEqual(dataRow["C11"], 0, false);
        //						if (flag9)
        //						{
        //							taskInfo.Difficulty = 1m;
        //						}
        //						else
        //						{
        //							taskInfo.Difficulty = Conversions.ToDecimal(dataRow["C11"]);
        //						}
        //						bool flag10 = taskInfo.Phase == TaskPhase.DeductedEffort;
        //						if (flag10)
        //						{
        //							taskInfo.BaselinedEffort = decimal.Negate(taskInfo.BaselinedEffort);
        //						}
        //						arrayList.Add(taskInfo);
        //					}
        //				}
        //				finally
        //				{
        //					IEnumerator enumerator;
        //					if (enumerator is IDisposable)
        //					{
        //						(enumerator as IDisposable).Dispose();
        //					}
        //				}
        //			}
        //		}
        //		return arrayList;
        //	}
        //}

        //// Token: 0x0600103F RID: 4159 RVA: 0x00073964 File Offset: 0x00071B64
        //public ArrayList GetTaskDetailTimephasedData(DateTime StartDate, DateTime EndDate, cls_CM_ProjectSchedule2007 Project = null, cls_CM_ResourceOnServer2007 Resource = null)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	cls_CM_Staff_Abridged cls_CM_Staff_Abridged = new cls_CM_Staff_Abridged();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine(this.GetTaskDetailTimephasedDataSQL(Project).ToString());
        //	bool flag = Resource != null;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("  \tAND ENT_RES.ResourceEnterpriseUniqueID = @ResourceEnterpriseUniqueID          ");
        //	}
        //	stringBuilder.AppendLine("  ORDER BY       ");
        //	stringBuilder.AppendLine("    TP.[WPROJ_ID]      ");
        //	stringBuilder.AppendLine("    ,ENT_RES.[ResourceName]      ");
        //	stringBuilder.AppendLine("    ,TSK.[TaskUniqueID]      ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	bool flag2 = Project != null;
        //	if (flag2)
        //	{
        //		parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = Project.ID;
        //	}
        //	bool flag3 = Resource != null;
        //	if (flag3)
        //	{
        //		parameters.Add(new SqlParameter("@ResourceEnterpriseUniqueID", SqlDbType.Int)).Value = Resource.EnterpriseID;
        //	}
        //	parameters.Add(new SqlParameter("@StartDate", SqlDbType.DateTime)).Value = StartDate.ToString("yyy-MM-dd 00:00:00");
        //	parameters.Add(new SqlParameter("@EndDate", SqlDbType.DateTime)).Value = EndDate.ToString("yyy-MM-dd 00:00:00");
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag4 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	checked
        //	{
        //		if (flag4)
        //		{
        //			using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //			{
        //				try
        //				{
        //					foreach (object obj in dataTable.Rows)
        //					{
        //						DataRow dataRow = (DataRow)obj;
        //						TaskInfo taskInfo = new TaskInfo
        //						{
        //							ID = Conversions.ToInteger(dataRow["TaskUniqueID"]),
        //							Name = Conversions.ToString(dataRow["TaskName"]),
        //							ModuleName = Conversions.ToString(dataRow["Modules"]),
        //							ProjectID = Conversions.ToInteger(dataRow["WPROJ_ID"]),
        //							ResourceNTAccount = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ResourceNTAccount"])) ? 0 : dataRow["ResourceNTAccount"])
        //						};
        //						string[] array = taskInfo.ResourceNTAccount.Split(new char[]
        //						{
        //							'\\'
        //						});
        //						bool flag5 = array != null && array.Length == 2;
        //						if (flag5)
        //						{
        //							ArrayList arrayList2 = cls_CM_Staff_Abridged.fncG_CM_GetStaffList("", array[1], "", "", "", "", false, "", false);
        //							bool flag6 = arrayList2 != null && arrayList2.Count > 0;
        //							if (flag6)
        //							{
        //								taskInfo.ResourceName = Conversions.ToString(NewLateBinding.LateGet(arrayList2[0], null, "FullName", new object[0], null, null, null));
        //							}
        //							else
        //							{
        //								taskInfo.ResourceName = Conversions.ToString(dataRow["ResourceName"]);
        //							}
        //						}
        //						else
        //						{
        //							taskInfo.ResourceName = Conversions.ToString(dataRow["ResourceName"]);
        //						}
        //						taskInfo.BaselinedEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeBaselineWork"])) ? 0 : dataRow["AssignmentTimeBaselineWork"]);
        //						taskInfo.ScheduleEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeWork"])) ? 0 : dataRow["AssignmentTimeWork"]);
        //						taskInfo.ActualEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeActualWork"])) ? 0 : dataRow["AssignmentTimeActualWork"]);
        //						taskInfo.OvertimeEffort = Conversions.ToDecimal(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeActualOvertimeWork"])) ? 0 : dataRow["AssignmentTimeActualOvertimeWork"]);
        //						taskInfo.StartDate = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeStart"])) ? 0 : dataRow["AssignmentTimeStart"]);
        //						taskInfo.FinishDate = Conversions.ToString(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AssignmentTimeFinish"])) ? 0 : dataRow["AssignmentTimeFinish"]);
        //						bool flag7 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsNonProjectEffort"])) || Operators.ConditionalCompareObjectEqual(dataRow["IsNonProjectEffort"], 0, false);
        //						if (flag7)
        //						{
        //							taskInfo.Phase = TaskPhase.Others;
        //						}
        //						else
        //						{
        //							bool flag8 = Operators.ConditionalCompareObjectEqual(dataRow["IsNonProjectEffort"], 1, false);
        //							if (flag8)
        //							{
        //								taskInfo.Phase = TaskPhase.Training;
        //							}
        //						}
        //						bool flag9 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaskDifficulty"])) || Operators.ConditionalCompareObjectEqual(dataRow["TaskDifficulty"], 0, false);
        //						if (flag9)
        //						{
        //							taskInfo.Difficulty = 1m;
        //						}
        //						else
        //						{
        //							taskInfo.Difficulty = Conversions.ToDecimal(dataRow["TaskDifficulty"]);
        //						}
        //						bool flag10 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaskClass"])) || Operators.ConditionalCompareObjectEqual(dataRow["TaskClass"], "", false);
        //						if (flag10)
        //						{
        //							taskInfo.Phase = TaskPhase.Others;
        //						}
        //						else
        //						{
        //							taskInfo.Phase = TaskPhase.Others;
        //							int num = cls_CM_Function.TaskPhaseShortName.Length - 1;
        //							for (int i = 0; i <= num; i++)
        //							{
        //								bool flag11 = Operators.ConditionalCompareObjectEqual(cls_CM_Function.TaskPhaseShortName[i], dataRow["TaskClass"], false);
        //								if (flag11)
        //								{
        //									taskInfo.Phase = (TaskPhase)i;
        //									break;
        //								}
        //							}
        //						}
        //						arrayList.Add(taskInfo);
        //					}
        //				}
        //				finally
        //				{
        //					IEnumerator enumerator;
        //					if (enumerator is IDisposable)
        //					{
        //						(enumerator as IDisposable).Dispose();
        //					}
        //				}
        //			}
        //		}
        //		return arrayList;
        //	}
        //}

        //// Token: 0x06001040 RID: 4160 RVA: 0x00073FE0 File Offset: 0x000721E0
        //private StringBuilder GetTaskDetailTimephasedDataSQL(cls_CM_ProjectSchedule2007 ProjectSchedule)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT DISTINCT      ");
        //	stringBuilder.AppendLine("    TP.[WPROJ_ID]      ");
        //	stringBuilder.AppendLine("    ,TSK.[TaskUniqueID]      ");
        //	stringBuilder.AppendLine("    ,CONVERT(nvarchar(MAX),TSK_ENT.[TaskEnterpriseText1]) [Modules]      ");
        //	stringBuilder.AppendLine("    ,TSK_ENT.[TaskEnterpriseFlag1] [IsNonProjectEffort]      ");
        //	stringBuilder.AppendLine("    ,CONVERT(nvarchar(MAX),TSK_ENT.[TaskEnterpriseText4]) [TaskClass]      ");
        //	stringBuilder.AppendLine("    ,TSK_ENT.[TaskEnterpriseNumber16] [TaskDifficulty]      ");
        //	stringBuilder.AppendLine("    ,CONVERT(nvarchar(MAX),TSK.[TaskName])  [TaskName]    ");
        //	stringBuilder.AppendLine("    ,CONVERT(nvarchar(MAX),ENT_RES.[ResourceName])   [ResourceName]   ");
        //	stringBuilder.AppendLine("    ,CONVERT(nvarchar(MAX),ENT_RES.[ResourceNTAccount])   [ResourceNTAccount]   ");
        //	stringBuilder.AppendLine("  --  ,TP.[ProjectUniqueID]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentUniqueID]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeStart]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeFinish]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeBaselineWork]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeWork]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualWork]      ");
        //	stringBuilder.AppendLine("    ,TP.[AssignmentTimeActualOvertimeWork]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeActualCost]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeBaselineCost]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeCost]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeCumulativeCost]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeCumulativeWork]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeOvertimeWork]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimePeakUnits]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeRegularWork]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeActualWorkProtected]      ");
        //	stringBuilder.AppendLine("  --  ,TP.[AssignmentTimeActualOvertimeWorkProtected]      ");
        //	stringBuilder.AppendLine("  FROM       ");
        //	stringBuilder.AppendLine("  \t[ProjectServer].[dbo].[MSP_VIEW_PROJ_ASSN_TP_BY_DAY]\tTP      ");
        //	stringBuilder.AppendLine("  \t, [ProjectServer].[dbo].[MSP_VIEW_PROJ_ASSN_STD]  ASN      ");
        //	stringBuilder.AppendLine("  \t, [ProjectServer].[dbo].[MSP_VIEW_PROJ_TASKS_STD]  TSK      ");
        //	stringBuilder.AppendLine("  \t, [ProjectServer].[dbo].[MSP_VIEW_PROJ_TASKS_ENT]  TSK_ENT      ");
        //	stringBuilder.AppendLine("  \t, [ProjectServer].[dbo].[MSP_VIEW_PROJ_RES_STD]  \tENT_RES      ");
        //	stringBuilder.AppendLine("  WHERE      ");
        //	stringBuilder.AppendLine("  \t(1 = 1)      ");
        //	stringBuilder.AppendLine("  \tAND TP.[AssignmentUniqueID] = ASN.[AssignmentUniqueID]      ");
        //	stringBuilder.AppendLine("  \tAND TP.[WPROJ_ID] = ASN.[WPROJ_ID]      ");
        //	stringBuilder.AppendLine("  \tAND ASN.[TaskUniqueID] = TSK.[TaskUniqueID]      ");
        //	stringBuilder.AppendLine("  \tAND ASN.[WPROJ_ID] = TSK.[WPROJ_ID]      ");
        //	stringBuilder.AppendLine("  \tAND TSK_ENT.[WPROJ_ID] = TSK.[WPROJ_ID]      ");
        //	stringBuilder.AppendLine("  \tAND TSK_ENT.[ENT_TaskUniqueID] = TSK.TaskUniqueID      ");
        //	stringBuilder.AppendLine("    \tAND ENT_RES.ResourceEnterpriseUniqueID = ASN.ResourceEnterpriseUniqueID                 ");
        //	stringBuilder.AppendLine("    \tAND ENT_RES.WPROJ_ID = ASN.WPROJ_ID     ");
        //	stringBuilder.AppendLine("    \tAND ASN.ResourceEnterpriseUniqueID <> -1        ");
        //	bool flag = ProjectSchedule != null;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("  \t    AND TP.[WPROJ_ID] = @WPROJ_ID       ");
        //	}
        //	stringBuilder.AppendLine("    \tAND TP.[AssignmentTimeStart] >= @StartDate               ");
        //	stringBuilder.AppendLine("    \tAND TP.[AssignmentTimeStart] <= @EndDate        ");
        //	stringBuilder.AppendLine("  --\tAND ASN.[ResourceEnterpriseUniqueID] = --ID cua nguoi can tinh      ");
        //	return stringBuilder;
        //}

        //// Token: 0x06001041 RID: 4161 RVA: 0x00074254 File Offset: 0x00072454
        //public TaskInfo GetParentTask(cls_CM_ProjectSchedule2007 Project, int TaskUniqueID)
        //{
        //	TaskInfo result = default(TaskInfo);
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  \t--Lay thong tin task summary cua task dua vao   ");
        //	stringBuilder.AppendLine("  \tSELECT    ");
        //	stringBuilder.AppendLine("    ET1.[TaskEnterpriseText1]   C1   ");
        //	stringBuilder.AppendLine("    ,T2.[TaskName]              C2   ");
        //	stringBuilder.AppendLine("    ,T2.[TaskUniqueID]          C3   ");
        //	stringBuilder.AppendLine("  \tFROM   ");
        //	stringBuilder.AppendLine("    [ProjectServer].[dbo].[MSP_VIEW_PROJ_TASKS_STD] T1   ");
        //	stringBuilder.AppendLine("    , [ProjectServer].[dbo].[MSP_VIEW_PROJ_TASKS_ENT] ET1   ");
        //	stringBuilder.AppendLine("    , [ProjectServer].[dbo].[MSP_VIEW_PROJ_TASKS_STD] T2   ");
        //	stringBuilder.AppendLine("  \tWHERE    ");
        //	stringBuilder.AppendLine("    (1=1)   ");
        //	stringBuilder.AppendLine("    and ET1.[WPROJ_ID] = T2.[WPROJ_ID]   ");
        //	stringBuilder.AppendLine("    and ET1.[ENT_TaskUniqueID] = T2.TaskUniqueID   ");
        //	stringBuilder.AppendLine("    and T2.[WPROJ_ID] = T1.[WPROJ_ID]   ");
        //	stringBuilder.AppendLine("    and T2.[TaskUniqueID] = T1.[TaskParentUID]   ");
        //	stringBuilder.AppendLine("    --Dua dieu kien Project vao day   ");
        //	stringBuilder.AppendLine("    and T1.[WPROJ_ID] = @WPROJ_ID   ");
        //	stringBuilder.AppendLine("    --Dua dieu kien TaskUniqueID vao day   ");
        //	stringBuilder.AppendLine("    and T1.TaskUniqueID = @TaskUniqueID   ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = Project.ID;
        //	parameters.Add(new SqlParameter("@TaskUniqueID", SqlDbType.Int)).Value = TaskUniqueID;
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					result = default(TaskInfo);
        //					result.ModuleName = Conversions.ToString(dataRow["C1"]);
        //					result.Name = Conversions.ToString(dataRow["C2"]);
        //					result.ID = Conversions.ToInteger(dataRow["C3"]);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return result;
        //}

        //// Token: 0x06001042 RID: 4162 RVA: 0x000744DC File Offset: 0x000726DC
        //public string GetNTAccount(int WPROJ_ID, int TaskUniqueID)
        //{
        //	string result = "";
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("    SELECT DISTINCT  ");
        //	stringBuilder.AppendLine("      ASN.[TaskUniqueID] ");
        //	stringBuilder.AppendLine("      , ASN.[WPROJ_ID] ");
        //	stringBuilder.AppendLine("      , ASN.ResourceEnterpriseUniqueID ");
        //	stringBuilder.AppendLine("      , CONVERT(nvarchar(MAX),ENT_RES.[ResourceNTAccount])   [ResourceNTAccount]  ");
        //	stringBuilder.AppendLine("    FROM  ");
        //	stringBuilder.AppendLine("      [MSP_VIEW_PROJ_RES_STD]  \tENT_RES    ");
        //	stringBuilder.AppendLine("      , [MSP_VIEW_PROJ_ASSN_STD]  ASN       ");
        //	stringBuilder.AppendLine("    WHERE ");
        //	stringBuilder.AppendLine("      (1=1) ");
        //	stringBuilder.AppendLine("      AND ENT_RES.ResourceEnterpriseUniqueID = ASN.ResourceEnterpriseUniqueID ");
        //	stringBuilder.AppendLine("      AND ASN.ResourceEnterpriseUniqueID <> -1 ");
        //	stringBuilder.AppendLine("      AND ASN.[WPROJ_ID] = @WPROJ_ID ");
        //	stringBuilder.AppendLine("      AND ASN.[TaskUniqueID] = @TaskUniqueID ");
        //	stringBuilder.AppendLine("    ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_DatabaseToProjectServer.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@WPROJ_ID", SqlDbType.Int)).Value = WPROJ_ID;
        //	parameters.Add(new SqlParameter("@TaskUniqueID", SqlDbType.Int)).Value = TaskUniqueID;
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_DatabaseToProjectServer.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //	if (flag)
        //	{
        //		bool flag2 = cls_DB_Dynaset.Dynaset.Tables.Count > 0;
        //		if (flag2)
        //		{
        //			using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //			{
        //				bool flag3 = dataTable.Rows.Count != 0;
        //				if (flag3)
        //				{
        //					result = Conversions.ToString(dataTable.Rows[0]["ResourceNTAccount"]);
        //				}
        //			}
        //		}
        //	}
        //	return result;
        //}

        //// Token: 0x06001043 RID: 4163 RVA: 0x000746D8 File Offset: 0x000728D8
        //public void GetDeletedScheduleInProjectEffort(ref ArrayList idList, ref ArrayList nameList)
        //{
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  SELECT DISTINCT [Project], [ScheduleName] ");
        //	stringBuilder.AppendLine("  FROM [PRJ_Effort] ");
        //	stringBuilder.AppendLine("  WHERE (1=1) ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	bool flag = Operators.CompareString(mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.ID, "0000000009", false) != 0;
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("  AND (RegUser = @LoginUser ");
        //		stringBuilder.AppendLine("       OR ModUser = @LoginUser ");
        //		stringBuilder.AppendLine("       OR ConfirmedBy = @LoginUser) ");
        //		parameters.Add(new SqlParameter("@LoginUser", SqlDbType.NVarChar)).Value = mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.ID;
        //	}
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	idList = new ArrayList();
        //	nameList = new ArrayList();
        //	bool flag2 = cls_DB_Dynaset != null;
        //	if (flag2)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					ArrayList projectScheduleList = this.GetProjectScheduleList(Conversions.ToInteger(dataRow["Project"]), "", null, false);
        //					bool flag3 = projectScheduleList == null || projectScheduleList.Count == 0;
        //					if (flag3)
        //					{
        //						idList.Add(RuntimeHelpers.GetObjectValue(dataRow["Project"]));
        //						nameList.Add(RuntimeHelpers.GetObjectValue(dataRow["ScheduleName"]));
        //					}
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //}

        //// Token: 0x06001044 RID: 4164 RVA: 0x000748D4 File Offset: 0x00072AD4
        //public ArrayList GetProjectStaffEffort(cls_CM_ProjectSchedule2007 Project, cls_CM_Staff_Abridged staff, string YearMonth = "")
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  \tSELECT T1.[ID]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[Project]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[StartDate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[EndDate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[ScheduleEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[ProjectActualEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[TrainingEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[TrainingActualEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      , '' [Leader]      \t  ");
        //	stringBuilder.AppendLine("  \t      , 0 [ManagementRate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[CustomerEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[AutoCal]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[HowToConv]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[IsConfirmed]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ConfirmedBy]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ConfirmDate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[LeaderRate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[IsPM]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ProjectEffortNotes]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[TrainingEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[Notes]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ScheduleName]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[Member]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[NTAccount]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[QualityPer]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[ScheduleWithQuality]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[ConvQuality]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[ModQuality]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[CusEffortConv]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[KeepLaborEff]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[IsKeptlabor]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[PrjEffectiveEff]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[PrjBonusEff]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T5.[Notes]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,'' [ProjectEffortNotes]      \t  ");
        //	stringBuilder.AppendLine("          ,T5.[OriginalScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,T5.[ExchangedScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,T5.[OriginalActualEffort]        ");
        //	stringBuilder.AppendLine("          ,T5.[ExchangedActualEffort]        ");
        //	stringBuilder.AppendLine("          ,T5.[TotalEffortWithBonus]        ");
        //	stringBuilder.AppendLine("  \t  FROM       \t  ");
        //	stringBuilder.AppendLine("       (SELECT        ");
        //	stringBuilder.AppendLine("    \t   T2.[ID]    \t  ");
        //	stringBuilder.AppendLine("          ,T2.[Effort]        ");
        //	stringBuilder.AppendLine("          ,T2.[Member]        ");
        //	stringBuilder.AppendLine("          ,T2.[NTAccount]        ");
        //	stringBuilder.AppendLine("          ,T2.[ScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[ProjectActualEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[TrainingEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[TrainingActualEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[QualityPer]        ");
        //	stringBuilder.AppendLine("          ,T2.[ScheduleWithQuality]        ");
        //	stringBuilder.AppendLine("          ,T2.[ConvQuality]        ");
        //	stringBuilder.AppendLine("          ,T2.[ModQuality]        ");
        //	stringBuilder.AppendLine("          ,T2.[CusEffortConv]        ");
        //	stringBuilder.AppendLine("          ,T2.[KeepLaborEff]        ");
        //	stringBuilder.AppendLine("          ,T2.[IsKeptlabor]        ");
        //	stringBuilder.AppendLine("          ,T2.[PrjEffectiveEff]        ");
        //	stringBuilder.AppendLine("          ,T2.[PrjBonusEff]        ");
        //	stringBuilder.AppendLine("          ,T2.[Notes]        ");
        //	stringBuilder.AppendLine("          ,T2.[RegUser]        ");
        //	stringBuilder.AppendLine("          ,T2.[RegDate]        ");
        //	stringBuilder.AppendLine("          ,T2.[ModUser]        ");
        //	stringBuilder.AppendLine("          ,T2.[ModDate]        ");
        //	stringBuilder.AppendLine("          ,T2.[OriginalScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[ExchangedScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[OriginalActualEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[ExchangedActualEffort]        ");
        //	stringBuilder.AppendLine("          ,T2.[TotalEffortWithBonus]        ");
        //	stringBuilder.AppendLine("          FROM [PRJ_EffortDetail] T2         ");
        //	stringBuilder.AppendLine("          WHERE        ");
        //	stringBuilder.AppendLine("      (1 = 1)      ");
        //	stringBuilder.AppendLine("      AND T2.[NTAccount] = @NTAccount      ");
        //	stringBuilder.AppendLine("      ) T5      ");
        //	stringBuilder.AppendLine("       , [PRJ_Effort] T1        ");
        //	stringBuilder.AppendLine("  \t  WHERE       \t  ");
        //	stringBuilder.AppendLine("    \t(1 = 1)    \t  ");
        //	stringBuilder.AppendLine("    \tAND T1.ID = T5.[Effort]    \t  ");
        //	stringBuilder.AppendLine("    \tAND LEFT(T1.EndDate, 6) = @YearMonth    \t  ");
        //	stringBuilder.AppendLine("            ");
        //	stringBuilder.AppendLine("  \tUNION ALL      \t  ");
        //	stringBuilder.AppendLine("            ");
        //	stringBuilder.AppendLine("  \tSELECT T1.[ID]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[Project]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[StartDate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[EndDate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [ScheduleEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [ProjectActualEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [TrainingEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [TrainingActualEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T4.[Leader]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T4.[ManagementRate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[CustomerEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[AutoCal]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[HowToConv]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[IsConfirmed]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ConfirmedBy]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ConfirmDate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[LeaderRate]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[IsPM]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ProjectEffortNotes]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[TrainingEffort]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[Notes]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T1.[ScheduleName]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,'' [Member]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,'' [NTAccount]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [QualityPer]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [ScheduleWithQuality]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [ConvQuality]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [ModQuality]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [CusEffortConv]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [KeepLaborEff]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [IsKeptlabor]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [PrjEffectiveEff]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,0 [PrjBonusEff]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,'' [Notes]      \t  ");
        //	stringBuilder.AppendLine("  \t      ,T4.[Notes] [ProjectEffortNotes]      \t  ");
        //	stringBuilder.AppendLine("          ,0 [OriginalScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,0 [ExchangedScheduleEffort]        ");
        //	stringBuilder.AppendLine("          ,0 [OriginalActualEffort]        ");
        //	stringBuilder.AppendLine("          ,0 [ExchangedActualEffort]        ");
        //	stringBuilder.AppendLine("          ,0 [TotalEffortWithBonus]        ");
        //	stringBuilder.AppendLine("  \t  FROM       \t  ");
        //	stringBuilder.AppendLine("       (SELECT         ");
        //	stringBuilder.AppendLine("    \t   T3.[ID]    \t  ");
        //	stringBuilder.AppendLine("          ,T3.[Effort]        ");
        //	stringBuilder.AppendLine("          ,T3.[Leader]        ");
        //	stringBuilder.AppendLine("          ,T3.[ManagementRate]        ");
        //	stringBuilder.AppendLine("          ,T3.[Notes]        ");
        //	stringBuilder.AppendLine("    \tFROM [PRJ_EffortProjectDetail] T3    \t  ");
        //	stringBuilder.AppendLine("    \tWHERE    \t  ");
        //	stringBuilder.AppendLine("      (1 = 1)      ");
        //	stringBuilder.AppendLine("      AND T3.[Leader] = @LeaderID      ");
        //	stringBuilder.AppendLine("    \t) T4    \t  ");
        //	stringBuilder.AppendLine("       , [PRJ_Effort] T1        ");
        //	stringBuilder.AppendLine("  \t WHERE       \t  ");
        //	stringBuilder.AppendLine("    \t(1 = 1)    \t  ");
        //	stringBuilder.AppendLine("    \tAND T1.ID = T4.[Effort]    \t  ");
        //	stringBuilder.AppendLine("    \tAND LEFT(T1.EndDate, 6) = @YearMonth  ");
        //	stringBuilder.AppendLine("            ");
        //	stringBuilder.AppendLine("  \tORDER BY [ScheduleName]      \t  ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	parameters.Add(new SqlParameter("@NTAccount", SqlDbType.NVarChar)).Value = staff.UserName;
        //	parameters.Add(new SqlParameter("@LeaderID", SqlDbType.NVarChar)).Value = staff.ID;
        //	parameters.Add(new SqlParameter("@YearMonth", SqlDbType.NVarChar)).Value = YearMonth;
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag = cls_DB_Dynaset != null;
        //	checked
        //	{
        //		if (flag)
        //		{
        //			using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //			{
        //				try
        //				{
        //					foreach (object obj in dataTable.Rows)
        //					{
        //						DataRow dataRow = (DataRow)obj;
        //						bool flag2 = false;
        //						int num = arrayList.Count - 1;
        //						int i;
        //						for (i = 0; i <= num; i++)
        //						{
        //							object obj2 = arrayList[i];
        //							bool flag3 = Operators.ConditionalCompareObjectEqual(((obj2 != null) ? ((EffortDetailPerStaff)obj2) : default(EffortDetailPerStaff)).ProjectName, dataRow["ScheduleName"], false);
        //							if (flag3)
        //							{
        //								flag2 = true;
        //								break;
        //							}
        //						}
        //						bool flag4 = flag2;
        //						EffortDetailPerStaff effortDetailPerStaff;
        //						if (flag4)
        //						{
        //							object obj3 = arrayList[i];
        //							effortDetailPerStaff = ((obj3 != null) ? ((EffortDetailPerStaff)obj3) : default(EffortDetailPerStaff));
        //						}
        //						else
        //						{
        //							effortDetailPerStaff = default(EffortDetailPerStaff);
        //						}
        //						EffortDetailPerStaff effortDetailPerStaff2 = default(EffortDetailPerStaff);
        //						object dbobj = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["StartDate"]));
        //						ref DateTime ptr = ref effortDetailPerStaff2.StartDate;
        //						object value = effortDetailPerStaff2.StartDate;
        //						cls_CM_Function.SetDBFieldData(dbobj, ref value);
        //						ptr = Conversions.ToDate(value);
        //						effortDetailPerStaff.StartDate = effortDetailPerStaff2.StartDate;
        //						object dbobj2 = cls_CM_Function.ConvertDateStrAndDate(RuntimeHelpers.GetObjectValue(dataRow["EndDate"]));
        //						ptr = ref effortDetailPerStaff2.EndDate;
        //						value = effortDetailPerStaff2.EndDate;
        //						cls_CM_Function.SetDBFieldData(dbobj2, ref value);
        //						ptr = Conversions.ToDate(value);
        //						effortDetailPerStaff.EndDate = effortDetailPerStaff2.EndDate;
        //						object objectValue = RuntimeHelpers.GetObjectValue(dataRow["ScheduleEffort"]);
        //						ref decimal ptr2 = ref effortDetailPerStaff2.ProjectScheduleEffort;
        //						value = effortDetailPerStaff2.ProjectScheduleEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.ProjectScheduleEffort;
        //						effortDetailPerStaff.ProjectScheduleEffort = decimal.Add(ptr2, effortDetailPerStaff2.ProjectScheduleEffort);
        //						object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow["ProjectActualEffort"]);
        //						ptr2 = ref effortDetailPerStaff2.ProjectActualEffort;
        //						value = effortDetailPerStaff2.ProjectActualEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue2, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.ProjectActualEffort;
        //						effortDetailPerStaff.ProjectActualEffort = decimal.Add(ptr2, effortDetailPerStaff2.ProjectActualEffort);
        //						object objectValue3 = RuntimeHelpers.GetObjectValue(dataRow["TrainingEffort"]);
        //						ptr2 = ref effortDetailPerStaff2.TrainingScheduleEffort;
        //						value = effortDetailPerStaff2.TrainingScheduleEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue3, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.TrainingScheduleEffort;
        //						effortDetailPerStaff.TrainingScheduleEffort = decimal.Add(ptr2, effortDetailPerStaff2.TrainingScheduleEffort);
        //						object objectValue4 = RuntimeHelpers.GetObjectValue(dataRow["TrainingActualEffort"]);
        //						ptr2 = ref effortDetailPerStaff2.TrainingActualEffort;
        //						value = effortDetailPerStaff2.TrainingActualEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue4, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.TrainingActualEffort;
        //						effortDetailPerStaff.TrainingActualEffort = decimal.Add(ptr2, effortDetailPerStaff2.TrainingActualEffort);
        //						object objectValue5 = RuntimeHelpers.GetObjectValue(dataRow["ManagementRate"]);
        //						ptr2 = ref effortDetailPerStaff2.ManagementRate;
        //						value = effortDetailPerStaff2.ManagementRate;
        //						cls_CM_Function.SetDBFieldData(objectValue5, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.ManagementRate;
        //						effortDetailPerStaff.ManagementRate = decimal.Add(ptr2, effortDetailPerStaff2.ManagementRate);
        //						object objectValue6 = RuntimeHelpers.GetObjectValue(dataRow["CustomerEffort"]);
        //						ptr2 = ref effortDetailPerStaff2.CustomerEffort;
        //						value = effortDetailPerStaff2.CustomerEffort;
        //						cls_CM_Function.SetDBFieldData(objectValue6, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						effortDetailPerStaff.CustomerEffort = effortDetailPerStaff2.CustomerEffort;
        //						object objectValue7 = RuntimeHelpers.GetObjectValue(dataRow["LeaderRate"]);
        //						ptr2 = ref effortDetailPerStaff2.LeaderRate;
        //						value = effortDetailPerStaff2.LeaderRate;
        //						cls_CM_Function.SetDBFieldData(objectValue7, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						effortDetailPerStaff.LeaderRate = effortDetailPerStaff2.LeaderRate;
        //						object objectValue8 = RuntimeHelpers.GetObjectValue(dataRow["ScheduleName"]);
        //						ref string ptr3 = ref effortDetailPerStaff2.ProjectName;
        //						value = effortDetailPerStaff2.ProjectName;
        //						cls_CM_Function.SetDBFieldData(objectValue8, ref value);
        //						ptr3 = Conversions.ToString(value);
        //						effortDetailPerStaff.ProjectName = effortDetailPerStaff2.ProjectName;
        //						object objectValue9 = RuntimeHelpers.GetObjectValue(dataRow["ModQuality"]);
        //						ptr2 = ref effortDetailPerStaff2.ModQuality;
        //						value = effortDetailPerStaff2.ModQuality;
        //						cls_CM_Function.SetDBFieldData(objectValue9, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.ModQuality;
        //						effortDetailPerStaff.ModQuality = decimal.Add(ptr2, effortDetailPerStaff2.ModQuality);
        //						object objectValue10 = RuntimeHelpers.GetObjectValue(dataRow["KeepLaborEff"]);
        //						ptr2 = ref effortDetailPerStaff2.KeepLaborEff;
        //						value = effortDetailPerStaff2.KeepLaborEff;
        //						cls_CM_Function.SetDBFieldData(objectValue10, ref value);
        //						ptr2 = Conversions.ToDecimal(value);
        //						ptr2 = ref effortDetailPerStaff.KeepLaborEff;
        //						effortDetailPerStaff.KeepLaborEff = decimal.Add(ptr2, effortDetailPerStaff2.KeepLaborEff);
        //						decimal num2 = 0m;
        //						object objectValue11 = RuntimeHelpers.GetObjectValue(dataRow["ScheduleWithQuality"]);
        //						value = num2;
        //						cls_CM_Function.SetDBFieldData(objectValue11, ref value);
        //						num2 = Conversions.ToDecimal(value);
        //						decimal num3 = 0m;
        //						object objectValue12 = RuntimeHelpers.GetObjectValue(dataRow["TotalEffortWithBonus"]);
        //						value = num3;
        //						cls_CM_Function.SetDBFieldData(objectValue12, ref value);
        //						num3 = Conversions.ToDecimal(value);
        //						effortDetailPerStaff2.ModPhase = decimal.Subtract(num3, num2);
        //						ptr2 = ref effortDetailPerStaff.ModPhase;
        //						effortDetailPerStaff.ModPhase = decimal.Add(ptr2, effortDetailPerStaff2.ModPhase);
        //						bool flag5 = flag2;
        //						if (flag5)
        //						{
        //							arrayList[i] = effortDetailPerStaff;
        //						}
        //						else
        //						{
        //							effortDetailPerStaff.SumTrainingScheduleEffort = 0m;
        //							arrayList.Add(effortDetailPerStaff);
        //						}
        //					}
        //				}
        //				finally
        //				{
        //					IEnumerator enumerator;
        //					if (enumerator is IDisposable)
        //					{
        //						(enumerator as IDisposable).Dispose();
        //					}
        //				}
        //			}
        //		}
        //		return arrayList;
        //	}
        //}

        //// Token: 0x06001045 RID: 4165 RVA: 0x000756F0 File Offset: 0x000738F0
        //public ArrayList GetPhaseExchangeList(TaskPhase phase = (TaskPhase)(-1), string phaseShortName = "", object validFromDate = null, object validToDate = null)
        //{
        //	ArrayList arrayList = new ArrayList();
        //	StringBuilder stringBuilder = new StringBuilder("");
        //	stringBuilder.AppendLine("  \tSELECT [ID]  ");
        //	stringBuilder.AppendLine("  \t      ,[PhaseName]  ");
        //	stringBuilder.AppendLine("  \t      ,[PhaseNo]  ");
        //	stringBuilder.AppendLine("  \t      ,[Factor]  ");
        //	stringBuilder.AppendLine("  \t      ,[ExchangeFactor]  ");
        //	stringBuilder.AppendLine("  \t      ,[ValidFrom]  ");
        //	stringBuilder.AppendLine("  \t      ,[ValidTo]  ");
        //	stringBuilder.AppendLine("  \t  FROM [PRJ_EffortPhases]  ");
        //	stringBuilder.AppendLine("  \t  WHERE (1 = 1)  ");
        //	mod_WMS_Declare.rwl.EnterWriteLock();
        //	cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //	parameters.Clear();
        //	bool flag = phase != (TaskPhase)(-1);
        //	if (flag)
        //	{
        //		stringBuilder.AppendLine("  \t       AND ([PhaseNo]=@PhaseNo)  ");
        //		parameters.Add(new SqlParameter("@PhaseNo", SqlDbType.SmallInt)).Value = phase;
        //	}
        //	bool flag2 = Operators.CompareString(phaseShortName, "", false) != 0;
        //	if (flag2)
        //	{
        //		stringBuilder.AppendLine("  \t       AND ([PhaseName]=@PhaseName)  ");
        //		parameters.Add(new SqlParameter("@PhaseName", SqlDbType.NVarChar)).Value = phaseShortName;
        //	}
        //	bool flag3 = validFromDate != null;
        //	if (flag3)
        //	{
        //		stringBuilder.AppendLine("  \t       AND (LEFT([ValidFrom],6) = @ValidFrom)  ");
        //		parameters.Add(new SqlParameter("@ValidFrom", SqlDbType.NVarChar)).Value = validFromDate.ToString()[Conversions.ToInteger("yyyyMM")];
        //	}
        //	bool flag4 = validToDate != null;
        //	if (flag4)
        //	{
        //		stringBuilder.AppendLine("  \t       AND (LEFT([ValidTo],6) = @ValidTo)  ");
        //		parameters.Add(new SqlParameter("@ValidTo", SqlDbType.NVarChar)).Value = validToDate.ToString()[Conversions.ToInteger("yyyyMM")];
        //	}
        //	cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
        //	mod_WMS_Declare.rwl.ExitWriteLock();
        //	bool flag5 = cls_DB_Dynaset != null;
        //	if (flag5)
        //	{
        //		using (DataTable dataTable = cls_DB_Dynaset.Dynaset.Tables[0])
        //		{
        //			try
        //			{
        //				foreach (object obj in dataTable.Rows)
        //				{
        //					DataRow dataRow = (DataRow)obj;
        //					PhaseExchange phaseExchange = default(PhaseExchange);
        //					object objectValue = RuntimeHelpers.GetObjectValue(dataRow["PhaseName"]);
        //					ref string ptr = ref phaseExchange.ShortName;
        //					object value = phaseExchange.ShortName;
        //					cls_CM_Function.SetDBFieldData(objectValue, ref value);
        //					ptr = Conversions.ToString(value);
        //					object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow["PhaseNo"]);
        //					ref TaskPhase ptr2 = ref phaseExchange.Phase;
        //					value = phaseExchange.Phase;
        //					cls_CM_Function.SetDBFieldData(objectValue2, ref value);
        //					ptr2 = (TaskPhase)Conversions.ToInteger(value);
        //					object objectValue3 = RuntimeHelpers.GetObjectValue(dataRow["Factor"]);
        //					ref decimal ptr3 = ref phaseExchange.BonusEffortRate;
        //					value = phaseExchange.BonusEffortRate;
        //					cls_CM_Function.SetDBFieldData(objectValue3, ref value);
        //					ptr3 = Conversions.ToDecimal(value);
        //					object objectValue4 = RuntimeHelpers.GetObjectValue(dataRow["ExchangeFactor"]);
        //					ptr3 = ref phaseExchange.EffortExchangeRate;
        //					value = phaseExchange.EffortExchangeRate;
        //					cls_CM_Function.SetDBFieldData(objectValue4, ref value);
        //					ptr3 = Conversions.ToDecimal(value);
        //					object objectValue5 = RuntimeHelpers.GetObjectValue(dataRow["ValidFrom"]);
        //					ref DateTime ptr4 = ref phaseExchange.ValidFrom;
        //					value = phaseExchange.ValidFrom;
        //					cls_CM_Function.SetDBFieldData(objectValue5, ref value);
        //					ptr4 = Conversions.ToDate(value);
        //					object objectValue6 = RuntimeHelpers.GetObjectValue(dataRow["ValidTo"]);
        //					ptr4 = ref phaseExchange.ValidTo;
        //					value = phaseExchange.ValidTo;
        //					cls_CM_Function.SetDBFieldData(objectValue6, ref value);
        //					ptr4 = Conversions.ToDate(value);
        //					bool flag6 = DateTime.Compare(phaseExchange.ValidTo, DateTime.MinValue) == 0;
        //					if (flag6)
        //					{
        //						phaseExchange.ValidTo = DateTime.MaxValue;
        //					}
        //					arrayList.Add(phaseExchange);
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator;
        //				if (enumerator is IDisposable)
        //				{
        //					(enumerator as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	return arrayList;
        //}

        //// Token: 0x06001046 RID: 4166 RVA: 0x00075B2C File Offset: 0x00073D2C
        //public void SumTrainingEffort(ProjectStaffEffort oneEffort, ref decimal trainingSchedule, ref decimal trainingActual, ref decimal trainingRate)
        //{
        //	trainingSchedule = 0m;
        //	trainingActual = 0m;
        //	trainingRate = 0m;
        //	checked
        //	{
        //		int num = oneEffort.Detail.Count - 1;
        //		for (int i = 0; i <= num; i++)
        //		{
        //			ProjectStaffEffortDetail projectStaffEffortDetail = oneEffort.Detail[i];
        //			int num2 = projectStaffEffortDetail.PhaseDetailEffort.Count - 1;
        //			for (int j = 0; j <= num2; j++)
        //			{
        //				object obj = projectStaffEffortDetail.PhaseDetailEffort[j];
        //				EffortByPhaseData effortByPhaseData = (obj != null) ? ((EffortByPhaseData)obj) : default(EffortByPhaseData);
        //				bool flag = effortByPhaseData.EffortPhase == TaskPhase.Training;
        //				if (flag)
        //				{
        //					trainingSchedule = decimal.Add(trainingSchedule, effortByPhaseData.OriginalBaselinedEffort);
        //					trainingActual = decimal.Add(trainingActual, effortByPhaseData.OriginalActualEffort);
        //					trainingRate = effortByPhaseData.EffortExchangedRate;
        //				}
        //			}
        //		}
        //	}
        //}

        //// Token: 0x06001047 RID: 4167 RVA: 0x00075C10 File Offset: 0x00073E10
        //public void SumTrainingEffort(ProjectStaffEffortDetail oneEffortDetail, ref decimal trainingSchedule, ref decimal trainingActual, ref decimal trainingRate)
        //{
        //	trainingSchedule = 0m;
        //	trainingActual = 0m;
        //	trainingRate = 0m;
        //	checked
        //	{
        //		int num = oneEffortDetail.PhaseDetailEffort.Count - 1;
        //		for (int i = 0; i <= num; i++)
        //		{
        //			object obj = oneEffortDetail.PhaseDetailEffort[i];
        //			EffortByPhaseData effortByPhaseData = (obj != null) ? ((EffortByPhaseData)obj) : default(EffortByPhaseData);
        //			bool flag = effortByPhaseData.EffortPhase == TaskPhase.Training;
        //			if (flag)
        //			{
        //				trainingSchedule = decimal.Add(trainingSchedule, effortByPhaseData.OriginalBaselinedEffort);
        //				trainingActual = decimal.Add(trainingActual, effortByPhaseData.OriginalActualEffort);
        //				trainingRate = effortByPhaseData.EffortExchangedRate;
        //			}
        //		}
        //	}
        //}

        //// Token: 0x06001048 RID: 4168 RVA: 0x00075CBC File Offset: 0x00073EBC
        //public bool InsertMapMSP20032007()
        //{
        //	cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
        //	List<cls_CM_ProjectSchedule2007> projectScheduleList = cls_CM_ProjectSchedule.GetProjectScheduleList(Guid.Empty, "", null, false, DataStoreEnum.WorkingStore);
        //	ArrayList projectScheduleList2 = this.GetProjectScheduleList(int.MinValue, "", null, false);
        //	try
        //	{
        //		foreach (cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule2 in projectScheduleList)
        //		{
        //			try
        //			{
        //				foreach (object obj in projectScheduleList2)
        //				{
        //					cls_CM_ProjectSchedule cls_CM_ProjectSchedule3 = (cls_CM_ProjectSchedule)obj;
        //					bool flag = Operators.CompareString(cls_CM_ProjectSchedule2.Name.Trim(), cls_CM_ProjectSchedule3.Name.Trim() + "_Published", false) == 0 | Operators.CompareString(cls_CM_ProjectSchedule2.Name.Trim(), cls_CM_ProjectSchedule3.Name.Trim(), false) == 0;
        //					if (flag)
        //					{
        //						StringBuilder stringBuilder = new StringBuilder("");
        //						stringBuilder.AppendLine("   INSERT INTO [PRJ_MSP20032007Map]  ");
        //						stringBuilder.AppendLine("              (  ");
        //						stringBuilder.AppendLine("              [ID2003]  ");
        //						stringBuilder.AppendLine("              ,[ID2007]  ");
        //						stringBuilder.AppendLine("              ,[PrjName]  ");
        //						stringBuilder.AppendLine("              )  ");
        //						stringBuilder.AppendLine("        VALUES  ");
        //						stringBuilder.AppendLine("              (  ");
        //						stringBuilder.AppendLine("              @ID2003  ");
        //						stringBuilder.AppendLine("              ,@ID2007  ");
        //						stringBuilder.AppendLine("              ,@PrjName  ");
        //						stringBuilder.AppendLine("              )   ");
        //						cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
        //						parameters.Clear();
        //						parameters.Add(new SqlParameter("@ID2003", SqlDbType.Int)).Value = cls_CM_ProjectSchedule3.ID;
        //						parameters.Add(new SqlParameter("@ID2007", SqlDbType.NVarChar)).Value = cls_CM_ProjectSchedule2.ID.ToString();
        //						parameters.Add(new SqlParameter("@PrjName", SqlDbType.NVarChar)).Value = cls_CM_ProjectSchedule2.Name;
        //						mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
        //					}
        //				}
        //			}
        //			finally
        //			{
        //				IEnumerator enumerator2;
        //				if (enumerator2 is IDisposable)
        //				{
        //					(enumerator2 as IDisposable).Dispose();
        //				}
        //			}
        //		}
        //	}
        //	finally
        //	{
        //		List<cls_CM_ProjectSchedule2007>.Enumerator enumerator;
        //		((IDisposable)enumerator).Dispose();
        //	}
        //	bool result;
        //	return result;
        //}
    }
}
