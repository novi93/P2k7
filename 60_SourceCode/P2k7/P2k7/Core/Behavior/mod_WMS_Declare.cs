using P2k7.Core.Behavior.DB_SQLServer;
using System.Resources;
using System.Threading;

namespace P2k7.Core.Behavior
{
    class mod_WMS_Declare
    {
        // Token: 0x04000441 RID: 1089
        public const string SYSTEM_ERR_CONNECT_DB = "Cannot connect to database, program will exit !";

        // Token: 0x04000442 RID: 1090
        public const string SYSTEM_ERR_CLASS = "9999";

        // Token: 0x04000443 RID: 1091
        public const string gcStr_DomainName = "FUJINET";

        // Token: 0x04000444 RID: 1092
        public const string gcStr_SubDomainName = ".vn";

        // Token: 0x04000445 RID: 1093
        public const string MailServerURL = "mail.fujinet.net";

        // Token: 0x04000446 RID: 1094
        public const string mailDomain = "@fujinet.net";

        // Token: 0x04000447 RID: 1095
        public const string gcStr_InputableTag = "InputableTag";

        // Token: 0x04000448 RID: 1096
        public const string gcStr_TypeCode = "0";

        // Token: 0x04000449 RID: 1097
        public const int gcInt_OrganizationCode = 1;

        // Token: 0x0400044A RID: 1098
        public const string gcStr_TypeAllOrganization = "0000000000";

        // Token: 0x0400044B RID: 1099
        public const string gcStr_Type_Organizaion = "0000000001";

        // Token: 0x0400044C RID: 1100
        public const string gcStr_Type_Sex = "0000000002";

        // Token: 0x0400044D RID: 1101
        public const string gcStr_Type_Role = "0000000005";

        // Token: 0x0400044E RID: 1102
        public const string gcStr_Type_AbsenceType = "0000000007";

        // Token: 0x0400044F RID: 1103
        public const string gcStr_Type_Status = "0000000010";

        // Token: 0x04000450 RID: 1104
        public const string gcStr_SystemTitle = "FUJINET Working management system";

        // Token: 0x04000451 RID: 1105
        public const string gcStr_InTime = "08:00:00";

        // Token: 0x04000452 RID: 1106
        public const string gcStr_OutTime_On = "17:15:00";

        // Token: 0x04000453 RID: 1107
        public const string gcStr_OutTime_Late = "18:00:00";

        // Token: 0x04000454 RID: 1108
        public const int gcInt_TypeofDepartment = 2;

        // Token: 0x04000455 RID: 1109
        public const string gcStr_frm_CUS_ManageCustomerID = "0000000001";

        // Token: 0x04000456 RID: 1110
        public const string gcStr_frm_PAL_FileManagementID = "0000000002";

        // Token: 0x04000457 RID: 1111
        public const string gcStr_frm_OMM_SettingProjectFolderID = "0000000003";

        // Token: 0x04000458 RID: 1112
        public const string gcStr_frm_OMM_Function_ListID = "0000000004";

        // Token: 0x04000459 RID: 1113
        public const string gcStr_frm_OMM_Group_ListID = "0000000005";

        // Token: 0x0400045A RID: 1114
        public const string gcStr_frm_OMM_Group_StaffID = "0000000006";

        // Token: 0x0400045B RID: 1115
        public const string gcStr_frm_QA_ManageChecklistsID = "0000000007";

        // Token: 0x0400045C RID: 1116
        public const string gcStr_ResourceBookingForm = "0000000008";

        // Token: 0x0400045D RID: 1117
        public const string gcStr_FJNCalendar = "FJNCalendar";

        // Token: 0x0400045E RID: 1118
        public const string gcStr_ProjectServerURL1 = "https://projects.fujinet.vn/pwa";

        // Token: 0x0400045F RID: 1119
        public const string gcStr_ProjectServerURL2 = "https://projects.fujinet.vn/pwa";

        // Token: 0x04000460 RID: 1120
        public const string gcStr_BugTrackerURL1 = "http://tools.fujinet.net/btms_new/";

