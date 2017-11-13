Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraPrinting
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Reports
Imports DevExpress.DevAV
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class EmployeesExport
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(EmployeesReportViewModel))
            InitializeComponent()
            AddHandler ViewModel.ReportTypeChanged, AddressOf ViewModel_ReportTypeChanged
            AddHandler ViewModel.ReportEntityKeyChanged, AddressOf ViewModel_ReportEntityKeyChanged
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
            AddHandler exportSettingsControl.ExportClick, AddressOf exportSettings_Export
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            RemoveHandler ViewModel.ReportEntityKeyChanged, AddressOf ViewModel_ReportEntityKeyChanged
            RemoveHandler ViewModel.ReportTypeChanged, AddressOf ViewModel_ReportTypeChanged
            RemoveHandler exportSettingsControl.ExportClick, AddressOf exportSettings_Export
            previewControl.DocumentSource = Nothing
            MyBase.OnDisposing()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ViewModel.OnLoad()
            UpdatePreview()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As EmployeesReportViewModel
            Get
                Return GetViewModel(Of EmployeesReportViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As EmployeeCollectionViewModel
            Get
                Return GetParentViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property
        Private Function GetParameter(ByVal name As String, ByVal type As Type) As Parameter
            If report IsNot Nothing Then
                If report.Parameters(name) Is Nothing OrElse report.Parameters(name).Type <> type Then
                    Throw New Exception("Invalid report parameter.")
                End If
                Return report.Parameters(name)
            End If
            Return Nothing
        End Function
        Private ReadOnly Property ParamAscending() As Parameter
            Get
                Return GetParameter("paramAscending", GetType(Boolean))
            End Get
        End Property
        Private ReadOnly Property ParamEvaluations() As Parameter
            Get
                Return GetParameter("paramEvaluations", GetType(Boolean))
            End Get
        End Property
        Private ReadOnly Property ParamDueDate() As Parameter
            Get
                Return GetParameter("paramDueDate", GetType(Boolean))
            End Get
        End Property
        Private Sub ViewModel_ReportEntityKeyChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not(TypeOf report Is EmployeeProfile) Then
                Return
            End If
            UpdatePreview()
        End Sub
        Private Sub ViewModel_ReportTypeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdatePreview()
        End Sub
        Private Sub ViewModel_Reload(ByVal sender As Object, ByVal e As EventArgs)
            UpdatePreview()
        End Sub
        Private report As XtraReport
        Private Sub UpdatePreview()
            If ViewModel.ReportType = EmployeeReportType.None Then
                Return
            End If
            Me.report = CreateAndInitializeReport(ViewModel.ReportType)
            previewControl.DocumentSource = report
            CreateDocument(report)
            exportSettingsControl.SetSettings(GetSettingsEditor(ViewModel.ReportType))
            exportSettingsControl.ExportEnabled = False
        End Sub
        Private Function GetSettingsEditor(ByVal reportType As EmployeeReportType) As Control
            Select Case reportType
                Case EmployeeReportType.Profile
                    Return New EvaluationsControl(Sub(value) SetParameter(ParamEvaluations, value), CBool(ParamEvaluations.Value))
                Case EmployeeReportType.Directory, EmployeeReportType.Summary
                    Return New SortOrderControl(Sub(value) SetParameter(ParamAscending, value), CBool(ParamAscending.Value))
                Case EmployeeReportType.TaskList
                    Return New TasksSortControl(Sub(value) SetParameter(ParamDueDate, value), CBool(ParamDueDate.Value))
            End Select
            Return Nothing
        End Function
        Private Sub SetParameter(ByVal parameter As Parameter, ByVal value As Boolean)
            If parameter IsNot Nothing Then
                parameter.Value = value
                CreateDocument(report)
            End If
        End Sub
        Private Sub exportSettings_Export(ByVal sender As Object, ByVal e As EventArgs)
            previewControl.DocumentViewer.PrintingSystem.ExportOptions.PrintPreview.ShowOptionsBeforeExport = If(Control.ModifierKeys = Keys.Control, True, False)
            Select Case exportSettingsControl.SelectedExport
                Case ExportTarget.Pdf
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportPdf)
                Case ExportTarget.Html
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportHtm)
                Case ExportTarget.Mht
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportMht)
                Case ExportTarget.Rtf
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportRtf)
                Case ExportTarget.Xls
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportXls)
                Case ExportTarget.Xlsx
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportXlsx)
                Case ExportTarget.Csv
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportCsv)
                Case ExportTarget.Text
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportTxt)
                Case ExportTarget.Image
                    previewControl.DocumentViewer.ExecCommand(PrintingSystemCommand.ExportGraphic)
                Case Else
                    Throw New ArgumentOutOfRangeException("Export")
            End Select
        End Sub
        Private Function CreateAndInitializeReport(ByVal reportType As EmployeeReportType) As XtraReport
            Dim locator = GetService(Of Services.IReportLocator)()
            Dim report = TryCast(locator.GetReport(reportType), XtraReport)
            Select Case reportType
                Case EmployeeReportType.Profile
                    report.DataSource = New List(Of Employee) From {CollectionViewModel.SelectedEntity}
                Case EmployeeReportType.TaskList
                    report.DataSource = ViewModel.Tasks
                Case EmployeeReportType.Directory, EmployeeReportType.Summary
                    report.DataSource = CollectionViewModel.Entities
            End Select
            Return report
        End Function
        Private Sub CreateDocument(ByVal report As XtraReport)
            If report IsNot Nothing Then
                report.PrintingSystem.ClearContent()
                report.CreateDocument(True)
                RemoveHandler report.PrintingSystem.AfterBuildPages, AddressOf PrintingSystem_AfterBuildPages
                AddHandler report.PrintingSystem.AfterBuildPages, AddressOf PrintingSystem_AfterBuildPages
            End If
        End Sub
        Private Sub PrintingSystem_AfterBuildPages(ByVal sender As Object, ByVal e As EventArgs)
            exportSettingsControl.ExportEnabled = DirectCast(sender, PrintingSystemBase).PageCount > 0
            previewControl.Visible = True
        End Sub
    End Class
End Namespace
