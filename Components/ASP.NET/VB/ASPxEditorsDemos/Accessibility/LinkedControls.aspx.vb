Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Collections.Generic

Partial Public Class Accessibility_LinkedControls
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		FilterProductsGrid()
	End Sub

	Protected Sub FilterProductsGrid()
		Using context = New NorthwindContext()
			Dim selectedCategories = lbCategories.SelectedValues.OfType(Of Integer)()
			Dim filteredProducts = context.Products.Where(Function(product) selectedCategories.Contains(CInt(Fix(product.CategoryID))))
			gvProducts.DataSource = filteredProducts.ToList()
			gvProducts.DataBind()
			gvProducts.JSProperties("cpProductCount") = gvProducts.VisibleRowCount
		End Using
	End Sub
End Class
