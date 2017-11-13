Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace SpreadsheetDemo
    Partial Public Class DocumentThemes
        Inherits SpreadsheetDemoModule

        Private generator As DocumentThemesDocumentGenerator

        Public Sub New()
            InitializeComponent()
            Me.generator = New DocumentThemesDocumentGenerator()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            InitializeWorkbook()
            Me.spreadsheetControl1.Document.History.Clear()
        End Sub
        Private Sub InitializeWorkbook()
            generator.Generate(spreadsheetControl1.Document)
            lbDocumentTheme.SelectedIndex = 0
        End Sub

        Private Sub lbDocumentTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If Not Me.generator.IsValidDocument() Then
                Return
            End If

            spreadsheetControl1.BeginUpdate()

            Select Case lbDocumentTheme.SelectedIndex
                Case 0
                    Me.generator.ApplyThemeGreen()
                Case 1
                    Me.generator.ApplyThemeOrange()
                Case 2
                    Me.generator.ApplyThemeRed()
                Case 3
                    Me.generator.ApplyThemeViolet()
                Case Else
                    Me.generator.ApplyThemeBlue()
            End Select

            Me.generator.FormatCells()
            spreadsheetControl1.EndUpdate()
            spreadsheetControl1.Document.History.Clear()
        End Sub
    End Class
End Namespace
