Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for frmStyleConditions.
	''' </summary>
	Partial Public Class frmStyleConditions
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal location As Point, ByVal field As PivotGridField)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.Location = location
			Me.field = field
			FillData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private WithEvents conditionItem1 As DevExpress.XtraPivotGrid.Demos.ConditionItem
		Private field As PivotGridField
		Private Sub FillData()
			FormatItemList.Items.Clear()
			If field Is Nothing Then
				Return
			End If
			For i As Integer = 0 To field.PivotGrid.FormatConditions.Count - 1
				If field.Equals(field.PivotGrid.FormatConditions(i).Field) Then
					FormatItemList.Items.Add(New DemoFormatCondition(field.PivotGrid.FormatConditions(i)))
				End If
			Next i
			If FormatItemList.Items.Count > 0 Then
				FormatItemList.SelectedIndex = 0
			Else
				conditionItem1.InitItem(Nothing)
			End If
		End Sub

		Private Sub SetRemoveEnabled()
			sbRemove.Enabled = FormatItemList.SelectedIndex > -1
		End Sub

		Private Sub FormatItemList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormatItemList.SelectedIndexChanged
			SetRemoveEnabled()
			If FormatItemList.SelectedItem IsNot Nothing Then
				conditionItem1.InitItem(field.PivotGrid.FormatConditions((CType(FormatItemList.SelectedItem, DemoFormatCondition)).Index))
			Else
				conditionItem1.InitItem(Nothing)
			End If
		End Sub

		Private Sub sbAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAdd.Click
			FormatItemList.Items.BeginUpdate()
			Dim item As New PivotGridStyleFormatCondition()
			item.Field = Me.field
			field.PivotGrid.FormatConditions.Add(item)
			Dim demoCondition As New DemoFormatCondition(item)
			FormatItemList.Items.Add(demoCondition)
			FormatItemList.SelectedItem = demoCondition
			FormatItemList.Items.EndUpdate()
		End Sub

		Private Sub sbRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRemove.Click
			Dim condition As DemoFormatCondition = TryCast(FormatItemList.SelectedItem, DemoFormatCondition)
			If condition Is Nothing Then
				Return
			End If
			field.PivotGrid.FormatConditions.Remove(condition.StyleCondition)
			FormatItemList.Items.Remove(condition)
		End Sub

		Private Sub frmStyleConditions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
			If e.KeyCode = Keys.Escape Then
				Me.Close()
			End If
		End Sub

		Private Sub conditionItem1_RefreshValues(ByVal sender As Object, ByVal e As System.EventArgs) Handles conditionItem1.RefreshValues
			FormatItemList.Refresh()
		End Sub
	End Class
End Namespace
