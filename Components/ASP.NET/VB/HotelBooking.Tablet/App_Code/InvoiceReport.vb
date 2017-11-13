Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class InvoiceReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Private detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private xrLine1 As DevExpress.XtraReports.UI.XRLine
    Public HotelDescriptionLabel As DevExpress.XtraReports.UI.XRLabel
    Private xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Public TotalPriceLabel As DevExpress.XtraReports.UI.XRLabel
    Private xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Public PriceTable As DevExpress.XtraReports.UI.XRTable
    Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Private xrLine3 As DevExpress.XtraReports.UI.XRLine
    Public CheckOutLabel As DevExpress.XtraReports.UI.XRLabel
    Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Public CheckInLabel As DevExpress.XtraReports.UI.XRLabel
    Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Public HotelAddressLabel As DevExpress.XtraReports.UI.XRLabel
    Public HotelNameLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public HotelSmallImagePictureBox As DevExpress.XtraReports.UI.XRPictureBox
    Private xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Public HotelLargeImagePictureBox As DevExpress.XtraReports.UI.XRPictureBox
    Public HotelAddressLine2Label As DevExpress.XtraReports.UI.XRLabel
    Public HotelAddressLine1Label As DevExpress.XtraReports.UI.XRLabel
    Public HotelNameLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Private xrLine4 As DevExpress.XtraReports.UI.XRLine
    Private xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Public RatingPictureBox As DevExpress.XtraReports.UI.XRPictureBox
    Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = Global.Resources.InvoiceReport.ResourceManager
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.RatingPictureBox = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.HotelDescriptionLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TotalPriceLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PriceTable = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.CheckOutLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.CheckInLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.HotelAddressLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.HotelNameLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.HotelSmallImagePictureBox = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.HotelLargeImagePictureBox = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.HotelAddressLine2Label = New DevExpress.XtraReports.UI.XRLabel()
            Me.HotelAddressLine1Label = New DevExpress.XtraReports.UI.XRLabel()
            Me.HotelNameLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine4 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me.PriceTable, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 53.04166F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.RatingPictureBox, Me.HotelDescriptionLabel, Me.xrLabel15, Me.TotalPriceLabel, Me.xrLabel13, Me.PriceTable, Me.xrLine3, Me.CheckOutLabel, Me.xrLabel11, Me.CheckInLabel, Me.xrLabel9, Me.HotelAddressLabel, Me.HotelNameLabel2, Me.HotelSmallImagePictureBox, Me.xrLine2, Me.xrLabel6, Me.HotelLargeImagePictureBox, Me.HotelAddressLine2Label, Me.HotelAddressLine1Label, Me.HotelNameLabel1})
            Me.detailBand1.HeightF = 614.5417F
            Me.detailBand1.Name = "detailBand1"
            ' 
            ' RatingPictureBox
            ' 
            Me.RatingPictureBox.Image = (CType(resources.GetObject("RatingPictureBox.Image"), System.Drawing.Image))
            Me.RatingPictureBox.LocationFloat = New DevExpress.Utils.PointFloat(195F, 0F)
            Me.RatingPictureBox.Name = "RatingPictureBox"
            Me.RatingPictureBox.SizeF = New System.Drawing.SizeF(180.2084F, 37.7917F)
            ' 
            ' HotelDescriptionLabel
            ' 
            Me.HotelDescriptionLabel.AutoWidth = True
            Me.HotelDescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.HotelDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(52)))), (CInt((CByte(52)))), (CInt((CByte(52)))))
            Me.HotelDescriptionLabel.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 514.9167F)
            Me.HotelDescriptionLabel.Multiline = True
            Me.HotelDescriptionLabel.Name = "HotelDescriptionLabel"
            Me.HotelDescriptionLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.HotelDescriptionLabel.SizeF = New System.Drawing.SizeF(750.9998F, 69.875F)
            Me.HotelDescriptionLabel.StylePriority.UseFont = False
            Me.HotelDescriptionLabel.StylePriority.UseForeColor = False
            Me.HotelDescriptionLabel.Text = "HotelDescriptionLabel"
            ' 
            ' xrLabel15
            ' 
            Me.xrLabel15.Font = New System.Drawing.Font("Segoe UI", 13.5F)
            Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 485F)
            Me.xrLabel15.Name = "xrLabel15"
            Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel15.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel15.StylePriority.UseFont = False
            Me.xrLabel15.Text = "Description"
            ' 
            ' TotalPriceLabel
            ' 
            Me.TotalPriceLabel.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.TotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(52)))), (CInt((CByte(52)))), (CInt((CByte(52)))))
            Me.TotalPriceLabel.LocationFloat = New DevExpress.Utils.PointFloat(624.1669F, 325.6667F)
            Me.TotalPriceLabel.Name = "TotalPriceLabel"
            Me.TotalPriceLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.TotalPriceLabel.SizeF = New System.Drawing.SizeF(126.8336F, 36.5416F)
            Me.TotalPriceLabel.StylePriority.UseFont = False
            Me.TotalPriceLabel.StylePriority.UseForeColor = False
            Me.TotalPriceLabel.StylePriority.UsePadding = False
            Me.TotalPriceLabel.StylePriority.UseTextAlignment = False
            Me.TotalPriceLabel.Text = "$1000.00"
            Me.TotalPriceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            ' 
            ' xrLabel13
            ' 
            Me.xrLabel13.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.xrLabel13.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 325.6667F)
            Me.xrLabel13.Name = "xrLabel13"
            Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 3, 100F)
            Me.xrLabel13.SizeF = New System.Drawing.SizeF(150.4168F, 36.54166F)
            Me.xrLabel13.StylePriority.UseFont = False
            Me.xrLabel13.StylePriority.UseForeColor = False
            Me.xrLabel13.StylePriority.UsePadding = False
            Me.xrLabel13.StylePriority.UseTextAlignment = False
            Me.xrLabel13.Text = "TOTAL"
            Me.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' PriceTable
            ' 
            Me.PriceTable.BorderColor = System.Drawing.Color.Transparent
            Me.PriceTable.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.PriceTable.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.PriceTable.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 300.6667F)
            Me.PriceTable.Name = "PriceTable"
            Me.PriceTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.PriceTable.SizeF = New System.Drawing.SizeF(277.2503F, 25F)
            Me.PriceTable.StylePriority.UseBorderColor = False
            Me.PriceTable.StylePriority.UseFont = False
            Me.PriceTable.StylePriority.UseForeColor = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 2.3621389289424295R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(52)))), (CInt((CByte(52)))), (CInt((CByte(52)))))
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StylePriority.UseForeColor = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "$323.22"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell3.Weight = 1.1866659014754952R
            ' 
            ' xrLine3
            ' 
            Me.xrLine3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(191)))), (CInt((CByte(191)))))
            Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 277.6667F)
            Me.xrLine3.Name = "xrLine3"
            Me.xrLine3.SizeF = New System.Drawing.SizeF(277.2503F, 23F)
            Me.xrLine3.StylePriority.UseForeColor = False
            ' 
            ' CheckOutLabel
            ' 
            Me.CheckOutLabel.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.CheckOutLabel.LocationFloat = New DevExpress.Utils.PointFloat(577.0834F, 246.7084F)
            Me.CheckOutLabel.Name = "CheckOutLabel"
            Me.CheckOutLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.CheckOutLabel.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.CheckOutLabel.StylePriority.UseFont = False
            Me.CheckOutLabel.Text = "03/20/2014"
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.xrLabel11.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(577.0833F, 223.7083F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(100F, 23.00002F)
            Me.xrLabel11.StylePriority.UseFont = False
            Me.xrLabel11.StylePriority.UseForeColor = False
            Me.xrLabel11.Text = "Check out"
            ' 
            ' CheckInLabel
            ' 
            Me.CheckInLabel.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.CheckInLabel.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 246.7084F)
            Me.CheckInLabel.Name = "CheckInLabel"
            Me.CheckInLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.CheckInLabel.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.CheckInLabel.StylePriority.UseFont = False
            Me.CheckInLabel.StylePriority.UsePadding = False
            Me.CheckInLabel.Text = "03/20/2014"
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.xrLabel9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 223.7083F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(100F, 23.00002F)
            Me.xrLabel9.StylePriority.UseFont = False
            Me.xrLabel9.StylePriority.UseForeColor = False
            Me.xrLabel9.StylePriority.UsePadding = False
            Me.xrLabel9.Text = "Check in"
            ' 
            ' HotelAddressLabel
            ' 
            Me.HotelAddressLabel.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.HotelAddressLabel.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.HotelAddressLabel.LocationFloat = New DevExpress.Utils.PointFloat(554.1667F, 166.2916F)
            Me.HotelAddressLabel.Multiline = True
            Me.HotelAddressLabel.Name = "HotelAddressLabel"
            Me.HotelAddressLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.HotelAddressLabel.SizeF = New System.Drawing.SizeF(196.8333F, 22.99998F)
            Me.HotelAddressLabel.StylePriority.UseFont = False
            Me.HotelAddressLabel.StylePriority.UseForeColor = False
            Me.HotelAddressLabel.StylePriority.UsePadding = False
            Me.HotelAddressLabel.Text = "Hollywood Hotel / The Hotel"
            ' 
            ' HotelNameLabel2
            ' 
            Me.HotelNameLabel2.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.HotelNameLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(52)))), (CInt((CByte(52)))), (CInt((CByte(52)))))
            Me.HotelNameLabel2.LocationFloat = New DevExpress.Utils.PointFloat(554.1666F, 143.2916F)
            Me.HotelNameLabel2.Multiline = True
            Me.HotelNameLabel2.Name = "HotelNameLabel2"
            Me.HotelNameLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F)
            Me.HotelNameLabel2.SizeF = New System.Drawing.SizeF(196.8334F, 23F)
            Me.HotelNameLabel2.StylePriority.UseFont = False
            Me.HotelNameLabel2.StylePriority.UseForeColor = False
            Me.HotelNameLabel2.StylePriority.UsePadding = False
            Me.HotelNameLabel2.Text = "Hollywood Hotel / The Hotel"
            ' 
            ' HotelSmallImagePictureBox
            ' 
            Me.HotelSmallImagePictureBox.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(200)))), (CInt((CByte(199)))), (CInt((CByte(199)))))
            Me.HotelSmallImagePictureBox.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.HotelSmallImagePictureBox.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 143.2916F)
            Me.HotelSmallImagePictureBox.Name = "HotelSmallImagePictureBox"
            Me.HotelSmallImagePictureBox.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
            Me.HotelSmallImagePictureBox.SizeF = New System.Drawing.SizeF(69.99997F, 70F)
            Me.HotelSmallImagePictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            Me.HotelSmallImagePictureBox.StylePriority.UseBorderColor = False
            Me.HotelSmallImagePictureBox.StylePriority.UseBorders = False
            Me.HotelSmallImagePictureBox.StylePriority.UsePadding = False
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.BorderWidth = 1F
            Me.xrLine2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(191)))), (CInt((CByte(191)))))
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 113F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.SizeF = New System.Drawing.SizeF(277.2498F, 18.83335F)
            Me.xrLine2.StylePriority.UseBorderWidth = False
            Me.xrLine2.StylePriority.UseForeColor = False
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.Font = New System.Drawing.Font("Segoe UI", 13.5F)
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(473.7501F, 89.99999F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(277.25F, 22.99998F)
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.StylePriority.UsePadding = False
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            Me.xrLabel6.Text = "Your Reservation Summary"
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' HotelLargeImagePictureBox
            ' 
            Me.HotelLargeImagePictureBox.LocationFloat = New DevExpress.Utils.PointFloat(0F, 89.99999F)
            Me.HotelLargeImagePictureBox.Name = "HotelLargeImagePictureBox"
            Me.HotelLargeImagePictureBox.SizeF = New System.Drawing.SizeF(445.2083F, 372.9166F)
            ' 
            ' HotelAddressLine2Label
            ' 
            Me.HotelAddressLine2Label.AutoWidth = True
            Me.HotelAddressLine2Label.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.HotelAddressLine2Label.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.HotelAddressLine2Label.LocationFloat = New DevExpress.Utils.PointFloat(0F, 60.79175F)
            Me.HotelAddressLine2Label.Multiline = True
            Me.HotelAddressLine2Label.Name = "HotelAddressLine2Label"
            Me.HotelAddressLine2Label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.HotelAddressLine2Label.SizeF = New System.Drawing.SizeF(250.4167F, 22.99998F)
            Me.HotelAddressLine2Label.StylePriority.UseFont = False
            Me.HotelAddressLine2Label.StylePriority.UseForeColor = False
            Me.HotelAddressLine2Label.Text = "Address Line 2"
            ' 
            ' HotelAddressLine1Label
            ' 
            Me.HotelAddressLine1Label.AutoWidth = True
            Me.HotelAddressLine1Label.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.HotelAddressLine1Label.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.HotelAddressLine1Label.LocationFloat = New DevExpress.Utils.PointFloat(0F, 37.79173F)
            Me.HotelAddressLine1Label.Name = "HotelAddressLine1Label"
            Me.HotelAddressLine1Label.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.HotelAddressLine1Label.SizeF = New System.Drawing.SizeF(250.4167F, 23F)
            Me.HotelAddressLine1Label.StylePriority.UseFont = False
            Me.HotelAddressLine1Label.StylePriority.UseForeColor = False
            Me.HotelAddressLine1Label.Text = "Address Line 1"
            ' 
            ' HotelNameLabel1
            ' 
            Me.HotelNameLabel1.AutoWidth = True
            Me.HotelNameLabel1.Font = New System.Drawing.Font("Times New Roman", 18F)
            Me.HotelNameLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(52)))), (CInt((CByte(52)))), (CInt((CByte(52)))))
            Me.HotelNameLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 4F)
            Me.HotelNameLabel1.Name = "HotelNameLabel1"
            Me.HotelNameLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.HotelNameLabel1.SizeF = New System.Drawing.SizeF(179.5833F, 30.29167F)
            Me.HotelNameLabel1.StylePriority.UseFont = False
            Me.HotelNameLabel1.StylePriority.UseForeColor = False
            Me.HotelNameLabel1.Text = "Hollywood Hotel"
            Me.HotelNameLabel1.WordWrap = False
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 17F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1, Me.xrPictureBox1, Me.xrLine1})
            Me.ReportHeader.HeightF = 86.625F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(215.6249F, 3F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(229.5834F, 19F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.Text = "ASP.NET CONTROLS AND LIBRARIES"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(215.6249F, 22.20832F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(214.5833F, 17.79167F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "POWERED BY DEVEXPRESS"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(189.5833F, 40F)
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(191)))), (CInt((CByte(191)))))
            Me.xrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(189.5833F, 0F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(26.04164F, 39.99999F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4, Me.xrLine4, Me.xrLabel17})
            Me.ReportFooter.HeightF = 77F
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.PrintAtBottom = True
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(577.0833F, 33.41668F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(173.9167F, 37.58335F)
            ' 
            ' xrLine4
            ' 
            Me.xrLine4.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(191)))), (CInt((CByte(191)))))
            Me.xrLine4.LineWidth = 2
            Me.xrLine4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLine4.Name = "xrLine4"
            Me.xrLine4.SizeF = New System.Drawing.SizeF(751.0001F, 23.00002F)
            Me.xrLine4.StylePriority.UseForeColor = False
            ' 
            ' xrLabel17
            ' 
            Me.xrLabel17.AutoWidth = True
            Me.xrLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.xrLabel17.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(103)))), (CInt((CByte(103)))), (CInt((CByte(103)))))
            Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 23.00002F)
            Me.xrLabel17.Name = "xrLabel17"
            Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel17.SizeF = New System.Drawing.SizeF(568.5417F, 48.00002F)
            Me.xrLabel17.StylePriority.UseFont = False
            Me.xrLabel17.StylePriority.UseForeColor = False
            Me.xrLabel17.Text = "This ASP.NET web report was generated with DevExpress Reporting which is included" & " in DevExpress ASP.NET Subscription and supports both WebForms and MVC. "
            ' 
            ' InvoiceReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.ReportHeader, Me.ReportFooter})
            Me.Margins = New System.Drawing.Printing.Margins(50, 49, 53, 17)
            Me.Version = "14.2"
            CType(Me.PriceTable, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
