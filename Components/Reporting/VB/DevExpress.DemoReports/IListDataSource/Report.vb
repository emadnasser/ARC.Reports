Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace XtraReportsDemos.IListDatasource
    Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend xrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend xrPictureBox4 As XRPictureBox
        Private topMarginBand1 As TopMarginBand
        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.IListDatasource
            DisplayName = ReportNames.IListDatasource
        End Sub

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
            Dim constructor1 As New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Dim parameter1 As New DevExpress.DataAccess.ObjectBinding.Parameter()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 22F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Category", "Category - {0}")})
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 22F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(237)))), (CInt((CByte(249)))), (CInt((CByte(255)))))
            Me.xrTableCell1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(180)))), (CInt((CByte(210)))), (CInt((CByte(255)))))
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ID")})
            Me.xrTableCell1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.049230769230769231R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(180)))), (CInt((CByte(210)))), (CInt((CByte(255)))))
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Category")})
            Me.xrTableCell2.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell2.Multiline = True
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.1676923076923077R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(180)))), (CInt((CByte(210)))), (CInt((CByte(255)))))
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CommonName")})
            Me.xrTableCell3.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell3.Multiline = True
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.14R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(180)))), (CInt((CByte(210)))), (CInt((CByte(255)))))
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SpeciesName")})
            Me.xrTableCell4.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.14461538461538462R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(237)))), (CInt((CByte(249)))), (CInt((CByte(255)))))
            Me.xrTableCell5.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(180)))), (CInt((CByte(210)))), (CInt((CByte(255)))))
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Notes")})
            Me.xrTableCell5.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell5.Multiline = True
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(7, 5, 5, 5, 100F)
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell5.Weight = 0.49846153846153846R
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.PageHeader.HeightF = 31F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(192)))), (CInt((CByte(255)))))
            Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 31F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(65)))), (CInt((CByte(134)))), (CInt((CByte(230)))))
            Me.xrTableCell6.BorderColor = System.Drawing.Color.White
            Me.xrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrTableCell6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell6.ForeColor = System.Drawing.Color.White
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell6.Text = "NN" & ControlChars.CrLf
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell6.Weight = 0.047692307692307694R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(65)))), (CInt((CByte(134)))), (CInt((CByte(230)))))
            Me.xrTableCell7.BorderColor = System.Drawing.Color.White
            Me.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableCell7.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell7.ForeColor = System.Drawing.Color.White
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.Text = "Category"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.1676923076923077R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(65)))), (CInt((CByte(134)))), (CInt((CByte(230)))))
            Me.xrTableCell8.BorderColor = System.Drawing.Color.White
            Me.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableCell8.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell8.ForeColor = System.Drawing.Color.White
            Me.xrTableCell8.Multiline = True
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.Text = "Common Name"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell8.Weight = 0.14R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(65)))), (CInt((CByte(134)))), (CInt((CByte(230)))))
            Me.xrTableCell9.BorderColor = System.Drawing.Color.White
            Me.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableCell9.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell9.ForeColor = System.Drawing.Color.White
            Me.xrTableCell9.Multiline = True
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell9.Text = "Species Name"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell9.Weight = 0.14461538461538462R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(65)))), (CInt((CByte(134)))), (CInt((CByte(230)))))
            Me.xrTableCell10.BorderColor = System.Drawing.Color.White
            Me.xrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableCell10.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell10.ForeColor = System.Drawing.Color.White
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.Text = "Notes"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.5R
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
            ' objectDataSource1
            ' 
            parameter1.Name = "filePath"
            parameter1.Type = GetType(String)
            parameter1.Value = "|DataDirectory|\biolife.txt"
            constructor1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() { parameter1})
            Me.objectDataSource1.Constructor = constructor1
            Me.objectDataSource1.DataSource = GetType(DevExpress.Demos.DataSources.Fishes)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.DataSource = Me.objectDataSource1
            Me.Margins = New System.Drawing.Printing.Margins(99, 100, 100, 75)
            Me.ReportPrintOptions.DetailCountAtDesignTime = 7
            Me.Version = "14.2"
            Me.Watermark.Image = (CType(resources.GetObject("Report.Watermark.Image"), System.Drawing.Image))
            Me.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.Watermark.ImageTiling = True
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region
    End Class
End Namespace

