Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.Web
Imports DevExpress.XtraCharts.Web

Partial Public Class DateTimeMeasureUnits
	Inherits ChartBasePage
	Private Const orderDateColumn As String = "OrderDate"
	Private Const freightColumn As String = "Freight"
	Private Const selectQuery As String = "SELECT OrderDate, Freight FROM Orders"
	Private Const chartTitle As String = "Sales Volume by "
	Private Const minMeasureUnit As DateTimeMeasureUnit = DateTimeMeasureUnit.Week

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property Options() As DateTimeScaleOptions
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisX.DateTimeScaleOptions
		End Get
	End Property
	Private ReadOnly Property IsAutoGrid() As Boolean
		Get
			Return chbAutoGrid.Checked
		End Get
	End Property
	Private ReadOnly Property IsAutoScale() As Boolean
		Get
			Return scaleMode.Equals(ScaleMode.Automatic)
		End Get
	End Property
	Private ReadOnly Property IsManualScale() As Boolean
		Get
			Return scaleMode.Equals(ScaleMode.Manual)
		End Get
	End Property
	Private ReadOnly Property IsContinuousScale() As Boolean
		Get
			Return scaleMode.Equals(ScaleMode.Continuous)
		End Get
	End Property
	Private ReadOnly Property AllowGridAlignment() As Boolean
		Get
			Return (Not IsAutoScale) AndAlso Not IsAutoGrid
		End Get
	End Property
	Private scaleMode As ScaleMode

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		scaleMode = GetScaleMode()
		If (Not IsPostBack) Then
			FillDefaultGridAlignmentCombo()
			UpdateScaleOptions()
			UpdateClientControls()
		End If
		Series.ArgumentDataMember = orderDateColumn
		Series.ValueDataMembers.AddRange(freightColumn)
		Series.DataSource = GetDataTable()
		If (Not IsPostBack) Then
			UpdateMeasureUnitSelectedIndex(Options.MeasureUnit)
			UpdateGridAlignmentSelectedIndex(Options.GridAlignment, minMeasureUnit)

		End If
	End Sub
	Protected Sub callbackPanel_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim measureUnitChanged As Boolean = e.Parameter = "SelectMeasureUnits" OrElse e.Parameter = "SelectScaleMode"
		If measureUnitChanged Then
			chbAutoGrid.Checked = True
		End If
		UpdateScaleOptions()
		UpdateClientControls()
		PerformSelectMeasureUnits()
		PerformSelectGridAlignment()
		PerformSelectAggregateFuntion()
		If IsContinuousScale Then
			FillDefaultGridAlignmentCombo()
		Else
			FillGridAlignmentCombo(Options.MeasureUnit)
		End If
		If measureUnitChanged OrElse e.Parameter = "SetAutoGrid" Then
			UpdateGridAlignmentSelectedIndex(Options.GridAlignment, Options.MeasureUnit)
		End If
		If (Not IsContinuousScale) AndAlso e.Parameter = "SelectScaleMode" Then
			UpdateMeasureUnitSelectedIndex(Options.MeasureUnit)
		End If
	End Sub
	Private Sub UpdateGridAlignmentSelectedIndex(ByVal gridAlignment As DateTimeGridAlignment, ByVal measureUnit As DateTimeMeasureUnit)
		cbGridAlignment.SelectedIndex = CInt(Fix(gridAlignment)) - CInt(Fix(measureUnit))
	End Sub
	Private Sub UpdateMeasureUnitSelectedIndex(ByVal measureUnit As DateTimeMeasureUnit)
		cbMeasureUnits.SelectedIndex = CInt(Fix(measureUnit)) - CInt(Fix(minMeasureUnit))
	End Sub
	Protected Sub FillGridAlignmentCombo(ByVal measureUnit As DateTimeMeasureUnit)
		cbGridAlignment.Items.Clear()
		Select Case measureUnit
			Case DateTimeMeasureUnit.Week
				cbGridAlignment.Items.AddRange(New ListEditItem() { GetWeekItem(), GetMonthItem(), GetQuarterItem(), GetYearItem() })
			Case DateTimeMeasureUnit.Month
				cbGridAlignment.Items.AddRange(New ListEditItem() { GetMonthItem(), GetQuarterItem(), GetYearItem() })
			Case DateTimeMeasureUnit.Quarter
				cbGridAlignment.Items.AddRange(New ListEditItem() { GetQuarterItem(), GetYearItem() })
			Case DateTimeMeasureUnit.Year
				cbGridAlignment.Items.Add(GetYearItem())
		End Select
	End Sub
	Private Sub FillDefaultGridAlignmentCombo()
		FillGridAlignmentCombo(minMeasureUnit)
	End Sub
	Private Function GetGridAlignmentItem(ByVal alignment As DateTimeGridAlignment) As ListEditItem
		Return New ListEditItem(alignment.ToString(), alignment)
	End Function
	Private Function GetYearItem() As ListEditItem
		Return GetGridAlignmentItem(DateTimeGridAlignment.Year)
	End Function
	Private Function GetMonthItem() As ListEditItem
		Return GetGridAlignmentItem(DateTimeGridAlignment.Month)
	End Function
	Private Function GetQuarterItem() As ListEditItem
		Return GetGridAlignmentItem(DateTimeGridAlignment.Quarter)
	End Function
	Private Function GetWeekItem() As ListEditItem
		Return GetGridAlignmentItem(DateTimeGridAlignment.Week)
	End Function
	Private Function GetSelectedComboBoxValue(Of TResult As Structure)(ByVal source As ASPxComboBox) As Object
		Dim result As TResult
		If System.Enum.TryParse(Of TResult)(source.SelectedItem.Value.ToString(), result) Then
			Return result
		End If
		Return Nothing
	End Function
	Private Sub PerformSelectGridAlignment()
		Dim alignment As Object = GetSelectedComboBoxValue(Of DateTimeGridAlignment)(cbGridAlignment)
		If AllowGridAlignment AndAlso alignment IsNot Nothing Then
			Options.GridAlignment = CType(alignment, DateTimeGridAlignment)
		End If
	End Sub
	Private Sub PerformSelectMeasureUnits()
		Dim measureUnit As Object = GetSelectedComboBoxValue(Of DateTimeMeasureUnit)(cbMeasureUnits)
		If IsManualScale AndAlso measureUnit IsNot Nothing Then
			Options.MeasureUnit = CType(measureUnit, DateTimeMeasureUnit)
		End If
	End Sub
	Private Sub PerformSelectAggregateFuntion()
		Dim [function] As Object = GetSelectedComboBoxValue(Of AggregateFunction)(cbAggregateFunction)
		If [function] IsNot Nothing Then
			Options.AggregateFunction = CType([function], AggregateFunction)
		End If
	End Sub
	Private Function GetScaleMode() As ScaleMode
		Dim scaleMode As Object = GetSelectedComboBoxValue(Of ScaleMode)(cbScaleMode)
		Return If(scaleMode IsNot Nothing, CType(scaleMode, ScaleMode), ScaleMode.Automatic)
	End Function
	Private Sub UpdateScaleOptions()
		Options.ScaleMode = scaleMode
		Options.AutoGrid = If(IsAutoScale, True, IsAutoGrid)
		If (Not Options.AutoGrid) Then
			Options.GridSpacing = 1
		End If
	End Sub
	Private Sub UpdateClientControls()
		cbGridAlignment.ClientEnabled = AllowGridAlignment
		cbMeasureUnits.ClientEnabled = IsManualScale
		cbAggregateFunction.ClientEnabled = Not IsContinuousScale
		chbAutoGrid.ClientEnabled = Not IsAutoScale
	End Sub
	Private Function GetDataTable() As DataTable
		Using dataSource As New AccessDataSource(AccessDataSource1.DataFile, selectQuery)
			dataSource.DataSourceMode = SqlDataSourceMode.DataSet
			Return (CType(dataSource.Select(DataSourceSelectArguments.Empty), DataView)).ToTable()
		End Using
	End Function

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
