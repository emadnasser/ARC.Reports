Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Summary_GroupFooter
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim names() As String = System.Enum.GetNames(GetType(GridViewGroupFooterMode))
			For Each name As String In names
				ddlGroupFooter.Items.Add(name)
			Next name
			ddlGroupFooter.Text = grid.Settings.ShowGroupFooter.ToString()
			grid.ExpandRow(1)
		End If
	End Sub
	Protected Sub ddlGroupFooter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim mode As GridViewGroupFooterMode = CType(System.Enum.Parse(GetType(GridViewGroupFooterMode), ddlGroupFooter.Text), GridViewGroupFooterMode)
		grid.Settings.ShowGroupFooter = mode
	End Sub

	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			e.Value = price * quantity
		End If
	End Sub
End Class
