Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleDateEdit
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
			Me.icbEditMask = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.ceSynchronizing = New DevExpress.XtraEditors.CheckEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.icbShowVistaClock = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.icbVistaDisplayMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ceShowWeekNumbers = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowToday = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowClear = New DevExpress.XtraEditors.CheckEdit()
			Me.icbWeekNumberRule = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.icbAllowNullInput = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.dateEditSample = New DevExpress.XtraEditors.DateEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.icbEditMask.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceSynchronizing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.icbShowVistaClock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbVistaDisplayMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowWeekNumbers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowToday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowClear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbWeekNumberRule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbAllowNullInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.dateEditSample.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(960, 611)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(954, 605)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.icbEditMask)
			Me.groupControl2.Controls.Add(Me.ceSynchronizing)
			Me.groupControl2.Controls.Add(Me.label2)
			Me.groupControl2.Location = New System.Drawing.Point(280, 286)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(289, 98)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Mask"
			' 
			' icbEditMask
			' 
			Me.icbEditMask.EditValue = "imageComboBoxEdit1"
			Me.icbEditMask.Location = New System.Drawing.Point(89, 32)
			Me.icbEditMask.Name = "icbEditMask"
			Me.icbEditMask.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbEditMask.Size = New System.Drawing.Size(172, 20)
			Me.icbEditMask.TabIndex = 0
'			Me.icbEditMask.SelectedIndexChanged += New System.EventHandler(Me.icbEditMask_SelectedIndexChanged)
			' 
			' ceSynchronizing
			' 
			Me.ceSynchronizing.EditValue = True
			Me.ceSynchronizing.Location = New System.Drawing.Point(18, 61)
			Me.ceSynchronizing.Name = "ceSynchronizing"
			Me.ceSynchronizing.Properties.Caption = "Synchronize edit mask with display format"
			Me.ceSynchronizing.Size = New System.Drawing.Size(240, 19)
			Me.ceSynchronizing.TabIndex = 1
