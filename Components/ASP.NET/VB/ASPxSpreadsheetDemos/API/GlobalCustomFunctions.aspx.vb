Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class ServerSideFunctionality_GlobalCustomFunctions
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not Page.IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "DiscountCustomFunction.xlsx")
			Spreadsheet.Open(filePath)
		End If
	End Sub
End Class
