Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for Summaries.
	''' </summary>
	Public Partial Class Summaries
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			InitSummaries()
			checkBox1.Checked = treeList1.OptionsMenu.EnableFooterMenu
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
		End Sub

		'<checkBox1>
		Private Sub InitSummaries()
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

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			treeList1.OptionsMenu.EnableFooterMenu = checkBox1.Checked
		End Sub
		'</checkBox1>

		Private Sub treeList1_TreeListMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.TreeListMenuItemClickEventArgs) Handles treeList1.TreeListMenuItemClick
			If e.MenuType = DevExpress.XtraTreeList.Menu.TreeListMenuType.Summary AndAlso (Not e.MenuItem.Tag.Equals(DevExpress.XtraTreeList.Localization.TreeListStringId.MenuFooterCount)) AndAlso e.Column.FieldName = "Budget" Then
				Dim s As String = e.SummaryFormat
				Dim i As Integer = s.IndexOf("0")
				If i > 0 Then
				s = s.Substring(0, i) & "0:c}"
				End If
				e.SummaryFormat = s
			End If
		End Sub

	End Class
End Namespace
