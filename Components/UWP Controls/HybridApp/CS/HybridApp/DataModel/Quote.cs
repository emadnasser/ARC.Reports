
namespace HybridApp.HybridAppService {
    public partial class Quote {
        CustomerStore customerStore;
        public CustomerStore CustomerStore {
            get { return customerStore; }
            set {
                if(customerStore != value) {
                    customerStore = value;
                    RaisePropertyChanged("CustomerStore");
                }
            }
        }
    }
}
