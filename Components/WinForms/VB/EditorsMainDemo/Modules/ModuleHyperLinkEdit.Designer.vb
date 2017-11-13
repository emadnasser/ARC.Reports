Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleHyperLinkEdit
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleHyperLinkEdit))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.lbAddress = New DevExpress.XtraEditors.LabelControl()
			Me.label8 = New DevExpress.XtraEditors.LabelControl()
			Me.colorEditLinkColor = New DevExpress.XtraEditors.ColorEdit()
			Me.label6 = New DevExpress.XtraEditors.LabelControl()
			Me.icbAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.teCaption = New DevExpress.XtraEditors.TextEdit()
			Me.sbImageClear = New DevExpress.XtraEditors.SimpleButton()
			Me.sbImageSet = New DevExpress.XtraEditors.SimpleButton()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label5 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceSingleClick = New DevExpress.XtraEditors.CheckEdit()
			Me.lbStartKey = New DevExpress.XtraEditors.LabelControl()
			Me.icbWindowStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.hyperLinkEditSample = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.meFiringEvents = New DevExpress.XtraEditors.MemoEdit()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.hyperLinkEdit2 = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.colorEditLinkColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceSingleClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbWindowStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.hyperLinkEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.hyperLinkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(817, 597)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(811, 569)
			Me.xtraTabPage1.Text = "General"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.lbAddress)
			Me.groupControl2.Controls.Add(Me.label8)
			Me.groupControl2.Controls.Add(Me.colorEditLinkColor)
			Me.groupControl2.Controls.Add(Me.label6)
			Me.groupControl2.Controls.Add(Me.icbAlignment)
			Me.groupControl2.Controls.Add(Me.label3)
			Me.groupControl2.Controls.Add(Me.teCaption)
			Me.groupControl2.Controls.Add(Me.sbImageClear)
			Me.groupControl2.Controls.Add(Me.sbImageSet)
			Me.groupControl2.Controls.Add(Me.label4)
			Me.groupControl2.Controls.Add(Me.label5)
			Me.groupControl2.Location = New System.Drawing.Point(309, 180)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(333, 183)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Appearance"
			' 
			' lbAddress
			' 
			Me.lbAddress.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbAddress.Location = New System.Drawing.Point(140, 35)
			Me.lbAddress.Name = "lbAddress"
			Me.lbAddress.Size = New System.Drawing.Size(26, 13)
			Me.lbAddress.TabIndex = 25
			Me.lbAddress.Text = "Text"
			' 
			' label8
			' 
			Me.label8.Location = New System.Drawing.Point(20, 35)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(43, 13)
			Me.label8.TabIndex = 24
			Me.label8.Text = "Address:"
			' 
			' colorEditLinkColor
			' 
			Me.colorEditLinkColor.EditValue = System.Drawing.Color.Empty
			Me.colorEditLinkColor.Location = New System.Drawing.Point(140, 144)
			Me.colorEditLinkColor.Name = "colorEditLinkColor"
			Me.colorEditLinkColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEditLinkColor.Size = New System.Drawing.Size(172, 20)
			Me.colorEditLinkColor.TabIndex = 23
'			Me.colorEditLinkColor.EditValueChanged += New System.EventHandler(Me.colorEditLinkColor_EditValueChanged)
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(20, 147)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(48, 13)
			Me.label6.TabIndex = 22
			Me.label6.Text = "Link color:"
			' 
			' icbAlignment
			' 
			Me.icbAlignment.EditValue = "imageComboBoxEdit1"
			Me.icbAlignment.Location = New System.Drawing.Point(140, 115)
			Me.icbAlignment.Name = "icbAlignment"
			Me.icbAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbAlignment.Size = New System.Drawing.Size(172, 20)
			Me.icbAlignment.TabIndex = 3
'			Me.icbAlignment.SelectedIndexChanged += New System.EventHandler(Me.icbAlignment_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 118)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(83, 13)
			Me.label3.TabIndex = 17
			Me.label3.Text = "Image alignment:"
			' 
			' teCaption
			' 
			Me.teCaption.EditValue = ""
			Me.teCaption.Location = New System.Drawing.Point(140, 57)
			Me.teCaption.Name = "teCaption"
			Me.teCaption.Size = New System.Drawing.Size(172, 20)
			Me.teCaption.TabIndex = 0
