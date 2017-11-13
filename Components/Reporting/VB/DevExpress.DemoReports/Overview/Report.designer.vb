Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.Overview
    Partial Public Class Report
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private OddStyle As DevExpress.XtraReports.UI.XRControlStyle

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                'if(components != null) {
                '    components.Dispose();
                '}
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
            Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' EvenStyle
            ' 
            Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(250)))), (CInt((CByte(250)))), (CInt((CByte(240)))))
            Me.EvenStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(207)))), (CInt((CByte(189)))))
            Me.EvenStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.EvenStyle.BorderWidth = 1F
            Me.EvenStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.EvenStyle.ForeColor = System.Drawing.Color.Black
            Me.EvenStyle.Name = "EvenStyle"
            ' 
            ' OddStyle
            ' 
            Me.OddStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(225)))), (CInt((CByte(232)))), (CInt((CByte(220)))))
            Me.OddStyle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(207)))), (CInt((CByte(189)))))
            Me.OddStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.OddStyle.BorderWidth = 1F
            Me.OddStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.OddStyle.ForeColor = System.Drawing.Color.Black
            Me.OddStyle.Name = "OddStyle"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1, Me.xrTable1, Me.xrLabel11, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.xrLabel6, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2})
            Me.Detail.HeightF = 188.5417F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPageBreak1
            ' 
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 186.5417F)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(12.00004F, 91.20834F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(497.9968F, 69.17F)
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrTableCell1.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrTableCell1.ForeColor = System.Drawing.Color.White
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 6, 4, 100F)
            Me.xrTableCell1.StylePriority.UseFont = False
            Me.xrTableCell1.Text = "About:"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell1.Weight = 0.1869154328505041R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrTableCell2.BorderColor = System.Drawing.Color.White
            Me.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableCell2.BorderWidth = 4F
            Me.xrTableCell2.CanGrow = False
            Me.xrTableCell2.Font = New System.Drawing.Font("Tahoma", 9F)
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrTableCell2.StylePriority.UseBackColor = False
            Me.xrTableCell2.StylePriority.UseBorderColor = False
            Me.xrTableCell2.StylePriority.UseBorders = False
            Me.xrTableCell2.StylePriority.UseBorderWidth = False
            Me.xrTableCell2.StylePriority.UseFont = False
            Me.xrTableCell2.StylePriority.UsePadding = False
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "[Notes]"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell2.Weight = 0.81308456714949584R
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel11.CanShrink = True
            Me.xrLabel11.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(108.8332F, 163.9584F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(401.17F, 24.42F)
            Me.xrLabel11.StylePriority.UseBackColor = False
            Me.xrLabel11.StylePriority.UseFont = False
            Me.xrLabel11.StylePriority.UsePadding = False
            Me.xrLabel11.StylePriority.UseTextAlignment = False
            Me.xrLabel11.Text = "[Country], [City], [Address]"
            Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel9.CanShrink = True
            Me.xrLabel9.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(108.8302F, 63.99998F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(401.17F, 24.42F)
            Me.xrLabel9.StylePriority.UseBackColor = False
            Me.xrLabel9.StylePriority.UseFont = False
            Me.xrLabel9.StylePriority.UsePadding = False
            Me.xrLabel9.StylePriority.UseTextAlignment = False
            Me.xrLabel9.Text = "[BirthDate!dddd, MMMM d, yyyy]"
            Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel8.CanShrink = True
            Me.xrLabel8.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(108.8333F, 7.999992F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(401.17F, 24.42F)
            Me.xrLabel8.StylePriority.UseBackColor = False
            Me.xrLabel8.StylePriority.UseFont = False
            Me.xrLabel8.StylePriority.UsePadding = False
            Me.xrLabel8.StylePriority.UseTextAlignment = False
            Me.xrLabel8.Text = "[FirstName] [LastName]"
            Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel7.CanShrink = True
            Me.xrLabel7.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(108.8333F, 36F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(401.17F, 24.42F)
            Me.xrLabel7.StylePriority.UseBackColor = False
            Me.xrLabel7.StylePriority.UseFont = False
            Me.xrLabel7.StylePriority.UsePadding = False
            Me.xrLabel7.StylePriority.UseTextAlignment = False
            Me.xrLabel7.Text = "[Title]"
            Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel6.CanShrink = True
            Me.xrLabel6.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel6.ForeColor = System.Drawing.Color.White
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(12.00004F, 163.9584F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(93.08334F, 22.5833F)
            Me.xrLabel6.StylePriority.UseBackColor = False
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.StylePriority.UseForeColor = False
            Me.xrLabel6.StylePriority.UsePadding = False
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            Me.xrLabel6.Text = "Address:"
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel4.CanShrink = True
            Me.xrLabel4.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel4.ForeColor = System.Drawing.Color.White
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(12F, 64F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(93.08334F, 24.66672F)
            Me.xrLabel4.StylePriority.UseBackColor = False
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "Birth Date:"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel3.CanShrink = True
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel3.ForeColor = System.Drawing.Color.White
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(11.99998F, 36F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(93.08342F, 24.4166F)
            Me.xrLabel3.StylePriority.UseBackColor = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.Text = "Position:"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel2.CanShrink = True
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel2.ForeColor = System.Drawing.Color.White
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(12F, 8F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(93.08342F, 24.66672F)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "Name:"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' formattingRule1
            ' 
            Me.formattingRule1.Name = "formattingRule1"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel1.CanShrink = True
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 20.25F)
            Me.xrLabel1.ForeColor = System.Drawing.Color.White
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(12.00012F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(497.9999F, 40F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Employee"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 14.37496F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 15.41667F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "LastName"
            table1.Name = "Employees"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "FirstName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Title"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "BirthDate"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Address"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "City"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Country"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Notes"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Name = "Employees"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.PageHeader.HeightF = 40F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.BottomMargin, Me.topMarginBand1, Me.PageHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Employees"
            Me.DataSource = Me.sqlDataSource1
            Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
            Me.Margins = New System.Drawing.Printing.Margins(0, 0, 15, 14)
            Me.PageHeight = 300
            Me.PageWidth = 520
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.ReportPrintOptions.DetailCountAtDesignTime = 7
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.EvenStyle, Me.OddStyle})
            Me.Version = "16.1"
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
