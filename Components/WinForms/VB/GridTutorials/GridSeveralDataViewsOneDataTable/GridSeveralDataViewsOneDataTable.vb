Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridSeveralDataViewsOneDataTable.
	''' </summary>
	Public Partial Class GridSeveralDataViewsOneDataTable
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

		Private Sub GridSeveralDataViewsOneDataTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		'<checkEdit1>
		Private dv1, dv2 As DataView

		'</checkEdit1>
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As DataSet = New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim tbl As String = "[Order Details]"
				Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
				oleDbDataAdapter.Fill(ds, tbl)

				'<checkEdit1>
				Dim dt As DataTable = ds.Tables(0)
				dv1 = New DataView(dt)
				dv2 = New DataView(dt)
				'</checkEdit1>

				gridControl1.DataSource = dv1
				gridControl1.MainView.PopulateColumns()

				SetDataSource(gridControl2)
				gridControl2.MainView.PopulateColumns()
			End If
		End Sub

		'<checkEdit1>
		Private Sub SetDataSource(ByVal grid As GridControl)
			If checkEdit1.Checked Then
			grid.DataSource = dv1
			Else
				grid.DataSource = dv2
			End If
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			SetDataSource(gridControl2)
			gridView1.FocusedRowHandle = 0
		End Sub
		'</checkEdit1>
	End Class
End Namespace
