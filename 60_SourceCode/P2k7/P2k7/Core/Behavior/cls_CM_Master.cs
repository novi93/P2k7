using Microsoft.VisualBasic.CompilerServices;

namespace P2k7.Core.Behavior
{
    // Token: 0x02000071 RID: 113
    public class cls_CM_Master
    {
        // Token: 0x170001E1 RID: 481
        // (get) Token: 0x0600052C RID: 1324 RVA: 0x00014684 File Offset: 0x00012884
        // (set) Token: 0x0600052D RID: 1325 RVA: 0x0001469C File Offset: 0x0001289C
        public string AbsPathToSavingLocation
        {
            get
            {
                return this.mvStr_AbsPathToSavingLocation;
            }
            set
            {
                this.mvStr_AbsPathToSavingLocation = value;
            }
        }

        // Token: 0x170001E2 RID: 482
        // (get) Token: 0x0600052E RID: 1326 RVA: 0x000146A8 File Offset: 0x000128A8
        // (set) Token: 0x0600052F RID: 1327 RVA: 0x000146C0 File Offset: 0x000128C0
        public string AbsPathToHistoryOthers
        {
            get
            {
                return this.mvStr_AbsPathToHistoryOthers;
            }
            set
            {
                this.mvStr_AbsPathToHistoryOthers = value;
            }
        }

        // Token: 0x170001E3 RID: 483
        // (get) Token: 0x06000530 RID: 1328 RVA: 0x000146CC File Offset: 0x000128CC
        // (set) Token: 0x06000531 RID: 1329 RVA: 0x000146E4 File Offset: 0x000128E4
        public string AbsPathToTemplateForCreateOthers
        {
            get
            {
                return this.mvStr_AbsPathToTemplateForCreateOthers;
            }
            set
            {
                this.mvStr_AbsPathToTemplateForCreateOthers = value;
            }
        }

        // Token: 0x170001E4 RID: 484
        // (get) Token: 0x06000532 RID: 1330 RVA: 0x000146F0 File Offset: 0x000128F0
        // (set) Token: 0x06000533 RID: 1331 RVA: 0x00014708 File Offset: 0x00012908
        public string AbsPathToPAL
        {
            get
            {
                return this.mvStr_AbsPathToPAL;
            }
            set
            {
                this.mvStr_AbsPathToPAL = value;
            }
        }

        // Token: 0x170001E5 RID: 485
        // (get) Token: 0x06000534 RID: 1332 RVA: 0x00014714 File Offset: 0x00012914
        // (set) Token: 0x06000535 RID: 1333 RVA: 0x0001472C File Offset: 0x0001292C
        public string AbsPathToFPMG
        {
            get
            {
                return this.mvStr_AbsPathToFPMG;
            }
            set
            {
                this.mvStr_AbsPathToFPMG = value;
            }
        }

        // Token: 0x170001E6 RID: 486
        // (get) Token: 0x06000536 RID: 1334 RVA: 0x00014738 File Offset: 0x00012938
        // (set) Token: 0x06000537 RID: 1335 RVA: 0x00014750 File Offset: 0x00012950
        public string AbsPathToHistory
        {
            get
            {
                return this.mvStr_AbsPathToHistory;
            }
            set
            {
                this.mvStr_AbsPathToHistory = value;
            }
        }

        // Token: 0x170001E7 RID: 487
        // (get) Token: 0x06000538 RID: 1336 RVA: 0x0001475C File Offset: 0x0001295C
        // (set) Token: 0x06000539 RID: 1337 RVA: 0x00014774 File Offset: 0x00012974
        public string HistoryPath
        {
            get
            {
                return this.mvStr_HistoryPath;
            }
            set
            {
                this.mvStr_HistoryPath = value;
            }
        }

        // Token: 0x170001E8 RID: 488
        // (get) Token: 0x0600053A RID: 1338 RVA: 0x00014780 File Offset: 0x00012980
        // (set) Token: 0x0600053B RID: 1339 RVA: 0x00014798 File Offset: 0x00012998
        public string AbsPathToTemplateForCreate
        {
            get
            {
                return this.mvStr_AbsPathToTemplateForCreate;
            }
            set
            {
                this.mvStr_AbsPathToTemplateForCreate = value;
            }
        }

        // Token: 0x170001E9 RID: 489
        // (get) Token: 0x0600053C RID: 1340 RVA: 0x000147A4 File Offset: 0x000129A4
        // (set) Token: 0x0600053D RID: 1341 RVA: 0x000147BC File Offset: 0x000129BC
        public string AbsPathToPALISMS
        {
            get
            {
                return this.mvStr_AbsPathToPALISMS;
            }
            set
            {
                this.mvStr_AbsPathToPALISMS = value;
            }
        }

        // Token: 0x170001EA RID: 490
        // (get) Token: 0x0600053E RID: 1342 RVA: 0x000147C8 File Offset: 0x000129C8
        // (set) Token: 0x0600053F RID: 1343 RVA: 0x000147E0 File Offset: 0x000129E0
        public string AbsPathToFPMGISMS
        {
            get
            {
                return this.mvStr_AbsPathToFPMGISMS;
            }
            set
            {
                this.mvStr_AbsPathToFPMGISMS = value;
            }
        }

