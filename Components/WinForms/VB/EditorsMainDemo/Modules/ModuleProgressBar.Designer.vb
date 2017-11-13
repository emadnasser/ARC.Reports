Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleProgressBar
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
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.progressBarSample = New DevExpress.XtraEditors.ProgressBarControl()
            Me.lblStartColor = New DevExpress.XtraEditors.LabelControl()
            Me.colorEditStartColor = New DevExpress.XtraEditors.ColorEdit()
            Me.colorEditEndColor = New DevExpress.XtraEditors.ColorEdit()
            Me.btnApplyColors = New DevExpress.XtraEditors.SimpleButton()
            Me.comboBoxProgressStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblBarStyle = New DevExpress.XtraEditors.LabelControl()
            Me.checkEditVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditShowText = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditShowPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.colorEditTextColor = New DevExpress.XtraEditors.ColorEdit()
            Me.lblTextColor = New DevExpress.XtraEditors.LabelControl()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.timerInternal = New System.Windows.Forms.Timer(Me.components)
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.grAnimation = New DevExpress.XtraEditors.GroupControl()
            Me.spinDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.spinSpeed = New DevExpress.XtraEditors.SpinEdit()
            Me.lbDelay = New DevExpress.XtraEditors.LabelControl()
            Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.lbSpeed = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            Me.comboBoxTextOrientation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblTextOrientation = New DevExpress.XtraEditors.LabelControl()
            Me.gcColors = New DevExpress.XtraEditors.GroupControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl6 = New DevExpress.XtraEditors.GroupControl()
            Me.progressBarSample2 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.buttonsUpDown = New DevExpress.XtraEditors.ButtonEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.buttonsMaxMin = New DevExpress.XtraEditors.ButtonEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.comboBoxMaxMin = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblStep = New DevExpress.XtraEditors.LabelControl()
            Me.lblMaxMin = New DevExpress.XtraEditors.LabelControl()
            Me.textEditCurrentValue = New DevExpress.XtraEditors.TextEdit()
            Me.checkEditAnimation = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditStep = New DevExpress.XtraEditors.SpinEdit()
            Me.lblCurrentValue = New DevExpress.XtraEditors.LabelControl()
            CType(Me.progressBarSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.colorEditStartColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.colorEditEndColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxProgressStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditShowText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditShowPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.colorEditTextColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.grAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grAnimation.SuspendLayout()
            CType(Me.spinDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinSpeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl5.SuspendLayout()
            CType(Me.comboBoxTextOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcColors, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcColors.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl6.SuspendLayout()
            CType(Me.progressBarSample2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.buttonsUpDown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonsMaxMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxMaxMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEditCurrentValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditAnimation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEditStep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'progressBarSample
            '
            Me.progressBarSample.EditValue = 100
            Me.progressBarSample.Location = New System.Drawing.Point(51, 59)
            Me.progressBarSample.Name = "progressBarSample"
            Me.progressBarSample.Properties.Maximum = 200
            Me.progressBarSample.Size = New System.Drawing.Size(144, 20)
            Me.progressBarSample.TabIndex = 0
            '
            'lblStartColor
            '
            Me.lblStartColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblStartColor.Location = New System.Drawing.Point(20, 30)
            Me.lblStartColor.Name = "lblStartColor"
            Me.lblStartColor.Size = New System.Drawing.Size(66, 20)
            Me.lblStartColor.TabIndex = 1
            Me.lblStartColor.Text = "Start/end:"
            '
            'colorEditStartColor
            '
            Me.colorEditStartColor.EditValue = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.colorEditStartColor.Location = New System.Drawing.Point(117, 30)
            Me.colorEditStartColor.Name = "colorEditStartColor"
            Me.colorEditStartColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditStartColor.Size = New System.Drawing.Size(48, 20)
            Me.colorEditStartColor.TabIndex = 0
            '
            'colorEditEndColor
            '
            Me.colorEditEndColor.EditValue = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorEditEndColor.Location = New System.Drawing.Point(169, 30)
            Me.colorEditEndColor.Name = "colorEditEndColor"
            Me.colorEditEndColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditEndColor.Size = New System.Drawing.Size(48, 20)
            Me.colorEditEndColor.TabIndex = 1
            '
            'btnApplyColors
            '
            Me.btnApplyColors.Location = New System.Drawing.Point(117, 59)
            Me.btnApplyColors.Name = "btnApplyColors"
            Me.btnApplyColors.Size = New System.Drawing.Size(100, 24)
            Me.btnApplyColors.TabIndex = 2
            Me.btnApplyColors.Text = "Apply"
            '
            'comboBoxProgressStyle
            '
            Me.comboBoxProgressStyle.EditValue = "Broken"
            Me.comboBoxProgressStyle.Location = New System.Drawing.Point(95, 30)
            Me.comboBoxProgressStyle.Name = "comboBoxProgressStyle"
            Me.comboBoxProgressStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxProgressStyle.Properties.Items.AddRange(New Object() {"Solid", "Broken"})
            Me.comboBoxProgressStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxProgressStyle.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxProgressStyle.TabIndex = 0
            '
            'lblBarStyle
            '
            Me.lblBarStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblBarStyle.Location = New System.Drawing.Point(20, 30)
            Me.lblBarStyle.Name = "lblBarStyle"
            Me.lblBarStyle.Size = New System.Drawing.Size(66, 19)
            Me.lblBarStyle.TabIndex = 7
            Me.lblBarStyle.Text = "Bar style:"
            '
            'checkEditVertical
            '
            Me.checkEditVertical.Location = New System.Drawing.Point(18, 56)
            Me.checkEditVertical.Name = "checkEditVertical"
            Me.checkEditVertical.Properties.Caption = "Vertical"
            Me.checkEditVertical.Size = New System.Drawing.Size(181, 19)
            Me.checkEditVertical.TabIndex = 1
            '
            'checkEditShowText
            '
            Me.checkEditShowText.Location = New System.Drawing.Point(20, 30)
            Me.checkEditShowText.Name = "checkEditShowText"
            Me.checkEditShowText.Properties.Caption = "Show text"
            Me.checkEditShowText.Size = New System.Drawing.Size(172, 19)
            Me.checkEditShowText.TabIndex = 0
            '
            'checkEditShowPercent
            '
            Me.checkEditShowPercent.EditValue = True
            Me.checkEditShowPercent.Location = New System.Drawing.Point(20, 55)
            Me.checkEditShowPercent.Name = "checkEditShowPercent"
            Me.checkEditShowPercent.Properties.Caption = "Show percents"
            Me.checkEditShowPercent.Size = New System.Drawing.Size(172, 19)
            Me.checkEditShowPercent.TabIndex = 1
            '
            'colorEditTextColor
            '
            Me.colorEditTextColor.EditValue = System.Drawing.Color.Black
            Me.colorEditTextColor.Location = New System.Drawing.Point(116, 80)
            Me.colorEditTextColor.Name = "colorEditTextColor"
            Me.colorEditTextColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditTextColor.Size = New System.Drawing.Size(101, 20)
            Me.colorEditTextColor.TabIndex = 2
            '
            'lblTextColor
            '
            Me.lblTextColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblTextColor.Location = New System.Drawing.Point(26, 79)
            Me.lblTextColor.Name = "lblTextColor"
            Me.lblTextColor.Size = New System.Drawing.Size(66, 21)
            Me.lblTextColor.TabIndex = 12
            Me.lblTextColor.Text = "Text color:"
            '
            'timer
            '
            Me.timer.Interval = 50
            '
            'timerInternal
            '
            Me.timerInternal.Enabled = True
            Me.timerInternal.Interval = 25
            '
            'groupControl2
            '
            Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl2.Appearance.Options.UseBackColor = True
            Me.groupControl2.Controls.Add(Me.comboBoxProgressStyle)
            Me.groupControl2.Controls.Add(Me.checkEditVertical)
            Me.groupControl2.Controls.Add(Me.lblBarStyle)
            Me.groupControl2.Location = New System.Drawing.Point(325, 30)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(230, 92)
            Me.groupControl2.TabIndex = 1
            Me.groupControl2.Text = "Layout"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(874, 685)
            Me.xtraTabControl1.TabIndex = 16
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.grAnimation)
            Me.xtraTabPage1.Controls.Add(Me.groupControl3)
            Me.xtraTabPage1.Controls.Add(Me.groupControl5)
            Me.xtraTabPage1.Controls.Add(Me.gcColors)
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(868, 657)
            Me.xtraTabPage1.Text = "Layout and Appearance"
            '
            'grAnimation
            '
            Me.grAnimation.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.grAnimation.Appearance.Options.UseBackColor = True
            Me.grAnimation.Controls.Add(Me.spinDelay)
            Me.grAnimation.Controls.Add(Me.spinSpeed)
            Me.grAnimation.Controls.Add(Me.lbDelay)
            Me.grAnimation.Controls.Add(Me.CheckEdit1)
            Me.grAnimation.Controls.Add(Me.lbSpeed)
            Me.grAnimation.Location = New System.Drawing.Point(325, 310)
            Me.grAnimation.Name = "grAnimation"
            Me.grAnimation.Size = New System.Drawing.Size(230, 121)
            Me.grAnimation.TabIndex = 4
            Me.grAnimation.Text = "Flow animation"
            '
            'spinDelay
            '
            Me.spinDelay.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinDelay.Enabled = False
            Me.spinDelay.Location = New System.Drawing.Point(116, 81)
            Me.spinDelay.Name = "spinDelay"
            Me.spinDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinDelay.Properties.IsFloatValue = False
            Me.spinDelay.Properties.Mask.EditMask = "N00"
            Me.spinDelay.Size = New System.Drawing.Size(100, 20)
            Me.spinDelay.TabIndex = 5
            '
            'spinSpeed
            '
            Me.spinSpeed.EditValue = New Decimal(New Integer() {180, 0, 0, 0})
            Me.spinSpeed.Enabled = False
            Me.spinSpeed.Location = New System.Drawing.Point(116, 55)
            Me.spinSpeed.Name = "spinSpeed"
            Me.spinSpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinSpeed.Properties.IsFloatValue = False
            Me.spinSpeed.Properties.Mask.EditMask = "N00"
            Me.spinSpeed.Size = New System.Drawing.Size(100, 20)
            Me.spinSpeed.TabIndex = 4
            '
            'lbDelay
            '
            Me.lbDelay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbDelay.Enabled = False
            Me.lbDelay.Location = New System.Drawing.Point(26, 81)
            Me.lbDelay.Name = "lbDelay"
            Me.lbDelay.Size = New System.Drawing.Size(84, 20)
            Me.lbDelay.TabIndex = 3
            Me.lbDelay.Text = "Animation delay:"
            '
            'CheckEdit1
            '
            Me.CheckEdit1.Location = New System.Drawing.Point(20, 30)
            Me.CheckEdit1.Name = "CheckEdit1"
            Me.CheckEdit1.Properties.Caption = "Show flow animation"
            Me.CheckEdit1.Size = New System.Drawing.Size(128, 19)
            Me.CheckEdit1.TabIndex = 2
            '
            'lbSpeed
            '
            Me.lbSpeed.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbSpeed.Enabled = False
            Me.lbSpeed.Location = New System.Drawing.Point(26, 55)
            Me.lbSpeed.Name = "lbSpeed"
            Me.lbSpeed.Size = New System.Drawing.Size(84, 20)
            Me.lbSpeed.TabIndex = 1
            Me.lbSpeed.Text = "Animation speed:"
            '
            'groupControl3
            '
            Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl3.Appearance.Options.UseBackColor = True
            Me.groupControl3.Controls.Add(Me.progressBarSample)
            Me.groupControl3.Location = New System.Drawing.Point(30, 30)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(264, 381)
            Me.groupControl3.TabIndex = 0
            Me.groupControl3.Text = "Sample"
            '
            'groupControl5
            '
            Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl5.Appearance.Options.UseBackColor = True
            Me.groupControl5.Controls.Add(Me.comboBoxTextOrientation)
            Me.groupControl5.Controls.Add(Me.lblTextOrientation)
            Me.groupControl5.Controls.Add(Me.checkEditShowText)
            Me.groupControl5.Controls.Add(Me.colorEditTextColor)
            Me.groupControl5.Controls.Add(Me.lblTextColor)
            Me.groupControl5.Controls.Add(Me.checkEditShowPercent)
            Me.groupControl5.Location = New System.Drawing.Point(325, 143)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Size = New System.Drawing.Size(230, 146)
            Me.groupControl5.TabIndex = 2
            Me.groupControl5.Text = "Text"
            '
            'comboBoxTextOrientation
            '
            Me.comboBoxTextOrientation.EditValue = "Default"
            Me.comboBoxTextOrientation.Location = New System.Drawing.Point(116, 106)
            Me.comboBoxTextOrientation.Name = "comboBoxTextOrientation"
            Me.comboBoxTextOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxTextOrientation.Properties.Items.AddRange(New Object() {"Default", "Horizontal", "VerticalUpwards", "VerticalDownwards"})
            Me.comboBoxTextOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxTextOrientation.Size = New System.Drawing.Size(101, 20)
            Me.comboBoxTextOrientation.TabIndex = 14
            '
            'lblTextOrientation
            '
            Me.lblTextOrientation.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblTextOrientation.Location = New System.Drawing.Point(26, 105)
            Me.lblTextOrientation.Name = "lblTextOrientation"
            Me.lblTextOrientation.Size = New System.Drawing.Size(84, 21)
            Me.lblTextOrientation.TabIndex = 13
            Me.lblTextOrientation.Text = "Text orientation:"
            '
            'gcColors
            '
            Me.gcColors.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.gcColors.Appearance.Options.UseBackColor = True
            Me.gcColors.Controls.Add(Me.btnApplyColors)
            Me.gcColors.Controls.Add(Me.colorEditStartColor)
            Me.gcColors.Controls.Add(Me.lblStartColor)
            Me.gcColors.Controls.Add(Me.colorEditEndColor)
            Me.gcColors.Location = New System.Drawing.Point(325, 450)
            Me.gcColors.Name = "gcColors"
            Me.gcColors.Size = New System.Drawing.Size(230, 96)
            Me.gcColors.TabIndex = 3
            Me.gcColors.Text = "Bar colors"
            Me.gcColors.Visible = False
            '
            'xtraTabPage2
            '
            Me.xtraTabPage2.Controls.Add(Me.groupControl6)
            Me.xtraTabPage2.Controls.Add(Me.groupControl4)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(868, 657)
            Me.xtraTabPage2.Text = "Position Management"
            '
            'groupControl6
            '
            Me.groupControl6.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl6.Appearance.Options.UseBackColor = True
            Me.groupControl6.Controls.Add(Me.progressBarSample2)
            Me.groupControl6.Location = New System.Drawing.Point(30, 30)
            Me.groupControl6.Name = "groupControl6"
            Me.groupControl6.Size = New System.Drawing.Size(215, 227)
            Me.groupControl6.TabIndex = 0
            Me.groupControl6.Text = "Sample"
            '
            'progressBarSample2
            '
            Me.progressBarSample2.Location = New System.Drawing.Point(18, 66)
            Me.progressBarSample2.Name = "progressBarSample2"
            Me.progressBarSample2.Properties.EndColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.progressBarSample2.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
            Me.progressBarSample2.Properties.ShowTitle = True
            Me.progressBarSample2.Properties.StartColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.progressBarSample2.Size = New System.Drawing.Size(162, 20)
            Me.progressBarSample2.TabIndex = 0
            '
            'groupControl4
            '
            Me.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl4.Appearance.Options.UseBackColor = True
            Me.groupControl4.Controls.Add(Me.buttonsUpDown)
            Me.groupControl4.Controls.Add(Me.label2)
            Me.groupControl4.Controls.Add(Me.buttonsMaxMin)
            Me.groupControl4.Controls.Add(Me.label1)
            Me.groupControl4.Controls.Add(Me.comboBoxMaxMin)
            Me.groupControl4.Controls.Add(Me.lblStep)
            Me.groupControl4.Controls.Add(Me.lblMaxMin)
            Me.groupControl4.Controls.Add(Me.textEditCurrentValue)
            Me.groupControl4.Controls.Add(Me.checkEditAnimation)
            Me.groupControl4.Controls.Add(Me.spinEditStep)
            Me.groupControl4.Controls.Add(Me.lblCurrentValue)
            Me.groupControl4.Location = New System.Drawing.Point(276, 30)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(327, 227)
            Me.groupControl4.TabIndex = 1
            Me.groupControl4.Text = "Options"
            '
            'buttonsUpDown
            '
            Me.buttonsUpDown.EditValue = "buttonEdit2"
            Me.buttonsUpDown.Location = New System.Drawing.Point(164, 118)
            Me.buttonsUpDown.Name = "buttonsUpDown"
            Me.buttonsUpDown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Up", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Down", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
            Me.buttonsUpDown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.buttonsUpDown.Size = New System.Drawing.Size(136, 20)
            Me.buttonsUpDown.TabIndex = 3
            '
            'label2
            '
            Me.label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.label2.Location = New System.Drawing.Point(20, 121)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(138, 14)
            Me.label2.TabIndex = 14
            Me.label2.Text = "Variable position change:"
            '
            'buttonsMaxMin
            '
            Me.buttonsMaxMin.EditValue = "buttonEdit1"
            Me.buttonsMaxMin.Location = New System.Drawing.Point(164, 60)
            Me.buttonsMaxMin.Name = "buttonsMaxMin"
            Me.buttonsMaxMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Min", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Max", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, False)})
            Me.buttonsMaxMin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.buttonsMaxMin.Size = New System.Drawing.Size(136, 20)
            Me.buttonsMaxMin.TabIndex = 1
            '
            'label1
            '
            Me.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.label1.Location = New System.Drawing.Point(20, 60)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(138, 20)
            Me.label1.TabIndex = 12
            Me.label1.Text = "Set position to:"
            '
            'comboBoxMaxMin
            '
            Me.comboBoxMaxMin.EditValue = "Min=0; Max=100"
            Me.comboBoxMaxMin.Location = New System.Drawing.Point(164, 31)
            Me.comboBoxMaxMin.Name = "comboBoxMaxMin"
            Me.comboBoxMaxMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxMaxMin.Properties.Items.AddRange(New Object() {"Min = 0; Max = 100", "Min = 100; Max = 200", "Min = -100; Max = 100"})
            Me.comboBoxMaxMin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxMaxMin.Size = New System.Drawing.Size(136, 20)
            Me.comboBoxMaxMin.TabIndex = 0
            '
            'lblStep
            '
            Me.lblStep.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblStep.Location = New System.Drawing.Point(20, 91)
            Me.lblStep.Name = "lblStep"
            Me.lblStep.Size = New System.Drawing.Size(138, 16)
            Me.lblStep.TabIndex = 4
            Me.lblStep.Text = "Step:"
            '
            'lblMaxMin
            '
            Me.lblMaxMin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblMaxMin.Location = New System.Drawing.Point(20, 30)
            Me.lblMaxMin.Name = "lblMaxMin"
            Me.lblMaxMin.Size = New System.Drawing.Size(138, 21)
            Me.lblMaxMin.TabIndex = 10
            Me.lblMaxMin.Text = "Maximum and minimum:"
            '
            'textEditCurrentValue
            '
            Me.textEditCurrentValue.EditValue = "0"
            Me.textEditCurrentValue.Location = New System.Drawing.Point(164, 147)
            Me.textEditCurrentValue.Name = "textEditCurrentValue"
            Me.textEditCurrentValue.Properties.ReadOnly = True
            Me.textEditCurrentValue.Size = New System.Drawing.Size(136, 20)
            Me.textEditCurrentValue.TabIndex = 4
            '
            'checkEditAnimation
            '
            Me.checkEditAnimation.Location = New System.Drawing.Point(18, 185)
            Me.checkEditAnimation.Name = "checkEditAnimation"
            Me.checkEditAnimation.Properties.Caption = "Enable animation"
            Me.checkEditAnimation.Size = New System.Drawing.Size(144, 19)
            Me.checkEditAnimation.TabIndex = 5
            '
            'spinEditStep
            '
            Me.spinEditStep.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditStep.Location = New System.Drawing.Point(164, 89)
            Me.spinEditStep.Name = "spinEditStep"
            Me.spinEditStep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Step!", 52, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, False)})
            Me.spinEditStep.Properties.IsFloatValue = False
            Me.spinEditStep.Properties.Mask.EditMask = "N00"
            Me.spinEditStep.Size = New System.Drawing.Size(136, 20)
            Me.spinEditStep.TabIndex = 2
            '
            'lblCurrentValue
            '
            Me.lblCurrentValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblCurrentValue.Location = New System.Drawing.Point(20, 149)
            Me.lblCurrentValue.Name = "lblCurrentValue"
            Me.lblCurrentValue.Size = New System.Drawing.Size(138, 16)
            Me.lblCurrentValue.TabIndex = 5
            Me.lblCurrentValue.Text = "Current value:"
            '
            'ModuleProgressBar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleProgressBar"
            Me.Size = New System.Drawing.Size(879, 690)
            CType(Me.progressBarSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.colorEditStartColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.colorEditEndColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxProgressStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditShowText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditShowPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.colorEditTextColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.grAnimation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grAnimation.ResumeLayout(False)
            CType(Me.spinDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinSpeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            CType(Me.comboBoxTextOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcColors, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcColors.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl6.ResumeLayout(False)
            CType(Me.progressBarSample2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType(Me.buttonsUpDown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonsMaxMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxMaxMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEditCurrentValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditAnimation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEditStep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private lblStartColor As DevExpress.XtraEditors.LabelControl
		Private colorEditStartColor As DevExpress.XtraEditors.ColorEdit
		Private colorEditEndColor As DevExpress.XtraEditors.ColorEdit
		Private WithEvents btnApplyColors As DevExpress.XtraEditors.SimpleButton
		Private progressBarSample As DevExpress.XtraEditors.ProgressBarControl
		Private lblBarStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxProgressStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEditVertical As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEditShowText As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEditShowPercent As DevExpress.XtraEditors.CheckEdit
		Private WithEvents colorEditTextColor As DevExpress.XtraEditors.ColorEdit
		Private lblTextColor As DevExpress.XtraEditors.LabelControl
		Private WithEvents timer As System.Windows.Forms.Timer
		Private WithEvents timerInternal As System.Windows.Forms.Timer
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents progressBarSample2 As DevExpress.XtraEditors.ProgressBarControl
		Private groupControl4 As DevExpress.XtraEditors.GroupControl
		Private WithEvents comboBoxMaxMin As DevExpress.XtraEditors.ComboBoxEdit
		Private lblStep As DevExpress.XtraEditors.LabelControl
		Private lblMaxMin As DevExpress.XtraEditors.LabelControl
		Private textEditCurrentValue As DevExpress.XtraEditors.TextEdit
		Private WithEvents checkEditAnimation As DevExpress.XtraEditors.CheckEdit
		Private WithEvents spinEditStep As DevExpress.XtraEditors.SpinEdit
		Private lblCurrentValue As DevExpress.XtraEditors.LabelControl
		Private gcColors As DevExpress.XtraEditors.GroupControl
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents buttonsMaxMin As DevExpress.XtraEditors.ButtonEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents buttonsUpDown As DevExpress.XtraEditors.ButtonEdit
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private groupControl6 As DevExpress.XtraEditors.GroupControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private lblTextOrientation As DevExpress.XtraEditors.LabelControl
        Private WithEvents comboBoxTextOrientation As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents grAnimation As DevExpress.XtraEditors.GroupControl
        Friend WithEvents spinDelay As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents spinSpeed As DevExpress.XtraEditors.SpinEdit
        Private WithEvents lbDelay As DevExpress.XtraEditors.LabelControl
        Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents lbSpeed As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