        // Token: 0x04000461 RID: 1121
        public const string gcStr_BugTrackerURL2 = "http://tools.fujinet.net/btms_new/";

        // Token: 0x04000462 RID: 1122
        public const string gcStr_QAMSURL1 = "http://tools.fujinet.net/qams/";

        // Token: 0x04000463 RID: 1123
        public const string gcStr_QAMSURL2 = "http://tools.fujinet.net/qams/";

        // Token: 0x04000464 RID: 1124
        public const string gcStr_PTMSURL1 = "http://tools.fujinet.net/ptms/";

        // Token: 0x04000465 RID: 1125
        public const string gcStr_PTMSURL2 = "http://tools.fujinet.net/ptms/";

        // Token: 0x04000466 RID: 1126
        public const string gcStr_IntranetURL1 = "http://web.fujinet.vn/index2.htm";

        // Token: 0x04000467 RID: 1127
        public const string gcStr_IntranetURL2 = "http://web.fujinet.vn/index2.htm";

        // Token: 0x04000468 RID: 1128
        public const string gcStr_ITSupportURL = "http://itsupport.fujinet.vn";

        // Token: 0x04000469 RID: 1129
        public const string gcStr_BTMSAPI = "https://tools.fujinet.net:8008/btms_new/api/soap/mantisconnect.php?wsdl";

        // Token: 0x0400046A RID: 1130
        public const string BTMSLINK_2018 = "https://tools.fujinet.net:8008/btms2018";

        // Token: 0x0400046B RID: 1131
        public const int ADMINISTRATOR_ACCESS_LEVEL = 90;

        // Token: 0x0400046C RID: 1132
        public const string PROJECT_SERVER_URI = "https://projectsvr-01.fujinet.vn/PWA/";

        // Token: 0x0400046D RID: 1133
        public const string PROJECT_SERVICE_PATH = "_vti_bin/psi/Project.asmx";

        // Token: 0x0400046E RID: 1134
        public const string QUEUESYSTEM_SERVICE_PATH = "_vti_bin/psi/QueueSystem.asmx";

        // Token: 0x0400046F RID: 1135
        public const string CUSTOMFIELD_SERVICE_PATH = "_vti_bin/PSI/CustomFields.asmx";

        // Token: 0x04000470 RID: 1136
        public const string ADMIN_SERVICE_PATH = "_vti_bin/PSI/Admin.asmx";

        // Token: 0x04000471 RID: 1137
        public const string ARCHIVE_SERVICE_PATH = "_vti_bin/PSI/Archive.asmx";

        // Token: 0x04000472 RID: 1138
        public const string AUTHENTICATION_SERVICE_PATH = "_vti_bin/PSI/Authentication.asmx";

        // Token: 0x04000473 RID: 1139
        public const string CALENDAR_SERVICE_PATH = "_vti_bin/PSI/Calendar.asmx";

        // Token: 0x04000474 RID: 1140
        public const string CUBEADMIN_SERVICE_PATH = "_vti_bin/PSI/CubeAdmin.asmx";

        // Token: 0x04000475 RID: 1141
        public const string EVENTS_SERVICE_PATH = "_vti_bin/PSI/Events.asmx";

        // Token: 0x04000476 RID: 1142
        public const string LOGINFORMS_SERVICE_PATH = "_vti_bin/PSI/LoginForms.asmx";

        // Token: 0x04000477 RID: 1143
        public const string LOGINWINDOWS_SERVICE_PATH = "_vti_bin/PSI/LoginWindows.asmx";

        // Token: 0x04000478 RID: 1144
        public const string LOOKUPTABLE_SERVICE_PATH = "_vti_bin/PSI/LookupTable.asmx";

        // Token: 0x04000479 RID: 1145
        public const string NOTIFICATIONS_SERVICE_PATH = "_vti_bin/PSI/Notifications.asmx";

        // Token: 0x0400047A RID: 1146
        public const string OBJECTLINKPROVIDER_SERVICE_PATH = "_vti_bin/PSI/ObjectLinkProvider.asmx";

