using System;

namespace P2k7.Entities
{
    [Flags]
    public enum ProjectEntityType
    {
        Project = 1,
        Task = 2,
        Resource = 4,
        Assignment = 8,
        Dependency = 16,
        ProjectCustomFields = 32,
        TaskCustomFields = 64,
        ResourceCustomFields = 128,
        AssignmentCustomFields = 256,
        AssignmentCore = 512,
        ProjectDefaults = 1024,
        AssignmentOwnerDefaults = 2048,
        AssignmentCustomFieldsNoRolldown = 4096
    }
}
