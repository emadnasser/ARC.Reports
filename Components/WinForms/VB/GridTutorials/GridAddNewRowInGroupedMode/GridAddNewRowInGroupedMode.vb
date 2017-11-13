Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridAddNewRowInGroupedMode.
	''' </summary>
	Public Partial Class GridAddNewRowInGroupedMode
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Private dv As DataView
		Private Sub GridAddNewRowInGroupedMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			gridView1.ExpandAllGroups()
		End Sub


		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As DataSet = New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim tblGrid As String = "[Order Details]"
				Dim tblLookUp As String = "Products"
				Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, con)
				oleDbDataAdapter.Fill(ds, tblGrid)
				oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, con)
				oleDbDataAdapter.Fill(ds, tblLookUp)

				Dim dvManager As DataViewManager = New DataViewManager(ds)
				dv = dvManager.CreateDataView(ds.Tables(tblGrid))

				gridControl1.DataSource = dv
				repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
			End If
		End Sub

		'<simpleButton1>
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			AddRow(gridView1)
		End Sub

		Private Sub AddRow(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
			Dim currentRow As Integer
			currentRow = view.FocusedRowHandle
			If currentRow < 0 Then
				currentRow = view.GetDataRowHandleByGroupRowHandle(currentRow)
			End If
			view.AddNewRow()

			If view.SortInfo.GroupCount = 0 Then
			Return
			End If

			'Initialize group values
			For Each groupColumn As DevExpress.XtraGrid.Columns.GridColumn In view.GroupedColumns
				Dim val As Object = view.GetRowCellValue(currentRow, groupColumn)
				view.SetRowCellValue(view.FocusedRowHandle, groupColumn, val)
			Next groupColumn
			view.UpdateCurrentRow()
			view.ShowEditor()
		End Sub
		'</simpleButton1>
	End Class
End Namespace
