Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class FullWeekViewModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			PrepareViews()
		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl1
			End Get
		End Property
		Protected ReadOnly Property DisplayOptions() As DayViewAppointmentDisplayOptions
			Get
				Return CType(schedulerControl1.FullWeekView.AppointmentDisplayOptions, DayViewAppointmentDisplayOptions)
			End Get
		End Property
		Private ReadOnly Property TimeIndicatorDisplayOptions() As TimeIndicatorDisplayOptions
			Get
				Return CType(schedulerControl1.FullWeekView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
			End Get
		End Property

		Private Sub PrepareViews()
			Me.schedulerControl1.FullWeekView.Enabled = True
			Me.schedulerControl1.DayView.Enabled = False
			Me.schedulerControl1.WeekView.Enabled = False
			Me.schedulerControl1.MonthView.Enabled = False
			Me.schedulerControl1.WorkWeekView.Enabled = False
			Me.schedulerControl1.TimelineView.Enabled = False
			Me.schedulerControl1.GanttView.Enabled = False
			Me.schedulerControl1.AgendaView.Enabled = False
		End Sub
		Private Sub FullWeekViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl1, schedulerStorage)
			chkShowWorkTimeOnly.Checked = schedulerControl1.FullWeekView.ShowWorkTimeOnly
			chkShowAllDayArea.Checked = schedulerControl1.FullWeekView.ShowAllDayArea
			chkShowDayHeaders.Checked = schedulerControl1.FullWeekView.ShowDayHeaders
			chkAppointmentShadows.Checked = DisplayOptions.ShowShadows
			chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment

			cbAllDayStatus.EditValue = DisplayOptions.AllDayAppointmentsStatusDisplayType
			cbStatus.EditValue = DisplayOptions.StatusDisplayType
			cbSnapToCellsMode.EditValue = DisplayOptions.SnapToCellsMode
			cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
			cbTimeMarkerVisibility.EditValue = schedulerControl1.FullWeekView.TimeMarkerVisibility
		End Sub

		Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowWorkTimeOnly.CheckedChanged
			schedulerControl1.FullWeekView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
		End Sub

		Private Sub chkShowAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowAllDayArea.CheckedChanged
			schedulerControl1.FullWeekView.ShowAllDayArea = chkShowAllDayArea.Checked
		End Sub

		Private Sub chkShowDayHeaders_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowDayHeaders.CheckedChanged
			schedulerControl1.FullWeekView.ShowDayHeaders = chkShowDayHeaders.Checked
		End Sub

		Private Sub chkAppointmentShadows_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAppointmentShadows.CheckedChanged
			schedulerControl1.FullWeekView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked
		End Sub

		Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl1.PopupMenuShowing
			If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
			End If
		End Sub
		Private Sub FullWeekViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
			schedulerControl1.ActiveViewType = SchedulerViewType.FullWeek
		End Sub

		Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.SelectedIndexChanged
			DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
		End Sub

		Private Sub cbAllDayStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAllDayStatus.SelectedIndexChanged
			DisplayOptions.AllDayAppointmentsStatusDisplayType = CType(cbAllDayStatus.EditValue, AppointmentStatusDisplayType)
		End Sub

		Private Sub cbSnapToCellsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSnapToCellsMode.SelectedIndexChanged
			DisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
		End Sub

		Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowOverAppointment.CheckedChanged
			TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
		End Sub

		Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeIndicatorVisibility.SelectedIndexChanged
			TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
		End Sub

		Private Sub cbTimeMarkerVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeMarkerVisibility.SelectedIndexChanged
			schedulerControl1.FullWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
		End Sub
	End Class
End Namespace
