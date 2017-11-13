Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core
Imports DevExpress.Data
Imports DevExpress.Xpf.DemoBase.Helpers
Imports System.Collections.Generic
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/GroupSummaryViewModel.(cs)"), CodeFile("ModuleResources/GroupSummaryClasses.(cs)"), CodeFile("ModuleResources/GroupSummaryTemplates(.SL).xaml")>
    Partial Public Class DataGroupSummaries
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub summaryItemTemplateComboBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            If summaryItemTemplateComboBox.SelectedIndex = 0 Then
                view.GroupSummaryItemTemplate = CType(Me.FindResource("customTemplateWithSummaryCustomization"), DataTemplate)
                view.ClearValue(GridViewBase.GroupSummaryItemTemplateSelectorProperty)
            End If
            If summaryItemTemplateComboBox.SelectedIndex = 1 Then
                view.GroupSummaryItemTemplateSelector = New ConditionalGroupSummaryItemTemplateSelector(CType(Me.FindResource("smallValueTemplate"), DataTemplate), CType(Me.FindResource("largeValueTemplate"), DataTemplate))
                view.ClearValue(GridViewBase.GroupSummaryItemTemplateProperty)
            End If
            If summaryItemTemplateComboBox.SelectedIndex = 2 Then
                view.GroupSummaryItemTemplate = CType(Me.FindResource("customTemplate"), DataTemplate)
                view.ClearValue(GridViewBase.GroupSummaryItemTemplateSelectorProperty)
            End If
            If summaryItemTemplateComboBox.SelectedIndex = 3 Then
                grid.View.ClearValue(GridViewBase.GroupSummaryItemTemplateProperty)
                grid.View.ClearValue(GridViewBase.GroupSummaryItemTemplateSelectorProperty)
            End If
        End Sub
    End Class
End Namespace
