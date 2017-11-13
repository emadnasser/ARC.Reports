Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraVerticalGrid.Rows

Namespace DevExpress.XtraVerticalGrid.Demos
    Partial Public Class FindPanel
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
            cheHighlightFindResults.Checked = vGridControl1.OptionsFind.HighlightFindResults
            cheClearFindOnClose.Checked = vGridControl1.OptionsFind.ClearFindOnClose
            cheShowCloseButton.Checked = vGridControl1.OptionsFind.ShowCloseButton
            cheShowClearButton.Checked = vGridControl1.OptionsFind.ShowClearButton
            cheShowFindButton.Checked = vGridControl1.OptionsFind.ShowFindButton
            cbFindDelay.EditValue = vGridControl1.OptionsFind.FindDelay

            cbVisibility.Properties.Items.AddEnum(Of FindPanelVisibility)()
            cbVisibility.EditValue = vGridControl1.OptionsFind.Visibility

            cbFindMode.Properties.Items.AddEnum(Of FindMode)()
            cbFindMode.EditValue = vGridControl1.OptionsFind.FindMode

            cbFindFilterColumns.Properties.Items.AddRange(GetFindFilterColumnItems(vGridControl1))
        End Sub



        Private Sub cheHighlightFindResults_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightFindResults.CheckedChanged
            vGridControl1.OptionsFind.HighlightFindResults = GetBoolValue(sender)
        End Sub
        Private Sub cheClearFindOnClose_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheClearFindOnClose.CheckedChanged
            vGridControl1.OptionsFind.ClearFindOnClose = GetBoolValue(sender)
        End Sub
        Private Sub cheShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheShowCloseButton.CheckedChanged
            vGridControl1.OptionsFind.ShowCloseButton = GetBoolValue(sender)
        End Sub
        Private Sub cheShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheShowClearButton.CheckedChanged
            vGridControl1.OptionsFind.ShowClearButton = GetBoolValue(sender)
        End Sub
        Private Sub cheShowFindButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheShowFindButton.CheckedChanged
            vGridControl1.OptionsFind.ShowFindButton = GetBoolValue(sender)
        End Sub
        Private Sub cbFindDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFindDelay.EditValueChanged
            vGridControl1.OptionsFind.FindDelay = GetInteger(sender)
        End Sub
        Private Sub cbVisibility_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVisibility.EditValueChanged
            vGridControl1.OptionsFind.Visibility = GetEnum(Of FindPanelVisibility)(sender)
        End Sub
        Private Sub cbFindMode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFindMode.EditValueChanged
            vGridControl1.OptionsFind.FindMode = GetEnum(Of FindMode)(sender)
        End Sub
        Private Sub cbFindFilterColumns_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFindFilterColumns.EditValueChanged
            Dim edit As CheckedComboBoxEdit = DirectCast(sender, CheckedComboBoxEdit)
            Dim findFilterColumnsText As String = edit.Text.Replace(", ", ";")
            If findFilterColumnsText <> "*" Then
                findFilterColumnsText = findFilterColumnsText.Replace("*;", "")
            End If
            vGridControl1.OptionsFind.FindFilterColumns = findFilterColumnsText
        End Sub

        Private Function GetFindFilterColumnItems(ByVal vGrid As VGridControlBase) As CheckedListBoxItem()
            Dim items As New List(Of CheckedListBoxItem)()
            items.Add(New CheckedListBoxItem("*", "*", CheckState.Checked))
            For Each row As BaseRow In vGrid.VisibleRows
                For Each properties As RowProperties In row.GetRowProperties()
                    If properties.Bindable Then
                        items.Add(New CheckedListBoxItem(properties.FieldName, properties.Caption))
                    End If
                Next properties
            Next row
            Return items.ToArray()
        End Function
        Private Function GetEnum(Of T)(ByVal sender As Object) As T
            Return CType(DirectCast(sender, ImageComboBoxEdit).EditValue, T)
        End Function
        Private Function GetInteger(ByVal sender As Object) As Integer
            Return Convert.ToInt32(DirectCast(sender, BaseEdit).EditValue)
        End Function
        Private Function GetBoolValue(ByVal sender As Object) As Boolean
            Return DirectCast(sender, CheckEdit).Checked
        End Function
    End Class
End Namespace
