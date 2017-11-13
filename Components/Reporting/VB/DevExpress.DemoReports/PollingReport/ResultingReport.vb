Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PollingReport
    Public Class ResultingReport
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand
        Private detailBand1 As DetailBand
        Private components As System.ComponentModel.IContainer
        Private bottomMarginBand1 As BottomMarginBand
        Public PollingLink As XRLabel
        Private ReportFooter As ReportFooterBand
        Private ReportHeader As ReportHeaderBand
        Private paramPollCount As DevExpress.XtraReports.Parameters.Parameter
        Private WithEvents xrChart1 As XRChart
        Private ghStyle1 As XRControlStyle
        Private ghStyle2 As XRControlStyle
        Private detStyle1Odd As XRControlStyle
        Private xrTable1 As XRTable
        Private xrTableRow5 As XRTableRow
        Private xrTableCell9 As XRTableCell
        Private xrTableCell10 As XRTableCell
        Private detStyle1Even As XRControlStyle
        Private xrLine2 As XRLine
        Private xrLine1 As XRLine
        Private xrSubreport1 As XRSubreport
        Private GroupHeader1 As GroupHeaderBand
        Public ResultingReportDS As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Public Sub New()
            InitializeComponent()

            Dim subreport As ResultingTableReport = TryCast(xrSubreport1.ReportSource, ResultingTableReport)
            If subreport IsNot Nothing Then
                subreport.ResultingTableReportDS.DataSource = ResultingReportDS
                subreport.Colors = GetColorList(xrChart1.PaletteRepository(Me.xrChart1.PaletteName))
            End If
        End Sub

        Private Function GetColorList(ByVal palette As Palette) As List(Of Color)
            Dim list As New List(Of Color)()
            For Each item As PaletteEntry In palette
                list.Add(item.Color)
            Next item
            Return list
        End Function

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.PollingLink = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.paramPollCount = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ghStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ghStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.detStyle1Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.detStyle1Even = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.ResultingReportDS = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ResultingReportDS, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Dpi = 100F
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            Me.detailBand1.Dpi = 100F
            Me.detailBand1.HeightF = 0F
            Me.detailBand1.Name = "detailBand1"
            Me.detailBand1.StylePriority.UseFont = False
            ' 
            ' xrChart1
            ' 
            Me.xrChart1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrChart1.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrChart1.AppearanceNameSerializable = "Light"
            Me.xrChart1.BorderColor = System.Drawing.Color.Black
            Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            simpleDiagram1.EqualPieSize = True
            simpleDiagram1.LayoutDirection = DevExpress.XtraCharts.LayoutDirection.Vertical
            Me.xrChart1.Diagram = simpleDiagram1
            Me.xrChart1.Dpi = 100F
            Me.xrChart1.Legend.Name = "Default Legend"
            Me.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(350F, 37.5F)
            Me.xrChart1.Name = "xrChart1"
            Me.xrChart1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            series1.ArgumentDataMember = "Answer"
            series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("QuestionID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, Nothing)})
            pieSeriesLabel1.TextPattern = "{A}"
            series1.Label = pieSeriesLabel1
            series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "AnswerCount"
            pieSeriesView1.MinAllowedSizePercentage = 75R
            series1.View = pieSeriesView1
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.xrChart1.SizeF = New System.Drawing.SizeF(300F, 187.5F)
            Me.xrChart1.StylePriority.UsePadding = False
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Dpi = 100F
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' PollingLink
            ' 
            Me.PollingLink.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(114)))), (CInt((CByte(45)))))
            Me.PollingLink.Dpi = 100F
            Me.PollingLink.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.PollingLink.ForeColor = System.Drawing.Color.White
            Me.PollingLink.LocationFloat = New DevExpress.Utils.PointFloat(25F, 25F)
            Me.PollingLink.Name = "PollingLink"
            Me.PollingLink.NavigateUrl = "empty"
            Me.PollingLink.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.PollingLink.SizeF = New System.Drawing.SizeF(150F, 32.5F)
            Me.PollingLink.StylePriority.UseBackColor = False
            Me.PollingLink.StylePriority.UseFont = False
            Me.PollingLink.StylePriority.UseForeColor = False
            Me.PollingLink.StylePriority.UseTextAlignment = False
            Me.PollingLink.Text = "Start a new poll"
            Me.PollingLink.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLine1.Dpi = 100F
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 12.49997F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.PollingLink})
            Me.ReportFooter.Dpi = 100F
            Me.ReportFooter.HeightF = 57.5F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine2, Me.xrTable1})
            Me.ReportHeader.Dpi = 100F
            Me.ReportHeader.HeightF = 62.49999F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.StylePriority.UseFont = False
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLine2.Dpi = 100F
            Me.xrLine2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(112)))), (CInt((CByte(112)))), (CInt((CByte(112)))))
            Me.xrLine2.LineWidth = 2
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.SizeF = New System.Drawing.SizeF(650F, 2.083333F)
            Me.xrLine2.StylePriority.UseForeColor = False
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Dpi = 100F
            Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTable1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(112)))), (CInt((CByte(112)))), (CInt((CByte(112)))))
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(25F, 25F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow5})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(600F, 33F)
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UseForeColor = False
            Me.xrTable1.StylePriority.UseTextAlignment = False
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow5.Dpi = 100F
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Weight = 0.65999999999999992R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Dpi = 100F
            Me.xrTableCell9.Font = New System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(114)))), (CInt((CByte(45)))))
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StylePriority.UseFont = False
            Me.xrTableCell9.StylePriority.UseForeColor = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Polling results"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell9.Weight = 1.4950000859781933R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Dpi = 100F
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Number of people polled : [Parameters.paramPollCount]"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell10.Weight = 1.26500004317221R
            Me.xrTableCell10.WordWrap = False
            ' 
            ' paramPollCount
            ' 
            Me.paramPollCount.Description = "Poll Count"
            Me.paramPollCount.Name = "paramPollCount"
            Me.paramPollCount.Type = GetType(Integer)
            Me.paramPollCount.ValueInfo = "0"
            Me.paramPollCount.Visible = False
            ' 
            ' ghStyle1
            ' 
            Me.ghStyle1.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold)
            Me.ghStyle1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(112)))), (CInt((CByte(112)))), (CInt((CByte(112)))))
            Me.ghStyle1.Name = "ghStyle1"
            Me.ghStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.ghStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' ghStyle2
            ' 
            Me.ghStyle2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
            Me.ghStyle2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.ghStyle2.ForeColor = System.Drawing.Color.White
            Me.ghStyle2.Name = "ghStyle2"
            Me.ghStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' detStyle1Odd
            ' 
            Me.detStyle1Odd.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.detStyle1Odd.Name = "detStyle1Odd"
            ' 
            ' detStyle1Even
            ' 
            Me.detStyle1Even.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(242)))), (CInt((CByte(242)))), (CInt((CByte(242)))))
            Me.detStyle1Even.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.detStyle1Even.Name = "detStyle1Even"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrSubreport1, Me.xrChart1})
            Me.GroupHeader1.Dpi = 100F
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 225F
            Me.GroupHeader1.KeepTogether = True
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.Dpi = 100F
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(25.00003F, 37.5F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramQuestionID", Nothing, "QuestionID"))
            Me.xrSubreport1.ReportSource = New XtraReportsDemos.PollingReport.ResultingTableReport()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(325F, 187.5F)
            ' 
            ' ResultingReportDS
            ' 
            Me.ResultingReportDS.DataSource = GetType(XtraReportsDemos.PollingReport.ResultingData)
            Me.ResultingReportDS.Name = "ResultingReportDS"
            ' 
            ' ResultingReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.ReportFooter, Me.ReportHeader, Me.GroupHeader1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.ResultingReportDS})
            Me.DataSource = Me.ResultingReportDS
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramPollCount})
            Me.SnappingMode = (CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode))
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.ghStyle1, Me.ghStyle2, Me.detStyle1Odd, Me.detStyle1Even})
            Me.Version = "16.2"
            CType(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ResultingReportDS, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Private Sub xrChart1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrChart1.BeforePrint
            Me.xrChart1.Series(0).DataFilters(0).Value = GetCurrentColumnValue("QuestionID")
        End Sub
    End Class
End Namespace
