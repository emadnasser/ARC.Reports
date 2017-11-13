Imports System
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Editors
Imports System.Windows.Controls

Namespace GridDemo
    Partial Public Class GridSummaries
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnTotalSummaryEditor_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.View.ShowTotalSummaryEditor(grid.Columns(2))
        End Sub

        Private Sub btnFixedTotalSummaryEditor_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.View.ShowFixedTotalSummaryEditor()
        End Sub
    End Class
End Namespace
