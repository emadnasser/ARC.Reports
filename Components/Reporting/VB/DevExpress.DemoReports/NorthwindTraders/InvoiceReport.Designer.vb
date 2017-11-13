Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.NorthwindTraders
    Partial Public Class InvoiceReport
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private GroupFooter0 As DevExpress.XtraReports.UI.GroupFooterBand
        Private lbShipName As DevExpress.XtraReports.UI.XRLabel
        Private lbShipAddress As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents lbShipCityRegionPostalCode As DevExpress.XtraReports.UI.XRLabel
        Private lbShipCountry As DevExpress.XtraReports.UI.XRLabel
        Private lbAddress1 As DevExpress.XtraReports.UI.XRLabel
        Private lbCountry As DevExpress.XtraReports.UI.XRLabel
        Private lbCompanyName As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents lbCityRegionPostalCode As DevExpress.XtraReports.UI.XRLabel
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTable3 As DevExpress.XtraReports.UI.XRTable
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
        Private clExtPrice As DevExpress.XtraReports.UI.XRTableCell
        Private clSubtotal As DevExpress.XtraReports.UI.XRTableCell
        Private WithEvents clTotal As DevExpress.XtraReports.UI.XRTableCell
        Private clProductID As DevExpress.XtraReports.UI.XRTableCell
        Private clProductName As DevExpress.XtraReports.UI.XRTableCell
        Private clQuantity As DevExpress.XtraReports.UI.XRTableCell
        Private clUnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Private clDiscount As DevExpress.XtraReports.UI.XRTableCell
        Private clOrderID As DevExpress.XtraReports.UI.XRTableCell
        Private clCustomerID As DevExpress.XtraReports.UI.XRTableCell
        Private clSalesperson As DevExpress.XtraReports.UI.XRTableCell
        Private clOrderDate As DevExpress.XtraReports.UI.XRTableCell
        Private clRequiredDate As DevExpress.XtraReports.UI.XRTableCell
        Private clShippedDate As DevExpress.XtraReports.UI.XRTableCell
        Private clShipVia As DevExpress.XtraReports.UI.XRTableCell
        Private clFreight As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private lbDate As DevExpress.XtraReports.UI.XRLabel
        Private lbAddress As DevExpress.XtraReports.UI.XRLabel
        Private lbInvoice As DevExpress.XtraReports.UI.XRLabel
        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private lbBillTo As DevExpress.XtraReports.UI.XRLabel
        Private lbShipTo As DevExpress.XtraReports.UI.XRLabel
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
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(InvoiceReport))
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
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim column16 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column18 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression18 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As New DevExpress.DataAccess.Sql.Table()
            Dim column19 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression19 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column20 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression20 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table4 As New DevExpress.DataAccess.Sql.Table()
            Dim column21 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression21 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column22 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression22 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table5 As New DevExpress.DataAccess.Sql.Table()
            Dim column23 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression23 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column24 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression24 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column25 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression25 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column26 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression26 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column27 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression27 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column28 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression28 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table6 As New DevExpress.DataAccess.Sql.Table()
            Dim join1 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join2 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join3 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join4 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo4 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join5 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo5 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clProductID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clQuantity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clDiscount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clExtPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.lbShipTo = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbBillTo = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clOrderID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clCustomerID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSalesperson = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clOrderDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clRequiredDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clShippedDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clShipVia = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbShipName = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbShipAddress = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbShipCityRegionPostalCode = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbShipCountry = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbAddress1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCountry = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCompanyName = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCityRegionPostalCode = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter0 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSubtotal = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clFreight = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clTotal = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.lbDate = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbAddress = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbInvoice = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.ExtendedPrice = New DevExpress.XtraReports.UI.CalculatedField()
            Me.SalesPerson = New DevExpress.XtraReports.UI.CalculatedField()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow5})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(651F, 23F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.xrTableRow5.BorderColor = System.Drawing.Color.White
            Me.xrTableRow5.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow5.BorderWidth = 1F
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clProductID, Me.clProductName, Me.clQuantity, Me.clUnitPrice, Me.clDiscount, Me.clExtPrice})
            Me.xrTableRow5.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 1R
            ' 
            ' clProductID
            ' 
            Me.clProductID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ProductID")})
            Me.clProductID.Name = "clProductID"
            Me.clProductID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clProductID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clProductID.Weight = 0.10906298003072197R
            ' 
            ' clProductName
            ' 
            Me.clProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ProductName")})
            Me.clProductName.Name = "clProductName"
            Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clProductName.Weight = 0.30261136712749614R
            ' 
            ' clQuantity
            ' 
            Me.clQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Quantity")})
            Me.clQuantity.Name = "clQuantity"
            Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clQuantity.Weight = 0.13671274961597543R
            ' 
            ' clUnitPrice
            ' 
            Me.clUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.UnitPrice", "{0:$#,##.00}")})
            Me.clUnitPrice.Name = "clUnitPrice"
            Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clUnitPrice.Weight = 0.13671274961597543R
            ' 
            ' clDiscount
            ' 
            Me.clDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Discount", "{0:0%}")})
            Me.clDiscount.Name = "clDiscount"
            Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clDiscount.Weight = 0.13671274961597543R
            ' 
            ' clExtPrice
            ' 
            Me.clExtPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ExtendedPrice", "{0:$#,##.00}")})
            Me.clExtPrice.Name = "clExtPrice"
            Me.clExtPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clExtPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clExtPrice.Weight = 0.1781874039938556R
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbShipTo, Me.lbBillTo, Me.xrTable1, Me.lbShipName, Me.lbShipAddress, Me.lbShipCityRegionPostalCode, Me.lbShipCountry, Me.lbAddress1, Me.lbCountry, Me.lbCompanyName, Me.lbCityRegionPostalCode})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
            Me.GroupHeader0.HeightF = 219F
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipTo
            ' 
            Me.lbShipTo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.lbShipTo.BorderColor = System.Drawing.Color.White
            Me.lbShipTo.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.lbShipTo.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbShipTo.ForeColor = System.Drawing.Color.Black
            Me.lbShipTo.LocationFloat = New DevExpress.Utils.PointFloat(0F, 17F)
            Me.lbShipTo.Name = "lbShipTo"
            Me.lbShipTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipTo.SizeF = New System.Drawing.SizeF(72F, 25F)
            Me.lbShipTo.Text = "Ship To:"
            Me.lbShipTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbBillTo
            ' 
            Me.lbBillTo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.lbBillTo.BorderColor = System.Drawing.Color.White
            Me.lbBillTo.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.lbBillTo.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbBillTo.ForeColor = System.Drawing.Color.Black
            Me.lbBillTo.LocationFloat = New DevExpress.Utils.PointFloat(359F, 17F)
            Me.lbBillTo.Name = "lbBillTo"
            Me.lbBillTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbBillTo.SizeF = New System.Drawing.SizeF(66F, 25F)
            Me.lbBillTo.Text = "Bill To:"
            Me.lbBillTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 130F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.xrTableRow2, Me.xrTableRow3, Me.xrTableRow4})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(651F, 89F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrTableRow1.BorderColor = System.Drawing.Color.White
            Me.xrTableRow1.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell29, Me.xrTableCell30, Me.xrTableCell31, Me.xrTableCell32, Me.xrTableCell33, Me.xrTableCell34, Me.xrTableCell35})
            Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableRow1.ForeColor = System.Drawing.Color.White
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 0.25842696629213485R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell29.Text = "Order ID:"
            Me.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell29.Weight = 0.10906298003072197R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell30.Text = "Customer ID:"
            Me.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell30.Weight = 0.130568356374808R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell31.Text = "Salesperson:"
            Me.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell31.Weight = 0.17357910906298002R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell32.Text = "Order Date:"
            Me.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell32.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell33
            ' 
            Me.xrTableCell33.Name = "xrTableCell33"
            Me.xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell33.Text = "Required Date:"
            Me.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell33.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell34
            ' 
            Me.xrTableCell34.Name = "xrTableCell34"
            Me.xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell34.Text = "Shipped Date:"
            Me.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell34.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell35
            ' 
            Me.xrTableCell35.Name = "xrTableCell35"
            Me.xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell35.Text = "Ship Via:"
            Me.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell35.Weight = 0.17665130568356374R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.xrTableRow2.BorderColor = System.Drawing.Color.White
            Me.xrTableRow2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clOrderID, Me.clCustomerID, Me.clSalesperson, Me.clOrderDate, Me.clRequiredDate, Me.clShippedDate, Me.clShipVia})
            Me.xrTableRow2.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 0.25842696629213485R
            ' 
            ' clOrderID
            ' 
            Me.clOrderID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.OrderID")})
            Me.clOrderID.Name = "clOrderID"
            Me.clOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clOrderID.Weight = 0.10906298003072197R
            ' 
            ' clCustomerID
            ' 
            Me.clCustomerID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.CustomerID")})
            Me.clCustomerID.Name = "clCustomerID"
            Me.clCustomerID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clCustomerID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clCustomerID.Weight = 0.130568356374808R
            ' 
            ' clSalesperson
            ' 
            Me.clSalesperson.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Salesperson")})
            Me.clSalesperson.Name = "clSalesperson"
            Me.clSalesperson.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clSalesperson.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clSalesperson.Weight = 0.17357910906298002R
            ' 
            ' clOrderDate
            ' 
            Me.clOrderDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.OrderDate", "{0:MM/dd/yyyy}")})
            Me.clOrderDate.Name = "clOrderDate"
            Me.clOrderDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clOrderDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clOrderDate.Weight = 0.13671274961597543R
            ' 
            ' clRequiredDate
            ' 
            Me.clRequiredDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.RequiredDate", "{0:MM/dd/yyyy}")})
            Me.clRequiredDate.Name = "clRequiredDate"
            Me.clRequiredDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clRequiredDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clRequiredDate.Weight = 0.13671274961597543R
            ' 
            ' clShippedDate
            ' 
            Me.clShippedDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShippedDate", "{0:MM/dd/yyyy}")})
            Me.clShippedDate.Name = "clShippedDate"
            Me.clShippedDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clShippedDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clShippedDate.Weight = 0.13671274961597543R
            ' 
            ' clShipVia
            ' 
            Me.clShipVia.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShippersCompanyName")})
            Me.clShipVia.Name = "clShipVia"
            Me.clShipVia.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clShipVia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clShipVia.Weight = 0.17665130568356374R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 0.2247191011235955R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrTableRow4.BorderColor = System.Drawing.Color.White
            Me.xrTableRow4.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell22, Me.xrTableCell24, Me.xrTableCell25, Me.xrTableCell26, Me.xrTableCell27, Me.xrTableCell28})
            Me.xrTableRow4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableRow4.ForeColor = System.Drawing.Color.White
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.25842696629213485R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell22.Text = "Product ID:"
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell22.Weight = 0.10906298003072197R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell24.Text = "Product Name:"
            Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell24.Weight = 0.30261136712749614R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell25.Text = "Quantity:"
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell25.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell26.Text = "Unit Price:"
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell26.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell27.Text = "Discount:"
            Me.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell27.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell28.Text = "Extended Price:"
            Me.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell28.Weight = 0.1781874039938556R
            ' 
            ' lbShipName
            ' 
            Me.lbShipName.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbShipName.BorderColor = System.Drawing.Color.White
            Me.lbShipName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShipName")})
            Me.lbShipName.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipName.LocationFloat = New DevExpress.Utils.PointFloat(72F, 17F)
            Me.lbShipName.Name = "lbShipName"
            Me.lbShipName.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipName.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipName.Text = "ShipName"
            Me.lbShipName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipAddress
            ' 
            Me.lbShipAddress.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbShipAddress.BorderColor = System.Drawing.Color.White
            Me.lbShipAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShipAddress")})
            Me.lbShipAddress.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipAddress.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipAddress.LocationFloat = New DevExpress.Utils.PointFloat(72F, 42F)
            Me.lbShipAddress.Name = "lbShipAddress"
            Me.lbShipAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipAddress.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipAddress.Text = "ShipAddress"
            Me.lbShipAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipCityRegionPostalCode
            ' 
            Me.lbShipCityRegionPostalCode.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbShipCityRegionPostalCode.BorderColor = System.Drawing.Color.White
            Me.lbShipCityRegionPostalCode.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipCityRegionPostalCode.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipCityRegionPostalCode.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipCityRegionPostalCode.LocationFloat = New DevExpress.Utils.PointFloat(72F, 67F)
            Me.lbShipCityRegionPostalCode.Name = "lbShipCityRegionPostalCode"
            Me.lbShipCityRegionPostalCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipCityRegionPostalCode.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipCityRegionPostalCode.Text = "ShipCityRegionPostalCode"
            Me.lbShipCityRegionPostalCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipCountry
            ' 
            Me.lbShipCountry.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbShipCountry.BorderColor = System.Drawing.Color.White
            Me.lbShipCountry.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipCountry.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShipCountry")})
            Me.lbShipCountry.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipCountry.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipCountry.LocationFloat = New DevExpress.Utils.PointFloat(72F, 92F)
            Me.lbShipCountry.Name = "lbShipCountry"
            Me.lbShipCountry.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipCountry.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipCountry.Text = "ShipCountry"
            Me.lbShipCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbAddress1
            ' 
            Me.lbAddress1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbAddress1.BorderColor = System.Drawing.Color.White
            Me.lbAddress1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbAddress1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Address")})
            Me.lbAddress1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbAddress1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbAddress1.LocationFloat = New DevExpress.Utils.PointFloat(425F, 42F)
            Me.lbAddress1.Name = "lbAddress1"
            Me.lbAddress1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbAddress1.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbAddress1.Text = "Address"
            Me.lbAddress1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbCountry
            ' 
            Me.lbCountry.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbCountry.BorderColor = System.Drawing.Color.White
            Me.lbCountry.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCountry.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Country")})
            Me.lbCountry.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbCountry.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbCountry.LocationFloat = New DevExpress.Utils.PointFloat(425F, 92F)
            Me.lbCountry.Name = "lbCountry"
            Me.lbCountry.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbCountry.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbCountry.Text = "Country"
            Me.lbCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbCompanyName
            ' 
            Me.lbCompanyName.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbCompanyName.BorderColor = System.Drawing.Color.White
            Me.lbCompanyName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCompanyName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.CustomersCompanyName")})
            Me.lbCompanyName.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbCompanyName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(425F, 17F)
            Me.lbCompanyName.Name = "lbCompanyName"
            Me.lbCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbCompanyName.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbCompanyName.Text = "CompanyName"
            Me.lbCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbCityRegionPostalCode
            ' 
            Me.lbCityRegionPostalCode.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.lbCityRegionPostalCode.BorderColor = System.Drawing.Color.White
            Me.lbCityRegionPostalCode.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCityRegionPostalCode.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbCityRegionPostalCode.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbCityRegionPostalCode.LocationFloat = New DevExpress.Utils.PointFloat(425F, 67F)
            Me.lbCityRegionPostalCode.Name = "lbCityRegionPostalCode"
            Me.lbCityRegionPostalCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbCityRegionPostalCode.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbCityRegionPostalCode.Text = "CityRegionPostalCode"
            Me.lbCityRegionPostalCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupFooter0
            ' 
            Me.GroupFooter0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable3})
            Me.GroupFooter0.HeightF = 79.99998F
            Me.GroupFooter0.Name = "GroupFooter0"
            Me.GroupFooter0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupFooter0.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.GroupFooter0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(1F, 0F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow6, Me.xrTableRow7, Me.xrTableRow8})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(648F, 75F)
            Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell8, Me.clSubtotal})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow6.Weight = 0.33333333333333331R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 0.68827160493827155R
            ' 
            ' clSubtotal
            ' 
            Me.clSubtotal.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.clSubtotal.BorderColor = System.Drawing.Color.White
            Me.clSubtotal.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.clSubtotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ExtendedPrice")})
            Me.clSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.clSubtotal.ForeColor = System.Drawing.Color.Black
            Me.clSubtotal.Name = "clSubtotal"
            Me.clSubtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            xrSummary1.FormatString = "{0:'SubTotal:  '$#,##.00}"
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.clSubtotal.Summary = xrSummary1
            Me.clSubtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clSubtotal.Weight = 0.31172839506172839R
            Me.clSubtotal.XlsxFormatString = """SubTotal: ""$#,##.00"
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell2, Me.clFreight})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow7.Weight = 0.33333333333333331R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell2.Weight = 0.68827160493827155R
            ' 
            ' clFreight
            ' 
            Me.clFreight.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.clFreight.BorderColor = System.Drawing.Color.White
            Me.clFreight.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.clFreight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Freight", "{0:'Frieght:  '$#,##.00}")})
            Me.clFreight.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.clFreight.ForeColor = System.Drawing.Color.Black
            Me.clFreight.Name = "clFreight"
            Me.clFreight.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clFreight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clFreight.Weight = 0.31172839506172839R
            Me.clFreight.XlsxFormatString = """Frieght: ""$#,##.00"
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell10, Me.clTotal})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow8.Weight = 0.33333333333333331R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell10.Weight = 0.68827160493827155R
            ' 
            ' clTotal
            ' 
            Me.clTotal.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.clTotal.BorderColor = System.Drawing.Color.White
            Me.clTotal.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.clTotal.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.clTotal.ForeColor = System.Drawing.Color.Black
            Me.clTotal.Name = "clTotal"
            Me.clTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F)
            Me.clTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clTotal.Weight = 0.31172839506172839R
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Format = "{0:d}"
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(561F, 100F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(87F, 16F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LineWidth = 3
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 92F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine1.SizeF = New System.Drawing.SizeF(648F, 8F)
            ' 
            ' lbDate
            ' 
            Me.lbDate.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbDate.ForeColor = System.Drawing.Color.Black
            Me.lbDate.LocationFloat = New DevExpress.Utils.PointFloat(511F, 100F)
            Me.lbDate.Name = "lbDate"
            Me.lbDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbDate.SizeF = New System.Drawing.SizeF(49F, 20F)
            Me.lbDate.Text = "Date:"
            Me.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbAddress
            ' 
            Me.lbAddress.Font = New System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic)
            Me.lbAddress.ForeColor = System.Drawing.Color.Black
            Me.lbAddress.LocationFloat = New DevExpress.Utils.PointFloat(8F, 100F)
            Me.lbAddress.Multiline = True
            Me.lbAddress.Name = "lbAddress"
            Me.lbAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbAddress.SizeF = New System.Drawing.SizeF(258F, 33F)
            Me.lbAddress.Text = "One Portals Way, Twin Points WA  98156" & ControlChars.CrLf & "Phone: 1-206-555-1417   Fax: 1-206-555-59" & "38"
            Me.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbInvoice
            ' 
            Me.lbInvoice.Font = New System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold)
            Me.lbInvoice.ForeColor = System.Drawing.Color.Black
            Me.lbInvoice.LocationFloat = New DevExpress.Utils.PointFloat(511F, 0F)
            Me.lbInvoice.Name = "lbInvoice"
            Me.lbInvoice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbInvoice.SizeF = New System.Drawing.SizeF(129F, 33F)
            Me.lbInvoice.Text = "INVOICE"
            Me.lbInvoice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.Image = (CType(resources.GetObject("xrPictureBox2.Image"), System.Drawing.Image))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(94F, 18F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(189F, 45F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrPageInfo1, Me.lbDate, Me.lbInvoice, Me.xrPictureBox2, Me.xrLine1, Me.lbAddress})
            Me.PageHeader.HeightF = 136F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 1F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(87.5F, 87.5F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox3})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox3
            ' 
            Me.xrPictureBox3.Image = (CType(resources.GetObject("xrPictureBox3.Image"), System.Drawing.Image))
            Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(254F, 13F)
            Me.xrPictureBox3.Name = "xrPictureBox3"
            Me.xrPictureBox3.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
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
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "Orders"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CustomerID"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "EmployeeID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "OrderDate"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "RequiredDate"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "ShippedDate"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ShipVia"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Freight"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ShipName"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "ShipAddress"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "ShipCity"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "ShipRegion"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "ShipPostalCode"
            columnExpression13.Table = table1
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "ShipCountry"
            columnExpression14.Table = table1
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "UnitPrice"
            table2.Name = "OrderDetails"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Quantity"
            columnExpression16.Table = table2
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "Discount"
            columnExpression17.Table = table2
            column17.Expression = columnExpression17
            columnExpression18.ColumnName = "ProductID"
            table3.Name = "Products"
            columnExpression18.Table = table3
            column18.Expression = columnExpression18
            columnExpression19.ColumnName = "ProductName"
            columnExpression19.Table = table3
            column19.Expression = columnExpression19
            columnExpression20.ColumnName = "LastName"
            table4.Name = "Employees"
            columnExpression20.Table = table4
            column20.Expression = columnExpression20
            columnExpression21.ColumnName = "FirstName"
            columnExpression21.Table = table4
            column21.Expression = columnExpression21
            column22.Alias = "CustomersCompanyName"
            columnExpression22.ColumnName = "CompanyName"
            table5.Name = "Customers"
            columnExpression22.Table = table5
            column22.Expression = columnExpression22
            columnExpression23.ColumnName = "Address"
            columnExpression23.Table = table5
            column23.Expression = columnExpression23
            columnExpression24.ColumnName = "City"
            columnExpression24.Table = table5
            column24.Expression = columnExpression24
            columnExpression25.ColumnName = "Region"
            columnExpression25.Table = table5
            column25.Expression = columnExpression25
            columnExpression26.ColumnName = "PostalCode"
            columnExpression26.Table = table5
            column26.Expression = columnExpression26
            columnExpression27.ColumnName = "Country"
            columnExpression27.Table = table5
            column27.Expression = columnExpression27
            column28.Alias = "ShippersCompanyName"
            columnExpression28.ColumnName = "CompanyName"
            table6.Name = "Shippers"
            columnExpression28.Table = table6
            column28.Expression = columnExpression28
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Columns.Add(column12)
            selectQuery1.Columns.Add(column13)
            selectQuery1.Columns.Add(column14)
            selectQuery1.Columns.Add(column15)
            selectQuery1.Columns.Add(column16)
            selectQuery1.Columns.Add(column17)
            selectQuery1.Columns.Add(column18)
            selectQuery1.Columns.Add(column19)
            selectQuery1.Columns.Add(column20)
            selectQuery1.Columns.Add(column21)
            selectQuery1.Columns.Add(column22)
            selectQuery1.Columns.Add(column23)
            selectQuery1.Columns.Add(column24)
            selectQuery1.Columns.Add(column25)
            selectQuery1.Columns.Add(column26)
            selectQuery1.Columns.Add(column27)
            selectQuery1.Columns.Add(column28)
            selectQuery1.FilterString = "Orders.OrderID < 10261"
            selectQuery1.Name = "Invoices"
            relationColumnInfo1.NestedKeyColumn = "OrderID"
            relationColumnInfo1.ParentKeyColumn = "OrderID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            relationColumnInfo2.NestedKeyColumn = "ProductID"
            relationColumnInfo2.ParentKeyColumn = "ProductID"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table3
            join2.Parent = table2
            relationColumnInfo3.NestedKeyColumn = "EmployeeID"
            relationColumnInfo3.ParentKeyColumn = "EmployeeID"
            join3.KeyColumns.Add(relationColumnInfo3)
            join3.Nested = table4
            join3.Parent = table1
            relationColumnInfo4.NestedKeyColumn = "CustomerID"
            relationColumnInfo4.ParentKeyColumn = "CustomerID"
            join4.KeyColumns.Add(relationColumnInfo4)
            join4.Nested = table5
            join4.Parent = table1
            relationColumnInfo5.NestedKeyColumn = "ShipperID"
            relationColumnInfo5.ParentKeyColumn = "ShipVia"
            join5.KeyColumns.Add(relationColumnInfo5)
            join5.Nested = table6
            join5.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Relations.Add(join3)
            selectQuery1.Relations.Add(join4)
            selectQuery1.Relations.Add(join5)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            selectQuery1.Tables.Add(table3)
            selectQuery1.Tables.Add(table4)
            selectQuery1.Tables.Add(table5)
            selectQuery1.Tables.Add(table6)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' ExtendedPrice
            ' 
            Me.ExtendedPrice.DataMember = "Invoices"
            Me.ExtendedPrice.Expression = "[UnitPrice]*[Quantity]*(1-[Discount])"
            Me.ExtendedPrice.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal
            Me.ExtendedPrice.Name = "ExtendedPrice"
            ' 
            ' SalesPerson
            ' 
            Me.SalesPerson.DataMember = "Invoices"
            Me.SalesPerson.Expression = "[FirstName] + ' ' + [LastName]"
            Me.SalesPerson.Name = "SalesPerson"
            ' 
            ' InvoiceReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.GroupHeader0, Me.Detail, Me.GroupFooter0, Me.PageHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.ExtendedPrice, Me.SalesPerson})
            Me.DataMember = "Invoices"
            Me.DataSource = Me.sqlDataSource1
            Me.Margins = New System.Drawing.Printing.Margins(99, 95, 100, 75)
            Me.ReportPrintOptions.DetailCountAtDesignTime = 4
            Me.Version = "16.1"
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private ExtendedPrice As DevExpress.XtraReports.UI.CalculatedField
        Private SalesPerson As DevExpress.XtraReports.UI.CalculatedField
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
