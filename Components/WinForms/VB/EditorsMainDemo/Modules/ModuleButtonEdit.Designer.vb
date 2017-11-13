Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleButtonEdit
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleButtonEdit))
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject7 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject8 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject9 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject10 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject11 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject12 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject13 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.xtraTabControlButtons = New DevExpress.XtraTab.XtraTabControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxTextEditStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.buttonEditSample = New DevExpress.XtraEditors.ButtonEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.meFiringEvents = New DevExpress.XtraEditors.MemoEdit()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.buttonEdit5 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit4 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit3 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit2 = New DevExpress.XtraEditors.ButtonEdit()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.xtraTabControlButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxTextEditStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.buttonEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.buttonEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(1060, 653)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(1054, 625)
			Me.xtraTabPage1.Text = "General"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.xtraTabControlButtons)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.comboBoxTextEditStyle)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(335, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(309, 399)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Appearance and buttons"
			' 
			' xtraTabControlButtons
			' 
			Me.xtraTabControlButtons.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True
			Me.xtraTabControlButtons.Location = New System.Drawing.Point(20, 89)
			Me.xtraTabControlButtons.Name = "xtraTabControlButtons"
			Me.xtraTabControlButtons.Size = New System.Drawing.Size(271, 292)
			Me.xtraTabControlButtons.TabIndex = 14
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 61)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(41, 13)
			Me.label1.TabIndex = 13
			Me.label1.Text = "Buttons:"
			' 
			' comboBoxTextEditStyle
			' 
			Me.comboBoxTextEditStyle.EditValue = ""
			Me.comboBoxTextEditStyle.Location = New System.Drawing.Point(120, 32)
			Me.comboBoxTextEditStyle.Name = "comboBoxTextEditStyle"
			Me.comboBoxTextEditStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxTextEditStyle.Properties.Items.AddRange(New Object() { "Standard", "HideTextEditor", "DisabledTextEditor"})
			Me.comboBoxTextEditStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxTextEditStyle.Size = New System.Drawing.Size(171, 20)
			Me.comboBoxTextEditStyle.TabIndex = 12
'			Me.comboBoxTextEditStyle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxTextEditStyle_SelectedIndexChanged)
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 35)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(73, 13)
			Me.lblSelect.TabIndex = 11
			Me.lblSelect.Text = "Text edit style:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.buttonEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(274, 399)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' buttonEditSample
			' 
			Me.buttonEditSample.EditValue = "Sample Button Edit"
			Me.buttonEditSample.Location = New System.Drawing.Point(28, 147)
			Me.buttonEditSample.Name = "buttonEditSample"
			Me.buttonEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
			Me.buttonEditSample.Size = New System.Drawing.Size(211, 20)
			Me.buttonEditSample.TabIndex = 0
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.groupControl5)
			Me.xtraTabPage2.Controls.Add(Me.groupControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(1054, 625)
			Me.xtraTabPage2.Text = "Button Samples"
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.Controls.Add(Me.meFiringEvents)
			Me.groupControl5.Location = New System.Drawing.Point(336, 30)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl5.Size = New System.Drawing.Size(304, 304)
			Me.groupControl5.TabIndex = 4
			Me.groupControl5.Text = "Button event log"
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
			Me.meFiringEvents.Size = New System.Drawing.Size(284, 265)
			Me.meFiringEvents.TabIndex = 0
			Me.meFiringEvents.UseOptimizedRendering = True
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.buttonEdit5)
			Me.groupControl2.Controls.Add(Me.buttonEdit4)
			Me.groupControl2.Controls.Add(Me.buttonEdit3)
			Me.groupControl2.Controls.Add(Me.buttonEdit2)
			Me.groupControl2.Controls.Add(Me.buttonEdit1)
			Me.groupControl2.Location = New System.Drawing.Point(30, 30)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(274, 304)
			Me.groupControl2.TabIndex = 2
			Me.groupControl2.Text = "Samples"
			' 
			' buttonEdit5
			' 
			Me.buttonEdit5.EditValue = "buttonEdit5"
			Me.buttonEdit5.Location = New System.Drawing.Point(20, 262)
			Me.buttonEdit5.Name = "buttonEdit5"
			Me.buttonEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Clear Event Log", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("buttonEdit5.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, False)})
			Me.buttonEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
