
namespace HybridApp.HybridAppService {
    public partial class Person {
        public Person() {
            Address = new Address();
        }
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
    }
}
