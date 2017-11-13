Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for RowsNavigation.
	''' </summary>
	Public Partial Class RowsNavigation
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

		Private Sub RowsNavigation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			vGridControl1.FocusedRow = vGridControl1.Rows(0).ChildRows(0)
		End Sub

		'<button1>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			vGridControl1.FocusFirst()
		End Sub
		'</button1>

		'<button2>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			vGridControl1.FocusPrev()
		End Sub
		'</button2>

		'<button3>
		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			vGridControl1.FocusNext()
		End Sub
		'</button3>

		'<button4>
		Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
			vGridControl1.FocusLast()
		End Sub
		'</button4>
	End Class
End Namespace
