Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Linq
Imports DevExpress.Web.Demos
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Partial Public Class Customization_ResourceHeaderLayout
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, DemoScheduler)
		SchedulerDemoUtils.ApplyWorkTime(Me, DemoScheduler)
		DataHelper.SetupDefaultMappings(DemoScheduler, True)
		DataHelper.ProvideRowInsertion(DemoScheduler, AppointmentDataSource)
		DataHelper.SetupStatuses(DemoScheduler)
		DataHelper.SetupLabels(DemoScheduler)
		If (Not IsPostBack) Then
			cbRotateCaption.Checked = DemoScheduler.OptionsView.ResourceHeaders.RotateCaption
			cbShowCaption.Checked = DemoScheduler.OptionsView.ResourceHeaders.ShowCaption
			cbResourceColorFillArea.Value = CInt(Fix(DemoScheduler.OptionsView.ResourceColorFillArea))
			cbImageAlign.Value = CInt(Fix(DemoScheduler.OptionsView.ResourceHeaders.ImageAlign))
		Else
			DemoScheduler.OptionsView.ResourceHeaders.RotateCaption = cbRotateCaption.Checked
			DemoScheduler.OptionsView.ResourceHeaders.ShowCaption = cbShowCaption.Checked
			DemoScheduler.OptionsView.ResourceHeaders.ImageAlign = CType(CInt(Fix(cbImageAlign.Value)), HeaderImageAlign)
			DemoScheduler.OptionsView.ResourceColorFillArea = CType(CInt(Fix(cbResourceColorFillArea.Value)), ResourceColorFillArea)
		End If
		DemoScheduler.DataBind()
	End Sub
End Class
