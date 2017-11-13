Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports System

Namespace DevExpress.Docs.Demos
	Public Class CellArtDocumentGenerator
		Private image As Bitmap

		Public Sub New(ByVal image As Bitmap)
			Me.image = image
		End Sub

		Public Function Generate() As IWorkbook
			Dim workbook As IWorkbook = New Workbook()
			CreateCellArt(workbook, Me.image)
			Return workbook
		End Function
		Private Sub CreateCellArt(ByVal book As IWorkbook, ByVal image As Bitmap)
			book.Unit = Office.DocumentUnit.Point
			Dim sheet As Worksheet = book.Worksheets(0)

			Dim width As Integer = image.Width
			Dim height As Integer = image.Height
			Dim c As Double = 100000R / (width * height)
			Dim [step] As Double = Math.Sqrt(c)
			If c < 1 Then
				width = CInt(Fix(width * [step]))
				height = CInt(Fix(height * [step]))
			Else
				[step] = 1
			End If
			Dim cx As Integer = -1
			Dim cy As Integer = -1

			For x As Integer = 0 To image.Width - 1
				For y As Integer = 0 To image.Height - 1
					If cx <> CInt(Fix(x * [step])) OrElse cy <> CInt(Fix(y * [step])) Then
						cx = CInt(Fix(x * [step]))
						cy = CInt(Fix(y * [step]))
						Dim pixel As Color = image.GetPixel(x, y)
						Dim cell As Cell = sheet.Cells(cy, cx)
						If (Not IsTransparentOrEmpty(pixel)) Then
							cell.Fill.PatternType = PatternType.Solid
							cell.Fill.BackgroundColor = pixel
						End If
					End If
				Next y
			Next x
			sheet.ActiveView.ShowGridlines = False
			Dim range As Range = sheet.Range.FromLTRB(0, 0, width, height)
			range.ColumnWidth = 0.75
			range.RowHeight = 0.75
		End Sub
		Private Function IsTransparentOrEmpty(ByVal color As Color) As Boolean
			Return color.A = 0
		End Function
	End Class
End Namespace
