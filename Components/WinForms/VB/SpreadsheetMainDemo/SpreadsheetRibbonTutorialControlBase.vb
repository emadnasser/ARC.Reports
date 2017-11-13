Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars.Ribbon
Imports System

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class SpreadsheetRibbonTutorialControlBase
		Inherits SpreadSheetTutorialControlBase
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture

			SubscribeEvents()
		End Sub

		#Region "Properties"
		Protected Friend Overridable ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return homeRibbonPage1
			End Get
		End Property
		#End Region

		Protected Friend Overridable Sub SubscribeEvents()
			AddHandler spreadsheetControl1.CellEndEdit, AddressOf spreadsheetControl1_CellEndEditOverride
			AddHandler spreadsheetControl1.CellValueChanged, AddressOf spreadsheetControl1_CellValueChangedOverride
		End Sub

		Protected Overridable Sub spreadsheetControl1_CellValueChangedOverride(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
		End Sub
		Protected Overridable Sub spreadsheetControl1_CellEndEditOverride(ByVal sender As Object, ByVal e As SpreadsheetCellValidatingEventArgs)
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim selectedPage As RibbonPage = SelectedRibbonPage
			If selectedPage IsNot Nothing Then
				ribbonControl1.SelectedPage = selectedPage
			End If
		End Sub
	End Class
End Namespace
