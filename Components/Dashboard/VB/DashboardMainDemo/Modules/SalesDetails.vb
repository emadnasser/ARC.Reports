Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardWin
Imports DevExpress.XtraEditors

Namespace DashboardMainDemo.Modules
	Partial Public Class SalesDetails
		Inherits DashboardTutorialControl
		Private apiDisabled As Boolean = False

		Protected Overrides ReadOnly Property CalculateHiddenTotals() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub SubscribeDashboardEvents()
			AddHandler DashboardViewer.DashboardItemClick, AddressOf DashboardViewer_DashboardItemClick
			AddHandler DashboardViewer.DashboardItemVisualInteractivity, AddressOf OnDashboardItemVisualInteractivity
		End Sub
		Private Sub OnDashboardItemVisualInteractivity(ByVal sender As Object, ByVal e As DashboardItemVisualInteractivityEventArgs)
			If e.DashboardItemName = "cardSalesByProduct" Then
				e.EnableHighlighting = True
			End If
		End Sub
		Private Sub DashboardViewer_DashboardItemClick(ByVal sender As Object, ByVal e As DashboardItemMouseActionEventArgs)
			If (Not apiDisabled) AndAlso e.DashboardItemName = "cardSalesByProduct" Then
				Dim axisPoint As AxisPoint = e.GetAxisPoint()
				If axisPoint IsNot Nothing Then
					Using form As New SalesDetailsPopupForm()
						form.SetGridDataSource(CreateGridData(e))
						form.SetPieData(CreatePieData(e))
						form.SetChartData(CreateChartData(e))
						form.PrepareChart(e)
						form.SetUnitsInStock(GetUnitsInStock(e))
						form.Text = axisPoint.Value.ToString()
						form.ShowDialog()
					End Using
				End If
			End If
		End Sub
		Private Function GetUnitsInStock(ByVal e As DashboardItemMouseActionEventArgs) As Object
			Dim clickedItemData As MultiDimensionalData = e.Data.GetSlice(e.GetAxisPoint())
			Dim measures As New List(Of MeasureDescriptor)(e.Data.GetMeasures())
'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
			Dim unitsInStockMeasure As MeasureDescriptor = measures.Find(Function(descriptor) descriptor.DataMember = "UnitsInStock")
			Return clickedItemData.GetValue(unitsInStockMeasure).DisplayText
		End Function
		Private Function CreateGridData(ByVal e As DashboardItemMouseActionEventArgs) As DashboardUnderlyingDataSet
			Dim columnNames As IList(Of String) = e.Data.GetDataMembers()
			Return e.GetUnderlyingData(New List(Of String) (New String() {columnNames(7), columnNames(1), columnNames(5), columnNames(6), columnNames(9), columnNames(10), columnNames(3), columnNames(4), columnNames(8)}))
		End Function
		Private Function CreatePieData(ByVal e As DashboardItemMouseActionEventArgs) As DataTable
			Dim axisPoint As AxisPoint = e.GetAxisPoint()
			Dim data As MultiDimensionalData = e.Data
			Dim delta As DeltaDescriptor = e.GetDeltas()(0)

			Dim table As New DataTable()

			table.Columns.Add("Argument", GetType(String))
			table.Columns.Add("Value", GetType(Decimal))

			Dim row As DataRow = Nothing
			row = table.NewRow()
			row("Argument") = axisPoint.Value.ToString()
			Dim deltaValue As Decimal = Convert.ToDecimal(data.GetSlice(axisPoint).GetDeltaValue(delta).ActualValue.Value)
			row("Value") = deltaValue
			table.Rows.Add(row)
			row = table.NewRow()
			Dim totalValue As Decimal = Convert.ToDecimal(data.GetSlice(axisPoint.Parent).GetDeltaValue(delta).ActualValue.Value)
			row("Argument") = "Other " & axisPoint.Parent.Value.ToString()
			row("Value") = (totalValue - deltaValue).ToString()
			table.Rows.Add(row)

			Return table
		End Function
		Private Function CreateChartData(ByVal e As DashboardItemMouseActionEventArgs) As DataTable
			Dim clickedItemData As MultiDimensionalData = e.Data.GetSlice(e.GetAxisPoint())
			Dim delta As DeltaDescriptor = e.GetDeltas()(0)

			Dim table As New DataTable()

			table.Columns.Add("Argument", GetType(Integer))
			table.Columns.Add("Actual", GetType(Double))
			table.Columns.Add("Target", GetType(Double))

			For Each point As AxisPoint In clickedItemData.GetAxisPoints("Sparkline")
				Dim argumentValue As Object = point.Value
				If TypeOf argumentValue Is Integer Then
					Dim row As DataRow = table.NewRow()
					row("Argument") = argumentValue
					Dim deltaValue As DeltaValue = clickedItemData.GetSlice(point).GetDeltaValue(delta)
					row("Actual") = deltaValue.ActualValue.Value
					row("Target") = deltaValue.TargetValue.Value
					table.Rows.Add(row)
				End If
			Next point

			Return table
		End Function
		Protected Overrides Sub EditDashboard()
			If apiDisabled OrElse XtraMessageBox.Show(LookAndFeel, Me, "If you proceed and modify this dashboard, the capability to pop up detail windows for individual cards will be disabled. Do you wish to continue?", "Sales Details", MessageBoxButtons.YesNo) = DialogResult.Yes Then
				MyBase.EditDashboard()
				If (Not apiDisabled) AndAlso DashboardModified Then
					apiDisabled = True
				End If
			End If
		End Sub
	End Class
End Namespace
