Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class API_ClientSideEvents
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not Page.IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "ClientSideEvents.xlsx")

			Spreadsheet.Open(filePath)
		End If
	End Sub
End Class
