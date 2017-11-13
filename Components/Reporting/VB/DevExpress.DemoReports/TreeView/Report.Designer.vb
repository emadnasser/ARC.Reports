Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.TreeView
    Partial Public Class Report
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private lbTitle As DevExpress.XtraReports.UI.XRLabel
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private winControlContainer1 As DevExpress.XtraReports.UI.PrintableComponentContainer
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private components As System.ComponentModel.IContainer = Nothing
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.winControlContainer1 = New DevExpress.XtraReports.UI.PrintableComponentContainer()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.winControlContainer1})
            Me.Detail.HeightF = 122F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' winControlContainer1
            ' 
            Me.winControlContainer1.BackColor = System.Drawing.Color.Transparent
            Me.winControlContainer1.BorderColor = System.Drawing.SystemColors.ControlText
            Me.winControlContainer1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.winControlContainer1.BorderWidth = 1F
            Me.winControlContainer1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.winControlContainer1.Name = "winControlContainer1"
            Me.winControlContainer1.SizeF = New System.Drawing.SizeF(895F, 111F)
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrPageInfo2, Me.xrPageInfo1, Me.lbTitle})
            Me.ReportHeader.HeightF = 107F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 11.25F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25F, 50F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(98F, 24F)
            Me.xrLabel1.Text = "Current User:"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.BackColor = System.Drawing.Color.Transparent
            Me.xrPageInfo2.Font = New System.Drawing.Font("Tahoma", 11.25F)
            Me.xrPageInfo2.Format = "Date: {0}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(25F, 75F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(251F, 24F)
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.BackColor = System.Drawing.Color.Transparent
            Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 11.25F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(134F, 50F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.UserName
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(270F, 24F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.BackColor = System.Drawing.Color.Transparent
            Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 15.75F)
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(15F, 14F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(877F, 32F)
            Me.lbTitle.Text = "The World's Countries by Region"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(374F, 13F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
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
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 75)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Version = "15.2"
            Me.Watermark.Image = (CType(resources.GetObject("Report.Watermark.Image"), System.Drawing.Image))
            Me.Watermark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom
            Me.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.Horizontal
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    End Class
End Namespace
