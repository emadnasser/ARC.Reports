Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports GridDemo
Imports System.Collections
Imports System.Globalization
Imports DevExpress.Data
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.DemoBase.Helpers
Imports System.Data
Imports System.ComponentModel
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("Controls/SalesByYearData.(cs)"), CodeFile("ModuleResources/AlignGroupSummariesByColumnsViewModel.(cs)")>
    Partial Public Class AlignGroupSummariesByColumns
        Inherits GridDemoModule

        Private ReadOnly Property ViewModel() As AlignGroupSummariesByColumnsViewModel
            Get
                Return CType(DataContext, AlignGroupSummariesByColumnsViewModel)
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            If grid.ItemsSource IsNot Nothing Then
                PopulateColumnsAndSummaries()
            End If
            grid.ExpandGroupRow(-1)
            AddHandler grid.ItemsSourceChanged, AddressOf grid_ItemsSourceChanged
        End Sub

        Private Sub PopulateColumnsAndSummaries()
            Dim properties As PropertyDescriptorCollection = DirectCast(grid.ItemsSource, ITypedList).GetItemProperties(Nothing)
            For Each [property] As PropertyDescriptor In properties
                If [property].Name.Contains("Date") Then
                    Continue For
                End If
                grid.Columns.Add(New GridColumn() With {
                    .FieldName = [property].Name, .EditSettings = New SpinEditSettings() With {.MaskType = MaskType.Numeric, .Mask = "c", .MaskCulture = New CultureInfo("en-US"), .MaskUseAsDisplayFormat = True, .DisplayFormat="${0:N}"}
                })
                grid.TotalSummary.Add(New GridSummaryItem() With {.FieldName = [property].Name, .SummaryType = SummaryItemType.Sum, .DisplayFormat = "${0:N}"})
                grid.GroupSummary.Add(New GridSummaryItem() With {.FieldName = [property].Name, .SummaryType = SummaryItemType.Sum, .DisplayFormat = "${0:N}"})
            Next [property]
        End Sub
        Private Sub grid_ItemsSourceChanged(ByVal sender As Object, ByVal e As ItemsSourceChangedEventArgs)
            If grid.GroupSummary.Count = 0 Then
                PopulateColumnsAndSummaries()
            End If
            Dim byMonthReport As Boolean = ViewModel.ReportTypeIndex = 1
            grid.Columns("DateMonth").Visible = byMonthReport
            If byMonthReport Then
                grid.Columns("DateMonth").GroupIndex = 1
            Else
                grid.UngroupBy("DateMonth")
            End If
            grid.ExpandGroupRow(-1)
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
