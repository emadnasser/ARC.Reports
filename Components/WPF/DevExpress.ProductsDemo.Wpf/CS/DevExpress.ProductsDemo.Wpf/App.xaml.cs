using System;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.PdfViewer;
using DevExpress.Internal;

namespace ProductsDemo {
    public partial class App : Application {
        public App() {
            ExceptionHelper.Initialize();
            DevExpress.Images.ImagesAssemblyLoader.Load();
            PdfViewerLocalizer.Active = new CustomPdfViewerLocalizer();
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name;
        }
        public static void Start(Action baseStart, Application application) {
            ServiceContainer.Default.RegisterService(new ApplicationJumpListService());
        }
        protected override void OnStartup(StartupEventArgs e) {
            Start(() => { base.OnStartup(e); }, this);
        }
    }
    public class CustomPdfViewerLocalizer : PdfViewerLocalizer {
        public override string GetLocalizedString(PdfViewerStringId id) {
            switch(id) {
                case PdfViewerStringId.BarCaption: return "PDF VIEWER";
                default: return base.GetLocalizedString(id);
            }
        }
    }
}
#if CLICKONCE
    namespace DevExpress.Internal.DemoLauncher {
        public static class ClickOnceEntryPoint {
            public static Window CreateMainWindow() {
                ViewLocator.Default = new ViewLocator(new[] { typeof(ProductsDemo.App).Assembly });
                Application app = Application.Current;
                ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name;
                DevExpress.Images.ImagesAssemblyLoader.Load();
                PdfViewerLocalizer.Active = new ProductsDemo.CustomPdfViewerLocalizer();
                ProductsDemo.App.Start(() => { }, app);
                return new ProductsDemo.MainWindow();
            }
        }
    }
#endif
