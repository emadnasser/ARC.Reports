Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleCheckEdit
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleCheckEdit))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.pictureGrayed = New DevExpress.XtraEditors.PictureEdit()
			Me.pictureUnchecked = New DevExpress.XtraEditors.PictureEdit()
			Me.pictureChecked = New DevExpress.XtraEditors.PictureEdit()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.gcSampleCheckBox = New DevExpress.XtraEditors.GroupControl()
			Me.checkEditSample = New DevExpress.XtraEditors.CheckEdit()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.btnApplyImagesOK = New DevExpress.XtraEditors.SimpleButton()
			Me.btnApplyImagesCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAllowHTMLString = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditAllowMnemonics = New DevExpress.XtraEditors.CheckEdit()
			Me.btnToggleState = New DevExpress.XtraEditors.SimpleButton()
			Me.comboCheckState = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditAllowGrayed = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.editorStyleSwitcher = New DevExpress.XtraEditors.ButtonEdit()
			Me.popupCustomImages = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.lblCurrentStyle = New DevExpress.XtraEditors.LabelControl()
			Me.lblCustomPictures = New DevExpress.XtraEditors.LabelControl()
			Me.comboAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblCheckBoxAlign = New DevExpress.XtraEditors.LabelControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.gcRadioCheckEdits = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl6 = New DevExpress.XtraEditors.GroupControl()
			Me.checkEditRadioGroup = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEditApplyRadioStyle = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.pictureGrayed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureUnchecked.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureChecked.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.gcSampleCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gcSampleCheckBox.SuspendLayout()
			CType(Me.checkEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.ceAllowHTMLString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditAllowMnemonics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboCheckState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditAllowGrayed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.editorStyleSwitcher.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupCustomImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.gcRadioCheckEdits, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl6.SuspendLayout()
			CType(Me.checkEditRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditApplyRadioStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureGrayed
			' 
			Me.pictureGrayed.EditValue = (CObj(resources.GetObject("pictureGrayed.EditValue")))
			Me.pictureGrayed.Location = New System.Drawing.Point(118, 50)
			Me.pictureGrayed.Name = "pictureGrayed"
			Me.pictureGrayed.Size = New System.Drawing.Size(36, 36)
			Me.pictureGrayed.TabIndex = 6
			Me.pictureGrayed.ToolTip = "Right-click to load an image"
			' 
			' pictureUnchecked
			' 
			Me.pictureUnchecked.EditValue = (CObj(resources.GetObject("pictureUnchecked.EditValue")))
			Me.pictureUnchecked.Location = New System.Drawing.Point(71, 50)
			Me.pictureUnchecked.Name = "pictureUnchecked"
			Me.pictureUnchecked.Size = New System.Drawing.Size(36, 36)
			Me.pictureUnchecked.TabIndex = 5
			Me.pictureUnchecked.ToolTip = "Right-click to load an image"
			' 
			' pictureChecked
			' 
			Me.pictureChecked.EditValue = (CObj(resources.GetObject("pictureChecked.EditValue")))
			Me.pictureChecked.Location = New System.Drawing.Point(24, 50)
			Me.pictureChecked.Name = "pictureChecked"
			Me.pictureChecked.Size = New System.Drawing.Size(36, 36)
			Me.pictureChecked.TabIndex = 4
			Me.pictureChecked.ToolTip = "Right-click to load an image"
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(755, 663)
			Me.xtraTabControl1.TabIndex = 4
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gcSampleCheckBox)
			Me.xtraTabPage1.Controls.Add(Me.popupContainerControl1)
			Me.xtraTabPage1.Controls.Add(Me.groupControl3)
			Me.xtraTabPage1.Controls.Add(Me.groupControl5)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(749, 635)
			Me.xtraTabPage1.Text = "Check States and Styles"
			' 
			' gcSampleCheckBox
			' 
			Me.gcSampleCheckBox.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.gcSampleCheckBox.Appearance.Options.UseBackColor = True
			Me.gcSampleCheckBox.Controls.Add(Me.checkEditSample)
			Me.gcSampleCheckBox.Location = New System.Drawing.Point(30, 30)
			Me.gcSampleCheckBox.Name = "gcSampleCheckBox"
			Me.gcSampleCheckBox.Size = New System.Drawing.Size(202, 359)
			Me.gcSampleCheckBox.TabIndex = 0
			Me.gcSampleCheckBox.Text = "Sample"
			' 
			' checkEditSample
			' 
			Me.checkEditSample.Location = New System.Drawing.Point(47, 54)
			Me.checkEditSample.Name = "checkEditSample"
			Me.checkEditSample.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
			Me.checkEditSample.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.checkEditSample.Properties.Appearance.Options.UseFont = True
			Me.checkEditSample.Properties.Appearance.Options.UseTextOptions = True
			Me.checkEditSample.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.checkEditSample.Properties.AutoHeight = False
			Me.checkEditSample.Properties.Caption = "<Color=Blue>Sample<Color=Black> <b>check</b><br>box"
			Me.checkEditSample.Size = New System.Drawing.Size(135, 45)
			Me.checkEditSample.TabIndex = 0
'			Me.checkEditSample.CheckStateChanged += New System.EventHandler(Me.checkEditSample_CheckStateChanged)
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.label2)
			Me.popupContainerControl1.Controls.Add(Me.btnApplyImagesOK)
			Me.popupContainerControl1.Controls.Add(Me.btnApplyImagesCancel)
			Me.popupContainerControl1.Controls.Add(Me.pictureUnchecked)
			Me.popupContainerControl1.Controls.Add(Me.pictureChecked)
			Me.popupContainerControl1.Controls.Add(Me.pictureGrayed)
			Me.popupContainerControl1.Location = New System.Drawing.Point(20, 504)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(182, 133)
			Me.popupContainerControl1.TabIndex = 15
			' 
			' label2
			' 
			Me.label2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.label2.Location = New System.Drawing.Point(8, 8)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(164, 26)
			Me.label2.TabIndex = 9
			Me.label2.Text = "Right-click images to change pictures"
			' 
			' btnApplyImagesOK
			' 
			Me.btnApplyImagesOK.Location = New System.Drawing.Point(40, 101)
			Me.btnApplyImagesOK.Name = "btnApplyImagesOK"
			Me.btnApplyImagesOK.Size = New System.Drawing.Size(64, 24)
			Me.btnApplyImagesOK.TabIndex = 0
			Me.btnApplyImagesOK.Text = "Apply"
