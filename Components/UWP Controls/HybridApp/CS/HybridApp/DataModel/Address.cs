using DevExpress.UI.Xaml.Map;

namespace HybridApp.HybridAppService {
    public partial class Address {
        public string CityLine {
            get { return string.Format("{0}, {1} {2}", City, State, ZipCode); }
        }
        public GeoPoint Location { get { return new GeoPoint(Latitude, Longitude); } }
        public override string ToString() {
            return string.Format("{0}, {1}", Line, CityLine);
        }
    }
}
