Imports System
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    Public Class DemosHelper
        Public Shared Sub ShowDescriptionForm(ByVal location As System.Drawing.Point, ByVal description As String, ByVal caption As String)
            Dim frm As New DevExpress.XtraEditors.XtraForm()
            Dim tb As New TextBox()
            tb.Multiline = True
            tb.Dock = DockStyle.Fill
            tb.ScrollBars = ScrollBars.Vertical
            tb.Text = description
            tb.SelectionLength = 0

            frm.Controls.Add(tb)
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow
            frm.Text = caption
            frm.ShowInTaskbar = False
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = DevExpress.Utils.ControlUtils.CalcLocation(location, location, frm.Size)
            frm.ShowDialog()
        End Sub
    End Class
    Public Class MyGridView
        Inherits GridView

        Public Shared Function IsCondition(ByVal column As GridColumn) As Boolean
            If column Is Nothing Then
                Return False
            End If
            For Each c As StyleFormatCondition In column.View.FormatConditions
                If c.Column.Equals(column) Then
                    Return True
                End If
            Next c
            Return False
        End Function

        Public Sub SetIcons()
            For Each column As GridColumn In Me.Columns
                column.ImageIndex = If(IsCondition(column), 0, -1)
            Next column
        End Sub
        Protected Overrides Sub ApplyColumnFilter(ByVal column As DevExpress.XtraGrid.Columns.GridColumn, ByVal listBoxItem As FilterItem)
            If listBoxItem Is Nothing Then
                Return
            End If
            If listBoxItem.Text = My.Resources.ConditionsName Then
                Dim editor As New ConditionsEditor(column, column.View.GridControl.FindForm())
                editor.ShowDialog()
                SetIcons()
            Else
            MyBase.ApplyColumnFilter(column, listBoxItem)
            End If
        End Sub
    End Class

    Public Class ItemFormatRule
        Private gridFormatRule As GridFormatRule
        Public Sub New(ByVal gridFormatRule As GridFormatRule)
            Me.gridFormatRule = gridFormatRule
        End Sub
        Public ReadOnly Property Rule() As FormatConditionRuleValue
            Get
                Return TryCast(gridFormatRule.Rule, FormatConditionRuleValue)
            End Get
        End Property
        Public Overrides Function ToString() As String
            If Rule.Condition <> FormatCondition.None Then
                If Rule.Condition = FormatCondition.Between OrElse Rule.Condition = FormatCondition.NotBetween Then
                    Return String.Format("{0} {1}, {2}", Rule.Condition, Rule.Value1, Rule.Value2)
                Else
                    Return String.Format("{0} {1}", Rule.Condition, Rule.Value1)
                End If
            End If
            Return String.Format(My.Resources.ConditionItemCaption, Index)
        End Function
        Public ReadOnly Property Index() As Integer
            Get
                Return gridFormatRule.Column.View.FormatRules.IndexOf(gridFormatRule)
            End Get
        End Property
        Public ReadOnly Property Condition() As GridFormatRule
            Get
                Return gridFormatRule
            End Get
        End Property
    End Class

    Public Class ItemExpressionFormatRule
        Private gridFormatRule_Renamed As GridFormatRule
        Public Sub New(ByVal gridFormatRule As GridFormatRule)
            Me.gridFormatRule_Renamed = gridFormatRule
        End Sub
        Public ReadOnly Property Rule() As FormatConditionRuleExpression
            Get
                Return TryCast(gridFormatRule_Renamed.Rule, FormatConditionRuleExpression)
            End Get
        End Property
        Public ReadOnly Property IsExpressionCondition() As Boolean
            Get
                Return Rule IsNot Nothing
            End Get
        End Property
        Public Overrides Function ToString() As String
            If Not IsExpressionCondition Then
                Return MyBase.ToString()
            End If
            If String.IsNullOrEmpty(Rule.Expression) Then
                Return String.Format(My.Resources.EmptyConditionCaption, Index)
            End If
            Return Rule.Expression
        End Function
        Public ReadOnly Property Index() As Integer
            Get
                Return gridFormatRule_Renamed.Collection.IndexOf(gridFormatRule_Renamed)
            End Get
        End Property
        Public ReadOnly Property GridFormatRule() As GridFormatRule
            Get
                Return gridFormatRule_Renamed
            End Get
        End Property
    End Class
End Namespace
