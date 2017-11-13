Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleToggleSwitch
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.gcSampleCheckBox = New DevExpress.XtraEditors.GroupControl()
			Me.toggleSwitch = New DevExpress.XtraEditors.ToggleSwitch()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.tsAllowThumbAnimation = New DevExpress.XtraEditors.CheckEdit()
			Me.tsAllowHTMLString = New DevExpress.XtraEditors.CheckEdit()
			Me.tsAllowMnemonics = New DevExpress.XtraEditors.CheckEdit()
			Me.btnToggleState = New DevExpress.XtraEditors.SimpleButton()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.tsTextOff = New DevExpress.XtraEditors.TextEdit()
			Me.tsTextOn = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.comboAlign = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblCheckBoxAlign = New DevExpress.XtraEditors.LabelControl()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.gcSampleCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gcSampleCheckBox.SuspendLayout()
			CType(Me.toggleSwitch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.tsAllowThumbAnimation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tsAllowHTMLString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tsAllowMnemonics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.tsTextOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tsTextOn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(1019, 618)
			Me.xtraTabControl1.TabIndex = 5
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gcSampleCheckBox)
			Me.xtraTabPage1.Controls.Add(Me.groupControl3)
			Me.xtraTabPage1.Controls.Add(Me.groupControl5)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(1013, 590)
			Me.xtraTabPage1.Text = "ToggleSwitch States and Styles"
			' 
			' gcSampleCheckBox
			' 
			Me.gcSampleCheckBox.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.gcSampleCheckBox.Appearance.Options.UseBackColor = True
			Me.gcSampleCheckBox.Controls.Add(Me.toggleSwitch)
			Me.gcSampleCheckBox.Location = New System.Drawing.Point(30, 30)
			Me.gcSampleCheckBox.Name = "gcSampleCheckBox"
			Me.gcSampleCheckBox.Size = New System.Drawing.Size(303, 317)
			Me.gcSampleCheckBox.TabIndex = 0
			Me.gcSampleCheckBox.Text = "Sample"
			' 
			' toggleSwitch
			' 
			Me.toggleSwitch.Location = New System.Drawing.Point(45, 129)
			Me.toggleSwitch.Name = "toggleSwitch"
			Me.toggleSwitch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toggleSwitch.Properties.Appearance.Options.UseFont = True
			Me.toggleSwitch.Properties.AutoWidth = True
			Me.toggleSwitch.Properties.OffText = "Off"
			Me.toggleSwitch.Properties.OnText = "On"
			Me.toggleSwitch.Size = New System.Drawing.Size(202, 49)
			Me.toggleSwitch.TabIndex = 1
