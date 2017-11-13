Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid.Localization

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class TopValues
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\TopValues.vb"
            TutorialInfo.WhatsThisXMLFile = "TopValues.xml"

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
		'<icbField>
		Private Sub TopValues_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = GetNWindData("SalesPerson")
			InitComboBoxes()
			icbField.SelectedIndex = icbField.Properties.Items.Count - 1

			pivotGridControl1.HeaderImages = HeadersImageList
			pivotGridControl1.ValueImages = CategoryImageList
			fieldSalesPerson.ImageIndex = 0
			pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
		End Sub

		Private Sub InitComboBoxes()
			For Each field As PivotGridField In pivotGridControl1.Fields
				If field.SortBySummaryInfo.Field Is fieldExtendedPrice Then
					icbField.Properties.Items.Add(New ImageComboBoxItem(field.Caption.ToString(), field, -1))
				End If
			Next field
		End Sub
		Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbField.SelectedIndexChanged
			pivotGridControl1.BeginUpdate()
			For Each field As PivotGridField In pivotGridControl1.Fields
				If field.SortBySummaryInfo.Field Is fieldExtendedPrice Then
					field.Area = PivotArea.RowArea
					Dim IsVisible As Boolean = field Is CType(icbField.EditValue, PivotGridField)
					field.Visible = IsVisible
					If IsVisible Then
						seTop.Properties.MaxValue = field.GetUniqueValues().Length
						SetFieldTop()
					End If
				End If
			Next field
			pivotGridControl1.EndUpdate()
		End Sub
		'</icbField>
		'<seTop>
		'<ceTopValuesShowOthers>
		Private Sub seTop_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTop.EditValueChanged
			SetFieldTop()
		End Sub
		Private Sub SetFieldTop()
			Dim field As PivotGridField = TryCast(icbField.EditValue, PivotGridField)
			If field Is Nothing Then
				Return
			End If
			field.TopValueCount = Convert.ToInt32(seTop.Value)
			field.TopValueShowOthers = ceTopValuesShowOthers.Checked
		End Sub
		'</ceTopValuesShowOthers>
		'</seTop>
		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) AndAlso (Not e.IsOthersValue) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub
		Private Sub ceTopValuesShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceTopValuesShowOthers.CheckedChanged
			SetFieldTop()
		End Sub
		Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs) Handles pivotGridControl1.CustomDrawFieldValue
			If e.IsOthersValue Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
			End If
		End Sub
	End Class
End Namespace

