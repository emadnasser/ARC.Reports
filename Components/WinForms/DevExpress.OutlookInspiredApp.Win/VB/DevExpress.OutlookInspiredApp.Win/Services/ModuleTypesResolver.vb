Namespace DevExpress.DevAV.Services

    Public Interface IModuleTypesResolver
        Function GetName(ByVal moduleType As ModuleType) As String
        Function GetTypeName(ByVal moduleType As ModuleType) As String
        Function GetId(ByVal moduleType As ModuleType) As System.Guid
        Function GetMainModuleType(ByVal type As ModuleType) As ModuleType
        Function GetMapModuleType(ByVal type As ModuleType) As ModuleType
        Function GetMailMergeModuleType(ByVal type As ModuleType) As ModuleType
        Function GetAnalysisModuleType(ByVal type As ModuleType) As ModuleType
        Function GetPeekModuleType(ByVal type As ModuleType) As ModuleType
        Function GetNavPaneModuleType(ByVal type As ModuleType) As ModuleType
        Function GetNavPaneHeaderModuleType(ByVal type As ModuleType) As ModuleType
        Function GetExportModuleType(ByVal type As ModuleType) As ModuleType
        Function GetPrintModuleType(ByVal type As ModuleType) As ModuleType
    End Interface
    Friend Class ModuleTypesResolver
        Implements IModuleTypesResolver

        Public Function GetName(ByVal moduleType As ModuleType) As String Implements IModuleTypesResolver.GetName
            If moduleType = DevExpress.DevAV.ModuleType.Unknown Then
                Return Nothing
            End If
            Return moduleType.ToString()
        End Function
        Public Function GetTypeName(ByVal moduleType As ModuleType) As String Implements IModuleTypesResolver.GetTypeName
            If moduleType = DevExpress.DevAV.ModuleType.Unknown Then
                Return Nothing
            End If
            Return moduleType.ToString()
        End Function
        Public Function GetId(ByVal moduleType As ModuleType) As System.Guid Implements IModuleTypesResolver.GetId
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeesPeek, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a2")
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomersPeek, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a3")
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductsPeek, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a4")
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersPeek, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a5")
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesPeek, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a6")
                Case Else
                    Return System.Guid.Empty
            End Select
        End Function
        Public Function GetMainModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMainModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeesPeek, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return DevExpress.DevAV.ModuleType.Employees
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomersPeek, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return DevExpress.DevAV.ModuleType.Customers
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductsPeek, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return DevExpress.DevAV.ModuleType.Products
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersPeek, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return DevExpress.DevAV.ModuleType.Orders
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesPeek, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return DevExpress.DevAV.ModuleType.Quotes
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetMapModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMapModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeeEditView
                    Return DevExpress.DevAV.ModuleType.EmployeeMapView
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomerEditView
                    Return DevExpress.DevAV.ModuleType.CustomerMapView
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductEditView
                    Return DevExpress.DevAV.ModuleType.ProductMapView
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrderEditView
                    Return DevExpress.DevAV.ModuleType.OrderMapView
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuoteEditView
                    Return DevExpress.DevAV.ModuleType.QuoteMapView
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetMailMergeModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMailMergeModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeeEditView
                    Return DevExpress.DevAV.ModuleType.EmployeeMailMerge
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrderEditView
                    Return DevExpress.DevAV.ModuleType.OrderMailMerge
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetAnalysisModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetAnalysisModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomerEditView
                    Return DevExpress.DevAV.ModuleType.CustomerAnalysis
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductEditView
                    Return DevExpress.DevAV.ModuleType.ProductAnalysis
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetPeekModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetPeekModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeesPeek, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return DevExpress.DevAV.ModuleType.EmployeesPeek
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomersPeek, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return DevExpress.DevAV.ModuleType.CustomersPeek
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductsPeek, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return DevExpress.DevAV.ModuleType.ProductsPeek
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersPeek, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return DevExpress.DevAV.ModuleType.OrdersPeek
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesPeek, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return DevExpress.DevAV.ModuleType.QuotesPeek

                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetNavPaneModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetNavPaneModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeesPeek, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return DevExpress.DevAV.ModuleType.EmployeesFilterPane
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomersPeek, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return DevExpress.DevAV.ModuleType.CustomersFilterPane
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductsPeek, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return DevExpress.DevAV.ModuleType.ProductsFilterPane
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersPeek, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return DevExpress.DevAV.ModuleType.OrdersFilterPane
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesPeek, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return DevExpress.DevAV.ModuleType.QuotesFilterPane
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetNavPaneHeaderModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetNavPaneHeaderModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees, DevExpress.DevAV.ModuleType.EmployeesFilterPane
                    Return DevExpress.DevAV.ModuleType.EmployeesFilterPaneCollapsed
                Case DevExpress.DevAV.ModuleType.Customers, DevExpress.DevAV.ModuleType.CustomersFilterPane
                    Return DevExpress.DevAV.ModuleType.CustomersFilterPaneCollapsed
                Case DevExpress.DevAV.ModuleType.Products, DevExpress.DevAV.ModuleType.ProductsFilterPane
                    Return DevExpress.DevAV.ModuleType.ProductsFilterPaneCollapsed
                Case DevExpress.DevAV.ModuleType.Orders, DevExpress.DevAV.ModuleType.OrdersFilterPane
                    Return DevExpress.DevAV.ModuleType.OrdersFilterPaneCollapsed
                Case DevExpress.DevAV.ModuleType.Quotes, DevExpress.DevAV.ModuleType.QuotesFilterPane
                    Return DevExpress.DevAV.ModuleType.QuotesFilterPaneCollapsed
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetExportModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetExportModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees
                    Return DevExpress.DevAV.ModuleType.EmployeesExport
                Case DevExpress.DevAV.ModuleType.Customers
                    Return DevExpress.DevAV.ModuleType.CustomersExport
                Case DevExpress.DevAV.ModuleType.Products
                    Return DevExpress.DevAV.ModuleType.ProductsExport
                Case DevExpress.DevAV.ModuleType.Orders
                    Return DevExpress.DevAV.ModuleType.OrdersExport
                Case DevExpress.DevAV.ModuleType.Quotes
                    Return DevExpress.DevAV.ModuleType.QuotesExport
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
        Public Function GetPrintModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetPrintModuleType
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.Employees
                    Return DevExpress.DevAV.ModuleType.EmployeesPrint
                Case DevExpress.DevAV.ModuleType.Customers
                    Return DevExpress.DevAV.ModuleType.CustomersPrint
                Case DevExpress.DevAV.ModuleType.Products
                    Return DevExpress.DevAV.ModuleType.ProductsPrint
                Case DevExpress.DevAV.ModuleType.Orders
                    Return DevExpress.DevAV.ModuleType.OrdersPrint
                Case DevExpress.DevAV.ModuleType.Quotes
                    Return DevExpress.DevAV.ModuleType.QuotesPrint
                Case Else
                    Return DevExpress.DevAV.ModuleType.Unknown
            End Select
        End Function
    End Class
End Namespace
