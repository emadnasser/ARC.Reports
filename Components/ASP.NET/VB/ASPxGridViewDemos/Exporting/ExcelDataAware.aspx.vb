Imports Microsoft.VisualBasic
Imports System
Imports DemosExport
Imports DevExpress.Export
Imports DevExpress.XtraPrinting

Partial Public Class Exporting_ExcelDataAware
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Grid.ExpandRow(0)
		End If
		Exporter.ExportSelectedRowsOnly = Convert.ToBoolean(ExportRowTypeComboBox.SelectedIndex)
	End Sub

	Protected Sub ToolbarExport_ItemClick(ByVal source As Object, ByVal e As DemosExport.ExportItemClickEventArgs)
		Select Case e.ExportType
			Case DemoExportFormat.Xls
				Exporter.WriteXlsToResponse(New XlsExportOptionsEx() With {.ExportType = ExportType.DataAware})
			Case DemoExportFormat.Xlsx
				Exporter.WriteXlsxToResponse(New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware})
			Case DemoExportFormat.Csv
				Exporter.WriteCsvToResponse(New CsvExportOptionsEx() With {.ExportType = ExportType.DataAware})
		End Select
	End Sub
End Class
