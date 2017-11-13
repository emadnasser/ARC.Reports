Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class CustomChartData
        Inherits PivotGridDemoModule

        Private Enum RowFieldValueExportRule
            ProductName = 0
            CategoryAndProduct = 1
            CategoryEncoded = 2
        End Enum
        Private Shared Categories() As String = { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood" }

        Private rowFieldValueExportRule_Renamed As RowFieldValueExportRule

        Private Property RowExportRule() As RowFieldValueExportRule
            Get
                Return rowFieldValueExportRule_Renamed
            End Get
            Set(ByVal value As RowFieldValueExportRule)
                rowFieldValueExportRule_Renamed = value
            End Set
        End Property
        Public Sub New()
            InitializeComponent()
            ChartFactory.InitComboBox(cbChartType, New Type() { InitDiagram() })
            RowExportRule = PivotGridDemo.PivotGrid.CustomChartData.RowFieldValueExportRule.ProductName
            pivotGrid.ChartProvideRowFieldValuesAsType = GetType(String)
            cbRowFieldValuesExportRule.Items.AddRange(New String() { "ProductName", "Category/ProductName", "Encoded Product Category" })
            cbRowFieldValuesExportRule.SelectedIndex = 0
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            pivotGrid.MultiSelection.SetSelection(CreateSelectedPoints())
            SetMeasureUnits(DateTimeMeasurementUnit.Year, DateTimeMeasurementUnit.Quarter, DateTimeMeasurementUnit.Month)
            CollapseValues()
        End Sub
        Private Function InitDiagram() As Type
            Dim xyDiagram As New XYDiagram2D()
            xyDiagram.SeriesDataMember = "Series"
            xyDiagram.AxisX = New AxisX2D()
            xyDiagram.AxisX.DateTimeScaleOptions = New ManualDateTimeScaleOptions() With {.MeasureUnit = DateTimeMeasureUnit.Year, .GridAlignment = DateTimeGridAlignment.Year, .AutoGrid = False}
            xyDiagram.AxisX.WholeRange = New DevExpress.Xpf.Charts.Range()
            xyDiagram.AxisY = New AxisY2D()
            xyDiagram.AxisY.WholeRange = New DevExpress.Xpf.Charts.Range()
            xyDiagram.AxisX.Label = New AxisLabel()
            chartControl.Diagram = xyDiagram
            Return chartControl.Diagram.GetType()
        End Function
        Private Function CreateSelectedPoints() As System.Drawing.Point()
            Dim points((pivotGrid.ColumnCount * 12) - 1) As System.Drawing.Point
            For i As Integer = 0 To pivotGrid.ColumnCount - 1
                For j As Integer = 0 To 11
                    points(i + j * pivotGrid.ColumnCount) = New System.Drawing.Point(i, j + 1)
                Next j
            Next i
            Return points
        End Function
        Private Sub SetMeasureUnits(ParamArray ByVal units() As DateTimeMeasurementUnit)
            Dim prevUnit As Object = If(cbChartDateMeasureUnit.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(cbChartDateMeasureUnit.SelectedItem.ToString()), Nothing, System.Enum.Parse(GetType(DateTimeMeasurementUnit), cbChartDateMeasureUnit.SelectedItem.ToString()))
            Dim prevItem As String = ""
            cbChartDateMeasureUnit.Items.Clear()
            For Each unit As DateTimeMeasurementUnit In units
                Dim unitName As String = System.Enum.GetName(GetType(DateTimeMeasurementUnit), unit)
                cbChartDateMeasureUnit.Items.Add(unitName)
                If prevUnit IsNot Nothing AndAlso Object.Equals(unit, DirectCast(prevUnit, DateTimeMeasurementUnit)) Then
                    prevItem = unitName
                End If
            Next unit
            If Not String.IsNullOrEmpty(prevItem) Then
                cbChartDateMeasureUnit.SelectedItem = prevItem
            Else
                cbChartDateMeasureUnit.SelectedIndex = 0
            End If
        End Sub
        Private Sub CollapseValues()
            fieldCategoryName.CollapseAll()
            fieldCategoryName.ExpandValue("Condiments")
        End Sub
        Private Function EncodeCategoryName(ByVal categoryName As String) As Char
            For i As Integer = 0 To Categories.Length - 1
                If Categories(i) = categoryName Then
                    Return Convert.ToChar(Convert.ToInt32("A"c) + i)
                End If
            Next i
            Return "Z"c
        End Function
        Private Sub cbChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim seriesTemplate As Series = ChartFactory.CreateSeriesInstance(CType(CType(cbChartType.SelectedItem, ComboBoxEditItem).Tag, Type))
            seriesTemplate.ArgumentDataMember = "Arguments"
            seriesTemplate.ArgumentScaleType = ScaleType.DateTime
            seriesTemplate.ValueDataMember = "Values"
            If seriesTemplate.Label Is Nothing Then
                seriesTemplate.Label = New SeriesLabel()
            End If
            seriesTemplate.LabelsVisibility = ceShowPointsLabels.IsChecked.HasValue AndAlso ceShowPointsLabels.IsChecked.Value
            seriesTemplate.LegendTextPattern = "{A}: {V:G}"
            chartControl.Diagram.SeriesTemplate = seriesTemplate
        End Sub
        Private Sub ceShowPointsLabels_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chartControl.Diagram.SeriesTemplate.LabelsVisibility = ceShowPointsLabels.IsChecked.HasValue AndAlso ceShowPointsLabels.IsChecked.Value
        End Sub
        Private Sub cbChartDateMeasureUnit_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim diagram As XYDiagram2D = CType(chartControl.Diagram, XYDiagram2D)
            Dim unit As DateTimeMeasureUnit = DirectCast(System.Enum.Parse(GetType(DateTimeMeasureUnit), cbChartDateMeasureUnit.SelectedItem.ToString()), DateTimeMeasureUnit)
            diagram.AxisX.DateTimeScaleOptions = New ManualDateTimeScaleOptions() With {.MeasureUnit = unit, .GridAlignment = CType(unit, DateTimeGridAlignment), .AutoGrid = False}
            Select Case unit
                Case DateTimeMeasureUnit.Year
                    diagram.AxisX.Label.TextPattern = "{A:yyyy}"
                Case DateTimeMeasureUnit.Quarter
                    diagram.AxisX.Label.TextPattern = "{A:q}"
                Case DateTimeMeasureUnit.Month
                    diagram.AxisX.Label.TextPattern = "{A:y}"
                Case Else
            End Select
        End Sub
        Private Sub pivotGrid_FieldExpandedInGroupChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
            If Not fieldYear.ExpandedInFieldsGroup Then
                SetMeasureUnits(DateTimeMeasurementUnit.Year)
                Return
            End If
            If Not fieldQuarter.ExpandedInFieldsGroup Then
                SetMeasureUnits(DateTimeMeasurementUnit.Year, DateTimeMeasurementUnit.Quarter)
                Return
            End If
            SetMeasureUnits(DateTimeMeasurementUnit.Year, DateTimeMeasurementUnit.Quarter, DateTimeMeasurementUnit.Month)
        End Sub
        Private Sub cbRowFieldValuesExportRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RowExportRule = CType(cbRowFieldValuesExportRule.SelectedIndex, RowFieldValueExportRule)
            pivotGrid.ChartProvideRowFieldValuesAsType = If(RowExportRule = PivotGridDemo.PivotGrid.CustomChartData.RowFieldValueExportRule.CategoryEncoded, GetType(Char), GetType(String))
            pivotGrid.RefreshData()
        End Sub
        Private Sub pivotGrid_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs)
            If e.ItemType = PivotChartItemType.CellItem Then
                If e.Value Is DBNull.Value OrElse CDec(e.Value) < Convert.ToDecimal(seCellZeroValueThreshold.Value) Then
                    e.Value = 0
                End If
            End If
            If e.ItemType = PivotChartItemType.RowItem Then
                Dim isCategoryNameField As Boolean = Object.Equals(e.FieldValueInfo.Field, fieldCategoryName)
                Select Case RowExportRule
                    Case PivotGridDemo.PivotGrid.CustomChartData.RowFieldValueExportRule.ProductName
                        e.Value = If(isCategoryNameField, e.FieldValueInfo.Value.ToString() & " Category", e.FieldValueInfo.Value)
                    Case PivotGridDemo.PivotGrid.CustomChartData.RowFieldValueExportRule.CategoryAndProduct
                        e.Value = If(isCategoryNameField, e.FieldValueInfo.Value.ToString() & "/"c & "Total", e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString() & "/"c & e.FieldValueInfo.Value.ToString())
                    Case PivotGridDemo.PivotGrid.CustomChartData.RowFieldValueExportRule.CategoryEncoded
                        Dim categoryName As String = If(isCategoryNameField, e.FieldValueInfo.Value.ToString(), e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString())
                        e.Value = EncodeCategoryName(categoryName)
                End Select
            End If
        End Sub
        Private Sub seCellZeroValueThreshold_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            pivotGrid.RefreshData()
        End Sub
    End Class
End Namespace
