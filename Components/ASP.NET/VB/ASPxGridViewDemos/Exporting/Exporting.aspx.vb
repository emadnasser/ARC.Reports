Imports Microsoft.VisualBasic
Imports System
Imports DemosExport
Imports DevExpress.Export
Imports DevExpress.XtraPrinting

Partial Public Class Exporting_Exporting
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
End Class