        // Token: 0x0400047B RID: 1147
        public const string PWA_SERVICE_PATH = "_vti_bin/PSI/PWA.asmx";

        // Token: 0x0400047C RID: 1148
        public const string RESOURCE_SERVICE_PATH = "_vti_bin/PSI/Resource.asmx";

        // Token: 0x0400047D RID: 1149
        public const string RESOURCEPLAN_SERVICE_PATH = "_vti_bin/PSI/ResourcePlan.asmx";

        // Token: 0x0400047E RID: 1150
        public const string SECURITY_SERVICE_PATH = "_vti_bin/PSI/Security.asmx";

        // Token: 0x0400047F RID: 1151
        public const string STATUSING_SERVICE_PATH = "_vti_bin/PSI/Statusing.asmx";

        // Token: 0x04000480 RID: 1152
        public const string TIMESHEET_SERVICE_PATH = "_vti_bin/PSI/TimeSheet.asmx";

        // Token: 0x04000481 RID: 1153
        public const string VIEW_SERVICE_PATH = "_vti_bin/PSI/View.asmx";

        // Token: 0x04000482 RID: 1154
        public const string WINPROJ_SERVICE_PATH = "_vti_bin/PSI/WinProj.asmx";

        // Token: 0x04000483 RID: 1155
        public const string WSSINTEROP_SERVICE_PATH = "_vti_bin/PSI/WssInterop.asmx";

        // Token: 0x04000484 RID: 1156
        public const string SOFTWARE_DEV_SCHEDULE_PARTNAME = "Software Development";

        // Token: 0x04000485 RID: 1157
        public const string PROJECT_MAN_SCHEDULE_PARTNAME = "Project Management";

        // Token: 0x04000486 RID: 1158
        public const string FIXBUG_SCHEDULE_PARTNAME = "Fix customer's defects";

        // Token: 0x04000487 RID: 1159
        public const string SOFTWARE_DEV_SCHEDULE_PARTID = "SD";

        // Token: 0x04000488 RID: 1160
        public const string PROJECT_MAN_SCHEDULE_PARTID = "PM";

        // Token: 0x04000489 RID: 1161
        public const string FIXBUG_SCHEDULE_PARTID = "FIXCUSDEF";

        // Token: 0x0400048A RID: 1162
        public const string SUBPROJECT_TASKCLASS = "SUB_PRJ";

        // Token: 0x0400048B RID: 1163
        public const string TASKCLASSTYPE = "TaskClass";

        // Token: 0x0400048C RID: 1164
        public const string WMS_SERVICES_URL = "https://wms.fujinet.vn:8443/NewWMSServices/MainServices.asmx";

        // Token: 0x0400048D RID: 1165
        public const string ALL_DATA_USER = "qatest";

        // Token: 0x0400048E RID: 1166
        public const string ALL_DATA_PWD = "BbCc2014";

        // Token: 0x0400048F RID: 1167
        public const int VIEWER_ACCESS_LEVEL = 10;

        // Token: 0x04000490 RID: 1168
        public const int DEVELOPER_ACCESS_LEVEL = 55;

        // Token: 0x04000491 RID: 1169
        public const int MANAGER_ACCESS_LEVEL = 70;

        // Token: 0x04000492 RID: 1170
        public const int DEPTMANAGER_ACCESS_LEVEL = 80;

        // Token: 0x04000493 RID: 1171
        public const string STATUS_PROJECT_DEFAULT = "development";

        // Token: 0x04000494 RID: 1172
        public const string VIEW_STATUS_PROJECT_DEFAULT = "private";

        // Token: 0x04000495 RID: 1173
        public const string gcStr_RoleSupervisorID = "0000000014";

        // Token: 0x04000496 RID: 1174
        public const string gcStr_RoleViceManagerID = "0000000019";

        // Token: 0x04000497 RID: 1175
        public const string gcStr_RoleViewerID = "0000000015";

