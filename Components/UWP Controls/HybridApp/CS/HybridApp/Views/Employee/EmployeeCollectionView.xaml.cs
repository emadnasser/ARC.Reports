using System;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Native;
using HybridApp.HybridAppService;
using HybridApp.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;

namespace HybridApp.Views {
    public sealed partial class EmployeeCollectionView : Page {
        public EmployeeCollectionView() {
            this.InitializeComponent();
            DataContext = ViewModel = new EmployeeCollectionViewModel();
        }
        public EmployeeCollectionViewModel ViewModel { get; private set; }
        void container_Loaded(object sender, RoutedEventArgs e) {
            var panel = (FrameworkElement)sender;
            panel.Width = grid.ActualWidth - panel.Margin.Left - panel.Margin.Right;
        }
        void Page_Loaded(object sender, RoutedEventArgs e) {
            ((LayoutHelper.FindRoot(this) as ContentControl)?.Content as Border).BorderThickness = new Thickness(0);
        }
    }
    public class SimpleConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return value;
        }
    }
    public class GridViewEventArgsConverter : EventArgsConverterBase<DoubleTappedRoutedEventArgs> {
        protected override object Convert(object sender, DoubleTappedRoutedEventArgs args) {
            var element = args.OriginalSource as DependencyObject;
            if(element == null)
                return null;
            var row = LayoutHelper.FindParentObject<GridViewItem>(element);
            return row?.Content;
        }
    }
}
