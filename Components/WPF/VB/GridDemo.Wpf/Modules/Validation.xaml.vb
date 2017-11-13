Imports System
Imports System.Collections.Generic
Imports GridDemo
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/ValidationViewModel.(cs)")>
    Partial Public Class Validation
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
