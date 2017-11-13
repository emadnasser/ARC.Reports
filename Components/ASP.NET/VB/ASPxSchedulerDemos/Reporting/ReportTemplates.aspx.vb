Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraScheduler

Partial Public Class ReportTemplates
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
		DataHelper.SetupCustomEventsMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)

		If (Not IsPostBack) Then
			Dim interval As TimeInterval = ASPxScheduler1.ActiveView.GetVisibleIntervals().Interval
			ASPxDateEdit1.Date = interval.Start
			ASPxDateEdit2.Date = interval.End
		End If
		PrepareReportPreview(PreviewPanel)

	End Sub
	Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		PreviewPanel.Visible = True
	End Sub
	Private Sub PrepareReportPreview(ByVal cp As Control)
		ASPxSchedulerControlPrintAdapter1.TimeInterval = GetPrintTimeInterval()

		Dim reportPreview As Reporting_ReportPreview = CType(Page.LoadControl("ReportPreview.ascx"), Reporting_ReportPreview)
		reportPreview.ControlAdapter = ASPxSchedulerControlPrintAdapter1
		Dim reportName As String = ReportTemplateCombo.Text
		reportPreview.ReportTemplateFileName = "SchedulerReportTemplates\" & reportName


		ASPxSchedulerControlPrintAdapter1.EnableSmartSync = reportName.ToLower().Contains("trifold")

		cp.Controls.Clear()
		cp.Controls.Add(reportPreview)
	End Sub
	Private Function GetPrintTimeInterval() As TimeInterval
		Dim start As DateTime = ASPxDateEdit1.Date
		Dim [end] As DateTime = ASPxDateEdit2.Date
		Return If((start <= [end]), New TimeInterval(start, [end]), New TimeInterval([end], start))
	End Function

End Class
