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
Imports DevExpress.Xpf.Editors.Validation

Namespace EditorsDemo
    Partial Public Class ValidationSettings
        Inherits UserControl

        Public Shared ReadOnly FocusedEditorProperty As DependencyProperty = DependencyProperty.Register("FocusedEditor", GetType(DependencyObject), GetType(ValidationSettings), New PropertyMetadata(Nothing, New PropertyChangedCallback(AddressOf FocusedEditorPropertyChanged)))
        Private Shared Sub FocusedEditorPropertyChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            d.SetValue(FrameworkElement.DataContextProperty, e.NewValue)
        End Sub
        Public Property FocusedEditor() As DependencyObject
            Get
                Return DirectCast(GetValue(FocusedEditorProperty), DependencyObject)
            End Get
            Set(ByVal value As DependencyObject)
                SetValue(FocusedEditorProperty, value)
            End Set
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
End Namespace
