using P2k7.Api.CustomfieldsWebSvc;
using P2k7.Entities;
using P2k7.Api.LookuptableWebSvc;
using P2k7.Api.ProjectWebSvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace P2k7.Api.Data
{
    public class TaskRepository : BaseRepository
    {
        public CustomFieldRepository CfRepo { get; }
        public ProjectRepository PrjRepo { get; }

        public TaskRepository( CustomFieldRepository CfRepo, ProjectRepository PrjRepo) : base()
        {
            this.CfRepo = CfRepo;
            this.PrjRepo = PrjRepo;
        }

        public List<LookupTableDataSet.LookupTableTreesRow> ReadTaskIncludeTaskClass()
        {
            var lookuptableDS = lookupTable.ReadLookupTables("", false, 0);

            var tskTypeList = (LookupTableDataSet.LookupTablesRow[])lookuptableDS.LookupTables.Select(string.Format("{0} = '{1}'",
                                                                   lookuptableDS.LookupTables.LT_NAMEColumn.ColumnName,
                                                                   "TaskClass"));
            if (tskTypeList == null || tskTypeList.Length == 0)
            {
                return null;
            }

            var taskClassTypeUID = tskTypeList[0].LT_UID; // fc96f7f7-9964-4bca-a072-32c42f469c4d
            var FilterStr = string.Format("{0} = '{1}'",
                                          lookuptableDS.LookupTableTrees.LT_UIDColumn.ColumnName,
                                          taskClassTypeUID);

            var rs = ((LookupTableDataSet.LookupTableTreesRow[])lookuptableDS.LookupTableTrees.Select(FilterStr)).ToList();

            return rs;
        }


        public IEnumerable<Entities.TaskInfo> GetTaskSummaryTimephasedDataNew(Guid schedule_ID, DateTime StartDate, DateTime EndDate, DataStoreEnum whereToGet = DataStoreEnum.PublishedStore)
        {
            // truncate time
            StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 0);
            EndDate = new DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 23, 59, 59);

            // get raw data
            var entityType = ProjectEntityType.Task | ProjectEntityType.Assignment | ProjectEntityType.TaskCustomFields;

            var projectDataSet = project.ReadProjectEntities(schedule_ID, Convert.ToInt32(entityType), whereToGet);
            var customFieldDS = customFields.ReadCustomFields("", false);
            var lookupTableDataSet = lookupTable.ReadLookupTables("", false, 0);
            var resourceDS = resource.ReadResources("", false);

            var taskClassList = CfRepo.ReadTaskClass();
            var taskCLassLookUpUID = CfRepo.ReadTaskClassLookUpUID();
            var ctr = customFieldDS.CustomFields.Select($"{customFieldDS.CustomFields.MD_LOOKUP_TABLE_UIDColumn.ColumnName} = '{taskCLassLookUpUID}'").FirstOrDefault();
            var ctr2 = (CustomFieldDataSet.CustomFieldsRow)ctr;
            var TaskClassMD_PROP_UID = ctr2.MD_PROP_UID;
            var TaskClassMD_PROP_UID_SECONDARY = ctr2.MD_PROP_UID_SECONDARY;

            // get by out param :   list of subprj (NAME, WBS)
            var spjTuple = PrjRepo.GetSubPrjListWBS(projectDataSet);
            var subPrjWBS = spjTuple.Item1;
            var subPrjName = spjTuple.Item2;

            //var TASK_UID = projectDataSet.Task.TASK_UIDColumn.ColumnName;
            //var CODE_VALUE = projectDataSet.TaskCustomFields.CODE_VALUEColumn.ColumnName;
            //var LT_STRUCT_UID = "LT_STRUCT_UID"; // todo  get dynamic name
            //var a = customFieldDS.CustomFields.Select( (CustomFieldsRow x) => x.MD_LOOKUP_TABLE_UID = )

            var TaskFullInfo = (from task in projectDataSet.Task.AsEnumerable()
                                join task_customField in projectDataSet.TaskCustomFields.AsEnumerable()
                                    on new
                                    {
                                        TASK_UID = ((ProjectDataSet.TaskRow)task).TASK_UID,
                                        TaskClassMD_PROP_UID = TaskClassMD_PROP_UID
                                    }
                                    equals new
                                    {
                                        TASK_UID = ((ProjectDataSet.TaskCustomFieldsRow)task_customField).TASK_UID,
                                        TaskClassMD_PROP_UID = ((ProjectDataSet.TaskCustomFieldsRow)task_customField).MD_PROP_UID,
                                    } into tskcust
                                from tskcustDefault in tskcust.DefaultIfEmpty()
                                join taskClass in taskClassList
                                   on new
                                   {
                                       CODE_VALUE = (tskcustDefault == null  || tskcustDefault["CODE_VALUE"] == DBNull.Value) ? Guid.Empty : ((ProjectDataSet.TaskCustomFieldsRow)tskcustDefault).CODE_VALUE
                                       // CODE_VALUE = ((ProjectDataSet.TaskCustomFieldsRow)tskcustDefault).CODE_VALUE
                                   }
                                   equals new { CODE_VALUE = taskClass.LT_STRUCT_UID } into tskClass
                                from x in tskClass.DefaultIfEmpty()
                                select new Entities.TaskInfo
                                {
                                    Task = (ProjectDataSet.TaskRow)task,
                                    Task_CustomField = (ProjectDataSet.TaskCustomFieldsRow)tskcustDefault,
                                    TaskClass = (LookupTableDataSet.LookupTableTreesRow)x
                                });

            return TaskFullInfo;
            ;
        }

        public IEnumerable SummaryEffortTree(Guid schedule_ID,
                                             DateTime StartDate,
                                             DateTime ToDate)
        {

            var taskSummaryTimephasedData = GetTaskSummaryTimephasedDataNew(schedule_ID,
                                                                         StartDate,
                                                                         ToDate,
                                                                         DataStoreEnum.PublishedStore);

            var rs = taskSummaryTimephasedData.Select(x =>
            new
            {
                Id = x.Task.TASK_UID.ToString(),
                ParentId = (x.Task.TASK_UID == x.Task.TASK_PARENT_UID) ? "0" : x.Task.TASK_PARENT_UID.ToString(),
                Name = x.Task.TASK_NAME,
                TaskClass = x.TaskClass == null ? "" : x.TaskClass.LT_VALUE_TEXT,
                TaskClassName = x.TaskClass == null ? "" : x.TaskClass.LT_VALUE_DESC,
                Acctual  = Convert.ToDecimal(x.Task.TASK_ACT_WORK)/60000m
                //DD = 16m,
                //PG = 24m,
                //isSubPrj = !(x.TaskClass == null ? false : (x.TaskClass.LT_VALUE_TEXT == "SUB_PRJ"))
            });

            var rs2 = rs.ToList();
            
            var a = project.ReadProject(Guid.Empty, DataStoreEnum.PublishedStore);
            return rs.ToList();
        }
    }
}
