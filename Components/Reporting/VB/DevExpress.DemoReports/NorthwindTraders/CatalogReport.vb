Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.Globalization
Imports System.Reflection

Namespace XtraReportsDemos.NorthwindTraders
    Partial Public Class CatalogReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.NorthwindTraders_Catalog
            DisplayName = ReportNames.NorthwindTraders_Catalog

            parameterSortGroupsType.Type = GetType(SortGroupsType)
            parameterSortGroupsType.Value = SortGroupsType.Count
            parameterSortGroupsType.Visible = EnableGroupsSorting
            parameterSortGroupsOrder.Type = GetType(XRColumnSortOrder)
            parameterSortGroupsOrder.Value = XRColumnSortOrder.Ascending
            parameterSortGroupsOrder.Visible = EnableGroupsSorting

            UpdateGroupSortingSummary()
        End Sub

        Public ReadOnly Property GroupHeader() As GroupHeaderBand
            Get
                Return GroupHeader0
            End Get
        End Property
        Protected Overridable ReadOnly Property EnableGroupsSorting() As Boolean
            Get
                Return True
            End Get
        End Property

        Private Sub UpdateGroupSortingSummary()
            GroupHeader0.SortingSummary.Enabled = EnableGroupsSorting
            GroupHeader0.SortingSummary.FieldName = "UnitPrice" 'dsCatalog1.Products.UnitPriceColumn.ColumnName;
            GroupHeader0.SortingSummary.SortOrder = CType(parameterSortGroupsOrder.Value, XRColumnSortOrder)
            GroupHeader0.SortingSummary.IgnoreNullValues = True

            Select Case CType(parameterSortGroupsType.Value, SortGroupsType)
                Case SortGroupsType.None
                    GroupHeader0.SortingSummary.Enabled = False
                Case SortGroupsType.Count
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Count
                Case SortGroupsType.TotalSales
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Sum
                    GroupHeader0.SortingSummary.FieldName = "ProductSales"
                Case SortGroupsType.LowestPrice
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Min
                Case SortGroupsType.HighestPrice
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Max
            End Select
        End Sub
        Protected Overrides Sub OnBeforePrint(ByVal e As System.Drawing.Printing.PrintEventArgs)
            MyBase.OnBeforePrint(e)
            'dsCatalog ds = (dsCatalog)DataSource;
            'if(ds.Order_Details.Rows.Count == 0) {
            '    Order_DetailsTableAdapter order_DetailsTableAdapter = new Order_DetailsTableAdapter();
            '    order_DetailsTableAdapter.Fill(ds.Order_Details);
            '}
            UpdateGroupSortingSummary()
        End Sub
    End Class
End Namespace
