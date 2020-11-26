using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace P2k7.Core.Behavior
{
	// Token: 0x02000072 RID: 114
	public class cls_DB_Master
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x00014AEC File Offset: 0x00012CEC
		public void fncG_DB_GetData(ref cls_CM_Master iObj_Master)
		{
			//StringBuilder stringBuilder = new StringBuilder("");
			//stringBuilder.AppendLine(" SELECT  ");
			//stringBuilder.AppendLine("        AbsPathToPAL                   C1");
			//stringBuilder.AppendLine("       ,AbsPathToFPMG                  C2");
			//stringBuilder.AppendLine("       ,AbsPathToHistory               C3");
			//stringBuilder.AppendLine("       ,HistoryPath                    C4");
			//stringBuilder.AppendLine("       ,AbsPathToTemplateForCreate     C5");
			//stringBuilder.AppendLine("       ,AbsPathToVSSTemplate           C6");
			//stringBuilder.AppendLine("       ,AbsPathToNoVSSFolderTemplate   C7");
			//stringBuilder.AppendLine("       ,AbsPathToVSSFolderTemplate     C8");
			//stringBuilder.AppendLine("       ,TaskAutoReloadInterval         C9");
			//stringBuilder.AppendLine("       ,AbsPathToPALISMS               C10");
			//stringBuilder.AppendLine("       ,AbsPathToFPMGISMS              C11");
			//stringBuilder.AppendLine("       ,AbsPathToHistoryISMS           C12");
			//stringBuilder.AppendLine("       ,AbsPathToTemplateForCreateISMS C13");
			//stringBuilder.AppendLine("       ,AbsPathToSavingLocation        C14");
			//stringBuilder.AppendLine("       ,AbsPathToHistoryOthers         C15");
			//stringBuilder.AppendLine("       ,AbsPathToTemplateForCreateOthers C16");
			//stringBuilder.AppendLine("       ,WMSServicesLoginUser           C17");
			//stringBuilder.AppendLine("       ,WMSServicesLoginPassword       C18");
			//stringBuilder.AppendLine("       ,CommonSalt       C19");
			//stringBuilder.AppendLine("       ,AESKey       C20");
			//stringBuilder.AppendLine("   FROM  ");
			//stringBuilder.AppendLine("       OMM_MASTER ");
			//mod_WMS_Declare.rwl.EnterWriteLock();
			//cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			//parameters.Clear();
			//cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			//mod_WMS_Declare.rwl.ExitWriteLock();
			//cls_DB_Dynaset.MoveFirst();
			//bool flag = cls_DB_Dynaset.EOF() == 0L;
			//if (flag)
			//{
			//	iObj_Master.AbsPathToPAL = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C1"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C1"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToFPMG = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C2"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C2"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToHistory = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C3"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C3"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.HistoryPath = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C4"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C4"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToTemplateForCreate = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C5"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C5"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToVSSTemplate = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C6"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C6"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToNoVSSFolderTemplate = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C7"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C7"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToVSSFolderTemplate = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C8"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C8"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.TaskAutoReloadInterval = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C9"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C9"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToPALISMS = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C10"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C10"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToFPMGISMS = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C11"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C11"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToHistoryISMS = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C12"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C12"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToTemplateForCreateISMS = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C13"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C13"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToSavingLocation = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C14"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C14"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToHistoryOthers = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C15"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C15"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AbsPathToTemplateForCreateOthers = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C16"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C16"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.WMSServicesLoginUser = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C17"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C17"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.WMSServicesLoginPassword = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C18"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C18"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.CommonSalt = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C18"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C19"], null, "Value", new object[0], null, null, null));
			//	iObj_Master.AESKey = Conversions.ToString((NewLateBinding.LateGet(cls_DB_Dynaset["C18"], null, "Value", new object[0], null, null, null) == DBNull.Value) ? "" : NewLateBinding.LateGet(cls_DB_Dynaset["C20"], null, "Value", new object[0], null, null, null));
			//}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00015368 File Offset: 0x00013568
		public bool fncG_DB_Update(cls_CM_Master iObj_Master)
		{
			bool result = false;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.AppendLine(" UPDATE [OMM_Master]   ");
			stringBuilder.AppendLine("    SET [AbsPathToPAL] = @AbsPathToPAL   ");
			stringBuilder.AppendLine("       ,[AbsPathToFPMG] = @AbsPathToFPMG   ");
			stringBuilder.AppendLine("       ,[AbsPathToHistory] = @AbsPathToHistory   ");
			stringBuilder.AppendLine("       ,[AbsPathToTemplateForCreate] = @AbsPathToTemplateForCreate   ");
			stringBuilder.AppendLine("       ,[AbsPathToVSSTemplate] = @AbsPathToVSSTemplate   ");
			stringBuilder.AppendLine("       ,[AbsPathToNoVSSFolderTemplate] = @AbsPathToNoVSSFolderTemplate   ");
			stringBuilder.AppendLine("       ,[AbsPathToVSSFolderTemplate] = @AbsPathToVSSFolderTemplate   ");
			stringBuilder.AppendLine("       ,[TaskAutoReloadInterval] = @TaskAutoReloadInterval   ");
			stringBuilder.AppendLine("       ,[AbsPathToPALISMS] = @AbsPathToPALISMS   ");
			stringBuilder.AppendLine("       ,[AbsPathToFPMGISMS] = @AbsPathToFPMGISMS   ");
			stringBuilder.AppendLine("       ,[AbsPathToHistoryISMS] = @AbsPathToHistoryISMS   ");
			stringBuilder.AppendLine("       ,[AbsPathToTemplateForCreateISMS] = @AbsPathToTemplateForCreateISMS   ");
			stringBuilder.AppendLine("       ,[AbsPathToSavingLocation] = @AbsPathToSavingLocation   ");
			stringBuilder.AppendLine("       ,[AbsPathToHistoryOthers] = @AbsPathToHistoryOthers   ");
			stringBuilder.AppendLine("       ,[AbsPathToTemplateForCreateOthers] = @AbsPathToTemplateForCreateOthers   ");
			stringBuilder.AppendLine("  WHERE    ");
			stringBuilder.AppendLine("        1 = 1                           ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			parameters.Add(new SqlParameter("@AbsPathToPAL", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToPAL;
			parameters.Add(new SqlParameter("@AbsPathToFPMG", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToFPMG;
			parameters.Add(new SqlParameter("@AbsPathToHistory", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToHistory;
			parameters.Add(new SqlParameter("@AbsPathToTemplateForCreate", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToTemplateForCreate;
			parameters.Add(new SqlParameter("@AbsPathToVSSTemplate", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToVSSTemplate;
			parameters.Add(new SqlParameter("@AbsPathToNoVSSFolderTemplate", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToNoVSSFolderTemplate;
			parameters.Add(new SqlParameter("@AbsPathToVSSFolderTemplate", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToVSSFolderTemplate;
			parameters.Add(new SqlParameter("@TaskAutoReloadInterval", SqlDbType.NVarChar)).Value = iObj_Master.TaskAutoReloadInterval;
			parameters.Add(new SqlParameter("@AbsPathToPALISMS", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToPALISMS;
			parameters.Add(new SqlParameter("@AbsPathToFPMGISMS", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToFPMGISMS;
			parameters.Add(new SqlParameter("@AbsPathToHistoryISMS", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToHistoryISMS;
			parameters.Add(new SqlParameter("@AbsPathToTemplateForCreateISMS", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToTemplateForCreateISMS;
			parameters.Add(new SqlParameter("@AbsPathToSavingLocation", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToSavingLocation;
			parameters.Add(new SqlParameter("@AbsPathToHistoryOthers", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToHistoryOthers;
			parameters.Add(new SqlParameter("@AbsPathToTemplateForCreateOthers", SqlDbType.NVarChar)).Value = iObj_Master.AbsPathToTemplateForCreateOthers;
			mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			return result;
		}
	}
}
