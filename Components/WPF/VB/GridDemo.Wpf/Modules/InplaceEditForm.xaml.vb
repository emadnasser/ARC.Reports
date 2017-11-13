Imports System.Linq
Imports DevExpress.DemoData.Models
Imports DevExpress.Xpf.Grid
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing
Imports DevExpress.DemoData.Models.Vehicles

Namespace GridDemo
    <CodeFile("ModuleResources/InplaceEditFormResources.xaml")>
    Partial Public Class InplaceEditForm
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = (New VehiclesContext()).Models.ToList()
        End Sub

        Private Sub OnTemplateValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If tableView Is Nothing Then
                Return
            End If
            Dim index As Integer = templatesListBox.SelectedIndex
            If index = 0 Then
                tableView.ClearValue(TableView.EditFormTemplateProperty)
            ElseIf index = 1 Then
                tableView.EditFormTemplate = CType(Resources("CustomEditFormTemplate"), DataTemplate)
            End If
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
