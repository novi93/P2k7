using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2k7.Core.Behavior.DB_SQLServer;

namespace P2k7.Core.Behavior
{
	// Token: 0x0200009B RID: 155
	public class cls_CM_Document
	{
		//// Token: 0x1700023A RID: 570
		//// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00028528 File Offset: 0x00026728
		//// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00028540 File Offset: 0x00026740
		//public string ID
		//{
		//	get
		//	{
		//		return this.strID;
		//	}
		//	set
		//	{
		//		this.strID = value;
		//	}
		//}

		//// Token: 0x1700023B RID: 571
		//// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0002854C File Offset: 0x0002674C
		//// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00028564 File Offset: 0x00026764
		//public string DocId
		//{
		//	get
		//	{
		//		return this.strDocID;
		//	}
		//	set
		//	{
		//		this.strDocID = value;
		//	}
		//}

		//// Token: 0x1700023C RID: 572
		//// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00028570 File Offset: 0x00026770
		//// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00028588 File Offset: 0x00026788
		//public string Name
		//{
		//	get
		//	{
		//		return this.strDocName;
		//	}
		//	set
		//	{
		//		this.strDocName = value;
		//	}
		//}

		//// Token: 0x1700023D RID: 573
		//// (get) Token: 0x060006CA RID: 1738 RVA: 0x00028594 File Offset: 0x00026794
		//// (set) Token: 0x060006CB RID: 1739 RVA: 0x000285AC File Offset: 0x000267AC
		//public string FileName
		//{
		//	get
		//	{
		//		return this.strDocFileName;
		//	}
		//	set
		//	{
		//		this.strDocFileName = value;
		//	}
		//}

		//// Token: 0x1700023E RID: 574
		//// (get) Token: 0x060006CC RID: 1740 RVA: 0x000285B8 File Offset: 0x000267B8
		//// (set) Token: 0x060006CD RID: 1741 RVA: 0x000285D0 File Offset: 0x000267D0
		//public string Extension
		//{
		//	get
		//	{
		//		return this.strDocExtension;
		//	}
		//	set
		//	{
		//		this.strDocExtension = value;
		//	}
		//}

		//// Token: 0x1700023F RID: 575
		//// (get) Token: 0x060006CE RID: 1742 RVA: 0x000285DC File Offset: 0x000267DC
		//// (set) Token: 0x060006CF RID: 1743 RVA: 0x000285F4 File Offset: 0x000267F4
		//public string RevNo
		//{
		//	get
		//	{
		//		return this.strDocRevNo;
		//	}
		//	set
		//	{
		//		this.strDocRevNo = value;
		//	}
		//}

		//// Token: 0x17000240 RID: 576
		//// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00028600 File Offset: 0x00026800
		//// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00028618 File Offset: 0x00026818
		//public string PathInFPMG
		//{
		//	get
		//	{
		//		return this.strPathInFPMG;
		//	}
		//	set
		//	{
		//		this.strPathInFPMG = value;
		//	}
		//}

		//// Token: 0x17000241 RID: 577
		//// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00028624 File Offset: 0x00026824
		//// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0002863C File Offset: 0x0002683C
		//public string PathInPAL
		//{
		//	get
		//	{
		//		return this.strPathInPAL;
		//	}
		//	set
		//	{
		//		this.strPathInPAL = value;
		//	}
		//}

		//// Token: 0x17000242 RID: 578
		//// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00028648 File Offset: 0x00026848
		//// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00028660 File Offset: 0x00026860
		//public string PathToDoc
		//{
		//	get
		//	{
		//		return this.strPathToDoc;
		//	}
		//	set
		//	{
		//		this.strPathToDoc = value;
		//	}
		//}

		//// Token: 0x17000243 RID: 579
		//// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0002866C File Offset: 0x0002686C
		//// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00028684 File Offset: 0x00026884
		//public cls_CM_DocumentLanguage Language
		//{
		//	get
		//	{
		//		return this.mvObj_DocLanguage;
		//	}
		//	set
		//	{
		//		this.mvObj_DocLanguage = value;
		//	}
		//}

		//// Token: 0x17000244 RID: 580
		//// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00028690 File Offset: 0x00026890
		//// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000286A8 File Offset: 0x000268A8
		//public cls_CM_DocumentType Type
		//{
		//	get
		//	{
		//		return this.mvObj_DocType;
		//	}
		//	set
		//	{
		//		this.mvObj_DocType = value;
		//	}
		//}

		//// Token: 0x17000245 RID: 581
		//// (get) Token: 0x060006DA RID: 1754 RVA: 0x000286B4 File Offset: 0x000268B4
		//// (set) Token: 0x060006DB RID: 1755 RVA: 0x000286CC File Offset: 0x000268CC
		//public cls_CM_DocumentClass DocClass
		//{
		//	get
		//	{
		//		return this.mvObj_DocClass;
		//	}
		//	set
		//	{
		//		this.mvObj_DocClass = value;
		//	}
		//}

