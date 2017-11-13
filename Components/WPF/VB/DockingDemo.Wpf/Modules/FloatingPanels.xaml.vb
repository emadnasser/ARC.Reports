Imports System

Namespace DockingDemo
    Partial Public Class FloatingPanels
        Inherits DockingDemoModule

        Public Sub New()
            InitializeComponent()
            AddHandler DesktopContainer.Loaded, AddressOf OnDesktopContainerLoaded
        End Sub
        Protected Overrides Sub RaiseModuleAppear()
            MyBase.RaiseModuleAppear()
            InvalidateVisual()
        End Sub
        Private Sub OnDesktopContainerLoaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            RemoveHandler DesktopContainer.Loaded, AddressOf OnDesktopContainerLoaded
            ShowWindowModeContainer()
        End Sub
        Private isWindow As Boolean
        Private Sub OnFloatingModeButtonlick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If isWindow Then
                ShowDesktopModeContainer()
            Else
                ShowWindowModeContainer()
            End If
        End Sub
        Private Sub ShowWindowModeContainer()
            ModeSwitchButton.Content = "Show in Desktop Mode"
            WindowBarManager.Visibility = System.Windows.Visibility.Visible
            DesktopBarManager.Visibility = System.Windows.Visibility.Collapsed
            isWindow = True
        End Sub
        Private Sub ShowDesktopModeContainer()
            ModeSwitchButton.Content = "Show in Window Mode"
            DesktopBarManager.Visibility = System.Windows.Visibility.Visible
            WindowBarManager.Visibility = System.Windows.Visibility.Collapsed
            isWindow = False
        End Sub
        Protected Overrides ReadOnly Property Container() As DevExpress.Xpf.Docking.DockLayoutManager
            Get
                Return If(isWindow, WindowContainer, DesktopContainer)
            End Get
        End Property
    End Class
End Namespace
