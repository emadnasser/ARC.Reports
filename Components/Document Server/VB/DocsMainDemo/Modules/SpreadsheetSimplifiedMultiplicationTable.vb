Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetSimplifiedMultiplicationTableModule
		Inherits SpreadsheetTutorialControl

		Public Sub New()
			InitializeComponent()
			RefreshPreview()
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "Simplified_Multiplication_Table"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			Dim generator As New SimplifiedMultiplicationTableDocumentGenerator(DefaultCulture)
			generator.ColumnCount = CInt(Fix(columnsSpinEdit.Value))
			generator.TableCount = CInt(Fix(tableCountSpinEdit.Value))
			generator.FitToPage = FitToPageCheckEdit.Checked
			Return generator.Generate()
		End Function
		Private Sub spinEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tableCountSpinEdit.EditValueChanged, columnsSpinEdit.EditValueChanged
			RefreshPreview()
		End Sub
	End Class
End Namespace
