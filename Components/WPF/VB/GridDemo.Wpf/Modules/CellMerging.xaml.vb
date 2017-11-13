Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid.Printing
Imports DevExpress.XtraExport.Helpers
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace GridDemo
    <CodeFile("IssueListContext.(cs)"), CodeFile("Controls/Converters.(cs)"), CodeFile("ModuleResources/CellMergingTemplates.xaml")>
    Partial Public Class CellMerging
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
