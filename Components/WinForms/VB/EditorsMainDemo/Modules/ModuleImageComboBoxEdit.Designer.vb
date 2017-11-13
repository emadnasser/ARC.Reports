Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleImageComboBoxEdit
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleImageComboBoxEdit))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceLargeImages = New DevExpress.XtraEditors.CheckEdit()
			Me.icbAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.icbHighlightedItemStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ceCTRLScroll = New DevExpress.XtraEditors.CheckEdit()
			Me.icbShowDropDown = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
			Me.ceImmediatePopup = New DevExpress.XtraEditors.CheckEdit()
			Me.ceHotTrackItems = New DevExpress.XtraEditors.CheckEdit()
			Me.ceCycleOnDblClick = New DevExpress.XtraEditors.CheckEdit()
			Me.ceAutoComplete = New DevExpress.XtraEditors.CheckEdit()
			Me.seDropDownRows = New DevExpress.XtraEditors.SpinEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.imageComboBoxEditSample = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imcSmall = New DevExpress.Utils.ImageCollection(Me.components)
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
			Me.teImageComboBoxEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.teImageComboBoxEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.teImageComboBoxEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.imageComboBoxEdit3 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imcLarge = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceLargeImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.icbHighlightedItemStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceCTRLScroll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbShowDropDown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceImmediatePopup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceHotTrackItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceCycleOnDblClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAutoComplete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seDropDownRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.imageComboBoxEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imcSmall, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl4.SuspendLayout()
			CType(Me.teImageComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teImageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teImageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.imageComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imcLarge, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(829, 587)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(823, 559)
			Me.xtraTabPage1.Text = "General"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.ceLargeImages)
			Me.groupControl2.Controls.Add(Me.icbAlignment)
			Me.groupControl2.Controls.Add(Me.label1)
			Me.groupControl2.Location = New System.Drawing.Point(310, 336)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(291, 96)
			Me.groupControl2.TabIndex = 4
			Me.groupControl2.Text = "Image properties"
			' 
			' ceLargeImages
			' 
			Me.ceLargeImages.Location = New System.Drawing.Point(18, 58)
			Me.ceLargeImages.Name = "ceLargeImages"
			Me.ceLargeImages.Properties.Caption = "Use large images"
			Me.ceLargeImages.Size = New System.Drawing.Size(168, 19)
			Me.ceLargeImages.TabIndex = 28
'			Me.ceLargeImages.CheckedChanged += New System.EventHandler(Me.ceLargeImages_CheckedChanged)
			' 
			' icbAlignment
			' 
			Me.icbAlignment.EditValue = "imageComboBoxEdit1"
			Me.icbAlignment.Location = New System.Drawing.Point(143, 32)
			Me.icbAlignment.Name = "icbAlignment"
			Me.icbAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbAlignment.Size = New System.Drawing.Size(127, 20)
			Me.icbAlignment.TabIndex = 26
