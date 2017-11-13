Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleZoomTrackBar
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
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.lbValue = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.checkEditUseMiddleValue = New DevExpress.XtraEditors.CheckEdit()
			Me.seMiddle = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.seLargeChange = New DevExpress.XtraEditors.SpinEdit()
			Me.seSmallChange = New DevExpress.XtraEditors.SpinEdit()
			Me.seMaximum = New DevExpress.XtraEditors.SpinEdit()
			Me.seMinimum = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbScrollThumbStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.checkEditVertical = New DevExpress.XtraEditors.CheckEdit()
			Me.lblBarStyle = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.checkEditUseMiddleValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMiddle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seLargeChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seSmallChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMaximum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMinimum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbScrollThumbStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(1043, 677)
			Me.xtraTabControl1.TabIndex = 16
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl3)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(1037, 671)
			Me.xtraTabPage1.Text = "Layout and Appearance"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.CaptionImage = My.Resources.info_16x16
			Me.groupControl1.Controls.Add(Me.lbValue)
			Me.groupControl1.Location = New System.Drawing.Point(332, 332)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(266, 73)
			Me.groupControl1.TabIndex = 6
			Me.groupControl1.Text = "Value"
			' 
			' lbValue
			' 
			Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.lbValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbValue.Location = New System.Drawing.Point(16, 31)
			Me.lbValue.Name = "lbValue"
			Me.lbValue.Size = New System.Drawing.Size(227, 22)
			Me.lbValue.TabIndex = 0
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.checkEditUseMiddleValue)
			Me.groupControl2.Controls.Add(Me.seMiddle)
			Me.groupControl2.Controls.Add(Me.labelControl5)
			Me.groupControl2.Controls.Add(Me.seLargeChange)
			Me.groupControl2.Controls.Add(Me.seSmallChange)
			Me.groupControl2.Controls.Add(Me.seMaximum)
			Me.groupControl2.Controls.Add(Me.seMinimum)
			Me.groupControl2.Controls.Add(Me.labelControl4)
			Me.groupControl2.Controls.Add(Me.labelControl3)
			Me.groupControl2.Controls.Add(Me.labelControl2)
			Me.groupControl2.Controls.Add(Me.labelControl1)
			Me.groupControl2.Controls.Add(Me.icbScrollThumbStyle)
			Me.groupControl2.Controls.Add(Me.checkEditVertical)
			Me.groupControl2.Controls.Add(Me.lblBarStyle)
			Me.groupControl2.Location = New System.Drawing.Point(332, 30)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(266, 281)
			Me.groupControl2.TabIndex = 4
			Me.groupControl2.Text = "Properties"
			' 
			' checkEditUseMiddleValue
			' 
			Me.checkEditUseMiddleValue.Location = New System.Drawing.Point(18, 84)
			Me.checkEditUseMiddleValue.Name = "checkEditUseMiddleValue"
			Me.checkEditUseMiddleValue.Properties.Caption = "Use Middle Value"
			Me.checkEditUseMiddleValue.Size = New System.Drawing.Size(108, 19)
			Me.checkEditUseMiddleValue.TabIndex = 2
'			Me.checkEditUseMiddleValue.CheckedChanged += New System.EventHandler(Me.checkEditUseMiddleValue_CheckedChanged)
			' 
			' seMiddle
			' 
			Me.seMiddle.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMiddle.Enabled = False
			Me.seMiddle.Location = New System.Drawing.Point(135, 227)
			Me.seMiddle.Name = "seMiddle"
			Me.seMiddle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMiddle.Properties.IsFloatValue = False
			Me.seMiddle.Properties.Mask.EditMask = "N00"
			Me.seMiddle.Size = New System.Drawing.Size(108, 20)
			Me.seMiddle.TabIndex = 7
'			Me.seMiddle.EditValueChanged += New System.EventHandler(Me.seMiddle_EditValueChanged)
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(20, 230)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(30, 13)
			Me.labelControl5.TabIndex = 17
			Me.labelControl5.Text = "Middle"
			' 
			' seLargeChange
			' 
			Me.seLargeChange.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seLargeChange.Location = New System.Drawing.Point(135, 198)
			Me.seLargeChange.Name = "seLargeChange"
			Me.seLargeChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seLargeChange.Properties.IsFloatValue = False
			Me.seLargeChange.Properties.Mask.EditMask = "N00"
			Me.seLargeChange.Size = New System.Drawing.Size(108, 20)
			Me.seLargeChange.TabIndex = 6
'			Me.seLargeChange.EditValueChanged += New System.EventHandler(Me.seLargeChange_EditValueChanged)
			' 
			' seSmallChange
			' 
			Me.seSmallChange.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seSmallChange.Location = New System.Drawing.Point(135, 169)
			Me.seSmallChange.Name = "seSmallChange"
			Me.seSmallChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seSmallChange.Properties.IsFloatValue = False
			Me.seSmallChange.Properties.Mask.EditMask = "N00"
			Me.seSmallChange.Size = New System.Drawing.Size(108, 20)
			Me.seSmallChange.TabIndex = 5
