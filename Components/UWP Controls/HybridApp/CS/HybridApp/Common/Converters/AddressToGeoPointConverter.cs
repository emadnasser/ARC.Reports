using System;
using DevExpress.UI.Xaml.Map;
using HybridApp.HybridAppService;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public class AddressToGeoPointConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            var address = value as Address;
            if(address == null)
                return value;
            return new GeoPoint(address.Latitude, address.Longitude);
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
