Imports System
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Windows
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("Controls/Converters.(cs)")>
    Partial Public Class StandardTableView
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbSummary_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If lbSummary.SelectedIndex = 0 Then
                grid.View.ShowTotalSummary = False
                grid.View.ShowFixedTotalSummary = True
            Else
                grid.View.ShowTotalSummary = True
                grid.View.ShowFixedTotalSummary = False
            End If
        End Sub
    End Class
End Namespace
