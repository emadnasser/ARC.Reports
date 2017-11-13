Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class SortBySummary
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BeginUpdate()
            fieldYear.FilterValues.FilterType = FieldFilterType.Included
            fieldYear.FilterValues.Add(fieldYear.GetUniqueValues()(0))
            pivotGrid.EndUpdate()
        End Sub
        Private Sub pivotGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(FieldArea.ColumnArea, True, False)
            InitComboBoxes()
        End Sub
        Private Sub InitComboBoxes()
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Area = FieldArea.DataArea Then
                    cbField.Items.Add(New ComboBoxEditItem() With {.Content = field.Caption.ToString(), .Tag = field})
                    If Object.ReferenceEquals(field, fieldSalesPerson.SortByField) Then
                        cbField.SelectedItem = cbField.Items(cbField.Items.Count - 1)
                    End If
                End If
            Next field
            cbField.SelectedIndex = 0
        End Sub
        Private Sub cbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If cbField.SelectedIndex < 0 Then
                Return
            End If
            fieldSalesPerson.SortByField = CType(CType(cbField.SelectedItem, ComboBoxEditItem).Tag, PivotGridField)
        End Sub
    End Class
End Namespace
