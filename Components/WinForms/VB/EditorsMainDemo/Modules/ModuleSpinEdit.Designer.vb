Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleSpinEdit
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.gcSample = New DevExpress.XtraEditors.GroupControl()
			Me.spinEditSample1 = New DevExpress.XtraEditors.SpinEdit()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.checkEditFloatValue = New DevExpress.XtraEditors.CheckEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.comboIncrementValue = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboMaxMin = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEditButtonPos = New DevExpress.XtraEditors.SpinEdit()
			Me.checkEditAdditionalButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.comboSpinStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.meFiringEvents = New DevExpress.XtraEditors.MemoEdit()
			Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
			Me.checkEditValidate = New DevExpress.XtraEditors.CheckEdit()
			Me.comboFiringMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label5 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.spinEditSample2 = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.gcSample, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gcSample.SuspendLayout()
			CType(Me.spinEditSample1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.checkEditFloatValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboIncrementValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboMaxMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.spinEditButtonPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditAdditionalButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboSpinStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl4.SuspendLayout()
			CType(Me.checkEditValidate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboFiringMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.spinEditSample2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(874, 585)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gcSample)
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(868, 557)
			Me.xtraTabPage1.Text = "General"
			' 
			' gcSample
			' 
			Me.gcSample.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.gcSample.Appearance.Options.UseBackColor = True
			Me.gcSample.Controls.Add(Me.spinEditSample1)
			Me.gcSample.Location = New System.Drawing.Point(30, 30)
			Me.gcSample.Name = "gcSample"
			Me.gcSample.Size = New System.Drawing.Size(202, 277)
			Me.gcSample.TabIndex = 0
			Me.gcSample.Text = "Sample"
			' 
			' spinEditSample1
			' 
			Me.spinEditSample1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEditSample1.Location = New System.Drawing.Point(25, 93)
			Me.spinEditSample1.Name = "spinEditSample1"
			Me.spinEditSample1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "0", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, False)})
			Me.spinEditSample1.Properties.Increment = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinEditSample1.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.spinEditSample1.Properties.MinValue = New Decimal(New Integer() { 1000, 0, 0, -2147483648})
			Me.spinEditSample1.Size = New System.Drawing.Size(143, 20)
			Me.spinEditSample1.TabIndex = 0
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.checkEditFloatValue)
			Me.groupControl2.Controls.Add(Me.label4)
			Me.groupControl2.Controls.Add(Me.label3)
			Me.groupControl2.Controls.Add(Me.comboIncrementValue)
			Me.groupControl2.Controls.Add(Me.comboMaxMin)
			Me.groupControl2.Location = New System.Drawing.Point(263, 30)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(257, 131)
			Me.groupControl2.TabIndex = 1
			Me.groupControl2.Text = "Edit value management"
			' 
			' checkEditFloatValue
			' 
			Me.checkEditFloatValue.EditValue = True
			Me.checkEditFloatValue.Location = New System.Drawing.Point(18, 90)
			Me.checkEditFloatValue.Name = "checkEditFloatValue"
			Me.checkEditFloatValue.Properties.Caption = "Is float value"
			Me.checkEditFloatValue.Size = New System.Drawing.Size(224, 19)
			Me.checkEditFloatValue.TabIndex = 3
'			Me.checkEditFloatValue.CheckedChanged += New System.EventHandler(Me.checkEditFloatValue_CheckedChanged)
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 64)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(53, 13)
			Me.label4.TabIndex = 4
			Me.label4.Text = "Increment:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 35)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(50, 13)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Min / max:"
			' 
			' comboIncrementValue
			' 
			Me.comboIncrementValue.EditValue = "10"
			Me.comboIncrementValue.Location = New System.Drawing.Point(136, 61)
			Me.comboIncrementValue.Name = "comboIncrementValue"
			Me.comboIncrementValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboIncrementValue.Properties.Items.AddRange(New Object() { "10", "1", "0.5", "0.1"})
			Me.comboIncrementValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboIncrementValue.Size = New System.Drawing.Size(100, 20)
			Me.comboIncrementValue.TabIndex = 1
