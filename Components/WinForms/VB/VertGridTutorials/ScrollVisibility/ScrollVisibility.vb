Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for ScrollVisibilitySample.
	''' </summary>
	Public Partial Class ScrollVisibilitySample
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

		Private Sub ScrollVisibilitySample_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			AdjustmentGrid()
		End Sub

		Private Sub AdjustmentGrid()
			dataNavigator1.DataSource = vGridControl1.DataSource
			Select Case vGridControl1.LayoutStyle
				Case LayoutViewStyle.BandsView
					radioGroup2.SelectedIndex = 0
				Case LayoutViewStyle.SingleRecordView
					radioGroup2.SelectedIndex = 1
				Case LayoutViewStyle.MultiRecordView
					radioGroup2.SelectedIndex = 2
			End Select
			Select Case vGridControl1.ScrollVisibility
				Case ScrollVisibility.Never
					radioGroup1.SelectedIndex = 0
				Case ScrollVisibility.Auto
					radioGroup1.SelectedIndex = 1
				Case ScrollVisibility.Both
					radioGroup1.SelectedIndex = 2
				Case ScrollVisibility.Horizontal
					radioGroup1.SelectedIndex = 3
				Case ScrollVisibility.Vertical
					radioGroup1.SelectedIndex = 4
			End Select
			ShowDBNavigator()
		End Sub

		'<radioGroup1>
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			Select Case radioGroup1.SelectedIndex
				Case 0
					vGridControl1.ScrollVisibility = ScrollVisibility.Never
				Case 1
					vGridControl1.ScrollVisibility = ScrollVisibility.Auto
				Case 2
					vGridControl1.ScrollVisibility = ScrollVisibility.Both
				Case 3
					vGridControl1.ScrollVisibility = ScrollVisibility.Horizontal
				Case 4
					vGridControl1.ScrollVisibility = ScrollVisibility.Vertical
			End Select
			ShowDBNavigator()
		End Sub
		'</radioGroup1>

		'<radioGroup2>
		Private Sub radioGroup2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup2.SelectedIndexChanged
			Select Case radioGroup2.SelectedIndex
				Case 0
					vGridControl1.LayoutStyle = LayoutViewStyle.BandsView
				Case 1
					vGridControl1.LayoutStyle = LayoutViewStyle.SingleRecordView
				Case 2
					vGridControl1.LayoutStyle = LayoutViewStyle.MultiRecordView
			End Select
			ShowDBNavigator()

		End Sub
		'</radioGroup2>

		Private Sub ShowDBNavigator()
			panel3.Visible = ((vGridControl1.ScrollVisibility = ScrollVisibility.Never OrElse vGridControl1.ScrollVisibility = ScrollVisibility.Vertical) AndAlso (vGridControl1.LayoutStyle = LayoutViewStyle.BandsView OrElse vGridControl1.LayoutStyle = LayoutViewStyle.SingleRecordView))
		End Sub
	End Class
End Namespace
