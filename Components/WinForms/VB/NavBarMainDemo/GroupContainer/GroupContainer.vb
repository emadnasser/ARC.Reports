Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for GroupContainer.
	''' </summary>
	Partial Public Class GroupContainer
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

		Private Sub GroupContainer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			radioButton1.Checked = True
			checkBox3.Checked = True
			checkBox1.Checked = checkBox3.Checked
			comboBox1.Properties.Items.AddRange(System.IO.Directory.GetLogicalDrives())
			If comboBox1.Properties.Items.Count > 1 Then
				comboBox1.SelectedIndex = 1
			End If
			comboBox2.SelectedIndex = 0
			dateTimePicker2.EditValue = Date.Now
			dateTimePicker1.EditValue = dateTimePicker2.EditValue
		End Sub

		Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton5.CheckedChanged, radioButton4.CheckedChanged, radioButton3.CheckedChanged, radioButton2.CheckedChanged, radioButton1.CheckedChanged
			Dim rb As CheckEdit = TryCast(sender, CheckEdit)
			rb.Font = New Font(rb.Font,If(rb.Checked, FontStyle.Bold, FontStyle.Regular))
			Dim isSpecifyDates As Boolean = rb Is radioButton5 AndAlso rb.Checked
			dateTimePicker2.Enabled = isSpecifyDates
			dateTimePicker1.Enabled = dateTimePicker2.Enabled
			comboBox2.Enabled = dateTimePicker1.Enabled
		End Sub

		Private Sub checkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged, checkBox4.CheckedChanged, checkBox3.CheckedChanged, checkBox2.CheckedChanged, checkBox1.CheckedChanged
			Dim cb As CheckEdit = TryCast(sender, CheckEdit)
			cb.Font = New Font(cb.Font,If(cb.Checked, FontStyle.Bold, FontStyle.Regular))
		End Sub
	End Class
End Namespace
