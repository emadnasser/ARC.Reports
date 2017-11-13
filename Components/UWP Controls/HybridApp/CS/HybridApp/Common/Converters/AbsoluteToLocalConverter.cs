using System;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public class AbsoluteToLocalConverter : IValueConverter {
        public double MaxValue { get; set; }
        public double MinValue { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language) {
            if(!(value is double))
                return value;
            return (double)value * (MaxValue - MinValue) + MinValue;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
