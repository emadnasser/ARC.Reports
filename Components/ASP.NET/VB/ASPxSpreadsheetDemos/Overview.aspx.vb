Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class Overview
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.CreateOverviewRibbon(Spreadsheet)
		If (Not IsPostBack) Then
			Spreadsheet.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "MonthlyBudget.xlsx"))
		End If
	End Sub
End Class
