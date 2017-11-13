Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class Products
    Inherits MasterDetailPage

    Public Overrides ReadOnly Property FilterBag() As FilterBag
        Get
            Return DemoUtils.ProductFilter
        End Get
    End Property
    Public Overrides ReadOnly Property PageName() As String
        Get
            Return "Products"
        End Get
    End Property
    Public Overrides ReadOnly Property MasterUC() As MasterUserControl
        Get
            Return TryCast(Products_Master, MasterUserControl)
        End Get
    End Property
    Public Overrides ReadOnly Property DetailUC() As DetailUserControl
        Get
            Return TryCast(Products_Detail, DetailUserControl)
        End Get
    End Property

    Protected ReadOnly Property SelectedProduct() As Product
        Get
            Return DataProvider.Products.FirstOrDefault(Function(p) p.Id = SelectedItemID)
        End Get
    End Property

    Protected Sub ProductPopup_WindowCallback(ByVal source As Object, ByVal e As PopupWindowCallbackArgs)
        ProductPopupImageSlider.ImageSourceFolder = DemoUtils.ImageLoader.ProductImagesVirtPath(SelectedProduct.Id)
        ProductPopupImageSlider.ActiveItemIndex = Integer.Parse(e.Parameter)
    End Sub

    Public Overrides Sub OnFilterChanged()
        Update()
    End Sub

    Public Overrides Function GetFilterColumns() As IEnumerable(Of FilterControlColumn)
        Dim result = New List(Of FilterControlColumn)()
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Name", .DisplayName = "Product Name"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Cost"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "SalePrice"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "RetailPrice"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Inventory"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Manufacturing"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Backordered"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Category"})
        result.Add(New FilterControlDateColumn() With {.PropertyName = "ProductionStart"})
        result.Add(New FilterControlCheckColumn() With {.PropertyName = "Available"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Support.FullName", .DisplayName = "Support Name"})
        Return result
    End Function


End Class
