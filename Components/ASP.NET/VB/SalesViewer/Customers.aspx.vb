Imports System
Imports DataAccess

Partial Public Class Customers
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Using provider As New CustomersProvider()
            CustomersGridView.DataSource = provider.GetList()
            CustomersGridView.DataBind()
            If Not CustomersGridView.IsCallback Then
                Dim focusedRow As Customer = TryCast(CustomersGridView.GetRow(CustomersGridView.FocusedRowIndex), Customer)
                If focusedRow IsNot Nothing Then
                    CustomerDetails.LoadContent(focusedRow.Id)
                End If
            End If
        End Using
    End Sub

    Public Overrides ReadOnly Property RangeControl() As IRangeControl
        Get
            Return FooterRangeControl
        End Get
    End Property
End Class
