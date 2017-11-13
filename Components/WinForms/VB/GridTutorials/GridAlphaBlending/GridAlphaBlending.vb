Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridAlphaBlending.
	''' </summary>
	Public Partial Class GridAlphaBlending
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

		Private Sub GridAlphaBlending_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitHelper.InitAdvBandedView(gridControl1)
			checkEdit1.Checked = xtraGridBlending1.Enabled
		End Sub

		'<checkEdit1>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			Dim checkEdit As CheckEdit = TryCast(sender, CheckEdit)
			xtraGridBlending1.Enabled = checkEdit.Checked
			simpleButton1.Enabled = xtraGridBlending1.Enabled
		End Sub
		'</checkEdit1>

	  '<simpleButton1>
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			xtraGridBlending1.ShowDialog()
		End Sub
	  '</simpleButton1>
	End Class
End Namespace
