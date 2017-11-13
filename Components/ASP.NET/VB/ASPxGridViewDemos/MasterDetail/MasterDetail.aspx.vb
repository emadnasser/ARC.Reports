Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class MasterDetail_MasterDetail
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.DataBind()
			grid.DetailRows.ExpandRow(0)
		End If
	End Sub
	Protected Sub detailGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Session("CustomerID") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()
	End Sub
	Protected Sub detailGrid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			e.Value = price * quantity
		End If
	End Sub
	Protected Sub chkSingleExpanded_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		grid.SettingsDetail.AllowOnlyOneMasterRowExpanded = chkSingleExpanded.Checked
		If grid.SettingsDetail.AllowOnlyOneMasterRowExpanded Then
			grid.DetailRows.CollapseAllRows()
		End If
	End Sub
End Class