        // Token: 0x04000498 RID: 1176
        public const string gcStr_RolePSID = "0000000018";

        // Token: 0x04000499 RID: 1177
        public const string gcStr_RoleCCID = "0000000007";

        // Token: 0x0400049A RID: 1178
        public const string gcStr_RolePMID = "0000000001";

        // Token: 0x0400049B RID: 1179
        public const string gcStr_RolePLID = "0000000002";

        // Token: 0x0400049C RID: 1180
        public const string gcStr_RoleQAID = "0000000003";

        // Token: 0x0400049D RID: 1181
        public const string gcStr_RoleManagerID = "0000000009";

        // Token: 0x0400049E RID: 1182
        public const string gcStr_CodeStaff = "0000000009";

        // Token: 0x0400049F RID: 1183
        public const string gcStr_VDirector = "0000000055";

        // Token: 0x040004A0 RID: 1184
        public const string gcStr_Business = "0000000078";

        // Token: 0x040004A1 RID: 1185
        public const string gcStr_AdminGName = "Admin";

        // Token: 0x040004A2 RID: 1186
        public const string appointmentUserSplitter = ";";

        // Token: 0x040004A3 RID: 1187
        public const string roomTypeID = "RT001";

        // Token: 0x040004A4 RID: 1188
        public const string smartroomID = "0000000739";

        // Token: 0x040004A5 RID: 1189
        public const string polycomTypeID = "RT004";

        // Token: 0x040004A6 RID: 1190
        public const string gcStr_MSCLOCSetupPath = "\\\\fjs-02.fujinet.vn\\fjn_doc$\\1_Fujinet_QMS_Library (PAL)\\5_SupportTools\\Programming\\LineOfCode\\LOCCounter\\standalone";

        // Token: 0x040004A7 RID: 1191
        public const int XlDirection_xlDown = -4121;

        // Token: 0x040004A8 RID: 1192
        public const int XlVAlign_xlVAlignBottom = -4107;

        // Token: 0x040004A9 RID: 1193
        public const int XlSortOrder_xlAscending = 1;

        // Token: 0x040004AA RID: 1194
        public const int XlYesNoGuess_xlGuess = 0;

        // Token: 0x040004AB RID: 1195
        public const int XlSortDataOption_xlSortNormal = 0;

        // Token: 0x040004AC RID: 1196
        public const int Constants_xlTopToBottom = 1;

        // Token: 0x040004AD RID: 1197
        public const int XlCalculation_xlCalculationManual = -4135;

        // Token: 0x040004AE RID: 1198
        public const int XlCalculation_xlCalculationAutomatic = -4105;

        // Token: 0x040004AF RID: 1199
        public static ReaderWriterLockSlim rwl = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

        // Token: 0x040004B0 RID: 1200
        public const int rwlTimeOut = 900000;

        // Token: 0x040004B1 RID: 1201
        public static cls_DB_Access gvObj_Database;

        // Token: 0x040004B2 RID: 1202
        public static cls_DB_Access gvObj_DatabaseToProjectServer;

        // Token: 0x040004B3 RID: 1203
        public static cls_DB_Access gvObj_DatabaseToProjectServer2007;

        // Token: 0x040004B4 RID: 1204
        public static Fujinet.DB.MySQL.cls_DB_Access gvObj_DatabaseToQAMS;

        // Token: 0x040004B5 RID: 1205
        public static Fujinet.DB.MySQL.cls_DB_Access gvObj_DatabaseToBTMS;

        // Token: 0x040004B6 RID: 1206
        public static string gvStr_Password;

        // Token: 0x040004B7 RID: 1207
        public static mod_WMS_Declare.pLoginInfo gvObj_LoginInfo;

        // Token: 0x040004B8 RID: 1208
        public static string gvStr_TempDir;

        // Token: 0x040004B9 RID: 1209
        public static ResourceManager gvObj_LocaleResourceManager;

