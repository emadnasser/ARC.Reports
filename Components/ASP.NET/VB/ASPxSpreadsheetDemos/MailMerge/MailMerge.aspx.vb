Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.Internal
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class MailMerge_MailMerge
	Inherits OfficeDemoPage
	Protected ReadOnly Property ConnectionString() As String
		Get
			Dim sqlExpressString As String = ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString
			Return DbEngineDetector.PatchConnectionString(sqlExpressString)
		End Get
	End Property


	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) Then
			Dim resultingWorkbook As IWorkbook = GenerateMailMergeDocument()
			If resultingWorkbook IsNot Nothing Then
				OpenResultingDocument(resultingWorkbook)
			End If
			SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		End If
	End Sub

	Private Function GenerateMailMergeDocument() As IWorkbook
		Dim workbook As IWorkbook = Spreadsheet.Document
		LoadMailMergeTemplate(workbook)
		workbook.MailMergeDataSource = GetMailMergeDataSource()
		SetMailMergeMode(workbook)
		Return workbook.GenerateMailMergeDocuments()(0)
	End Function
	Private Function GetMailMergeDataSource() As DataTable
		Dim query As String = "SELECT [LastName], [FirstName], [BirthDate], [Country], [City], [Address], [Title], [Notes], [HomePhone], [Photo] FROM [Employees]"

		Dim employees As New DataTable()

		Using connection = New SqlConnection(ConnectionString)
		Using dataAdapter = New SqlDataAdapter(query, connection)
			connection.Open()

			dataAdapter.Fill(employees)

			connection.Close()
		End Using
		End Using

		Return employees
	End Function

	Private Sub LoadMailMergeTemplate(ByVal workbook As IWorkbook)
		workbook.LoadDocument(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "EmployeesHorizontalTemplate.xlsx"))
	End Sub
	Private Sub SetMailMergeMode(ByVal workbook As IWorkbook)
		Dim mode As String = rblMailMergeMode.Value.ToString()
		workbook.DefinedNames.GetDefinedName("MAILMERGEMODE").RefersTo = String.Format("""{0}""", mode)
		If mode = "Worksheets" Then
			workbook.Worksheets(0).Columns(2).Width = 2440
		End If
	End Sub
	Private Sub OpenResultingDocument(ByVal resultingWorkbook As IWorkbook)
		Using result As New MemoryStream()
			For Each worksheet As Worksheet In resultingWorkbook.Worksheets
				worksheet.Shapes(0).Left = CSng(worksheet.Columns(0).Width + (worksheet.Columns(1).Width - worksheet.Shapes(0).Width) / 2)
			Next worksheet
			resultingWorkbook.SaveDocument(result, DocumentFormat.OpenXml)
			result.Seek(0, SeekOrigin.Begin)
			Spreadsheet.Open(Guid.NewGuid().ToString(), DocumentFormat.OpenXml, Function() result)
		End Using
	End Sub
End Class