        // Token: 0x170001EB RID: 491
        // (get) Token: 0x06000540 RID: 1344 RVA: 0x000147EC File Offset: 0x000129EC
        // (set) Token: 0x06000541 RID: 1345 RVA: 0x00014804 File Offset: 0x00012A04
        public string AbsPathToHistoryISMS
        {
            get
            {
                return this.mvStr_AbsPathToHistoryISMS;
            }
            set
            {
                this.mvStr_AbsPathToHistoryISMS = value;
            }
        }

        // Token: 0x170001EC RID: 492
        // (get) Token: 0x06000542 RID: 1346 RVA: 0x00014810 File Offset: 0x00012A10
        // (set) Token: 0x06000543 RID: 1347 RVA: 0x00014828 File Offset: 0x00012A28
        public string AbsPathToTemplateForCreateISMS
        {
            get
            {
                return this.mvStr_AbsPathToTemplateForCreateISMS;
            }
            set
            {
                this.mvStr_AbsPathToTemplateForCreateISMS = value;
            }
        }

        // Token: 0x170001ED RID: 493
        // (get) Token: 0x06000544 RID: 1348 RVA: 0x00014834 File Offset: 0x00012A34
        // (set) Token: 0x06000545 RID: 1349 RVA: 0x0001484C File Offset: 0x00012A4C
        public string AbsPathToVSSTemplate
        {
            get
            {
                return this.mvStr_AbsPathToVSSTemplate;
            }
            set
            {
                this.mvStr_AbsPathToVSSTemplate = value;
            }
        }

        // Token: 0x170001EE RID: 494
        // (get) Token: 0x06000546 RID: 1350 RVA: 0x00014858 File Offset: 0x00012A58
        // (set) Token: 0x06000547 RID: 1351 RVA: 0x00014870 File Offset: 0x00012A70
        public string AbsPathToNoVSSFolderTemplate
        {
            get
            {
                return this.mvStr_AbsPathToNoVSSFolderTemplate;
            }
            set
            {
                this.mvStr_AbsPathToNoVSSFolderTemplate = value;
            }
        }

        // Token: 0x170001EF RID: 495
        // (get) Token: 0x06000548 RID: 1352 RVA: 0x0001487C File Offset: 0x00012A7C
        // (set) Token: 0x06000549 RID: 1353 RVA: 0x00014894 File Offset: 0x00012A94
        public string AbsPathToVSSFolderTemplate
        {
            get
            {
                return this.mvStr_AbsPathToVSSFolderTemplate;
            }
            set
            {
                this.mvStr_AbsPathToVSSFolderTemplate = value;
            }
        }

        // Token: 0x170001F0 RID: 496
        // (get) Token: 0x0600054A RID: 1354 RVA: 0x000148A0 File Offset: 0x00012AA0
        // (set) Token: 0x0600054B RID: 1355 RVA: 0x000148B8 File Offset: 0x00012AB8
        public string TaskAutoReloadInterval
        {
            get
            {
                return this.mvStr_TaskAutoReloadInterval;
            }
            set
            {
                this.mvStr_TaskAutoReloadInterval = value;
            }
        }

        // Token: 0x170001F1 RID: 497
        // (get) Token: 0x0600054C RID: 1356 RVA: 0x000148C4 File Offset: 0x00012AC4
        // (set) Token: 0x0600054D RID: 1357 RVA: 0x000148DC File Offset: 0x00012ADC
        public string WMSServicesLoginUser
        {
            get
            {
                return this.mvStr_WMSServicesLoginUser;
            }
            set
            {
                this.mvStr_WMSServicesLoginUser = value;
            }
        }

        // Token: 0x170001F2 RID: 498
        // (get) Token: 0x0600054E RID: 1358 RVA: 0x000148E8 File Offset: 0x00012AE8
        // (set) Token: 0x0600054F RID: 1359 RVA: 0x00014900 File Offset: 0x00012B00
        public string WMSServicesLoginPassword
        {
            get
            {
                return this.mvStr_WMSServicesLoginPassword;
            }
            set
            {
                this.mvStr_WMSServicesLoginPassword = value;
            }
        }

        // Token: 0x170001F3 RID: 499
        // (get) Token: 0x06000550 RID: 1360 RVA: 0x0001490C File Offset: 0x00012B0C
        // (set) Token: 0x06000551 RID: 1361 RVA: 0x00014924 File Offset: 0x00012B24
        public string CommonSalt
        {
            get
            {
                return this.mvStr_CommonSalt;
            }
            set
            {
                this.mvStr_CommonSalt = value;
            }
        }

        // Token: 0x170001F4 RID: 500
        // (get) Token: 0x06000552 RID: 1362 RVA: 0x00014930 File Offset: 0x00012B30
        // (set) Token: 0x06000553 RID: 1363 RVA: 0x00014948 File Offset: 0x00012B48
        public string AESKey
        {
            get
            {
                return this.mvStr_AESKey;
            }
            set
            {
                this.mvStr_AESKey = value;
            }
        }

