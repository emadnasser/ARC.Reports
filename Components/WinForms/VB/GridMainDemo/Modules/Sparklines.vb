Imports DevExpress.Sparkline
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class Sparklines
		Inherits TutorialControl

		Private Const januaryIndex As Integer = 3
		Private Const decemberIndex As Integer = 14
        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridControl.MainView
            End Get
        End Property
		Public Sub New()
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\Sparklines.vb"
            TutorialInfo.WhatsThisXMLFile = "Sparklines.xml"
			gridControl.ForceInitialize()
			cheHighlightMaxPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
			cheHighlightMinPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
			cheHighlightStartPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
			cheHighlightEndPoint.Checked = repositoryItemSparklineEdit1.View.HighlightMaxPoint
			UpdateColors()
			UpdateMaxColorEnabled()
			UpdateMinColorEnabled()
			UpdateStartColorEnabled()
			UpdateEndColorEnabled()
			InitCustomersPaymentData(dsContacts1)
			InitializeViewCombobox()
		End Sub
		Private Sub InitializeViewCombobox()
			For Each view As SparklineViewType In System.Enum.GetValues(GetType(SparklineViewType))
				cbeView.Properties.Items.Add(view)
			Next view
			cbeView.SelectedItem = repositoryItemSparklineEdit1.View.Type
		End Sub
		Private Sub Sparklines_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gridControl.ForceInitialize()
			gridView.ExpandAllGroups()
		End Sub
		'<cbeView>
		Private Sub cbeView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeView.SelectedIndexChanged
            If repositoryItemSparklineEdit1.View.Type <> CType(cbeView.SelectedItem, SparklineViewType) Then
                repositoryItemSparklineEdit1.View = SparklineViewBase.CreateView(CType(cbeView.SelectedItem, SparklineViewType))
            End If
		End Sub
		'</cbeView>
		'<cheHighlightMaxPoint>
		Private Sub cheHighlightMaxPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightMaxPoint.CheckedChanged
			repositoryItemSparklineEdit1.View.HighlightMaxPoint = cheHighlightMaxPoint.Checked
			UpdateMaxColorEnabled()
		End Sub
		'</cheHighlightMaxPoint>
		'<cheHighlightMinPoint>
		Private Sub cheHighlightMinPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightMinPoint.CheckedChanged
			repositoryItemSparklineEdit1.View.HighlightMinPoint = cheHighlightMinPoint.Checked
			UpdateMinColorEnabled()
		End Sub
		'</cheHighlightMinPoint>
		'<cheHighlightStartPoint>
		Private Sub cheHighlightStartPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightStartPoint.CheckedChanged
			repositoryItemSparklineEdit1.View.HighlightStartPoint = cheHighlightStartPoint.Checked
			UpdateStartColorEnabled()
		End Sub
		'</cheHighlightStartPoint>
		'<cheHighlightEndPoint>
		Private Sub cheHighlightEndPoint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheHighlightEndPoint.CheckedChanged
			repositoryItemSparklineEdit1.View.HighlightEndPoint = cheHighlightEndPoint.Checked
			UpdateEndColorEnabled()
		End Sub
		'</cheHighlightEndPoint>
		Private Sub UpdateMaxColorEnabled()
			ceMax.Enabled = cheHighlightMaxPoint.Checked
		End Sub
		Private Sub UpdateMinColorEnabled()
			ceMin.Enabled = cheHighlightMinPoint.Checked
		End Sub
		Private Sub UpdateStartColorEnabled()
			ceStart.Enabled = cheHighlightStartPoint.Checked
		End Sub
		Private Sub UpdateEndColorEnabled()
			ceEnd.Enabled = cheHighlightEndPoint.Checked
		End Sub
		'<ceStart>
		Private Sub ceStart_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceStart.EditValueChanged
			repositoryItemSparklineEdit1.View.StartPointColor = ceStart.Color
		End Sub
		'</ceStart>
		'<ceMin>
		Private Sub ceMin_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMin.EditValueChanged
			repositoryItemSparklineEdit1.View.MinPointColor = ceMin.Color
		End Sub
		'</ceMin>
		'<ceEnd>
		Private Sub ceEnd_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceEnd.EditValueChanged
			repositoryItemSparklineEdit1.View.EndPointColor = ceEnd.Color
		End Sub
		'</ceEnd>
		'<ceMax>
		Private Sub ceMax_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceMax.EditValueChanged
			repositoryItemSparklineEdit1.View.MaxPointColor = ceMax.Color
		End Sub
		'</ceMax>
		'<ceColor>
		Private Sub ceColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceColor.EditValueChanged
			repositoryItemSparklineEdit1.View.Color = ceColor.Color
		End Sub
		'</ceColor>
		Private Sub UpdateColors()
			ceMax.Color = repositoryItemSparklineEdit1.View.ActualMaxPointColor
			ceMin.Color = repositoryItemSparklineEdit1.View.ActualMinPointColor
			ceStart.Color = repositoryItemSparklineEdit1.View.ActualStartPointColor
			ceEnd.Color = repositoryItemSparklineEdit1.View.ActualEndPointColor
			ceColor.Color = repositoryItemSparklineEdit1.View.ActualColor
		End Sub
		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			UpdateColors()
		End Sub
		'<gridControl>
		Private Sub gridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles gridView.CustomUnboundColumnData
			If e.IsGetData Then
				Dim values As New List(Of Double)()
				Dim row_Renamed As DataRowView = CType(e.Row, DataRowView)
				For i As Integer = januaryIndex To decemberIndex
					values.Add(CDbl(row_Renamed.Row.ItemArray(i)))
				Next i
				e.Value = values
			End If
		End Sub
		'</gridControl>
    End Class
End Namespace
