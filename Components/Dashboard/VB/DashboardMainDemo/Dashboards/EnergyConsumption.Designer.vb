Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class EnergyConsumption
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
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim uniformScale1 As New DevExpress.DashboardCommon.UniformScale()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField3 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField4 As New DevExpress.DashboardCommon.CalculatedField()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim calculatedField5 As New DevExpress.DashboardCommon.CalculatedField()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension7 As New DevExpress.DashboardCommon.Dimension()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardParameter1 As New DevExpress.DashboardCommon.DashboardParameter()
			Dim staticListLookUpSettings1 As New DevExpress.DashboardCommon.StaticListLookUpSettings()
			Me.mapProduction = New DevExpress.DashboardCommon.BubbleMapDashboardItem()
			Me.dsConsumptionTotal = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.pieConsumption = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.dsConsumptionBySector = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartConsumptionHistory = New DevExpress.DashboardCommon.ChartDashboardItem()
			CType(Me.mapProduction, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsConsumptionTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieConsumption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsConsumptionBySector, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartConsumptionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' mapProduction
			' 
			Me.mapProduction.Area = DevExpress.DashboardCommon.ShapefileArea.Europe
			measure1.DataMember = "YearShortage"
			measure1.Name = "Shortage (Color)"
			measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			Me.mapProduction.Color = measure1
			uniformScale1.LevelsCount = 5
			Me.mapProduction.ColorScale = uniformScale1
			Me.mapProduction.ComponentName = "mapProduction"
			measure2.DataMember = "YearConsumption"
			measure2.Name = "Consumption"
			measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			dimension1.DataMember = "Country"
			measure3.DataMember = "YearProduction"
			measure3.Name = "Production (Size)"
			measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			dimension2.DataMember = "Latitude"
			dimension3.DataMember = "Longitude"
			Me.mapProduction.DataItemRepository.Clear()
			Me.mapProduction.DataItemRepository.Add(measure2, "DataItem5")
			Me.mapProduction.DataItemRepository.Add(dimension1, "DataItem4")
			Me.mapProduction.DataItemRepository.Add(measure1, "DataItem3")
			Me.mapProduction.DataItemRepository.Add(measure3, "DataItem2")
			Me.mapProduction.DataItemRepository.Add(dimension2, "DataItem0")
			Me.mapProduction.DataItemRepository.Add(dimension3, "DataItem1")
			Me.mapProduction.DataSource = Me.dsConsumptionTotal
			Me.mapProduction.InteractivityOptions.IgnoreMasterFilters = False
			Me.mapProduction.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.mapProduction.IsMasterFilterCrossDataSource = True
			Me.mapProduction.Latitude = dimension2
			Me.mapProduction.Legend.Orientation = DevExpress.DashboardCommon.MapLegendOrientation.Horizontal
			Me.mapProduction.Legend.Position = DevExpress.DashboardCommon.MapLegendPosition.BottomRight
			Me.mapProduction.Legend.Visible = True
			Me.mapProduction.Longitude = dimension3
			Me.mapProduction.Name = "Energy Production vs Shortage"
			Me.mapProduction.ShapeTitleAttributeName = "NAME"
			Me.mapProduction.ShowCaption = True
			Me.mapProduction.TooltipDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.mapProduction.TooltipMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
			Me.mapProduction.Viewport.BottomLatitude = 27.646386718750023R
			Me.mapProduction.Viewport.CenterPointLatitude = 54.855558031681227R
			Me.mapProduction.Viewport.CenterPointLongitude = 17.541333007812533R
			Me.mapProduction.Viewport.LeftLongitude = -31.282958984375R
			Me.mapProduction.Viewport.RightLongitude = 66.365625000000051R
			Me.mapProduction.Viewport.TopLatitude = 71.177685546874955R
			Me.mapProduction.Weight = measure3
			Me.mapProduction.WeightedLegend.Position = DevExpress.DashboardCommon.MapLegendPosition.BottomLeft
			Me.mapProduction.WeightedLegend.Type = DevExpress.DashboardCommon.WeightedLegendType.Nested
			Me.mapProduction.WeightedLegend.Visible = True
			' 
			' dsConsumptionTotal
			' 
			calculatedField1.Expression = "ToDecimal([Consumption] - [Production])"
			calculatedField1.Name = "Shortage"
			calculatedField2.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Production], 0.0))"
			calculatedField2.Name = "YearProduction"
			calculatedField3.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Shortage], 0.0))"
			calculatedField3.Name = "YearShortage"
			calculatedField4.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Consumption], 0.0))"
			calculatedField4.Name = "YearConsumption"
			Me.dsConsumptionTotal.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2, calculatedField3, calculatedField4})
			Me.dsConsumptionTotal.ComponentName = "dsConsumptionTotal"
			Me.dsConsumptionTotal.DataSchema = ""
			Me.dsConsumptionTotal.DataSource = GetType(DashboardMainDemo.EnergyConsumptionTotalDataRow)
			Me.dsConsumptionTotal.Name = "Energy Consumption Total"
			' 
			' pieConsumption
			' 
			dimension4.DataMember = "Sector"
			Me.pieConsumption.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.pieConsumption.ComponentName = "pieConsumption"
			dimension5.DataMember = "Country"
			measure4.DataMember = "YearConsumption"
			measure4.Name = "YearConsumption (Sum)"
			measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			Me.pieConsumption.DataItemRepository.Clear()
			Me.pieConsumption.DataItemRepository.Add(dimension5, "DataItem3")
			Me.pieConsumption.DataItemRepository.Add(dimension4, "DataItem2")
			Me.pieConsumption.DataItemRepository.Add(measure4, "DataItem0")
			Me.pieConsumption.DataSource = Me.dsConsumptionBySector
			Me.pieConsumption.FilterString = ""
			Me.pieConsumption.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieConsumption.Name = "Energy Consumption by Sector"
			Me.pieConsumption.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.pieConsumption.ShowCaption = True
			Me.pieConsumption.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure4})
			' 
			' dsConsumptionBySector
			' 
			calculatedField5.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Consumption], 0.0))"
			calculatedField5.Name = "YearConsumption"
			Me.dsConsumptionBySector.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField5})
			Me.dsConsumptionBySector.ComponentName = "dsConsumptionBySector"
			Me.dsConsumptionBySector.DataSchema = ""
			Me.dsConsumptionBySector.DataSource = GetType(DashboardMainDemo.EnergyConsumptionBySectorDataRow)
			Me.dsConsumptionBySector.Name = "Energy Consumption by Sector"
			' 
			' chartConsumptionHistory
			' 
			dimension6.DataMember = "Year"
			Me.chartConsumptionHistory.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension6})
			Me.chartConsumptionHistory.AxisX.TitleVisible = False
			Me.chartConsumptionHistory.ComponentName = "chartConsumptionHistory"
			dimension7.DataMember = "Sector"
			measure5.DataMember = "Consumption"
			measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			Me.chartConsumptionHistory.DataItemRepository.Clear()
			Me.chartConsumptionHistory.DataItemRepository.Add(dimension7, "DataItem2")
			Me.chartConsumptionHistory.DataItemRepository.Add(dimension6, "DataItem1")
			Me.chartConsumptionHistory.DataItemRepository.Add(measure5, "DataItem0")
			Me.chartConsumptionHistory.DataSource = Me.dsConsumptionBySector
			Me.chartConsumptionHistory.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartConsumptionHistory.Legend.Visible = False
			Me.chartConsumptionHistory.Name = "Energy Consumption History by Sector"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StepLine
			simpleSeries1.AddDataItem("Value", measure5)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartConsumptionHistory.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartConsumptionHistory.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension7})
			Me.chartConsumptionHistory.ShowCaption = False
			' 
			' EnergyConsumption
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsConsumptionTotal, Me.dsConsumptionBySector})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartConsumptionHistory, Me.pieConsumption, Me.mapProduction})
			dashboardLayoutItem1.DashboardItem = Me.mapProduction
			dashboardLayoutItem1.Weight = 59.982253771073644R
			dashboardLayoutItem2.DashboardItem = Me.pieConsumption
			dashboardLayoutItem2.Weight = 52.038834951456309R
			dashboardLayoutItem3.DashboardItem = Me.chartConsumptionHistory
			dashboardLayoutItem3.Weight = 47.961165048543691R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem2, dashboardLayoutItem3})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 40.017746228926356R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutGroup2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			staticListLookUpSettings1.Values = New String() { "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009"}
			dashboardParameter1.LookUpSettings = staticListLookUpSettings1
			dashboardParameter1.Name = "Year"
			dashboardParameter1.Type = GetType(Integer)
			dashboardParameter1.Value = 2009
			Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() { dashboardParameter1})
			Me.Title.Text = "Energy Consumption"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.EnergyConsumption_DataLoading);
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapProduction, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsConsumptionTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieConsumption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsConsumptionBySector, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartConsumptionHistory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private chartConsumptionHistory As DevExpress.DashboardCommon.ChartDashboardItem
		Private pieConsumption As DevExpress.DashboardCommon.PieDashboardItem
		Private mapProduction As DevExpress.DashboardCommon.BubbleMapDashboardItem
		Private dsConsumptionTotal As DevExpress.DashboardCommon.DashboardObjectDataSource
		Private dsConsumptionBySector As DevExpress.DashboardCommon.DashboardObjectDataSource


	End Class
End Namespace
