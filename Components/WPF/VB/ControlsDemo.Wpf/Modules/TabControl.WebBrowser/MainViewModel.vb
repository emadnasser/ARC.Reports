Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace ControlsDemo.TabControl.WebBrowser
    Public Class MainViewModel
        Public Sub LaunchDemo()
            Me.GetService(Of IWindowService)().Show("WebBrowserView", Nothing, Me)
        End Sub
    End Class
End Namespace
