Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class Splitter_PaneAutoSizing
	Inherits Page
	Private Const htmlLocation As String = "~/App_Data/Html"
	Public Function GetHtml() As String
		Dim htmlFileName As String = If(String.IsNullOrEmpty(ASPxTreeView1.SelectedNode.Name), "Articles.html", ASPxTreeView1.SelectedNode.Name & ".html")
		Dim resolvedPath As String = MapPath(Path.Combine(htmlLocation, htmlFileName))
		Return File.ReadAllText(resolvedPath)
	End Function

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Splitter/CSS/PaneAutoSizing.css")
		If (Not IsCallback) Then
			ASPxTreeView1.SelectedNode = ASPxTreeView1.Nodes(0).Nodes(0)
		End If
	End Sub
End Class
