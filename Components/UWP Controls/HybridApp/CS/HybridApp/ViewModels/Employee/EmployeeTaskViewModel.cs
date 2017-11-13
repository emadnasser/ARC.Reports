using System;
using System.Collections.ObjectModel;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class EmployeeTaskViewModel : SingleObjectViewModel<EmployeeTask> {
        public override void Close() { }
        protected async override void Loaded() {
            LookUpEmployees = await DataProvider.Client.GetCollection<Employee>();
            LookUpCustomerEmployees = await DataProvider.Client.GetCollection<CustomerEmployee>();
            base.Loaded();
            this.RaisePropertiesChanged("Entity");
        }
        ObservableCollection<Employee> lookUpEmployees;
        public ObservableCollection<Employee> LookUpEmployees {
            get { return lookUpEmployees; }
            set { SetProperty(ref lookUpEmployees, value); }
        }
        ObservableCollection<CustomerEmployee> lookUpCustomerEmployees;
        public ObservableCollection<CustomerEmployee> LookUpCustomerEmployees {
            get { return lookUpCustomerEmployees; }
            set { SetProperty(ref lookUpCustomerEmployees, value); }
        }
        Employee employee;
        public Employee Employee {
            get { return employee; }
            set { SetProperty(ref employee, value); }
        }
        protected override EmployeeTask CreateEntity() {
            var entity = base.CreateEntity();
            entity.StartDate = DateTime.Now;
            entity.DueDate = DateTime.Now + new TimeSpan(48, 0, 0);
            entity.Owner = Employee;
            entity.AssignedEmployee = Employee;
            return entity;
        }
        public DateTime? ReminderTime {
            get {
                if(Entity == null || Entity.ReminderDateTime == null)
                    return null;
                return Entity.ReminderDateTime.Value;
            }
            set {
                if(Entity == null || value == null || Entity.ReminderDateTime == null)
                    return;
                DateTime reminderDateTime = (DateTime)this.Entity.ReminderDateTime;
                Entity.ReminderDateTime = new DateTime(reminderDateTime.Year, reminderDateTime.Month, reminderDateTime.Day, ((DateTime)value).Hour, ((DateTime)value).Minute, reminderDateTime.Second);
            }
        }
    }
}
