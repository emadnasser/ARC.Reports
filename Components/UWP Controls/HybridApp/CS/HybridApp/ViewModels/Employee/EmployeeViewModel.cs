using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using HybridApp.HybridAppService;
using Windows.ApplicationModel.Email;
using Windows.System;

namespace HybridApp.ViewModels {
    public class EmployeeViewModel : SingleObjectViewModel<Employee> {
        public EmployeeViewModel() {
            HomeCallCommand = new DelegateCommand(HomeCall);
            MobileCallCommand = new DelegateCommand(MobileCall);
            MailToCommand = new DelegateCommand(MailTo);
            VideoCallCommand = new DelegateCommand(VideoCall);
            ShowMeetingCommand = new DelegateCommand(ShowMeeting);
        }
        protected override Task<bool> TrySave(bool force = false) {
            Employee entity = (Employee)Parameter;
            if(Entity != null && (string.IsNullOrWhiteSpace(Entity.FullName)
                || entity.FirstName != Entity.FirstName || entity.LastName != Entity.LastName)) {
                Entity.FullName = Entity.FirstName + " " + Entity.LastName;
            }
            return base.TrySave(force);
        }
        void VideoCall() {
            CallCommand("Video Call", Entity.Skype);
        }
        async void MailTo() {
            string emailUri = "mailto:" + Entity.Email + "?subject=" + "New E-mail" + "&body=" + "Dear " + Entity.Prefix.ToString() + ". " + Entity.FullName + " ...";
            await Launcher.LaunchUriAsync(new Uri(emailUri));
        }
        private void MobileCall() {
            CallCommand("Mobile Call", Entity.MobilePhone);
        }
        void HomeCall() {
            CallCommand("Home Call", Entity.HomePhone);
        }
        void CallCommand(string commandName, string address) {
            MessageBoxService.ShowAsync(string.Format("{0}: {1}", commandName, address));
        }
        public void ShowMeeting() {
            MessageBoxService.ShowAsync(string.Format("Schedule meeting with {0}?", Entity.FullName), "Meeting", MessageButton.YesNoCancel);
        }
        protected override Employee CreateEntity() {
            return new Employee() { Picture = new byte[] { } };
        }
        protected override void OnEntityChanged(Employee oldValue, Employee newValue) {
            base.OnEntityChanged(oldValue, newValue);
            UpdateLookUp(newValue);
        }
        void UpdateLookUp(Employee newValue) {
            if(Entity != null && !Windows.ApplicationModel.DesignMode.DesignModeEnabled) {
                EmployeeAssignedTasksLookUp = new TaskCollectionViewModel(Entity);
                (EmployeeAssignedTasksLookUp as ISupportParentViewModel).ParentViewModel = this;
                AssignedNotesLookUp = new EvaluationCollectionViewModel(Entity);
                (AssignedNotesLookUp as ISupportParentViewModel).ParentViewModel = this;
            } else {
                EmployeeAssignedTasksLookUp = null;
                AssignedNotesLookUp = null;
            }
        }
        public DelegateCommand HomeCallCommand { get; set; }
        public DelegateCommand MobileCallCommand { get; set; }
        public DelegateCommand MailToCommand { get; set; }
        public DelegateCommand VideoCallCommand { get; set; }
        public DelegateCommand ShowMeetingCommand { get; set; }
        TaskCollectionViewModel employeeAssignedTasksLookUp;
        public TaskCollectionViewModel EmployeeAssignedTasksLookUp {
            get { return employeeAssignedTasksLookUp; }
            set { SetProperty(ref employeeAssignedTasksLookUp, value); }
        }
        EvaluationCollectionViewModel assignedNotesLookUp;
        public EvaluationCollectionViewModel AssignedNotesLookUp {
            get { return assignedNotesLookUp; }
            set { SetProperty(ref assignedNotesLookUp, value); }
        }
    }
}
