Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports System.Globalization

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetMultiplicationTableModule
		Inherits SpreadsheetTutorialControl

		Public Sub New()
			InitializeComponent()
			RefreshPreview()
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "Multiplication_Table"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			Dim generator As New MultiplicationTableDocumentGenerator(DefaultCulture)
			generator.Width = CInt(Fix(widthSpinEdit.Value))

			generator.Height = CInt(Fix(heightSpinEdit.Value))
			generator.FitToPage = FitToPageCheckEdit.Checked
			generator.CreateInfoCells = createInfoCellsCheckEdit.Checked
			generator.UseSharedFormula = useSharedFormulaCheckEdit.Checked
			Return generator.Generate()
		End Function

		Private Sub ParametersChanged(ByVal sender As Object, ByVal e As EventArgs) Handles widthSpinEdit.EditValueChanged, heightSpinEdit.EditValueChanged, createInfoCellsCheckEdit.CheckedChanged, useSharedFormulaCheckEdit.CheckedChanged
			RefreshPreview()
		End Sub
	End Class
End Namespace
