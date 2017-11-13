Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class DrillDownDemo
		Inherits ChartDemoBase2D
		Private ReadOnly summaryColumnName() As String = { "MinPrice", "MaxPrice", "AvgPrice" }

		Private ReadOnly Property CategoriesSeries() As Series
			Get
				Return chart.GetSeriesByName("Categories")
			End Get
		End Property
		Private ReadOnly Property ProductsSeries() As Series
			Get
				Return chart.GetSeriesByName("Products")
			End Get
		End Property
		Private ReadOnly Property IsCategoriesChart() As Boolean
			Get
				Return If(CategoriesSeries IsNot Nothing, CategoriesSeries.Visible, False)
			End Get
		End Property

		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return IsCategoriesChart
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitProductsChart(ByVal point As SeriesPoint)
			If CategoriesSeries IsNot Nothing AndAlso ProductsSeries IsNot Nothing Then
				CategoriesSeries.Visible = False
				ProductsSeries.DataFilters(0).Value = CInt(Fix((CType(point.Tag, DataRowView))("CategoryId")))
				ProductsSeries.LegendText = point.Argument
				Dim view As XYDiagramSeriesViewBase = TryCast(ProductsSeries.View, XYDiagramSeriesViewBase)
				If view IsNot Nothing Then
					Dim axisX As AxisXBase = view.AxisX
					axisX.Label.Angle = 30
					Dim axisY As AxisYBase = view.AxisY
					axisY.Title.Text = "Price, USD"
					axisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
					chart.ToolTipOptions.ShowForPoints = True
					chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
					chart.Legend.AlignmentVertical = LegendAlignmentVertical.Top
					chart.Legend.Margins.All = 10
					If chart.Titles.Count > 1 Then
						chart.Titles(0).Visibility = DevExpress.Utils.DefaultBoolean.False
						chart.Titles(1).Visibility = DevExpress.Utils.DefaultBoolean.True
					End If
				End If
			End If
			ChartControl.Animate()
		End Sub
		Private Sub InitCategoriesChart()
			If CategoriesSeries IsNot Nothing Then
				CategoriesSeries.Visible = True
				chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
				chart.Legend.AlignmentVertical = LegendAlignmentVertical.Center
				chart.Legend.Margins.All = 5
				chart.ToolTipOptions.ShowForPoints = False
				If chart.Titles.Count > 1 Then
					chart.Titles(0).Visibility = DevExpress.Utils.DefaultBoolean.True
					chart.Titles(1).Visibility = DevExpress.Utils.DefaultBoolean.False
				End If
			End If
			ChartControl.Animate()
		End Sub
		Private Sub comboBoxSummary_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxSummary.SelectedIndexChanged
			If CategoriesSeries IsNot Nothing Then
				CategoriesSeries.ValueDataMembers(0) = summaryColumnName(comboBoxSummary.SelectedIndex)
				If chart.Titles.Count > 0 Then
					chart.Titles(0).Text = comboBoxSummary.SelectedItem.ToString() & " Product Prices by Categories"
				End If
			End If
			ChartControl.Animate()
		End Sub

		Protected Overrides Function AllowSelectAnotherObject(ByVal obj As Object) As Boolean
			Return (Not IsCategoriesChart) AndAlso (TypeOf obj Is ChartTitle)
		End Function
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			ProductsSeries.CrosshairLabelPattern = "Product: {A}" & Constants.vbLf & "Price:     ${V:0.00}"
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
			Dim path As String = Utils.GetRelativePath("nwind.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(Me.oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Try
				Me.oleDbDataAdapterCategories.Fill(Me.dS31)
				Me.oleDbDataAdapterProducts.Fill(Me.dS31)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
			comboBoxSummary.SelectedIndex = 0
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If IsCategoriesChart Then
				If seriesSelected IsNot Nothing AndAlso pointSelected IsNot Nothing Then
					InitProductsChart(Me.pointSelected)
					comboBoxSummary.Enabled = False
					seriesSelected = Nothing
				End If
			Else
				If TypeOf selectedAnotherObject Is ChartTitle Then
					InitCategoriesChart()
					comboBoxSummary.Enabled = True
					selectedAnotherObject = Nothing
				End If
			End If
		End Sub
	End Class
End Namespace
