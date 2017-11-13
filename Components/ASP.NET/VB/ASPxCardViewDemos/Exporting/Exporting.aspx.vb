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
				cardViewExport.WritePdfToResponse()
			Case DemoExportFormat.Xls
				cardViewExport.WriteXlsToResponse(New XlsExportOptionsEx() With {.ExportType = ExportType.DataAware})
			Case DemoExportFormat.Xlsx
				cardViewExport.WriteXlsxToResponse(New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware})
			Case DemoExportFormat.Rtf
				cardViewExport.WriteRtfToResponse()
		End Select
	End Sub
End Class
