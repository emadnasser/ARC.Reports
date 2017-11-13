Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class BreakevenAnalysisModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			InitializeWorkbook()
		End Sub

		#Region "Properties"
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return insertRibbonPage1
			End Get
		End Property
		#End Region

		Private Sub InitializeWorkbook()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("BreakevenAnalysis.xlsx"))
		End Sub
	End Class
End Namespace
