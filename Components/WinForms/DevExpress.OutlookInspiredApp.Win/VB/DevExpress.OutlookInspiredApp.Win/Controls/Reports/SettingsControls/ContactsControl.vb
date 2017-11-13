Imports System
Imports System.Windows.Forms

Namespace DevExpress.DevAV
    Partial Public Class ContactsControl
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
                btnIncludeContacts.Checked = True
            Else
                btnExcludeContacts.Checked = True
            End If
        End Sub
        Private Sub btnIncludeContacts_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnIncludeContacts.CheckedChanged
            If callback IsNot Nothing Then
                callback(True)
            End If
        End Sub
        Private Sub btnExcludeContacts_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcludeContacts.CheckedChanged
            If callback IsNot Nothing Then
                callback(False)
            End If
        End Sub
    End Class
End Namespace
