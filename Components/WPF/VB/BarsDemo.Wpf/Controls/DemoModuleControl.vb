Imports System
Imports System.Windows
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Utils


Namespace BarsDemo
    Public Class BarsDemoModule
        Inherits DemoModule

        Public Shared ReadOnly BarManagerProperty As DependencyProperty = DependencyPropertyManager.Register("BarManager", GetType(BarManager), GetType(BarsDemoModule), New FrameworkPropertyMetadata(Nothing))
        Public Property Manager() As BarManager
            Get
                Return CType(GetValue(BarManagerProperty), BarManager)
            End Get
            Set(ByVal value As BarManager)
                SetValue(BarManagerProperty, value)
            End Set
        End Property
        Shared Sub New()
            BarNameScope.IsScopeOwnerProperty.OverrideMetadata(GetType(BarsDemoModule), New FrameworkPropertyMetadata(True))
        End Sub
        Public Sub New()

            AddHandler Loaded, AddressOf OnLoaded
            AddHandler Unloaded, AddressOf OnUnloaded
        End Sub
        Protected Overridable Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim en As New VisualTreeEnumerator(Me)
            Do While en.MoveNext()
                Dim _manager As BarManager = TryCast(en.Current, BarManager)
                If _manager IsNot Nothing Then
                    DemoModuleControl.DemoContent = _manager
                    Manager = _manager
                    Exit Do
                End If
            Loop
        End Sub
        Protected Overridable Sub OnUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        End Sub
        Protected Overrides Function CanLeave() As Boolean
            Return True
        End Function
    End Class
End Namespace
