using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Internal;
using DevExpress.MailClient.ViewModel;
using DevExpress.MailClient.View;
using DevExpress.Xpf.Core;
using System.Globalization;
using System.Threading;

namespace DevExpress.MailClient.Xpf {
    public partial class App : Application {
        public static void Initialize() {
            DevExpress.Images.ImagesAssemblyLoader.Load();
            ExceptionHelper.Initialize();
            ServiceContainer.Default.RegisterService(new ApplicationJumpListService());
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name;
            SetCultureInfo();
            InitModules();
        }

        protected override void OnStartup(StartupEventArgs e) {
            Initialize();
            base.OnStartup(e);
        }

        static void SetCultureInfo() {
            CultureInfo demoCI = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            demoCI.DateTimeFormat = new DateTimeFormatInfo();
            Thread.CurrentThread.CurrentCulture = demoCI;
            CultureInfo demoUI = (CultureInfo)Thread.CurrentThread.CurrentUICulture.Clone();
            demoUI.DateTimeFormat = new DateTimeFormatInfo();
            Thread.CurrentThread.CurrentUICulture = demoUI;
        }
        static void InitModules() {
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Mail,
                () => MailNavigationViewModel.Create(), typeof(NavBarMailView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Tasks,
                () => TasksNavigationViewModel.Create(), typeof(NavBarTasksView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Calendar,
                () => CalendarNavigationViewModel.Create(), typeof(NavBarCalendarView));
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Contacts,
                () => ContactsNavigationViewModel.Create(), typeof(NavBarContactsView));

            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Mail, () => MailViewModel.Create(), typeof(MailView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Tasks, () => TasksViewModel.Create(), typeof(TasksView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Calendar, () => CalendarViewModel.Create(), typeof(CalendarView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Contacts, () => ContactsViewModel.Create(), typeof(ContactsView));
        }
    }
}
#if CLICKONCE
namespace DevExpress.Internal.DemoLauncher {
    public static class ClickOnceEntryPoint {
        public static Window CreateMainWindow() {
            DevExpress.Images.ImagesAssemblyLoader.Load();
            DevExpress.MailClient.Xpf.App.Initialize();
            Application app = Application.Current;
            return new DevExpress.MailClient.View.MainWindow();
        }
    }
}
#endif
