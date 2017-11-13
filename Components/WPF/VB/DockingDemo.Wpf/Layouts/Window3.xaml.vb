Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Docking

Namespace DockingDemo
    Partial Public Class Window3
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub bClose_ItemClick(ByVal sender As Object, ByVal ea As ItemClickEventArgs)
            Dim manager As DockLayoutManager = DockLayoutManager.GetDockLayoutManager(TryCast(sender, DependencyObject))
            Dim item As BaseLayoutItem = DockLayoutManager.GetLayoutItem(TryCast(sender, DependencyObject))
            manager.DockController.Close(item)
        End Sub
    End Class
End Namespace