		//// Token: 0x17000246 RID: 582
		//// (get) Token: 0x060006DC RID: 1756 RVA: 0x000286D8 File Offset: 0x000268D8
		//// (set) Token: 0x060006DD RID: 1757 RVA: 0x000286F0 File Offset: 0x000268F0
		//public string Note
		//{
		//	get
		//	{
		//		return this.strNote;
		//	}
		//	set
		//	{
		//		this.strNote = value;
		//	}
		//}

		//// Token: 0x17000247 RID: 583
		//// (get) Token: 0x060006DE RID: 1758 RVA: 0x000286FC File Offset: 0x000268FC
		//// (set) Token: 0x060006DF RID: 1759 RVA: 0x00028714 File Offset: 0x00026914
		//public mod_WMS_Declare.gcObj_DocumentOwner Owner
		//{
		//	get
		//	{
		//		return this.objOwner;
		//	}
		//	set
		//	{
		//		this.objOwner = value;
		//	}
		//}

		//// Token: 0x17000248 RID: 584
		//// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00028720 File Offset: 0x00026920
		//// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00028738 File Offset: 0x00026938
		//public string Tag
		//{
		//	get
		//	{
		//		return this.strTag;
		//	}
		//	set
		//	{
		//		this.strTag = value;
		//	}
		//}

		//// Token: 0x17000249 RID: 585
		//// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00028744 File Offset: 0x00026944
		//// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0002875C File Offset: 0x0002695C
		//public long DMSDocID
		//{
		//	get
		//	{
		//		return this.dbDMSDocID;
		//	}
		//	set
		//	{
		//		this.dbDMSDocID = value;
		//	}
		//}

		//// Token: 0x060006E4 RID: 1764 RVA: 0x00028768 File Offset: 0x00026968
		//public cls_CM_Document()
		//{
		//	this.mvObj_DocLanguage = new cls_CM_DocumentLanguage();
		//	this.mvObj_DocType = new cls_CM_DocumentType();
		//	this.mvObj_DocClass = new cls_CM_DocumentClass();
		//	this.strID = "";
		//	this.strDocID = "";
		//	this.strDocName = "";
		//	this.strDocFileName = "";
		//	this.strDocExtension = "";
		//	this.strDocRevNo = "";
		//	this.strPathInFPMG = "";
		//	this.strPathInPAL = "";
		//	this.strPathToDoc = "";
		//	this.strNote = "";
		//	this.strTag = "";
		//	this.dbDMSDocID = 0L;
		//	this.objOwner = mod_WMS_Declare.gcObj_DocumentOwner.CMMIOwner;
		//}

		//// Token: 0x060006E5 RID: 1765 RVA: 0x00028828 File Offset: 0x00026A28
		//public cls_CM_Document(cls_CM_Document iObj_Input)
		//{
		//	this.mvObj_DocLanguage = new cls_CM_DocumentLanguage();
		//	this.mvObj_DocType = new cls_CM_DocumentType();
		//	this.mvObj_DocClass = new cls_CM_DocumentClass();
		//	this.mvObj_DocLanguage = iObj_Input.Language;
		//	this.mvObj_DocType = iObj_Input.Type;
		//	this.mvObj_DocClass = iObj_Input.DocClass;
		//	this.strID = iObj_Input.ID;
		//	this.strDocID = iObj_Input.DocId;
		//	this.strDocName = iObj_Input.Name;
		//	this.strDocFileName = iObj_Input.FileName;
		//	this.strDocExtension = iObj_Input.Extension;
		//	this.strDocRevNo = iObj_Input.RevNo;
		//	this.strPathInFPMG = iObj_Input.PathInFPMG;
		//	this.strPathInPAL = iObj_Input.PathInPAL;
		//	this.strPathToDoc = iObj_Input.PathToDoc;
		//	this.strNote = iObj_Input.Note;
		//	this.objOwner = iObj_Input.objOwner;
		//	this.strTag = iObj_Input.Tag;
		//	this.dbDMSDocID = iObj_Input.DMSDocID;
		//}

