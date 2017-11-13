Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services.Implementation
Imports System.Globalization

Namespace DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cmbVertAptEnd As ComboBoxEdit
		Private WithEvents cmbVertAptStart As ComboBoxEdit
		Private WithEvents cmbHorzAptEnd As ComboBoxEdit
		Private WithEvents cmbHorzAptStart As ComboBoxEdit
		Private WithEvents cmbHeaderCaptions As ComboBoxEdit
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem


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
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(21))
		End Sub
		Private Sub InitializeControlValues()
			PopulateFormatCombo(cmbHorzAptStart)
			PopulateFormatCombo(cmbHorzAptEnd)
			PopulateFormatCombo(cmbVertAptStart)
			PopulateFormatCombo(cmbVertAptEnd)

			PopulateFormatCombo(cmbHeaderCaptions)

		End Sub
		Private Sub PopulateFormatCombo(ByVal comboBox As ComboBoxEdit)
			comboBox.Properties.Items.Clear()
			comboBox.Properties.Items.Add("Default")
			comboBox.Properties.Items.AddRange(DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns())
			comboBox.SelectedIndex = 0
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			UpdateFormatServices()
		End Sub
		Public Sub UpdateFormatServices()
			StoragePrintAdapter.RemoveService(GetType(IHeaderCaptionService))
			Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService(cmbHeaderCaptions.Text)
			StoragePrintAdapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)

			StoragePrintAdapter.RemoveService(GetType(IAppointmentFormatStringService))
			Dim customAptFormatService As New CustomAppointmentFormatStringService()
			customAptFormatService.HorizontalAppointmentStart = cmbHorzAptStart.Text
			customAptFormatService.HorizontalAppointmentEnd = cmbHorzAptEnd.Text
			customAptFormatService.VerticalAppointmentStart = cmbVertAptStart.Text
			customAptFormatService.VerticalAppointmentEnd = cmbVertAptEnd.Text
			StoragePrintAdapter.AddService(GetType(IAppointmentFormatStringService), customAptFormatService)
		End Sub


		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.cmbHorzAptEnd = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbHorzAptStart = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbVertAptEnd = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbVertAptStart = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbHeaderCaptions = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
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
			CType(Me.cmbHorzAptEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbHorzAptStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbVertAptEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbVertAptStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbHeaderCaptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Size = New System.Drawing.Size(416, 396)
			' 
			' btnEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Size = New System.Drawing.Size(240, 22)
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(416, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(284, 396)
			Me.navigationPaneSettings.Size = New System.Drawing.Size(284, 396)
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(254, 352)
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
			Me.layoutControlSettings.Controls.Add(Me.cmbHeaderCaptions)
			Me.layoutControlSettings.Controls.Add(Me.cmbHorzAptEnd)
			Me.layoutControlSettings.Controls.Add(Me.cmbVertAptEnd)
			Me.layoutControlSettings.Controls.Add(Me.cmbVertAptStart)
			Me.layoutControlSettings.Controls.Add(Me.cmbHorzAptStart)
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
			Me.layoutControlSettings.Size = New System.Drawing.Size(254, 352)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbHorzAptStart, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbVertAptStart, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbVertAptEnd, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbHorzAptEnd, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbHeaderCaptions, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup1, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.emptySpaceItem3, Me.emptySpaceItem4})
			Me.layoutControlGroupSettings.Name = "Root"
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(254, 352)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			Me.layoutControlItem1.Size = New System.Drawing.Size(244, 26)
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
			Me.emptySpaceItem1.Size = New System.Drawing.Size(244, 10)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 266)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(244, 76)
			' 
			' cmbHorzAptEnd
			' 
			Me.cmbHorzAptEnd.Location = New System.Drawing.Point(108, 91)
			Me.cmbHorzAptEnd.Name = "cmbHorzAptEnd"
			Me.cmbHorzAptEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.cmbHorzAptEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbHorzAptEnd.Size = New System.Drawing.Size(133, 20)
			Me.cmbHorzAptEnd.StyleController = Me.layoutControlSettings
			Me.cmbHorzAptEnd.TabIndex = 53
'			Me.cmbHorzAptEnd.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' cmbHorzAptStart
			' 
			Me.cmbHorzAptStart.Location = New System.Drawing.Point(108, 67)
			Me.cmbHorzAptStart.Name = "cmbHorzAptStart"
			Me.cmbHorzAptStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", Nothing, Nothing, True)})
			Me.cmbHorzAptStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbHorzAptStart.Size = New System.Drawing.Size(133, 20)
			Me.cmbHorzAptStart.StyleController = Me.layoutControlSettings
			Me.cmbHorzAptStart.TabIndex = 51
'			Me.cmbHorzAptStart.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' cmbVertAptEnd
			' 
			Me.cmbVertAptEnd.Location = New System.Drawing.Point(108, 179)
			Me.cmbVertAptEnd.Name = "cmbVertAptEnd"
			Me.cmbVertAptEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
			Me.cmbVertAptEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbVertAptEnd.Size = New System.Drawing.Size(133, 20)
			Me.cmbVertAptEnd.StyleController = Me.layoutControlSettings
			Me.cmbVertAptEnd.TabIndex = 53
'			Me.cmbVertAptEnd.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' cmbVertAptStart
			' 
			Me.cmbVertAptStart.Location = New System.Drawing.Point(108, 155)
			Me.cmbVertAptStart.Name = "cmbVertAptStart"
			Me.cmbVertAptStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
			Me.cmbVertAptStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbVertAptStart.Size = New System.Drawing.Size(133, 20)
			Me.cmbVertAptStart.StyleController = Me.layoutControlSettings
			Me.cmbVertAptStart.TabIndex = 51
