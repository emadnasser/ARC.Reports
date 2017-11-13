Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Public NotInheritable Class HtmlEditorUtils

	Private Const htmlLocation As String = "~/App_Data/Html"
	Private Shared ReadOnly darkThemeNames As ICollection(Of String) = New String() { "BlackGlass", "PlasticBlue", "RedWine" }

	Private Sub New()
	End Sub
	Public Shared Sub SetHtml(ByVal page As Page, ByVal htmlEditor As ASPxHtmlEditor, ByVal htmlFileName As String)
		Dim resolvedPath As String = page.MapPath(Path.Combine(htmlLocation, htmlFileName))
		htmlEditor.Html = File.ReadAllText(resolvedPath)
	End Sub
	Public Shared Function GetHtml(ByVal page As Page, ByVal htmlFileName As String) As String
		Dim resolvedPath As String = page.MapPath(Path.Combine(htmlLocation, htmlFileName))
		Return File.ReadAllText(resolvedPath)
	End Function
	Public Shared Function GetHtml(ByVal page As Page, ByVal htmlFileName As String, ByVal demoPageIsInRootFolder As Boolean) As String
		Dim result As String = GetHtml(page, htmlFileName)
		Return If(demoPageIsInRootFolder, result, result.Replace("UploadFiles/", "../UploadFiles/"))
	End Function

	Public Shared Function IsDarkTheme(ByVal themeName As String) As Boolean
		Return darkThemeNames.Contains(themeName)
	End Function

End Class
