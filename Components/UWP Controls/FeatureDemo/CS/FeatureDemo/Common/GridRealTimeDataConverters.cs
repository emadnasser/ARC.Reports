using FeatureDemo.Data;
using DevExpress.UI.Xaml.Charts;
using GridDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace FeatureDemo.Common {
    public class BooleanToAngleConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return (bool)value ? 180 : 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class BooleanToColorConverter : IValueConverter {
        internal static Color GreenColor = Color.FromArgb(255, 3, 176, 137);
        internal static Color RedColor = Color.FromArgb(255, 201, 5, 65);

        public object Convert(object value, Type targetType, object parameter, string language) {
            return new SolidColorBrush((bool)value ? GreenColor : RedColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class ValueToColorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return new SolidColorBrush(System.Convert.ToDouble(value) > 0 ? BooleanToColorConverter.GreenColor : BooleanToColorConverter.RedColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class StockPriceConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return String.Format("{0:.00}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class StockVolumeConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return String.Format("{0:###,###,###}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class StockDeltaPriceConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return String.Format("{0:+0.00;-0.00;0}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class StockDeltaPricePercentConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return String.Format("{0:+0.00;-0.00;0}%", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class ArrowDirectionConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return System.Convert.ToDouble(value) > 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    public class ArrayToChartDataConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            int[] array = value as int[];
            if(array == null)
                return null;
            DataPointCollection collection = new DataPointCollection();
            for(int i = 0; i < StockItem.HistoryLength; i++)
                collection.Add(new DataPoint(i, array[i]));
            return collection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

}
