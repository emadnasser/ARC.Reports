Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTrackBar
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
			Me.seLabelDistance = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.ceShowTickLabels = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowCustomValue = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowValue = New DevExpress.XtraEditors.CheckEdit()
			Me.seTickFrequency = New DevExpress.XtraEditors.SpinEdit()
			Me.seLargeChange = New DevExpress.XtraEditors.SpinEdit()
			Me.seSmallChange = New DevExpress.XtraEditors.SpinEdit()
			Me.seMaximum = New DevExpress.XtraEditors.SpinEdit()
			Me.seMinimum = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbTickStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.checkEditVertical = New DevExpress.XtraEditors.CheckEdit()
			Me.lblBarStyle = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.seLabelDistance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowTickLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowCustomValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seTickFrequency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seLargeChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seSmallChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMaximum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMinimum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbTickStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(873, 643)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl3)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(867, 637)
			Me.xtraTabPage1.Text = "Layout and Appearance"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.seLabelDistance)
			Me.groupControl2.Controls.Add(Me.labelControl6)
			Me.groupControl2.Controls.Add(Me.ceShowTickLabels)
			Me.groupControl2.Controls.Add(Me.ceShowCustomValue)
			Me.groupControl2.Controls.Add(Me.ceShowValue)
			Me.groupControl2.Controls.Add(Me.seTickFrequency)
			Me.groupControl2.Controls.Add(Me.seLargeChange)
			Me.groupControl2.Controls.Add(Me.seSmallChange)
			Me.groupControl2.Controls.Add(Me.seMaximum)
			Me.groupControl2.Controls.Add(Me.seMinimum)
			Me.groupControl2.Controls.Add(Me.labelControl5)
			Me.groupControl2.Controls.Add(Me.labelControl4)
			Me.groupControl2.Controls.Add(Me.labelControl3)
			Me.groupControl2.Controls.Add(Me.labelControl2)
			Me.groupControl2.Controls.Add(Me.labelControl1)
			Me.groupControl2.Controls.Add(Me.icbTickStyle)
			Me.groupControl2.Controls.Add(Me.checkEditVertical)
			Me.groupControl2.Controls.Add(Me.lblBarStyle)
			Me.groupControl2.Location = New System.Drawing.Point(309, 30)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(273, 353)
			Me.groupControl2.TabIndex = 4
			Me.groupControl2.Text = "Properties"
			' 
			' seLabelDistance
			' 
			Me.seLabelDistance.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.seLabelDistance.Enabled = False
			Me.seLabelDistance.Location = New System.Drawing.Point(112, 314)
			Me.seLabelDistance.Name = "seLabelDistance"
			Me.seLabelDistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seLabelDistance.Properties.IsFloatValue = False
			Me.seLabelDistance.Properties.Mask.EditMask = "N00"
			Me.seLabelDistance.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.seLabelDistance.Properties.MinValue = New Decimal(New Integer() { 5, 0, 0, -2147483648})
			Me.seLabelDistance.Size = New System.Drawing.Size(136, 20)
			Me.seLabelDistance.TabIndex = 10
'			Me.seLabelDistance.EditValueChanged += New System.EventHandler(Me.seLabelDistance_EditValueChanged)
			' 
			' labelControl6
			' 
			Me.labelControl6.Location = New System.Drawing.Point(20, 317)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(73, 13)
			Me.labelControl6.TabIndex = 15
			Me.labelControl6.Text = "Label Distance:"
			' 
			' ceShowTickLabels
			' 
			Me.ceShowTickLabels.AllowDrop = True
			Me.ceShowTickLabels.Location = New System.Drawing.Point(18, 136)
			Me.ceShowTickLabels.Name = "ceShowTickLabels"
			Me.ceShowTickLabels.Properties.Caption = "Show Labels"
			Me.ceShowTickLabels.Size = New System.Drawing.Size(200, 19)
			Me.ceShowTickLabels.TabIndex = 4
