using DevExpress.Internal;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.SalesDemo.Model;
using DevExpress.SalesDemo.Wpf.Helpers;
using DevExpress.SalesDemo.Wpf.View;
using DevExpress.SalesDemo.Wpf.View.Common;
using DevExpress.SalesDemo.Wpf.ViewModel;
using DevExpress.Xpf.Core;
using System;
using System.Windows;

namespace DevExpress.SalesDemo.Wpf {
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            ExceptionHelper.Initialize();
            ViewLocator.Default = new ViewLocator(typeof(App).Assembly);
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name;
            using(DataSource.Progress.Subscribe(new DataGenerationProgress()))
                DataSource.EnsureDataProvider();
            base.OnStartup(e);
            InitModules();
        }
        public static void InitModules() {
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Dashboard,
                () => NavigationItemViewModel.Create(ModuleType.Dashboard, "Sales", "Revenue" + Environment.NewLine + "Snapshots",
                    ResourceImageHelper.GetResourceImage("Sales.png")),
                typeof(NavigationItemView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Products,
                () => NavigationItemViewModel.Create(ModuleType.Products, "Products", "Revenue" + Environment.NewLine + "by Products",
                    ResourceImageHelper.GetResourceImage("Products.png")),
                typeof(NavigationItemView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Sectors,
                () => NavigationItemViewModel.Create(ModuleType.Sectors, "Sectors", "Revenue" + Environment.NewLine + "by Sectors",
                    ResourceImageHelper.GetResourceImage("Sectors.png")),
                typeof(NavigationItemView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Regions,
                () => NavigationItemViewModel.Create(ModuleType.Regions, "Regions", "Revenue" + Environment.NewLine + "by Regions",
                    ResourceImageHelper.GetResourceImage("Regions.png")),
                typeof(NavigationItemView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Channels,
                () => NavigationItemViewModel.Create(ModuleType.Channels, "Channels", "Revenue" + Environment.NewLine + "by Sales Channels",
                    ResourceImageHelper.GetResourceImage("Channels.png")),
                typeof(NavigationItemView));

            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Dashboard, () => SalesDashboardViewModel.Create(), typeof(SalesDashboard));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Products, () => ProductsViewModel.Create(), typeof(ProductsView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Sectors, () => SectorsViewModel.Create(), typeof(SectorsView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Regions, () => RegionsViewModel.Create(), typeof(RegionsView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Channels, () => ChannelsViewModel.Create(), typeof(ChannelsView));

            ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Dashboard);
        }
    }
    class DataGenerationProgress : IObserver<int> {
        void IObserver<int>.OnCompleted() {
            DXSplashScreen.Close();
        }
        void IObserver<int>.OnNext(int value) {
            if(!DXSplashScreen.IsActive) {
                DXSplashScreen.Show(typeof(ProgressSplashScreenView));
                DXSplashScreen.SetState(ProgressSplashScreenViewModel.Create("Generating Sales...", AssemblyInfo.AssemblyCopyright));
            }
            DXSplashScreen.Progress((double)value);
        }
        void IObserver<int>.OnError(Exception error) { throw error; }
    }
}
#if CLICKONCE
namespace DevExpress.Internal.DemoLauncher {
    public static class ClickOnceEntryPoint {
        public static Window CreateMainWindow() {
            Application app = Application.Current;
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name;
            app.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = DevExpress.Utils.AssemblyHelper.GetResourceUri(typeof(ClickOnceEntryPoint).Assembly, "Themes/Common.xaml") });
            using(DataSource.Progress.Subscribe(new DevExpress.SalesDemo.Wpf.DataGenerationProgress()))
                DataSource.EnsureDataProvider();
            ViewLocator.Default = new ViewLocator(typeof(DevExpress.SalesDemo.Wpf.App).Assembly);
            DevExpress.SalesDemo.Wpf.App.InitModules();
            return new DevExpress.SalesDemo.Wpf.MainWindow();
        }
    }
}
#endif
