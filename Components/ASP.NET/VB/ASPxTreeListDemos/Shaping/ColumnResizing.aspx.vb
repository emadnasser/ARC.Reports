Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class Shaping_ColumnResizing
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		treeList.SettingsResizing.ColumnResizeMode = CType(System.Enum.Parse(GetType(ColumnResizeMode), ddlResizingMode.Text, True), ColumnResizeMode)
		treeList.SettingsResizing.Visualization = CType(System.Enum.Parse(GetType(ResizingMode), ddlResizingVisualization.Text, True), ResizingMode)
	End Sub
End Class
