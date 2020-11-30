using P2k7.LookuptableWebSvc;
using P2k7.ProjectWebSvc;

namespace P2k7.Entities
{
    public class TaskInfo
    {
        public ProjectDataSet.TaskRow Task { get; internal set; }
        public ProjectDataSet.TaskCustomFieldsRow Task_CustomField { get; internal set; }
        public LookupTableDataSet.LookupTableTreesRow TaskClass { get; internal set; }
    }
}
