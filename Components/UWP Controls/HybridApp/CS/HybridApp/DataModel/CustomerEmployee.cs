
namespace HybridApp.HybridAppService {
    public partial class CustomerEmployee {
        byte[] picture;
        public byte[] Picture {
            get { return picture; }
            set {
                if(picture != value) {
                    picture = value;
                    RaisePropertyChanged("Picture");
                }
            }
        }
        CustomerStore customerStore;
        public CustomerStore CustomerStore {
            get { return customerStore; }
            set {
                if(customerStore != value) {
                    customerStore = value;
                    RaisePropertyChanged("CustomerStore");
                    RaisePropertyChanged("Address");
                }
            }
        }
        public Address Address {
            get { return (CustomerStore != null) ? CustomerStore.Address : null; }
        }
    }
}
