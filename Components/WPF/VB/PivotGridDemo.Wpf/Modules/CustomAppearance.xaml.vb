Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core
Imports System.Windows.Markup
Imports System.Windows.Data
Imports DevExpress.Xpf.Editors.Helpers
Imports System.Windows.Media
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class CustomAppearance
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            pivotGrid.BeginUpdate()
            fieldCategoryName.FilterValues.FilterType = FieldFilterType.Included
            fieldCategoryName.FilterValues.Add("Grains/Cereals")
            fieldCategoryName.FilterValues.Add("Meat/Poultry")
            fieldCategoryName.FilterValues.Add("Produce")
            fieldSalesPerson.FilterValues.Add("Robert King")
            fieldSalesPerson.FilterValues.Add("Steven Buchanan")
            pivotGrid.EndUpdate()
            AddHandler pivotGrid.FocusedCellChanged, AddressOf OnFocusedCellChanged
            AddHandler Loaded, AddressOf OnModuleLoaded
        End Sub

        Private Sub OnModuleLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(fieldSalesPerson, True, False)
        End Sub

        Private Sub OnFocusedCellChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.RaiseEvent(New PivotBrushChangedEventArgs(PivotGridControl.BrushChangedEvent, pivotGrid, PivotBrushType.CellBrush))
            pivotGrid.RaiseEvent(New PivotBrushChangedEventArgs(PivotGridControl.BrushChangedEvent, pivotGrid, PivotBrushType.ValueBrush))
        End Sub

        Private Sub OnCustomCellAppearance(ByVal sender As Object, ByVal e As PivotCustomCellAppearanceEventArgs)
            Dim columnSelected As Boolean = e.RowIndex = pivotGrid.FocusedCell.Y
            Dim rowSelected As Boolean = e.ColumnIndex = pivotGrid.FocusedCell.X
            If columnSelected AndAlso (Not rowSelected) OrElse (Not columnSelected) AndAlso rowSelected Then
                Dim mode As CellMode = CellMode.Selected
                If e.RowValueType > 0 OrElse e.ColumnValueType > 0 Then
                    mode = mode Or CellMode.Tolal
                End If
                e.Background = GetActualCellBackgroundBrush(mode)
                e.Foreground = GetActualCellForegroundBrush(mode)
            End If
        End Sub

        Private Sub OnCustomValueAppearance(ByVal sender As Object, ByVal e As PivotCustomValueAppearanceEventArgs)
            If e.MaxIndex <> e.MinIndex Then
                Return
            End If
            If e.IsColumn AndAlso e.MinIndex = pivotGrid.FocusedCell.X OrElse (Not e.IsColumn) AndAlso e.MinIndex = pivotGrid.FocusedCell.Y Then
                e.Background = pivotGrid.ValueSelectedBackground
            End If
        End Sub

        Private Function GetActualCellForegroundBrush(ByVal actualMode As CellMode) As Brush
            Select Case actualMode
                Case CellMode.None
                    Return pivotGrid.CellForeground
                Case CellMode.Selected
                    Return pivotGrid.CellSelectedForeground
                Case CellMode.Tolal
                    Return pivotGrid.CellTotalForeground
                Case CellMode.TotalSelected
                    Return pivotGrid.CellTotalSelectedForeground
                Case Else
                    Throw New Exception("CellMode")
            End Select
        End Function

        Private Function GetActualCellBackgroundBrush(ByVal actualMode As CellMode) As Brush
            Select Case actualMode
                Case CellMode.None
                    Return pivotGrid.CellBackground
                Case CellMode.Selected
                    Return pivotGrid.CellSelectedBackground
                Case CellMode.Tolal
                    Return pivotGrid.CellTotalBackground
                Case CellMode.TotalSelected
                    Return pivotGrid.CellTotalSelectedBackground
                Case Else
                    Throw New Exception("CellMode")
            End Select
        End Function

        Public Enum CellMode
            None = 0
            Tolal = 1
            Selected = 2
            TotalSelected = Tolal Or Selected
        End Enum
    End Class
End Namespace
