Imports System
Imports System.Windows
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class CustomGroupInterval
        Inherits PivotGridDemoModule


        Private selectedDemo_Renamed As Integer

        Public Sub New()
            selectedDemo_Renamed = 0
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().ProductReports.ToList()
            cbGroup.Items.Add(New ComboBoxEditItem() With {.Content = "Group Products by First Characters", .Tag = 0})
            cbGroup.Items.Add(New ComboBoxEditItem() With {.Content = "Group Sales by Year and Quarter", .Tag = 1})
            cbGroup.SelectedIndex = 0
        End Sub

        Private ReadOnly Property SelectedDemo() As Integer
            Get
                Return selectedDemo_Renamed
            End Get
        End Property

        Private Sub cbGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim tag As Object = CType(cbGroup.SelectedItem, ComboBoxEditItem).Tag
            selectedDemo_Renamed = DirectCast(tag, Integer)
            pivotGrid.BeginUpdate()
            Select Case SelectedDemo
                Case 0
                    pivotGrid.Fields(0).Visible = True
                    pivotGrid.Fields(0).Caption = "Product Group"
                    pivotGrid.Fields(0).GroupInterval = FieldGroupInterval.Custom

                    pivotGrid.Fields(4).Caption = "Year"
                    pivotGrid.Fields(4).GroupInterval = FieldGroupInterval.DateYear

                    pivotGrid.Fields(3).Visible = False
                    pivotGrid.Fields(3).GroupInterval = FieldGroupInterval.Default
                Case 1
                    pivotGrid.Fields(3).Visible = True
                    pivotGrid.Fields(3).Caption = "Year - Quarter"
                    pivotGrid.Fields(3).GroupInterval = FieldGroupInterval.Custom
                    pivotGrid.Fields(3).AreaIndex = 0

                    pivotGrid.Fields(4).Caption = "Shipped Date"
                    pivotGrid.Fields(4).GroupInterval = FieldGroupInterval.Date
                    pivotGrid.Fields(4).AreaIndex = 1

                    pivotGrid.Fields(0).Visible = False
                    pivotGrid.Fields(0).GroupInterval = FieldGroupInterval.Default
            End Select
            pivotGrid.EndUpdate()
            pivotGrid.CollapseAll()
        End Sub
        Private Sub pivotGrid_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs)
            Select Case SelectedDemo
                Case 0
                    If Not Object.ReferenceEquals(e.Field, pivotGrid.Fields(0)) Then
                        Return
                    End If
                    If Convert.ToChar(e.Value.ToString().Chars(0)) < "F"c Then
                        e.GroupValue = "A-E"
                        Return
                    End If
                    If Convert.ToChar(e.Value.ToString().Chars(0)) > "E"c AndAlso Convert.ToChar(e.Value.ToString().Chars(0)) < "T"c Then
                        e.GroupValue = "F-S"
                        Return
                    End If
                    If Convert.ToChar(e.Value.ToString().Chars(0)) > "S"c Then
                        e.GroupValue = "T-Z"
                    End If
                Case 1
                    If Not Object.ReferenceEquals(e.Field, pivotGrid.Fields(3)) Then
                        Return
                    End If
                    e.GroupValue = CDate(e.Value).Year & " - " & ((CDate(e.Value).Month - 1) \ 3 + 1).ToString()
            End Select
        End Sub
    End Class
End Namespace
