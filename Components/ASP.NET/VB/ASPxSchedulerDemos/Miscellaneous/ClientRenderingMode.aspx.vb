Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler

Partial Public Class Miscellaneous_ClientRenderingMode
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
		SchedulerDemoUtils.ApplyDefaults(Me, DemoScheduler)
		DataHelper.SetupDefaultMappings(DemoScheduler)
		DataHelper.ProvideRowInsertion(DemoScheduler, AppointmentDataSource)
		DataHelper.SetupStatuses(DemoScheduler)
		DataHelper.SetupLabels(DemoScheduler)
		If (Not IsPostBack) Then
			cbEnableClientRender.Checked = DemoScheduler.EnableClientRender
		Else
			DemoScheduler.EnableClientRender = cbEnableClientRender.Checked
		End If
		DemoScheduler.DataBind()

	End Sub
End Class
