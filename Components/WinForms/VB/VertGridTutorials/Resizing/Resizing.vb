Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for Resizing.
	''' </summary>
	Public Partial Class Resizing
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

		Private Sub Resizing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			SetValues()
		End Sub

		Private Sub SetValues()
			checkBox1.Checked = vGridControl1.OptionsBehavior.ResizeRowHeaders
			checkBox2.Checked = vGridControl1.OptionsBehavior.ResizeRowValues
			checkBox3.Checked = vGridControl1.OptionsBehavior.ResizeHeaderPanel
			spinEdit1.Value = vGridControl1.RecordWidth
			spinEdit2.Value = vGridControl1.RowHeaderWidth
			spinEdit3.Value = vGridControl1.RecordsInterval
		End Sub

		'<checkBox1>
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			Dim cb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			vGridControl1.OptionsBehavior.ResizeRowHeaders = cb.Checked
		End Sub
		'</checkBox1>

		'<checkBox2>
		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
			Dim cb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			vGridControl1.OptionsBehavior.ResizeRowValues = cb.Checked
		End Sub
		'</checkBox2>

		'<checkBox3>
		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
			Dim cb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			vGridControl1.OptionsBehavior.ResizeHeaderPanel = cb.Checked
		End Sub
		'</checkBox3>

		'<spinEdit1>
		Private Sub spinEdit1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged
			Dim n As DevExpress.XtraEditors.SpinEdit = TryCast(sender, DevExpress.XtraEditors.SpinEdit)
			vGridControl1.RecordWidth = CInt(Fix(n.Value))
		End Sub
		'</spinEdit1>

		'<spinEdit2>
		Private Sub spinEdit2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit2.EditValueChanged
			Dim n As DevExpress.XtraEditors.SpinEdit = TryCast(sender, DevExpress.XtraEditors.SpinEdit)
			vGridControl1.RowHeaderWidth = CInt(Fix(n.Value))
		End Sub
		'</spinEdit2>

		'<spinEdit3>
		Private Sub spinEdit3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit3.EditValueChanged
			Dim n As DevExpress.XtraEditors.SpinEdit = TryCast(sender, DevExpress.XtraEditors.SpinEdit)
			vGridControl1.RecordsInterval = CInt(Fix(n.Value))
		End Sub
		'</spinEdit3>

		Private Sub vGridControl1_RowHeaderWidthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vGridControl1.RowHeaderWidthChanged
			SetValues()
		End Sub

		Private Sub vGridControl1_RecordWidthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vGridControl1.RecordWidthChanged
			SetValues()
		End Sub
	End Class
End Namespace
