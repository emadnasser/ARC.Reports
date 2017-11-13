Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleRadioGroup
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
			Me.btnPopulateItems = New DevExpress.XtraEditors.SimpleButton()
			Me.btnClearItems = New DevExpress.XtraEditors.SimpleButton()
			Me.txtSelectedIndexValue = New DevExpress.XtraEditors.TextEdit()
			Me.lblCurrentItemDesc = New DevExpress.XtraEditors.LabelControl()
			Me.lblEditValue = New DevExpress.XtraEditors.LabelControl()
			Me.spinSelectedIndex = New DevExpress.XtraEditors.SpinEdit()
			Me.lblSelectedIndex = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditAllowMnemonics = New DevExpress.XtraEditors.CheckEdit()
			Me.comboSetEditValue = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblColumnCount = New DevExpress.XtraEditors.LabelControl()
			Me.lblGlyphAlign = New DevExpress.XtraEditors.LabelControl()
			Me.spinColumns = New DevExpress.XtraEditors.SpinEdit()
			Me.comboGlyphAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.radioGroupSample = New DevExpress.XtraEditors.RadioGroup()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			CType(Me.txtSelectedIndexValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinSelectedIndex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditAllowMnemonics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboSetEditValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboGlyphAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroupSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnPopulateItems
			' 
			Me.btnPopulateItems.Location = New System.Drawing.Point(118, 30)
			Me.btnPopulateItems.Name = "btnPopulateItems"
			Me.btnPopulateItems.Size = New System.Drawing.Size(114, 24)
			Me.btnPopulateItems.TabIndex = 1
			Me.btnPopulateItems.Text = "Populate Items"
'			Me.btnPopulateItems.Click += New System.EventHandler(Me.btnPopulateItems_Click)
			' 
			' btnClearItems
			' 
			Me.btnClearItems.Location = New System.Drawing.Point(20, 30)
			Me.btnClearItems.Name = "btnClearItems"
			Me.btnClearItems.Size = New System.Drawing.Size(92, 24)
			Me.btnClearItems.TabIndex = 0
			Me.btnClearItems.Text = "Clear Items"
'			Me.btnClearItems.Click += New System.EventHandler(Me.btnClearItems_Click)
			' 
			' txtSelectedIndexValue
			' 
			Me.txtSelectedIndexValue.EditValue = ""
			Me.txtSelectedIndexValue.Location = New System.Drawing.Point(140, 116)
			Me.txtSelectedIndexValue.Name = "txtSelectedIndexValue"
			Me.txtSelectedIndexValue.Properties.ReadOnly = True
			Me.txtSelectedIndexValue.Size = New System.Drawing.Size(88, 20)
			Me.txtSelectedIndexValue.TabIndex = 3
			' 
			' lblCurrentItemDesc
			' 
			Me.lblCurrentItemDesc.Location = New System.Drawing.Point(20, 119)
			Me.lblCurrentItemDesc.Name = "lblCurrentItemDesc"
			Me.lblCurrentItemDesc.Size = New System.Drawing.Size(68, 13)
			Me.lblCurrentItemDesc.TabIndex = 10
			Me.lblCurrentItemDesc.Text = "Index / value:"
			' 
			' lblEditValue
			' 
			Me.lblEditValue.Location = New System.Drawing.Point(22, 90)
			Me.lblEditValue.Name = "lblEditValue"
			Me.lblEditValue.Size = New System.Drawing.Size(70, 13)
			Me.lblEditValue.TabIndex = 9
			Me.lblEditValue.Text = "Set edit value:"
			' 
			' spinSelectedIndex
			' 
			Me.spinSelectedIndex.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinSelectedIndex.Location = New System.Drawing.Point(140, 58)
			Me.spinSelectedIndex.Name = "spinSelectedIndex"
			Me.spinSelectedIndex.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinSelectedIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.spinSelectedIndex.Properties.IsFloatValue = False
			Me.spinSelectedIndex.Properties.Mask.EditMask = "N00"
			Me.spinSelectedIndex.Properties.MaxValue = New Decimal(New Integer() { 4, 0, 0, 0})
			Me.spinSelectedIndex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.spinSelectedIndex.Size = New System.Drawing.Size(88, 20)
			Me.spinSelectedIndex.TabIndex = 1
'			Me.spinSelectedIndex.EditValueChanged += New System.EventHandler(Me.spinSelectedIndex_EditValueChanged)
			' 
			' lblSelectedIndex
			' 
			Me.lblSelectedIndex.Location = New System.Drawing.Point(22, 61)
			Me.lblSelectedIndex.Name = "lblSelectedIndex"
			Me.lblSelectedIndex.Size = New System.Drawing.Size(74, 13)
			Me.lblSelectedIndex.TabIndex = 7
			Me.lblSelectedIndex.Text = "Selected index:"
			' 
			' checkEditAllowMnemonics
			' 
			Me.checkEditAllowMnemonics.Location = New System.Drawing.Point(20, 30)
			Me.checkEditAllowMnemonics.Name = "checkEditAllowMnemonics"
			Me.checkEditAllowMnemonics.Properties.Caption = "Allow mnemonics"
			Me.checkEditAllowMnemonics.Size = New System.Drawing.Size(200, 19)
			Me.checkEditAllowMnemonics.TabIndex = 0
'			Me.checkEditAllowMnemonics.CheckedChanged += New System.EventHandler(Me.checkEditAllowMnemonics_CheckedChanged)
			' 
			' comboSetEditValue
			' 
			Me.comboSetEditValue.EditValue = "Circle"
			Me.comboSetEditValue.Location = New System.Drawing.Point(140, 87)
			Me.comboSetEditValue.Name = "comboSetEditValue"
			Me.comboSetEditValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboSetEditValue.Properties.Items.AddRange(New Object() { "Circle", "Rectangle", "Ellipse", "Triangle", "Square", "Nothing"})
			Me.comboSetEditValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboSetEditValue.Size = New System.Drawing.Size(88, 20)
			Me.comboSetEditValue.TabIndex = 2
'			Me.comboSetEditValue.SelectedIndexChanged += New System.EventHandler(Me.comboSetEditValue_SelectedIndexChanged)
			' 
			' lblColumnCount
			' 
			Me.lblColumnCount.Location = New System.Drawing.Point(20, 33)
			Me.lblColumnCount.Name = "lblColumnCount"
			Me.lblColumnCount.Size = New System.Drawing.Size(69, 13)
			Me.lblColumnCount.TabIndex = 5
			Me.lblColumnCount.Text = "Column count:"
			' 
			' lblGlyphAlign
			' 
			Me.lblGlyphAlign.Location = New System.Drawing.Point(20, 63)
			Me.lblGlyphAlign.Name = "lblGlyphAlign"
			Me.lblGlyphAlign.Size = New System.Drawing.Size(80, 13)
			Me.lblGlyphAlign.TabIndex = 4
			Me.lblGlyphAlign.Text = "Glyph alignment:"
			' 
			' spinColumns
			' 
			Me.spinColumns.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinColumns.Location = New System.Drawing.Point(140, 30)
			Me.spinColumns.Name = "spinColumns"
			Me.spinColumns.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinColumns.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.spinColumns.Properties.IsFloatValue = False
			Me.spinColumns.Properties.Mask.EditMask = "N00"
			Me.spinColumns.Properties.MaxValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.spinColumns.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinColumns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.spinColumns.Size = New System.Drawing.Size(88, 20)
			Me.spinColumns.TabIndex = 0
'			Me.spinColumns.EditValueChanged += New System.EventHandler(Me.spinColumns_EditValueChanged)
			' 
			' comboGlyphAlign
			' 
			Me.comboGlyphAlign.EditValue = "Near"
			Me.comboGlyphAlign.Location = New System.Drawing.Point(140, 60)
			Me.comboGlyphAlign.Name = "comboGlyphAlign"
			Me.comboGlyphAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboGlyphAlign.Properties.Items.AddRange(New Object() { "Near", "Center", "Far"})
			Me.comboGlyphAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboGlyphAlign.Size = New System.Drawing.Size(88, 20)
			Me.comboGlyphAlign.TabIndex = 1
'			Me.comboGlyphAlign.SelectedIndexChanged += New System.EventHandler(Me.comboGlyphAlign_SelectedIndexChanged)
			' 
			' radioGroupSample
			' 
			Me.radioGroupSample.Location = New System.Drawing.Point(61, 87)
			Me.radioGroupSample.Name = "radioGroupSample"
			Me.radioGroupSample.Properties.Appearance.Options.UseTextOptions = True
			Me.radioGroupSample.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
			Me.radioGroupSample.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.radioGroupSample.Properties.Columns = 1
			Me.radioGroupSample.Size = New System.Drawing.Size(149, 178)
			Me.radioGroupSample.TabIndex = 0
'			Me.radioGroupSample.SelectedIndexChanged += New System.EventHandler(Me.radioGroupSample_SelectedIndexChanged)
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.lblGlyphAlign)
			Me.groupControl1.Controls.Add(Me.comboGlyphAlign)
			Me.groupControl1.Controls.Add(Me.lblColumnCount)
			Me.groupControl1.Controls.Add(Me.spinColumns)
			Me.groupControl1.Location = New System.Drawing.Point(348, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(248, 112)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Layout customization"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.txtSelectedIndexValue)
			Me.groupControl2.Controls.Add(Me.lblEditValue)
			Me.groupControl2.Controls.Add(Me.lblSelectedIndex)
			Me.groupControl2.Controls.Add(Me.spinSelectedIndex)
			Me.groupControl2.Controls.Add(Me.checkEditAllowMnemonics)
			Me.groupControl2.Controls.Add(Me.lblCurrentItemDesc)
			Me.groupControl2.Controls.Add(Me.comboSetEditValue)
			Me.groupControl2.Location = New System.Drawing.Point(348, 163)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(248, 157)
			Me.groupControl2.TabIndex = 2
			Me.groupControl2.Text = "Selected item management"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.btnClearItems)
			Me.groupControl3.Controls.Add(Me.btnPopulateItems)
			Me.groupControl3.Location = New System.Drawing.Point(348, 341)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(248, 70)
			Me.groupControl3.TabIndex = 3
			Me.groupControl3.Text = "Item collection management"
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(878, 592)
			Me.xtraTabControl1.TabIndex = 14
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl3)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(872, 586)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.radioGroupSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(287, 381)
			Me.panelControl1.TabIndex = 0
			Me.panelControl1.Text = "Sample"
			' 
			' ModuleRadioGroup
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleRadioGroup"
			Me.Size = New System.Drawing.Size(883, 597)
'			Me.Load += New System.EventHandler(Me.ModuleRadioGroup_Load)
			CType(Me.txtSelectedIndexValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinSelectedIndex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditAllowMnemonics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboSetEditValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboGlyphAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroupSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents radioGroupSample As DevExpress.XtraEditors.RadioGroup
		Private WithEvents comboGlyphAlign As DevExpress.XtraEditors.ComboBoxEdit
		Private lblGlyphAlign As DevExpress.XtraEditors.LabelControl
		Private lblColumnCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboSetEditValue As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEditAllowMnemonics As DevExpress.XtraEditors.CheckEdit
		Private lblSelectedIndex As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinSelectedIndex As DevExpress.XtraEditors.SpinEdit
		Private lblEditValue As DevExpress.XtraEditors.LabelControl
		Private lblCurrentItemDesc As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnClearItems As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnPopulateItems As DevExpress.XtraEditors.SimpleButton
		Private WithEvents spinColumns As DevExpress.XtraEditors.SpinEdit
		Private txtSelectedIndexValue As DevExpress.XtraEditors.TextEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
