Imports System
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports System.Linq
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class SortByColumn
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BeginUpdate()
            Dim value As Object = fieldYear.GetUniqueValues()(0)
            fieldYear.FilterValues.ValuesIncluded = New Object() { value }
            If fieldSalesPerson.SortByConditions.Count < 1 Then
                fieldSalesPerson.SortByConditions.Add(New SortByCondition(fieldYear, value))
                fieldSalesPerson.SortByConditions.Add(New SortByCondition(fieldMonth, 8))
            End If
            pivotGrid.EndUpdate()
        End Sub
        Private Sub pivotGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(FieldArea.ColumnArea, True, False)
        End Sub
    End Class
End Namespace
