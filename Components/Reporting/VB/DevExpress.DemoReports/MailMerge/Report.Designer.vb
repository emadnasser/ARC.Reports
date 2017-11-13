Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace XtraReportsDemos.MailMerge
    Partial Public Class Report
        Private WithEvents xrRichText1 As DevExpress.XtraReports.UI.XRRichText
        Private Detail As DevExpress.XtraReports.UI.DetailBand

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
            Dim column18 As New DevExpress.DataAccess.Sql.Column()
            Dim customExpression1 As New DevExpress.DataAccess.Sql.CustomExpression()
            Dim join1 As New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.dsEmployees1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.AddressWithoutLineBreaks = New DevExpress.XtraReports.UI.CalculatedField()
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrRichText1})
            Me.Detail.HeightF = 244F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrRichText1
            ' 
            Me.xrRichText1.BackColor = System.Drawing.Color.Transparent
            Me.xrRichText1.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.xrRichText1.KeepTogether = True
            Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 8F)
            Me.xrRichText1.Name = "xrRichText1"
            Me.xrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
            Me.xrRichText1.SizeF = New System.Drawing.SizeF(634F, 217F)
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' dsEmployees1
            ' 
            Me.dsEmployees1.ConnectionName = "NWindConnectionString"
            Me.dsEmployees1.Name = "dsEmployees1"
            columnExpression1.ColumnName = "Address"
            table1.Alias = "e"
            table1.Name = "Employees"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "BirthDate"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "City"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Country"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "EmployeeID"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "LastName"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "FirstName"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "HireDate"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "HomePhone"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Notes"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "Photo"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "PostalCode"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "Extension"
            columnExpression13.Table = table1
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "Region"
            columnExpression14.Table = table1
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ReportsTo"
            columnExpression15.Table = table1
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Title"
            columnExpression16.Table = table1
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "TitleOfCourtesy"
            columnExpression17.Table = table1
            column17.Expression = columnExpression17
            column18.Alias = "ReportsToInfo"
            customExpression1.Expression = "Concat([r].[FirstName], ' ', [r].[LastName])"
            column18.Expression = customExpression1
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
            selectQuery1.Columns.Add(column18)
            selectQuery1.Name = "Employees"
            relationColumnInfo1.NestedKeyColumn = "EmployeeID"
            relationColumnInfo1.ParentKeyColumn = "ReportsTo"
            join1.KeyColumns.Add(relationColumnInfo1)
            table2.Alias = "r"
            table2.Name = "Employees"
            join1.Nested = table2
            join1.Parent = table1
            join1.Type = DevExpress.Xpo.DB.JoinType.LeftOuter
            selectQuery1.Relations.Add(join1)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            Me.dsEmployees1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.dsEmployees1.ResultSchemaSerializable = resources.GetString("dsEmployees1.ResultSchemaSerializable")
            ' 
            ' AddressWithoutLineBreaks
            ' 
            Me.AddressWithoutLineBreaks.DataMember = "Employees"
            Me.AddressWithoutLineBreaks.Expression = "Replace([Address], Concat(Char(13), Char(10)), ' ')"
            Me.AddressWithoutLineBreaks.Name = "AddressWithoutLineBreaks"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.AddressWithoutLineBreaks})
            Me.DataMember = "Employees"
            Me.DataSource = Me.dsEmployees1
            Me.ReportPrintOptions.DetailCountAtDesignTime = 2
            Me.Version = "16.1"
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
        Private dsEmployees1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private components As System.ComponentModel.IContainer
        Private AddressWithoutLineBreaks As DevExpress.XtraReports.UI.CalculatedField
    End Class
End Namespace
