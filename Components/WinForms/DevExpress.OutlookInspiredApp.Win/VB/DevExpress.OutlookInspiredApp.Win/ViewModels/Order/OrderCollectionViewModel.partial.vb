Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Linq.Expressions
Imports System.Linq
Imports System

Namespace DevExpress.DevAV.ViewModels

    Partial Public Class OrderCollectionViewModel
        Implements ISupportMap, ISupportCustomFilters

        Public Overrides Sub Refresh()
            MyBase.Refresh()
            RaiseReload()
        End Sub
        Protected Overrides Sub OnSelectedEntityChanged()
            MyBase.OnSelectedEntityChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowMap())
            Me.RaiseCanExecuteChanged(Sub(x) x.PrintInvoice())
            Me.RaiseCanExecuteChanged(Sub(x) x.QuickReport(SalesReportType.Invoice))
        End Sub
        Public Event Reload As EventHandler
        Public Event CustomFilter As EventHandler
        Public Event CustomFiltersReset As EventHandler Implements ISupportCustomFilters.CustomFiltersReset
        <Command>
        Public Sub ShowMap() Implements ISupportMap.ShowMap
            ShowMapCore(SelectedEntity)
        End Sub
        Public Function CanShowMap() As Boolean Implements ISupportMap.CanShowMap
            Return CanShowMapCore(SelectedEntity)
        End Function
        Protected Friend Sub ShowMapCore(ByVal order As Order)
            ShowDocument(Of OrderMapViewModel)("MapView", order.Id)
        End Sub
        Protected Friend Function CanShowMapCore(ByVal order As Order) As Boolean
            Return order IsNot Nothing
        End Function
        <Command>
        Public Sub ShowViewSettings()
            Dim dms = DirectCast(Me, DevExpress.Mvvm.ISupportServices).ServiceContainer.GetService(Of DevExpress.Mvvm.IDocumentManagerService)("View Settings")
            If dms IsNot Nothing Then
                Dim document = dms.Documents.FirstOrDefault(Function(d) TypeOf d.Content Is ViewSettingsViewModel)
                If document Is Nothing Then
                    document = dms.CreateDocument("View Settings", Nothing, Nothing, Me)
                End If
                document.Show()
            End If
        End Sub
        <Command>
        Public Sub NewCustomFilter()
            RaiseCustomFilter()
        End Sub
        <Command>
        Public Sub PrintSalesReport()
            RaisePrint(SalesReportType.SalesReport)
        End Sub
        <Command>
        Public Sub PrintSalesByStore()
            RaisePrint(SalesReportType.SalesByStore)
        End Sub
        <Command(UseCommandManager := False, CanExecuteMethodName := "CanPrint")>
        Public Sub PrintInvoice()
            RaisePrint(SalesReportType.Invoice)
        End Sub
        Public Function CanPrint() As Boolean
            Return SelectedEntity IsNot Nothing
        End Function
        <Command>
        Public Sub QuickReport(ByVal reportType As SalesReportType)
            QuickReportCore(SelectedEntity, reportType)
        End Sub
        Public Function CanQuickReport(ByVal reportType As SalesReportType) As Boolean
            Return CanQuickReportCore(SelectedEntity, reportType)
        End Function
        Protected Friend Sub QuickReportCore(ByVal order As Order, ByVal reportTemplate As SalesReportType)
            ShowDocument(Of OrderMailMergeViewModel)("MailMerge", reportTemplate)
        End Sub
        Protected Friend Function CanQuickReportCore(ByVal order As Order, ByVal reportTemplate As SalesReportType) As Boolean
            Return order IsNot Nothing
        End Function
        <Command>
        Public Sub ShowAllFolders()
            RaiseShowAllFolders()
        End Sub
        <Command>
        Public Sub ResetCustomFilters() Implements ISupportCustomFilters.ResetCustomFilters
            RaiseCustomFiltersReset()
        End Sub
        Private Sub RaisePrint(ByVal reportType As SalesReportType)
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then
                mainViewModel.RaisePrint(reportType)
            End If
        End Sub
        Private Sub RaiseShowAllFolders()
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then
                mainViewModel.RaiseShowAllFolders()
            End If
        End Sub
        Private Sub RaiseReload()
            Dim handler As EventHandler = ReloadEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomFilter()
            Dim handler As EventHandler = CustomFilterEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomFiltersReset()
            Dim handler As EventHandler = CustomFiltersResetEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub ShowDocument(Of TViewModel)(ByVal documentType As String, ByVal parameter As Object)
            Dim document = FindDocument(Of TViewModel)()
            If TypeOf parameter Is Long Then
                document = FindDocument(Of TViewModel)(DirectCast(parameter, Long))
            End If
            If document Is Nothing Then
                document = DocumentManagerService.CreateDocument(documentType, Nothing, parameter, Me)
            Else
                ViewModelHelper.EnsureViewModel(document.Content, Me, parameter)
            End If
            document.Show()
        End Sub
        Public Overrides Sub Delete(ByVal entity As Order)
            MessageBoxService.ShowMessage("To ensure data integrity, the Sales module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Sale", MessageButton.OK)
        End Sub
        Public Overrides Function GetEntities(Optional ByVal filter As Expression(Of Func(Of Order, Boolean)) = Nothing) As IQueryable(Of Order)
            Return MyBase.GetEntities(filter).ActualOrders()
        End Function
        Friend Function GetSaleAnalisysInfos() As System.Collections.Generic.IEnumerable(Of SaleAnalisysInfo)
            Return QueriesHelper.GetSaleAnalysis(CreateUnitOfWork().OrderItems)
        End Function
        Friend Function GetSaleSummaryInfos() As System.Collections.Generic.IEnumerable(Of SaleSummaryInfo)
            Return QueriesHelper.GetSaleSummaries(CreateUnitOfWork().OrderItems)
        End Function
        Friend Function GetOrderItems() As System.Collections.Generic.List(Of OrderItem)
            Return CreateUnitOfWork().OrderItems.Include(Function(x) x.Order).ToList()
        End Function
        Friend Function GetOrderItems(ByVal storeId? As Long) As System.Collections.Generic.List(Of OrderItem)
            Return CreateUnitOfWork().OrderItems.Include(Function(x) x.Order).Where(Function(x) Nullable.Equals(x.Order.StoreId, storeId)).ToList()
        End Function
    End Class
End Namespace