'			Me.btnApplyImagesOK.Click += New System.EventHandler(Me.btnApplyImagesOK_Click)
			' 
			' btnApplyImagesCancel
			' 
			Me.btnApplyImagesCancel.Location = New System.Drawing.Point(108, 101)
			Me.btnApplyImagesCancel.Name = "btnApplyImagesCancel"
			Me.btnApplyImagesCancel.Size = New System.Drawing.Size(64, 24)
			Me.btnApplyImagesCancel.TabIndex = 1
			Me.btnApplyImagesCancel.Text = "Cancel"
'			Me.btnApplyImagesCancel.Click += New System.EventHandler(Me.btnApplyImagesCancel_Click)
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.ceAllowHTMLString)
			Me.groupControl3.Controls.Add(Me.checkEditAllowMnemonics)
			Me.groupControl3.Controls.Add(Me.btnToggleState)
			Me.groupControl3.Controls.Add(Me.comboCheckState)
			Me.groupControl3.Controls.Add(Me.label4)
			Me.groupControl3.Controls.Add(Me.label3)
			Me.groupControl3.Controls.Add(Me.checkEditAllowGrayed)
			Me.groupControl3.Location = New System.Drawing.Point(262, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(282, 178)
			Me.groupControl3.TabIndex = 1
			Me.groupControl3.Text = "Check state"
			' 
			' ceAllowHTMLString
			' 
			Me.ceAllowHTMLString.Location = New System.Drawing.Point(20, 80)
			Me.ceAllowHTMLString.Name = "ceAllowHTMLString"
			Me.ceAllowHTMLString.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.ceAllowHTMLString.Properties.Appearance.Options.UseBackColor = True
			Me.ceAllowHTMLString.Properties.Caption = "Allow HTML Draw"
			Me.ceAllowHTMLString.Size = New System.Drawing.Size(232, 19)
			Me.ceAllowHTMLString.TabIndex = 2
'			Me.ceAllowHTMLString.CheckedChanged += New System.EventHandler(Me.ceAllowHTMLString_CheckedChanged)
			' 
			' checkEditAllowMnemonics
			' 
			Me.checkEditAllowMnemonics.Location = New System.Drawing.Point(20, 30)
			Me.checkEditAllowMnemonics.Name = "checkEditAllowMnemonics"
			Me.checkEditAllowMnemonics.Properties.Caption = "Allow mnemonics"
			Me.checkEditAllowMnemonics.Size = New System.Drawing.Size(232, 19)
			Me.checkEditAllowMnemonics.TabIndex = 0
'			Me.checkEditAllowMnemonics.CheckedChanged += New System.EventHandler(Me.checkEditAllowMnemonics_CheckedChanged)
			' 
			' btnToggleState
			' 
			Me.btnToggleState.Location = New System.Drawing.Point(119, 107)
			Me.btnToggleState.Name = "btnToggleState"
			Me.btnToggleState.Size = New System.Drawing.Size(140, 24)
			Me.btnToggleState.TabIndex = 4
			Me.btnToggleState.Text = "Toggle"
'			Me.btnToggleState.Click += New System.EventHandler(Me.btnToggleState_Click)
			' 
			' comboCheckState
			' 
			Me.comboCheckState.EditValue = "Unchecked"
			Me.comboCheckState.Location = New System.Drawing.Point(119, 137)
			Me.comboCheckState.Name = "comboCheckState"
			Me.comboCheckState.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboCheckState.Properties.Items.AddRange(New Object() { "Checked", "Unchecked", "Indeterminate"})
			Me.comboCheckState.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboCheckState.Size = New System.Drawing.Size(140, 20)
			Me.comboCheckState.TabIndex = 6
'			Me.comboCheckState.SelectedIndexChanged += New System.EventHandler(Me.comboCheckState_SelectedIndexChanged)
			' 
			' label4
			' 
			Me.label4.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label4.Location = New System.Drawing.Point(23, 112)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(82, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Check / uncheck:"
			' 
			' label3
			' 
			Me.label3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label3.Location = New System.Drawing.Point(23, 140)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(61, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Check state:"
			' 
			' checkEditAllowGrayed
			' 
			Me.checkEditAllowGrayed.Location = New System.Drawing.Point(20, 55)
			Me.checkEditAllowGrayed.Name = "checkEditAllowGrayed"
			Me.checkEditAllowGrayed.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.checkEditAllowGrayed.Properties.Appearance.Options.UseBackColor = True
			Me.checkEditAllowGrayed.Properties.Caption = "Allow indeterminate state"
			Me.checkEditAllowGrayed.Size = New System.Drawing.Size(232, 19)
			Me.checkEditAllowGrayed.TabIndex = 1
'			Me.checkEditAllowGrayed.CheckedChanged += New System.EventHandler(Me.checkEditAllowGrayed_CheckedChanged)
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.Controls.Add(Me.editorStyleSwitcher)
			Me.groupControl5.Controls.Add(Me.popupCustomImages)
			Me.groupControl5.Controls.Add(Me.lblCurrentStyle)
			Me.groupControl5.Controls.Add(Me.lblCustomPictures)
			Me.groupControl5.Controls.Add(Me.comboAlign)
			Me.groupControl5.Controls.Add(Me.lblCheckBoxAlign)
			Me.groupControl5.Location = New System.Drawing.Point(262, 230)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Size = New System.Drawing.Size(282, 159)
			Me.groupControl5.TabIndex = 2
			Me.groupControl5.Text = "Check box"
			' 
			' editorStyleSwitcher
			' 
			Me.editorStyleSwitcher.EditValue = "Standard"
			Me.editorStyleSwitcher.Location = New System.Drawing.Point(116, 28)
			Me.editorStyleSwitcher.Name = "editorStyleSwitcher"
			Me.editorStyleSwitcher.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, False)})
			Me.editorStyleSwitcher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.editorStyleSwitcher.Size = New System.Drawing.Size(143, 20)
			Me.editorStyleSwitcher.TabIndex = 0
			Me.editorStyleSwitcher.ToolTip = "Click the editor button to switch styles"
