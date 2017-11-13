Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.DataAccess

Namespace XtraReportsDemos.TableReport
    Partial Public Class Report
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private lbOrderID As DevExpress.XtraReports.UI.XRLabel
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private clProductName As DevExpress.XtraReports.UI.XRTableCell
        Private clUnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Private clQuantity As DevExpress.XtraReports.UI.XRTableCell
        Private clDiscount As DevExpress.XtraReports.UI.XRTableCell
        Private clSubtotal As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private clSupplier As DevExpress.XtraReports.UI.XRTableCell
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
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
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As New DevExpress.DataAccess.Sql.CustomExpression()
            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim sorting1 As New DevExpress.DataAccess.Sql.Sorting()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSupplier = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clQuantity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clDiscount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSubtotal = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.MaxRowCountParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.OrderIdParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.dsOrderDetails1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(250)))), (CInt((CByte(250)))), (CInt((CByte(240)))))
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(207)))), (CInt((CByte(189)))))
            Me.EvenStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.EvenStyle.ForeColor = System.Drawing.Color.Black
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(225)))), (CInt((CByte(232)))), (CInt((CByte(220)))))
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(207)))), (CInt((CByte(189)))))
            Me.OddStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.OddStyle.ForeColor = System.Drawing.Color.Black
            Me.OddStyle.Name = "OddStyle"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1, Me.xrTable2})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPageBreak1
            ' 
            Me.xrPageBreak1.FormattingRules.Add(Me.formattingRule1)
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            Me.xrPageBreak1.Visible = False
            ' 
            ' formattingRule1
            ' 
            Me.formattingRule1.Condition = "([DataSource.CurrentRowIndex] % [Parameters.MaxRowCountParameter]  == 0) And ([Da" & "taSource.CurrentRowIndex] != 0)"
            Me.formattingRule1.DataMember = "OrderDetails"
            ' 
            ' 
            ' 
            Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True
            Me.formattingRule1.Name = "formattingRule1"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.Black
            Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.BorderWidth = 1F
            Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75F)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clProductName, Me.clSupplier, Me.clUnitPrice, Me.clQuantity, Me.clDiscount, Me.clSubtotal})
            Me.xrTableRow2.EvenStyleName = "EvenStyle"
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.OddStyleName = "OddStyle"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1R
            ' 
            ' clProductName
            ' 
            Me.clProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.ProductName")})
            Me.clProductName.Name = "clProductName"
            Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 5, 3, 3, 100F)
            Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clProductName.Weight = 0.25384615384615383R
            ' 
            ' clSupplier
            ' 
            Me.clSupplier.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Supplier")})
            Me.clSupplier.Name = "clSupplier"
            Me.clSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 3, 3, 3, 100F)
            Me.clSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clSupplier.Weight = 0.31538461538461537R
            ' 
            ' clUnitPrice
            ' 
            Me.clUnitPrice.BorderWidth = 1F
            Me.clUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.UnitPrice", "{0:$#,##.00}")})
            Me.clUnitPrice.Name = "clUnitPrice"
            Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clUnitPrice.Weight = 0.1076923076923077R
            ' 
            ' clQuantity
            ' 
            Me.clQuantity.BorderWidth = 1F
            Me.clQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {
                New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "OrderDetails.UnitPrice"),
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Quantity")
            })
            Me.clQuantity.Name = "clQuantity"
            Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clQuantity.Weight = 0.1076923076923077R
            ' 
            ' clDiscount
            ' 
            Me.clDiscount.BorderWidth = 1F
            Me.clDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {
                New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "OrderDetails.Quantity", "{0:#,##.00%}"),
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Discount", "{0:0%}")
            })
            Me.clDiscount.Name = "clDiscount"
            Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clDiscount.Weight = 0.1076923076923077R
            ' 
            ' clSubtotal
            ' 
            Me.clSubtotal.BorderWidth = 1F
            Me.clSubtotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.SubTotal", "{0:$#,##.00}")})
            Me.clSubtotal.Name = "clSubtotal"
            Me.clSubtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clSubtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clSubtotal.Weight = 0.1076923076923077R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.lbOrderID, Me.xrLabel1})
            Me.ReportHeader.HeightF = 84F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(406F, 67F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(245F, 16F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' lbOrderID
            ' 
            Me.lbOrderID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.OrderID")})
            Me.lbOrderID.Font = New System.Drawing.Font("Tahoma", 18F)
            Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(425F, 17F)
            Me.lbOrderID.Name = "lbOrderID"
            Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbOrderID.SizeF = New System.Drawing.SizeF(117F, 33F)
            Me.lbOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.CanShrink = True
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 18F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(50F, 17F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(366F, 33F)
            Me.xrLabel1.Text = "Details of the customer order"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(214)))), (CInt((CByte(211)))))
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(177)))), (CInt((CByte(183)))))
            Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.BorderWidth = 2F
            Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 1F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 43F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell4, Me.xrTableCell7, Me.xrTableCell2, Me.xrTableCell13, Me.xrTableCell3})
            Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BorderWidth = 1F
            Me.xrTableCell1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox2, Me.xrLabel2})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableCell1.Text = "Product"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.25384615384615383R
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.BorderWidth = 0F
            Me.xrPictureBox2.Image = (CType(resources.GetObject("xrPictureBox2.Image"), System.Drawing.Image))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(92F, 4F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(55.20833F, 37.5F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BorderWidth = 0F
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(8F, 8F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(66F, 30F)
            Me.xrLabel2.Text = "Product"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.BorderWidth = 1F
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.Text = "Supplier"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.31538461538461537R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BorderWidth = 1F
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.Text = "Unit Price"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.1076923076923077R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BorderWidth = 1F
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Text = "Quantity"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.1076923076923077R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.BorderWidth = 1F
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.Text = "Discount"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.1076923076923077R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.BorderWidth = 1F
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.Text = "Subtotal"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.1076923076923077R
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
            Me.ReportFooter.HeightF = 33F
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(214)))), (CInt((CByte(211)))))
            Me.xrLabel3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(177)))), (CInt((CByte(181)))))
            Me.xrLabel3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel3.CanGrow = False
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.SubTotal")})
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(408F, 12F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(242F, 21F)
            xrSummary1.FormatString = "{0: Total order cost :   $0.00 }"
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrLabel3.Summary = xrSummary1
            Me.xrLabel3.Text = "xrLabel3"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrLabel3.XlsxFormatString = """Total order cost: ""$0.00"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.PageHeader.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
            Me.PageHeader.HeightF = 44F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 13F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
            Me.GroupFooter1.HeightF = 33F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupFooter1.RepeatEveryPage = True
            Me.GroupFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(214)))), (CInt((CByte(211)))))
            Me.xrLabel5.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(177)))), (CInt((CByte(181)))))
            Me.xrLabel5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel5.CanGrow = False
            Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.SubTotal")})
            Me.xrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(355F, 12F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(295F, 21F)
            xrSummary2.FormatString = "{0: Total order cost  for this page:   $0.00 }"
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Page
            Me.xrLabel5.Summary = xrSummary2
            Me.xrLabel5.Text = "xrLabel5"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrLabel5.XlsxFormatString = """Total order cost for this page: ""$0.00"
            ' 
            ' MaxRowCountParameter
            ' 
            Me.MaxRowCountParameter.Description = "Max Rows per Page: "
            Me.MaxRowCountParameter.Name = "MaxRowCountParameter"
            Me.MaxRowCountParameter.Type = GetType(Integer)
            Me.MaxRowCountParameter.ValueInfo = "10"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' OrderIdParameter
            ' 
            Me.OrderIdParameter.Description = "Order Id:"
            Me.OrderIdParameter.Name = "OrderIdParameter"
            Me.OrderIdParameter.Type = GetType(Integer)
            Me.OrderIdParameter.ValueInfo = "11077"
            ' 
            ' dsOrderDetails1
            ' 
            Me.dsOrderDetails1.ConnectionName = "NWindConnectionString"
            Me.dsOrderDetails1.Name = "dsOrderDetails1"
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
            columnExpression7.ColumnName = "Supplier"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            column8.Alias = "SubTotal"
            customExpression1.Expression = "ToDouble([OrderDetailsExtended].[Quantity] * [OrderDetailsExtended].[UnitPrice])"
            column8.Expression = customExpression1
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.FilterString = "[OrderDetailsExtended.OrderID] = ?OrderIdParameter"
            selectQuery1.Name = "OrderDetails"
            queryParameter1.Name = "OrderIdParameter"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.OrderIdParameter]", GetType(Integer))
            selectQuery1.Parameters.Add(queryParameter1)
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending
            columnExpression8.ColumnName = "ExtendedPrice"
            columnExpression8.Table = table1
            sorting1.Expression = columnExpression8
            selectQuery1.Sorting.Add(sorting1)
            selectQuery1.Tables.Add(table1)
            Me.dsOrderDetails1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsOrderDetails1.ResultSchemaSerializable = resources.GetString("dsOrderDetails1.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.ReportFooter, Me.PageHeader, Me.BottomMargin, Me.GroupFooter1, Me.topMarginBand1})
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.dsOrderDetails1
            Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
            Me.Margins = New System.Drawing.Printing.Margins(100, 96, 100, 75)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.OrderIdParameter, Me.MaxRowCountParameter})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 7
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.EvenStyle, Me.OddStyle})
            Me.Version = "16.1"
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
        Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
        Private MaxRowCountParameter As DevExpress.XtraReports.Parameters.Parameter
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private OrderIdParameter As DevExpress.XtraReports.Parameters.Parameter
        Private dsOrderDetails1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
