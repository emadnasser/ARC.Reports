
namespace HybridApp.HybridAppService {
    public partial class Crest {
        byte[] largeImage;
        public byte[] LargeImage {
            get { return largeImage; }
            set {
                if(largeImage != value) {
                    largeImage = value;
                    RaisePropertyChanged("LargeImage");
                }
            }
        }
    }
}
