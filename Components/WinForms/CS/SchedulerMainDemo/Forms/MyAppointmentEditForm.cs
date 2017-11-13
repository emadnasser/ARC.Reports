using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler.UI;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
// ...

namespace DevExpress.XtraScheduler.Demos {
	public partial class MyAppointmentEditForm : DevExpress.XtraEditors.XtraForm {
		SchedulerControl control;
		Appointment apt;
		bool openRecurrenceForm = false;
		int suspendUpdateCount;
        IDXMenuManager menuManager;
		private DevExpress.XtraEditors.CheckEdit checkAllDay;
		// Note that the MyAppointmentFormController class is inherited from
		// the AppointmentFormController one to add custom properties.
		// See its declaration at the end of this file.
		MyAppointmentFormController controller;

		public MyAppointmentEditForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) {
			this.openRecurrenceForm = openRecurrenceForm;
			this.controller = new MyAppointmentFormController(control, apt);
			this.apt = apt;
			this.control = control;
			//
			// Required for Windows Form Designer support
			//
			SuspendUpdate();
			InitializeComponent();
			ResumeUpdate();

			UpdateForm();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		protected IAppointmentStorage Appointments { get { return control.DataStorage.Appointments; } }
        protected internal bool IsNewAppointment { get { return controller != null ? controller.IsNewAppointment : true; } }
		protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }
        public IDXMenuManager MenuManager { get { return menuManager; } }

		protected void SuspendUpdate() {
			suspendUpdateCount++;
		}
		protected void ResumeUpdate() {
			if (suspendUpdateCount > 0)
				suspendUpdateCount--;
		}

        public void SetMenuManager(IDXMenuManager menuManager) {
            SetMenuManagerCore(Controls, menuManager);
            this.menuManager = menuManager;
        }
        void SetMenuManagerCore(Control.ControlCollection controls, IDXMenuManager menuManager) {
            int count = controls.Count;
            for (int i = 0; i < count; i++) {
                Control control = controls[i];
                SetMenuManagerCore(control.Controls, menuManager);
                BaseEdit baseEdit = control as BaseEdit;
                if (baseEdit == null)
                    continue;
                baseEdit.MenuManager = menuManager;
            }
        }
		private void btnAddRec_Click(object sender, System.EventArgs e) {
			OnRecurrenceButton();
		}

		void OnRecurrenceButton() {
			ShowRecurrenceForm();
		}

		void ShowRecurrenceForm() {
			if (!control.SupportsRecurrence)
				return;

			// Prepare to edit appointment's recurrence.
			Appointment editedAptCopy = controller.EditedAppointmentCopy;
			Appointment editedPattern = controller.EditedPattern;
			Appointment patternCopy = controller.PrepareToRecurrenceEdit();

			AppointmentRecurrenceForm dlg = new AppointmentRecurrenceForm(patternCopy, control.OptionsView.FirstDayOfWeek, controller);
            dlg.SetMenuManager(MenuManager);
			// Required for skins support.
			dlg.LookAndFeel.ParentLookAndFeel = this.LookAndFeel.ParentLookAndFeel;
            dlg.ShowExceptionsRemoveMsgBox = controller.AreExceptionsPresent();

			DialogResult result = dlg.ShowDialog(this);
			dlg.Dispose();

			if (result == DialogResult.Abort)
				controller.RemoveRecurrence();
			else
				if (result == DialogResult.OK) {
					controller.ApplyRecurrence(patternCopy);
					if (controller.EditedAppointmentCopy != editedAptCopy)
						UpdateForm();
				}
			UpdateIntervalControls();
		}

		private void btnOK_Click(object sender, System.EventArgs e) {
			// Required to check appointment's conflicts.
			if (!controller.IsConflictResolved())
				return;

			controller.Subject = txSubject.Text;
			controller.SetStatus(edStatus.AppointmentStatus);
			controller.SetLabel(edLabel.AppointmentLabel);
			controller.AllDay = this.checkAllDay.Checked;
			controller.DisplayStart = this.dtStart.DateTime.Date + this.timeStart.Time.TimeOfDay;
			controller.DisplayEnd = this.dtEnd.DateTime.Date + this.timeEnd.Time.TimeOfDay;
			controller.CustomName = txCustomName.Text;
			controller.CustomStatus = txCustomStatus.Text;

			// Save all changes made to the appointment edited in a form.
			controller.ApplyChanges();
		}

