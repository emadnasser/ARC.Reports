Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class TopValues
        Inherits PivotGridDemoModule

        Shared Sub New()
            Dim ownerType As Type = GetType(TopValues)
        End Sub
        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            InitComboBoxes()
            cbField.SelectedIndex = cbField.Items.Count - 1
        End Sub
        Private Sub pivotGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(True, False)
        End Sub
        Private Sub InitComboBoxes()
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Area = FieldArea.RowArea OrElse field.Area = FieldArea.ColumnArea Then
                    cbField.Items.Add(field.Caption)
                End If
            Next field
        End Sub
        Private Sub checkTopValueShowOthers_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetFieldTop()
        End Sub
        Private Sub checkTopValueShowOthers_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetFieldTop()
        End Sub
        Private Sub cbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetFieldTop()
            HideRowAreaFields()
        End Sub
        Private Sub seTopValuesCount_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            SetFieldTop()
            pivotGrid.BestFit(True, False)
        End Sub
        Private Sub SetFieldTop()
            If pivotGrid Is Nothing Then
                Return
            End If
            pivotGrid.BeginUpdate()
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Caption = cbField.SelectedItem.ToString() Then
                    field.Visible = True
                    field.SortOrder = FieldSortOrder.Descending
                    field.SortByField = fieldExtendedPrice
                    field.TopValueCount = Convert.ToInt32(seTopValuesCount.Value)
                    field.TopValueShowOthers = checkTopValueShowOthers.IsChecked.Value
                Else
                    field.TopValueCount = 0
                End If
            Next field
            pivotGrid.EndUpdate()
        End Sub

        Private Sub HideRowAreaFields()
            If pivotGrid Is Nothing Then
                Return
            End If
            pivotGrid.BeginUpdate()
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Caption = cbField.SelectedItem.ToString() Then
                Else
                    If field.Area = FieldArea.ColumnArea OrElse field.Area = FieldArea.RowArea Then
                        field.Visible = False
                    End If
                End If
            Next field
            pivotGrid.EndUpdate()
        End Sub
    End Class
End Namespace
