Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Xpf.Core
Imports System.Windows.Controls
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class KPIDashboard
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().ProductReports.ToList()
            SalesTarget = GetSalesTarget()
            UpdateKPIs()
        End Sub

        Private privateSalesTarget As Double
        Protected Property SalesTarget() As Double
            Get
                Return privateSalesTarget
            End Get
            Private Set(ByVal value As Double)
                privateSalesTarget = value
            End Set
        End Property

        Private Sub pivotGrid_GridLayout(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateKPIs()
        End Sub

        Private Sub UpdateKPIs()
            If avgTransGauge Is Nothing Then
                Return
            End If

            Dim avgTrans As Double = GetAverageTransaction()
            avgTransGauge.Min = If(avgTrans < 400, avgTrans - 100, 400)
            avgTransGauge.Max = (If(avgTrans > 800, (Math.Ceiling(avgTrans / 100) + 1) * 100, 800))
            avgTransGauge.Value = avgTrans

            Dim salesToLastYear As Double = GetSalesToLastYear()
            If salesToLastYear < 0 Then
                salesToLastYearGauge.Visibility = Visibility.Collapsed
                salesToLastYearNA.Visibility = Visibility.Visible
            Else
                salesToLastYearGauge.Visibility = Visibility.Visible
                salesToLastYearNA.Visibility = Visibility.Collapsed
                salesToLastYearGauge.Min = If(salesToLastYear < 1, 0, 1)
                salesToLastYearGauge.Max = If(salesToLastYear < 1, 1, (If(salesToLastYear > 2, Math.Ceiling(salesToLastYear) + 1, 2)))
                salesToLastYearGauge.Value = salesToLastYear
            End If

            Dim salesToTarget As Double = GetSalesToTarget()
            salesToTargetGauge.Min = If(salesToTarget < 1, 0, 1)
            salesToTargetGauge.Max = If(salesToTarget < 1, 1, (If(salesToTarget > 2, Math.Ceiling(salesToTarget) + 1, 2)))
            salesToTargetGauge.Value = salesToTarget
        End Sub

        Private Function GetAverageTransaction() As Double
            Dim ds As PivotDrillDownDataSource = pivotGrid.CreateDrillDownDataSource()
            If ds.RowCount = 0 Then
                Return 0
            End If
            Dim transactionSum As Double = 0
            For i As Integer = 0 To ds.RowCount - 1
                transactionSum += Convert.ToDouble(ds(i)("ProductSales"))
            Next i
            Return transactionSum / ds.RowCount
        End Function

        Private Function GetSalesToLastYear() As Double
            If fieldYear.FilterValues.ValuesIncluded.Count() <> 2 OrElse pivotGrid.GetFieldCountByArea(FieldArea.DataArea) <> 1 Then
                Return -1
            End If
            Dim years() As Object = fieldYear.FilterValues.ValuesIncluded
            Array.Sort(years)
            Dim thisYear As Double = Convert.ToDouble(pivotGrid.GetCellValue(New Object() { years(1) }, Nothing)), lastYear As Double = Convert.ToDouble(pivotGrid.GetCellValue(New Object() { years(0) }, Nothing))
            Return If(lastYear <> 0, thisYear / lastYear, 1)
        End Function

        Private Function GetSalesTarget() As Double
            If Not fieldYear.FilterValues.IsEmpty Then
                Throw New ArgumentException("!fieldYear.FilterValues.IsEmpty")
            End If
            Dim years() As Object = fieldYear.GetUniqueValues()
            Array.Sort(years)
            Dim year0Sales As Double = Convert.ToDouble(pivotGrid.GetCellValue(New Object() { years(0) }, Nothing))
            If year0Sales = 0 Then
                Throw New ArgumentException("no sales")
            End If
            Return year0Sales * Convert.ToDouble(Math.Pow(1.3, years.Length))
        End Function

        Private Function GetSalesToTarget() As Double
            If pivotGrid.GetFieldCountByArea(FieldArea.DataArea) <> 1 Then
                Return 1
            End If
            Dim sales As Double = Convert.ToDouble(pivotGrid.GetCellValue(New Object(){}, New Object(){}))
            Return If(SalesTarget <> 0, sales / SalesTarget, 1)
        End Function

        Private Sub ResetField(ByVal field As PivotGridField, ByVal area As FieldArea, ByVal areaIndex As Integer)
            field.Area = area
            field.AreaIndex = areaIndex
            field.FilterValues.Clear()
            field.FilterValues.FilterType = FieldFilterType.Excluded
        End Sub

        Private Sub Reset()
            If pivotGrid Is Nothing Then
                Return
            End If
            pivotGrid.BeginUpdate()
            ResetField(fieldCategory, FieldArea.RowArea, 0)
            ResetField(fieldProduct, FieldArea.RowArea, 1)
            ResetField(fieldSales, FieldArea.DataArea, 0)
            ResetField(fieldYear, FieldArea.ColumnArea, 0)
            ResetField(fieldQuarter, FieldArea.ColumnArea, 1)
            pivotGrid.EndUpdate()
        End Sub

        Private Sub ListBoxEdit_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Select Case dashboardList.SelectedIndex
                Case 0
                    Reset()
                    pivotGrid.ExpandAll()
                Case 1
                    pivotGrid.BeginUpdate()
                    Reset()
                    fieldYear.FilterValues.ValuesIncluded = New Object() { fieldYear.GetUniqueValues()(0), fieldYear.GetUniqueValues()(1) }
                    pivotGrid.EndUpdate()
                    pivotGrid.ExpandAllRows()
                    pivotGrid.CollapseAllColumns()
                Case 2
                    pivotGrid.BeginUpdate()
                    Reset()
                    fieldCategory.FilterValues.ValuesIncluded = New Object() { "Beverages", "Condiments" }
                    pivotGrid.EndUpdate()
                    pivotGrid.ExpandAllColumns()
                    pivotGrid.CollapseAllRows()
            End Select
        End Sub
    End Class
    Public Class SimpleGaugeControl
        Inherits Control

        Public Shared MinProperty As DependencyProperty
        Public Shared MaxProperty As DependencyProperty
        Public Shared ValueProperty As DependencyProperty
        Public Shared ValueStringFormatProperty As DependencyProperty
        Shared Sub New()
            Dim ownerType As Type = GetType(SimpleGaugeControl)
            MinProperty = DependencyProperty.Register("Min", GetType(Double), ownerType, New PropertyMetadata(0R))
            MaxProperty = DependencyProperty.Register("Max", GetType(Double), ownerType, New PropertyMetadata(10R))
            ValueProperty = DependencyProperty.Register("Value", GetType(Double), ownerType, New PropertyMetadata(3R, AddressOf UpdateDisplayText))
            ValueStringFormatProperty = DependencyProperty.Register("ValueStringFormat", GetType(String), ownerType, New PropertyMetadata(String.Empty, AddressOf UpdateDisplayText))
        End Sub
        Private Shared Sub UpdateDisplayText(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, SimpleGaugeControl).UpdateDisplayText()
        End Sub
        Private textControl As ContentControl
        Public Sub New()
            Me.SetDefaultStyleKey(GetType(SimpleGaugeControl))
        End Sub
        Public Property Value() As Double
            Get
                Return DirectCast(GetValue(ValueProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(ValueProperty, value)
            End Set
        End Property
        Public Property Min() As Double
            Get
                Return DirectCast(GetValue(MinProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(MinProperty, value)
            End Set
        End Property
        Public Property Max() As Double
            Get
                Return DirectCast(GetValue(MaxProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(MaxProperty, value)
            End Set
        End Property
        Public Property ValueStringFormat() As String
            Get
                Return DirectCast(GetValue(ValueStringFormatProperty), String)
            End Get
            Set(ByVal value As String)
                SetValue(ValueStringFormatProperty, value)
            End Set
        End Property
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            textControl = TryCast(GetTemplateChild("PART_Text"), ContentControl)
            UpdateDisplayText()
        End Sub
        Private Sub UpdateDisplayText()
            If textControl Is Nothing Then
                Return
            End If
            Dim format As String = If((Not String.IsNullOrEmpty(ValueStringFormat)), "{0:" & ValueStringFormat & "}", "{0}")
            textControl.Content = String.Format(format, Value)
        End Sub
    End Class
End Namespace