'			Me.buttonEdit5.Properties.Click += New System.EventHandler(Me.buttonEdit5_Properties_Click)
			Me.buttonEdit5.Size = New System.Drawing.Size(227, 22)
			Me.buttonEdit5.TabIndex = 4
			' 
			' buttonEdit4
			' 
			Me.buttonEdit4.EditValue = "buttonEdit4"
			Me.buttonEdit4.Location = New System.Drawing.Point(20, 140)
			Me.buttonEdit4.Name = "buttonEdit4"
			Me.buttonEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("buttonEdit4.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Home", "Home button", Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("buttonEdit4.Properties.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Level Up", "LevelUp button", Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("buttonEdit4.Properties.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Back", "Back button", Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("buttonEdit4.Properties.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Forward", "Forward button", Nothing, False)})
			Me.buttonEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			Me.buttonEdit4.Size = New System.Drawing.Size(227, 22)
			Me.buttonEdit4.TabIndex = 3
'			Me.buttonEdit4.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonClick)
'			Me.buttonEdit4.ButtonPressed += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonPressed)
			' 
			' buttonEdit3
			' 
			Me.buttonEdit3.EditValue = "with caption"
			Me.buttonEdit3.Location = New System.Drawing.Point(20, 104)
			Me.buttonEdit3.Name = "buttonEdit3"
			Me.buttonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("buttonEdit3.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", "Open button", Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Close", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleLeft, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", "Close button", Nothing, False)})
			Me.buttonEdit3.Size = New System.Drawing.Size(227, 22)
			Me.buttonEdit3.TabIndex = 2
'			Me.buttonEdit3.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonClick)
'			Me.buttonEdit3.ButtonPressed += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonPressed)
			' 
			' buttonEdit2
			' 
			Me.buttonEdit2.EditValue = "disabled button"
			Me.buttonEdit2.Location = New System.Drawing.Point(20, 72)
			Me.buttonEdit2.Name = "buttonEdit2"
			Me.buttonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", "Ellipsis button", Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "", "Undo button", Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "", "Redo button", Nothing, False)})
			Me.buttonEdit2.Size = New System.Drawing.Size(227, 20)
			Me.buttonEdit2.TabIndex = 1
'			Me.buttonEdit2.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonClick)
'			Me.buttonEdit2.ButtonPressed += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonPressed)
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.EditValue = ""
			Me.buttonEdit1.Location = New System.Drawing.Point(20, 40)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject12, "", "Left button", Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, "", "Right button", Nothing, True)})
			Me.buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.buttonEdit1.Size = New System.Drawing.Size(227, 20)
			Me.buttonEdit1.TabIndex = 0
'			Me.buttonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit_ButtonClick)
'			Me.buttonEdit1.ButtonPressed += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_ButtonPressed)
			' 
			' ModuleButtonEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleButtonEdit"
			Me.Size = New System.Drawing.Size(1065, 658)
'			Me.Load += New System.EventHandler(Me.ModuleButtonEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.xtraTabControlButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxTextEditStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.buttonEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.buttonEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private buttonEditSample As DevExpress.XtraEditors.ButtonEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents comboBoxTextEditStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private xtraTabControlButtons As DevExpress.XtraTab.XtraTabControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents buttonEdit2 As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents buttonEdit3 As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents buttonEdit4 As DevExpress.XtraEditors.ButtonEdit
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private meFiringEvents As DevExpress.XtraEditors.MemoEdit
		Private WithEvents buttonEdit5 As DevExpress.XtraEditors.ButtonEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
