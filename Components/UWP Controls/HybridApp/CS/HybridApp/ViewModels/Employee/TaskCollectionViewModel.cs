using System;
using System.Threading.Tasks;
using DevExpress.Core.Native;
using DevExpress.Mvvm;
using HybridApp.HybridAppService;
using Windows.Phone.UI.Input;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace HybridApp.ViewModels {
    public class TaskCollectionViewModel : CollectionViewModel<EmployeeTask> {
        public TaskCollectionViewModel() {
            ShowTotalSummary = true;
        }
        public TaskCollectionViewModel(Employee employee) : base(new TaskFilterTreeViewModel(employee)) {
            Employee = employee;
            SetEntities();
        }
        protected override void OnEntityMessage(DataModel.EntityMessage<EmployeeTask> message) {
            base.OnEntityMessage(message);
            SetEntities();
        }
        protected Employee Employee { get; set; }
        protected override void Edit(EmployeeTask entity) {
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(true, () => EditCore(entity), true);
            else
                EditCore(entity);
        }
        async void EditCore(EmployeeTask entity) {
            var viewModel = new EmployeeTaskViewModel() { Employee = this.Employee };
            (viewModel as ISupportParentViewModel).ParentViewModel = this;
            (viewModel as ISupportParameter).Parameter = entity;
            var dialogCommands = new UICommand[] { new UICommand("Save", "Save", viewModel.SaveAndCloseCommand, true, false), new UICommand("Cancel", "Cancel", viewModel.CancelAndCloseCommand, false, true) };
            UICommand dialogServiceResult = await DialogService.ShowDialogAsync(dialogCommands, CreateTitle(entity), "EmployeeTaskView", viewModel);
            if(dialogServiceResult != null && dialogServiceResult.Id.ToString() == "Save")
                SetEntities();
        }
        string CreateTitle(EmployeeTask entity) {
            return entity == null || entity.AssignedEmployee == null ? "New Task" : "Edit Task - " + entity.AssignedEmployee.FullName;
        }
        protected override bool CanNew() {
            return Employee == null || (Employee != null && !Employee.IsNew);
        }
        void ReloadEntities() {
            SetEntities();
        }
        public bool Manipulation {
            get { return GetProperty(() => Manipulation); }
            set { SetProperty(() => Manipulation, value); }
        }
        public bool ShowTotalSummary { get; set; }
    }
}
