Imports System
Imports System.Collections.Generic
Imports DevExpress.Xpf.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Bars
Imports DevExpress.Mvvm

Namespace GridDemo
    <CodeFile("ModuleResources/IntervalGroupingClasses.(cs)")>
    Partial Public Class IntervalGrouping
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            groupModeList.SelectedIndex = 0
        End Sub
        Private Sub groupModeList_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            SetGroupInterval(groupModeList.SelectedIndex)
        End Sub
        Private Sub SetGroupInterval(ByVal index As Integer)
            grid.SortInfo.Clear()
            grid.GroupCount = 0
            For Each column As GridColumn In grid.Columns
                column.GroupInterval = ColumnGroupInterval.Default
                column.SortMode = ColumnSortMode.Default
            Next column
            Select Case index
                Case 0
                    SetInterval("Country", ColumnGroupInterval.Alphabetical)
                Case 1
                    SetInterval("OrderDate", ColumnGroupInterval.DateMonth)
                Case 2
                    SetInterval("OrderDate", ColumnGroupInterval.DateYear)
                Case 3
                    SetInterval("OrderDate", ColumnGroupInterval.DateRange)
                Case 4
                    SetSortMode("UnitPrice", ColumnSortMode.Custom)
            End Select
        End Sub
        Private Sub SetInterval(ByVal fieldName As String, ByVal interval As ColumnGroupInterval)
            grid.Columns(fieldName).GroupInterval = interval
            grid.GroupBy(fieldName)
        End Sub
        Private Sub SetSortMode(ByVal fieldName As String, ByVal sortMode As ColumnSortMode)
            grid.Columns(fieldName).SortMode = sortMode
            grid.GroupBy(fieldName)
        End Sub
        Private Sub grid_CustomColumnGroup(ByVal sender As Object, ByVal e As CustomColumnSortEventArgs)
            Dim x As Double = Math.Floor(Convert.ToDouble(e.Value1) / 10)
            Dim y As Double = Math.Floor(Convert.ToDouble(e.Value2) / 10)
            Dim res As Integer = Comparer(Of Double).Default.Compare(x, y)
            If x > 19 AndAlso y > 19 Then
                res = 0
            End If
            e.Result = res
            e.Handled = True
        End Sub
        Private Sub view_CustomGroupDisplayText(ByVal sender As Object, ByVal e As CustomGroupDisplayTextEventArgs)
            If e.Column.SortMode = ColumnSortMode.Custom Then
                Dim d As Double = Math.Floor(Convert.ToDouble(e.Value) / 10)
                Dim ret As String = String.Format("{0:$0.00} - {1:$0.00} ", d * 10, (d + 1) * 10)
                If d > 19 Then
                    ret = String.Format(">= {0:$0.00} ", d * 10)
                End If
                e.DisplayText = ret
            End If
        End Sub

        Private Sub view_ShowGridMenu(ByVal sender As Object, ByVal e As GridMenuEventArgs)
            If e.MenuType = GridMenuType.Column AndAlso e.MenuInfo.Column.FieldName = "OrderDate" Then
                e.Customizations.Add(New RemoveBarItemAndLinkAction() With {.ItemName = DefaultColumnMenuItemNames.MenuColumnGroupIntervalNone})
                e.Customizations.Add(New RemoveBarItemAndLinkAction() With {.ItemName = DefaultColumnMenuItemNames.MenuColumnGroupIntervalDay})
                SetContextMenuItemCommand(e, DefaultColumnMenuItemNames.MenuColumnGroupIntervalMonth, 1)
                SetContextMenuItemCommand(e, DefaultColumnMenuItemNames.MenuColumnGroupIntervalYear, 2)
                SetContextMenuItemCommand(e, DefaultColumnMenuItemNames.MenuColumnGroupIntervalSmart, 3)
            End If
        End Sub
        Private Sub SetContextMenuItemCommand(ByVal e As GridMenuEventArgs, ByVal itemName As String, ByVal index As Integer)
            Dim item As BarItem = e.MenuInfo.Menu.GetBarItemByName(itemName)
            If item IsNot Nothing Then
                item.Command = New DelegateCommand(Of Object)(Sub(obj As Object) groupModeList.SelectedIndex = index)
            End If
        End Sub
    End Class
End Namespace
