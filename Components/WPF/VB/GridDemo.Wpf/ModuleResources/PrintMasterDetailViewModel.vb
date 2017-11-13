Imports DevExpress.Utils
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports DevExpress.DemoData
Imports DevExpress.DemoData.Models

Namespace GridDemo
    Public Class PrintMasterDetailModuleViewModel
        Inherits BindableBase

        Private allowPrintDetailsCore, printAllDetailsCore As DefaultBoolean
        Private printOrdersColumnHeadersCore, printOrdersSummariesCore, printCustomersColumnHeadersCore, printCustomersSummariesCore, printInvoicesColumnHeadersCore, printInvoicesSummariesCore, printEmployeesColumnHeadersCore, printEmployeesSummariesCore, printSelectedEmployeesOnlyCore, printSelectedOrdersOnlyCore, printSelectedInvoicesOnlyCore, printSelectedCustomersOnlyCore As Boolean

        Public Sub New()
            Employees = (New NWindDataLoader()).Employees
            AllowPrintDetails = DefaultBoolean.True
            PrintAllDetails = DefaultBoolean.False
            PrintOrdersSummaries = True
            PrintOrdersColumnHeaders = True
            PrintCustomersColumnHeaders = True
            PrintCustomersSummaries = True
            PrintInvoicesColumnHeaders = True
            PrintInvoicesSummaries = True
            PrintEmployeesColumnHeaders = True
            PrintEmployeesSummaries = True
        End Sub

        Private privateEmployees As Object
        Public Property Employees() As Object
            Get
                Return privateEmployees
            End Get
            Private Set(ByVal value As Object)
                privateEmployees = value
            End Set
        End Property

        Public Property AllowPrintDetails() As DefaultBoolean
            Get
                Return allowPrintDetailsCore
            End Get
            Set(ByVal value As DefaultBoolean)
                SetProperty(allowPrintDetailsCore, value, Function() AllowPrintDetails)
            End Set
        End Property
        Public Property PrintAllDetails() As DefaultBoolean
            Get
                Return printAllDetailsCore
            End Get
            Set(ByVal value As DefaultBoolean)
                SetProperty(printAllDetailsCore, value, Function() PrintAllDetails)
            End Set
        End Property


        Public Property PrintOrdersColumnHeaders() As Boolean
            Get
                Return printOrdersColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printOrdersColumnHeadersCore, value, Function() PrintOrdersColumnHeaders)
            End Set
        End Property
        Public Property PrintOrdersSummaries() As Boolean
            Get
                Return printOrdersSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printOrdersSummariesCore, value, Function() PrintOrdersSummaries)
            End Set
        End Property

        Public Property PrintCustomersColumnHeaders() As Boolean
            Get
                Return printCustomersColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printCustomersColumnHeadersCore, value, Function() PrintCustomersColumnHeaders)
            End Set
        End Property
        Public Property PrintCustomersSummaries() As Boolean
            Get
                Return printCustomersSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printCustomersSummariesCore, value, Function() PrintCustomersSummaries)
            End Set
        End Property

        Public Property PrintInvoicesColumnHeaders() As Boolean
            Get
                Return printInvoicesColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printInvoicesColumnHeadersCore, value, Function() PrintInvoicesColumnHeaders)
            End Set
        End Property

        Public Property PrintInvoicesSummaries() As Boolean
            Get
                Return printInvoicesSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printInvoicesSummariesCore, value, Function() PrintInvoicesSummaries)
            End Set
        End Property

        Public Property PrintEmployeesColumnHeaders() As Boolean
            Get
                Return printEmployeesColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printEmployeesColumnHeadersCore, value, Function() PrintEmployeesColumnHeaders)
            End Set
        End Property

        Public Property PrintEmployeesSummaries() As Boolean
            Get
                Return printEmployeesSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printEmployeesSummariesCore, value, Function() PrintEmployeesSummaries)
            End Set
        End Property

        Public Property PrintSelectedEmployeesOnly() As Boolean
            Get
                Return printSelectedEmployeesOnlyCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printSelectedEmployeesOnlyCore, value, Function() PrintSelectedEmployeesOnly)
            End Set
        End Property

        Public Property PrintSelectedOrdersOnly() As Boolean
            Get
                Return printSelectedOrdersOnlyCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printSelectedOrdersOnlyCore, value, Function() PrintSelectedOrdersOnly)
            End Set
        End Property

        Public Property PrintSelectedInvoicesOnly() As Boolean
            Get
                Return printSelectedInvoicesOnlyCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printSelectedInvoicesOnlyCore, value, Function() PrintSelectedInvoicesOnly)
            End Set
        End Property

        Public Property PrintSelectedCustomersOnly() As Boolean
            Get
                Return printSelectedCustomersOnlyCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(printSelectedCustomersOnlyCore, value, Function() PrintSelectedCustomersOnly)
            End Set
        End Property
    End Class
End Namespace