'			Me.ceShowTickLabels.CheckedChanged += New System.EventHandler(Me.ceShowTickLabels_CheckedChanged)
			' 
			' ceShowCustomValue
			' 
			Me.ceShowCustomValue.EditValue = True
			Me.ceShowCustomValue.Location = New System.Drawing.Point(18, 111)
			Me.ceShowCustomValue.Name = "ceShowCustomValue"
			Me.ceShowCustomValue.Properties.Caption = "Show Custom Value"
			Me.ceShowCustomValue.Size = New System.Drawing.Size(200, 19)
			Me.ceShowCustomValue.TabIndex = 3
			' 
			' ceShowValue
			' 
			Me.ceShowValue.Location = New System.Drawing.Point(18, 86)
			Me.ceShowValue.Name = "ceShowValue"
			Me.ceShowValue.Properties.Caption = "Show Value ToolTip"
			Me.ceShowValue.Size = New System.Drawing.Size(200, 19)
			Me.ceShowValue.TabIndex = 2
'			Me.ceShowValue.CheckedChanged += New System.EventHandler(Me.ceShowValue_CheckedChanged)
			' 
			' seTickFrequency
			' 
			Me.seTickFrequency.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seTickFrequency.Location = New System.Drawing.Point(112, 285)
			Me.seTickFrequency.Name = "seTickFrequency"
			Me.seTickFrequency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seTickFrequency.Properties.IsFloatValue = False
			Me.seTickFrequency.Properties.Mask.EditMask = "N00"
			Me.seTickFrequency.Size = New System.Drawing.Size(136, 20)
			Me.seTickFrequency.TabIndex = 9
'			Me.seTickFrequency.EditValueChanged += New System.EventHandler(Me.seTickFrequency_EditValueChanged)
			' 
			' seLargeChange
			' 
			Me.seLargeChange.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seLargeChange.Location = New System.Drawing.Point(112, 256)
			Me.seLargeChange.Name = "seLargeChange"
			Me.seLargeChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seLargeChange.Properties.IsFloatValue = False
			Me.seLargeChange.Properties.Mask.EditMask = "N00"
			Me.seLargeChange.Size = New System.Drawing.Size(136, 20)
			Me.seLargeChange.TabIndex = 8
'			Me.seLargeChange.EditValueChanged += New System.EventHandler(Me.seLargeChange_EditValueChanged)
			' 
			' seSmallChange
			' 
			Me.seSmallChange.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seSmallChange.Location = New System.Drawing.Point(112, 227)
			Me.seSmallChange.Name = "seSmallChange"
			Me.seSmallChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seSmallChange.Properties.IsFloatValue = False
			Me.seSmallChange.Properties.Mask.EditMask = "N00"
			Me.seSmallChange.Size = New System.Drawing.Size(136, 20)
			Me.seSmallChange.TabIndex = 7
'			Me.seSmallChange.EditValueChanged += New System.EventHandler(Me.seSmallChange_EditValueChanged)
			' 
			' seMaximum
			' 
			Me.seMaximum.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMaximum.Location = New System.Drawing.Point(112, 198)
			Me.seMaximum.Name = "seMaximum"
			Me.seMaximum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMaximum.Properties.IsFloatValue = False
			Me.seMaximum.Properties.Mask.EditMask = "N00"
			Me.seMaximum.Size = New System.Drawing.Size(136, 20)
			Me.seMaximum.TabIndex = 6
'			Me.seMaximum.EditValueChanged += New System.EventHandler(Me.seMaximum_EditValueChanged)
			' 
			' seMinimum
			' 
			Me.seMinimum.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMinimum.Location = New System.Drawing.Point(112, 169)
			Me.seMinimum.Name = "seMinimum"
			Me.seMinimum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMinimum.Properties.IsFloatValue = False
			Me.seMinimum.Properties.Mask.EditMask = "N00"
			Me.seMinimum.Size = New System.Drawing.Size(136, 20)
			Me.seMinimum.TabIndex = 5
