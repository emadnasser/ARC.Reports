Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class DateTimeScaleDemo
		Inherits ChartDemoBase2D
		Public Class ComboBoxItem
			Private titleText As String
			Private actionField As Action

			Public ReadOnly Property ItemAction() As Action
				Get
					Return actionField
				End Get
			End Property

			Public Sub New(ByVal titleText As String, ByVal actionParam As Action)
				Me.titleText = titleText
				Me.actionField = actionParam
			End Sub
			Public Overrides Function ToString() As String
				Return titleText
			End Function
		End Class

		Private Const OrderDateColumn As String = "OrderDate"
		Private Const FreightColumn As String = "Freight"
		Private Const SelectQuery As String = "SELECT OrderDate, Freight FROM Orders"
		Private Const Title As String = "Sales Volume by "

		Private gridAlignmentItems As List(Of ComboBoxItem)

		Protected ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chart.Diagram, XYDiagram)
			End Get
		End Property
		Protected ReadOnly Property AxisX() As AxisX
			Get
				Return Diagram.AxisX
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property
		Public Overrides ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CreateGridAlignmentComboBoxItems() As List(Of ComboBoxItem)
			Return New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Year", AddressOf SetYearGridAlignment), New ComboBoxItem("Quarter", AddressOf SetQuarterGridAlignment), New ComboBoxItem("Month", AddressOf SetMonthGridAlignment), New ComboBoxItem("Week", AddressOf SetWeekGridAlignment), New ComboBoxItem("Day", AddressOf SetDayGridAlignment)})
		End Function
		Private Sub FillScaleMode()
			Dim scaleModeItems As New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Manual", AddressOf SetManualScaleMode), New ComboBoxItem("Continuous", AddressOf SetContinuousScaleMode), New ComboBoxItem("Automatic", AddressOf SetAutomaticScaleMode)})
			cbScaleMode.Properties.Items.AddRange(scaleModeItems)
		End Sub
		Private Sub FillMeasureUnit()
			Dim measureUnitItems As New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Year", AddressOf SetYearMeasureUnit), New ComboBoxItem("Quarter", AddressOf SetQuarterMeasureUnit), New ComboBoxItem("Month", AddressOf SetMonthMeasureUnit), New ComboBoxItem("Week", AddressOf SetWeekMeasureUnit), New ComboBoxItem("Day", AddressOf SetDayMeasureUnit)})
			cbMeasureUnit.Properties.Items.AddRange(measureUnitItems)
		End Sub
		Private Sub FillFunctions()
			Dim aggregateFunctionItems As New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Average", AddressOf SetAverageFunctionItems), New ComboBoxItem("Minimum", AddressOf SetMinimumFunctionItems), New ComboBoxItem("Maximum", AddressOf SetMaximumFunctionItems), New ComboBoxItem("Sum", AddressOf SetSumFunctionItems), New ComboBoxItem("Count", AddressOf SetCountFunctionItems)})
			cbAggregateFunction.Properties.Items.AddRange(aggregateFunctionItems)
			cbAggregateFunction.SelectedIndex = 3
		End Sub
		Private Sub BindChartToData()
			Dim ds As New DataSet()
			Using connection As New OleDbConnection()
				Dim path As String = Utils.GetRelativePath("nwind.mdb")
				If path.Length > 0 Then
					Utils.SetConnectionString(connection, path)
				Else
					XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
				Try
					Using adapter As New OleDbDataAdapter(SelectQuery, connection)
						adapter.Fill(ds)
					End Using
				Catch e As OleDbException
					XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End Try
			End Using

			Dim series As New Series("Primary", ViewType.StackedBar)
			series.DataSource = ds
			series.ArgumentDataMember = "Table.OrderDate"
			series.ValueDataMembers.AddRange(New String() { "Table.Freight" })

			chart.Series.Clear()
			chart.Series.Add(series)
		End Sub
		Private Sub SetChartTitle(ByVal additionalTitle As String)
			If chart.Titles.Count > 0 Then
				chart.Titles(0).Text = Title & additionalTitle
			End If
		End Sub
		Private Sub ResetAxisOptions()
			AxisX.DateTimeScaleOptions.GridSpacing = 1
			AxisX.Tickmarks.MinorVisible = False
			AxisX.Label.Angle = 0
		End Sub
		Private Sub EnableAggregateFunction(ByVal isEnabled As Boolean)
			cbAggregateFunction.Enabled = isEnabled
			If isEnabled Then
				ExecuteSelectedItemAction(cbAggregateFunction)
			End If
		End Sub
		Private Sub EnablebGridAlignment(ByVal isEnabled As Boolean)
			chbAutoGrid.Enabled = isEnabled
			If isEnabled Then
				UpdateAutoGrid()
			Else
				cbGridAlignment.Enabled = isEnabled
			End If
		End Sub
		Private Sub SetAxisXGridAlignment(ByVal gridAlignment As DateTimeGridAlignment)
			AxisX.DateTimeScaleOptions.GridAlignment = gridAlignment
		End Sub
		Private Sub SetAxisXAggregateFunction(ByVal aggregateFunction As AggregateFunction)
			AxisX.DateTimeScaleOptions.AggregateFunction = aggregateFunction
		End Sub
		Private Sub SetManualScaleMode()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual
			cbMeasureUnit.Enabled = True
			ExecuteSelectedItemAction(cbMeasureUnit)
			EnablebGridAlignment(True)
			EnableAggregateFunction(True)
		End Sub
		Private Sub SetContinuousScaleMode()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous
			cbMeasureUnit.Enabled = False
			EnablebGridAlignment(True)
			UpdateGridAlignment(5)
			EnableAggregateFunction(False)
		End Sub
		Private Sub SetAutomaticScaleMode()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic
			cbMeasureUnit.Enabled = False
			EnablebGridAlignment(False)
			EnableAggregateFunction(True)
		End Sub
		Private Sub SetYearMeasureUnit()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year
			UpdateGridAlignment(1)
			SetChartTitle("Years")
		End Sub
		Private Sub SetQuarterMeasureUnit()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Quarter
			UpdateGridAlignment(2)
			SetChartTitle("Quarters")
		End Sub
		Private Sub SetMonthMeasureUnit()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month
			UpdateGridAlignment(3)
			SetChartTitle("Months")
		End Sub
		Private Sub SetWeekMeasureUnit()
			ResetAxisOptions()
			AxisX.Tickmarks.MinorVisible = True
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week
			UpdateGridAlignment(4)
			SetChartTitle("Weeks")
		End Sub
		Private Sub SetDayMeasureUnit()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day
			UpdateGridAlignment(5)
			SetChartTitle("Days")
		End Sub
		Private Sub UpdateGridAlignment(ByVal itemsCount As Integer)
			itemsCount = Math.Max(itemsCount, 1)
			Dim selectedIndex As Integer = Math.Max(cbGridAlignment.SelectedIndex, 0)
			cbGridAlignment.Properties.Items.Clear()
			cbGridAlignment.Properties.Items.AddRange(gridAlignmentItems.GetRange(0, itemsCount))
			cbGridAlignment.SelectedIndex = Math.Min(itemsCount - 1, selectedIndex)
			If cbGridAlignment.Enabled Then
				ExecuteSelectedItemAction(cbGridAlignment)
			End If
		End Sub
		Private Sub UpdateAutoGrid()
			Dim isAutoGrid As Boolean = chbAutoGrid.Checked
			AxisX.DateTimeScaleOptions.AutoGrid = isAutoGrid
			cbGridAlignment.Enabled = Not isAutoGrid
			If (Not isAutoGrid) Then
				ExecuteSelectedItemAction(cbGridAlignment)
			End If
		End Sub
		Private Sub SetDayGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Day)
		End Sub
		Private Sub SetWeekGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Week)
		End Sub
		Private Sub SetMonthGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Month)
		End Sub
		Private Sub SetQuarterGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Quarter)
		End Sub
		Private Sub SetYearGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Year)
		End Sub
		Private Sub SetCountFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Count)
		End Sub
		Private Sub SetSumFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Sum)
		End Sub
		Private Sub SetMaximumFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Maximum)
		End Sub
		Private Sub SetMinimumFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Average)
		End Sub
		Private Sub SetAverageFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Minimum)
		End Sub
		Private Sub ExecuteSelectedItemAction(ByVal comboBox As ComboBoxEdit)
			Dim item As ComboBoxItem = TryCast(comboBox.SelectedItem, ComboBoxItem)
			If item IsNot Nothing Then
				Dim itemAction As Action = item.ItemAction
				If itemAction IsNot Nothing Then
					itemAction()
				End If
			End If
		End Sub
		Private Sub ComboBoxSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAggregateFunction.SelectedIndexChanged, cbMeasureUnit.SelectedValueChanged, cbGridAlignment.SelectedValueChanged, cbScaleMode.SelectedValueChanged
			Dim comboBox As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			If comboBox IsNot Nothing Then
				ExecuteSelectedItemAction(comboBox)
			End If
		End Sub
		Private Sub chbAutoGrid_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbAutoGrid.CheckedChanged
			UpdateAutoGrid()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.CrosshairEnabled = DefaultBoolean.True
			gridAlignmentItems = CreateGridAlignmentComboBoxItems()
			FillMeasureUnit()
			FillFunctions()
			FillScaleMode()
			BindChartToData()
			cbMeasureUnit.SelectedIndex = 0
			cbScaleMode.SelectedIndex = 0
		End Sub
	End Class
End Namespace
