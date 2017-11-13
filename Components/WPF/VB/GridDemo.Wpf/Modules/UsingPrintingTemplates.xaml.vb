Imports System
Imports System.Windows
Imports GridDemo
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/PrintTemplatesResources(.SL).xaml"), CodeFile("Controls/DemoModuleControl.(cs)")>
    Partial Public Class UsingPrintingTemplates
        Inherits PrintViewGridDemoModule

        Protected Overrides ReadOnly Property DXTabControl() As DXTabControl
            Get
                Return tabControl
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            templateNamesListBox.SelectedIndex = 2
            ShowPreviewInNewTab()
            templateNamesListBox.SelectedIndex = 1
            ShowPreviewInNewTab()
            templateNamesListBox.SelectedIndex = 0
            ShowPreviewInNewTab()
        End Sub
        Private Sub templateNamesListBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If view Is Nothing Then
                Return
            End If
            If templateNamesListBox.SelectedIndex = 0 Then
                view.PrintHeaderTemplate = CType(Resources("detailPrintHeaderTemplate"), DataTemplate)
                view.PrintRowTemplate = CType(Resources("detailPrintRowTemplate"), DataTemplate)
                view.PrintColumnHeaderStyle = CType(Resources("mailMergePrintHeaderStyle"), Style)
            End If
            If templateNamesListBox.SelectedIndex = 1 Then
                view.PrintHeaderTemplate = Nothing
                view.PrintRowTemplate = CType(Resources("mailMergePrintRowTemplate"), DataTemplate)
                view.PrintColumnHeaderStyle = CType(Resources("mailMergePrintHeaderStyle"), Style)
            End If
            If templateNamesListBox.SelectedIndex = 2 Then
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintHeaderTemplateProperty)
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintRowTemplateProperty)
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintColumnHeaderStyleProperty)
            End If
        End Sub
        Protected Overrides Sub ShowPreviewInNewTab()
            ShowPrintPreviewInNewTab(grid, tabControl, String.Format("{0} Preview", templateNamesListBox.SelectedItem))
        End Sub
        Protected Sub newTabButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ShowPreviewInNewTab()
        End Sub
        Protected Sub tabControl_TabHidden(ByVal sender As Object, ByVal e As TabControlTabHiddenEventArgs)
            DisposePrintPreviewTabContent(CType(DXTabControl.Items(e.TabIndex), DXTabItem))
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
