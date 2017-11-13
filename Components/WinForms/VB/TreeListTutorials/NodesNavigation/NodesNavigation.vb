Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for NodesNavigation.
	''' </summary>
	Public Partial Class NodesNavigation
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

		'<button1>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			treeList1.MoveFirst()
		End Sub
		'</button1>

		'<button2>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			treeList1.MovePrev()
		End Sub
		'</button2>

		'<button3>
		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			treeList1.MovePrevVisible()
		End Sub
		'</button3>

		'<button4>
		Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
			treeList1.MoveNext()
		End Sub
		'</button4>

		'<button5>
		Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
			treeList1.MoveNextVisible()
		End Sub
		'</button5>

		'<button6>
		Private Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
			treeList1.MoveLast()
		End Sub
		'</button6>

		'<button7>
		Private Sub button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button7.Click
			treeList1.MoveLastVisible()
		End Sub
		'</button7>
	End Class
End Namespace
