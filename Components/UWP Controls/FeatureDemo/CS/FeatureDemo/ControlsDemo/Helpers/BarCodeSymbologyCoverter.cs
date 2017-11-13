using DevExpress.UI.Xaml.Controls;
using DevExpress.XtraPrinting.BarCode.Native;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Data;

namespace FeatureDemo.ControlsDemo {
    public class BarCodeSymbologyCoverter : IValueConverter {
        Dictionary<BarCodeSymbology, SymbologyBase> symbologies = new Dictionary<BarCodeSymbology, SymbologyBase>();
        public object Convert(object value, Type targetType, object parameter, string language) {
            var symbologyValue = (BarCodeSymbology)value;
            if(!symbologies.ContainsKey(symbologyValue)) {
                symbologies.Add(symbologyValue, BarCodeSymbologyStorage.Create(symbologyValue));
            }
            return symbologies[symbologyValue];
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return ((SymbologyBase)value).GeneratorBase.SymbologyCode;
        }
    }
}
