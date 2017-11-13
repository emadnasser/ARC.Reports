Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.Charts
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private lbTitle As DevExpress.XtraReports.UI.XRLabel
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupHeader As DevExpress.XtraReports.UI.XRControlStyle
        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
        Public xrChart1 As DevExpress.XtraReports.UI.XRChart
        Private xrlblCategoryName As DevExpress.XtraReports.UI.XRLabel
        Private CategoryStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private components As System.ComponentModel.IContainer = Nothing
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
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
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim efConnectionParameters1 As New DevExpress.DataAccess.EntityFramework.EFConnectionParameters()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Dim staticListLookUpSettings1 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.efDataSource1 = New DevExpress.DataAccess.EntityFramework.EFDataSource(Me.components)
            Me.xrlblCategoryName = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.CategoryStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.AppearanceParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ColorEachParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.efDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.Transparent
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(232)))), (CInt((CByte(205)))), (CInt((CByte(162)))))
            Me.OddStyle.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide))
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.OddStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.OddStyle.Name = "OddStyle"
            ' 
            ' GroupHeader
            ' 
            Me.GroupHeader.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(243)))), (CInt((CByte(243)))), (CInt((CByte(243)))))
            Me.GroupHeader.BorderColor = System.Drawing.Color.White
            Me.GroupHeader.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.GroupHeader.BorderWidth = 1F
            Me.GroupHeader.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.GroupHeader.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(139)))), (CInt((CByte(139)))), (CInt((CByte(139)))))
            Me.GroupHeader.Name = "GroupHeader"
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(237)))), (CInt((CByte(196)))))
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(232)))), (CInt((CByte(205)))), (CInt((CByte(162)))))
            Me.EvenStyle.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide))
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.EvenStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.Transparent
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart1, Me.xrlblCategoryName})
            Me.Detail.Font = New System.Drawing.Font("Verdana", 9.75F)
            Me.Detail.HeightF = 592F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrChart1
            ' 
            Me.xrChart1.BorderColor = System.Drawing.SystemColors.ControlText
            Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart1.DataMember = "Categories.Products"
            Me.xrChart1.DataSource = Me.efDataSource1
            xyDiagram1.AxisX.Label.Angle = 45
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.xrChart1.Diagram = xyDiagram1
            Me.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 40F)
            Me.xrChart1.Name = "xrChart1"
            series1.ArgumentDataMember = "ProductName"
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
            series1.Label = sideBySideBarSeriesLabel1
            series1.Name = "Series 1"
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            series1.ValueDataMembersSerializable = "UnitPrice"
            sideBySideBarSeriesView1.ColorEach = True
            series1.View = sideBySideBarSeriesView1
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.xrChart1.SizeF = New System.Drawing.SizeF(917F, 552F)
            Me.xrChart1.StylePriority.UseBackColor = False
            Me.xrChart1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' efDataSource1
            ' 
            efConnectionParameters1.ConnectionStringName = "NWindEntities_ConnectionString"
            efConnectionParameters1.Source = GetType(DevExpress.DemoData.Models.NWindEntities)
            Me.efDataSource1.ConnectionParameters = efConnectionParameters1
            Me.efDataSource1.Name = "efDataSource1"
            ' 
            ' xrlblCategoryName
            ' 
            Me.xrlblCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {
                New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Categories.CategoryName", "{0} Chart"),
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "Category: {0}")
            })
            Me.xrlblCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrlblCategoryName.Name = "xrlblCategoryName"
            Me.xrlblCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlblCategoryName.SizeF = New System.Drawing.SizeF(917F, 33F)
            Me.xrlblCategoryName.StyleName = "CategoryStyle"
            Me.xrlblCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 89F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(382F, 22F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic)
            Me.xrPageInfo1.Format = "Page : {0 } / {1}"
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(817F, 0F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.lbTitle, Me.xrPageInfo2})
            Me.ReportHeader.HeightF = 50F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(132)))), (CInt((CByte(213)))))
            Me.xrLine1.LineWidth = 2
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 41F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine1.SizeF = New System.Drawing.SizeF(917F, 9F)
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 18F)
            Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(132)))), (CInt((CByte(213)))))
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(225F, 38F)
            Me.lbTitle.Text = "Products by Prices"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.xrPageInfo2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(132)))), (CInt((CByte(213)))))
            Me.xrPageInfo2.Format = "{0:""Current Date: "" dddd, dd MMMM yyyy}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(625F, 17F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(292F, 23F)
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            ' 
            ' CategoryStyle
            ' 
            Me.CategoryStyle.BackColor = System.Drawing.Color.Transparent
            Me.CategoryStyle.BorderColor = System.Drawing.SystemColors.ControlText
            Me.CategoryStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.CategoryStyle.BorderWidth = 1F
            Me.CategoryStyle.Font = New System.Drawing.Font("Tahoma", 14.25F)
            Me.CategoryStyle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(243)))), (CInt((CByte(120)))), (CInt((CByte(0)))))
            Me.CategoryStyle.Name = "CategoryStyle"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 119F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' AppearanceParameter
            ' 
            Me.AppearanceParameter.Description = "Appearance:"
            staticListLookUpSettings1.FilterString = Nothing
            Me.AppearanceParameter.LookUpSettings = staticListLookUpSettings1
            Me.AppearanceParameter.Name = "AppearanceParameter"
            ' 
            ' ColorEachParameter
            ' 
            Me.ColorEachParameter.Description = "Color each"
            Me.ColorEachParameter.Name = "ColorEachParameter"
            Me.ColorEachParameter.Type = GetType(Boolean)
            Me.ColorEachParameter.ValueInfo = "True"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.BottomMargin, Me.ReportHeader, Me.topMarginBand1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.efDataSource1
            Me.Landscape = True
            Me.Margins = New System.Drawing.Printing.Margins(100, 80, 119, 89)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.AppearanceParameter, Me.ColorEachParameter})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 1
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.OddStyle, Me.GroupHeader, Me.EvenStyle, Me.CategoryStyle})
            Me.Version = "16.1"
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.efDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private AppearanceParameter As DevExpress.XtraReports.Parameters.Parameter
        Private ColorEachParameter As DevExpress.XtraReports.Parameters.Parameter
        Private efDataSource1 As DevExpress.DataAccess.EntityFramework.EFDataSource



    End Class
End Namespace
