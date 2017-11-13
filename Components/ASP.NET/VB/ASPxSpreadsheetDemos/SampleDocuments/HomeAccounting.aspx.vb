Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Demos

Partial Public Class SampleDocuments_HomeAccounting
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "SampleDocuments\\HomeAccounting.xlsx")
			Spreadsheet.Open(filePath)
		End If
	End Sub
End Class
