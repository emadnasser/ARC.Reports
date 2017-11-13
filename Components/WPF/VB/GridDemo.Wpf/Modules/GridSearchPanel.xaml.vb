Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Core
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/SearchPanelViewModel.(cs)"), CodeFile("ModuleResources/SearchPanelClasses.(cs)"), CodeFile("ModuleResources/SearchPanelTemplates(.SL).xaml"), CodeFile("Controls/Converters.(cs)")>
    Partial Public Class GridSearchPanel
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
