using P2k7.Api.LookuptableWebSvc;
using P2k7.Api.ProjectWebSvc;

namespace P2k7.Api.Data.Entities
{
    public class TaskInfo
    {
        public ProjectDataSet.TaskRow Task { get; internal set; }
        public ProjectDataSet.TaskCustomFieldsRow Task_CustomField { get; internal set; }
        public LookupTableDataSet.LookupTableTreesRow TaskClass { get; internal set; }
    }
}
