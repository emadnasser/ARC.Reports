Imports Microsoft.VisualBasic
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing

Namespace DevExpress.XtraSpreadsheet.Demos

	Partial Public Class PivotTableModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Properties"
		Private ReadOnly Property Workbook() As IWorkbook
			Get
				Return spreadsheetControl1.Document
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Me.pivotTableToolsRibbonPageCategory1.Visible = True
				Me.pivotTableAnalyzeRibbonPage1.Visible = True
				Return Me.pivotTableAnalyzeRibbonPage1
			End Get
		End Property
		#End Region

		Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
			MyBase.OnLoad(e)
			ApplyOptions()
			InitializeWorkbook()
		End Sub

		Private Sub InitializeWorkbook()
			Workbook.LoadDocument(DemoUtils.GetRelativePath("PivotTableDemoTemplate.xlsx"))
		End Sub
		Private Sub ApplyOptions()
			Dim pivotTableFieldListOptions As SpreadsheetPivotTableFieldListOptions = spreadsheetControl1.Options.PivotTableFieldList
			pivotTableFieldListOptions.StartPosition = SpreadsheetPivotTableFieldListStartPosition.ManualSpreadsheetControl
			pivotTableFieldListOptions.StartSize = New Size(306, 601)
			Dim width As Double = spreadsheetControl1.Width - pivotTableFieldListOptions.StartSize.Width * (spreadsheetControl1.DpiX / 96.0)
			pivotTableFieldListOptions.StartLocation = New Point(CInt(Fix(width)), 0)
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet("C3")
		End Sub

		Protected Overrides Sub DoHide()
			Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet("A1")
			MyBase.DoHide()
		End Sub
	End Class
End Namespace
