Imports Microsoft.VisualBasic
Imports System
Imports DashboardMainDemo
Imports DevExpress.DashboardCommon

''' <summary>
''' Summary description
''' </summary>
Public Class EnergyStatisticsDashboard
	Inherits Dashboard
	Private gridProductionImportByCountry As GridDashboardItem
	Private dsCountries As DashboardObjectDataSource
	Private mapProduction As PieMapDashboardItem
	Private cardProductionImportByType As CardDashboardItem
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Dim resources As System.Resources.ResourceManager = Global.Resources.EnergyStatisticsDashboard.ResourceManager
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField3 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField4 As New DevExpress.DashboardCommon.CalculatedField()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim gridSparklineColumn1 As New DevExpress.DashboardCommon.GridSparklineColumn()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim gridItemFormatRule1 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionValue1 As New DevExpress.DashboardCommon.FormatConditionValue()
			Dim appearanceSettings1 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim gridItemFormatRule2 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionValue2 As New DevExpress.DashboardCommon.FormatConditionValue()
			Dim appearanceSettings2 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim gridItemFormatRule3 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionValue3 As New DevExpress.DashboardCommon.FormatConditionValue()
			Dim appearanceSettings3 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim dimension7 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardParameter1 As New DevExpress.DashboardCommon.DashboardParameter()
			Dim staticListLookUpSettings1 As New DevExpress.DashboardCommon.StaticListLookUpSettings()
			Me.mapProduction = New DevExpress.DashboardCommon.PieMapDashboardItem()
			Me.dsCountries = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.gridProductionImportByCountry = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.cardProductionImportByType = New DevExpress.DashboardCommon.CardDashboardItem()
			CType(Me.mapProduction, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsCountries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridProductionImportByCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardProductionImportByType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' mapProduction
			' 
			Me.mapProduction.Area = DevExpress.DashboardCommon.ShapefileArea.Europe
			dimension1.DataMember = "EnergyType"
			Me.mapProduction.Argument = dimension1
			Me.mapProduction.ComponentName = "mapProduction"
			dimension2.DataMember = "Latitude"
			dimension3.DataMember = "Longitude"
			measure1.DataMember = "YearProduction"
			measure1.Name = "Production"
			measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			measure2.DataMember = "YearImport"
			measure2.Name = "Import"
			measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			dimension4.DataMember = "Country"
			Me.mapProduction.DataItemRepository.Clear()
			Me.mapProduction.DataItemRepository.Add(dimension2, "DataItem0")
			Me.mapProduction.DataItemRepository.Add(dimension3, "DataItem1")
			Me.mapProduction.DataItemRepository.Add(measure1, "DataItem4")
			Me.mapProduction.DataItemRepository.Add(dimension1, "DataItem3")
			Me.mapProduction.DataItemRepository.Add(measure2, "DataItem2")
			Me.mapProduction.DataItemRepository.Add(dimension4, "DataItem5")
			Me.mapProduction.DataSource = Me.dsCountries
			Me.mapProduction.InteractivityOptions.IgnoreMasterFilters = True
			Me.mapProduction.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.mapProduction.Latitude = dimension2
			Me.mapProduction.Legend.Visible = True
			Me.mapProduction.Longitude = dimension3
			Me.mapProduction.Name = "Energy Statistics by Country"
			Me.mapProduction.ShapeTitleAttributeName = "NAME"
			Me.mapProduction.ShowCaption = True
			Me.mapProduction.TooltipDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.mapProduction.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1, measure2})
			Me.mapProduction.Viewport.BottomLatitude = 27.646386718750023R
			Me.mapProduction.Viewport.CenterPointLatitude = 54.855558031681227R
			Me.mapProduction.Viewport.CenterPointLongitude = 17.541333007812533R
			Me.mapProduction.Viewport.LeftLongitude = -31.282958984375R
			Me.mapProduction.Viewport.RightLongitude = 66.365625000000051R
			Me.mapProduction.Viewport.TopLatitude = 71.177685546874955R
			Me.mapProduction.WeightedLegend.Position = DevExpress.DashboardCommon.MapLegendPosition.BottomLeft
			Me.mapProduction.WeightedLegend.Visible = True
			' 
			' dsCountries
			' 
			calculatedField1.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Import], 0))"
			calculatedField1.Name = "YearImport"
			calculatedField2.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Production], 0))"
			calculatedField2.Name = "YearProduction"
			calculatedField3.Expression = "ToDecimal([YearProduction] + [YearImport])"
			calculatedField3.Name = "YearTotal"
			calculatedField4.Expression = "ToDecimal(Iif(Sum([YearTotal]) = 0, 0, Sum([YearProduction]) / Sum([YearTotal])))"
			calculatedField4.Name = "DomesticShare"
			Me.dsCountries.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2, calculatedField3, calculatedField4})
			Me.dsCountries.ComponentName = "dsCountries"
			Me.dsCountries.DataMember = "Countries"
			Me.dsCountries.DataSchema = resources.GetString("dsCountries.DataSchema")
			Me.dsCountries.Name = "Countries"
			' 
			' gridProductionImportByCountry
			' 
			dimension5.DataMember = "Country"
			gridDimensionColumn1.Name = "Country"
			gridDimensionColumn1.Weight = 50.063938618925832R
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension5)
			measure3.DataMember = "DomesticShare"
			measure3.Name = "Domestic Share"
			measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			gridMeasureColumn1.Weight = 56.297953964194377R
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure3)
			measure4.DataMember = "Production"
			measure4.Name = "Production"
			gridSparklineColumn1.SparklineOptions.ViewType = DevExpress.DashboardCommon.SparklineViewType.Area
			gridSparklineColumn1.Weight = 62.531969309462916R
			gridSparklineColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridSparklineColumn1.AddDataItem("SparklineValue", measure4)
			Me.gridProductionImportByCountry.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1, gridSparklineColumn1})
			Me.gridProductionImportByCountry.ComponentName = "gridProductionImportByCountry"
			dimension6.DataMember = "Year"
			measure5.DataMember = "Production"
			Me.gridProductionImportByCountry.DataItemRepository.Clear()
			Me.gridProductionImportByCountry.DataItemRepository.Add(dimension5, "DataItem0")
			Me.gridProductionImportByCountry.DataItemRepository.Add(dimension6, "DataItem2")
			Me.gridProductionImportByCountry.DataItemRepository.Add(measure5, "DataItem5")
			Me.gridProductionImportByCountry.DataItemRepository.Add(measure3, "DataItem6")
			Me.gridProductionImportByCountry.DataItemRepository.Add(measure4, "DataItem1")
			Me.gridProductionImportByCountry.DataSource = Me.dsCountries
			formatConditionValue1.Condition = DevExpress.DashboardCommon.DashboardFormatCondition.GreaterOrEqual
			appearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontGreen
			formatConditionValue1.StyleSettings = appearanceSettings1
			formatConditionValue1.Value1 = New Decimal(New Integer() { 5, 0, 0, 65536})
			gridItemFormatRule1.Condition = formatConditionValue1
			gridItemFormatRule1.DataItem = measure3
			gridItemFormatRule1.Name = "FormatRule 1"
			formatConditionValue2.Condition = DevExpress.DashboardCommon.DashboardFormatCondition.Less
			appearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontYellow
			formatConditionValue2.StyleSettings = appearanceSettings2
			formatConditionValue2.Value1 = New Decimal(New Integer() { 5, 0, 0, 65536})
			gridItemFormatRule2.Condition = formatConditionValue2
			gridItemFormatRule2.DataItem = measure3
			gridItemFormatRule2.Name = "FormatRule 2"
			appearanceSettings3.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontRed
			formatConditionValue3.StyleSettings = appearanceSettings3
			formatConditionValue3.Value1 = New Decimal(New Integer() { 0, 0, 0, 0})
			gridItemFormatRule3.Condition = formatConditionValue3
			gridItemFormatRule3.DataItem = measure3
			gridItemFormatRule3.Name = "FormatRule 3"
			Me.gridProductionImportByCountry.FormatRules.AddRange(New DevExpress.DashboardCommon.GridItemFormatRule() { gridItemFormatRule1, gridItemFormatRule2, gridItemFormatRule3})
			Me.gridProductionImportByCountry.GridOptions.ShowHorizontalLines = False
			Me.gridProductionImportByCountry.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure5})
			Me.gridProductionImportByCountry.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridProductionImportByCountry.Name = "Energy Statistics by Country"
			Me.gridProductionImportByCountry.ShowCaption = False
			Me.gridProductionImportByCountry.SparklineArgument = dimension6
			' 
			' cardProductionImportByType
			' 
			measure6.DataMember = "YearImport"
			measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			measure7.DataMember = "YearProduction"
			card1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater
			card1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue
			card1.AddDataItem("ActualValue", measure6)
			card1.AddDataItem("TargetValue", measure7)
			Me.cardProductionImportByType.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
			Me.cardProductionImportByType.ComponentName = "cardProductionImportByType"
			Me.cardProductionImportByType.ContentLineCount = 1
			dimension7.DataMember = "EnergyType"
			Me.cardProductionImportByType.DataItemRepository.Clear()
			Me.cardProductionImportByType.DataItemRepository.Add(dimension7, "DataItem0")
			Me.cardProductionImportByType.DataItemRepository.Add(measure7, "DataItem1")
			Me.cardProductionImportByType.DataItemRepository.Add(measure6, "DataItem2")
			Me.cardProductionImportByType.DataSource = Me.dsCountries
			Me.cardProductionImportByType.FilterString = "[DataItem0] In ('Petroleum Products', 'Solid Fuels', 'Gases')"
			Me.cardProductionImportByType.InteractivityOptions.IgnoreMasterFilters = False
			Me.cardProductionImportByType.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.cardProductionImportByType.Name = "Energy Statistics by Type - Production vs Import"
			Me.cardProductionImportByType.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension7})
			Me.cardProductionImportByType.ShowCaption = True
			' 
			' EnergyStatisticsDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsCountries})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridProductionImportByCountry, Me.mapProduction, Me.cardProductionImportByType})
			dashboardLayoutItem1.DashboardItem = Me.mapProduction
			dashboardLayoutItem1.Weight = 66.992014196983135R
			dashboardLayoutItem2.DashboardItem = Me.gridProductionImportByCountry
			dashboardLayoutItem2.Weight = 33.007985803016858R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 73.931623931623932R
			dashboardLayoutItem3.DashboardItem = Me.cardProductionImportByType
			dashboardLayoutItem3.Weight = 26.068376068376068R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			staticListLookUpSettings1.Values = New String() { "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009"}
			dashboardParameter1.LookUpSettings = staticListLookUpSettings1
			dashboardParameter1.Name = "Year"
			dashboardParameter1.Type = GetType(Integer)
			dashboardParameter1.Value = 2009
			Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() { dashboardParameter1})
			Me.Title.Text = "Energy Statistics"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.WorldwideEnergyUseDashboard_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapProduction, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsCountries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridProductionImportByCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardProductionImportByType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub WorldwideEnergyUseDashboard_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
		e.Data = DataLoader.EnergyStatistics.Tables("Countries")
	End Sub
End Class
