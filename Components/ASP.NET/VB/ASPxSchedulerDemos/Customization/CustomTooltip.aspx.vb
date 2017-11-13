Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.Web.ASPxScheduler

Partial Public Class Customization_CustomTooltip
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
'        
'			The following code utilizes the DataHelper class, which is implemented
'			solely for the ASPxScheduler Demo project.
'			It is intended to hide unnecessary details and clarify the main idea.
'			For the recommended data binding techniques, please refer to the
'			Data Binding section modules:
'			  ~/DataBinding/BoundMode.aspx for MS Access database
'			  ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'			  ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'		
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		SchedulerDemoUtils.ApplyWorkTime(Me, ASPxScheduler1)
		DevExpress.Web.ASPxWebControl.RegisterBaseScript(Page)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.DataBind()
	End Sub

	Protected Sub OnSchedulerBeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.SchedulerCallbackCommandEventArgs)
		If e.CommandId = "EnableToolTipCallback" Then
			e.Command = New EnableToolTipCallback(ASPxScheduler1)
		End If
	End Sub
End Class
Public Class EnableToolTipCallback
	Inherits SchedulerCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub
	Public Overrides Sub Execute(ByVal parameters As String)
		MyBase.Execute(parameters)
		Dim args() As String = parameters.Split(New Char() { "="c })
		If args(0) = "selection" Then
			If args(1) = "false" Then
				Control.OptionsToolTips.ShowSelectionToolTip = False
			ElseIf args(1) = "true" Then
				Control.OptionsToolTips.ShowSelectionToolTip = True
			End If
		ElseIf args(0) = "appointment" Then
			If args(1) = "false" Then
				Control.OptionsToolTips.ShowAppointmentToolTip = False
			ElseIf args(1) = "true" Then
				Control.OptionsToolTips.ShowAppointmentToolTip = True
			End If
		ElseIf args(0) = "drag" Then
			If args(1) = "false" Then
				Control.OptionsToolTips.ShowAppointmentDragToolTip = False
			ElseIf args(1) = "true" Then
				Control.OptionsToolTips.ShowAppointmentDragToolTip = True
			End If
		End If
		Control.ApplyChanges(ASPxSchedulerChangeAction.All)
	End Sub

	Public Overrides ReadOnly Property Id() As String
		Get
			Return "EnableToolTipCallback"
		End Get
	End Property

	Protected Overrides Sub ParseParameters(ByVal parameters As String)
		'do nothing
	End Sub

	Protected Overrides Sub ExecuteCore()
		'do nothing
	End Sub
End Class
