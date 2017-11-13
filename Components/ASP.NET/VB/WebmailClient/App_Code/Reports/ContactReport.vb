Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.UI
Imports System.Collections

Public Class ContactReport
	Inherits XtraReport
	Private tableRow1 As XRTableRow
	Private tableCell1 As XRTableCell
	Private tableCell2 As XRTableCell
	Private tableCell4 As XRTableCell
	Private tableRow3 As XRTableRow
	Private tableCell3 As XRTableCell
	Private tableCell6 As XRTableCell
	Private label1 As XRLabel
	Private tableRow2 As XRTableRow
	Private tableCell5 As XRTableCell
	Private TopMargin As TopMarginBand
	Private ReportHeader As ReportHeaderBand
	Private Detail As DetailBand
	Private WithEvents table1 As XRTable
	Private tableRow4 As XRTableRow
	Private tableCell7 As XRTableCell
	Private tableCell8 As XRTableCell
	Private WithEvents pictureBox1 As XRPictureBox
	Private BottomMargin As BottomMarginBand

	Public Sub New(ByVal contacts As IEnumerable)
		InitializeComponent()
		Me.DataSource = contacts
	End Sub

	Private Sub InitializeComponent()
		Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.table1 = New DevExpress.XtraReports.UI.XRTable()
		Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' tableRow1
		' 
		Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2})
		Me.tableRow1.Name = "tableRow1"
		Me.tableRow1.Weight = 1R
		' 
		' tableCell1
		' 
		Me.tableCell1.Font = New System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.tableCell1.Name = "tableCell1"
		Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell1.StylePriority.UseFont = False
		Me.tableCell1.StylePriority.UsePadding = False
		Me.tableCell1.StylePriority.UseTextAlignment = False
		Me.tableCell1.Text = "Name"
		Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell1.Weight = 0.74962134111264145R
		' 
		' tableCell2
		' 
		Me.tableCell2.Name = "tableCell2"
		Me.tableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell2.StylePriority.UsePadding = False
		Me.tableCell2.StylePriority.UseTextAlignment = False
		Me.tableCell2.Text = "[Name]"
		Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell2.Weight = 2.2503786588873589R
		' 
		' tableCell4
		' 
		Me.tableCell4.Font = New System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.tableCell4.Name = "tableCell4"
		Me.tableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell4.StylePriority.UseFont = False
		Me.tableCell4.StylePriority.UsePadding = False
		Me.tableCell4.StylePriority.UseTextAlignment = False
		Me.tableCell4.Text = "Email"
		Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell4.Weight = 0.74962134111264134R
		' 
		' tableRow3
		' 
		Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell3, Me.tableCell6})
		Me.tableRow3.Name = "tableRow3"
		Me.tableRow3.Weight = 1R
		' 
		' tableCell3
		' 
		Me.tableCell3.Font = New System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.tableCell3.Name = "tableCell3"
		Me.tableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell3.StylePriority.UseFont = False
		Me.tableCell3.StylePriority.UsePadding = False
		Me.tableCell3.StylePriority.UseTextAlignment = False
		Me.tableCell3.Text = "Address"
		Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell3.Weight = 0.74962156339552211R
		' 
		' tableCell6
		' 
		Me.tableCell6.Name = "tableCell6"
		Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell6.StylePriority.UsePadding = False
		Me.tableCell6.StylePriority.UseTextAlignment = False
		Me.tableCell6.Text = "[Address]"
		Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell6.Weight = 2.2503784366044779R
		' 
		' label1
		' 
		Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
		Me.label1.Font = New System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold)
		Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
		Me.label1.Name = "label1"
		Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.label1.SizeF = New System.Drawing.SizeF(639.9999F, 35.875F)
		Me.label1.StylePriority.UseBackColor = False
		Me.label1.StylePriority.UseFont = False
		Me.label1.StylePriority.UseTextAlignment = False
		Me.label1.Text = "Contacts List"
		Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		' 
		' tableRow2
		' 
		Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell4, Me.tableCell5})
		Me.tableRow2.Name = "tableRow2"
		Me.tableRow2.Weight = 1R
		' 
		' tableCell5
		' 
		Me.tableCell5.Name = "tableCell5"
		Me.tableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell5.StylePriority.UsePadding = False
		Me.tableCell5.StylePriority.UseTextAlignment = False
		Me.tableCell5.Text = "[Email]"
		Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell5.Weight = 2.2503786588873584R
		' 
		' TopMargin
		' 
		Me.TopMargin.Name = "TopMargin"
		' 
		' ReportHeader
		' 
		Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
		Me.ReportHeader.HeightF = 35.875F
		Me.ReportHeader.Name = "ReportHeader"
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1, Me.pictureBox1})
		Me.Detail.HeightF = 198.9583F
		Me.Detail.Name = "Detail"
		' 
		' table1
		' 
		Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(203.125F, 33.29166F)
		Me.table1.Name = "table1"
		Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1, Me.tableRow2, Me.tableRow3, Me.tableRow4})
		Me.table1.SizeF = New System.Drawing.SizeF(411.8749F, 129.1667F)
'		Me.table1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.table1_BeforePrint);
		' 
		' tableRow4
		' 
		Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell7, Me.tableCell8})
		Me.tableRow4.Name = "tableRow4"
		Me.tableRow4.Weight = 1R
		' 
		' tableCell7
		' 
		Me.tableCell7.Font = New System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.tableCell7.Name = "tableCell7"
		Me.tableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell7.StylePriority.UseFont = False
		Me.tableCell7.StylePriority.UsePadding = False
		Me.tableCell7.StylePriority.UseTextAlignment = False
		Me.tableCell7.Text = "Phone"
		Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell7.Weight = 0.74962156339552211R
		' 
		' tableCell8
		' 
		Me.tableCell8.Name = "tableCell8"
		Me.tableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F)
		Me.tableCell8.StylePriority.UsePadding = False
		Me.tableCell8.StylePriority.UseTextAlignment = False
		Me.tableCell8.Text = "[Phone]"
		Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.tableCell8.Weight = 2.2503784366044779R
		' 
		' pictureBox1
		' 
		Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 22.87499F)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.SizeF = New System.Drawing.SizeF(150F, 150F)
		Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
'		Me.pictureBox1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.pictureBox1_BeforePrint);
		' 
		' BottomMargin
		' 
		Me.BottomMargin.Name = "BottomMargin"
		' 
		' ContactReport
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.Detail, Me.BottomMargin, Me.ReportHeader})
		Me.Version = "13.2"
		CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	Private Sub table1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles table1.BeforePrint
		Dim table = CType(sender, XRTable)
		Dim report = table.Report
		Dim address = report.GetCurrentColumnValue(Of String)("Address")
		Dim phone = report.GetCurrentColumnValue(Of String)("Phone")

		If String.IsNullOrEmpty(address) Then
			Me.tableRow3.Visible = False
		End If
		If String.IsNullOrEmpty(phone) Then
			Me.tableRow4.Visible = False
		End If
	End Sub

	Private Sub pictureBox1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles pictureBox1.BeforePrint
		Dim pictureBox = CType(sender, XRPictureBox)
		pictureBox.ImageUrl = pictureBox.Report.GetCurrentColumnValue(Of String)("PhotoUrl")
	End Sub
End Class
