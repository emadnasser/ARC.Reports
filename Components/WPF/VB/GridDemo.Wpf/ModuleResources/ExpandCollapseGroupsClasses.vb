Imports System.Windows
Imports System.Windows.Controls

Namespace GridDemo
    Public Class DXExpanderDecorator
        Inherits ContentControl

        Public Shared ReadOnly IsItemVisibleProperty As DependencyProperty = DependencyProperty.Register("IsItemVisible", GetType(Boolean), GetType(DXExpanderDecorator), New PropertyMetadata(True, New PropertyChangedCallback(AddressOf OnIsItemVisibleChanged)))
        Private Shared Sub OnIsItemVisibleChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, DXExpanderDecorator).OnIsItemVisibleChangedCore()
        End Sub
        Public Property IsItemVisible() As Boolean
            Get
                Return DirectCast(GetValue(IsItemVisibleProperty), Boolean)
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsItemVisibleProperty, value)
            End Set
        End Property
        Private Sub OnIsItemVisibleChangedCore()
            VisualStateManager.GoToState(Me,If(IsItemVisible, "VisibleInGroup", "HiddenInGroup"), False)
        End Sub
    End Class
End Namespace
