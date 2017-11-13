Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class NavBarHints
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(NavBarHints))
			Me.imageList1 = New ImageList(Me.components)
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.imageList2 = New ImageList(Me.components)
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceCustomHint = New DevExpress.XtraEditors.CheckEdit()
			Me.seInterval = New DevExpress.XtraEditors.SpinEdit()
			Me.ceLinkHint = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ceGroupHint = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceCustomHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceLinkHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceGroupHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panelControl1)
			Me.contentPanel_Renamed.Margin = New Padding(2)
			Me.contentPanel_Renamed.Padding = New Padding(3)
			Me.contentPanel_Renamed.Size = New Size(595, 436)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			Me.imageList1.Images.SetKeyName(8, "")
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup3
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(3, 3)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
			Me.navBarControl1.Size = New Size(172, 411)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 28
'			Me.navBarControl1.GetHint += New DevExpress.XtraNavBar.NavBarGetHintEventHandler(Me.navBarControl1_GetHint)
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "Deleted"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup3.Hint = "Deleted Group hint"
			Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup3.LargeImageIndex = 3
			Me.navBarGroup3.Name = "navBarGroup3"
			Me.navBarGroup3.SmallImageIndex = 3
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "Report"
			Me.navBarItem5.Hint = "Report hint"
			Me.navBarItem5.LargeImageIndex = 4
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 4
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "Deleted Items"
			Me.navBarItem4.Enabled = False
			Me.navBarItem4.Hint = "Deleted Items folder"
			Me.navBarItem4.LargeImageIndex = 3
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImageIndex = 3
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Local"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.Hint = "Local Group hint"
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup1.LargeImageIndex = 5
			Me.navBarGroup1.Name = "navBarGroup1"
			Me.navBarGroup1.SmallImageIndex = 5
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "Inbox"
			Me.navBarItem1.Hint = "Inbox folder"
			Me.navBarItem1.LargeImageIndex = 0
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 0
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "Outbox"
			Me.navBarItem2.Hint = "Outbox folder"
			Me.navBarItem2.LargeImageIndex = 1
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 1
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Sent Items"
			Me.navBarItem3.Enabled = False
			Me.navBarItem3.Hint = "Sent Items folder"
			Me.navBarItem3.LargeImageIndex = 2
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 2
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Contacts"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.navBarGroup2.Hint = "Contacts Group hint"
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7)})
			Me.navBarGroup2.LargeImageIndex = 6
			Me.navBarGroup2.Name = "navBarGroup2"
			Me.navBarGroup2.SmallImageIndex = 6
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "Calendar"
			Me.navBarItem6.Hint = "Calendar hint"
			Me.navBarItem6.LargeImageIndex = 7
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 7
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Caption = "Task"
			Me.navBarItem7.Hint = "Task hint"
			Me.navBarItem7.LargeImageIndex = 8
			Me.navBarItem7.Name = "navBarItem7"
			Me.navBarItem7.SmallImageIndex = 8
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), ImageListStreamer))
			Me.imageList2.TransparentColor = Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			Me.imageList2.Images.SetKeyName(3, "")
			Me.imageList2.Images.SetKeyName(4, "")
			Me.imageList2.Images.SetKeyName(5, "")
			Me.imageList2.Images.SetKeyName(6, "")
			Me.imageList2.Images.SetKeyName(7, "")
			Me.imageList2.Images.SetKeyName(8, "")
			' 
			' groupControl1
			' 
			Me.groupControl1.Anchor = AnchorStyles.Top
			Me.groupControl1.Controls.Add(Me.ceCustomHint)
			Me.groupControl1.Controls.Add(Me.seInterval)
			Me.groupControl1.Controls.Add(Me.ceLinkHint)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.ceGroupHint)
			Me.groupControl1.Location = New Point(223, 12)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New Size(320, 168)
			Me.groupControl1.TabIndex = 29
			Me.groupControl1.Text = "Properties"
			' 
			' ceCustomHint
			' 
			Me.ceCustomHint.Location = New Point(16, 128)
			Me.ceCustomHint.Name = "ceCustomHint"
			Me.ceCustomHint.Properties.Caption = "Custom Hint (GetHint event)"
			Me.ceCustomHint.Size = New Size(224, 19)
			Me.ceCustomHint.TabIndex = 4
			' 
			' seInterval
			' 
			Me.seInterval.EditValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.seInterval.Location = New Point(152, 88)
			Me.seInterval.Name = "seInterval"
			Me.seInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seInterval.Properties.Increment = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.seInterval.Properties.IsFloatValue = False
			Me.seInterval.Properties.Mask.EditMask = "N00"
			Me.seInterval.Properties.MaxValue = New Decimal(New Integer() { 10000, 0, 0, 0})
			Me.seInterval.Properties.MinValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.seInterval.Size = New Size(80, 20)
			Me.seInterval.TabIndex = 3
'			Me.seInterval.EditValueChanged += New System.EventHandler(Me.seInterval_EditValueChanged)
			' 
			' ceLinkHint
			' 
			Me.ceLinkHint.Location = New Point(16, 56)
			Me.ceLinkHint.Name = "ceLinkHint"
			Me.ceLinkHint.Properties.Caption = "Show Link Hint"
			Me.ceLinkHint.Size = New Size(144, 19)
			Me.ceLinkHint.TabIndex = 2
'			Me.ceLinkHint.CheckedChanged += New System.EventHandler(Me.ceLinkHint_CheckedChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New Point(24, 90)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New Size(93, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Show Hint Interval:"
			' 
			' ceGroupHint
			' 
			Me.ceGroupHint.Location = New Point(16, 32)
			Me.ceGroupHint.Name = "ceGroupHint"
			Me.ceGroupHint.Properties.Caption = "Show Group Hint"
			Me.ceGroupHint.Size = New Size(144, 19)
			Me.ceGroupHint.TabIndex = 0
'			Me.ceGroupHint.CheckedChanged += New System.EventHandler(Me.ceGroupHint_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.navBarControl1)
			Me.panelControl1.Controls.Add(Me.groupControl1)
			Me.panelControl1.Location = New Point(7, 8)
			Me.panelControl1.Margin = New Padding(2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(581, 417)
			Me.panelControl1.TabIndex = 30
			' 
			' NavBarHints
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "NavBarHints"
			Me.Size = New Size(595, 436)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceCustomHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceLinkHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceGroupHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private imageList1 As ImageList
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private imageList2 As ImageList
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceGroupHint As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceLinkHint As DevExpress.XtraEditors.CheckEdit
		Private WithEvents seInterval As DevExpress.XtraEditors.SpinEdit
		Private ceCustomHint As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As XtraEditors.PanelControl

	End Class
End Namespace
