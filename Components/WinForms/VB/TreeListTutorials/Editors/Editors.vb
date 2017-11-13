Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraTab

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for Editors.
	''' </summary>
	Public Partial Class Editors
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			InitProperties()
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
				treeList1.ExpandAll()
			End If
		End Sub

		Private Sub InitProperties()
			For Each col As DevExpress.XtraTreeList.Columns.TreeListColumn In treeList1.Columns
				Dim tp As XtraTabPage = New XtraTabPage()
                Dim pg As DXperience.Demos.XtraPropertyGrid = New DXperience.Demos.XtraPropertyGrid()
				pg.BackColor = SystemColors.ControlLight
                pg.PropertyGrid.SelectedObject = col.ColumnEdit
				pg.Dock = DockStyle.Fill
                tp.Text = col.FieldName
				tp.Controls.Add(pg)
				tabControl1.TabPages.Add(tp)
			Next col
			tabControl1.SelectedTabPageIndex = 2
		End Sub

		Private Sub tabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabControl1.SelectedPageChanged
			Dim s As String = tabControl1.SelectedTabPage.Text
			treeList1.FocusedColumn = treeList1.Columns(s)
		End Sub
	End Class
End Namespace
