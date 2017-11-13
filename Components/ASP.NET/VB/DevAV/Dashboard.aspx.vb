Imports DevExpress.Web
Imports System.Collections.Generic

Partial Public Class Dashboard
    Inherits BasePage

    Public Overrides ReadOnly Property FilterBag() As FilterBag
        Get
            Return DemoUtils.DashboardFilter
        End Get
    End Property
    Public Overrides ReadOnly Property PageName() As String
        Get
            Return "Dashboard"
        End Get
    End Property
    Public Overrides ReadOnly Property ContentHasScroll() As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property ContentHasBorder() As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overrides ReadOnly Property HasSearchPanel() As Boolean
        Get
            Return False
        End Get
    End Property

    Protected ReadOnly Property ViewControl() As ViewUserControl
        Get
            Return TryCast(ProductsPivotGrid, ViewUserControl)
        End Get
    End Property

    Public Overrides Function GetFilterColumns() As IEnumerable(Of FilterControlColumn)
        Dim result = New List(Of FilterControlColumn)()
        result.Add(New FilterControlTextColumn() With {.DisplayName = "Category", .PropertyName = "Product.Category"})
        result.Add(New FilterControlTextColumn() With {.DisplayName = "Name", .PropertyName = "Product.Name"})
        result.Add(New FilterControlTextColumn() With {.DisplayName = "State", .PropertyName = "Order.Store.Address.State"})
        result.Add(New FilterControlTextColumn() With {.DisplayName = "City", .PropertyName = "Order.Store.Address.City"})
        Return result
    End Function

    Public Overrides Sub OnFilterChanged()
        ViewControl.Update()
    End Sub
End Class
