Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleNavigator
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleNavigator))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
			Me.meFiringEvents = New DevExpress.XtraEditors.MemoEdit()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceShowPageButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowAppendRemove = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowEditingButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowCustomButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceShowToolTips = New DevExpress.XtraEditors.CheckEdit()
			Me.ceEnableAutoRepeat = New DevExpress.XtraEditors.CheckEdit()
			Me.icbTextLocations = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.dataNavigatorSample = New DevExpress.XtraEditors.DataNavigator()
			Me.imlSmall = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl5.SuspendLayout()
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceShowPageButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowAppendRemove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowEditingButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowCustomButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceShowToolTips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceEnableAutoRepeat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbTextLocations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(935, 611)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl5)
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(929, 605)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl5
			' 
			Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl5.Appearance.Options.UseBackColor = True
			Me.groupControl5.Controls.Add(Me.meFiringEvents)
			Me.groupControl5.Location = New System.Drawing.Point(439, 183)
			Me.groupControl5.Name = "groupControl5"
			Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl5.Size = New System.Drawing.Size(283, 136)
			Me.groupControl5.TabIndex = 5
			Me.groupControl5.Text = "Button event log"
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
			Me.meFiringEvents.Size = New System.Drawing.Size(263, 97)
			Me.meFiringEvents.TabIndex = 0
			Me.meFiringEvents.TabStop = False
			Me.meFiringEvents.UseOptimizedRendering = True
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.ceShowPageButtons)
			Me.groupControl2.Controls.Add(Me.ceShowAppendRemove)
			Me.groupControl2.Controls.Add(Me.ceShowEditingButtons)
			Me.groupControl2.Controls.Add(Me.ceShowCustomButtons)
			Me.groupControl2.Location = New System.Drawing.Point(30, 183)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(388, 136)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Show buttons"
			' 
			' ceShowPageButtons
			' 
			Me.ceShowPageButtons.Location = New System.Drawing.Point(12, 100)
			Me.ceShowPageButtons.Name = "ceShowPageButtons"
			Me.ceShowPageButtons.Properties.Caption = "Show page buttons"
			Me.ceShowPageButtons.Size = New System.Drawing.Size(208, 19)
			Me.ceShowPageButtons.TabIndex = 23
'			Me.ceShowPageButtons.CheckedChanged += New System.EventHandler(Me.ceShowPageButtons_CheckedChanged)
			' 
			' ceShowAppendRemove
			' 
			Me.ceShowAppendRemove.Location = New System.Drawing.Point(12, 76)
			Me.ceShowAppendRemove.Name = "ceShowAppendRemove"
			Me.ceShowAppendRemove.Properties.Caption = "Show Append/Remove buttons"
			Me.ceShowAppendRemove.Size = New System.Drawing.Size(208, 19)
			Me.ceShowAppendRemove.TabIndex = 22
'			Me.ceShowAppendRemove.CheckedChanged += New System.EventHandler(Me.ceShowAppendRemove_CheckedChanged)
			' 
			' ceShowEditingButtons
			' 
			Me.ceShowEditingButtons.Location = New System.Drawing.Point(12, 52)
			Me.ceShowEditingButtons.Name = "ceShowEditingButtons"
			Me.ceShowEditingButtons.Properties.Caption = "Show editing buttons"
			Me.ceShowEditingButtons.Size = New System.Drawing.Size(208, 19)
			Me.ceShowEditingButtons.TabIndex = 21
'			Me.ceShowEditingButtons.CheckedChanged += New System.EventHandler(Me.ceShowEditingButtons_CheckedChanged)
			' 
			' ceShowCustomButtons
			' 
			Me.ceShowCustomButtons.Location = New System.Drawing.Point(12, 28)
			Me.ceShowCustomButtons.Name = "ceShowCustomButtons"
			Me.ceShowCustomButtons.Properties.Caption = "Show custom buttons"
			Me.ceShowCustomButtons.Size = New System.Drawing.Size(208, 19)
			Me.ceShowCustomButtons.TabIndex = 20
