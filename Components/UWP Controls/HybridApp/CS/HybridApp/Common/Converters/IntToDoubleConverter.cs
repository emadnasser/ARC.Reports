using System;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public class IntToDoubleConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return System.Convert.ChangeType(value, typeof(double));
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
