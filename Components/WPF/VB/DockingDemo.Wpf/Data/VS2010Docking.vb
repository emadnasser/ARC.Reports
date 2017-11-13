Imports System.IO
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DockingDemo.MVVM

Namespace DockingDemo
    Partial Public Class VS2010Docking
        Inherits DockingDemoModule

        Public Sub New()
            InitializeComponent()
            Me.DataContext = New VS2010MainWindowViewModel()
        End Sub
        Private Sub bHome_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            NavigateHomePage()
        End Sub
        Private Sub bAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            ShowAbout()
        End Sub
    End Class
End Namespace
