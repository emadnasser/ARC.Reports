Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class GroupStyles
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GroupStyles))
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.imageList1 = New ImageList(Me.components)
			Me.imageList2 = New ImageList(Me.components)
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.cbContactImage = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbLocalImage = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.cbContactStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbLocalStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ceAllowSelectedLink = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.cbContactImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLocalImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbContactStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLocalStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAllowSelectedLink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panelControl1)
			Me.contentPanel_Renamed.Margin = New Padding(2)
			Me.contentPanel_Renamed.Padding = New Padding(3)
			Me.contentPanel_Renamed.Size = New Size(565, 463)
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "Inbox"
			Me.navBarItem1.LargeImageIndex = 0
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 0
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "Outbox"
			Me.navBarItem2.LargeImageIndex = 1
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 1
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
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Local"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
			Me.navBarGroup1.LargeImageIndex = 5
			Me.navBarGroup1.Name = "navBarGroup1"
			Me.navBarGroup1.SmallImageIndex = 5
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Sent Items"
			Me.navBarItem3.Enabled = False
			Me.navBarItem3.LargeImageIndex = 2
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 2
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "Deleted Items"
			Me.navBarItem4.Enabled = False
			Me.navBarItem4.LargeImageIndex = 3
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImageIndex = 3
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "Report"
			Me.navBarItem5.LargeImageIndex = 4
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 4
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "Calendar"
			Me.navBarItem6.LargeImageIndex = 7
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 7
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(3, 7)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
			Me.navBarControl1.Size = New Size(172, 432)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 21
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Contacts"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
			Me.navBarGroup2.LargeImageIndex = 6
			Me.navBarGroup2.Name = "navBarGroup2"
			Me.navBarGroup2.SmallImageIndex = 6
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Caption = "Task"
			Me.navBarItem7.LargeImageIndex = 8
			Me.navBarItem7.Name = "navBarItem7"
			Me.navBarItem7.SmallImageIndex = 8
			' 
			' groupControl1
			' 
			Me.groupControl1.Anchor = AnchorStyles.Top
			Me.groupControl1.Controls.Add(Me.cbContactImage)
			Me.groupControl1.Controls.Add(Me.cbLocalImage)
			Me.groupControl1.Controls.Add(Me.labelControl3)
			Me.groupControl1.Controls.Add(Me.labelControl4)
			Me.groupControl1.Controls.Add(Me.cbContactStyle)
			Me.groupControl1.Controls.Add(Me.cbLocalStyle)
			Me.groupControl1.Controls.Add(Me.labelControl2)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.ceAllowSelectedLink)
			Me.groupControl1.Location = New Point(223, 9)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New Size(320, 200)
			Me.groupControl1.TabIndex = 25
			Me.groupControl1.Text = "Properties"
			' 
			' cbContactImage
			' 
			Me.cbContactImage.Location = New Point(160, 160)
			Me.cbContactImage.Name = "cbContactImage"
			Me.cbContactImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbContactImage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbContactImage.Size = New Size(136, 20)
			Me.cbContactImage.TabIndex = 8
'			Me.cbContactImage.SelectedIndexChanged += New System.EventHandler(Me.cbContactImage_SelectedIndexChanged)
			' 
			' cbLocalImage
			' 
			Me.cbLocalImage.Location = New Point(160, 128)
			Me.cbLocalImage.Name = "cbLocalImage"
			Me.cbLocalImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLocalImage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLocalImage.Size = New Size(136, 20)
			Me.cbLocalImage.TabIndex = 7
'			Me.cbLocalImage.SelectedIndexChanged += New System.EventHandler(Me.cbLocalImage_SelectedIndexChanged)
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New Point(24, 164)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New Size(113, 13)
			Me.labelControl3.TabIndex = 6
			Me.labelControl3.Text = "'Contacts' group image:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New Point(24, 130)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New Size(94, 13)
			Me.labelControl4.TabIndex = 5
			Me.labelControl4.Text = "'Local' group image:"
			' 
			' cbContactStyle
			' 
			Me.cbContactStyle.Location = New Point(160, 96)
			Me.cbContactStyle.Name = "cbContactStyle"
			Me.cbContactStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbContactStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbContactStyle.Size = New Size(136, 20)
			Me.cbContactStyle.TabIndex = 4
'			Me.cbContactStyle.SelectedIndexChanged += New System.EventHandler(Me.cbContactStyle_SelectedIndexChanged)
			' 
			' cbLocalStyle
			' 
			Me.cbLocalStyle.Location = New Point(160, 64)
			Me.cbLocalStyle.Name = "cbLocalStyle"
			Me.cbLocalStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLocalStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLocalStyle.Size = New Size(136, 20)
			Me.cbLocalStyle.TabIndex = 3
'			Me.cbLocalStyle.SelectedIndexChanged += New System.EventHandler(Me.cbLocalStyle_SelectedIndexChanged)
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New Point(24, 99)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New Size(108, 13)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "'Contacts' group style:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New Point(24, 66)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New Size(89, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "'Local' group style:"
			' 
			' ceAllowSelectedLink
			' 
			Me.ceAllowSelectedLink.Location = New Point(16, 32)
			Me.ceAllowSelectedLink.Name = "ceAllowSelectedLink"
			Me.ceAllowSelectedLink.Properties.Caption = "Allow Selected Link"
			Me.ceAllowSelectedLink.Size = New Size(144, 19)
			Me.ceAllowSelectedLink.TabIndex = 0
'			Me.ceAllowSelectedLink.CheckedChanged += New System.EventHandler(Me.ceAllowSelectedLink_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.groupControl1)
			Me.panelControl1.Controls.Add(Me.navBarControl1)
			Me.panelControl1.Location = New Point(7, 5)
			Me.panelControl1.Margin = New Padding(2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(551, 451)
			Me.panelControl1.TabIndex = 26
			' 
			' GroupStyles
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "GroupStyles"
			Me.Size = New Size(565, 463)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.cbContactImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLocalImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbContactStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLocalStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAllowSelectedLink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private imageList1 As ImageList
		Private imageList2 As ImageList
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceAllowSelectedLink As DevExpress.XtraEditors.CheckEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbLocalStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbContactStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbContactImage As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbLocalImage As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As XtraEditors.PanelControl

	End Class
End Namespace