'			Me.editorStyleSwitcher.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.editorStyleSwitcher_ButtonClick)
			' 
			' popupCustomImages
			' 
			Me.popupCustomImages.EditValue = "Choose images..."
			Me.popupCustomImages.Location = New System.Drawing.Point(116, 54)
			Me.popupCustomImages.Name = "popupCustomImages"
			Me.popupCustomImages.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupCustomImages.Properties.PopupControl = Me.popupContainerControl1
			Me.popupCustomImages.Properties.PopupFormMinSize = New System.Drawing.Size(140, 0)
			Me.popupCustomImages.Properties.PopupSizeable = False
			Me.popupCustomImages.Properties.ShowPopupCloseButton = False
			Me.popupCustomImages.Size = New System.Drawing.Size(143, 20)
			Me.popupCustomImages.TabIndex = 1
			' 
			' lblCurrentStyle
			' 
			Me.lblCurrentStyle.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lblCurrentStyle.Location = New System.Drawing.Point(22, 31)
			Me.lblCurrentStyle.Name = "lblCurrentStyle"
			Me.lblCurrentStyle.Size = New System.Drawing.Size(59, 13)
			Me.lblCurrentStyle.TabIndex = 3
			Me.lblCurrentStyle.Text = "Check style:"
			' 
			' lblCustomPictures
			' 
			Me.lblCustomPictures.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lblCustomPictures.Location = New System.Drawing.Point(22, 57)
			Me.lblCustomPictures.Name = "lblCustomPictures"
			Me.lblCustomPictures.Size = New System.Drawing.Size(76, 13)
			Me.lblCustomPictures.TabIndex = 12
			Me.lblCustomPictures.Text = "Custom images:"
			' 
			' comboAlign
			' 
			Me.comboAlign.EditValue = "Near"
			Me.comboAlign.Location = New System.Drawing.Point(116, 80)
			Me.comboAlign.Name = "comboAlign"
			Me.comboAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboAlign.Properties.Items.AddRange(New Object() { "Near", "Center", "Far"})
			Me.comboAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboAlign.Size = New System.Drawing.Size(143, 20)
			Me.comboAlign.TabIndex = 2
