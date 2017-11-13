Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class ucPerfomanceGrid
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = GetDataTabletFromCSVFile("")
        End Sub
        Private Shared Function GetDataTabletFromCSVFile(ByVal csv_file_path As String) As DataTable
            Dim CSVFilePathName As String = DataLoader.GetRelativePath("PerformanceReport.csv")
            If String.IsNullOrEmpty(CSVFilePathName) Then
                Return Nothing
            End If
            Dim lines() As String = File.ReadAllLines(CSVFilePathName)
            Dim fields() As String
            fields = lines(0).Split(New Char() { ","c })
            Dim dataTable As New DataTable()
            For i As Integer = 0 To fields.Count() - 1
                dataTable.Columns.Add(fields(i), GetType(String))
            Next i
            Dim row As DataRow
            For i As Integer = 1 To lines.Count() - 1
                fields = lines(i).Split(New Char() { ","c })
                row = dataTable.NewRow()
                For f As Integer = 0 To dataTable.Columns.Count - 1
                    row(f) = fields(f)
                Next f
                dataTable.Rows.Add(row)
            Next i
            Return dataTable
        End Function
    End Class
End Namespace
