Imports System.Windows
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class FilterPopup
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub

        Private Sub OnPivotGridLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetGroupFilter()
            SetFilter()
        End Sub

        Private Sub SetGroupFilter()
            If PivotGridGroup1 Is Nothing OrElse (Not PivotGridGroup1.FilterValues.IsEmpty) Then
                Return
            End If
            PivotGridGroup1.FilterValues.BeginUpdate()
            PivotGridGroup1.FilterValues.FilterType = FieldFilterType.Included
            PivotGridGroup1.FilterValues.Values.Add("Beverages")
            PivotGridGroup1.FilterValues.EndUpdate()
            If PivotGridGroup2 Is Nothing OrElse (Not PivotGridGroup2.FilterValues.IsEmpty) Then
                Return
            End If
            PivotGridGroup2.FilterValues.BeginUpdate()
            PivotGridGroup2.FilterValues.FilterType = FieldFilterType.Included
            Dim values() As Object = fieldYear.GetUniqueValues()
            PivotGridGroup2.FilterValues.Values.Add(values(0)).ChildValues.Add(3)
            PivotGridGroup2.FilterValues.Values(values(0)).ChildValues(3).ChildValues.Add(9)
            PivotGridGroup2.FilterValues.Values.Add(values(1)).ChildValues.Add(1)
            PivotGridGroup2.FilterValues.Values(values(1)).ChildValues.Add(4)
            PivotGridGroup2.FilterValues.EndUpdate()
        End Sub

        Private Sub SetFilter()
            fieldCategory.FilterValues.FilterType = FieldFilterType.Included
            fieldCategory.FilterValues.Add("Beverages")
        End Sub
    End Class
End Namespace
