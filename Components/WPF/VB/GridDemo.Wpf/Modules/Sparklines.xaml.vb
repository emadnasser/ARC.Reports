Imports DevExpress.Xpf.Grid.Printing
Imports DevExpress.XtraExport.Helpers
Namespace GridDemo
    Partial Public Class Sparklines
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
