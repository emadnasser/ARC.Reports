Imports Microsoft.VisualBasic
Imports System
Imports DashboardMainDemo
Imports DevExpress.DashboardCommon

''' <summary>
''' Summary description
''' </summary>
Public Class HumanResourcesDashboard
	Inherits Dashboard
	Private piePayrollStructureSum As PieDashboardItem
	Private dsEmployees As DashboardObjectDataSource
	Private gridStaffTurnoverTime As GridDashboardItem
	Private dsDepartments As DashboardObjectDataSource
	Private cardStaffTurnoverByDept As CardDashboardItem
	Private pieAbsenceReasonSum As PieDashboardItem
	Private chartPayrollStructure As ChartDashboardItem
	Private chartAbsenseDuration As ChartDashboardItem
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
			Dim resources As System.Resources.ResourceManager = Global.Resources.HumanResourcesDashboard.ResourceManager
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn2 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim gridColumnTotal1 As New DevExpress.DashboardCommon.GridColumnTotal()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn1 As New DevExpress.DashboardCommon.GridDeltaColumn()
			Dim gridItemFormatRule1 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionColorRangeBar1 As New DevExpress.DashboardCommon.FormatConditionColorRangeBar()
			Dim rangeInfo1 As New DevExpress.DashboardCommon.RangeInfo()
			Dim barStyleSettings1 As New DevExpress.DashboardCommon.BarStyleSettings()
			Dim rangeInfo2 As New DevExpress.DashboardCommon.RangeInfo()
			Dim barStyleSettings2 As New DevExpress.DashboardCommon.BarStyleSettings()
			Dim rangeInfo3 As New DevExpress.DashboardCommon.RangeInfo()
			Dim barStyleSettings3 As New DevExpress.DashboardCommon.BarStyleSettings()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries3 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure9 As New DevExpress.DashboardCommon.Measure()
			Dim measure10 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane2 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries4 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries5 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim measure11 As New DevExpress.DashboardCommon.Measure()
			Dim measure12 As New DevExpress.DashboardCommon.Measure()
			Dim measure13 As New DevExpress.DashboardCommon.Measure()
			Dim measure14 As New DevExpress.DashboardCommon.Measure()
			Dim measure15 As New DevExpress.DashboardCommon.Measure()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup4 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem5 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem6 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.gridStaffTurnoverTime = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.dsDepartments = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.cardStaffTurnoverByDept = New DevExpress.DashboardCommon.CardDashboardItem()
			Me.chartPayrollStructure = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dsEmployees = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartAbsenseDuration = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.piePayrollStructureSum = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.pieAbsenceReasonSum = New DevExpress.DashboardCommon.PieDashboardItem()
			CType(Me.gridStaffTurnoverTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardStaffTurnoverByDept, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartPayrollStructure, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartAbsenseDuration, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.piePayrollStructureSum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieAbsenceReasonSum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' gridStaffTurnoverTime
			' 
			dimension1.DataMember = "CurrentDate"
			dimension1.Name = "Year"
			gridDimensionColumn1.Name = "Year"
			gridDimensionColumn1.Weight = 55.650319829424305R
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension1)
			dimension2.DataMember = "CurrentDate"
			dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			dimension2.Name = "Month"
			gridDimensionColumn2.Name = "Month"
			gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn2.AddDataItem("Dimension", dimension2)
			measure1.DataMember = "StaffTurnrover"
			measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			gridMeasureColumn1.Name = "Turnover"
			gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Auto
			gridMeasureColumn1.Totals.AddRange(New DevExpress.DashboardCommon.GridColumnTotal() { gridColumnTotal1})
			gridMeasureColumn1.Weight = 84.914712153518124R
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure1)
			measure2.DataMember = "StaffTurnrover"
			measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			measure3.DataMember = "StaffTurnroverCritical"
			measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			gridDeltaColumn1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater
			gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue
			gridDeltaColumn1.Name = "Turnover"
			gridDeltaColumn1.Weight = 84.434968017057571R
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn1.AddDataItem("ActualValue", measure2)
			gridDeltaColumn1.AddDataItem("TargetValue", measure3)
			Me.gridStaffTurnoverTime.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridDimensionColumn2, gridMeasureColumn1, gridDeltaColumn1})
			Me.gridStaffTurnoverTime.ComponentName = "gridStaffTurnoverTime"
			Me.gridStaffTurnoverTime.DataItemRepository.Clear()
			Me.gridStaffTurnoverTime.DataItemRepository.Add(measure2, "DataItem4")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(dimension2, "DataItem0")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(dimension1, "DataItem3")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(measure1, "DataItem2")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(measure3, "DataItem5")
			Me.gridStaffTurnoverTime.DataSource = Me.dsDepartments
			formatConditionColorRangeBar1.BarOptions.ShowBarOnly = True
			barStyleSettings1.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Green
			rangeInfo1.StyleSettings = barStyleSettings1
			rangeInfo1.Value = 0R
			barStyleSettings2.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Blue
			rangeInfo2.StyleSettings = barStyleSettings2
			rangeInfo2.Value = 33R
			barStyleSettings3.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Red
			rangeInfo3.StyleSettings = barStyleSettings3
			rangeInfo3.Value = 67R
			formatConditionColorRangeBar1.RangeSet.AddRange(New DevExpress.DashboardCommon.RangeInfo() { rangeInfo1, rangeInfo2, rangeInfo3})
			formatConditionColorRangeBar1.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Percent
			gridItemFormatRule1.Condition = formatConditionColorRangeBar1
			gridItemFormatRule1.DataItem = measure1
			gridItemFormatRule1.Name = "FormatRule 1"
			Me.gridStaffTurnoverTime.FormatRules.AddRange(New DevExpress.DashboardCommon.GridItemFormatRule() { gridItemFormatRule1})
			Me.gridStaffTurnoverTime.GridOptions.ShowHorizontalLines = False
			Me.gridStaffTurnoverTime.InteractivityOptions.IgnoreMasterFilters = True
			Me.gridStaffTurnoverTime.InteractivityOptions.IsDrillDownEnabled = True
			Me.gridStaffTurnoverTime.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.gridStaffTurnoverTime.IsMasterFilterCrossDataSource = True
			Me.gridStaffTurnoverTime.Name = "Staff Turnover through Time"
			Me.gridStaffTurnoverTime.ShowCaption = True
			' 
			' dsDepartments
			' 
			Me.dsDepartments.ComponentName = "dsDepartments"
			Me.dsDepartments.DataMember = "DepartmentData"
			Me.dsDepartments.DataSchema = resources.GetString("dsDepartments.DataSchema")
			Me.dsDepartments.Name = "Departments"
			' 
			' cardStaffTurnoverByDept
			' 
			measure4.DataMember = "StaffTurnrover"
			measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			measure5.DataMember = "StaffTurnroverCritical"
			measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			card1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater
			card1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue
			card1.Name = "StaffTurnrover (Average) vs StaffTurnroverCritical (Average)"
			card1.AddDataItem("ActualValue", measure4)
			card1.AddDataItem("TargetValue", measure5)
			Me.cardStaffTurnoverByDept.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
			Me.cardStaffTurnoverByDept.ComponentName = "cardStaffTurnoverByDept"
			Me.cardStaffTurnoverByDept.ContentLineCount = 4
			dimension3.DataMember = "Department"
			Me.cardStaffTurnoverByDept.DataItemRepository.Clear()
			Me.cardStaffTurnoverByDept.DataItemRepository.Add(measure4, "DataItem0")
			Me.cardStaffTurnoverByDept.DataItemRepository.Add(measure5, "DataItem1")
			Me.cardStaffTurnoverByDept.DataItemRepository.Add(dimension3, "DataItem2")
			Me.cardStaffTurnoverByDept.DataSource = Me.dsDepartments
			Me.cardStaffTurnoverByDept.InteractivityOptions.IgnoreMasterFilters = False
			Me.cardStaffTurnoverByDept.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.cardStaffTurnoverByDept.IsMasterFilterCrossDataSource = True
			Me.cardStaffTurnoverByDept.Name = " Staff Turnover by Department"
			Me.cardStaffTurnoverByDept.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.cardStaffTurnoverByDept.ShowCaption = True
			' 
			' chartPayrollStructure
			' 
			dimension4.DataMember = "Employee"
			dimension4.TopNOptions.Enabled = True
			measure6.DataMember = "Salary"
			dimension4.TopNOptions.Measure = measure6
			Me.chartPayrollStructure.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.chartPayrollStructure.AxisX.TitleVisible = False
			Me.chartPayrollStructure.ComponentName = "chartPayrollStructure"
			measure7.DataMember = "Bonus"
			measure8.DataMember = "Overtime"
			Me.chartPayrollStructure.DataItemRepository.Clear()
			Me.chartPayrollStructure.DataItemRepository.Add(measure6, "DataItem0")
			Me.chartPayrollStructure.DataItemRepository.Add(measure7, "DataItem1")
			Me.chartPayrollStructure.DataItemRepository.Add(measure8, "DataItem2")
			Me.chartPayrollStructure.DataItemRepository.Add(dimension4, "DataItem3")
			Me.chartPayrollStructure.DataSource = Me.dsEmployees
			Me.chartPayrollStructure.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartPayrollStructure.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal
			Me.chartPayrollStructure.Name = " Payroll Structure for Top 5 Employees"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Value"
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Salary"
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries1.AddDataItem("Value", measure6)
			simpleSeries2.Name = "Bonus"
			simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries2.AddDataItem("Value", measure7)
			simpleSeries3.Name = "Overtime"
			simpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries3.AddDataItem("Value", measure8)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1, simpleSeries2, simpleSeries3})
			Me.chartPayrollStructure.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartPayrollStructure.ShowCaption = True
			' 
			' dsEmployees
			' 
			Me.dsEmployees.ComponentName = "dsEmployees"
			Me.dsEmployees.DataMember = "EmployeeData"
			Me.dsEmployees.DataSchema = resources.GetString("dsEmployees.DataSchema")
			Me.dsEmployees.Name = "Employees"
			' 
			' chartAbsenseDuration
			' 
			dimension5.DataMember = "Employee"
			dimension5.TopNOptions.Enabled = True
			measure9.DataMember = "VacationDays"
			measure9.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			dimension5.TopNOptions.Measure = measure9
			Me.chartAbsenseDuration.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.chartAbsenseDuration.AxisX.TitleVisible = False
			Me.chartAbsenseDuration.ComponentName = "chartAbsenseDuration"
			measure10.DataMember = "SickLeaveDays"
			measure10.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			Me.chartAbsenseDuration.DataItemRepository.Clear()
			Me.chartAbsenseDuration.DataItemRepository.Add(measure9, "DataItem0")
			Me.chartAbsenseDuration.DataItemRepository.Add(measure10, "DataItem1")
			Me.chartAbsenseDuration.DataItemRepository.Add(dimension5, "DataItem2")
			Me.chartAbsenseDuration.DataSource = Me.dsEmployees
			Me.chartAbsenseDuration.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartAbsenseDuration.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal
			Me.chartAbsenseDuration.Name = "Absence Duration for Top 5 Employees"
			chartPane2.Name = "Pane 1"
			chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.PrimaryAxisY.ShowGridLines = True
			chartPane2.PrimaryAxisY.Title = "Value"
			chartPane2.PrimaryAxisY.TitleVisible = False
			chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.SecondaryAxisY.ShowGridLines = False
			chartPane2.SecondaryAxisY.TitleVisible = True
			simpleSeries4.Name = "Vacation"
			simpleSeries4.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries4.AddDataItem("Value", measure9)
			simpleSeries5.Name = "Sick Leave"
			simpleSeries5.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries5.AddDataItem("Value", measure10)
			chartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries4, simpleSeries5})
			Me.chartAbsenseDuration.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane2})
			Me.chartAbsenseDuration.ShowCaption = True
			' 
			' piePayrollStructureSum
			' 
			Me.piePayrollStructureSum.ComponentName = "piePayrollStructureSum"
			measure11.DataMember = "Salary"
			measure11.Name = "Salary"
			measure12.DataMember = "Bonus"
			measure12.Name = "Bonus"
			measure13.DataMember = "Overtime"
			measure13.Name = "Overtime"
			Me.piePayrollStructureSum.DataItemRepository.Clear()
			Me.piePayrollStructureSum.DataItemRepository.Add(measure11, "DataItem0")
			Me.piePayrollStructureSum.DataItemRepository.Add(measure12, "DataItem1")
			Me.piePayrollStructureSum.DataItemRepository.Add(measure13, "DataItem2")
			Me.piePayrollStructureSum.DataSource = Me.dsEmployees
			Me.piePayrollStructureSum.InteractivityOptions.IgnoreMasterFilters = False
			Me.piePayrollStructureSum.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.piePayrollStructureSum.Name = "Payroll Structure Summary"
			Me.piePayrollStructureSum.ShowCaption = True
			Me.piePayrollStructureSum.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure11, measure12, measure13})
			' 
			' pieAbsenceReasonSum
			' 
			Me.pieAbsenceReasonSum.ComponentName = "pieAbsenceReasonSum"
			measure14.DataMember = "VacationDays"
			measure14.Name = "Vacation"
			measure14.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			measure15.DataMember = "SickLeaveDays"
			measure15.Name = "Sick Leave"
			measure15.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			Me.pieAbsenceReasonSum.DataItemRepository.Clear()
			Me.pieAbsenceReasonSum.DataItemRepository.Add(measure14, "DataItem0")
			Me.pieAbsenceReasonSum.DataItemRepository.Add(measure15, "DataItem1")
			Me.pieAbsenceReasonSum.DataSource = Me.dsEmployees
			Me.pieAbsenceReasonSum.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieAbsenceReasonSum.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.pieAbsenceReasonSum.Name = "Absence Reason Summary"
			Me.pieAbsenceReasonSum.ShowCaption = True
			Me.pieAbsenceReasonSum.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure14, measure15})
			' 
			' HumanResourcesDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsDepartments, Me.dsEmployees})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.piePayrollStructureSum, Me.gridStaffTurnoverTime, Me.cardStaffTurnoverByDept, Me.pieAbsenceReasonSum, Me.chartPayrollStructure, Me.chartAbsenseDuration})
			dashboardLayoutItem1.DashboardItem = Me.gridStaffTurnoverTime
			dashboardLayoutItem1.Weight = 66.996047430830046R
			dashboardLayoutItem2.DashboardItem = Me.cardStaffTurnoverByDept
			dashboardLayoutItem2.Weight = 33.003952569169961R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 40.0196656833825R
			dashboardLayoutItem3.DashboardItem = Me.chartPayrollStructure
			dashboardLayoutItem3.Weight = 32.213438735177867R
			dashboardLayoutItem4.DashboardItem = Me.chartAbsenseDuration
			dashboardLayoutItem4.Weight = 34.387351778656125R
			dashboardLayoutItem5.DashboardItem = Me.piePayrollStructureSum
			dashboardLayoutItem5.Weight = 53.770491803278688R
			dashboardLayoutItem6.DashboardItem = Me.pieAbsenceReasonSum
			dashboardLayoutItem6.Weight = 46.229508196721312R
			dashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem5, dashboardLayoutItem6})
			dashboardLayoutGroup4.DashboardItem = Nothing
			dashboardLayoutGroup4.Weight = 33.399209486166008R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4, dashboardLayoutGroup4})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 59.9803343166175R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Human Resources"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.HumanResourcesDashboard_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridStaffTurnoverTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsDepartments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardStaffTurnoverByDept, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartPayrollStructure, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsEmployees, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartAbsenseDuration, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.piePayrollStructureSum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieAbsenceReasonSum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub HumanResourcesDashboard_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
		If e.DataSource Is dsDepartments Then
			e.Data = DataLoader.HumanResourcesData.DepartmentData
		ElseIf e.DataSource Is dsEmployees Then
			e.Data = DataLoader.HumanResourcesData.EmployeeData
		End If
	End Sub
End Class
