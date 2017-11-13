Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing

		'bool showReminder;
		'bool showReccurence;

		Private allowInitAptText As Boolean
		Private allowInitAptImages As Boolean
		Private WithEvents chkAptImages As CheckEdit
		Private WithEvents chkAptText As CheckEdit
		Private WithEvents chkShowRecurrence As CheckEdit
		Private WithEvents cbStatus As ImageComboBoxEdit
		Private WithEvents cbTimeDisplayType As ImageComboBoxEdit
		Private WithEvents chkShowReminder As CheckEdit
		Private WithEvents chkStartTimeVisibility As CheckEdit
		Private WithEvents chkEndTimeVisibility As CheckEdit

		Private showStartTime As Boolean
		Private showEndTime As Boolean
		Private statusDisplayType As AppointmentStatusDisplayType
		Private timeDisplayType As AppointmentTimeDisplayType

		Private showBell As Boolean
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
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private layoutControlItem9 As XtraLayout.LayoutControlItem
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private showRecurrence As Boolean

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
		End Sub

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

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
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(7))
		End Sub
		Private Sub InitializeControlValues()
			allowInitAptText = chkAptText.Checked
			allowInitAptImages = chkAptImages.Checked

			cbTimeDisplayType.SelectedIndex = 0
			cbStatus.SelectedIndex = 0
			showStartTime = chkStartTimeVisibility.Checked
			showEndTime = chkEndTimeVisibility.Checked
			showRecurrence = chkShowRecurrence.Checked
			showBell = chkShowReminder.Checked
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			Report.AllowInitAppointmentText = allowInitAptText
			Report.AllowInitAppointmentImages = allowInitAptImages

			Report.ShowStartTime = showStartTime
			Report.ShowEndTime = showEndTime
			Report.StatusDisplayType = statusDisplayType
			Report.TimeDisplayType = timeDisplayType
			Report.ShowBell = showBell
			Report.ShowRecurrence = showRecurrence
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.chkAptImages = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAptText = New DevExpress.XtraEditors.CheckEdit()
			Me.chkShowRecurrence = New DevExpress.XtraEditors.CheckEdit()
			Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.cbTimeDisplayType = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.chkShowReminder = New DevExpress.XtraEditors.CheckEdit()
			Me.chkStartTimeVisibility = New DevExpress.XtraEditors.CheckEdit()
			Me.chkEndTimeVisibility = New DevExpress.XtraEditors.CheckEdit()
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
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
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
			CType(Me.chkAptImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAptText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 27)
			Me.printControl.Size = New System.Drawing.Size(487, 384)
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			Me.btnEdit.Size = New System.Drawing.Size(169, 22)
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(487, 27)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(213, 384)
			Me.navigationPaneSettings.Size = New System.Drawing.Size(213, 384)
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(183, 340)
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
			Me.layoutControlSettings.Controls.Add(Me.chkAptImages)
			Me.layoutControlSettings.Controls.Add(Me.chkAptText)
			Me.layoutControlSettings.Controls.Add(Me.chkShowRecurrence)
			Me.layoutControlSettings.Controls.Add(Me.chkShowReminder)
			Me.layoutControlSettings.Controls.Add(Me.cbStatus)
			Me.layoutControlSettings.Controls.Add(Me.cbTimeDisplayType)
			Me.layoutControlSettings.Controls.Add(Me.chkEndTimeVisibility)
			Me.layoutControlSettings.Controls.Add(Me.chkStartTimeVisibility)
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
			Me.layoutControlSettings.Size = New System.Drawing.Size(183, 340)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkStartTimeVisibility, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkEndTimeVisibility, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cbTimeDisplayType, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cbStatus, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkShowReminder, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkShowRecurrence, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkAptText, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkAptImages, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup1, Me.emptySpaceItem3})
			Me.layoutControlGroupSettings.Name = "Root"
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(183, 340)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			Me.layoutControlItem1.Size = New System.Drawing.Size(173, 26)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem1.Size = New System.Drawing.Size(173, 10)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 292)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(173, 38)
			' 
			' chkAptImages
			' 
			Me.chkAptImages.EditValue = True
			Me.chkAptImages.Location = New System.Drawing.Point(13, 270)
			Me.chkAptImages.Name = "chkAptImages"
			Me.chkAptImages.Properties.Caption = "Custom Images"
			Me.chkAptImages.Size = New System.Drawing.Size(157, 19)
			Me.chkAptImages.StyleController = Me.layoutControlSettings
			Me.chkAptImages.TabIndex = 49
'			Me.chkAptImages.CheckedChanged += New System.EventHandler(Me.chkAptImages_CheckedChanged);
			' 
			' chkAptText
			' 
			Me.chkAptText.EditValue = True
			Me.chkAptText.Location = New System.Drawing.Point(13, 247)
			Me.chkAptText.Name = "chkAptText"
			Me.chkAptText.Properties.Caption = "Custom Text"
			Me.chkAptText.Size = New System.Drawing.Size(157, 19)
			Me.chkAptText.StyleController = Me.layoutControlSettings
			Me.chkAptText.TabIndex = 48
'			Me.chkAptText.CheckedChanged += New System.EventHandler(Me.chkAptText_CheckedChanged);
			' 
			' chkShowRecurrence
			' 
			Me.chkShowRecurrence.EditValue = True
			Me.chkShowRecurrence.Location = New System.Drawing.Point(13, 161)
			Me.chkShowRecurrence.Name = "chkShowRecurrence"
			Me.chkShowRecurrence.Properties.Caption = "Recurrence"
			Me.chkShowRecurrence.Size = New System.Drawing.Size(157, 19)
			Me.chkShowRecurrence.StyleController = Me.layoutControlSettings
			Me.chkShowRecurrence.TabIndex = 74
