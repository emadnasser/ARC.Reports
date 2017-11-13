Imports Microsoft.VisualBasic
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports DevExpress.Utils

Namespace PivotGridOlapBrowser.Helpers
	Public Class BrowserChart
		Inherits ChartControl
		Implements IXRControlCreatable
		Shared Sub InitChart(ByVal chart As BrowserChart)
			chart.SeriesDataMember = "Series"
			chart.SeriesTemplate.ArgumentDataMember = "Arguments"
			chart.SeriesTemplate.ValueDataMembers.AddRange(New String() { "Values" })
			chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
			chart.Legend.AlignmentVertical = LegendAlignmentVertical.Center
			PrepareXYDiagram(TryCast(chart.Diagram, XYDiagram))
		End Sub
		Private Shared Sub PrepareXYDiagram(ByVal diagram As XYDiagram)
			If diagram Is Nothing Then
				Return
			End If
			diagram.AxisX.Label.Angle = -45
			diagram.AxisX.Label.EnableAntialiasing = DefaultBoolean.True
			'diagram.AxisX.Label.Staggered = true;
		End Sub

		Private fViewType As ViewType
		Private showTotals_Renamed As Boolean
		Private showSelection_Renamed? As Boolean
		Private ReadOnly state As DataState

		Public Sub New(ByVal viewType As ViewType, ByVal showTotals As Boolean, ByVal showSelection? As Boolean, ByVal state As DataState)
			BrowserChart.InitChart(Me)
			Me.showTotals_Renamed = showTotals
			Me.showSelection_Renamed = showSelection
			Me.state = state
			ApplyFilter()
			Me.ViewType = viewType
		End Sub
		Public Property ShowTotals() As Boolean
			Get
				Return showTotals_Renamed
			End Get
			Set(ByVal value As Boolean)
				If value = showTotals_Renamed Then
					Return
				End If
				Me.showTotals_Renamed = value
				ApplyFilter()
			End Set
		End Property
		Public Property ShowSelection() As Boolean?
			Get
				Return showSelection_Renamed
			End Get
			Set(ByVal value? As Boolean)
				If value.Equals(showSelection_Renamed) Then
					Return
				End If
				Me.showSelection_Renamed = value
				ApplyFilter()
			End Set
		End Property
		Public Property ViewType() As ViewType
			Get
				Return Me.fViewType
			End Get
			Set(ByVal value As ViewType)
				If Object.Equals(fViewType, value) Then
					Return
				End If
				Me.fViewType = value
				SeriesTemplate.ChangeView(Me.fViewType)
			End Set
		End Property
		Protected Sub ApplyFilter()
			SeriesTemplate.DataFilters.Clear()
			SeriesTemplate.DataFilters.ConjunctionMode = ConjunctionTypes.And
			If (Not Me.showTotals_Renamed) Then
				Select Case Me.state
					Case DataState.SingleColumn
						AddRowFilter()
					Case DataState.SingleRow
						AddColumnFilter()
					Case Else
						AddColumnFilter()
						AddRowFilter()
				End Select
			End If
			If Me.showSelection_Renamed.GetValueOrDefault() = True Then
				AddSelectionFilter()
			End If
		End Sub
		Private Sub AddRowFilter()
			SeriesTemplate.DataFilters.AddRange(New DataFilter() { New DataFilter(PivotDataExtractor.ColumnNameIsRowTotal, GetType(Boolean).Name, DataFilterCondition.Equal, False), New DataFilter(PivotDataExtractor.ColumnNameIsRowGrandTotal, GetType(Boolean).Name, DataFilterCondition.Equal, False) })
		End Sub
		Private Sub AddColumnFilter()
			SeriesTemplate.DataFilters.AddRange(New DataFilter() { New DataFilter(PivotDataExtractor.ColumnNameIsColumnTotal, GetType(Boolean).Name, DataFilterCondition.Equal, False), New DataFilter(PivotDataExtractor.ColumnNameIsColumnGrandTotal, GetType(Boolean).Name, DataFilterCondition.Equal, False) })
		End Sub
		Private Sub AddSelectionFilter()
			SeriesTemplate.DataFilters.AddRange(New DataFilter() { New DataFilter(PivotDataExtractor.ColumnNameIsSelected, GetType(Boolean).Name, DataFilterCondition.Equal, True) })
		End Sub
		#Region "IXRControlCreatable Members"
		Public Shadows Function CreateControl() As XRControl Implements IXRControlCreatable.CreateControl
			Return XRChartEx.Create(Me)
		End Function
		#End Region
	End Class
End Namespace
