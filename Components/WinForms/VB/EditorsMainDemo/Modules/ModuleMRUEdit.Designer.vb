Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMRUEdit
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAllowAdding = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAllowRemoveItems = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowCustomButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.seMaxItemCount = New DevExpress.XtraEditors.SpinEdit()
			Me.lblSelect = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.mruEditSample = New DevExpress.XtraEditors.MRUEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceAllowAdding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceAllowRemoveItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowCustomButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMaxItemCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.mruEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(794, 519)
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
			Me.xtraTabPage1.Size = New System.Drawing.Size(788, 513)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.ceAllowAdding)
			Me.groupControl2.Location = New System.Drawing.Point(349, 178)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(234, 60)
			Me.groupControl2.TabIndex = 2
			Me.groupControl2.Text = "AddingMRUItem event"
			' 
			' ceAllowAdding
			' 
			Me.ceAllowAdding.EditValue = True
			Me.ceAllowAdding.Location = New System.Drawing.Point(20, 30)
			Me.ceAllowAdding.Name = "ceAllowAdding"
			Me.ceAllowAdding.Properties.Caption = "Allow adding item to a mru list"
			Me.ceAllowAdding.Size = New System.Drawing.Size(184, 19)
			Me.ceAllowAdding.TabIndex = 0
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceAllowRemoveItems)
			Me.groupControl1.Controls.Add(Me.ceShowCustomButtons)
			Me.groupControl1.Controls.Add(Me.seMaxItemCount)
			Me.groupControl1.Controls.Add(Me.lblSelect)
			Me.groupControl1.Location = New System.Drawing.Point(349, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(234, 127)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Properties"
			' 
			' ceAllowRemoveItems
			' 
			Me.ceAllowRemoveItems.Location = New System.Drawing.Point(18, 61)
			Me.ceAllowRemoveItems.Name = "ceAllowRemoveItems"
			Me.ceAllowRemoveItems.Properties.Caption = "Allow Remove MRU Items"
			Me.ceAllowRemoveItems.Size = New System.Drawing.Size(188, 19)
			Me.ceAllowRemoveItems.TabIndex = 1
'			Me.ceAllowRemoveItems.CheckedChanged += New System.EventHandler(Me.ceAllowRemoveItems_CheckedChanged)
			' 
			' ceShowCustomButtons
			' 
			Me.ceShowCustomButtons.Location = New System.Drawing.Point(18, 86)
			Me.ceShowCustomButtons.Name = "ceShowCustomButtons"
			Me.ceShowCustomButtons.Properties.Caption = "Show custom buttons"
			Me.ceShowCustomButtons.Size = New System.Drawing.Size(188, 19)
			Me.ceShowCustomButtons.TabIndex = 2
'			Me.ceShowCustomButtons.CheckedChanged += New System.EventHandler(Me.ceShowCustomButtons_CheckedChanged)
			' 
			' seMaxItemCount
			' 
			Me.seMaxItemCount.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMaxItemCount.Location = New System.Drawing.Point(132, 32)
			Me.seMaxItemCount.Name = "seMaxItemCount"
			Me.seMaxItemCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMaxItemCount.Properties.IsFloatValue = False
			Me.seMaxItemCount.Properties.Mask.EditMask = "N00"
			Me.seMaxItemCount.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.seMaxItemCount.Size = New System.Drawing.Size(80, 20)
			Me.seMaxItemCount.TabIndex = 0
'			Me.seMaxItemCount.EditValueChanged += New System.EventHandler(Me.seMaxItemCount_EditValueChanged)
			' 
			' lblSelect
			' 
			Me.lblSelect.Location = New System.Drawing.Point(20, 35)
			Me.lblSelect.Name = "lblSelect"
			Me.lblSelect.Size = New System.Drawing.Size(75, 13)
			Me.lblSelect.TabIndex = 3
			Me.lblSelect.Text = "MaxItemCount:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.mruEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(288, 208)
			Me.panelControl1.TabIndex = 0
			Me.panelControl1.Text = "Sample"
			' 
			' mruEditSample
			' 
			Me.mruEditSample.EditValue = "www.devexpress.com"
			Me.mruEditSample.Location = New System.Drawing.Point(27, 73)
			Me.mruEditSample.Name = "mruEditSample"
			Me.mruEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open file", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Open file", Nothing, False)})
			Me.mruEditSample.Properties.Items.AddRange(New Object() { "www.devexpress.com", "www.devexpress.com/ClientCenter/Downloads/#Trials", "www.devexpress.com/ClientCenter/Purchase/"})
			Me.mruEditSample.Size = New System.Drawing.Size(224, 20)
			Me.mruEditSample.TabIndex = 0
'			Me.mruEditSample.AddingMRUItem += New DevExpress.XtraEditors.Controls.AddingMRUItemEventHandler(Me.mruEditSample_AddingMRUItem)
'			Me.mruEditSample.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.mruEditSample_ButtonClick)
			' 
			' ModuleMRUEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleMRUEdit"
			Me.Size = New System.Drawing.Size(799, 524)
'			Me.Load += New System.EventHandler(Me.ModuleMRUEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.ceAllowAdding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceAllowRemoveItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowCustomButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMaxItemCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.mruEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents mruEditSample As DevExpress.XtraEditors.MRUEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents seMaxItemCount As DevExpress.XtraEditors.SpinEdit
		Private lblSelect As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceShowCustomButtons As DevExpress.XtraEditors.CheckEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private ceAllowAdding As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents ceAllowRemoveItems As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