'			Me.chkShowRecurrence.CheckedChanged += New System.EventHandler(Me.chkShowRecurrence_CheckedChanged);
			' 
			' cbStatus
			' 
			Me.cbStatus.EditValue = ""
			Me.cbStatus.Location = New System.Drawing.Point(52, 67)
			Me.cbStatus.Name = "cbStatus"
			Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
			Me.cbStatus.Size = New System.Drawing.Size(118, 20)
			Me.cbStatus.StyleController = Me.layoutControlSettings
			Me.cbStatus.TabIndex = 73
'			Me.cbStatus.SelectedIndexChanged += New System.EventHandler(Me.cbStatus_SelectedIndexChanged);
			' 
			' cbTimeDisplayType
			' 
			Me.cbTimeDisplayType.EditValue = ""
			Me.cbTimeDisplayType.Location = New System.Drawing.Point(52, 91)
			Me.cbTimeDisplayType.Name = "cbTimeDisplayType"
			Me.cbTimeDisplayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbTimeDisplayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)})
			Me.cbTimeDisplayType.Size = New System.Drawing.Size(118, 20)
			Me.cbTimeDisplayType.StyleController = Me.layoutControlSettings
			Me.cbTimeDisplayType.TabIndex = 22
'			Me.cbTimeDisplayType.SelectedIndexChanged += New System.EventHandler(Me.cbTimeDisplayType_SelectedIndexChanged);
			' 
			' chkShowReminder
			' 
			Me.chkShowReminder.EditValue = True
			Me.chkShowReminder.Location = New System.Drawing.Point(13, 184)
			Me.chkShowReminder.Name = "chkShowReminder"
			Me.chkShowReminder.Properties.Caption = "Reminder"
			Me.chkShowReminder.Size = New System.Drawing.Size(157, 19)
			Me.chkShowReminder.StyleController = Me.layoutControlSettings
			Me.chkShowReminder.TabIndex = 13
'			Me.chkShowReminder.CheckedChanged += New System.EventHandler(Me.chkShowReminder_CheckedChanged);
			' 
			' chkStartTimeVisibility
			' 
			Me.chkStartTimeVisibility.EditValue = True
			Me.chkStartTimeVisibility.Location = New System.Drawing.Point(13, 115)
			Me.chkStartTimeVisibility.Name = "chkStartTimeVisibility"
			Me.chkStartTimeVisibility.Properties.Caption = "Start Time"
			Me.chkStartTimeVisibility.Size = New System.Drawing.Size(157, 19)
			Me.chkStartTimeVisibility.StyleController = Me.layoutControlSettings
			Me.chkStartTimeVisibility.TabIndex = 11
'			Me.chkStartTimeVisibility.CheckedChanged += New System.EventHandler(Me.chkStartTimeVisibility_CheckedChanged);
			' 
			' chkEndTimeVisibility
			' 
			Me.chkEndTimeVisibility.EditValue = True
			Me.chkEndTimeVisibility.Location = New System.Drawing.Point(13, 138)
			Me.chkEndTimeVisibility.Name = "chkEndTimeVisibility"
			Me.chkEndTimeVisibility.Properties.Caption = "End Time"
			Me.chkEndTimeVisibility.Size = New System.Drawing.Size(157, 19)
			Me.chkEndTimeVisibility.StyleController = Me.layoutControlSettings
			Me.chkEndTimeVisibility.TabIndex = 10
'			Me.chkEndTimeVisibility.CheckedChanged += New System.EventHandler(Me.chkEndTimeVisibility_CheckedChanged);
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.cbStatus
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(161, 24)
			Me.layoutControlItem2.Text = "Status:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(35, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.cbTimeDisplayType
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(161, 24)
			Me.layoutControlItem3.Text = "Time:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.chkStartTimeVisibility
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(161, 23)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.chkEndTimeVisibility
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 71)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(161, 23)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.chkShowRecurrence
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 94)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(161, 23)
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextVisible = False
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.chkShowReminder
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 117)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(161, 23)
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextVisible = False
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem2, Me.layoutControlItem3})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(173, 170)
			Me.layoutControlGroup1.Text = "Appointment Display Options"
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.chkAptText
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(161, 23)
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextVisible = False
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.chkAptImages
			Me.layoutControlItem9.Location = New System.Drawing.Point(0, 23)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(161, 23)
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem9.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem8, Me.layoutControlItem9})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 216)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(173, 76)
			Me.layoutControlGroup2.Text = "Customization"
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 206)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(173, 10)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' PreviewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "PreviewControl"
			Me.Size = New System.Drawing.Size(700, 411)
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
			CType(Me.chkAptImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAptText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub chkAptText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAptText.CheckedChanged
			allowInitAptText = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkAptImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAptImages.CheckedChanged
			allowInitAptImages = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkStartTimeVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkStartTimeVisibility.CheckedChanged
			showStartTime = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkEndTimeVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEndTimeVisibility.CheckedChanged
			showEndTime = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()

		End Sub

		Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.SelectedIndexChanged
			statusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
			UpdateActiveReport()
		End Sub

		Private Sub cbTimeDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeDisplayType.SelectedIndexChanged
			timeDisplayType = CType(cbTimeDisplayType.EditValue, AppointmentTimeDisplayType)
			UpdateActiveReport()
		End Sub

		Private Sub chkShowRecurrence_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowRecurrence.CheckedChanged
			showRecurrence = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkShowReminder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowReminder.CheckedChanged
			showBell = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

