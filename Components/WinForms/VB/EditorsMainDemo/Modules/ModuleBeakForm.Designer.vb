Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleBeakForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleBeakForm))
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.appearanceOptionsGroup = New DevExpress.XtraEditors.GroupControl()
            Me.beakLocLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeBeakLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.borderColorLabel = New DevExpress.XtraEditors.LabelControl()
            Me.backColorLabel = New DevExpress.XtraEditors.LabelControl()
            Me.ceCloseOnOuterClick = New DevExpress.XtraEditors.CheckEdit()
            Me.borderColorEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.backColorEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.prevewPanelHintLabel = New DevExpress.XtraEditors.LabelControl()
            Me.flyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelHintLabel = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.buttonPanelOptionsGroup = New DevExpress.XtraEditors.GroupControl()
            Me.btnRemoveButton = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddButton = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonPanelAligLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeButtonPanelAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.buttonPanelLocLabel = New DevExpress.XtraEditors.LabelControl()
            Me.ceShowButtonPanel = New DevExpress.XtraEditors.CheckEdit()
            Me.cbeButtonPanelLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.previewGroup = New DevExpress.XtraEditors.GroupControl()
            Me.previewPanel = New DevExpress.XtraEditors.PanelControl()
            CType(Me.appearanceOptionsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.appearanceOptionsGroup.SuspendLayout()
            CType(Me.cbeBeakLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceCloseOnOuterClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.borderColorEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.backColorEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.flyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel.SuspendLayout()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.buttonPanelOptionsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonPanelOptionsGroup.SuspendLayout()
            CType(Me.cbeButtonPanelAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowButtonPanel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeButtonPanelLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.previewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.previewGroup.SuspendLayout()
            CType(Me.previewPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.previewPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'appearanceOptionsGroup
            '
            Me.appearanceOptionsGroup.Controls.Add(Me.beakLocLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.cbeBeakLocation)
            Me.appearanceOptionsGroup.Controls.Add(Me.borderColorLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.backColorLabel)
            Me.appearanceOptionsGroup.Controls.Add(Me.ceCloseOnOuterClick)
            Me.appearanceOptionsGroup.Controls.Add(Me.borderColorEdit)
            Me.appearanceOptionsGroup.Controls.Add(Me.backColorEdit)
            Me.appearanceOptionsGroup.Location = New System.Drawing.Point(324, 22)
            Me.appearanceOptionsGroup.Name = "appearanceOptionsGroup"
            Me.appearanceOptionsGroup.Size = New System.Drawing.Size(338, 154)
            Me.appearanceOptionsGroup.TabIndex = 0
            Me.appearanceOptionsGroup.Text = "Appearance && Behavior Options"
            '
            'beakLocLabel
            '
            Me.beakLocLabel.Location = New System.Drawing.Point(20, 35)
            Me.beakLocLabel.Name = "beakLocLabel"
            Me.beakLocLabel.Size = New System.Drawing.Size(70, 13)
            Me.beakLocLabel.TabIndex = 6
            Me.beakLocLabel.Text = "Beak Location:"
            '
            'cbeBeakLocation
            '
            Me.cbeBeakLocation.Location = New System.Drawing.Point(106, 32)
            Me.cbeBeakLocation.Name = "cbeBeakLocation"
            Me.cbeBeakLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeBeakLocation.Size = New System.Drawing.Size(204, 20)
            Me.cbeBeakLocation.TabIndex = 5
            '
            'borderColorLabel
            '
            Me.borderColorLabel.Location = New System.Drawing.Point(20, 93)
            Me.borderColorLabel.Name = "borderColorLabel"
            Me.borderColorLabel.Size = New System.Drawing.Size(64, 13)
            Me.borderColorLabel.TabIndex = 4
            Me.borderColorLabel.Text = "Border Color:"
            '
            'backColorLabel
            '
            Me.backColorLabel.Location = New System.Drawing.Point(20, 65)
            Me.backColorLabel.Name = "backColorLabel"
            Me.backColorLabel.Size = New System.Drawing.Size(54, 13)
            Me.backColorLabel.TabIndex = 3
            Me.backColorLabel.Text = "Back Color:"
            '
            'ceCloseOnOuterClick
            '
            Me.ceCloseOnOuterClick.Location = New System.Drawing.Point(19, 119)
            Me.ceCloseOnOuterClick.Name = "ceCloseOnOuterClick"
            Me.ceCloseOnOuterClick.Properties.Caption = "Close On Outer Click"
            Me.ceCloseOnOuterClick.Size = New System.Drawing.Size(178, 15)
            Me.ceCloseOnOuterClick.TabIndex = 2
            '
            'borderColorEdit
            '
            Me.borderColorEdit.EditValue = System.Drawing.Color.Empty
            Me.borderColorEdit.Location = New System.Drawing.Point(106, 90)
            Me.borderColorEdit.Name = "borderColorEdit"
            Me.borderColorEdit.Properties.AutomaticBorderColor = System.Drawing.Color.Black
            Me.borderColorEdit.Properties.AutomaticColor = System.Drawing.Color.DimGray
            Me.borderColorEdit.Properties.AutomaticColorButtonCaption = "Reset Color"
            Me.borderColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.borderColorEdit.Size = New System.Drawing.Size(204, 20)
            Me.borderColorEdit.TabIndex = 1
            '
            'backColorEdit
            '
            Me.backColorEdit.EditValue = System.Drawing.Color.Empty
            Me.backColorEdit.Location = New System.Drawing.Point(106, 61)
            Me.backColorEdit.Name = "backColorEdit"
            Me.backColorEdit.Properties.AutomaticBorderColor = System.Drawing.Color.Black
            Me.backColorEdit.Properties.AutomaticColor = System.Drawing.Color.Transparent
            Me.backColorEdit.Properties.AutomaticColorButtonCaption = "Reset Color"
            Me.backColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.backColorEdit.Size = New System.Drawing.Size(204, 20)
            Me.backColorEdit.TabIndex = 0
            '
            'prevewPanelHintLabel
            '
            Me.prevewPanelHintLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.prevewPanelHintLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.prevewPanelHintLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.prevewPanelHintLabel.Location = New System.Drawing.Point(28, 11)
            Me.prevewPanelHintLabel.Name = "prevewPanelHintLabel"
            Me.prevewPanelHintLabel.Size = New System.Drawing.Size(133, 36)
            Me.prevewPanelHintLabel.TabIndex = 0
            Me.prevewPanelHintLabel.Text = "Move mouse here to show the Beak Form"
            '
            'flyoutPanel
            '
            Me.flyoutPanel.Controls.Add(Me.flyoutPanelHintLabel)
            Me.flyoutPanel.Location = New System.Drawing.Point(27, 382)
            Me.flyoutPanel.Name = "flyoutPanel"
            Me.flyoutPanel.OptionsButtonPanel.AllowGlyphSkinning = True
            Me.flyoutPanel.OptionsButtonPanel.ButtonPanelHeight = 36
            ToolTipItem1.Text = "Exit"
            SuperToolTip1.Items.Add(ToolTipItem1)
            Me.flyoutPanel.OptionsButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.Utils.PeekFormButton("Button", CType(resources.GetObject("flyoutPanel.OptionsButtonPanel.Buttons"), System.Drawing.Image), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exit", False, -1, True, SuperToolTip1, True, False, True, Nothing, "Exit", -1, False)})
            Me.flyoutPanel.OptionsButtonPanel.ShowButtonPanel = True
            Me.flyoutPanel.OwnerControl = Me
            Me.flyoutPanel.Padding = New System.Windows.Forms.Padding(0, 36, 0, 0)
            Me.flyoutPanel.Size = New System.Drawing.Size(338, 120)
            Me.flyoutPanel.TabIndex = 2
            '
            'flyoutPanelHintLabel
            '
            Me.flyoutPanelHintLabel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.flyoutPanelHintLabel.Location = New System.Drawing.Point(90, 58)
            Me.flyoutPanelHintLabel.Name = "flyoutPanelHintLabel"
            Me.flyoutPanelHintLabel.Size = New System.Drawing.Size(152, 13)
            Me.flyoutPanelHintLabel.TabIndex = 0
            Me.flyoutPanelHintLabel.Text = "You can place any content here"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(779, 522)
            Me.xtraTabControl1.TabIndex = 3
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.buttonPanelOptionsGroup)
            Me.xtraTabPage1.Controls.Add(Me.previewGroup)
            Me.xtraTabPage1.Controls.Add(Me.flyoutPanel)
            Me.xtraTabPage1.Controls.Add(Me.appearanceOptionsGroup)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(773, 516)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            '
            'buttonPanelOptionsGroup
            '
            Me.buttonPanelOptionsGroup.Controls.Add(Me.btnRemoveButton)
            Me.buttonPanelOptionsGroup.Controls.Add(Me.btnAddButton)
            Me.buttonPanelOptionsGroup.Controls.Add(Me.buttonPanelAligLabel)
            Me.buttonPanelOptionsGroup.Controls.Add(Me.cbeButtonPanelAlignment)
            Me.buttonPanelOptionsGroup.Controls.Add(Me.buttonPanelLocLabel)
            Me.buttonPanelOptionsGroup.Controls.Add(Me.ceShowButtonPanel)
            Me.buttonPanelOptionsGroup.Controls.Add(Me.cbeButtonPanelLocation)
            Me.buttonPanelOptionsGroup.Location = New System.Drawing.Point(324, 197)
            Me.buttonPanelOptionsGroup.Name = "buttonPanelOptionsGroup"
            Me.buttonPanelOptionsGroup.Size = New System.Drawing.Size(338, 161)
            Me.buttonPanelOptionsGroup.TabIndex = 4
            Me.buttonPanelOptionsGroup.Text = "ButtonPanel Appearance"
            '
            'btnRemoveButton
            '
            Me.btnRemoveButton.Location = New System.Drawing.Point(211, 116)
            Me.btnRemoveButton.Name = "btnRemoveButton"
            Me.btnRemoveButton.Size = New System.Drawing.Size(99, 23)
            Me.btnRemoveButton.TabIndex = 13
            Me.btnRemoveButton.Text = "Remove Button"
            '
            'btnAddButton
            '
            Me.btnAddButton.Location = New System.Drawing.Point(106, 116)
            Me.btnAddButton.Name = "btnAddButton"
            Me.btnAddButton.Size = New System.Drawing.Size(99, 23)
            Me.btnAddButton.TabIndex = 12
            Me.btnAddButton.Text = "Add Button"
            '
            'buttonPanelAligLabel
            '
            Me.buttonPanelAligLabel.Location = New System.Drawing.Point(20, 90)
            Me.buttonPanelAligLabel.Name = "buttonPanelAligLabel"
            Me.buttonPanelAligLabel.Size = New System.Drawing.Size(51, 13)
            Me.buttonPanelAligLabel.TabIndex = 6
            Me.buttonPanelAligLabel.Text = "Alignment:"
            '
            'cbeButtonPanelAlignment
            '
            Me.cbeButtonPanelAlignment.Location = New System.Drawing.Point(106, 87)
            Me.cbeButtonPanelAlignment.Name = "cbeButtonPanelAlignment"
            Me.cbeButtonPanelAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeButtonPanelAlignment.Properties.DropDownRows = 14
            Me.cbeButtonPanelAlignment.Size = New System.Drawing.Size(204, 20)
            Me.cbeButtonPanelAlignment.TabIndex = 5
            '
            'buttonPanelLocLabel
            '
            Me.buttonPanelLocLabel.Location = New System.Drawing.Point(20, 61)
            Me.buttonPanelLocLabel.Name = "buttonPanelLocLabel"
            Me.buttonPanelLocLabel.Size = New System.Drawing.Size(44, 13)
            Me.buttonPanelLocLabel.TabIndex = 10
            Me.buttonPanelLocLabel.Text = "Location:"
            '
            'ceShowButtonPanel
            '
            Me.ceShowButtonPanel.Location = New System.Drawing.Point(19, 30)
            Me.ceShowButtonPanel.Name = "ceShowButtonPanel"
            Me.ceShowButtonPanel.Properties.Caption = "Show ButtonPanel"
            Me.ceShowButtonPanel.Size = New System.Drawing.Size(164, 15)
            Me.ceShowButtonPanel.TabIndex = 11
            '
            'cbeButtonPanelLocation
            '
            Me.cbeButtonPanelLocation.Location = New System.Drawing.Point(106, 58)
            Me.cbeButtonPanelLocation.Name = "cbeButtonPanelLocation"
            Me.cbeButtonPanelLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeButtonPanelLocation.Size = New System.Drawing.Size(204, 20)
            Me.cbeButtonPanelLocation.TabIndex = 9
            '
            'previewGroup
            '
            Me.previewGroup.Controls.Add(Me.previewPanel)
            Me.previewGroup.Location = New System.Drawing.Point(27, 22)
            Me.previewGroup.Name = "previewGroup"
            Me.previewGroup.Size = New System.Drawing.Size(266, 336)
            Me.previewGroup.TabIndex = 3
            Me.previewGroup.Text = "Sample"
            '
            'previewPanel
            '
            Me.previewPanel.Controls.Add(Me.prevewPanelHintLabel)
            Me.previewPanel.Location = New System.Drawing.Point(35, 129)
            Me.previewPanel.Name = "previewPanel"
            Me.previewPanel.Size = New System.Drawing.Size(197, 60)
            Me.previewPanel.TabIndex = 1
            '
            'ModuleBeakForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleBeakForm"
            Me.Size = New System.Drawing.Size(784, 527)
            CType(Me.appearanceOptionsGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.appearanceOptionsGroup.ResumeLayout(False)
            Me.appearanceOptionsGroup.PerformLayout()
            CType(Me.cbeBeakLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceCloseOnOuterClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.borderColorEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.backColorEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.flyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel.ResumeLayout(False)
            Me.flyoutPanel.PerformLayout()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.buttonPanelOptionsGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonPanelOptionsGroup.ResumeLayout(False)
            Me.buttonPanelOptionsGroup.PerformLayout()
            CType(Me.cbeButtonPanelAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowButtonPanel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeButtonPanelLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.previewGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.previewGroup.ResumeLayout(False)
            CType(Me.previewPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.previewPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private appearanceOptionsGroup As GroupControl
		Private prevewPanelHintLabel As LabelControl
		Private WithEvents flyoutPanel As Utils.FlyoutPanel
		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
		Private flyoutPanelHintLabel As LabelControl
		Private previewGroup As GroupControl
		Private WithEvents previewPanel As PanelControl
		Private borderColorLabel As LabelControl
		Private backColorLabel As LabelControl
		Private WithEvents ceCloseOnOuterClick As CheckEdit
		Private WithEvents borderColorEdit As ColorPickEdit
		Private WithEvents backColorEdit As ColorPickEdit
		Private buttonPanelLocLabel As LabelControl
		Private WithEvents cbeButtonPanelLocation As ImageComboBoxEdit
		Private buttonPanelAligLabel As LabelControl
		Private WithEvents cbeButtonPanelAlignment As ImageComboBoxEdit
		Private WithEvents ceShowButtonPanel As CheckEdit
		Private buttonPanelOptionsGroup As GroupControl
		Private WithEvents btnRemoveButton As SimpleButton
		Private WithEvents btnAddButton As SimpleButton
		Private beakLocLabel As LabelControl
		Private WithEvents cbeBeakLocation As ImageComboBoxEdit

	End Class
End Namespace
