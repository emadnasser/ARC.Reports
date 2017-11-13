Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar

Partial Public Class iCalendar_iCalendarExport
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

		If Request.QueryString.Count = 1 AndAlso Request.QueryString(0) = "DevExpressCalendar.ics" Then
			PostCalendarFile()
		End If
	End Sub
	Private Sub PostCalendarFile()
		Dim exporter As New iCalendarExporter(ASPxScheduler1.Storage)
		Using memoryStream As New MemoryStream()
			exporter.Export(memoryStream)
			Dim responseStream As Stream = Response.OutputStream
			memoryStream.WriteTo(responseStream)
			responseStream.Flush()
		End Using
		Response.ContentType = "text/calendar"
		Response.AddHeader("Content-Disposition", "attachment; filename=DevExpressCalendar.ics")
		Response.End()
	End Sub
	Protected Sub ASPxScheduler1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.PopupMenuShowingEventArgs)
		Dim menu As ASPxSchedulerPopupMenu = e.Menu
		If menu.MenuId.Equals(SchedulerMenuItemId.AppointmentMenu) Then
			Dim item As New DevExpress.Web.MenuItem("Export Appointment", "ExportAppointment")
			menu.Items.Insert(1, item)
			menu.ClientSideEvents.ItemClick = "function(s, e) { OnMenuClick(s,e); }"
		End If
	End Sub
	Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.SchedulerCallbackCommandEventArgs)
		If e.CommandId = "EXPORTAPT" Then
			e.Command = New ExportAppointmentCallbackCommand(CType(sender, ASPxScheduler))
		End If
	End Sub
End Class
Public Class ExportAppointmentCallbackCommand
	Inherits SchedulerCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub

	Public Overrides ReadOnly Property Id() As String
		Get
			Return "EXPORTAPT"
		End Get
	End Property
	Protected Overrides Sub ParseParameters(ByVal parameters As String)
	End Sub
	Protected Overrides Sub ExecuteCore()
		PostCalendarFile(Control.SelectedAppointments)
	End Sub
	Private Sub PostCalendarFile(ByVal appointments As AppointmentBaseCollection)
		Dim exporter As New iCalendarExporter(Control.Storage, appointments)
		If appointments.Count = 0 Then
			Return
		End If
		Using memoryStream As New MemoryStream()
			exporter.Export(memoryStream)
			Dim outputStream As Stream = Control.Page.Response.OutputStream
			memoryStream.WriteTo(outputStream)
			outputStream.Flush()
		End Using
		Control.Page.Response.ContentType = "text/calendar"
		Control.Page.Response.AddHeader("Content-Disposition", "attachment; filename=appointment.ics")
		Control.Page.Response.End()
	End Sub

End Class