'			Me.comboAlign.SelectedIndexChanged += New System.EventHandler(Me.comboAlign_SelectedIndexChanged)
			' 
			' lblCheckBoxAlign
			' 
			Me.lblCheckBoxAlign.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lblCheckBoxAlign.Location = New System.Drawing.Point(22, 83)
			Me.lblCheckBoxAlign.Name = "lblCheckBoxAlign"
			Me.lblCheckBoxAlign.Size = New System.Drawing.Size(51, 13)
			Me.lblCheckBoxAlign.TabIndex = 1
			Me.lblCheckBoxAlign.Text = "Alignment:"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.gcRadioCheckEdits)
			Me.xtraTabPage2.Controls.Add(Me.groupControl6)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(749, 635)
			Me.xtraTabPage2.Text = "Radio Groups"
			' 
			' gcRadioCheckEdits
			' 
			Me.gcRadioCheckEdits.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.gcRadioCheckEdits.Appearance.Options.UseBackColor = True
			Me.gcRadioCheckEdits.Location = New System.Drawing.Point(30, 29)
			Me.gcRadioCheckEdits.Name = "gcRadioCheckEdits"
			Me.gcRadioCheckEdits.Size = New System.Drawing.Size(175, 310)
			Me.gcRadioCheckEdits.TabIndex = 0
			Me.gcRadioCheckEdits.Text = "Sample"
			' 
			' groupControl6
			' 
			Me.groupControl6.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl6.Appearance.Options.UseBackColor = True
			Me.groupControl6.Controls.Add(Me.checkEditRadioGroup)
			Me.groupControl6.Controls.Add(Me.checkEditApplyRadioStyle)
			Me.groupControl6.Location = New System.Drawing.Point(236, 29)
			Me.groupControl6.Name = "groupControl6"
			Me.groupControl6.Size = New System.Drawing.Size(228, 310)
			Me.groupControl6.TabIndex = 1
			Me.groupControl6.Text = "Options"
			' 
			' checkEditRadioGroup
			' 
			Me.checkEditRadioGroup.Location = New System.Drawing.Point(20, 30)
			Me.checkEditRadioGroup.Name = "checkEditRadioGroup"
			Me.checkEditRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.checkEditRadioGroup.Properties.Appearance.Options.UseBackColor = True
			Me.checkEditRadioGroup.Properties.Caption = "Radio group"
			Me.checkEditRadioGroup.Size = New System.Drawing.Size(184, 19)
			Me.checkEditRadioGroup.TabIndex = 0
