Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for SimpleAlphaBlending.
	''' </summary>
	Public Partial Class SimpleAlphaBlending
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

		Private Sub SimpleAlphaBlending_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			checkBox1.Checked = True
		End Sub

		'<checkBox1>
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			xtraVertGridBlending1.Enabled = checkBox1.Checked
			button1.Enabled = checkBox1.Checked
		End Sub
		'</checkBox1>

		'<button1>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			xtraVertGridBlending1.ShowDialog()
		End Sub
		'</button1>
	End Class
End Namespace
