Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ButtonProperties
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
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.teCaption = New DevExpress.XtraEditors.TextEdit()
			Me.teToolTip = New DevExpress.XtraEditors.TextEdit()
			Me.icbKind = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.seWidth = New DevExpress.XtraEditors.SpinEdit()
			Me.ceEnabled = New DevExpress.XtraEditors.CheckEdit()
			Me.ceVisible = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.sbImageClear = New DevExpress.XtraEditors.SimpleButton()
			Me.icbAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.sbImageLoad = New DevExpress.XtraEditors.SimpleButton()
			Me.label5 = New DevExpress.XtraEditors.LabelControl()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.teCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teToolTip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceEnabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(16, 21)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(41, 13)
			Me.lblSelect.TabIndex = 12
			Me.lblSelect.Text = "Caption:"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(16, 76)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(24, 13)
			Me.label1.TabIndex = 13
			Me.label1.Text = "Kind:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(16, 105)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(32, 13)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Width:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(16, 47)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(36, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "Tooltip:"
			' 
			' teCaption
			' 
			Me.teCaption.EditValue = ""
			Me.teCaption.Location = New System.Drawing.Point(99, 17)
			Me.teCaption.Name = "teCaption"
			Me.teCaption.Size = New System.Drawing.Size(145, 20)
			Me.teCaption.TabIndex = 16
'			Me.teCaption.EditValueChanged += New System.EventHandler(Me.teCaption_EditValueChanged)
			' 
			' teToolTip
			' 
			Me.teToolTip.EditValue = ""
			Me.teToolTip.Location = New System.Drawing.Point(99, 44)
			Me.teToolTip.Name = "teToolTip"
			Me.teToolTip.Size = New System.Drawing.Size(145, 20)
			Me.teToolTip.TabIndex = 17
'			Me.teToolTip.EditValueChanged += New System.EventHandler(Me.teToolTip_EditValueChanged)
			' 
			' icbKind
			' 
			Me.icbKind.EditValue = "imageComboBoxEdit1"
			Me.icbKind.Location = New System.Drawing.Point(99, 73)
			Me.icbKind.Name = "icbKind"
			Me.icbKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbKind.Properties.DropDownRows = 15
			Me.icbKind.Size = New System.Drawing.Size(145, 20)
			Me.icbKind.TabIndex = 18
'			Me.icbKind.SelectedIndexChanged += New System.EventHandler(Me.icbKind_SelectedIndexChanged)
			' 
			' seWidth
			' 
			Me.seWidth.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seWidth.Location = New System.Drawing.Point(99, 102)
			Me.seWidth.Name = "seWidth"
			Me.seWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seWidth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.seWidth.Properties.IsFloatValue = False
			Me.seWidth.Properties.Mask.EditMask = "N00"
			Me.seWidth.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.seWidth.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.seWidth.Size = New System.Drawing.Size(145, 20)
			Me.seWidth.TabIndex = 19
'			Me.seWidth.EditValueChanged += New System.EventHandler(Me.seWidth_EditValueChanged)
			' 
			' ceEnabled
			' 
			Me.ceEnabled.Location = New System.Drawing.Point(97, 131)
			Me.ceEnabled.Name = "ceEnabled"
			Me.ceEnabled.Properties.Caption = "Enabled"
			Me.ceEnabled.Size = New System.Drawing.Size(124, 19)
			Me.ceEnabled.TabIndex = 20
'			Me.ceEnabled.CheckedChanged += New System.EventHandler(Me.ceEnabled_CheckedChanged)
			' 
			' ceVisible
			' 
			Me.ceVisible.Location = New System.Drawing.Point(97, 156)
			Me.ceVisible.Name = "ceVisible"
			Me.ceVisible.Properties.Caption = "Visible"
			Me.ceVisible.Size = New System.Drawing.Size(124, 19)
			Me.ceVisible.TabIndex = 21
'			Me.ceVisible.CheckedChanged += New System.EventHandler(Me.ceVisible_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.sbImageClear)
			Me.panelControl1.Controls.Add(Me.icbAlignment)
			Me.panelControl1.Controls.Add(Me.sbImageLoad)
			Me.panelControl1.Controls.Add(Me.label5)
			Me.panelControl1.Controls.Add(Me.label4)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.teCaption)
			Me.panelControl1.Controls.Add(Me.icbKind)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.ceEnabled)
			Me.panelControl1.Controls.Add(Me.label3)
			Me.panelControl1.Controls.Add(Me.teToolTip)
			Me.panelControl1.Controls.Add(Me.lblSelect)
			Me.panelControl1.Controls.Add(Me.ceVisible)
			Me.panelControl1.Controls.Add(Me.seWidth)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(259, 258)
			Me.panelControl1.TabIndex = 22
			' 
			' sbImageClear
			' 
			Me.sbImageClear.Location = New System.Drawing.Point(174, 198)
			Me.sbImageClear.Name = "sbImageClear"
			Me.sbImageClear.Size = New System.Drawing.Size(70, 20)
			Me.sbImageClear.TabIndex = 25
			Me.sbImageClear.Text = "Clear"
'			Me.sbImageClear.Click += New System.EventHandler(Me.sbImageClear_Click)
			' 
			' icbAlignment
			' 
			Me.icbAlignment.EditValue = "imageComboBoxEdit1"
			Me.icbAlignment.Location = New System.Drawing.Point(99, 227)
			Me.icbAlignment.Name = "icbAlignment"
			Me.icbAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbAlignment.Properties.DropDownRows = 15
			Me.icbAlignment.Size = New System.Drawing.Size(145, 20)
			Me.icbAlignment.TabIndex = 26
'			Me.icbAlignment.SelectedIndexChanged += New System.EventHandler(Me.icbAlignment_SelectedIndexChanged)
			' 
			' sbImageLoad
			' 
			Me.sbImageLoad.Location = New System.Drawing.Point(99, 198)
			Me.sbImageLoad.Name = "sbImageLoad"
			Me.sbImageLoad.Size = New System.Drawing.Size(67, 20)
			Me.sbImageLoad.TabIndex = 24
			Me.sbImageLoad.Text = "Load"
'			Me.sbImageLoad.Click += New System.EventHandler(Me.sbImageLoad_Click)
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(16, 230)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(77, 13)
			Me.label5.TabIndex = 23
			Me.label5.Text = "Image Location:"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(16, 201)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(34, 13)
			Me.label4.TabIndex = 22
			Me.label4.Text = "Image:"
			' 
			' ButtonProperties
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "ButtonProperties"
			Me.Size = New System.Drawing.Size(259, 258)
			CType(Me.teCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teToolTip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceEnabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.icbAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teCaption As DevExpress.XtraEditors.TextEdit
		Private WithEvents teToolTip As DevExpress.XtraEditors.TextEdit
		Private WithEvents icbKind As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents seWidth As DevExpress.XtraEditors.SpinEdit
		Private WithEvents ceEnabled As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceVisible As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbImageLoad As DevExpress.XtraEditors.SimpleButton
		Private WithEvents icbAlignment As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents sbImageClear As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace
