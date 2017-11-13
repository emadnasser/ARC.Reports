Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Docking

Namespace DockingDemo
    Partial Public Class Window2
        Inherits UserControl

        Private transform As New MatrixTransform()
        Public Sub New()
            InitializeComponent()
            image.LayoutTransform = transform
        End Sub
        Private Sub bClose_ItemClick(ByVal sender As Object, ByVal ea As ItemClickEventArgs)
            Dim manager As DockLayoutManager = DockLayoutManager.GetDockLayoutManager(TryCast(sender, DependencyObject))
            Dim item As BaseLayoutItem = DockLayoutManager.GetLayoutItem(TryCast(sender, DependencyObject))
            manager.DockController.Close(item)
        End Sub
        Private Sub biFlipHorz_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            transform.Matrix = Matrix.Multiply(transform.Matrix, New Matrix(-1, 0, 0, 1, 0, 0))
        End Sub
        Private Sub biFlipVert_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            transform.Matrix = Matrix.Multiply(transform.Matrix, New Matrix(1, 0, 0, -1, 0, 0))
        End Sub
        Private Sub biRotateCW_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            transform.Matrix = Matrix.Multiply(transform.Matrix, New Matrix(0, 1, -1, 0, 0, 0))
        End Sub
        Private Sub biRotateCCW_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            transform.Matrix = Matrix.Multiply(transform.Matrix, New Matrix(0, -1, 1, 0, 0, 0))
        End Sub
    End Class
End Namespace
