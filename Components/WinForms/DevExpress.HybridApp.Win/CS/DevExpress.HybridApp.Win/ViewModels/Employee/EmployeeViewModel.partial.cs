using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm;
using System.Windows;

namespace DevExpress.DevAV.ViewModels {
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, long, IDevAVDbUnitOfWork> {
        EmployeeCollectionViewModel ParentViewModel {
            get { return this.GetParentViewModel<EmployeeCollectionViewModel>(); }
        }
        public void ShowMailMerge() {
            ParentViewModel.ShowMailMerge(Entity);
        }
        public void ShowReport() {
            ParentViewModel.ShowReportForSelectedEntity(EmployeeReportType.Profile);
        }
        public void ShowMeetingDialog() {
            MessageBoxService.Show(string.Format("Schedule meeting with {0}?", Entity.FullName), string.Empty, MessageBoxButton.YesNoCancel);
        }
    }
}
