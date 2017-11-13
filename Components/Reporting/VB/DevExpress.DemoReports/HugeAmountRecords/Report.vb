Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.HugeAmountRecords
    Public Class Report
        Inherits XtraReport

        Private xrTable2 As XRTable
        Private xrTableRow2 As XRTableRow
        Private xrTableCell6 As XRTableCell
        Private xrTableCell7 As XRTableCell
        Private xrTableCell8 As XRTableCell
        Private xrTableCell9 As XRTableCell
        Private xrTableCell10 As XRTableCell
        Private PageHeader As PageHeaderBand
        Private WithEvents xrTable1 As XRTable
        Private xrTableRow1 As XRTableRow
        Private xrTableCell1 As XRTableCell
        Private xrCheckBox1 As XRCheckBox
        Private xrTableCell2 As XRTableCell
        Private xrTableCell3 As XRTableCell
        Private xrTableCell4 As XRTableCell
        Private xrTableCell5 As XRTableCell
        Private oddStyle As XRControlStyle
        Private calculatedField1 As CalculatedField
        Private xrPageInfo1 As XRPageInfo
        Private BottomMargin As BottomMarginBand
        Private GroupFooter1 As GroupFooterBand
        Private xrPageBreak1 As XRPageBreak
        Private xrLabel1 As XRLabel
        Private GroupHeader1 As GroupHeaderBand
        Private topMarginBand1 As TopMarginBand
        Private RowCountParameter As DevExpress.XtraReports.Parameters.Parameter
        Private Detail As DetailBand
        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
        Private components As System.ComponentModel.IContainer

        Public Sub New()
            InitializeComponent()
            Name = ReportName
            DisplayName = ReportName
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim parameter1 As New DevExpress.DataAccess.ObjectBinding.Parameter()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.oddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.RowCountParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(230)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
            Me.xrTable1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.OddStyleName = "oddStyle"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(646F, 23F)
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ColumnID")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.10371517027863778R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ColumnText")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.29566563467492263R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ColumnCurrency", "{0:c2}")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 35, 0, 0, 100F)
            Me.xrTableCell3.StylePriority.UsePadding = False
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.Weight = 0.19969040247678019R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ColumnDate", "{0:MM/dd/yyyy}")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.19969040247678019R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCheckBox1})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 0.20123839009287925R
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrCheckBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "ColumnBool")})
            Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(57F, 3F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(25F, 17F)
            Me.xrCheckBox1.StylePriority.UseBorders = False
            Me.xrCheckBox1.StylePriority.UseTextAlignment = False
            Me.xrCheckBox1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(118)))), (CInt((CByte(130)))), (CInt((CByte(112)))))
            Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(230)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
            Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.xrTable2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(233)))), (CInt((CByte(233)))), (CInt((CByte(233)))))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(646F, 23F)
            Me.xrTable2.StylePriority.UseBackColor = False
            Me.xrTable2.StylePriority.UseBorderColor = False
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseForeColor = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell6.Text = "ID"
            Me.xrTableCell6.Weight = 0.10371517027863778R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.Text = "Text"
            Me.xrTableCell7.Weight = 0.29566563467492263R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.Text = "Currency"
            Me.xrTableCell8.Weight = 0.19969040247678019R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell9.Text = "Date"
            Me.xrTableCell9.Weight = 0.19969040247678019R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.Text = "Bool"
            Me.xrTableCell10.Weight = 0.20123839009287925R
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.PageHeader.HeightF = 23F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' oddStyle
            ' 
            Me.oddStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(236)))), (CInt((CByte(239)))), (CInt((CByte(233)))))
            Me.oddStyle.Name = "oddStyle"
            ' 
            ' calculatedField1
            ' 
            Me.calculatedField1.DataSource = Me.objectDataSource1
            Me.calculatedField1.Expression = "([ColumnID] -1) / 1000 + 1"
            Me.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
            Me.calculatedField1.Name = "calculatedField1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic)
            Me.xrPageInfo1.Format = "{0} of {1} pages "
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(558F, 4.999987F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.RunningBand = Me.GroupHeader1
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(92F, 25F)
            Me.xrPageInfo1.StylePriority.UseFont = False
            Me.xrPageInfo1.StylePriority.UseTextAlignment = False
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("calculatedField1", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 0F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.Visible = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrLabel1})
            Me.BottomMargin.HeightF = 63F
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(258F, 4.999987F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(300F, 25F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Group [calculatedField1]:"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrLabel1.XlsxFormatString = """Group ""0"":"""
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1})
            Me.GroupFooter1.HeightF = 2F
            Me.GroupFooter1.Name = "GroupFooter1"
            ' 
            ' xrPageBreak1
            ' 
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' RowCountParameter
            ' 
            Me.RowCountParameter.Description = "Row Count"
            Me.RowCountParameter.Name = "RowCountParameter"
            Me.RowCountParameter.Type = GetType(UInteger)
            Me.RowCountParameter.ValueInfo = "100000"
            '
            ' objectDataSource1
            ' 
            Me.objectDataSource1.DataMember = "CreateItems"
            Me.objectDataSource1.DataSource = GetType(XtraReportsDemos.HugeAmountRecords.DataItem)
            Me.objectDataSource1.Name = "objectDataSource1"
            parameter1.Name = "rowCount"
            parameter1.Type = GetType(DevExpress.DataAccess.Expression)
            parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.RowCountParameter]", GetType(Integer))
            Me.objectDataSource1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() { parameter1})
            '
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.GroupHeader1, Me.BottomMargin, Me.GroupFooter1, Me.topMarginBand1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calculatedField1})
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 63)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.RowCountParameter})
            Me.ReportPrintOptions.DetailCountAtDesignTime = 25
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.oddStyle})
            Me.DataSource = objectDataSource1
            Me.ComponentStorage.Add(objectDataSource1)
            Me.Version = "15.2"
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Private ReadOnly Property ActualPrintRowCount() As UInteger
            Get
                Return If(BrickPresentation = DevExpress.XtraReports.Native.BrickPresentation.Runtime, CUInt(Parameters("RowCountParameter").Value), CUInt(ReportPrintOptions.DetailCountAtDesignTime))
            End Get
        End Property
        Protected Overridable ReadOnly Property ReportName() As String
            Get
                Return ReportNames.HugeAmountRecords
            End Get
        End Property

        Private ReadOnly Property RowIndex() As Integer?
            Get
                Return Report.GetCurrentColumnValue(Of Integer?)(calculatedField1.Name)
            End Get
        End Property

        Private prevRowIndex? As Integer

        Private Sub xrTable1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrTable1.BeforePrint
            Dim table As XRTable = DirectCast(sender, XRTable)

            Dim rowIndex_Renamed? As Integer = RowIndex
            If Not prevRowIndex.Equals(rowIndex_Renamed) Then
                table.Bookmark = String.Format("Record # {0}", Report.GetCurrentColumnValue("ColumnID"))
                prevRowIndex = rowIndex_Renamed
            Else
                table.Bookmark = Nothing
            End If
        End Sub
    End Class
End Namespace
