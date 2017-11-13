Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Columns_ColumnResizing
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal args As EventArgs)
		grid.SettingsResizing.ColumnResizeMode = CType(System.Enum.Parse(GetType(ColumnResizeMode), ddlResizingMode.Text, True), ColumnResizeMode)
		grid.SettingsResizing.Visualization = CType(System.Enum.Parse(GetType(ResizingMode), ddlResizingVisualization.Text, True), ResizingMode)
	End Sub
End Class
