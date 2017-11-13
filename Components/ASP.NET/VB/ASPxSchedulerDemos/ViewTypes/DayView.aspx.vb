Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler
Imports Microsoft.AspNet.EntityDataSource

Partial Public Class ViewTypes_DayView
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
		ApplyOptions()
		ASPxScheduler1.DataBind()
	End Sub

	Private Sub ApplyOptions()
		ASPxScheduler1.BeginUpdate()
		Try
			Dim dayView As DevExpress.Web.ASPxScheduler.DayView = ASPxScheduler1.DayView
			dayView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
			dayView.ShowAllDayArea = chkShowAllDayArea.Checked
			dayView.ShowDayHeaders = chkShowDayHeaders.Checked
			dayView.AppointmentDisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.Value, AppointmentSnapToCellsMode)
			dayView.DayCount = CInt(Fix(cbDayCount.SelectedIndex)) + 1
			dayView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.Value, TimeIndicatorVisibility)
			dayView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.Value, TimeMarkerVisibility)
		Finally
			ASPxScheduler1.EndUpdate()
		End Try
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
