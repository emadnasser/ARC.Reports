Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class HitInfo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HitInfo))
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label5 = New DevExpress.XtraEditors.LabelControl()
			Me.label6 = New DevExpress.XtraEditors.LabelControl()
			Me.label7 = New DevExpress.XtraEditors.LabelControl()
			Me.imageList1 = New ImageList(Me.components)
			Me.imageList2 = New ImageList(Me.components)
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
			Me.lbHitTest = New DevExpress.XtraEditors.TextEdit()
			Me.lbGroup = New DevExpress.XtraEditors.TextEdit()
			Me.lbLink = New DevExpress.XtraEditors.TextEdit()
			Me.lbPoint = New DevExpress.XtraEditors.TextEdit()
			Me.lbClick = New DevExpress.XtraEditors.MemoEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbHitTest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbLink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbPoint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panelControl1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Margin = New Padding(2, 2, 2, 2)
			Me.contentPanel_Renamed.Padding = New Padding(3, 3, 3, 3)
			Me.contentPanel_Renamed.Size = New Size(554, 391)
			' 
			' label3
			' 
			Me.label3.Location = New Point(26, 1)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(38, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "HitTest:"
			' 
			' label4
			' 
			Me.label4.Location = New Point(26, 26)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(33, 13)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Group:"
			' 
			' label5
			' 
			Me.label5.Location = New Point(26, 50)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(22, 13)
			Me.label5.TabIndex = 8
			Me.label5.Text = "Link:"
			' 
			' label6
			' 
			Me.label6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.label6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.label6.Location = New Point(26, 104)
			Me.label6.Name = "label6"
			Me.label6.Size = New Size(74, 48)
			Me.label6.TabIndex = 10
			Me.label6.Text = "Last Link Clicked:"
			' 
			' label7
			' 
			Me.label7.Location = New Point(26, 74)
			Me.label7.Name = "label7"
			Me.label7.Size = New Size(28, 13)
			Me.label7.TabIndex = 9
			Me.label7.Text = "Point:"
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
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(4, 3)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
			Me.navBarControl1.Size = New Size(172, 380)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
'			Me.navBarControl1.LinkClicked += New DevExpress.XtraNavBar.NavBarLinkEventHandler(Me.navBarControl1_LinkClicked)
'			Me.navBarControl1.MouseLeave += New System.EventHandler(Me.navBarControl1_MouseLeave)
'			Me.navBarControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.navBarControl1_MouseMove)
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
			' lbHitTest
			' 
			Me.lbHitTest.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lbHitTest.Location = New Point(106, 0)
			Me.lbHitTest.Name = "lbHitTest"
			Me.lbHitTest.Properties.Appearance.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.lbHitTest.Properties.Appearance.Options.UseFont = True
			Me.lbHitTest.Properties.ReadOnly = True
			Me.lbHitTest.Size = New Size(253, 20)
			Me.lbHitTest.TabIndex = 1
			' 
			' lbGroup
			' 
			Me.lbGroup.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lbGroup.Location = New Point(106, 24)
			Me.lbGroup.Name = "lbGroup"
			Me.lbGroup.Properties.ReadOnly = True
			Me.lbGroup.Size = New Size(253, 20)
			Me.lbGroup.TabIndex = 2
			' 
			' lbLink
			' 
			Me.lbLink.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lbLink.Location = New Point(106, 48)
			Me.lbLink.Name = "lbLink"
			Me.lbLink.Properties.ReadOnly = True
			Me.lbLink.Size = New Size(253, 20)
			Me.lbLink.TabIndex = 3
			' 
			' lbPoint
			' 
			Me.lbPoint.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lbPoint.Location = New Point(106, 72)
			Me.lbPoint.Name = "lbPoint"
			Me.lbPoint.Properties.ReadOnly = True
			Me.lbPoint.Size = New Size(253, 20)
			Me.lbPoint.TabIndex = 4
			' 
			' lbClick
			' 
			Me.lbClick.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lbClick.Location = New Point(106, 104)
			Me.lbClick.Name = "lbClick"
			Me.lbClick.Properties.Appearance.BackColor = SystemColors.Info
			Me.lbClick.Properties.Appearance.Options.UseBackColor = True
			Me.lbClick.Properties.ReadOnly = True
			Me.lbClick.Properties.ScrollBars = ScrollBars.None
			Me.lbClick.Size = New Size(253, 48)
			Me.lbClick.TabIndex = 5
			Me.lbClick.UseOptimizedRendering = True
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.label3)
			Me.panelControl1.Controls.Add(Me.lbClick)
			Me.panelControl1.Controls.Add(Me.label4)
			Me.panelControl1.Controls.Add(Me.lbPoint)
			Me.panelControl1.Controls.Add(Me.label5)
			Me.panelControl1.Controls.Add(Me.lbLink)
			Me.panelControl1.Controls.Add(Me.label6)
			Me.panelControl1.Controls.Add(Me.lbGroup)
			Me.panelControl1.Controls.Add(Me.label7)
			Me.panelControl1.Controls.Add(Me.lbHitTest)
			Me.panelControl1.Location = New Point(182, 5)
			Me.panelControl1.Margin = New Padding(2, 2, 2, 2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(365, 378)
			Me.panelControl1.TabIndex = 11
			' 
			' HitInfo
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "HitInfo"
			Me.Size = New Size(554, 391)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbHitTest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbLink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbPoint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private label6 As DevExpress.XtraEditors.LabelControl
		Private label7 As DevExpress.XtraEditors.LabelControl
		Private imageList1 As ImageList
		Private imageList2 As ImageList
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
		Private lbHitTest As DevExpress.XtraEditors.TextEdit
		Private lbGroup As DevExpress.XtraEditors.TextEdit
		Private lbLink As DevExpress.XtraEditors.TextEdit
		Private lbPoint As DevExpress.XtraEditors.TextEdit
		Private lbClick As DevExpress.XtraEditors.MemoEdit
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As XtraEditors.PanelControl

	End Class
End Namespace
