Imports System
Imports System.Windows
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Utils
Imports DevExpress.Xpf.Ribbon
Imports System.Windows.Media
Imports DevExpress.Xpf.Core
Imports DevExpress.Mvvm
Imports System.Linq

Namespace RibbonDemo
    Public Class RibbonDemoModule
        Inherits DemoModule

        Public Shared ReadOnly BarManagerProperty As DependencyProperty
        Public Shared ReadOnly RibbonProperty As DependencyProperty

        Shared Sub New()
            Dim ownerType As Type = GetType(RibbonDemoModule)
            BarManagerProperty = DependencyPropertyManager.Register("BarManager", GetType(BarManager), ownerType, New FrameworkPropertyMetadata(Nothing))
            RibbonProperty = DependencyPropertyManager.Register("Ribbon", GetType(RibbonControl), ownerType, New FrameworkPropertyMetadata(Nothing))
        End Sub
        Public Property Manager() As BarManager
            Get
                Return CType(GetValue(BarManagerProperty), BarManager)
            End Get
            Set(ByVal value As BarManager)
                SetValue(BarManagerProperty, value)
            End Set
        End Property
        Public Property Ribbon() As RibbonControl
            Get
                Return CType(GetValue(RibbonProperty), RibbonControl)
            End Get
            Set(ByVal value As RibbonControl)
                SetValue(RibbonProperty, value)
            End Set
        End Property
        Public Sub New()
            AddHandler Loaded, AddressOf OnLoaded
        End Sub

        Protected Overridable ReadOnly Property NeedChangeEditorsTheme() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overridable Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Manager = CType(DemoModuleControl.FindDemoContent(GetType(BarManager), Me), BarManager)
            Ribbon = CType(DemoModuleControl.FindDemoContent(GetType(RibbonControl), Me), RibbonControl)
            DemoModuleControl.DemoContent = Manager
        End Sub
        Protected Overrides Function CanLeave() As Boolean
            Return True
        End Function
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            Dim newValue As Boolean = DirectCast(e.NewValue, Boolean)
            If Ribbon IsNot Nothing Then
                Ribbon.AllowKeyTips = Not newValue
                If Not newValue Then
                    NavigationTree.ExitMenuMode(False, False)
                    Ribbon.CloseApplicationMenu()
                End If
            End If
        End Sub
    End Class
End Namespace
