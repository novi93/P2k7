using Microsoft.VisualBasic.CompilerServices;
using P2k7.Core.Behavior.DB_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2k7.Core.Behavior
{
	// Token: 0x02000119 RID: 281
	public class cls_CM_Project
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00064C8C File Offset: 0x00062E8C
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00064CA4 File Offset: 0x00062EA4
		public string ID
		{
			get
			{
				return this.mvInt_ID;
			}
			set
			{
				this.mvInt_ID = value;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00064CB0 File Offset: 0x00062EB0
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00064CC8 File Offset: 0x00062EC8
		public string ProjectID
		{
			get
			{
				return this.mvStr_ProjectID;
			}
			set
			{
				this.mvStr_ProjectID = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00064CD4 File Offset: 0x00062ED4
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00064CEC File Offset: 0x00062EEC
		public string Name
		{
			get
			{
				return this.mvStr_ProjectName;
			}
			set
			{
				this.mvStr_ProjectName = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00064CF8 File Offset: 0x00062EF8
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x00064D10 File Offset: 0x00062F10
		public string ProjectNameOnRepositoriesSVN
		{
			get
			{
				return this.mvStr_ProjectNameOnRepositoriesSVN;
			}
			set
			{
				this.mvStr_ProjectNameOnRepositoriesSVN = value;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00064D1C File Offset: 0x00062F1C
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00064D34 File Offset: 0x00062F34
		public List<cls_CM_ProjectDocuments> Documents
		{
			get
			{
				return this.mvObj_Documents;
			}
			set
			{
				this.mvObj_Documents = value;
			}
		}

		//// Token: 0x17000596 RID: 1430
		//// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00064D40 File Offset: 0x00062F40
		//// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00064D58 File Offset: 0x00062F58
		//public cls_CM_Customer Customer
		//{
		//	get
		//	{
		//		return this.mvObj_Customer;
		//	}
		//	set
		//	{
		//		this.mvObj_Customer = value;
		//	}
		//}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00064D64 File Offset: 0x00062F64
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00064D7C File Offset: 0x00062F7C
		public string PlanStartDate
		{
			get
			{
				return this.mvDat_PlanStartDate;
			}
			set
			{
				this.mvDat_PlanStartDate = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00064D88 File Offset: 0x00062F88
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00064DA0 File Offset: 0x00062FA0
		public string PlanEndDate
		{
			get
			{
				return this.mvDat_PlanEndDate;
			}
			set
			{
				this.mvDat_PlanEndDate = value;
			}
		}

		//// Token: 0x17000599 RID: 1433
		//// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00064DAC File Offset: 0x00062FAC
		//// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00064DC4 File Offset: 0x00062FC4
		//public cls_CM_Staff_Abridged Manager
		//{
		//	get
		//	{
		//		return this.mvObj_Manager;
		//	}
		//	set
		//	{
		//		this.mvObj_Manager = value;
		//	}
		//}

		//// Token: 0x1700059A RID: 1434
		//// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00064DD0 File Offset: 0x00062FD0
		//// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00064DE8 File Offset: 0x00062FE8
		//public cls_CM_Staff_Abridged ProjectManager
		//{
		//	get
		//	{
		//		return this.mvObj_ProjectManager;
		//	}
		//	set
		//	{
		//		this.mvObj_ProjectManager = value;
		//	}
		//}

		//// Token: 0x1700059B RID: 1435
		//// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00064DF4 File Offset: 0x00062FF4
		//// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00064E0C File Offset: 0x0006300C
		//public cls_CM_Staff_Abridged ProjectLeader
		//{
		//	get
		//	{
		//		return this.mvObj_ProjectLeader;
		//	}
		//	set
		//	{
		//		this.mvObj_ProjectLeader = value;
		//	}
		//}

		//// Token: 0x1700059C RID: 1436
		//// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00064E18 File Offset: 0x00063018
		//// (set) Token: 0x06000F65 RID: 3941 RVA: 0x00064E30 File Offset: 0x00063030
		//public cls_CM_Staff_Abridged ProjectQA
		//{
		//	get
		//	{
		//		return this.mvObj_ProjectQA;
		//	}
		//	set
		//	{
		//		this.mvObj_ProjectQA = value;
		//	}
		//}

		//// Token: 0x1700059D RID: 1437
		//// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00064E3C File Offset: 0x0006303C
		//// (set) Token: 0x06000F67 RID: 3943 RVA: 0x00064E54 File Offset: 0x00063054
		//public cls_CM_ProjectType Type
		//{
		//	get
		//	{
		//		return this.mvObj_Type;
		//	}
		//	set
		//	{
		//		this.mvObj_Type = value;
		//	}
		//}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00064E60 File Offset: 0x00063060
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00064E78 File Offset: 0x00063078
		public string PathonTDrive
		{
			get
			{
				return this.mvStr_PathonTDrive;
			}
			set
			{
				this.mvStr_PathonTDrive = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00064E84 File Offset: 0x00063084
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00064E9C File Offset: 0x0006309C
		public string PathVSS
		{
			get
			{
				return this.mvStr_PathVSS;
			}
			set
			{
				this.mvStr_PathVSS = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00064EA8 File Offset: 0x000630A8
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00064EC0 File Offset: 0x000630C0
		public string PathSVN
		{
			get
			{
				return this.mvStr_PathSVN;
			}
			set
			{
				this.mvStr_PathSVN = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00064ECC File Offset: 0x000630CC
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00064EE4 File Offset: 0x000630E4
		public string PathToRepositoriesSVN
		{
			get
			{
				return this.mvStr_PathToRepositoriesSVN;
			}
			set
			{
				this.mvStr_PathToRepositoriesSVN = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00064EF0 File Offset: 0x000630F0
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00064F08 File Offset: 0x00063108
		public string ActualStartDate
		{
			get
			{
				return this.mvDat_ActualStartDate;
			}
			set
			{
				this.mvDat_ActualStartDate = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00064F14 File Offset: 0x00063114
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00064F2C File Offset: 0x0006312C
		public string ActualEndDate
		{
			get
			{
				return this.mvDat_ActualEndDate;
			}
			set
			{
				this.mvDat_ActualEndDate = value;
			}
		}

		//// Token: 0x170005A4 RID: 1444
		//// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00064F38 File Offset: 0x00063138
		//// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00064F50 File Offset: 0x00063150
		//public List<ProjectMember> Members
		//{
		//	get
		//	{
		//		return this.mvObj_Members;
		//	}
		//	set
		//	{
		//		this.mvObj_Members = value;
		//	}
		//}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00064F5C File Offset: 0x0006315C
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00064F74 File Offset: 0x00063174
		public bool GeneratedID
		{
			get
			{
				return this.mvBln_GeneratedID;
			}
			set
			{
				this.mvBln_GeneratedID = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00064F80 File Offset: 0x00063180
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00064F98 File Offset: 0x00063198
		public Guid ScheduleID
		{
			get
			{
				return this.mvInt_ScheduleID;
			}
			set
			{
				this.mvInt_ScheduleID = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00064FA4 File Offset: 0x000631A4
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00064FBC File Offset: 0x000631BC
		public string ScheduleIDList
		{
			get
			{
				return this._ScheduleIDList;
			}
			set
			{
				this._ScheduleIDList = value;
			}
		}

		//// Token: 0x170005A8 RID: 1448
		//// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00064FC8 File Offset: 0x000631C8
		//// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00064FE0 File Offset: 0x000631E0
		//public cls_CM_Status Status
		//{
		//	get
		//	{
		//		return this.mvObj_ProjectStatus;
		//	}
		//	set
		//	{
		//		this.mvObj_ProjectStatus = value;
		//	}
		//}

		//// Token: 0x170005A9 RID: 1449
		//// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00064FEC File Offset: 0x000631EC
		//// (set) Token: 0x06000F7F RID: 3967 RVA: 0x00065004 File Offset: 0x00063204
		//public Quotation QuotationData
		//{
		//	get
		//	{
		//		return this._quotationData;
		//	}
		//	set
		//	{
		//		this._quotationData = value;
		//	}
		//}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00065010 File Offset: 0x00063210
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00065028 File Offset: 0x00063228
		public bool IsViewReadOnly
		{
			get
			{
				return this._isViewReadOnly;
			}
			set
			{
				this._isViewReadOnly = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00065034 File Offset: 0x00063234
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0006504C File Offset: 0x0006324C
		public string BTMSIDList
		{
			get
			{
				return this._BTMSIDList;
			}
			set
			{
				this._BTMSIDList = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00065058 File Offset: 0x00063258
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00065070 File Offset: 0x00063270
		public string NewBTMSIDList
		{
			get
			{
				return this._NewBTMSIDList;
			}
			set
			{
				this._NewBTMSIDList = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0006507C File Offset: 0x0006327C
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00065094 File Offset: 0x00063294
		public string ListPhanLoai
		{
			get
			{
				return this.mvStr_ListPhanLoai;
			}
			set
			{
				this.mvStr_ListPhanLoai = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x000650A0 File Offset: 0x000632A0
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x000650B8 File Offset: 0x000632B8
		public string ListNgonNgu
		{
			get
			{
				return this.mvStr_ListNgonNgu;
			}
			set
			{
				this.mvStr_ListNgonNgu = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x000650C4 File Offset: 0x000632C4
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x000650DC File Offset: 0x000632DC
		public string ListAppServer
		{
			get
			{
				return this.mvStr_ListAppServer;
			}
			set
			{
				this.mvStr_ListAppServer = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000650E8 File Offset: 0x000632E8
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00065100 File Offset: 0x00063300
		public string ListDatabase
		{
			get
			{
				return this.mvStr_ListDatabase;
			}
			set
			{
				this.mvStr_ListDatabase = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0006510C File Offset: 0x0006330C
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00065124 File Offset: 0x00063324
		public string ListComponent
		{
			get
			{
				return this.mvStr_ListComponent;
			}
			set
			{
				this.mvStr_ListComponent = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00065130 File Offset: 0x00063330
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00065148 File Offset: 0x00063348
		public string ListFramework
		{
			get
			{
				return this.mvStr_ListFramework;
			}
			set
			{
				this.mvStr_ListFramework = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00065154 File Offset: 0x00063354
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x0006516C File Offset: 0x0006336C
		public string ListIDE
		{
			get
			{
				return this.mvStr_ListIDE;
			}
			set
			{
				this.mvStr_ListIDE = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00065178 File Offset: 0x00063378
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00065190 File Offset: 0x00063390
		public string ListSourceControl
		{
			get
			{
				return this.mvStr_ListSourceControl;
			}
			set
			{
				this.mvStr_ListSourceControl = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0006519C File Offset: 0x0006339C
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x000651B4 File Offset: 0x000633B4
		public string ListOS
		{
			get
			{
				return this.mvStr_ListOS;
			}
			set
			{
				this.mvStr_ListOS = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x000651C0 File Offset: 0x000633C0
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x000651D8 File Offset: 0x000633D8
		public string ListMoTaProject
		{
			get
			{
				return this.mvStr_ListMoTaProject;
			}
			set
			{
				this.mvStr_ListMoTaProject = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x000651E4 File Offset: 0x000633E4
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x000651FC File Offset: 0x000633FC
		public string ListCacDiemDacTrung
		{
			get
			{
				return this.mvStr_ListCacDiemDacTrung;
			}
			set
			{
				this.mvStr_ListCacDiemDacTrung = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00065208 File Offset: 0x00063408
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00065220 File Offset: 0x00063420
		public string ListDiemBaoMat
		{
			get
			{
				return this.mvStr_ListDiemBaoMat;
			}
			set
			{
				this.mvStr_ListDiemBaoMat = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0006522C File Offset: 0x0006342C
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00065244 File Offset: 0x00063444
		public string ListDiemNoiBat
		{
			get
			{
				return this.mvStr_ListDiemNoiBat;
			}
			set
			{
				this.mvStr_ListDiemNoiBat = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00065250 File Offset: 0x00063450
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00065268 File Offset: 0x00063468
		public string ListCacDiemKhac
		{
			get
			{
				return this.mvStr_ListCacDiemKhac;
			}
			set
			{
				this.mvStr_ListCacDiemKhac = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00065274 File Offset: 0x00063474
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x0006528C File Offset: 0x0006348C
		public decimal SoMM
		{
			get
			{
				return this.mvDec_SoMM;
			}
			set
			{
				this.mvDec_SoMM = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00065298 File Offset: 0x00063498
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x000652B0 File Offset: 0x000634B0
		public string BTMS2018IDList
		{
			get
			{
				return this._BTMS2018IDList;
			}
			set
			{
				this._BTMS2018IDList = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x000652BC File Offset: 0x000634BC
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x000652D4 File Offset: 0x000634D4
		public string PhanLoai
		{
			get
			{
				return this.mvStr_PhanLoai;
			}
			set
			{
				this.mvStr_PhanLoai = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000652E0 File Offset: 0x000634E0
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x000652F8 File Offset: 0x000634F8
		public string NgonNgu
		{
			get
			{
				return this.mvStr_NgonNgu;
			}
			set
			{
				this.mvStr_NgonNgu = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00065304 File Offset: 0x00063504
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0006531C File Offset: 0x0006351C
		public string AppServer
		{
			get
			{
				return this.mvStr_AppServer;
			}
			set
			{
				this.mvStr_AppServer = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00065328 File Offset: 0x00063528
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00065340 File Offset: 0x00063540
		public string Database
		{
			get
			{
				return this.mvStr_Database;
			}
			set
			{
				this.mvStr_Database = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0006534C File Offset: 0x0006354C
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00065364 File Offset: 0x00063564
		public string Component
		{
			get
			{
				return this.mvStr_Component;
			}
			set
			{
				this.mvStr_Component = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00065370 File Offset: 0x00063570
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00065388 File Offset: 0x00063588
		public string Framework
		{
			get
			{
				return this.mvStr_Framework;
			}
			set
			{
				this.mvStr_Framework = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00065394 File Offset: 0x00063594
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x000653AC File Offset: 0x000635AC
		public string IDE
		{
			get
			{
				return this.mvStr_IDE;
			}
			set
			{
				this.mvStr_IDE = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x000653B8 File Offset: 0x000635B8
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x000653D0 File Offset: 0x000635D0
		public string SourceControl
		{
			get
			{
				return this.mvStr_SourceControl;
			}
			set
			{
				this.mvStr_SourceControl = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000653DC File Offset: 0x000635DC
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000653F4 File Offset: 0x000635F4
		public string OS
		{
			get
			{
				return this.mvStr_OS;
			}
			set
			{
				this.mvStr_OS = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00065400 File Offset: 0x00063600
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00065418 File Offset: 0x00063618
		public string QAMS2018IDList
		{
			get
			{
				return this._QAMS2018IDList;
			}
			set
			{
				this._QAMS2018IDList = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00065424 File Offset: 0x00063624
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0006543C File Offset: 0x0006363C
		public Array CheckUpdate
		{
			get
			{
				return this.mvArr_CheckUpdate;
			}
			set
			{
				value.CopyTo(this.mvArr_CheckUpdate, 0);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00065450 File Offset: 0x00063650
		public cls_CM_Project()
		{
			this.mvInt_ID = Conversions.ToString(0);
			this.mvDec_SoMM = 0m;
			this.mvStr_ProjectID = "";
			this.mvStr_ProjectName = "";
			this.mvStr_ProjectNameOnRepositoriesSVN = "";
			this.mvStr_PathToRepositoriesSVN = "";
            //this.mvObj_Customer = new cls_CM_Customer();
            this.mvDat_PlanStartDate = DateTime.Today.ToString("yyyyMMdd");
            this.mvDat_PlanEndDate = DateTime.Today.ToString("yyyyMMdd");
			//this.mvObj_Manager = new cls_CM_Staff_Abridged();
			//this.mvObj_ProjectManager = new cls_CM_Staff_Abridged();
			//this.mvObj_ProjectLeader = new cls_CM_Staff_Abridged();
			//this.mvObj_ProjectQA = new cls_CM_Staff_Abridged();
			//this.mvObj_Type = new cls_CM_ProjectType();
			this.mvStr_PathonTDrive = "";
			this.mvStr_PathVSS = "";
			this.mvDat_ActualStartDate = "";
			this.mvDat_ActualEndDate = "";
			this.mvObj_Documents = new List<cls_CM_ProjectDocuments>();
			//this.mvObj_Members = new List<ProjectMember>();
			//this.mvObj_ProjectStatus = new cls_CM_Status();
			this.mvInt_ScheduleID = cls_CM_ProjectSchedule2007.SCHEDULE_NOT_SET;
			this._ScheduleIDList = cls_DB_ProjectSchedule.ChangeGUIDToID(cls_CM_ProjectSchedule2007.SCHEDULE_NOT_SET);
			//this.QuotationData = new Quotation();
			this.mvStr_PathSVN = "";
			this._BTMSIDList = "";
			this._NewBTMSIDList = "";
			this._BTMS2018IDList = "";
			this._QAMS2018IDList = "";
			this.mvStr_ListNgonNgu = "";
			this.mvStr_ListAppServer = "";
			this.mvStr_ListDatabase = "";
			this.mvStr_ListComponent = "";
			this.mvStr_ListFramework = "";
			this.mvStr_ListIDE = "";
			this.mvStr_ListSourceControl = "";
			this.mvStr_ListMoTaProject = "";
			this.mvStr_ListCacDiemDacTrung = "";
			this.mvStr_ListCacDiemKhac = "";
			this.mvStr_ListDiemNoiBat = "";
			this.mvStr_ListDiemBaoMat = "";
			this.mvStr_ListOS = "";
			this.mvArr_CheckUpdate = Array.CreateInstance(typeof(byte), 8);
		}

		//// Token: 0x06000FBD RID: 4029 RVA: 0x0006566C File Offset: 0x0006386C
		//public cls_CM_Project(cls_CM_Project iObj_Project)
		//{
		//	this.mvInt_ID = iObj_Project.ID;
		//	this.mvStr_ProjectID = iObj_Project.ProjectID;
		//	this.mvStr_ProjectName = iObj_Project.Name;
		//	this.mvDec_SoMM = iObj_Project.SoMM;
		//	this.mvStr_ProjectNameOnRepositoriesSVN = iObj_Project.ProjectNameOnRepositoriesSVN;
		//	this.mvStr_PathToRepositoriesSVN = iObj_Project.PathToRepositoriesSVN;
		//	//this.mvObj_Customer = new cls_CM_Customer();
		//	//this.mvObj_Customer = iObj_Project.Customer;
		//	this.mvDat_PlanStartDate = iObj_Project.PlanStartDate;
		//	this.mvDat_PlanEndDate = iObj_Project.PlanEndDate;
		//	//this.mvObj_Manager = new cls_CM_Staff_Abridged();
		//	//this.mvObj_Manager = iObj_Project.Manager;
		//	//this.mvObj_ProjectManager = new cls_CM_Staff_Abridged();
		//	//this.mvObj_ProjectManager = iObj_Project.ProjectManager;
		//	//this.mvObj_ProjectLeader = new cls_CM_Staff_Abridged();
		//	//this.mvObj_ProjectLeader = iObj_Project.ProjectLeader;
		//	//this.mvObj_ProjectQA = new cls_CM_Staff_Abridged();
		//	//this.mvObj_ProjectQA = iObj_Project.ProjectQA;
		//	//this.mvObj_Type = new cls_CM_ProjectType();
		//	//this.mvObj_Type = iObj_Project.Type;
		//	this.mvStr_PathonTDrive = iObj_Project.PathonTDrive;
		//	this.mvStr_PathSVN = iObj_Project.PathSVN;
		//	this.mvStr_PathVSS = iObj_Project.PathVSS;
		//	this.mvDat_ActualStartDate = iObj_Project.mvDat_ActualStartDate;
		//	this.mvDat_ActualEndDate = iObj_Project.ActualEndDate;
		//	this.mvObj_Documents = new List<cls_CM_ProjectDocuments>();
		//	this.mvObj_Documents = iObj_Project.Documents;
		//	this.mvObj_Members = new List<ProjectMember>();
		//	checked
		//	{
		//		int num = iObj_Project.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			this.mvObj_Members.Add(iObj_Project.Members[i]);
		//		}
		//		this.mvBln_GeneratedID = iObj_Project.GeneratedID;
		//		this.mvInt_ScheduleID = iObj_Project.ScheduleID;
		//		this.mvObj_ProjectStatus = new cls_CM_Status();
		//		this.mvObj_ProjectStatus = iObj_Project.Status;
		//		this._ScheduleIDList = iObj_Project.ScheduleIDList;
		//		this.QuotationData = new Quotation();
		//		this.QuotationData = iObj_Project.QuotationData;
		//		this._BTMSIDList = iObj_Project._BTMSIDList;
		//		this._NewBTMSIDList = iObj_Project._NewBTMSIDList;
		//		this._BTMS2018IDList = iObj_Project._BTMS2018IDList;
		//		this._QAMS2018IDList = iObj_Project._QAMS2018IDList;
		//		this.mvStr_ListPhanLoai = iObj_Project.ListPhanLoai;
		//		this.mvStr_ListNgonNgu = iObj_Project.ListNgonNgu;
		//		this.mvStr_ListAppServer = iObj_Project.ListAppServer;
		//		this.mvStr_ListDatabase = iObj_Project.ListDatabase;
		//		this.mvStr_ListComponent = iObj_Project.ListComponent;
		//		this.mvStr_ListFramework = iObj_Project.ListFramework;
		//		this.mvStr_ListIDE = iObj_Project.ListIDE;
		//		this.mvStr_ListSourceControl = iObj_Project.ListSourceControl;
		//		this.mvStr_ListMoTaProject = iObj_Project.ListMoTaProject;
		//		this.mvStr_ListCacDiemDacTrung = iObj_Project.ListCacDiemDacTrung;
		//		this.mvStr_ListCacDiemKhac = iObj_Project.ListCacDiemKhac;
		//		this.mvStr_ListDiemBaoMat = iObj_Project.ListDiemBaoMat;
		//		this.mvStr_ListDiemNoiBat = iObj_Project.ListDiemNoiBat;
		//		this.mvStr_ListOS = iObj_Project.ListOS;
		//		this.mvStr_PhanLoai = iObj_Project.PhanLoai;
		//		this.mvStr_NgonNgu = iObj_Project.NgonNgu;
		//		this.mvStr_AppServer = iObj_Project.AppServer;
		//		this.mvStr_Database = iObj_Project.Database;
		//		this.mvStr_Component = iObj_Project.Component;
		//		this.mvStr_Framework = iObj_Project.Framework;
		//		this.mvStr_IDE = iObj_Project.IDE;
		//		this.mvStr_SourceControl = iObj_Project.SourceControl;
		//		this.mvStr_OS = iObj_Project.OS;
		//		this.mvArr_CheckUpdate = Array.CreateInstance(typeof(byte), 8);
		//		iObj_Project.mvArr_CheckUpdate.CopyTo(this.mvArr_CheckUpdate, 0);
		//	}
		//}

		// Token: 0x06000FBE RID: 4030 RVA: 0x000659BC File Offset: 0x00063BBC
		public override string ToString()
		{
			bool flag = Operators.CompareString(this.Name, "", false) != 0;
			string result;
			if (flag)
			{
				result = this.ProjectID + " (" + this.Name + ")";
			}
			else
			{
				result = this.ProjectID;
			}
			return result;
		}

		//// Token: 0x06000FBF RID: 4031 RVA: 0x00065A0C File Offset: 0x00063C0C
		//public bool IsExistMemberRole(List<ProjectMember> ListMember, cls_CM_ProjectRole Role)
		//{
		//	checked
		//	{
		//		int num = ListMember.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = Operators.CompareString(ListMember[i].Role.ID, Role.ID, false) == 0;
		//			if (flag)
		//			{
		//				return true;
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC0 RID: 4032 RVA: 0x00065A60 File Offset: 0x00063C60
		//public bool IsSupervisor(cls_CM_Staff_Abridged staff)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = Operators.CompareString(staff.UserName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000014", false) == 0;
		//			if (flag)
		//			{
		//				return true;
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC1 RID: 4033 RVA: 0x00065AE4 File Offset: 0x00063CE4
		//public bool IsSupervisor(string userName)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = Operators.CompareString(userName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000014", false) == 0;
		//			if (flag)
		//			{
		//				return true;
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC2 RID: 4034 RVA: 0x00065B60 File Offset: 0x00063D60
		//public bool IsProcessSupporter(cls_CM_Staff_Abridged staff)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = Operators.CompareString(staff.UserName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000018", false) == 0;
		//			if (flag)
		//			{
		//				return true;
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC3 RID: 4035 RVA: 0x00065BE4 File Offset: 0x00063DE4
		//public bool IsViewer(string userName, bool isUserID = false)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = !isUserID;
		//			if (flag)
		//			{
		//				bool flag2 = Operators.CompareString(userName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000015", false) == 0;
		//				if (flag2)
		//				{
		//					return true;
		//				}
		//			}
		//			else
		//			{
		//				bool flag3 = Operators.CompareString(userName, this.Members[i].Staff.ID, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000015", false) == 0;
		//				if (flag3)
		//				{
		//					return true;
		//				}
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC4 RID: 4036 RVA: 0x00065CC8 File Offset: 0x00063EC8
		//public bool IsProcessSupporter(string userName, bool isUserID = false)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = !isUserID;
		//			if (flag)
		//			{
		//				bool flag2 = Operators.CompareString(userName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000018", false) == 0;
		//				if (flag2)
		//				{
		//					return true;
		//				}
		//			}
		//			else
		//			{
		//				bool flag3 = Operators.CompareString(userName, this.Members[i].Staff.ID, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000018", false) == 0;
		//				if (flag3)
		//				{
		//					return true;
		//				}
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC5 RID: 4037 RVA: 0x00065DAC File Offset: 0x00063FAC
		//public bool IsCC(string userName, bool isUserID = false)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = !isUserID;
		//			if (flag)
		//			{
		//				bool flag2 = Operators.CompareString(userName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000007", false) == 0;
		//				if (flag2)
		//				{
		//					return true;
		//				}
		//			}
		//			else
		//			{
		//				bool flag3 = Operators.CompareString(userName, this.Members[i].Staff.ID, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000007", false) == 0;
		//				if (flag3)
		//				{
		//					return true;
		//				}
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC6 RID: 4038 RVA: 0x00065E90 File Offset: 0x00064090
		//public bool IsViceManager(string userName, bool isUserID = false)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = !isUserID;
		//			if (flag)
		//			{
		//				bool flag2 = Operators.CompareString(userName, this.Members[i].Staff.UserName, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000019", false) == 0;
		//				if (flag2)
		//				{
		//					return true;
		//				}
		//			}
		//			else
		//			{
		//				bool flag3 = Operators.CompareString(userName, this.Members[i].Staff.ID, false) == 0 && Operators.CompareString(this.Members[i].Role.ID, "0000000019", false) == 0;
		//				if (flag3)
		//				{
		//					return true;
		//				}
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FC7 RID: 4039 RVA: 0x00065F74 File Offset: 0x00064174
		//public void UpdateProjectMembers(ref List<ProjectMember> ListMember)
		//{
		//	ProjectMember projectMember = default(ProjectMember);
		//	cls_CM_ProjectRole cls_CM_ProjectRole = new cls_CM_ProjectRole();
		//	cls_CM_ProjectRole.fncG_CM_GetRole("0000000009");
		//	bool flag = !this.IsExistMemberRole(ListMember, cls_CM_ProjectRole);
		//	if (flag)
		//	{
		//		projectMember.Role = cls_CM_ProjectRole;
		//		ListMember.Add(projectMember);
		//	}
		//	cls_CM_ProjectRole = new cls_CM_ProjectRole();
		//	cls_CM_ProjectRole.fncG_CM_GetRole("0000000001");
		//	bool flag2 = !this.IsExistMemberRole(ListMember, cls_CM_ProjectRole);
		//	if (flag2)
		//	{
		//		projectMember.Role = cls_CM_ProjectRole;
		//		ListMember.Add(projectMember);
		//	}
		//	cls_CM_ProjectRole = new cls_CM_ProjectRole();
		//	cls_CM_ProjectRole.fncG_CM_GetRole("0000000002");
		//	bool flag3 = !this.IsExistMemberRole(ListMember, cls_CM_ProjectRole);
		//	if (flag3)
		//	{
		//		projectMember.Role = cls_CM_ProjectRole;
		//		ListMember.Add(projectMember);
		//	}
		//	cls_CM_ProjectRole = new cls_CM_ProjectRole();
		//	cls_CM_ProjectRole.fncG_CM_GetRole("0000000003");
		//	bool flag4 = !this.IsExistMemberRole(ListMember, cls_CM_ProjectRole);
		//	if (flag4)
		//	{
		//		projectMember.Role = cls_CM_ProjectRole;
		//		ListMember.Add(projectMember);
		//	}
		//	checked
		//	{
		//		int num = ListMember.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			projectMember = ListMember[i];
		//			string id = projectMember.Role.ID;
		//			if (Operators.CompareString(id, "0000000009", false) != 0)
		//			{
		//				if (Operators.CompareString(id, "0000000001", false) != 0)
		//				{
		//					if (Operators.CompareString(id, "0000000002", false) != 0)
		//					{
		//						if (Operators.CompareString(id, "0000000003", false) == 0)
		//						{
		//							projectMember.Staff = this.ProjectQA;
		//							ListMember[i] = projectMember;
		//						}
		//					}
		//					else
		//					{
		//						projectMember.Staff = this.ProjectLeader;
		//						ListMember[i] = projectMember;
		//					}
		//				}
		//				else
		//				{
		//					projectMember.Staff = this.ProjectManager;
		//					ListMember[i] = projectMember;
		//				}
		//			}
		//			else
		//			{
		//				projectMember.Staff = this.Manager;
		//				ListMember[i] = projectMember;
		//			}
		//		}
		//	}
		//}

		//// Token: 0x06000FC8 RID: 4040 RVA: 0x00066147 File Offset: 0x00064347
		//public void fncG_PJ_GenerateID()
		//{
		//	this.ID = cls_CM_Function.fncG_CM_GenerateNewIDFromTable("PRJ_ProjectsInfo");
		//}

		//// Token: 0x06000FC9 RID: 4041 RVA: 0x0006615C File Offset: 0x0006435C
		//public void fncG_PJ_GenerateProjectID()
		//{
		//	DateTime dateValue = new DateTime(Conversions.ToInteger(this.mvDat_PlanStartDate.Substring(0, 4)), Conversions.ToInteger(this.mvDat_PlanStartDate.Substring(4, 2)), Conversions.ToInteger(this.mvDat_PlanStartDate.Substring(6, 2)));
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	StringBuilder stringBuilder = new StringBuilder("");
		//	stringBuilder.AppendFormat("PJ-{0}-{1}-{2}", this.mvObj_Customer.ShortName, Conversions.ToString(DateAndTime.Year(dateValue)) + DateAndTime.Month(dateValue).ToString("00"), (checked(cls_DB_Project.fncG_DB_GetProjectSequenceNo(this) + 1)).ToString("0000"));
		//	this.mvStr_ProjectID = stringBuilder.ToString();
		//}

		//// Token: 0x06000FCA RID: 4042 RVA: 0x00066214 File Offset: 0x00064414
		//public void fncG_PJ_UpdateProjectID(string iStr_OldID)
		//{
		//	DateTime dateValue = new DateTime(Conversions.ToInteger(this.mvDat_PlanStartDate.Substring(0, 4)), Conversions.ToInteger(this.mvDat_PlanStartDate.Substring(4, 2)), Conversions.ToInteger(this.mvDat_PlanStartDate.Substring(6, 2)));
		//	string arg = iStr_OldID.Split(new char[]
		//	{
		//		'-'
		//	})[3];
		//	StringBuilder stringBuilder = new StringBuilder("");
		//	stringBuilder.AppendFormat("PJ-{0}-{1}-{2}", this.mvObj_Customer.ShortName, Conversions.ToString(DateAndTime.Year(dateValue)) + DateAndTime.Month(dateValue).ToString("00"), arg);
		//	this.mvStr_ProjectID = stringBuilder.ToString();
		//}

		//// Token: 0x06000FCB RID: 4043 RVA: 0x000662C8 File Offset: 0x000644C8
		//public ArrayList fncG_PJ_SearchDocument(string iStr_DocName)
		//{
		//	ArrayList arrayList = new ArrayList();
		//	try
		//	{
		//		foreach (cls_CM_ProjectDocuments cls_CM_ProjectDocuments in this.mvObj_Documents)
		//		{
		//			bool flag = cls_CM_ProjectDocuments.Name.Contains(iStr_DocName);
		//			if (flag)
		//			{
		//				arrayList.Add(cls_CM_ProjectDocuments);
		//			}
		//		}
		//	}
		//	finally
		//	{
		//		List<cls_CM_ProjectDocuments>.Enumerator enumerator;
		//		((IDisposable)enumerator).Dispose();
		//	}
		//	return arrayList;
		//}

		//// Token: 0x06000FCC RID: 4044 RVA: 0x00066344 File Offset: 0x00064544
		//public List<cls_CM_Project> fncG_PJ_ListProject(string iStr_ID = "", string iStr_ProjectID = "", string iStr_ProjectName = "", string iStr_Customer = "", string iStr_PlanStartDate = "", string iStr_PlanEndDate = "", string iStr_Manager = "", string iStr_ProjectManager = "", string iStr_ProjectLeader = "", string iStr_ProjectQA = "", string iStr_ProjectType = "", string iStr_ActualStartDate = "", string iStr_ActualEndDate = "", string iStr_Status = "")
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.fncG_DB_ListProject(iStr_ID, iStr_ProjectID, iStr_ProjectName, iStr_Customer, iStr_PlanStartDate, iStr_PlanEndDate, iStr_Manager, iStr_ProjectManager, iStr_ProjectLeader, iStr_ProjectQA, iStr_ProjectType, iStr_ActualStartDate, iStr_ActualEndDate, iStr_Status);
		//}

		//// Token: 0x06000FCD RID: 4045 RVA: 0x0006637C File Offset: 0x0006457C
		//public List<cls_CM_Project> FilterProjects(string userID = "", string projectIDOrName = "", [DateTimeConstant(0L)] [Optional] DateTime startDate, [DateTimeConstant(0L)] [Optional] DateTime endDate, List<cls_CM_Status> statusList = null)
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.FilterProjects(userID, projectIDOrName, startDate, endDate, statusList);
		//}

		//// Token: 0x06000FCE RID: 4046 RVA: 0x000663A4 File Offset: 0x000645A4
		//public List<cls_CM_Project> fncG_PJ_ListActiveProject(string userID, bool isManager, bool isPM, bool isPL, bool isSupervisor, bool isQA, bool isMember)
		//{
		//	List<cls_CM_Project> list = new List<cls_CM_Project>();
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	List<string> list2 = cls_DB_Project.GetCurrentProject(userID, true, "", isManager, isPM, isPL, isSupervisor, isQA, isMember);
		//	list2 = list2.Distinct<string>().ToList<string>();
		//	try
		//	{
		//		foreach (string iStr_ID in list2)
		//		{
		//			List<cls_CM_Project> list3 = cls_DB_Project.fncG_DB_ListProject(iStr_ID, "", "", "", "", "", "", "", "", "", "", "", "", "");
		//			bool flag = list3 != null && list3.Count > 0;
		//			if (flag)
		//			{
		//				list.AddRange(list3);
		//			}
		//		}
		//	}
		//	finally
		//	{
		//		List<string>.Enumerator enumerator;
		//		((IDisposable)enumerator).Dispose();
		//	}
		//	return list;
		//}

		//// Token: 0x06000FCF RID: 4047 RVA: 0x0006649C File Offset: 0x0006469C
		//public List<cls_CM_Project> fncG_PJ_ListActiveProjectWithBasicInfo(string userID, bool isManager, bool isPM, bool isPL, bool isSupervisor, bool isQA, bool isMember)
		//{
		//	List<cls_CM_Project> list = new List<cls_CM_Project>();
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	List<string> list2 = cls_DB_Project.GetCurrentProject(userID, true, "", isManager, isPM, isPL, isSupervisor, isQA, isMember);
		//	list2 = list2.Distinct<string>().ToList<string>();
		//	try
		//	{
		//		foreach (string iStr_ID in list2)
		//		{
		//			List<cls_CM_Project> list3 = cls_DB_Project.fncG_DB_ListProjectWithBasicInfo(iStr_ID, "", "", "", "", "", "", "", "", "", "", "", "", "");
		//			bool flag = list3 != null && list3.Count > 0;
		//			if (flag)
		//			{
		//				list.AddRange(list3);
		//			}
		//		}
		//	}
		//	finally
		//	{
		//		List<string>.Enumerator enumerator;
		//		((IDisposable)enumerator).Dispose();
		//	}
		//	return list;
		//}

		//// Token: 0x06000FD0 RID: 4048 RVA: 0x00066594 File Offset: 0x00064794
		//public bool fncG_PJ_Insert()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	cls_DB_Project cls_DB_Project2 = cls_DB_Project;
		//	cls_CM_Project cls_CM_Project = this;
		//	Array checkUpdate = this.CheckUpdate;
		//	bool result = cls_DB_Project2.fncG_DB_Insert(ref cls_CM_Project, ref checkUpdate);
		//	this.CheckUpdate = checkUpdate;
		//	return result;
		//}

		//// Token: 0x06000FD1 RID: 4049 RVA: 0x000665C8 File Offset: 0x000647C8
		//public bool fncG_PJ_InsertAll()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	cls_DB_Project cls_DB_Project2 = cls_DB_Project;
		//	Array checkUpdate = this.CheckUpdate;
		//	bool result = cls_DB_Project2.fncG_DB_InsertAll(this, ref checkUpdate);
		//	this.CheckUpdate = checkUpdate;
		//	return result;
		//}

		//// Token: 0x06000FD2 RID: 4050 RVA: 0x000665F8 File Offset: 0x000647F8
		//public bool fncG_PJ_FrameworkDetail()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.fncG_DB_InsertFrameworkDetail(this);
		//}

		//// Token: 0x06000FD3 RID: 4051 RVA: 0x00066618 File Offset: 0x00064818
		//public bool fncG_PJ_UpdateFrameworkDetail()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.UpdateFrameworkDetail(this);
		//}

		//// Token: 0x06000FD4 RID: 4052 RVA: 0x00066638 File Offset: 0x00064838
		//public bool fncG_PJ_UpdateAll()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	cls_DB_Project cls_DB_Project2 = cls_DB_Project;
		//	Array checkUpdate = this.CheckUpdate;
		//	bool result = cls_DB_Project2.fncG_DB_UpdateAll(this, ref checkUpdate);
		//	this.CheckUpdate = checkUpdate;
		//	return result;
		//}

		//// Token: 0x06000FD5 RID: 4053 RVA: 0x00066668 File Offset: 0x00064868
		//public bool fncG_PJ_Update()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	cls_DB_Project cls_DB_Project2 = cls_DB_Project;
		//	Array checkUpdate = this.CheckUpdate;
		//	bool result = cls_DB_Project2.fncG_DB_Update(this, ref checkUpdate);
		//	this.CheckUpdate = checkUpdate;
		//	return result;
		//}

		//// Token: 0x06000FD6 RID: 4054 RVA: 0x00066698 File Offset: 0x00064898
		//public bool fncG_PJ_Delete()
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.fncG_DB_Delete(this);
		//}

		//// Token: 0x06000FD7 RID: 4055 RVA: 0x000666B8 File Offset: 0x000648B8
		//public bool IsMember(cls_CM_Staff_Abridged Staff)
		//{
		//	checked
		//	{
		//		int num = this.Members.Count - 1;
		//		for (int i = 0; i <= num; i++)
		//		{
		//			bool flag = Operators.CompareString(this.Members[i].Staff.UserName, Staff.UserName, false) == 0;
		//			if (flag)
		//			{
		//				return true;
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FD8 RID: 4056 RVA: 0x00066714 File Offset: 0x00064914
		//public static bool IsExists(cls_CM_Project objPrj)
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return Conversions.ToBoolean(cls_DB_Project.IsExists(objPrj));
		//}

		//// Token: 0x06000FD9 RID: 4057 RVA: 0x00066738 File Offset: 0x00064938
		//public bool IsMember(string UserID, bool IncludeQA = true)
		//{
		//	checked
		//	{
		//		if (IncludeQA)
		//		{
		//			int num = this.Members.Count - 1;
		//			for (int i = 0; i <= num; i++)
		//			{
		//				bool flag = Operators.CompareString(this.Members[i].Staff.ID, UserID, false) == 0;
		//				if (flag)
		//				{
		//					return true;
		//				}
		//			}
		//		}
		//		else
		//		{
		//			int num2 = this.Members.Count - 1;
		//			for (int j = 0; j <= num2; j++)
		//			{
		//				bool flag2 = Operators.CompareString(this.Members[j].Role.ShortName, "QA", false) != 0;
		//				if (flag2)
		//				{
		//					bool flag3 = Operators.CompareString(this.Members[j].Staff.ID, UserID, false) == 0;
		//					if (flag3)
		//					{
		//						return true;
		//					}
		//				}
		//			}
		//		}
		//		return false;
		//	}
		//}

		//// Token: 0x06000FDA RID: 4058 RVA: 0x00066818 File Offset: 0x00064A18
		//public string GetProjectNameFromProjectID(string ID)
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.GetProjectNameFromProjectID(ID);
		//}

		//// Token: 0x06000FDB RID: 4059 RVA: 0x00066838 File Offset: 0x00064A38
		//public static bool CanCreateProject(string userName)
		//{
		//	CreateProjectPermission createProjectPermission = new CreateProjectPermission();
		//	OMM_CreateProjectPermission omm_CreateProjectPermission = createProjectPermission.OMM_CreateProjectPermission.FirstOrDefault((OMM_CreateProjectPermission x) => Operators.CompareString(x.UserName, userName, false) == 0);
		//	bool flag = omm_CreateProjectPermission == null;
		//	return !flag;
		//}

		//// Token: 0x06000FDC RID: 4060 RVA: 0x00066934 File Offset: 0x00064B34
		//public object UpdateListIdInProjectInfo(string ID, string listID, bool btms = false, bool qams = false, bool schedule = false)
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.fncG_DB_UpdateListId(ID, listID, btms, qams, schedule);
		//}

		//// Token: 0x06000FDD RID: 4061 RVA: 0x0006695C File Offset: 0x00064B5C
		//public void UpdateScheduleMap()
		//{
		//	bool flag = this.ScheduleIDList != null && Operators.CompareString(this.ScheduleIDList, "", false) != 0;
		//	if (flag)
		//	{
		//		ListScheduleTemp listScheduleTemp = new ListScheduleTemp();
		//		IQueryable<PRJ_ListSchedulePermissionDetail> entities = from x in listScheduleTemp.PRJ_ListSchedulePermissionDetail
		//		where Operators.CompareString(x.ProjectID, this.ID, false) == 0
		//		select x;
		//		listScheduleTemp.PRJ_ListSchedulePermissionDetail.RemoveRange(entities);
		//		listScheduleTemp.SaveChanges();
		//		List<string> list = this.ScheduleIDList.Split(new char[]
		//		{
		//			','
		//		}).ToList<string>();
		//		try
		//		{
		//			foreach (string text in list)
		//			{
		//				bool flag2 = Operators.CompareString(text, cls_CM_ProjectSchedule2007.SCHEDULE_NOT_SET.ToString(), false) != 0 && Operators.CompareString(text, "0", false) != 0;
		//				if (flag2)
		//				{
		//					Guid guid;
		//					bool flag3 = !Guid.TryParse(text, out guid);
		//					if (flag3)
		//					{
		//						guid = new Guid(cls_DB_ProjectSchedule.ChangeIDToGUID(text));
		//						bool flag4 = guid == Guid.Empty;
		//						if (flag4)
		//						{
		//							continue;
		//						}
		//					}
		//					cls_CM_Function.SaveTempScheduleList(guid, true, this.ID);
		//				}
		//			}
		//		}
		//		finally
		//		{
		//			//List<string>.Enumerator enumerator;
		//			//((IDisposable)enumerator).Dispose();
		//		}
		//	}
		//}

		//// Token: 0x06000FDE RID: 4062 RVA: 0x00066B4C File Offset: 0x00064D4C
		//public object GetMemberExperience(string Username, string Dept, string Team, string Language, string TimeStart, string TimeEnd)
		//{
		//	cls_DB_Project cls_DB_Project = new cls_DB_Project();
		//	return cls_DB_Project.fncG_DB_MemberExperience(Username, Dept, Team, Language, TimeStart, TimeEnd);
		//}

		// Token: 0x04000A34 RID: 2612
		private string mvInt_ID;

		// Token: 0x04000A35 RID: 2613
		private string mvStr_ProjectID;

		// Token: 0x04000A36 RID: 2614
		private string mvStr_ProjectName;

		// Token: 0x04000A37 RID: 2615
		private List<cls_CM_ProjectDocuments> mvObj_Documents;

		// Token: 0x04000A38 RID: 2616
		//private cls_CM_Customer mvObj_Customer;

		// Token: 0x04000A39 RID: 2617
		private string mvDat_PlanStartDate;

		// Token: 0x04000A3A RID: 2618
		private string mvDat_PlanEndDate;

		//// Token: 0x04000A3B RID: 2619
		//private cls_CM_Staff_Abridged mvObj_Manager;

		//// Token: 0x04000A3C RID: 2620
		//private cls_CM_Staff_Abridged mvObj_ProjectManager;

		//// Token: 0x04000A3D RID: 2621
		//private cls_CM_Staff_Abridged mvObj_ProjectLeader;

		//// Token: 0x04000A3E RID: 2622
		//private cls_CM_Staff_Abridged mvObj_ProjectQA;

		//// Token: 0x04000A3F RID: 2623
		//private cls_CM_ProjectType mvObj_Type;

		// Token: 0x04000A40 RID: 2624
		private string mvStr_PathonTDrive;

		// Token: 0x04000A41 RID: 2625
		private string mvStr_PathVSS;

		// Token: 0x04000A42 RID: 2626
		private string mvStr_PathSVN;

		// Token: 0x04000A43 RID: 2627
		private string mvDat_ActualStartDate;

		// Token: 0x04000A44 RID: 2628
		private string mvDat_ActualEndDate;

		// Token: 0x04000A45 RID: 2629
		//private List<ProjectMember> mvObj_Members;

		// Token: 0x04000A46 RID: 2630
		private bool mvBln_GeneratedID;

		// Token: 0x04000A47 RID: 2631
		private Guid mvInt_ScheduleID;

		// Token: 0x04000A48 RID: 2632
		private string _ScheduleIDList;

		// Token: 0x04000A49 RID: 2633
		private string _BTMSIDList;

		// Token: 0x04000A4A RID: 2634
		private string _NewBTMSIDList;

		// Token: 0x04000A4B RID: 2635
		private string _BTMS2018IDList;

		// Token: 0x04000A4C RID: 2636
		private string _QAMS2018IDList;

		// Token: 0x04000A4D RID: 2637
		//private cls_CM_Status mvObj_ProjectStatus;

		// Token: 0x04000A4E RID: 2638
		private string mvStr_PathToRepositoriesSVN;

		// Token: 0x04000A4F RID: 2639
		private string mvStr_ProjectNameOnRepositoriesSVN;

		// Token: 0x04000A50 RID: 2640
		private string mvStr_ListPhanLoai;

		// Token: 0x04000A51 RID: 2641
		private string mvStr_ListNgonNgu;

		// Token: 0x04000A52 RID: 2642
		private string mvStr_ListAppServer;

		// Token: 0x04000A53 RID: 2643
		private string mvStr_ListDatabase;

		// Token: 0x04000A54 RID: 2644
		private string mvStr_ListComponent;

		// Token: 0x04000A55 RID: 2645
		private string mvStr_ListFramework;

		// Token: 0x04000A56 RID: 2646
		private string mvStr_ListIDE;

		// Token: 0x04000A57 RID: 2647
		private string mvStr_ListSourceControl;

		// Token: 0x04000A58 RID: 2648
		private string mvStr_ListOS;

		// Token: 0x04000A59 RID: 2649
		private string mvStr_ListMoTaProject;

		// Token: 0x04000A5A RID: 2650
		private string mvStr_ListCacDiemDacTrung;

		// Token: 0x04000A5B RID: 2651
		private string mvStr_ListCacDiemKhac;

		// Token: 0x04000A5C RID: 2652
		private string mvStr_ListDiemNoiBat;

		// Token: 0x04000A5D RID: 2653
		private string mvStr_ListDiemBaoMat;

		// Token: 0x04000A5E RID: 2654
		private string mvStr_PhanLoai;

		// Token: 0x04000A5F RID: 2655
		private string mvStr_NgonNgu;

		// Token: 0x04000A60 RID: 2656
		private string mvStr_AppServer;

		// Token: 0x04000A61 RID: 2657
		private string mvStr_Database;

		// Token: 0x04000A62 RID: 2658
		private string mvStr_Component;

		// Token: 0x04000A63 RID: 2659
		private string mvStr_Framework;

		// Token: 0x04000A64 RID: 2660
		private string mvStr_IDE;

		// Token: 0x04000A65 RID: 2661
		private string mvStr_SourceControl;

		// Token: 0x04000A66 RID: 2662
		private string mvStr_OS;

		// Token: 0x04000A67 RID: 2663
		private decimal mvDec_SoMM;

		// Token: 0x04000A68 RID: 2664
		private Array mvArr_CheckUpdate;

		// Token: 0x04000A69 RID: 2665
		private bool _isViewReadOnly;

		// Token: 0x04000A6A RID: 2666
		public const string ProjectCloseStatus = "0000000008";

		// Token: 0x04000A6B RID: 2667
		public const string ProjectStatus = "0000000004";

		// Token: 0x04000A6C RID: 2668
		//private Quotation _quotationData;
	}// class
}// ns
