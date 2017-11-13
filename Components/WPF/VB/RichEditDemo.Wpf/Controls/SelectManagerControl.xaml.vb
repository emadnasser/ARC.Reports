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
Imports DevExpress.Office.Utils

Namespace RichEditDemo
    Partial Public Class SelectManagerControl
        Inherits PopupControlBase

        Public Shared ReadOnly ManagersProperty As DependencyProperty
        Public Shared ReadOnly InfosProperty As DependencyProperty

        Shared Sub New()
            ManagersProperty = DependencyProperty.Register("Managers", GetType(List(Of String)), GetType(SelectManagerControl), New PropertyMetadata(Nothing))
            InfosProperty = DependencyProperty.Register("Infos", GetType(List(Of String)), GetType(SelectManagerControl), New PropertyMetadata(Nothing))
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal managers As List(Of String), ByVal infos As List(Of String))
            Guard.ArgumentNotNull(infos, "infos")
            If managers.Count <> infos.Count Then
                Exceptions.ThrowArgumentException("infos", infos)
            End If
            Me.Infos = infos
            Me.Managers = managers
            InitializeComponent()
            Dispatcher.BeginInvoke(New Action(Function() Me.listBox.Focus()))
        End Sub

        Public Property Managers() As List(Of String)
            Get
                Return DirectCast(GetValue(ManagersProperty), List(Of String))
            End Get
            Set(ByVal value As List(Of String))
                SetValue(ManagersProperty, value)
            End Set
        End Property
        Public Property Infos() As List(Of String)
            Get
                Return DirectCast(GetValue(InfosProperty), List(Of String))
            End Get
            Set(ByVal value As List(Of String))
                SetValue(InfosProperty, value)
            End Set
        End Property

        Protected Overrides Sub SetEditValueCore(ByVal value As Object)
            Dim item As String = DirectCast(value, String)
            Dim index As Integer = Managers.IndexOf(item)
            If index < 0 Then
                Return
            End If
            MyBase.SetEditValueCore(String.Format("{0}, {1}", item, Infos(index)))
        End Sub
        Protected Overrides Sub SetEditValue()
            SetEditValueCore(CStr(Me.listBox.SelectedItem))
        End Sub
        Protected Overrides Sub OnOwnerWindowChanged()
            If OwnerWindow IsNot Nothing Then
                OwnerWindow.Caption = "Select a manager"
            End If
        End Sub
        Private Sub listBox_MouseLeftButtonUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            If Me.listBox.SelectedIndex >= 0 Then
                PerformCommit()
            End If
        End Sub
    End Class
End Namespace