'			Me.seSmallChange.EditValueChanged += New System.EventHandler(Me.seSmallChange_EditValueChanged)
			' 
			' seMaximum
			' 
			Me.seMaximum.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMaximum.Location = New System.Drawing.Point(135, 140)
			Me.seMaximum.Name = "seMaximum"
			Me.seMaximum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMaximum.Properties.IsFloatValue = False
			Me.seMaximum.Properties.Mask.EditMask = "N00"
			Me.seMaximum.Size = New System.Drawing.Size(108, 20)
			Me.seMaximum.TabIndex = 4
'			Me.seMaximum.EditValueChanged += New System.EventHandler(Me.seMaximum_EditValueChanged)
			' 
			' seMinimum
			' 
			Me.seMinimum.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMinimum.Location = New System.Drawing.Point(135, 111)
			Me.seMinimum.Name = "seMinimum"
			Me.seMinimum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMinimum.Properties.IsFloatValue = False
			Me.seMinimum.Properties.Mask.EditMask = "N00"
			Me.seMinimum.Size = New System.Drawing.Size(108, 20)
			Me.seMinimum.TabIndex = 3
'			Me.seMinimum.EditValueChanged += New System.EventHandler(Me.seMinimum_EditValueChanged)
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(20, 201)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(71, 13)
			Me.labelControl4.TabIndex = 11
			Me.labelControl4.Text = "Large Change:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(20, 172)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(68, 13)
			Me.labelControl3.TabIndex = 10
			Me.labelControl3.Text = "Small Change:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(20, 143)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(48, 13)
			Me.labelControl2.TabIndex = 9
			Me.labelControl2.Text = "Maximum:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 114)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(44, 13)
			Me.labelControl1.TabIndex = 8
			Me.labelControl1.Text = "Minimum:"
			' 
			' icbScrollThumbStyle
			' 
			Me.icbScrollThumbStyle.Location = New System.Drawing.Point(135, 32)
			Me.icbScrollThumbStyle.Name = "icbScrollThumbStyle"
			Me.icbScrollThumbStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbScrollThumbStyle.Size = New System.Drawing.Size(108, 20)
			Me.icbScrollThumbStyle.TabIndex = 0
'			Me.icbScrollThumbStyle.SelectedIndexChanged += New System.EventHandler(Me.icbScrollThumbStyle_SelectedIndexChanged)
			' 
			' checkEditVertical
			' 
			Me.checkEditVertical.Location = New System.Drawing.Point(18, 59)
			Me.checkEditVertical.Name = "checkEditVertical"
			Me.checkEditVertical.Properties.Caption = "Vertical"
			Me.checkEditVertical.Size = New System.Drawing.Size(83, 19)
			Me.checkEditVertical.TabIndex = 1
'			Me.checkEditVertical.CheckedChanged += New System.EventHandler(Me.checkEditVertical_CheckedChanged)
			' 
			' lblBarStyle
			' 
			Me.lblBarStyle.Location = New System.Drawing.Point(20, 35)
			Me.lblBarStyle.Name = "lblBarStyle"
			Me.lblBarStyle.Size = New System.Drawing.Size(91, 13)
			Me.lblBarStyle.TabIndex = 7
			Me.lblBarStyle.Text = "Scroll Thumb Style:"
			' 
			' groupControl3
			' 
			Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl3.Appearance.Options.UseBackColor = True
			Me.groupControl3.Controls.Add(Me.zoomTrackBarControl1)
			Me.groupControl3.Location = New System.Drawing.Point(30, 30)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(271, 375)
			Me.groupControl3.TabIndex = 0
			Me.groupControl3.Text = "Sample"
			' 
			' zoomTrackBarControl1
			' 
			Me.zoomTrackBarControl1.EditValue = 5
			Me.zoomTrackBarControl1.Location = New System.Drawing.Point(16, 120)
			Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
			Me.zoomTrackBarControl1.Properties.Middle = 5
			Me.zoomTrackBarControl1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.zoomTrackBarControl1.Size = New System.Drawing.Size(176, 23)
			Me.zoomTrackBarControl1.TabIndex = 0
			Me.zoomTrackBarControl1.Value = 5
'			Me.zoomTrackBarControl1.EditValueChanged += New System.EventHandler(Me.zoomTrackBarControl1_EditValueChanged)
			' 
			' ModuleZoomTrackBar
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleZoomTrackBar"
			Me.Size = New System.Drawing.Size(1048, 682)
'			Me.Load += New System.EventHandler(Me.ModuleZoomTrackBar_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.checkEditUseMiddleValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMiddle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seLargeChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seSmallChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMaximum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMinimum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbScrollThumbStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.groupControl3.PerformLayout()
			CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkEditVertical As DevExpress.XtraEditors.CheckEdit
		Private lblBarStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents zoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl
		Private WithEvents icbScrollThumbStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seMinimum As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seMaximum As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seSmallChange As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seLargeChange As DevExpress.XtraEditors.SpinEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lbValue As DevExpress.XtraEditors.LabelControl
		Private WithEvents seMiddle As DevExpress.XtraEditors.SpinEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditUseMiddleValue As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
