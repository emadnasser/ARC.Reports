Imports Microsoft.VisualBasic
Imports System
Imports DemosExport
Imports DevExpress.Data
Imports DevExpress.Export
Imports DevExpress.Web
Imports DevExpress.XtraPrinting

Partial Public Class Exporting_ExportSelected
	Inherits System.Web.UI.Page
	Protected Sub ToolbarExport_ItemClick(ByVal source As Object, ByVal e As ExportItemClickEventArgs)
		Select Case e.ExportType
			Case DemoExportFormat.Pdf
				gridExport.WritePdfToResponse()
			Case DemoExportFormat.Xls
				gridExport.WriteXlsToResponse(New XlsExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
			Case DemoExportFormat.Xlsx
				gridExport.WriteXlsxToResponse(New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
			Case DemoExportFormat.Rtf
				gridExport.WriteRtfToResponse()
			Case DemoExportFormat.Csv
				gridExport.WriteCsvToResponse(New CsvExportOptionsEx() With {.ExportType = ExportType.WYSIWYG})
		End Select
	End Sub
	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName <> "Total" Then
			Return
		End If
		Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
		Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("UnitsInStock"))
		e.Value = price * quantity
	End Sub
	Protected Sub grid_CustomSummaryCalculate(ByVal sender As Object, ByVal e As CustomSummaryEventArgs)
		If Object.Equals(e.Item, grid.TotalSummary("ProductName")) Then
			e.TotalValue = grid.Selection.Count
			e.TotalValueReady = True
		End If
		If Object.Equals(e.Item, grid.TotalSummary("Total")) Then
			If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
				e.TotalValue = 0
			End If
			If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
				Dim keyValue As Object = e.GetValue("ProductID")
				If grid.Selection.IsRowSelectedByKey(keyValue) Then
					e.TotalValue = Convert.ToDecimal(e.TotalValue) + Convert.ToDecimal(e.FieldValue)
				End If
			End If
		End If
	End Sub
	Protected Sub grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		If e.Parameters = "Refresh" Then
			grid.DataBind()
		End If
	End Sub
End Class
