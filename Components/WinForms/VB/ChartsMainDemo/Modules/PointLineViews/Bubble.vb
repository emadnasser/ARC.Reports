Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class BubbleDemo
		Inherits ChartDemoBase2D
		Private Shared ReadOnly transparencies() As String = { "0", "45", "90", "135", "180", "225", "255" }

		Private itemCollection As MarkerKindItemCollection

		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property
		Protected Overrides ReadOnly Property ToolTipEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.True
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Private ReadOnly Property BubbleSeries() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property BubbleSeriesView() As BubbleSeriesView
			Get
				Return TryCast((If(BubbleSeries IsNot Nothing, BubbleSeries.View, Nothing)), BubbleSeriesView)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub cbeMarkerKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeMarkerKind.SelectedIndexChanged
			If cbeMarkerKind.SelectedIndex >= 0 AndAlso BubbleSeriesView IsNot Nothing Then
				Dim item As MarkerKindItem = TryCast(cbeMarkerKind.SelectedItem, MarkerKindItem)
				If item IsNot Nothing Then
					BubbleSeriesView.BubbleMarkerOptions.Kind = item.MarkerKind
					If item.MarkerKind.Equals(MarkerKind.Star) Then
						BubbleSeriesView.BubbleMarkerOptions.StarPointCount = (CType(item, StarMarkerKindItem)).PointCount
					End If
				End If
				ChartControl.Animate()
			End If
		End Sub
		Private Sub cbeLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeLabelPosition.SelectedIndexChanged
			If cbeLabelPosition.SelectedIndex >= 0 AndAlso BubbleSeries IsNot Nothing Then
				Dim label As BubbleSeriesLabel = TryCast(BubbleSeries.Label, BubbleSeriesLabel)
				If label IsNot Nothing Then
					label.Position = CType(cbeLabelPosition.SelectedIndex, PointLabelPosition)
				End If
			End If
		End Sub
		Private Sub speMaxSize_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles speMaxSize.EditValueChanging
			If BubbleSeriesView IsNot Nothing Then
				If Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) <= BubbleSeriesView.MinSize Then
					e.Cancel = True
				End If
			End If
		End Sub
		Private Sub speMaxSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles speMaxSize.EditValueChanged
			If BubbleSeriesView IsNot Nothing Then
				BubbleSeriesView.MaxSize = Convert.ToDouble(speMaxSize.EditValue)
			End If
		End Sub
		Private Sub speMinSize_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles speMinSize.EditValueChanging
			If BubbleSeriesView IsNot Nothing Then
				If Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) >= BubbleSeriesView.MaxSize Then
					e.Cancel = True
				End If
			End If
		End Sub
		Private Sub speMinSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles speMinSize.EditValueChanged
			If BubbleSeriesView IsNot Nothing Then
				BubbleSeriesView.MinSize = Convert.ToDouble(speMinSize.EditValue)
			End If
		End Sub
		Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chart.CustomDrawSeriesPoint
			e.LegendText = (CType(e.SeriesPoint.Tag, BubbleDataItem)).Title
		End Sub
		Private Sub cbeTransparency_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeTransparency.SelectedIndexChanged
			If BubbleSeriesView IsNot Nothing Then
				BubbleSeriesView.Transparency = Convert.ToByte(cbeTransparency.Text)
			End If
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			itemCollection = MarkerKindItemCollection.CreateCollection()
			Dim items(itemCollection.Count - 1) As MarkerKindItem
			itemCollection.CopyTo(items)
			cbeMarkerKind.Properties.Items.AddRange(items)
			cbeMarkerKind.SelectedIndex = CInt(Fix(BubbleSeriesView.BubbleMarkerOptions.Kind))
			cbeLabelPosition.SelectedIndex = CInt(Fix((CType(BubbleSeries.Label, BubbleSeriesLabel)).Position))
			speMaxSize.EditValue = BubbleSeriesView.MaxSize
			speMinSize.EditValue = BubbleSeriesView.MinSize
			cbeTransparency.Properties.Items.AddRange(transparencies)
			cbeTransparency.SelectedIndex = 2
			ShowLabels = BubbleSeries.LabelsVisibility = DefaultBoolean.True
			ChartControl.CrosshairEnabled = DefaultBoolean.False
			ChartControl.ToolTipEnabled = DefaultBoolean.True
			BubbleSeries.ToolTipPointPattern = "Production budget: ${V}M" & Constants.vbLf & "Worldwide grosses: ${W}B"
			BubbleSeries.DataSource = BubbleData.GetData()
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If BubbleSeries IsNot Nothing Then
				lblLabelPosition.Enabled = ShowLabels
				cbeLabelPosition.Enabled = lblLabelPosition.Enabled
				Dim label As BubbleSeriesLabel = TryCast(BubbleSeries.Label, BubbleSeriesLabel)
				If label IsNot Nothing Then
					cbeLabelPosition.SelectedIndex = CInt(Fix(label.Position))
				End If
				If BubbleSeriesView IsNot Nothing Then
					speMaxSize.EditValue = BubbleSeriesView.MaxSize
					speMinSize.EditValue = BubbleSeriesView.MinSize
				End If
			End If
		End Sub
	End Class
End Namespace
