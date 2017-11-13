Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.DemoData.Models
Imports System.Linq

Namespace PivotGridDemo.PivotGrid
    Partial Public Class ChartsIntegration
        Inherits PivotGridDemoModule

        Private Shared ReadOnly ProductFilterValues() As String = {"Chai", "Chang", "Chocolade", "Filo Mix", "Geitost", "Ikura", "Konbu", "Maxilaku", "Pavlova", "Spegesild", "Tofu", "Tourtière"}
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChartFactory.InitComboBox(cbChartType, Nothing)
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            SetFilter()
            SetSelection()
        End Sub
        Private Sub SetFilter()
            fieldProductName.FilterValues.ValuesIncluded = ProductFilterValues
            fieldOrderYear.FilterValues.SetValues(New Object() { fieldOrderYear.GetUniqueValues()(0) }, FieldFilterType.Included, True)
        End Sub
        Private Sub SetSelection()
            pivotGrid.SetSelectionByFieldValues(False, New Object() { "Chai" })
            pivotGrid.SetSelectionByFieldValues(False, New Object() { "Chocolade" })
        End Sub
        Private Sub cbChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If cbChartType.SelectedIndex < 0 Then
                Return
            End If
            chartControl.Diagram = ChartFactory.GenerateDiagram(CType(CType(cbChartType.SelectedItem, ComboBoxEditItem).Tag, Type), ceShowPointsLabels.IsChecked)
            pivotGrid.ChartProvideEmptyCells = IsProvideEmptyCells()
        End Sub
        Private Sub ceShowPointsLabels_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chartControl.Diagram.SeriesTemplate.LabelsVisibility = Object.Equals(ceShowPointsLabels.IsChecked, True)
            chartControl.CrosshairEnabled = Object.Equals(ceShowPointsLabels.IsChecked, False)
        End Sub

        Private Sub oncrChartDataVerticalSelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.ChartProvideDataByColumns = crChartDataVertical.SelectedIndex = 1
        End Sub

        Private Sub chartControl_BoundDataChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If TypeOf chartControl.Diagram Is SimpleDiagram2D Then
                ConfigurePie()
            End If
            If TypeOf chartControl.Diagram Is SimpleDiagram3D Then
                ConfigurePie()
            End If
            CheckWarningVisivility()
        End Sub

        Private Sub ConfigurePie()
            Dim counts As New Dictionary(Of PieSeries, Integer)()
            For Each series As PieSeries In chartControl.Diagram.Series
                counts.Add(series, GetPointsCount(series))
                series.Titles.Add(New Title() With {.Content = series.DisplayName, .Dock = Dock.Bottom, .HorizontalAlignment = System.Windows.HorizontalAlignment.Center, .FontSize = 12, .VerticalAlignment = System.Windows.VerticalAlignment.Center})
                series.ShowInLegend = False
            Next series

            Dim max As Integer = 0
            Dim maxSeries As PieSeries = Nothing
            For Each pair As KeyValuePair(Of PieSeries, Integer) In counts
                If max < pair.Value Then
                    max = pair.Value
                    maxSeries = pair.Key
                End If
            Next pair

            If maxSeries Is Nothing Then
                Return
            End If
            Dim values As New List(Of String)()
            For Each point As SeriesPoint In maxSeries.Points
                values.Add(point.Argument)
            Next point

            maxSeries.ShowInLegend = True

            If TypeOf chartControl.Diagram Is SimpleDiagram2D Then
                For Each series As PieSeries In chartControl.Diagram.Series
                    For Each point As SeriesPoint In maxSeries.Points
                        If Not values.Contains(point.Argument) Then
                            series.ShowInLegend = True
                            values.Add(point.Argument)
                        End If
                    Next point
                Next series
            End If
        End Sub

        Private Function GetPointsCount(ByVal series As PieSeries) As Integer
            Dim count As Integer = 0
            For i As Integer = 0 To series.Points.Count - 1
                If Not Double.IsNaN(series.Points(i).Value) Then
                    count += 1
                End If
            Next i
            Return count
        End Function

        Private Sub CheckWarningVisivility()
            Dim cellInfo As PivotCellBaseEventArgs
            Dim showWarning As Boolean = False
            If pivotGrid.MultiSelection.SelectedCells.Count = 0 Then
                cellInfo = pivotGrid.GetCellInfo(pivotGrid.FocusedCell.X, pivotGrid.FocusedCell.Y)
                showWarning = (cellInfo.ColumnValueType = FieldValueType.GrandTotal AndAlso (Not pivotGrid.ChartProvideColumnGrandTotals)) OrElse (cellInfo.RowValueType = FieldValueType.GrandTotal AndAlso (Not pivotGrid.ChartProvideRowGrandTotals))
            Else
                For Each cell As System.Drawing.Point In pivotGrid.MultiSelection.SelectedCells
                    cellInfo = pivotGrid.GetCellInfo(cell.X, cell.Y)
                    If (cellInfo.ColumnValueType = FieldValueType.GrandTotal AndAlso (Not pivotGrid.ChartProvideColumnGrandTotals)) OrElse (cellInfo.RowValueType = FieldValueType.GrandTotal AndAlso (Not pivotGrid.ChartProvideRowGrandTotals)) Then
                        showWarning = True
                    Else
                        showWarning = False
                        Exit For
                    End If
                Next cell
            End If
            warningChart.Visibility = If(showWarning, Visibility.Visible, Visibility.Collapsed)
        End Sub
        Private Function IsProvideEmptyCells() As Boolean
            If (TypeOf chartControl.Diagram Is SimpleDiagram2D) OrElse (TypeOf chartControl.Diagram Is SimpleDiagram3D) Then
                Return True
            End If
            Return False
        End Function
        Private Sub pivotGrid_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs)
            If IsProvideEmptyCells() Then
                If e.ItemDataMember = PivotChartItemDataMember.Value AndAlso e.Value Is DBNull.Value Then
                    e.Value = 0
                End If
            End If
        End Sub
    End Class
    Friend NotInheritable Class ChartFactory

        Private Sub New()
        End Sub

        Private Shared ReadOnly XYDiagram2DType As Type = GetType(XYDiagram2D)
        Private Shared ReadOnly XYDiagram3DType As Type = GetType(XYDiagram3D)
        Private Shared ReadOnly SimpleDiagram3DType As Type = GetType(SimpleDiagram3D)
        Private Shared ReadOnly SimpleDiagram2DType As Type = GetType(SimpleDiagram2D)
        Private Shared ReadOnly DefaultSeriesType As Type = GetType(BarStackedSeries2D)


        Private Shared seriesTypes_Renamed As Dictionary(Of Type, SeriesTypeDescriptor)
        Public Shared ReadOnly Property SeriesTypes() As Dictionary(Of Type, SeriesTypeDescriptor)
            Get
                If seriesTypes_Renamed Is Nothing Then
                    seriesTypes_Renamed = CreateSeriesTypes()
                End If
                Return seriesTypes_Renamed
            End Get
        End Property
        Private Shared Function CreateSeriesTypes() As Dictionary(Of Type, SeriesTypeDescriptor)

            Dim seriesTypes_Renamed As New Dictionary(Of Type, SeriesTypeDescriptor)()
            seriesTypes_Renamed.Add(GetType(AreaFullStackedSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText = "Area Full-Stacked Series 2D"})
            seriesTypes_Renamed.Add(GetType(AreaSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText="Area Series 2D"})
            seriesTypes_Renamed.Add(GetType(AreaStackedSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText="Area Stacked Series 2D"})
            seriesTypes_Renamed.Add(GetType(BarFullStackedSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText="Bar Full-Stacked Series 2D"})
            seriesTypes_Renamed.Add(GetType(BarStackedSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText="Bar Stacked Series 2D"})
            seriesTypes_Renamed.Add(GetType(LineSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText="Line Series 2D"})
            seriesTypes_Renamed.Add(GetType(PointSeries2D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram2DType, .DisplayText = "Point Series 2D"})
            seriesTypes_Renamed.Add(GetType(AreaSeries3D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram3DType, .DisplayText="Area Series 3D"})
            seriesTypes_Renamed.Add(GetType(AreaStackedSeries3D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram3DType, .DisplayText="Area Stacked Series 3D"})
            seriesTypes_Renamed.Add(GetType(AreaFullStackedSeries3D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram3DType, .DisplayText="Area Full-Stacked Series 3D"})
            seriesTypes_Renamed.Add(GetType(BarSeries3D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram3DType, .DisplayText="Bar Series 3D"})
            seriesTypes_Renamed.Add(GetType(PointSeries3D), New SeriesTypeDescriptor With {.DiagramType = XYDiagram3DType, .DisplayText="Point Series 3D"})
            seriesTypes_Renamed.Add(GetType(PieSeries3D), New SeriesTypeDescriptor With {.DiagramType = SimpleDiagram3DType, .DisplayText="Pie Series 3D"})
            seriesTypes_Renamed.Add(GetType(PieSeries2D), New SeriesTypeDescriptor With {.DiagramType = SimpleDiagram2DType, .DisplayText = "Pie Series 2D"})
            Return seriesTypes_Renamed
        End Function

        Public Class SeriesTypeDescriptor
            Public Property DiagramType() As Type
            Public Property DisplayText() As String
        End Class

        Public Shared Function CompareComboItemsByStringContent(ByVal first As ComboBoxEditItem, ByVal second As ComboBoxEditItem) As Integer
            Dim firstStr As String = TryCast(first.Content, String)
            Return If(firstStr Is Nothing, -1, firstStr.CompareTo(TryCast(second.Content, String)))
        End Function
        Public Shared Sub InitComboBox(ByVal comboBox As ComboBoxEdit, ByVal diagramFilter() As Type)
            Dim itemsList As New List(Of ComboBoxEditItem)()
            Dim item As ComboBoxEditItem, selectedItem As ComboBoxEditItem = Nothing
            For Each seriesType As Type In SeriesTypes.Keys
                Dim sd As SeriesTypeDescriptor = SeriesTypes(seriesType)
                If diagramFilter Is Nothing OrElse Array.IndexOf(diagramFilter, sd.DiagramType) >= 0 Then
                    item = New ComboBoxEditItem()
                    item.Content = sd.DisplayText
                    item.Tag = seriesType
                    itemsList.Add(item)
                    If Object.Equals(seriesType, DefaultSeriesType) Then
                        selectedItem = item
                    End If
                End If
            Next seriesType
            itemsList.Sort(AddressOf CompareComboItemsByStringContent)
            comboBox.Items.AddRange(itemsList.ToArray())
            comboBox.SelectedItem = selectedItem
        End Sub
        Public Shared Function GenerateDiagram(ByVal seriesType As Type, ByVal showPointsLabels? As Boolean) As Diagram
            Dim seriesTemplate As Series = CreateSeriesInstance(seriesType)
            Dim diagram As Diagram = CreateDiagramBySeriesType(seriesType)
            If TypeOf diagram Is XYDiagram2D Then
                PrepareXYDiagram2D(TryCast(diagram, XYDiagram2D))
            End If
            If TypeOf diagram Is XYDiagram3D Then
                PrepareXYDiagram3D(TryCast(diagram, XYDiagram3D))
            End If
            If TypeOf diagram Is Diagram3D Then
                CType(diagram, Diagram3D).RuntimeRotation = True
            End If
            diagram.SeriesDataMember = "Series"
            seriesTemplate.ArgumentDataMember = "Arguments"
            seriesTemplate.ValueDataMember = "Values"
            If seriesTemplate.Label Is Nothing Then
                seriesTemplate.Label = New SeriesLabel()
            End If
            seriesTemplate.LabelsVisibility = CBool(showPointsLabels) = True
            If TypeOf seriesTemplate Is PieSeries2D OrElse TypeOf seriesTemplate Is PieSeries3D Then
                seriesTemplate.LegendTextPattern = "{A}"
                seriesTemplate.Label.TextPattern = "{A}: {VP:P0}"
            Else
                seriesTemplate.LegendTextPattern = "{A}: {V:G}"
                seriesTemplate.ShowInLegend = True
            End If
            diagram.SeriesTemplate = seriesTemplate
            Return diagram
        End Function
        Private Shared Sub PrepareXYDiagram2D(ByVal diagram As XYDiagram2D)
            If diagram Is Nothing Then
                Return
            End If
            diagram.AxisX = New AxisX2D()
            diagram.AxisX.Label = New AxisLabel()
            diagram.AxisX.Label.Staggered = True
        End Sub
        Private Shared Sub PrepareXYDiagram3D(ByVal diagram As XYDiagram3D)
            If diagram Is Nothing Then
                Return
            End If
            diagram.AxisX = New AxisX3D()
            diagram.AxisX.Label = New AxisLabel()
            diagram.AxisX.Label.Visible = False
        End Sub
        Public Shared Function CreateSeriesInstance(ByVal seriesType As Type) As Series
            Dim series As Series = DirectCast(Activator.CreateInstance(seriesType), Series)
            Dim supportTransparency As ISupportTransparency = TryCast(series, ISupportTransparency)
            If supportTransparency IsNot Nothing Then
                Dim flag As Boolean = TypeOf series Is AreaSeries2D
                flag = flag OrElse TypeOf series Is AreaSeries3D
                If flag Then
                    supportTransparency.Transparency = 0.4
                Else
                    supportTransparency.Transparency = 0
                End If
            End If
            Return series
        End Function
        Private Shared Function CreateDiagramBySeriesType(ByVal seriesType As Type) As Diagram
            Return DirectCast(Activator.CreateInstance(SeriesTypes(seriesType).DiagramType), Diagram)
        End Function
    End Class
End Namespace
