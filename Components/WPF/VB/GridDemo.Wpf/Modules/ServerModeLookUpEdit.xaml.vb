Imports System
Imports DevExpress.Xpf.DemoBase
Imports GridDemo.PeopleDataService
Imports DevExpress.Data.WcfLinq
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    <CodeFile("ModuleResources/ServerModeLookUpEditViewModel.(cs)"), CodeFile("ModuleResources/ServerModeLookUpEditResources.xaml")>
    Partial Public Class ServerModeLookUpEdit
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub Clear()
            view.CloseEditor()
            MyBase.Clear()
        End Sub

        Protected Overrides Function GetModuleDataContext() As Object
            Return DataContext
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
    End Class
End Namespace
