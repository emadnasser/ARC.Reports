Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraSpreadsheet.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DataValidationModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()

			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataValidation_template.xlsx"), DocumentFormat.Xlsx)
			spreadsheetControl1.Options.Behavior.Drawing.Move = DocumentCapability.Disabled
			spreadsheetControl1.Options.Behavior.Drawing.Resize = DocumentCapability.Disabled
			spreadsheetControl1.Options.Behavior.Drawing.Rotate = DocumentCapability.Disabled
		End Sub

		#Region "Properties"
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return dataRibbonPage1
			End Get
		End Property
		#End Region
	End Class
End Namespace