'			Me.comboIncrementValue.SelectedIndexChanged += New System.EventHandler(Me.comboIncrementValue_SelectedIndexChanged)
			' 
			' comboMaxMin
			' 
			Me.comboMaxMin.EditValue = "-1000 / 1000"
			Me.comboMaxMin.Location = New System.Drawing.Point(136, 32)
			Me.comboMaxMin.Name = "comboMaxMin"
			Me.comboMaxMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboMaxMin.Properties.Items.AddRange(New Object() { "-1000 / 1000", "10 / 99", "0 / 12.5"})
			Me.comboMaxMin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboMaxMin.Size = New System.Drawing.Size(100, 20)
			Me.comboMaxMin.TabIndex = 0
'			Me.comboMaxMin.SelectedIndexChanged += New System.EventHandler(Me.comboMaxMin_SelectedIndexChanged)
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Controls.Add(Me.spinEditButtonPos)
			Me.groupControl1.Controls.Add(Me.checkEditAdditionalButtons)
			Me.groupControl1.Controls.Add(Me.comboSpinStyle)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Location = New System.Drawing.Point(263, 182)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(257, 125)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Spin button management"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(22, 60)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(99, 13)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Spin button position:"
			' 
			' spinEditButtonPos
			' 
			Me.spinEditButtonPos.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEditButtonPos.Location = New System.Drawing.Point(136, 57)
			Me.spinEditButtonPos.Name = "spinEditButtonPos"
			Me.spinEditButtonPos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "0", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, False)})
			Me.spinEditButtonPos.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.spinEditButtonPos.Properties.IsFloatValue = False
			Me.spinEditButtonPos.Properties.Mask.EditMask = "N00"
			Me.spinEditButtonPos.Properties.MaxValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.spinEditButtonPos.Size = New System.Drawing.Size(100, 20)
			Me.spinEditButtonPos.TabIndex = 3
'			Me.spinEditButtonPos.EditValueChanged += New System.EventHandler(Me.spinEditButtonPos_EditValueChanged)
			' 
			' checkEditAdditionalButtons
			' 
			Me.checkEditAdditionalButtons.Location = New System.Drawing.Point(20, 32)
			Me.checkEditAdditionalButtons.Name = "checkEditAdditionalButtons"
			Me.checkEditAdditionalButtons.Properties.Caption = "Show additional buttons"
			Me.checkEditAdditionalButtons.Size = New System.Drawing.Size(220, 19)
			Me.checkEditAdditionalButtons.TabIndex = 2
'			Me.checkEditAdditionalButtons.CheckedChanged += New System.EventHandler(Me.checkEditAdditionalButtons_CheckedChanged)
			' 
			' comboSpinStyle
			' 
			Me.comboSpinStyle.EditValue = "Vertical"
			Me.comboSpinStyle.Location = New System.Drawing.Point(136, 85)
			Me.comboSpinStyle.Name = "comboSpinStyle"
			Me.comboSpinStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboSpinStyle.Properties.Items.AddRange(New Object() { "Vertical", "Horizontal"})
			Me.comboSpinStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboSpinStyle.Size = New System.Drawing.Size(100, 20)
			Me.comboSpinStyle.TabIndex = 4
'			Me.comboSpinStyle.SelectedIndexChanged += New System.EventHandler(Me.comboSpinStyle_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(22, 88)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(50, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Spin style:"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.groupControl5)
			Me.xtraTabPage2.Controls.Add(Me.groupControl4)
			Me.xtraTabPage2.Controls.Add(Me.groupControl3)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(868, 557)
			Me.xtraTabPage2.Text = "Firing Events"
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.Controls.Add(Me.meFiringEvents)
			Me.groupControl5.Location = New System.Drawing.Point(263, 155)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl5.Size = New System.Drawing.Size(304, 122)
			Me.groupControl5.TabIndex = 3
			Me.groupControl5.Text = "Events firing"
			' 
			' meFiringEvents
			' 
			Me.meFiringEvents.Dock = System.Windows.Forms.DockStyle.Fill
			Me.meFiringEvents.EditValue = ""
			Me.meFiringEvents.Location = New System.Drawing.Point(10, 29)
			Me.meFiringEvents.Name = "meFiringEvents"
			Me.meFiringEvents.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.meFiringEvents.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.meFiringEvents.Properties.Appearance.Options.UseBackColor = True
			Me.meFiringEvents.Properties.Appearance.Options.UseForeColor = True
			Me.meFiringEvents.Properties.ReadOnly = True
			Me.meFiringEvents.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.meFiringEvents.Size = New System.Drawing.Size(284, 83)
			Me.meFiringEvents.TabIndex = 0
			Me.meFiringEvents.UseOptimizedRendering = True
			' 
			' groupControl4
			' 
			Me.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl4.Appearance.Options.UseBackColor = True
			Me.groupControl4.Controls.Add(Me.checkEditValidate)
			Me.groupControl4.Controls.Add(Me.comboFiringMode)
			Me.groupControl4.Controls.Add(Me.label5)
			Me.groupControl4.Location = New System.Drawing.Point(263, 30)
			Me.groupControl4.Name = "groupControl4"
			Me.groupControl4.Size = New System.Drawing.Size(304, 103)
			Me.groupControl4.TabIndex = 2
			Me.groupControl4.Text = "Events properties"
			' 
			' checkEditValidate
			' 
			Me.checkEditValidate.Location = New System.Drawing.Point(18, 61)
			Me.checkEditValidate.Name = "checkEditValidate"
			Me.checkEditValidate.Properties.Caption = "Validate on ENTER key"
			Me.checkEditValidate.Size = New System.Drawing.Size(168, 19)
			Me.checkEditValidate.TabIndex = 7
