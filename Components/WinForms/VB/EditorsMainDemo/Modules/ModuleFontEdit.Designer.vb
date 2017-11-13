Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleFontEdit
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
			Me.cbFontSize = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ceShowSymbolPreview = New DevExpress.XtraEditors.CheckEdit()
			Me.seRUItemCount = New DevExpress.XtraEditors.SpinEdit()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.fontEditSample = New DevExpress.XtraEditors.FontEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.cbFontSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowSymbolPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seRUItemCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.fontEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(787, 550)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(781, 544)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.cbFontSize)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.ceShowSymbolPreview)
			Me.groupControl1.Controls.Add(Me.seRUItemCount)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(301, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(286, 125)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' cbFontSize
			' 
			Me.cbFontSize.AllowDrop = True
			Me.cbFontSize.Location = New System.Drawing.Point(175, 59)
			Me.cbFontSize.Name = "cbFontSize"
			Me.cbFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbFontSize.Properties.DropDownRows = 12
			Me.cbFontSize.Properties.Items.AddRange(New Object() { "7", "8", "9", "10", "12", "14", "16", "20", "25", "30"})
			Me.cbFontSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbFontSize.Size = New System.Drawing.Size(86, 20)
			Me.cbFontSize.TabIndex = 1
'			Me.cbFontSize.SelectedIndexChanged += New System.EventHandler(Me.cbFontSize_SelectedIndexChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.AllowHtmlString = True
			Me.labelControl1.Location = New System.Drawing.Point(20, 60)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(105, 13)
			Me.labelControl1.TabIndex = 15
			Me.labelControl1.Text = "DropDown Font <b>Size</b>:"
			' 
			' ceShowSymbolPreview
			' 
			Me.ceShowSymbolPreview.Location = New System.Drawing.Point(18, 88)
			Me.ceShowSymbolPreview.Name = "ceShowSymbolPreview"
			Me.ceShowSymbolPreview.Properties.Caption = "Show Symbol Font Preview"
			Me.ceShowSymbolPreview.Size = New System.Drawing.Size(243, 19)
			Me.ceShowSymbolPreview.TabIndex = 2
'			Me.ceShowSymbolPreview.CheckedChanged += New System.EventHandler(Me.ceShowSymbolPreview_CheckedChanged)
			' 
			' seRUItemCount
			' 
			Me.seRUItemCount.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seRUItemCount.Location = New System.Drawing.Point(175, 30)
			Me.seRUItemCount.Name = "seRUItemCount"
			Me.seRUItemCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seRUItemCount.Properties.IsFloatValue = False
			Me.seRUItemCount.Properties.Mask.EditMask = "N00"
			Me.seRUItemCount.Properties.MaxValue = New Decimal(New Integer() { 28, 0, 0, 0})
			Me.seRUItemCount.Size = New System.Drawing.Size(86, 20)
			Me.seRUItemCount.TabIndex = 0
'			Me.seRUItemCount.EditValueChanged += New System.EventHandler(Me.seRUItemCount_EditValueChanged)
			' 
			' lblSelect
			' 
			Me.lblSelect.AllowHtmlString = True
			Me.lblSelect.Location = New System.Drawing.Point(20, 33)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(134, 13)
			Me.lblSelect.TabIndex = 12
			Me.lblSelect.Text = "Recently Used Item <b>Count</b>:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.fontEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(240, 125)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' fontEditSample
			' 
			Me.fontEditSample.Location = New System.Drawing.Point(14, 51)
			Me.fontEditSample.Name = "fontEditSample"
			Me.fontEditSample.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.fontEditSample.Properties.AppearanceDropDown.Options.UseFont = True
			Me.fontEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.fontEditSample.Size = New System.Drawing.Size(206, 20)
			Me.fontEditSample.TabIndex = 0
			' 
			' ModuleFontEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleFontEdit"
			Me.Size = New System.Drawing.Size(792, 555)
'			Me.Load += New System.EventHandler(Me.ModuleCalcEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.cbFontSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowSymbolPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seRUItemCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.fontEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private WithEvents seRUItemCount As DevExpress.XtraEditors.SpinEdit
		Private WithEvents ceShowSymbolPreview As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private fontEditSample As DevExpress.XtraEditors.FontEdit
		Private WithEvents cbFontSize As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
