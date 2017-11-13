Namespace DevExpress.XtraEditors.Demos
    Partial Public Class ModuleProgressPanel
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
            Me.groupRingProperties = New DevExpress.XtraEditors.GroupControl()
            Me.spinRingDiameter = New DevExpress.XtraEditors.SpinEdit()
            Me.lblRingDiameter = New DevExpress.XtraEditors.LabelControl()
            Me.groupLineProperties = New DevExpress.XtraEditors.GroupControl()
            Me.lblLineElementType = New DevExpress.XtraEditors.LabelControl()
            Me.comboBoxLineElementType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinLineHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.lblLineHeight = New DevExpress.XtraEditors.LabelControl()
            Me.groupAnimationProperties = New DevExpress.XtraEditors.GroupControl()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.colorEditElementColor = New DevExpress.XtraEditors.ColorEdit()
            Me.spinSpeed = New DevExpress.XtraEditors.SpinEdit()
            Me.spinAcceleration = New DevExpress.XtraEditors.SpinEdit()
            Me.lblSpeed = New DevExpress.XtraEditors.LabelControl()
            Me.lblAcceleration = New DevExpress.XtraEditors.LabelControl()
            Me.lblElementCount = New DevExpress.XtraEditors.LabelControl()
            Me.spinElementCount = New DevExpress.XtraEditors.SpinEdit()
            Me.groupPanelProperties = New DevExpress.XtraEditors.GroupControl()
            Me.spinFrameInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.lblFrameInterval = New DevExpress.XtraEditors.LabelControl()
            Me.spinFrameCount = New DevExpress.XtraEditors.SpinEdit()
            Me.lblFrameCount = New DevExpress.XtraEditors.LabelControl()
            Me.lblAnimationType = New DevExpress.XtraEditors.LabelControl()
            Me.comboBoxAnimationType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.groupSample = New DevExpress.XtraEditors.GroupControl()
            Me.progressPanelSample = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            CType(Me.groupRingProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupRingProperties.SuspendLayout()
            CType(Me.spinRingDiameter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupLineProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupLineProperties.SuspendLayout()
            CType(Me.comboBoxLineElementType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinLineHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupAnimationProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupAnimationProperties.SuspendLayout()
            CType(Me.colorEditElementColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinSpeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinAcceleration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinElementCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupPanelProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupPanelProperties.SuspendLayout()
            CType(Me.spinFrameInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinFrameCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAnimationType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupSample, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupSample.SuspendLayout()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' groupRingProperties
            ' 
            Me.groupRingProperties.CaptionImageUri.Uri = ""
            Me.groupRingProperties.Controls.Add(Me.spinRingDiameter)
            Me.groupRingProperties.Controls.Add(Me.lblRingDiameter)
            Me.groupRingProperties.Location = New System.Drawing.Point(495, 468)
            Me.groupRingProperties.Margin = New System.Windows.Forms.Padding(15)
            Me.groupRingProperties.Name = "groupRingProperties"
            Me.groupRingProperties.Padding = New System.Windows.Forms.Padding(5)
            Me.groupRingProperties.Size = New System.Drawing.Size(301, 58)
            Me.groupRingProperties.TabIndex = 12
            Me.groupRingProperties.Text = "Ring animation properties"
            ' 
            ' spinRingDiameter
            ' 
            Me.spinRingDiameter.EditValue = New Decimal(New Integer() {40, 0, 0, 0})
            Me.spinRingDiameter.Location = New System.Drawing.Point(179, 28)
            Me.spinRingDiameter.Name = "spinRingDiameter"
            Me.spinRingDiameter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinRingDiameter.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinRingDiameter.Properties.IsFloatValue = False
            Me.spinRingDiameter.Properties.Mask.EditMask = "N00"
            Me.spinRingDiameter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinRingDiameter.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinRingDiameter.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinRingDiameter.Size = New System.Drawing.Size(107, 20)
            Me.spinRingDiameter.TabIndex = 6
            ' 
            ' lblRingDiameter
            ' 
            Me.lblRingDiameter.Location = New System.Drawing.Point(22, 31)
            Me.lblRingDiameter.Name = "lblRingDiameter"
            Me.lblRingDiameter.Size = New System.Drawing.Size(119, 13)
            Me.lblRingDiameter.TabIndex = 1
            Me.lblRingDiameter.Text = "Ring animation diameter:"
            ' 
            ' groupLineProperties
            ' 
            Me.groupLineProperties.CaptionImageUri.Uri = ""
            Me.groupLineProperties.Controls.Add(Me.lblLineElementType)
            Me.groupLineProperties.Controls.Add(Me.comboBoxLineElementType)
            Me.groupLineProperties.Controls.Add(Me.spinLineHeight)
            Me.groupLineProperties.Controls.Add(Me.lblLineHeight)
            Me.groupLineProperties.Location = New System.Drawing.Point(495, 350)
            Me.groupLineProperties.Margin = New System.Windows.Forms.Padding(15)
            Me.groupLineProperties.Name = "groupLineProperties"
            Me.groupLineProperties.Padding = New System.Windows.Forms.Padding(5)
            Me.groupLineProperties.Size = New System.Drawing.Size(301, 88)
            Me.groupLineProperties.TabIndex = 10
            Me.groupLineProperties.Text = "Line animation properties"
            ' 
            ' lblLineElementType
            ' 
            Me.lblLineElementType.Location = New System.Drawing.Point(22, 59)
            Me.lblLineElementType.Name = "lblLineElementType"
            Me.lblLineElementType.Size = New System.Drawing.Size(138, 13)
            Me.lblLineElementType.TabIndex = 3
            Me.lblLineElementType.Text = "Line animation element type:"
            ' 
            ' comboBoxLineElementType
            ' 
            Me.comboBoxLineElementType.EditValue = "Circle"
            Me.comboBoxLineElementType.Enabled = False
            Me.comboBoxLineElementType.Location = New System.Drawing.Point(179, 56)
            Me.comboBoxLineElementType.Name = "comboBoxLineElementType"
            Me.comboBoxLineElementType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxLineElementType.Properties.Items.AddRange(New Object() {"Circle", "Rectangle", "Triangle"})
            Me.comboBoxLineElementType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxLineElementType.Size = New System.Drawing.Size(107, 20)
            Me.comboBoxLineElementType.TabIndex = 2
            ' 
            ' spinLineHeight
            ' 
            Me.spinLineHeight.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinLineHeight.Enabled = False
            Me.spinLineHeight.Location = New System.Drawing.Point(179, 30)
            Me.spinLineHeight.Name = "spinLineHeight"
            Me.spinLineHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinLineHeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinLineHeight.Properties.IsFloatValue = False
            Me.spinLineHeight.Properties.Mask.EditMask = "N00"
            Me.spinLineHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinLineHeight.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinLineHeight.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinLineHeight.Size = New System.Drawing.Size(107, 20)
            Me.spinLineHeight.TabIndex = 6
            ' 
            ' lblLineHeight
            ' 
            Me.lblLineHeight.Location = New System.Drawing.Point(22, 33)
            Me.lblLineHeight.Name = "lblLineHeight"
            Me.lblLineHeight.Size = New System.Drawing.Size(146, 13)
            Me.lblLineHeight.TabIndex = 1
            Me.lblLineHeight.Text = "Line animation element height:"
            ' 
            ' groupAnimationProperties
            ' 
            Me.groupAnimationProperties.CaptionImageUri.Uri = ""
            Me.groupAnimationProperties.Controls.Add(Me.labelControl5)
            Me.groupAnimationProperties.Controls.Add(Me.colorEditElementColor)
            Me.groupAnimationProperties.Controls.Add(Me.spinSpeed)
            Me.groupAnimationProperties.Controls.Add(Me.spinAcceleration)
            Me.groupAnimationProperties.Controls.Add(Me.lblSpeed)
            Me.groupAnimationProperties.Controls.Add(Me.lblAcceleration)
            Me.groupAnimationProperties.Controls.Add(Me.lblElementCount)
            Me.groupAnimationProperties.Controls.Add(Me.spinElementCount)
            Me.groupAnimationProperties.Location = New System.Drawing.Point(495, 186)
            Me.groupAnimationProperties.Margin = New System.Windows.Forms.Padding(10)
            Me.groupAnimationProperties.Name = "groupAnimationProperties"
            Me.groupAnimationProperties.Padding = New System.Windows.Forms.Padding(5)
            Me.groupAnimationProperties.Size = New System.Drawing.Size(301, 139)
            Me.groupAnimationProperties.TabIndex = 11
            Me.groupAnimationProperties.Text = "Animation Properties"
            ' 
            ' labelControl5
            ' 
            Me.labelControl5.Location = New System.Drawing.Point(22, 111)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(118, 13)
            Me.labelControl5.TabIndex = 20
            Me.labelControl5.Text = "Animation element color:"
            ' 
            ' colorEditElementColor
            ' 
            Me.colorEditElementColor.EditValue = System.Drawing.Color.Empty
            Me.colorEditElementColor.Location = New System.Drawing.Point(179, 108)
            Me.colorEditElementColor.Name = "colorEditElementColor"
            Me.colorEditElementColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditElementColor.Size = New System.Drawing.Size(107, 20)
            Me.colorEditElementColor.TabIndex = 19
            ' 
            ' spinSpeed
            ' 
            Me.spinSpeed.EditValue = New Decimal(New Integer() {55, 0, 0, 65536})
            Me.spinSpeed.Location = New System.Drawing.Point(179, 82)
            Me.spinSpeed.Name = "spinSpeed"
            Me.spinSpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinSpeed.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinSpeed.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.spinSpeed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinSpeed.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinSpeed.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinSpeed.Size = New System.Drawing.Size(107, 20)
            Me.spinSpeed.TabIndex = 6
            ' 
            ' spinAcceleration
            ' 
            Me.spinAcceleration.EditValue = New Decimal(New Integer() {70, 0, 0, 65536})
            Me.spinAcceleration.Location = New System.Drawing.Point(179, 56)
            Me.spinAcceleration.Name = "spinAcceleration"
            Me.spinAcceleration.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinAcceleration.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinAcceleration.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.spinAcceleration.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinAcceleration.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinAcceleration.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinAcceleration.Size = New System.Drawing.Size(107, 20)
            Me.spinAcceleration.TabIndex = 5
            ' 
            ' lblSpeed
            ' 
            Me.lblSpeed.Location = New System.Drawing.Point(22, 85)
            Me.lblSpeed.Name = "lblSpeed"
            Me.lblSpeed.Size = New System.Drawing.Size(83, 13)
            Me.lblSpeed.TabIndex = 3
            Me.lblSpeed.Text = "Animation speed:"
            ' 
            ' lblAcceleration
            ' 
            Me.lblAcceleration.Location = New System.Drawing.Point(22, 59)
            Me.lblAcceleration.Name = "lblAcceleration"
            Me.lblAcceleration.Size = New System.Drawing.Size(112, 13)
            Me.lblAcceleration.TabIndex = 2
            Me.lblAcceleration.Text = "Animation acceleration:"
            ' 
            ' lblElementCount
            ' 
            Me.lblElementCount.Location = New System.Drawing.Point(22, 33)
            Me.lblElementCount.Name = "lblElementCount"
            Me.lblElementCount.Size = New System.Drawing.Size(122, 13)
            Me.lblElementCount.TabIndex = 0
            Me.lblElementCount.Text = "Animation element count:"
            ' 
            ' spinElementCount
            ' 
            Me.spinElementCount.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinElementCount.Location = New System.Drawing.Point(179, 30)
            Me.spinElementCount.Name = "spinElementCount"
            Me.spinElementCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinElementCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinElementCount.Properties.IsFloatValue = False
            Me.spinElementCount.Properties.Mask.EditMask = "N00"
            Me.spinElementCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinElementCount.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinElementCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinElementCount.Size = New System.Drawing.Size(107, 20)
            Me.spinElementCount.TabIndex = 4
            ' 
            ' groupPanelProperties
            ' 
            Me.groupPanelProperties.CaptionImageUri.Uri = ""
            Me.groupPanelProperties.Controls.Add(Me.spinFrameInterval)
            Me.groupPanelProperties.Controls.Add(Me.lblFrameInterval)
            Me.groupPanelProperties.Controls.Add(Me.spinFrameCount)
            Me.groupPanelProperties.Controls.Add(Me.lblFrameCount)
            Me.groupPanelProperties.Controls.Add(Me.lblAnimationType)
            Me.groupPanelProperties.Controls.Add(Me.comboBoxAnimationType)
            Me.groupPanelProperties.Location = New System.Drawing.Point(495, 46)
            Me.groupPanelProperties.Margin = New System.Windows.Forms.Padding(15)
            Me.groupPanelProperties.Name = "groupPanelProperties"
            Me.groupPanelProperties.Padding = New System.Windows.Forms.Padding(5)
            Me.groupPanelProperties.Size = New System.Drawing.Size(301, 115)
            Me.groupPanelProperties.TabIndex = 9
            Me.groupPanelProperties.Text = "ProgressPanel properties"
            ' 
            ' spinFrameInterval
            ' 
            Me.spinFrameInterval.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinFrameInterval.Location = New System.Drawing.Point(179, 82)
            Me.spinFrameInterval.Name = "spinFrameInterval"
            Me.spinFrameInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinFrameInterval.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinFrameInterval.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinFrameInterval.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinFrameInterval.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.spinFrameInterval.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinFrameInterval.Size = New System.Drawing.Size(107, 20)
            Me.spinFrameInterval.TabIndex = 14
            ' 
            ' lblFrameInterval
            ' 
            Me.lblFrameInterval.Location = New System.Drawing.Point(22, 85)
            Me.lblFrameInterval.Name = "lblFrameInterval"
            Me.lblFrameInterval.Size = New System.Drawing.Size(73, 13)
            Me.lblFrameInterval.TabIndex = 13
            Me.lblFrameInterval.Text = "Frame interval:"
            ' 
            ' spinFrameCount
            ' 
            Me.spinFrameCount.EditValue = New Decimal(New Integer() {38000, 0, 0, 0})
            Me.spinFrameCount.Location = New System.Drawing.Point(179, 56)
            Me.spinFrameCount.Name = "spinFrameCount"
            Me.spinFrameCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinFrameCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.spinFrameCount.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinFrameCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinFrameCount.Properties.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.spinFrameCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinFrameCount.Size = New System.Drawing.Size(107, 20)
            Me.spinFrameCount.TabIndex = 12
            ' 
            ' lblFrameCount
            ' 
            Me.lblFrameCount.Location = New System.Drawing.Point(22, 59)
            Me.lblFrameCount.Name = "lblFrameCount"
            Me.lblFrameCount.Size = New System.Drawing.Size(64, 13)
            Me.lblFrameCount.TabIndex = 11
            Me.lblFrameCount.Text = "Frame count:"
            ' 
            ' lblAnimationType
            ' 
            Me.lblAnimationType.Location = New System.Drawing.Point(22, 33)
            Me.lblAnimationType.Name = "lblAnimationType"
            Me.lblAnimationType.Size = New System.Drawing.Size(100, 13)
            Me.lblAnimationType.TabIndex = 1
            Me.lblAnimationType.Text = "Wait animation type:"
            ' 
            ' comboBoxAnimationType
            ' 
            Me.comboBoxAnimationType.EditValue = "Ring"
            Me.comboBoxAnimationType.Location = New System.Drawing.Point(179, 30)
            Me.comboBoxAnimationType.Name = "comboBoxAnimationType"
            Me.comboBoxAnimationType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxAnimationType.Properties.Items.AddRange(New Object() {"Default", "Line", "Ring"})
            Me.comboBoxAnimationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxAnimationType.Size = New System.Drawing.Size(107, 20)
            Me.comboBoxAnimationType.TabIndex = 0
            ' 
            ' groupSample
            ' 
            Me.groupSample.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupSample.Appearance.Options.UseBackColor = True
            Me.groupSample.CaptionImageUri.Uri = ""
            Me.groupSample.Controls.Add(Me.progressPanelSample)
            Me.groupSample.Location = New System.Drawing.Point(37, 46)
            Me.groupSample.Margin = New System.Windows.Forms.Padding(15)
            Me.groupSample.Name = "groupSample"
            Me.groupSample.Size = New System.Drawing.Size(428, 480)
            Me.groupSample.TabIndex = 8
            Me.groupSample.Text = "Sample"
            ' 
            ' progressPanelSample
            ' 
            Me.progressPanelSample.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.progressPanelSample.Appearance.Options.UseBackColor = True
            Me.progressPanelSample.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.progressPanelSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.progressPanelSample.Location = New System.Drawing.Point(2, 20)
            Me.progressPanelSample.Name = "progressPanelSample"
            Me.progressPanelSample.Size = New System.Drawing.Size(424, 458)
            Me.progressPanelSample.TabIndex = 0
            Me.progressPanelSample.Text = "progressPanel1"
            Me.progressPanelSample.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            Me.xtraTabControl1.Size = New System.Drawing.Size(874, 685)
            Me.xtraTabControl1.TabIndex = 13
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.groupSample)
            Me.xtraTabPage1.Controls.Add(Me.groupRingProperties)
            Me.xtraTabPage1.Controls.Add(Me.groupPanelProperties)
            Me.xtraTabPage1.Controls.Add(Me.groupLineProperties)
            Me.xtraTabPage1.Controls.Add(Me.groupAnimationProperties)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(868, 679)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' ModuleProgressPanel
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleProgressPanel"
            Me.Size = New System.Drawing.Size(879, 690)
            CType(Me.groupRingProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupRingProperties.ResumeLayout(False)
            Me.groupRingProperties.PerformLayout()
            CType(Me.spinRingDiameter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupLineProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupLineProperties.ResumeLayout(False)
            Me.groupLineProperties.PerformLayout()
            CType(Me.comboBoxLineElementType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinLineHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupAnimationProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupAnimationProperties.ResumeLayout(False)
            Me.groupAnimationProperties.PerformLayout()
            CType(Me.colorEditElementColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinSpeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinAcceleration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinElementCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupPanelProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupPanelProperties.ResumeLayout(False)
            Me.groupPanelProperties.PerformLayout()
            CType(Me.spinFrameInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinFrameCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAnimationType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupSample, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupSample.ResumeLayout(False)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private groupRingProperties As GroupControl
        Private WithEvents spinRingDiameter As SpinEdit
        Private lblRingDiameter As LabelControl
        Private groupLineProperties As GroupControl
        Private lblLineElementType As LabelControl
        Private WithEvents comboBoxLineElementType As ComboBoxEdit
        Private WithEvents spinLineHeight As SpinEdit
        Private lblLineHeight As LabelControl
        Private groupAnimationProperties As GroupControl
        Private WithEvents spinSpeed As SpinEdit
        Private WithEvents spinAcceleration As SpinEdit
        Private lblSpeed As LabelControl
        Private lblAcceleration As LabelControl
        Private lblElementCount As LabelControl
        Private WithEvents spinElementCount As SpinEdit
        Private groupPanelProperties As GroupControl
        Private lblAnimationType As LabelControl
        Private WithEvents comboBoxAnimationType As ComboBoxEdit
        Private groupSample As GroupControl
        Private progressPanelSample As XtraWaitForm.ProgressPanel
        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private xtraTabPage1 As XtraTab.XtraTabPage
        Private WithEvents spinFrameInterval As SpinEdit
        Private lblFrameInterval As LabelControl
        Private WithEvents spinFrameCount As SpinEdit
        Private lblFrameCount As LabelControl
        Private labelControl5 As LabelControl
        Private WithEvents colorEditElementColor As ColorEdit
    End Class
End Namespace

