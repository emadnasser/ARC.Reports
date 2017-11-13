Imports System
Imports System.Windows
Imports GridDemo
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("Controls/DemoModuleControl.(cs)"), CodeFile("ModuleResources/AdvancedPrintingOptionsTemplates(.SL).xaml")>
    Partial Public Class AdvancedPrintingOptions
        Inherits PrintViewGridDemoModule

        Protected Overrides ReadOnly Property DXTabControl() As DXTabControl
            Get
                Return tabControl
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            printStyleChooser.SelectedIndex = 1
            ShowPreviewInNewTab()
            printStyleChooser.SelectedIndex = 0
            ShowPreviewInNewTab()
        End Sub
        Private Sub printStyleChooser_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If view Is Nothing Then
                Return
            End If
            If printStyleChooser.SelectedIndex = 0 Then
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintColumnHeaderStyleProperty)
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintCellStyleProperty)
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintGroupRowStyleProperty)
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintTotalSummaryStyleProperty)
                view.ClearValue(DevExpress.Xpf.Grid.TableView.PrintFixedTotalSummaryStyleProperty)
            End If
            If printStyleChooser.SelectedIndex = 1 Then
                view.PrintColumnHeaderStyle = CType(Resources("customPrintColumnHeaderStyle"), Style)
                view.PrintCellStyle = CType(Resources("customPrintCellStyle"), Style)
                view.PrintGroupRowStyle = CType(Resources("customGroupRowStyle"), Style)
                view.PrintTotalSummaryStyle = CType(Resources("customPrintTotalSummaryStyle"), Style)
                view.PrintFixedTotalSummaryStyle = CType(Resources("customPrintFixedTotalSummaryStyle"), Style)
            End If
        End Sub
        Protected Overrides Sub ShowPreviewInNewTab()
            ShowPrintPreviewInNewTab(grid, tabControl, String.Format("{0} Style Preview", printStyleChooser.SelectedItem))
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
