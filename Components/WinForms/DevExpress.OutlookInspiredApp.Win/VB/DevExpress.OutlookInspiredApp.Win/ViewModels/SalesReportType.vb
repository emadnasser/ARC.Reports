Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.DevAV.ViewModels
    Public Enum SalesReportType
        None
        <Display(Name := "Sales Report")>
        SalesReport
        <Display(Name := "Sales by store")>
        SalesByStore
        <Display(Name := "Thank You")>
        ThankYou
        <Display(Name := "Invoice")>
        Invoice
    End Enum
    Public Module SalesReportTypeExtension
        <System.Runtime.CompilerServices.Extension> _
        Public Function ToFileName(ByVal reportTemplate As SalesReportType) As String
            Select Case reportTemplate
                Case SalesReportType.SalesReport
                    Return ("Sales Order Summary Report")
                Case SalesReportType.SalesByStore
                    Return ("Sales Analysys Report")
                Case SalesReportType.ThankYou
                    Return ("Sales Thank You")
                Case Else
                    Return ("Sales Invoice")
            End Select
        End Function
    End Module
End Namespace
