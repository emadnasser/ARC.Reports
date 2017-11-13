Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.Sparkline
    Public Class Report
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand
        Private Detail As DetailBand
        Private bottomMarginBand1 As BottomMarginBand
        Private GroupHeader As GroupHeaderBand
        Private calcSum As CalculatedField
        Private calcAverage As CalculatedField
        Private GroupFooter As GroupFooterBand
        Private tableDetail As XRTable
        Private xrTableRow1 As XRTableRow
        Private xrTableCell1 As XRTableCell
        Private xrTableCell2 As XRTableCell
        Private xrTableCell3 As XRTableCell
        Private xrTableCell4 As XRTableCell
        Private sparkline As XRSparkline
        Private tableGroupFooter As XRTable
        Private xrTableRow3 As XRTableRow
        Private xrTableCell10 As XRTableCell
        Private xrTableCell11 As XRTableCell
        Private xrTableCell12 As XRTableCell
        Private xrTableCell13 As XRTableCell
        Private PageHeader As PageHeaderBand
        Private tablePageHeader As XRTable
        Private xrTableRow2 As XRTableRow
        Private xrTableCell5 As XRTableCell
        Private xrTableCell6 As XRTableCell
        Private xrTableCell7 As XRTableCell
        Private xrTableCell8 As XRTableCell
        Private xrTableCell9 As XRTableCell
        Private tableGroupHeader As XRTable
        Private xrTableRow4 As XRTableRow
        Private xrTableCell14 As XRTableCell
        Private xrTableCell15 As XRTableCell
        Friend xrPictureBox1 As XRPictureBox
        Private xrPageInfo1 As XRPageInfo
        Private xrTableCell16 As XRTableCell
        Private oddStyle As XRControlStyle
        Private dsContacts1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
        Private evenStyle As XRControlStyle

        Public Sub New()
            InitializeComponent()
            AddHandler sparkline.BeforePrint, AddressOf xrSparkline1_BeforePrint
        End Sub

        Private Sub xrSparkline1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            Dim values As New List(Of Double)()
            Dim months() As String = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
            For Each month As String In months
                values.Add(GetCurrentColumnValue(Of Double)(month))
            Next month
            sparkline.DataSource = values
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim lineSparklineView1 As New DevExpress.Sparkline.LineSparklineView()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
            Dim xrSummary3 As New DevExpress.XtraReports.UI.XRSummary()
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
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.sparkline = New DevExpress.XtraReports.UI.XRSparkline()
            Me.tableDetail = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.GroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.tableGroupHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.calcSum = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calcAverage = New DevExpress.XtraReports.UI.CalculatedField()
            Me.GroupFooter = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.tableGroupFooter = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.tablePageHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.oddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.evenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.dsContacts1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.tableDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tableGroupHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tableGroupFooter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tablePageHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            Me.topMarginBand1.StylePriority.UseFont = False
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.sparkline, Me.tableDetail})
            Me.Detail.EvenStyleName = "evenStyle"
            Me.Detail.HeightF = 43F
            Me.Detail.Name = "Detail"
            Me.Detail.OddStyleName = "oddStyle"
            ' 
            ' sparkline
            ' 
            Me.sparkline.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
            Me.sparkline.LocationFloat = New DevExpress.Utils.PointFloat(435F, 0F)
            Me.sparkline.Name = "sparkline"
            Me.sparkline.SizeF = New System.Drawing.SizeF(215F, 43F)
            Me.sparkline.StylePriority.UseBorders = False
            lineSparklineView1.Color = System.Drawing.Color.FromArgb((CInt((CByte(116)))), (CInt((CByte(197)))), (CInt((CByte(195)))))
            lineSparklineView1.HighlightMaxPoint = True
            lineSparklineView1.HighlightMinPoint = True
            lineSparklineView1.MaxPointColor = System.Drawing.Color.FromArgb((CInt((CByte(150)))), (CInt((CByte(3)))), (CInt((CByte(94)))))
            lineSparklineView1.MaxPointMarkerSize = 6
            lineSparklineView1.MinPointColor = System.Drawing.Color.FromArgb((CInt((CByte(17)))), (CInt((CByte(116)))), (CInt((CByte(167)))))
            lineSparklineView1.MinPointMarkerSize = 6
            Me.sparkline.View = lineSparklineView1
            Me.sparkline.XlsxFormatString = Nothing
            ' 
            ' tableDetail
            ' 
            Me.tableDetail.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.tableDetail.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tableDetail.Name = "tableDetail"
            Me.tableDetail.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableDetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.tableDetail.SizeF = New System.Drawing.SizeF(435F, 43F)
            Me.tableDetail.StylePriority.UseBorders = False
            Me.tableDetail.StylePriority.UsePadding = False
            Me.tableDetail.StylePriority.UseTextAlignment = False
            Me.tableDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.ID")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.280021918927671R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.Customer Name")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell2.Weight = 1.4401123702185R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.calcSum", "{0:c}")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Weight = 0.880068677022519R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.calcAverage", "{0:c}")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Weight = 0.880068815054061R
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPictureBox1})
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Format = "Page : {0 } / {1}"
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(570.75F, 10.00001F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(79.25F, 21.16667F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(249F, 30F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' GroupHeader
            ' 
            Me.GroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tableGroupHeader})
            Me.GroupHeader.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Year", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader.HeightF = 36F
            Me.GroupHeader.Name = "GroupHeader"
            ' 
            ' tableGroupHeader
            ' 
            Me.tableGroupHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tableGroupHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tableGroupHeader.Name = "tableGroupHeader"
            Me.tableGroupHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
            Me.tableGroupHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow4})
            Me.tableGroupHeader.SizeF = New System.Drawing.SizeF(650F, 36F)
            Me.tableGroupHeader.StylePriority.UseTextAlignment = False
            Me.tableGroupHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell14, Me.xrTableCell15})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Weight = 1R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.Year", "Year: {0}")})
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.StylePriority.UseTextAlignment = False
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell14.Weight = 1.40576914860652R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.Customer Name", "(count==={0})")})
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.StylePriority.UseBorders = False
            xrSummary1.FormatString = "(count={0})"
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrTableCell15.Summary = xrSummary1
            Me.xrTableCell15.Weight = 1.59423085139348R
            ' 
            ' calcSum
            ' 
            Me.calcSum.DataMember = "CustomersPayment"
            Me.calcSum.DisplayName = "Sum"
            Me.calcSum.Expression = "[April] + [August] + [December] + [February] + [January] + [July] + [June] + [Mar" & "ch] + [May] + [November] + [October] + [September]"
            Me.calcSum.FieldType = DevExpress.XtraReports.UI.FieldType.Double
            Me.calcSum.Name = "calcSum"
            ' 
            ' calcAverage
            ' 
            Me.calcAverage.DataMember = "CustomersPayment"
            Me.calcAverage.DisplayName = "Average"
            Me.calcAverage.Expression = "[calcSum] / 12.0"
            Me.calcAverage.FieldType = DevExpress.XtraReports.UI.FieldType.Double
            Me.calcAverage.Name = "calcAverage"
            ' 
            ' GroupFooter
            ' 
            Me.GroupFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tableGroupFooter})
            Me.GroupFooter.HeightF = 30F
            Me.GroupFooter.Name = "GroupFooter"
            ' 
            ' tableGroupFooter
            ' 
            Me.tableGroupFooter.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.tableGroupFooter.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tableGroupFooter.Name = "tableGroupFooter"
            Me.tableGroupFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.tableGroupFooter.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow3})
            Me.tableGroupFooter.SizeF = New System.Drawing.SizeF(650F, 30F)
            Me.tableGroupFooter.StylePriority.UseBorders = False
            Me.tableGroupFooter.StylePriority.UsePadding = False
            Me.tableGroupFooter.StylePriority.UseTextAlignment = False
            Me.tableGroupFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell10, Me.xrTableCell16, Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell13})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 1R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Weight = 0.203225842748793R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Weight = 1.04516120486701R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.calcSum")})
            Me.xrTableCell11.Name = "xrTableCell11"
            xrSummary2.FormatString = "{0:c}"
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrTableCell11.Summary = xrSummary2
            Me.xrTableCell11.Weight = 0.638709829467386R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomersPayment.calcAverage")})
            Me.xrTableCell12.Name = "xrTableCell12"
            xrSummary3.FormatString = "{0:c}"
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrTableCell12.Summary = xrSummary3
            Me.xrTableCell12.Weight = 0.638709652268553R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.StylePriority.UseBorders = False
            Me.xrTableCell13.Weight = 1.24838687041697R
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tablePageHeader})
            Me.PageHeader.HeightF = 26F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.StylePriority.UseFont = False
            ' 
            ' tablePageHeader
            ' 
            Me.tablePageHeader.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(143)))), (CInt((CByte(143)))), (CInt((CByte(143)))))
            Me.tablePageHeader.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(122)))), (CInt((CByte(122)))), (CInt((CByte(122)))))
            Me.tablePageHeader.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.tablePageHeader.ForeColor = System.Drawing.Color.White
            Me.tablePageHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tablePageHeader.Name = "tablePageHeader"
            Me.tablePageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 3, 0, 0, 100F)
            Me.tablePageHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.tablePageHeader.SizeF = New System.Drawing.SizeF(650F, 26F)
            Me.tablePageHeader.StylePriority.UseBackColor = False
            Me.tablePageHeader.StylePriority.UseBorderColor = False
            Me.tablePageHeader.StylePriority.UseBorders = False
            Me.tablePageHeader.StylePriority.UseForeColor = False
            Me.tablePageHeader.StylePriority.UsePadding = False
            Me.tablePageHeader.StylePriority.UseTextAlignment = False
            Me.tablePageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "ID"
            Me.xrTableCell5.Weight = 0.161538455669696R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StylePriority.UseBackColor = False
            Me.xrTableCell6.Text = "Customer Name"
            Me.xrTableCell6.Weight = 0.830769260113056R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Text = "Sum"
            Me.xrTableCell7.Weight = 0.507692295954778R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Text = "Average"
            Me.xrTableCell8.Weight = 0.507692319429838R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Text = "Payments"
            Me.xrTableCell9.Weight = 0.992307668832632R
            ' 
            ' oddStyle
            ' 
            Me.oddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(210)))), (CInt((CByte(210)))))
            Me.oddStyle.Name = "oddStyle"
            Me.oddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' evenStyle
            ' 
            Me.evenStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(247)))), (CInt((CByte(247)))), (CInt((CByte(247)))))
            Me.evenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(210)))), (CInt((CByte(210)))))
            Me.evenStyle.Name = "evenStyle"
            Me.evenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' dsContacts1
            ' 
            Me.dsContacts1.ConnectionName = "ContactsConnectionString"
            Me.dsContacts1.Name = "dsContacts1"
            columnExpression1.ColumnName = "ID"
            table1.Name = "CustomersPayment"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Customer Name"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Year"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "January"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "February"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "March"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "April"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "May"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "June"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "July"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "August"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "September"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "October"
            columnExpression13.Table = table1
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "November"
            columnExpression14.Table = table1
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "December"
            columnExpression15.Table = table1
            column15.Expression = columnExpression15
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
            selectQuery1.Name = "CustomersPayment"
            selectQuery1.Tables.Add(table1)
            Me.dsContacts1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsContacts1.ResultSchemaSerializable = resources.GetString("dsContacts1.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.Detail, Me.bottomMarginBand1, Me.GroupHeader, Me.GroupFooter, Me.PageHeader})
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(210)))), (CInt((CByte(210)))))
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calcSum, Me.calcAverage})
            Me.DataMember = "CustomersPayment"
            Me.DataSource = Me.dsContacts1
            Me.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.oddStyle, Me.evenStyle})
            Me.Version = "16.1"
            CType(Me.tableDetail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tableGroupHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tableGroupFooter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tablePageHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
