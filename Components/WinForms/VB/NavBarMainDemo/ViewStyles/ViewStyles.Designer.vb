Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class ViewStyles
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ViewStyles))
			Me.lblStyles = New DevExpress.XtraEditors.LabelControl()
			Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.imageList2 = New ImageList(Me.components)
			Me.imageList1 = New ImageList(Me.components)
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panelControl1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Size = New Size(998, 404)
			' 
			' lblStyles
			' 
			Me.lblStyles.Location = New Point(62, 4)
			Me.lblStyles.Margin = New Padding(4)
			Me.lblStyles.Name = "lblStyles"
			Me.lblStyles.Size = New Size(39, 16)
			Me.lblStyles.TabIndex = 24
			Me.lblStyles.Text = "Views:"
			' 
			' listBox1
			' 
			Me.listBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
			Me.listBox1.Location = New Point(62, 25)
			Me.listBox1.Margin = New Padding(4)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New Size(267, 306)
			Me.listBox1.TabIndex = 25
'			Me.listBox1.SelectedIndexChanged += New System.EventHandler(Me.listBox1_SelectedIndexChanged)
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
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.Dock = DockStyle.Left
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(6, 6)
			Me.navBarControl1.Margin = New Padding(4)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 229
			Me.navBarControl1.Size = New Size(229, 392)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 26
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
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "Calendar"
			Me.navBarItem6.LargeImageIndex = 7
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 7
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Caption = "Task"
			Me.navBarItem7.LargeImageIndex = 8
			Me.navBarItem7.Name = "navBarItem7"
			Me.navBarItem7.SmallImageIndex = 8
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "Report"
			Me.navBarItem5.LargeImageIndex = 4
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 4
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
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.lblStyles)
			Me.panelControl1.Controls.Add(Me.listBox1)
			Me.panelControl1.Dock = DockStyle.Fill
			Me.panelControl1.Location = New Point(235, 6)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(757, 392)
			Me.panelControl1.TabIndex = 27
			' 
			' ViewStyles
			' 
			Me.Appearance.Font = New Font("Tahoma", 8.25F)
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(8F, 17F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Margin = New Padding(4)
			Me.Name = "ViewStyles"
			Me.Size = New Size(998, 404)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private lblStyles As DevExpress.XtraEditors.LabelControl
		Private WithEvents listBox1 As DevExpress.XtraEditors.ListBoxControl
		Private imageList2 As ImageList
		Private imageList1 As ImageList
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As XtraEditors.PanelControl

	End Class
End Namespace
