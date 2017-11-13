Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports System.Globalization

Namespace DevExpress.Docs.Demos
	Public Class MailMergeDocumentGenerator
		Private culture As CultureInfo
		Public Sub New(ByVal culture As CultureInfo)
			Me.culture = culture
			FitToPage = True
		End Sub

		Public Property StatementNumber() As String
		Public Property CustomerId() As String
		Public Property CustomerName() As String
		Public Property Street() As String
		Public Property City() As String
		Public Property State() As String
		Public Property ZIP() As String
		Public Property Phone() As String
		Public Property Email() As String
		Public Property Path() As String
		Public Property FitToPage() As Boolean

		Public Function Generate() As IWorkbook
			Return CreateBook()
		End Function

		Private Function CreateBook() As IWorkbook
			Dim book As IWorkbook = New Workbook()
			book.Options.Culture = culture
			book.LoadDocument(Path)
			FillData(book)
			book.Worksheets(0).PrintOptions.FitToPage = FitToPage
			For Each cell As Cell In book.Worksheets(0).GetExistingCells()
				If cell.DisplayText.Contains("[Statement]") Then
					cell.Value = cell.DisplayText.Replace("[Statement]", StatementNumber)
				End If
				If cell.DisplayText.Contains("[ABC12345]") Then
					cell.Value = cell.DisplayText.Replace("[ABC12345]", CustomerId)
				End If
				If cell.DisplayText.Contains("[Name]") Then
					cell.Value = cell.DisplayText.Replace("[Name]", CustomerName)
				End If
				If cell.DisplayText.Contains("[Street Address]") Then
					cell.Value = cell.DisplayText.Replace("[Street Address]", Street)
				End If
				If cell.DisplayText.Contains("[City]") Then
					cell.Value = cell.DisplayText.Replace("[City]", City)
				End If
				If cell.DisplayText.Contains("[ST]") Then
					cell.Value = cell.DisplayText.Replace("[ST]", State)
				End If
				If cell.DisplayText.Contains("[ZIP Code]") Then
					cell.Value = cell.DisplayText.Replace("[ZIP Code]", ZIP)
				End If
				If cell.DisplayText.Contains("[Phone]") Then
					cell.Value = cell.DisplayText.Replace("[Phone]", Phone)
				End If
				If cell.DisplayText.Contains("[E-mail]") Then
					cell.Value = cell.DisplayText.Replace("[E-mail]", Email)
				End If
			Next cell
			Return book
		End Function

		Private Sub FillData(ByVal book As IWorkbook)
			For i As Integer = 14 To 21
				book.Worksheets(0).Cells(i, 0).Value = DateTime.Today
			Next i
			book.Worksheets(0).Cells("B15").Value = "Konbu"
			book.Worksheets(0).Cells("B16").Value = "Genen Shouyu"
			book.Worksheets(0).Cells("B17").Value = "Alice Mutton"
			book.Worksheets(0).Cells("B18").Value = "Sasquatch Ale"
			book.Worksheets(0).Cells("B19").Value = "Singaporean Hokkien Fried Mee"
			book.Worksheets(0).Cells("B20").Value = "Manjimup Dried Apples"
			book.Worksheets(0).Cells("B21").Value = "Perth Pasties"
			book.Worksheets(0).Cells("B22").Value = "Laughing Lumberjack Lager"

			book.Worksheets(0).Cells("F15").Value = 102
			book.Worksheets(0).Cells("F16").Value = 124
			book.Worksheets(0).Cells("F17").Value = 624
			book.Worksheets(0).Cells("F18").Value = 238
			book.Worksheets(0).Cells("F19").Value = 28
			book.Worksheets(0).Cells("F20").Value = 530
			book.Worksheets(0).Cells("F21").Value = 459.2
			book.Worksheets(0).Cells("F22").Value = 140
		End Sub
	End Class
End Namespace
