Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraTab
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
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
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub Editors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitProperties()
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml")
			If DBFileName <> "" Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(DBFileName)
				vGridControl1.DataSource = dataSet.Tables(0).DefaultView
			End If
		End Sub

		Private Sub AddTab(ByVal row As DevExpress.XtraVerticalGrid.Rows.BaseRow)
			If TypeOf row Is DevExpress.XtraVerticalGrid.Rows.EditorRow Then
				Dim tp As XtraTabPage = New XtraTabPage()
				Dim pg As XtraPropertyGrid = New XtraPropertyGrid()
				pg.PropertyGrid.SelectedObject = row.Properties.RowEdit
				pg.Dock = DockStyle.Fill
				pg.ShowDescription = False
				tp.Text = row.Properties.Caption
				tp.Controls.Add(pg)
				tabControl1.TabPages.Add(tp)
			End If
			For Each cRow As DevExpress.XtraVerticalGrid.Rows.BaseRow In row.ChildRows
				AddTab(cRow)
			Next cRow
		End Sub

		Private Sub InitProperties()
			For Each row As DevExpress.XtraVerticalGrid.Rows.BaseRow In vGridControl1.Rows
				AddTab(row)
			Next row
			tabControl1.SelectedTabPageIndex = 8
		End Sub

		Private Function SelectRow(ByVal row As DevExpress.XtraVerticalGrid.Rows.BaseRow, ByVal s As String) As Boolean
			If row.Properties.Caption = s Then
				vGridControl1.FocusedRow = row
				Return False
			End If
			For Each cRow As DevExpress.XtraVerticalGrid.Rows.BaseRow In row.ChildRows
				SelectRow(cRow, s)
			Next cRow
			Return True
		End Function

		Private Sub tabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles tabControl1.SelectedPageChanged
			Dim caption As String = tabControl1.TabPages(tabControl1.SelectedTabPageIndex).Text
			For Each row As DevExpress.XtraVerticalGrid.Rows.BaseRow In vGridControl1.Rows
				If (Not SelectRow(row, caption)) Then
				Return
				End If
			Next row
		End Sub
	End Class
End Namespace
