Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.BarCodes
    Partial Public Class ProductLabelsReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine2 As DevExpress.XtraReports.UI.XRLine
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ProductLabelsReport))
            Dim eaN13Generator1 As New DevExpress.XtraPrinting.BarCode.EAN13Generator()
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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.dsProducts1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1})
            Me.Detail.HeightF = 233F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrPanel1.BorderWidth = 3F
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLine2, Me.xrLabel5, Me.xrLine1, Me.xrLabel4, Me.xrLabel1, Me.xrBarCode1, Me.xrLabel2})
            Me.xrPanel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Products.ProductName")})
            Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 0F)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPanel1.SizeF = New System.Drawing.SizeF(475F, 233F)
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 6F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(27.08333F, 27.08333F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(8F, 34F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine2.SizeF = New System.Drawing.SizeF(458F, 8F)
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 14.25F)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(42F, 8F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(425F, 25F)
            Me.xrLabel5.Text = "Northwind Traders"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 205F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrLine1.SizeF = New System.Drawing.SizeF(458F, 8F)
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 8F)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(8F, 213F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(458F, 16F)
            Me.xrLabel4.Text = "One Portals Way, Twin Points WA  98156, Phone: 1-206-555-1417   Fax: 1-206-555-59" & "38"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.CanShrink = True
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 42F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(458F, 33F)
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.EAN13")})
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 158F)
            Me.xrBarCode1.Module = 1F
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(167F, 42F)
            Me.xrBarCode1.Symbology = eaN13Generator1
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.CanShrink = True
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:C2}")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(8F, 83F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(458F, 67F)
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 30F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 30F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' dsProducts1
            ' 
            Me.dsProducts1.ConnectionName = "NWindConnectionString"
            Me.dsProducts1.Name = "dsProducts1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
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
            selectQuery1.Name = "Products"
            selectQuery1.Tables.Add(table1)
            Me.dsProducts1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsProducts1.ResultSchemaSerializable = resources.GetString("dsProducts1.ResultSchemaSerializable")
            ' 
            ' ProductLabelsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.DataMember = "Products"
            Me.DataSource = Me.dsProducts1
            Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
            Me.PageHeight = 300
            Me.PageWidth = 557
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.ReportPrintOptions.DetailCountAtDesignTime = 1
            Me.Version = "16.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
        Private dsProducts1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