'			Me.icbAlignment.SelectedIndexChanged += New System.EventHandler(Me.icbAlignment_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 35)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(80, 13)
			Me.label1.TabIndex = 27
			Me.label1.Text = "Glyph alignment:"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.icbHighlightedItemStyle)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.ceCTRLScroll)
			Me.groupControl1.Controls.Add(Me.icbShowDropDown)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.cePopupSizeable)
			Me.groupControl1.Controls.Add(Me.ceImmediatePopup)
			Me.groupControl1.Controls.Add(Me.ceHotTrackItems)
			Me.groupControl1.Controls.Add(Me.ceCycleOnDblClick)
			Me.groupControl1.Controls.Add(Me.ceAutoComplete)
			Me.groupControl1.Controls.Add(Me.seDropDownRows)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Location = New System.Drawing.Point(310, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(291, 285)
			Me.groupControl1.TabIndex = 3
			Me.groupControl1.Text = "ComboBox properties"
			' 
			' icbHighlightedItemStyle
			' 
			Me.icbHighlightedItemStyle.EditValue = "imageComboBoxEdit1"
			Me.icbHighlightedItemStyle.Location = New System.Drawing.Point(143, 61)
			Me.icbHighlightedItemStyle.Name = "icbHighlightedItemStyle"
			Me.icbHighlightedItemStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbHighlightedItemStyle.Size = New System.Drawing.Size(127, 20)
			Me.icbHighlightedItemStyle.TabIndex = 1
'			Me.icbHighlightedItemStyle.SelectedIndexChanged += New System.EventHandler(Me.icbHighlightedItemStyle_SelectedIndexChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 64)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(106, 13)
			Me.labelControl1.TabIndex = 29
			Me.labelControl1.Text = "Highlighted item style:"
			' 
			' ceCTRLScroll
			' 
			Me.ceCTRLScroll.Location = New System.Drawing.Point(18, 244)
			Me.ceCTRLScroll.Name = "ceCTRLScroll"
			Me.ceCTRLScroll.Properties.Caption = "Use CTRL scroll"
			Me.ceCTRLScroll.Size = New System.Drawing.Size(168, 19)
			Me.ceCTRLScroll.TabIndex = 8
'			Me.ceCTRLScroll.CheckedChanged += New System.EventHandler(Me.ceCTRLScroll_CheckedChanged)
			' 
			' icbShowDropDown
			' 
			Me.icbShowDropDown.EditValue = "imageComboBoxEdit1"
			Me.icbShowDropDown.Location = New System.Drawing.Point(143, 32)
			Me.icbShowDropDown.Name = "icbShowDropDown"
			Me.icbShowDropDown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbShowDropDown.Size = New System.Drawing.Size(128, 20)
			Me.icbShowDropDown.TabIndex = 0
'			Me.icbShowDropDown.SelectedIndexChanged += New System.EventHandler(Me.icbShowDropDown_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 35)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(81, 13)
			Me.label3.TabIndex = 25
			Me.label3.Text = "Show dropdown:"
			' 
			' cePopupSizeable
			' 
			Me.cePopupSizeable.Location = New System.Drawing.Point(18, 219)
			Me.cePopupSizeable.Name = "cePopupSizeable"
			Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
			Me.cePopupSizeable.Size = New System.Drawing.Size(168, 19)
			Me.cePopupSizeable.TabIndex = 7
'			Me.cePopupSizeable.CheckedChanged += New System.EventHandler(Me.cePopupSizeable_CheckedChanged)
			' 
			' ceImmediatePopup
			' 
			Me.ceImmediatePopup.Location = New System.Drawing.Point(18, 194)
			Me.ceImmediatePopup.Name = "ceImmediatePopup"
			Me.ceImmediatePopup.Properties.Caption = "Immediate popup"
			Me.ceImmediatePopup.Size = New System.Drawing.Size(168, 19)
			Me.ceImmediatePopup.TabIndex = 6
'			Me.ceImmediatePopup.CheckedChanged += New System.EventHandler(Me.ceImmediatePopup_CheckedChanged)
			' 
			' ceHotTrackItems
			' 
			Me.ceHotTrackItems.Location = New System.Drawing.Point(18, 169)
			Me.ceHotTrackItems.Name = "ceHotTrackItems"
			Me.ceHotTrackItems.Properties.Caption = "Hot-track items"
			Me.ceHotTrackItems.Size = New System.Drawing.Size(168, 19)
			Me.ceHotTrackItems.TabIndex = 5
'			Me.ceHotTrackItems.CheckedChanged += New System.EventHandler(Me.ceHotTrackItems_CheckedChanged)
			' 
			' ceCycleOnDblClick
			' 
			Me.ceCycleOnDblClick.Location = New System.Drawing.Point(18, 144)
			Me.ceCycleOnDblClick.Name = "ceCycleOnDblClick"
			Me.ceCycleOnDblClick.Properties.Caption = "Cycle on double click"
			Me.ceCycleOnDblClick.Size = New System.Drawing.Size(168, 19)
			Me.ceCycleOnDblClick.TabIndex = 4
'			Me.ceCycleOnDblClick.CheckedChanged += New System.EventHandler(Me.ceCycleOnDblClick_CheckedChanged)
			' 
			' ceAutoComplete
			' 
			Me.ceAutoComplete.Location = New System.Drawing.Point(18, 119)
			Me.ceAutoComplete.Name = "ceAutoComplete"
			Me.ceAutoComplete.Properties.Caption = "Auto-complete"
			Me.ceAutoComplete.Size = New System.Drawing.Size(168, 19)
			Me.ceAutoComplete.TabIndex = 3
'			Me.ceAutoComplete.CheckedChanged += New System.EventHandler(Me.ceAutoComplete_CheckedChanged)
			' 
			' seDropDownRows
			' 
			Me.seDropDownRows.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seDropDownRows.Location = New System.Drawing.Point(143, 90)
			Me.seDropDownRows.Name = "seDropDownRows"
			Me.seDropDownRows.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seDropDownRows.Properties.IsFloatValue = False
			Me.seDropDownRows.Properties.Mask.EditMask = "N00"
			Me.seDropDownRows.Properties.MaxValue = New Decimal(New Integer() { 25, 0, 0, 0})
			Me.seDropDownRows.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seDropDownRows.Size = New System.Drawing.Size(108, 20)
			Me.seDropDownRows.TabIndex = 2
'			Me.seDropDownRows.EditValueChanged += New System.EventHandler(Me.seDropDownRows_EditValueChanged)
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 93)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(79, 13)
			Me.label2.TabIndex = 16
			Me.label2.Text = "Dropdown rows:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.imageComboBoxEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(249, 402)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' imageComboBoxEditSample
			' 
			Me.imageComboBoxEditSample.EditValue = "imageComboBoxEdit1"
			Me.imageComboBoxEditSample.Location = New System.Drawing.Point(22, 95)
			Me.imageComboBoxEditSample.Name = "imageComboBoxEditSample"
			Me.imageComboBoxEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEditSample.Properties.DropDownRows = 10
			Me.imageComboBoxEditSample.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Design", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mail", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pie", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Home", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tag", 5, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Contact", 6, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Database", 7, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", 8, 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Video", 9, 9)})
			Me.imageComboBoxEditSample.Properties.SmallImages = Me.imcSmall
			Me.imageComboBoxEditSample.Size = New System.Drawing.Size(201, 20)
			Me.imageComboBoxEditSample.TabIndex = 0
			' 
			' imcSmall
			' 
			Me.imcSmall.ImageStream = (CType(resources.GetObject("imcSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imcSmall.InsertGalleryImage("time_16x16.png", "images/scheduling/time_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/time_16x16.png"), 0)
			Me.imcSmall.Images.SetKeyName(0, "time_16x16.png")
			Me.imcSmall.InsertGalleryImage("design_16x16.png", "images/miscellaneous/design_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/design_16x16.png"), 1)
			Me.imcSmall.Images.SetKeyName(1, "design_16x16.png")
			Me.imcSmall.InsertGalleryImage("mail_16x16.png", "images/mail/mail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_16x16.png"), 2)
			Me.imcSmall.Images.SetKeyName(2, "mail_16x16.png")
			Me.imcSmall.InsertGalleryImage("pie_16x16.png", "images/chart/pie_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_16x16.png"), 3)
			Me.imcSmall.Images.SetKeyName(3, "pie_16x16.png")
			Me.imcSmall.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 4)
			Me.imcSmall.Images.SetKeyName(4, "home_16x16.png")
			Me.imcSmall.InsertGalleryImage("tag_16x16.png", "images/programming/tag_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/tag_16x16.png"), 5)
			Me.imcSmall.Images.SetKeyName(5, "tag_16x16.png")
			Me.imcSmall.InsertGalleryImage("contact_16x16.png", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 6)
			Me.imcSmall.Images.SetKeyName(6, "contact_16x16.png")
			Me.imcSmall.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 7)
			Me.imcSmall.Images.SetKeyName(7, "database_16x16.png")
			Me.imcSmall.InsertGalleryImage("task_16x16.png", "images/tasks/task_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_16x16.png"), 8)
			Me.imcSmall.Images.SetKeyName(8, "task_16x16.png")
			Me.imcSmall.InsertGalleryImage("video_16x16.png", "images/miscellaneous/video_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/video_16x16.png"), 9)
			Me.imcSmall.Images.SetKeyName(9, "video_16x16.png")
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.groupControl4)
			Me.xtraTabPage2.Controls.Add(Me.groupControl3)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(823, 559)
			Me.xtraTabPage2.Text = "Selected values and descriptions"
			' 
			' groupControl4
			' 
			Me.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl4.Appearance.Options.UseBackColor = True
			Me.groupControl4.Controls.Add(Me.teImageComboBoxEdit3)
			Me.groupControl4.Controls.Add(Me.teImageComboBoxEdit2)
			Me.groupControl4.Controls.Add(Me.teImageComboBoxEdit1)
			Me.groupControl4.Location = New System.Drawing.Point(269, 30)
			Me.groupControl4.Name = "groupControl4"
			Me.groupControl4.Size = New System.Drawing.Size(309, 156)
			Me.groupControl4.TabIndex = 3
			Me.groupControl4.Text = "Selected index / value / description"
			' 
			' teImageComboBoxEdit3
			' 
			Me.teImageComboBoxEdit3.EditValue = ""
			Me.teImageComboBoxEdit3.Location = New System.Drawing.Point(20, 110)
			Me.teImageComboBoxEdit3.Name = "teImageComboBoxEdit3"
			Me.teImageComboBoxEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.teImageComboBoxEdit3.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.teImageComboBoxEdit3.Properties.Appearance.Options.UseBackColor = True
			Me.teImageComboBoxEdit3.Properties.Appearance.Options.UseForeColor = True
			Me.teImageComboBoxEdit3.Properties.ReadOnly = True
			Me.teImageComboBoxEdit3.Size = New System.Drawing.Size(268, 20)
			Me.teImageComboBoxEdit3.TabIndex = 29
			Me.teImageComboBoxEdit3.TabStop = False
			' 
			' teImageComboBoxEdit2
			' 
			Me.teImageComboBoxEdit2.EditValue = ""
			Me.teImageComboBoxEdit2.Location = New System.Drawing.Point(20, 74)
			Me.teImageComboBoxEdit2.Name = "teImageComboBoxEdit2"
			Me.teImageComboBoxEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.teImageComboBoxEdit2.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.teImageComboBoxEdit2.Properties.Appearance.Options.UseBackColor = True
			Me.teImageComboBoxEdit2.Properties.Appearance.Options.UseForeColor = True
			Me.teImageComboBoxEdit2.Properties.ReadOnly = True
			Me.teImageComboBoxEdit2.Size = New System.Drawing.Size(268, 20)
			Me.teImageComboBoxEdit2.TabIndex = 28
			Me.teImageComboBoxEdit2.TabStop = False
			' 
			' teImageComboBoxEdit1
			' 
			Me.teImageComboBoxEdit1.EditValue = ""
			Me.teImageComboBoxEdit1.Location = New System.Drawing.Point(20, 38)
			Me.teImageComboBoxEdit1.Name = "teImageComboBoxEdit1"
			Me.teImageComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.teImageComboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.teImageComboBoxEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.teImageComboBoxEdit1.Properties.Appearance.Options.UseForeColor = True
			Me.teImageComboBoxEdit1.Properties.ReadOnly = True
			Me.teImageComboBoxEdit1.Size = New System.Drawing.Size(268, 20)
			Me.teImageComboBoxEdit1.TabIndex = 27
			Me.teImageComboBoxEdit1.TabStop = False
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.imageComboBoxEdit3)
			Me.groupControl3.Controls.Add(Me.imageComboBoxEdit1)
			Me.groupControl3.Controls.Add(Me.imageComboBoxEdit2)
			Me.groupControl3.Location = New System.Drawing.Point(30, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(208, 156)
			Me.groupControl3.TabIndex = 2
			Me.groupControl3.Text = "Editors"
			' 
			' imageComboBoxEdit3
			' 
			Me.imageComboBoxEdit3.EditValue = "imageComboBoxEdit3"
			Me.imageComboBoxEdit3.Location = New System.Drawing.Point(20, 110)
			Me.imageComboBoxEdit3.Name = "imageComboBoxEdit3"
			Me.imageComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit3.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", True, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unknown", Nothing, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", False, 1)})
			Me.imageComboBoxEdit3.Properties.SmallImages = Me.imageList1
			Me.imageComboBoxEdit3.Size = New System.Drawing.Size(164, 20)
			Me.imageComboBoxEdit3.TabIndex = 5
'			Me.imageComboBoxEdit3.EditValueChanged += New System.EventHandler(Me.imageComboBoxEdit3_EditValueChanged)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			' 
			' imageComboBoxEdit1
			' 
			Me.imageComboBoxEdit1.Location = New System.Drawing.Point(20, 38)
			Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
			Me.imageComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit1.Properties.DropDownRows = 10
			Me.imageComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Design", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mail", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pie", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Home", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tag", 5, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Contact", 6, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Database", 7, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", 8, 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Video", 9, 9)})
			Me.imageComboBoxEdit1.Properties.SmallImages = Me.imcSmall
			Me.imageComboBoxEdit1.Size = New System.Drawing.Size(164, 20)
			Me.imageComboBoxEdit1.TabIndex = 0
'			Me.imageComboBoxEdit1.EditValueChanged += New System.EventHandler(Me.imageComboBoxEdit1_EditValueChanged)
			' 
			' imageComboBoxEdit2
			' 
			Me.imageComboBoxEdit2.EditValue = "imageComboBoxEdit2"
			Me.imageComboBoxEdit2.Location = New System.Drawing.Point(20, 74)
			Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
			Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit2.Size = New System.Drawing.Size(164, 20)
			Me.imageComboBoxEdit2.TabIndex = 4
'			Me.imageComboBoxEdit2.EditValueChanged += New System.EventHandler(Me.imageComboBoxEdit2_EditValueChanged)
			' 
			' imcLarge
			' 
			Me.imcLarge.ImageSize = New System.Drawing.Size(32, 32)
			Me.imcLarge.ImageStream = (CType(resources.GetObject("imcLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imcLarge.InsertGalleryImage("time_32x32.png", "images/scheduling/time_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/time_32x32.png"), 0)
			Me.imcLarge.Images.SetKeyName(0, "time_32x32.png")
			Me.imcLarge.InsertGalleryImage("design_32x32.png", "images/miscellaneous/design_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/design_32x32.png"), 1)
			Me.imcLarge.Images.SetKeyName(1, "design_32x32.png")
			Me.imcLarge.InsertGalleryImage("mail_32x32.png", "images/mail/mail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_32x32.png"), 2)
			Me.imcLarge.Images.SetKeyName(2, "mail_32x32.png")
			Me.imcLarge.InsertGalleryImage("pie_32x32.png", "images/chart/pie_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_32x32.png"), 3)
			Me.imcLarge.Images.SetKeyName(3, "pie_32x32.png")
			Me.imcLarge.InsertGalleryImage("home_32x32.png", "images/navigation/home_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_32x32.png"), 4)
			Me.imcLarge.Images.SetKeyName(4, "home_32x32.png")
			Me.imcLarge.InsertGalleryImage("tag_32x32.png", "images/programming/tag_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/tag_32x32.png"), 5)
			Me.imcLarge.Images.SetKeyName(5, "tag_32x32.png")
			Me.imcLarge.InsertGalleryImage("contact_32x32.png", "images/mail/contact_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_32x32.png"), 6)
			Me.imcLarge.Images.SetKeyName(6, "contact_32x32.png")
			Me.imcLarge.InsertGalleryImage("database_32x32.png", "images/data/database_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_32x32.png"), 7)
			Me.imcLarge.Images.SetKeyName(7, "database_32x32.png")
			Me.imcLarge.InsertGalleryImage("task_32x32.png", "images/tasks/task_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_32x32.png"), 8)
			Me.imcLarge.Images.SetKeyName(8, "task_32x32.png")
			Me.imcLarge.InsertGalleryImage("video_32x32.png", "images/miscellaneous/video_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/video_32x32.png"), 9)
			Me.imcLarge.Images.SetKeyName(9, "video_32x32.png")
			' 
			' ModuleImageComboBoxEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleImageComboBoxEdit"
			Me.Size = New System.Drawing.Size(834, 592)