		//// Token: 0x060006E6 RID: 1766 RVA: 0x00028920 File Offset: 0x00026B20
		//public void fncGetDocFromId(string wStrDocID)
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	DataTable dataTable = cls_DB_Document.fncG_DB_GetDocumentByDocId(wStrDocID);
		//	bool flag = dataTable != null;
		//	if (flag)
		//	{
		//		bool flag2 = dataTable.Rows.Count > 0;
		//		if (flag2)
		//		{
		//			this.strID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["ID"]));
		//			this.strDocID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocID"]));
		//			this.strDocName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocName"]));
		//			this.strDocFileName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocFileName"]));
		//			this.mvObj_DocLanguage.ID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocLanguage"]));
		//			this.mvObj_DocLanguage.Name = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["Language"]));
		//			this.mvObj_DocType.ID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocType"]));
		//			this.mvObj_DocType.TypeName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["TypeName"]));
		//			this.mvObj_DocClass.ID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocClass"]));
		//			this.mvObj_DocClass.ClassName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["ClassName"]));
		//			this.strDocExtension = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocExtension"]));
		//			this.strDocRevNo = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocRevNo"]));
		//			this.strPathInFPMG = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["PathInFPMG"], "")));
		//			this.strPathInPAL = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["PathInPAL"], "")));
		//			this.strPathToDoc = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["PathToDoc"], "")));
		//			this.strNote = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["Note"], "")));
		//			this.dbDMSDocID = Conversions.ToLong(dataTable.Rows[0]["DMSDocID"]);
		//		}
		//	}
		//}

		//// Token: 0x060006E7 RID: 1767 RVA: 0x00028C30 File Offset: 0x00026E30
		//public void fncGetDocById(string wStrId)
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	DataTable dataTable = cls_DB_Document.fncG_DB_GetDocumentById(wStrId);
		//	bool flag = dataTable != null;
		//	if (flag)
		//	{
		//		bool flag2 = dataTable.Rows.Count > 0;
		//		if (flag2)
		//		{
		//			this.strID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["ID"]));
		//			this.strDocID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocID"]));
		//			this.strDocName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocName"]));
		//			this.strDocFileName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocFileName"]));
		//			this.mvObj_DocLanguage.ID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocLanguage"]));
		//			this.mvObj_DocLanguage.Name = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["Language"]));
		//			this.mvObj_DocType.ID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocType"]));
		//			this.mvObj_DocType.TypeName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["TypeName"]));
		//			this.mvObj_DocClass.ID = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocClass"]));
		//			this.mvObj_DocClass.ClassName = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["ClassName"]));
		//			this.strDocExtension = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocExtension"]));
		//			this.strDocRevNo = StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DocRevNo"]));
		//			this.strPathInFPMG = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["PathInFPMG"], "")));
		//			this.strPathInPAL = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["PathInPAL"], "")));
		//			this.strPathToDoc = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["PathToDoc"], "")));
		//			this.strNote = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["Note"], "")));
		//			this.strTag = StringUtil.fncTrim(Conversions.ToString(Operators.AddObject(dataTable.Rows[0]["Tag"], "")));
		//			this.dbDMSDocID = Conversions.ToLong(StringUtil.fncTrim(Conversions.ToString(dataTable.Rows[0]["DMSDocID"])));
		//		}
		//	}
		//}

		//// Token: 0x060006E8 RID: 1768 RVA: 0x00028F78 File Offset: 0x00027178
		//public static DataTable fncG_CM_GetDocumentList()
		//{
		//	DataTable result = null;
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	result = cls_DB_Document.fncG_DB_GetDocumentList();
		//	cls_CM_Document.AddPathSaveDoc(ref result);
		//	return result;
		//}

		//// Token: 0x060006E9 RID: 1769 RVA: 0x00028FA4 File Offset: 0x000271A4
		//private static void AddPathSaveDoc(ref DataTable DocList)
		//{
		//	cls_CM_ProjectDirectoryTemplate cls_CM_ProjectDirectoryTemplate = new cls_CM_ProjectDirectoryTemplate();
		//	DataColumn column = DocList.Columns.Add("PathInT", typeof(string));
		//	try
		//	{
		//		foreach (object obj in DocList.Rows)
		//		{
		//			DataRow dataRow = (DataRow)obj;
		//			ArrayList arrayList = cls_CM_ProjectDirectoryTemplate.fncG_CM_GetPathToDoc(Conversions.ToString(dataRow["DocID"]));
		//			bool flag = arrayList.Count != 0;
		//			if (flag)
		//			{
		//				dataRow[column] = RuntimeHelpers.GetObjectValue(arrayList[0]);
		//			}
		//			else
		//			{
		//				dataRow[column] = "";
		//			}
		//		}
		//	}
		//	finally
		//	{
		//		//IEnumerator enumerator;
		//		//if (enumerator is IDisposable)
		//		//{
		//		//	(enumerator as IDisposable).Dispose();
				
		//	}
		//}

		//// Token: 0x060006EA RID: 1770 RVA: 0x00029074 File Offset: 0x00027274
		//public DataTable fncG_CM_GetClassList()
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_GetClassList();
		//}

		//// Token: 0x060006EB RID: 1771 RVA: 0x00029098 File Offset: 0x00027298
		//public static DataTable fncG_CM_GetTypeList()
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_GetTypeList();
		//}

