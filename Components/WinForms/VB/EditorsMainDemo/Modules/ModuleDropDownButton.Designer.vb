Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleDropDownButton
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleDropDownButton))
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.icbDropDownStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.icbImageLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.icbImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.icbDropDownControl = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.meFiringEvents = New DevExpress.XtraEditors.MemoEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.timeEdit1 = New DevExpress.XtraEditors.TimeEdit()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.gcSample = New DevExpress.XtraEditors.GroupControl()
			Me.sampleDropDownButton = New DevExpress.XtraEditors.DropDownButton()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.icbDropDownStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbImageLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbDropDownControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer1.SuspendLayout()
			CType(Me.timeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcSample, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gcSample.SuspendLayout()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 35)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(92, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "DropDown Control:"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.icbDropDownStyle)
			Me.groupControl2.Controls.Add(Me.icbImageLocation)
			Me.groupControl2.Controls.Add(Me.labelControl6)
			Me.groupControl2.Controls.Add(Me.labelControl3)
			Me.groupControl2.Controls.Add(Me.icbImage)
			Me.groupControl2.Controls.Add(Me.labelControl2)
			Me.groupControl2.Controls.Add(Me.icbDropDownControl)
			Me.groupControl2.Controls.Add(Me.labelControl1)
			Me.groupControl2.Location = New System.Drawing.Point(291, 30)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(333, 154)
			Me.groupControl2.TabIndex = 7
			Me.groupControl2.Text = "Options"
			' 
			' icbDropDownStyle
			' 
			Me.icbDropDownStyle.Location = New System.Drawing.Point(151, 111)
			Me.icbDropDownStyle.Name = "icbDropDownStyle"
			Me.icbDropDownStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbDropDownStyle.Size = New System.Drawing.Size(160, 20)
			Me.icbDropDownStyle.TabIndex = 6
'			Me.icbDropDownStyle.SelectedIndexChanged += New System.EventHandler(Me.icbDropDownStyle_SelectedIndexChanged)
			' 
			' icbImageLocation
			' 
			Me.icbImageLocation.Location = New System.Drawing.Point(151, 85)
			Me.icbImageLocation.Name = "icbImageLocation"
			Me.icbImageLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbImageLocation.Properties.DropDownRows = 12
			Me.icbImageLocation.Size = New System.Drawing.Size(160, 20)
			Me.icbImageLocation.TabIndex = 6
'			Me.icbImageLocation.SelectedIndexChanged += New System.EventHandler(Me.icbImageLocation_SelectedIndexChanged)
			' 
			' labelControl6
			' 
			Me.labelControl6.Location = New System.Drawing.Point(20, 114)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(113, 13)
			Me.labelControl6.TabIndex = 5
			Me.labelControl6.Text = "DropDown Arrow Style:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(20, 88)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(77, 13)
			Me.labelControl3.TabIndex = 5
			Me.labelControl3.Text = "Image Location:"
			' 
			' icbImage
			' 
			Me.icbImage.Location = New System.Drawing.Point(151, 59)
			Me.icbImage.Name = "icbImage"
			Me.icbImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbImage.Properties.SmallImages = Me.imageCollection1
			Me.icbImage.Size = New System.Drawing.Size(160, 20)
			Me.icbImage.TabIndex = 4
'			Me.icbImage.SelectedIndexChanged += New System.EventHandler(Me.icbImage_SelectedIndexChanged)
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Address")
			Me.imageCollection1.Images.SetKeyName(1, "Contact")
			Me.imageCollection1.Images.SetKeyName(2, "Contract")
			Me.imageCollection1.Images.SetKeyName(3, "Customer")
			Me.imageCollection1.Images.SetKeyName(4, "Employeer")
			Me.imageCollection1.Images.SetKeyName(5, "Report")
			Me.imageCollection1.Images.SetKeyName(6, "User")
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(20, 62)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(34, 13)
			Me.labelControl2.TabIndex = 3
			Me.labelControl2.Text = "Image:"
			' 
			' icbDropDownControl
			' 
			Me.icbDropDownControl.Location = New System.Drawing.Point(151, 32)
			Me.icbDropDownControl.Name = "icbDropDownControl"
			Me.icbDropDownControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbDropDownControl.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Popup Menu", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Popup Control Container", 1, -1)})
			Me.icbDropDownControl.Size = New System.Drawing.Size(160, 20)
			Me.icbDropDownControl.TabIndex = 2
