using DevExpress.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace GridDemo {
    public sealed partial class ConditionalFormattingModule : GridDemoUserControl {
        public ConditionalFormattingModule() {
            this.InitializeComponent();
            Unloaded += OnUnloaded;
        }

        private void OnUnloaded(object sender, RoutedEventArgs e) {
            gridControl.DataContext = null;
            gridRoot.DataContext = null;
        }

        protected internal override GridControl Grid { get { return gridControl; } }
    }

    public class RowHandleToBackgroundConverter : IValueConverter {
        public Brush EvenRowBackground { get; set; }
        public Brush OddRowBackground { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language) {
            if(((int)value % 2) == 0)
                return OddRowBackground;
            else
                return EvenRowBackground;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
    public class DoubleToForeground : IValueConverter {
        public double ThresholdValue { get; set; }
        public ComparisonType ComparisonType { get; set; }
        public Brush Foreground { get; set; }
        public Brush DefaultForeground { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language) {
            switch(ComparisonType) {
                case ComparisonType.Greater:
                    if((double)value > ThresholdValue)
                        return Foreground;
                    else
                        return DefaultForeground;
                case ComparisonType.Less:
                    if((double)value < ThresholdValue)
                        return Foreground;
                    else
                        return DefaultForeground;
            }
            return DefaultForeground;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
    public enum ComparisonType {
        Greater,
        Less
    }
}
