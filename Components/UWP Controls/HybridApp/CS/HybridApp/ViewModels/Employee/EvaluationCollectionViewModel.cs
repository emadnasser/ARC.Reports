using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using HybridApp.Common;
using HybridApp.HybridAppService;
using Windows.UI.Core;

namespace HybridApp.ViewModels {
    public class EvaluationCollectionViewModel : CollectionViewModel<Evaluation> {
        public EvaluationCollectionViewModel(Employee employee) {
            Employee = employee;
        }
        public Employee Employee {
            get { return GetProperty(() => Employee); }
            set { SetProperty(() => Employee, value, SetEntities); }
        }
        protected override void OnEntityMessage(DataModel.EntityMessage<Evaluation> message) {
            base.OnEntityMessage(message);
            SetEntities();
        }
        protected override async Task<ObservableCollection<Evaluation>> GetEntities() {
            if(Employee == null)
                return null;
            var allEvaluations = await DataProvider.Client.GetCollection<Evaluation>();
            return allEvaluations.Where(e => e.EmployeeId == Employee.Id).AsObservableCollection();
        }
        protected override void Edit(Evaluation entity) {
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(true, () => EditCore(entity), true);
            else
                EditCore(entity);
        }
        async void EditCore(Evaluation entity) {
            var viewModel = new EvaluationViewModel() { Employee = this.Employee };
            (viewModel as ISupportParentViewModel).ParentViewModel = this;
            (viewModel as ISupportParameter).Parameter = entity;
            var dialogCommands = new UICommand[] { new UICommand("Save", "Save", viewModel.SaveAndCloseCommand, true, false), new UICommand("Cancel", "Cancel", viewModel.CancelAndCloseCommand, false, true) };
            UICommand dialogServiceResult = await DialogService.ShowDialogAsync(dialogCommands, CreateTitle(entity), "EvaluationView", viewModel);
            if(dialogServiceResult != null && dialogServiceResult.Id.ToString() == "Save")
                SetEntities();
        }
        string CreateTitle(Evaluation entity) {
            return entity == null || entity.Employee == null ? "New Note" : "Edit Note " + entity.Employee.FullName;
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
    }
}
