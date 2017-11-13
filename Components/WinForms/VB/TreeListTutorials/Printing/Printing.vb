Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for Printing.
	''' </summary>
	Public Partial Class Printing
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			InitView()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
		End Sub

		Private Sub InitView()
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

		'<button1>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            treeList1.ShowPrintPreview()
            Windows.Forms.Cursor.Current = Cursors.Default
		End Sub
		'</button1>

		'<button2>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
			Dim frm As DevExpress.XtraEditors.XtraForm = New DevExpress.XtraEditors.XtraForm()
			frm.Text = "Print Designer"
			Dim print As DevExpress.XtraTreeList.Frames.TreeListPrinting = New DevExpress.XtraTreeList.Frames.TreeListPrinting()
			print.InitFrame(treeList1, "PrintingReport management", Nothing)
			print.Dock = DockStyle.Fill
			frm.Controls.Add(print)
			frm.Size = print.UserControlSize
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.ShowDialog()
            Windows.Forms.Cursor.Current = Cursors.Default
		End Sub
		'</button2>
	End Class
End Namespace
