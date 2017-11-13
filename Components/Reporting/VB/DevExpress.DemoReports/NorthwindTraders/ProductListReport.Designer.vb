Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.NorthwindTraders
    Partial Public Class ProductListReport
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private lbTitle As DevExpress.XtraReports.UI.XRLabel
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrLine3 As DevExpress.XtraReports.UI.XRLine
        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ProductListReport))
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
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.FirstLetter = New DevExpress.XtraReports.UI.CalculatedField()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.BorderColor = System.Drawing.Color.White
            Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Right
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Detail.HeightF = 20F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(17F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(616F, 20F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrRow2
            ' 
            Me.xrRow2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.xrRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell8, Me.xrTableCell6, Me.xrTableCell9})
            Me.xrRow2.Name = "xrRow2"
            Me.xrRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrRow2.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 1, 1, 100F)
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell4.Weight = 0.2435064935064935R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.CategoryName")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 1, 1, 100F)
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell5.Weight = 0.18993506493506493R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit")})
            Me.xrTableCell8.KeepTogether = True
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 0, 1, 1, 100F)
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell8.Weight = 0.21590909090909091R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
            Me.xrTableCell6.KeepTogether = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 8, 1, 1, 100F)
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.Weight = 0.18344155844155843R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell9.ForeColor = System.Drawing.Color.White
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell9.Weight = 0.16720779220779219R
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("FirstLetter", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader0.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader0.HeightF = 38F
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.xrTable1.BorderColor = System.Drawing.Color.White
            Me.xrTable1.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Products.FirstLetter")})
            Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTable1.ForeColor = System.Drawing.Color.Black
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(17F, 8F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(616F, 30F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrRow1
            ' 
            Me.xrRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell7, Me.xrTableCell3, Me.xrTableCell10})
            Me.xrRow1.Name = "xrRow1"
            Me.xrRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.xrTableCell1.Text = "ProductName:"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.2435064935064935R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.xrTableCell2.Text = "Category Name:"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.18993506493506493R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.xrTableCell7.Text = "Quantity Per Unit:"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.21590909090909091R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.xrTableCell3.Text = "Units In Stock:"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.18344155844155843R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.FirstLetter")})
            Me.xrTableCell10.Font = New System.Drawing.Font("Tahoma", 14.25F)
            Me.xrTableCell10.ForeColor = System.Drawing.Color.White
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 9, 5, 0, 100F)
            Me.xrTableCell10.Text = "xrTableCell10"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell10.Weight = 0.16720779220779219R
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 15.75F)
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(17F, 26F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(400F, 23F)
            Me.lbTitle.Text = "Alphabetical List of Products"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox2, Me.xrPictureBox1, Me.xrLine3, Me.xrPageInfo2, Me.lbTitle})
            Me.ReportHeader.HeightF = 74F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.Image = (CType(resources.GetObject("xrPictureBox2.Image"), System.Drawing.Image))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(516F, 15F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(116F, 28F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(471F, 7F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(45F, 42F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrLine3
            ' 
            Me.xrLine3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrLine3.LineWidth = 6
            Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(17F, 49F)
            Me.xrLine3.Name = "xrLine3"
            Me.xrLine3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine3.SizeF = New System.Drawing.SizeF(616F, 9F)
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrPageInfo2.Format = "{0:d}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(533F, 58F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(96F, 16F)
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 95F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 30F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic)
            Me.xrPageInfo1.Format = "Page : {0 } / {1}"
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(508F, 8F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(134F, 17F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' FirstLetter
            ' 
            Me.FirstLetter.DataMember = "Products"
            Me.FirstLetter.Expression = "Substring([ProductName], 0, 1)"
            Me.FirstLetter.Name = "FirstLetter"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "QuantityPerUnit"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitsInStock"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "CategoryID"
            table2.Name = "Categories"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "CategoryName"
            columnExpression6.Table = table2
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' ProductListReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.ReportHeader, Me.GroupHeader0, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.FirstLetter})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 95)
            Me.ReportPrintOptions.DetailCountAtDesignTime = 15
            Me.Version = "16.1"
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private FirstLetter As DevExpress.XtraReports.UI.CalculatedField
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
