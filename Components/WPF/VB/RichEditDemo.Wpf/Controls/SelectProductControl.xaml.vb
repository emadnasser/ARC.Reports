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
Imports DevExpress.Utils

Namespace RichEditDemo
    Partial Public Class SelectProductControl
        Inherits PopupControlBase

        Public Shared ReadOnly ProductsProperty As DependencyProperty

        Shared Sub New()
            ProductsProperty = DependencyProperty.Register("Products", GetType(List(Of String)), GetType(SelectProductControl), New PropertyMetadata(Nothing))
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal list As List(Of String))
            Guard.ArgumentNotNull(list, "list")
            Products = list
            InitializeComponent()
            Dispatcher.BeginInvoke(New Action(Function() Me.listBox.Focus()))
        End Sub

        Public Property Products() As List(Of String)
            Get
                Return DirectCast(GetValue(ProductsProperty), List(Of String))
            End Get
            Set(ByVal value As List(Of String))
                SetValue(ProductsProperty, value)
            End Set
        End Property

        Protected Overrides Sub SetEditValue()
            SetEditValueCore(CStr(Me.listBox.SelectedItem))
        End Sub
        Protected Overrides Sub OnOwnerWindowChanged()
            If OwnerWindow IsNot Nothing Then
                OwnerWindow.Caption = "Select a product"
            End If
        End Sub
        Private Sub listBox_MouseLeftButtonUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            If Me.listBox.SelectedIndex >= 0 Then
                PerformCommit()
            End If
        End Sub
    End Class
End Namespace
