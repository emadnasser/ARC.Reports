Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler
Imports DevExpress.Web.ASPxScheduler
Imports System.Threading

Partial Public Class ViewTypes_WorkWeekView
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
'        
'            The following code utilizes the DataHelper class, which is implemented
'            solely for the ASPxScheduler Demo project.
'            It is intended to hide unnecessary details and clarify the main idea.
'            For the recommended data binding techniques, please refer to the
'            Data Binding section modules:
'              ~/DataBinding/BoundMode.aspx for MS Access database
'              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'        
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ApplyWorkDays()
		ASPxScheduler1.DataBind()
	End Sub

	Private Sub ApplyWorkDays()
		Dim weekDays As WeekDays = CType(0, WeekDays)

		If chkSunday.Checked Then
			weekDays = weekDays Or WeekDays.Sunday
		End If
		If chkMonday.Checked Then
			weekDays = weekDays Or WeekDays.Monday
		End If
		If chkTuesday.Checked Then
			weekDays = weekDays Or WeekDays.Tuesday
		End If
		If chkWednesday.Checked Then
			weekDays = weekDays Or WeekDays.Wednesday
		End If
		If chkThursday.Checked Then
			weekDays = weekDays Or WeekDays.Thursday
		End If
		If chkFriday.Checked Then
			weekDays = weekDays Or WeekDays.Friday
		End If
		If chkSaturday.Checked Then
			weekDays = weekDays Or WeekDays.Saturday
		End If

		ASPxScheduler1.BeginUpdate()
		Try
			Dim workDays As WorkDaysCollection = ASPxScheduler1.WorkDays
			workDays.Clear()
			workDays.Add(weekDays)
		Finally
			ASPxScheduler1.EndUpdate()
		End Try

		ASPxScheduler1.WorkWeekView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.Value, TimeIndicatorVisibility)
		ASPxScheduler1.WorkWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.Value, TimeMarkerVisibility)
		ApplyCommonOptions()
		ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.NotifyVisibleIntervalsChanged)
	End Sub

	Private Sub ApplyCommonOptions()
		ASPxScheduler1.OptionsBehavior.HighlightSelectionHeaders = HighlightSelectionCheckBox.Checked
		ASPxScheduler1.OptionsView.AppointmentSelectionAppearanceMode = CType(SelectionAppearanceModeComboBox.Value, AppointmentSelectionAppearanceMode)
		ASPxScheduler1.OptionsBehavior.ShowViewNavigator = ShowViewNavigatorCheckBox.Checked
		ASPxScheduler1.OptionsBehavior.ShowViewVisibleInterval = ShowViewVisibleIntervalCheckBox.Checked
	End Sub
End Class
