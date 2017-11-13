Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.DemoData.Models
Imports System.Data.Entity
Imports System.Linq
Imports DevExpress.Xpf.Core

Namespace GridDemo
    <CodeFile("ModuleResources/CardViewPrintingTemplates(.SL).xaml"), CodeFile("ModuleResources/CardViewTemplates(.SL).xaml")>
    Partial Public Class CardViewPrinting
        Inherits PrintViewGridDemoModule

        Public Sub New()
            InitializeComponent()
            printStyleChooser.SelectedIndex = 0
            ShowPreviewInNewTab()
            printStyleChooser.SelectedIndex = 1
            ShowPreviewInNewTab()
        End Sub

        Protected Overrides Function GetExportView() As DataViewBase
            Return cardView
        End Function

        Protected Overrides ReadOnly Property DXTabControl() As DXTabControl
            Get
                Return tabControl
            End Get
        End Property

        Private Sub printStyleChooser_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If cardView Is Nothing Then
                Return
            End If
            Select Case printStyleChooser.SelectedIndex
                Case 0
                    cardView.Style = CType(Resources("DefaultCardViewPrintStyle"), Style)
                Case 1
                    cardView.Style = CType(Resources("UniformCardSizePrintStyle"), Style)
            End Select
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
    End Class
End Namespace
