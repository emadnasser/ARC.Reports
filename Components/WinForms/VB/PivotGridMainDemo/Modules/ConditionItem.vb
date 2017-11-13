Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Namespace DevExpress.XtraPivotGrid.Demos
	Partial Public Class ConditionItem
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			InitializeComponent()
			InitConditions()
		End Sub

		Private init As Boolean = False
		Private item As PivotGridStyleFormatCondition = Nothing
		Public Event RefreshValues As EventHandler
		Private Sub InitConditions()
			icbCondition.Properties.Items.AddEnum(GetType(FormatConditionEnum))
		End Sub

		Public Sub InitItem(ByVal item As PivotGridStyleFormatCondition)
			Me.item = item
			init = True
			Dim IsNull As Boolean = item Is Nothing
			If (Not IsNull) Then
				propertyGrid1.PropertyGrid.SelectedObject = item.Appearance
				icbCondition.EditValue = item.Condition
				seValue1.EditValue = item.Value1
				seValue2.EditValue = item.Value2
				ceCell.Checked = item.ApplyToCell
				ceTotalCell.Checked = item.ApplyToTotalCell
				ceGrandTotalCell.Checked = item.ApplyToGrandTotalCell
				ceCustomSummaryCell.Checked = item.ApplyToCustomTotalCell
			Else
				propertyGrid1.PropertyGrid.SelectedObject = Nothing
				icbCondition.EditValue = Nothing
				seValue2.EditValue = 0
				seValue1.EditValue = seValue2.EditValue
				ceCustomSummaryCell.Checked = False
				ceGrandTotalCell.Checked = ceCustomSummaryCell.Checked
				ceTotalCell.Checked = ceGrandTotalCell.Checked
				ceCell.Checked = ceTotalCell.Checked
			End If
			ceCustomSummaryCell.Enabled = Not IsNull
			ceGrandTotalCell.Enabled = ceCustomSummaryCell.Enabled
			ceTotalCell.Enabled = ceGrandTotalCell.Enabled
			ceCell.Enabled = ceTotalCell.Enabled
			seValue2.Enabled = ceCell.Enabled
			seValue1.Enabled = seValue2.Enabled
			icbCondition.Enabled = seValue1.Enabled
			init = False
		End Sub

		Private Sub RaiseRefreshValues()
			RaiseEvent RefreshValues(Me, EventArgs.Empty)
		End Sub

		Private Sub icbCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbCondition.SelectedIndexChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.Condition = CType(icbCondition.EditValue, FormatConditionEnum)
			RaiseRefreshValues()
		End Sub

		Private Sub seValue1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seValue1.EditValueChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.Value1 = seValue1.Value
			RaiseRefreshValues()
		End Sub

		Private Sub seValue2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seValue2.EditValueChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.Value2 = seValue2.Value
			RaiseRefreshValues()
		End Sub

		Private Sub ceCell_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCell.CheckedChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.ApplyToCell = ceCell.Checked
		End Sub

		Private Sub ceTotalCell_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceTotalCell.CheckedChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.ApplyToTotalCell = ceTotalCell.Checked
		End Sub

		Private Sub ceGrandTotalCell_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceGrandTotalCell.CheckedChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.ApplyToGrandTotalCell = ceGrandTotalCell.Checked
		End Sub

		Private Sub ceCustomSummaryCell_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCustomSummaryCell.CheckedChanged
			If init OrElse item Is Nothing Then
				Return
			End If
			item.ApplyToCustomTotalCell = ceCustomSummaryCell.Checked
		End Sub
	End Class
End Namespace
