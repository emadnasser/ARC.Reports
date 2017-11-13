using System;
using System.Windows.Data;
using DevExpress.Xpf.Grid;
using System.Windows.Markup;

namespace GridDemo {
    public class GridImagesConverter : MarkupExtension, IValueConverter {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        #region IValueConverter Members
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            string resourcePath = string.Format("DevExpress.Xpf.Grid.Images.FixedRow{0}.png", value);
            return DevExpress.Xpf.Core.Native.ImageHelper.CreateImageFromEmbeddedResource(typeof(GridControl).Assembly, resourcePath);
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
        #endregion
    }
    public class FixedRowPositionToVisibilityConverter : MarkupExtension, IValueConverter {
        public FixedRowPosition InvisibleRowPosition { get; set; }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        #region IValueConverter Members
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return !Equals(value, InvisibleRowPosition);
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
