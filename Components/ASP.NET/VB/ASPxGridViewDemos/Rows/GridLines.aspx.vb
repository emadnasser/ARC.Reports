Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class Rows_GridLines
	Inherits Page

	Protected Sub ddlGridLines_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		grid.Settings.GridLines = CType(System.Enum.Parse(GetType(GridLines), ddlGridLines.Text, True), GridLines)
	End Sub
End Class
