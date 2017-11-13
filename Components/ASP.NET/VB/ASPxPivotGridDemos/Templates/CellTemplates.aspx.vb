Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxPivotGrid
Imports System.Drawing
Imports DevExpress.XtraPivotGrid

Partial Public Class Appearance_CellTemplate
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		pivotGrid.CellTemplate = New CellTemplate()
	End Sub
	Private Class CellTemplate
		Implements ITemplate

		Private Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			Dim templateContainer As PivotGridCellTemplateContainer = CType(container, PivotGridCellTemplateContainer)
			Dim field As DevExpress.Web.ASPxPivotGrid.PivotGridField = templateContainer.DataField

			If field IsNot Nothing AndAlso field.Caption = "Percents" Then
				Dim value As Integer = Convert.ToInt32(Convert.ToDecimal(templateContainer.Value) * 350)

				Dim table As New Table()
				table.Width = Unit.Pixel(400)
				templateContainer.Controls.Add(table)

				Dim row As New TableRow()
				table.Controls.Add(row)

				Dim cell As New TableCell()
				cell.Style.Add(HtmlTextWriterStyle.Padding, "0px")
				cell.Width = Unit.Pixel(value)
				cell.Height = Unit.Pixel(20)
				If templateContainer.Item.RowValueType = PivotGridValueType.Total Then
					cell.BackColor = Color.FromArgb(148, 184, 243)
				Else
					cell.BackColor = Color.FromArgb(243, 148, 164)
				End If
				If templateContainer.Item.RowValueType = PivotGridValueType.GrandTotal Then
					cell.BackColor = Color.FromArgb(134, 206, 128)
				End If
				row.Controls.Add(cell)

				cell = New TableCell()
				cell.Text = templateContainer.Item.Text
				cell.Wrap = False
				row.Controls.Add(cell)
			Else
				templateContainer.Controls.Add(New LiteralControl(templateContainer.Text))
			End If
		End Sub
	End Class
End Class
