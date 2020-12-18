using iProject.Core;
using iProject.Core.Extension;
using iProject.Model;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace iProject.ViewModel
{
    public class ReportActualViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ReportActualViewModel()
        {

        }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public IEnumerable<ActualData> ActualData { get; }

    }
}
