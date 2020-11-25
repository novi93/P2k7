using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using P2k7.ProjectWebSvc;
using P2k7.ResourceWebSvc;

namespace P2k7.Core.Behavior
{
    // Token: 0x02000154 RID: 340
    public class cls_CM_ResourceOnServer2007
    {
        // Token: 0x17000751 RID: 1873
        // (get) Token: 0x0600143B RID: 5179 RVA: 0x0009021C File Offset: 0x0008E41C
        // (set) Token: 0x0600143C RID: 5180 RVA: 0x00090234 File Offset: 0x0008E434
        public Guid ID
        {
            get
            {
                return this.ResourceID;
            }
            set
            {
                this.ResourceID = value;
            }
        }

        // Token: 0x17000752 RID: 1874
        // (get) Token: 0x0600143D RID: 5181 RVA: 0x00090240 File Offset: 0x0008E440
        // (set) Token: 0x0600143E RID: 5182 RVA: 0x00090258 File Offset: 0x0008E458
        public string Name
        {
            get
            {
                return this.ResourceName;
            }
            set
            {
                this.ResourceName = value;
            }
        }

        // Token: 0x17000753 RID: 1875
        // (get) Token: 0x0600143F RID: 5183 RVA: 0x00090264 File Offset: 0x0008E464
        // (set) Token: 0x06001440 RID: 5184 RVA: 0x0009027C File Offset: 0x0008E47C
        public string Account
        {
            get
            {
                return this.NTAccount;
            }
            set
            {
                this.NTAccount = value;
            }
        }

        // Token: 0x17000754 RID: 1876
        // (get) Token: 0x06001441 RID: 5185 RVA: 0x00090288 File Offset: 0x0008E488
        // (set) Token: 0x06001442 RID: 5186 RVA: 0x000902A0 File Offset: 0x0008E4A0
        public Guid EnterpriseID
        {
            get
            {
                return this.UniqueEnterpriseID;
            }
            set
            {
                this.UniqueEnterpriseID = value;
            }
        }

        // Token: 0x17000755 RID: 1877
        // (get) Token: 0x06001443 RID: 5187 RVA: 0x000902AC File Offset: 0x0008E4AC
        // (set) Token: 0x06001444 RID: 5188 RVA: 0x000902C4 File Offset: 0x0008E4C4
        public decimal BaselinedEffort
        {
            get
            {
                return this.BaselinedEff;
            }
            set
            {
                this.BaselinedEff = value;
            }
        }

        // Token: 0x17000756 RID: 1878
        // (get) Token: 0x06001445 RID: 5189 RVA: 0x000902D0 File Offset: 0x0008E4D0
        // (set) Token: 0x06001446 RID: 5190 RVA: 0x000902E8 File Offset: 0x0008E4E8
        public decimal ScheduleEffort
        {
            get
            {
                return this.ScheduleEff;
            }
            set
            {
                this.ScheduleEff = value;
            }
        }

        // Token: 0x17000757 RID: 1879
        // (get) Token: 0x06001447 RID: 5191 RVA: 0x000902F4 File Offset: 0x0008E4F4
        // (set) Token: 0x06001448 RID: 5192 RVA: 0x0009030C File Offset: 0x0008E50C
        public decimal ActualEffort
        {
            get
            {
                return this.ActualEff;
            }
            set
            {
                this.ActualEff = value;
            }
        }

        // Token: 0x17000758 RID: 1880
        // (get) Token: 0x06001449 RID: 5193 RVA: 0x00090318 File Offset: 0x0008E518
        // (set) Token: 0x0600144A RID: 5194 RVA: 0x00090330 File Offset: 0x0008E530
        public decimal OvertimeEffort
        {
            get
            {
                return this.OvertimeEff;
            }
            set
            {
                this.OvertimeEff = value;
            }
        }

        // Token: 0x0600144B RID: 5195 RVA: 0x0009033C File Offset: 0x0008E53C
        public cls_CM_ResourceOnServer2007()
        {
            this.ResourceID = default(Guid);
            this.ResourceName = "";
            this.NTAccount = "";
            this.UniqueEnterpriseID = default(Guid);
            this.BaselinedEff = 0m;
            this.ScheduleEff = 0m;
            this.ActualEff = 0m;
            this.OvertimeEff = 0m;
        }

        // Token: 0x0600144C RID: 5196 RVA: 0x000903B0 File Offset: 0x0008E5B0
        public cls_CM_ResourceOnServer2007(cls_CM_ResourceOnServer2007 Resource)
        {
            this.ResourceID = Resource.ResourceID;
            this.ResourceName = Resource.ResourceName;
            this.NTAccount = Resource.NTAccount;
            this.UniqueEnterpriseID = Resource.UniqueEnterpriseID;
            this.BaselinedEff = Resource.BaselinedEff;
            this.ScheduleEff = Resource.ScheduleEff;
            this.ActualEff = Resource.ActualEff;
            this.OvertimeEff = Resource.OvertimeEff;
        }

