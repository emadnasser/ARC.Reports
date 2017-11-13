Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/ExpandCollapseGroupsTemplates(.SL).xaml"), CodeFile("ModuleResources/ExpandCollapseGroupsClasses.(cs)")>
    Partial Public Class ExpandCollapseGroups
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub animationTypeComboBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            If animationTypeComboBox.SelectedIndex = 0 OrElse animationTypeComboBox.SelectedIndex = 2 OrElse animationTypeComboBox.SelectedIndex = 4 Then
                grid.View.ClearValue(GridViewBase.CollapseStoryboardProperty)
                grid.View.ClearValue(GridViewBase.ExpandStoryboardProperty)
            End If
            If animationTypeComboBox.SelectedIndex = 1 OrElse animationTypeComboBox.SelectedIndex = 3 OrElse animationTypeComboBox.SelectedIndex = 5 Then
                view.ExpandStoryboard = GetStoryboard("expandStoryborad")
                view.CollapseStoryboard = GetStoryboard("collapseStoryborad")
            End If
            If animationTypeComboBox.SelectedIndex = 1 OrElse animationTypeComboBox.SelectedIndex = 2 Then
                view.RowDecorationTemplate = CType(Resources("fadeInTemplate"), ControlTemplate)
            End If
            If animationTypeComboBox.SelectedIndex = 3 OrElse animationTypeComboBox.SelectedIndex = 4 Then
                view.RowDecorationTemplate = CType(Resources("blindsTemplate"), ControlTemplate)
            End If
            If animationTypeComboBox.SelectedIndex = 0 OrElse animationTypeComboBox.SelectedIndex = 5 Then
                view.ClearValue(DevExpress.Xpf.Grid.TableView.RowDecorationTemplateProperty)
            End If
        End Sub
        Private Function GetStoryboard(ByVal resourceName As String) As Storyboard
            Return CType(Resources(resourceName), Storyboard)
        End Function
    End Class
End Namespace
