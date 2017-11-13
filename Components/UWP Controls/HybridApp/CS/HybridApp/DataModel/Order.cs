namespace HybridApp.HybridAppService {
    public partial class Order {
        CustomerStore store;
        public CustomerStore Store {
            get { return store; }
            set {
                if(store != value) {
                    store = value;
                    RaisePropertyChanged("Store");
                }
            }
        }
        Customer customer;
        public Customer Customer {
            get { return customer; }
            set {
                if(customer != value) {
                    customer = value;
                    RaisePropertyChanged("Customer");
                }
            }
        }
    }
}
