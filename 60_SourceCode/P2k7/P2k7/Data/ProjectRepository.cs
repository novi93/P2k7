using P2k7.ProjectWebSvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P2k7.Data
{
    public class ProjectRepository : PsiRepository
    {
        public CustomFieldRepository CfRepo { get; }

        public ProjectRepository(MySettings mySettings, CustomFieldRepository cfRepo) : base(mySettings)
        {
            CfRepo = cfRepo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectGuid"></param>
        /// <param name="dataStoreEnum"></param>
        /// <returns></returns>
        public ProjectDataSet ReadProject(Guid projectGuid, DataStoreEnum dataStoreEnum)
        {
            return project.ReadProject(projectGuid, (ProjectWebSvc.DataStoreEnum)dataStoreEnum);
             
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <param name=""></param>
        /// <returns>
        /// Item1 : subPrjWBS 
        /// Item2 : subPrjName
        /// </returns>
        public Tuple<List<string>,List<string>> GetSubPrjListWBS(ProjectDataSet project)
        {
            var subPrjWBS = new List<string>();
            var subPrjName = new List<string>();

            // get taskclass field
            var SubPrjTaskClassInfo = CfRepo.ReadTaskClass("SUB_PRJ");

            if (SubPrjTaskClassInfo != null)
            {
                // get ID of all task has taskClass =  SUBPRJ
                var SubPrjTaskHasList = (ProjectDataSet.TaskCustomFieldsRow[])project.TaskCustomFields.Select(
                    $"{project.TaskCustomFields.MD_PROP_UIDColumn.ColumnName} = '{"000039b7-8bbe-4ceb-82c4-fa8c0b400322"}'" +
                    $" AND {project.TaskCustomFields.CODE_VALUEColumn.ColumnName} = '{SubPrjTaskClassInfo.LT_STRUCT_UID}'");

                if (SubPrjTaskHasList != null)
                {
                    // get all task is SUBPRJ
                    foreach (ProjectDataSet.TaskCustomFieldsRow taskCustomFieldsRow in SubPrjTaskHasList)
                    {
                        ProjectDataSet.TaskRow[] array5 = (ProjectDataSet.TaskRow[])project.Task
                            .Select($"{project.Task.TASK_UIDColumn.ColumnName} = '{taskCustomFieldsRow.TASK_UID}'"
                            );
                        if (array5 != null && array5.Count() == 1)
                        {
                            subPrjWBS.Add(array5[0].TASK_WBS);
                            subPrjName.Add(array5[0].TASK_NAME);
                        }
                    }
                }
            }
            return Tuple.Create(subPrjWBS,subPrjName);
        }

    } // class
} // ns
