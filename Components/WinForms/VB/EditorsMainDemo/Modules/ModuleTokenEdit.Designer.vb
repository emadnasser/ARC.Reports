Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTokenEdit
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.previewGroup = New DevExpress.XtraEditors.GroupControl()
            Me.editValueLabel = New DevExpress.XtraEditors.LabelControl()
            Me.tokenEdit = New DevExpress.XtraEditors.TokenEdit()
            Me.flyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
            Me.tokenLabelValue = New DevExpress.XtraEditors.LabelControl()
            Me.tokenLabel = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.cbePopupPanelLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowPopupPanel = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            Me.eventsLog = New DevExpress.XtraEditors.MemoEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnClearEventLog = New DevExpress.XtraEditors.SimpleButton()
            Me.appearanceOptionsGroup = New DevExpress.XtraEditors.GroupControl()
            Me.GlyphLocationLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeGlyphLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbeFontSize = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.fontSizeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeEditMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.editModeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeDropDownMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.dropDownModeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.cbeEditValueSep = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowItemRemoveButton = New DevExpress.XtraEditors.CheckEdit()
            Me.seDropDownRowCount = New DevExpress.XtraEditors.SpinEdit()
            Me.maxExpandLinesLabel = New DevExpress.XtraEditors.LabelControl()
            Me.seMaxExpandLines = New DevExpress.XtraEditors.SpinEdit()
            Me.dropDownRowCountLabel = New DevExpress.XtraEditors.LabelControl()
            Me.checkModeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeCheckMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowDropDown = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.previewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.previewGroup.SuspendLayout()
            CType(Me.tokenEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.cbePopupPanelLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowPopupPanel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl5.SuspendLayout()
            CType(Me.eventsLog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.appearanceOptionsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.appearanceOptionsGroup.SuspendLayout()
            CType(Me.cbeGlyphLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeFontSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeEditMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeDropDownMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeEditValueSep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowItemRemoveButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDropDownRowCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seMaxExpandLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeCheckMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowDropDown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'previewGroup
            '
            Me.previewGroup.Controls.Add(Me.editValueLabel)
            Me.previewGroup.Controls.Add(Me.tokenEdit)
            Me.previewGroup.Location = New System.Drawing.Point(23, 15)
            Me.previewGroup.Name = "previewGroup"
            Me.previewGroup.Size = New System.Drawing.Size(326, 348)
            Me.previewGroup.TabIndex = 0
            Me.previewGroup.Text = "Sample"
            '
            'editValueLabel
            '
            Me.editValueLabel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.editValueLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.editValueLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.editValueLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.editValueLabel.Location = New System.Drawing.Point(20, 31)
            Me.editValueLabel.Name = "editValueLabel"
            Me.editValueLabel.Size = New System.Drawing.Size(278, 44)
            Me.editValueLabel.TabIndex = 0
            Me.editValueLabel.Text = "Edit Value: (empty)"
            '
            'tokenEdit
            '
            Me.tokenEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tokenEdit.Location = New System.Drawing.Point(20, 87)
            Me.tokenEdit.Properties.AutoHeightMode = TokenEditAutoHeightMode.RestrictedExpand
            Me.tokenEdit.Name = "tokenEdit"
            Me.tokenEdit.Properties.PopupPanel = Me.flyoutPanel1
            Me.tokenEdit.Properties.PopupPanelOptions.ShowPopupPanel = False
            Me.tokenEdit.Properties.Separators.AddRange(New String() {",", ";"})
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("January", "January"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("February", "February"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("March", "March"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("April", "April"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("May", "May"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("June", "June"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("July", "July"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("August", "August"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("September", "September"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("October", "October"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("November", "November"))
            Me.tokenEdit.Properties.Tokens.Add(New DevExpress.XtraEditors.TokenEditToken("December", "December"))
            Me.tokenEdit.Size = New System.Drawing.Size(278, 20)
            Me.tokenEdit.TabIndex = 1
            '
            'flyoutPanel1
            '
            Me.flyoutPanel1.Controls.Add(Me.tokenLabelValue)
            Me.flyoutPanel1.Controls.Add(Me.tokenLabel)
            Me.flyoutPanel1.Location = New System.Drawing.Point(23, 596)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.OwnerControl = Me.xtraTabControl1
            Me.flyoutPanel1.Size = New System.Drawing.Size(326, 90)
            Me.flyoutPanel1.TabIndex = 17
            '
            'tokenLabelValue
            '
            Me.tokenLabelValue.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tokenLabelValue.Location = New System.Drawing.Point(170, 36)
            Me.tokenLabelValue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.tokenLabelValue.Name = "tokenLabelValue"
            Me.tokenLabelValue.Size = New System.Drawing.Size(45, 16)
            Me.tokenLabelValue.TabIndex = 3
            Me.tokenLabelValue.Text = "(Token)"
            '
            'tokenLabel
            '
            Me.tokenLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tokenLabel.Location = New System.Drawing.Point(124, 36)
            Me.tokenLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.tokenLabel.Name = "tokenLabel"
            Me.tokenLabel.Size = New System.Drawing.Size(40, 16)
            Me.tokenLabel.TabIndex = 3
            Me.tokenLabel.Text = "Token:"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(784, 705)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.flyoutPanel1)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Controls.Add(Me.previewGroup)
            Me.xtraTabPage1.Controls.Add(Me.groupControl5)
            Me.xtraTabPage1.Controls.Add(Me.appearanceOptionsGroup)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(778, 699)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            '
            'groupControl1
            '
            Me.groupControl1.Controls.Add(Me.cbePopupPanelLocation)
            Me.groupControl1.Controls.Add(Me.ceShowPopupPanel)
            Me.groupControl1.Controls.Add(Me.labelControl5)
            Me.groupControl1.Location = New System.Drawing.Point(23, 384)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(326, 196)
            Me.groupControl1.TabIndex = 2
            Me.groupControl1.Text = "PopupPanel Options"
            '
            'cbePopupPanelLocation
            '
            Me.cbePopupPanelLocation.Location = New System.Drawing.Point(86, 58)
            Me.cbePopupPanelLocation.Name = "cbePopupPanelLocation"
            Me.cbePopupPanelLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbePopupPanelLocation.Size = New System.Drawing.Size(182, 20)
            Me.cbePopupPanelLocation.TabIndex = 2
            '
            'ceShowPopupPanel
            '
            Me.ceShowPopupPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ceShowPopupPanel.Location = New System.Drawing.Point(19, 30)
            Me.ceShowPopupPanel.Name = "ceShowPopupPanel"
            Me.ceShowPopupPanel.Properties.Caption = "Show PopupPanel"
            Me.ceShowPopupPanel.Size = New System.Drawing.Size(157, 19)
            Me.ceShowPopupPanel.TabIndex = 0
            '
            'labelControl5
            '
            Me.labelControl5.Location = New System.Drawing.Point(20, 61)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(44, 13)
            Me.labelControl5.TabIndex = 1
            Me.labelControl5.Text = "Location:"
            '
            'groupControl5
            '
            Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl5.Appearance.Options.UseBackColor = True
            Me.groupControl5.CaptionImage = Global.My.Resources.Resources.note_16x16
            Me.groupControl5.Controls.Add(Me.eventsLog)
            Me.groupControl5.Controls.Add(Me.panelControl1)
            Me.groupControl5.Location = New System.Drawing.Point(380, 384)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
            Me.groupControl5.Size = New System.Drawing.Size(371, 196)
            Me.groupControl5.TabIndex = 3
            Me.groupControl5.Text = "Event log"
            '
            'eventsLog
            '
            Me.eventsLog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.eventsLog.EditValue = ""
            Me.eventsLog.Location = New System.Drawing.Point(10, 32)
            Me.eventsLog.Name = "eventsLog"
            Me.eventsLog.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.eventsLog.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.eventsLog.Properties.Appearance.Options.UseBackColor = True
            Me.eventsLog.Properties.Appearance.Options.UseForeColor = True
            Me.eventsLog.Properties.ReadOnly = True
            Me.eventsLog.Size = New System.Drawing.Size(351, 107)
            Me.eventsLog.TabIndex = 0
            Me.eventsLog.TabStop = False
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.btnClearEventLog)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(10, 139)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(351, 47)
            Me.panelControl1.TabIndex = 1
            '
            'btnClearEventLog
            '
            Me.btnClearEventLog.Location = New System.Drawing.Point(271, 12)
            Me.btnClearEventLog.Name = "btnClearEventLog"
            Me.btnClearEventLog.Size = New System.Drawing.Size(80, 23)
            Me.btnClearEventLog.TabIndex = 0
            Me.btnClearEventLog.Text = "Clear log"
            '
            'appearanceOptionsGroup
            '
            Me.appearanceOptionsGroup.Controls.Add(Me.GlyphLocationLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeGlyphLocation)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeFontSize)
            Me.appearanceOptionsGroup.Controls.Add(Me.fontSizeLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeEditMode)
            Me.appearanceOptionsGroup.Controls.Add(Me.editModeLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeDropDownMode)
            Me.appearanceOptionsGroup.Controls.Add(Me.dropDownModeLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.labelControl2)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeEditValueSep)
            Me.appearanceOptionsGroup.Controls.Add(Me.cePopupSizeable)
            Me.appearanceOptionsGroup.Controls.Add(Me.ceShowItemRemoveButton)
            Me.appearanceOptionsGroup.Controls.Add(Me.seDropDownRowCount)
            Me.appearanceOptionsGroup.Controls.Add(Me.maxExpandLinesLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.seMaxExpandLines)
            Me.appearanceOptionsGroup.Controls.Add(Me.dropDownRowCountLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.checkModeLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeCheckMode)
            Me.appearanceOptionsGroup.Controls.Add(Me.ceShowDropDown)
            Me.appearanceOptionsGroup.Location = New System.Drawing.Point(380, 15)
            Me.appearanceOptionsGroup.Name = "appearanceOptionsGroup"
            Me.appearanceOptionsGroup.Size = New System.Drawing.Size(371, 348)
            Me.appearanceOptionsGroup.TabIndex = 1
            Me.appearanceOptionsGroup.Text = "Appearance && Behavior Options"
            '
            'GlyphLocationLabel
            '
            Me.GlyphLocationLabel.Location = New System.Drawing.Point(20, 308)
            Me.GlyphLocationLabel.Name = "GlyphLocationLabel"
            Me.GlyphLocationLabel.Size = New System.Drawing.Size(74, 13)
            Me.GlyphLocationLabel.TabIndex = 17
            Me.GlyphLocationLabel.Text = "Glyph Location:"
            '
            'cbeGlyphLocation
            '
            Me.cbeGlyphLocation.Location = New System.Drawing.Point(156, 305)
            Me.cbeGlyphLocation.Name = "cbeGlyphLocation"
            Me.cbeGlyphLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeGlyphLocation.Size = New System.Drawing.Size(187, 20)
            Me.cbeGlyphLocation.TabIndex = 18
            '
            'cbeFontSize
            '
            Me.cbeFontSize.Location = New System.Drawing.Point(156, 102)
            Me.cbeFontSize.Name = "cbeFontSize"
            Me.cbeFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeFontSize.Size = New System.Drawing.Size(187, 20)
            Me.cbeFontSize.TabIndex = 4
            '
            'fontSizeLabel
            '
            Me.fontSizeLabel.Location = New System.Drawing.Point(20, 105)
            Me.fontSizeLabel.Name = "fontSizeLabel"
            Me.fontSizeLabel.Size = New System.Drawing.Size(48, 13)
            Me.fontSizeLabel.TabIndex = 3
            Me.fontSizeLabel.Text = "Font Size:"
            '
            'cbeEditMode
            '
            Me.cbeEditMode.Location = New System.Drawing.Point(156, 131)
            Me.cbeEditMode.Name = "cbeEditMode"
            Me.cbeEditMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeEditMode.Size = New System.Drawing.Size(187, 20)
            Me.cbeEditMode.TabIndex = 6
            '
            'editModeLabel
            '
            Me.editModeLabel.Location = New System.Drawing.Point(20, 134)
            Me.editModeLabel.Name = "editModeLabel"
            Me.editModeLabel.Size = New System.Drawing.Size(51, 13)
            Me.editModeLabel.TabIndex = 5
            Me.editModeLabel.Text = "Edit Mode:"
            '
            'cbeDropDownMode
            '
            Me.cbeDropDownMode.Location = New System.Drawing.Point(156, 189)
            Me.cbeDropDownMode.Name = "cbeDropDownMode"
            Me.cbeDropDownMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeDropDownMode.Size = New System.Drawing.Size(187, 20)
            Me.cbeDropDownMode.TabIndex = 10
            '
            'dropDownModeLabel
            '
            Me.dropDownModeLabel.Location = New System.Drawing.Point(20, 192)
            Me.dropDownModeLabel.Name = "dropDownModeLabel"
            Me.dropDownModeLabel.Size = New System.Drawing.Size(83, 13)
            Me.dropDownModeLabel.TabIndex = 9
            Me.dropDownModeLabel.Text = "DropDown Mode:"
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(20, 163)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(99, 13)
            Me.labelControl2.TabIndex = 7
            Me.labelControl2.Text = "EditValue Separator:"
            '
            'cbeEditValueSep
            '
            Me.cbeEditValueSep.Location = New System.Drawing.Point(156, 160)
            Me.cbeEditValueSep.Name = "cbeEditValueSep"
            Me.cbeEditValueSep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeEditValueSep.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(",", ",", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(";", ";", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("-", "-", -1)})
            Me.cbeEditValueSep.Size = New System.Drawing.Size(187, 20)
            Me.cbeEditValueSep.TabIndex = 8
            '
            'cePopupSizeable
            '
            Me.cePopupSizeable.Location = New System.Drawing.Point(19, 52)
            Me.cePopupSizeable.Name = "cePopupSizeable"
            Me.cePopupSizeable.Properties.Caption = "Popup Sizeable"
            Me.cePopupSizeable.Size = New System.Drawing.Size(106, 19)
            Me.cePopupSizeable.TabIndex = 1
            '
            'ceShowItemRemoveButton
            '
            Me.ceShowItemRemoveButton.Location = New System.Drawing.Point(19, 74)
            Me.ceShowItemRemoveButton.Name = "ceShowItemRemoveButton"
            Me.ceShowItemRemoveButton.Properties.Caption = "Show Remove Token Buttons in DropDown"
            Me.ceShowItemRemoveButton.Size = New System.Drawing.Size(229, 19)
            Me.ceShowItemRemoveButton.TabIndex = 2
            '
            'seDropDownRowCount
            '
            Me.seDropDownRowCount.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
            Me.seDropDownRowCount.Location = New System.Drawing.Point(156, 218)
            Me.seDropDownRowCount.Name = "seDropDownRowCount"
            Me.seDropDownRowCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seDropDownRowCount.Properties.Mask.EditMask = "n0"
            Me.seDropDownRowCount.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.seDropDownRowCount.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
            Me.seDropDownRowCount.Size = New System.Drawing.Size(187, 20)
            Me.seDropDownRowCount.TabIndex = 12
            '
            'maxExpandLinesLabel
            '
            Me.maxExpandLinesLabel.Location = New System.Drawing.Point(20, 279)
            Me.maxExpandLinesLabel.Name = "maxExpandLinesLabel"
            Me.maxExpandLinesLabel.Size = New System.Drawing.Size(114, 13)
            Me.maxExpandLinesLabel.TabIndex = 15
            Me.maxExpandLinesLabel.Text = "Maximum Expand Lines:"
            '
            'seMaxExpandLines
            '
            Me.seMaxExpandLines.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seMaxExpandLines.Location = New System.Drawing.Point(156, 276)
            Me.seMaxExpandLines.Name = "seMaxExpandLines"
            Me.seMaxExpandLines.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seMaxExpandLines.Properties.Mask.EditMask = "n0"
            Me.seMaxExpandLines.Properties.MaxValue = New Decimal(New Integer() {8, 0, 0, 0})
            Me.seMaxExpandLines.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seMaxExpandLines.Size = New System.Drawing.Size(187, 20)
            Me.seMaxExpandLines.TabIndex = 16
            '
            'dropDownRowCountLabel
            '
            Me.dropDownRowCountLabel.Location = New System.Drawing.Point(20, 221)
            Me.dropDownRowCountLabel.Name = "dropDownRowCountLabel"
            Me.dropDownRowCountLabel.Size = New System.Drawing.Size(110, 13)
            Me.dropDownRowCountLabel.TabIndex = 11
            Me.dropDownRowCountLabel.Text = "DropDown Row Count:"
            '
            'checkModeLabel
            '
            Me.checkModeLabel.Location = New System.Drawing.Point(20, 250)
            Me.checkModeLabel.Name = "checkModeLabel"
            Me.checkModeLabel.Size = New System.Drawing.Size(62, 13)
            Me.checkModeLabel.TabIndex = 13
            Me.checkModeLabel.Text = "Check Mode:"
            '
            'cbeCheckMode
            '
            Me.cbeCheckMode.Location = New System.Drawing.Point(156, 247)
            Me.cbeCheckMode.Name = "cbeCheckMode"
            Me.cbeCheckMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeCheckMode.Size = New System.Drawing.Size(187, 20)
            Me.cbeCheckMode.TabIndex = 14
            '
            'ceShowDropDown
            '
            Me.ceShowDropDown.Location = New System.Drawing.Point(19, 30)
            Me.ceShowDropDown.Name = "ceShowDropDown"
            Me.ceShowDropDown.Properties.Caption = "Show DropDown"
            Me.ceShowDropDown.Size = New System.Drawing.Size(106, 19)
            Me.ceShowDropDown.TabIndex = 0
            '
            'ModuleTokenEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleTokenEdit"
            Me.Size = New System.Drawing.Size(789, 710)
            CType(Me.previewGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.previewGroup.ResumeLayout(False)
            CType(Me.tokenEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            Me.flyoutPanel1.PerformLayout()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.cbePopupPanelLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowPopupPanel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            CType(Me.eventsLog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.appearanceOptionsGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.appearanceOptionsGroup.ResumeLayout(False)
            Me.appearanceOptionsGroup.PerformLayout()
            CType(Me.cbeGlyphLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeFontSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeEditMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeDropDownMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeEditValueSep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowItemRemoveButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDropDownRowCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seMaxExpandLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeCheckMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowDropDown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private previewGroup As GroupControl
        Private appearanceOptionsGroup As GroupControl
        Private WithEvents tokenEdit As TokenEdit
        Private groupControl5 As GroupControl
        Private eventsLog As MemoEdit
        Private panelControl1 As PanelControl
        Private WithEvents btnClearEventLog As SimpleButton
        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private xtraTabPage1 As XtraTab.XtraTabPage
        Private WithEvents ceShowDropDown As CheckEdit
        Private checkModeLabel As LabelControl
        Private dropDownRowCountLabel As LabelControl
        Private maxExpandLinesLabel As LabelControl
        Private WithEvents seMaxExpandLines As SpinEdit
        Private groupControl1 As GroupControl
        Private WithEvents cbePopupPanelLocation As ImageComboBoxEdit
        Private WithEvents ceShowPopupPanel As CheckEdit
        Private labelControl5 As LabelControl
        Private WithEvents cbeCheckMode As ImageComboBoxEdit
		Private WithEvents seDropDownRowCount As SpinEdit
		Private flyoutPanel1 As Utils.FlyoutPanel
		Private tokenLabel As LabelControl
		Private tokenLabelValue As LabelControl
		Private WithEvents ceShowItemRemoveButton As CheckEdit
		Private editValueLabel As LabelControl
		Private WithEvents cePopupSizeable As CheckEdit
		Private WithEvents cbeEditValueSep As ImageComboBoxEdit
		Private labelControl2 As LabelControl
		Private WithEvents cbeDropDownMode As ImageComboBoxEdit
		Private dropDownModeLabel As LabelControl
		Private WithEvents cbeEditMode As ImageComboBoxEdit
		Private editModeLabel As LabelControl
		Private WithEvents cbeFontSize As ImageComboBoxEdit
        Private fontSizeLabel As LabelControl
        Private WithEvents GlyphLocationLabel As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbeGlyphLocation As DevExpress.XtraEditors.ImageComboBoxEdit

	End Class
End Namespace
