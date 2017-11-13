Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports DevExpress.Office.Utils
Imports DevExpress.Spreadsheet
Imports DevExpress.DataAccess

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MailMergePicturesModule
		Inherits MailMergeModuleBase
		Protected Overrides Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
			spreadsheetControl.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs
			spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\EmployeesHorizontalTemplate.xlsx"))
			spreadsheetControl.Document.MailMergeParameters("SpreadsheetControl").Value = spreadsheetControl
		End Sub
		Protected Overrides Sub LoadData(ByVal book As IWorkbook)
			ChangeFilter(book)
		End Sub
		Protected Overrides ReadOnly Property ShowHideCommentsItem() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides Sub ChangeFilter(ByVal book As IWorkbook)
			Dim filter As EmployeePosition = EmployeePosition.None
			If ShowSalesManagers Then
				filter = filter Or EmployeePosition.SalesManager
			End If
			If ShowInsideSalesCoordinators Then
				filter = filter Or EmployeePosition.InsideSalesCoordinators
			End If
			If ShowSalesRepresentatives Then
				filter = filter Or EmployeePosition.SalesRepresentatives
			End If
			book.MailMergeParameters("Position").Value = filter
		End Sub
	End Class
	#Region "EmployeeInfo"
	<Flags> _
	Public Enum EmployeePosition
		None = 0
		Unknown = 1
		SalesManager = 2
		InsideSalesCoordinators = 4
		SalesRepresentatives = 8
	End Enum

	Public Class EmployeesInfo
		#Region "StaticMembers"
		Private Shared ReadOnly employeePositionsTable As Dictionary(Of String, EmployeePosition) = GenerateEmployeePositionsTable()
		Private Shared Function GenerateEmployeePositionsTable() As Dictionary(Of String, EmployeePosition)
			Dim result As New Dictionary(Of String, EmployeePosition)()
			result.Add("Sales Manager", EmployeePosition.SalesManager)
			result.Add("Inside Sales Coordinator", EmployeePosition.InsideSalesCoordinators)
			result.Add("Sales Representative", EmployeePosition.SalesRepresentatives)
			Return result
		End Function

		#End Region
		Private ReadOnly spreadsheetControl As ISpreadsheetControl
		Public Sub New(ByVal spreadsheetControl As ISpreadsheetControl)
			Me.spreadsheetControl = spreadsheetControl
		End Sub
		Public Function GenerateReport(ByVal employeePositionFilter As EmployeePosition) As IEnumerable(Of EmployeeInfo)
			Dim result As New List(Of EmployeeInfo)()
			If spreadsheetControl Is Nothing OrElse (Not spreadsheetControl.Document.Worksheets.Contains("Employees")) Then
				Return result
			End If
			Dim employeesWorksheet As Worksheet = spreadsheetControl.Document.Worksheets("Employees")
			Dim i As Integer = 1
			Do While Not employeesWorksheet(i, 0).Value.IsEmpty
				Dim employeeRange As Range = employeesWorksheet.Range.FromLTRB(0, i, 14, i)
				Dim employeeInfo As New EmployeeInfo(employeeRange)
				Dim employeePosition As EmployeePosition = ExtractEmployeePosition(employeeInfo.Title)
				If (employeePosition And employeePositionFilter) <> 0 Then
					result.Add(employeeInfo)
				End If
				i += 1
			Loop
			Return result
		End Function
		Private Function ExtractEmployeePosition(ByVal textValue As String) As EmployeePosition
			Dim result As EmployeePosition
			If (Not employeePositionsTable.TryGetValue(textValue, result)) Then
				result = EmployeePosition.Unknown
			End If
			Return result
		End Function
	End Class

	Public Class EmployeeInfo
		#Region "Properties"
		Private privateLastName As String
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Private Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Private Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Private Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateTitleOfCourtesy As String
		Public Property TitleOfCourtesy() As String
			Get
				Return privateTitleOfCourtesy
			End Get
			Private Set(ByVal value As String)
				privateTitleOfCourtesy = value
			End Set
		End Property
		Private privateBirthDate As DateTime
		Public Property BirthDate() As DateTime
			Get
				Return privateBirthDate
			End Get
			Private Set(ByVal value As DateTime)
				privateBirthDate = value
			End Set
		End Property
		Private privateHireDate As DateTime
		Public Property HireDate() As DateTime
			Get
				Return privateHireDate
			End Get
			Private Set(ByVal value As DateTime)
				privateHireDate = value
			End Set
		End Property
		Private privateAddress As String
		Public Property Address() As String
			Get
				Return privateAddress
			End Get
			Private Set(ByVal value As String)
				privateAddress = value
			End Set
		End Property
		Private privateCity As String
		Public Property City() As String
			Get
				Return privateCity
			End Get
			Private Set(ByVal value As String)
				privateCity = value
			End Set
		End Property
		Private privateRegion As String
		Public Property Region() As String
			Get
				Return privateRegion
			End Get
			Private Set(ByVal value As String)
				privateRegion = value
			End Set
		End Property
		Private privatePostalCode As String
		Public Property PostalCode() As String
			Get
				Return privatePostalCode
			End Get
			Private Set(ByVal value As String)
				privatePostalCode = value
			End Set
		End Property
		Private privateCountry As String
		Public Property Country() As String
			Get
				Return privateCountry
			End Get
			Private Set(ByVal value As String)
				privateCountry = value
			End Set
		End Property
		Private privateHomePhone As String
		Public Property HomePhone() As String
			Get
				Return privateHomePhone
			End Get
			Private Set(ByVal value As String)
				privateHomePhone = value
			End Set
		End Property
		Private privateExtension As String
		Public Property Extension() As String
			Get
				Return privateExtension
			End Get
			Private Set(ByVal value As String)
				privateExtension = value
			End Set
		End Property
		Private privatePhoto As Bitmap
		Public Property Photo() As Bitmap
			Get
				Return privatePhoto
			End Get
			Private Set(ByVal value As Bitmap)
				privatePhoto = value
			End Set
		End Property
		Private privateNotes As String
		Public Property Notes() As String
			Get
				Return privateNotes
			End Get
			Private Set(ByVal value As String)
				privateNotes = value
			End Set
		End Property
		#End Region
		Public Sub New(ByVal range As Range)
			LastName = range(0).Value.TextValue
			FirstName = range(1).Value.TextValue
			Title = range(2).Value.TextValue
			TitleOfCourtesy = range(3).Value.TextValue
			BirthDate = range(4).Value.DateTimeValue
			HireDate = range(5).Value.DateTimeValue
			Address = range(6).Value.TextValue
			City = range(7).Value.TextValue
			Region = range(8).Value.TextValue
			PostalCode = range(9).Value.TextValue
			Country = range(10).Value.TextValue
			HomePhone = range(11).Value.TextValue
			Extension = range(12).Value.TextValue
			Notes = range(14).Value.TextValue
			Photo = Nothing
			Dim picturesByName As IList(Of Picture) = range.Worksheet.Pictures.GetPicturesByName(LastName)
			If picturesByName.Count <> 0 Then
				Photo = New Bitmap(New MemoryStream(picturesByName(0).Image.GetImageBytes(OfficeImageFormat.Bmp)))
			End If
		End Sub
	End Class
	#End Region
End Namespace
