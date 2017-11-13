Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class Validation
		Inherits TutorialControl
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\Validation.vb"
            TutorialInfo.WhatsThisXMLFile = "Validation.xml"

			pivotGridControl.DataSource = GetNWindData("SalesPerson")
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
			InitValidationControls()
			pivotGridControl.HeaderImages = HeadersImageList
			pivotGridControl.ValueImages = CategoryImageList
			fieldSalesPerson.ImageIndex = 0
			pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
		End Sub

		Private Sub pivotGridControl_EditorValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs) Handles pivotGridControl.EditValueChanged
			If Comparer.ReferenceEquals(e.DataField, fieldQuantity) Then
				Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
				Dim editValue As Integer = Convert.ToInt32(e.Editor.EditValue)
				If ds.RowCount > 0 Then
					Dim newCellValue As Integer = CInt(Fix(Math.Floor(CDec(editValue) / ds.RowCount))), extra As Integer = editValue Mod ds.RowCount
					For i As Integer = 0 To ds.RowCount - 1
						If i = ds.RowCount - 1 Then
							ds(i)(fieldQuantity) = CShort(Fix(newCellValue + extra))
						Else
							ds(i)(fieldQuantity) = CShort(Fix(newCellValue))
						End If
					Next i
				Else
					Dim table As DataTable = (CType(pivotGridControl.DataSource, DataView)).Table
					Dim row(table.Columns.Count - 1) As Object
					SetRowValues(PivotArea.ColumnArea, e, table, row)
					SetRowValues(PivotArea.RowArea, e, table, row)
					Dim columnIndex As Integer = table.Columns.IndexOf(fieldQuantity.FieldName)
					row(columnIndex) = editValue
					table.Rows.Add(row)
					table.AcceptChanges()
					pivotGridControl.RefreshData()
				End If
			End If
		End Sub
		Private Sub SetRowValues(ByVal area As PivotArea, ByVal e As EditValueChangedEventArgs, ByVal table As DataTable, ByVal row() As Object)
			Dim fields As List(Of PivotGridField) = pivotGridControl.GetFieldsByArea(area)
			For i As Integer = 0 To fields.Count - 1
				Dim value As Object = e.GetFieldValue(fields(i))
				Dim columnIndex As Integer = table.Columns.IndexOf(fields(i).FieldName)
				row(columnIndex) = value
			Next i
		End Sub
		'<totalValidation>
		'<commonValidation>
		Private Sub pivotGridControl_ValidatingEditor(ByVal sender As Object, ByVal e As BaseContainerValidateEditorEventArgs) Handles pivotGridControl.ValidatingEditor
			Dim focusedCell As PivotCellEventArgs = GetFocusedCellInfo(pivotGridControl)
			If Comparer.ReferenceEquals(focusedCell.DataField, fieldQuantity) Then
				Dim convertedValue As Integer = 0
				Dim oldValue As Integer = Convert.ToInt32(focusedCell.Value)
				Try
					If IsTotalOrGrandTotal(focusedCell) Then
						convertedValue = Convert.ToInt32(e.Value)
						Dim factor As Double = CDbl(convertedValue) / CDbl(oldValue)
						Dim newMaxValue As Double = factor * Convert.ToDouble(focusedCell.SummaryValue.Max)
						Try
							Convert.ToInt16(newMaxValue)
						Catch
							e.Valid = False
							e.ErrorText = "Value cann't be decomposed to the components of type Int16"
						End Try
						ApplyValidation(totalValidation, convertedValue, e)
					Else
						convertedValue = CInt(Fix(Convert.ToInt16(e.Value)))
						ApplyValidation(commonValidation, convertedValue, e)
					End If
				Catch ex As Exception
					e.Valid = False
					e.ErrorText = ex.Message
				End Try
				e.Value = convertedValue
			End If
		End Sub
		'</commonValidation>
		'</totalValidation>
		Private Sub InitValidationControls()
			commonValidation.spinEdit1.EditValue = 0
			commonValidation.imageComboBoxEdit1.SelectedIndex = 1
			commonValidation.imageComboBoxEdit2.SelectedIndex = 2
			commonValidation.spinEdit2.EditValue = 150
			totalValidation.spinEdit1.EditValue = 0
			totalValidation.imageComboBoxEdit1.SelectedIndex = 1
			totalValidation.imageComboBoxEdit2.SelectedIndex = 2
			totalValidation.spinEdit2.EditValue = 1500
		End Sub
		'<commonValidation>
		'<totalValidation>
		Private Sub ApplyValidation(ByVal validation As ValidationControl, ByVal value As Integer, ByVal e As BaseContainerValidateEditorEventArgs)
			Dim reply() As Object = validation.IsTrueCondition(value)
			If reply IsNot Nothing AndAlso (Not CBool(reply(0))) Then
				e.ErrorText = reply(1).ToString()
				e.Valid = False
			End If
		End Sub
		'</commonValidation>
		'</totalValidation>
		Private Function GetFocusedCellInfo(ByVal pivot As PivotGridControl) As PivotCellEventArgs
			Dim focused As Point = pivot.Cells.FocusedCell
			Return pivot.Cells.GetCellInfo(focused.X, focused.Y)
		End Function

		Private Sub pivotGridControl_CustomAppearance(ByVal sender As Object, ByVal e As PivotCustomAppearanceEventArgs) Handles pivotGridControl.CustomAppearance
			If (Not Comparer.ReferenceEquals(e.DataField, fieldQuantity)) Then
				Return
			End If
			If IsTotalOrGrandTotal(e) Then
				If (Not CBool(totalValidation.IsTrueCondition(e.Value)(0))) Then
					e.Appearance.BackColor = Color.Pink
					e.Appearance.BackColor2 = Color.Pink
				End If
			Else
				If (Not CBool(commonValidation.IsTrueCondition(e.Value)(0))) Then
					e.Appearance.BackColor = Color.Red
					e.Appearance.BackColor2 = Color.Red
				End If
			End If
		End Sub
		Private Function IsTotalOrGrandTotal(ByVal e As PivotCellEventArgs) As Boolean
			Return e.ColumnValueType = PivotGridValueType.Total OrElse e.RowValueType = PivotGridValueType.Total OrElse e.ColumnValueType = PivotGridValueType.GrandTotal OrElse e.RowValueType = PivotGridValueType.GrandTotal
		End Function

		Private Sub validationControl_ValidateCondition(ByVal sender As Object, ByVal e As EventArgs) Handles totalValidation.ValidateCondition, commonValidation.ValidateCondition
			pivotGridControl.LayoutChanged()
		End Sub

		Private Sub pivotGridControl_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs) Handles pivotGridControl.FieldValueImageIndex
			If e.Field Is fieldCategoryName AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub
	End Class
End Namespace
