Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.Web
Imports DevExpress.XtraScheduler.iCalendar

Partial Public Class iCalendar_iCalendarImport
	Inherits System.Web.UI.Page
	#Region "Page_Load"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
'        
'                The following code utilizes the DataHelper class, which is implemented
'                solely for the ASPxScheduler Demo project.
'                It is intended to hide unnecessary details and clarify the main idea.
'                For the recommended data binding techniques, please refer to the
'                Data Binding section modules:
'                  ~/DataBinding/BoundMode.aspx for MS Access database
'                  ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'                  ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'        
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		DataHelper.SetupCustomEventsMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)

	End Sub
	#End Region
	Protected Sub ASPxUploadControl1_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
		Dim uploadControl As ASPxUploadControl = CType(sender, ASPxUploadControl)
		Dim uploadedFile As UploadedFile = uploadControl.UploadedFiles(0)
		If (Not IsFileNameCorrect(uploadedFile.FileName)) Then
			e.IsValid = False
			e.ErrorText = "Incorrect file type"
			Return
		End If
		If uploadedFile.IsValid Then
			Session("UploadedFile") = GetBytes(uploadedFile.FileContent)
		End If
	End Sub
	Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
		If e.CommandId = ImportAppointmentsCallbackCommand.CommandId Then
			e.Command = New ImportAppointmentsCallbackCommand(CType(sender, ASPxScheduler))
		End If
	End Sub
	#Region "IsFileNameCorrect"
	Private Function IsFileNameCorrect(ByVal fileName As String) As Boolean
		Dim length As Integer = fileName.Length
		Return fileName.Substring(length - 4, 4) = ".ics"
	End Function
	#End Region
	#Region "GetBytes"
	Private Function GetBytes(ByVal stream As Stream) As Byte()
		stream.Position = 0
		Dim buf(stream.Length - 1) As Byte
		stream.Read(buf, 0, CInt(Fix(stream.Length)))
		Return buf
	End Function
	#End Region

	#Region "ImportAppointmentsCallbackCommand"
	Private Class ImportAppointmentsCallbackCommand
		Inherits SchedulerCallbackCommand
		Public Const CommandId As String = "IMPRTAPT"

		Public Sub New(ByVal control As ASPxScheduler)
			MyBase.New(control)
		End Sub

		Public Overrides ReadOnly Property Id() As String
			Get
				Return CommandId
			End Get
		End Property

		Protected Overrides Sub ParseParameters(ByVal parameters As String)
			' do nothing
		End Sub
		Protected Overrides Sub ExecuteCore()
			Using stream As Stream = GetStream()
				If stream Is Nothing Then
					Return
				End If
				Dim page As iCalendar_iCalendarImport = TryCast(Control.Page, iCalendar_iCalendarImport)
				If page IsNot Nothing AndAlso page.ASPxCheckBox1.Checked Then
					Control.Storage.Appointments.Clear()
				End If
				Dim importer As New iCalendarImporter(Control.Storage)
				importer.Import(stream)
				Control.Page.Session("UploadedFile") = Nothing
			End Using
		End Sub
		Private Function GetStream() As Stream
			Dim buf() As Byte = TryCast(Control.Page.Session("UploadedFile"), Byte())
			If buf Is Nothing Then
				Return Nothing
			End If
			Dim stream As Stream = New MemoryStream(buf)
			Return stream
		End Function
	End Class
	#End Region
End Class
