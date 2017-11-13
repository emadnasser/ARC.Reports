Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class WorkWeekViewModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private ReadOnly Property TimeIndicatorDisplayOptions() As TimeIndicatorDisplayOptions
			Get
				Return CType(schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
			End Get
		End Property
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			PrepareViews()
			weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays
		End Sub

		Private Sub PrepareViews()
			Me.schedulerControl.DayView.Enabled = False
			Me.schedulerControl.WeekView.Enabled = False
			Me.schedulerControl.MonthView.Enabled = False
			Me.schedulerControl.TimelineView.Enabled = False
			Me.schedulerControl.AgendaView.Enabled = False
		End Sub
		Private Sub WorkWeekViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
			chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment
			cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
			cbTimeMarkerVisibility.EditValue = schedulerControl.WorkWeekView.TimeMarkerVisibility
		End Sub

		Private Sub weekDaysCheckEdit1_WeekDaysChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles weekDaysCheckEdit1.WeekDaysChanged
			Dim workDays As WorkDaysCollection = schedulerControl.WorkDays
			workDays.BeginUpdate()
			workDays.Clear()
			If weekDaysCheckEdit1.WeekDays <> CType(0, WeekDays) Then
				workDays.Add(New WeekDaysWorkDay(weekDaysCheckEdit1.WeekDays))
			End If
			workDays.EndUpdate()
		End Sub

		Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
			If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
			End If
		End Sub

		Private Sub WorkWeekViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
			schedulerControl.ActiveViewType = SchedulerViewType.WorkWeek
		End Sub

		Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowOverAppointment.CheckedChanged
			TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
		End Sub

		Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeIndicatorVisibility.SelectedIndexChanged
			TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
		End Sub

		Private Sub cbTimeMarkerVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeMarkerVisibility.SelectedIndexChanged
			schedulerControl.WorkWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
		End Sub
	End Class
End Namespace
