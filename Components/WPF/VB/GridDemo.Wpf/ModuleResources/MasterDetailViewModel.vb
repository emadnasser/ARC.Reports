Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Mvvm
Imports DevExpress.DemoData.Models
Imports System.Collections.Generic
Imports System.Windows
Imports System.Data
Imports DevExpress.DemoData

Namespace GridDemo
    Public Class MasterDetailViewModel
        Inherits BindableBase

        Private privateEmployees As Object
        Public Property Employees() As Object
            Get
                Return privateEmployees
            End Get
            Private Set(ByVal value As Object)
                privateEmployees = value
            End Set
        End Property

        Public Sub New()
            Employees = (New NWindDataLoader()).Employees
            ShowOrdersSummaries = True
            ShowOrdersColumnHeaders = True
            ShowCustomersColumnHeaders = True
            ShowCustomersSummaries = True
            ShowInvoicesColumnHeaders = True
            ShowInvoicesSummaries = True
            ShowDetailButtons = True
        End Sub
        Private showOrdersColumnHeadersCore As Boolean
        Public Property ShowOrdersColumnHeaders() As Boolean
            Get
                Return showOrdersColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showOrdersColumnHeadersCore, value, Function() ShowOrdersColumnHeaders)
            End Set
        End Property
        Private showOrdersSummariesCore As Boolean
        Public Property ShowOrdersSummaries() As Boolean
            Get
                Return showOrdersSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showOrdersSummariesCore, value, Function() ShowOrdersSummaries)
            End Set
        End Property

        Private showCustomersColumnHeadersCore As Boolean
        Public Property ShowCustomersColumnHeaders() As Boolean
            Get
                Return showCustomersColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showCustomersColumnHeadersCore, value, Function() ShowCustomersColumnHeaders)
            End Set
        End Property
        Private showCustomersSummariesCore As Boolean
        Public Property ShowCustomersSummaries() As Boolean
            Get
                Return showCustomersSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showCustomersSummariesCore, value, Function() ShowCustomersSummaries)
            End Set
        End Property

        Private showInvoicesColumnHeadersCore As Boolean
        Public Property ShowInvoicesColumnHeaders() As Boolean
            Get
                Return showInvoicesColumnHeadersCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showInvoicesColumnHeadersCore, value, Function() ShowInvoicesColumnHeaders)
            End Set
        End Property
        Private showInvoicesSummariesCore As Boolean
        Public Property ShowInvoicesSummaries() As Boolean
            Get
                Return showInvoicesSummariesCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showInvoicesSummariesCore, value, Function() ShowInvoicesSummaries)
            End Set
        End Property

        Private showDetailButtonsCore As Boolean
        Public Property ShowDetailButtons() As Boolean
            Get
                Return showDetailButtonsCore
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showDetailButtonsCore, value, Function() ShowDetailButtons)
            End Set
        End Property
    End Class
End Namespace
