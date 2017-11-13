Imports Microsoft.VisualBasic
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class ViewTypes_FullWeekView
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
			Dim fullWeekView As DevExpress.Web.ASPxScheduler.FullWeekView = ASPxScheduler1.FullWeekView
			fullWeekView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
			fullWeekView.ShowAllDayArea = chkShowAllDayArea.Checked
			fullWeekView.ShowDayHeaders = chkShowDayHeaders.Checked
			fullWeekView.AppointmentDisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.Value, AppointmentSnapToCellsMode)
			fullWeekView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.Value, TimeIndicatorVisibility)
			fullWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.Value, TimeMarkerVisibility)
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