        // Token: 0x0600144D RID: 5197 RVA: 0x00090428 File Offset: 0x0008E628
        public List<cls_CM_ResourceOnServer2007> GetResourceOfSchedule(Guid intProjectID, DataStoreEnum whereToGet)
        {
            Project project = new Project();
            List<cls_CM_ResourceOnServer2007> list = new List<cls_CM_ResourceOnServer2007>();
            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
            project.Credentials = cls_CM_Function.GetCredentials(false);
            ProjectDataSet projectDataSet = project.ReadProjectEntities(intProjectID, 4, whereToGet);
            cls_CM_Staff_Abridged cls_CM_Staff_Abridged = new cls_CM_Staff_Abridged();
            try
            {
                foreach (object obj in projectDataSet.ProjectResource)
                {
                    ProjectDataSet.ProjectResourceRow projectResourceRow = (ProjectDataSet.ProjectResourceRow)obj;
                    cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer = new cls_CM_ResourceOnServer2007();
                    cls_CM_ResourceOnServer.ID = projectResourceRow.RES_UID;
                    bool flag = !projectResourceRow.IsWRES_ACCOUNTNull();
                    if (flag)
                    {
                        cls_CM_ResourceOnServer.Account = projectResourceRow.WRES_ACCOUNT;
                    }
                    else
                    {
                        cls_CM_ResourceOnServer.Account = "";
                    }
                    string[] array = cls_CM_ResourceOnServer.Account.Split(new char[]
                    {
                        '\\'
                    });
                    bool flag2 = array != null && array.Length == 2;
                    if (flag2)
                    {
                        ArrayList arrayList = cls_CM_Staff_Abridged.fncG_CM_GetStaffList("", array[1], "", "", "", "", false, "", false);
                        bool flag3 = arrayList != null && arrayList.Count > 0;
                        if (flag3)
                        {
                            cls_CM_ResourceOnServer.Name = Conversions.ToString(NewLateBinding.LateGet(arrayList[0], null, "FullName", new object[0], null, null, null));
                        }
                        else
                        {
                            cls_CM_ResourceOnServer.Name = projectResourceRow.RES_NAME;
                        }
                    }
                    else
                    {
                        cls_CM_ResourceOnServer.Name = projectResourceRow.RES_NAME;
                    }
                    cls_CM_ResourceOnServer.EnterpriseID = projectResourceRow.RES_UID;
                    list.Add(cls_CM_ResourceOnServer);
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

        // Token: 0x0600144E RID: 5198 RVA: 0x000905FC File Offset: 0x0008E7FC
        public List<cls_CM_ResourceOnServer2007> GetResourceInfo(Guid strID, string strAccount = "")
        {
            ResourceUserView resourceUserView = new ResourceUserView();
            MSP_EpmResource_UserView msp_EpmResource_UserView = new MSP_EpmResource_UserView();
            List<cls_CM_ResourceOnServer2007> list = new List<cls_CM_ResourceOnServer2007>();
            cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer = new cls_CM_ResourceOnServer2007();
            bool flag = strID != Guid.Empty & Operators.CompareString(strAccount, "", false) != 0;
            if (flag)
            {
                bool flag2 = !strAccount.Contains("FUJINET\\");
                if (flag2)
                {
                    strAccount = strAccount.Insert(0, "FUJINET\\");
                }
                msp_EpmResource_UserView = resourceUserView.MSP_EpmResource_UserView.SingleOrDefault((MSP_EpmResource_UserView x) => x.ResourceUID == strID & Operators.CompareString(x.ResourceNTAccount, strAccount, false) == 0);
            }
            else
            {
                bool flag3 = strID != Guid.Empty;
                if (flag3)
                {
                    msp_EpmResource_UserView = resourceUserView.MSP_EpmResource_UserView.SingleOrDefault((MSP_EpmResource_UserView x) => x.ResourceUID == strID);
                }
                else
                {
                    bool flag4 = Operators.CompareString(strAccount, "", false) != 0;
                    if (flag4)
                    {
                        bool flag5 = !strAccount.Contains("FUJINET\\");
                        if (flag5)
                        {
                            strAccount = strAccount.Insert(0, "FUJINET\\");
                        }
                        msp_EpmResource_UserView = resourceUserView.MSP_EpmResource_UserView.SingleOrDefault((MSP_EpmResource_UserView x) => Operators.CompareString(x.ResourceNTAccount, strAccount, false) == 0);
                    }
                }
            }
            cls_CM_ResourceOnServer.Account = msp_EpmResource_UserView.ResourceNTAccount;
            cls_CM_ResourceOnServer.ID = msp_EpmResource_UserView.ResourceUID;
            cls_CM_ResourceOnServer.Name = msp_EpmResource_UserView.ResourceName;
            list.Add(cls_CM_ResourceOnServer);
            return list;
        }

        // Token: 0x0600144F RID: 5199 RVA: 0x0009098C File Offset: 0x0008EB8C
        public List<cls_CM_ResourceOnServer2007> GetResourceInfo(ResourceDataSet resourceDS, Guid strID, string strAccount = "")
        {
            cls_CM_ResourceOnServer2007._Closure$__36 - 0 CS$<> 8__locals1 = new cls_CM_ResourceOnServer2007._Closure$__36 - 0(CS$<> 8__locals1);
            CS$<> 8__locals1.$VB$Local_strID = strID;
            CS$<> 8__locals1.$VB$Local_strAccount = strAccount;
            ResourceUserView resourceUserView = new ResourceUserView();
            List<cls_CM_ResourceOnServer2007> list = new List<cls_CM_ResourceOnServer2007>();
            bool flag = CS$<> 8__locals1.$VB$Local_strID != Guid.Empty;
            if (flag)
            {
                cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer = new cls_CM_ResourceOnServer2007();
                MSP_EpmResource_UserView msp_EpmResource_UserView = new MSP_EpmResource_UserView();
                msp_EpmResource_UserView = resourceUserView.MSP_EpmResource_UserView.SingleOrDefault((MSP_EpmResource_UserView x) => x.ResourceUID == CS$<> 8__locals1.$VB$Local_strID);
                cls_CM_ResourceOnServer.Account = msp_EpmResource_UserView.ResourceNTAccount;
                cls_CM_ResourceOnServer.ID = msp_EpmResource_UserView.ResourceUID;
                cls_CM_ResourceOnServer.Name = msp_EpmResource_UserView.ResourceName;
                list.Add(cls_CM_ResourceOnServer);
            }
            else
            {
                bool flag2 = Operators.CompareString(CS$<> 8__locals1.$VB$Local_strAccount, "", false) != 0;
                if (flag2)
                {
                    MSP_EpmResource_UserView msp_EpmResource_UserView2 = new MSP_EpmResource_UserView();
                    cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer2 = new cls_CM_ResourceOnServer2007();
                    bool flag3 = !CS$<> 8__locals1.$VB$Local_strAccount.Contains("FUJINET\\");
                    if (flag3)
                    {
                        CS$<> 8__locals1.$VB$Local_strAccount = CS$<> 8__locals1.$VB$Local_strAccount.Insert(0, "FUJINET\\");
                    }
                    msp_EpmResource_UserView2 = resourceUserView.MSP_EpmResource_UserView.SingleOrDefault((MSP_EpmResource_UserView x) => Operators.CompareString(x.ResourceNTAccount, CS$<> 8__locals1.$VB$Local_strAccount, false) == 0);
                    cls_CM_ResourceOnServer2.Account = msp_EpmResource_UserView2.ResourceNTAccount;
                    cls_CM_ResourceOnServer2.ID = msp_EpmResource_UserView2.ResourceUID;
                    cls_CM_ResourceOnServer2.Name = msp_EpmResource_UserView2.ResourceName;
                    list.Add(cls_CM_ResourceOnServer2);
                }
                else
                {
                    try
                    {
                        foreach (object obj in resourceDS.Resources.Rows)
                        {
                            ResourceDataSet.ResourcesRow resourcesRow = (ResourceDataSet.ResourcesRow)obj;
                            list.Add(new cls_CM_ResourceOnServer2007
                            {
                                Account = resourcesRow.WRES_ACCOUNT,
                                ID = resourcesRow.RES_UID,
                                Name = resourcesRow.RES_NAME
                            });
                        }
                    }
                    finally
                    {
                        IEnumerator enumerator;
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }
            }
            return list;
        }

        // Token: 0x06001450 RID: 5200 RVA: 0x00090C90 File Offset: 0x0008EE90
        public static ResourceDataSet GetAllResource()
        {
            cls_CM_Function.OverrideCertificateValidation();
            ResourceDataSet resourceDataSet = new ResourceDataSet();
            return new Resource
            {
                Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx",
                Credentials = cls_CM_Function.GetCredentials(false)
            }.ReadResources("", false);
        }

        // Token: 0x04000D07 RID: 3335
        private Guid ResourceID;

        // Token: 0x04000D08 RID: 3336
        private string ResourceName;

        // Token: 0x04000D09 RID: 3337
        private string NTAccount;

        // Token: 0x04000D0A RID: 3338
        private Guid UniqueEnterpriseID;

        // Token: 0x04000D0B RID: 3339
        private decimal BaselinedEff;

        // Token: 0x04000D0C RID: 3340
        private decimal ScheduleEff;

        // Token: 0x04000D0D RID: 3341
        private decimal ActualEff;

        // Token: 0x04000D0E RID: 3342
        private decimal OvertimeEff;
    }
}
