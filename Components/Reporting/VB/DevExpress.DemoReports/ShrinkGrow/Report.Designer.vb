Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.ShrinkGrow
    Partial Public Class Report
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Public xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
        Private xrPanel2 As DevExpress.XtraReports.UI.XRPanel
        Private lbCaption As DevExpress.XtraReports.UI.XRLabel
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Report))
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
            Dim column16 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbCaption = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.dsEmployees1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel2})
            Me.Detail.HeightF = 174F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPanel2
            ' 
            Me.xrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1, Me.xrLabel4, Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel11, Me.xrLabel5, Me.xrLabel9, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8})
            Me.xrPanel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Employees.LastName", "Employee: {0}")})
            Me.xrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPanel2.Name = "xrPanel2"
            Me.xrPanel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPanel2.SizeF = New System.Drawing.SizeF(650F, 171F)
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(217F, 100F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(425F, 33F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell3})
            Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrTableCell1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell1.ForeColor = System.Drawing.Color.White
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 6, 4, 100F)
            Me.xrTableCell1.Text = "About"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell1.Weight = 0.23529411764705882R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrTableCell3.BorderColor = System.Drawing.Color.White
            Me.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableCell3.BorderWidth = 4F
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Notes")})
            Me.xrTableCell3.ForeColor = System.Drawing.Color.Black
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell3.Weight = 0.76470588235294112R
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel4.BorderColor = System.Drawing.Color.Black
            Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.FirstName")})
            Me.xrLabel4.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(321F, 13F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(320F, 25F)
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Employees.Photo")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(4F, 13F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 7, 7, 7, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(179F, 150F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel2.BorderColor = System.Drawing.Color.Black
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Title")})
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(321F, 42F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(320F, 25F)
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel11.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel11.ForeColor = System.Drawing.Color.White
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(217F, 137F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrLabel11.Text = "Address:"
            Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel5.BorderColor = System.Drawing.Color.Black
            Me.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Address")})
            Me.xrLabel5.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(321F, 137F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(320F, 25F)
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel9.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel9.ForeColor = System.Drawing.Color.White
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(217F, 71F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrLabel9.Text = "Birth Date:"
            Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(237)))), (CInt((CByte(218)))))
            Me.xrLabel6.BorderColor = System.Drawing.Color.Black
            Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.BirthDate")})
            Me.xrLabel6.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(321F, 71F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(320F, 25F)
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrLabel6.XlsxFormatString = "dddd, mmmm dd, yyyy"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel7.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel7.ForeColor = System.Drawing.Color.White
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(217F, 13F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrLabel7.Text = "Name:"
            Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.xrLabel8.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel8.ForeColor = System.Drawing.Color.White
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(217F, 42F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrLabel8.Text = "Position:"
            Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbCaption})
            Me.ReportHeader.HeightF = 75F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCaption
            ' 
            Me.lbCaption.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(109)))), (CInt((CByte(140)))), (CInt((CByte(89)))))
            Me.lbCaption.Font = New System.Drawing.Font("Tahoma", 20.25F)
            Me.lbCaption.ForeColor = System.Drawing.Color.White
            Me.lbCaption.LocationFloat = New DevExpress.Utils.PointFloat(4F, 0F)
            Me.lbCaption.Name = "lbCaption"
            Me.lbCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCaption.SizeF = New System.Drawing.SizeF(638F, 50F)
            Me.lbCaption.Text = "Employees List"
            Me.lbCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4, Me.xrPageInfo1})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 17F)
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
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(542F, 4F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(98F, 17F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 105F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' dsEmployees1
            ' 
            Me.dsEmployees1.ConnectionName = "NWindConnectionString"
            Me.dsEmployees1.Name = "dsEmployees1"
            columnExpression1.ColumnName = "EmployeeID"
            table1.Name = "Employees"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "LastName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "FirstName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Title"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "TitleOfCourtesy"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "BirthDate"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "HireDate"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "Address"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "City"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Region"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "PostalCode"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "Country"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "HomePhone"
            columnExpression13.Table = table1
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Extension"
            columnExpression14.Table = table1
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "Photo"
            columnExpression15.Table = table1
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Notes"
            columnExpression16.Table = table1
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "ReportsTo"
            columnExpression17.Table = table1
            column17.Expression = columnExpression17
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
            selectQuery1.Columns.Add(column16)
            selectQuery1.Columns.Add(column17)
            selectQuery1.Name = "Employees"
            selectQuery1.Tables.Add(table1)
            Me.dsEmployees1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsEmployees1.ResultSchemaSerializable = resources.GetString("dsEmployees1.ResultSchemaSerializable")
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.ReportHeader, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.DataMember = "Employees"
            Me.DataSource = Me.dsEmployees1
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 105, 75)
            Me.ReportPrintOptions.DetailCountAtDesignTime = 2
            Me.Version = "16.1"
            Me.Watermark.Font = New System.Drawing.Font("Verdana", 54F)
            Me.Watermark.ShowBehind = False
            Me.Watermark.Text = "CONFIDENTIAL"
            Me.Watermark.TextTransparency = 150
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private dsEmployees1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
