Imports DevExpress.Spreadsheet
Imports DevExpress.DevAV.ViewModels
Imports System.Linq

Namespace DevExpress.DevAV.Modules

    Partial Public Class CustomerAnalysis
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(CustomerAnalysisViewModel))
            InitializeComponent()
            BindCommands()
            LoadTemplate()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As CustomerAnalysisViewModel
            Get
                Return GetViewModel(Of CustomerAnalysisViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As CustomerCollectionViewModel
            Get
                Return GetParentViewModel(Of CustomerCollectionViewModel)()
            End Get
        End Property
        Protected Overrides Sub OnParentViewModelAttached()
            MyBase.OnParentViewModelAttached()
            LoadAnalysisData()
        End Sub
        Private Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
        End Sub
        Private Sub LoadTemplate()
            Using stream = AnalysisTemplatesHelper.GetAnalysisTemplate(AnalysisTemplate.CustomerSales)
                spreadsheetControl.LoadDocument(stream, DocumentFormat.Xlsm)
            End Using
        End Sub
        Private Sub LoadAnalysisData()
            spreadsheetControl.Document.BeginUpdate()
            Dim salesReportWorksheet = spreadsheetControl.Document.Worksheets("Sales Report")
            Dim salesReportItems = ViewModel.GetSalesReport().ToList()
            Dim frCustomers = salesReportItems.Select(Function(i) i.CustomerName).Distinct().OrderBy(Function(i) i).ToList()
            salesReportWorksheet.Import(frCustomers, 14, 1, True)
            For Each reportItem In salesReportItems
                Dim rowOffset As Integer = frCustomers.IndexOf(reportItem.CustomerName)
                Dim columnOffset As Integer = AnalysisPeriod.MonthOffsetFromStart(reportItem.Date) \ 12
                If rowOffset < 0 OrElse columnOffset < 0 Then
                    Continue For
                End If
                salesReportWorksheet.Cells(14 + rowOffset, 3 + columnOffset * 2).SetValue(reportItem.Total)
            Next reportItem
            Dim salesDataWorksheet = spreadsheetControl.Document.Worksheets("Sales Data")
            Dim salesDataItems = ViewModel.GetSalesData().ToList()
            Dim states = salesDataItems.Select(Function(i) i.State).Distinct().OrderBy(Function(i) i).ToList()

            salesDataWorksheet.Import(ViewModel.GetStates(states), 5, 3, False)
            For Each dataItem In salesDataItems
                Dim rowOffset As Integer = AnalysisPeriod.MonthOffsetFromStart(dataItem.Date)
                Dim columnOffset As Integer = states.IndexOf(dataItem.State)
                If rowOffset < 0 OrElse columnOffset < 0 Then
                    Continue For
                End If
                salesDataWorksheet.Cells(6 + rowOffset, 3 + columnOffset).SetValue(dataItem.Total)
            Next dataItem
            spreadsheetControl.Document.Worksheets.ActiveWorksheet = salesReportWorksheet
            spreadsheetControl.Document.EndUpdate()
        End Sub
        #Region ""
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
    End Class
End Namespace
