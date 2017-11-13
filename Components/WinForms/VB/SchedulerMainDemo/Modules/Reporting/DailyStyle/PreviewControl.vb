Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Protected WithEvents chkPrintAllAppointments As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents cbTimeScale As DevExpress.XtraScheduler.UI.DurationEdit
		Protected steToTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit
		Protected steFromTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit
		Protected edtEnd As DevExpress.XtraEditors.DateEdit
		Protected edtStart As DevExpress.XtraEditors.DateEdit
		Private spinResourceCount As DevExpress.XtraEditors.SpinEdit

		Private visibleResourceCount As Integer = 0
		Private visibleDayCount As Integer = 1
		Private printAllAppointments As Boolean = False
		Private timeScale As TimeSpan = TimeSpan.Zero
		Private printInterval As TimeInterval = TimeInterval.Empty
		Private spinDayCount As DevExpress.XtraEditors.SpinEdit
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private layoutControlItem9 As XtraLayout.LayoutControlItem
		Private visibleTime As TimeOfDayInterval = TimeOfDayInterval.Day

		'SchedulerGroupType groupType = SchedulerGroupType.None;

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property
		Private Property EndDate() As DateTime
			Get
				Return edtEnd.DateTime.AddDays(1)
			End Get
			Set(ByVal value As DateTime)
				edtEnd.DateTime = value.AddDays(-1)
			End Set
		End Property
		Private Property StartDate() As DateTime
			Get
				Return edtStart.DateTime
			End Get
			Set(ByVal value As DateTime)
				edtStart.DateTime = value
			End Set
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
			SubscribeEvents()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Private Sub InitializeControlValues()
			Me.visibleResourceCount = Report.VisibleResourceCount
			Me.spinResourceCount.EditValue = visibleResourceCount
			Me.spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount

			Me.visibleDayCount = Report.VisibleDayCount
			Me.spinDayCount.EditValue = Me.visibleDayCount
			Me.spinDayCount.Properties.MinValue = 1
			Me.spinDayCount.Properties.MaxValue = 7

			visibleTime = Report.VisibleTime
			steFromTime.Time = New DateTime(visibleTime.Start.Ticks)
			steToTime.Time = New DateTime(visibleTime.End.Ticks)

			printInterval = New TimeInterval(BaseDate, BaseDate.AddDays(6))
			StartDate = printInterval.Start
			EndDate = printInterval.End

			timeScale = Report.TimeScale
			cbTimeScale.EditValue = timeScale

			printAllAppointments = Report.PrintAllAppointments
			chkPrintAllAppointments.Checked = printAllAppointments

		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			StoragePrintAdapter.TimeInterval = printInterval
			MyBase.UpdateReportProperties(otherReport)

			Report.VisibleResourceCount = Me.visibleResourceCount
			Report.VisibleTime = Me.visibleTime
			Report.TimeScale = Me.timeScale
			Report.VisibleDayCount = Me.visibleDayCount

			Report.PrintAllAppointments = printAllAppointments
		End Sub
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.chkPrintAllAppointments = New DevExpress.XtraEditors.CheckEdit()
			Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.edtStart = New DevExpress.XtraEditors.DateEdit()
			Me.cbTimeScale = New DevExpress.XtraScheduler.UI.DurationEdit()
			Me.steToTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
			Me.steFromTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.spinDayCount = New DevExpress.XtraEditors.SpinEdit()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPaneSettings.SuspendLayout()
			Me.navigationPageSettings.SuspendLayout()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlSettings.SuspendLayout()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkPrintAllAppointments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.steToTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.steFromTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinDayCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Size = New System.Drawing.Size(484, 396)
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(172, 22)
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(484, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(216, 396)
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.Size = New System.Drawing.Size(216, 396)
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(186, 352)
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			Me.layoutControlSettings.Controls.Add(Me.steToTime)
			Me.layoutControlSettings.Controls.Add(Me.chkPrintAllAppointments)
			Me.layoutControlSettings.Controls.Add(Me.steFromTime)
			Me.layoutControlSettings.Controls.Add(Me.cbTimeScale)
			Me.layoutControlSettings.Controls.Add(Me.spinDayCount)
			Me.layoutControlSettings.Controls.Add(Me.edtEnd)
			Me.layoutControlSettings.Controls.Add(Me.spinResourceCount)
			Me.layoutControlSettings.Controls.Add(Me.edtStart)
			Me.layoutControlSettings.Size = New System.Drawing.Size(186, 352)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.edtStart, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.edtEnd, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinDayCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cbTimeScale, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.steFromTime, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkPrintAllAppointments, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.steToTime, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Name = "layoutControlGroup1"
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9})
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(186, 352)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(176, 26)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(176, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)

			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 227)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(176, 115)
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' chkPrintAllAppointments
			' 
			Me.chkPrintAllAppointments.Location = New System.Drawing.Point(7, 211)
			Me.chkPrintAllAppointments.Name = "chkPrintAllAppointments"
			Me.chkPrintAllAppointments.Properties.AccessibleName = "Print all appointments"
			Me.chkPrintAllAppointments.Properties.AutoWidth = True
			Me.chkPrintAllAppointments.Properties.Caption = "Print All Appointments"
			Me.chkPrintAllAppointments.Size = New System.Drawing.Size(127, 19)
			Me.chkPrintAllAppointments.StyleController = Me.layoutControlSettings
			Me.chkPrintAllAppointments.TabIndex = 8
