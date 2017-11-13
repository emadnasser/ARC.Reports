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

    Partial Public Class OrdersPrint
        Inherits BaseModuleControl

        Private report As XtraReport
        Public Sub New()
            MyBase.New(GetType(OrdersReportViewModel))
            InitializeComponent()
            AddHandler ViewModel.ReportTypeChanged, AddressOf ViewModel_ReportTypeChanged
            AddHandler ViewModel.ReportEntityKeyChanged, AddressOf ViewModel_ReportEntityKeyChanged
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
            printSettingsControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            RemoveHandler ViewModel.ReportEntityKeyChanged, AddressOf ViewModel_ReportEntityKeyChanged
            RemoveHandler ViewModel.ReportTypeChanged, AddressOf ViewModel_ReportTypeChanged
            previewControl.DocumentSource = Nothing
            report = Nothing
            ReleaseModuleReports(Of SalesReportType)()
            MyBase.OnDisposing()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ViewModel.OnLoad()
            UpdatePreview()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As OrdersReportViewModel
            Get
                Return GetViewModel(Of OrdersReportViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As OrderCollectionViewModel
            Get
                Return GetParentViewModel(Of OrderCollectionViewModel)()
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
        Private ReadOnly Property ParamYears() As Parameter
            Get
                Return GetParameter("paramYears", GetType(String))
            End Get
        End Property
        Private ReadOnly Property ParamOrderDate() As Parameter
            Get
                Return GetParameter("paramOrderDate", GetType(Boolean))
            End Get
        End Property
        Private ReadOnly Property ParamFromDate() As Parameter
            Get
                Return GetParameter("paramFromDate", GetType(Date))
            End Get
        End Property
        Private ReadOnly Property ParamToDate() As Parameter
            Get
                Return GetParameter("paramToDate", GetType(Date))
            End Get
        End Property
        Private Sub ViewModel_ReportEntityKeyChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not(TypeOf report Is SalesInvoice) Then
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
        Private Sub UpdatePreview()
            If ViewModel.ReportType = SalesReportType.None Then
                Return
            End If
            Me.report = CreateAndInitializeReport(ViewModel.ReportType)
            previewControl.DocumentSource = report
            CreateDocument(report)
            printSettingsControl.SetSettings(GetSettingsEditor(ViewModel.ReportType))
            printSettingsControl.PrintEnabled = False
        End Sub
        Private Function GetSettingsEditor(ByVal reportType As SalesReportType) As Control
            Select Case reportType
                Case SalesReportType.Invoice
                    Return New SortOrderControl(Sub(value) SetParameter(ParamAscending, value), CBool(ParamAscending.Value))
                Case SalesReportType.SalesReport
                    Return New SortFilterControl(Sub(value) SetParameter(ParamOrderDate, value), CBool(ParamOrderDate.Value), Sub(fromDate) SetParameter(ParamFromDate, fromDate), CDate(ParamFromDate.Value), Sub(toDate) SetParameter(ParamToDate, toDate), CDate(ParamToDate.Value))
                Case SalesReportType.SalesByStore
                    Return New YearsControl(Sub(value) SetParameter(ParamYears, value), CStr(ParamYears.Value))
            End Select
            Return Nothing
        End Function
        Private Sub SetParameter(ByVal parameter As Parameter, ByVal value As Object)
            If parameter IsNot Nothing Then
                parameter.Value = value
                CreateDocument(report)
            End If
        End Sub
        Private Function CreateAndInitializeReport(ByVal reportType As SalesReportType) As XtraReport
            Dim locator = GetService(Of Services.IReportLocator)()
            Dim report = TryCast(locator.GetReport(reportType), XtraReport)
            Select Case reportType
                Case SalesReportType.Invoice
                    report.DataSource = New List(Of Order) From {CollectionViewModel.SelectedEntity}
                Case SalesReportType.SalesReport
                    report.DataSource = CollectionViewModel.GetSaleSummaryInfos()
                Case SalesReportType.SalesByStore
                    report.DataSource = CollectionViewModel.GetSaleAnalisysInfos()
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
            printSettingsControl.PrintEnabled = DirectCast(sender, PrintingSystemBase).PageCount > 0
            previewControl.Visible = True
        End Sub
        Private Sub settingsControl_PrintClick(ByVal sender As Object, ByVal e As EventArgs) Handles printSettingsControl.PrintClick
            Using tool As New ReportPrintTool(report)
                tool.Print(printSettingsControl.SelectedPrinterName)
            End Using
        End Sub
        Private Sub settingsControl_PrintOptionsClick(ByVal sender As Object, ByVal e As EventArgs) Handles printSettingsControl.PrintOptionsClick
            Using tool As New ReportPrintTool(report)
             tool.PrintDialog(FindForm(), LookAndFeel)
            End Using
        End Sub
    End Class
End Namespace
