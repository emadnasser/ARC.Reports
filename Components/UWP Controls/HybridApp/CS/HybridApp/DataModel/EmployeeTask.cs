
namespace HybridApp.HybridAppService {
    public partial class EmployeeTask {
        Employee assignedEmployee;
        public Employee AssignedEmployee {
            get { return assignedEmployee; }
            set {
                if(assignedEmployee == value)
                    return;
                assignedEmployee = value;
                AssignedEmployeeId = value == null ? (long?)null : value.Id;
                this.RaisePropertyChanged("AssignedEmployee");
            }
        }
        Employee owner;
        public Employee Owner {
            get { return owner; }
            set {
                if (owner == value)
                    return;
                owner = value;
                OwnerId = value == null ? (long?)null : value.Id;
                this.RaisePropertyChanged("Owner");
            }
        }
        CustomerEmployee customerEmployee;
        public CustomerEmployee CustomerEmployee {
            get { return customerEmployee; }
            set {
                if(customerEmployee == value)
                    return;
                customerEmployee = value;
                CustomerEmployeeId = value == null ? (long?)null : value.Id;
                this.RaisePropertyChanged("CustomerEmployee");
            }
        }
    }
}
