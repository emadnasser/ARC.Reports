using System;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public class NullableIntConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return (int?)((double)value);
        }
    }
}
