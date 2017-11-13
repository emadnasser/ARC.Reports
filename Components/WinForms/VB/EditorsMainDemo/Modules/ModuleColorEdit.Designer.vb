Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleColorEdit
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
			Me.seClear = New DevExpress.XtraEditors.SimpleButton()
			Me.seAdd = New DevExpress.XtraEditors.SimpleButton()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAsInteger = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowColorDialog = New DevExpress.XtraEditors.CheckEdit()
			Me.icbColorText = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.icbColorAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.colorEditSample = New DevExpress.XtraEditors.ColorEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceAsInteger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowColorDialog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbColorText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbColorAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.colorEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(859, 510)
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
			Me.xtraTabPage1.Size = New System.Drawing.Size(853, 504)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.seClear)
			Me.groupControl2.Controls.Add(Me.seAdd)
			Me.groupControl2.Location = New System.Drawing.Point(303, 225)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(275, 74)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Custom Colors"
			' 
			' seClear
			' 
			Me.seClear.Enabled = False
			Me.seClear.Location = New System.Drawing.Point(177, 34)
			Me.seClear.Name = "seClear"
			Me.seClear.Size = New System.Drawing.Size(76, 24)
			Me.seClear.TabIndex = 1
			Me.seClear.Text = "Clear"
'			Me.seClear.Click += New System.EventHandler(Me.seClear_Click)
			' 
			' seAdd
			' 
			Me.seAdd.Location = New System.Drawing.Point(87, 34)
			Me.seAdd.Name = "seAdd"
			Me.seAdd.Size = New System.Drawing.Size(80, 24)
			Me.seAdd.TabIndex = 0
			Me.seAdd.Text = "Create"
'			Me.seAdd.Click += New System.EventHandler(Me.seAdd_Click)
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceAsInteger)
			Me.groupControl1.Controls.Add(Me.ceShowColorDialog)
			Me.groupControl1.Controls.Add(Me.icbColorText)
			Me.groupControl1.Controls.Add(Me.icbColorAlignment)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(303, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(275, 174)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' ceAsInteger
			' 
			Me.ceAsInteger.Location = New System.Drawing.Point(18, 118)
			Me.ceAsInteger.Name = "ceAsInteger"
			Me.ceAsInteger.Properties.Caption = "Store Color as Integer"
			Me.ceAsInteger.Size = New System.Drawing.Size(232, 19)
			Me.ceAsInteger.TabIndex = 18
'			Me.ceAsInteger.CheckedChanged += New System.EventHandler(Me.ceIsInteger_CheckedChanged)
			' 
			' ceShowColorDialog
			' 
			Me.ceShowColorDialog.Location = New System.Drawing.Point(18, 90)
			Me.ceShowColorDialog.Name = "ceShowColorDialog"
			Me.ceShowColorDialog.Properties.Caption = "Show Color Dialog"
			Me.ceShowColorDialog.Size = New System.Drawing.Size(232, 19)
			Me.ceShowColorDialog.TabIndex = 17
'			Me.ceShowColorDialog.CheckedChanged += New System.EventHandler(Me.ceShowColorDialog_CheckedChanged)
			' 
			' icbColorText
			' 
			Me.icbColorText.EditValue = "imageComboBoxEdit2"
			Me.icbColorText.Location = New System.Drawing.Point(129, 61)
			Me.icbColorText.Name = "icbColorText"
			Me.icbColorText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbColorText.Size = New System.Drawing.Size(124, 20)
			Me.icbColorText.TabIndex = 16
'			Me.icbColorText.SelectedIndexChanged += New System.EventHandler(Me.icbColorText_SelectedIndexChanged)
			' 
			' icbColorAlignment
			' 
			Me.icbColorAlignment.EditValue = "imageComboBoxEdit1"
			Me.icbColorAlignment.Location = New System.Drawing.Point(129, 32)
			Me.icbColorAlignment.Name = "icbColorAlignment"
			Me.icbColorAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbColorAlignment.Size = New System.Drawing.Size(124, 20)
			Me.icbColorAlignment.TabIndex = 15
'			Me.icbColorAlignment.SelectedIndexChanged += New System.EventHandler(Me.icbColorAlignment_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 64)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(54, 13)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Color Text:"
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 35)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(79, 13)
			Me.lblSelect.TabIndex = 13
			Me.lblSelect.Text = "Color Alignment:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.colorEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(242, 269)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' colorEditSample
			' 
			Me.colorEditSample.EditValue = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(192)))), (CInt((CByte(255)))))
			Me.colorEditSample.Location = New System.Drawing.Point(25, 91)
			Me.colorEditSample.Name = "colorEditSample"
			Me.colorEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEditSample.Size = New System.Drawing.Size(198, 20)
			Me.colorEditSample.TabIndex = 0
			' 
			' ModuleColorEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleColorEdit"
			Me.Size = New System.Drawing.Size(864, 515)
'			Me.Load += New System.EventHandler(Me.ModuleColorEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceAsInteger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowColorDialog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbColorText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbColorAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.colorEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private colorEditSample As DevExpress.XtraEditors.ColorEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbColorAlignment As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbColorText As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceShowColorDialog As DevExpress.XtraEditors.CheckEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents seAdd As DevExpress.XtraEditors.SimpleButton
		Private WithEvents seClear As DevExpress.XtraEditors.SimpleButton
		Private WithEvents ceAsInteger As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
