Imports System

Imports System.Data
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    Partial Public Class Grouping
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            AddHandler viewsListBox.EditValueChanged, AddressOf viewsListBox_SelectionChanged
            GroupByCountryThenCity()
        End Sub
        Private Sub viewsListBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            grid.View = CType(FindResource(If(viewsListBox.SelectedIndex = 0, "tableView", "cardView")), GridViewBase)
            allowFixedGroupsCheckBox.IsEnabled = viewsListBox.SelectedIndex = 0
        End Sub
  Private Sub GroupByCountryThenCity()
            grid.ClearGrouping()
   grid.GroupBy("Country")
   grid.GroupBy("City")
  End Sub

  Private Sub GroupByCountryThenCityThenOrderDate()
            grid.ClearGrouping()
            grid.GroupBy("Country")
            grid.GroupBy("City")
            grid.GroupBy("OrderDate")
  End Sub

  Private Sub GroupByCityThenOrderDate()
            grid.ClearGrouping()
            grid.GroupBy("City")
            grid.GroupBy("OrderDate")
  End Sub
        Private Sub ClearGrouping()
            grid.ClearGrouping()
        End Sub
        Private Sub groupList_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
   If grid Is Nothing Then
       Return
   End If
   Select Case groupList.SelectedIndex
    Case 0
        GroupByCountryThenCity()
    Case 1
        GroupByCountryThenCityThenOrderDate()
    Case 2
        GroupByCityThenOrderDate()
                Case 3
                    ClearGrouping()
   End Select
        End Sub
        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
    End Class
End Namespace
