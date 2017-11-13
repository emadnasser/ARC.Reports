Imports System.Windows
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Core
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class CustomerReports
        Inherits PivotGridDemoModule

        Private Const allString As String = "(All)"

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().CustomerReports.ToList()
            ResetValues()
        End Sub
        Private Sub ListBoxEdit_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BeginUpdate()
            Select Case reportsList.SelectedIndex
                Case 0
                    ResetValues()
                Case 1
                    SetYearFilter()
                Case 2
                    SetTopProducts()
                Case 3
                    SetTopCustomers()
            End Select
            pivotGrid.EndUpdateAsync()
        End Sub
        Private Sub cbeYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateYearFilter()
        End Sub
        Private Sub cbeQuarter_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateQuarterFilter()
        End Sub

        Private Sub SetTopCustomers()
            ResetValues()
            fieldProductName.Area = FieldArea.FilterArea
            fieldQuarter.Area = FieldArea.FilterArea
            fieldYear.Area = fieldQuarter.Area
            fieldCompanyName.SortByField = fieldProductAmount
            fieldCompanyName.SortOrder = FieldSortOrder.Descending
            fieldCompanyName.TopValueCount = 10
        End Sub
        Private Sub SetTopProducts()
            ResetValues()
            fieldQuarter.Area = FieldArea.FilterArea
            fieldYear.Area = fieldQuarter.Area
            fieldProductName.SortByField = fieldProductAmount
            fieldProductName.SortOrder = FieldSortOrder.Descending
            fieldProductName.TopValueCount = 2
        End Sub
        Private Sub SetYearFilter()
            ResetValues()
            If cbeYear.Items.Count = 0 Then
                cbeQuarter.Items.Add(allString)
                For Each obj As Object In fieldYear.GetUniqueValues()
                    cbeYear.Items.Add(obj)
                Next obj
                cbeYear.SelectedItem = cbeYear.Items(0)
                For Each obj As Object In fieldQuarter.GetUniqueValues()
                    cbeQuarter.Items.Add(obj)
                Next obj
                cbeQuarter.SelectedItem = cbeQuarter.Items(0)
                cbeYear.SelectedItem = cbeYear.Items(0)
            End If
            gbxFiltering.Visibility = System.Windows.Visibility.Visible
            UpdateYearFilter()
            UpdateQuarterFilter()
        End Sub
        Private Sub ResetValues()
            If gbxFiltering IsNot Nothing Then
            gbxFiltering.Visibility = System.Windows.Visibility.Collapsed
            End If
            If fieldQuarter IsNot Nothing Then
                fieldQuarter.FilterValues.Clear()
                fieldQuarter.FilterValues.FilterType = FieldFilterType.Excluded
                fieldQuarter.Area = FieldArea.ColumnArea
            End If
            If fieldYear IsNot Nothing Then
                fieldYear.FilterValues.Clear()
                fieldYear.FilterValues.FilterType = FieldFilterType.Excluded
                fieldYear.Area = FieldArea.ColumnArea
                fieldYear.AreaIndex = 0
            End If
            If fieldProductName IsNot Nothing Then
                fieldProductName.SortOrder = FieldSortOrder.Ascending
                fieldProductName.SortByField = Nothing
                fieldProductName.TopValueCount = 0
                fieldProductName.Area = FieldArea.RowArea
                fieldProductName.AreaIndex = 1
            End If
            If fieldCompanyName IsNot Nothing Then
                fieldCompanyName.SortByField = Nothing
                fieldCompanyName.TopValueCount = 0
                fieldCompanyName.SortOrder = FieldSortOrder.Ascending
            End If
        End Sub
        Private Sub UpdateYearFilter()
            fieldYear.FilterValues.FilterType = FieldFilterType.Included
            fieldYear.FilterValues.Clear()
            fieldYear.FilterValues.Add(cbeYear.SelectedItem)
        End Sub
        Private Sub UpdateQuarterFilter()
            fieldQuarter.FilterValues.Clear()
            fieldQuarter.FilterValues.FilterType = FieldFilterType.Excluded
            If cbeQuarter.SelectedIndex = 0 Then
                Return
            End If
            fieldQuarter.FilterValues.FilterType = FieldFilterType.Included
            fieldQuarter.FilterValues.Add(cbeQuarter.SelectedItem)
        End Sub
    End Class
End Namespace
