Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing
Imports System.Collections.Generic

Namespace GridDemo
    <CodeFile("ModuleResources/FilteringTemplates(.SL).xaml"), CodeFile("ModuleResources/FilteringClasses.(cs)")>
    Partial Public Class Filtering
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()

            grid.FilterCriteria = New OperandProperty("City") = "Bergamo"
            grid.FilterCriteria = New OperandProperty("UnboundOrderDate") >= New Date(Date.Today.Year, 1, 1)
            AddHandler viewsListBox.EditValueChanging, AddressOf ViewsListBox_EditValueChanging
        End Sub

        Private Sub ViewsListBox_EditValueChanging(ByVal sender As Object, ByVal e As EditValueChangingEventArgs)
            grid.View.IncrementalSearchEnd()
        End Sub

        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
