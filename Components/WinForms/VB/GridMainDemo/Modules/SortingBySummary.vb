Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Paint

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for SortingBySummary.
    ''' </summary>
    Partial Public Class SortingBySummary
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\SortingBySummary.vb"
            TutorialInfo.WhatsThisXMLFile = "SortingBySummary.xml"
            ' TODO: Add any initialization after the InitForm call

            '<gridControl1>
            '            
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem() {
            '~    New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Product Name", Nothing, "(Product: Count {0})"),
            '~    New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Order Sum", Nothing, "(Orders: Sum {0:c})"),
            '~    New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Unit Price", Nothing, "(Price: Avg {0:c})")})
            '            
            '</gridControl1>


        End Sub
        Private colorsSortValue As New ColorsObject(Color.RoyalBlue, Color.Empty)
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property
        Private Sub SortingBySummary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            gridControl1.DataSource = GroupIntervalData.CreateDataTable(500, False)
            cbeSorting.SelectedIndex = 4
        End Sub

        '<cbeSorting>
        Private ReadOnly Property GroupColumn() As GridColumn
            Get
                Return gridColumn5
            End Get
        End Property
        Private ReadOnly Property CurrentSummaryItemIndex() As Integer
            Get
                Return CInt(Fix(cbeSorting.SelectedIndex)) \ 2 - 1
            End Get
        End Property
        Private ReadOnly Property CurrentSortOrder() As ColumnSortOrder
            Get
                Return If(cbeSorting.SelectedIndex Mod 2 = 0, ColumnSortOrder.Ascending, ColumnSortOrder.Descending)
            End Get
        End Property

        Private Sub cbeSorting_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbeSorting.SelectedIndexChanged
            gridView1.BeginSort()
            Try
                gridView1.GroupSummarySortInfo.Clear()
                GroupColumn.SortOrder = CurrentSortOrder
                If CurrentSummaryItemIndex >= 0 Then
                    gridView1.GroupSummarySortInfo.Add(gridView1.GroupSummary(CurrentSummaryItemIndex), CurrentSortOrder, GroupColumn)
                End If
            Finally
                gridView1.EndSort()
            End Try
        End Sub
        '</cbeSorting>

        Private Sub gridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles gridView1.GridMenuItemClick
            If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                Return
            End If
            If e.SummaryItem Is Nothing Then
                Return
            End If
            Dim index As Integer = -1
            If e.DXMenuItem.Caption.IndexOf("Product") > -1 Then
                index = 2
            End If
            If e.DXMenuItem.Caption.IndexOf("Order Sum") > -1 Then
                index = 4
            End If
            If e.DXMenuItem.Caption.IndexOf("Price") > -1 Then
                index = 6
            End If
            If SortOrder.Descending.ToString() = e.SummaryFormat Then
                index += 1
            End If
            cbeSorting.SelectedIndex = -1
            cbeSorting.SelectedIndex = index
            e.Handled = True
        End Sub
    End Class
End Namespace
