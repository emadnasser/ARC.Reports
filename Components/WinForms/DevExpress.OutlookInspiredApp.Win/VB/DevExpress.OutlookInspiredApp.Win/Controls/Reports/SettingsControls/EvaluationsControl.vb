Imports System
Imports System.Windows.Forms

Namespace DevExpress.DevAV
    Partial Public Class EvaluationsControl
        Inherits UserControl

        Private callback As Action(Of Boolean)
        Private defaultValue As Boolean
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal callback As Action(Of Boolean), ByVal defaultValue As Boolean)
            Me.New()
            Me.callback = callback
            Me.defaultValue = defaultValue
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If defaultValue Then
                btnIncludeEvaluations.Checked = True
            Else
                btnExcludeEvaluations.Checked = True
            End If
        End Sub
        Private Sub btnAscendingOrder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnIncludeEvaluations.CheckedChanged
            If callback IsNot Nothing Then
                callback(True)
            End If
        End Sub
        Private Sub btnDescendingOrder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcludeEvaluations.CheckedChanged
            If callback IsNot Nothing Then
                callback(False)
            End If
        End Sub
    End Class
End Namespace
