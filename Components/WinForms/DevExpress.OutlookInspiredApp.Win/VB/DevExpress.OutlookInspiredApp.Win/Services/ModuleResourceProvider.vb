Namespace DevExpress.DevAV.Services
    Public Interface IModuleResourceProvider
        Function GetCaption(ByVal moduleType As ModuleType) As String
        Function GetModuleImageUri(ByVal moduleType As ModuleType, Optional ByVal smallImage As Boolean = False) As String
    End Interface
    Public Class ModuleResourceProvider
        Implements IModuleResourceProvider

        Public Function GetCaption(ByVal moduleType As ModuleType) As String Implements IModuleResourceProvider.GetCaption
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Unknown
                    Return Nothing
                Case DevExpress.DevAV.ModuleType.EmployeesPeek, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return "Employees"
                Case DevExpress.DevAV.ModuleType.CustomersPeek, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return "Customers"
                Case DevExpress.DevAV.ModuleType.ProductsPeek, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return "Products"
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return "Sales"
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return "Opportunities"
                Case Else
                    Return moduleType.ToString()
            End Select
        End Function
        Public Overridable Function GetModuleImageUri(ByVal moduleType As ModuleType, Optional ByVal smallImage As Boolean = False) As String Implements IModuleResourceProvider.GetModuleImageUri
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return If(smallImage, "resource://DevExpress.DevAV.Resources.Modules.Employees.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Modules.Employees.svg")
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return If(smallImage, "resource://DevExpress.DevAV.Resources.Modules.Customers.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Modules.Customers.svg")
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return If(smallImage, "resource://DevExpress.DevAV.Resources.Modules.Products.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Modules.Products.svg")
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return If(smallImage, "resource://DevExpress.DevAV.Resources.Modules.Sales.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Modules.Sales.svg")
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return If(smallImage, "resource://DevExpress.DevAV.Resources.Modules.Opportunities.svg?Size=16x16", "resource://DevExpress.DevAV.Resources.Modules.Opportunities.svg")
                Case DevExpress.DevAV.ModuleType.Unknown
                    Return Nothing
                Case Else
                    Return Nothing
            End Select
        End Function
    End Class
End Namespace
