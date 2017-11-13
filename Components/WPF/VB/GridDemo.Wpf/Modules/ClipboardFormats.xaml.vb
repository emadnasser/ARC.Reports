Imports System
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/ConditionalFormatting/ConditionalFormattingViewModel.cs"), CodeFile("ModuleResources/ConditionalFormatting/SaleOverviewData.cs")>
    Partial Public Class ClipboardFormats
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            tableView.SelectCells(5, grid.Columns.First(), 15, grid.Columns.Last())
            tableView.CopySelectedCellsToClipboard()
            PasteClipboardData()
        End Sub
        Protected Overrides ReadOnly Property IsGridBorderVisible() As Boolean
            Get
                Return True
            End Get
        End Property
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            tableView.CopySelectedCellsToClipboard()
            PasteClipboardData()
        End Sub
        Friend Sub PasteClipboardData()
            PasteHTMLFormat()
            PasteXLSFormat()
            PasteRTFFormat()
        End Sub
        Private Sub PasteRTFFormat()
            richEditControl.Document.RtfText = String.Empty
            richEditControl.Document.Text = String.Empty
            Dim rtfText As String
            Try
                rtfText = Clipboard.GetText(TextDataFormat.Rtf)
            Catch
                rtfText = Nothing
            End Try
            richEditControl.Document.AppendRtfText(rtfText)
        End Sub
        Private Sub PasteXLSFormat()
            spreadsheetControl.ActiveWorksheet.Clear(spreadsheetControl.ActiveWorksheet.GetDataRange())
            Dim stream As Stream
            Try
                stream = TryCast(Clipboard.GetDataObject().GetData("Biff8"), Stream)
            Catch
                stream = Nothing
            End Try
            spreadsheetControl.LoadDocument(stream, DevExpress.Spreadsheet.DocumentFormat.Xls)
            spreadsheetControl.ActiveWorksheet.DefaultColumnWidthInPixels = CInt((spreadsheetControl.ActualWidth)) \ grid.Columns.Count
        End Sub
        Private Sub PasteHTMLFormat()
            Dim html As String
            Try
                html = Clipboard.GetText(TextDataFormat.Html)
            Catch
                html = Nothing
            End Try
            If String.IsNullOrEmpty(html) Then
                webBrowser.NavigateToString(" ")
            Else
                html = html.Remove(0, html.Substring(0, html.IndexOf("<html", StringComparison.OrdinalIgnoreCase)).Length)
                webBrowser.NavigateToString(html)
            End If
        End Sub
        Public Overrides Sub Leave()
            webBrowser.Visibility = Visibility.Collapsed
        End Sub
        Public Overrides Sub Show()
            webBrowser.Visibility = Visibility.Visible
        End Sub
        Protected Overrides Sub Clear()
            MyBase.Clear()
            webBrowser.Visibility = System.Windows.Visibility.Collapsed
            webBrowser.Source = Nothing
            webBrowser.Dispose()
        End Sub

    End Class
End Namespace
