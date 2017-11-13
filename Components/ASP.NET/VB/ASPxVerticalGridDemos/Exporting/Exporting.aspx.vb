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
				verticalGridExport.WritePdfToResponse()
			Case DemoExportFormat.Xls
				verticalGridExport.WriteXlsToResponse()
			Case DemoExportFormat.Xlsx
				verticalGridExport.WriteXlsxToResponse()
			Case DemoExportFormat.Rtf
				verticalGridExport.WriteRtfToResponse()
		End Select
	End Sub
End Class
