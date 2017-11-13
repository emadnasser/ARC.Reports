Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Commands

Namespace SpreadsheetDemo
    Partial Public Class PrintTitles
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()

            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"), DocumentFormat.Xlsx)
        End Sub

        Private Sub btnPageSetup_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim service As ISpreadsheetCommandFactoryService = DirectCast(spreadsheetControl1.GetService(GetType(ISpreadsheetCommandFactoryService)), ISpreadsheetCommandFactoryService)
            Dim command As SpreadsheetCommand = service.CreateCommand(SpreadsheetCommandId.PageSetupSheet)
            command.ForceExecute(command.CreateDefaultCommandUIState())
        End Sub
        Private Sub btnPrintPreview_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim service As ISpreadsheetCommandFactoryService = DirectCast(spreadsheetControl1.GetService(GetType(ISpreadsheetCommandFactoryService)), ISpreadsheetCommandFactoryService)
            Dim command As SpreadsheetCommand = service.CreateCommand(SpreadsheetCommandId.FilePrintPreview)
            command.ForceExecute(command.CreateDefaultCommandUIState())
        End Sub
    End Class
End Namespace
