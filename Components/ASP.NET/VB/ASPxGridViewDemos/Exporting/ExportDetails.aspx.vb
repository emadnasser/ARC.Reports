Imports Microsoft.VisualBasic
Imports System
Imports DemosExport
Imports DevExpress.Export
Imports DevExpress.Web
Imports DevExpress.XtraPrinting

Partial Public Class Exporting_ExportDetails
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ddlExportMode.Items.AddRange(System.Enum.GetNames(GetType(GridViewDetailExportMode)))
			ddlExportMode.Text = GridViewDetailExportMode.Expanded.ToString()
			grid.DataBind()
			grid.DetailRows.ExpandRow(0)
		End If
	End Sub
	Protected Sub detailGrid_BeforePerformDataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Session("CategoryID") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()
	End Sub
	Protected Sub UpdateExportMode()
		grid.SettingsDetail.ExportMode = CType(System.Enum.Parse(GetType(GridViewDetailExportMode), ddlExportMode.Text), GridViewDetailExportMode)
	End Sub
	Protected Sub ToolbarExport_ItemClick(ByVal source As Object, ByVal e As ExportItemClickEventArgs)
		UpdateExportMode()
		Select Case e.ExportType
			Case DemoExportFormat.Pdf
				exporter.WritePdfToResponse()
			Case DemoExportFormat.Xls
				exporter.WriteXlsToResponse(New XlsExportOptionsEx() With {.ExportType = ExportType.WYSIWYG})
			Case DemoExportFormat.Xlsx
				exporter.WriteXlsxToResponse(New XlsxExportOptionsEx() With {.ExportType = ExportType.WYSIWYG})
			Case DemoExportFormat.Rtf
				exporter.WriteRtfToResponse()
			Case DemoExportFormat.Csv
				exporter.WriteCsvToResponse(New CsvExportOptionsEx() With {.ExportType = ExportType.WYSIWYG})
		End Select
	End Sub
End Class
