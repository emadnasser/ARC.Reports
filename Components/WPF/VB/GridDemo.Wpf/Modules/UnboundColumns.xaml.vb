Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/UnboundColumnsTemplates(.SL).xaml"), CodeFile("ModuleResources/UnboundColumnsClasses.(cs)")>
    Partial Public Class UnboundColumns
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            grid.ExpandAllGroups()
        End Sub
        Private Sub showExpressionEditorButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.View.ShowUnboundExpressionEditor(grid.Columns(DirectCast(CType(columnsList.SelectedItem, ListBoxItem).Tag, String)))
        End Sub
    End Class
End Namespace
