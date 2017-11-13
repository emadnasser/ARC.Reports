Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CompactLayout
		Inherits TutorialControl
		Protected Overrides ReadOnly Property HideCustFormWhenSwitchDemo() As Boolean
			Get
				Return False
			End Get
		End Property
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\CompactLayout.vb"
            TutorialInfo.WhatsThisXMLFile = "CompactLayout.xml"
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
		Protected ReadOnly Property IsCompactLayout() As Boolean
			Get
				Return CBool(groupLayout.EditValue)
			End Get
		End Property

		Private Sub CompactLayout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			pivotGridControl1.ValueImages = CategoryImageList
			pivotGridControl1.BestFit()
			pivotGridControl1.CollapseAll()
			pivotGridControl1.FieldsCustomization(splitContainerControl1.Panel1)
			pivotGridControl1.ExpandValue(False, New Object() { "Andrew Fuller" })
			pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = True
			pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = True
		End Sub

		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso (IsCompactLayout OrElse Comparer.Equals(e.ValueType, PivotGridValueType.Value)) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		'<groupLayout>
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles groupLayout.SelectedIndexChanged
			If IsCompactLayout Then
				pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree
				pivotGridControl1.OptionsBehavior.HorizontalScrolling = PivotGridScrolling.CellsArea
			Else
				pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far
				pivotGridControl1.OptionsBehavior.HorizontalScrolling = PivotGridScrolling.Control
			End If
		End Sub
		'</groupLayout>
	End Class
End Namespace
