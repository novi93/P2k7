using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace P2k7.Core.Behavior.DB_SQLServer
{
	public class cls_DB_Document
	{
		// Token: 0x06000717 RID: 1815 RVA: 0x00029450 File Offset: 0x00027650
		public DataTable fncG_DB_GetDocumentList()
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc.ID,                                 ");
			stringBuilder.Append("        doc.DocID,                              ");
			stringBuilder.Append("        doc.DocName,                            ");
			stringBuilder.Append("        doc.DocFileName,                        ");
			stringBuilder.Append("        doc.DocLanguage,                        ");
			stringBuilder.Append("        doc.DocType,                            ");
			stringBuilder.Append("        doc.DocClass,                           ");
			stringBuilder.Append("        doc.DocExtension,                       ");
			stringBuilder.Append("        doc.DocRevNo,                           ");
			stringBuilder.Append("        doc.PathInFPMG,                         ");
			stringBuilder.Append("        doc.PathInPAL,                          ");
			stringBuilder.Append("        doc.PathToDoc,                          ");
			stringBuilder.Append("        doc.Note,                               ");
			stringBuilder.Append("        doc.Tag,                                ");
			stringBuilder.Append("        doc_lan.Language,                       ");
			stringBuilder.Append("        doc_type.TypeName,                      ");
			stringBuilder.Append("        doc_cls.ClassName,                      ");
			stringBuilder.Append("        doc.DocOwner                            ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentsFJS doc,                       ");
			stringBuilder.Append("        DC_DocumentLanguage doc_lan,            ");
			stringBuilder.Append("        DC_DocumentType doc_type,               ");
			stringBuilder.Append("        DC_DocumentClass doc_cls                ");
			stringBuilder.Append("    where                                       ");
			stringBuilder.Append("        1 = 1                                   ");
			stringBuilder.Append("        and doc.IsDeleted = 0                   ");
			stringBuilder.Append("        and doc.DocLanguage = doc_lan.ID        ");
			stringBuilder.Append("        and doc.DocType = doc_type.ID           ");
			stringBuilder.Append("        and doc.DocClass = doc_cls.ID           ");
			stringBuilder.Append("    order by                                    ");
			stringBuilder.Append("        doc.DocName                             ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			mod_WMS_Declare.gvObj_Database.Parameters.Clear();
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00029660 File Offset: 0x00027860
		public DataTable fncG_DB_GetClassList()
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc_cls.ID,                             ");
			stringBuilder.Append("        doc_cls.ClassName,                      ");
			stringBuilder.Append("        doc_cls.ShortName                       ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentClass doc_cls                ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			mod_WMS_Declare.gvObj_Database.Parameters.Clear();
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00029738 File Offset: 0x00027938
		public DataTable fncG_DB_GetLanguageList()
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc_lan.ID,                             ");
			stringBuilder.Append("        doc_lan.Language                        ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentLanguage doc_lan             ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			mod_WMS_Declare.gvObj_Database.Parameters.Clear();
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00029804 File Offset: 0x00027A04
		public DataTable fncG_DB_GetTypeList()
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc_type.ID,                            ");
			stringBuilder.Append("        doc_type.TypeName,                      ");
			stringBuilder.Append("        doc_type.ShortName                      ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentType doc_type                ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			mod_WMS_Declare.gvObj_Database.Parameters.Clear();
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000298DC File Offset: 0x00027ADC
		public bool fncG_DB_InsertDocument(cls_CM_Document objDoc)
		{
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("   insert into DC_DocumentsFJS    ");
			stringBuilder.Append("   (                           ");
			stringBuilder.Append("       ID                      ");
			stringBuilder.Append("       ,DocID                   ");
			stringBuilder.Append("       ,DocName                ");
			stringBuilder.Append("       ,DocFileName            ");
			stringBuilder.Append("       ,DocLanguage            ");
			stringBuilder.Append("       ,DocType                ");
			stringBuilder.Append("       ,DocClass               ");
			stringBuilder.Append("       ,DocExtension           ");
			stringBuilder.Append("       ,DocRevNo               ");
			bool flag = objDoc.PathInFPMG != null;
			if (flag)
			{
				stringBuilder.Append("   ,PathInFPMG             ");
			}
			bool flag2 = objDoc.PathInPAL != null;
			if (flag2)
			{
				stringBuilder.Append("   ,PathInPAL              ");
			}
			bool flag3 = objDoc.PathToDoc != null;
			if (flag3)
			{
				stringBuilder.Append("   ,PathToDoc              ");
			}
			bool flag4 = objDoc.Note != null;
			if (flag4)
			{
				stringBuilder.Append("   ,Note                   ");
			}
			stringBuilder.Append("       ,CreatedDate            ");
			stringBuilder.Append("       ,DocOwner               ");
			bool flag5 = objDoc.Tag != null;
			if (flag5)
			{
				stringBuilder.Append("       ,Tag               ");
			}
			stringBuilder.Append("   )                           ");
			stringBuilder.Append("   values                      ");
			stringBuilder.Append("   (                           ");
			stringBuilder.Append("       @ID                     ");
			stringBuilder.Append("       ,@DocID                  ");
			stringBuilder.Append("       ,@DocName               ");
			stringBuilder.Append("       ,@DocFileName           ");
			stringBuilder.Append("       ,@DocLanguage           ");
			stringBuilder.Append("       ,@DocType               ");
			stringBuilder.Append("       ,@DocClass              ");
			stringBuilder.Append("       ,@DocExtension          ");
			stringBuilder.Append("       ,@DocRevNo              ");
			bool flag6 = objDoc.PathInFPMG != null;
			if (flag6)
			{
				stringBuilder.Append("   ,@PathInFPMG            ");
			}
			bool flag7 = objDoc.PathInPAL != null;
			if (flag7)
			{
				stringBuilder.Append("   ,@PathInPAL             ");
			}
			bool flag8 = objDoc.PathToDoc != null;
			if (flag8)
			{
				stringBuilder.Append("   ,@PathToDoc             ");
			}
			bool flag9 = objDoc.Note != null;
			if (flag9)
			{
				stringBuilder.Append("   ,@Note                  ");
			}
			stringBuilder.Append("       ,@CreatedDate           ");
			stringBuilder.Append("       ,@Owner           ");
			bool flag10 = objDoc.Tag != null;
			if (flag10)
			{
				stringBuilder.Append("       ,@Tag               ");
			}
			stringBuilder.Append("   )                           ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar)).Value = objDoc.ID;
			parameters.Add(new SqlParameter("@DocID", SqlDbType.NVarChar)).Value = objDoc.DocId;
			parameters.Add(new SqlParameter("@DocName", SqlDbType.NVarChar)).Value = objDoc.Name;
			parameters.Add(new SqlParameter("@DocFileName", SqlDbType.NVarChar)).Value = objDoc.FileName;
			parameters.Add(new SqlParameter("@DocLanguage", SqlDbType.NVarChar)).Value = objDoc.Language.ID;
			parameters.Add(new SqlParameter("@DocType", SqlDbType.NVarChar)).Value = objDoc.Type.ID;
			parameters.Add(new SqlParameter("@DocClass", SqlDbType.NVarChar)).Value = objDoc.DocClass.ID;
			parameters.Add(new SqlParameter("@DocExtension", SqlDbType.NVarChar)).Value = objDoc.Extension;
			parameters.Add(new SqlParameter("@DocRevNo", SqlDbType.NVarChar)).Value = objDoc.RevNo;
			bool flag11 = objDoc.PathInFPMG != null;
			if (flag11)
			{
				parameters.Add(new SqlParameter("@PathInFPMG", SqlDbType.NVarChar)).Value = objDoc.PathInFPMG;
			}
			bool flag12 = objDoc.PathInPAL != null;
			if (flag12)
			{
				parameters.Add(new SqlParameter("@PathInPAL", SqlDbType.NVarChar)).Value = objDoc.PathInPAL;
			}
			bool flag13 = objDoc.PathToDoc != null;
			if (flag13)
			{
				parameters.Add(new SqlParameter("@PathToDoc", SqlDbType.NVarChar)).Value = objDoc.PathToDoc;
			}
			bool flag14 = objDoc.Note != null;
			if (flag14)
			{
				parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar)).Value = objDoc.Note;
			}
			parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.NVarChar)).Value = DateTime.Now.ToString("yyyyMMdd");
			parameters.Add(new SqlParameter("@Owner", SqlDbType.SmallInt)).Value = objDoc.Owner;
			bool flag15 = objDoc.Tag != null;
			if (flag15)
			{
				parameters.Add(new SqlParameter("@Tag", SqlDbType.NVarChar)).Value = objDoc.Tag;
			}
			mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			return true;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00029E18 File Offset: 0x00028018
		public DataTable fncG_DB_CountDoc(string strDocClass, string strDocYear)
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                         ");
			stringBuilder.Append("       count(doc.ID)                               ");
			stringBuilder.Append("   from                                            ");
			stringBuilder.Append("       DC_DocumentsFJS doc                            ");
			stringBuilder.Append("   where                                           ");
			stringBuilder.Append("       1 = 1                                       ");
			stringBuilder.Append("       and doc.DocClass = @DocClass                ");
			stringBuilder.Append("       and left(doc.CreatedDate, 4) = @DocYear     ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			parameters.Add(new SqlParameter("@DocClass", SqlDbType.NVarChar)).Value = strDocClass;
			parameters.Add(new SqlParameter("@DocYear", SqlDbType.NVarChar)).Value = strDocYear;
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00029F44 File Offset: 0x00028144
		public DataTable fncG_DB_SearchDocument(string strLanguageId, string strTypeId, string strClassId, string strDocName, string strTag, string strStartDate, string strEndDate)
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc.ID,                                 ");
			stringBuilder.Append("        doc.DocID,                              ");
			stringBuilder.Append("        doc.DocName,                            ");
			stringBuilder.Append("        doc.DocFileName,                        ");
			stringBuilder.Append("        doc.DocLanguage,                        ");
			stringBuilder.Append("        doc.DocType,                            ");
			stringBuilder.Append("        doc.DocClass,                           ");
			stringBuilder.Append("        doc.DocExtension,                       ");
			stringBuilder.Append("        doc.DocRevNo,                           ");
			stringBuilder.Append("        doc.PathInFPMG,                         ");
			stringBuilder.Append("        doc.PathInPAL,                          ");
			stringBuilder.Append("        doc.PathToDoc,                          ");
			stringBuilder.Append("        doc.Note,                               ");
			stringBuilder.Append("        doc.Tag,                                ");
			stringBuilder.Append("        doc_lan.Language,                       ");
			stringBuilder.Append("        doc_type.TypeName,                      ");
			stringBuilder.Append("        doc_cls.ClassName,                      ");
			stringBuilder.Append("        doc.DocOwner                            ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentsFJS doc,                       ");
			stringBuilder.Append("        DC_DocumentLanguage doc_lan,            ");
			stringBuilder.Append("        DC_DocumentType doc_type,               ");
			stringBuilder.Append("        DC_DocumentClass doc_cls                ");
			stringBuilder.Append("    where                                       ");
			stringBuilder.Append("        1 = 1                                   ");
			stringBuilder.Append("        and doc.IsDeleted = 0                   ");
			stringBuilder.Append("        and doc.DocLanguage = doc_lan.ID        ");
			stringBuilder.Append("        and doc.DocType = doc_type.ID           ");
			stringBuilder.Append("        and doc.DocClass = doc_cls.ID           ");
			bool flag = strLanguageId != null;
			if (flag)
			{
				stringBuilder.Append("    and doc_lan.ID = @LanguageId            ");
				parameters.Add(new SqlParameter("@LanguageId", SqlDbType.NVarChar)).Value = strLanguageId;
			}
			bool flag2 = strTypeId != null;
			if (flag2)
			{
				stringBuilder.Append("    and doc_type.ID = @TypeId               ");
				parameters.Add(new SqlParameter("@TypeId", SqlDbType.NVarChar)).Value = strTypeId;
			}
			bool flag3 = strClassId != null;
			if (flag3)
			{
				stringBuilder.Append("    and doc_cls.ID = @ClassId               ");
				parameters.Add(new SqlParameter("@ClassId", SqlDbType.NVarChar)).Value = strClassId;
			}
			bool flag4 = strDocName != null;
			if (flag4)
			{
				stringBuilder.Append("    and doc.DocName like @DocName           ");
				parameters.Add(new SqlParameter("@DocName", SqlDbType.NVarChar)).Value = "%" + strDocName + "%";
			}
			bool flag5 = strTag != null;
			if (flag5)
			{
				stringBuilder.Append("    and doc.Tag like @Tag           ");
				parameters.Add(new SqlParameter("@Tag", SqlDbType.NVarChar)).Value = "%" + strTag + "%";
			}
			stringBuilder.Append("    order by                                    ");
			stringBuilder.Append("        doc.DocName                             ");
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag6 = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag6)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0002A278 File Offset: 0x00028478
		public DataTable fncG_DB_GetDocumentByDocId(string strDocID)
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc.ID,                                 ");
			stringBuilder.Append("        doc.DocID,                              ");
			stringBuilder.Append("        doc.DocName,                            ");
			stringBuilder.Append("        doc.DocFileName,                        ");
			stringBuilder.Append("        doc.DocLanguage,                        ");
			stringBuilder.Append("        doc.DocType,                            ");
			stringBuilder.Append("        doc.DocClass,                           ");
			stringBuilder.Append("        doc.DocExtension,                       ");
			stringBuilder.Append("        doc.DocRevNo,                           ");
			stringBuilder.Append("        doc.PathInFPMG,                         ");
			stringBuilder.Append("        doc.PathInPAL,                          ");
			stringBuilder.Append("        doc.PathToDoc,                          ");
			stringBuilder.Append("        doc.Note,                               ");
			stringBuilder.Append("        doc_lan.Language,                       ");
			stringBuilder.Append("        doc_type.TypeName,                      ");
			stringBuilder.Append("        doc_cls.ClassName,                      ");
			stringBuilder.Append("        doc.DocOwner,                           ");
			stringBuilder.Append("        doc.DMSDocID                            ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentsFJS doc,                       ");
			stringBuilder.Append("        DC_DocumentLanguage doc_lan,            ");
			stringBuilder.Append("        DC_DocumentType doc_type,               ");
			stringBuilder.Append("        DC_DocumentClass doc_cls                ");
			stringBuilder.Append("    where                                       ");
			stringBuilder.Append("        1 = 1                                   ");
			stringBuilder.Append("        and doc.IsDeleted = 0                   ");
			stringBuilder.Append("        and doc.DocLanguage = doc_lan.ID        ");
			stringBuilder.Append("        and doc.DocType = doc_type.ID           ");
			stringBuilder.Append("        and doc.DocClass = doc_cls.ID           ");
			stringBuilder.Append("        and doc.DocID = @DocID                  ");
			stringBuilder.Append("    order by                                    ");
			stringBuilder.Append("        doc.DocID                               ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			parameters.Add(new SqlParameter("@DocID", SqlDbType.NVarChar)).Value = strDocID;
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0002A4B8 File Offset: 0x000286B8
		public DataTable fncG_DB_GetDocumentById(string strID)
		{
			DataTable result = null;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.Append("    select                                      ");
			stringBuilder.Append("        doc.ID,                                 ");
			stringBuilder.Append("        doc.DocID,                              ");
			stringBuilder.Append("        doc.DocName,                            ");
			stringBuilder.Append("        doc.DocFileName,                        ");
			stringBuilder.Append("        doc.DocLanguage,                        ");
			stringBuilder.Append("        doc.DocType,                            ");
			stringBuilder.Append("        doc.DocClass,                           ");
			stringBuilder.Append("        doc.DocExtension,                       ");
			stringBuilder.Append("        doc.DocRevNo,                           ");
			stringBuilder.Append("        doc.PathInFPMG,                         ");
			stringBuilder.Append("        doc.PathInPAL,                          ");
			stringBuilder.Append("        doc.PathToDoc,                          ");
			stringBuilder.Append("        doc.Note,                               ");
			stringBuilder.Append("        doc_lan.Language,                       ");
			stringBuilder.Append("        doc_type.TypeName,                      ");
			stringBuilder.Append("        doc_cls.ClassName,                      ");
			stringBuilder.Append("        doc.DocOwner,                            ");
			stringBuilder.Append("        doc.DMSDocID,                            ");
			stringBuilder.Append("        doc.Tag                               ");
			stringBuilder.Append("    from                                        ");
			stringBuilder.Append("        DC_DocumentsFJS doc,                       ");
			stringBuilder.Append("        DC_DocumentLanguage doc_lan,            ");
			stringBuilder.Append("        DC_DocumentType doc_type,               ");
			stringBuilder.Append("        DC_DocumentClass doc_cls                ");
			stringBuilder.Append("    where                                       ");
			stringBuilder.Append("        1 = 1                                   ");
			stringBuilder.Append("        and doc.IsDeleted = 0                   ");
			stringBuilder.Append("        and doc.DocLanguage = doc_lan.ID        ");
			stringBuilder.Append("        and doc.DocType = doc_type.ID           ");
			stringBuilder.Append("        and doc.DocClass = doc_cls.ID           ");
			stringBuilder.Append("        and doc.ID = @ID                        ");
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar)).Value = strID;
			stringBuilder.Append("    order by                                    ");
			stringBuilder.Append("        doc.DocID                               ");
			cls_DB_Dynaset cls_DB_Dynaset = mod_WMS_Declare.gvObj_Database.DBCreateDynaset(stringBuilder.ToString(), false, false);
			mod_WMS_Declare.rwl.ExitWriteLock();
			bool flag = cls_DB_Dynaset != null && cls_DB_Dynaset.Dynaset.Tables.Count > 0;
			if (flag)
			{
				result = cls_DB_Dynaset.Dynaset.Tables[0];
			}
			return result;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002A704 File Offset: 0x00028904
		public bool fncG_DB_UpdateDocument(cls_CM_Document objDoc)
		{
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.AppendLine("   update DC_DocumentsFJS                 ");
			stringBuilder.AppendLine("   set                                 ");
			stringBuilder.AppendLine("   DocID = @DocID,                 ");
			stringBuilder.AppendLine("   DocName = @DocName,             ");
			stringBuilder.AppendLine("   DocFileName = @DocFileName,     ");
			stringBuilder.AppendLine("   DocLanguage = @DocLanguage,     ");
			stringBuilder.AppendLine("   DocType = @DocType,             ");
			stringBuilder.AppendLine("   DocClass = @DocClass,           ");
			stringBuilder.AppendLine("   DocRevNo = @DocRevNo,           ");
			stringBuilder.AppendLine("   PathInFPMG = @PathInFPMG,       ");
			stringBuilder.AppendLine("   PathInPAL = @PathInPAL,         ");
			stringBuilder.AppendLine("   PathToDoc = @PathToDoc,         ");
			stringBuilder.AppendLine("   Note = @Note,         ");
			stringBuilder.AppendLine("   DocOwner = @Owner         ");
			stringBuilder.AppendLine("   ,Tag = @Tag         ");
			parameters.Add(new SqlParameter("@DocID", SqlDbType.NVarChar)).Value = objDoc.DocId;
			parameters.Add(new SqlParameter("@DocName", SqlDbType.NVarChar)).Value = objDoc.Name;
			parameters.Add(new SqlParameter("@DocFileName", SqlDbType.NVarChar)).Value = objDoc.FileName;
			parameters.Add(new SqlParameter("@DocLanguage", SqlDbType.NVarChar)).Value = objDoc.Language.ID;
			parameters.Add(new SqlParameter("@DocType", SqlDbType.NVarChar)).Value = objDoc.Type.ID;
			parameters.Add(new SqlParameter("@DocClass", SqlDbType.NVarChar)).Value = objDoc.DocClass.ID;
			parameters.Add(new SqlParameter("@DocRevNo", SqlDbType.NVarChar)).Value = objDoc.RevNo;
			parameters.Add(new SqlParameter("@PathInFPMG", SqlDbType.NVarChar)).Value = objDoc.PathInFPMG;
			parameters.Add(new SqlParameter("@PathInPAL", SqlDbType.NVarChar)).Value = objDoc.PathInPAL;
			parameters.Add(new SqlParameter("@PathToDoc", SqlDbType.NVarChar)).Value = objDoc.PathToDoc;
			parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar)).Value = objDoc.Note;
			parameters.Add(new SqlParameter("@Owner", SqlDbType.SmallInt)).Value = objDoc.Owner;
			parameters.Add(new SqlParameter("@Tag", SqlDbType.NVarChar)).Value = objDoc.Tag;
			stringBuilder.AppendLine("   where                               ");
			stringBuilder.AppendLine("       ID = @ID                        ");
			parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar)).Value = objDoc.ID;
			mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
			bool result = true;
			mod_WMS_Declare.rwl.ExitWriteLock();
			return result;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0002A9E8 File Offset: 0x00028BE8
		public bool fncG_DB_DeleteDocument(cls_CM_Document objDoc)
		{
			mod_WMS_Declare.rwl.EnterWriteLock();
			cls_DB_ParameterCollection parameters = mod_WMS_Declare.gvObj_Database.Parameters;
			parameters.Clear();
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.AppendLine("   update DC_DocumentsFJS                 ");
			stringBuilder.AppendLine("   set                                 ");
			stringBuilder.AppendLine("   IsDeleted = 1                       ");
			stringBuilder.AppendLine("   where                               ");
			stringBuilder.AppendLine("       ID = @ID                        ");
			parameters.Add(new SqlParameter("@ID", SqlDbType.NVarChar)).Value = objDoc.ID;
			mod_WMS_Declare.gvObj_Database.DBExecuteSQL(stringBuilder.ToString(), false);
			bool result = true;
			mod_WMS_Declare.rwl.ExitWriteLock();
			return result;
		}
	}
}
