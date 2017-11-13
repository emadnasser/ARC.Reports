Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraPrinting
Imports System.Windows

Namespace GridDemo
    <CodeFile("ModuleResources/DataAwareExport/DataAwareExportViewModel.cs"), CodeFile("ModuleResources/DataAwareExport/ProductSaleData.cs")>
    Partial Public Class DataAwareExport
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            grid.ExpandGroupRow(-1)
            AddHandler grid.ItemsSourceChanged, AddressOf grid_ItemsSourceChanged
        End Sub

        Private Sub grid_ItemsSourceChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.ItemsSourceChangedEventArgs)
            grid.ExpandGroupRow(-1)
        End Sub

        Protected Overrides Function GetModuleDataContext() As Object
            Return DataContext
        End Function
        Private Sub ExportButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DemoModuleExportHelper(view), DemoModuleExportHelper).ExportToXlsx()
        End Sub
    End Class
End Namespace
