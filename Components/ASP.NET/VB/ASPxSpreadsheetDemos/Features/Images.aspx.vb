Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Internal
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos
Imports DevExpress.XtraSpreadsheet.API.Native.Implementation

Partial Public Class Features_Images
	Inherits OfficeDemoPage
	Protected ReadOnly Property ConnectionString() As String
		Get
			Dim sqlExpressString As String = ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString
			Return DbEngineDetector.PatchConnectionString(sqlExpressString)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)

		If Page.IsPostBack Then
			Return
		End If

		Dim filePath As String = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "AddressBook.xlsx")
		Spreadsheet.Open(filePath)

		Dim employees As DataTable = GetEmployees()
		AddEmployesToSpreadsheet(employees)

		Spreadsheet.Document.History.Clear()
	End Sub
	Private Function GetEmployees() As DataTable
		Dim query As String = "SELECT [LastName], [FirstName], [BirthDate], [Country], [City], [Address], [HomePhone], [Photo] FROM [Employees]"

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
	Private Sub AddEmployesToSpreadsheet(ByVal employees As DataTable)
		Dim worksheet As Worksheet = Spreadsheet.Document.Worksheets.ActiveWorksheet
		If worksheet.Shapes.Count > 0 Then
			Return
		End If

		Const StartAddressRowOffset As Integer = 4
		Dim employeesCount As Integer = employees.Rows.Count
		CreateRequiredRows(worksheet, employeesCount, StartAddressRowOffset)
		For i = 0 To employeesCount - 1
			Dim rowOffset = StartAddressRowOffset + i
			Dim employee As DataRow = employees.Rows(i)
			worksheet("C" & rowOffset).Value = String.Format("{0} {1}", employee("FirstName"), employee("LastName"))
			worksheet("D" & rowOffset).Value = employee.Field(Of DateTime)("BirthDate")
			worksheet("E" & rowOffset).Value = employee.Field(Of String)("Country")
			worksheet("F" & rowOffset).Value = employee.Field(Of String)("City")
			worksheet("G" & rowOffset).Value = employee.Field(Of String)("Address")
			worksheet("H" & rowOffset).Value = employee.Field(Of String)("HomePhone")
			Dim photoMemoryStream As New MemoryStream(employee.Field(Of Byte())("Photo"))
			worksheet.Pictures.AddPicture(New StreamDocumentImageSource(photoMemoryStream), worksheet("B" & rowOffset))
		Next i
	End Sub
	Private Sub CreateRequiredRows(ByVal worksheet As Worksheet, ByVal rowsCount As Integer, ByVal startAddressRowOffset As Integer)
		Dim sourceStyleRow = worksheet.Rows(startAddressRowOffset - 1)
		For i = 0 To rowsCount - 1
			Dim rowOffset = startAddressRowOffset + i
			If rowOffset > startAddressRowOffset Then
				worksheet.Rows(rowOffset - 1).CopyFrom(sourceStyleRow)
			End If
		Next i
	End Sub
End Class
