Namespace DevExpress.XtraEditors.Demos
	Partial Public Class MaskProperties
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
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceUseMaskAsDisplayFormat = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowPlaceHolder = New DevExpress.XtraEditors.CheckEdit()
			Me.ceSaveLiteral = New DevExpress.XtraEditors.CheckEdit()
			Me.ceIgnoreMaskBlank = New DevExpress.XtraEditors.CheckEdit()
			Me.cbPlaceHolder = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.teEditMask = New DevExpress.XtraEditors.TextEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.lbMaskType = New DevExpress.XtraEditors.LabelControl()
			Me.ceBeepOnError = New DevExpress.XtraEditors.CheckEdit()
			Me.icbAutoComplete = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.lbName = New DevExpress.XtraEditors.LabelControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceUseMaskAsDisplayFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowPlaceHolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceSaveLiteral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceIgnoreMaskBlank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbPlaceHolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teEditMask.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceBeepOnError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbAutoComplete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.ceUseMaskAsDisplayFormat)
			Me.groupControl1.Controls.Add(Me.ceShowPlaceHolder)
			Me.groupControl1.Controls.Add(Me.ceSaveLiteral)
			Me.groupControl1.Controls.Add(Me.ceIgnoreMaskBlank)
			Me.groupControl1.Controls.Add(Me.cbPlaceHolder)
			Me.groupControl1.Controls.Add(Me.teEditMask)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.lbMaskType)
			Me.groupControl1.Controls.Add(Me.ceBeepOnError)
			Me.groupControl1.Controls.Add(Me.icbAutoComplete)
			Me.groupControl1.Controls.Add(Me.label4)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Location = New System.Drawing.Point(30, 54)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(282, 276)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "Mask properties"
			' 
			' ceUseMaskAsDisplayFormat
			' 
			Me.ceUseMaskAsDisplayFormat.Location = New System.Drawing.Point(18, 234)
			Me.ceUseMaskAsDisplayFormat.Name = "ceUseMaskAsDisplayFormat"
			Me.ceUseMaskAsDisplayFormat.Properties.Caption = "Use mask as display format"
			Me.ceUseMaskAsDisplayFormat.Size = New System.Drawing.Size(184, 19)
			Me.ceUseMaskAsDisplayFormat.TabIndex = 8
			Me.ceUseMaskAsDisplayFormat.TabStop = False
'			Me.ceUseMaskAsDisplayFormat.CheckedChanged += New System.EventHandler(Me.ceUseMaskAsDisplayFormat_CheckedChanged)
			' 
			' ceShowPlaceHolder
			' 
			Me.ceShowPlaceHolder.Location = New System.Drawing.Point(18, 210)
			Me.ceShowPlaceHolder.Name = "ceShowPlaceHolder"
			Me.ceShowPlaceHolder.Properties.Caption = "Show place holders"
			Me.ceShowPlaceHolder.Size = New System.Drawing.Size(184, 19)
			Me.ceShowPlaceHolder.TabIndex = 7
			Me.ceShowPlaceHolder.TabStop = False
'			Me.ceShowPlaceHolder.CheckedChanged += New System.EventHandler(Me.ceShowPlaceHolder_CheckedChanged)
			' 
			' ceSaveLiteral
			' 
			Me.ceSaveLiteral.Location = New System.Drawing.Point(18, 186)
			Me.ceSaveLiteral.Name = "ceSaveLiteral"
			Me.ceSaveLiteral.Properties.Caption = "Save literals"
			Me.ceSaveLiteral.Size = New System.Drawing.Size(184, 19)
			Me.ceSaveLiteral.TabIndex = 6
			Me.ceSaveLiteral.TabStop = False
'			Me.ceSaveLiteral.CheckedChanged += New System.EventHandler(Me.ceSaveLiteral_CheckedChanged)
			' 
			' ceIgnoreMaskBlank
			' 
			Me.ceIgnoreMaskBlank.Location = New System.Drawing.Point(18, 162)
			Me.ceIgnoreMaskBlank.Name = "ceIgnoreMaskBlank"
			Me.ceIgnoreMaskBlank.Properties.Caption = "Ignore mask blanks"
			Me.ceIgnoreMaskBlank.Size = New System.Drawing.Size(184, 19)
			Me.ceIgnoreMaskBlank.TabIndex = 5
			Me.ceIgnoreMaskBlank.TabStop = False