'			Me.ceSynchronizing.CheckedChanged += New System.EventHandler(Me.ceSynchronizing_CheckedChanged)
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 35)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(49, 13)
			Me.label2.TabIndex = 15
			Me.label2.Text = "Edit mask:"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.icbShowVistaClock)
			Me.groupControl1.Controls.Add(Me.labelControl2)
			Me.groupControl1.Controls.Add(Me.icbVistaDisplayMode)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.ceShowWeekNumbers)
			Me.groupControl1.Controls.Add(Me.ceShowToday)
			Me.groupControl1.Controls.Add(Me.ceShowClear)
			Me.groupControl1.Controls.Add(Me.icbWeekNumberRule)
			Me.groupControl1.Controls.Add(Me.icbAllowNullInput)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(280, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(289, 235)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' icbShowVistaClock
			' 
			Me.icbShowVistaClock.EditValue = "imageComboBoxEdit1"
			Me.icbShowVistaClock.Location = New System.Drawing.Point(149, 61)
			Me.icbShowVistaClock.Name = "icbShowVistaClock"
			Me.icbShowVistaClock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbShowVistaClock.Size = New System.Drawing.Size(112, 20)
			Me.icbShowVistaClock.TabIndex = 18
'			Me.icbShowVistaClock.SelectedIndexChanged += New System.EventHandler(Me.icbShowVistaClock_SelectedIndexChanged)
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(20, 64)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(107, 13)
			Me.labelControl2.TabIndex = 19
			Me.labelControl2.Text = "Calendar Time Editing:"
			' 
			' icbVistaDisplayMode
			' 
			Me.icbVistaDisplayMode.EditValue = "imageComboBoxEdit1"
			Me.icbVistaDisplayMode.Location = New System.Drawing.Point(149, 32)
			Me.icbVistaDisplayMode.Name = "icbVistaDisplayMode"
			Me.icbVistaDisplayMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbVistaDisplayMode.Size = New System.Drawing.Size(112, 20)
			Me.icbVistaDisplayMode.TabIndex = 0
'			Me.icbVistaDisplayMode.SelectedIndexChanged += New System.EventHandler(Me.icbVistaDisplayMode_SelectedIndexChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 35)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(72, 13)
			Me.labelControl1.TabIndex = 17
			Me.labelControl1.Text = "Calendar View:"
			' 
			' ceShowWeekNumbers
			' 
			Me.ceShowWeekNumbers.Location = New System.Drawing.Point(18, 198)
			Me.ceShowWeekNumbers.Name = "ceShowWeekNumbers"
			Me.ceShowWeekNumbers.Properties.Caption = "Show week numbers"
			Me.ceShowWeekNumbers.Size = New System.Drawing.Size(168, 19)
			Me.ceShowWeekNumbers.TabIndex = 5
'			Me.ceShowWeekNumbers.CheckedChanged += New System.EventHandler(Me.ceShowWeekNumbers_CheckedChanged)
			' 
			' ceShowToday
			' 
			Me.ceShowToday.Location = New System.Drawing.Point(18, 173)
			Me.ceShowToday.Name = "ceShowToday"
			Me.ceShowToday.Properties.Caption = "Show Today button"
			Me.ceShowToday.Size = New System.Drawing.Size(168, 19)
			Me.ceShowToday.TabIndex = 4
'			Me.ceShowToday.CheckedChanged += New System.EventHandler(Me.ceShowToday_CheckedChanged)
			' 
			' ceShowClear
			' 
			Me.ceShowClear.Location = New System.Drawing.Point(18, 148)
			Me.ceShowClear.Name = "ceShowClear"
			Me.ceShowClear.Properties.Caption = "Show Clear button"
			Me.ceShowClear.Size = New System.Drawing.Size(168, 19)
			Me.ceShowClear.TabIndex = 3
'			Me.ceShowClear.CheckedChanged += New System.EventHandler(Me.ceShowClear_CheckedChanged)
			' 
			' icbWeekNumberRule
			' 
			Me.icbWeekNumberRule.EditValue = "imageComboBoxEdit1"
			Me.icbWeekNumberRule.Location = New System.Drawing.Point(149, 119)
			Me.icbWeekNumberRule.Name = "icbWeekNumberRule"
			Me.icbWeekNumberRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbWeekNumberRule.Size = New System.Drawing.Size(112, 20)
			Me.icbWeekNumberRule.TabIndex = 2
'			Me.icbWeekNumberRule.SelectedIndexChanged += New System.EventHandler(Me.icbWeekNumberRule_SelectedIndexChanged)
			' 
			' icbAllowNullInput
			' 
			Me.icbAllowNullInput.EditValue = "imageComboBoxEdit1"
			Me.icbAllowNullInput.Location = New System.Drawing.Point(149, 90)
			Me.icbAllowNullInput.Name = "icbAllowNullInput"
			Me.icbAllowNullInput.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbAllowNullInput.Size = New System.Drawing.Size(112, 20)
			Me.icbAllowNullInput.TabIndex = 1
'			Me.icbAllowNullInput.SelectedIndexChanged += New System.EventHandler(Me.icbAllowNullInput_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 122)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(91, 13)
			Me.label1.TabIndex = 15
			Me.label1.Text = "Week number rule:"
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 93)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(78, 13)
			Me.lblSelect.TabIndex = 14
			Me.lblSelect.Text = "Allow Null Input:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.dateEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(219, 354)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' dateEditSample
			' 
			Me.dateEditSample.EditValue = New Date(2005, 5, 30, 0, 0, 0, 0)
			Me.dateEditSample.Location = New System.Drawing.Point(17, 63)
			Me.dateEditSample.Name = "dateEditSample"
			Me.dateEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEditSample.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEditSample.Size = New System.Drawing.Size(182, 20)
			Me.dateEditSample.TabIndex = 0
			' 
			' ModuleDateEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleDateEdit"
			Me.Size = New System.Drawing.Size(965, 616)
'			Me.Load += New System.EventHandler(Me.ModuleDateEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.icbEditMask.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceSynchronizing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.icbShowVistaClock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbVistaDisplayMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowWeekNumbers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowToday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowClear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbWeekNumberRule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbAllowNullInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.dateEditSample.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private dateEditSample As DevExpress.XtraEditors.DateEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbAllowNullInput As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbWeekNumberRule As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceShowClear As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowToday As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowWeekNumbers As DevExpress.XtraEditors.CheckEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbEditMask As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceSynchronizing As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents icbVistaDisplayMode As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbShowVistaClock As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
