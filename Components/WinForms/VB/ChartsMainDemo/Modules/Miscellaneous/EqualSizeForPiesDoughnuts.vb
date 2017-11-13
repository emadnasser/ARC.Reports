Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class EqualSizeForPiesDoughnutsDemo
		Inherits ChartDemoBase2D

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			checkEditShowLabels.Visible = False
		End Sub

		Private Sub cheEqualPieSize_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheEqualPieSize.CheckedChanged
			If chart Is Nothing Then
				Return
			End If
			Dim simpleDiagram As SimpleDiagram = TryCast(chart.Diagram, SimpleDiagram)
			If simpleDiagram Is Nothing Then
				Return
			End If
			If cheEqualPieSize.Checked = True Then
				simpleDiagram.EqualPieSize = True
			Else
				simpleDiagram.EqualPieSize = False
			End If
		End Sub
		Private Sub tbcMinAllowedSizePercentage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbcMinAllowedSizePercentage.EditValueChanged
			CType(chart.Series("Condiments").View, PieSeriesView).MinAllowedSizePercentage = tbcMinAllowedSizePercentage.Value
		End Sub
		Private Sub seRestoreDefaultLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbRestoreDefaultLayout.Click
			tbcMinAllowedSizePercentage.Value = 0
			cheEqualPieSize.Checked = False
			cbeView.SelectedIndex = 0
		End Sub
		Private Sub cbeView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeView.SelectedIndexChanged
			If CStr(cbeView.EditValue) Is "Pie" Then
				For Each series As Series In chart.Series
					series.ChangeView(ViewType.Pie)
				Next series
			Else
				For Each series As Series In chart.Series
					series.ChangeView(ViewType.Doughnut)
				Next series
			End If
		End Sub
		Private Sub tbcMinAllowedSizePercentage_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As XtraEditors.TrackBarValueToolTipEventArgs) Handles tbcMinAllowedSizePercentage.BeforeShowValueToolTip
			e.ShowArgs.ToolTip = String.Format("{0}%", tbcMinAllowedSizePercentage.Value)
		End Sub
	End Class
End Namespace
