Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.PivotGrid
    Partial Public Class Report
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Me.fieldOrderID = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldProduct = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldQuantity = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldDiscount = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldSum = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
            Me.dsOrderReports = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.fieldProductID = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPivotGridCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrPivotGridFieldStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' fieldOrderID
            ' 
            Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderID.AreaIndex = 0
            Me.fieldOrderID.Caption = "Order"
            Me.fieldOrderID.FieldName = "OrderID"
            Me.fieldOrderID.Name = "fieldOrderID"
            Me.fieldOrderID.Width = 54
            ' 
            ' fieldProduct
            ' 
            Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProduct.AreaIndex = 2
            Me.fieldProduct.Caption = "Product Name"
            Me.fieldProduct.FieldName = "ProductName"
            Me.fieldProduct.Name = "fieldProduct"
            Me.fieldProduct.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldProduct.Width = 185
            ' 
            ' fieldUnitPrice
            ' 
            Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitPrice.AreaIndex = 0
            Me.fieldUnitPrice.Caption = "Unit Price"
            Me.fieldUnitPrice.CellFormat.FormatString = "c"
            Me.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldUnitPrice.FieldName = "UnitPrice"
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            Me.fieldUnitPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
            Me.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldUnitPrice.Width = 122
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
            Me.fieldQuantity.Width = 125
            ' 
            ' fieldDiscount
            ' 
            Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldDiscount.AreaIndex = 2
            Me.fieldDiscount.FieldName = "Discount"
            Me.fieldDiscount.Name = "fieldDiscount"
            Me.fieldDiscount.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
            Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldDiscount.TotalCellFormat.FormatString = "P"
            Me.fieldDiscount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldDiscount.Width = 126
            ' 
            ' fieldSum
            ' 
            Me.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldSum.AreaIndex = 3
            Me.fieldSum.CellFormat.FormatString = "c"
            Me.fieldSum.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldSum.FieldName = "ExtendedPrice"
            Me.fieldSum.Name = "fieldSum"
            Me.fieldSum.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
            Me.fieldSum.Width = 134
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
            Me.Detail.HeightF = 75F
            Me.Detail.Name = "Detail"
            ' 
            ' xrPivotGrid1
            ' 
            Me.xrPivotGrid1.CellStyleName = "xrPivotGridCellStyle"
            Me.xrPivotGrid1.DataMember = "OrderReports"
            Me.xrPivotGrid1.DataSource = Me.dsOrderReports
            Me.xrPivotGrid1.FieldHeaderStyleName = "xrPivotGridFieldStyle"
            Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldOrderID, Me.fieldProduct, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldSum, Me.fieldProductID})
            Me.xrPivotGrid1.FieldValueStyleName = "xrPivotGridFieldStyle"
            Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
            Me.xrPivotGrid1.Name = "xrPivotGrid1"
            Me.xrPivotGrid1.OptionsDataField.AreaIndex = 0
            Me.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
            Me.xrPivotGrid1.OptionsView.ShowDataHeaders = False
            Me.xrPivotGrid1.Prefilter.CriteriaString = "[fieldOrderID] < 10261"
            Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(879.9999F, 70.00002F)
            ' 
            ' dsOrderReports
            ' 
            Me.dsOrderReports.ConnectionName = "NWindConnectionString"
            Me.dsOrderReports.Name = "dsOrderReports"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "OrderDetailsExtended"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ProductName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitPrice"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Quantity"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Discount"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ExtendedPrice"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Name = "OrderReports"
            selectQuery1.Tables.Add(table1)
            Me.dsOrderReports.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsOrderReports.ResultSchemaSerializable = resources.GetString("dsOrderReports.ResultSchemaSerializable")
            ' 
            ' fieldProductID
            ' 
            Me.fieldProductID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductID.AreaIndex = 1
            Me.fieldProductID.FieldName = "ProductID"
            Me.fieldProductID.Name = "fieldProductID"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
            Me.ReportHeader.HeightF = 73F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Underline)
            Me.xrLabel2.ForeColor = System.Drawing.Color.Black
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(289.2083F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(324F, 42F)
            Me.xrLabel2.Text = "Orders Report"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 84.99998F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(382.3333F, 38.3333F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrPageInfo1.Format = "Page : {0 } / {1}"
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(791.9999F, 10.00001F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            ' 
            ' xrPivotGridCellStyle
            ' 
            Me.xrPivotGridCellStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(245)))), (CInt((CByte(216)))))
            Me.xrPivotGridCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrPivotGridCellStyle.Name = "xrPivotGridCellStyle"
            Me.xrPivotGridCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' xrPivotGridFieldStyle
            ' 
            Me.xrPivotGridFieldStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(223)))), (CInt((CByte(201)))))
            Me.xrPivotGridFieldStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrPivotGridFieldStyle.Name = "xrPivotGridFieldStyle"
            Me.xrPivotGridFieldStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.Landscape = True
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 85)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrPivotGridCellStyle, Me.xrPivotGridFieldStyle})
            Me.Version = "16.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Private fieldOrderID As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldProduct As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldUnitPrice As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldQuantity As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldDiscount As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldSum As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrPivotGridCellStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private xrPivotGridFieldStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private fieldProductID As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Public xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
        Private dsOrderReports As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