'			Me.checkEditRadioGroup.CheckedChanged += New System.EventHandler(Me.checkEditRadioGroup_CheckedChanged)
			' 
			' checkEditApplyRadioStyle
			' 
			Me.checkEditApplyRadioStyle.Location = New System.Drawing.Point(20, 55)
			Me.checkEditApplyRadioStyle.Name = "checkEditApplyRadioStyle"
			Me.checkEditApplyRadioStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.checkEditApplyRadioStyle.Properties.Appearance.Options.UseBackColor = True
			Me.checkEditApplyRadioStyle.Properties.Caption = "Apply radio group style"
			Me.checkEditApplyRadioStyle.Size = New System.Drawing.Size(184, 19)
			Me.checkEditApplyRadioStyle.TabIndex = 10
'			Me.checkEditApplyRadioStyle.CheckedChanged += New System.EventHandler(Me.checkEditApplyRadioStyle_CheckedChanged)
			' 
			' ModuleCheckEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleCheckEdit"
			Me.Size = New System.Drawing.Size(760, 668)
'			Me.Load += New System.EventHandler(Me.TutorialModuleCheckEdit_Load)
			CType(Me.pictureGrayed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureUnchecked.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureChecked.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.gcSampleCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gcSampleCheckBox.ResumeLayout(False)
			CType(Me.checkEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.groupControl3.PerformLayout()
			CType(Me.ceAllowHTMLString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditAllowMnemonics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboCheckState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditAllowGrayed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			Me.groupControl5.PerformLayout()
			CType(Me.editorStyleSwitcher.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupCustomImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.gcRadioCheckEdits, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl6.ResumeLayout(False)
			CType(Me.checkEditRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditApplyRadioStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private pictureChecked As DevExpress.XtraEditors.PictureEdit
		Private pictureUnchecked As DevExpress.XtraEditors.PictureEdit
		Private pictureGrayed As DevExpress.XtraEditors.PictureEdit
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private WithEvents btnApplyImagesCancel As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnApplyImagesOK As DevExpress.XtraEditors.SimpleButton
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private WithEvents editorStyleSwitcher As DevExpress.XtraEditors.ButtonEdit
		Private popupCustomImages As DevExpress.XtraEditors.PopupContainerEdit
		Private lblCurrentStyle As DevExpress.XtraEditors.LabelControl
		Private lblCustomPictures As DevExpress.XtraEditors.LabelControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents btnToggleState As DevExpress.XtraEditors.SimpleButton
		Private WithEvents comboCheckState As DevExpress.XtraEditors.ComboBoxEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditAllowGrayed As DevExpress.XtraEditors.CheckEdit
		Private WithEvents comboAlign As DevExpress.XtraEditors.ComboBoxEdit
		Private lblCheckBoxAlign As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditAllowMnemonics As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEditSample As DevExpress.XtraEditors.CheckEdit
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private groupControl6 As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkEditRadioGroup As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEditApplyRadioStyle As DevExpress.XtraEditors.CheckEdit
		Private gcSampleCheckBox As DevExpress.XtraEditors.GroupControl
		Private gcRadioCheckEdits As DevExpress.XtraEditors.GroupControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents ceAllowHTMLString As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
