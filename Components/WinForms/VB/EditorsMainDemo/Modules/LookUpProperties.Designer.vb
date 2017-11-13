Namespace DevExpress.XtraEditors.Demos
	Partial Public Class LookUpProperties
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
			Me.lbDisplay = New DevExpress.XtraEditors.LabelControl()
			Me.lbValue = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceCaseSensitiveSearch = New DevExpress.XtraEditors.CheckEdit()
			Me.icbSearchMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.icbHeaderClickMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.seColumnIndex = New DevExpress.XtraEditors.SpinEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceShowLines = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowHeader = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowFooter = New DevExpress.XtraEditors.CheckEdit()
			Me.ceHotTrack = New DevExpress.XtraEditors.CheckEdit()
			Me.teNullText = New DevExpress.XtraEditors.TextEdit()
			Me.label6 = New DevExpress.XtraEditors.LabelControl()
			Me.seItemHeight = New DevExpress.XtraEditors.SpinEdit()
			Me.label5 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceCaseSensitiveSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbSearchMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbHeaderClickMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seColumnIndex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceShowLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceHotTrack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teNullText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seItemHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(30, 20)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(79, 13)
			Me.lblSelect.TabIndex = 13
			Me.lblSelect.Text = "Display Member:"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(30, 42)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(71, 13)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Value Member:"
			' 
			' lbDisplay
			' 
			Me.lbDisplay.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbDisplay.Location = New System.Drawing.Point(126, 20)
			Me.lbDisplay.Name = "lbDisplay"
			Me.lbDisplay.Size = New System.Drawing.Size(47, 13)
			Me.lbDisplay.TabIndex = 15
			Me.lbDisplay.Text = "Member"
			' 
			' lbValue
			' 
			Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbValue.Location = New System.Drawing.Point(126, 42)
			Me.lbValue.Name = "lbValue"
			Me.lbValue.Size = New System.Drawing.Size(47, 13)
			Me.lbValue.TabIndex = 16
			Me.lbValue.Text = "Member"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.ceCaseSensitiveSearch)
			Me.groupControl1.Controls.Add(Me.icbSearchMode)
			Me.groupControl1.Controls.Add(Me.icbHeaderClickMode)
			Me.groupControl1.Controls.Add(Me.seColumnIndex)
			Me.groupControl1.Controls.Add(Me.label4)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Location = New System.Drawing.Point(30, 66)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(255, 163)
			Me.groupControl1.TabIndex = 17
			Me.groupControl1.Text = "Search"
			' 
			' ceCaseSensitiveSearch
			' 
			Me.ceCaseSensitiveSearch.Location = New System.Drawing.Point(18, 119)
			Me.ceCaseSensitiveSearch.Name = "ceCaseSensitiveSearch"
			Me.ceCaseSensitiveSearch.Properties.Caption = "Case sensitive search"
			Me.ceCaseSensitiveSearch.Size = New System.Drawing.Size(148, 19)
			Me.ceCaseSensitiveSearch.TabIndex = 20
'			Me.ceCaseSensitiveSearch.CheckedChanged += New System.EventHandler(Me.ceCaseSensitiveSearch_CheckedChanged)
			' 
			' icbSearchMode
			' 
			Me.icbSearchMode.EditValue = "imageComboBoxEdit2"
			Me.icbSearchMode.Location = New System.Drawing.Point(124, 90)
			Me.icbSearchMode.Name = "icbSearchMode"
			Me.icbSearchMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbSearchMode.Size = New System.Drawing.Size(112, 20)
			Me.icbSearchMode.TabIndex = 19
'			Me.icbSearchMode.SelectedIndexChanged += New System.EventHandler(Me.icbSearchMode_SelectedIndexChanged)
			' 
			' icbHeaderClickMode
			' 
			Me.icbHeaderClickMode.EditValue = "imageComboBoxEdit1"
			Me.icbHeaderClickMode.Location = New System.Drawing.Point(124, 61)
			Me.icbHeaderClickMode.Name = "icbHeaderClickMode"
			Me.icbHeaderClickMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbHeaderClickMode.Size = New System.Drawing.Size(112, 20)
			Me.icbHeaderClickMode.TabIndex = 18
'			Me.icbHeaderClickMode.SelectedIndexChanged += New System.EventHandler(Me.icbHeaderClickMode_SelectedIndexChanged)
			' 
			' seColumnIndex
			' 
			Me.seColumnIndex.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seColumnIndex.Location = New System.Drawing.Point(176, 32)
			Me.seColumnIndex.Name = "seColumnIndex"
			Me.seColumnIndex.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seColumnIndex.Properties.IsFloatValue = False
			Me.seColumnIndex.Properties.Mask.EditMask = "N00"
			Me.seColumnIndex.Properties.MaxValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.seColumnIndex.Size = New System.Drawing.Size(60, 20)
			Me.seColumnIndex.TabIndex = 17