'			Me.toggleSwitch.Resize += New System.EventHandler(Me.tsResize)
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.tsAllowThumbAnimation)
			Me.groupControl3.Controls.Add(Me.tsAllowHTMLString)
			Me.groupControl3.Controls.Add(Me.tsAllowMnemonics)
			Me.groupControl3.Controls.Add(Me.btnToggleState)
			Me.groupControl3.Controls.Add(Me.label4)
			Me.groupControl3.Location = New System.Drawing.Point(364, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(265, 158)
			Me.groupControl3.TabIndex = 1
			Me.groupControl3.Text = "Toggle state"
			' 
			' tsAllowThumbAnimation
			' 
			Me.tsAllowThumbAnimation.EditValue = True
			Me.tsAllowThumbAnimation.Location = New System.Drawing.Point(20, 80)
			Me.tsAllowThumbAnimation.Name = "tsAllowThumbAnimation"
			Me.tsAllowThumbAnimation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.tsAllowThumbAnimation.Properties.Appearance.Options.UseBackColor = True
			Me.tsAllowThumbAnimation.Properties.Caption = "Allow Thumb Animation "
			Me.tsAllowThumbAnimation.Size = New System.Drawing.Size(232, 19)
			Me.tsAllowThumbAnimation.TabIndex = 5
'			Me.tsAllowThumbAnimation.CheckedChanged += New System.EventHandler(Me.tsAllowThumbAnimation_CheckedChanged)
			' 
			' tsAllowHTMLString
			' 
			Me.tsAllowHTMLString.Location = New System.Drawing.Point(20, 55)
			Me.tsAllowHTMLString.Name = "tsAllowHTMLString"
			Me.tsAllowHTMLString.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.tsAllowHTMLString.Properties.Appearance.Options.UseBackColor = True
			Me.tsAllowHTMLString.Properties.Caption = "Allow HTML Draw"
			Me.tsAllowHTMLString.Size = New System.Drawing.Size(232, 19)
			Me.tsAllowHTMLString.TabIndex = 2
'			Me.tsAllowHTMLString.CheckedChanged += New System.EventHandler(Me.tsAllowHTMLString_CheckedChanged)
			' 
			' tsAllowMnemonics
			' 
			Me.tsAllowMnemonics.Location = New System.Drawing.Point(20, 30)
			Me.tsAllowMnemonics.Name = "tsAllowMnemonics"
			Me.tsAllowMnemonics.Properties.Caption = "Allow mnemonics"
			Me.tsAllowMnemonics.Size = New System.Drawing.Size(232, 19)
			Me.tsAllowMnemonics.TabIndex = 0
'			Me.tsAllowMnemonics.CheckedChanged += New System.EventHandler(Me.tsAllowMnemonics_CheckedChanged)
			' 
			' btnToggleState
			' 
			Me.btnToggleState.Location = New System.Drawing.Point(100, 114)
			Me.btnToggleState.Name = "btnToggleState"
			Me.btnToggleState.Size = New System.Drawing.Size(140, 24)
			Me.btnToggleState.TabIndex = 4
			Me.btnToggleState.Text = "Toggle"
'			Me.btnToggleState.Click += New System.EventHandler(Me.btnToggleState_Click)
			' 
			' label4
			' 
			Me.label4.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label4.Location = New System.Drawing.Point(22, 119)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(44, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "On / Off:"
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.Controls.Add(Me.tsTextOff)
			Me.groupControl5.Controls.Add(Me.tsTextOn)
			Me.groupControl5.Controls.Add(Me.labelControl3)
			Me.groupControl5.Controls.Add(Me.labelControl2)
			Me.groupControl5.Controls.Add(Me.comboAlign)
			Me.groupControl5.Controls.Add(Me.lblCheckBoxAlign)
			Me.groupControl5.Location = New System.Drawing.Point(364, 209)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Size = New System.Drawing.Size(265, 138)
			Me.groupControl5.TabIndex = 2
			Me.groupControl5.Text = "Toggle properties"
			' 
			' tsTextOff
			' 
			Me.tsTextOff.EditValue = "Off"
			Me.tsTextOff.Location = New System.Drawing.Point(100, 64)
			Me.tsTextOff.Name = "tsTextOff"
			Me.tsTextOff.Size = New System.Drawing.Size(140, 20)
			Me.tsTextOff.TabIndex = 9
'			Me.tsTextOff.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.OffTextChanging)
			' 
			' tsTextOn
			' 
			Me.tsTextOn.EditValue = "On"
			Me.tsTextOn.Location = New System.Drawing.Point(100, 35)
			Me.tsTextOn.Name = "tsTextOn"
			Me.tsTextOn.Size = New System.Drawing.Size(140, 20)
			Me.tsTextOn.TabIndex = 8
'			Me.tsTextOn.EditValueChanging += New DevExpress.XtraEditors.Controls.ChangingEventHandler(Me.OnTextChanging)
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(22, 67)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(45, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "Text Off:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(22, 38)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(43, 13)
			Me.labelControl2.TabIndex = 6
			Me.labelControl2.Text = "Text On:"
			' 
			' comboAlign
			' 
			Me.comboAlign.EditValue = "Near"
			Me.comboAlign.Location = New System.Drawing.Point(100, 93)
			Me.comboAlign.Name = "comboAlign"
			Me.comboAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboAlign.Properties.Items.AddRange(New Object() { "Near", "Center", "Far"})
			Me.comboAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboAlign.Size = New System.Drawing.Size(140, 20)
			Me.comboAlign.TabIndex = 2
'			Me.comboAlign.SelectedIndexChanged += New System.EventHandler(Me.comboAlign_SelectedIndexChanged)
			' 
			' lblCheckBoxAlign
			' 
			Me.lblCheckBoxAlign.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lblCheckBoxAlign.Location = New System.Drawing.Point(22, 96)
			Me.lblCheckBoxAlign.Name = "lblCheckBoxAlign"
			Me.lblCheckBoxAlign.Size = New System.Drawing.Size(51, 13)
			Me.lblCheckBoxAlign.TabIndex = 1
			Me.lblCheckBoxAlign.Text = "Alignment:"
			' 
			' ModuleToggleSwitch
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleToggleSwitch"
			Me.Size = New System.Drawing.Size(1024, 623)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.gcSampleCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gcSampleCheckBox.ResumeLayout(False)
			CType(Me.toggleSwitch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.groupControl3.PerformLayout()
			CType(Me.tsAllowThumbAnimation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tsAllowHTMLString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tsAllowMnemonics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			Me.groupControl5.PerformLayout()
			CType(Me.tsTextOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tsTextOn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private gcSampleCheckBox As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents tsAllowHTMLString As DevExpress.XtraEditors.CheckEdit
		Private WithEvents tsAllowMnemonics As DevExpress.XtraEditors.CheckEdit
		Private WithEvents btnToggleState As DevExpress.XtraEditors.SimpleButton
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private WithEvents comboAlign As DevExpress.XtraEditors.ComboBoxEdit
		Private lblCheckBoxAlign As DevExpress.XtraEditors.LabelControl
		Private WithEvents toggleSwitch As DevExpress.XtraEditors.ToggleSwitch
		Private WithEvents tsTextOff As DevExpress.XtraEditors.TextEdit
		Private WithEvents tsTextOn As DevExpress.XtraEditors.TextEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents tsAllowThumbAnimation As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