        // Token: 0x06000554 RID: 1364 RVA: 0x00014954 File Offset: 0x00012B54
        public cls_CM_Master()
        {
            this.mvStr_AbsPathToPAL = "";
            this.mvStr_AbsPathToFPMG = "";
            this.mvStr_AbsPathToHistory = "";
            this.mvStr_HistoryPath = "";
            this.mvStr_AbsPathToTemplateForCreate = "";
            this.mvStr_AbsPathToVSSTemplate = "";
            this.mvStr_AbsPathToNoVSSFolderTemplate = "";
            this.mvStr_AbsPathToVSSFolderTemplate = "";
            this.mvStr_TaskAutoReloadInterval = "";
            this.mvObj_DBMaster = new cls_DB_Master();
        }

        // Token: 0x06000555 RID: 1365 RVA: 0x000149D8 File Offset: 0x00012BD8
        public void fncG_CM_GetData()
        {
            cls_DB_Master cls_DB_Master = this.mvObj_DBMaster;
            cls_CM_Master cls_CM_Master = this;
            cls_DB_Master.fncG_DB_GetData(ref cls_CM_Master);
            this.AbsPathToFPMG = this.fncG_CM_DropSlash(this.AbsPathToFPMG);
            this.AbsPathToHistory = this.fncG_CM_DropSlash(this.AbsPathToHistory);
            this.AbsPathToPAL = this.fncG_CM_DropSlash(this.AbsPathToPAL);
            this.AbsPathToNoVSSFolderTemplate = this.fncG_CM_DropSlash(this.AbsPathToNoVSSFolderTemplate);
            this.AbsPathToTemplateForCreate = this.fncG_CM_DropSlash(this.AbsPathToTemplateForCreate);
            this.AbsPathToVSSFolderTemplate = this.fncG_CM_DropSlash(this.AbsPathToVSSFolderTemplate);
            this.AbsPathToVSSTemplate = this.fncG_CM_DropSlash(this.AbsPathToVSSTemplate);
        }

        // Token: 0x06000556 RID: 1366 RVA: 0x00014A7B File Offset: 0x00012C7B
        public void fncG_CM_Update()
        {
            this.mvObj_DBMaster.fncG_DB_Update(this);
        }

        // Token: 0x06000557 RID: 1367 RVA: 0x00014A8C File Offset: 0x00012C8C
        public string fncG_CM_DropSlash(string iStr_Path)
        {
            bool flag = Operators.CompareString(iStr_Path, "", false) != 0;
            checked
            {
                if (flag)
                {
                    bool flag2 = Operators.CompareString(Conversions.ToString(iStr_Path[iStr_Path.Length - 1]), "\\", false) == 0;
                    if (flag2)
                    {
                        iStr_Path = iStr_Path.Remove(iStr_Path.Length - 1);
                    }
                }
                return iStr_Path;
            }
        }

        // Token: 0x040002AE RID: 686
        private string mvStr_AbsPathToPAL;

        // Token: 0x040002AF RID: 687
        private string mvStr_AbsPathToFPMG;

        // Token: 0x040002B0 RID: 688
        private string mvStr_AbsPathToHistory;

        // Token: 0x040002B1 RID: 689
        private string mvStr_HistoryPath;

        // Token: 0x040002B2 RID: 690
        private string mvStr_AbsPathToTemplateForCreate;

        // Token: 0x040002B3 RID: 691
        private string mvStr_AbsPathToPALISMS;

        // Token: 0x040002B4 RID: 692
        private string mvStr_AbsPathToFPMGISMS;

        // Token: 0x040002B5 RID: 693
        private string mvStr_AbsPathToHistoryISMS;

        // Token: 0x040002B6 RID: 694
        private string mvStr_AbsPathToTemplateForCreateISMS;

        // Token: 0x040002B7 RID: 695
        private string mvStr_AbsPathToVSSTemplate;

        // Token: 0x040002B8 RID: 696
        private string mvStr_AbsPathToNoVSSFolderTemplate;

        // Token: 0x040002B9 RID: 697
        private string mvStr_AbsPathToVSSFolderTemplate;

        // Token: 0x040002BA RID: 698
        private string mvStr_TaskAutoReloadInterval;

        // Token: 0x040002BB RID: 699
        private string mvStr_AbsPathToSavingLocation;

        // Token: 0x040002BC RID: 700
        private string mvStr_AbsPathToHistoryOthers;

        // Token: 0x040002BD RID: 701
        private string mvStr_AbsPathToTemplateForCreateOthers;

        // Token: 0x040002BE RID: 702
        private string mvStr_WMSServicesLoginUser;

        // Token: 0x040002BF RID: 703
        private string mvStr_WMSServicesLoginPassword;

        // Token: 0x040002C0 RID: 704
        private string mvStr_CommonSalt;

        // Token: 0x040002C1 RID: 705
        private string mvStr_AESKey;

        // Token: 0x040002C2 RID: 706
        private cls_DB_Master mvObj_DBMaster;
    } //cls
} //ns