'			Me.seColumnIndex.EditValueChanged += New System.EventHandler(Me.seColumnIndex_EditValueChanged)
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 93)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(66, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Search mode:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 64)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(90, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "Header click mode:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 35)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(128, 13)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Auto-search column index:"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.ceShowLines)
			Me.groupControl2.Controls.Add(Me.ceShowHeader)
			Me.groupControl2.Controls.Add(Me.ceShowFooter)
			Me.groupControl2.Controls.Add(Me.ceHotTrack)
			Me.groupControl2.Controls.Add(Me.teNullText)
			Me.groupControl2.Controls.Add(Me.label6)
			Me.groupControl2.Controls.Add(Me.seItemHeight)
			Me.groupControl2.Controls.Add(Me.label5)
			Me.groupControl2.Location = New System.Drawing.Point(30, 250)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(255, 196)
			Me.groupControl2.TabIndex = 18
			Me.groupControl2.Text = "Appearance"
			' 
			' ceShowLines
			' 
			Me.ceShowLines.Location = New System.Drawing.Point(18, 160)
			Me.ceShowLines.Name = "ceShowLines"
			Me.ceShowLines.Properties.Caption = "Show lines"
			Me.ceShowLines.Size = New System.Drawing.Size(148, 19)
			Me.ceShowLines.TabIndex = 24
'			Me.ceShowLines.CheckedChanged += New System.EventHandler(Me.ceShowLines_CheckedChanged)
			' 
			' ceShowHeader
			' 
			Me.ceShowHeader.Location = New System.Drawing.Point(18, 137)
			Me.ceShowHeader.Name = "ceShowHeader"
			Me.ceShowHeader.Properties.Caption = "Show header"
			Me.ceShowHeader.Size = New System.Drawing.Size(148, 19)
			Me.ceShowHeader.TabIndex = 23
'			Me.ceShowHeader.CheckedChanged += New System.EventHandler(Me.ceShowHeader_CheckedChanged)
			' 
			' ceShowFooter
			' 
			Me.ceShowFooter.Location = New System.Drawing.Point(18, 112)
			Me.ceShowFooter.Name = "ceShowFooter"
			Me.ceShowFooter.Properties.Caption = "Show footer"
			Me.ceShowFooter.Size = New System.Drawing.Size(148, 19)
			Me.ceShowFooter.TabIndex = 22
'			Me.ceShowFooter.CheckedChanged += New System.EventHandler(Me.ceShowFooter_CheckedChanged)
			' 
			' ceHotTrack
			' 
			Me.ceHotTrack.Location = New System.Drawing.Point(18, 87)
			Me.ceHotTrack.Name = "ceHotTrack"
			Me.ceHotTrack.Properties.Caption = "Hot-track items"
			Me.ceHotTrack.Size = New System.Drawing.Size(148, 19)
			Me.ceHotTrack.TabIndex = 21
'			Me.ceHotTrack.CheckedChanged += New System.EventHandler(Me.ceHotTrack_CheckedChanged)
			' 
			' teNullText
			' 
			Me.teNullText.EditValue = ""
			Me.teNullText.Location = New System.Drawing.Point(124, 61)
			Me.teNullText.Name = "teNullText"
			Me.teNullText.Size = New System.Drawing.Size(112, 20)
			Me.teNullText.TabIndex = 20
'			Me.teNullText.EditValueChanged += New System.EventHandler(Me.teNullText_EditValueChanged)
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(20, 64)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(46, 13)
			Me.label6.TabIndex = 19
			Me.label6.Text = "Null Text:"
			' 
			' seItemHeight
			' 
			Me.seItemHeight.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seItemHeight.Location = New System.Drawing.Point(176, 32)
			Me.seItemHeight.Name = "seItemHeight"
			Me.seItemHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seItemHeight.Properties.IsFloatValue = False
			Me.seItemHeight.Properties.Mask.EditMask = "N00"
			Me.seItemHeight.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.seItemHeight.Size = New System.Drawing.Size(60, 20)
			Me.seItemHeight.TabIndex = 18
'			Me.seItemHeight.EditValueChanged += New System.EventHandler(Me.seItemHeight_EditValueChanged)
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(20, 35)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(109, 13)
			Me.label5.TabIndex = 15
			Me.label5.Text = "Dropdown item height:"
			' 
			' LookUpProperties
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.groupControl2)
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.lbValue)
			Me.Controls.Add(Me.lbDisplay)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.lblSelect)
			Me.Name = "LookUpProperties"
			Me.Size = New System.Drawing.Size(311, 475)
'			Me.Load += New System.EventHandler(Me.LookUpProperties_Load)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceCaseSensitiveSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbSearchMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbHeaderClickMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seColumnIndex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.ceShowLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceHotTrack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teNullText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seItemHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private lbDisplay As DevExpress.XtraEditors.LabelControl
		Private lbValue As DevExpress.XtraEditors.LabelControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private label6 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents seColumnIndex As DevExpress.XtraEditors.SpinEdit
		Private WithEvents icbHeaderClickMode As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbSearchMode As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceCaseSensitiveSearch As DevExpress.XtraEditors.CheckEdit
		Private WithEvents seItemHeight As DevExpress.XtraEditors.SpinEdit
		Private WithEvents teNullText As DevExpress.XtraEditors.TextEdit
		Private WithEvents ceHotTrack As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowFooter As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowHeader As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowLines As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