'			Me.checkEditValidate.CheckedChanged += New System.EventHandler(Me.checkEditValidate_CheckedChanged)
			' 
			' comboFiringMode
			' 
			Me.comboFiringMode.EditValue = "Buffered"
			Me.comboFiringMode.Location = New System.Drawing.Point(192, 32)
			Me.comboFiringMode.Name = "comboFiringMode"
			Me.comboFiringMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboFiringMode.Properties.Items.AddRange(New Object() { "Buffered", "Default"})
			Me.comboFiringMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboFiringMode.Size = New System.Drawing.Size(100, 20)
			Me.comboFiringMode.TabIndex = 6
'			Me.comboFiringMode.SelectedIndexChanged += New System.EventHandler(Me.comboFiringMode_SelectedIndexChanged)
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(20, 35)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(147, 13)
			Me.label5.TabIndex = 4
			Me.label5.Text = "EditValueChanged firing mode:"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.spinEditSample2)
			Me.groupControl3.Location = New System.Drawing.Point(30, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(202, 247)
			Me.groupControl3.TabIndex = 1
			Me.groupControl3.Text = "Sample"
			' 
			' spinEditSample2
			' 
			Me.spinEditSample2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEditSample2.Location = New System.Drawing.Point(20, 70)
			Me.spinEditSample2.Name = "spinEditSample2"
			Me.spinEditSample2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "0", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, False)})
			Me.spinEditSample2.Size = New System.Drawing.Size(153, 20)
			Me.spinEditSample2.TabIndex = 0
'			Me.spinEditSample2.EditValueChanged += New System.EventHandler(Me.spinEditSample2_EditValueChanged)
'			Me.spinEditSample2.Validated += New System.EventHandler(Me.spinEditSample2_Validated)
			' 
			' ModuleSpinEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleSpinEdit"
			Me.Size = New System.Drawing.Size(879, 590)
'			Me.Load += New System.EventHandler(Me.ModuleSpinEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.gcSample, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gcSample.ResumeLayout(False)
			CType(Me.spinEditSample1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.checkEditFloatValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboIncrementValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboMaxMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.spinEditButtonPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditAdditionalButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboSpinStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl4.ResumeLayout(False)
			Me.groupControl4.PerformLayout()
			CType(Me.checkEditValidate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboFiringMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.spinEditSample2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboSpinStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEditAdditionalButtons As DevExpress.XtraEditors.CheckEdit
		Private WithEvents spinEditButtonPos As DevExpress.XtraEditors.SpinEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents comboMaxMin As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents comboIncrementValue As DevExpress.XtraEditors.ComboBoxEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private gcSample As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkEditFloatValue As DevExpress.XtraEditors.CheckEdit
		Private spinEditSample1 As DevExpress.XtraEditors.SpinEdit
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents spinEditSample2 As DevExpress.XtraEditors.SpinEdit
		Private groupControl4 As DevExpress.XtraEditors.GroupControl
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboFiringMode As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEditValidate As DevExpress.XtraEditors.CheckEdit
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private meFiringEvents As DevExpress.XtraEditors.MemoEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
