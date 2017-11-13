Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Export
Imports DevExpress.Utils
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPrinting

Partial Public Class Features_Printing
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Private Sub Export(ByVal saveAs As Boolean)
		For Each field As PivotGridField In ASPxPivotGrid1.Fields
			If field.ValueFormat IsNot Nothing AndAlso (Not String.IsNullOrEmpty(field.ValueFormat.FormatString)) Then
				field.UseNativeFormat = If(checkCustomFormattedValuesAsText.Checked, DefaultBoolean.False, DefaultBoolean.True)
			End If
		Next field

		ASPxPivotGridExporter1.OptionsPrint.PrintHeadersOnEveryPage = checkPrintHeadersOnEveryPage.Checked
		ASPxPivotGridExporter1.OptionsPrint.MergeColumnFieldValues = checkMergeColumnFieldValues.Checked
		ASPxPivotGridExporter1.OptionsPrint.MergeRowFieldValues = checkMergeRowFieldValues.Checked

		ASPxPivotGridExporter1.OptionsPrint.PrintFilterHeaders = If(checkPrintFilterFieldHeaders.Checked, DefaultBoolean.True, DefaultBoolean.False)
		ASPxPivotGridExporter1.OptionsPrint.PrintColumnHeaders = If(checkPrintColumnFieldHeaders.Checked, DefaultBoolean.True, DefaultBoolean.False)
		ASPxPivotGridExporter1.OptionsPrint.PrintRowHeaders = If(checkPrintRowFieldHeaders.Checked, DefaultBoolean.True, DefaultBoolean.False)
		ASPxPivotGridExporter1.OptionsPrint.PrintDataHeaders = If(checkPrintDataFieldHeaders.Checked, DefaultBoolean.True, DefaultBoolean.False)

		Const fileName As String = "PivotGrid"
		Dim options As XlsxExportOptionsEx
		Select Case listExportFormat.SelectedIndex
			Case 0
				ASPxPivotGridExporter1.ExportPdfToResponse(fileName, saveAs)
			Case 1
				options = New XlsxExportOptionsEx() With {.ExportType = ExportType.WYSIWYG}
				ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs)
			Case 2
				ASPxPivotGridExporter1.ExportMhtToResponse(fileName, "utf-8", "ASPxPivotGrid Printing Sample", True, saveAs)
			Case 3
				ASPxPivotGridExporter1.ExportRtfToResponse(fileName, saveAs)
			Case 4
				ASPxPivotGridExporter1.ExportTextToResponse(fileName, saveAs)
			Case 5
				ASPxPivotGridExporter1.ExportHtmlToResponse(fileName, "utf-8", "ASPxPivotGrid Printing Sample", True, saveAs)
			Case 6
				options = New XlsxExportOptionsEx() With {.ExportType = ExportType.DataAware, .AllowGrouping = If(allowGroupingCheckBox.Checked, DefaultBoolean.True, DefaultBoolean.False), .TextExportMode = If(exportCellValuesAsText.Checked, TextExportMode.Text, TextExportMode.Value), .AllowFixedColumns = If(allowFixedColumns.Checked, DefaultBoolean.True, DefaultBoolean.False), .AllowFixedColumnHeaderPanel = If(allowFixedColumns.Checked, DefaultBoolean.True, DefaultBoolean.False), .RawDataMode = exportRawData.Checked}
				ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs)
		End Select
	End Sub

	Protected Sub buttonOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
		Export(False)
	End Sub
	Protected Sub buttonSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs)
		Export(True)
	End Sub
End Class
