Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PollingReport
    Public Class ResultingTableReport
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand
        Private detailBand1 As DetailBand
        Private components As System.ComponentModel.IContainer
        Private bottomMarginBand1 As BottomMarginBand
        Private dtlTable1 As XRTable
        Private WithEvents detailTableRow As XRTableRow
        Private xrTableCell1 As XRTableCell
        Private xrTableCell2 As XRTableCell
        Private xrTableCell3 As XRTableCell
        Private ghTable1 As XRTable
        Private xrTableRow2 As XRTableRow
        Private xrTableCell4 As XRTableCell
        Private paramQuestionID As DevExpress.XtraReports.Parameters.Parameter
        Private questionStyle As XRControlStyle
        Private xrTableRow4 As XRTableRow
        Private xrTableCell6 As XRTableCell
        Private xrTableCell8 As XRTableCell
        Private headerStyle As XRControlStyle
        Private detailStyleEven As XRControlStyle
        Private xrTableCell12 As XRTableCell
        Friend ResultingTableReportDS As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
        Private GroupHeader1 As GroupHeaderBand
        Private xrLabel1 As XRLabel
        Private detailStyleOdd As XRControlStyle
        Private xrTableCell5 As XRTableCell
        Private xrShape1 As XRShape
        Private emptyAnswerTextColor As System.Drawing.Color

        Friend Property Colors() As List(Of Color)

        Public Sub New()
            InitializeComponent()
            emptyAnswerTextColor = detailTableRow.ForeColor
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim shapeRectangle1 As New DevExpress.XtraPrinting.Shape.ShapeRectangle()
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.dtlTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.detailTableRow = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrShape1 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ghTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.paramQuestionID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.questionStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.headerStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.detailStyleEven = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.detailStyleOdd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.ResultingTableReportDS = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType(Me.dtlTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ghTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ResultingTableReportDS, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.dtlTable1})
            Me.detailBand1.Dpi = 100F
            Me.detailBand1.HeightF = 30F
            Me.detailBand1.Name = "detailBand1"
            Me.detailBand1.StylePriority.UseFont = False
            ' 
            ' dtlTable1
            ' 
            Me.dtlTable1.Dpi = 100F
            Me.dtlTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.dtlTable1.Name = "dtlTable1"
            Me.dtlTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.detailTableRow})
            Me.dtlTable1.SizeF = New System.Drawing.SizeF(325F, 30F)
            Me.dtlTable1.StylePriority.UseTextAlignment = False
            Me.dtlTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' detailTableRow
            ' 
            Me.detailTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell5, Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.detailTableRow.Dpi = 100F
            Me.detailTableRow.EvenStyleName = "detailStyleEven"
            Me.detailTableRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
            Me.detailTableRow.Name = "detailTableRow"
            Me.detailTableRow.OddStyleName = "detailStyleOdd"
            Me.detailTableRow.StylePriority.UseForeColor = False
            Me.detailTableRow.Weight = 1R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrShape1})
            Me.xrTableCell5.Dpi = 100F
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Weight = 0.26494085357768737R
            ' 
            ' xrShape1
            ' 
            Me.xrShape1.Dpi = 100F
            Me.xrShape1.ForeColor = System.Drawing.Color.Transparent
            Me.xrShape1.LocationFloat = New DevExpress.Utils.PointFloat(5F, 2.5F)
            Me.xrShape1.Name = "xrShape1"
            Me.xrShape1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F)
            Me.xrShape1.Shape = shapeRectangle1
            Me.xrShape1.SizeF = New System.Drawing.SizeF(24.99998F, 25F)
            Me.xrShape1.StylePriority.UseForeColor = False
            Me.xrShape1.StylePriority.UsePadding = False
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Answer")})
            Me.xrTableCell1.Dpi = 100F
            Me.xrTableCell1.Multiline = True
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.Weight = 1.5749258970746736R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AnswerCount")})
            Me.xrTableCell2.Dpi = 100F
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell2.Weight = 0.45996698152369797R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AnswerCount")})
            Me.xrTableCell3.Dpi = 100F
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            xrSummary1.FormatString = "{0:0.0%}"
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Percentage
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrTableCell3.Summary = xrSummary1
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.5703587583536065R
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Dpi = 100F
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' ghTable1
            ' 
            Me.ghTable1.Dpi = 100F
            Me.ghTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.ghTable1.Name = "ghTable1"
            Me.ghTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2, Me.xrTableRow4})
            Me.ghTable1.SizeF = New System.Drawing.SizeF(325F, 63.54F)
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4})
            Me.xrTableRow2.Dpi = 100F
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.StylePriority.UseTextAlignment = False
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1.7039473665263247R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.xrTableCell4.Dpi = 100F
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StylePriority.UsePadding = False
            Me.xrTableCell4.Weight = 3.8269230769230766R
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Question")})
            Me.xrLabel1.Dpi = 100F
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(325F, 25F)
            Me.xrLabel1.StyleName = "questionStyle"
            Me.xrLabel1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell12, Me.xrTableCell8, Me.xrTableCell6})
            Me.xrTableRow4.Dpi = 100F
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.StyleName = "headerStyle"
            Me.xrTableRow4.StylePriority.UseTextAlignment = False
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableRow4.Weight = 1.1052630062961615R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.Dpi = 100F
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F)
            Me.xrTableCell12.StylePriority.UsePadding = False
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell12.Weight = 2.2579717305482263R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Dpi = 100F
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StylePriority.UseBorderColor = False
            Me.xrTableCell8.StylePriority.UseBorders = False
            Me.xrTableCell8.StylePriority.UseBorderWidth = False
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "Voted"
            Me.xrTableCell8.Weight = 0.56449296046847441R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Dpi = 100F
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Text = "Percent"
            Me.xrTableCell6.Weight = 0.69997138007444848R
            ' 
            ' paramQuestionID
            ' 
            Me.paramQuestionID.Description = "Question ID"
            Me.paramQuestionID.Name = "paramQuestionID"
            Me.paramQuestionID.Type = GetType(Integer)
            Me.paramQuestionID.ValueInfo = "0"
            Me.paramQuestionID.Visible = False
            ' 
            ' questionStyle
            ' 
            Me.questionStyle.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.questionStyle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(112)))), (CInt((CByte(112)))), (CInt((CByte(112)))))
            Me.questionStyle.Name = "questionStyle"
            Me.questionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' headerStyle
            ' 
            Me.headerStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(141)))), (CInt((CByte(141)))))
            Me.headerStyle.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.headerStyle.ForeColor = System.Drawing.Color.White
            Me.headerStyle.Name = "headerStyle"
            Me.headerStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' detailStyleEven
            ' 
            Me.detailStyleEven.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.detailStyleEven.Name = "detailStyleEven"
            ' 
            ' detailStyleOdd
            ' 
            Me.detailStyleOdd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(242)))), (CInt((CByte(242)))), (CInt((CByte(242)))))
            Me.detailStyleOdd.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.detailStyleOdd.Name = "detailStyleOdd"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.ghTable1})
            Me.GroupHeader1.Dpi = 100F
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 63.54168F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' ResultingTableReportDS
            ' 
            Me.ResultingTableReportDS.DataMember = ""
            Me.ResultingTableReportDS.DataSource = GetType(XtraReportsDemos.PollingReport.ResultingData)
            Me.ResultingTableReportDS.Name = "ResultingTableReportDS"
            ' 
            ' ResultingTableReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.GroupHeader1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.ResultingTableReportDS})
            Me.DataSource = Me.ResultingTableReportDS
            Me.FilterString = "[QuestionID] = ?paramQuestionID"
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramQuestionID})
            Me.SnappingMode = (CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode))
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.questionStyle, Me.headerStyle, Me.detailStyleEven, Me.detailStyleOdd})
            Me.Version = "16.2"
            CType(Me.dtlTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ghTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ResultingTableReportDS, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Private Sub detailTableRow_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles detailTableRow.BeforePrint
            Dim voted As Integer = Report.GetCurrentColumnValue(Of Integer)("AnswerCount")
            If Colors Is Nothing OrElse Colors.Count = 0 Then
                detailTableRow.ForeColor = If(voted > 0, Color.Black, emptyAnswerTextColor)
                xrShape1.FillColor = System.Drawing.Color.Transparent
            ElseIf voted > 0 Then
                Dim colorIndex As Integer = Report.CurrentRowIndex Mod Colors.Count
                xrShape1.FillColor = Colors(colorIndex)
                detailTableRow.ForeColor = xrShape1.FillColor
            Else
                detailTableRow.ForeColor = emptyAnswerTextColor
                xrShape1.FillColor = System.Drawing.Color.Transparent
            End If
        End Sub
    End Class
End Namespace
