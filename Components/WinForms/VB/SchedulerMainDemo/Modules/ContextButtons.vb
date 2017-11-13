Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class ContextButtonsModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub ContextButtonsModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
			'this.schedulerControl.AppointmentContextButtons.Add(new DeleteAppointmentContextButton());
			'this.schedulerControl.AppointmentContextButtons.Add(new OpenAppointmentContextButton());
			'this.chEditKeepInView.Checked = this.schedulerControl.OptionsAppointmentContextButtons.KeepInView;
			Me.cbContextButtonAlignment.EditValue = ContextItemAlignment.TopFar
			Me.cbContextButtonVisibility.EditValue = ContextItemVisibility.Auto
		End Sub
		Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
			If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
			End If
		End Sub
		Private Sub chEditKeepInView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chEditKeepInView.CheckedChanged
			'this.schedulerControl.OptionsAppointmentContextButtons.KeepInView = this.chEditKeepInView.Checked;
		End Sub
		Private Sub cbOpenContextButtonVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbContextButtonVisibility.SelectedIndexChanged
			'ContextItemVisibility visibility = (ContextItemVisibility)cbContextButtonVisibility.EditValue;
			'SchedulerContextItemCollection appointmentContextButtons = this.schedulerControl.AppointmentContextButtons;
			'foreach (ContextItem button in appointmentContextButtons)
			'    button.Visibility = visibility;
		End Sub
		Private Sub cbContextButtonAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbContextButtonAlignment.SelectedIndexChanged
			'ContextItemAlignment alignment = (ContextItemAlignment)cbContextButtonAlignment.EditValue;
			'SchedulerContextItemCollection appointmentContextButtons = this.schedulerControl.AppointmentContextButtons;
			'foreach (ContextItem button in appointmentContextButtons)
			'    button.Alignment = alignment;
		End Sub
	End Class
End Namespace

