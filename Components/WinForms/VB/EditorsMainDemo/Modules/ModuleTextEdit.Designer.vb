Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTextEdit
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
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.textEditSample = New DevExpress.XtraEditors.TextEdit()
			Me.checkEditHideSelection = New DevExpress.XtraEditors.CheckEdit()
			Me.comboBoxPasswordChar = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxSelectCase = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.tabctrlTextEdit = New DevExpress.XtraTab.XtraTabControl()
			Me.tabpgGeneral = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.buttonsSelection = New DevExpress.XtraEditors.ButtonEdit()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.tabpgFormatting = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
			Me.comboDateFormat = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblDateEditValue = New DevExpress.XtraEditors.LabelControl()
			Me.dateEdit = New DevExpress.XtraEditors.DateEdit()
			Me.lblDateFormatType = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.textEditDate = New DevExpress.XtraEditors.TextEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.lblDecimalPlaces = New DevExpress.XtraEditors.LabelControl()
			Me.lblNumFormatType = New DevExpress.XtraEditors.LabelControl()
			Me.spinEditDecimalPlaces = New DevExpress.XtraEditors.SpinEdit()
			Me.comboNumericFormat = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboNumericEditValue = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblNumEditValue = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.textEditNumeric = New DevExpress.XtraEditors.TextEdit()
			CType(Me.textEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditHideSelection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxPasswordChar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxSelectCase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabctrlTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabctrlTextEdit.SuspendLayout()
			Me.tabpgGeneral.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.buttonsSelection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			Me.tabpgFormatting.SuspendLayout()
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl4.SuspendLayout()
			CType(Me.comboDateFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl3.SuspendLayout()
			CType(Me.textEditDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.spinEditDecimalPlaces.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboNumericFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboNumericEditValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.textEditNumeric.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEditSample
			' 
			Me.textEditSample.EditValue = "Sample Text"
			Me.textEditSample.Location = New System.Drawing.Point(20, 72)
			Me.textEditSample.Name = "textEditSample"
			Me.textEditSample.Properties.HideSelection = False
			Me.textEditSample.Size = New System.Drawing.Size(205, 20)
			Me.textEditSample.TabIndex = 1
			' 
			' checkEditHideSelection
			' 
			Me.checkEditHideSelection.Location = New System.Drawing.Point(18, 64)
			Me.checkEditHideSelection.Name = "checkEditHideSelection"
			Me.checkEditHideSelection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.checkEditHideSelection.Properties.Appearance.Options.UseBackColor = True
			Me.checkEditHideSelection.Properties.Caption = "Hide selection"
			Me.checkEditHideSelection.Size = New System.Drawing.Size(176, 19)
			Me.checkEditHideSelection.TabIndex = 1
'			Me.checkEditHideSelection.CheckedChanged += New System.EventHandler(Me.checkEditHideSelection_CheckedChanged)
			' 
			' comboBoxPasswordChar
			' 
			Me.comboBoxPasswordChar.EditValue = ""
			Me.comboBoxPasswordChar.Location = New System.Drawing.Point(104, 61)
			Me.comboBoxPasswordChar.Name = "comboBoxPasswordChar"
			Me.comboBoxPasswordChar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxPasswordChar.Properties.Items.AddRange(New Object() { "", "*", "#"})
			Me.comboBoxPasswordChar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxPasswordChar.Size = New System.Drawing.Size(113, 20)
			Me.comboBoxPasswordChar.TabIndex = 1
'			Me.comboBoxPasswordChar.SelectedIndexChanged += New System.EventHandler(Me.comboBoxPasswordChar_SelectedIndexChanged)
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 64)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(74, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Password char:"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 37)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(57, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Case mode:"
			' 
			' comboBoxSelectCase
			' 
			Me.comboBoxSelectCase.EditValue = "Normal"
			Me.comboBoxSelectCase.Location = New System.Drawing.Point(104, 32)
			Me.comboBoxSelectCase.Name = "comboBoxSelectCase"
			Me.comboBoxSelectCase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxSelectCase.Properties.Items.AddRange(New Object() { "Normal", "Upper", "Lower"})
			Me.comboBoxSelectCase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxSelectCase.Size = New System.Drawing.Size(113, 20)
			Me.comboBoxSelectCase.TabIndex = 0
'			Me.comboBoxSelectCase.SelectedIndexChanged += New System.EventHandler(Me.comboBoxSelectCase_SelectedIndexChanged)
			' 
			' tabctrlTextEdit
			' 
			Me.tabctrlTextEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabctrlTextEdit.Location = New System.Drawing.Point(5, 0)
			Me.tabctrlTextEdit.Name = "tabctrlTextEdit"
			Me.tabctrlTextEdit.SelectedTabPage = Me.tabpgGeneral
			Me.tabctrlTextEdit.Size = New System.Drawing.Size(1085, 683)
			Me.tabctrlTextEdit.TabIndex = 6
			Me.tabctrlTextEdit.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tabpgGeneral, Me.tabpgFormatting})
			' 
			' tabpgGeneral
			' 
			Me.tabpgGeneral.Controls.Add(Me.panelControl1)
			Me.tabpgGeneral.Controls.Add(Me.groupControl3)
			Me.tabpgGeneral.Controls.Add(Me.groupControl2)
			Me.tabpgGeneral.Name = "tabpgGeneral"
			Me.tabpgGeneral.Size = New System.Drawing.Size(1079, 655)
			Me.tabpgGeneral.Text = "General"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.textEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(266, 236)
			Me.panelControl1.TabIndex = 0
			Me.panelControl1.Text = "Sample"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.lblSelect)
			Me.groupControl3.Controls.Add(Me.checkEditHideSelection)
			Me.groupControl3.Controls.Add(Me.buttonsSelection)
			Me.groupControl3.Location = New System.Drawing.Point(327, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(234, 104)
			Me.groupControl3.TabIndex = 1
			Me.groupControl3.Text = "Selection management"
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 37)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(33, 13)
			Me.lblSelect.TabIndex = 10
			Me.lblSelect.Text = "Select:"
			' 
			' buttonsSelection
			' 
			Me.buttonsSelection.EditValue = "buttonEdit1"
			Me.buttonsSelection.Location = New System.Drawing.Point(77, 35)
			Me.buttonsSelection.Name = "buttonsSelection"
			Me.buttonsSelection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "All", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Random", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Clear", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", Nothing, Nothing, False)})
			Me.buttonsSelection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			Me.buttonsSelection.Size = New System.Drawing.Size(140, 20)
			Me.buttonsSelection.TabIndex = 0
