Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModulePopupContainerEdit
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
			Me.icbShowDropDown = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowPopupShadow = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowPopupCloseButton = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceCloseOnOuterMouseClick = New DevExpress.XtraEditors.CheckEdit()
			Me.popupContainerControlSample = New DevExpress.XtraEditors.PopupContainerControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.ilbFont = New DevExpress.XtraEditors.ImageListBoxControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.clbStyle = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.seSize = New DevExpress.XtraEditors.SpinEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.lbSample = New DevExpress.XtraEditors.LabelControl()
			Me.popupContainerEditSample = New DevExpress.XtraEditors.PopupContainerEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.icbShowDropDown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowPopupShadow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowPopupCloseButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceCloseOnOuterMouseClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControlSample, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControlSample.SuspendLayout()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.ilbFont, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clbStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.popupContainerEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(780, 557)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.popupContainerControlSample)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(774, 551)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.icbShowDropDown)
			Me.groupControl2.Controls.Add(Me.label4)
			Me.groupControl2.Controls.Add(Me.cePopupSizeable)
			Me.groupControl2.Controls.Add(Me.ceShowPopupShadow)
			Me.groupControl2.Controls.Add(Me.ceShowPopupCloseButton)
			Me.groupControl2.Location = New System.Drawing.Point(301, 111)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(240, 145)
			Me.groupControl2.TabIndex = 4
			Me.groupControl2.Text = "Popup properties"
			' 
			' icbShowDropDown
			' 
			Me.icbShowDropDown.EditValue = "imageComboBoxEdit1"
			Me.icbShowDropDown.Location = New System.Drawing.Point(116, 30)
			Me.icbShowDropDown.Name = "icbShowDropDown"
			Me.icbShowDropDown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbShowDropDown.Size = New System.Drawing.Size(112, 20)
			Me.icbShowDropDown.TabIndex = 0
'			Me.icbShowDropDown.SelectedIndexChanged += New System.EventHandler(Me.icbShowDropDown_SelectedIndexChanged)
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 33)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(83, 13)
			Me.label4.TabIndex = 25
			Me.label4.Text = "Show DropDown:"
			' 
			' cePopupSizeable
			' 
			Me.cePopupSizeable.Location = New System.Drawing.Point(18, 59)
			Me.cePopupSizeable.Name = "cePopupSizeable"
			Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
			Me.cePopupSizeable.Size = New System.Drawing.Size(168, 19)
			Me.cePopupSizeable.TabIndex = 1
'			Me.cePopupSizeable.CheckedChanged += New System.EventHandler(Me.cePopupSizeable_CheckedChanged)
			' 
			' ceShowPopupShadow
			' 
			Me.ceShowPopupShadow.Location = New System.Drawing.Point(18, 109)
			Me.ceShowPopupShadow.Name = "ceShowPopupShadow"
			Me.ceShowPopupShadow.Properties.Caption = "Show popup shadow"
			Me.ceShowPopupShadow.Size = New System.Drawing.Size(168, 19)
			Me.ceShowPopupShadow.TabIndex = 3
'			Me.ceShowPopupShadow.CheckedChanged += New System.EventHandler(Me.ceShowPopupShadow_CheckedChanged)
			' 
			' ceShowPopupCloseButton
			' 
			Me.ceShowPopupCloseButton.Location = New System.Drawing.Point(18, 84)
			Me.ceShowPopupCloseButton.Name = "ceShowPopupCloseButton"
			Me.ceShowPopupCloseButton.Properties.Caption = "Show Popup Close button"
			Me.ceShowPopupCloseButton.Size = New System.Drawing.Size(168, 19)
			Me.ceShowPopupCloseButton.TabIndex = 2
'			Me.ceShowPopupCloseButton.CheckedChanged += New System.EventHandler(Me.ceShowPopupCloseButton_CheckedChanged)
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceCloseOnOuterMouseClick)
			Me.groupControl1.Location = New System.Drawing.Point(301, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(240, 60)
			Me.groupControl1.TabIndex = 3
			Me.groupControl1.Text = "Properties"
			' 
			' ceCloseOnOuterMouseClick
			' 
			Me.ceCloseOnOuterMouseClick.Location = New System.Drawing.Point(18, 30)
			Me.ceCloseOnOuterMouseClick.Name = "ceCloseOnOuterMouseClick"
			Me.ceCloseOnOuterMouseClick.Properties.Caption = "Close on outer mouse click"
			Me.ceCloseOnOuterMouseClick.Size = New System.Drawing.Size(168, 19)
			Me.ceCloseOnOuterMouseClick.TabIndex = 1
'			Me.ceCloseOnOuterMouseClick.CheckedChanged += New System.EventHandler(Me.ceCloseOnOuterMouseClick_CheckedChanged)
			' 
			' popupContainerControlSample
			' 
			Me.popupContainerControlSample.Controls.Add(Me.splitContainerControl1)
			Me.popupContainerControlSample.Location = New System.Drawing.Point(20, 306)
			Me.popupContainerControlSample.Name = "popupContainerControlSample"
			Me.popupContainerControlSample.Padding = New System.Windows.Forms.Padding(4)
			Me.popupContainerControlSample.Size = New System.Drawing.Size(384, 225)
			Me.popupContainerControlSample.TabIndex = 2
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.splitContainerControl1.Location = New System.Drawing.Point(4, 4)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.ilbFont)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.label2)
			Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.clbStyle)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.label3)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.seSize)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.label1)
			Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(376, 217)
			Me.splitContainerControl1.SplitterPosition = 107
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' ilbFont
			' 
			Me.ilbFont.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ilbFont.ItemHeight = 16
			Me.ilbFont.Location = New System.Drawing.Point(0, 17)
			Me.ilbFont.Name = "ilbFont"
			Me.ilbFont.Size = New System.Drawing.Size(264, 200)
			Me.ilbFont.TabIndex = 14
