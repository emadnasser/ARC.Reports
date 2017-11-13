Imports System
Imports System.Windows.Controls
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Xpf.Core
Imports System.Windows.Input

Namespace RichEditDemo
    Public Class PopupControlBase
        Inherits UserControl

        Private fEditValue As Object
        Private fRange As DocumentRange
        Private fOwnerWindow As FloatingContainer

        Public Sub New()
            AddHandler Me.KeyDown, AddressOf PopupControlBase_KeyDown
        End Sub

        Public Overridable ReadOnly Property EditValue() As Object
            Get
                Return fEditValue
            End Get
        End Property
        Public Property Range() As DocumentRange
            Get
                Return fRange
            End Get
            Set(ByVal value As DocumentRange)
                fRange = value
            End Set
        End Property
        Public Property OwnerWindow() As FloatingContainer
            Get
                Return fOwnerWindow
            End Get
            Set(ByVal value As FloatingContainer)
                If fOwnerWindow Is value Then
                    Return
                End If
                fOwnerWindow = value
                OnOwnerWindowChanged()
            End Set
        End Property

        Private onCommit As EventHandler
        Public Custom Event Commit As EventHandler
            AddHandler(ByVal value As EventHandler)
                onCommit = DirectCast(System.Delegate.Combine(onCommit, value), EventHandler)
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                onCommit = DirectCast(System.Delegate.Remove(onCommit, value), EventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If onCommit IsNot Nothing Then
                    For Each d As EventHandler In onCommit.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Protected Sub RaiseCommitEvent()
            If onCommit IsNot Nothing Then
                onCommit(Me, EventArgs.Empty)
            End If
        End Sub

        Protected Overridable Sub OnOwnerWindowChanged()
        End Sub
        Protected Overridable Sub SetEditValueCore(ByVal value As Object)
            Me.fEditValue = value
        End Sub
        Protected Overridable Sub SetEditValue()
        End Sub
        Private Sub PopupControlBase_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.Key = Key.Escape Then
                Close()
            ElseIf e.Key = Key.Enter Then
                PerformCommit()
            End If
        End Sub
        Protected Overridable Sub PerformCommit()
            SetEditValue()
            RaiseCommitEvent()
            Close()
        End Sub
        Protected Sub Close()
            If OwnerWindow IsNot Nothing AndAlso OwnerWindow.IsOpen Then
                OwnerWindow.IsOpen = False
            End If
        End Sub
    End Class
End Namespace
