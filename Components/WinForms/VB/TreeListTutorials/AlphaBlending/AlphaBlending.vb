Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for AlphaBlending.
	''' </summary>
	Public Partial Class AlphaBlending
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			InitView()
			checkBox1.Checked = True
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
		End Sub

		Private Sub InitView()
			treeList1.OptionsView.ShowSummaryFooter = True
			treeList1.OptionsView.ShowRowFooterSummary = True
			Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList1.Columns(1)
			col.SummaryFooter = SummaryItemType.Sum
			col.SummaryFooterStrFormat = "Sum = {0:c}"
			col.RowFooterSummary = SummaryItemType.Sum
			col.RowFooterSummaryStrFormat = "{0:c}"
			col.AllNodesSummary = True
			col = treeList1.Columns(0)
			col.SummaryFooter = SummaryItemType.Count
			col.RowFooterSummary = SummaryItemType.Count
			col.AllNodesSummary = True
		End Sub

		'<checkBox1>
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			xtraTreeListBlending1.Enabled = checkBox1.Checked
			button1.Enabled = checkBox1.Checked
		End Sub
		'</checkBox1>

		'<button1>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			xtraTreeListBlending1.ShowDialog()
		End Sub
		'</button1>
	End Class
End Namespace
