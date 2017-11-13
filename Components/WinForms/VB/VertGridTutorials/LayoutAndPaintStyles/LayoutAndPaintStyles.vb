Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for LayoutAndPaintStyles.
	''' </summary>
	Public Partial Class LayoutAndPaintStyles
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

		Private Sub LayoutAndPaintStyles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			AdjustmentGrid()
		End Sub

		Private Sub AdjustmentGrid()
			Select Case vGridControl1.LayoutStyle
				Case LayoutViewStyle.BandsView
					radioGroup1.EditValue = 0
				Case LayoutViewStyle.SingleRecordView
					radioGroup1.EditValue = 1
				Case LayoutViewStyle.MultiRecordView
					radioGroup1.EditValue = 2
			End Select
			spinEdit1.Value = vGridControl1.BandsInterval
		End Sub

		'<radioGroup1>
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			spinEdit1.Enabled = False
			If radioGroup1.EditValue.Equals(0) Then
				vGridControl1.LayoutStyle = LayoutViewStyle.BandsView
				spinEdit1.Enabled = True
			End If
			If radioGroup1.EditValue.Equals(1) Then
			vGridControl1.LayoutStyle = LayoutViewStyle.SingleRecordView
			End If
			If radioGroup1.EditValue.Equals(2) Then
			vGridControl1.LayoutStyle = LayoutViewStyle.MultiRecordView
			End If

		End Sub
		'</radioGroup1>

		'<spinEdit1>
		Private Sub spinEdit1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged
			vGridControl1.BandsInterval = CInt(Fix(spinEdit1.Value))
			spinEdit1.Value = vGridControl1.BandsInterval
		End Sub
		'</spinEdit1>
	End Class
End Namespace
