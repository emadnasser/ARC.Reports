Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid.ViewInfo
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Multiselect
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			Design.XViews.ConfigureDemoView(vGridControl1)
			cbMultiselectMode.Properties.Items.AddEnum(Of MultiSelectMode)()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			cheMultiselect.Checked = True
            cbMultiselectMode.EditValue = vGridControl1.OptionsSelectionAndFocus.MultiSelectMode
        End Sub
		Private Function GetBoolValue(ByVal sender As Object) As Boolean
			Return (CType(sender, CheckEdit)).Checked
		End Function
		Private Function GetEnum(Of T)(ByVal sender As Object) As T
			Return CType((CType(sender, ImageComboBoxEdit)).EditValue, T)
		End Function
        Private Sub cheMultiselectCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheMultiselect.CheckedChanged
            Dim value As Boolean = GetBoolValue(sender)
            vGridControl1.OptionsSelectionAndFocus.MultiSelect = value
            cbMultiselectMode.Enabled = value
        End Sub
        Private Sub cbMultiselectModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMultiselectMode.SelectedIndexChanged
			vGridControl1.OptionsSelectionAndFocus.MultiSelectMode = GetEnum(Of MultiSelectMode)(sender)
		End Sub
		Private rnd As New Random()
        Private Sub sbSelectSomeElementsClick(ByVal sender As Object, ByVal e As EventArgs) Handles sbSelectSomeElements.Click
            vGridControl1.ClearSelection()
            Dim iterationCount As Integer = -1
            Select Case vGridControl1.OptionsSelectionAndFocus.MultiSelectMode
                Case MultiSelectMode.RecordSelect
                    iterationCount = rnd.Next(1, vGridControl1.RecordCount)
                Case MultiSelectMode.RowSelect
                    iterationCount = rnd.Next(1, vGridControl1.ViewInfo.RowsViewInfo.Count)
                Case MultiSelectMode.CellSelect
                    iterationCount = rnd.Next(1, vGridControl1.ViewInfo.RowsViewInfo.Count * vGridControl1.RecordCount)
            End Select
            For i As Integer = 0 To iterationCount - 1
                Dim record As Integer = rnd.Next(0, vGridControl1.RecordCount)
                Dim rowIndex As Integer = rnd.Next(0, vGridControl1.ViewInfo.RowsViewInfo.Count)
                Dim row As BaseRow = vGridControl1.ViewInfo.RowsViewInfo.Cast(Of BaseRowViewInfo)().ToArray()(rowIndex).Row
                Dim cell As Integer = rnd.Next(0, row.RowPropertiesCount)
                Select Case vGridControl1.OptionsSelectionAndFocus.MultiSelectMode
                    Case MultiSelectMode.RecordSelect
                        vGridControl1.SelectRecord(record)
                    Case MultiSelectMode.RowSelect
                        vGridControl1.SelectRow(row)
                    Case MultiSelectMode.CellSelect
                        vGridControl1.SelectCell(record, row, cell)
                End Select
            Next i
        End Sub
    End Class
End Namespace
