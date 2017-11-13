Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.DemoBase
Imports System
Imports System.Collections.Generic
Imports System.IO
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

Namespace GridDemo
    Partial Public Class ExcelItemsSource
        Inherits PrintViewGridDemoModule

        Public Sub New()
            InitializeComponent()
            SetUpSpreadsheetControl()
        End Sub

        Protected Overrides Function GetExportView() As DevExpress.Xpf.Grid.DataViewBase
            Return view
        End Function

        Protected Overrides ReadOnly Property DXTabControl() As DevExpress.Xpf.Core.DXTabControl
            Get
                Return tabControl
            End Get
        End Property


        Private Sub SetUpSpreadsheetControl()
            Using stream As Stream = Application.GetResourceStream(New Uri("pack://application:,,,/GridDemo;component/Data/Orders.xls")).Stream
                spreadsheetControl.Document.LoadDocument(stream, DocumentFormat.Xls)
            End Using
        End Sub
    End Class
End Namespace
