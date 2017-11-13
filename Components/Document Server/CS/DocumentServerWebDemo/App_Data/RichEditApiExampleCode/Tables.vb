Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditExamples
	Public NotInheritable Class Tables
		Private Sub New()
		End Sub
		Private Shared Sub CreateTable(ByVal document As Document)
'			#Region "#Create Table"
			document.Tables.Create(document.CaretPosition, 5, 5)
'			#End Region ' #Create Table
		End Sub
		Private Shared Sub ChangeTableStyle(ByVal document As Document)
'			#Region "#Table Style"
			Dim table As Table = document.Tables.Create(document.CaretPosition, 5, 5)
			table.Style.TableBorders.Left.LineColor = DXColor.Coral
			table.Style.TableBorders.Left.LineStyle = TableBorderLineStyle.Double
			table.Style.TableBorders.Left.LineThickness = 5

			table.Style.TableBorders.Top.LineColor = DXColor.Coral
			table.Style.TableBorders.Top.LineStyle = TableBorderLineStyle.Double
			table.Style.TableBorders.Top.LineThickness = 5

			table.Style.TableBorders.Right.LineColor = DXColor.Coral
			table.Style.TableBorders.Right.LineStyle = TableBorderLineStyle.Double
			table.Style.TableBorders.Right.LineThickness = 5

			table.Style.TableBorders.Bottom.LineColor = DXColor.Coral
			table.Style.TableBorders.Bottom.LineStyle = TableBorderLineStyle.Double
			table.Style.TableBorders.Bottom.LineThickness = 5

			table.Style.TableBorders.InsideHorizontalBorder.LineColor = DXColor.Coral
			table.Style.TableBorders.InsideVerticalBorder.LineColor = DXColor.Coral
'			#End Region ' #Table Style
		End Sub
		Private Shared Sub ChangeRowStyle(ByVal document As Document)
'			#Region "#Row Style"
			Dim table As Table = document.Tables.Create(document.CaretPosition, 5, 5)
			table.Rows(0).Height = 100
			For i As Integer = 0 To table.Rows(0).Cells.Count - 1
				table.Rows(0).Cells(i).BackgroundColor = DXColor.Gray
				table.Rows(0).Cells(i).PreferredWidthType = WidthType.Fixed
				table.Rows(0).Cells(i).PreferredWidth = 150
			Next i
'			#End Region ' #Row Style
		End Sub
		Private Shared Sub ChangeColumnStyle(ByVal document As Document)
'			#Region "#Column Style"
			Dim table As Table = document.Tables.Create(document.CaretPosition, 5, 5)
			table(0, 0).PreferredWidthType = WidthType.Fixed
			table(0, 0).PreferredWidth = 400
			For i As Integer = 0 To table.Rows.Count - 1
				table(i, 0).BackgroundColor = DXColor.Maroon
			Next i
'			#End Region ' #Column Style
		End Sub
		Private Shared Sub ChangeCellStyle(ByVal document As Document)
'			#Region "#Cell Style"
			Dim table As Table = document.Tables.Create(document.CaretPosition, 5, 5)
			table(2, 2).PreferredWidthType = WidthType.Fixed
			table(2, 2).PreferredWidth = 400
			table(2, 2).Height = 400
			table(2, 2).BackgroundColor = DXColor.RosyBrown
'			#End Region ' #Cell Style
		End Sub
	End Class
End Namespace
