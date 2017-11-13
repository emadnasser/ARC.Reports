Imports Microsoft.VisualBasic
Imports System.IO
Imports DemosExport
Imports DevExpress.Export
Imports DevExpress.Web
Imports DevExpress.XtraPrinting

Partial Public Class Exporting_ExportWithDataCellBands
	Inherits System.Web.UI.Page
	Protected Sub ToolbarExport_ItemClick(ByVal source As Object, ByVal e As ExportItemClickEventArgs)
		Select Case e.ExportType
			Case DemoExportFormat.Pdf
				gridExporter.WritePdfToResponse()
			Case DemoExportFormat.Xls
				gridExporter.WriteXlsToResponse(New XlsExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
			Case DemoExportFormat.Xlsx
				gridExporter.WriteXlsxToResponse(New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
			Case DemoExportFormat.Rtf
				gridExporter.WriteRtfToResponse()
		End Select
	End Sub

	Protected Sub gridExporter_RenderBrick(ByVal sender As Object, ByVal e As ASPxGridViewExportRenderingEventArgs)
		If (Not Object.Equals(e.RowType, GridViewRowType.Data)) Then
			Return
		End If
		Dim dataColumn = CType(e.Column, GridViewDataColumn)
		If dataColumn.FieldName = "PhotoUrl" Then
			Dim path = MapPath(e.Value.ToString())
			If File.Exists(path) Then
				e.ImageValue = File.ReadAllBytes(path)
			End If
		End If
	End Sub
End Class