'			Me.cmbVertAptStart.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' cmbHeaderCaptions
			' 
			Me.cmbHeaderCaptions.Location = New System.Drawing.Point(108, 243)
			Me.cmbHeaderCaptions.Name = "cmbHeaderCaptions"
			Me.cmbHeaderCaptions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.cmbHeaderCaptions.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbHeaderCaptions.Size = New System.Drawing.Size(133, 20)
			Me.cmbHeaderCaptions.StyleController = Me.layoutControlSettings
			Me.cmbHeaderCaptions.TabIndex = 53
'			Me.cmbHeaderCaptions.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.cmbHorzAptStart
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(232, 24)
			Me.layoutControlItem6.Text = "Start Date Format:"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.cmbHorzAptEnd
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(232, 24)
			Me.layoutControlItem5.Text = "End Date Format:"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(91, 13)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem6, Me.layoutControlItem5})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(244, 78)
			Me.layoutControlGroup1.Text = "Horizontal Appointment"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.cmbVertAptStart
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(232, 24)
			Me.layoutControlItem2.Text = "Start Date Format:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(91, 13)
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.cmbVertAptEnd
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(232, 24)
			Me.layoutControlItem7.Text = "End Date Format:"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(91, 13)
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem7})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 124)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(244, 78)
			Me.layoutControlGroup2.Text = "Vertical Appointment"
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.cmbHeaderCaptions
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(232, 24)
			Me.layoutControlItem3.Text = "Format:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 212)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup3.Size = New System.Drawing.Size(244, 54)
			Me.layoutControlGroup3.Text = "Day Headers"
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 114)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(244, 10)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem4
			' 
			Me.emptySpaceItem4.AllowHotTrack = False
			Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 202)
			Me.emptySpaceItem4.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem4.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem4.Name = "emptySpaceItem4"
			Me.emptySpaceItem4.Size = New System.Drawing.Size(244, 10)
			Me.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
			' 
			' PreviewControl
			' 
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
			CType(Me.cmbHorzAptEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbHorzAptStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbVertAptEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbVertAptStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbHeaderCaptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub cmbHorzAptStart_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbHorzAptEnd.SelectedIndexChanged, cmbHorzAptStart.SelectedIndexChanged, cmbVertAptEnd.SelectedIndexChanged, cmbVertAptStart.SelectedIndexChanged, cmbHeaderCaptions.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

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

	End Class

   Public Class CustomHeaderCaptionService
	   Inherits HeaderCaptionServiceWrapper
	   Private format As String
		Public Sub New(ByVal format As String)
			MyBase.New(New HeaderCaptionService())
			Me.format = format
		End Sub
	   Protected Overridable Function CreateFormat(ByVal format As String) As String
		   If format = "Default" Then
			   Return String.Empty
		   End If
		   Return String.Format("{{0:{0}}}", format)
	   End Function
	   Public Overrides Function GetDayColumnHeaderCaption(ByVal header As DayHeader) As String
			Return CreateFormat(format)
	   End Function
   End Class
	Public Class CustomAppointmentFormatStringService
		Inherits AppointmentFormatStringServiceWrapper
		Private horizontalAppointmentStart_Renamed As String
		Private horizontalAppointmentEnd_Renamed As String
		Private verticalAppointmentStart_Renamed As String
		Private verticalAppointmentEnd_Renamed As String

		Public Sub New()
			MyBase.New(New AppointmentFormatStringService())
		End Sub
		Public Property HorizontalAppointmentStart() As String
			Get
				Return horizontalAppointmentStart_Renamed
			End Get
			Set(ByVal value As String)
				horizontalAppointmentStart_Renamed = value
			End Set
		End Property
		Public Property HorizontalAppointmentEnd() As String
			Get
				Return horizontalAppointmentEnd_Renamed
			End Get
			Set(ByVal value As String)
				horizontalAppointmentEnd_Renamed = value
			End Set
		End Property
		Public Property VerticalAppointmentStart() As String
			Get
				Return verticalAppointmentStart_Renamed
			End Get
			Set(ByVal value As String)
				verticalAppointmentStart_Renamed = value
			End Set
		End Property
		Public Property VerticalAppointmentEnd() As String
			Get
				Return verticalAppointmentEnd_Renamed
			End Get
			Set(ByVal value As String)
				verticalAppointmentEnd_Renamed = value
			End Set
		End Property

		Protected Overridable Function CreateFormat(ByVal format As String) As String
			If format = "Default" Then
				Return String.Empty
			End If
			Return String.Format("{{0:{0}}} ", format)
		End Function
		Public Overrides Function GetHorizontalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(horizontalAppointmentStart_Renamed)
		End Function
		Public Overrides Function GetHorizontalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(horizontalAppointmentEnd_Renamed)
		End Function
		Public Overrides Function GetVerticalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(verticalAppointmentStart_Renamed)
		End Function
		Public Overrides Function GetVerticalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(verticalAppointmentEnd_Renamed)
		End Function
		Public Overrides Function GetContinueItemStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return MyBase.GetContinueItemStartFormat(aptViewInfo)
		End Function
		Public Overrides Function GetContinueItemEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return MyBase.GetContinueItemEndFormat(aptViewInfo)
		End Function
	End Class
End Namespace

