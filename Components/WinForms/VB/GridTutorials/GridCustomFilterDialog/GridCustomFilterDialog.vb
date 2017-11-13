Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridCustomFilterDialog.
	''' </summary>
	Public Partial Class GridCustomFilterDialog
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

		Private Sub GridCustomFilterDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			radioGroup1.SelectedIndex = 1
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As DataSet = New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim tbl As String = "Products"
				Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
				oleDbDataAdapter.Fill(ds, tbl)

				Dim dvManager As DataViewManager = New DataViewManager(ds)
				Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tbl))

				gridControl1.DataSource = dv
			End If
		End Sub

		'<radioGroup1>
		Private filterColumn As String = "UnitPrice"
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			Dim editValue As Integer = CInt(Fix(radioGroup1.EditValue))
			If editValue = 0 Then
				gridView1.OptionsFilter.UseNewCustomFilterDialog = False
				gridView1.Columns(filterColumn).FilterInfo = New Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, Nothing, "[UnitPrice] <= 20")
			Else
				gridView1.OptionsFilter.UseNewCustomFilterDialog = True
				gridView1.Columns(filterColumn).FilterInfo = New Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, Nothing, "[UnitPrice] > [UnitsInStock]")
			End If
		End Sub

		Private Sub gridView1_CustomFilterDialog(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomFilterDialogEventArgs) Handles gridView1.CustomFilterDialog
			If radioGroup1.EditValue.Equals(2) Then
				Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
				e.Handled = True
				e.FilterInfo = Nothing
				Dim dlg As DevExpress.XtraGrid.Filter.FilterCustomDialog2 = New DevExpress.XtraGrid.Filter.FilterCustomDialog2(e.Column, gv.Columns, True)
				dlg.ShowDialog()
			End If
		End Sub
		'</radioGroup1>
	End Class
End Namespace
