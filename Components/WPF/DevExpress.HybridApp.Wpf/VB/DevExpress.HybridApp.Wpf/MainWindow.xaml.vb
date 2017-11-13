Imports System.Windows
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.Utils.TouchHelpers
Imports DevExpress.Xpf.Core

Namespace DevExpress.DevAV
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWPF, Me)
            InitializeComponent()
            If Height > SystemParameters.VirtualScreenHeight OrElse Width > SystemParameters.VirtualScreenWidth Then
                WindowState = WindowState.Maximized
            End If
            If DeviceDetector.IsTablet Then
                WindowStyle = WindowStyle.None
                ResizeMode = ResizeMode.CanMinimize
                WindowState = WindowState.Maximized
            End If
        End Sub
        Private Sub MainWindowLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If (Not DeviceDetector.IsTablet) AndAlso (Left < 0 OrElse Top < 0) Then
                WindowState = WindowState.Maximized
            End If
        End Sub
    End Class
End Namespace
