Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class RunningTotal
		Inherits TutorialControl
		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\RunningTotal.vb"
            TutorialInfo.WhatsThisXMLFile = "RunningTotal.xml"

			pivotGridControl.DataSource = GetNWindData("CustomerReports")
			ceShowRunningTotals.Checked = True
			ceAllowCrossGroupRunningTotals.Checked = True
			pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
		End Sub
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		'<ceShowRunningTotals>
		Private Sub ceShowRunningTotals_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowRunningTotals.CheckedChanged
			fieldOrderQuarter.RunningTotal = ceShowRunningTotals.Checked
			ceAllowCrossGroupRunningTotals.Enabled = ceShowRunningTotals.Checked
		End Sub
		'</ceShowRunningTotals>

		'<ceAllowCrossGroupRunningTotals>
		Private Sub ceAllowCrossGroupRunningTotals_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAllowCrossGroupRunningTotals.CheckedChanged
			pivotGridControl.OptionsData.AllowCrossGroupVariation = ceAllowCrossGroupRunningTotals.Checked
		End Sub
		'</ceAllowCrossGroupRunningTotals>
	End Class
End Namespace
