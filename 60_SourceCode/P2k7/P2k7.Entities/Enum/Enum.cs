namespace P2k7.Api.Data.Enum
{
    public enum TaskPhase
    {
        GetRequirement = 0,
        BasicDesign = 1,
        ReviewBasicDesign = 2,
        DetailDesign = 3,
        ReviewDetailDesign = 4,
        Coding = 5,
        ReviewCode = 6,
        Testing1 = 7,
        Testing2 = 8,
        Testing2CT = 9,
        Testing2ST = 10,
        DelTesting = 11,
        FixDefectInt = 12,
        FixDefectCus = 13,
        Management = 14,
        Training = 15,
        Others = 16,
        MarkPGName = 17,
        MarkSubProject = 18,
        ChangeRequest = 19,
        Research = 20,
        DeductedEffort = 21,
        Support1 = 22,
        Support2 = 23,
        CreateTST1Testcase = 24,
        ReviewTST1Testcase = 25,
        CreateTST2CTTestcase = 26,
        ReviewTST2CTTestcase = 27,
        CreateTST2STTestcase = 28,
        ReviewTST2STTestcase = 29,
        JCSupport = 30,
        SCConvert = 31,
        Quotation = 32,
        Investigate1 = 33,
        Investigate2 = 34
    }
    public enum TaskClass
    {
        ManagementTask = 0,
        DevelopmentTask = 1,
        FixBugTask = 2,
        OtherTasks = 3
    }

    public enum ScheduleStatus
    {
        // Token: 0x04000876 RID: 2166
        NotInRange,
        // Token: 0x04000877 RID: 2167
        Planned,
        // Token: 0x04000878 RID: 2168
        Production,
        // Token: 0x04000879 RID: 2169
        OnHold,
        // Token: 0x0400087A RID: 2170
        Cancelled,
        // Token: 0x0400087B RID: 2171
        Completed
    }
    public enum LoginMode
    {
        WindowsAuth,
        FormAuth
    }
        public enum ScreenModeEnum
    {
        Init ,
        Header,
        Deatail
    }
}
