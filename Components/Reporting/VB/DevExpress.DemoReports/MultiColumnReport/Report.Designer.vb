Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.MultiColumnReport
    Partial Public Class Report
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
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim allColumns1 As New DevExpress.DataAccess.Sql.AllColumns()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Me.EvenContactName = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddContactName = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.EvenInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.ColumnLayoutParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.dsCustomers1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' EvenContactName
            ' 
            Me.EvenContactName.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(123)))), (CInt((CByte(153)))), (CInt((CByte(201)))))
            Me.EvenContactName.BorderColor = System.Drawing.SystemColors.ControlText
            Me.EvenContactName.BorderWidth = 1F
            Me.EvenContactName.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold)
            Me.EvenContactName.ForeColor = System.Drawing.Color.White
            Me.EvenContactName.Name = "EvenContactName"
            ' 
            ' OddContactName
            ' 
            Me.OddContactName.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(187)))), (CInt((CByte(138)))), (CInt((CByte(146)))))
            Me.OddContactName.BorderColor = System.Drawing.Color.Empty
            Me.OddContactName.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.OddContactName.BorderWidth = 1F
            Me.OddContactName.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold)
            Me.OddContactName.ForeColor = System.Drawing.Color.White
            Me.OddContactName.Name = "OddContactName"
            ' 
            ' OddInfo
            ' 
            Me.OddInfo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(241)))), (CInt((CByte(226)))), (CInt((CByte(228)))))
            Me.OddInfo.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(187)))), (CInt((CByte(138)))), (CInt((CByte(146)))))
            Me.OddInfo.BorderWidth = 1F
            Me.OddInfo.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.OddInfo.ForeColor = System.Drawing.SystemColors.ControlText
            Me.OddInfo.Name = "OddInfo"
            ' 
            ' EvenInfo
            ' 
            Me.EvenInfo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(234)))), (CInt((CByte(251)))))
            Me.EvenInfo.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(123)))), (CInt((CByte(153)))), (CInt((CByte(201)))))
            Me.EvenInfo.BorderWidth = 1F
            Me.EvenInfo.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.EvenInfo.ForeColor = System.Drawing.SystemColors.ControlText
            Me.EvenInfo.Name = "EvenInfo"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 118F
            Me.Detail.MultiColumn.ColumnCount = 3
            Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
            Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.EvenStyleName = "EvenContactName"
            Me.xrTable1.KeepTogether = True
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(8.000056F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.xrTableRow2, Me.xrTableRow4, Me.xrTableRow5, Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(200F, 110F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell3, Me.xrTableCell7})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 0.22727272727272727R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell3.EvenStyleName = "EvenContactName"
            Me.xrTableCell3.Font = New System.Drawing.Font("Times New Roman", 12F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)))
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.OddStyleName = "OddContactName"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "[ContactName]"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell3.Weight = 0.84895828247070315R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell7.EvenStyleName = "EvenContactName"
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.OddStyleName = "OddContactName"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F)
            Me.xrTableCell7.StylePriority.UseBorders = False
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrTableCell7.Summary = xrSummary1
            Me.xrTableCell7.Text = "xrTableCell7"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell7.Weight = 0.15104171752929685R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell8})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 0.12696995964802466R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell8.EvenStyleName = "EvenInfo"
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.OddStyleName = "OddInfo"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.StylePriority.UseBorders = False
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "[City], [Country]"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 1R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.28889780973517726R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Address")})
            Me.xrTableCell4.EvenStyleName = "EvenInfo"
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.OddStyleName = "OddInfo"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
            Me.xrTableCell4.Weight = 1R
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell5})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 0.1269699532063979R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.PostalCode")})
            Me.xrTableCell5.EvenStyleName = "EvenInfo"
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.OddStyleName = "OddInfo"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell5.Weight = 1R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell2})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 0.13443878885601271R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Phone")})
            Me.xrTableCell2.EvenStyleName = "EvenInfo"
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.OddStyleName = "OddInfo"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell2.Weight = 1R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel8})
            Me.ReportHeader.HeightF = 54.99999F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel8.Font = New System.Drawing.Font("Tahoma", 20.25F)
            Me.xrLabel8.ForeColor = System.Drawing.Color.Black
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(8F, 2F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(633F, 42F)
            Me.xrLabel8.Text = "Customer List"
            Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 30F)
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
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(550F, 8F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' ColumnLayoutParameter
            ' 
            Me.ColumnLayoutParameter.Description = "First across, then down"
            Me.ColumnLayoutParameter.Name = "ColumnLayoutParameter"
            Me.ColumnLayoutParameter.Type = GetType(Boolean)
            Me.ColumnLayoutParameter.ValueInfo = "True"
            ' 
            ' dsCustomers1
            ' 
            Me.dsCustomers1.ConnectionName = "NWindConnectionString"
            Me.dsCustomers1.Name = "dsCustomers1"
            allColumns1.Table = Nothing
            selectQuery1.Columns.Add(allColumns1)
            selectQuery1.Name = "Customers"
            table1.Name = "Customers"
            selectQuery1.Tables.Add(table1)
            Me.dsCustomers1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsCustomers1.ResultSchemaSerializable = resources.GetString("dsCustomers1.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.ReportHeader, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.DataMember = "Customers"
            Me.DataSource = Me.dsCustomers1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.ColumnLayoutParameter})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 9
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.EvenContactName, Me.OddContactName, Me.OddInfo, Me.EvenInfo})
            Me.Version = "16.2"
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private EvenContactName As DevExpress.XtraReports.UI.XRControlStyle
        Private OddContactName As DevExpress.XtraReports.UI.XRControlStyle
        Private OddInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private EvenInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private ColumnLayoutParameter As DevExpress.XtraReports.Parameters.Parameter
        Private dsCustomers1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
