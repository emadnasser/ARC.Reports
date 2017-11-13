Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace RichEditDemo
    Partial Public Class SelectDateControl
        Inherits PopupControlBase

        Public Sub New()
            InitializeComponent()
            Dispatcher.BeginInvoke(New Action(Function() Me.dateEdit.Focus()))
            Me.dateEdit.DateTime = Date.Now
        End Sub

        Protected Overrides Sub OnOwnerWindowChanged()
            If OwnerWindow IsNot Nothing Then
                OwnerWindow.Caption = "Select a date"
            End If
        End Sub
        Private Sub ButtonInfo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PerformCommit()
        End Sub
        Protected Overrides Sub SetEditValue()
            SetEditValueCore(Me.dateEdit.DateTime)
        End Sub
    End Class
End Namespace
