Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridEditorShowMode.
	''' </summary>
	Public Partial Class GridEditorShowMode
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitEditors()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Private updateValues As Boolean = False
		Private Sub GridEditorShowMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
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
				Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

				gridControl1.DataSource = dv
				repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
			End If
		End Sub


		Private Sub InitEditors()
            imageComboBoxEdit1.Properties.Items.AddEnum(GetType(DevExpress.Utils.EditorShowMode))
            imageComboBoxEdit2.Properties.Items.AddEnum(GetType(DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum))
            updateValues = True
			imageComboBoxEdit1.EditValue = gridView1.OptionsBehavior.EditorShowMode
            imageComboBoxEdit2.EditValue = gridView1.OptionsView.ShowButtonMode
			checkEdit1.EditValue = gridView1.OptionsBehavior.Editable
			UpdateEnableMode()
			updateValues = False
		End Sub

		Private Sub UpdateEnableMode()
			imageComboBoxEdit2.Enabled = gridView1.OptionsBehavior.Editable
			imageComboBoxEdit1.Enabled = imageComboBoxEdit2.Enabled
		End Sub

		'<checkEdit1>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			If updateValues Then
			Return
			End If
			Dim checkEdit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			gridView1.OptionsBehavior.Editable = checkEdit.Checked
			UpdateEnableMode()
		End Sub
		'</checkEdit1>

		'<imageComboBoxEdit1>
		Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit1.SelectedIndexChanged
			If updateValues Then
			Return
			End If
			Dim edit As DevExpress.XtraEditors.ImageComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ImageComboBoxEdit)
			gridView1.OptionsBehavior.EditorShowMode = CType(edit.EditValue, DevExpress.Utils.EditorShowMode)
		End Sub
		'</imageComboBoxEdit1>

		'<imageComboBoxEdit2>
		Private Sub imageComboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit2.SelectedIndexChanged
			If updateValues Then
			Return
			End If
			Dim edit As DevExpress.XtraEditors.ImageComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ImageComboBoxEdit)
            gridView1.OptionsView.ShowButtonMode = CType(edit.EditValue, DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum)
		End Sub
		'</imageComboBoxEdit2>
	End Class
End Namespace
