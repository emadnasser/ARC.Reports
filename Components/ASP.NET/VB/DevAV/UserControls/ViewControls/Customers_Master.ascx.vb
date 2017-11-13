Imports System
Imports System.Linq
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_Customers_Master
    Inherits MasterUserControl

    Public Overrides Property SelectedItemID() As Long
        Get
            Dim customerID = CustomerGrid.GetRowValues(CustomerGrid.FocusedRowIndex, CustomerGrid.KeyFieldName)
            Return If(customerID IsNot Nothing, CLng((customerID)), DataProvider.emptyEntryID)
        End Get
        Set(ByVal value As Long)
            Throw New NotImplementedException()
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Update()
    End Sub

    Public Overrides Sub Update()
        BindGrid()
        UpdateDetail()
    End Sub

    Protected Sub BindGrid() ' TODO try use cache in all gridviews
        CustomerGrid.DataSource = DataProvider.Customers.ToList()
        CustomerGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(False)
        CustomerGrid.SearchPanelFilter = OwnerPage.FilterBag.SearchText
        CustomerGrid.DataBind()
    End Sub
End Class
