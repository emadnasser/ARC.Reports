Imports DevExpress.Sparkline

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleSparklineEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.AboutFile = Nothing
			TutorialInfo.Description = ""
			TutorialInfo.TutorialName = "Sparkline Edit Tutorial"
			TutorialInfo.WhatsThisCodeFile = ""
			TutorialInfo.WhatsThisXMLFile = ""
			InitializeViewCombobox()
			UpdateElements()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleSparklineEdit.vb"
            TutorialInfo.WhatsThisXMLFile = "SparklineEdit.xml"
		End Sub
		Private Sub InitializeViewCombobox()
			For Each view As SparklineViewType In System.Enum.GetValues(GetType(SparklineViewType))
				cbeView.Properties.Items.Add(view)
			Next view
			cbeView.SelectedItem = sparklineEdit.Properties.View.Type
		End Sub
		Private Sub UpdateElements()
			ceMax.Color = sparklineEdit.Properties.View.ActualMaxPointColor
			ceMin.Color = sparklineEdit.Properties.View.ActualMinPointColor
			ceStart.Color = sparklineEdit.Properties.View.ActualStartPointColor
			ceEnd.Color = sparklineEdit.Properties.View.ActualEndPointColor
			ceColor.Color = sparklineEdit.Properties.View.ActualColor
			ceNegative.Color = sparklineEdit.Properties.View.ActualNegativePointColor

			cheHighlightMaxPoint.Checked = sparklineEdit.Properties.View.HighlightMaxPoint
			cheHighlightMinPoint.Checked = sparklineEdit.Properties.View.HighlightMinPoint
			cheHighlightStartPoint.Checked = sparklineEdit.Properties.View.HighlightStartPoint
			cheHighlightEndPoint.Checked = sparklineEdit.Properties.View.HighlightEndPoint

			Dim lineView As LineSparklineView = TryCast(sparklineEdit.Properties.View, LineSparklineView)
			ceMarkers.Enabled = lineView IsNot Nothing
			cheShowMarkers.Enabled = ceMarkers.Enabled
			If lineView IsNot Nothing Then
				ceMarkers.Color = lineView.ActualMarkerColor
				cheHighlightNegativePoints.Checked = lineView.HighlightNegativePoints
				cheShowMarkers.Checked = lineView.ShowMarkers
			End If

			Dim areaView As AreaSparklineView = TryCast(sparklineEdit.Properties.View, AreaSparklineView)
			trbArea.Enabled = areaView IsNot Nothing
			lblArea.Enabled = trbArea.Enabled
			If areaView IsNot Nothing Then
				trbArea.Value = areaView.AreaOpacity
			End If

			cheHighlightNegativePoints.Enabled = Not(TypeOf sparklineEdit.Properties.View Is WinLossSparklineView)
			If TypeOf sparklineEdit.Properties.View Is BarSparklineView Then
				cheHighlightNegativePoints.Checked = CType(sparklineEdit.Properties.View, BarSparklineView).HighlightNegativePoints
			End If

			ceMax.Enabled = cheHighlightMaxPoint.Checked
			ceMin.Enabled = cheHighlightMinPoint.Checked
			ceStart.Enabled = cheHighlightStartPoint.Checked
			ceEnd.Enabled = cheHighlightEndPoint.Checked
			ceMarkers.Enabled = cheShowMarkers.Checked AndAlso cheShowMarkers.Enabled
			ceNegative.Enabled = cheHighlightNegativePoints.Checked AndAlso cheHighlightNegativePoints.Enabled OrElse Not cheHighlightNegativePoints.Enabled
		End Sub
		' <cbeView>
		Private Sub cbeView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeView.SelectedIndexChanged
            If sparklineEdit.Properties.View.Type <> CType(cbeView.SelectedItem, SparklineViewType) Then
                sparklineEdit.Properties.View = SparklineViewBase.CreateView(CType(cbeView.SelectedItem, SparklineViewType))
            End If
			UpdateElements()
		End Sub
		' </cbeView>
		' <ceColor>
		Private Sub ceColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceColor.EditValueChanged
			sparklineEdit.Properties.View.Color = ceColor.Color
		End Sub
		' </ceColor>
		' <trbArea>
		Private Sub trbArea_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trbArea.EditValueChanged
			Dim areaView As AreaSparklineView = TryCast(sparklineEdit.Properties.View, AreaSparklineView)
			If areaView IsNot Nothing Then
				areaView.AreaOpacity = CByte(trbArea.Value)
			End If
		End Sub
		' </trbArea>
		' <ceStart>
		Private Sub ceStart_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceStart.EditValueChanged
			sparklineEdit.Properties.View.StartPointColor = ceStart.Color
		End Sub
		' </ceStart>
		' <ceMin>
		Private Sub ceMin_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMin.EditValueChanged
			sparklineEdit.Properties.View.MinPointColor = ceMin.Color
		End Sub
		' </ceMin>
		' <ceEnd>
		Private Sub ceEnd_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceEnd.EditValueChanged
			sparklineEdit.Properties.View.EndPointColor = ceEnd.Color
		End Sub
		' </ceEnd>
		' <ceMax>
		Private Sub ceMax_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMax.EditValueChanged
			sparklineEdit.Properties.View.MaxPointColor = ceMax.Color
		End Sub
		' </ceMax>
		' <ceNegative>
		Private Sub ceNegative_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceNegative.EditValueChanged
			sparklineEdit.Properties.View.NegativePointColor = ceNegative.Color
		End Sub
		' </ceNegative>
		' <ceMarkers>
		Private Sub ceMarkers_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMarkers.EditValueChanged
			If TypeOf sparklineEdit.Properties.View Is LineSparklineView Then
				CType(sparklineEdit.Properties.View, LineSparklineView).MarkerColor = ceMarkers.Color
			End If
		End Sub
		' </ceMarkers>
		' <cheHighlightStartPoint>
		Private Sub cheHighlightStartPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightStartPoint.CheckedChanged
			sparklineEdit.Properties.View.HighlightStartPoint = cheHighlightStartPoint.Checked
			ceStart.Enabled = cheHighlightStartPoint.Checked
		End Sub
		' </cheHighlightStartPoint>
		' <cheHighlightMinPoint>
		Private Sub cheHighlightMinPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightMinPoint.CheckedChanged
			sparklineEdit.Properties.View.HighlightMinPoint = cheHighlightMinPoint.Checked
			ceMin.Enabled = cheHighlightMinPoint.Checked
		End Sub
		' </cheHighlightMinPoint>
		' <cheHighlightEndPoint>
		Private Sub cheHighlightEndPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightEndPoint.CheckedChanged
			sparklineEdit.Properties.View.HighlightEndPoint = cheHighlightEndPoint.Checked
			ceEnd.Enabled = cheHighlightEndPoint.Checked
		End Sub
		' </cheHighlightEndPoint>
		' <cheHighlightMaxPoint>
		Private Sub cheHighlightMaxPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightMaxPoint.CheckedChanged
			sparklineEdit.Properties.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked
			ceMax.Enabled = cheHighlightMaxPoint.Checked
		End Sub
		' </cheHighlightMaxPoint>
		' <cheHighlightNegativePoints>
		Private Sub cheHighlightNegativePoints_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightNegativePoints.CheckedChanged
			If TypeOf sparklineEdit.Properties.View Is LineSparklineView Then
				CType(sparklineEdit.Properties.View, LineSparklineView).HighlightNegativePoints = cheHighlightNegativePoints.Checked
			ElseIf TypeOf sparklineEdit.Properties.View Is BarSparklineView Then
				CType(sparklineEdit.Properties.View, BarSparklineView).HighlightNegativePoints = cheHighlightNegativePoints.Checked
			End If
			ceNegative.Enabled = cheHighlightNegativePoints.Checked
		End Sub
		' </cheHighlightNegativePoints>
		' <cheShowMarkers>
		Private Sub cheShowMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheShowMarkers.CheckedChanged
			Dim lineView As LineSparklineView = TryCast(sparklineEdit.Properties.View, LineSparklineView)
			If lineView IsNot Nothing Then
				lineView.ShowMarkers = cheShowMarkers.Checked
			End If
			ceMarkers.Enabled = cheShowMarkers.Checked
		End Sub
		' </cheShowMarkers>
	End Class
End Namespace
