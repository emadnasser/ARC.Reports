Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Design
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ExpressionConditionsEditor
        Inherits XtraUserControl

        Public currentView As GridView = Nothing
        Private init_Renamed As Boolean = False
        Public Sub New()
            InitializeComponent()
            propertyGrid1.ShowDescription = False
            propertyGrid1.ShowCategories = propertyGrid1.ShowDescription
            propertyGrid1.ShowButtons = propertyGrid1.ShowCategories
        End Sub

        Public Sub Init(ByVal view As GridView)
            currentView = view
            InitConditions()
            InitColumns()
            If FormatItemList.Items.Count > 0 Then
                FormatItemList.SelectedIndex = 0
            End If
        End Sub

        Private Sub InitColumns()
            If currentView Is Nothing Then
                Return
            End If
            For Each col As GridColumn In currentView.Columns
                imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem(col.GetTextCaption(), col, -1))
            Next col
        End Sub

        Private Sub InitConditions()
            If currentView Is Nothing Then
                Return
            End If
            FormatItemList.BeginUpdate()
            Try
                FormatItemList.Items.Clear()
                For Each condition As GridFormatRule In currentView.FormatRules
                    Dim eCondition As New ItemExpressionFormatRule(condition)
                    If eCondition.IsExpressionCondition Then
                        FormatItemList.Items.Add(eCondition)
                    End If
                Next condition
            Finally
                FormatItemList.EndUpdate()
            End Try
        End Sub

        Private ReadOnly Property CurrentCondition() As GridFormatRule
            Get
                If FormatItemList.SelectedItem IsNot Nothing Then
                    Return CType(FormatItemList.SelectedItem, ItemExpressionFormatRule).GridFormatRule
                End If
                Return Nothing
            End Get
        End Property

        Private Sub ShowEditor(ByVal condition As GridFormatRule)
            Dim rule As FormatConditionRuleExpression = TryCast(condition.Rule, FormatConditionRuleExpression)
            If rule Is Nothing Then
                Return
            End If
            Using form As ExpressionEditorForm = New FormatRuleExpressionEditorForm(rule, Nothing, rule.Expression)
                form.StartPosition = FormStartPosition.CenterParent
                If form.ShowDialog(Me) = DialogResult.OK Then
                    rule.Expression = form.Expression
                End If
            End Using
        End Sub

        Private Sub ShowEditor()
            If CurrentCondition Is Nothing Then
                Return
            End If
            ShowEditor(CurrentCondition)
            FormatItemList.Refresh()
        End Sub

        Private Sub barButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem3.ItemClick
            ShowEditor()
        End Sub

        Private Sub FormatItemList_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles FormatItemList.MouseDoubleClick
            ShowEditor()
        End Sub

        Private Sub SelectObjectUpdate()
            If _update Then
                Return
            End If
            EnableButtons()
            init_Renamed = True
            If CurrentCondition Is Nothing Then
                propertyGrid1.Enabled = False
                propertyGrid1.PropertyGrid.SelectedObject = Nothing
                panelControl1.Visible = False

            Else
                propertyGrid1.Enabled = True
                propertyGrid1.PropertyGrid.SelectedObject = CType(CurrentCondition.Rule, FormatConditionRuleExpression).Appearance
                panelControl1.Visible = True
                checkEdit1.Checked = CurrentCondition.ApplyToRow
                imageComboBoxEdit1.EditValue = CurrentCondition.Column
            End If
            init_Renamed = False
        End Sub

        Private Sub FormatItemList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles FormatItemList.SelectedIndexChanged
            SelectObjectUpdate()
        End Sub

        Private Sub EnableButtons()
            barButtonItem2.Enabled = CurrentCondition IsNot Nothing
            barButtonItem3.Visibility = If(CurrentCondition Is Nothing, BarItemVisibility.Never, BarItemVisibility.Always)
        End Sub

        Private _update As Boolean = False

        '<FormatItemList>
        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem2.ItemClick
            _update = True
            If CurrentCondition Is Nothing Then
                Return
            End If
            currentView.FormatRules.Remove(CurrentCondition)
            FormatItemList.Items.RemoveAt(FormatItemList.SelectedIndex)
            _update = False
            SelectObjectUpdate()
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barButtonItem1.ItemClick
            Dim condition As New GridFormatRule()
            condition.Rule = New FormatConditionRuleExpression()
            currentView.FormatRules.Add(condition)
            Dim index As Integer = FormatItemList.Items.Count
            InitConditions()
            FormatItemList.SelectedIndex = index
            ShowEditor()
        End Sub
        '</FormatItemList>
        '<checkEdit1>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            If CurrentCondition Is Nothing OrElse init_Renamed Then
                Return
            End If
            CurrentCondition.ApplyToRow = checkEdit1.Checked
        End Sub
        '</checkEdit1>
        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imageComboBoxEdit1.SelectedIndexChanged
            If CurrentCondition Is Nothing OrElse init_Renamed Then
                Return
            End If
            Dim col As GridColumn = TryCast(imageComboBoxEdit1.EditValue, GridColumn)
            CurrentCondition.Column = col
        End Sub
    End Class
End Namespace
