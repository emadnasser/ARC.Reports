Imports System
Imports DataAccess
Imports DataContext

Partial Public Class CustomerDetails
    Inherits UserControlBase

    Private privateLocation As Location
    Public Property Location() As Location
        Get
            Return privateLocation
        End Get
        Private Set(ByVal value As Location)
            privateLocation = value
        End Set
    End Property

    Public Sub LoadContent(ByVal customerId As Integer)
        Dim startDate As Date = GetSalesStartDate()
        Dim endDate As Date = GetSalesEndDate()

        HorizontalBarChart.Title = DateTimeHelper.GetDateRangeString(startDate, endDate)
        HorizontalBarChart.SetData(SalesProvider.GetCustomerPurchasesGroupedByProduct(customerId, startDate, endDate))
        Using provider As New CustomersProvider()
            Location = provider.GetCustomerLocation(customerId)
        End Using
        CustomerDetailsHolder.Visible = True
        EmptyDataMessageHolder.Visible = False
    End Sub
End Class
