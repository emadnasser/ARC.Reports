using System;
using System.Collections.ObjectModel;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class EvaluationViewModel : SingleObjectViewModel<Evaluation> {
        async protected override void Loaded() {
            LookUpEmployees = await DataProvider.Client.GetCollection<Employee>();
            base.Loaded();
            this.RaisePropertiesChanged("Entity");
        }
        protected override Evaluation CreateEntity() {
            var entity = base.CreateEntity();
            entity.CreatedOn = DateTime.Now;
            entity.CreatedBy = Employee;
            return entity;
        }
        Employee employee;
        public Employee Employee {
            get { return employee; }
            set { SetProperty(ref employee, value); }
        }
        ObservableCollection<Employee> lookUpEmployees;
        public ObservableCollection<Employee> LookUpEmployees {
            get { return lookUpEmployees; }
            set { SetProperty(ref lookUpEmployees, value); }
        }
        public override void Close() { }
    }
}
