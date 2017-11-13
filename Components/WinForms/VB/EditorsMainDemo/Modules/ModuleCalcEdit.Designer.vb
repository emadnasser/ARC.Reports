Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleCalcEdit
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceShowCustomButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
			Me.sePrecision = New DevExpress.XtraEditors.SpinEdit()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.calcEditSample = New DevExpress.XtraEditors.CalcEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceShowCustomButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sePrecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.calcEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(810, 502)
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
			Me.xtraTabPage1.Size = New System.Drawing.Size(804, 496)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.ceShowCustomButtons)
			Me.groupControl2.Location = New System.Drawing.Point(321, 147)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(208, 67)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Custom buttons"
			' 
			' ceShowCustomButtons
			' 
			Me.ceShowCustomButtons.Location = New System.Drawing.Point(20, 31)
			Me.ceShowCustomButtons.Name = "ceShowCustomButtons"
			Me.ceShowCustomButtons.Properties.Caption = "Show custom buttons"
			Me.ceShowCustomButtons.Size = New System.Drawing.Size(176, 19)
			Me.ceShowCustomButtons.TabIndex = 0
'			Me.ceShowCustomButtons.CheckedChanged += New System.EventHandler(Me.ceShowCustomButtons_CheckedChanged)
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceShowCloseButton)
			Me.groupControl1.Controls.Add(Me.sePrecision)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(321, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(208, 96)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' ceShowCloseButton
			' 
			Me.ceShowCloseButton.Location = New System.Drawing.Point(18, 58)
			Me.ceShowCloseButton.Name = "ceShowCloseButton"
			Me.ceShowCloseButton.Properties.Caption = "Show Close button"
			Me.ceShowCloseButton.Size = New System.Drawing.Size(178, 19)
			Me.ceShowCloseButton.TabIndex = 14
'			Me.ceShowCloseButton.CheckedChanged += New System.EventHandler(Me.ceShowCloseButton_CheckedChanged)
			' 
			' sePrecision
			' 
			Me.sePrecision.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.sePrecision.Location = New System.Drawing.Point(92, 32)
			Me.sePrecision.Name = "sePrecision"
			Me.sePrecision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.sePrecision.Properties.IsFloatValue = False
			Me.sePrecision.Properties.Mask.EditMask = "N00"
			Me.sePrecision.Properties.MaxValue = New Decimal(New Integer() { 28, 0, 0, 0})
			Me.sePrecision.Size = New System.Drawing.Size(104, 20)
			Me.sePrecision.TabIndex = 13
'			Me.sePrecision.EditValueChanged += New System.EventHandler(Me.sePrecision_EditValueChanged)
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 35)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(46, 13)
			Me.lblSelect.TabIndex = 12
			Me.lblSelect.Text = "Precision:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.calcEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(260, 184)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' calcEditSample
			' 
			Me.calcEditSample.EditValue = New Decimal(New Integer() { 22, 0, 0, 65536})
			Me.calcEditSample.Location = New System.Drawing.Point(8, 76)
			Me.calcEditSample.Name = "calcEditSample"
			Me.calcEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Clear", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C)), serializableAppearanceObject1, "", "clear", Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "^2", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2)), serializableAppearanceObject2, "", "involution2", Nothing, False)})
			Me.calcEditSample.Size = New System.Drawing.Size(220, 20)
			Me.calcEditSample.TabIndex = 0
'			Me.calcEditSample.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.calcEditSample_ButtonClick)
			' 
			' ModuleCalcEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleCalcEdit"
			Me.Size = New System.Drawing.Size(815, 507)
'			Me.Load += New System.EventHandler(Me.ModuleCalcEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.ceShowCustomButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sePrecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.calcEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents calcEditSample As DevExpress.XtraEditors.CalcEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private WithEvents sePrecision As DevExpress.XtraEditors.SpinEdit
		Private WithEvents ceShowCloseButton As DevExpress.XtraEditors.CheckEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceShowCustomButtons As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
