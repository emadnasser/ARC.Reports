Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler
Imports DevExpress.Web
Imports System.Globalization
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services.Implementation

Partial Public Class Reporting_DateFormatting
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As New DateFormattingReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter
		report.SchedulerAdapter.TimeInterval = New TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddMonths(1))
		ReportViewer.Report = report

		InitializeControlValues()
		UpdateFormatServices(CType(report.SchedulerAdapter, SchedulerStorageBasePrintAdapter))
	End Sub
	Private Sub InitializeControlValues()
		If (Not IsPostBack) Then
			PopulateFormatCombo(cbHorzAptStart)
			PopulateFormatCombo(cbHorzAptStart)
			PopulateFormatCombo(cbHorzAptEnd)
			PopulateFormatCombo(cbVertAptStart)
			PopulateFormatCombo(cbVertAptEnd)
			PopulateFormatCombo(cbHeaderCaptions)
		End If
	End Sub
	Private Sub PopulateFormatCombo(ByVal comboBox As ASPxComboBox)
		comboBox.ValueType = GetType(String)
		comboBox.Items.Add("Default")
		comboBox.Items.AddRange(DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns())
		comboBox.SelectedIndex = 0
	End Sub
	Private Sub UpdateFormatServices(ByVal adapter As SchedulerStorageBasePrintAdapter)
		adapter.RemoveService(GetType(IHeaderCaptionService))
		Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService(cbHeaderCaptions.Text)
		adapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)

		adapter.RemoveService(GetType(IAppointmentFormatStringService))
		Dim customAptFormatService As New CustomAppointmentFormatStringService()
		customAptFormatService.HorizontalAppointmentStart = cbHorzAptStart.Text
		customAptFormatService.HorizontalAppointmentEnd = cbHorzAptEnd.Text
		customAptFormatService.VerticalAppointmentStart = cbVertAptStart.Text
		customAptFormatService.VerticalAppointmentEnd = cbVertAptEnd.Text
		adapter.AddService(GetType(IAppointmentFormatStringService), customAptFormatService)
	End Sub
End Class
Public Class CustomHeaderCaptionService
	Inherits HeaderCaptionServiceWrapper
	Private format As String
	Public Sub New(ByVal format As String)
		MyBase.New(New HeaderCaptionService())
		Me.format = format
	End Sub
	Protected Overridable Function CreateFormat(ByVal format As String) As String
		If format = "Default" Then
			Return String.Empty
		End If
		Return String.Format("{{0:{0}}}", format)
	End Function
	Public Overrides Function GetDayColumnHeaderCaption(ByVal header As DayHeader) As String
		Return CreateFormat(format)
	End Function
End Class
Public Class CustomAppointmentFormatStringService
	Inherits AppointmentFormatStringServiceWrapper
	Private horizontalAppointmentStart_Renamed As String
	Private horizontalAppointmentEnd_Renamed As String
	Private verticalAppointmentStart_Renamed As String
	Private verticalAppointmentEnd_Renamed As String

	Public Sub New()
		MyBase.New(New AppointmentFormatStringService())
	End Sub
	Public Property HorizontalAppointmentStart() As String
		Get
			Return horizontalAppointmentStart_Renamed
		End Get
		Set(ByVal value As String)
			horizontalAppointmentStart_Renamed = value
		End Set
	End Property
	Public Property HorizontalAppointmentEnd() As String
		Get
			Return horizontalAppointmentEnd_Renamed
		End Get
		Set(ByVal value As String)
			horizontalAppointmentEnd_Renamed = value
		End Set
	End Property
	Public Property VerticalAppointmentStart() As String
		Get
			Return verticalAppointmentStart_Renamed
		End Get
		Set(ByVal value As String)
			verticalAppointmentStart_Renamed = value
		End Set
	End Property
	Public Property VerticalAppointmentEnd() As String
		Get
			Return verticalAppointmentEnd_Renamed
		End Get
		Set(ByVal value As String)
			verticalAppointmentEnd_Renamed = value
		End Set
	End Property

	Protected Overridable Function CreateFormat(ByVal format As String) As String
		If format = "Default" Then
			Return String.Empty
		End If
		Return String.Format("{{0:{0}}} ", format)
	End Function
	Public Overrides Function GetHorizontalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
		Return CreateFormat(horizontalAppointmentStart_Renamed)
	End Function
	Public Overrides Function GetHorizontalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
		Return CreateFormat(horizontalAppointmentEnd_Renamed)
	End Function
	Public Overrides Function GetVerticalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
		Return CreateFormat(verticalAppointmentStart_Renamed)
	End Function
	Public Overrides Function GetVerticalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
		Return CreateFormat(verticalAppointmentEnd_Renamed)
	End Function
	Public Overrides Function GetContinueItemStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
		Return MyBase.GetContinueItemStartFormat(aptViewInfo)
	End Function
	Public Overrides Function GetContinueItemEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
		Return MyBase.GetContinueItemEndFormat(aptViewInfo)
	End Function
End Class