        // Token: 0x040004BA RID: 1210
        public static object gvArr_TypeNotUpdate = new object[]
        {
            "0000000001",
            "0000000002",
            "0000000003",
            "0000000004",
            "0000000005",
            "0000000006",
            "0000000007",
            "0000000008",
            "0000000009",
            "0000000010"
        };

        // Token: 0x040004BB RID: 1211
        public static cls_CM_Master gvObj_Master;

        // Token: 0x040004BC RID: 1212
        public static string gvStr_IDFormatString = "0000000000";

        // Token: 0x040004BD RID: 1213
        public static bool gvBln_ReLogin = false;

        //todo
        //// Token: 0x040004BE RID: 1214
        //public static FJN_WMSEntities gvObj_SQLEntity = new FJN_WMSEntities();

        // Token: 0x040004BF RID: 1215
        public static string gvStr_BTMSCreateUser = "createprjbtms";

        // Token: 0x040004C0 RID: 1216
        public static string gvStr_BTMSCreatePass = "XmdK833?";

        // Token: 0x040004C1 RID: 1217
        public static string gvStr_QAMSCreateUser = "createprjqams";

        // Token: 0x040004C2 RID: 1218
        public static string gvStr_QAMSCreatePass = "PhFg646$";

        // Token: 0x040004C3 RID: 1219
        public const string commonUserService = "commonuser";

        // Token: 0x040004C4 RID: 1220
        public const string commonPassService = "c6311f832665b51143c8d8075e6779a4";

        // Token: 0x040004C5 RID: 1221
        public const string encryptADUser = "YP8a3Sj3YzOPLHTlQ+X5QA==";

        // Token: 0x040004C6 RID: 1222
        public const string encryptADPass = "p209owbeSNyKeZ/Q83Eqkg5/eAhbaep+8TSTMP5fQ+8=";

        // Token: 0x040004C7 RID: 1223
        public const string encryptBTMSUser = "Mrynj71IlRNvEj21+KN1IkCgfafZH8StCIt+DKmxWV0=";

        // Token: 0x040004C8 RID: 1224
        public const string encryptBTMSPass = "rv0LItJHh5fb9hD8HH3t1kpI/M989j9KluDwNNCBd38=";

        // Token: 0x02000311 RID: 785
        public enum gcObj_DocumentOwner
        {
            // Token: 0x04001157 RID: 4439
            CMMIOwner = 1,
            // Token: 0x04001158 RID: 4440
            ISMSOwner,
            // Token: 0x04001159 RID: 4441
            Others
        }

        // Token: 0x02000312 RID: 786
        public enum StakeholderCommitmentStatus
        {
            // Token: 0x0400115B RID: 4443
            Monitoring = 1,
            // Token: 0x0400115C RID: 4444
            Cancelled,
            // Token: 0x0400115D RID: 4445
            Closed
        }

        // Token: 0x02000313 RID: 787
        public struct pStaffInfo
        {
            // Token: 0x0400115E RID: 4446
            public string ID;

            // Token: 0x0400115F RID: 4447
            public string Name;

            // Token: 0x04001160 RID: 4448
            public string ShortName;

            // Token: 0x04001161 RID: 4449
            public string Sex;

            // Token: 0x04001162 RID: 4450
            public string Birthday;

            // Token: 0x04001163 RID: 4451
            public string Tel;

            // Token: 0x04001164 RID: 4452
            public string Fax;

            // Token: 0x04001165 RID: 4453
            public string ZipCode;

            // Token: 0x04001166 RID: 4454
            public string Address;

            // Token: 0x04001167 RID: 4455
            public string Email;

            // Token: 0x04001168 RID: 4456
            public string URL;

            // Token: 0x04001169 RID: 4457
            public string Note;

            // Token: 0x0400116A RID: 4458
            public string StartWorkingDate;

            // Token: 0x0400116B RID: 4459
            public string EndWorkingDate;

            // Token: 0x0400116C RID: 4460
            public string UserName;

            // Token: 0x0400116D RID: 4461
            public string Password;

            // Token: 0x0400116E RID: 4462
            public string UseDomainPassword;

