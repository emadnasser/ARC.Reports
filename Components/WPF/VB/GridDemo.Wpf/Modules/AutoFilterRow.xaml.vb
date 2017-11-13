Imports System
Imports System.Windows
Imports System.Windows.Data
Imports GridDemo
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Utils
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/AutoFilterRowTemplates(.SL).xaml"), CodeFile("ModuleResources/AutoFilterRowClasses.(cs)")>
    Partial Public Class AutoFilterRow
        Inherits GridDemoModule

  Public Sub New()
   InitializeComponent()
   grid.ItemsSource = OutlookDataGenerator.CreateOutlookDataTable(1000)
            Dim settings As New ComboBoxEditSettings() With {.IsTextEditable = False}
            ComboBoxEdit.SetupComboBoxSettingsEnumItemSource(Of Priority)(settings)
            colPriority.EditSettings = settings
  End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
