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

    Partial Public Class ProductsPrint
        Inherits BaseModuleControl

        Private report As XtraReport
        Public Sub New()
            MyBase.New(GetType(ProductsReportViewModel))
            InitializeComponent()
            AddHandler ViewModel.ReportTypeChanged, AddressOf ViewModel_ReportTypeChanged
            AddHandler ViewModel.ReportEntityKeyChanged, AddressOf ViewModel_ReportEntityKeyChanged
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
            printControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.ReportTypeChanged, AddressOf ViewModel_ReportTypeChanged
            RemoveHandler ViewModel.ReportEntityKeyChanged, AddressOf ViewModel_ReportEntityKeyChanged
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            previewControl.DocumentSource = Nothing
            report = Nothing
            ReleaseModuleReports(Of ProductReportType)()
            MyBase.OnDisposing()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ViewModel.OnLoad()
            UpdatePreview()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As ProductsReportViewModel
            Get
                Return GetViewModel(Of ProductsReportViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As ProductCollectionViewModel
            Get
                Return GetParentViewModel(Of ProductCollectionViewModel)()
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
        Private ReadOnly Property ParamImages() As Parameter
            Get
                Return GetParameter("paramImages", GetType(Boolean))
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
        Private ReadOnly Property ParamAscending() As Parameter
            Get
                Return GetParameter("paramAscending", GetType(Boolean))
            End Get
        End Property
        Private Sub ViewModel_ReportEntityKeyChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdatePreview()
        End Sub
        Private Sub ViewModel_Reload(ByVal sender As Object, ByVal e As EventArgs)
            UpdatePreview()
        End Sub
        Private Sub ViewModel_ReportTypeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdatePreview()
        End Sub
        Private Sub UpdatePreview()
            If ViewModel.ReportType = ProductReportType.None Then
                Return
            End If
            Me.report = CreateAndInitializeReport(ViewModel.ReportType)
            previewControl.DocumentSource = report
            CreateDocument(report)
            printControl.SetSettings(GetSettingsEditor(ViewModel.ReportType))
            printControl.PrintEnabled = False
        End Sub
        Private Function GetSettingsEditor(ByVal reportType As ProductReportType) As Control
            Select Case reportType
                Case ProductReportType.SpecificationSummary
                    Return New ImagesControl(Sub(value) SetParameter(ParamImages, value), CBool(ParamImages.Value))
                Case ProductReportType.SalesSummary
                    Return New YearsControl(Sub(value) SetParameter(ParamYears, value), CStr(ParamYears.Value))
                Case ProductReportType.TopSalesperson
                    Return New SortOrderControl(Sub(value) SetParameter(ParamAscending, value), CBool(ParamAscending.Value))
                Case ProductReportType.OrderDetail
                    Return New SortFilterControl(Sub(value) SetParameter(ParamOrderDate, value), CBool(ParamOrderDate.Value), Sub(fromDate) SetParameter(ParamFromDate, fromDate), CDate(ParamFromDate.Value), Sub(toDate) SetParameter(ParamToDate, toDate), CDate(ParamToDate.Value))
            End Select
            Return Nothing
        End Function
        Private Sub SetParameter(ByVal parameter As Parameter, ByVal value As Object)
            If parameter IsNot Nothing Then
                parameter.Value = value
                CreateDocument(report)
            End If
        End Sub
        Private Function CreateAndInitializeReport(ByVal reportType As ProductReportType) As XtraReport
            Dim locator = GetService(Of Services.IReportLocator)()
            Dim report = TryCast(locator.GetReport(reportType), XtraReport)
            Select Case reportType
                Case ProductReportType.SpecificationSummary
                    report.DataSource = New List(Of Product) From {CollectionViewModel.SelectedEntity}
                Case ProductReportType.SalesSummary, ProductReportType.TopSalesperson
                    report.DataSource = ViewModel.GetOrderItems(CLng(CollectionViewModel.SelectedEntityKey))
                Case ProductReportType.OrderDetail
                    report.DataSource = ViewModel.GetOrderItems(CLng(CollectionViewModel.SelectedEntityKey))
                    TryCast(report, ProductOrders).SetStates(ViewModel.GetStates())
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
            printControl.PrintEnabled = DirectCast(sender, PrintingSystemBase).PageCount > 0
        End Sub
        Private Sub settingsControl_PrintClick(ByVal sender As Object, ByVal e As EventArgs) Handles printControl.PrintClick
            Using tool As New ReportPrintTool(report)
                tool.Print(printControl.SelectedPrinterName)
            End Using
        End Sub
        Private Sub settingsControl_PrintOptionsClick(ByVal sender As Object, ByVal e As EventArgs) Handles printControl.PrintOptionsClick
            Using tool As New ReportPrintTool(report)
                tool.PrintDialog(FindForm(), LookAndFeel)
            End Using
        End Sub
    End Class
End Namespace
