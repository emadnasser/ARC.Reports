Imports System.Windows
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Printing
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class PrintOptions
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(True, False)
            ShowPrintPreview(pivotGrid)
        End Sub
    End Class
End Namespace
