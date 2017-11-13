Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet

Namespace DevExpress.Docs.Demos
	Partial Public Class PrintTitles
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			FitToPageCheckEdit.Visible = False
			FitToPageCheckEdit.Checked = False
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub
		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "PrintTitles"
			End Get
		End Property

		Private Sub InitializePreviewControl()
			SpreadsheetTutorialPanel.Location = Point.Empty
		End Sub
		Public Overrides Function CreateBook() As IWorkbook
			InitializePreviewControl()
			Dim book As IWorkbook = New Workbook()
			book.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"))
			Return book
		End Function
		'protected override void RefreshPreview() {
			'base.RefreshPreview();
			'this.spreadsheetPreview1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToTwoPages);
		'}
	End Class
End Namespace
