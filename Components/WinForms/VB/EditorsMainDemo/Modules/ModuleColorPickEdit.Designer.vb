Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleColorPickEdit
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
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.icbTooltipMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.seClear = New DevExpress.XtraEditors.SimpleButton()
            Me.ceShowWebTab = New DevExpress.XtraEditors.CheckEdit()
            Me.seAdd = New DevExpress.XtraEditors.SimpleButton()
            Me.ceShowSystemTab = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowWebSafeTab = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowCustomTab = New DevExpress.XtraEditors.CheckEdit()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.ceAllowTransparency = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowPreview = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowMakeWebSafeBtn = New DevExpress.XtraEditors.CheckEdit()
            Me.lblShowArrowsOption = New DevExpress.XtraEditors.LabelControl()
            Me.lblShowTabsOption = New DevExpress.XtraEditors.LabelControl()
            Me.icbShowArrows = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowTabs = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.ceShowMoreColorsButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowAutomaticButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAsInteger = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowColorDialog = New DevExpress.XtraEditors.CheckEdit()
            Me.icbColorText = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbColorAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.colorEditSample = New DevExpress.XtraEditors.ColorPickEdit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.icbTooltipMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowWebTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowSystemTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowWebSafeTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowCustomTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            CType(Me.ceAllowTransparency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowMakeWebSafeBtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbShowArrows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbShowTabs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.ceShowMoreColorsButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowAutomaticButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAsInteger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowColorDialog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbColorText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbColorAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.colorEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(1016, 667)
            Me.xtraTabControl1.TabIndex = 1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.groupControl4)
            Me.xtraTabPage1.Controls.Add(Me.groupControl3)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Controls.Add(Me.panelControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(1010, 661)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            '
            'groupControl4
            '
            Me.groupControl4.Controls.Add(Me.icbTooltipMode)
            Me.groupControl4.Controls.Add(Me.labelControl1)
            Me.groupControl4.Controls.Add(Me.seClear)
            Me.groupControl4.Controls.Add(Me.ceShowWebTab)
            Me.groupControl4.Controls.Add(Me.seAdd)
            Me.groupControl4.Controls.Add(Me.ceShowSystemTab)
            Me.groupControl4.Controls.Add(Me.ceShowWebSafeTab)
            Me.groupControl4.Controls.Add(Me.ceShowCustomTab)
            Me.groupControl4.Location = New System.Drawing.Point(30, 346)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(627, 127)
            Me.groupControl4.TabIndex = 5
            Me.groupControl4.Text = "Popup Options"
            '
            'icbTooltipMode
            '
            Me.icbTooltipMode.Location = New System.Drawing.Point(158, 87)
            Me.icbTooltipMode.Name = "icbTooltipMode"
            Me.icbTooltipMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbTooltipMode.Size = New System.Drawing.Size(122, 20)
            Me.icbTooltipMode.TabIndex = 2
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(22, 90)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(73, 13)
            Me.labelControl1.TabIndex = 5
            Me.labelControl1.Text = "Tooltip Format:"
            '
            'seClear
            '
            Me.seClear.Enabled = False
            Me.seClear.Location = New System.Drawing.Point(412, 66)
            Me.seClear.Name = "seClear"
            Me.seClear.Size = New System.Drawing.Size(147, 24)
            Me.seClear.TabIndex = 1
            Me.seClear.Text = "Clear Custom Colors"
            '
            'ceShowWebTab
            '
            Me.ceShowWebTab.Location = New System.Drawing.Point(156, 32)
            Me.ceShowWebTab.Name = "ceShowWebTab"
            Me.ceShowWebTab.Properties.Caption = "Show Web Tab"
            Me.ceShowWebTab.Size = New System.Drawing.Size(139, 19)
            Me.ceShowWebTab.TabIndex = 4
            '
            'seAdd
            '
            Me.seAdd.Location = New System.Drawing.Point(412, 36)
            Me.seAdd.Name = "seAdd"
            Me.seAdd.Size = New System.Drawing.Size(147, 24)
            Me.seAdd.TabIndex = 0
            Me.seAdd.Text = "Generate Custom Colors"
            '
            'ceShowSystemTab
            '
            Me.ceShowSystemTab.Location = New System.Drawing.Point(20, 57)
            Me.ceShowSystemTab.Name = "ceShowSystemTab"
            Me.ceShowSystemTab.Properties.Caption = "Show System Tab"
            Me.ceShowSystemTab.Size = New System.Drawing.Size(120, 19)
            Me.ceShowSystemTab.TabIndex = 3
            '
            'ceShowWebSafeTab
            '
            Me.ceShowWebSafeTab.Location = New System.Drawing.Point(156, 57)
            Me.ceShowWebSafeTab.Name = "ceShowWebSafeTab"
            Me.ceShowWebSafeTab.Properties.Caption = "Show Web-Safe Tab"
            Me.ceShowWebSafeTab.Size = New System.Drawing.Size(139, 19)
            Me.ceShowWebSafeTab.TabIndex = 2
            '
            'ceShowCustomTab
            '
            Me.ceShowCustomTab.Location = New System.Drawing.Point(20, 32)
            Me.ceShowCustomTab.Name = "ceShowCustomTab"
            Me.ceShowCustomTab.Properties.Caption = "Show Custom Tab"
            Me.ceShowCustomTab.Size = New System.Drawing.Size(120, 19)
            Me.ceShowCustomTab.TabIndex = 0
            '
            'groupControl3
            '
            Me.groupControl3.Controls.Add(Me.ceAllowTransparency)
            Me.groupControl3.Controls.Add(Me.ceShowPreview)
            Me.groupControl3.Controls.Add(Me.ceShowMakeWebSafeBtn)
            Me.groupControl3.Controls.Add(Me.lblShowArrowsOption)
            Me.groupControl3.Controls.Add(Me.lblShowTabsOption)
            Me.groupControl3.Controls.Add(Me.icbShowArrows)
            Me.groupControl3.Controls.Add(Me.icbShowTabs)
            Me.groupControl3.Location = New System.Drawing.Point(358, 178)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(299, 147)
            Me.groupControl3.TabIndex = 4
            Me.groupControl3.Text = "Color Dialog Options"
            '
            'ceAllowTransparency
            '
            Me.ceAllowTransparency.Location = New System.Drawing.Point(129, 87)
            Me.ceAllowTransparency.Name = "ceAllowTransparency"
            Me.ceAllowTransparency.Properties.Caption = "Allow Transparency"
            Me.ceAllowTransparency.Size = New System.Drawing.Size(123, 19)
            Me.ceAllowTransparency.TabIndex = 12
            '
            'ceShowPreview
            '
            Me.ceShowPreview.Location = New System.Drawing.Point(18, 87)
            Me.ceShowPreview.Name = "ceShowPreview"
            Me.ceShowPreview.Properties.Caption = "Show Preview"
            Me.ceShowPreview.Size = New System.Drawing.Size(99, 19)
            Me.ceShowPreview.TabIndex = 11
            '
            'ceShowMakeWebSafeBtn
            '
            Me.ceShowMakeWebSafeBtn.Location = New System.Drawing.Point(18, 112)
            Me.ceShowMakeWebSafeBtn.Name = "ceShowMakeWebSafeBtn"
            Me.ceShowMakeWebSafeBtn.Properties.Caption = "Show ""Make Web-Safe"" Button"
            Me.ceShowMakeWebSafeBtn.Size = New System.Drawing.Size(176, 19)
            Me.ceShowMakeWebSafeBtn.TabIndex = 10
            '
            'lblShowArrowsOption
            '
            Me.lblShowArrowsOption.Location = New System.Drawing.Point(20, 64)
            Me.lblShowArrowsOption.Name = "lblShowArrowsOption"
            Me.lblShowArrowsOption.Size = New System.Drawing.Size(67, 13)
            Me.lblShowArrowsOption.TabIndex = 9
            Me.lblShowArrowsOption.Text = "Show Arrows:"
            '
            'lblShowTabsOption
            '
            Me.lblShowTabsOption.Location = New System.Drawing.Point(20, 35)
            Me.lblShowTabsOption.Name = "lblShowTabsOption"
            Me.lblShowTabsOption.Size = New System.Drawing.Size(56, 13)
            Me.lblShowTabsOption.TabIndex = 5
            Me.lblShowTabsOption.Text = "Show Tabs:"
            '
            'icbShowArrows
            '
            Me.icbShowArrows.Location = New System.Drawing.Point(128, 61)
            Me.icbShowArrows.Name = "icbShowArrows"
            Me.icbShowArrows.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowArrows.Size = New System.Drawing.Size(124, 20)
            Me.icbShowArrows.TabIndex = 4
            '
            'icbShowTabs
            '
            Me.icbShowTabs.Location = New System.Drawing.Point(128, 32)
            Me.icbShowTabs.Name = "icbShowTabs"
            Me.icbShowTabs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowTabs.Size = New System.Drawing.Size(124, 20)
            Me.icbShowTabs.TabIndex = 0
            '
            'groupControl1
            '
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.ceShowMoreColorsButton)
            Me.groupControl1.Controls.Add(Me.ceShowAutomaticButton)
            Me.groupControl1.Controls.Add(Me.ceAsInteger)
            Me.groupControl1.Controls.Add(Me.ceShowColorDialog)
            Me.groupControl1.Controls.Add(Me.icbColorText)
            Me.groupControl1.Controls.Add(Me.icbColorAlignment)
            Me.groupControl1.Controls.Add(Me.label1)
            Me.groupControl1.Controls.Add(Me.lblSelect)
            Me.groupControl1.Location = New System.Drawing.Point(30, 178)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(295, 147)
            Me.groupControl1.TabIndex = 2
            Me.groupControl1.Text = "Properties"
            '
            'ceShowMoreColorsButton
            '
            Me.ceShowMoreColorsButton.Location = New System.Drawing.Point(150, 112)
            Me.ceShowMoreColorsButton.Name = "ceShowMoreColorsButton"
            Me.ceShowMoreColorsButton.Properties.Caption = "Show ""More Colors"""
            Me.ceShowMoreColorsButton.Size = New System.Drawing.Size(145, 19)
            Me.ceShowMoreColorsButton.TabIndex = 19
            '
            'ceShowAutomaticButton
            '
            Me.ceShowAutomaticButton.Location = New System.Drawing.Point(150, 87)
            Me.ceShowAutomaticButton.Name = "ceShowAutomaticButton"
            Me.ceShowAutomaticButton.Properties.Caption = "Show ""Automatic"""
            Me.ceShowAutomaticButton.Size = New System.Drawing.Size(140, 19)
            Me.ceShowAutomaticButton.TabIndex = 19
            '
            'ceAsInteger
            '
            Me.ceAsInteger.Location = New System.Drawing.Point(18, 112)
            Me.ceAsInteger.Name = "ceAsInteger"
            Me.ceAsInteger.Properties.Caption = "Store Color as Integer"
            Me.ceAsInteger.Size = New System.Drawing.Size(137, 19)
            Me.ceAsInteger.TabIndex = 18
            '
            'ceShowColorDialog
            '
            Me.ceShowColorDialog.Location = New System.Drawing.Point(18, 87)
            Me.ceShowColorDialog.Name = "ceShowColorDialog"
            Me.ceShowColorDialog.Properties.Caption = "Show Color Dialog"
            Me.ceShowColorDialog.Size = New System.Drawing.Size(232, 19)
            Me.ceShowColorDialog.TabIndex = 17
            '
            'icbColorText
            '
            Me.icbColorText.EditValue = "imageComboBoxEdit2"
            Me.icbColorText.Location = New System.Drawing.Point(105, 61)
            Me.icbColorText.Name = "icbColorText"
            Me.icbColorText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbColorText.Size = New System.Drawing.Size(175, 20)
            Me.icbColorText.TabIndex = 16
            '
            'icbColorAlignment
            '
            Me.icbColorAlignment.EditValue = "imageComboBoxEdit1"
            Me.icbColorAlignment.Location = New System.Drawing.Point(105, 32)
            Me.icbColorAlignment.Name = "icbColorAlignment"
            Me.icbColorAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbColorAlignment.Size = New System.Drawing.Size(175, 20)
            Me.icbColorAlignment.TabIndex = 15
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(20, 64)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(54, 13)
            Me.label1.TabIndex = 14
            Me.label1.Text = "Color Text:"
            '
            'lblSelect
            '
            Me.lblSelect.Location = New System.Drawing.Point(20, 35)
            Me.lblSelect.Name = "lblSelect"
            Me.lblSelect.Size = New System.Drawing.Size(79, 13)
            Me.lblSelect.TabIndex = 13
            Me.lblSelect.Text = "Color Alignment:"
            '
            'panelControl1
            '
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Controls.Add(Me.colorEditSample)
            Me.panelControl1.Location = New System.Drawing.Point(30, 30)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(627, 127)
            Me.panelControl1.TabIndex = 1
            Me.panelControl1.Text = "Sample"
            '
            'colorEditSample
            '
            Me.colorEditSample.EditValue = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.colorEditSample.Location = New System.Drawing.Point(158, 24)
            Me.colorEditSample.Name = "colorEditSample"
            Me.colorEditSample.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditSample.Size = New System.Drawing.Size(188, 20)
            Me.colorEditSample.TabIndex = 1
            '
            'ModuleColorPickEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleColorPickEdit"
            Me.Size = New System.Drawing.Size(1021, 672)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            Me.groupControl4.PerformLayout()
            CType(Me.icbTooltipMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowWebTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowSystemTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowWebSafeTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowCustomTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            Me.groupControl3.PerformLayout()
            CType(Me.ceAllowTransparency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowMakeWebSafeBtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbShowArrows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbShowTabs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.ceShowMoreColorsButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowAutomaticButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAsInteger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowColorDialog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbColorText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbColorAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.colorEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbColorAlignment As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbColorText As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceShowColorDialog As DevExpress.XtraEditors.CheckEdit
		Private WithEvents seAdd As DevExpress.XtraEditors.SimpleButton
		Private WithEvents seClear As DevExpress.XtraEditors.SimpleButton
		Private WithEvents ceAsInteger As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private colorEditSample As DevExpress.XtraEditors.ColorPickEdit
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents icbShowTabs As DevExpress.XtraEditors.ImageComboBoxEdit
		Private lblShowArrowsOption As DevExpress.XtraEditors.LabelControl
		Private lblShowTabsOption As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbShowArrows As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceAllowTransparency As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowPreview As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowMakeWebSafeBtn As DevExpress.XtraEditors.CheckEdit
		Private groupControl4 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceShowWebTab As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowSystemTab As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowWebSafeTab As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowCustomTab As DevExpress.XtraEditors.CheckEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbTooltipMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Friend WithEvents ceShowMoreColorsButton As CheckEdit
        Friend WithEvents ceShowAutomaticButton As CheckEdit
    End Class
End Namespace
