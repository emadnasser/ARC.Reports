Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase
Imports System.Windows.Controls
Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace GridDemo
    <CodeFile("ModuleResources/SharedResources(.SL).xaml"), CodeFile("ModuleResources/EmbeddedTableViewTemplates(.SL).xaml")>
    Partial Public Class EmbeddedTableView
        Inherits GridDemoModule

        Public Shared ReadOnly SelectedTabIndexProperty As DependencyProperty = DependencyProperty.RegisterAttached("SelectedTabIndex", GetType(Integer), GetType(EmbeddedTableView), New PropertyMetadata(0))
        Public Shared Sub SetSelectedTabIndex(ByVal element As DependencyObject, ByVal value As Integer)
            element.SetValue(SelectedTabIndexProperty, value)
        End Sub
        Public Shared Function GetSelectedTabIndex(ByVal element As DependencyObject) As Integer
            Return DirectCast(element.GetValue(SelectedTabIndexProperty), Integer)
        End Function
        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
    End Class
End Namespace
