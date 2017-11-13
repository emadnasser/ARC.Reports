Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridColumnAlignment.
	''' </summary>
	Public Partial Class GridColumnAlignment
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

		Private Sub GridColumnAlignment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitComboBoxes()
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

		Private Sub InitComboBoxes()
			For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridView1.Columns
				comboBoxEdit1.Properties.Items.Add(c.Caption)
			Next c
			comboBoxEdit1.SelectedIndex = 1
			comboBoxEdit2.Properties.Items.AddRange(System.Enum.GetNames(GetType(DevExpress.Utils.HorzAlignment)))
			comboBoxEdit2.SelectedIndex = 2
		End Sub

		Private Function HorzAlignmentByString(ByVal s As String) As DevExpress.Utils.HorzAlignment
			If s = "" Then
			Return DevExpress.Utils.HorzAlignment.Default
			End If
			Return CType(System.Enum.Parse(GetType(DevExpress.Utils.HorzAlignment), s), DevExpress.Utils.HorzAlignment)
		End Function

	  '<comboBoxEdit1>
	  '<comboBoxEdit2>
		Private Sub SetColumnStyle(ByVal c As DevExpress.XtraGrid.Columns.GridColumn, ByVal alignment As String)
			If c Is Nothing Then
			Return
			End If
			c.AppearanceCell.TextOptions.HAlignment = HorzAlignmentByString(alignment)
		End Sub
	  '</comboBoxEdit1>
	  '</comboBoxEdit2>

	  '<comboBoxEdit1>
	  '<comboBoxEdit2>
		Private Function ColumnByCaption(ByVal s As String) As DevExpress.XtraGrid.Columns.GridColumn
			For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridView1.Columns
				If c.Caption = s Then
				Return c
				End If
			Next c
			Return Nothing
		End Function
	  '</comboBoxEdit1>
	  '</comboBoxEdit2>

	  '<comboBoxEdit1>
	  '<comboBoxEdit2>
		Private Sub comboBoxEdit_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEdit2.SelectedIndexChanged, comboBoxEdit1.SelectedIndexChanged
			SetColumnStyle(ColumnByCaption(comboBoxEdit1.EditValue.ToString()), comboBoxEdit2.EditValue.ToString())
		End Sub
	  '</comboBoxEdit1>
	  '</comboBoxEdit2>
	End Class
End Namespace