		void UpdateForm() {
			SuspendUpdate();
			try {
				txSubject.Text = controller.Subject;

                IAppointmentStorage appointments = Appointments;
                edStatus.AppointmentStatus = appointments.Statuses.GetById(controller.StatusKey);
                edLabel.AppointmentLabel = appointments.Labels.GetById(controller.LabelKey);

                dtStart.DateTime = controller.DisplayStart.Date;
				dtEnd.DateTime = controller.DisplayEnd.Date;

				timeStart.Time = DateTime.MinValue.AddTicks(controller.Start.TimeOfDay.Ticks);
				timeEnd.Time = DateTime.MinValue.AddTicks(controller.End.TimeOfDay.Ticks);
				checkAllDay.Checked = controller.AllDay;

				edStatus.Storage = control.DataStorage;
				edLabel.Storage = control.DataStorage;

				txCustomName.Text = controller.CustomName;
				txCustomStatus.Text = controller.CustomStatus;
            } finally {
				ResumeUpdate();
			}
			UpdateIntervalControls();
		}

		private void MyAppointmentEditForm_Activated(object sender, System.EventArgs e) {
			// Required to show the recurrence form.
			if (openRecurrenceForm) {
				openRecurrenceForm = false;
				OnRecurrenceButton();
			}
		}

		private void dtStart_EditValueChanged(object sender, System.EventArgs e) {
			if (!IsUpdateSuspended)
				controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
			UpdateIntervalControls();
		}
		protected virtual void UpdateIntervalControls() {
			if (IsUpdateSuspended)
				return;

			SuspendUpdate();
			try {
				dtStart.EditValue = controller.DisplayStart.Date;
				dtEnd.EditValue = controller.DisplayEnd.Date;
				timeStart.EditValue = controller.DisplayStart.TimeOfDay;
				timeEnd.EditValue = controller.DisplayEnd.TimeOfDay;

                Appointment editedAptCopy = controller.EditedAppointmentCopy;
                bool showControls = IsNewAppointment || !editedAptCopy.Type.Equals(AppointmentType.Pattern);
                dtStart.Enabled = showControls;
                dtEnd.Enabled = showControls;
                bool enableTime = showControls && !controller.AllDay;
                timeStart.Visible = enableTime;
                timeStart.Enabled = enableTime;
                timeEnd.Visible = enableTime;
                timeEnd.Enabled = enableTime;
                checkAllDay.Enabled = showControls;
            } finally {
				ResumeUpdate();
			}
		}
		private void timeStart_EditValueChanged(object sender, System.EventArgs e) {
			if (!IsUpdateSuspended)
				controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
			UpdateIntervalControls();
		}
		private void timeEnd_EditValueChanged(object sender, System.EventArgs e) {
            if (IsUpdateSuspended)
                return;
			if (IsIntervalValid())
				controller.DisplayEnd = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			else
				timeEnd.EditValue = controller.End.TimeOfDay;
		}
		private void dtEnd_EditValueChanged(object sender, System.EventArgs e) {
            if (IsUpdateSuspended)
                return;
			if (IsIntervalValid())
				controller.DisplayEnd = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			else
				dtEnd.EditValue = controller.DisplayEnd.Date;
		}
		bool IsIntervalValid() {
			DateTime start = dtStart.DateTime + timeStart.Time.TimeOfDay;
			DateTime end = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			return end >= start;
		}

		private void checkAllDay_CheckedChanged(object sender, System.EventArgs e) {
			controller.AllDay = this.checkAllDay.Checked;
			if (!IsUpdateSuspended)
				UpdateAppointmentStatus();

			UpdateIntervalControls();
		}
		void UpdateAppointmentStatus() {
			IAppointmentStatus currentStatus = edStatus.AppointmentStatus;
			IAppointmentStatus newStatus = controller.UpdateStatus(currentStatus);
			if (newStatus != currentStatus)
				edStatus.AppointmentStatus = newStatus;
		}
	}
	public class MyAppointmentFormController : AppointmentFormController {

		public string CustomName { get { return (string)EditedAppointmentCopy.CustomFields["CustomName"]; } set { EditedAppointmentCopy.CustomFields["CustomName"] = value; } }
		public string CustomStatus { get { return (string)EditedAppointmentCopy.CustomFields["CustomStatus"]; } set { EditedAppointmentCopy.CustomFields["CustomStatus"] = value; } }

		string SourceCustomName { get { return (string)SourceAppointment.CustomFields["CustomName"]; } set { SourceAppointment.CustomFields["CustomName"] = value; } }
		string SourceCustomStatus { get { return (string)SourceAppointment.CustomFields["CustomStatus"]; } set { SourceAppointment.CustomFields["CustomStatus"] = value; } }

		public MyAppointmentFormController(SchedulerControl control, Appointment apt)
			: base(control, apt) {
		}

		public override bool IsAppointmentChanged() {
			if (base.IsAppointmentChanged())
				return true;
			return SourceCustomName != CustomName ||
				SourceCustomStatus != CustomStatus;
		}

		protected override void ApplyCustomFieldsValues() {
			SourceCustomName = CustomName;
			SourceCustomStatus = CustomStatus;
		}
	}
}
