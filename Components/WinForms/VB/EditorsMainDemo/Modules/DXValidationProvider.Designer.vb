Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleDXValidationProvider
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
			Me.components = New System.ComponentModel.Container()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.icbIconAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.manualValidate = New DevExpress.XtraEditors.CheckEdit()
			Me.autoValidateCheck = New DevExpress.XtraEditors.CheckEdit()
			Me.btnValidate = New DevExpress.XtraEditors.SimpleButton()
			Me.notEqualsComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.notEmptyTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.rangeTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
			Me.customTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.compareTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.containsTextEdit = New DevExpress.XtraEditors.TextEdit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.icbIconAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.manualValidate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.autoValidateCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.notEqualsComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.notEmptyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rangeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compareTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.containsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(877, 560)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.notEqualsComboBoxEdit)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.labelControl2)
			Me.xtraTabPage1.Controls.Add(Me.labelControl6)
			Me.xtraTabPage1.Controls.Add(Me.notEmptyTextEdit)
			Me.xtraTabPage1.Controls.Add(Me.containsTextEdit)
			Me.xtraTabPage1.Controls.Add(Me.rangeTextEdit)
			Me.xtraTabPage1.Controls.Add(Me.compareTextEdit)
			Me.xtraTabPage1.Controls.Add(Me.labelControl5)
			Me.xtraTabPage1.Controls.Add(Me.labelControl3)
			Me.xtraTabPage1.Controls.Add(Me.labelControl4)
			Me.xtraTabPage1.Controls.Add(Me.customTextEdit)
			Me.xtraTabPage1.Controls.Add(Me.labelControl7)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(871, 554)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.icbIconAlignment)
			Me.groupControl1.Controls.Add(Me.labelControl8)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.manualValidate)
			Me.groupControl1.Controls.Add(Me.autoValidateCheck)
			Me.groupControl1.Controls.Add(Me.btnValidate)
			Me.groupControl1.Location = New System.Drawing.Point(537, 31)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(203, 219)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Validation"
			' 
			' icbIconAlignment
			' 
			Me.icbIconAlignment.Location = New System.Drawing.Point(49, 118)
			Me.icbIconAlignment.Name = "icbIconAlignment"
			Me.icbIconAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbIconAlignment.Size = New System.Drawing.Size(132, 20)
			Me.icbIconAlignment.TabIndex = 2
'			Me.icbIconAlignment.SelectedIndexChanged += New System.EventHandler(Me.icbIconAlignment_SelectedIndexChanged)
			' 
			' labelControl8
			' 
			Me.labelControl8.Location = New System.Drawing.Point(20, 94)
			Me.labelControl8.Name = "labelControl8"
			Me.labelControl8.Size = New System.Drawing.Size(75, 13)
			Me.labelControl8.TabIndex = 3
			Me.labelControl8.Text = "Icon Alignment:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 37)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(79, 13)
			Me.labelControl1.TabIndex = 2
			Me.labelControl1.Text = "Validation Mode:"
			' 
			' manualValidate
			' 
			Me.manualValidate.Location = New System.Drawing.Point(119, 35)
			Me.manualValidate.Name = "manualValidate"
			Me.manualValidate.Properties.Caption = "manual"
			Me.manualValidate.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.manualValidate.Properties.RadioGroupIndex = 1
			Me.manualValidate.Size = New System.Drawing.Size(62, 19)
			Me.manualValidate.TabIndex = 1
			Me.manualValidate.TabStop = False
'			Me.manualValidate.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged)
			' 
			' autoValidateCheck
			' 
			Me.autoValidateCheck.Location = New System.Drawing.Point(119, 59)
			Me.autoValidateCheck.Name = "autoValidateCheck"
			Me.autoValidateCheck.Properties.Caption = "auto"
			Me.autoValidateCheck.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.autoValidateCheck.Properties.RadioGroupIndex = 1
			Me.autoValidateCheck.Size = New System.Drawing.Size(62, 19)
			Me.autoValidateCheck.TabIndex = 1
			Me.autoValidateCheck.TabStop = False
'			Me.autoValidateCheck.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged)
			' 
			' btnValidate
			' 
			Me.btnValidate.Location = New System.Drawing.Point(49, 177)
			Me.btnValidate.Name = "btnValidate"
			Me.btnValidate.Size = New System.Drawing.Size(113, 23)
			Me.btnValidate.TabIndex = 0
			Me.btnValidate.Text = "Validate"
