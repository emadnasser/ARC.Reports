Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.Utils
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class IntervalGrouping
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            InitComboBoxes()
            ceProductInterval.IsChecked = True
        End Sub
        Private Sub InitComboBoxes()
            Dim arr As Array = EnumExtensions.GetValues(GetType(FieldGroupInterval))
            For Each interval As FieldGroupInterval In arr
                If interval.ToString().IndexOf("Date") = 0 Then
                    cbGroupInterval.Items.Add(New ComboBoxEditItem() With {.Content = interval.ToString(), .Tag = interval})
                End If
            Next interval
            cbGroupInterval.SelectedIndex = cbGroupInterval.Items.Count - 1
        End Sub
        Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If Object.ReferenceEquals(e.Field, fieldOrderDate) AndAlso e.Field.GroupInterval = FieldGroupInterval.DateQuarter Then
                e.DisplayText = String.Format("Qtr {0}", e.Value)
                If e.ValueType = FieldValueType.Total Then
                    e.DisplayText &= " Total"
                End If
            End If
        End Sub
        Private Sub cbGroupInterval_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If cbGroupInterval.SelectedIndex < 0 Then
                Return
            End If
            fieldOrderDate.FilterValues.Clear()
            fieldOrderDate.GroupInterval = CType(CType(cbGroupInterval.SelectedItem, ComboBoxEditItem).Tag, FieldGroupInterval)
            fieldOrderDate.Caption = String.Format("Order Date ({0})", fieldOrderDate.GroupInterval.ToString().Replace("Date", ""))
        End Sub
    End Class
End Namespace