'			Me.ilbFont.DoubleClick += New System.EventHandler(Me.ilbFont_DoubleClick)
'			Me.ilbFont.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.popupFont_KeyDown)
			' 
			' label2
			' 
			Me.label2.Dock = System.Windows.Forms.DockStyle.Top
			Me.label2.Location = New System.Drawing.Point(0, 0)
			Me.label2.Name = "label2"
			Me.label2.Padding = New System.Windows.Forms.Padding(2)
			Me.label2.Size = New System.Drawing.Size(30, 17)
			Me.label2.TabIndex = 15
			Me.label2.Text = "Font:"
			' 
			' clbStyle
			' 
			Me.clbStyle.CheckOnClick = True
			Me.clbStyle.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clbStyle.ItemHeight = 16
			Me.clbStyle.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Bold"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Italic"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Strikeout"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Underline")})
			Me.clbStyle.Location = New System.Drawing.Point(0, 17)
			Me.clbStyle.Name = "clbStyle"
			Me.clbStyle.Size = New System.Drawing.Size(107, 163)
			Me.clbStyle.TabIndex = 17
'			Me.clbStyle.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.popupFont_KeyDown)
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label3.Location = New System.Drawing.Point(0, 180)
			Me.label3.Name = "label3"
			Me.label3.Padding = New System.Windows.Forms.Padding(2)
			Me.label3.Size = New System.Drawing.Size(27, 17)
			Me.label3.TabIndex = 19
			Me.label3.Text = "Size:"
			' 
			' seSize
			' 
			Me.seSize.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.seSize.EditValue = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.seSize.Location = New System.Drawing.Point(0, 197)
			Me.seSize.Name = "seSize"
			Me.seSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seSize.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.seSize.Properties.MinValue = New Decimal(New Integer() { 6, 0, 0, 0})
			Me.seSize.Properties.ValidateOnEnterKey = True
			Me.seSize.Size = New System.Drawing.Size(107, 20)
			Me.seSize.TabIndex = 18
'			Me.seSize.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.popupFont_KeyDown)
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Top
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Padding = New System.Windows.Forms.Padding(2)
			Me.label1.Size = New System.Drawing.Size(57, 17)
			Me.label1.TabIndex = 16
			Me.label1.Text = "Font Style:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.lbSample)
			Me.panelControl1.Controls.Add(Me.popupContainerEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(240, 226)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' lbSample
			' 
			Me.lbSample.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbSample.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.lbSample.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.lbSample.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbSample.Location = New System.Drawing.Point(8, 23)
			Me.lbSample.Name = "lbSample"
			Me.lbSample.Size = New System.Drawing.Size(224, 47)
			Me.lbSample.TabIndex = 1
			Me.lbSample.Text = "Font Sample"
			' 
			' popupContainerEditSample
			' 
			Me.popupContainerEditSample.EditValue = "popupContainerEdit1"
			Me.popupContainerEditSample.Location = New System.Drawing.Point(19, 76)
			Me.popupContainerEditSample.Name = "popupContainerEditSample"
			Me.popupContainerEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEditSample.Properties.PopupControl = Me.popupContainerControlSample
			Me.popupContainerEditSample.Size = New System.Drawing.Size(203, 20)
			Me.popupContainerEditSample.TabIndex = 0
'			Me.popupContainerEditSample.QueryResultValue += New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(Me.popupContainerEditSample_QueryResultValue)
'			Me.popupContainerEditSample.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.popupContainerEditSample_QueryPopUp)
			' 
			' ModulePopupContainerEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModulePopupContainerEdit"
			Me.Size = New System.Drawing.Size(785, 562)
'			Me.Load += New System.EventHandler(Me.ModulePopupContainerEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.icbShowDropDown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowPopupShadow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowPopupCloseButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.ceCloseOnOuterMouseClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControlSample, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControlSample.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.ilbFont, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clbStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.popupContainerEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents popupContainerEditSample As DevExpress.XtraEditors.PopupContainerEdit
		Private popupContainerControlSample As DevExpress.XtraEditors.PopupContainerControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ilbFont As DevExpress.XtraEditors.ImageListBoxControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents clbStyle As DevExpress.XtraEditors.CheckedListBoxControl
		Private WithEvents seSize As DevExpress.XtraEditors.SpinEdit
		Private lbSample As DevExpress.XtraEditors.LabelControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents icbShowDropDown As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cePopupSizeable As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowPopupShadow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowPopupCloseButton As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceCloseOnOuterMouseClick As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