'			Me.buttonsSelection.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonsSelection_ButtonClick)
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.label2)
			Me.groupControl2.Controls.Add(Me.label1)
			Me.groupControl2.Controls.Add(Me.comboBoxPasswordChar)
			Me.groupControl2.Controls.Add(Me.comboBoxSelectCase)
			Me.groupControl2.Location = New System.Drawing.Point(327, 155)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(234, 111)
			Me.groupControl2.TabIndex = 2
			Me.groupControl2.Text = "Formatting basics"
			' 
			' tabpgFormatting
			' 
			Me.tabpgFormatting.Controls.Add(Me.groupControl4)
			Me.tabpgFormatting.Controls.Add(Me.panelControl3)
			Me.tabpgFormatting.Controls.Add(Me.groupControl1)
			Me.tabpgFormatting.Controls.Add(Me.panelControl2)
			Me.tabpgFormatting.Name = "tabpgFormatting"
			Me.tabpgFormatting.Size = New System.Drawing.Size(1079, 655)
			Me.tabpgFormatting.Text = "Formatting and Parsing"
			' 
			' groupControl4
			' 
			Me.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl4.Appearance.Options.UseBackColor = True
			Me.groupControl4.Controls.Add(Me.comboDateFormat)
			Me.groupControl4.Controls.Add(Me.lblDateEditValue)
			Me.groupControl4.Controls.Add(Me.dateEdit)
			Me.groupControl4.Controls.Add(Me.lblDateFormatType)
			Me.groupControl4.Location = New System.Drawing.Point(327, 213)
			Me.groupControl4.Name = "groupControl4"
			Me.groupControl4.Size = New System.Drawing.Size(267, 109)
			Me.groupControl4.TabIndex = 3
			Me.groupControl4.Text = "Date and time formatting"
			' 
			' comboDateFormat
			' 
			Me.comboDateFormat.EditValue = "No formatting"
			Me.comboDateFormat.Location = New System.Drawing.Point(113, 32)
			Me.comboDateFormat.Name = "comboDateFormat"
			Me.comboDateFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboDateFormat.Properties.DropDownRows = 10
			Me.comboDateFormat.Properties.Items.AddRange(New Object() { "No formatting", "Short date", "Long date", "Short time", "Long time", "Full date/time", "General date/time", "Sortable date/time"})
			Me.comboDateFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboDateFormat.Size = New System.Drawing.Size(128, 20)
			Me.comboDateFormat.TabIndex = 0