'			Me.chkPrintAllAppointments.CheckedChanged += New System.EventHandler(Me.chkPrintAllAppointments_CheckedChanged);
			' 
			' edtEnd
			' 
			Me.edtEnd.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtEnd.Location = New System.Drawing.Point(92, 139)
			Me.edtEnd.Name = "edtEnd"
			Me.edtEnd.Properties.AccessibleName = "End date:"
			Me.edtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtEnd.Size = New System.Drawing.Size(87, 20)
			Me.edtEnd.StyleController = Me.layoutControlSettings
			Me.edtEnd.TabIndex = 16
			' 
			' edtStart
			' 
			Me.edtStart.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtStart.Location = New System.Drawing.Point(92, 115)
			Me.edtStart.Name = "edtStart"
			Me.edtStart.Properties.AccessibleName = "Start date:"
			Me.edtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtStart.Size = New System.Drawing.Size(87, 20)
			Me.edtStart.StyleController = Me.layoutControlSettings
			Me.edtStart.TabIndex = 15
			' 
			' cbTimeScale
			' 
			Me.cbTimeScale.EditValue = ""
			Me.cbTimeScale.Location = New System.Drawing.Point(92, 91)
			Me.cbTimeScale.Name = "cbTimeScale"
			Me.cbTimeScale.Properties.AccessibleName = "Duration:"
			Me.cbTimeScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbTimeScale.Properties.DisabledStateText = Nothing
			Me.cbTimeScale.Properties.Items.AddRange(New Object() { System.TimeSpan.Parse("00:05:00"), System.TimeSpan.Parse("00:10:00"), System.TimeSpan.Parse("00:15:00"), System.TimeSpan.Parse("00:30:00"), System.TimeSpan.Parse("01:00:00"), System.TimeSpan.Parse("02:00:00"), System.TimeSpan.Parse("03:00:00"), System.TimeSpan.Parse("04:00:00"), System.TimeSpan.Parse("05:00:00"), System.TimeSpan.Parse("06:00:00"), System.TimeSpan.Parse("07:00:00"), System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("09:00:00"), System.TimeSpan.Parse("10:00:00"), System.TimeSpan.Parse("11:00:00"), System.TimeSpan.Parse("12:00:00")})
			Me.cbTimeScale.Properties.ShowEmptyItem = False
			Me.cbTimeScale.Size = New System.Drawing.Size(87, 20)
			Me.cbTimeScale.StyleController = Me.layoutControlSettings
			Me.cbTimeScale.TabIndex = 22
