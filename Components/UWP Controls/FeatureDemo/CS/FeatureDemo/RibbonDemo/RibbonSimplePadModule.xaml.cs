using DevExpress.UI.Xaml.Ribbon;
using FeatureDemo.Common;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace RibbonDemo {
    public sealed partial class RibbonSimplePadModule : DemoModuleView {
        public RibbonViewModel ViewModel { get { return DataContext as RibbonViewModel; } }

        public RibbonSimplePadModule() {
            this.InitializeComponent();
            Unloaded += OnUnloaded;
        }

        private void OnUnloaded(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            var popups = VisualTreeHelper.GetOpenPopups(Window.Current);
            foreach(var popup in popups) {
                popup.IsOpen = false;
            }
            InputPane.GetForCurrentView().TryHide();
        }
    }
}
