Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.PivotGridAndChart
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xpiPageCount As DevExpress.XtraReports.UI.XRPageInfo
        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupHeader As DevExpress.XtraReports.UI.XRControlStyle
        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private CategoryStyle As DevExpress.XtraReports.UI.XRControlStyle
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
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim stackedSplineAreaSeriesView1 As New DevExpress.XtraCharts.StackedSplineAreaSeriesView()
            Dim efConnectionParameters1 As New DevExpress.DataAccess.EntityFramework.EFConnectionParameters()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrChart = New DevExpress.XtraReports.UI.XRChart()
            Me.xrPivotGrid = New DevExpress.XtraReports.UI.XRPivotGrid()
            Me.efDataSource1 = New DevExpress.DataAccess.EntityFramework.EFDataSource()
            Me.pgfSalesPerson = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pgfSalesTotal = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pgfYear = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pgfQuarter = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xpbDevExpress = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xpiPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.CategoryStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrlTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.parameterShowLabels = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterGenerateSeriesFromColumns = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterShowRowGrandTotals = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterShowColumnGrandTotals = New DevExpress.XtraReports.Parameters.Parameter()
            Me.parameterViewType = New DevExpress.XtraReports.Parameters.Parameter()
            CType(Me.xrChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(stackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart, Me.xrPivotGrid})
            Me.Detail.Font = New System.Drawing.Font("Verdana", 9.75F)
            Me.Detail.HeightF = 592F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrChart
            ' 
            Me.xrChart.BorderColor = System.Drawing.SystemColors.ControlText
            Me.xrChart.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart.DataSource = Me.xrPivotGrid
            xyDiagram1.AxisLabelsResolveOverlappingMinIndent = 0
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.Title.Text = "Year Quarter"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
            xyDiagram1.AxisY.Title.Text = "Sales Total"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.xrChart.Diagram = xyDiagram1
            Me.xrChart.Legend.MaxHorizontalPercentage = 30R
            Me.xrChart.LocationFloat = New DevExpress.Utils.PointFloat(7.947286E-05F, 217F)
            Me.xrChart.Name = "xrChart"
            Me.xrChart.SeriesDataMember = "Series"
            Me.xrChart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.xrChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.xrChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.xrChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            stackedSplineAreaSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
            stackedSplineAreaSeriesView1.Transparency = (CByte(100))
            Me.xrChart.SeriesTemplate.View = stackedSplineAreaSeriesView1
            Me.xrChart.SizeF = New System.Drawing.SizeF(919.9999F, 295F)
            ' 
            ' xrPivotGrid
            ' 
            Me.xrPivotGrid.DataMember = "SalesPersons"
            Me.xrPivotGrid.DataSource = Me.efDataSource1
            Me.xrPivotGrid.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.pgfSalesPerson, Me.pgfSalesTotal, Me.pgfYear, Me.pgfQuarter})
            Me.xrPivotGrid.HeaderGroupLineStyleName = "GroupHeader"
            Me.xrPivotGrid.LocationFloat = New DevExpress.Utils.PointFloat(1F, 0F)
            Me.xrPivotGrid.Name = "xrPivotGrid"
            Me.xrPivotGrid.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.xrPivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
            Me.xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = False
            Me.xrPivotGrid.OptionsPrint.FilterSeparatorBarPadding = 3
            Me.xrPivotGrid.OptionsView.ShowColumnTotals = False
            Me.xrPivotGrid.OptionsView.ShowRowTotals = False
            Me.xrPivotGrid.SizeF = New System.Drawing.SizeF(920F, 215.625F)
            ' 
            ' efDataSource1
            ' 
            efConnectionParameters1.ConnectionStringName = "NWindEntities_ConnectionString"
            efConnectionParameters1.Source = GetType(DevExpress.DemoData.Models.NWindEntities)
            Me.efDataSource1.ConnectionParameters = efConnectionParameters1
            Me.efDataSource1.Name = "efDataSource1"
            ' 
            ' pgfSalesPerson
            ' 
            Me.pgfSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pgfSalesPerson.AreaIndex = 0
            Me.pgfSalesPerson.Caption = "Sales Person"
            Me.pgfSalesPerson.FieldName = "FullName"
            Me.pgfSalesPerson.Name = "pgfSalesPerson"
            ' 
            ' pgfSalesTotal
            ' 
            Me.pgfSalesTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pgfSalesTotal.AreaIndex = 0
            Me.pgfSalesTotal.Caption = "Sales Total"
            Me.pgfSalesTotal.FieldName = "ExtendedPrice"
            Me.pgfSalesTotal.Name = "pgfSalesTotal"
            ' 
            ' pgfYear
            ' 
            Me.pgfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pgfYear.AreaIndex = 0
            Me.pgfYear.Caption = "Year"
            Me.pgfYear.FieldName = "OrderDate"
            Me.pgfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.pgfYear.Name = "pgfYear"
            Me.pgfYear.UnboundFieldName = "pgfYear"
            ' 
            ' pgfQuarter
            ' 
            Me.pgfQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pgfQuarter.AreaIndex = 1
            Me.pgfQuarter.Caption = "Quarter"
            Me.pgfQuarter.FieldName = "OrderDate"
            Me.pgfQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.pgfQuarter.Name = "pgfQuarter"
            Me.pgfQuarter.UnboundFieldName = "pgfQuarter"
            Me.pgfQuarter.Width = 87
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xpbDevExpress, Me.xpiPageCount})
            Me.BottomMargin.HeightF = 87F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xpbDevExpress
            ' 
            Me.xpbDevExpress.Image = (CType(resources.GetObject("xpbDevExpress.Image"), System.Drawing.Image))
            Me.xpbDevExpress.LocationFloat = New DevExpress.Utils.PointFloat(382F, 22F)
            Me.xpbDevExpress.Name = "xpbDevExpress"
            Me.xpbDevExpress.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xpbDevExpress.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xpbDevExpress.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xpbDevExpress.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xpiPageCount
            ' 
            Me.xpiPageCount.Font = New System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic)
            Me.xpiPageCount.Format = "Page : {0 } / {1}"
            Me.xpiPageCount.LocationFloat = New DevExpress.Utils.PointFloat(817F, 0F)
            Me.xpiPageCount.Name = "xpiPageCount"
            Me.xpiPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xpiPageCount.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xpiPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrlTitle})
            Me.ReportHeader.HeightF = 48.95833F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrlTitle
            ' 
            Me.xrlTitle.Font = New System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Underline)
            Me.xrlTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrlTitle.Name = "xrlTitle"
            Me.xrlTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlTitle.SizeF = New System.Drawing.SizeF(920F, 48.95833F)
            Me.xrlTitle.StylePriority.UseFont = False
            Me.xrlTitle.StylePriority.UseTextAlignment = False
            Me.xrlTitle.Text = "Sales by Person"
            Me.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' parameterShowLabels
            ' 
            Me.parameterShowLabels.Description = "Show Labels"
            Me.parameterShowLabels.Name = "parameterShowLabels"
            Me.parameterShowLabels.Type = GetType(Boolean)
            Me.parameterShowLabels.ValueInfo = "False"
            ' 
            ' parameterGenerateSeriesFromColumns
            ' 
            Me.parameterGenerateSeriesFromColumns.Description = "Generate Series from Columns"
            Me.parameterGenerateSeriesFromColumns.Name = "parameterGenerateSeriesFromColumns"
            Me.parameterGenerateSeriesFromColumns.Type = GetType(Boolean)
            Me.parameterGenerateSeriesFromColumns.ValueInfo = "False"
            ' 
            ' parameterShowRowGrandTotals
            ' 
            Me.parameterShowRowGrandTotals.Description = "Show Row Grand Totals"
            Me.parameterShowRowGrandTotals.Name = "parameterShowRowGrandTotals"
            Me.parameterShowRowGrandTotals.Type = GetType(Boolean)
            Me.parameterShowRowGrandTotals.ValueInfo = "False"
            ' 
            ' parameterShowColumnGrandTotals
            ' 
            Me.parameterShowColumnGrandTotals.Description = "Show Column Grand Totals"
            Me.parameterShowColumnGrandTotals.Name = "parameterShowColumnGrandTotals"
            Me.parameterShowColumnGrandTotals.Type = GetType(Boolean)
            Me.parameterShowColumnGrandTotals.ValueInfo = "False"
            ' 
            ' parameterViewType
            ' 
            Me.parameterViewType.Description = "View Type"
            Me.parameterViewType.Name = "parameterViewType"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.BottomMargin, Me.topMarginBand1, Me.ReportHeader})
            Me.Landscape = True
            Me.Margins = New System.Drawing.Printing.Margins(100, 78, 119, 87)
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.parameterViewType, Me.parameterShowLabels, Me.parameterGenerateSeriesFromColumns, Me.parameterShowRowGrandTotals, Me.parameterShowColumnGrandTotals})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.OddStyle, Me.GroupHeader, Me.EvenStyle, Me.CategoryStyle})
            Me.Version = "14.2"
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(stackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.efDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xpbDevExpress As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private xrChart As DevExpress.XtraReports.UI.XRChart
        Private pgfSalesPerson As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private pgfSalesTotal As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private pgfYear As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private pgfQuarter As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrlTitle As DevExpress.XtraReports.UI.XRLabel
        Private parameterShowLabels As DevExpress.XtraReports.Parameters.Parameter
        Private parameterGenerateSeriesFromColumns As DevExpress.XtraReports.Parameters.Parameter
        Private parameterShowRowGrandTotals As DevExpress.XtraReports.Parameters.Parameter
        Private parameterShowColumnGrandTotals As DevExpress.XtraReports.Parameters.Parameter
        Private parameterViewType As DevExpress.XtraReports.Parameters.Parameter
        Public xrPivotGrid As DevExpress.XtraReports.UI.XRPivotGrid
        Private efDataSource1 As DevExpress.DataAccess.EntityFramework.EFDataSource
    End Class
End Namespace
