Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Collections

Public Class MailReport
	Inherits XtraReport
	Private TopMargin As TopMarginBand
	Private table2 As XRTable
	Private tableRow2 As XRTableRow
	Private tableCell4 As XRTableCell
	Private tableCell5 As XRTableCell
	Private tableCell6 As XRTableCell
	Private table1 As XRTable
	Private tableRow1 As XRTableRow
	Private tableCell1 As XRTableCell
	Private tableCell2 As XRTableCell
	Private tableCell3 As XRTableCell
	Private BottomMargin As BottomMarginBand
	Private Detail As DetailBand

	Public Sub New(ByVal messages As IEnumerable)
		InitializeComponent()
		Me.DataSource = messages
	End Sub

	Private Sub InitializeComponent()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.table2 = New DevExpress.XtraReports.UI.XRTable()
		Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.table1 = New DevExpress.XtraReports.UI.XRTable()
		Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' TopMargin
		' 
		Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
		Me.TopMargin.HeightF = 133.3333F
		Me.TopMargin.Name = "TopMargin"
		' 
		' table2
		' 
		Me.table2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
		Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 97.50001F)
		Me.table2.Name = "table2"
		Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
		Me.table2.SizeF = New System.Drawing.SizeF(630F, 35.8333F)
		' 
		' tableRow2
		' 
		Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell4, Me.tableCell5, Me.tableCell6})
		Me.tableRow2.Name = "tableRow2"
		Me.tableRow2.Weight = 1R
		' 
		' tableCell4
		' 
		Me.tableCell4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
		Me.tableCell4.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
		Me.tableCell4.CanGrow = False
		Me.tableCell4.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
		Me.tableCell4.Name = "tableCell4"
		Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell4.StylePriority.UseBackColor = False
		Me.tableCell4.StylePriority.UseBorders = False
		Me.tableCell4.StylePriority.UseFont = False
		Me.tableCell4.StylePriority.UsePadding = False
		Me.tableCell4.Text = "From"
		Me.tableCell4.Weight = 1R
		' 
		' tableCell5
		' 
		Me.tableCell5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
		Me.tableCell5.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
		Me.tableCell5.CanGrow = False
		Me.tableCell5.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
		Me.tableCell5.Name = "tableCell5"
		Me.tableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell5.StylePriority.UseBackColor = False
		Me.tableCell5.StylePriority.UseBorders = False
		Me.tableCell5.StylePriority.UseFont = False
		Me.tableCell5.StylePriority.UsePadding = False
		Me.tableCell5.Text = "Subject"
		Me.tableCell5.Weight = 1.461309523809524R
		' 
		' tableCell6
		' 
		Me.tableCell6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
		Me.tableCell6.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
		Me.tableCell6.CanGrow = False
		Me.tableCell6.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
		Me.tableCell6.Name = "tableCell6"
		Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell6.StylePriority.UseBackColor = False
		Me.tableCell6.StylePriority.UseBorders = False
		Me.tableCell6.StylePriority.UseFont = False
		Me.tableCell6.StylePriority.UsePadding = False
		Me.tableCell6.Text = "Date"
		Me.tableCell6.Weight = 0.53869047619047616R
		' 
		' table1
		' 
		Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(10F, 0F)
		Me.table1.Name = "table1"
		Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
		Me.table1.SizeF = New System.Drawing.SizeF(630F, 25F)
		' 
		' tableRow1
		' 
		Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2, Me.tableCell3})
		Me.tableRow1.Name = "tableRow1"
		Me.tableRow1.Weight = 1R
		' 
		' tableCell1
		' 
		Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Top
		Me.tableCell1.Name = "tableCell1"
		Me.tableCell1.StylePriority.UseBorders = False
		Me.tableCell1.Text = "[From]"
		Me.tableCell1.Weight = 2.1000004577636715R
		' 
		' tableCell2
		' 
		Me.tableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Top
		Me.tableCell2.Name = "tableCell2"
		Me.tableCell2.StylePriority.UseBorders = False
		Me.tableCell2.Text = "[Subject]"
		Me.tableCell2.Weight = 3.068749389648437R
		' 
		' tableCell3
		' 
		Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Top
		Me.tableCell3.Name = "tableCell3"
		Me.tableCell3.StylePriority.UseBorders = False
		Me.tableCell3.Text = "[Date]"
		Me.tableCell3.Weight = 1.1312501525878913R
		' 
		' BottomMargin
		' 
		Me.BottomMargin.Name = "BottomMargin"
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
		Me.Detail.HeightF = 35.00001F
		Me.Detail.Name = "Detail"
		' 
		' MailReport
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.Detail, Me.BottomMargin})
		Me.Margins = New System.Drawing.Printing.Margins(100, 100, 133, 100)
		Me.Version = "13.2"
		CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
End Class
