namespace HybridApp.HybridAppService {
    public partial class Evaluation {
        Employee employee;
        public Employee Employee {
            get { return employee; }
            set {
                if(employee != value) {
                    employee = value;
                    EmployeeId = value == null ? (long?)null : value.Id;
                    RaisePropertyChanged("Employee");
                }
            }
        }
        Employee createdBy;
        public Employee CreatedBy {
            get { return createdBy; }
            set {
                if(createdBy != value) {
                    createdBy = value;
                    CreatedById = value == null ? (long?)null : value.Id;
                    RaisePropertyChanged("CreatedBy");
                }
            }
        }
    }
}
