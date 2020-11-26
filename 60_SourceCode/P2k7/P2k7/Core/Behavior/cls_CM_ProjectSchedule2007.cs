using P2k7.Core.Behavior.DB_SQLServer;
using P2k7.CustomfieldsWebSvc;
using P2k7.Entities.Enum;
using P2k7.LookuptableWebSvc;
using P2k7.ProjectWebSvc;
using P2k7.ResourceWebSvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P2k7.Core.Behavior
{
    public class cls_CM_ProjectSchedule2007
    {
        // Token: 0x06000DB9 RID: 3513 RVA: 0x00052FAB File Offset: 0x000511AB
        public cls_CM_ProjectSchedule2007()
        {
            //this.ScheduleOwner = new cls_CM_ResourceOnServer2007();
            //this.ListPrjEffort = new List<ProjectStaffEffort>();
            this._readOnlyData = false;
        }

        // Token: 0x17000517 RID: 1303
        // (get) Token: 0x06000DBA RID: 3514 RVA: 0x00052FD4 File Offset: 0x000511D4
        // (set) Token: 0x06000DBB RID: 3515 RVA: 0x00052FEC File Offset: 0x000511EC
        public Guid ID
        {
            get
            {
                return this.WScheduleID;
            }
            set
            {
                this.WScheduleID = value;
            }
        }

        // Token: 0x17000518 RID: 1304
        // (get) Token: 0x06000DBC RID: 3516 RVA: 0x00052FF8 File Offset: 0x000511F8
        // (set) Token: 0x06000DBD RID: 3517 RVA: 0x00053010 File Offset: 0x00051210
        public bool ReadOnlyData
        {
            get
            {
                return this._readOnlyData;
            }
            set
            {
                this._readOnlyData = value;
            }
        }

        // Token: 0x17000519 RID: 1305
        // (get) Token: 0x06000DBE RID: 3518 RVA: 0x0005301C File Offset: 0x0005121C
        // (set) Token: 0x06000DBF RID: 3519 RVA: 0x00053034 File Offset: 0x00051234
        public string Name
        {
            get
            {
                return this.ScheduleName;
            }
            set
            {
                this.ScheduleName = value;
            }
        }

        //// Token: 0x1700051A RID: 1306
        //// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00053040 File Offset: 0x00051240
        //// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00053058 File Offset: 0x00051258
        //public cls_CM_ResourceOnServer2007 Manager
        //{
        //    get
        //    {
        //        return this.ScheduleOwner;
        //    }
        //    set
        //    {
        //        this.ScheduleOwner = value;
        //    }
        //}

        //// Token: 0x1700051B RID: 1307
        //// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00053064 File Offset: 0x00051264
        //// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0005307C File Offset: 0x0005127C
        //public List<ProjectStaffEffort> ListEffort
        //{
        //    get
        //    {
        //        return this.ListPrjEffort;
        //    }
        //    set
        //    {
        //        this.ListPrjEffort = value;
        //    }
        //}

        // Token: 0x1700051C RID: 1308
        // (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00053088 File Offset: 0x00051288
        // (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000530A0 File Offset: 0x000512A0
        public bool IsCheckout
        {
            get
            {
                return this.IsScheduleCheckout;
            }
            set
            {
                this.IsScheduleCheckout = value;
            }
        }

        // Token: 0x1700051D RID: 1309
        // (get) Token: 0x06000DC6 RID: 3526 RVA: 0x000530AC File Offset: 0x000512AC
        // (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000530C4 File Offset: 0x000512C4
        public ScheduleStatus Status
        {
            get
            {
                return this.ProjectScheduleStatus;
            }
            set
            {
                this.ProjectScheduleStatus = value;
            }
        }

        //        // Token: 0x06000DC8 RID: 3528 RVA: 0x000530D0 File Offset: 0x000512D0
        //        public cls_CM_ProjectSchedule2007 GetProjectSchedule(Guid intID, DataStoreEnum whereToGet, bool GetAsAdmin = false)
        //        {
        //            Project project = new Project();
        //            ArrayList arrayList = new ArrayList();
        //            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
        //            cls_CM_Function.OverrideCertificateValidation();
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            project.Credentials = cls_CM_Function.GetCredentials(GetAsAdmin);
        //            ProjectDataSet projectDataSet = project.ReadProjectEntities(intID, 1, whereToGet);
        //            ProjectUserView projectUserView = new ProjectUserView();
        //            MSP_EpmProject_UserView msp_EpmProject_UserView = new MSP_EpmProject_UserView();
        //            msp_EpmProject_UserView = projectUserView.MSP_EpmProject_UserView.SingleOrDefault((MSP_EpmProject_UserView x) => x.ProjectUID == intID);
        //            cls_CM_ProjectSchedule.Status = (ScheduleStatus)Conversions.ToInteger(Enum.Parse(typeof(ScheduleStatus), msp_EpmProject_UserView.Production_Status.Replace(" ", "")));
        //            cls_CM_ProjectSchedule.ID = intID;
        //            cls_CM_ProjectSchedule.Name = projectDataSet.Project[0].PROJ_NAME;
        //            List<cls_CM_ResourceOnServer2007> list = new List<cls_CM_ResourceOnServer2007>();
        //            list = cls_CM_ProjectSchedule.Manager.GetResourceInfo(projectDataSet.Project[0].ProjectOwnerID, "");
        //            bool flag = list.Count != 0;
        //            if (flag)
        //            {
        //                cls_CM_ProjectSchedule.Manager = list[0];
        //            }
        //            cls_CM_ProjectSchedule.IsCheckout = !projectDataSet.Project[0].IsPROJ_CHECKOUTBYNull();
        //            return cls_CM_ProjectSchedule;
        //        }

        //        // Token: 0x06000DC9 RID: 3529 RVA: 0x00053284 File Offset: 0x00051484
        //        public cls_CM_ProjectSchedule2007 GetProjectScheduleTempDB(Guid intID, DataStoreEnum whereToGet, bool GetAsAdmin = false)
        //        {
        //            Project project = new Project();
        //            ArrayList arrayList = new ArrayList();
        //            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
        //            ListScheduleTemp listScheduleTemp = new ListScheduleTemp();
        //            PRJ_ListSchedulePermission prj_ListSchedulePermission = listScheduleTemp.PRJ_ListSchedulePermission.FirstOrDefault((PRJ_ListSchedulePermission x) => Operators.CompareString(x.ScheduleGUID, intID.ToString(), false) == 0);
        //            cls_CM_ProjectSchedule.Status = (ScheduleStatus)Conversions.ToInteger(prj_ListSchedulePermission.Status);
        //            cls_CM_ProjectSchedule.ID = intID;
        //            cls_CM_ProjectSchedule.Name = prj_ListSchedulePermission.ScheduleName;
        //            cls_CM_ProjectSchedule.Manager = new cls_CM_ResourceOnServer2007();
        //            cls_CM_ProjectSchedule.Manager.Account = "FUJINET\\" + prj_ListSchedulePermission.Owner;
        //            cls_CM_ProjectSchedule.Manager.ID = new Guid(prj_ListSchedulePermission.ResourceUID);
        //            cls_CM_ProjectSchedule.Manager.Name = prj_ListSchedulePermission.ResourceName;
        //            cls_CM_ProjectSchedule.IsCheckout = false;
        //            return cls_CM_ProjectSchedule;
        //        }

        // Token: 0x06000DCA RID: 3530 RVA: 0x0005342C File Offset: 0x0005162C
        public List<cls_CM_ProjectSchedule2007> GetProjectScheduleList(Guid intID, string strName = "", cls_CM_ResourceOnServer2007 objManager = null, bool OngoingProjectsOnly = true, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore)
        {
            List<cls_CM_ProjectSchedule2007> list = new List<cls_CM_ProjectSchedule2007>();
            ResourceDataSet resourceDS = new ResourceDataSet();
            Resource resource = new Resource();
            cls_CM_Function.OverrideCertificateValidation();
            Project project = new Project();
            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
            project.Credentials = cls_CM_Function.GetCredentials(true);
            resource.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx";
            resource.Credentials = cls_CM_Function.GetCredentials(true);
            resourceDS = resource.ReadResources("", false);
            ProjectDataSet projectDataSet = new ProjectDataSet();
            projectDataSet.Merge(project.ReadProjectStatus(intID, whereToGet, strName, 0));
            //ProjectUserView projectUserView = new ProjectUserView();
            //List<cls_CM_ResourceOnServer2007> list2 = new List<cls_CM_ResourceOnServer2007>();
            //try
            //{
            //    IEnumerator enumerator = projectDataSet.Project.GetEnumerator();
            //    while (enumerator.MoveNext())
            //    {
            //        cls_CM_ProjectSchedule2007._Closure$__86 - 0 CS$<> 8__locals1 = new cls_CM_ProjectSchedule2007._Closure$__86 - 0(CS$<> 8__locals1);
            //        CS$<> 8__locals1.$VB$Local_oneRow = (ProjectDataSet.ProjectRow)enumerator.Current;
            //        bool flag = objManager != null;
            //        if (flag)
            //        {
            //            bool flag2 = !CS$<> 8__locals1.$VB$Local_oneRow.IsProjectOwnerIDNull();
            //            if (flag2)
            //            {
            //                bool flag3 = CS$<> 8__locals1.$VB$Local_oneRow.ProjectOwnerID != objManager.ID;
            //                if (flag3)
            //                {
            //                    continue;
            //                }
            //            }
            //            goto IL_102;
            //        }
            //        goto IL_102;
            //        continue;
            //    IL_102:
            //        MSP_EpmProject_UserView msp_EpmProject_UserView = projectUserView.MSP_EpmProject_UserView.SingleOrDefault((MSP_EpmProject_UserView x) => x.ProjectUID == CS$<> 8__locals1.$VB$Local_oneRow.PROJ_UID);
            //        bool flag4 = msp_EpmProject_UserView == null;
            //        if (!flag4)
            //        {
            //            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
            //            cls_CM_ProjectSchedule.Status = (ScheduleStatus)Conversions.ToInteger(Enum.Parse(typeof(ScheduleStatus), msp_EpmProject_UserView.Production_Status.Replace(" ", "")));
            //            if (OngoingProjectsOnly)
            //            {
            //                bool flag5 = cls_CM_ProjectSchedule.Status == ScheduleStatus.Completed | cls_CM_ProjectSchedule.Status == ScheduleStatus.Cancelled;
            //                if (flag5)
            //                {
            //                    continue;
            //                }
            //            }
            //            cls_CM_ProjectSchedule.ID = CS$<> 8__locals1.$VB$Local_oneRow.PROJ_UID;
            //            cls_CM_ProjectSchedule.Name = CS$<> 8__locals1.$VB$Local_oneRow.PROJ_NAME;
            //            list2 = cls_CM_ProjectSchedule.Manager.GetResourceInfo(resourceDS, msp_EpmProject_UserView.ProjectOwnerResourceUID, "");
            //            bool flag6 = list2.Count != 0;
            //            if (flag6)
            //            {
            //                cls_CM_ProjectSchedule.Manager = list2[0];
            //            }
            //            cls_CM_ProjectSchedule.IsCheckout = !CS$<> 8__locals1.$VB$Local_oneRow.IsPROJ_CHECKOUTBYNull();
            //            list.Add(cls_CM_ProjectSchedule);
            //        }
            //    }
            //}
            //finally
            //{
            //    //IEnumerator enumerator;
            //    //if (enumerator is IDisposable)
            //    //{
            //    //    (enumerator as IDisposable).Dispose();
            //    //}
            //}
            return list;
        }

        //        // Token: 0x06000DCB RID: 3531 RVA: 0x00053710 File Offset: 0x00051910
        //        public CustomFieldDataSet GetCustomFieldsDataSet()
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            CustomFields customFields = new CustomFields();
        //            customFields.Credentials = cls_CM_Function.GetCredentials(false);
        //            customFields.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/CustomFields.asmx";
        //            CustomFieldDataSet customFieldDataSet = new CustomFieldDataSet();
        //            return customFields.ReadCustomFields(new Filter
        //            {
        //                FilterTableName = customFieldDataSet.CustomFields.TableName,
        //                Fields =
        //                {
        //                    new Filter.Field(customFieldDataSet.CustomFields.TableName, customFieldDataSet.CustomFields.MD_PROP_NAMEColumn.ColumnName, Filter.SortOrderTypeEnum.Asc),
        //                    new Filter.Field(customFieldDataSet.CustomFields.MD_PROP_UIDColumn.ColumnName)
        //                },
        //                Criteria = new Filter.FieldOperator(Filter.FieldOperationType.Equal, customFieldDataSet.CustomFields.MD_ENT_TYPE_UIDColumn.ColumnName, new object[]
        //                {
        //                    EntityCollection.Entities.ProjectEntity.UniqueId
        //                })
        //            }.GetXml(), false);
        //        }

        //        // Token: 0x06000DCC RID: 3532 RVA: 0x000537F8 File Offset: 0x000519F8
        //        public LookupTableDataSet GetLookupTablesDataSet()
        //        {
        //            LookupTable lookupTable = new LookupTable();
        //            LookupTableDataSet lookupTableDataSet = new LookupTableDataSet();
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Filter filter = new Filter();
        //            filter.FilterTableName = lookupTableDataSet.LookupTableTrees.TableName;
        //            filter.Fields.Add(new Filter.Field(lookupTableDataSet.LookupTableTrees.LT_STRUCT_UIDColumn.ColumnName, Conversions.ToString(1)));
        //            filter.Fields.Add(new Filter.Field(lookupTableDataSet.LookupTableTrees.LT_VALUE_TEXTColumn.ColumnName));
        //            lookupTable.Credentials = cls_CM_Function.GetCredentials(false);
        //            lookupTable.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LookupTable.asmx";
        //            return lookupTable.ReadLookupTables("", false, 0);
        //        }

        //        // Token: 0x06000DCD RID: 3533 RVA: 0x000538A4 File Offset: 0x00051AA4
        //        public ScheduleStatus GetProjectStatus(ProjectDataSet oneProject, LookupTableDataSet lookupDS)
        //        {
        //            try
        //            {
        //                foreach (object obj in oneProject.ProjectCustomFields)
        //                {
        //                    ProjectDataSet.ProjectCustomFieldsRow projectCustomFieldsRow = (ProjectDataSet.ProjectCustomFieldsRow)obj;
        //                    bool flag = projectCustomFieldsRow.MD_PROP_UID == new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b40038d");
        //                    if (flag)
        //                    {
        //                        string lt_VALUE_TEXT = lookupDS.LookupTableTrees.FindByLT_STRUCT_UID(projectCustomFieldsRow.CODE_VALUE).LT_VALUE_TEXT;
        //                        try
        //                        {
        //                            foreach (object value in Enum.GetValues(typeof(ScheduleStatus)))
        //                            {
        //                                ScheduleStatus scheduleStatus = (ScheduleStatus)Conversions.ToInteger(value);
        //                                bool flag2 = Operators.CompareString(Enum.GetName(typeof(ScheduleStatus), scheduleStatus), lt_VALUE_TEXT, false) == 0;
        //                                if (flag2)
        //                                {
        //                                    return scheduleStatus;
        //                                }
        //                            }
        //                        }
        //                        finally
        //                        {
        //                            IEnumerator enumerator2;
        //                            if (enumerator2 is IDisposable)
        //                            {
        //                                (enumerator2 as IDisposable).Dispose();
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            finally
        //            {
        //                IEnumerator enumerator;
        //                if (enumerator is IDisposable)
        //                {
        //                    (enumerator as IDisposable).Dispose();
        //                }
        //            }
        //            return ScheduleStatus.NotInRange;
        //        }

        //        // Token: 0x06000DCE RID: 3534 RVA: 0x000539C8 File Offset: 0x00051BC8
        //        public ArrayList GetNonApproveScheduleList()
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            return cls_DB_ProjectSchedule.GetNonApproveScheduleList();
        //        }

        //        // Token: 0x06000DCF RID: 3535 RVA: 0x000539E8 File Offset: 0x00051BE8
        //        public List<cls_CM_ProjectSchedule2007> GetScheduleOfUser(string strUserName, DataStoreEnum whereToGet)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Resource resource = new Resource();
        //            resource.Credentials = cls_CM_Function.GetCredentials(false);
        //            resource.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx";
        //            ResourceDataSet resourceDataSet = new ResourceDataSet();
        //            resourceDataSet = resource.ReadResources(this.GetResourceFilter(strUserName).GetXml(), false);
        //            ResourceAssignmentDataSet resourceAssignmentDataSet = new ResourceAssignmentDataSet();
        //            Filter filter = new Filter();
        //            filter.FilterTableName = resourceAssignmentDataSet.ResourceAssignment.TableName;
        //            filter.Fields.Add(new Filter.Field(filter.FilterTableName, resourceAssignmentDataSet.ResourceAssignment.RES_UIDColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(filter.FilterTableName, resourceAssignmentDataSet.ResourceAssignment.RES_NAMEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            Filter.LogicalOperator criteria = new Filter.LogicalOperator(Filter.LogicalOperationType.Or, new List<Filter.IOperator>
        //            {
        //                new Filter.FieldOperator(Filter.FieldOperationType.Equal, resourceAssignmentDataSet.ResourceAssignment.RES_UIDColumn.ColumnName, new object[]
        //                {
        //                    resourceDataSet.Resources[0].RES_UID
        //                })
        //            }.ToArray());
        //            filter.Criteria = criteria;
        //            ResourceAssignmentDataSet resourceAssignmentDataSet2 = resource.ReadResourceAssignments(filter.GetXml());
        //            List<cls_CM_ProjectSchedule2007> list = new List<cls_CM_ProjectSchedule2007>();
        //            try
        //            {
        //                foreach (object obj in resourceAssignmentDataSet2.ResourceAssignment)
        //                {
        //                    ResourceAssignmentDataSet.ResourceAssignmentRow resourceAssignmentRow = (ResourceAssignmentDataSet.ResourceAssignmentRow)obj;
        //                    list.Add(this.GetProjectSchedule(resourceAssignmentRow.PROJ_UID, whereToGet, false));
        //                }
        //            }
        //            finally
        //            {
        //                IEnumerator enumerator;
        //                if (enumerator is IDisposable)
        //                {
        //                    (enumerator as IDisposable).Dispose();
        //                }
        //            }
        //            return list;
        //        }

        //        // Token: 0x06000DD0 RID: 3536 RVA: 0x00053B90 File Offset: 0x00051D90
        //        private Filter GetResourceFilter(string account)
        //        {
        //            ResourceDataSet resourceDataSet = new ResourceDataSet();
        //            Filter filter = new Filter();
        //            filter.FilterTableName = resourceDataSet.Resources.TableName;
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_UIDColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_NAMEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_INITIALSColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_TYPEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_CODEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_TIMESHEET_MGR_UIDColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            Filter.LogicalOperator criteria = new Filter.LogicalOperator(Filter.LogicalOperationType.Or, new List<Filter.IOperator>
        //            {
        //                new Filter.FieldOperator(Filter.FieldOperationType.Equal, resourceDataSet.Resources.WRES_ACCOUNTColumn.ColumnName, new object[]
        //                {
        //                    "FUJINET\\" + account
        //                })
        //            }.ToArray());
        //            filter.Criteria = criteria;
        //            return filter;
        //        }

        //        // Token: 0x06000DD1 RID: 3537 RVA: 0x00053D20 File Offset: 0x00051F20
        //        public List<cls_CM_ResourceOnServer2007> GetResourceOfSchedule(Guid intProjectID, DataStoreEnum whereToGet)
        //        {
        //            return this.ScheduleOwner.GetResourceOfSchedule(intProjectID, whereToGet);
        //        }

        //        // Token: 0x06000DD2 RID: 3538 RVA: 0x00053D40 File Offset: 0x00051F40
        //        public bool SaveProjectStaffEffort(ref string activeID = "", bool isInsertEmptyMember = true)
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule2 = cls_DB_ProjectSchedule;
        //            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = this;
        //            return cls_DB_ProjectSchedule2.SaveProjectStaffEffort(ref cls_CM_ProjectSchedule, ref activeID, isInsertEmptyMember);
        //        }

        //        // Token: 0x06000DD3 RID: 3539 RVA: 0x00053D64 File Offset: 0x00051F64
        //        public bool DeleteStaffEffort(ProjectStaffEffort OneBonus)
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            return cls_DB_ProjectSchedule.DeleteStaffEffort(OneBonus);
        //        }

        //        // Token: 0x06000DD4 RID: 3540 RVA: 0x00053D84 File Offset: 0x00051F84
        //        public List<ProjectStaffEffort> GetStaffEffortList(string ProjectName)
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            this.ListEffort = cls_DB_ProjectSchedule.GetStaffEffortList(ProjectName);
        //            return this.ListEffort;
        //        }

        //        // Token: 0x06000DD5 RID: 3541 RVA: 0x00053DB0 File Offset: 0x00051FB0
        //        public List<Project2007Task> GetTaskList(int outlineLevel = -1, DataStoreEnum whereToget = DataStoreEnum.PublishedStore, bool WithAssn = false)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Project project = new Project();
        //            List<Project2007Task> list = new List<Project2007Task>();
        //            CustomFields customFields = new CustomFields();
        //            CustomFieldDataSet customFieldDS = new CustomFieldDataSet();
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            project.Credentials = cls_CM_Function.GetCredentials(true);
        //            customFields.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/CustomFields.asmx";
        //            customFields.Credentials = cls_CM_Function.GetCredentials(true);
        //            customFieldDS = customFields.ReadCustomFields("", false);
        //            LookupTable lookupTable = new LookupTable();
        //            LookupTableDataSet lookupTableDS = new LookupTableDataSet();
        //            lookupTable.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LookupTable.asmx";
        //            lookupTable.Credentials = cls_CM_Function.GetCredentials(true);
        //            lookupTableDS = lookupTable.ReadLookupTables("", false, 0);
        //            bool flag = !WithAssn;
        //            ProjectDataSet projectDataSet;
        //            if (flag)
        //            {
        //                projectDataSet = project.ReadProjectEntities(this.ID, 66, whereToget);
        //            }
        //            else
        //            {
        //                projectDataSet = project.ReadProjectEntities(this.ID, 330, whereToget);
        //            }
        //            bool flag2 = outlineLevel != -1;
        //            DataRow[] array;
        //            if (flag2)
        //            {
        //                array = projectDataSet.Task.Select(projectDataSet.Task.TASK_OUTLINE_LEVELColumn.ColumnName + "=" + Conversions.ToString(outlineLevel), projectDataSet.Task.TASK_IDColumn.ColumnName + " ASC");
        //            }
        //            else
        //            {
        //                array = projectDataSet.Task.Select("", projectDataSet.Task.TASK_IDColumn.ColumnName + " ASC");
        //            }
        //            foreach (ProjectDataSet.TaskRow taskRow in array)
        //            {
        //                Project2007Task item = default(Project2007Task);
        //                bool task_IS_NULL = taskRow.TASK_IS_NULL;
        //                if (!task_IS_NULL)
        //                {
        //                    item = this.ConvertTaskRowToProjectTask(taskRow, projectDataSet, customFieldDS, lookupTableDS);
        //                    list.Add(item);
        //                }
        //            }
        //            return list;
        //        }

        //        // Token: 0x06000DD6 RID: 3542 RVA: 0x00053F74 File Offset: 0x00052174
        //        public List<Project2007Assignment> GetTaskWithAssignmentList(DataStoreEnum whereToget = DataStoreEnum.PublishedStore, bool viewTaskOfOtherUser = false)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Project project = new Project();
        //            List<Project2007Assignment> list = new List<Project2007Assignment>();
        //            CustomFields customFields = new CustomFields();
        //            CustomFieldDataSet customFieldDS = new CustomFieldDataSet();
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            bool flag = !viewTaskOfOtherUser;
        //            if (flag)
        //            {
        //                project.Credentials = cls_CM_Function.GetCredentials(false);
        //            }
        //            else
        //            {
        //                project.Credentials = cls_CM_Function.GetCredentials(true);
        //            }
        //            customFields.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/CustomFields.asmx";
        //            customFields.Credentials = cls_CM_Function.GetCredentials(false);
        //            customFieldDS = customFields.ReadCustomFields("", false);
        //            LookupTable lookupTable = new LookupTable();
        //            LookupTableDataSet lookupTableDS = new LookupTableDataSet();
        //            lookupTable.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LookupTable.asmx";
        //            lookupTable.Credentials = cls_CM_Function.GetCredentials(false);
        //            lookupTableDS = lookupTable.ReadLookupTables("", false, 0);
        //            ResourceDataSet resourceDS = new ResourceDataSet();
        //            resourceDS = new Resource
        //            {
        //                Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx",
        //                Credentials = cls_CM_Function.GetCredentials(true)
        //            }.ReadResources("", false);
        //            ProjectDataSet projectDataSet = project.ReadProjectEntities(this.ID, 330, whereToget);
        //            ProjectDataSet.AssignmentRow[] array = (ProjectDataSet.AssignmentRow[])projectDataSet.Assignment.Select();
        //            foreach (ProjectDataSet.AssignmentRow oneRow in array)
        //            {
        //                Project2007Assignment item = default(Project2007Assignment);
        //                item = this.ConvertAssignementRowToProjectAssignment(oneRow, projectDataSet, customFieldDS, lookupTableDS, resourceDS);
        //                list.Add(item);
        //            }
        //            return list;
        //        }

        /// <summary>
        /// GetTaskCustomFieldValue
        /// </summary>
        /// <param name="projectDS"></param>
        /// <param name="customFieldDS"></param>
        /// <param name="lookupTableDS"></param>
        /// <param name="customFieldUID"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public static object GetTaskCustomFieldValue(ProjectDataSet projectDS, CustomFieldDataSet customFieldDS, LookupTableDataSet lookupTableDS, Guid customFieldUID, ProjectDataSet.TaskRow task)
        {
            ProjectDataSet.TaskCustomFieldsRow[] array = (ProjectDataSet.TaskCustomFieldsRow[])projectDS.TaskCustomFields.Select(string.Concat(new string[]
            {
                        projectDS.TaskCustomFields.TASK_UIDColumn.ColumnName,
                        "='",
                        task.TASK_UID.ToString(),
                        "' AND ",
                        projectDS.TaskCustomFields.MD_PROP_UIDColumn.ColumnName,
                        "='",
                        customFieldUID.ToString(),
                        "'"
            }));
            object obj = null;
            bool flag = array.Count() <= 0;
            object result;
            if (flag)
            {
                result = null;
            }
            else
            {
                bool flag2 = !array[0].IsCODE_VALUENull();
                if (flag2)
                {
                    Guid code_VALUE = array[0].CODE_VALUE;
                    bool flag3 = !lookupTableDS.LookupTableTrees.FindByLT_STRUCT_UID(code_VALUE).IsLT_VALUE_TEXTNull();
                    if (flag3)
                    {
                        obj = lookupTableDS.LookupTableTrees.FindByLT_STRUCT_UID(code_VALUE).LT_VALUE_TEXT;
                    }
                }
                else
                {
                    bool flag4 = !array[0].IsDUR_VALUENull();
                    if (flag4)
                    {
                        obj = array[0].DUR_VALUE;
                    }
                    else
                    {
                        bool flag5 = !array[0].IsNUM_VALUENull();
                        if (flag5)
                        {
                            obj = array[0].NUM_VALUE;
                        }
                        else
                        {
                            bool flag6 = !array[0].IsDATE_VALUENull();
                            if (flag6)
                            {
                                obj = array[0].DATE_VALUE;
                            }
                            else
                            {
                                bool flag7 = !array[0].IsTEXT_VALUENull();
                                if (flag7)
                                {
                                    bool flag8 = array[0].TEXT_VALUE.IndexOf("\0") >= 0;
                                    if (flag8)
                                    {
                                        obj = array[0].TEXT_VALUE.Substring(0, array[0].TEXT_VALUE.IndexOf("\0"));
                                    }
                                    else
                                    {
                                        obj = array[0].TEXT_VALUE;
                                    }
                                }
                                else
                                {
                                    obj = array[0].FLAG_VALUE;
                                }
                            }
                        }
                    }
                }
                result = obj;
            }
            return result;
        }

        //        // Token: 0x06000DD8 RID: 3544 RVA: 0x000542CC File Offset: 0x000524CC
        //        public static object GetAssignmentCustomFieldValue(ProjectDataSet projectDS, CustomFieldDataSet customFieldDS, LookupTableDataSet lookupTableDS, Guid customFieldUID, ProjectDataSet.AssignmentRow assn)
        //        {
        //            DataRow[] array = projectDS.AssignmentCustomFields.Select(string.Concat(new string[]
        //            {
        //                projectDS.AssignmentCustomFields.ASSN_UIDColumn.ColumnName,
        //                "='",
        //                assn.ASSN_UID.ToString(),
        //                "' AND ",
        //                projectDS.AssignmentCustomFields.MD_PROP_UIDColumn.ColumnName,
        //                "='",
        //                customFieldUID.ToString(),
        //                "'"
        //            }));
        //            object obj = null;
        //            bool flag = array.Count<DataRow>() <= 0;
        //            object result;
        //            if (flag)
        //            {
        //                result = null;
        //            }
        //            else
        //            {
        //                bool flag2 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.CODE_VALUEColumn.ColumnName]));
        //                if (flag2)
        //                {
        //                    object obj2 = array[0][projectDS.AssignmentCustomFields.CODE_VALUEColumn.ColumnName];
        //                    Guid lt_STRUCT_UID = (obj2 != null) ? ((Guid)obj2) : default(Guid);
        //                    bool flag3 = !lookupTableDS.LookupTableTrees.FindByLT_STRUCT_UID(lt_STRUCT_UID).IsLT_VALUE_TEXTNull();
        //                    if (flag3)
        //                    {
        //                        obj = lookupTableDS.LookupTableTrees.FindByLT_STRUCT_UID(lt_STRUCT_UID).LT_VALUE_TEXT;
        //                    }
        //                }
        //                else
        //                {
        //                    bool flag4 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.DUR_VALUEColumn.ColumnName]));
        //                    if (flag4)
        //                    {
        //                        obj = RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.DUR_VALUEColumn.ColumnName]);
        //                    }
        //                    else
        //                    {
        //                        bool flag5 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.NUM_VALUEColumn.ColumnName]));
        //                        if (flag5)
        //                        {
        //                            obj = RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.NUM_VALUEColumn.ColumnName]);
        //                        }
        //                        else
        //                        {
        //                            bool flag6 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.DATE_VALUEColumn.ColumnName]));
        //                            if (flag6)
        //                            {
        //                                obj = RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.DATE_VALUEColumn.ColumnName]);
        //                            }
        //                            else
        //                            {
        //                                bool flag7 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.TEXT_VALUEColumn.ColumnName]));
        //                                if (flag7)
        //                                {
        //                                    obj = RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.TEXT_VALUEColumn.ColumnName]);
        //                                }
        //                                else
        //                                {
        //                                    obj = RuntimeHelpers.GetObjectValue(array[0][projectDS.AssignmentCustomFields.FLAG_VALUEColumn.ColumnName]);
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //                result = obj;
        //            }
        //            return result;
        //        }

        //        // Token: 0x06000DD9 RID: 3545 RVA: 0x00054568 File Offset: 0x00052768
        //        public Project2007Task ConvertTaskRowToProjectTask(ProjectDataSet.TaskRow oneRow, ProjectDataSet onePrj, CustomFieldDataSet customFieldDS, LookupTableDataSet lookupTableDS)
        //        {
        //            Project2007Task project2007Task = new Project2007Task
        //            {
        //                Modules = Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b40031f"), oneRow))
        //            };
        //            bool flag = project2007Task.Modules == null;
        //            if (flag)
        //            {
        //                project2007Task.Modules = "";
        //            }
        //            project2007Task.ScheduleDeliveryDate = Conversions.ToDate(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400261"), oneRow));
        //            project2007Task.ActualDeliveryDate = Conversions.ToDate(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400262"), oneRow));
        //            project2007Task.UniqueID = oneRow.TASK_UID;
        //            project2007Task.OrderID = Conversions.ToString(oneRow.TASK_ID);
        //            ProjectDataSet.AssignmentRow[] array = (ProjectDataSet.AssignmentRow[])onePrj.Assignment.Select(onePrj.Assignment.TASK_UIDColumn.ColumnName + "='" + oneRow.TASK_UID.ToString() + "'");
        //            project2007Task.AssignmentUID = new List<Guid>();
        //            foreach (ProjectDataSet.AssignmentRow assignmentRow in array)
        //            {
        //                project2007Task.AssignmentUID.Add(assignmentRow.ASSN_UID);
        //            }
        //            project2007Task.Name = (oneRow.IsTASK_NAMENull() ? "" : oneRow.TASK_NAME);
        //            project2007Task.StartDateTime = (oneRow.IsTASK_START_DATENull() ? DateTime.MinValue : oneRow.TASK_START_DATE);
        //            project2007Task.FinishDateTime = (oneRow.IsTASK_FINISH_DATENull() ? DateTime.MinValue : oneRow.TASK_FINISH_DATE);
        //            project2007Task.Work = (oneRow.IsTASK_WORKNull() ? 0.0 : oneRow.TASK_WORK) / 60000.0;
        //            project2007Task.Duration = (double)(oneRow.IsTASK_DURNull() ? 0 : oneRow.TASK_DUR);
        //            project2007Task.BaselineStartDateTime = (oneRow.IsTB_STARTNull() ? DateTime.MinValue : oneRow.TB_START);
        //            project2007Task.BaselineFinishDateTime = (oneRow.IsTB_FINISHNull() ? DateTime.MinValue : oneRow.TB_FINISH);
        //            project2007Task.BaselineWork = (oneRow.IsTB_WORKNull() ? 0.0 : oneRow.TB_WORK) / 60000.0;
        //            project2007Task.ActualStartDateTime = (oneRow.IsTASK_ACT_STARTNull() ? DateTime.MinValue : oneRow.TASK_ACT_START);
        //            project2007Task.ActualFinishDateTime = (oneRow.IsTASK_ACT_FINISHNull() ? DateTime.MinValue : oneRow.TASK_ACT_FINISH);
        //            project2007Task.ActualWork = (oneRow.IsTASK_ACT_WORKNull() ? 0.0 : oneRow.TASK_ACT_WORK) / 60000.0;
        //            project2007Task.ActualOvertime = (oneRow.IsTASK_ACT_OVT_WORKNull() ? 0.0 : oneRow.TASK_ACT_OVT_WORK) / 60000.0;
        //            project2007Task.ActualWorkPercentComplete = (double)(oneRow.IsTASK_PCT_WORK_COMPNull() ? 0 : oneRow.TASK_PCT_WORK_COMP);
        //            project2007Task.RemainingWork = (oneRow.IsTASK_REM_WORKNull() ? 0.0 : oneRow.TASK_REM_WORK) / 60000.0;
        //            project2007Task.IsSummaryTask = (!oneRow.IsTASK_IS_SUMMARYNull() && oneRow.TASK_IS_SUMMARY);
        //            project2007Task.ParentID = (oneRow.IsTASK_PARENT_UIDNull() ? Guid.Empty : oneRow.TASK_PARENT_UID);
        //            project2007Task.TaskOutlineLevel = (oneRow.IsTASK_OUTLINE_LEVELNull() ? -1 : oneRow.TASK_OUTLINE_LEVEL);
        //            project2007Task.TaskOutlineNumber = (oneRow.IsTASK_OUTLINE_NUMNull() ? "" : oneRow.TASK_OUTLINE_NUM);
        //            project2007Task.TaskWBS = (oneRow.IsTASK_WBSNull() ? "" : oneRow.TASK_WBS);
        //            project2007Task.PercentEffortVariance = Conversions.ToDouble(cls_DB_ProjectSchedule.RemovePercent(Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400321"), oneRow))));
        //            project2007Task.PercentScheduleVariance = Conversions.ToDouble(cls_DB_ProjectSchedule.RemovePercent(Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400320"), oneRow))));
        //            project2007Task.LOC_New_Estimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002bb"), oneRow));
        //            project2007Task.LOC_New_Actual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002be"), oneRow));
        //            project2007Task.LOC_Reuse_Estimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c2"), oneRow));
        //            project2007Task.LOC_Reuse_Actual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002bf"), oneRow));
        //            project2007Task.LOC_Comment = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c7"), oneRow));
        //            project2007Task.TestCase_Estimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c4"), oneRow));
        //            project2007Task.TestCase_Actual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c0"), oneRow));
        //            project2007Task.Defect_SelfTest = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c1"), oneRow));
        //            project2007Task.QnA_SendToCus = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002bc"), oneRow));
        //            project2007Task.QnA_InAccurate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002bd"), oneRow));
        //            project2007Task.NumberOfPageEstimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c8"), oneRow));
        //            project2007Task.NumberOfPageActual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002c9"), oneRow));
        //            int num = 0;
        //            int num2 = 0;
        //            int num3 = 0;
        //            int num4 = 0;
        //            int num5 = 0;
        //            int num6 = 0;
        //            int num7 = 0;
        //            int num8 = 0;
        //            int num9 = 0;
        //            int num10 = 0;
        //            int num11 = 0;
        //            int num12 = 0;
        //            foreach (ProjectDataSet.AssignmentRow assn in array)
        //            {
        //                num = Conversions.ToInteger(Operators.AddObject(num, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("\t000039b7-8bbe-4ceb-82c4-fa8c0f408006"), assn)));
        //                num2 = Conversions.ToInteger(Operators.AddObject(num2, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408009"), assn)));
        //                num3 = Conversions.ToInteger(Operators.AddObject(num3, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800d"), assn)));
        //                num4 = Conversions.ToInteger(Operators.AddObject(num4, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800a"), assn)));
        //                num5 = Conversions.ToInteger(Operators.AddObject(num5, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408012"), assn)));
        //                num6 = Conversions.ToInteger(Operators.AddObject(num6, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800f"), assn)));
        //                num7 = Conversions.ToInteger(Operators.AddObject(num7, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800b"), assn)));
        //                num8 = Conversions.ToInteger(Operators.AddObject(num8, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800c"), assn)));
        //                num9 = Conversions.ToInteger(Operators.AddObject(num9, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408007"), assn)));
        //                num10 = Conversions.ToInteger(Operators.AddObject(num10, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408008"), assn)));
        //                num11 = Conversions.ToInteger(Operators.AddObject(num11, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408013"), assn)));
        //                num12 = Conversions.ToInteger(Operators.AddObject(num12, cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408014"), assn)));
        //            }
        //            bool flag2 = num != 0;
        //            if (flag2)
        //            {
        //                project2007Task.LOC_New_Estimate = num;
        //            }
        //            bool flag3 = num2 != 0;
        //            if (flag3)
        //            {
        //                project2007Task.LOC_New_Actual = num2;
        //            }
        //            bool flag4 = num3 != 0;
        //            if (flag4)
        //            {
        //                project2007Task.LOC_Reuse_Estimate = num3;
        //            }
        //            bool flag5 = num4 != 0;
        //            if (flag5)
        //            {
        //                project2007Task.LOC_Reuse_Actual = num4;
        //            }
        //            bool flag6 = num5 != 0;
        //            if (flag6)
        //            {
        //                project2007Task.LOC_Comment = num5;
        //            }
        //            bool flag7 = num6 != 0;
        //            if (flag7)
        //            {
        //                project2007Task.TestCase_Estimate = num6;
        //            }
        //            bool flag8 = num7 != 0;
        //            if (flag8)
        //            {
        //                project2007Task.TestCase_Actual = num7;
        //            }
        //            bool flag9 = num8 != 0;
        //            if (flag9)
        //            {
        //                project2007Task.Defect_SelfTest = num8;
        //            }
        //            bool flag10 = num9 != 0;
        //            if (flag10)
        //            {
        //                project2007Task.QnA_SendToCus = num9;
        //            }
        //            bool flag11 = num10 != 0;
        //            if (flag11)
        //            {
        //                project2007Task.QnA_InAccurate = num10;
        //            }
        //            bool flag12 = num11 != 0;
        //            if (flag12)
        //            {
        //                project2007Task.NumberOfPageEstimate = num11;
        //            }
        //            bool flag13 = num12 != 0;
        //            if (flag13)
        //            {
        //                project2007Task.NumberOfPageActual = num12;
        //            }
        //            object objectValue = RuntimeHelpers.GetObjectValue(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400322"), oneRow));
        //            bool flag14 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) || Operators.ConditionalCompareObjectEqual(objectValue, "", false);
        //            checked
        //            {
        //                if (flag14)
        //                {
        //                    project2007Task.Phase = TaskPhase.Others;
        //                }
        //                else
        //                {
        //                    project2007Task.Phase = TaskPhase.Others;
        //                    int num13 = cls_CM_Function.TaskPhaseShortName.Length - 1;
        //                    for (int k = 0; k <= num13; k++)
        //                    {
        //                        bool flag15 = Operators.ConditionalCompareObjectEqual(cls_CM_Function.TaskPhaseShortName[k], objectValue, false);
        //                        if (flag15)
        //                        {
        //                            project2007Task.Phase = (TaskPhase)k;
        //                            break;
        //                        }
        //                    }
        //                }
        //                return project2007Task;
        //            }
        //        }

        //        // Token: 0x06000DDA RID: 3546 RVA: 0x00054E8C File Offset: 0x0005308C
        //        public Project2007Assignment ConvertAssignementRowToProjectAssignment(ProjectDataSet.AssignmentRow oneRow, ProjectDataSet onePrj, CustomFieldDataSet customFieldDS, LookupTableDataSet lookupTableDS, ResourceDataSet resourceDS)
        //        {
        //            return new Project2007Assignment
        //            {
        //                Task = default(Project2007Task),
        //                Task = this.ConvertTaskRowToProjectTask(onePrj.Task.FindByTASK_UIDPROJ_UID(oneRow.TASK_UID, oneRow.PROJ_UID), onePrj, customFieldDS, lookupTableDS),
        //                ResourceNTAccount = cls_CM_ProjectSchedule2007.GetNTAccount(oneRow.RES_UID, resourceDS),
        //                Work = (oneRow.IsASSN_WORKNull() ? 0.0 : oneRow.ASSN_WORK) / 60000.0,
        //                BaselineWork = (oneRow.IsAB_WORKNull() ? 0.0 : oneRow.AB_WORK) / 60000.0,
        //                ActualWork = (oneRow.IsASSN_ACT_WORKNull() ? 0.0 : oneRow.ASSN_ACT_WORK) / 60000.0,
        //                ActualOvertime = (oneRow.IsASSN_ACT_OVT_WORKNull() ? 0.0 : oneRow.ASSN_ACT_OVT_WORK) / 60000.0,
        //                ActualWorkPercentComplete = (double)(oneRow.IsASSN_PCT_WORK_COMPLETENull() ? 0 : oneRow.ASSN_PCT_WORK_COMPLETE),
        //                RemainingWork = (oneRow.IsASSN_REM_WORKNull() ? 0.0 : oneRow.ASSN_REM_WORK) / 60000.0,
        //                PercentEffortVariance = Conversions.ToDouble(cls_DB_ProjectSchedule.RemovePercent(Conversions.ToString(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408019"), oneRow)))),
        //                PercentScheduleVariance = Conversions.ToDouble(cls_DB_ProjectSchedule.RemovePercent(Conversions.ToString(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408018"), oneRow)))),
        //                LOC_New_Estimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("\t000039b7-8bbe-4ceb-82c4-fa8c0f408006"), oneRow)),
        //                LOC_New_Actual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408009"), oneRow)),
        //                LOC_Reuse_Estimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800d"), oneRow)),
        //                LOC_Reuse_Actual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800a"), oneRow)),
        //                LOC_Comment = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408012"), oneRow)),
        //                TestCase_Estimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800f"), oneRow)),
        //                TestCase_Actual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800b"), oneRow)),
        //                Defect_SelfTest = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f40800c"), oneRow)),
        //                QnA_SendToCus = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408007"), oneRow)),
        //                QnA_InAccurate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408008"), oneRow)),
        //                NumberOfPageEstimate = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408013"), oneRow)),
        //                NumberOfPageActual = Conversions.ToInteger(cls_CM_ProjectSchedule2007.GetAssignmentCustomFieldValue(onePrj, customFieldDS, lookupTableDS, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0f408014"), oneRow)),
        //                BaselineStartDateTime = (oneRow.IsAB_STARTNull() ? DateTime.MinValue : oneRow.AB_START),
        //                BaselineFinishDateTime = (oneRow.IsAB_FINISHNull() ? DateTime.MinValue : oneRow.AB_FINISH),
        //                ActualStartDateTime = (oneRow.IsASSN_ACT_STARTNull() ? DateTime.MinValue : oneRow.ASSN_ACT_START),
        //                ActualFinishDateTime = (oneRow.IsASSN_ACT_FINISHNull() ? DateTime.MinValue : oneRow.ASSN_ACT_FINISH),
        //                StartDateTime = (oneRow.IsASSN_START_DATENull() ? DateTime.MinValue : oneRow.ASSN_START_DATE),
        //                FinishDateTime = (oneRow.IsASSN_FINISH_DATENull() ? DateTime.MinValue : oneRow.ASSN_FINISH_DATE)
        //            };
        //        }

        //        // Token: 0x06000DDB RID: 3547 RVA: 0x00055258 File Offset: 0x00053458
        //        public Project2007Task GetTaskInfo(Guid TaskUniqueID, DataStoreEnum whereToGet)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Project project = new Project();
        //            ArrayList arrayList = new ArrayList();
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            project.Credentials = cls_CM_Function.GetCredentials(false);
        //            CustomFields customFields = new CustomFields();
        //            CustomFieldDataSet customFieldDS = new CustomFieldDataSet();
        //            customFields.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/CustomFields.asmx";
        //            customFields.Credentials = cls_CM_Function.GetCredentials(false);
        //            customFieldDS = customFields.ReadCustomFields("", false);
        //            LookupTable lookupTable = new LookupTable();
        //            LookupTableDataSet lookupTableDS = new LookupTableDataSet();
        //            lookupTable.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LookupTable.asmx";
        //            lookupTable.Credentials = cls_CM_Function.GetCredentials(false);
        //            lookupTableDS = lookupTable.ReadLookupTables("", false, 0);
        //            ProjectDataSet projectDataSet = project.ReadProjectEntities(this.ID, 66, whereToGet);
        //            DataRow dataRow = projectDataSet.Task.FindByTASK_UIDPROJ_UID(TaskUniqueID, this.ID);
        //            return this.ConvertTaskRowToProjectTask((ProjectDataSet.TaskRow)dataRow, projectDataSet, customFieldDS, lookupTableDS);
        //        }

        //        // Token: 0x06000DDC RID: 3548 RVA: 0x0005533C File Offset: 0x0005353C
        //        public List<Project2007Task> GetDeliveryList(DateTime StartDate, DateTime EndDate)
        //        {
        //            List<Project2007Task> taskList = this.GetTaskList(-1, DataStoreEnum.PublishedStore, false);
        //            int i = 0;
        //            checked
        //            {
        //                while (i <= taskList.Count - 1)
        //                {
        //                    Project2007Task project2007Task = taskList[i];
        //                    bool flag = DateTime.Compare(project2007Task.ScheduleDeliveryDate.Date, StartDate) < 0;
        //                    project2007Task = taskList[i];
        //                    bool flag2 = flag | DateTime.Compare(project2007Task.ScheduleDeliveryDate.Date, EndDate) > 0;
        //                    if (flag2)
        //                    {
        //                        taskList.RemoveAt(i);
        //                    }
        //                    else
        //                    {
        //                        i++;
        //                    }
        //                }
        //                return taskList;
        //            }
        //        }

        //        // Token: 0x06000DDD RID: 3549 RVA: 0x000553C4 File Offset: 0x000535C4
        //        public Project2007Task GetParentTask(Guid TaskUniqueID, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Project project = new Project();
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            project.Credentials = cls_CM_Function.GetCredentials(false);
        //            CustomFields customFields = new CustomFields();
        //            CustomFieldDataSet customFieldDS = new CustomFieldDataSet();
        //            customFields.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/CustomFields.asmx";
        //            customFields.Credentials = cls_CM_Function.GetCredentials(false);
        //            customFieldDS = customFields.ReadCustomFields("", false);
        //            LookupTable lookupTable = new LookupTable();
        //            LookupTableDataSet lookupTableDS = new LookupTableDataSet();
        //            lookupTable.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LookupTable.asmx";
        //            lookupTable.Credentials = cls_CM_Function.GetCredentials(false);
        //            lookupTableDS = lookupTable.ReadLookupTables("", false, 0);
        //            ProjectDataSet projectDataSet = project.ReadProjectEntities(this.ID, 66, whereToGet);
        //            ProjectDataSet.TaskRow taskRow = projectDataSet.Task.FindByTASK_UIDPROJ_UID(TaskUniqueID, this.ID);
        //            DataRow dataRow = projectDataSet.Task.FindByTASK_UIDPROJ_UID(taskRow.TASK_PARENT_UID, this.ID);
        //            return this.ConvertTaskRowToProjectTask((ProjectDataSet.TaskRow)dataRow, projectDataSet, customFieldDS, lookupTableDS);
        //        }

        //        // Token: 0x06000DDE RID: 3550 RVA: 0x000554BC File Offset: 0x000536BC
        //        public List<cls_CM_ResourceOnServer2007> GetSummaryTimephasedData(DateTime StartDate, DateTime EndDate, cls_CM_ResourceOnServer2007 Resource = null, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            List<cls_CM_ResourceOnServer2007> list = new List<cls_CM_ResourceOnServer2007>();
        //            Statusing statusing = new Statusing();
        //            Project project = new Project();
        //            statusing.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Statusing.asmx";
        //            statusing.Credentials = cls_CM_Function.GetCredentials(false);
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            project.Credentials = cls_CM_Function.GetCredentials(false);
        //            ProjectDataSet projectDataSet = project.ReadProjectEntities(this.ID, 74, whereToGet);
        //            cls_DB_ProjectSchedule2007 cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule2007();
        //            try
        //            {
        //                foreach (object obj in projectDataSet.Assignment)
        //                {
        //                    ProjectDataSet.AssignmentRow assignmentRow = (ProjectDataSet.AssignmentRow)obj;
        //                    StatusingTimephasedActualsDataSet statusingTimephasedActualsDataSet = statusing.ReadStatusTimephasedData(this.ID, assignmentRow.ASSN_UID, assignmentRow.ASSN_START_DATE, assignmentRow.ASSN_FINISH_DATE, 60L);
        //                    cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer = new cls_CM_ResourceOnServer2007();
        //                    bool flag = false;
        //                    try
        //                    {
        //                        foreach (cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer2 in list)
        //                        {
        //                            bool flag2 = cls_CM_ResourceOnServer2.ID == assignmentRow.RES_UID;
        //                            if (flag2)
        //                            {
        //                                cls_CM_ResourceOnServer = cls_CM_ResourceOnServer2;
        //                                flag = true;
        //                                break;
        //                            }
        //                        }
        //                    }
        //                    finally
        //                    {
        //                        List<cls_CM_ResourceOnServer2007>.Enumerator enumerator2;
        //                        ((IDisposable)enumerator2).Dispose();
        //                    }
        //                    try
        //                    {
        //                        foreach (object obj2 in statusingTimephasedActualsDataSet.AssignmentTimephasedData)
        //                        {
        //                            StatusingTimephasedActualsDataSet.AssignmentTimephasedDataRow assignmentTimephasedDataRow = (StatusingTimephasedActualsDataSet.AssignmentTimephasedDataRow)obj2;
        //                            cls_CM_ResourceOnServer2007 cls_CM_ResourceOnServer3;
        //                            (cls_CM_ResourceOnServer3 = cls_CM_ResourceOnServer).ScheduleEffort = decimal.Add(cls_CM_ResourceOnServer3.ScheduleEffort, assignmentTimephasedDataRow.AssignmentWork);
        //                            (cls_CM_ResourceOnServer3 = cls_CM_ResourceOnServer).ActualEffort = decimal.Add(cls_CM_ResourceOnServer3.ActualEffort, assignmentTimephasedDataRow.AssignmentActualWork);
        //                            (cls_CM_ResourceOnServer3 = cls_CM_ResourceOnServer).OvertimeEffort = decimal.Add(cls_CM_ResourceOnServer3.OvertimeEffort, assignmentTimephasedDataRow.AssignmentActualOvertimeWork);
        //                        }
        //                    }
        //                    finally
        //                    {
        //                        IEnumerator enumerator3;
        //                        if (enumerator3 is IDisposable)
        //                        {
        //                            (enumerator3 as IDisposable).Dispose();
        //                        }
        //                    }
        //                    bool flag3 = !flag;
        //                    if (flag3)
        //                    {
        //                        cls_CM_ResourceOnServer.ID = assignmentRow.RES_UID;
        //                        cls_CM_ResourceOnServer.Name = assignmentRow.RES_NAME;
        //                        cls_CM_ResourceOnServer.Account = cls_CM_ProjectSchedule2007.GetNTAccount(assignmentRow.RES_UID);
        //                        cls_CM_ResourceOnServer.BaselinedEffort = cls_DB_ProjectSchedule.GetSumBaselineWork(this, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
        //                        list.Add(cls_CM_ResourceOnServer);
        //                    }
        //                }
        //            }
        //            finally
        //            {
        //                IEnumerator enumerator;
        //                if (enumerator is IDisposable)
        //                {
        //                    (enumerator as IDisposable).Dispose();
        //                }
        //            }
        //            return list;
        //        }

        //        // Token: 0x06000DDF RID: 3551 RVA: 0x00055754 File Offset: 0x00053954
        //        public static List<Task2007Info> GetAllProjectTimephasedData(DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore, cls_CM_ResourceOnServer2007 Resource = null)
        //        {
        //            return cls_CM_ProjectSchedule2007.GetTaskSummaryTimephasedData(null, StartDate, EndDate, whereToGet, Resource);
        //        }

        //        // Token: 0x06000DE0 RID: 3552 RVA: 0x00055770 File Offset: 0x00053970
        //        private static string GetNTAccount(Guid resGuid)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Resource resource = new Resource();
        //            ResourceDataSet resourceDataSet = new ResourceDataSet();
        //            resource.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx";
        //            resource.Credentials = cls_CM_Function.GetCredentials(true);
        //            Filter filter = new Filter();
        //            filter.FilterTableName = resourceDataSet.Resources.TableName;
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.WRES_ACCOUNTColumn.ColumnName, Filter.SortOrderTypeEnum.Asc));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_UIDColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_NAMEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            Filter.LogicalOperator criteria = new Filter.LogicalOperator(Filter.LogicalOperationType.Or, new List<Filter.IOperator>
        //            {
        //                new Filter.FieldOperator(Filter.FieldOperationType.Equal, resourceDataSet.Resources.RES_UIDColumn.ColumnName, new object[]
        //                {
        //                    resGuid.ToString()
        //                })
        //            }.ToArray());
        //            filter.Criteria = criteria;
        //            resourceDataSet = resource.ReadResources(filter.GetXml(), false);
        //            bool flag = resourceDataSet.Resources.Count > 0;
        //            string result;
        //            if (flag)
        //            {
        //                result = resourceDataSet.Resources[0].WRES_ACCOUNT;
        //            }
        //            else
        //            {
        //                result = "";
        //            }
        //            return result;
        //        }

        //        // Token: 0x06000DE1 RID: 3553 RVA: 0x000558DC File Offset: 0x00053ADC
        //        private static string GetNTAccount(Guid resGuid, ResourceDataSet resourceDS)
        //        {
        //            return resourceDS.Resources.FindByRES_UID(resGuid).WRES_ACCOUNT;
        //        }

        //        // Token: 0x06000DE2 RID: 3554 RVA: 0x00055900 File Offset: 0x00053B00
        //        private static string GetResourceName(Guid resGuid)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Resource resource = new Resource();
        //            ResourceDataSet resourceDataSet = new ResourceDataSet();
        //            Filter filter = new Filter();
        //            resource.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx";
        //            resource.Credentials = cls_CM_Function.GetCredentials(false);
        //            filter.FilterTableName = resourceDataSet.Resources.TableName;
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.WRES_ACCOUNTColumn.ColumnName, Filter.SortOrderTypeEnum.Asc));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_UIDColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_NAMEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            Filter.LogicalOperator criteria = new Filter.LogicalOperator(Filter.LogicalOperationType.Or, new List<Filter.IOperator>
        //            {
        //                new Filter.FieldOperator(Filter.FieldOperationType.Equal, resourceDataSet.Resources.RES_UIDColumn.ColumnName, new object[]
        //                {
        //                    resGuid.ToString()
        //                })
        //            }.ToArray());
        //            filter.Criteria = criteria;
        //            resourceDataSet = resource.ReadResources(filter.GetXml(), false);
        //            return resourceDataSet.Resources[0].RES_NAME;
        //        }

        //        // Token: 0x06000DE3 RID: 3555 RVA: 0x00055A50 File Offset: 0x00053C50
        //        public static int GetResourceGUID(string resAccount)
        //        {
        //            cls_CM_Function.OverrideCertificateValidation();
        //            Resource resource = new Resource();
        //            ResourceDataSet resourceDataSet = new ResourceDataSet();
        //            Filter filter = new Filter();
        //            resource.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx";
        //            resource.Credentials = cls_CM_Function.GetCredentials(false);
        //            filter.FilterTableName = resourceDataSet.Resources.TableName;
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.WRES_ACCOUNTColumn.ColumnName, Filter.SortOrderTypeEnum.Asc));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_IDColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            filter.Fields.Add(new Filter.Field(resourceDataSet.Resources.TableName, resourceDataSet.Resources.RES_NAMEColumn.ColumnName, Filter.SortOrderTypeEnum.None));
        //            Filter.LogicalOperator criteria = new Filter.LogicalOperator(Filter.LogicalOperationType.Or, new List<Filter.IOperator>
        //            {
        //                new Filter.FieldOperator(Filter.FieldOperationType.Equal, resourceDataSet.Resources.WRES_ACCOUNTColumn.ColumnName, new object[]
        //                {
        //                    resAccount
        //                })
        //            }.ToArray());
        //            filter.Criteria = criteria;
        //            resourceDataSet = resource.ReadResources(filter.GetXml(), false);
        //            bool flag = resourceDataSet.Resources.Count > 0;
        //            int result;
        //            if (flag)
        //            {
        //                result = resourceDataSet.Resources[0].RES_ID;
        //            }
        //            else
        //            {
        //                result = 0;
        //            }
        //            return result;
        //        }

        // Token: 0x06000DE4 RID: 3556 RVA: 0x00055BAC File Offset: 0x00053DAC
        public static void GetResourceInfo(Guid resGuid, ref string resName, ref string resNTAccount, ResourceDataSet resourceDS)
        {
            ResourceDataSet.ResourcesRow resourcesRow = resourceDS.Resources.FindByRES_UID(resGuid);
            bool flag = resourcesRow != null;
            if (flag)
            {
                resName = resourcesRow.RES_NAME;
                resNTAccount = resourcesRow.WRES_ACCOUNT;
            }
            else
            {
                resName = "";
                resNTAccount = "";
            }
        }

        //        // Token: 0x06000DE5 RID: 3557 RVA: 0x00055BF4 File Offset: 0x00053DF4
        //        public static List<Task2007Info> GetTaskSummaryTimephasedData(cls_CM_ProjectSchedule2007 schedule, DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore, cls_CM_ResourceOnServer2007 Resource = null)
        //        {
        //            List<Task2007Info> list = new List<Task2007Info>();
        //            Project project = new Project();
        //            cls_CM_Function.OverrideCertificateValidation();
        //            StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0);
        //            EndDate = new DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 23, 59, 59);
        //            project.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/psi/Project.asmx";
        //            project.Credentials = cls_CM_Function.GetCredentials(true);
        //            CustomFields customFields = new CustomFields();
        //            CustomFieldDataSet customFieldDS = new CustomFieldDataSet();
        //            customFields.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/CustomFields.asmx";
        //            customFields.Credentials = cls_CM_Function.GetCredentials(false);
        //            customFieldDS = customFields.ReadCustomFields("", false);
        //            LookupTable lookupTable = new LookupTable();
        //            LookupTableDataSet lookupTableDataSet = new LookupTableDataSet();
        //            lookupTable.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LookupTable.asmx";
        //            lookupTable.Credentials = cls_CM_Function.GetCredentials(false);
        //            lookupTableDataSet = lookupTable.ReadLookupTables("", false, 0);
        //            ResourceDataSet resourceDS = new ResourceDataSet();
        //            resourceDS = new Resource
        //            {
        //                Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Resource.asmx",
        //                Credentials = cls_CM_Function.GetCredentials(true)
        //            }.ReadResources("", false);
        //            ProjectDataSet projectDataSet = project.ReadProjectEntities(schedule.ID, 74, whereToGet);
        //            string fixbugWBS;
        //            string devWBS;
        //            string manWBS;
        //            cls_CM_ProjectSchedule2007.GetWBSTaskClass(projectDataSet, ref fixbugWBS, ref devWBS, ref manWBS);
        //            List<string> subPrjWBS;
        //            List<string> subPrjName;
        //            cls_CM_ProjectSchedule2007.GetSubPrjListWBS(projectDataSet, ref subPrjWBS, ref subPrjName, lookupTableDataSet);
        //            cls_DB_ProjectSchedule2007 cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule2007();
        //            try
        //            {
        //                foreach (object obj in projectDataSet.Assignment)
        //                {
        //                    ProjectDataSet.AssignmentRow assignmentRow = (ProjectDataSet.AssignmentRow)obj;
        //                    Task2007Info task2007Info = default(Task2007Info);
        //                    ProjectDataSet.TaskRow taskRow = projectDataSet.Task.FindByTASK_UIDPROJ_UID(assignmentRow.TASK_UID, assignmentRow.PROJ_UID);
        //                    task2007Info.ID = assignmentRow.TASK_UID;
        //                    task2007Info.Name = taskRow.TASK_NAME;
        //                    task2007Info.ModuleName = Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b40031f"), taskRow));
        //                    task2007Info.ProjectID = assignmentRow.PROJ_UID;
        //                    bool flag = taskRow.IsTASK_WBSNull();
        //                    if (flag)
        //                    {
        //                        task2007Info.WBS = "";
        //                    }
        //                    else
        //                    {
        //                        task2007Info.WBS = taskRow.TASK_WBS;
        //                    }
        //                    task2007Info.TaskPart = cls_CM_ProjectSchedule2007.GetTaskPart(task2007Info.WBS, fixbugWBS, devWBS, manWBS);
        //                    task2007Info.SubPrjName = cls_CM_ProjectSchedule2007.GetSubPrjOfTask(task2007Info.WBS, subPrjWBS, subPrjName);
        //                    cls_CM_ProjectSchedule2007.GetResourceInfo(assignmentRow.RES_UID, ref task2007Info.ResourceName, ref task2007Info.ResourceNTAccount, resourceDS);
        //                    task2007Info.BaselinedEffort = cls_DB_ProjectSchedule.GetSumBaselineWork(schedule, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
        //                    task2007Info.OvertimeEffort = cls_DB_ProjectSchedule.GetSumOvertimeWork(schedule, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
        //                    task2007Info.ActualEffort = cls_DB_ProjectSchedule.GetSumActualWork(schedule, StartDate, EndDate, assignmentRow.ASSN_UID, Guid.Empty);
        //                    string text = Conversions.ToString(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400322"), taskRow));
        //                    bool flag2 = Conversions.ToBoolean(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b400293"), taskRow));
        //                    bool flag3 = !(-(flag2 > false));
        //                    if (flag3)
        //                    {
        //                        task2007Info.Phase = TaskPhase.Others;
        //                    }
        //                    else
        //                    {
        //                        bool flag4 = -(flag2 > false);
        //                        if (flag4)
        //                        {
        //                            task2007Info.Phase = TaskPhase.Training;
        //                        }
        //                    }
        //                    bool flag5 = Operators.CompareString(text, "", false) == 0;
        //                    checked
        //                    {
        //                        if (flag5)
        //                        {
        //                            task2007Info.Phase = TaskPhase.Others;
        //                        }
        //                        else
        //                        {
        //                            task2007Info.Phase = TaskPhase.Others;
        //                            int num = cls_CM_Function.TaskPhaseShortName.Length - 1;
        //                            for (int i = 0; i <= num; i++)
        //                            {
        //                                bool flag6 = Operators.CompareString(cls_CM_Function.TaskPhaseShortName[i], text, false) == 0;
        //                                if (flag6)
        //                                {
        //                                    task2007Info.Phase = (TaskPhase)i;
        //                                    break;
        //                                }
        //                            }
        //                        }
        //                        decimal num2 = Conversions.ToDecimal(cls_CM_ProjectSchedule2007.GetTaskCustomFieldValue(projectDataSet, customFieldDS, lookupTableDataSet, new Guid("000039b7-8bbe-4ceb-82c4-fa8c0b4002ca"), taskRow));
        //                        bool flag7 = decimal.Compare(num2, 0m) == 0;
        //                        if (flag7)
        //                        {
        //                            task2007Info.Difficulty = 1m;
        //                        }
        //                        else
        //                        {
        //                            task2007Info.Difficulty = num2;
        //                        }
        //                        bool flag8 = task2007Info.Phase == TaskPhase.DeductedEffort;
        //                        if (flag8)
        //                        {
        //                            task2007Info.BaselinedEffort = decimal.Negate(task2007Info.BaselinedEffort);
        //                        }
        //                        list.Add(task2007Info);
        //                    }
        //                }
        //            }
        //            finally
        //            {
        //                IEnumerator enumerator;
        //                if (enumerator is IDisposable)
        //                {
        //                    (enumerator as IDisposable).Dispose();
        //                }
        //            }
        //            return list;
        //        }

        //        // Token: 0x06000DE6 RID: 3558 RVA: 0x00056050 File Offset: 0x00054250
        //        public List<Task2007Info> GetTaskDetailTimephasedData(DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore, cls_CM_ResourceOnServer2007 Resource = null)
        //        {
        //            cls_DB_ProjectSchedule2007 cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule2007();
        //            bool flag = this.ID != Guid.Empty;
        //            List<Task2007Info> taskDetailTimephasedData;
        //            if (flag)
        //            {
        //                taskDetailTimephasedData = cls_DB_ProjectSchedule.GetTaskDetailTimephasedData(StartDate, EndDate, this, Resource);
        //            }
        //            else
        //            {
        //                taskDetailTimephasedData = cls_DB_ProjectSchedule.GetTaskDetailTimephasedData(StartDate, EndDate, null, Resource);
        //            }
        //            return taskDetailTimephasedData;
        //        }

        //        // Token: 0x06000DE7 RID: 3559 RVA: 0x00056098 File Offset: 0x00054298
        //        public void GetTaskSummaryTimephasedData_ClassifyProjectAndNonProject(ref ArrayList ProjectTaskList, ref ArrayList NonProjectTaskList, DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore, cls_CM_ResourceOnServer2007 Resource = null)
        //        {
        //            List<Task2007Info> taskSummaryTimephasedData = cls_CM_ProjectSchedule2007.GetTaskSummaryTimephasedData(this, StartDate, EndDate, whereToGet, Resource);
        //            ProjectTaskList = new ArrayList();
        //            NonProjectTaskList = new ArrayList();
        //            checked
        //            {
        //                int num = taskSummaryTimephasedData.Count - 1;
        //                for (int i = 0; i <= num; i++)
        //                {
        //                    bool flag = taskSummaryTimephasedData[i].Phase == TaskPhase.Training;
        //                    if (flag)
        //                    {
        //                        NonProjectTaskList.Add(taskSummaryTimephasedData[i]);
        //                    }
        //                    else
        //                    {
        //                        ProjectTaskList.Add(taskSummaryTimephasedData[i]);
        //                    }
        //                }
        //            }
        //        }

        //        // Token: 0x06000DE8 RID: 3560 RVA: 0x00056118 File Offset: 0x00054318
        //        public void GetTaskDetailTimephasedData_ClassifyProjectAndNonProject(ref ArrayList ProjectTaskList, ref ArrayList NonProjectTaskList, DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore)
        //        {
        //            List<Task2007Info> taskDetailTimephasedData = this.GetTaskDetailTimephasedData(StartDate, EndDate, whereToGet, null);
        //            ProjectTaskList = new ArrayList();
        //            NonProjectTaskList = new ArrayList();
        //            checked
        //            {
        //                int num = taskDetailTimephasedData.Count - 1;
        //                for (int i = 0; i <= num; i++)
        //                {
        //                    bool flag = taskDetailTimephasedData[i].Phase == TaskPhase.Training;
        //                    if (flag)
        //                    {
        //                        NonProjectTaskList.Add(taskDetailTimephasedData[i]);
        //                    }
        //                    else
        //                    {
        //                        ProjectTaskList.Add(taskDetailTimephasedData[i]);
        //                    }
        //                }
        //            }
        //        }

        //        // Token: 0x06000DE9 RID: 3561 RVA: 0x00056198 File Offset: 0x00054398
        //        public List<cls_CM_ProjectSchedule2007> GetDirectScheduleOfUser(string userID, bool OnlyForManaging = false)
        //        {
        //            List<cls_CM_ProjectSchedule2007> list = new List<cls_CM_ProjectSchedule2007>();
        //            cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule = new cls_CM_ProjectSchedule2007();
        //            List<cls_CM_ProjectSchedule2007> list2 = new List<cls_CM_ProjectSchedule2007>();
        //            list = cls_CM_ProjectSchedule.GetProjectScheduleList(Guid.Empty, "", null, true, DataStoreEnum.PublishedStore);
        //            bool flag = list == null || list.Count == 0;
        //            checked
        //            {
        //                List<cls_CM_ProjectSchedule2007> result;
        //                if (flag)
        //                {
        //                    result = list2;
        //                }
        //                else
        //                {
        //                    cls_CM_Project cls_CM_Project = new cls_CM_Project();
        //                    List<cls_CM_Project> listProject = cls_CM_Project.fncG_PJ_ListActiveProject(userID, true, true, true, true, true, false);
        //                    bool flag2 = list != null;
        //                    if (flag2)
        //                    {
        //                        int num = list.Count - 1;
        //                        for (int i = 0; i <= num; i++)
        //                        {
        //                            bool readOnlyData = false;
        //                            bool flag3 = Operators.CompareString(list[i].Manager.Account, "FUJINET\\" + mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.UserName, false) == 0 | cls_CM_Function.ScheduleIsViewedByLoginUser(list[i], listProject, ref readOnlyData, OnlyForManaging);
        //                            if (flag3)
        //                            {
        //                                cls_CM_ProjectSchedule2007 cls_CM_ProjectSchedule2 = list[i];
        //                                cls_CM_ProjectSchedule2.ReadOnlyData = readOnlyData;
        //                                list2.Add(cls_CM_ProjectSchedule2);
        //                            }
        //                        }
        //                    }
        //                    result = list2;
        //                }
        //                return result;
        //            }
        //        }

        //        // Token: 0x06000DEA RID: 3562 RVA: 0x000562A0 File Offset: 0x000544A0
        //        public void GetDeletedScheduleInProjectEffort(ref ArrayList idList, ref ArrayList nameList)
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            cls_DB_ProjectSchedule.GetDeletedScheduleInProjectEffort(ref idList, ref nameList);
        //        }

        // Token: 0x06000DEB RID: 3563 RVA: 0x000562C0 File Offset: 0x000544C0
        public static List<string> GetScheduleList(string listScheduleID)
        {
            List<string> list = new List<string>();
            list.AddRange(listScheduleID.Split(new char[]
            {
                        ','
            }));
            int i = 0;
            checked
            {
                while (i < list.Count)
                {
                    Guid guid = default(Guid);
                    bool flag = !Guid.TryParse(list[i], out guid);
                    if (flag)
                    {
                        list[i] = cls_DB_ProjectSchedule.ChangeIDToGUID(list[i]);
                    }
                    bool flag2 = new Guid(list[i]) == cls_CM_ProjectSchedule2007.SCHEDULE_NOT_SET;
                    if (flag2)
                    {
                        list.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                return list;
            }
        }

        //        // Token: 0x06000DEC RID: 3564 RVA: 0x00056368 File Offset: 0x00054568
        //        public bool IsParentOf(Task2007Info parentTask, Task2007Info childTask, ProjectDataSet projectDS)
        //        {
        //            for (; ; )
        //            {
        //                Guid task_PARENT_UID = projectDS.Task.FindByTASK_UIDPROJ_UID(childTask.ID, childTask.ProjectID).TASK_PARENT_UID;
        //                bool flag = task_PARENT_UID == Guid.Empty;
        //                if (flag)
        //                {
        //                    break;
        //                }
        //                bool flag2 = task_PARENT_UID == parentTask.ID;
        //                if (flag2)
        //                {
        //                    goto Block_2;
        //                }
        //            }
        //            return false;
        //        Block_2:
        //            return true;
        //        }

        //        // Token: 0x06000DED RID: 3565 RVA: 0x000563C8 File Offset: 0x000545C8
        //        public void GetChildTaskList(Project2007Task parentTask, ref List<Project2007Task> listChildTask, List<Project2007Task> listTask)
        //        {
        //            List<Project2007Task> list = new List<Project2007Task>();
        //            try
        //            {
        //                foreach (Project2007Task project2007Task in listTask)
        //                {
        //                    bool flag = project2007Task.ParentID == parentTask.UniqueID;
        //                    if (flag)
        //                    {
        //                        list.Add(project2007Task);
        //                    }
        //                }
        //            }
        //            finally
        //            {
        //                List<Project2007Task>.Enumerator enumerator;
        //                ((IDisposable)enumerator).Dispose();
        //            }
        //            listChildTask.AddRange(list);
        //            checked
        //            {
        //                int num = list.Count - 1;
        //                for (int i = 0; i <= num; i++)
        //                {
        //                    this.GetChildTaskList(list[i], ref listChildTask, listTask);
        //                }
        //            }
        //        }

        //        // Token: 0x06000DEE RID: 3566 RVA: 0x00056470 File Offset: 0x00054670
        //        public ArrayList GetProjectStaffEffort(cls_CM_ProjectSchedule2007 schedule, cls_CM_Staff_Abridged staff, string YearMonth = "")
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            return cls_DB_ProjectSchedule.GetProjectStaffEffort(schedule, staff, YearMonth);
        //        }

        //        // Token: 0x06000DEF RID: 3567 RVA: 0x00056494 File Offset: 0x00054694
        //        public ArrayList GetPhaseExchangeList(TaskPhase phase = (TaskPhase)(-1), string phaseShortName = "", object validFromDate = null, object validToDate = null)
        //        {
        //            cls_DB_ProjectSchedule cls_DB_ProjectSchedule = new cls_DB_ProjectSchedule();
        //            return cls_DB_ProjectSchedule.GetPhaseExchangeList(phase, phaseShortName, RuntimeHelpers.GetObjectValue(validFromDate), RuntimeHelpers.GetObjectValue(validToDate));
        //        }

        //        // Token: 0x06000DF0 RID: 3568 RVA: 0x000564C4 File Offset: 0x000546C4
        //        public PhaseExchange GetPhaseExchangeRate(TaskPhase phase, ArrayList listPhaseExchange, string yearMonth)
        //        {
        //            int i = 0;
        //            checked
        //            {
        //                while (i <= listPhaseExchange.Count - 1)
        //                {
        //                    object obj = listPhaseExchange[i];
        //                    PhaseExchange phaseExchange = (obj != null) ? ((PhaseExchange)obj) : default(PhaseExchange);
        //                    bool flag = Operators.CompareString(yearMonth, phaseExchange.ValidFrom.ToString("yyyyMM"), false) < 0 || Operators.CompareString(yearMonth, phaseExchange.ValidTo.ToString("yyyyMM"), false) > 0;
        //                    if (flag)
        //                    {
        //                        listPhaseExchange.RemoveAt(i);
        //                    }
        //                    else
        //                    {
        //                        i++;
        //                    }
        //                }
        //                int num = listPhaseExchange.Count - 1;
        //                for (i = 0; i <= num; i++)
        //                {
        //                    object obj2 = listPhaseExchange[i];
        //                    bool flag2 = ((obj2 != null) ? ((PhaseExchange)obj2) : default(PhaseExchange)).Phase == phase;
        //                    if (flag2)
        //                    {
        //                        object obj3 = listPhaseExchange[i];
        //                        return (obj3 != null) ? ((PhaseExchange)obj3) : default(PhaseExchange);
        //                    }
        //                }
        //                return new PhaseExchange
        //                {
        //                    EffortExchangeRate = 1m,
        //                    BonusEffortRate = 1m,
        //                    Phase = TaskPhase.Coding,
        //                    ShortName = "PG"
        //                };
        //            }
        //        }

        //        // Token: 0x06000DF1 RID: 3569 RVA: 0x000565F8 File Offset: 0x000547F8
        //        public decimal GetPhaseExchangeRate(string phaseShortName, ArrayList listPhaseExchange, string yearMonth)
        //        {
        //            int i = 0;
        //            checked
        //            {
        //                while (i <= listPhaseExchange.Count - 1)
        //                {
        //                    object obj = listPhaseExchange[i];
        //                    PhaseExchange phaseExchange = (obj != null) ? ((PhaseExchange)obj) : default(PhaseExchange);
        //                    bool flag = Operators.CompareString(yearMonth, phaseExchange.ValidFrom.ToString("yyyyMM"), false) < 0 || Operators.CompareString(yearMonth, phaseExchange.ValidTo.ToString("yyyyMM"), false) > 0;
        //                    if (flag)
        //                    {
        //                        listPhaseExchange.RemoveAt(i);
        //                    }
        //                    else
        //                    {
        //                        i++;
        //                    }
        //                }
        //                int num = listPhaseExchange.Count - 1;
        //                for (i = 0; i <= num; i++)
        //                {
        //                    object obj2 = listPhaseExchange[i];
        //                    bool flag2 = Operators.CompareString(((obj2 != null) ? ((PhaseExchange)obj2) : default(PhaseExchange)).ShortName, phaseShortName, false) == 0;
        //                    if (flag2)
        //                    {
        //                        object obj3 = listPhaseExchange[i];
        //                        return ((obj3 != null) ? ((PhaseExchange)obj3) : default(PhaseExchange)).BonusEffortRate;
        //                    }
        //                }
        //                return 1m;
        //            }
        //        }

        /// <summary>
        /// Get Task WBS by ref param  
        /// </summary>
        /// <param name="project">project data</param>
        /// <param name="FixBugTaskWBS">taskClass = FIXCUSDEF</param>
        /// <param name="DevelopmentTaskWBS">taskClass = SD</param>
        /// <param name="ManagementTaskWBS">taskClass = PM</param>
        /// <remarks> "1" : YES ; "-1" : NO</remarks>
        public static void GetWBSTaskClass(ProjectDataSet project, out string FixBugTaskWBS, out string DevelopmentTaskWBS, out string ManagementTaskWBS)
        {
            FixBugTaskWBS = "-1";
            DevelopmentTaskWBS = "-1";
            ManagementTaskWBS = "-1";

            string filterExpression = string.Format("{0} = '{1}' AND {2} = '{3}'",
                                                    project.TaskCustomFields.MD_PROP_UIDColumn.ColumnName,
                                                    "000039b7-8bbe-4ceb-82c4-fa8c0b40031f",
                                                    project.TaskCustomFields.TEXT_VALUEColumn.ColumnName,
                                                    "SD");

            // taskClass = SD
            var array = (ProjectDataSet.TaskCustomFieldsRow[])project.TaskCustomFields.Select(filterExpression);

            if (array != null)
            {
                foreach (ProjectDataSet.TaskCustomFieldsRow taskCustomFieldsRow in array)
                {
                    var array3 = (ProjectDataSet.TaskRow[])project.Task.Select(string.Format("{0} = '{1}' AND {2} = '{3}'",
                                                                                         project.Task.TASK_NAMEColumn.ColumnName,
                                                                                         "Software Development",
                                                                                         project.Task.TASK_UIDColumn.ColumnName,
                                                                                         taskCustomFieldsRow.TASK_UID.ToString()
                                                                                         ));
                    if (array3 != null && array3.Count() == 1)
                    {
                        DevelopmentTaskWBS = array3[0].TASK_WBS;
                        break;
                    }
                }
            }

            // taskClass = PM
            var array4 = (ProjectDataSet.TaskCustomFieldsRow[])project.TaskCustomFields.Select(string.Format("{0} = '{1}' AND {2} = '{3}'",
                                                                                                                project.TaskCustomFields.MD_PROP_UIDColumn.ColumnName,
                                                                                                                "000039b7-8bbe-4ceb-82c4-fa8c0b40031f",
                                                                                                                project.TaskCustomFields.TEXT_VALUEColumn.ColumnName,
                                                                                                                "PM"
                                                                                                                ));
            if (array4 != null)
            {
                foreach (ProjectDataSet.TaskCustomFieldsRow taskCustomFieldsRow2 in array4)
                {
                    var array6 = (ProjectDataSet.TaskRow[])project.Task.Select(string.Format("{0} = '{1}' AND {2} = '{3}'",
                                                                                    project.Task.TASK_NAMEColumn.ColumnName,
                                                                                    "Project Management",
                                                                                    project.Task.TASK_UIDColumn.ColumnName,
                                                                                    taskCustomFieldsRow2.TASK_UID.ToString()
                                                                                    ));
                    if (array6 != null && array6.Count() == 1)
                    {
                        ManagementTaskWBS = array6[0].TASK_WBS;
                        break;
                    }
                }
            }
            // taskClass = FIXCUSDEF
            var array7 = (ProjectDataSet.TaskCustomFieldsRow[])project.TaskCustomFields.Select(string.Format("{0} = '{1}' AND {2} = '{3}'",
                        project.TaskCustomFields.MD_PROP_UIDColumn.ColumnName,
                        "000039b7-8bbe-4ceb-82c4-fa8c0b40031f",
                        project.TaskCustomFields.TEXT_VALUEColumn.ColumnName,
                        "FIXCUSDEF"
                        ));
            if (array7 != null)
            {
                foreach (ProjectDataSet.TaskCustomFieldsRow taskCustomFieldsRow3 in array7)
                {
                    ProjectDataSet.TaskRow[] array9 = (ProjectDataSet.TaskRow[])project.Task.Select(string.Format("{0} = '{1}' AND {2} = '{3}'",
                                project.Task.TASK_NAMEColumn.ColumnName,
                                "Fix customer's defects".Replace("'", "''"),
                                project.Task.TASK_UIDColumn.ColumnName,
                                taskCustomFieldsRow3.TASK_UID.ToString()
                                ));
                    if (array9 != null && array9.Count() == 1)
                    {
                        FixBugTaskWBS = array9[0].TASK_WBS;
                    }
                }
            }
        }

        /// <summary>
        /// GetTaskPart
        /// </summary>
        /// <param name="taskWBS"></param>
        /// <param name="fixbugWBS"></param>
        /// <param name="devWBS"></param>
        /// <param name="manWBS"></param>
        /// <returns></returns>
        public static TaskClass GetTaskPart(string taskWBS, string fixbugWBS, string devWBS, string manWBS)
        {
            TaskClass result = TaskClass.OtherTasks;
            bool flag = taskWBS.StartsWith(fixbugWBS + ".");
            if (flag)
            {
                result = TaskClass.FixBugTask;
            }
            else
            {
                bool flag2 = taskWBS.StartsWith(manWBS + ".");
                if (flag2)
                {
                    result = TaskClass.ManagementTask;
                }
                else
                {
                    bool flag3 = taskWBS.StartsWith(devWBS + ".");
                    if (flag3)
                    {
                        result = TaskClass.DevelopmentTask;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// analyze SubProject data
        /// </summary>
        /// <param name="project"> IN: Project Data</param>
        /// <param name="subPrjWBS">OUT: WBS of SubProject</param>
        /// <param name="subPrjName">OUT: Name of SubProject</param>
        /// <param name="lookuptableDS" type="IN">IN: </param>
        public static void GetSubPrjListWBS(ProjectDataSet project, out List<string> subPrjWBS, out List<string> subPrjName, LookupTableDataSet lookuptableDS)
        {
            subPrjWBS = new List<string>();
            subPrjName = new List<string>();
            // get taskclass field
            var array = (LookupTableDataSet.LookupTablesRow[])lookuptableDS.LookupTables.Select(
                string.Format("{0} = '{1}'", lookuptableDS.LookupTables.LT_NAMEColumn.ColumnName, "TaskClass"));

            var guid = Guid.Empty;
            if (array != null && array.Count() > 0)
            {
                // save guid of taskclass field
                guid = array[0].LT_UID;
            }

            // get SUB PRJ taskClass
            var array2 = (LookupTableDataSet.LookupTableTreesRow[])lookuptableDS.LookupTableTrees.Select(
                string.Format("{0} = '{1}' AND {2} = '{3}'",
                        lookuptableDS.LookupTableTrees.LT_UIDColumn.ColumnName,
                        guid.ToString(),
                        lookuptableDS.LookupTableTrees.LT_VALUE_TEXTColumn.ColumnName,
                        "SUB_PRJ"
                        ));

            if (array2 != null && array2.Count() > 0)
            {
                var array3 = (ProjectDataSet.TaskCustomFieldsRow[])project.TaskCustomFields.Select(
                    string.Format("{0} = '{1}' AND {2} = '{3}'",
                        project.TaskCustomFields.MD_PROP_UIDColumn.ColumnName,
                        "000039b7-8bbe-4ceb-82c4-fa8c0b400322",
                        project.TaskCustomFields.CODE_VALUEColumn.ColumnName,
                        array2[0].LT_STRUCT_UID.ToString()
                        ));
                if (array3 != null)
                {
                    foreach (ProjectDataSet.TaskCustomFieldsRow taskCustomFieldsRow in array3)
                    {
                        ProjectDataSet.TaskRow[] array5 = (ProjectDataSet.TaskRow[])project.Task.Select(
                            string.Format("{0} = '{1}'",
                            project.Task.TASK_UIDColumn.ColumnName,
                            taskCustomFieldsRow.TASK_UID.ToString())
                            );
                        if (array5 != null && array5.Count() == 1)
                        {
                            subPrjWBS.Add(array5[0].TASK_WBS);
                            subPrjName.Add(array5[0].TASK_NAME);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskWBS"></param>
        /// <param name="subPrjWBS"></param>
        /// <param name="subPrjName"></param>
        /// <returns></returns>
        public static string GetSubPrjOfTask(string taskWBS, List<string> subPrjWBS, List<string> subPrjName)
        {
            string result = "";
            checked
            {
                int num = subPrjWBS.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    bool flag = taskWBS.StartsWith(subPrjWBS[i]);
                    if (flag)
                    {
                        result = subPrjName[i];
                        break;
                    }
                }
                return result;
            }
        }

        //        // Token: 0x06000DF6 RID: 3574 RVA: 0x00056D4C File Offset: 0x00054F4C
        //        public static bool AddProjectToSecureCategory(List<string> Proj_UID, string user, string pass)
        //        {
        //            bool result;
        //            try
        //            {
        //                Guid guid = new Guid("8af00505-b67a-463c-8826-d579ef9877a3");
        //                Guid project = PSSecurityObjectType.Project;
        //                bool flag = false;
        //                FujinetWMSDLL.WebSvcSecurity.Security security = new FujinetWMSDLL.WebSvcSecurity.Security();
        //                security.Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/Security.asmx";
        //                NetworkCredential credentials = new NetworkCredential(user, pass, "fujinet");
        //                security.Credentials = credentials;
        //                security.CookieContainer = new CookieContainer();
        //                SecurityCategoriesDataSet securityCategoriesDataSet = security.ReadCategory(guid);
        //                try
        //                {
        //                    foreach (string g in Proj_UID)
        //                    {
        //                        SecurityCategoriesDataSet.SecurityCategoryObjectsRow securityCategoryObjectsRow = securityCategoriesDataSet.SecurityCategoryObjects.FindByWSEC_CAT_UIDWSEC_OBJ_UIDWSEC_OBJ_TYPE_UID(guid, new Guid(g), project);
        //                        bool flag2 = securityCategoryObjectsRow == null;
        //                        if (flag2)
        //                        {
        //                            SecurityCategoriesDataSet.SecurityCategoryObjectsRow securityCategoryObjectsRow2 = securityCategoriesDataSet.SecurityCategoryObjects.NewSecurityCategoryObjectsRow();
        //                            securityCategoryObjectsRow2.WSEC_CAT_UID = guid;
        //                            securityCategoryObjectsRow2.WSEC_OBJ_TYPE_UID = project;
        //                            securityCategoryObjectsRow2.WSEC_OBJ_UID = new Guid(g);
        //                            securityCategoriesDataSet.SecurityCategoryObjects.AddSecurityCategoryObjectsRow(securityCategoryObjectsRow2);
        //                            flag = true;
        //                        }
        //                    }
        //                }
        //                finally
        //                {
        //                    List<string>.Enumerator enumerator;
        //                    ((IDisposable)enumerator).Dispose();
        //                }
        //                bool flag3 = flag;
        //                if (flag3)
        //                {
        //                    security.SetCategories(securityCategoriesDataSet);
        //                }
        //                result = flag;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw;
        //            }
        //            return result;
        //        }

        //        // Token: 0x06000DF7 RID: 3575 RVA: 0x00056EA0 File Offset: 0x000550A0
        //        public static decimal GetBonusRateofEffortRate(decimal effortRate)
        //        {
        //            EffortPhases effortPhases = new EffortPhases();
        //            PRJ_EffortPhases prj_EffortPhases = effortPhases.PRJ_EffortPhases.FirstOrDefault((PRJ_EffortPhases x) => (bool)(x.Factor == (decimal?)effortRate));
        //            bool flag = prj_EffortPhases != null;
        //            decimal result;
        //            if (flag)
        //            {
        //                result = prj_EffortPhases.BonusFactor.Value;
        //            }
        //            else
        //            {
        //                result = 1m;
        //            }
        //            return result;
        //        }

        //        // Token: 0x06000DF8 RID: 3576 RVA: 0x00056F84 File Offset: 0x00055184
        //        public static decimal GetTyGia(DateTime endDate)
        //        {
        //            decimal result = 0m;
        //            int endMonth = endDate.Month;
        //            int endYear = endDate.Year;
        //            FJN_WMSEntities fjn_WMSEntities = new FJN_WMSEntities();
        //            try
        //            {
        //                List<OMM_SpecificData> list = (from x in fjn_WMSEntities.OMM_SpecificData
        //                                               where checked((int)x.EndDate.Substring(4, 2) == endMonth & (int)x.EndDate.Substring(0, 4) == endYear)
        //                                               select x).ToList<OMM_SpecificData>();
        //                bool flag = list != null && list.Any<OMM_SpecificData>();
        //                if (flag)
        //                {
        //                    result = list[0].USDRate.Value;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //            }
        //            return result;
        //        }

        // Token: 0x040008FF RID: 2303
        public const string LOCNewEstimateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002bb";

        // Token: 0x04000900 RID: 2304
        public const string QANumGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002bc";

        // Token: 0x04000901 RID: 2305
        public const string QANGGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002bd";

        // Token: 0x04000902 RID: 2306
        public const string LOCNewActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002be";

        // Token: 0x04000903 RID: 2307
        public const string LOCReuseActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002bf";

        // Token: 0x04000904 RID: 2308
        public const string TestCaseActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c0";

        // Token: 0x04000905 RID: 2309
        public const string DefectGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c1";

        // Token: 0x04000906 RID: 2310
        public const string LOCReuseEstimateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c2";

        // Token: 0x04000907 RID: 2311
        public const string DeliveryInfoGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c3";

        // Token: 0x04000908 RID: 2312
        public const string DeliveryPlanDateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b400261";

        // Token: 0x04000909 RID: 2313
        public const string DeliveryActualDateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b400262";

        // Token: 0x0400090A RID: 2314
        public const string TestcaseMustHaveGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c4";

        // Token: 0x0400090B RID: 2315
        public const string SchVarByDayGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c5";

        // Token: 0x0400090C RID: 2316
        public const string EffVarGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c6";

        // Token: 0x0400090D RID: 2317
        public const string LOCCommentGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c7";

        // Token: 0x0400090E RID: 2318
        public const string DesignPageEstimateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c8";

        // Token: 0x0400090F RID: 2319
        public const string DesignPageActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002c9";

        // Token: 0x04000910 RID: 2320
        public const string TaskDifficultGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002ca";

        // Token: 0x04000911 RID: 2321
        public const string TaskProgrammingLanguageGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b4002e3";

        // Token: 0x04000912 RID: 2322
        public const string SchVarPercentGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b400320";

        // Token: 0x04000913 RID: 2323
        public const string EffVarPercentGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b400321";

        // Token: 0x04000914 RID: 2324
        public const string ModuleGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b40031f";

        // Token: 0x04000915 RID: 2325
        public const string ProjectProgrammingLanguageGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b40038e";

        // Token: 0x04000916 RID: 2326
        public const string ProductionStatusGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b40038d";

        // Token: 0x04000917 RID: 2327
        public const string TaskClassGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b400322";

        // Token: 0x04000918 RID: 2328
        public const string IsNonPrjEffortGUID = "000039b7-8bbe-4ceb-82c4-fa8c0b400293";

        // Token: 0x04000919 RID: 2329
        public const string AssnDeliveryPlanDateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408003";

        // Token: 0x0400091A RID: 2330
        public const string AssnDeliveryActualDateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408004";

        // Token: 0x0400091B RID: 2331
        public const string AssnIsNonPrjEffortGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408005";

        // Token: 0x0400091C RID: 2332
        public const string AssnLOCNewEstimateGUID = "\t000039b7-8bbe-4ceb-82c4-fa8c0f408006";

        // Token: 0x0400091D RID: 2333
        public const string AssnQANumGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408007";

        // Token: 0x0400091E RID: 2334
        public const string AssnQANGGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408008";

        // Token: 0x0400091F RID: 2335
        public const string AssnLOCNewActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408009";

        // Token: 0x04000920 RID: 2336
        public const string AssnLOCReuseActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40800a";

        // Token: 0x04000921 RID: 2337
        public const string AssnTestCaseActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40800b";

        // Token: 0x04000922 RID: 2338
        public const string AssnDefectGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40800c";

        // Token: 0x04000923 RID: 2339
        public const string AssnLOCReuseEstimateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40800d";

        // Token: 0x04000924 RID: 2340
        public const string AssnDeliveryInfoGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40800e";

        // Token: 0x04000925 RID: 2341
        public const string AssnTestcaseMustHaveGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40800f";

        // Token: 0x04000926 RID: 2342
        public const string AssnSchVarByDayGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408010";

        // Token: 0x04000927 RID: 2343
        public const string AssnEffVarGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408011";

        // Token: 0x04000928 RID: 2344
        public const string AssnLOCCommentGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408012";

        // Token: 0x04000929 RID: 2345
        public const string AssnDesignPageEstimateGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408013";

        // Token: 0x0400092A RID: 2346
        public const string AssnDesignPageActualGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408014";

        // Token: 0x0400092B RID: 2347
        public const string AssnTaskDifficultGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408015";

        // Token: 0x0400092C RID: 2348
        public const string AssnTaskProgrammingLanguageGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408016";

        // Token: 0x0400092D RID: 2349
        public const string AssnModuleGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408017";

        // Token: 0x0400092E RID: 2350
        public const string AssnSchVarPercentGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408018";

        // Token: 0x0400092F RID: 2351
        public const string AssnEffVarPercentGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f408019";

        // Token: 0x04000930 RID: 2352
        public const string AssnTaskClassGUID = "000039b7-8bbe-4ceb-82c4-fa8c0f40801a";

        // Token: 0x04000931 RID: 2353
        private Guid WScheduleID;

        // Token: 0x04000932 RID: 2354
        private bool IsScheduleCheckout;

        // Token: 0x04000933 RID: 2355
        private string ScheduleName;

        //// Token: 0x04000934 RID: 2356
        //private cls_CM_ResourceOnServer2007 ScheduleOwner;

        //// Token: 0x04000935 RID: 2357
        //private List<ProjectStaffEffort> ListPrjEffort;

        // Token: 0x04000936 RID: 2358
        private ScheduleStatus ProjectScheduleStatus;

        // Token: 0x04000937 RID: 2359
        public static Guid SCHEDULE_NOT_SET = Guid.Empty;

        // Token: 0x04000938 RID: 2360
        public const string _seperatorChar = ",";

        // Token: 0x04000939 RID: 2361
        public const decimal TRAINING_RATE = 0.6m;

        // Token: 0x0400093A RID: 2362
        private bool _readOnlyData;

        ////        // Token: 0x0400093B RID: 2363
        ////        public const decimal ConvertScheduleUnitToHour = 60000m;
    }
}// 
