Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleToolTipController
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
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.toolTipControllerContentProperties1 = New EditorsTutorials.Modules.ToolTipControllerContentProperties()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.pceToolTipLocation = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.toolTipLocationControl = New EditorsTutorials.Modules.ToolTipLocationControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.label7 = New DevExpress.XtraEditors.LabelControl()
            Me.ceShowShadow = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBeak = New DevExpress.XtraEditors.CheckEdit()
            Me.ceRounded = New DevExpress.XtraEditors.CheckEdit()
            Me.seRoundRadius = New DevExpress.XtraEditors.SpinEdit()
            Me.seInitialDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.seAutoPopDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.label6 = New DevExpress.XtraEditors.LabelControl()
            Me.label5 = New DevExpress.XtraEditors.LabelControl()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.propertyGrid2 = New System.Windows.Forms.PropertyGrid()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.lbSample = New System.Windows.Forms.Label()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.toolTipControllerContentProperties2 = New EditorsTutorials.Modules.ToolTipControllerContentProperties()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.lbSampleManual = New System.Windows.Forms.Label()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            Me.lbStyleSample = New System.Windows.Forms.Label()
            Me.groupControl6 = New DevExpress.XtraEditors.GroupControl()
            Me.icbType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.chAllowHTML = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
            Me.toolTipStyleController = New DevExpress.Utils.ToolTipController(Me.components)
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            CType(Me.pceToolTipLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl1.SuspendLayout()
            CType(Me.ceShowShadow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowBeak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceRounded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seRoundRadius.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seInitialDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seAutoPopDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl5.SuspendLayout()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl6.SuspendLayout()
            CType(Me.icbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chAllowHTML.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl2.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            Me.xtraTabPage3.SuspendLayout()
            Me.xtraTabPage4.SuspendLayout()
            Me.xtraTabPage5.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupControl1
            '
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.toolTipControllerContentProperties1)
            Me.groupControl1.Location = New System.Drawing.Point(30, 140)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(297, 182)
            Me.groupControl1.TabIndex = 1
            Me.groupControl1.Text = "Content"
            '
            'toolTipControllerContentProperties1
            '
            Me.toolTipControllerContentProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolTipControllerContentProperties1.Location = New System.Drawing.Point(2, 21)
            Me.toolTipControllerContentProperties1.Name = "toolTipControllerContentProperties1"
            Me.toolTipControllerContentProperties1.Size = New System.Drawing.Size(293, 159)
            Me.toolTipControllerContentProperties1.TabIndex = 0
            '
            'groupControl3
            '
            Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl3.Appearance.Options.UseBackColor = True
            Me.groupControl3.Controls.Add(Me.pceToolTipLocation)
            Me.groupControl3.Controls.Add(Me.label7)
            Me.groupControl3.Controls.Add(Me.ceShowShadow)
            Me.groupControl3.Controls.Add(Me.ceShowBeak)
            Me.groupControl3.Controls.Add(Me.ceRounded)
            Me.groupControl3.Controls.Add(Me.seRoundRadius)
            Me.groupControl3.Controls.Add(Me.seInitialDelay)
            Me.groupControl3.Controls.Add(Me.seAutoPopDelay)
            Me.groupControl3.Controls.Add(Me.label6)
            Me.groupControl3.Controls.Add(Me.label5)
            Me.groupControl3.Controls.Add(Me.label1)
            Me.groupControl3.Location = New System.Drawing.Point(30, 343)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(617, 123)
            Me.groupControl3.TabIndex = 3
            Me.groupControl3.Text = "Options"
            '
            'pceToolTipLocation
            '
            Me.pceToolTipLocation.EditValue = ""
            Me.pceToolTipLocation.Location = New System.Drawing.Point(393, 54)
            Me.pceToolTipLocation.Name = "pceToolTipLocation"
            Me.pceToolTipLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.pceToolTipLocation.Properties.PopupControl = Me.popupContainerControl1
            Me.pceToolTipLocation.Properties.ShowPopupCloseButton = False
            Me.pceToolTipLocation.Size = New System.Drawing.Size(148, 20)
            Me.pceToolTipLocation.TabIndex = 16
            '
            'popupContainerControl1
            '
            Me.popupContainerControl1.Controls.Add(Me.toolTipLocationControl)
            Me.popupContainerControl1.Location = New System.Drawing.Point(853, 14)
            Me.popupContainerControl1.Name = "popupContainerControl1"
            Me.popupContainerControl1.Size = New System.Drawing.Size(152, 104)
            Me.popupContainerControl1.TabIndex = 5
            '
            'toolTipLocationControl
            '
            Me.toolTipLocationControl.Controller = Me.toolTipController1
            Me.toolTipLocationControl.Location = New System.Drawing.Point(0, 0)
            Me.toolTipLocationControl.Name = "toolTipLocationControl"
            Me.toolTipLocationControl.Size = New System.Drawing.Size(152, 104)
            Me.toolTipLocationControl.TabIndex = 0
            '
            'toolTipController1
            '
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ShowBeak = True
            '
            'label7
            '
            Me.label7.Location = New System.Drawing.Point(364, 35)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(78, 13)
            Me.label7.TabIndex = 15
            Me.label7.Text = "ToolTip location:"
            '
            'ceShowShadow
            '
            Me.ceShowShadow.EditValue = Nothing
            Me.ceShowShadow.Location = New System.Drawing.Point(230, 84)
            Me.ceShowShadow.Name = "ceShowShadow"
            Me.ceShowShadow.Properties.Caption = "Show shadow"
            Me.ceShowShadow.Size = New System.Drawing.Size(112, 19)
            Me.ceShowShadow.TabIndex = 14
            '
            'ceShowBeak
            '
            Me.ceShowBeak.EditValue = Nothing
            Me.ceShowBeak.Location = New System.Drawing.Point(230, 58)
            Me.ceShowBeak.Name = "ceShowBeak"
            Me.ceShowBeak.Properties.Caption = "Show beak"
            Me.ceShowBeak.Size = New System.Drawing.Size(112, 19)
            Me.ceShowBeak.TabIndex = 13
            '
            'ceRounded
            '
            Me.ceRounded.EditValue = Nothing
            Me.ceRounded.Location = New System.Drawing.Point(230, 32)
            Me.ceRounded.Name = "ceRounded"
            Me.ceRounded.Properties.Caption = "Rounded"
            Me.ceRounded.Size = New System.Drawing.Size(112, 19)
            Me.ceRounded.TabIndex = 12
            '
            'seRoundRadius
            '
            Me.seRoundRadius.EditValue = New Decimal(New Integer() {7, 0, 0, 0})
            Me.seRoundRadius.Location = New System.Drawing.Point(114, 84)
            Me.seRoundRadius.Name = "seRoundRadius"
            Me.seRoundRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seRoundRadius.Properties.IsFloatValue = False
            Me.seRoundRadius.Properties.Mask.EditMask = "N00"
            Me.seRoundRadius.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
            Me.seRoundRadius.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seRoundRadius.Size = New System.Drawing.Size(80, 20)
            Me.seRoundRadius.TabIndex = 11
            '
            'seInitialDelay
            '
            Me.seInitialDelay.EditValue = New Decimal(New Integer() {500, 0, 0, 0})
            Me.seInitialDelay.Location = New System.Drawing.Point(114, 58)
            Me.seInitialDelay.Name = "seInitialDelay"
            Me.seInitialDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seInitialDelay.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.seInitialDelay.Properties.IsFloatValue = False
            Me.seInitialDelay.Properties.Mask.EditMask = "N00"
            Me.seInitialDelay.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seInitialDelay.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seInitialDelay.Size = New System.Drawing.Size(80, 20)
            Me.seInitialDelay.TabIndex = 10
            '
            'seAutoPopDelay
            '
            Me.seAutoPopDelay.EditValue = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.seAutoPopDelay.Location = New System.Drawing.Point(114, 32)
            Me.seAutoPopDelay.Name = "seAutoPopDelay"
            Me.seAutoPopDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seAutoPopDelay.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seAutoPopDelay.Properties.IsFloatValue = False
            Me.seAutoPopDelay.Properties.Mask.EditMask = "N00"
            Me.seAutoPopDelay.Properties.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.seAutoPopDelay.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seAutoPopDelay.Size = New System.Drawing.Size(80, 20)
            Me.seAutoPopDelay.TabIndex = 9
            '
            'label6
            '
            Me.label6.Location = New System.Drawing.Point(20, 87)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(67, 13)
            Me.label6.TabIndex = 8
            Me.label6.Text = "Round radius:"
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(20, 61)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(59, 13)
            Me.label5.TabIndex = 7
            Me.label5.Text = "Initial delay:"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(20, 35)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(74, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "AutoPop delay:"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.BackColor = System.Drawing.SystemColors.Control
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.HelpVisible = False
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(4, 4)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
            Me.propertyGrid1.Size = New System.Drawing.Size(277, 146)
            Me.propertyGrid1.TabIndex = 0
            Me.propertyGrid1.ToolbarVisible = False
            '
            'propertyGrid2
            '
            Me.propertyGrid2.BackColor = System.Drawing.SystemColors.Control
            Me.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid2.HelpVisible = False
            Me.propertyGrid2.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid2.Location = New System.Drawing.Point(4, 4)
            Me.propertyGrid2.Name = "propertyGrid2"
            Me.propertyGrid2.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
            Me.propertyGrid2.Size = New System.Drawing.Size(277, 146)
            Me.propertyGrid2.TabIndex = 1
            Me.propertyGrid2.ToolbarVisible = False
            '
            'panelControl1
            '
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Controls.Add(Me.lbSample)
            Me.panelControl1.Location = New System.Drawing.Point(30, 30)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(617, 88)
            Me.panelControl1.TabIndex = 0
            Me.panelControl1.Text = "Sample"
            '
            'lbSample
            '
            Me.lbSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSample.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.lbSample.Location = New System.Drawing.Point(12, 28)
            Me.lbSample.Name = "lbSample"
            Me.lbSample.Size = New System.Drawing.Size(244, 48)
            Me.lbSample.TabIndex = 0
            Me.lbSample.Text = "Hover the mouse cursor over this box to automatically display a tooltip."
            Me.lbSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'groupControl4
            '
            Me.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl4.Appearance.Options.UseBackColor = True
            Me.groupControl4.Controls.Add(Me.toolTipControllerContentProperties2)
            Me.groupControl4.Location = New System.Drawing.Point(30, 139)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(295, 184)
            Me.groupControl4.TabIndex = 2
            Me.groupControl4.Text = "Content"
            '
            'toolTipControllerContentProperties2
            '
            Me.toolTipControllerContentProperties2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolTipControllerContentProperties2.Location = New System.Drawing.Point(2, 21)
            Me.toolTipControllerContentProperties2.Name = "toolTipControllerContentProperties2"
            Me.toolTipControllerContentProperties2.Size = New System.Drawing.Size(291, 161)
            Me.toolTipControllerContentProperties2.TabIndex = 0
            '
            'groupControl2
            '
            Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl2.Appearance.Options.UseBackColor = True
            Me.groupControl2.Controls.Add(Me.lbSampleManual)
            Me.groupControl2.Location = New System.Drawing.Point(30, 30)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(295, 88)
            Me.groupControl2.TabIndex = 1
            Me.groupControl2.Text = "Sample"
            '
            'lbSampleManual
            '
            Me.lbSampleManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSampleManual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.lbSampleManual.Location = New System.Drawing.Point(72, 28)
            Me.lbSampleManual.Name = "lbSampleManual"
            Me.lbSampleManual.Size = New System.Drawing.Size(184, 48)
            Me.lbSampleManual.TabIndex = 0
            Me.lbSampleManual.Text = "Click this box to manually activate a tooltip."
            Me.lbSampleManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'groupControl5
            '
            Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl5.Appearance.Options.UseBackColor = True
            Me.groupControl5.Controls.Add(Me.lbStyleSample)
            Me.groupControl5.Location = New System.Drawing.Point(30, 30)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Size = New System.Drawing.Size(363, 88)
            Me.groupControl5.TabIndex = 1
            Me.groupControl5.Text = "Sample"
            '
            'lbStyleSample
            '
            Me.lbStyleSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbStyleSample.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.lbStyleSample.Location = New System.Drawing.Point(12, 28)
            Me.lbStyleSample.Name = "lbStyleSample"
            Me.lbStyleSample.Size = New System.Drawing.Size(244, 48)
            Me.lbStyleSample.TabIndex = 0
            Me.lbStyleSample.Text = "Hover the mouse cursor over this box to automatically display a tooltip."
            Me.lbStyleSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'groupControl6
            '
            Me.groupControl6.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl6.Appearance.Options.UseBackColor = True
            Me.groupControl6.Controls.Add(Me.icbType)
            Me.groupControl6.Controls.Add(Me.chAllowHTML)
            Me.groupControl6.Controls.Add(Me.labelControl4)
            Me.groupControl6.Location = New System.Drawing.Point(30, 139)
            Me.groupControl6.Name = "groupControl6"
            Me.groupControl6.Size = New System.Drawing.Size(363, 94)
            Me.groupControl6.TabIndex = 4
            Me.groupControl6.Text = "Properties"
            '
            'icbType
            '
            Me.icbType.Location = New System.Drawing.Point(109, 32)
            Me.icbType.Name = "icbType"
            Me.icbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbType.Size = New System.Drawing.Size(147, 20)
            Me.icbType.TabIndex = 14
            '
            'chAllowHTML
            '
            Me.chAllowHTML.EditValue = True
            Me.chAllowHTML.Location = New System.Drawing.Point(18, 61)
            Me.chAllowHTML.Name = "chAllowHTML"
            Me.chAllowHTML.Properties.Caption = "Allow HTML text"
            Me.chAllowHTML.Size = New System.Drawing.Size(112, 19)
            Me.chAllowHTML.TabIndex = 13
            '
            'labelControl4
            '
            Me.labelControl4.Location = New System.Drawing.Point(20, 35)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(61, 13)
            Me.labelControl4.TabIndex = 6
            Me.labelControl4.Text = "Tooltip type:"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(1026, 594)
            Me.xtraTabControl1.TabIndex = 14
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage4, Me.xtraTabPage5})
            Me.xtraTabControl1.TabStop = False
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.popupContainerControl1)
            Me.xtraTabPage1.Controls.Add(Me.xtraTabControl2)
            Me.xtraTabPage1.Controls.Add(Me.panelControl1)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Controls.Add(Me.groupControl3)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(1020, 566)
            Me.xtraTabPage1.Text = "Auto-popup tooltip"
            '
            'xtraTabControl2
            '
            Me.xtraTabControl2.Location = New System.Drawing.Point(356, 140)
            Me.xtraTabControl2.Name = "xtraTabControl2"
            Me.xtraTabControl2.SelectedTabPage = Me.xtraTabPage2
            Me.xtraTabControl2.Size = New System.Drawing.Size(291, 182)
            Me.xtraTabControl2.TabIndex = 4
            Me.xtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage2, Me.xtraTabPage3})
            '
            'xtraTabPage2
            '
            Me.xtraTabPage2.Controls.Add(Me.propertyGrid1)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(4)
            Me.xtraTabPage2.Size = New System.Drawing.Size(285, 154)
            Me.xtraTabPage2.Text = "Appearance"
            '
            'xtraTabPage3
            '
            Me.xtraTabPage3.Controls.Add(Me.propertyGrid2)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Padding = New System.Windows.Forms.Padding(4)
            Me.xtraTabPage3.Size = New System.Drawing.Size(285, 154)
            Me.xtraTabPage3.Text = "AppearanceTitle"
            '
            'xtraTabPage4
            '
            Me.xtraTabPage4.Controls.Add(Me.groupControl4)
            Me.xtraTabPage4.Controls.Add(Me.groupControl2)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            Me.xtraTabPage4.Size = New System.Drawing.Size(1020, 566)
            Me.xtraTabPage4.Text = "ShowHint method"
            '
            'xtraTabPage5
            '
            Me.xtraTabPage5.Controls.Add(Me.groupControl6)
            Me.xtraTabPage5.Controls.Add(Me.groupControl5)
            Me.xtraTabPage5.Name = "xtraTabPage5"
            Me.xtraTabPage5.Size = New System.Drawing.Size(1020, 566)
            Me.xtraTabPage5.Text = "Tooltip Types and Styles"
            '
            'toolTipStyleController
            '
            Me.toolTipStyleController.AllowHtmlText = True
            Me.toolTipStyleController.AutoPopDelay = 8000
            Me.toolTipStyleController.Rounded = True
            Me.toolTipStyleController.ShowBeak = True
            Me.toolTipStyleController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            '
            'ModuleToolTipController
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleToolTipController"
            Me.Size = New System.Drawing.Size(1031, 599)
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            Me.groupControl3.PerformLayout()
            CType(Me.pceToolTipLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl1.ResumeLayout(False)
            CType(Me.ceShowShadow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowBeak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceRounded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seRoundRadius.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seInitialDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seAutoPopDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl6.ResumeLayout(False)
            Me.groupControl6.PerformLayout()
            CType(Me.icbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chAllowHTML.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl2.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            Me.xtraTabPage3.ResumeLayout(False)
            Me.xtraTabPage4.ResumeLayout(False)
            Me.xtraTabPage5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
		Private xtraTabControl2 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private lbSample As System.Windows.Forms.Label
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private label6 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seAutoPopDelay As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seInitialDelay As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seRoundRadius As DevExpress.XtraEditors.SpinEdit
		Private WithEvents ceRounded As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowBeak As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowShadow As DevExpress.XtraEditors.CheckEdit
		Private label7 As DevExpress.XtraEditors.LabelControl
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents pceToolTipLocation As DevExpress.XtraEditors.PopupContainerEdit
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private WithEvents toolTipLocationControl As EditorsTutorials.Modules.ToolTipLocationControl
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private propertyGrid2 As System.Windows.Forms.PropertyGrid
		Private toolTipControllerContentProperties1 As EditorsTutorials.Modules.ToolTipControllerContentProperties
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents lbSampleManual As System.Windows.Forms.Label
		Private groupControl4 As DevExpress.XtraEditors.GroupControl
		Private toolTipControllerContentProperties2 As EditorsTutorials.Modules.ToolTipControllerContentProperties
		Private components As System.ComponentModel.IContainer = Nothing
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private groupControl6 As DevExpress.XtraEditors.GroupControl
		Private WithEvents icbType As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents chAllowHTML As DevExpress.XtraEditors.CheckEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private lbStyleSample As System.Windows.Forms.Label
		Private toolTipStyleController As DevExpress.Utils.ToolTipController

	End Class
End Namespace
