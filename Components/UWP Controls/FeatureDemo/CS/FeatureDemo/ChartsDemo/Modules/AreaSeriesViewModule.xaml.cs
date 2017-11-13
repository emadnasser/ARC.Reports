using FeatureDemo.Common;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ChartsDemo {
    public sealed partial class AreaSeriesViewModule : DemoModuleView {
        public AreaSeriesViewModule() {
            this.InitializeComponent();
            Loading += OnLoading;
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }
        void OnLoading(FrameworkElement sender, object args) {
            DataContext = new AreaSeriesViewModel();
            MinMargin = new Thickness(5);
        }
        void OnLoaded(object sender, RoutedEventArgs e) {
            ((AreaSeriesViewModel)DataContext).Initialize();
        }
        void OnUnloaded(object sender, RoutedEventArgs e) {
            DataContext = null;
        }
    }
}