'			Me.cbTimeScale.SelectedIndexChanged += New System.EventHandler(Me.cbDuration_SelectedIndexChanged);
			' 
			' steToTime
			' 
			Me.steToTime.EditValue = New System.DateTime(2005, 8, 24, 0, 0, 0, 0)
			Me.steToTime.Location = New System.Drawing.Point(92, 187)
			Me.steToTime.Name = "steToTime"
			Me.steToTime.Properties.AccessibleName = "Print to:"
			Me.steToTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.steToTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.steToTime.Size = New System.Drawing.Size(87, 20)
			Me.steToTime.StyleController = Me.layoutControlSettings
			Me.steToTime.TabIndex = 20
			' 
			' steFromTime
			' 
			Me.steFromTime.EditValue = New System.DateTime(2005, 8, 24, 0, 0, 0, 0)
			Me.steFromTime.Location = New System.Drawing.Point(92, 163)
			Me.steFromTime.Name = "steFromTime"
			Me.steFromTime.Properties.AccessibleName = "Print from:"
			Me.steFromTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.steFromTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.steFromTime.Size = New System.Drawing.Size(87, 20)
			Me.steFromTime.StyleController = Me.layoutControlSettings
			Me.steFromTime.TabIndex = 18
			' 
			' spinResourceCount
			' 
			Me.spinResourceCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Location = New System.Drawing.Point(92, 43)
			Me.spinResourceCount.Name = "spinResourceCount"
			Me.spinResourceCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinResourceCount.Properties.IsFloatValue = False
			Me.spinResourceCount.Properties.Mask.EditMask = "N00"
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(87, 20)
			Me.spinResourceCount.StyleController = Me.layoutControlSettings
			Me.spinResourceCount.TabIndex = 38
			' 
			' spinDayCount
			' 
			Me.spinDayCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinDayCount.Location = New System.Drawing.Point(92, 67)
			Me.spinDayCount.Name = "spinDayCount"
			Me.spinDayCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinDayCount.Properties.IsFloatValue = False
			Me.spinDayCount.Properties.Mask.EditMask = "N00"
			Me.spinDayCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinDayCount.Size = New System.Drawing.Size(87, 20)
			Me.spinDayCount.StyleController = Me.layoutControlSettings
			Me.spinDayCount.TabIndex = 38
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinResourceCount
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem2.Text = "Resource Count:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.spinDayCount
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 60)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem3.Text = "Day Count:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.cbTimeScale
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 84)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem4.Text = "Time S&cale:"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.edtStart
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 108)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem5.Text = "Start Date:"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.edtEnd
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 132)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem6.Text = "End Date:"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.steFromTime
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 156)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem7.Text = "Print From:"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.steToTime
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 180)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(176, 24)
			Me.layoutControlItem8.Text = "Print &To:"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.chkPrintAllAppointments
			Me.layoutControlItem9.Location = New System.Drawing.Point(0, 204)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(176, 23)
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem9.TextVisible = False
			' 
			' PreviewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "PreviewControl"
			Me.Controls.Add(Me.navigationPaneSettings)
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPaneSettings.ResumeLayout(False)
			Me.navigationPageSettings.ResumeLayout(False)
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlSettings.ResumeLayout(False)
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkPrintAllAppointments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.steToTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.steFromTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinDayCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			Dim designForm As New CustomDesignForm()
			Dim report As XtraSchedulerReport = GetActiveReport()
			If report Is Nothing Then
				Return
			End If

			designForm.OpenReport(report)
			PreventUpdate = True
			Try
				ShowDesignerForm(designForm, Me.FindForm())
			Finally
				PreventUpdate = False
			End Try
			designForm.Dispose()

			CreateReports()
			UpdateActiveReport()
		End Sub

		Protected Friend Overridable Sub UnsubscribeEvents()
			RemoveHandler spinDayCount.EditValueChanged, AddressOf spinDayCount_EditValueChanged
			RemoveHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
			RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			RemoveHandler steFromTime.EditValueChanged, AddressOf steFromTime_EditValueChanged
			RemoveHandler steToTime.EditValueChanged, AddressOf steToTime_EditValueChanged
		End Sub

		Protected Friend Overridable Sub SubscribeEvents()
			AddHandler spinDayCount.EditValueChanged, AddressOf spinDayCount_EditValueChanged
			AddHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
			AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			AddHandler steFromTime.EditValueChanged, AddressOf steFromTime_EditValueChanged
			AddHandler steToTime.EditValueChanged, AddressOf steToTime_EditValueChanged
		End Sub

		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue)
			UpdateActiveReport()
		End Sub
		Private Sub spinDayCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.visibleDayCount = Convert.ToInt32(spinDayCount.EditValue)
			UpdateActiveReport()
		End Sub
		Private Sub cbDuration_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeScale.SelectedIndexChanged
			Me.timeScale = cbTimeScale.Duration
			UpdateActiveReport()
		End Sub
		Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtEnd.EditValue = StartDate
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub
		Protected Friend Overridable Function IsValidInterval(ByVal start As DateTime, ByVal [end] As DateTime) As Boolean
			Return start <= [end]
		End Function
		Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtStart.EditValue = EndDate.AddDays(-1)
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub

		Private Sub steFromTime_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateVisibleTime()
		End Sub
		Private Sub steToTime_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateVisibleTime()
		End Sub
		Protected Friend Overridable Sub UpdateVisibleTime()
			'Debug.Assert(edtStart.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
			'Debug.Assert(edtEnd.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
			Dim start As TimeSpan = steFromTime.Time.TimeOfDay
			Dim [end] As TimeSpan = steToTime.Time.TimeOfDay
			Dim duration As TimeSpan = [end].Subtract(start)
			If duration.Ticks <= 0 Then
				[end] = [end] + DateTimeHelper.DaySpan
			End If

			Me.visibleTime = New TimeOfDayInterval(start, [end])
			UpdateActiveReport()
		End Sub

		Private Sub chkPrintAllAppointments_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPrintAllAppointments.CheckedChanged
			printAllAppointments = chkPrintAllAppointments.Checked
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

