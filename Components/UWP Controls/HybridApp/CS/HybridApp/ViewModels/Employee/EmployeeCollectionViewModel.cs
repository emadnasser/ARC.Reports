using DevExpress.Mvvm;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class EmployeeCollectionViewModel : CollectionViewModel<Employee> {
        public EmployeeCollectionViewModel() {
            AddTaskCommand = new DelegateCommand<Employee>(AddTask, CanAddTask);
            AddNoteCommand = new DelegateCommand<Employee>(AddNote, CanAddNote);
        }
        bool CanAddNote(Employee entity) {
            return entity != null;
        }
        void AddNote(Employee entity) {
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(true, () => AddNoteCore(entity), true);
            else
                AddNoteCore(entity);
        }
        void AddNoteCore(Employee entity) {
            var viewModel = new EvaluationViewModel() { Employee = entity };
            (viewModel as ISupportParentViewModel).ParentViewModel = this;
            var dialogCommands = new UICommand[] { new UICommand("Save", "Save", viewModel.SaveAndCloseCommand, true, false), new UICommand("Cancel", "Cancel", viewModel.CancelAndCloseCommand, false, true) };
            DialogService.ShowDialogAsync(dialogCommands, "New Note", "EvaluationView", viewModel);
        }
        bool CanAddTask(Employee entity) {
            return entity != null;
        }
        void AddTask(Employee entity) {
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(true, () => AddTaskCore(entity), true);
            else
                AddTaskCore(entity);
        }
        void AddTaskCore(Employee entity) {
            var viewModel = new EmployeeTaskViewModel() { Employee = entity };
            (viewModel as ISupportParentViewModel).ParentViewModel = this;
            var dialogCommands = new UICommand[] { new UICommand("Save", "Save", viewModel.SaveAndCloseCommand, true, false), new UICommand("Cancel", "Cancel", viewModel.CancelAndCloseCommand, false, true) };
            DialogService.ShowDialogAsync(dialogCommands, "New Task", "EmployeeTaskView", viewModel);
        }
        void ReloadEntities() {
            SetEntities();
        }

        public DelegateCommand<Employee> AddTaskCommand { get; private set; }
        public DelegateCommand<Employee> AddNoteCommand { get; private set; }
    }
}
