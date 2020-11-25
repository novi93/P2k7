using System;

namespace P2k7.Model
{
    public class ReportActualModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ScreenModeEnum ScreenMode { get; set; } = ScreenModeEnum.Header;

        public ActualData ActualData;

    }
}
