Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.RichText
    Partial Public Class Report
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText
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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.dsHomes = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrRichText1})
            Me.Detail.HeightF = 17F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrRichText1
            ' 
            Me.xrRichText1.CanShrink = True
            Me.xrRichText1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "Homes.RtfContent")})
            Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(24F, 1F)
            Me.xrRichText1.Name = "xrRichText1"
            Me.xrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 15, 100F)
            Me.xrRichText1.SizeF = New System.Drawing.SizeF(645F, 16F)
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Address", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader0.HeightF = 48F
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {
                New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Homes.Address"),
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Homes.Address")
            })
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 14.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle)))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(141F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(418F, 28F)
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(275F, 13F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 75F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' dsHomes
            ' 
            Me.dsHomes.ConnectionName = "HomesConnectionString"
            Me.dsHomes.Name = "dsHomes"
            columnExpression1.ColumnName = "Address"
            table1.Name = "Homes"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "RtfContent"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.FilterString = "[Homes.RtfContent] Is Not Null"
            selectQuery1.Name = "Homes"
            selectQuery1.Tables.Add(table1)
            Me.dsHomes.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsHomes.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iZHNIb21lcyI+PFZpZXcgTmFtZT0iSG9tZXMiPjxGaWVsZCBOYW1lPSJBZGRyZ" & "XNzIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IlJ0ZkNvbnRlbnQiIFR5cGU9IlN0cmluZyIgL" & "z48L1ZpZXc+PC9EYXRhU2V0Pg=="
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupHeader0, Me.BottomMargin, Me.topMarginBand1})
            Me.DataMember = "Homes"
            Me.DataSource = Me.dsHomes
            Me.Margins = New System.Drawing.Printing.Margins(75, 75, 75, 75)
            Me.ReportPrintOptions.DetailCountAtDesignTime = 1
            Me.Version = "16.1"
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private dsHomes As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
