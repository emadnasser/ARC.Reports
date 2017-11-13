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
Imports DevExpress.Xpf.Editors

Namespace RichEditDemo
    Partial Public Class SelectAmountControl
        Inherits PopupControlBase

        Public Sub New()
            InitializeComponent()
            Me.calcEdit.EditValue = 0D
            Dispatcher.BeginInvoke(New Action(Function() Me.calcEdit.Focus()))
            SetEditValueCore(0D)
        End Sub

        Private Sub calculator_ValueChanged(ByVal sender As Object, ByVal e As CalculatorValueChangedEventArgs)
            SetEditValue()
        End Sub
        Protected Overrides Sub SetEditValue()
            If Me.calcEdit.Value > 0 Then
                SetEditValueCore(Me.calcEdit.Value)
                Return
            End If
        End Sub
        Protected Overrides Sub OnOwnerWindowChanged()
            If OwnerWindow IsNot Nothing Then
                OwnerWindow.Caption = "Enter the amount"
            End If
        End Sub
        Private Sub ButtonInfo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PerformCommit()
        End Sub
    End Class
End Namespace
