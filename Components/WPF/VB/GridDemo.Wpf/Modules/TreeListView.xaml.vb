Imports System.Windows
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/TreeListViewTemplates(.SL).xaml"), CodeFile("ModuleResources/TreeListViewClasses.(cs)")>
    Partial Public Class TreeListView
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            Me.view.ExpandAllNodes()
        End Sub
        Private Sub chkEnableContextMenu_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.IsColumnMenuEnabled = True
            view.IsRowCellMenuEnabled = True
            view.IsTotalSummaryMenuEnabled = True
        End Sub
        Private Sub chkEnableContextMenu_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.IsColumnMenuEnabled = False
            view.IsRowCellMenuEnabled = False
            view.IsTotalSummaryMenuEnabled = False
        End Sub
    End Class
End Namespace