'			Me.comboDateFormat.SelectedIndexChanged += New System.EventHandler(Me.comboDateFormat_SelectedIndexChanged)
			' 
			' lblDateEditValue
			' 
			Me.lblDateEditValue.Location = New System.Drawing.Point(20, 64)
			Me.lblDateEditValue.Name = "lblDateEditValue"
			Me.lblDateEditValue.Size = New System.Drawing.Size(51, 13)
			Me.lblDateEditValue.TabIndex = 18
			Me.lblDateEditValue.Text = "Edit value:"
			' 
			' dateEdit
			' 
			Me.dateEdit.EditValue = New Date(2004, 11, 9, 0, 0, 0, 0)
			Me.dateEdit.Location = New System.Drawing.Point(113, 61)
			Me.dateEdit.Name = "dateEdit"
			Me.dateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit.Properties.ValidateOnEnterKey = True
			Me.dateEdit.Size = New System.Drawing.Size(128, 20)
			Me.dateEdit.TabIndex = 1
'			Me.dateEdit.EditValueChanged += New System.EventHandler(Me.dateEdit_EditValueChanged)
			' 
			' lblDateFormatType
			' 
			Me.lblDateFormatType.Location = New System.Drawing.Point(20, 35)
			Me.lblDateFormatType.Name = "lblDateFormatType"
			Me.lblDateFormatType.Size = New System.Drawing.Size(63, 13)
			Me.lblDateFormatType.TabIndex = 17
			Me.lblDateFormatType.Text = "Format type:"
			' 
			' panelControl3
			' 
			Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl3.Appearance.Options.UseBackColor = True
			Me.panelControl3.Controls.Add(Me.textEditDate)
			Me.panelControl3.Location = New System.Drawing.Point(30, 213)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Size = New System.Drawing.Size(266, 109)
			Me.panelControl3.TabIndex = 2
			Me.panelControl3.Text = "Date and time sample"
			' 
			' textEditDate
			' 
			Me.textEditDate.EditValue = New Date(2005, 1, 1, 17, 37, 28, 0)
			Me.textEditDate.Location = New System.Drawing.Point(20, 48)
			Me.textEditDate.Name = "textEditDate"
			Me.textEditDate.Properties.ReadOnly = True
			Me.textEditDate.Size = New System.Drawing.Size(225, 20)
			Me.textEditDate.TabIndex = 0
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.lblDecimalPlaces)
			Me.groupControl1.Controls.Add(Me.lblNumFormatType)
			Me.groupControl1.Controls.Add(Me.spinEditDecimalPlaces)
			Me.groupControl1.Controls.Add(Me.comboNumericFormat)
			Me.groupControl1.Controls.Add(Me.comboNumericEditValue)
			Me.groupControl1.Controls.Add(Me.lblNumEditValue)
			Me.groupControl1.Location = New System.Drawing.Point(327, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(267, 162)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Numeric formatting"
			' 
			' lblDecimalPlaces
			' 
			Me.lblDecimalPlaces.Location = New System.Drawing.Point(20, 64)
			Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
			Me.lblDecimalPlaces.Size = New System.Drawing.Size(73, 13)
			Me.lblDecimalPlaces.TabIndex = 17
			Me.lblDecimalPlaces.Text = "Decimal places:"
			' 
			' lblNumFormatType
			' 
			Me.lblNumFormatType.Location = New System.Drawing.Point(20, 35)
			Me.lblNumFormatType.Name = "lblNumFormatType"
			Me.lblNumFormatType.Size = New System.Drawing.Size(63, 13)
			Me.lblNumFormatType.TabIndex = 13
			Me.lblNumFormatType.Text = "Format type:"
			' 
			' spinEditDecimalPlaces
			' 
			Me.spinEditDecimalPlaces.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEditDecimalPlaces.Location = New System.Drawing.Point(113, 61)
			Me.spinEditDecimalPlaces.Name = "spinEditDecimalPlaces"
			Me.spinEditDecimalPlaces.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEditDecimalPlaces.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.spinEditDecimalPlaces.Properties.IsFloatValue = False
			Me.spinEditDecimalPlaces.Properties.Mask.EditMask = "N00"
			Me.spinEditDecimalPlaces.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinEditDecimalPlaces.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.spinEditDecimalPlaces.Size = New System.Drawing.Size(128, 20)
			Me.spinEditDecimalPlaces.TabIndex = 1
'			Me.spinEditDecimalPlaces.EditValueChanged += New System.EventHandler(Me.spinEditDecimalPlaces_EditValueChanged)
			' 
			' comboNumericFormat
			' 
			Me.comboNumericFormat.EditValue = "No formatting"
			Me.comboNumericFormat.Location = New System.Drawing.Point(113, 32)
			Me.comboNumericFormat.Name = "comboNumericFormat"
			Me.comboNumericFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboNumericFormat.Properties.Items.AddRange(New Object() {"No formatting", "Currency", "Fixed-point", "Scientific", "Percent", "Hexadecimal"})
			Me.comboNumericFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboNumericFormat.Size = New System.Drawing.Size(128, 20)
			Me.comboNumericFormat.TabIndex = 0
'			Me.comboNumericFormat.SelectedIndexChanged += New System.EventHandler(Me.comboNumericFormat_SelectedIndexChanged)
			' 
			' comboNumericEditValue
			' 
			Me.comboNumericEditValue.EditValue = ""
			Me.comboNumericEditValue.Location = New System.Drawing.Point(113, 90)
			Me.comboNumericEditValue.Name = "comboNumericEditValue"
			Me.comboNumericEditValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboNumericEditValue.Properties.Items.AddRange(New Object() { "0.5", "1", "123.45", "-12.34", "100"})
			Me.comboNumericEditValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboNumericEditValue.Size = New System.Drawing.Size(128, 20)
			Me.comboNumericEditValue.TabIndex = 2
'			Me.comboNumericEditValue.SelectedIndexChanged += New System.EventHandler(Me.comboNumericEditValue_SelectedIndexChanged)
			' 
			' lblNumEditValue
			' 
			Me.lblNumEditValue.Location = New System.Drawing.Point(20, 93)
			Me.lblNumEditValue.Name = "lblNumEditValue"
			Me.lblNumEditValue.Size = New System.Drawing.Size(51, 13)
			Me.lblNumEditValue.TabIndex = 15
			Me.lblNumEditValue.Text = "Edit value:"
			' 
			' panelControl2
			' 
			Me.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl2.Appearance.Options.UseBackColor = True
			Me.panelControl2.Controls.Add(Me.textEditNumeric)
			Me.panelControl2.Location = New System.Drawing.Point(30, 30)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(266, 162)
			Me.panelControl2.TabIndex = 0
			Me.panelControl2.Text = "Numeric sample"
			' 
			' textEditNumeric
			' 
			Me.textEditNumeric.EditValue = 1
			Me.textEditNumeric.Location = New System.Drawing.Point(20, 44)
			Me.textEditNumeric.Name = "textEditNumeric"
			Me.textEditNumeric.Properties.ReadOnly = True
			Me.textEditNumeric.Size = New System.Drawing.Size(225, 20)
			Me.textEditNumeric.TabIndex = 0
			' 
			' ModuleTextEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tabctrlTextEdit)
			Me.Name = "ModuleTextEdit"
			Me.Size = New System.Drawing.Size(1090, 688)
'			Me.Load += New System.EventHandler(Me.ModuleTextEdit_Load)
			CType(Me.textEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditHideSelection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxPasswordChar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxSelectCase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabctrlTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabctrlTextEdit.ResumeLayout(False)
			Me.tabpgGeneral.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.groupControl3.PerformLayout()
			CType(Me.buttonsSelection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			Me.tabpgFormatting.ResumeLayout(False)
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl4.ResumeLayout(False)
			Me.groupControl4.PerformLayout()
			CType(Me.comboDateFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl3.ResumeLayout(False)
			CType(Me.textEditDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.spinEditDecimalPlaces.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboNumericFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboNumericEditValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.textEditNumeric.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private textEditSample As DevExpress.XtraEditors.TextEdit
		Private WithEvents checkEditHideSelection As DevExpress.XtraEditors.CheckEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxSelectCase As DevExpress.XtraEditors.ComboBoxEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxPasswordChar As DevExpress.XtraEditors.ComboBoxEdit
		Private tabctrlTextEdit As DevExpress.XtraTab.XtraTabControl
		Private tabpgGeneral As DevExpress.XtraTab.XtraTabPage
		Private tabpgFormatting As DevExpress.XtraTab.XtraTabPage
		Private WithEvents comboNumericFormat As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents comboNumericEditValue As DevExpress.XtraEditors.ComboBoxEdit
		Private textEditNumeric As DevExpress.XtraEditors.TextEdit
		Private WithEvents spinEditDecimalPlaces As DevExpress.XtraEditors.SpinEdit
		Private lblDecimalPlaces As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboDateFormat As DevExpress.XtraEditors.ComboBoxEdit
		Private lblNumFormatType As DevExpress.XtraEditors.LabelControl
		Private textEditDate As DevExpress.XtraEditors.TextEdit
		Private lblDateFormatType As DevExpress.XtraEditors.LabelControl
		Private lblNumEditValue As DevExpress.XtraEditors.LabelControl
		Private lblDateEditValue As DevExpress.XtraEditors.LabelControl
		Private WithEvents dateEdit As DevExpress.XtraEditors.DateEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private WithEvents buttonsSelection As DevExpress.XtraEditors.ButtonEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private panelControl2 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private panelControl3 As DevExpress.XtraEditors.GroupControl
		Private groupControl4 As DevExpress.XtraEditors.GroupControl

	End Class
End Namespace
