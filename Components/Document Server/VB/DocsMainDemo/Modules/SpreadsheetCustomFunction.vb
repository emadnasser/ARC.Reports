Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetCustomFunctionModule
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "CustomFunction"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			InitializePreviewControl()
			Dim generator As New CustomFunctionDocumentGenerator(DefaultCulture)
			Return generator.Generate()
		End Function

		Private Sub InitializePreviewControl()
			SpreadsheetTutorialPanel.Location = Point.Empty
		End Sub
	End Class
End Namespace
