using P2k7.Entities.Enum;
using System;

namespace P2k7.Entities.Structs
{
    public struct Task2007Info
    {
        public Guid ID;
        public string WBS;
        public decimal Difficulty;
        public TaskPhase Phase;
        public string FinishDate;
        public string StartDate;
        public decimal OvertimeEffort;
        public TaskClass TaskPart;
        public decimal ActualEffort;
        public decimal BaselinedEffort;
        public string ResourceNTAccount;
        public string ResourceName;
        public Guid ProjectID;
        public string ModuleName;
        public string Name;
        public decimal ScheduleEffort;
        public string SubPrjName;
    }
}
