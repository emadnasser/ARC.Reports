Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports DevExpress.XtraRichEdit
Imports System.Collections.Generic
Imports DevExpress.Office.Services
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrintingLinks

Namespace DevExpress.Docs.Demos
	Partial Public Class RichEditMailMerge
		Inherits TutorialControlBase
		Private link As PrintableComponentLinkBase
		Private documentServer As RichEditDocumentServer
		Private connection As New System.Data.OleDb.OleDbConnection()
		Public Sub New()
			InitializeComponent()

			Me.documentServer = New RichEditDocumentServer()
			Dim path As String = DemoUtils.GetRelativePath("MailMerge.rtf")
			Me.documentServer.LoadDocument(path, DocumentFormat.Rtf)

			Me.printPreviewControl.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()
			Me.link = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(Me.printPreviewControl.PrintingSystem)
			LoadData()
			Me.documentServer.Options.MailMerge.ViewMergedData = True
			AddHandler Me.gridView1.FocusedRowChanged, AddressOf gridView1_FocusedRowChanged
			AddHandler Load, AddressOf MailMerge_Load
		End Sub

		Private Sub MailMerge_Load(ByVal sender As Object, ByVal e As EventArgs)
			ProcessSelectedRows()
		End Sub
		Private Sub ProcessSelectedRows()
			UpdateMailMergeOptions()
			link.Component = Me.documentServer
			link.CreateDocument()
		End Sub
		Protected Sub UpdateMailMergeOptions()
			Dim selectedRowIndexes() As Integer = gridView1.GetSelectedRows()
			Dim count As Integer = selectedRowIndexes.Length
			Dim selectedRows As New List(Of Object)()
			For i As Integer = 0 To count - 1
				selectedRows.Add(gridView1.GetRow(selectedRowIndexes(i)))
			Next i
			Me.documentServer.Options.MailMerge.DataSource = selectedRows
		End Sub
		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowChangedEventArgs)
			ProcessSelectedRows()
		End Sub
		Private Sub LoadData()
			Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
			If path.Length <= 0 Then
				Return
			End If
			Dim uriService As IUriStreamService = CType(Me.documentServer.GetService(GetType(IUriStreamService)), IUriStreamService)
			uriService.RegisterProvider(New DBUriStreamProvider(nwindDataSet.Employees, "Photo"))
			employeesTableAdapter.Connection = New System.Data.OleDb.OleDbConnection()
			DemoUtils.SetConnectionString(employeesTableAdapter.Connection, path)
			DemoUtils.SetConnectionString(Me.connection, path)
			Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
			FillData()
		End Sub
		Private Sub FillData()
			Dim cmd As String = "SELECT Employees.*, Customers.* FROM (Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;"
			Dim selectCommand As New System.Data.OleDb.OleDbCommand(cmd, connection)
			Dim adapter As New System.Data.OleDb.OleDbDataAdapter(selectCommand)
			Dim dataSet As New DataSet()
			adapter.Fill(dataSet)
			Me.gridControl1.DataSource = dataSet.Tables(0)
			Me.documentServer.Options.MailMerge.DataSource = dataSet.Tables(0)
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
		Private Function GetStream(ByVal uri As String) As Stream Implements IUriStreamProvider.GetStream
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
