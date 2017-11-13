Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class HumanResources
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
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries3 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim measure9 As New DevExpress.DashboardCommon.Measure()
			Dim measure10 As New DevExpress.DashboardCommon.Measure()
			Dim measure11 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure12 As New DevExpress.DashboardCommon.Measure()
			Dim measure13 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane2 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries4 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries5 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim measure14 As New DevExpress.DashboardCommon.Measure()
			Dim measure15 As New DevExpress.DashboardCommon.Measure()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem5 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem6 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.gridStaffTurnoverTime = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.dsDepartments = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartPayrollStructure = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dsEmployees = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.piePayrollStructureSum = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.cardStaffTurnoverByDept = New DevExpress.DashboardCommon.CardDashboardItem()
			Me.chartAbsenseDuration = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.pieAbsenceReasonSum = New DevExpress.DashboardCommon.PieDashboardItem()
			CType(Me.gridStaffTurnoverTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartPayrollStructure, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.piePayrollStructureSum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardStaffTurnoverByDept, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartAbsenseDuration, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
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
			gridDimensionColumn1.Weight = 55.617977528089888R
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
			gridMeasureColumn1.Weight = 84.9438202247191R
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
			gridDeltaColumn1.Weight = 84.438202247191015R
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn1.AddDataItem("ActualValue", measure2)
			gridDeltaColumn1.AddDataItem("TargetValue", measure3)
			Me.gridStaffTurnoverTime.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridDimensionColumn2, gridMeasureColumn1, gridDeltaColumn1})
			Me.gridStaffTurnoverTime.ComponentName = "gridStaffTurnoverTime"
			Me.gridStaffTurnoverTime.DataItemRepository.Clear()
			Me.gridStaffTurnoverTime.DataItemRepository.Add(measure3, "DataItem5")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(measure1, "DataItem2")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(dimension1, "DataItem3")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(dimension2, "DataItem0")
			Me.gridStaffTurnoverTime.DataItemRepository.Add(measure2, "DataItem4")
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
			Me.dsDepartments.DataSource = GetType(DashboardMainDemo.DepartmentData)
			Me.dsDepartments.Name = "Departments"
			' 
			' chartPayrollStructure
			' 
			dimension3.DataMember = "Employee"
			dimension3.TopNOptions.Enabled = True
			measure4.DataMember = "Salary"
			dimension3.TopNOptions.Measure = measure4
			Me.chartPayrollStructure.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.chartPayrollStructure.AxisX.TitleVisible = False
			Me.chartPayrollStructure.ComponentName = "chartPayrollStructure"
			measure5.DataMember = "Overtime"
			measure6.DataMember = "Bonus"
			Me.chartPayrollStructure.DataItemRepository.Clear()
			Me.chartPayrollStructure.DataItemRepository.Add(dimension3, "DataItem3")
			Me.chartPayrollStructure.DataItemRepository.Add(measure5, "DataItem2")
			Me.chartPayrollStructure.DataItemRepository.Add(measure6, "DataItem1")
			Me.chartPayrollStructure.DataItemRepository.Add(measure4, "DataItem0")
			Me.chartPayrollStructure.DataSource = Me.dsEmployees
			Me.chartPayrollStructure.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartPayrollStructure.Name = " Payroll Structure for Top 5 Employees"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Value"
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Salary"
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries1.AddDataItem("Value", measure4)
			simpleSeries2.Name = "Bonus"
			simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries2.AddDataItem("Value", measure6)
			simpleSeries3.Name = "Overtime"
			simpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries3.AddDataItem("Value", measure5)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1, simpleSeries2, simpleSeries3})
			Me.chartPayrollStructure.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartPayrollStructure.ShowCaption = True
			' 
			' dsEmployees
			' 
			Me.dsEmployees.ComponentName = "dsEmployees"
			Me.dsEmployees.DataSource = GetType(DashboardMainDemo.EmployeeData)
			Me.dsEmployees.Name = "Employees"
			' 
			' piePayrollStructureSum
			' 
			Me.piePayrollStructureSum.ComponentName = "piePayrollStructureSum"
			measure7.DataMember = "Overtime"
			measure7.Name = "Overtime"
			measure8.DataMember = "Bonus"
			measure8.Name = "Bonus"
			measure9.DataMember = "Salary"
			measure9.Name = "Salary"
			Me.piePayrollStructureSum.DataItemRepository.Clear()
			Me.piePayrollStructureSum.DataItemRepository.Add(measure7, "DataItem2")
			Me.piePayrollStructureSum.DataItemRepository.Add(measure8, "DataItem1")
			Me.piePayrollStructureSum.DataItemRepository.Add(measure9, "DataItem0")
			Me.piePayrollStructureSum.DataSource = Me.dsEmployees
			Me.piePayrollStructureSum.InteractivityOptions.IgnoreMasterFilters = False
			Me.piePayrollStructureSum.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.piePayrollStructureSum.Name = "Payroll Structure Summary"
			Me.piePayrollStructureSum.ShowCaption = True
			Me.piePayrollStructureSum.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure9, measure8, measure7})
			' 
			' cardStaffTurnoverByDept
			' 
			measure10.DataMember = "StaffTurnrover"
			measure10.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			measure10.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			measure11.DataMember = "StaffTurnroverCritical"
			measure11.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			card1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater
			card1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue
			card1.Name = "StaffTurnrover (Average) vs StaffTurnroverCritical (Average)"
			card1.AddDataItem("ActualValue", measure10)
			card1.AddDataItem("TargetValue", measure11)
			Me.cardStaffTurnoverByDept.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
			Me.cardStaffTurnoverByDept.ComponentName = "cardStaffTurnoverByDept"
			Me.cardStaffTurnoverByDept.ContentLineCount = 4
			dimension4.DataMember = "Department"
			Me.cardStaffTurnoverByDept.DataItemRepository.Clear()
			Me.cardStaffTurnoverByDept.DataItemRepository.Add(dimension4, "DataItem2")
			Me.cardStaffTurnoverByDept.DataItemRepository.Add(measure11, "DataItem1")
			Me.cardStaffTurnoverByDept.DataItemRepository.Add(measure10, "DataItem0")
			Me.cardStaffTurnoverByDept.DataSource = Me.dsDepartments
			Me.cardStaffTurnoverByDept.InteractivityOptions.IgnoreMasterFilters = False
			Me.cardStaffTurnoverByDept.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.cardStaffTurnoverByDept.IsMasterFilterCrossDataSource = True
			Me.cardStaffTurnoverByDept.Name = " Staff Turnover by Department"
			Me.cardStaffTurnoverByDept.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.cardStaffTurnoverByDept.ShowCaption = True
			' 
			' chartAbsenseDuration
			' 
			dimension5.DataMember = "Employee"
			dimension5.TopNOptions.Enabled = True
			measure12.DataMember = "VacationDays"
			measure12.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			dimension5.TopNOptions.Measure = measure12
			Me.chartAbsenseDuration.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.chartAbsenseDuration.AxisX.TitleVisible = False
			Me.chartAbsenseDuration.ComponentName = "chartAbsenseDuration"
			measure13.DataMember = "SickLeaveDays"
			measure13.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			Me.chartAbsenseDuration.DataItemRepository.Clear()
			Me.chartAbsenseDuration.DataItemRepository.Add(dimension5, "DataItem2")
			Me.chartAbsenseDuration.DataItemRepository.Add(measure13, "DataItem1")
			Me.chartAbsenseDuration.DataItemRepository.Add(measure12, "DataItem0")
			Me.chartAbsenseDuration.DataSource = Me.dsEmployees
			Me.chartAbsenseDuration.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartAbsenseDuration.Name = "Absence Duration for Top 5 Employees"
			chartPane2.Name = "Pane 1"
			chartPane2.PrimaryAxisY.ShowGridLines = True
			chartPane2.PrimaryAxisY.Title = "Value"
			chartPane2.PrimaryAxisY.TitleVisible = False
			chartPane2.SecondaryAxisY.ShowGridLines = False
			chartPane2.SecondaryAxisY.TitleVisible = True
			simpleSeries4.Name = "Vacation"
			simpleSeries4.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries4.AddDataItem("Value", measure12)
			simpleSeries5.Name = "Sick Leave"
			simpleSeries5.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries5.AddDataItem("Value", measure13)
			chartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries4, simpleSeries5})
			Me.chartAbsenseDuration.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane2})
			Me.chartAbsenseDuration.ShowCaption = True
			' 
			' pieAbsenceReasonSum
			' 
			Me.pieAbsenceReasonSum.ComponentName = "pieAbsenceReasonSum"
			measure14.DataMember = "SickLeaveDays"
			measure14.Name = "Sick Leave"
			measure14.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			measure15.DataMember = "VacationDays"
			measure15.Name = "Vacation"
			measure15.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			Me.pieAbsenceReasonSum.DataItemRepository.Clear()
			Me.pieAbsenceReasonSum.DataItemRepository.Add(measure14, "DataItem1")
			Me.pieAbsenceReasonSum.DataItemRepository.Add(measure15, "DataItem0")
			Me.pieAbsenceReasonSum.DataSource = Me.dsEmployees
			Me.pieAbsenceReasonSum.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieAbsenceReasonSum.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.pieAbsenceReasonSum.Name = "Absence Reason Summary"
			Me.pieAbsenceReasonSum.ShowCaption = True
			Me.pieAbsenceReasonSum.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure15, measure14})
			' 
			' HumanResources
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsDepartments, Me.dsEmployees})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.piePayrollStructureSum, Me.gridStaffTurnoverTime, Me.cardStaffTurnoverByDept, Me.pieAbsenceReasonSum, Me.chartPayrollStructure, Me.chartAbsenseDuration})
			dashboardLayoutItem1.DashboardItem = Me.gridStaffTurnoverTime
			dashboardLayoutItem1.Weight = 37.998436278342453R
			dashboardLayoutItem2.DashboardItem = Me.chartPayrollStructure
			dashboardLayoutItem2.Weight = 36.98201720093823R
			dashboardLayoutItem3.DashboardItem = Me.piePayrollStructureSum
			dashboardLayoutItem3.Weight = 25.019546520719313R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2, dashboardLayoutItem3})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 52.612393681652492R
			dashboardLayoutItem4.DashboardItem = Me.cardStaffTurnoverByDept
			dashboardLayoutItem4.Weight = 37.998436278342453R
			dashboardLayoutItem5.DashboardItem = Me.chartAbsenseDuration
			dashboardLayoutItem5.Weight = 36.98201720093823R
			dashboardLayoutItem6.DashboardItem = Me.pieAbsenceReasonSum
			dashboardLayoutItem6.Weight = 25.019546520719313R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem4, dashboardLayoutItem5, dashboardLayoutItem6})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Weight = 47.387606318347508R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Human Resources"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.HumanResources_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridStaffTurnoverTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsDepartments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartPayrollStructure, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsEmployees, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.piePayrollStructureSum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardStaffTurnoverByDept, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartAbsenseDuration, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieAbsenceReasonSum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private piePayrollStructureSum As DevExpress.DashboardCommon.PieDashboardItem
		Private gridStaffTurnoverTime As DevExpress.DashboardCommon.GridDashboardItem
		Private cardStaffTurnoverByDept As DevExpress.DashboardCommon.CardDashboardItem
		Private pieAbsenceReasonSum As DevExpress.DashboardCommon.PieDashboardItem
		Private chartPayrollStructure As DevExpress.DashboardCommon.ChartDashboardItem
		Private chartAbsenseDuration As DevExpress.DashboardCommon.ChartDashboardItem
		Private dsEmployees As DevExpress.DashboardCommon.DashboardObjectDataSource
		Private dsDepartments As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace
