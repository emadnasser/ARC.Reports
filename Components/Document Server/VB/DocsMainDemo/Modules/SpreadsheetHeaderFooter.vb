Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet

Namespace DevExpress.Docs.Demos
	Partial Public Class HeaderFooter
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			FitToPageCheckEdit.Checked = True
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub
		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "HeaderFooter"
			End Get
		End Property

		Private Sub InitializePreviewControl()
			SpreadsheetTutorialPanel.Location = Point.Empty
		End Sub
		Public Overrides Function CreateBook() As IWorkbook
			InitializePreviewControl()
			Dim book As IWorkbook = New Workbook()
			book.LoadDocument(DemoUtils.GetRelativePath("HeaderFooter_template.xlsx"))
			Return book
		End Function
	End Class
End Namespace
