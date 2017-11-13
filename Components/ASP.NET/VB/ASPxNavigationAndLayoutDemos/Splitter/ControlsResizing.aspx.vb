Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Splitter_ControlsResizing
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If ASPxWebControl.GlobalTheme.Contains("Metropolis") Then
			ASPxSplitter1.Styles.Pane.CssClass = "metropolisPane"
		ElseIf ASPxWebControl.GlobalTheme.Contains("Youthful") Then
			ASPxSplitter1.Styles.Pane.CssClass = "youthfulPane"
		Else
			ASPxSplitter1.Styles.Pane.CssClass = String.Empty
		End If
	End Sub
End Class
