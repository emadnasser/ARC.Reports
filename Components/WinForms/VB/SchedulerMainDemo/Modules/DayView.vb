Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class DayViewModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			PrepareViews()
			AddHandler Me.schedulerControl.MouseUp, AddressOf SchedulerControl_MouseUp
			AddHandler spinDaysCount.EditValueChanged, AddressOf spinDaysCount_EditValueChanged
			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Private Sub SchedulerControl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property
		Protected ReadOnly Property DisplayOptions() As DayViewAppointmentDisplayOptions
			Get
				Return CType(schedulerControl.DayView.AppointmentDisplayOptions, DayViewAppointmentDisplayOptions)
			End Get
		End Property
		Private ReadOnly Property TimeIndicatorDisplayOptions() As TimeIndicatorDisplayOptions
			Get
				Return CType(schedulerControl.DayView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
			End Get
		End Property
		Private Sub PrepareViews()
			Me.schedulerControl.WeekView.Enabled = False
			Me.schedulerControl.WorkWeekView.Enabled = False
			Me.schedulerControl.MonthView.Enabled = False
			Me.schedulerControl.TimelineView.Enabled = False
			Me.schedulerControl.AgendaView.Enabled = False
		End Sub
		Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
			UpdateControls()
		End Sub

		Private Sub UpdateControls()
			chkShowRightTimeRuler.Checked = True
			chkShowWorkTimeOnly.Checked = schedulerControl.DayView.ShowWorkTimeOnly
			chkShowAllDayArea.Checked = schedulerControl.DayView.ShowAllDayArea
			chkShowDayHeaders.Checked = schedulerControl.DayView.ShowDayHeaders
			chkAppointmentShadows.Checked = DisplayOptions.ShowShadows
			chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment
			spinDaysCount.EditValue = schedulerControl.DayView.DayCount

			cbAllDayStatus.EditValue = DisplayOptions.AllDayAppointmentsStatusDisplayType
			cbStatus.EditValue = DisplayOptions.StatusDisplayType
			cbSnapToCellsMode.EditValue = DisplayOptions.SnapToCellsMode
			cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
			cbTimeMarkerVisibility.EditValue = schedulerControl.DayView.TimeMarkerVisibility
		End Sub
		Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowWorkTimeOnly.CheckedChanged
			schedulerControl.DayView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
		End Sub

		Private Sub chkShowAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowAllDayArea.CheckedChanged
			schedulerControl.DayView.ShowAllDayArea = chkShowAllDayArea.Checked
		End Sub

		Private Sub chkShowDayHeaders_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowDayHeaders.CheckedChanged
			schedulerControl.DayView.ShowDayHeaders = chkShowDayHeaders.Checked
		End Sub

		Private Sub chkAppointmentShadows_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAppointmentShadows.CheckedChanged
			schedulerControl.DayView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked
		End Sub

		Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			schedulerControl.DayView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
		End Sub

		Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
			If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
			End If
		End Sub
		Private Sub DayViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
			schedulerControl.ActiveViewType = SchedulerViewType.Day
		End Sub

		Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.SelectedIndexChanged
			DisplayOptions.StatusDisplayType = CType(Me.cbStatus.EditValue, AppointmentStatusDisplayType)
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
			schedulerControl.DayView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
		End Sub

		Private Sub chkShowRightTimeRuler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowRightTimeRuler.CheckedChanged
			Dim timeRulersCount As Integer = schedulerControl.DayView.TimeRulers.Count
			For i As Integer = 0 To timeRulersCount - 1
				Dim timeRuler As TimeRuler = schedulerControl.DayView.TimeRulers(i)
				If timeRuler.HorizontalAlignment = TimeRulerHorizontalAlignment.Far Then
					timeRuler.Visible = chkShowRightTimeRuler.Checked
				End If
			Next i
		End Sub
	End Class
End Namespace

