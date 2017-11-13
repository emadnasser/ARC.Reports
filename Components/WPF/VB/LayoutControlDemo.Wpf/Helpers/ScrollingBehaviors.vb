Imports DevExpress.Mvvm.Native
Imports DevExpress.Mvvm.UI.Interactivity
Imports System.Windows
Imports System.Windows.Input

Namespace LayoutControlDemo.Helpers
    Public Class MouseWheelScrollingBehavior
        Inherits Behavior(Of FrameworkElement)

        Public Shared ReadOnly DisableScrollingProperty As DependencyProperty = DependencyProperty.Register("DisableScrolling", GetType(Boolean), GetType(MouseWheelScrollingBehavior), New PropertyMetadata(False, Sub(d, e) CType(d, MouseWheelScrollingBehavior).Update(CBool(e.NewValue))))
        Public Property DisableScrolling() As Boolean
            Get
                Return CBool(GetValue(DisableScrollingProperty))
            End Get
            Set(ByVal value As Boolean)
                SetValue(DisableScrollingProperty, value)
            End Set
        End Property
        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            Update(DisableScrolling)
        End Sub
        Protected Overrides Sub OnDetaching()
            Update(True)
            MyBase.OnDetaching()
        End Sub
        Private Sub Update(ByVal disableScrolling As Boolean)
            AssociatedObject.Do(Sub(x) RemoveHandler x.PreviewMouseWheel, AddressOf OnPreviewMouseWheel)
            If Me.DisableScrolling Then
                AssociatedObject.Do(Sub(x) AddHandler x.PreviewMouseWheel, AddressOf OnPreviewMouseWheel)
            End If
        End Sub
        Private Sub OnPreviewMouseWheel(ByVal sender As Object, ByVal e As MouseWheelEventArgs)
            e.Handled = True
        End Sub
    End Class
End Namespace
