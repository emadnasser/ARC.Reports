Imports System.Windows

Namespace DevExpress.Xpf.LayoutControlDemo
    Partial Public Class pageFlowLayoutControl
        Inherits LayoutControlDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub AllowLayerSizingCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            layoutItems.ShowLayerSeparators = True
        End Sub
        Private Sub StretchContentCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each child In layoutItems.GetLogicalChildren(False)
                child.Width = Double.NaN
            Next child
        End Sub
    End Class
End Namespace