'			Me.ceShowCustomButtons.CheckedChanged += New System.EventHandler(Me.ceShowCustomButtons_CheckedChanged)
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceShowToolTips)
			Me.groupControl1.Controls.Add(Me.ceEnableAutoRepeat)
			Me.groupControl1.Controls.Add(Me.icbTextLocations)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Location = New System.Drawing.Point(439, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(283, 132)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' ceShowToolTips
			' 
			Me.ceShowToolTips.Location = New System.Drawing.Point(18, 86)
			Me.ceShowToolTips.Name = "ceShowToolTips"
			Me.ceShowToolTips.Properties.Caption = "Show tooltips"
			Me.ceShowToolTips.Size = New System.Drawing.Size(140, 19)
			Me.ceShowToolTips.TabIndex = 19
'			Me.ceShowToolTips.CheckedChanged += New System.EventHandler(Me.ceShowToolTips_CheckedChanged)
			' 
			' ceEnableAutoRepeat
			' 
			Me.ceEnableAutoRepeat.Location = New System.Drawing.Point(18, 61)
			Me.ceEnableAutoRepeat.Name = "ceEnableAutoRepeat"
			Me.ceEnableAutoRepeat.Properties.Caption = "Enable auto-repeat"
			Me.ceEnableAutoRepeat.Size = New System.Drawing.Size(140, 19)
			Me.ceEnableAutoRepeat.TabIndex = 18
'			Me.ceEnableAutoRepeat.CheckedChanged += New System.EventHandler(Me.ceEnableAutoRepeat_CheckedChanged)
			' 
			' icbTextLocations
			' 
			Me.icbTextLocations.EditValue = "imageComboBoxEdit1"
			Me.icbTextLocations.Location = New System.Drawing.Point(107, 32)
			Me.icbTextLocations.Name = "icbTextLocations"
			Me.icbTextLocations.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbTextLocations.Size = New System.Drawing.Size(155, 20)
			Me.icbTextLocations.TabIndex = 16
'			Me.icbTextLocations.SelectedIndexChanged += New System.EventHandler(Me.icbTextLocations_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 35)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(66, 13)
			Me.label3.TabIndex = 17
			Me.label3.Text = "Text location:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.dataNavigatorSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(388, 132)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' dataNavigatorSample
			' 
			Me.dataNavigatorSample.Buttons.ImageList = Me.imlSmall
			Me.dataNavigatorSample.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() { New DevExpress.XtraEditors.NavigatorCustomButton(-1, 2, True, True, "Search", "Search"), New DevExpress.XtraEditors.NavigatorCustomButton(-1, 0, True, True, "Lock", "Lock")})
			Me.dataNavigatorSample.Location = New System.Drawing.Point(12, 36)
			Me.dataNavigatorSample.Name = "dataNavigatorSample"
			Me.dataNavigatorSample.Size = New System.Drawing.Size(282, 24)
			Me.dataNavigatorSample.TabIndex = 0
			Me.dataNavigatorSample.Text = "dataNavigator1"
'			Me.dataNavigatorSample.ButtonClick += New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(Me.dataNavigatorSample_ButtonClick)
			' 
			' imlSmall
			' 
			Me.imlSmall.ImageStream = (CType(resources.GetObject("imlSmall.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlSmall.TransparentColor = System.Drawing.Color.Magenta
			Me.imlSmall.Images.SetKeyName(0, "")
			Me.imlSmall.Images.SetKeyName(1, "")
			Me.imlSmall.Images.SetKeyName(2, "")
			Me.imlSmall.Images.SetKeyName(3, "")
			' 
			' ModuleNavigator
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleNavigator"
			Me.Size = New System.Drawing.Size(940, 616)
'			Me.Load += New System.EventHandler(Me.ModuleNavigator_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl5.ResumeLayout(False)
			CType(Me.meFiringEvents.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.ceShowPageButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowAppendRemove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowEditingButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowCustomButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceShowToolTips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceEnableAutoRepeat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbTextLocations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents icbTextLocations As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceEnableAutoRepeat As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowToolTips As DevExpress.XtraEditors.CheckEdit
		Private imlSmall As System.Windows.Forms.ImageList
		Private WithEvents ceShowCustomButtons As DevExpress.XtraEditors.CheckEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceShowEditingButtons As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowAppendRemove As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowPageButtons As DevExpress.XtraEditors.CheckEdit
		Private groupControl5 As DevExpress.XtraEditors.GroupControl
		Private meFiringEvents As DevExpress.XtraEditors.MemoEdit
		Private WithEvents dataNavigatorSample As DevExpress.XtraEditors.DataNavigator

	End Class
End Namespace
