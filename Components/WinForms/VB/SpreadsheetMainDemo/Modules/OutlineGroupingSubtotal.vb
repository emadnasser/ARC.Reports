Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class OutlineGroupingSubtotal
		Inherits SpreadsheetRibbonTutorialControlBase

		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OutlineGrouping_template.xlsx"))
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
