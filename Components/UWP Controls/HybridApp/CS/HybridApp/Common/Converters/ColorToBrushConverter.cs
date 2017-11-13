using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace HybridApp.Common {
    public class ColorToBrushConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return value is Color ? new SolidColorBrush((Color)value) : null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return value is SolidColorBrush ? ((SolidColorBrush)value).Color : Colors.Transparent;
        }
    }
}