'			Me.seMinimum.EditValueChanged += New System.EventHandler(Me.seMinimum_EditValueChanged)
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(20, 288)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(76, 13)
			Me.labelControl5.TabIndex = 12
			Me.labelControl5.Text = "Tick Frequency:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(20, 259)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(71, 13)
			Me.labelControl4.TabIndex = 11
			Me.labelControl4.Text = "Large Change:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(20, 230)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(68, 13)
			Me.labelControl3.TabIndex = 10
			Me.labelControl3.Text = "Small Change:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(20, 201)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(48, 13)
			Me.labelControl2.TabIndex = 9
			Me.labelControl2.Text = "Maximum:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 172)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(44, 13)
			Me.labelControl1.TabIndex = 8
			Me.labelControl1.Text = "Minimum:"
			' 
			' icbTickStyle
			' 
			Me.icbTickStyle.Location = New System.Drawing.Point(112, 32)
			Me.icbTickStyle.Name = "icbTickStyle"
			Me.icbTickStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbTickStyle.Size = New System.Drawing.Size(136, 20)
			Me.icbTickStyle.TabIndex = 0
'			Me.icbTickStyle.SelectedIndexChanged += New System.EventHandler(Me.icbTickStyle_SelectedIndexChanged)
			' 
			' checkEditVertical
			' 
			Me.checkEditVertical.Location = New System.Drawing.Point(18, 61)
			Me.checkEditVertical.Name = "checkEditVertical"
			Me.checkEditVertical.Properties.Caption = "Vertical"
			Me.checkEditVertical.Size = New System.Drawing.Size(200, 19)
			Me.checkEditVertical.TabIndex = 1
'			Me.checkEditVertical.CheckedChanged += New System.EventHandler(Me.checkEditVertical_CheckedChanged)
			' 
			' lblBarStyle
			' 
			Me.lblBarStyle.Location = New System.Drawing.Point(20, 35)
			Me.lblBarStyle.Name = "lblBarStyle"
			Me.lblBarStyle.Size = New System.Drawing.Size(48, 13)
			Me.lblBarStyle.TabIndex = 7
			Me.lblBarStyle.Text = "Tick style:"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.trackBarControl1)
			Me.groupControl3.Location = New System.Drawing.Point(30, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(248, 353)
			Me.groupControl3.TabIndex = 0
			Me.groupControl3.Text = "Sample"
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.EditValue = Nothing
			Me.trackBarControl1.Location = New System.Drawing.Point(15, 142)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarControl1.Properties.ShowValueToolTip = True
			Me.trackBarControl1.Size = New System.Drawing.Size(176, 45)
			Me.trackBarControl1.TabIndex = 0
'			Me.trackBarControl1.BeforeShowValueToolTip += New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(Me.trackBarControl1_BeforeShowValueToolTip)
			' 
			' ModuleTrackBar
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleTrackBar"
			Me.Size = New System.Drawing.Size(878, 648)
'			Me.Load += New System.EventHandler(Me.ModuleTrackBar_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.seLabelDistance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowTickLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowCustomValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seTickFrequency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seLargeChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seSmallChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMaximum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMinimum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbTickStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.groupControl3.PerformLayout()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkEditVertical As DevExpress.XtraEditors.CheckEdit
		Private lblBarStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
		Private WithEvents icbTickStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seMinimum As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seMaximum As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seSmallChange As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seLargeChange As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seTickFrequency As DevExpress.XtraEditors.SpinEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents ceShowValue As DevExpress.XtraEditors.CheckEdit
		Private ceShowCustomValue As DevExpress.XtraEditors.CheckEdit
		Private WithEvents seLabelDistance As DevExpress.XtraEditors.SpinEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceShowTickLabels As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
