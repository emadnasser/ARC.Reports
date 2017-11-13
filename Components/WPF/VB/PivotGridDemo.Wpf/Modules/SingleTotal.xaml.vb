Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Windows.Markup
Imports System.Windows.Controls
Imports DevExpress.Utils
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class SingleTotal
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.BeginUpdate()
            pivotGrid.AllowCrossGroupVariation = False
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            fieldYear.FilterValues.FilterType = FieldFilterType.Included
            Dim values() As Object = fieldYear.GetUniqueValues()
            fieldYear.FilterValues.Add(values(0))
            fieldYear.FilterValues.Add(values(1))
            fieldCategory.FilterValues.FilterType = FieldFilterType.Included
            fieldCategory.FilterValues.Add("Beverages")
            fieldCategory.FilterValues.Add("Condiments")
            pivotGrid.EndUpdate()
            InitComboBoxes()
        End Sub
        Private Sub pivotGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(FieldArea.ColumnArea, True, False)
        End Sub
        Private Sub InitComboBoxes()
            Dim arr As Array = EnumExtensions.GetValues(GetType(FieldSummaryType))
            For Each type As FieldSummaryType In arr
                cbSummaryType.Items.Add(type)
            Next type
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Area = FieldArea.DataArea AndAlso field.Visible Then
                    cbField.Items.Add(field.Caption)
                End If
            Next field
            cbField.SelectedIndex = 0
        End Sub
        Private Sub cbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Caption = cbField.SelectedItem.ToString() Then
                    cbSummaryType.SelectedIndex = cbSummaryType.Items.IndexOf(field.SummaryType)
                End If
            Next field
        End Sub
        Private Sub cbSummaryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each field As PivotGridField In pivotGrid.Fields
                If field.Caption = cbField.SelectedItem.ToString() Then
                    field.SummaryType = CType(cbSummaryType.SelectedItem, FieldSummaryType)
                End If
            Next field
        End Sub

        Private Sub OnPivotGridCustomSummary(ByVal sender As Object, ByVal e As PivotCustomSummaryEventArgs)
            e.CustomValue = e.SummaryValue.Summary
        End Sub
    End Class

End Namespace
