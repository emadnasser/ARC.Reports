using System;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public class HalfValueConverter : IValueConverter {
        public bool NegativeValue { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language) {
            if(!(value is double))
                return value;
            var result = ((double)value) / 2;
            if(NegativeValue)
                result *= -1;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
