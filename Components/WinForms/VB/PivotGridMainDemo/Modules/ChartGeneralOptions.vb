Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ChartGeneralOptions
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
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

		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\ChartGeneralOptions.vb"
            TutorialInfo.WhatsThisXMLFile = "ChartGeneralOptions.xml"

			pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked
			pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked
			pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked
            chartControl.CrosshairOptions.ShowArgumentLine = False

            Dim restrictedTypes() As ViewType = { ViewType.PolarArea, ViewType.PolarLine, ViewType.ScatterPolarLine, ViewType.SideBySideGantt, ViewType.Bubble, ViewType.SideBySideRangeBar, ViewType.RangeBar, ViewType.Gantt, ViewType.PolarPoint, ViewType.PolarRangeArea, ViewType.Stock, ViewType.CandleStick, ViewType.SideBySideFullStackedBar, ViewType.SideBySideFullStackedBar3D, ViewType.SideBySideStackedBar, ViewType.SideBySideStackedBar3D }
			For Each type As ViewType In System.Enum.GetValues(GetType(ViewType))
				If Array.IndexOf(Of ViewType)(restrictedTypes, type) >= 0 Then
					Continue For
				End If
				comboChartType.Properties.Items.Add(type)
			Next type
			comboChartType.SelectedItem = ViewType.Bar
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			pivotGridControl.DataSource = GetNWindData("SalesPerson")
			SetFilter()
			SetSelection()
			chartControl.DataSource = pivotGridControl
		End Sub
		Private Sub SetFilter()
			fieldProductName.FilterValues.SetValues(New Object() { "Chai", "Chang", "Chocolade", "Filo Mix", "Geitost", "Ikura", "Konbu", "Maxilaku", "Pavlova", "Spegesild", "Tourtiere" }, PivotFilterType.Included, True)
            fieldOrderYear.FilterValues.SetValues(New Object() {1995}, PivotFilterType.Included, True)
		End Sub
		Private Sub SetSelection()
			pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() { "Chocolade" })
			pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() { "Chai" })
		End Sub

		'<comboChartType>
		Private Sub comboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboChartType.SelectedIndexChanged
			chartControl.SeriesTemplate.ChangeView(CType(comboChartType.SelectedItem, ViewType))
			If chartControl.SeriesTemplate.Label IsNot Nothing Then
				chartControl.SeriesTemplate.LabelsVisibility = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
				chartControl.CrosshairEnabled = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
				checkShowPointLabels.Enabled = True
			Else
				checkShowPointLabels.Enabled = False
			End If
			If (TryCast(chartControl.SeriesTemplate.View, SimpleDiagramSeriesViewBase)) Is Nothing Then
				chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
			End If
			If TypeOf chartControl.Diagram Is Diagram3D Then
				Dim diagram As Diagram3D = CType(chartControl.Diagram, Diagram3D)
				diagram.RuntimeRotation = True
				diagram.RuntimeZooming = True
				diagram.RuntimeScrolling = True
			End If
			For Each series As Series In chartControl.Series
				Dim supportTransparency As ISupportTransparency = TryCast(series.View, ISupportTransparency)
				If supportTransparency IsNot Nothing Then
					If (TypeOf series.View Is AreaSeriesView) OrElse (TypeOf series.View Is Area3DSeriesView) OrElse (TypeOf series.View Is RadarAreaSeriesView) OrElse (TypeOf series.View Is Bar3DSeriesView) Then
						supportTransparency.Transparency = 135
					Else
						supportTransparency.Transparency = 0
					End If
				End If
			Next series
		End Sub
		'</comboChartType>

		'<checkShowPointLabels>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkShowPointLabels.CheckedChanged
			chartControl.SeriesTemplate.LabelsVisibility = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
			chartControl.CrosshairEnabled = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
		End Sub
		'</checkShowPointLabels>

		'<ceChartDataVertical>
		Private Sub ceChartDataVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceChartDataVertical.CheckedChanged
			pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked
		End Sub
		'</ceChartDataVertical>
		'<ceSelectionOnly>
		Private Sub ceSelectionOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceSelectionOnly.CheckedChanged
			pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked
			seUpdateDelay.Enabled = ceSelectionOnly.Checked
			lblUpdateDelay.Enabled = seUpdateDelay.Enabled
		End Sub
		'</ceSelectionOnly>
		'<ceShowColumnGrandTotals>
		Private Sub ceShowColumnGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowColumnGrandTotals.CheckedChanged
			pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked
		End Sub
		'</ceShowColumnGrandTotals>

		'<ceShowRowGrandTotals>
		Private Sub ceShowRowGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowRowGrandTotals.CheckedChanged
			pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked
		End Sub
		'</ceShowRowGrandTotals>

		'<seUpdateDelay>
		Private Sub seUpdateDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seUpdateDelay.EditValueChanged
			pivotGridControl.OptionsChartDataSource.UpdateDelay = CInt(Fix(seUpdateDelay.Value))
		End Sub
		'</seUpdateDelay>
	End Class
End Namespace
