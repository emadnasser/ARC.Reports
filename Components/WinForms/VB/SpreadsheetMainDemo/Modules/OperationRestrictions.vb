Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Docs.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class OperationRestrictionsModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OperationRestrictions_template.xlsx"), DocumentFormat.Xlsx)

			propertyGridControl1.SelectedObject = New BehaviorOptionsProvider(spreadsheetControl1.Options.Behavior)
			propertyGridControl1.RowHeaderWidth = 110
			propertyGridControl1.OptionsView.ShowRootCategories = False
			propertyGridControl1.ExpandAllRows()
			InitializeZoomFactors()
		End Sub

		Private Sub InitializeZoomFactors()
			spreadsheetControl1.Options.Behavior.MaxZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MaxZoomFactorDefault
			spreadsheetControl1.Options.Behavior.MinZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MinZoomFactorDefault
		End Sub

		#Region "Events"
		Private Sub edtReadOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtReadOnly.CheckedChanged
			spreadsheetControl1.ReadOnly = (CType(sender, CheckEdit)).Checked
		End Sub
		#End Region
	End Class

End Namespace
