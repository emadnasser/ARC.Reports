Imports System
Imports DataAccess
Imports DevExpress.Web

Partial Public Class Products
    Inherits BasePage

    Public Overrides ReadOnly Property RangeControl() As IRangeControl
        Get
            Return FooterRangeControl
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Using provider As New ProductsProvider()
            ProductsGridView.DataSource = provider.GetList()
            ProductsGridView.DataBind()

            If Not ProductsGridView.IsCallback Then
                Dim focusedRow As Product = TryCast(ProductsGridView.GetRow(ProductsGridView.FocusedRowIndex), Product)
                If focusedRow IsNot Nothing Then
                    ProductDetails.LoadContent(focusedRow.Id)
                End If
            End If
        End Using
    End Sub

    Protected Sub ProductsGridView_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs)
        If e.DataColumn.FieldName = "UnitsInInventory" AndAlso Convert.ToInt32(e.CellValue) < 0 Then
            e.Cell.Font.Bold = True
        End If
    End Sub
End Class
