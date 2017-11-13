Imports Microsoft.VisualBasic
Imports System.IO
Imports DemosExport
Imports DevExpress.Export
Imports DevExpress.Web
Imports DevExpress.XtraPrinting

Partial Public Class Exporting_ExportWithFormatConditions
	Inherits System.Web.UI.Page
	Protected Sub ToolbarExport_ItemClick(ByVal source As Object, ByVal e As ExportItemClickEventArgs)
		Select Case e.ExportType
			Case DemoExportFormat.Pdf
				cardViewExport.WritePdfToResponse()
			Case DemoExportFormat.Xls
				cardView.Columns("PhotoUrl").Visible = False
				cardViewExport.WriteXlsToResponse(New XlsExportOptionsEx() With {.ExportType = ExportType.DataAware})
			Case DemoExportFormat.Xlsx
				cardView.Columns("PhotoUrl").Visible = False
				cardViewExport.WriteXlsxToResponse(New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware})
			Case DemoExportFormat.Rtf
				cardViewExport.WriteRtfToResponse()
		End Select
	End Sub
	Protected Sub cardViewExport_RenderBrick(ByVal sender As Object, ByVal e As ASPxCardViewExportRenderingEventArgs)
		If e.Column.FieldName = "PhotoUrl" Then
			Dim path = MapPath(e.Value.ToString())
			If File.Exists(path) Then
				e.ImageValue = File.ReadAllBytes(path)
			End If
		End If
	End Sub
End Class
