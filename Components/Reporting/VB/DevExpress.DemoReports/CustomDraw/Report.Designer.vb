Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.CustomDraw
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private customControl1 As CustomControl
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private lbRegion As DevExpress.XtraReports.UI.XRLabel
        Private lbTitle As DevExpress.XtraReports.UI.XRLabel
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
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
            Dim staticListLookUpSettings1 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.customControl1 = New XtraReportsDemos.CustomDraw.CustomControl()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbRegion = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.RegionIdParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.customControl1})
            Me.Detail.HeightF = 400F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' customControl1
            ' 
            Me.customControl1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(247)))), (CInt((CByte(244)))), (CInt((CByte(241)))))
            Me.customControl1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(225)))), (CInt((CByte(215)))), (CInt((CByte(203)))))
            Me.customControl1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.customControl1.BorderWidth = 2F
            Me.customControl1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.customControl1.LocationFloat = New DevExpress.Utils.PointFloat(28F, 4F)
            Me.customControl1.Name = "customControl1"
            Me.customControl1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.customControl1.SizeF = New System.Drawing.SizeF(593F, 330F)
            Me.customControl1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbTitle, Me.xrLabel1, Me.lbRegion})
            Me.ReportHeader.HeightF = 88F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(173)))), (CInt((CByte(148)))), (CInt((CByte(116)))))
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbTitle.BorderWidth = 2F
            Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 14.25F)
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(45F, 8F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(554F, 30F)
            Me.lbTitle.Text = "Top 10 countries selected by population in percentage terms"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 18F)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(172)))), (CInt((CByte(135)))), (CInt((CByte(88)))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(510F, 49F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(110F, 29F)
            Me.xrLabel1.Text = "lbRegionName"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            ' 
            ' lbRegion
            ' 
            Me.lbRegion.BackColor = System.Drawing.Color.Transparent
            Me.lbRegion.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold)
            Me.lbRegion.ForeColor = System.Drawing.Color.Black
            Me.lbRegion.LocationFloat = New DevExpress.Utils.PointFloat(452F, 45F)
            Me.lbRegion.Name = "lbRegion"
            Me.lbRegion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbRegion.SizeF = New System.Drawing.SizeF(58F, 33F)
            Me.lbRegion.Text = "Region:"
            Me.lbRegion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
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
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' RegionIdParameter
            ' 
            Me.RegionIdParameter.Description = "Region:"
            staticListLookUpSettings1.FilterString = Nothing
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(1, "Africa"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(2, "Oceania"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(3, "Americas"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(4, "Asia"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(5, "Europe"))
            Me.RegionIdParameter.LookUpSettings = staticListLookUpSettings1
            Me.RegionIdParameter.Name = "RegionIdParameter"
            Me.RegionIdParameter.Type = GetType(Integer)
            Me.RegionIdParameter.ValueInfo = "1"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 75)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.RegionIdParameter})
            Me.RequestParameters = False
            Me.Version = "14.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private RegionIdParameter As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
