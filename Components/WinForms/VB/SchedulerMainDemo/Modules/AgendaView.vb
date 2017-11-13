Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Namespace DevExpress.XtraScheduler.Demos

	Partial Public Class AgendaViewModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
			PrepareViews()
		End Sub

		Private Sub AgendaViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage1)
			UpdateControls()
		End Sub

		Private Sub PrepareViews()
			Me.schedulerControl.AgendaView.Enabled = True
			Me.schedulerControl.FullWeekView.Enabled = False
			Me.schedulerControl.DayView.Enabled = False
			Me.schedulerControl.WeekView.Enabled = False
			Me.schedulerControl.MonthView.Enabled = False
			Me.schedulerControl.WorkWeekView.Enabled = False
			Me.schedulerControl.TimelineView.Enabled = False
			Me.schedulerControl.GanttView.Enabled = False
		End Sub

		Private Sub UpdateControls()
			Me.spinDaysCount.EditValue = schedulerControl.AgendaView.DayCount
			Me.cbStatus.EditValue = Me.schedulerControl.AgendaView.AppointmentDisplayOptions.StatusDisplayType
			Me.ceShowLabel.Checked = Me.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowLabel
			Me.ceShowResource.Checked = Me.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowResource
		End Sub

		Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinDaysCount.EditValueChanged
			schedulerControl.AgendaView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
		End Sub

		Private Sub cbStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.EditValueChanged
			If (Not GetType(AppointmentStatusDisplayType).IsAssignableFrom(Me.cbStatus.EditValue.GetType())) Then
				Return
			End If
			Me.schedulerControl.AgendaView.AppointmentDisplayOptions.StatusDisplayType = CType(Me.cbStatus.EditValue, AppointmentStatusDisplayType)
		End Sub

		Private Sub ceShowLabel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowLabel.CheckedChanged
			Me.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowLabel = Me.ceShowLabel.Checked
		End Sub

		Private Sub ceShowResource_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowResource.CheckedChanged
			Me.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowResource = Me.ceShowResource.Checked
		End Sub
	End Class

End Namespace
