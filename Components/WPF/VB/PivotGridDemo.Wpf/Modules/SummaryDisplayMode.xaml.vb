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
    Partial Public Class SummaryDisplayMode
        Inherits PivotGridDemoModule

        Shared Sub New()
            Dim ownerType As Type = GetType(SummaryDisplayMode)
        End Sub
        Public Sub New()
            InitializeComponent()
            InitComboBox()
            pivotGrid.AllowCrossGroupVariation = False
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
        Private Sub InitComboBox()
            Dim arr As Array = EnumExtensions.GetValues(GetType(FieldSummaryDisplayType))
            For Each type As FieldSummaryDisplayType In arr
                cbSummaryDisplayType.Items.Add(type.ToString())
            Next type
            cbSummaryDisplayType.SelectedIndex = 1
        End Sub
        Private Sub checkAllowCrossGroupVariation_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.AllowCrossGroupVariation = True
        End Sub
        Private Sub checkAllowCrossGroupVariation_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.AllowCrossGroupVariation = False
        End Sub
        Private Sub checkHideEmptyVariationItems_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            fieldQuantity1.HideEmptyVariationItems = True
        End Sub
        Private Sub checkHideEmptyVariationItems_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            fieldQuantity1.HideEmptyVariationItems = False
        End Sub
        Private Sub cbSummaryDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim value As String = cbSummaryDisplayType.SelectedItem.ToString()
            fieldQuantity1.SummaryDisplayType = DirectCast(System.Enum.Parse(GetType(FieldSummaryDisplayType), value, False), FieldSummaryDisplayType)
            fieldQuantity1.Caption = FieldVariationCaption(fieldQuantity1.SummaryDisplayType)
        End Sub

        Private Sub OnCustomAppearance(ByVal sender As Object, ByVal e As PivotCustomCellAppearanceEventArgs)
            If Not(TypeOf e.Value Is Decimal) Then
                Return
            End If
            If e.DataField.Equals(fieldQuantity1) Then
                If CDec(e.Value) >= 0 Then
                    e.Foreground = New SolidColorBrush(Colors.Blue)
                Else
                    e.Foreground = New SolidColorBrush(Colors.Red)
                End If
            End If
        End Sub
        Private Function FieldVariationCaption(ByVal displayType As FieldSummaryDisplayType) As String
            Select Case displayType
                Case FieldSummaryDisplayType.AbsoluteVariation
                    Return "Qty (Var)"
                Case FieldSummaryDisplayType.PercentVariation, FieldSummaryDisplayType.PercentOfColumn, FieldSummaryDisplayType.PercentOfColumnGrandTotal, FieldSummaryDisplayType.PercentOfGrandTotal, FieldSummaryDisplayType.PercentOfRow, FieldSummaryDisplayType.PercentOfRowGrandTotal
                    Return "Qty (%)"
                Case FieldSummaryDisplayType.RankInColumnLargestToSmallest, FieldSummaryDisplayType.RankInColumnSmallestToLargest, FieldSummaryDisplayType.RankInRowLargestToSmallest, FieldSummaryDisplayType.RankInRowSmallestToLargest
                    Return "Qty (Rank)"
                Case FieldSummaryDisplayType.Index
                    Return "Qty (Index)"
                Case Else
                    Return "Qty"
            End Select
        End Function
    End Class
End Namespace
