Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridExport.
    ''' </summary>
    Partial Public Class GridExport
        Inherits TutorialControl
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            AddHandler gridView1.PrintExportProgress, AddressOf gridView1_PrintExportProgress
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub GridExport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitNWindData()
            InitExportData()
        End Sub

        Private Sub InitExportData()
            For i As Integer = 0 To exportData.GetLength(0) - 1
                cbExport.Properties.Items.Add(exportData.GetValue(i, 0))
            Next i
            cbExport.SelectedIndex = 0
        End Sub

        Private tblGrid As String = "[Order Details]"
        Private tblLookUp As String = "Products"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
            oleDbDataAdapter.Fill(ds, tblGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
            oleDbDataAdapter.Fill(ds, tblLookUp)
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.ShowOnlyPredefinedDetails = True
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub

        Private Sub OpenFile(ByVal fileName As String)
            If XtraMessageBox.Show("Do you want to open this file?", "Export To...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Dim process As New System.Diagnostics.Process()
                    process.StartInfo.FileName = fileName
                    process.StartInfo.Verb = "Open"
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    process.Start()
                Catch
                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Cannot find an application on your system suitable for openning the file with exported data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            progressBarControl1.Position = 0
        End Sub

        Private Sub ExportToEx(ByVal filename As String, ByVal ext As String, ByVal exportView As BaseView)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If ext = "rtf" Then
                exportView.ExportToRtf(filename)
            End If
            If ext = "pdf" Then
                exportView.ExportToPdf(filename)
            End If
            If ext = "mht" Then
                exportView.ExportToMht(filename)
            End If
            If ext = "htm" Then
                exportView.ExportToHtml(filename)
            End If
            If ext = "txt" Then
                exportView.ExportToText(filename)
            End If
            If ext = "xls" Then
                exportView.ExportToXls(filename)
            End If
            If ext = "xlsx" Then
                exportView.ExportToXlsx(filename)
            End If
            Cursor.Current = currentCursor
        End Sub
        Private Function ShowSaveFileDialog(ByVal title As String, ByVal filter As String) As String
            Dim dlg As New SaveFileDialog()
            Dim name As String = Application.ProductName
            Dim n As Integer = name.LastIndexOf(".") + 1
            If n > 0 Then
                name = name.Substring(n, name.Length - n)
            End If
            dlg.Title = "Export To " & title
            dlg.FileName = name
            dlg.Filter = filter
            If dlg.ShowDialog() = DialogResult.OK Then
                Return dlg.FileName
            End If
            Return ""
        End Function
        Private Sub gridView1_PrintExportProgress(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
            SetPosition(e.ProgressPercentage)
        End Sub
        Private Sub SetPosition(ByVal pos As Integer)
            progressBarControl1.Position = pos
            Me.Update()
        End Sub
        Private exportData(,) As String = { _
            {"HTML Document", "HTML Documents|*.html", "htm"}, _
            {"Microsoft Excel 2007 Document", "Microsoft Excel|*.xlsx", "xlsx"}, _
            {"Microsoft Excel Document", "Microsoft Excel|*.xls", "xls"}, _
            {"RTF Document", "RTF Files|*.rtf", "rtf"}, _
            {"PDF Document", "PDF Files|*.pdf", "pdf"}, _
            {"MHT Document", "MHT Files|*.mht", "mht"}, _
            {"Text Document", "Text Files|*.txt", "txt"}}
        Private Sub sbExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbExport.Click
            Dim index As Integer = cbExport.SelectedIndex
            If index < 0 Then
                Return
            End If
            Dim fileName As String = ShowSaveFileDialog(exportData.GetValue(index, 0).ToString(), exportData.GetValue(index, 1).ToString())
            If fileName = String.Empty Then
                Return
            End If
            ExportToEx(fileName, exportData.GetValue(index, 2).ToString(), gridView1)
            OpenFile(fileName)
        End Sub
    End Class
End Namespace