'			Me.Load += New System.EventHandler(Me.ModuleImageComboBoxEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.ceLargeImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.icbHighlightedItemStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceCTRLScroll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbShowDropDown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceImmediatePopup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceHotTrackItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceCycleOnDblClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAutoComplete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seDropDownRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.imageComboBoxEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imcSmall, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl4.ResumeLayout(False)
			CType(Me.teImageComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teImageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teImageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.imageComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imcLarge, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private imageComboBoxEditSample As DevExpress.XtraEditors.ImageComboBoxEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceCTRLScroll As DevExpress.XtraEditors.CheckEdit
		Private WithEvents icbShowDropDown As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cePopupSizeable As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceImmediatePopup As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceHotTrackItems As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceCycleOnDblClick As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAutoComplete As DevExpress.XtraEditors.CheckEdit
		Private WithEvents seDropDownRows As DevExpress.XtraEditors.SpinEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents icbAlignment As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceLargeImages As DevExpress.XtraEditors.CheckEdit
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
		Private groupControl4 As DevExpress.XtraEditors.GroupControl
		Private teImageComboBoxEdit1 As DevExpress.XtraEditors.TextEdit
		Private WithEvents imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit
		Private teImageComboBoxEdit2 As DevExpress.XtraEditors.TextEdit
		Private WithEvents imageComboBoxEdit3 As DevExpress.XtraEditors.ImageComboBoxEdit
		Private teImageComboBoxEdit3 As DevExpress.XtraEditors.TextEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents icbHighlightedItemStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private imcLarge As Utils.ImageCollection
		Private imcSmall As Utils.ImageCollection

	End Class
End Namespace