            // Token: 0x0400116F RID: 4463
            public string RegDate;

            // Token: 0x04001170 RID: 4464
            public string RegStaff;

            // Token: 0x04001171 RID: 4465
            public string ModDate;

            // Token: 0x04001172 RID: 4466
            public string ModStaff;

            // Token: 0x04001173 RID: 4467
            public string TopOrganizationID;

            // Token: 0x04001174 RID: 4468
            public mod_WMS_Declare.EmployeeType EmpType;

            // Token: 0x04001175 RID: 4469
            public string Team;

            // Token: 0x04001176 RID: 4470
            public string Department;

            // Token: 0x04001177 RID: 4471
            public string Title;

            // Token: 0x04001178 RID: 4472
            public string UsingBugTrackerURL;

            // Token: 0x04001179 RID: 4473
            public string UsingProjectServerURL;

            // Token: 0x0400117A RID: 4474
            public string UsingQAMSURL;

            // Token: 0x0400117B RID: 4475
            public string UsingIntranetURL;

            // Token: 0x0400117C RID: 4476
            public string UsingPTMSURL;

            // Token: 0x0400117D RID: 4477
            public byte Location;

            // Token: 0x0400117E RID: 4478
            public bool ShowDashboard;

            // Token: 0x0400117F RID: 4479
            public bool ShowTodayWork;

            // Token: 0x04001180 RID: 4480
            public bool ShowOtherWork;

            // Token: 0x04001181 RID: 4481
            public bool ShowNewNotices;

            // Token: 0x04001182 RID: 4482
            public bool ShowReadNotices;

            // Token: 0x04001183 RID: 4483
            public bool ShowDeliveryList;

            // Token: 0x04001184 RID: 4484
            public bool ShowSCList;

            // Token: 0x04001185 RID: 4485
            public bool ShowProjectManagementHelp;

            // Token: 0x04001186 RID: 4486
            public bool ShowProcess;

            // Token: 0x04001187 RID: 4487
            public bool ShowTask;

            // Token: 0x04001188 RID: 4488
            public bool ShowTimerLogger;

            // Token: 0x04001189 RID: 4489
            public string StyleName;

            // Token: 0x0400118A RID: 4490
            public string FADeptCode;

            // Token: 0x0400118B RID: 4491
            public bool RunFDCA;
        }

        // Token: 0x02000314 RID: 788
        public struct pLoginInfo
        {
            // Token: 0x0400118C RID: 4492
            public mod_WMS_Declare.pStaffInfo StaffInfo;
        }

        // Token: 0x02000315 RID: 789
        public struct pADItem
        {
            // Token: 0x0400118D RID: 4493
            public string str_DisplayName;

            // Token: 0x0400118E RID: 4494
            public string str_UserID;

            // Token: 0x0400118F RID: 4495
            public string str_Mail;
        }

        // Token: 0x02000316 RID: 790
        public struct CellData
        {
            // Token: 0x04001190 RID: 4496
            public long RowIndex;

            // Token: 0x04001191 RID: 4497
            public long ColIndex;

            // Token: 0x04001192 RID: 4498
            public string Text;
        }

        // Token: 0x02000317 RID: 791
        public enum DayFormat
        {
            // Token: 0x04001194 RID: 4500
            YYYYMMDD = 1,
            // Token: 0x04001195 RID: 4501
            YYYYsMMsDD,
            // Token: 0x04001196 RID: 4502
            YYYYMMDDHHmmSS
        }

        // Token: 0x02000318 RID: 792
        public enum EmployeeType
        {
            // Token: 0x04001198 RID: 4504
            SYSTEMADMIN = 1,
            // Token: 0x04001199 RID: 4505
            LOCALADMIN,
            // Token: 0x0400119A RID: 4506
            STAFF
        }

        // Token: 0x02000319 RID: 793
        public enum ObjectClass
        {
            // Token: 0x0400119C RID: 4508
            TYPE,
            // Token: 0x0400119D RID: 4509
            CODE
        }
    } // class
} //ns