'			Me.icbDropDownControl.SelectedIndexChanged += New System.EventHandler(Me.icbDropDownControl_SelectedIndexChanged)
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(1194, 637)
			Me.xtraTabControl1.TabIndex = 3
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl5)
			Me.xtraTabPage1.Controls.Add(Me.popupControlContainer1)
			Me.xtraTabPage1.Controls.Add(Me.gcSample)
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(1188, 631)
			Me.xtraTabPage1.Text = "General"
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.CaptionImage = My.Resources.note_16x16
			Me.groupControl5.Controls.Add(Me.meFiringEvents)
			Me.groupControl5.Controls.Add(Me.panelControl1)
			Me.groupControl5.Location = New System.Drawing.Point(291, 205)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl5.Size = New System.Drawing.Size(333, 209)
			Me.groupControl5.TabIndex = 10
			Me.groupControl5.Text = "Event log"
			' 
			' meFiringEvents
			' 
			Me.meFiringEvents.Dock = System.Windows.Forms.DockStyle.Fill
			Me.meFiringEvents.EditValue = ""
			Me.meFiringEvents.Location = New System.Drawing.Point(10, 32)
			Me.meFiringEvents.Name = "meFiringEvents"
			Me.meFiringEvents.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.meFiringEvents.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.meFiringEvents.Properties.Appearance.Options.UseBackColor = True
			Me.meFiringEvents.Properties.Appearance.Options.UseForeColor = True
			Me.meFiringEvents.Properties.ReadOnly = True
			Me.meFiringEvents.Size = New System.Drawing.Size(313, 132)
			Me.meFiringEvents.TabIndex = 0
			Me.meFiringEvents.TabStop = False
			Me.meFiringEvents.UseOptimizedRendering = True
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.simpleButton3)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(10, 164)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(313, 35)
			Me.panelControl1.TabIndex = 9
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(233, 6)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(80, 24)
			Me.simpleButton3.TabIndex = 8
			Me.simpleButton3.Text = "Clear log"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click)
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.simpleButton2)
            Me.popupControlContainer1.Controls.Add(Me.simpleButton1)
			Me.popupControlContainer1.Controls.Add(Me.timeEdit1)
			Me.popupControlContainer1.Controls.Add(Me.dateEdit1)
			Me.popupControlContainer1.Controls.Add(Me.labelControl5)
			Me.popupControlContainer1.Controls.Add(Me.labelControl4)
			Me.popupControlContainer1.Location = New System.Drawing.Point(951, 12)
			Me.popupControlContainer1.Manager = Me.barManager1
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(220, 135)
			Me.popupControlContainer1.TabIndex = 8
			Me.popupControlContainer1.Visible = False
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(142, 94)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(64, 24)
			Me.simpleButton2.TabIndex = 7
			Me.simpleButton2.Text = "Clear"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click)
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(76, 94)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(60, 24)
			Me.simpleButton1.TabIndex = 6
			Me.simpleButton1.Text = "Now"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click)
			' 
			' timeEdit1
			' 
			Me.timeEdit1.EditValue = New Date(2009, 6, 22, 0, 0, 0, 0)
			Me.timeEdit1.Location = New System.Drawing.Point(76, 47)
			Me.timeEdit1.MenuManager = Me.barManager1
			Me.timeEdit1.Name = "timeEdit1"
			Me.timeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeEdit1.Size = New System.Drawing.Size(130, 20)
			Me.timeEdit1.TabIndex = 5
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Images = Me.imageCollection2
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5})
			Me.barManager1.MaxItemId = 5
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(5, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(1194, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(5, 637)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1194, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(5, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 637)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1199, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 637)
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection2.Images.SetKeyName(0, "save-16x16.png")
			Me.imageCollection2.Images.SetKeyName(1, "open-16x16.png")
			Me.imageCollection2.Images.SetKeyName(2, "copy-16x16.png")
			Me.imageCollection2.Images.SetKeyName(3, "paste-16x16.png")
			Me.imageCollection2.Images.SetKeyName(4, "delete-16x16.png")
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Copy"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.ImageIndex = 2
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Paste"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.ImageIndex = 3
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "Delete"
			Me.barButtonItem3.Id = 2
			Me.barButtonItem3.ImageIndex = 4
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "Open"
			Me.barButtonItem4.Id = 3
			Me.barButtonItem4.ImageIndex = 1
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "Save"
			Me.barButtonItem5.Id = 4
			Me.barButtonItem5.ImageIndex = 0
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(76, 17)
			Me.dateEdit1.MenuManager = Me.barManager1
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(130, 20)
			Me.dateEdit1.TabIndex = 4
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(17, 50)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(26, 13)
			Me.labelControl5.TabIndex = 3
			Me.labelControl5.Text = "Time:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(17, 20)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(27, 13)
			Me.labelControl4.TabIndex = 2
			Me.labelControl4.Text = "Date:"
			' 
			' gcSample
			' 
			Me.gcSample.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.gcSample.Appearance.Options.UseBackColor = True
			Me.gcSample.Controls.Add(Me.sampleDropDownButton)
			Me.gcSample.Location = New System.Drawing.Point(30, 30)
			Me.gcSample.Name = "gcSample"
			Me.gcSample.Size = New System.Drawing.Size(230, 384)
			Me.gcSample.TabIndex = 9
			Me.gcSample.Text = "Sample"
			' 
			' sampleDropDownButton
			' 
			Me.sampleDropDownButton.DropDownControl = Me.popupMenu1
			Me.sampleDropDownButton.ImageIndex = 0
			Me.sampleDropDownButton.ImageList = Me.imageCollection1
			Me.sampleDropDownButton.Location = New System.Drawing.Point(27, 44)
			Me.sampleDropDownButton.Name = "sampleDropDownButton"
			Me.sampleDropDownButton.Size = New System.Drawing.Size(172, 35)
			Me.sampleDropDownButton.TabIndex = 0
			Me.sampleDropDownButton.Text = "DropDown Button"
'			Me.sampleDropDownButton.ShowDropDownControl += New DevExpress.XtraEditors.ShowDropDownControlEventHandler(Me.sampleDropDownButton_ShowDropDownControl)
'			Me.sampleDropDownButton.Click += New System.EventHandler(Me.sampleDropDownButton_Click)
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' ModuleDropDownButton
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ModuleDropDownButton"
			Me.Size = New System.Drawing.Size(1199, 642)
'			Me.Load += New System.EventHandler(Me.ModulePictureEdit_Load)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.icbDropDownStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbImageLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbDropDownControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer1.ResumeLayout(False)
			Me.popupControlContainer1.PerformLayout()
			CType(Me.timeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcSample, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gcSample.ResumeLayout(False)
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private gcSample As DevExpress.XtraEditors.GroupControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents sampleDropDownButton As DevExpress.XtraEditors.DropDownButton
		Private WithEvents icbImageLocation As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbImage As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbDropDownControl As DevExpress.XtraEditors.ImageComboBoxEdit
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private timeEdit1 As DevExpress.XtraEditors.TimeEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private meFiringEvents As DevExpress.XtraEditors.MemoEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents icbDropDownStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
