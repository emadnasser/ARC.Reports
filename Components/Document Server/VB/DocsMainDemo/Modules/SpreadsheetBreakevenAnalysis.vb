Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation

Namespace DevExpress.Docs.Demos
	Partial Public Class BreakevenAnalysis
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			FitToPageCheckEdit.Checked = True
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub
		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "BreakevenAnalysis"
			End Get
		End Property

		Private Sub InitializePreviewControl()
			SpreadsheetTutorialPanel.Location = Point.Empty
		End Sub
		Public Overrides Function CreateBook() As IWorkbook
			InitializePreviewControl()
			Dim book As IWorkbook = New Workbook()
			book.AddService(GetType(IChartControllerFactoryService), New ChartControllerFactoryService())
			book.AddService(GetType(IChartImageService), New ChartImageService())
			book.LoadDocument(DemoUtils.GetRelativePath("BreakevenAnalysis.xlsx"))
			Return book
		End Function
	End Class
End Namespace
