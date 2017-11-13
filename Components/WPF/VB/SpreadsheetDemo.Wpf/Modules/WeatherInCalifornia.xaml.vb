Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraSpreadsheet.Demos

Namespace SpreadsheetDemo
    Partial Public Class WeatherInCalifornia
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            InitializeWorkbook()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            UpdateConditionalFormatting()
            ribbonControl1.SelectedPage = pageHome
        End Sub

        Private Sub InitializeWorkbook()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.LoadDocument(DemoUtils.GetRelativePath("WeatherInCalifornia.xlsx"))
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            UpdateConditionalFormatting()
        End Sub
        Private Sub UpdateConditionalFormatting()
            If spreadsheetControl1 Is Nothing Then
                Return
            End If

            spreadsheetControl1.BeginUpdate()
            Try
                Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
                sheet.ConditionalFormattings.Clear()
                If chkTemperature.IsChecked = True Then
                    DevExpress.XtraSpreadsheet.Demos.WeatherInCalifornia.ApplyTemperatureConditionalFormatting(sheet)
                End If
                If chkHumidity.IsChecked = True Then
                    DevExpress.XtraSpreadsheet.Demos.WeatherInCalifornia.ApplyHumidityConditionalFormatting(sheet)
                End If
                If chkPressure.IsChecked = True Then
                    DevExpress.XtraSpreadsheet.Demos.WeatherInCalifornia.ApplyPressureConditionalFormatting(sheet)
                End If
            Finally
                spreadsheetControl1.EndUpdate()
            End Try
        End Sub

    End Class
End Namespace
