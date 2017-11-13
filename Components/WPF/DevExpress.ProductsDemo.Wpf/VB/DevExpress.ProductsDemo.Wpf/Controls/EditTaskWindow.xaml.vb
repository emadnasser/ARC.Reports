Imports System
Imports DevExpress.Xpf.Core
Imports ProductsDemo.Modules

Namespace ProductsDemo.Controls
    Partial Public Class EditTaskWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DXRibbonWindow_Closed(ByVal sender As Object, ByVal e As EventArgs)
            CType(DataContext, EditTaskViewModel).Close()
        End Sub
    End Class
End Namespace
