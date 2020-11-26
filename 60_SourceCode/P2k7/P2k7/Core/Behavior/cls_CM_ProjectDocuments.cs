using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2k7.Core.Behavior
{
	// Token: 0x020000A4 RID: 164
	public class cls_CM_ProjectDocuments : cls_CM_Document
	{
		//// Token: 0x17000257 RID: 599
		//// (get) Token: 0x06000726 RID: 1830 RVA: 0x0002AFD4 File Offset: 0x000291D4
		//// (set) Token: 0x06000727 RID: 1831 RVA: 0x0002AFEC File Offset: 0x000291EC
		//public string Path
		//{
		//	get
		//	{
		//		return this.mvStr_PathToDoc;
		//	}
		//	set
		//	{
		//		this.mvStr_PathToDoc = value;
		//	}
		//}

		//// Token: 0x17000258 RID: 600
		//// (get) Token: 0x06000728 RID: 1832 RVA: 0x0002AFF8 File Offset: 0x000291F8
		//// (set) Token: 0x06000729 RID: 1833 RVA: 0x0002B010 File Offset: 0x00029210
		//public string TemplateFileName
		//{
		//	get
		//	{
		//		return this.mvStr_TemplateFileName;
		//	}
		//	set
		//	{
		//		this.mvStr_TemplateFileName = value;
		//	}
		//}

		//// Token: 0x17000259 RID: 601
		//// (get) Token: 0x0600072A RID: 1834 RVA: 0x0002B01C File Offset: 0x0002921C
		//// (set) Token: 0x0600072B RID: 1835 RVA: 0x0002B034 File Offset: 0x00029234
		//public bool IsFile
		//{
		//	get
		//	{
		//		return this.mvBln_IsFile;
		//	}
		//	set
		//	{
		//		this.mvBln_IsFile = value;
		//	}
		//}

		//// Token: 0x1700025A RID: 602
		//// (get) Token: 0x0600072C RID: 1836 RVA: 0x0002B040 File Offset: 0x00029240
		//// (set) Token: 0x0600072D RID: 1837 RVA: 0x0002B058 File Offset: 0x00029258
		//public string Description
		//{
		//	get
		//	{
		//		return this.mvStr_Description;
		//	}
		//	set
		//	{
		//		this.mvStr_Description = value;
		//	}
		//}

		//// Token: 0x1700025B RID: 603
		//// (get) Token: 0x0600072E RID: 1838 RVA: 0x0002B064 File Offset: 0x00029264
		//// (set) Token: 0x0600072F RID: 1839 RVA: 0x0002B07C File Offset: 0x0002927C
		//public DateTime CreateDate
		//{
		//	get
		//	{
		//		return this._createDate;
		//	}
		//	set
		//	{
		//		this._createDate = value;
		//	}
		//}

		//// Token: 0x1700025C RID: 604
		//// (get) Token: 0x06000730 RID: 1840 RVA: 0x0002B088 File Offset: 0x00029288
		//// (set) Token: 0x06000731 RID: 1841 RVA: 0x0002B0A0 File Offset: 0x000292A0
		//public DateTime LastUpdateDate
		//{
		//	get
		//	{
		//		return this._lastUpdateDate;
		//	}
		//	set
		//	{
		//		this._lastUpdateDate = value;
		//	}
		//}

		//// Token: 0x1700025D RID: 605
		//// (get) Token: 0x06000732 RID: 1842 RVA: 0x0002B0AC File Offset: 0x000292AC
		//// (set) Token: 0x06000733 RID: 1843 RVA: 0x0002B0C4 File Offset: 0x000292C4
		//public cls_CM_Staff_Abridged CreateBy
		//{
		//	get
		//	{
		//		return this._createBy;
		//	}
		//	set
		//	{
		//		this._createBy = value;
		//	}
		//}

		//// Token: 0x1700025E RID: 606
		//// (get) Token: 0x06000734 RID: 1844 RVA: 0x0002B0D0 File Offset: 0x000292D0
		//// (set) Token: 0x06000735 RID: 1845 RVA: 0x0002B0E8 File Offset: 0x000292E8
		//public cls_CM_Staff_Abridged LastUpdateBy
		//{
		//	get
		//	{
		//		return this._lastUpdateBy;
		//	}
		//	set
		//	{
		//		this._lastUpdateBy = value;
		//	}
		//}

		//// Token: 0x06000736 RID: 1846 RVA: 0x0002B0F2 File Offset: 0x000292F2
		//public cls_CM_ProjectDocuments()
		//{
		//	this.iObj_Found = new NameValueCollection();
		//	this.mvStr_PathToDoc = "";
		//	this.mvStr_TemplateFileName = "";
		//	this.mvBln_IsFile = true;
		//	this.mvStr_Description = "";
		//}

		//// Token: 0x06000737 RID: 1847 RVA: 0x0002B130 File Offset: 0x00029330
		//public bool subG_PJ_CreateDocFromTemplate(string iStr_PathOnT)
		//{
		//	bool flag = !Directory.Exists(iStr_PathOnT);
		//	bool result;
		//	if (flag)
		//	{
		//		result = false;
		//	}
		//	else
		//	{
		//		bool flag2 = !this.DownloadTemplateFileFromWMS(iStr_PathOnT);
		//		bool flag3 = !flag2;
		//		result = flag3;
		//	}
		//	return result;
		//}

		//// Token: 0x06000738 RID: 1848 RVA: 0x0002B16C File Offset: 0x0002936C
		//public new void subG_CM_GenerateID()
		//{
		//	base.ID = cls_CM_Function.fncG_CM_GenerateNewIDFromTable("PRJ_Documents");
		//}

		//// Token: 0x06000739 RID: 1849 RVA: 0x0002B180 File Offset: 0x00029380
		//public bool DownloadTemplateFileFromWMS(string iStr_PathOnT)
		//{
		//	RestClient restClient = new RestClient("https://wms.fujinet.vn:7443/dms/restapi");
		//	restClient.CookieContainer = new CookieContainer();
		//	RestRequest restRequest = new RestRequest("index.php/login", Method.POST);
		//	restRequest.AddHeader("Accept", "application/json");
		//	restRequest.AddParameter("user", "restapiuser");
		//	restRequest.AddParameter("pass", "Abc12345");
		//	IRestResponse restResponse = restClient.Execute(restRequest);
		//	bool flag = base.DMSDocID.ToString().Equals("") | base.DMSDocID == 0L;
		//	bool result;
		//	if (flag)
		//	{
		//		bool flag2 = false;
		//		result = flag2;
		//	}
		//	else
		//	{
		//		RestRequest restRequest2 = new RestRequest(string.Format("/index.php/document/{0}", base.DMSDocID), Method.GET);
		//		restRequest2.AddHeader("Accept", "application/json");
		//		IRestResponse restResponse2 = restClient.Execute(restRequest2);
		//		bool flag3 = restResponse2.StatusCode != HttpStatusCode.OK;
		//		bool flag2;
		//		if (flag3)
		//		{
		//			MessageBox.Show("Template " + this.TemplateFileName + " không tồn tại file");
		//			flag2 = false;
		//		}
		//		else
		//		{
		//			string content = restResponse2.Content;
		//			JObject jobject = JObject.Parse(content);
		//			cls_CM_DMSDoc cls_CM_DMSDoc = SimpleJson.DeserializeObject<cls_CM_DMSDoc>(jobject["data"].ToString());
		//			RestRequest restRequest3 = new RestRequest(string.Format("/index.php/document/{0}/version/{1}", base.DMSDocID, cls_CM_DMSDoc.version), Method.GET);
		//			restRequest3.AddHeader("Accept", "application\\\\/pdf");
		//			IRestResponse restResponse3 = restClient.Execute(restRequest3);
		//			string content2 = restResponse3.Content;
		//			cls_CM_ProjectDirectoryTemplate cls_CM_ProjectDirectoryTemplate = new cls_CM_ProjectDirectoryTemplate();
		//			string str = Conversions.ToString(cls_CM_ProjectDirectoryTemplate.fncG_CM_GetPathToDoc(base.DocId)[0]);
		//			this.Path = iStr_PathOnT + "\\" + str;
		//			bool flag4 = Directory.Exists(this.Path);
		//			if (flag4)
		//			{
		//				string path = string.Concat(new string[]
		//				{
		//					this.Path,
		//					"\\",
		//					base.FileName,
		//					".",
		//					base.Extension
		//				});
		//				bool flag5 = !File.Exists(path);
		//				if (flag5)
		//				{
		//					restClient.DownloadData(restRequest3).SaveAs(path);
		//					flag2 = true;
		//				}
		//			}
		//			else
		//			{
		//				flag2 = false;
		//			}
		//		}
		//		result = flag2;
		//	}
		//	return result;
		//}

		//// Token: 0x040004E8 RID: 1256
		//private string mvStr_PathToDoc;

		//// Token: 0x040004E9 RID: 1257
		//private string mvStr_TemplateFileName;

		//// Token: 0x040004EA RID: 1258
		//private bool mvBln_IsFile;

		//// Token: 0x040004EB RID: 1259
		//private string mvStr_Description;

		//// Token: 0x040004EC RID: 1260
		//private NameValueCollection iObj_Found;

		//// Token: 0x040004ED RID: 1261
		//private string[] iObj_DirectoryList;

		//// Token: 0x040004EE RID: 1262
		//private string[] iObj_FileArray;

		//// Token: 0x040004EF RID: 1263
		//private DateTime _createDate;

		//// Token: 0x040004F0 RID: 1264
		//private DateTime _lastUpdateDate;

		//// Token: 0x040004F1 RID: 1265
		//private cls_CM_Staff_Abridged _createBy;

		//// Token: 0x040004F2 RID: 1266
		//private cls_CM_Staff_Abridged _lastUpdateBy;
	}
}
