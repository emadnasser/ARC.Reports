Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class TotalsLocation
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\TotalsLocation.vb"
            TutorialInfo.WhatsThisXMLFile = "TotalsLocation.xml"

			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property

		Private Sub TotalsLocation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			pivotGridControl1.ValueImages = CategoryImageList
			InitComboBoxes()
		End Sub

		Private Sub InitComboBoxes()
			columnTotalsLocations.Properties.Items.AddEnum(GetType(PivotTotalsLocation))
			columnTotalsLocations.EditValue = pivotGridControl1.OptionsView.ColumnTotalsLocation

			rowTotalsLocations.Properties.Items.AddEnum(GetType(PivotRowTotalsLocation))
			rowTotalsLocations.EditValue = pivotGridControl1.OptionsView.RowTotalsLocation
		End Sub

		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub
		'<columnTotalsLocations>
		Private Sub icbTotalsLocations_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles columnTotalsLocations.SelectedIndexChanged
			pivotGridControl1.OptionsView.ColumnTotalsLocation = CType(columnTotalsLocations.EditValue, PivotTotalsLocation)
		End Sub
		'</columnTotalsLocations>
		'<rowTotalsLocations>
		Private Sub rowTotalsLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rowTotalsLocations.SelectedIndexChanged
			If Comparer.Equals(CType(rowTotalsLocations.EditValue, PivotRowTotalsLocation), PivotRowTotalsLocation.Tree) AndAlso pivotGridControl1.OptionsView.ShowRowTotals = False Then
				pivotGridControl1.OptionsView.ShowRowTotals = True
			End If
			pivotGridControl1.OptionsView.RowTotalsLocation = CType(rowTotalsLocations.EditValue, PivotRowTotalsLocation)
		End Sub
		'</rowTotalsLocations>
	End Class
End Namespace

