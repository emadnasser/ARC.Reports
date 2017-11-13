Imports System
Imports System.Windows
Imports GridDemo
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Utils
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.Native
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/PrintMasterDetailViewModel.(cs)"), CodeFile("Controls/DemoModuleControl.(cs)"), CodeFile("Controls/Converters.(cs)")>
    Partial Public Class PrintingMasterDetail
        Inherits PrintViewGridDemoModule

        Protected Overrides ReadOnly Property DXTabControl() As DXTabControl
            Get
                Return tabControl
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler Loaded, AddressOf PrintingMasterDetail_Loaded
        End Sub

        Private Sub PrintingMasterDetail_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.ExpandMasterRow(2)
            CType(grid.GetVisibleDetail(2), GridControl).ExpandMasterRow(0)
            grid.ExpandMasterRow(4, CustomersDescriptor)
            grid.ExpandMasterRow(6)
            ShowPreviewInNewTab()
        End Sub

        Protected Overrides Sub ShowPreviewInNewTab()
            ShowPrintPreviewInNewTab(grid, tabControl, "Preview")
        End Sub
        Protected Sub newTabButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ShowPreviewInNewTab()
        End Sub
        Protected Sub tabControl_TabHidden(ByVal sender As Object, ByVal e As TabControlTabHiddenEventArgs)
            DisposePrintPreviewTabContent(CType(DXTabControl.Items(e.TabIndex), DXTabItem))
        End Sub
    End Class
End Namespace