'			Me.teCaption.EditValueChanged += New System.EventHandler(Me.teCaption_EditValueChanged)
			' 
			' sbImageClear
			' 
			Me.sbImageClear.Location = New System.Drawing.Point(229, 86)
			Me.sbImageClear.Name = "sbImageClear"
			Me.sbImageClear.Size = New System.Drawing.Size(83, 20)
			Me.sbImageClear.TabIndex = 2
			Me.sbImageClear.Text = "Clear"
'			Me.sbImageClear.Click += New System.EventHandler(Me.sbImageClear_Click)
			' 
			' sbImageSet
			' 
			Me.sbImageSet.Location = New System.Drawing.Point(140, 86)
			Me.sbImageSet.Name = "sbImageSet"
			Me.sbImageSet.Size = New System.Drawing.Size(83, 20)
			Me.sbImageSet.TabIndex = 1
			Me.sbImageSet.Text = "Set"
'			Me.sbImageSet.Click += New System.EventHandler(Me.sbImageSet_Click)
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 88)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(34, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Image:"
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(20, 60)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(41, 13)
			Me.label5.TabIndex = 15
			Me.label5.Text = "Caption:"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceSingleClick)
			Me.groupControl1.Controls.Add(Me.lbStartKey)
			Me.groupControl1.Controls.Add(Me.icbWindowStyle)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Location = New System.Drawing.Point(309, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(333, 129)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Browser"
			' 
			' ceSingleClick
			' 
			Me.ceSingleClick.Location = New System.Drawing.Point(18, 87)
			Me.ceSingleClick.Name = "ceSingleClick"
			Me.ceSingleClick.Properties.Caption = "Single click"
			Me.ceSingleClick.Size = New System.Drawing.Size(222, 19)
			Me.ceSingleClick.TabIndex = 21
'			Me.ceSingleClick.CheckedChanged += New System.EventHandler(Me.ceSingleClick_CheckedChanged)
			' 
			' lbStartKey
			' 
			Me.lbStartKey.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbStartKey.Location = New System.Drawing.Point(140, 62)
			Me.lbStartKey.Name = "lbStartKey"
			Me.lbStartKey.Size = New System.Drawing.Size(21, 13)
			Me.lbStartKey.TabIndex = 19
			Me.lbStartKey.Text = "Key"
			' 
			' icbWindowStyle
			' 
			Me.icbWindowStyle.EditValue = "imageComboBoxEdit1"
			Me.icbWindowStyle.Location = New System.Drawing.Point(140, 32)
			Me.icbWindowStyle.Name = "icbWindowStyle"
			Me.icbWindowStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbWindowStyle.Size = New System.Drawing.Size(172, 20)
			Me.icbWindowStyle.TabIndex = 20
'			Me.icbWindowStyle.SelectedIndexChanged += New System.EventHandler(Me.icbWindowStyle_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 62)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(48, 13)
			Me.label1.TabIndex = 16
			Me.label1.Text = "Start key:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 35)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(108, 13)
			Me.label2.TabIndex = 15
			Me.label2.Text = "Browser window style:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.hyperLinkEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(248, 333)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' hyperLinkEditSample
			' 
			Me.hyperLinkEditSample.EditValue = "www.devexpress.com"
			Me.hyperLinkEditSample.Location = New System.Drawing.Point(12, 48)
			Me.hyperLinkEditSample.Name = "hyperLinkEditSample"
			Me.hyperLinkEditSample.Properties.Caption = "Developer Express on the Web"
			Me.hyperLinkEditSample.Properties.Image = (CType(resources.GetObject("hyperLinkEditSample.Properties.Image"), System.Drawing.Image))
			Me.hyperLinkEditSample.Size = New System.Drawing.Size(212, 24)
			Me.hyperLinkEditSample.TabIndex = 0
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.groupControl5)
			Me.xtraTabPage2.Controls.Add(Me.groupControl3)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(811, 569)
			Me.xtraTabPage2.Text = "Events"
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.Controls.Add(Me.meFiringEvents)
			Me.groupControl5.Location = New System.Drawing.Point(309, 30)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl5.Size = New System.Drawing.Size(308, 209)
			Me.groupControl5.TabIndex = 5
			Me.groupControl5.Text = "OpenLink event log"
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
			Me.meFiringEvents.Size = New System.Drawing.Size(288, 170)
			Me.meFiringEvents.TabIndex = 0
			Me.meFiringEvents.UseOptimizedRendering = True
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.hyperLinkEdit2)
			Me.groupControl3.Controls.Add(Me.hyperLinkEdit1)
			Me.groupControl3.Location = New System.Drawing.Point(30, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(248, 209)
			Me.groupControl3.TabIndex = 2
			Me.groupControl3.Text = "Samples"
			' 
			' hyperLinkEdit2
			' 
			Me.hyperLinkEdit2.EditValue = "http://www.devexpress.com/Products/Net/"
			Me.hyperLinkEdit2.Location = New System.Drawing.Point(22, 95)
			Me.hyperLinkEdit2.Name = "hyperLinkEdit2"
			Me.hyperLinkEdit2.Properties.AccessibleName = "custom"
			Me.hyperLinkEdit2.Properties.AllowFocused = False
			Me.hyperLinkEdit2.Properties.Appearance.BackColor = System.Drawing.Color.LavenderBlush
			Me.hyperLinkEdit2.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.hyperLinkEdit2.Properties.Appearance.Options.UseBackColor = True
			Me.hyperLinkEdit2.Properties.Appearance.Options.UseForeColor = True
			Me.hyperLinkEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Online Order", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, False)})
			Me.hyperLinkEdit2.Properties.Caption = "Technologies"
			Me.hyperLinkEdit2.Properties.Image = (CType(resources.GetObject("hyperLinkEdit2.Properties.Image"), System.Drawing.Image))
			Me.hyperLinkEdit2.Size = New System.Drawing.Size(198, 24)
			Me.hyperLinkEdit2.TabIndex = 8
'			Me.hyperLinkEdit2.OpenLink += New DevExpress.XtraEditors.Controls.OpenLinkEventHandler(Me.hyperLinkEdit_OpenLink)
'			Me.hyperLinkEdit2.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.hyperLinkEdit2_ButtonClick)
			' 
			' hyperLinkEdit1
			' 
			Me.hyperLinkEdit1.EditValue = "mailto:support@devexpress.com"
			Me.hyperLinkEdit1.Location = New System.Drawing.Point(22, 54)
			Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
			Me.hyperLinkEdit1.Properties.AllowFocused = False
			Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
			Me.hyperLinkEdit1.Properties.Caption = "Mail message to support"
			Me.hyperLinkEdit1.Properties.Image = (CType(resources.GetObject("hyperLinkEdit1.Properties.Image"), System.Drawing.Image))
			Me.hyperLinkEdit1.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.hyperLinkEdit1.Properties.LinkColor = System.Drawing.Color.OrangeRed
			Me.hyperLinkEdit1.Size = New System.Drawing.Size(198, 24)
			Me.hyperLinkEdit1.TabIndex = 7
'			Me.hyperLinkEdit1.OpenLink += New DevExpress.XtraEditors.Controls.OpenLinkEventHandler(Me.hyperLinkEdit_OpenLink)
			' 
			' ModuleHyperLinkEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleHyperLinkEdit"
			Me.Size = New System.Drawing.Size(822, 602)
'			Me.Load += New System.EventHandler(Me.ModuleHyperLinkEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.colorEditLinkColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceSingleClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbWindowStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.hyperLinkEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.hyperLinkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private hyperLinkEditSample As DevExpress.XtraEditors.HyperLinkEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private lbStartKey As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbWindowStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceSingleClick As DevExpress.XtraEditors.CheckEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbImageClear As DevExpress.XtraEditors.SimpleButton
		Private WithEvents teCaption As DevExpress.XtraEditors.TextEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbImageSet As DevExpress.XtraEditors.SimpleButton
		Private WithEvents icbAlignment As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label6 As DevExpress.XtraEditors.LabelControl
		Private WithEvents colorEditLinkColor As DevExpress.XtraEditors.ColorEdit
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private lbAddress As DevExpress.XtraEditors.LabelControl
		Private label8 As DevExpress.XtraEditors.LabelControl
		Private WithEvents hyperLinkEdit2 As DevExpress.XtraEditors.HyperLinkEdit
		Private WithEvents hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private meFiringEvents As DevExpress.XtraEditors.MemoEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
