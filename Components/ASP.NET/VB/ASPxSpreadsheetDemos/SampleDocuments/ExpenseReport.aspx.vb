Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class SampleDocuments_ExpenseReport
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "SampleDocuments\\ExpenseReport.xlsx")
			Spreadsheet.Open(filePath)
		End If
	End Sub
End Class
