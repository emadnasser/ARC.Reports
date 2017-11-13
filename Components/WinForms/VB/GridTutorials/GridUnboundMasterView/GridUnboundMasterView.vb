Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridUnboundMasterView.
	''' </summary>
	Public Partial Class GridUnboundMasterView
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

		Private Sub GridUnboundMasterView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData(xtraTabControl1.SelectedTabPage.Tag.ToString())
			gridControl1.MainView.PopulateColumns()
			ShowMasterDetailRows()
		End Sub
	  '<gridControl1>
		Private Sub InitData(ByVal collectionName As String)
			Select Case collectionName
				Case "IRelationList"
					gridControl1.DataSource = New IRelationListRecords()
				Case "NestedCollections"
					gridControl1.DataSource = New NestedRecords()
			End Select
		End Sub
	  '</gridControl1>
		Private Sub ShowMasterDetailRows()
			Dim i As Integer = 0
			Do While i < gridView1.RowCount
			gridView1.SetMasterRowExpanded(i, True)
				i += 1
			Loop
		End Sub

		Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
			gridControl1.Parent = e.Page
			InitData(e.Page.Tag.ToString())
			ShowMasterDetailRows()
		End Sub
	End Class
End Namespace
