using System;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public class TextSingleLineConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            string text = value as string;
            return text == null ? null : text.Replace(Environment.NewLine, " ");
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
