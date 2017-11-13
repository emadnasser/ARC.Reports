Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleComboBoxEdit
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
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.txtSelectedIndexValue = New DevExpress.XtraEditors.TextEdit()
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
			Me.icbTextEditStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.seDropDownRows = New DevExpress.XtraEditors.SpinEdit()
			Me.seItemHeight = New DevExpress.XtraEditors.SpinEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.comboBoxEditSample = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.txtSelectedIndexValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			CType(Me.icbTextEditStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seDropDownRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seItemHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.comboBoxEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(964, 565)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(958, 559)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.txtSelectedIndexValue)
			Me.groupControl2.Location = New System.Drawing.Point(296, 388)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(296, 71)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Selected index / Edit value"
			' 
			' txtSelectedIndexValue
			' 
			Me.txtSelectedIndexValue.EditValue = ""
			Me.txtSelectedIndexValue.Location = New System.Drawing.Point(20, 32)
			Me.txtSelectedIndexValue.Name = "txtSelectedIndexValue"
			Me.txtSelectedIndexValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.txtSelectedIndexValue.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.txtSelectedIndexValue.Properties.Appearance.Options.UseBackColor = True
			Me.txtSelectedIndexValue.Properties.Appearance.Options.UseForeColor = True
			Me.txtSelectedIndexValue.Properties.ReadOnly = True
			Me.txtSelectedIndexValue.Size = New System.Drawing.Size(255, 20)
			Me.txtSelectedIndexValue.TabIndex = 26
			Me.txtSelectedIndexValue.TabStop = False
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
			Me.groupControl1.Controls.Add(Me.icbTextEditStyle)
			Me.groupControl1.Controls.Add(Me.seDropDownRows)
			Me.groupControl1.Controls.Add(Me.seItemHeight)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(296, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(296, 337)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' icbHighlightedItemStyle
			' 
			Me.icbHighlightedItemStyle.EditValue = "imageComboBoxEdit1"
			Me.icbHighlightedItemStyle.Location = New System.Drawing.Point(148, 90)
			Me.icbHighlightedItemStyle.Name = "icbHighlightedItemStyle"
			Me.icbHighlightedItemStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbHighlightedItemStyle.Size = New System.Drawing.Size(127, 20)
			Me.icbHighlightedItemStyle.TabIndex = 2
'			Me.icbHighlightedItemStyle.SelectedIndexChanged += New System.EventHandler(Me.icbHighlightedItemStyle_SelectedIndexChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 93)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(106, 13)
			Me.labelControl1.TabIndex = 27
			Me.labelControl1.Text = "Highlighted item style:"
			' 
			' ceCTRLScroll
			' 
			Me.ceCTRLScroll.Location = New System.Drawing.Point(18, 299)
			Me.ceCTRLScroll.Name = "ceCTRLScroll"
			Me.ceCTRLScroll.Properties.Caption = "Use CTRL scroll"
			Me.ceCTRLScroll.Size = New System.Drawing.Size(168, 19)
			Me.ceCTRLScroll.TabIndex = 10
'			Me.ceCTRLScroll.CheckedChanged += New System.EventHandler(Me.ceCTRLScroll_CheckedChanged)
			' 
			' icbShowDropDown
			' 
			Me.icbShowDropDown.EditValue = "imageComboBoxEdit1"
			Me.icbShowDropDown.Location = New System.Drawing.Point(148, 61)
			Me.icbShowDropDown.Name = "icbShowDropDown"
			Me.icbShowDropDown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbShowDropDown.Size = New System.Drawing.Size(127, 20)
			Me.icbShowDropDown.TabIndex = 1
'			Me.icbShowDropDown.SelectedIndexChanged += New System.EventHandler(Me.icbShowDropDown_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 64)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(81, 13)
			Me.label3.TabIndex = 25
			Me.label3.Text = "Show dropdown:"
			' 
			' cePopupSizeable
			' 
			Me.cePopupSizeable.Location = New System.Drawing.Point(18, 274)
			Me.cePopupSizeable.Name = "cePopupSizeable"
			Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
			Me.cePopupSizeable.Size = New System.Drawing.Size(168, 19)
			Me.cePopupSizeable.TabIndex = 9
'			Me.cePopupSizeable.CheckedChanged += New System.EventHandler(Me.cePopupSizeable_CheckedChanged)
			' 
			' ceImmediatePopup
			' 
			Me.ceImmediatePopup.Location = New System.Drawing.Point(18, 249)
			Me.ceImmediatePopup.Name = "ceImmediatePopup"
			Me.ceImmediatePopup.Properties.Caption = "Immediate popup"
			Me.ceImmediatePopup.Size = New System.Drawing.Size(168, 19)
			Me.ceImmediatePopup.TabIndex = 8
'			Me.ceImmediatePopup.CheckedChanged += New System.EventHandler(Me.ceImmediatePopup_CheckedChanged)
			' 
			' ceHotTrackItems
			' 
			Me.ceHotTrackItems.Location = New System.Drawing.Point(18, 224)
			Me.ceHotTrackItems.Name = "ceHotTrackItems"
			Me.ceHotTrackItems.Properties.Caption = "Hot-track items"
			Me.ceHotTrackItems.Size = New System.Drawing.Size(168, 19)
			Me.ceHotTrackItems.TabIndex = 7
'			Me.ceHotTrackItems.CheckedChanged += New System.EventHandler(Me.ceHotTrackItems_CheckedChanged)
			' 
			' ceCycleOnDblClick
			' 
			Me.ceCycleOnDblClick.Location = New System.Drawing.Point(18, 199)
			Me.ceCycleOnDblClick.Name = "ceCycleOnDblClick"
			Me.ceCycleOnDblClick.Properties.Caption = "Cycle on double click"
			Me.ceCycleOnDblClick.Size = New System.Drawing.Size(168, 19)
			Me.ceCycleOnDblClick.TabIndex = 6
'			Me.ceCycleOnDblClick.CheckedChanged += New System.EventHandler(Me.ceCycleOnDblClick_CheckedChanged)
			' 
			' ceAutoComplete
			' 
			Me.ceAutoComplete.Location = New System.Drawing.Point(18, 174)
			Me.ceAutoComplete.Name = "ceAutoComplete"
			Me.ceAutoComplete.Properties.Caption = "Auto-complete"
			Me.ceAutoComplete.Size = New System.Drawing.Size(168, 19)
			Me.ceAutoComplete.TabIndex = 5
'			Me.ceAutoComplete.CheckedChanged += New System.EventHandler(Me.ceAutoComplete_CheckedChanged)
			' 
			' icbTextEditStyle
			' 
			Me.icbTextEditStyle.EditValue = "imageComboBoxEdit1"
			Me.icbTextEditStyle.Location = New System.Drawing.Point(148, 32)
			Me.icbTextEditStyle.Name = "icbTextEditStyle"
			Me.icbTextEditStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbTextEditStyle.Size = New System.Drawing.Size(127, 20)
			Me.icbTextEditStyle.TabIndex = 0
'			Me.icbTextEditStyle.SelectedIndexChanged += New System.EventHandler(Me.icbTextEditStyle_SelectedIndexChanged)
			' 
			' seDropDownRows
			' 
			Me.seDropDownRows.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seDropDownRows.Location = New System.Drawing.Point(148, 148)
			Me.seDropDownRows.Name = "seDropDownRows"
			Me.seDropDownRows.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seDropDownRows.Properties.IsFloatValue = False
			Me.seDropDownRows.Properties.Mask.EditMask = "N00"
			Me.seDropDownRows.Properties.MaxValue = New Decimal(New Integer() { 25, 0, 0, 0})
			Me.seDropDownRows.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seDropDownRows.Size = New System.Drawing.Size(108, 20)
			Me.seDropDownRows.TabIndex = 4
'			Me.seDropDownRows.EditValueChanged += New System.EventHandler(Me.seDropDownRows_EditValueChanged)
			' 
			' seItemHeight
			' 
			Me.seItemHeight.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seItemHeight.Location = New System.Drawing.Point(148, 119)
			Me.seItemHeight.Name = "seItemHeight"
			Me.seItemHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seItemHeight.Properties.IsFloatValue = False
			Me.seItemHeight.Properties.Mask.EditMask = "N00"
			Me.seItemHeight.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.seItemHeight.Size = New System.Drawing.Size(108, 20)
			Me.seItemHeight.TabIndex = 3
'			Me.seItemHeight.EditValueChanged += New System.EventHandler(Me.seItemHeight_EditValueChanged)
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 151)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(79, 13)
			Me.label2.TabIndex = 16
			Me.label2.Text = "Dropdown rows:"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 122)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(109, 13)
			Me.label1.TabIndex = 15
			Me.label1.Text = "Dropdown item height:"
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 39)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(73, 13)
			Me.lblSelect.TabIndex = 13
			Me.lblSelect.Text = "Text edit style:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.comboBoxEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(235, 429)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' comboBoxEditSample
			' 
			Me.comboBoxEditSample.Location = New System.Drawing.Point(19, 72)
			Me.comboBoxEditSample.Name = "comboBoxEditSample"
			Me.comboBoxEditSample.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
			Me.comboBoxEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditSample.Properties.DropDownRows = 12
			Me.comboBoxEditSample.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditSample.Size = New System.Drawing.Size(185, 20)
			Me.comboBoxEditSample.TabIndex = 0
'			Me.comboBoxEditSample.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditSample_SelectedIndexChanged)
'			Me.comboBoxEditSample.EditValueChanged += New System.EventHandler(Me.comboBoxEditSample_EditValueChanged)
			' 
			' ModuleComboBoxEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleComboBoxEdit"
			Me.Size = New System.Drawing.Size(969, 570)
'			Me.Load += New System.EventHandler(Me.ModuleComboBoxEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.txtSelectedIndexValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
			CType(Me.icbTextEditStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seDropDownRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seItemHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.comboBoxEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents comboBoxEditSample As DevExpress.XtraEditors.ComboBoxEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seItemHeight As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seDropDownRows As DevExpress.XtraEditors.SpinEdit
		Private WithEvents icbTextEditStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents cePopupSizeable As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceImmediatePopup As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceHotTrackItems As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceCycleOnDblClick As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAutoComplete As DevExpress.XtraEditors.CheckEdit
		Private WithEvents icbShowDropDown As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private txtSelectedIndexValue As DevExpress.XtraEditors.TextEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceCTRLScroll As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents icbHighlightedItemStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