'			Me.btnValidate.Click += New System.EventHandler(Me.btnValidate_Click)
			' 
			' notEqualsComboBoxEdit
			' 
			Me.notEqualsComboBoxEdit.Location = New System.Drawing.Point(30, 177)
			Me.notEqualsComboBoxEdit.Name = "notEqualsComboBoxEdit"
			Me.notEqualsComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.notEqualsComboBoxEdit.Properties.Items.AddRange(New Object() { "Project 1", "Project 2", "Project 3"})
			Me.notEqualsComboBoxEdit.Size = New System.Drawing.Size(134, 20)
			Me.notEqualsComboBoxEdit.TabIndex = 4
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl2.Location = New System.Drawing.Point(176, 285)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(225, 26)
			Me.labelControl2.TabIndex = 1
			Me.labelControl2.Text = "Dr./Mr./Mrs./Miss/Ms. + (Person name)" & vbCrLf & vbCrLf
			' 
			' labelControl6
			' 
			Me.labelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl6.Location = New System.Drawing.Point(176, 231)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(179, 26)
			Me.labelControl6.TabIndex = 1
			Me.labelControl6.Text = "Equals to the first editor's value " & vbCrLf & "(case sensitive)" & vbCrLf
			' 
			' notEmptyTextEdit
			' 
			Me.notEmptyTextEdit.Location = New System.Drawing.Point(30, 30)
			Me.notEmptyTextEdit.Name = "notEmptyTextEdit"
			Me.notEmptyTextEdit.Size = New System.Drawing.Size(134, 20)
			Me.notEmptyTextEdit.TabIndex = 1
			' 
			' rangeTextEdit
			' 
			Me.rangeTextEdit.Location = New System.Drawing.Point(30, 73)
			Me.rangeTextEdit.Name = "rangeTextEdit"
			Me.rangeTextEdit.Properties.Mask.EditMask = "d"
			Me.rangeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.rangeTextEdit.Size = New System.Drawing.Size(134, 20)
			Me.rangeTextEdit.TabIndex = 2
			' 
			' labelControl5
			' 
			Me.labelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl5.Location = New System.Drawing.Point(176, 178)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(111, 13)
			Me.labelControl5.TabIndex = 1
			Me.labelControl5.Text = "Not Equals '(select)'"
			' 
			' labelControl4
			' 
			Me.labelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl4.Location = New System.Drawing.Point(176, 74)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(39, 13)
			Me.labelControl4.TabIndex = 1
			Me.labelControl4.Text = "1 - 100"
			' 
			' labelControl7
			' 
			Me.labelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl7.Location = New System.Drawing.Point(177, 31)
			Me.labelControl7.Name = "labelControl7"
			Me.labelControl7.Size = New System.Drawing.Size(59, 13)
			Me.labelControl7.TabIndex = 1
			Me.labelControl7.Text = "Not empty"
			' 
			' customTextEdit
			' 
			Me.customTextEdit.Location = New System.Drawing.Point(30, 284)
			Me.customTextEdit.Name = "customTextEdit"
			Me.customTextEdit.Size = New System.Drawing.Size(134, 20)
			Me.customTextEdit.TabIndex = 6
			' 
			' labelControl3
			' 
			Me.labelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl3.Location = New System.Drawing.Point(176, 126)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(68, 13)
			Me.labelControl3.TabIndex = 1
			Me.labelControl3.Text = "Contains '@'"
			' 
			' compareTextEdit
			' 
			Me.compareTextEdit.Location = New System.Drawing.Point(30, 230)
			Me.compareTextEdit.Name = "compareTextEdit"
			Me.compareTextEdit.Size = New System.Drawing.Size(134, 20)
			Me.compareTextEdit.TabIndex = 5
			' 
			' containsTextEdit
			' 
			Me.containsTextEdit.Location = New System.Drawing.Point(30, 125)
			Me.containsTextEdit.Name = "containsTextEdit"
			Me.containsTextEdit.Size = New System.Drawing.Size(134, 20)
			Me.containsTextEdit.TabIndex = 3
			' 
			' ModuleDXValidationProvider
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleDXValidationProvider"
			Me.Size = New System.Drawing.Size(882, 565)
'			Me.Load += New System.EventHandler(Me.ModuleDXValidationProvider_Load)
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage1.PerformLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.icbIconAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.manualValidate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.autoValidateCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.notEqualsComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.notEmptyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rangeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compareTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.containsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents manualValidate As DevExpress.XtraEditors.CheckEdit
		Private WithEvents autoValidateCheck As DevExpress.XtraEditors.CheckEdit
		Private WithEvents btnValidate As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private notEmptyTextEdit As DevExpress.XtraEditors.TextEdit
		Private rangeTextEdit As DevExpress.XtraEditors.TextEdit
		Private compareTextEdit As DevExpress.XtraEditors.TextEdit
		Private containsTextEdit As DevExpress.XtraEditors.TextEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl7 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private customTextEdit As DevExpress.XtraEditors.TextEdit
		Private notEqualsComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents icbIconAlignment As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl8 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
