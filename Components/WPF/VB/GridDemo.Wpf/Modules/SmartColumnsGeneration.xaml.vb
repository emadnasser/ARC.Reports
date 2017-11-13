Imports System
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/SmartColumnsGenerationViewModel.(cs)")>
    Partial Public Class SmartColumnsGeneration
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
