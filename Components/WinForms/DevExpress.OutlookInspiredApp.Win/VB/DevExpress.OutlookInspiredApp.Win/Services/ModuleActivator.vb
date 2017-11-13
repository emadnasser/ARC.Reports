Imports DevExpress.DevAV.ViewModels
Imports System.Reflection
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.Services

    Public Interface IModuleActivator
        Function CreateModule(ByVal moduleTypeName As String) As Object
        Function CreateModule(ByVal moduleTypeName As String, ByVal viewModel As Object) As Object
    End Interface
    Friend Class ModuleActivator
        Implements IModuleActivator

        Private moduleAssembly As System.Reflection.Assembly
        Private rootNamespace As String
        Public Sub New(ByVal moduleAssembly As System.Reflection.Assembly, ByVal rootNamespace As String)
            Me.moduleAssembly = moduleAssembly
            Me.rootNamespace = rootNamespace
        End Sub
        Public Function CreateModule(ByVal moduleTypeName As String) As Object Implements IModuleActivator.CreateModule
            Dim moduleType As Type = moduleAssembly.GetType(rootNamespace & "."c & moduleTypeName)
            Return Activator.CreateInstance(moduleType)
        End Function
        Public Function CreateModule(ByVal moduleTypeName As String, ByVal viewModel As Object) As Object Implements IModuleActivator.CreateModule
            Dim moduleType As Type = moduleAssembly.GetType(rootNamespace & "."c & moduleTypeName)
            Return Activator.CreateInstance(moduleType, New Object() { viewModel })
        End Function
    End Class
    Public Interface IReportActivator
        Function CreateReport(ByVal reportKey As Object) As Object
    End Interface
    Friend Class ReportActivator
        Implements IReportActivator

        Private reportTypes As IDictionary(Of Object, Type)

        Public Sub New()
            Me.reportTypes = New Dictionary(Of Object, Type)()
            reportTypes.Add(EmployeeReportType.Directory, GetType(DevExpress.DevAV.Reports.EmployeeDirectory))
            reportTypes.Add(EmployeeReportType.Profile, GetType(DevExpress.DevAV.Reports.EmployeeProfile))
            reportTypes.Add(EmployeeReportType.Summary, GetType(DevExpress.DevAV.Reports.EmployeeSummary))
            reportTypes.Add(EmployeeReportType.TaskList, GetType(DevExpress.DevAV.Reports.EmployeeTaskList))

            reportTypes.Add(CustomerReportType.Profile, GetType(DevExpress.DevAV.Reports.CustomerProfile))
            reportTypes.Add(CustomerReportType.SelectedContactDirectory, GetType(DevExpress.DevAV.Reports.CustomerContactsDirectory))
            reportTypes.Add(CustomerReportType.ContactDirectory, GetType(DevExpress.DevAV.Reports.CustomerContactsDirectory))
            reportTypes.Add(CustomerReportType.LocationsDirectory, GetType(DevExpress.DevAV.Reports.CustomerLocationsDirectory))
            reportTypes.Add(CustomerReportType.SalesSummary, GetType(DevExpress.DevAV.Reports.CustomerSalesSummaryReport))
            reportTypes.Add(CustomerReportType.SalesDetail, GetType(DevExpress.DevAV.Reports.CustomerSalesDetailReport))

            reportTypes.Add(ProductReportType.SpecificationSummary, GetType(DevExpress.DevAV.Reports.ProductProfile))
            reportTypes.Add(ProductReportType.OrderDetail, GetType(DevExpress.DevAV.Reports.ProductOrders))
            reportTypes.Add(ProductReportType.SalesSummary, GetType(DevExpress.DevAV.Reports.ProductSalesSummary))
            reportTypes.Add(ProductReportType.TopSalesperson, GetType(DevExpress.DevAV.Reports.ProductTopSalesperson))

            reportTypes.Add(SalesReportType.Invoice, GetType(DevExpress.DevAV.Reports.SalesInvoice))
            reportTypes.Add(SalesReportType.SalesReport, GetType(DevExpress.DevAV.Reports.SalesOrdersSummaryReport))
            reportTypes.Add(SalesReportType.SalesByStore, GetType(DevExpress.DevAV.Reports.SalesAnalysisReport))
        End Sub
        Public Function CreateReport(ByVal reportKey As Object) As Object Implements IReportActivator.CreateReport
            Dim reportType As Type = Nothing
            If reportTypes.TryGetValue(reportKey, reportType) Then
                Return Activator.CreateInstance(reportType)
            End If
            Throw New ArgumentException("reportKey")
        End Function
    End Class
End Namespace
