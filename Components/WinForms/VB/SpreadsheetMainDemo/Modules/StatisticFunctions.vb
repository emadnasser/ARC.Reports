Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class StatisticFunctionsModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private workbook As IWorkbook

		Public Sub New()
			InitializeComponent()
			InitializeWorkbook()
			Me.spreadsheetControl1.Document.History.Clear()
		End Sub

		#Region "Properties"
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return formulasRibbonPage1
			End Get
		End Property
		#End Region

		#Region "Sample workbook initialization"
		Private Sub InitializeWorkbook()
			workbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("TrendlineAnalysis_template.xlsx"))
		End Sub
		#End Region
	End Class
End Namespace
