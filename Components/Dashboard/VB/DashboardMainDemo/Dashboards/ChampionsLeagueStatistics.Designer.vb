Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class ChampionsLeagueStatistics
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim chartPane2 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim chartPane3 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries3 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim pivotItemFormatRule1 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionBar1 As New DevExpress.DashboardCommon.FormatConditionBar()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.scatterChartLeagueStatistics = New DevExpress.DashboardCommon.ScatterChartDashboardItem()
			Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.groupCountryStatistics = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.chartStatisticsBySeason = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.comboBoxCountries = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
			Me.groupGoalDifference = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.pivotGoalDifference = New DevExpress.DashboardCommon.PivotDashboardItem()
			CType(Me.scatterChartLeagueStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupCountryStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartStatisticsBySeason, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxCountries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupGoalDifference, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGoalDifference, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' scatterChartLeagueStatistics
			' 
			dimension1.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
			dimension1.DataMember = "Country"
			dimension2.DataMember = "Club"
			Me.scatterChartLeagueStatistics.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1, dimension2})
			Me.scatterChartLeagueStatistics.AxisX.AlwaysShowZeroLevel = False
			Me.scatterChartLeagueStatistics.AxisX.LogarithmicBase = DevExpress.DashboardCommon.LogarithmicBase.Base5
			Me.scatterChartLeagueStatistics.AxisX.ShowGridLines = True
			Me.scatterChartLeagueStatistics.AxisX.TitleVisible = True
			measure1.DataMember = "Goals_for"
			measure1.Name = "Goals For"
			Me.scatterChartLeagueStatistics.AxisXMeasure = measure1
			Me.scatterChartLeagueStatistics.AxisY.AlwaysShowZeroLevel = False
			Me.scatterChartLeagueStatistics.AxisY.ShowGridLines = True
			Me.scatterChartLeagueStatistics.AxisY.TitleVisible = True
			measure2.DataMember = "Goals_against"
			measure2.Name = "Goals Against"
			Me.scatterChartLeagueStatistics.AxisYMeasure = measure2
			Me.scatterChartLeagueStatistics.ComponentName = "scatterChartLeagueStatistics"
			measure3.DataMember = "Points"
			measure3.Name = "Points"
			Me.scatterChartLeagueStatistics.DataItemRepository.Clear()
			Me.scatterChartLeagueStatistics.DataItemRepository.Add(measure1, "DataItem0")
			Me.scatterChartLeagueStatistics.DataItemRepository.Add(measure2, "DataItem1")
			Me.scatterChartLeagueStatistics.DataItemRepository.Add(measure3, "DataItem2")
			Me.scatterChartLeagueStatistics.DataItemRepository.Add(dimension1, "DataItem3")
			Me.scatterChartLeagueStatistics.DataItemRepository.Add(dimension2, "DataItem4")
			Me.scatterChartLeagueStatistics.DataSource = Me.dashboardObjectDataSource1
			Me.scatterChartLeagueStatistics.Group = Me.groupCountryStatistics
			Me.scatterChartLeagueStatistics.InteractivityOptions.IgnoreMasterFilters = False
			Me.scatterChartLeagueStatistics.InteractivityOptions.IsDrillDownEnabled = True
			Me.scatterChartLeagueStatistics.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.scatterChartLeagueStatistics.Legend.Visible = False
			Me.scatterChartLeagueStatistics.Name = "League Statistics by Country/Club"
			Me.scatterChartLeagueStatistics.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside
			Me.scatterChartLeagueStatistics.PointLabelOptions.ShowPointLabels = True
			Me.scatterChartLeagueStatistics.ShowCaption = False
			Me.scatterChartLeagueStatistics.Weight = measure3
			' 
			' dashboardObjectDataSource1
			' 
			calculatedField1.Expression = "ToInt([Goals_for] - [Goals_against])"
			calculatedField1.Name = "Goals difference"
			calculatedField2.Expression = "ToInt(3 * [Won] + [Drawn])"
			calculatedField2.Name = "Points"
			Me.dashboardObjectDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2})
			Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
			Me.dashboardObjectDataSource1.DataSchema = ""
			Me.dashboardObjectDataSource1.DataSource = GetType(DashboardMainDemo.ChampionsLeagueStatisticsDataRow)
			Me.dashboardObjectDataSource1.Name = "Data"
			' 
			' groupCountryStatistics
			' 
			Me.groupCountryStatistics.ComponentName = "groupCountryStatistics"
			Me.groupCountryStatistics.InteractivityOptions.IgnoreMasterFilters = True
			Me.groupCountryStatistics.InteractivityOptions.IsMasterFilter = True
			Me.groupCountryStatistics.Name = "Country/Club Statistics"
			Me.groupCountryStatistics.ShowCaption = True
			' 
			' chartStatisticsBySeason
			' 
			dimension3.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
			dimension3.DataMember = "Season"
			Me.chartStatisticsBySeason.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.chartStatisticsBySeason.AxisX.TitleVisible = True
			Me.chartStatisticsBySeason.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None
			Me.chartStatisticsBySeason.ColoringOptions.UseGlobalColors = False
			Me.chartStatisticsBySeason.ComponentName = "chartStatisticsBySeason"
			measure4.DataMember = "Goals_for"
			measure4.Name = "Goals For"
			measure5.DataMember = "Goals_against"
			measure5.Name = "Goals Against"
			measure6.DataMember = "Points"
			measure6.Name = "Points"
			Me.chartStatisticsBySeason.DataItemRepository.Clear()
			Me.chartStatisticsBySeason.DataItemRepository.Add(dimension3, "DataItem0")
			Me.chartStatisticsBySeason.DataItemRepository.Add(measure4, "DataItem3")
			Me.chartStatisticsBySeason.DataItemRepository.Add(measure5, "DataItem4")
			Me.chartStatisticsBySeason.DataItemRepository.Add(measure6, "DataItem2")
			Me.chartStatisticsBySeason.DataSource = Me.dashboardObjectDataSource1
			Me.chartStatisticsBySeason.Group = Me.groupCountryStatistics
			Me.chartStatisticsBySeason.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartStatisticsBySeason.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.chartStatisticsBySeason.Legend.Visible = False
			Me.chartStatisticsBySeason.Name = "Country/Club Statistics by Season"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside
			simpleSeries1.PointLabelOptions.ShowPointLabels = True
			simpleSeries1.AddDataItem("Value", measure6)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			chartPane2.Name = "Pane 2"
			chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.PrimaryAxisY.ShowGridLines = True
			chartPane2.PrimaryAxisY.TitleVisible = True
			chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.SecondaryAxisY.ShowGridLines = False
			chartPane2.SecondaryAxisY.TitleVisible = True
			simpleSeries2.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside
			simpleSeries2.PointLabelOptions.ShowPointLabels = True
			simpleSeries2.AddDataItem("Value", measure4)
			chartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries2})
			chartPane3.Name = "Pane 3"
			chartPane3.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane3.PrimaryAxisY.ShowGridLines = True
			chartPane3.PrimaryAxisY.TitleVisible = True
			chartPane3.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane3.SecondaryAxisY.ShowGridLines = False
			chartPane3.SecondaryAxisY.TitleVisible = True
			simpleSeries3.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside
			simpleSeries3.PointLabelOptions.ShowPointLabels = True
			simpleSeries3.AddDataItem("Value", measure5)
			chartPane3.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries3})
			Me.chartStatisticsBySeason.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1, chartPane2, chartPane3})
			Me.chartStatisticsBySeason.Rotated = True
			Me.chartStatisticsBySeason.ShowCaption = False
			' 
			' comboBoxCountries
			' 
			Me.comboBoxCountries.ComboBoxType = DevExpress.DashboardCommon.ComboBoxDashboardItemType.Checked
			Me.comboBoxCountries.ComponentName = "comboBoxCountries"
			dimension4.DataMember = "Country"
			Me.comboBoxCountries.DataItemRepository.Clear()
			Me.comboBoxCountries.DataItemRepository.Add(dimension4, "DataItem0")
			Me.comboBoxCountries.DataSource = Me.dashboardObjectDataSource1
			Me.comboBoxCountries.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.comboBoxCountries.Group = Me.groupGoalDifference
			Me.comboBoxCountries.InteractivityOptions.IgnoreMasterFilters = True
			Me.comboBoxCountries.Name = "Countries"
			Me.comboBoxCountries.ShowCaption = False
			' 
			' groupGoalDifference
			' 
			Me.groupGoalDifference.ComponentName = "groupGoalDifference"
			Me.groupGoalDifference.InteractivityOptions.IgnoreMasterFilters = True
			Me.groupGoalDifference.Name = "Goal Difference"
			Me.groupGoalDifference.ShowCaption = True
			' 
			' pivotGoalDifference
			' 
			dimension5.DataMember = "Season"
			Me.pivotGoalDifference.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.pivotGoalDifference.ComponentName = "pivotGoalDifference"
			measure7.DataMember = "Goals difference"
			measure7.Name = "Goals Difference"
			dimension6.DataMember = "Club"
			dimension6.SortByMeasure = measure7
			dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
			Me.pivotGoalDifference.DataItemRepository.Clear()
			Me.pivotGoalDifference.DataItemRepository.Add(measure7, "DataItem0")
			Me.pivotGoalDifference.DataItemRepository.Add(dimension5, "DataItem2")
			Me.pivotGoalDifference.DataItemRepository.Add(dimension6, "DataItem3")
			Me.pivotGoalDifference.DataSource = Me.dashboardObjectDataSource1
			formatConditionBar1.NegativeStyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Red
			formatConditionBar1.StyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Green
			pivotItemFormatRule1.Condition = formatConditionBar1
			pivotItemFormatRule1.DataItem = measure7
			pivotItemFormatRule1.Name = "FormatRule 5"
			Me.pivotGoalDifference.FormatRules.AddRange(New DevExpress.DashboardCommon.PivotItemFormatRule() { pivotItemFormatRule1})
			Me.pivotGoalDifference.Group = Me.groupGoalDifference
			Me.pivotGoalDifference.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotGoalDifference.Name = "Goal Difference by Club"
			Me.pivotGoalDifference.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension6})
			Me.pivotGoalDifference.ShowCaption = False
			Me.pivotGoalDifference.ShowColumnGrandTotals = False
			Me.pivotGoalDifference.ShowColumnTotals = False
			Me.pivotGoalDifference.ShowRowGrandTotals = False
			Me.pivotGoalDifference.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure7})
			' 
			' ChampionsLeagueStatistics
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
			Me.Groups.AddRange(New DevExpress.DashboardCommon.DashboardItemGroup() { Me.groupGoalDifference, Me.groupCountryStatistics})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.scatterChartLeagueStatistics, Me.pivotGoalDifference, Me.comboBoxCountries, Me.chartStatisticsBySeason})
			dashboardLayoutItem1.DashboardItem = Me.scatterChartLeagueStatistics
			dashboardLayoutItem1.Weight = 68.123393316195376R
			dashboardLayoutItem2.DashboardItem = Me.chartStatisticsBySeason
			dashboardLayoutItem2.Weight = 31.876606683804628R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Me.groupCountryStatistics
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 56.919468334636434R
			dashboardLayoutItem3.DashboardItem = Me.comboBoxCountries
			dashboardLayoutItem3.Weight = 4.1131105398457581R
			dashboardLayoutItem4.DashboardItem = Me.pivotGoalDifference
			dashboardLayoutItem4.Weight = 95.886889460154237R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup3.DashboardItem = Me.groupGoalDifference
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 43.080531665363566R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Champions League Statistics"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.ChampionsLeagueStatistics_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scatterChartLeagueStatistics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupCountryStatistics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartStatisticsBySeason, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxCountries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupGoalDifference, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGoalDifference, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private scatterChartLeagueStatistics As DevExpress.DashboardCommon.ScatterChartDashboardItem
		Private groupCountryStatistics As DevExpress.DashboardCommon.DashboardItemGroup
		Private pivotGoalDifference As DevExpress.DashboardCommon.PivotDashboardItem
		Private groupGoalDifference As DevExpress.DashboardCommon.DashboardItemGroup
		Private comboBoxCountries As DevExpress.DashboardCommon.ComboBoxDashboardItem
		Private chartStatisticsBySeason As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource







	End Class
End Namespace
