Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler

Partial Public Class Miscellaneous_FormsVisibility
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
		SchedulerDemoUtils.ApplyWorkTime(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.DataBind()

		ApplyOptions()
	End Sub
	Private Sub ApplyOptions()
		Dim options As ASPxSchedulerOptionsForms = ASPxScheduler1.OptionsForms
		options.BeginUpdate()
		Try
			Dim value As SchedulerFormVisibility = CType(rbVisibility.Value, SchedulerFormVisibility)
			options.AppointmentFormVisibility = value
			options.GotoDateFormVisibility = value
		Finally
			options.EndUpdate()
		End Try
	End Sub
End Class
