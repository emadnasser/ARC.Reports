Imports System
Imports System.Linq
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_Products_Master
    Inherits MasterUserControl

    Public Overrides Property SelectedItemID() As Long
        Get
            Dim productID = ProductGrid.GetRowValues(ProductGrid.FocusedRowIndex, ProductGrid.KeyFieldName)
            Return If(productID IsNot Nothing, CLng((productID)), DataProvider.emptyEntryID)
        End Get
        Set(ByVal value As Long)
            BindGrid()
            ProductGrid.FocusedRowIndex = ProductGrid.FindVisibleIndexByKeyValue(value)
            UpdateDetail()
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Update()
    End Sub

    Public Overrides Sub Update()
        BindGrid()
        UpdateDetail()
    End Sub

    Protected Sub BindGrid()
        ProductGrid.DataSource = DataProvider.Products.ToList()
        ProductGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(False)
        ProductGrid.SearchPanelFilter = OwnerPage.FilterBag.SearchText
        ProductGrid.DataBind()
    End Sub
End Class
