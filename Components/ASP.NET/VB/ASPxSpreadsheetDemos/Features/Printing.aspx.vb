Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Demos

Partial Public Class Features_Printing
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SpreadsheetDemoUtils.HideAllTabsExceptFileAndPageLayout(Spreadsheet)
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "TrendlineAnalysis_template.xlsx")
			Spreadsheet.Open(filePath)
		End If
	End Sub
End Class
