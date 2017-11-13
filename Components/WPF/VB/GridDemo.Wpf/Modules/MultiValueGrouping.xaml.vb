Imports System
Imports System.Windows
Imports System.Windows.Data
Imports GridDemo
Imports System.Windows.Markup
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing


Namespace GridDemo
    <CodeFile("ModuleResources/MultiValueGroupingTemplates(.SL).xaml"), CodeFile("ModuleResources/MultiValueGroupingClasses.(cs)")>
    Partial Public Class MultiValueGrouping
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            gc = New GroupingControllerTasksWithCategories(grid)
            AddHandler gc.AfterGrouping, AddressOf gc_AfterGrouping
            InitButtonCaption()
        End Sub

        Private gc As GroupingControllerTasksWithCategories
        Private Sub InitButtonCaption()
            groupButton.Content = If(gc.IsCategoryGrouping, " Ungroup by 'Category'", "Group by 'Category'")
        End Sub
        Private Sub groupButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If gc.CategoryColumn Is Nothing Then
                groupButton.IsEnabled = False
                Return
            End If
            If Not gc.CategoryColumn.IsGrouped Then
                grid.GroupBy(gc.CategoryColumn)
            Else
                grid.UngroupBy(gc.CategoryColumn)
            End If

        End Sub
        Private Sub gc_AfterGrouping(ByVal sender As Object, ByVal e As EventArgs)
            InitButtonCaption()
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
