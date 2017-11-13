Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for MultiSelect.
	''' </summary>
	Public Partial Class MultiSelect
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
			cbMultiSelect.Checked = True
			treeList1.Selection.Add(treeList1.Nodes(0))
			treeList1.Selection.Add(treeList1.Nodes(0).Nodes(0))
			treeList1.Selection.Add(treeList1.Nodes(0).Nodes(1))
		End Sub

		'<cbMultiSelect>
		Private Sub cbMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMultiSelect.CheckedChanged
			treeList1.OptionsSelection.MultiSelect = cbMultiSelect.Checked
			If cbMultiSelect.Checked Then
				SelectionChanged()
			Else
				lbSelectedRowsCount.Text = "-1"
				lbSelectedRows.Text = "MultiSelect is Disabled."
			End If
		End Sub
		'</cbMultiSelect>

		Private Function ArrayToString(ByVal arr As DevExpress.XtraTreeList.TreeListMultiSelection) As String
			Dim s As String = ""
			If arr.Count = 0 Then
				s = "Empty..."
			Else
				For Each node As DevExpress.XtraTreeList.Nodes.TreeListNode In arr
					If s = "" Then
						s &= ("") + node.Id.ToString()
					Else
						s &= (";") + node.Id.ToString()
					End If
				Next node
				s &= "."
			End If
			Return s
		End Function

		'<treeList1>
		'<cbMultiSelect>
		Private Sub SelectionChanged()
			lbSelectedRowsCount.Text = treeList1.Selection.Count.ToString()
			lbSelectedRows.Text = ArrayToString(treeList1.Selection)
		End Sub
		'</treeList1>
		'</cbMultiSelect>

		'<treeList1>
		Private Sub treeList1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.SelectionChanged
			SelectionChanged()
		End Sub
		'</treeList1>
	End Class
End Namespace