		//// Token: 0x060006EC RID: 1772 RVA: 0x000290BC File Offset: 0x000272BC
		//public static DataTable fncG_CM_GetLanguageList()
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_GetLanguageList();
		//}

		//// Token: 0x060006ED RID: 1773 RVA: 0x000290E0 File Offset: 0x000272E0
		//public bool fncG_CM_InsertDocument()
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_InsertDocument(this);
		//}

		//// Token: 0x060006EE RID: 1774 RVA: 0x00029104 File Offset: 0x00027304
		//public static DataTable fncG_CM_CountDoc(string strDocClass, string strDocYear)
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_CountDoc(strDocClass, strDocYear);
		//}

		//// Token: 0x060006EF RID: 1775 RVA: 0x00029128 File Offset: 0x00027328
		//public static DataTable fncG_CM_SearchDocument(string strLanguageId, string strTypeId, string strClassId, string strDocName, string strTag, string strStartDate, string strEndDate)
		//{
		//	DataTable result = null;
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	result = cls_DB_Document.fncG_DB_SearchDocument(strLanguageId, strTypeId, strClassId, strDocName, strTag, strStartDate, strEndDate);
		//	cls_CM_Document.AddPathSaveDoc(ref result);
		//	return result;
		//}

		//// Token: 0x060006F0 RID: 1776 RVA: 0x0002915C File Offset: 0x0002735C
		//public bool fncG_CM_Update()
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_UpdateDocument(this);
		//}

		//// Token: 0x060006F1 RID: 1777 RVA: 0x00029180 File Offset: 0x00027380
		//public bool fncG_CM_Delete()
		//{
		//	cls_DB_Document cls_DB_Document = new cls_DB_Document();
		//	return cls_DB_Document.fncG_DB_DeleteDocument(this);
		//}

		//// Token: 0x060006F2 RID: 1778 RVA: 0x000291A1 File Offset: 0x000273A1
		//public void subG_CM_GenerateID()
		//{
		//	//todo
		//	//this.ID = cls_CM_Function.fncG_CM_GenerateNewIDFromTable("DC_DocumentsFJS");
		//}

		//// Token: 0x060006F3 RID: 1779 RVA: 0x000291B8 File Offset: 0x000273B8
		//public static bool fncG_CM_CheckFileName(string FileName)
		//{
		//	bool flag = FileName == null;
		//	checked
		//	{
		//		bool result;
		//		if (flag)
		//		{
		//			result = false;
		//		}
		//		else
		//		{
		//			int num = cls_CM_Document.INVALID_CHARS_IN_FILENAME.Length - 1;
		//			for (int i = 0; i <= num; i++)
		//			{
		//				bool flag2 = FileName.Contains(cls_CM_Document.INVALID_CHARS_IN_FILENAME[i]);
		//				if (flag2)
		//				{
		//					return false;
		//				}
		//			}
		//			result = true;
		//		}
		//		return result;
		//	}
		//}

		//// Token: 0x040004C9 RID: 1225
		//private string strID;

		//// Token: 0x040004CA RID: 1226
		//private string strDocID;

		//// Token: 0x040004CB RID: 1227
		//private string strDocName;

		//// Token: 0x040004CC RID: 1228
		//private string strDocFileName;

		//// Token: 0x040004CD RID: 1229
		//private string strDocExtension;

		//// Token: 0x040004CE RID: 1230
		//private string strDocRevNo;

		//// Token: 0x040004CF RID: 1231
		//private string strPathInFPMG;

		//// Token: 0x040004D0 RID: 1232
		//private string strPathInPAL;

		//// Token: 0x040004D1 RID: 1233
		//private string strPathToDoc;

		//// Token: 0x040004D2 RID: 1234
		//private string strNote;

		//// Token: 0x040004D3 RID: 1235
		//private string strTag;

		//// Token: 0x040004D4 RID: 1236
		//private mod_WMS_Declare.gcObj_DocumentOwner objOwner;

		//// Token: 0x040004D5 RID: 1237
		//private long dbDMSDocID;

		//// Token: 0x040004D6 RID: 1238
		//private cls_CM_DocumentLanguage mvObj_DocLanguage;

		//// Token: 0x040004D7 RID: 1239
		//private cls_CM_DocumentType mvObj_DocType;

		//// Token: 0x040004D8 RID: 1240
		//private cls_CM_DocumentClass mvObj_DocClass;

		//// Token: 0x040004D9 RID: 1241
		//private static string[] INVALID_CHARS_IN_FILENAME = new string[]
		//{
		//	"\\",
		//	"/",
		//	":",
		//	"*",
		//	"<",
		//	">",
		//	"|",
		//	"\"",
		//	"?"
		//};
	}
}
