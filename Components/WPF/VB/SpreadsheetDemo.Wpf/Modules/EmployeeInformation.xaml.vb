Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace SpreadsheetDemo
    Partial Public Class EmployeeInformation
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            Dim generator As New EmployeeInformationDocumentGenerator(Me.spreadsheetControl1.Document)
            generator.Generate(DemoUtils.GetRelativePath("EmployeeInformation_template.xlsx"))
            spreadsheetControl1.Document.History.Clear()
            ribbonControl1.SelectedPage = pageHome
        End Sub

        Private Sub OnCalculateButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim book As IWorkbook = Me.spreadsheetControl1.Document
            If book.Worksheets.Count > 2 Then
                book.Worksheets.ActiveWorksheet = book.Worksheets(2)
            End If
        End Sub
    End Class
End Namespace
