Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridPreview.
	''' </summary>
	Public Partial Class GridPreview
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

		Private Sub GridPreview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitGrid()
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As DataSet = New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim tbl As String = "Employees"
				Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
				oleDbDataAdapter.Fill(ds, tbl)

				gridControl1.DataSource = ds.Tables(tbl)
			End If
		End Sub

		Private Sub InitGrid()
			checkEdit1.Checked = True
			checkEdit2.Checked = True
			checkEdit3.Checked = False
			For Each column As DevExpress.XtraGrid.Columns.GridColumn In gridView1.Columns
				comboBoxEdit1.Properties.Items.Add(column.FieldName)
			Next column
			comboBoxEdit1.EditValue = "Notes"
			spinEdit1.Value = gridView1.PreviewIndent
		End Sub

	  '<checkEdit1>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			gridView1.OptionsView.ShowPreview = checkEdit.Checked
		End Sub
	  '</checkEdit1>

	  '<checkEdit2>
		Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit2.CheckedChanged
			Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			gridView1.OptionsView.AutoCalcPreviewLineCount = checkEdit.Checked
		End Sub
	  '</checkEdit2>

	  '<checkEdit3>
		Private Sub checkEdit3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit3.CheckedChanged
			Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			gridView1.Invalidate()
			spinEdit1.Enabled = Not checkEdit.Checked
		End Sub
	  '</checkEdit3>

	  '<comboBoxEdit1>
		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
			Dim comboBox As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
			gridView1.PreviewFieldName = comboBox.EditValue.ToString()
		End Sub
	  '</comboBoxEdit1>

	  '<checkEdit3>
		Private Sub gridView1_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawRowPreview
			If checkEdit3.Checked Then
				Dim dx As Integer = 5
				Dim r As Rectangle = e.Bounds
				r.X += e.Bounds.Height + dx * 2
				r.Width -= e.Bounds.Height + dx * 2
				e.Graphics.DrawImage(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(CType(gridView1.GetDataRow(e.RowHandle)("Photo"), Byte())), e.Bounds.X + dx, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height)
				e.Appearance.DrawString(e.Cache, gridView1.GetRowPreviewDisplayText(e.RowHandle), r)
				e.Handled = True
			End If
		End Sub
	  '</checkEdit3>
		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged
			Dim spinEdit As DevExpress.XtraEditors.SpinEdit = TryCast(sender, DevExpress.XtraEditors.SpinEdit)
			gridView1.PreviewIndent = Convert.ToInt32(spinEdit1.Value)
		End Sub
	End Class
End Namespace
