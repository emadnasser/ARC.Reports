using DevExpress.MailClient.Helpers;
using DevExpress.Mvvm.POCO;

namespace DevExpress.MailClient.ViewModel {
    public class CalendarNavigationViewModel : NavigationViewModelBase {
        public static CalendarNavigationViewModel Create() {
            return ViewModelSource.Create(() => new CalendarNavigationViewModel());
        }

        protected CalendarNavigationViewModel() : base(ModuleType.Calendar) { }

        protected override void Initialize() {
            Header = "Calendar";
            Icon = FilePathHelper.GetDXImageUri("Scheduling/Today_32x32");
        }
    }
}
