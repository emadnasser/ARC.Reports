Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for ConditionsEditor.
    ''' </summary>
    Partial Public Class ConditionsEditor
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New(ByVal column As GridColumn, ByVal parent As Form)
            '
            ' Required for Windows Form Designer support
            '
            Me.gridView = TryCast(column.View, GridView)
            Me.column = column
            InitializeComponent()
            Left = parent.Left + (parent.Width - Width) \ 2
            Top = parent.Top + (parent.Height - Height) \ 2
            Text += String.Format(My.Resources.ForColumn, column.GetTextCaption())
            FillData()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Private gridView As GridView
        Private column As GridColumn
        Private Sub FillData()
            FormatItemList.Items.Clear()
            If gridView Is Nothing OrElse column Is Nothing Then
                Return
            End If
            For Each fRule As GridFormatRule In gridView.FormatRules
                If column.Equals(fRule.Column) Then
                    FormatItemList.Items.Add(New ItemFormatRule(fRule))
                End If
            Next fRule
            If FormatItemList.Items.Count > 0 Then
                FormatItemList.SelectedIndex = 0
            Else
                conditionsItem1.InitItem(Nothing)
            End If
        End Sub

        Private Sub SetRemoveEnabled()
            sbRemove.Enabled = FormatItemList.SelectedIndex > -1
        End Sub

        Private Sub FormatItemList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormatItemList.SelectedIndexChanged
            SetRemoveEnabled()
            If FormatItemList.SelectedItem IsNot Nothing Then
                conditionsItem1.InitItem(gridView.FormatRules(CType(FormatItemList.SelectedItem, ItemFormatRule).Index))
            Else
                conditionsItem1.InitItem(Nothing)
            End If
        End Sub

        Private Sub conditionsItem1_RefreshValues(ByVal sender As Object, ByVal e As System.EventArgs) Handles conditionsItem1.RefreshValues
            FormatItemList.Refresh()
        End Sub

        Private Sub sbAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAdd.Click
            If gridView Is Nothing Then
                Return
            End If
            FormatItemList.Items.BeginUpdate()
            Dim item As New GridFormatRule()
            item.Rule = New FormatConditionRuleValue()
            item.Column = Me.column
            gridView.FormatRules.Add(item)
            Dim iCondition As New ItemFormatRule(item)
            FormatItemList.Items.Add(iCondition)
            FormatItemList.SelectedItem = iCondition
            FormatItemList.Items.EndUpdate()
        End Sub

        Private Sub sbRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRemove.Click
            If gridView Is Nothing Then
                Return
            End If
            Dim condition As ItemFormatRule = TryCast(FormatItemList.SelectedItem, ItemFormatRule)
            If condition Is Nothing Then
                Return
            End If
            gridView.FormatRules.RemoveAt(condition.Index)
            FormatItemList.Items.Remove(condition)
        End Sub

        Private Sub ConditionsEditor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End Sub
    End Class
End Namespace
