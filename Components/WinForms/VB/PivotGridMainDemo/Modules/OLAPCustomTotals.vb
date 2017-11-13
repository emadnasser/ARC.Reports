Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPivotGrid.Demos.Helpers

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OlapCustomTotals
		Inherits TutorialControl
		Private fieldQuantity, fieldCategories As PivotGridField
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\OlapCustomTotals.vb"
            TutorialInfo.WhatsThisXMLFile = "OlapCustomTotals.xml"

			Dim success As Boolean = OLAPConfigurator.CreateSampleOLAPConfiguration(pivotGridControl)

			panelError.Visible = Not success
			separator1.Visible = Not success
			panelControl1.Enabled = success

			fieldCategories = pivotGridControl.Fields(OLAPConfigurator.CategoriesFieldName)
			If fieldCategories IsNot Nothing Then
				fieldCategories.TotalsVisibility = PivotTotalsVisibility.CustomTotals
			End If

			fieldQuantity = pivotGridControl.Fields(OLAPConfigurator.QuantityFieldName)
			If fieldQuantity IsNot Nothing Then
				fieldQuantity.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
				fieldQuantity.TotalCellFormat.FormatString = "f2"
			End If
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If fieldCategories IsNot Nothing Then
				fieldCategories.ExpandValue("Beverages")
				SetCustomTotals(fieldCategories.CustomTotals)
			End If
			UpdateListBoxColor(totalsListBox)
		End Sub
		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			UpdateListBoxColor(totalsListBox)
		End Sub
		'<totalsListBox>
		Private Sub chListBox_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles totalsListBox.ItemCheck
			If fieldCategories IsNot Nothing Then
				SetCustomTotals(fieldCategories.CustomTotals)
			End If
		End Sub
		Private Sub SetCustomTotals(ByVal totals As PivotGridCustomTotalCollection)
			totals.Clear()
			For i As Integer = 0 To totalsListBox.Items.Count - 1
				If totalsListBox.Items(i).CheckState = CheckState.Checked Then
					totals.Add(CType(System.Enum.Parse(GetType(PivotSummaryType), CStr(totalsListBox.Items(i).Value)), PivotSummaryType))
				End If
			Next i
		End Sub
		'</totalsListBox>
	End Class
End Namespace