'			Me.ceIgnoreMaskBlank.CheckedChanged += New System.EventHandler(Me.ceIgnoreMaskBlank_CheckedChanged)
			' 
			' cbPlaceHolder
			' 
			Me.cbPlaceHolder.EditValue = "_"
			Me.cbPlaceHolder.Location = New System.Drawing.Point(147, 109)
			Me.cbPlaceHolder.Name = "cbPlaceHolder"
			Me.cbPlaceHolder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbPlaceHolder.Properties.Items.AddRange(New Object() { "_", "*", ".", "~"})
			Me.cbPlaceHolder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbPlaceHolder.Size = New System.Drawing.Size(112, 20)
			Me.cbPlaceHolder.TabIndex = 3
			Me.cbPlaceHolder.TabStop = False
'			Me.cbPlaceHolder.SelectedIndexChanged += New System.EventHandler(Me.cbPlaceHolder_SelectedIndexChanged)
			' 
			' teEditMask
			' 
			Me.teEditMask.EditValue = ""
			Me.teEditMask.Location = New System.Drawing.Point(115, 51)
			Me.teEditMask.Name = "teEditMask"
			Me.teEditMask.Size = New System.Drawing.Size(144, 20)
			Me.teEditMask.TabIndex = 1
			Me.teEditMask.TabStop = False
'			Me.teEditMask.EditValueChanged += New System.EventHandler(Me.teEditMask_EditValueChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 54)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(49, 13)
			Me.label1.TabIndex = 22
			Me.label1.Text = "Edit mask:"
			' 
			' lbMaskType
			' 
			Me.lbMaskType.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lbMaskType.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbMaskType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.lbMaskType.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.lbMaskType.Location = New System.Drawing.Point(115, 32)
			Me.lbMaskType.Name = "lbMaskType"
			Me.lbMaskType.Size = New System.Drawing.Size(45, 13)
			Me.lbMaskType.TabIndex = 21
			Me.lbMaskType.Text = "Member"
			' 
			' ceBeepOnError
			' 
			Me.ceBeepOnError.Location = New System.Drawing.Point(18, 138)
			Me.ceBeepOnError.Name = "ceBeepOnError"
			Me.ceBeepOnError.Properties.Caption = "Beep on error"
			Me.ceBeepOnError.Size = New System.Drawing.Size(184, 19)
			Me.ceBeepOnError.TabIndex = 4
			Me.ceBeepOnError.TabStop = False
'			Me.ceBeepOnError.CheckedChanged += New System.EventHandler(Me.ceBeepOnError_CheckedChanged)
			' 
			' icbAutoComplete
			' 
			Me.icbAutoComplete.EditValue = "imageComboBoxEdit1"
			Me.icbAutoComplete.Location = New System.Drawing.Point(147, 80)
			Me.icbAutoComplete.Name = "icbAutoComplete"
			Me.icbAutoComplete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbAutoComplete.Size = New System.Drawing.Size(112, 20)
			Me.icbAutoComplete.TabIndex = 2
			Me.icbAutoComplete.TabStop = False
'			Me.icbAutoComplete.SelectedIndexChanged += New System.EventHandler(Me.icbAutoComplete_SelectedIndexChanged)
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 112)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(62, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Place holder:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 83)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(74, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "Auto-complete:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 32)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(53, 13)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Mask type:"
			' 
			' lbName
			' 
			Me.lbName.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lbName.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.lbName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.lbName.Location = New System.Drawing.Point(30, 30)
			Me.lbName.Name = "lbName"
			Me.lbName.Size = New System.Drawing.Size(45, 13)
			Me.lbName.TabIndex = 15
			Me.lbName.Text = "Member"
			' 
			' MaskProperties
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.lbName)
			Me.Name = "MaskProperties"
			Me.Size = New System.Drawing.Size(330, 350)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceUseMaskAsDisplayFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowPlaceHolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceSaveLiteral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceIgnoreMaskBlank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbPlaceHolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teEditMask.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceBeepOnError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbAutoComplete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Private lbName As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceBeepOnError As DevExpress.XtraEditors.CheckEdit
		Private WithEvents icbAutoComplete As DevExpress.XtraEditors.ImageComboBoxEdit
		Private lbMaskType As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teEditMask As DevExpress.XtraEditors.TextEdit
		Private WithEvents cbPlaceHolder As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents ceIgnoreMaskBlank As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceSaveLiteral As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowPlaceHolder As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceUseMaskAsDisplayFormat As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
