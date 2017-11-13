Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridBandedViewNavigation.
	''' </summary>
	Public Partial Class GridBandedViewNavigation
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

		Private Sub GridBandedViewNavigation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitHelper.InitAdvBandedView(gridControl1)
			InitOptions()
		End Sub

		Private Sub InitOptions()
		 checkEdit1.Checked = advBandedGridView1.OptionsNavigation.UseAdvHorzNavigation
			checkEdit2.Checked = advBandedGridView1.OptionsNavigation.UseAdvVertNavigation
		End Sub

	  '<checkEdit1>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			Dim edit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			advBandedGridView1.OptionsNavigation.UseAdvHorzNavigation = edit.Checked
		End Sub
	  '</checkEdit1>

	  '<checkEdit2>
		Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit2.CheckedChanged
			Dim edit As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			advBandedGridView1.OptionsNavigation.UseAdvVertNavigation = edit.Checked
		End Sub
	  '</checkEdit2>
	End Class
End Namespace
