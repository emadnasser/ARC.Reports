Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler
Imports System.ComponentModel
Imports System.Drawing

''' <summary>
''' Summary description for ScheduleReport
''' </summary>
Public Class ScheduleReport
	Inherits XtraReport
	Private topMarginBand1 As TopMarginBand
	Private detailBand1 As DetailBand
	Private GroupHeader1 As GroupHeaderBand
	Private PageHeader As PageHeaderBand
	Private xrLabelDay As XRLabel
	Private bottomMarginBand1 As BottomMarginBand
	Private xrControlStyle1 As XRControlStyle
	Private dataSet1 As System.Data.DataSet
	Private dataTable1 As System.Data.DataTable
	Private formattingRule1 As FormattingRule
	Private formattingRule2 As FormattingRule
	Private dataColumn1 As System.Data.DataColumn
	Private dataColumn2 As System.Data.DataColumn
	Private dataColumn3 As System.Data.DataColumn
	Private dataColumn4 As System.Data.DataColumn
	Private dataColumn5 As System.Data.DataColumn
	Private dataColumn6 As System.Data.DataColumn
	Private xrTable1 As XRTable
	Private xrTableRow1 As XRTableRow
	Private xrTableCell3 As XRTableCell
	Private xrTableCell1 As XRTableCell
	Private xrPanel1 As XRPanel
	Private GroupFooter1 As GroupFooterBand
	Private xrTableCell2 As XRTableCell

	Public Sub New(ByVal sessions As List(Of Session))
		InitializeComponent()
		InitDataSource(sessions)
	End Sub
	Private Sub InitDataSource(ByVal sessions As List(Of Session))
		For Each session As Session In sessions
			Dim adapter As New SessionPrintAdapter(session)
			dataSet1.Tables("reportAppointments").Rows.Add(adapter.Day, adapter.Time, adapter.Subject, adapter.Location, adapter.StartTime, adapter.Important)
		Next session
	End Sub

	Private Sub InitializeComponent()
		Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
		Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
		Me.formattingRule2 = New DevExpress.XtraReports.UI.FormattingRule()
		Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.dataTable1 = New System.Data.DataTable()
		Me.dataColumn1 = New System.Data.DataColumn()
		Me.dataColumn2 = New System.Data.DataColumn()
		Me.dataColumn3 = New System.Data.DataColumn()
		Me.dataColumn4 = New System.Data.DataColumn()
		Me.dataColumn5 = New System.Data.DataColumn()
		Me.dataColumn6 = New System.Data.DataColumn()
		Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
		Me.xrLabelDay = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.dataSet1 = New System.Data.DataSet()
		Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
		Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
		CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' topMarginBand1
		' 
		Me.topMarginBand1.HeightF = 24F
		Me.topMarginBand1.Name = "topMarginBand1"
		' 
		' detailBand1
		' 
		Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
		Me.detailBand1.HeightF = 30.00002F
		Me.detailBand1.Name = "detailBand1"
		Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("StartTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
		' 
		' xrTable1
		' 
		Me.xrTable1.FormattingRules.Add(Me.formattingRule1)
		Me.xrTable1.FormattingRules.Add(Me.formattingRule2)
		Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(53.84301F, 1.000015F)
		Me.xrTable1.Name = "xrTable1"
		Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
		Me.xrTable1.SizeF = New System.Drawing.SizeF(772.625F, 24F)
		Me.xrTable1.StylePriority.UseTextAlignment = False
		Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		' 
		' formattingRule1
		' 
		Me.formattingRule1.Condition = "[Important] == 1"
		' 
		' 
		' 
		Me.formattingRule1.Formatting.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(245))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(245))))))
		Me.formattingRule1.Name = "formattingRule1"
		' 
		' formattingRule2
		' 
		Me.formattingRule2.Condition = "[Important] == 2"
		' 
		' 
		' 
		Me.formattingRule2.Formatting.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
		Me.formattingRule2.Name = "formattingRule2"
		' 
		' xrTableRow1
		' 
		Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
		Me.xrTableRow1.Name = "xrTableRow1"
		Me.xrTableRow1.Weight = 0.96000000000000008R
		' 
		' xrTableCell1
		' 
		Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Me.dataTable1, "Time")})
		Me.xrTableCell1.Font = New System.Drawing.Font("Segoe UI", 9.75F)
		Me.xrTableCell1.Name = "xrTableCell1"
		Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F)
		Me.xrTableCell1.StylePriority.UseFont = False
		Me.xrTableCell1.StylePriority.UsePadding = False
		Me.xrTableCell1.StylePriority.UseTextAlignment = False
		Me.xrTableCell1.Text = "xrTableCell1"
		Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.xrTableCell1.Weight = 1.5730536282386878R
		' 
		' dataTable1
		' 
		Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4, Me.dataColumn5, Me.dataColumn6})
		Me.dataTable1.TableName = "reportAppointments"
		' 
		' dataColumn1
		' 
		Me.dataColumn1.ColumnName = "Day"
		' 
		' dataColumn2
		' 
		Me.dataColumn2.ColumnName = "Time"
		' 
		' dataColumn3
		' 
		Me.dataColumn3.ColumnName = "Subject"
		' 
		' dataColumn4
		' 
		Me.dataColumn4.ColumnName = "Locatoin"
		' 
		' dataColumn5
		' 
		Me.dataColumn5.ColumnMapping = System.Data.MappingType.Hidden
		Me.dataColumn5.ColumnName = "StartTime"
		Me.dataColumn5.DataType = GetType(System.DateTime)
		' 
		' dataColumn6
		' 
		Me.dataColumn6.ColumnMapping = System.Data.MappingType.Hidden
		Me.dataColumn6.ColumnName = "Important"
		Me.dataColumn6.DataType = GetType(Integer)
		' 
		' xrTableCell2
		' 
		Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Me.dataTable1, "Subject")})
		Me.xrTableCell2.Font = New System.Drawing.Font("Segoe UI", 9.75F)
		Me.xrTableCell2.Name = "xrTableCell2"
		Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.xrTableCell2.StylePriority.UseFont = False
		Me.xrTableCell2.StylePriority.UsePadding = False
		Me.xrTableCell2.StylePriority.UseTextAlignment = False
		Me.xrTableCell2.Text = "xrTableCell2"
		Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.xrTableCell2.Weight = 4.1472430771744557R
		' 
		' xrTableCell3
		' 
		Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Me.dataTable1, "Locatoin")})
		Me.xrTableCell3.Font = New System.Drawing.Font("Segoe UI", 9.75F)
		Me.xrTableCell3.Name = "xrTableCell3"
		Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.xrTableCell3.StylePriority.UseFont = False
		Me.xrTableCell3.StylePriority.UsePadding = False
		Me.xrTableCell3.StylePriority.UseTextAlignment = False
		Me.xrTableCell3.Text = "xrTableCell3"
		Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.xrTableCell3.Weight = 0.7444024566640064R
		' 
		' bottomMarginBand1
		' 
		Me.bottomMarginBand1.HeightF = 59.29171F
		Me.bottomMarginBand1.Name = "bottomMarginBand1"
		' 
		' GroupHeader1
		' 
		Me.GroupHeader1.BackColor = System.Drawing.Color.Silver
		Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelDay})
		Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Day", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
		Me.GroupHeader1.HeightF = 80.70831F
		Me.GroupHeader1.Name = "GroupHeader1"
		Me.GroupHeader1.StylePriority.UseBackColor = False
		' 
		' xrLabelDay
		' 
		Me.xrLabelDay.BackColor = System.Drawing.Color.Transparent
		Me.xrLabelDay.CanShrink = True
		Me.xrLabelDay.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Me.dataTable1, "Day")})
		Me.xrLabelDay.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
		Me.xrLabelDay.LocationFloat = New DevExpress.Utils.PointFloat(53.84301F, 34.375F)
		Me.xrLabelDay.Name = "xrLabelDay"
		Me.xrLabelDay.SizeF = New System.Drawing.SizeF(200.4166F, 35.29167F)
		Me.xrLabelDay.StylePriority.UseBackColor = False
		Me.xrLabelDay.StylePriority.UseFont = False
		Me.xrLabelDay.Text = "xrLabelDay"
		' 
		' PageHeader
		' 
		Me.PageHeader.HeightF = 109.7917F
		Me.PageHeader.Name = "PageHeader"
		' 
		' xrControlStyle1
		' 
		Me.xrControlStyle1.Name = "xrControlStyle1"
		Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		' 
		' dataSet1
		' 
		Me.dataSet1.DataSetName = "NewDataSet"
		Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
		' 
		' xrPanel1
		' 
		Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
		Me.xrPanel1.Name = "xrPanel1"
		Me.xrPanel1.SizeF = New System.Drawing.SizeF(5.104168F, 2F)
		' 
		' GroupFooter1
		' 
		Me.GroupFooter1.HeightF = 40.625F
		Me.GroupFooter1.Name = "GroupFooter1"
		' 
		' ScheduleReport
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.bottomMarginBand1, Me.topMarginBand1, Me.detailBand1, Me.GroupHeader1, Me.PageHeader, Me.GroupFooter1})
		Me.DataMember = "reportAppointments"
		Me.DataSource = Me.dataSet1
		Me.FormattingRules.Add(Me.formattingRule1)
		Me.FormattingRules.Add(Me.formattingRule2)
		Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1, Me.formattingRule2})
		Me.Margins = New System.Drawing.Printing.Margins(0, 0, 24, 59)
		Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1})
		Me.Version = "11.2"
		CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
End Class

Public Class SessionPrintAdapter
	Public Property Session() As Session

	Public ReadOnly Property Day() As String
		Get
			Return StartTime.ToShortDateString()
		End Get
	End Property
	Public ReadOnly Property Time() As String
		Get
			Return String.Format("{0} - {1}", StartTime.ToShortTimeString(), Session.EndTime.ToShortTimeString())
		End Get
	End Property
	Public ReadOnly Property StartTime() As DateTime
		Get
			Return Session.StartTime
		End Get
	End Property
	Public ReadOnly Property Subject() As String
		Get
			Return Session.Subject
		End Get
	End Property
	Public ReadOnly Property Location() As String
		Get
			Return Session.Location.ToString()
		End Get
	End Property
	Public ReadOnly Property Important() As Integer
		Get
			Return Session.Interest
		End Get
	End Property
	Public Sub New(ByVal curSession As Session)
		Session = curSession
	End Sub
End Class
