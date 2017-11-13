Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Web
Imports DevExpress.Web.Demos


Partial Public Class Templates_DataCell
	Inherits System.Web.UI.Page

	Private Const ProductTagFormat As String = "<span class='categoryProduct'>{0}</span>"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		VerticalGrid.Settings.HeaderAreaWidth = If(Utils.IsLargeTheme, 140, 120)
	End Sub

	Protected Function GetProductsHtml(ByVal container As VerticalGridDataItemTemplateContainer) As String
		Dim categoryID As Integer = Convert.ToInt32(container.KeyValue)
		Dim productNames = GetProductNames(categoryID)
		Return String.Join(String.Empty, productNames.Select(Function(p) String.Format(ProductTagFormat, p)))
	End Function

	Protected Function GetProductNames(ByVal categoryID As Integer) As List(Of String)
		Using context = New NorthwindContext()
			Return context.Products.Where(Function(p) p.CategoryID = categoryID).Select(Function(p) p.ProductName).ToList()
		End Using
	End Function
End Class
