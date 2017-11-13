using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.StockMarketTrader.ViewModel;
using DevExpress.Xpf.Core;
using DevExpress.StockMarketTrader;
using System.Windows.Threading;
using System.Timers;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Reflection;
using DevExpress.Utils;
using System.ComponentModel;
using System.Threading;
using System.Globalization;
using DevExpress.StockMarketTrader.Model.Offline;
using DevExpress.Internal;

namespace DevExpress.StockMarketTrader {
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            ExceptionHelper.Initialize();
            DevExpress.Xpf.Bars.BarManager.IgnoreMenuDropAlignment = true;
            DevExpress.Xpf.Bars.ResourceStorage.UseResourceStorage = false;
            Window window = Start(() => base.OnStartup(e));
            window.Show();
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWPF, this);
        }
        public static Window Start(Action baseStartup) {
            DXSplashScreen.Show<StockMarketTraderSplashScreen>();
            ApplicationThemeHelper.ApplicationThemeName = Theme.MetropolisDarkName;
            RealTimeDataViewModel rtdvm = new RealTimeDataViewModel();
            baseStartup();
            StockMarketView view = new StockMarketView();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            DXWindow window = new DXWindow();
            window.MinWidth = 1200;
            window.MinHeight = 600;
            window.Width = 1200;
            window.Height = 750;
            window.ShowIcon = false;
            window.ShowTitle = false;
            window.Title = "Stock Market";
            window.Icon = new BitmapImage(AssemblyHelper.GetResourceUri(typeof(App).Assembly, "Images/DX.ico"));
            Binding binding = new Binding("IsSuspendUpdating");
            binding.Source = rtdvm;
            binding.Mode = BindingMode.OneWayToSource;
            window.SetBinding(DXWindow.IsDraggingOrResizingProperty, binding);
            view.DataContext = rtdvm;
            window.Content = view;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Loaded += window_Loaded;
            DXSplashScreen.Close();
            return window;
        }
        static void window_Loaded(object sender, RoutedEventArgs e) {
            ((DXWindow)sender).Activate();
        }
    }
}
#if CLICKONCE
namespace DevExpress.Internal.DemoLauncher {
    public static class ClickOnceEntryPoint {
        public static Window CreateMainWindow() {
            Application app = Application.Current;
            return App.Start(() => { });
        }
    }
}
#endif
