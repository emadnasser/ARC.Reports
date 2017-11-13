Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for Preview.
	''' </summary>
	Public Partial Class Preview
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			InitOptions()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\BioLife.xml")
			If DBFileName <> "" Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(DBFileName)
				treeList1.DataSource = dataSet.Tables(0).DefaultView
				treeList1.PopulateColumns()
				HideColumns(New String() { "Notes", "Picture", "RecordDate" })
				treeList1.BestFitColumns()
				treeList1.ExpandAll()
				For Each col As DevExpress.XtraTreeList.Columns.TreeListColumn In treeList1.Columns
					comboBox1.Properties.Items.Add(col.FieldName)
				Next col
				comboBox1.SelectedItem = "Notes"
			End If
		End Sub

		Private Sub HideColumns(ByVal names As String())
			For Each s As String In names
				treeList1.Columns(s).VisibleIndex = -1
			Next s
		End Sub

		Private Sub InitOptions()
			checkBox1.Checked = treeList1.OptionsView.ShowPreview
			checkBox2.Checked = treeList1.OptionsView.AutoCalcPreviewLineCount
		End Sub

		'<comboBox1>
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
			treeList1.PreviewFieldName = comboBox1.SelectedItem.ToString()
		End Sub
		'</comboBox1>

		'<checkBox1>
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			Dim chb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			treeList1.OptionsView.ShowPreview = chb.Checked
		End Sub
		'</checkBox1>

		'<checkBox2>
		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
			Dim chb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			treeList1.OptionsView.AutoCalcPreviewLineCount = chb.Checked
		End Sub
		'</checkBox2>

		'<checkBox3>
		Private Sub treeList1_GetPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetPreviewTextEventArgs) Handles treeList1.GetPreviewText
			If checkBox3.Checked Then
				e.PreviewText = "This is a description for " & e.Node.GetDisplayText(3)
			End If
		End Sub

		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
			label3.Enabled = Not checkBox3.Checked
			comboBox1.Enabled = label3.Enabled
			treeList1.LayoutChanged()
		End Sub
		'</checkBox3>
	End Class
End Namespace
