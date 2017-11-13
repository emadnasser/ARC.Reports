
namespace HybridApp.HybridAppService {
    public partial class CustomerStore {
        Crest crest;
        public Crest Crest {
            get { return crest; }
            set {
                if(crest != value) {
                    crest = value;
                    RaisePropertyChanged("Crest");
                }
            }
        }
        public string AddressLine {
            get { return (Address != null) ? Address.ToString() : null; }
        }
        public string City { get { return Address == null ? "" : Address.City; } }
    }
}
