Imports Microsoft.VisualBasic
Imports System
Imports DemosExport

Partial Public Class Exporting_ExportWithFormatConditions
	Inherits System.Web.UI.Page
	Protected Sub ToolbarExport_ItemClick(ByVal source As Object, ByVal e As ExportItemClickEventArgs)
		Select Case e.ExportType
			Case DemoExportFormat.Pdf
				Exporter.WritePdfToResponse()
			Case DemoExportFormat.Xls
				Exporter.WriteXlsToResponse()
			Case DemoExportFormat.Xlsx
				Exporter.WriteXlsxToResponse()
			Case DemoExportFormat.Rtf
				Exporter.WriteRtfToResponse()
		End Select
	End Sub
End Class
