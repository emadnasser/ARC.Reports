Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class FirstLook
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.Document.LoadDocument(DemoUtils.GetRelativePath("EmployeeInformation.xlsx"))
            ribbonControl1.SelectedPage = pageHome
        End Sub
        Private ReadOnly Property ActiveSheet() As Worksheet
            Get
                Return spreadsheetControl1.ActiveWorksheet
            End Get
        End Property

        Private Sub cbSelectedCellSelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim selectedCell As String = DirectCast(sender, ComboBoxEdit).SelectedItem.ToString()
            spreadsheetControl1.SelectedCell = ActiveSheet(selectedCell)
        End Sub

        Private Sub cbSelectionSelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim selection As String = DirectCast(sender, ComboBoxEdit).SelectedItem.ToString()
            spreadsheetControl1.Selection = ActiveSheet(selection)
        End Sub
    End Class
End Namespace
