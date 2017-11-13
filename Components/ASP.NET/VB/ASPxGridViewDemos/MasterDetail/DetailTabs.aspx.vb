Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class MasterDetail_DetailTabs
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) AndAlso (Not IsPostBack) Then
			grid.DataBind()
			grid.DetailRows.ExpandRow(2)
		End If
	End Sub
	Protected Sub productsGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Session("SupplierID") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()
	End Sub
	Protected Sub categoriesGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Session("SupplierID") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()
	End Sub
	Protected Sub ordersGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Session("ProductID") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()
	End Sub
	Protected Sub ordersGrid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim discount As Decimal = Convert.ToDecimal(e.GetListSourceFieldValue("Discount"))
			e.Value = price * quantity * (1 - discount)
		End If
	End Sub
End Class
