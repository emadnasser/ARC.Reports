Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.Subreports
    Partial Public Class MasterReport
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Private lbCompany As DevExpress.XtraReports.UI.XRLabel
        Private lbCompany1 As DevExpress.XtraReports.UI.XRLabel
        Private lbOccupation As DevExpress.XtraReports.UI.XRLabel
        Private lbOccupation1 As DevExpress.XtraReports.UI.XRLabel
        Private lbCustomer As DevExpress.XtraReports.UI.XRLabel
        Private lbTitle As DevExpress.XtraReports.UI.XRLabel
        Private lbDate As DevExpress.XtraReports.UI.XRLabel
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private lbPersonName As DevExpress.XtraReports.UI.XRLabel
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private subreport1 As DevExpress.XtraReports.UI.XRSubreport
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MasterReport))
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As New DevExpress.DataAccess.Sql.CustomExpression()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbDate = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbPersonName = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCustomer = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbOccupation1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbOccupation = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCompany1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCompany = New DevExpress.XtraReports.UI.XRLabel()
            Me.fromDateParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.toDateParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.dsCust1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.subreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDate, Me.lbTitle})
            Me.ReportHeader.HeightF = 88F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbDate
            ' 
            Me.lbDate.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbDate.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(129)))), (CInt((CByte(142)))), (CInt((CByte(158)))))
            Me.lbDate.LocationFloat = New DevExpress.Utils.PointFloat(17F, 48F)
            Me.lbDate.Name = "lbDate"
            Me.lbDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbDate.SizeF = New System.Drawing.SizeF(628F, 16F)
            Me.lbDate.Text = "Orders with purchase dates from [Parameters.fromDateParameter!d] to [Parameters.t" & "oDateParameter!d]"
            Me.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' lbTitle
            ' 
            Me.lbTitle.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(129)))), (CInt((CByte(142)))), (CInt((CByte(158)))))
            Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbTitle.BorderWidth = 2F
            Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 14.25F)
            Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(129)))), (CInt((CByte(142)))), (CInt((CByte(158)))))
            Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(17F, 20F)
            Me.lbTitle.Name = "lbTitle"
            Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbTitle.SizeF = New System.Drawing.SizeF(628F, 28F)
            Me.lbTitle.Text = "Customer list with order information"
            Me.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1, Me.subreport1})
            Me.Detail.HeightF = 112F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(244)))), (CInt((CByte(242)))), (CInt((CByte(237)))))
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(214)))), (CInt((CByte(200)))))
            Me.xrTable1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Customers.PersonName")})
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(15F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(628F, 60F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbPersonName, Me.lbCustomer})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell1.Weight = 0.39331210191082805R
            ' 
            ' lbPersonName
            ' 
            Me.lbPersonName.BorderColor = System.Drawing.SystemColors.ControlText
            Me.lbPersonName.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbPersonName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.PersonName")})
            Me.lbPersonName.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.lbPersonName.LocationFloat = New DevExpress.Utils.PointFloat(80F, 8F)
            Me.lbPersonName.Name = "lbPersonName"
            Me.lbPersonName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbPersonName.SizeF = New System.Drawing.SizeF(106F, 25F)
            Me.lbPersonName.Text = "lbPersonName"
            Me.lbPersonName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCustomer
            ' 
            Me.lbCustomer.BorderColor = System.Drawing.SystemColors.ControlText
            Me.lbCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbCustomer.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbCustomer.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(167)))), (CInt((CByte(157)))), (CInt((CByte(134)))))
            Me.lbCustomer.LocationFloat = New DevExpress.Utils.PointFloat(8F, 8F)
            Me.lbCustomer.Name = "lbCustomer"
            Me.lbCustomer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCustomer.SizeF = New System.Drawing.SizeF(70F, 25F)
            Me.lbCustomer.Text = "Customer:"
            Me.lbCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableCell2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbOccupation1, Me.lbOccupation, Me.lbCompany1, Me.lbCompany})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell2.Weight = 0.606687898089172R
            ' 
            ' lbOccupation1
            ' 
            Me.lbOccupation1.BorderColor = System.Drawing.SystemColors.ControlText
            Me.lbOccupation1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbOccupation1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Occupation")})
            Me.lbOccupation1.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.lbOccupation1.LocationFloat = New DevExpress.Utils.PointFloat(104F, 28F)
            Me.lbOccupation1.Name = "lbOccupation1"
            Me.lbOccupation1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbOccupation1.SizeF = New System.Drawing.SizeF(150F, 20F)
            Me.lbOccupation1.Text = "xrLabel4"
            Me.lbOccupation1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbOccupation
            ' 
            Me.lbOccupation.BorderColor = System.Drawing.SystemColors.ControlText
            Me.lbOccupation.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbOccupation.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbOccupation.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(167)))), (CInt((CByte(157)))), (CInt((CByte(134)))))
            Me.lbOccupation.LocationFloat = New DevExpress.Utils.PointFloat(12F, 28F)
            Me.lbOccupation.Name = "lbOccupation"
            Me.lbOccupation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbOccupation.SizeF = New System.Drawing.SizeF(91F, 20F)
            Me.lbOccupation.Text = "Occupation:"
            Me.lbOccupation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCompany1
            ' 
            Me.lbCompany1.BorderColor = System.Drawing.SystemColors.ControlText
            Me.lbCompany1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbCompany1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Company")})
            Me.lbCompany1.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.lbCompany1.LocationFloat = New DevExpress.Utils.PointFloat(104F, 8F)
            Me.lbCompany1.Name = "lbCompany1"
            Me.lbCompany1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCompany1.SizeF = New System.Drawing.SizeF(150F, 17F)
            Me.lbCompany1.Text = "xrLabel3"
            Me.lbCompany1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCompany
            ' 
            Me.lbCompany.BorderColor = System.Drawing.SystemColors.ControlText
            Me.lbCompany.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.lbCompany.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbCompany.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(167)))), (CInt((CByte(157)))), (CInt((CByte(134)))))
            Me.lbCompany.LocationFloat = New DevExpress.Utils.PointFloat(12F, 8F)
            Me.lbCompany.Name = "lbCompany"
            Me.lbCompany.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCompany.SizeF = New System.Drawing.SizeF(83F, 17F)
            Me.lbCompany.Text = "Company:"
            Me.lbCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' fromDateParameter
            ' 
            Me.fromDateParameter.Description = "From date:"
            Me.fromDateParameter.Name = "fromDateParameter"
            Me.fromDateParameter.Type = GetType(Date)
            Me.fromDateParameter.ValueInfo = "2016-11-20"
            ' 
            ' toDateParameter
            ' 
            Me.toDateParameter.Description = "To date:"
            Me.toDateParameter.Name = "toDateParameter"
            Me.toDateParameter.Type = GetType(Date)
            Me.toDateParameter.ValueInfo = "2016-12-20"
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
            ' dsCust1
            ' 
            Me.dsCust1.ConnectionName = "HomesConnectionString"
            Me.dsCust1.Name = "dsCust1"
            columnExpression1.ColumnName = "ID"
            table1.Name = "Customers"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Company"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Occupation"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            column4.Alias = "PersonName"
            customExpression1.Expression = "Concat([Customers].[FirstName], ' ', [Customers].[LastName])"
            column4.Expression = customExpression1
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Customers"
            selectQuery1.Tables.Add(table1)
            Me.dsCust1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsCust1.ResultSchemaSerializable = resources.GetString("dsCust1.ResultSchemaSerializable")
            ' 
            ' subreport1
            ' 
            Me.subreport1.LocationFloat = New DevExpress.Utils.PointFloat(15F, 60F)
            Me.subreport1.Name = "subreport1"
            Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("customerIDParameter", Nothing, "Customers.ID"))
            Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("fromDateParameter", Me.fromDateParameter))
            Me.subreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("toDateParameter", Me.toDateParameter))
            Me.subreport1.ReportSource = New XtraReportsDemos.Subreports.DetailReport()
            Me.subreport1.SizeF = New System.Drawing.SizeF(628F, 52F)
            ' 
            ' MasterReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.ReportHeader, Me.Detail, Me.BottomMargin, Me.topMarginBand1})
            Me.DataMember = "Customers"
            Me.DataSource = Me.dsCust1
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 75)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.fromDateParameter, Me.toDateParameter})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 2
            Me.RequestParameters = False
            Me.Version = "16.1"
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        #End Region

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Public detailReport1 As DetailReport
        Private dsCust1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private fromDateParameter As DevExpress.XtraReports.Parameters.Parameter
        Private toDateParameter As DevExpress.XtraReports.Parameters.Parameter
        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
