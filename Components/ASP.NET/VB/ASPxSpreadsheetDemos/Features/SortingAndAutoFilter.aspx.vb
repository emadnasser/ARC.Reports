Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class Features_SortingAndAutoFilter
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not Page.IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "AutoFilter.xlsx")
			Spreadsheet.Open(filePath)
		End If

		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		SpreadsheetDemoUtils.HideFormulasTab(Spreadsheet)
		SpreadsheetDemoUtils.HidePageLayoutTab(Spreadsheet)
	End Sub
End Class
