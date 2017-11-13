Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraSpreadsheet.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class CommentsModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()

			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Comments_template.xlsx"), DocumentFormat.Xlsx)
		End Sub

		#Region "Properties"
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return reviewRibbonPage1
			End Get
		End Property
		#End Region
	End Class
End Namespace
