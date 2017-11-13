Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class Features_Charts
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not Page.IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "InvestmentPortfolio.xlsx")
			Spreadsheet.Open(filePath)
		End If

		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
	End Sub
End Class
