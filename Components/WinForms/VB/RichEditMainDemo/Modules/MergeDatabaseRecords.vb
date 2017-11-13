Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraSpellChecker.Parser
Imports DevExpress.XtraRichEdit.SpellChecker
Imports System.IO
Imports DevExpress.XtraTab
Imports DevExpress.XtraRichEdit.Demos.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Services
Imports System.Data.OleDb
Imports DevExpress.Office.Services

Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class MergeDatabaseRecordsModule
        Inherits MergeModuleBase
        Private connection As System.Data.OleDb.OleDbConnection
        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("MailMerge.rtf", sourceRichEditControl_Renamed)
            CType(New RichEditDemoExceptionsHandler(sourceRichEditControl_Renamed), RichEditDemoExceptionsHandler).Install()
            Me.connection = New System.Data.OleDb.OleDbConnection()
            SourceRichEditControl.Options.MailMerge.ViewMergedData = True
        End Sub


        Protected Overrides ReadOnly Property SourceRichEditControl() As RichEditControl
            Get
                Return sourceRichEditControl_Renamed
            End Get
        End Property

        Private Sub MailMergeModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
            If path.Length <= 0 Then
                Return
            End If
            Dim uriService As IUriStreamService = CType(SourceRichEditControl.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New DBUriStreamProvider(nwindDataSet.Employees, "Photo"))
            DemoUtils.SetConnectionString(employeesTableAdapter.Connection, path)
            DemoUtils.SetConnectionString(Me.connection, path)
            Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
            FillData()
        End Sub
        Protected Overrides Function CreateMergeFieldForm() As MergeFieldsFormBase
            Return New MergeDatabaseRecordsForm()
        End Function
        Protected Overrides Sub CalculateMailMergeOptions(ByVal form As MergeFieldsFormBase, ByVal options As MailMergeOptions)
            If form.MergeRecords = MergeRecords.Selected Then
                Dim selectedRowIndexes() As Integer = gridView1.GetSelectedRows()
                Dim count As Integer = selectedRowIndexes.Length
                Dim selectedRows As New List(Of Object)()
                For i As Integer = 0 To count - 1
                    selectedRows.Add(gridView1.GetRow(selectedRowIndexes(i)))
                Next i
                options.DataSource = selectedRows
            End If
        End Sub
        Private Sub FillData()
            Dim cmd As String = "SELECT Employees.*, Customers.* FROM (Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;"
            Dim selectCommand As New System.Data.OleDb.OleDbCommand(cmd, connection)

            Dim adapter As New System.Data.OleDb.OleDbDataAdapter(selectCommand)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet)
            SourceRichEditControl.Options.MailMerge.DataSource = dataSet.Tables(0)
            Me.gridControl1.DataSource = dataSet.Tables(0)
        End Sub

        Private Sub mergeToNewDocumentClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mergeToNewDocumentItem.ItemClick
            MergeToNewDocument()
        End Sub
    End Class
    Public Class DBUriStreamProvider
        Implements IUriStreamProvider
        Private Shared ReadOnly prefix As String = "dbimg://"
        Private table As DataTable
        Private columnName As String

        Public Sub New(ByVal table As DataTable, ByVal columnName As String)
            Me.table = table
            Me.columnName = columnName
        End Sub

#Region "IUriStreamProvider Members"
        Public Function GetStream(ByVal uri As String) As Stream Implements IUriStreamProvider.GetStream
            uri = uri.Trim()
            If (Not uri.StartsWith(prefix)) Then
                Return Nothing
            End If
            Dim strId As String = uri.Substring(prefix.Length).Trim()
            Dim id As Integer
            If (Not Integer.TryParse(strId, id)) Then
                Return Nothing
            End If
            Dim row As DataRow = table.Rows.Find(id)
            If row Is Nothing Then
                Return Nothing
            End If
            Dim bytes() As Byte = TryCast(row(columnName), Byte())
            If bytes Is Nothing Then
                Return Nothing
            End If
            Return New MemoryStream(bytes)
        End Function
#End Region
    End Class
End Namespace
