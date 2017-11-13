Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarBlending
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmNavBarBlending))
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.imageList1 = New ImageList(Me.components)
			Me.imageList2 = New ImageList(Me.components)
			Me.ctrlAlphaBlending1 = New DevExpress.XtraNavBar.Demos.ctrlAlphaBlending()
			Me.ctrlAlphaBlending2 = New DevExpress.XtraNavBar.Demos.ctrlAlphaBlending()
			Me.ctrlAlphaBlending3 = New DevExpress.XtraNavBar.Demos.ctrlAlphaBlending()
			Me.ctrlAlphaBlending4 = New DevExpress.XtraNavBar.Demos.ctrlAlphaBlending()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.ctrlAlphaBlending4)
			Me.contentPanel_Renamed.Controls.Add(Me.ctrlAlphaBlending3)
			Me.contentPanel_Renamed.Controls.Add(Me.ctrlAlphaBlending2)
			Me.contentPanel_Renamed.Controls.Add(Me.ctrlAlphaBlending1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Margin = New Padding(4, 4, 4, 4)
			Me.contentPanel_Renamed.Padding = New Padding(5, 5, 5, 5)
			Me.contentPanel_Renamed.Size = New Size(1005, 659)
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
			Me.navBarControl1.Appearance.Background.BackColor = Color.FromArgb((CInt((CByte(120)))), (CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(100)))))
			Me.navBarControl1.Appearance.Background.Options.UseBackColor = True
			Me.navBarControl1.Appearance.GroupBackground.BackColor = Color.FromArgb((CInt((CByte(119)))), (CInt((CByte(174)))), (CInt((CByte(215)))))
			Me.navBarControl1.Appearance.GroupBackground.Font = New Font("Verdana", 8.25F)
			Me.navBarControl1.Appearance.GroupBackground.Options.UseBackColor = True
			Me.navBarControl1.Appearance.GroupBackground.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeader.Font = New Font("Verdana", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeader.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeaderActive.Font = New Font("Verdana", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeaderActive.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.Font = New Font("Verdana", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.navBarControl1.Appearance.GroupHeaderPressed.Font = New Font("Verdana", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeaderPressed.Options.UseFont = True
			Me.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Appearance.ItemHotTracked.Font = New Font("Tahoma", 8F, FontStyle.Underline)
			Me.navBarControl1.Appearance.ItemHotTracked.Options.UseFont = True
			Me.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Appearance.ItemPressed.Font = New Font("Tahoma", 8F, FontStyle.Underline)
			Me.navBarControl1.Appearance.ItemPressed.Options.UseFont = True
			Me.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(5, 5)
			Me.navBarControl1.Margin = New Padding(4, 4, 4, 4)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 229
			Me.navBarControl1.Size = New Size(229, 741)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
			Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
'			Me.navBarControl1.CustomDrawGroupClientForeground += New DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(Me.navBarControl1_CustomDrawGroupClientForeground)
'			Me.navBarControl1.MouseLeave += New System.EventHandler(Me.navBarControl1_MouseLeave)
'			Me.navBarControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.navBarControl1_MouseMove)
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.AppearanceBackground.BackColor = Color.FromArgb((CInt((CByte(90)))), (CInt((CByte(193)))), (CInt((CByte(227)))), (CInt((CByte(151)))))
			Me.navBarGroup2.AppearanceBackground.Options.UseBackColor = True
			Me.navBarGroup2.BackgroundImage = (CType(resources.GetObject("navBarGroup2.BackgroundImage"), Image))
			Me.navBarGroup2.Caption = "Other Places"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6)})
			Me.navBarGroup2.LargeImageIndex = 1
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "Desktop"
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImageIndex = 0
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "My Computer"
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 1
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "My Network Places"
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 2
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.AppearanceBackground.BackColor = Color.FromArgb((CInt((CByte(10)))), (CInt((CByte(145)))), (CInt((CByte(236)))), (CInt((CByte(247)))))
			Me.navBarGroup1.AppearanceBackground.Options.UseBackColor = True
			Me.navBarGroup1.BackgroundImage = (CType(resources.GetObject("navBarGroup1.BackgroundImage"), Image))
			Me.navBarGroup1.Caption = "My Documents"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3)})
			Me.navBarGroup1.LargeImageIndex = 0
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "My Music"
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 3
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "My Pictures"
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 4
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Received Files"
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 5
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "Details"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.LargeImageIndex = 2
			Me.navBarGroup3.Name = "navBarGroup3"
'			Me.navBarGroup3.CalcGroupClientHeight += New DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventHandler(Me.navBarGroup3_CalcGroupClientHeight)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
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
			' 
			' ctrlAlphaBlending1
			' 
			Me.ctrlAlphaBlending1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.ctrlAlphaBlending1.Location = New Point(254, 5)
			Me.ctrlAlphaBlending1.Margin = New Padding(4, 5, 4, 5)
			Me.ctrlAlphaBlending1.Name = "ctrlAlphaBlending1"
			Me.ctrlAlphaBlending1.Size = New Size(706, 118)
			Me.ctrlAlphaBlending1.TabIndex = 1
			' 
			' ctrlAlphaBlending2
			' 
			Me.ctrlAlphaBlending2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.ctrlAlphaBlending2.Location = New Point(254, 131)
			Me.ctrlAlphaBlending2.Margin = New Padding(4, 5, 4, 5)
			Me.ctrlAlphaBlending2.Name = "ctrlAlphaBlending2"
			Me.ctrlAlphaBlending2.Size = New Size(706, 118)
			Me.ctrlAlphaBlending2.TabIndex = 2
			' 
			' ctrlAlphaBlending3
			' 
			Me.ctrlAlphaBlending3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.ctrlAlphaBlending3.Location = New Point(254, 256)
			Me.ctrlAlphaBlending3.Margin = New Padding(4, 5, 4, 5)
			Me.ctrlAlphaBlending3.Name = "ctrlAlphaBlending3"
			Me.ctrlAlphaBlending3.Size = New Size(706, 118)
			Me.ctrlAlphaBlending3.TabIndex = 3
			' 
			' ctrlAlphaBlending4
			' 
			Me.ctrlAlphaBlending4.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.ctrlAlphaBlending4.Location = New Point(254, 382)
			Me.ctrlAlphaBlending4.Margin = New Padding(4, 5, 4, 5)
			Me.ctrlAlphaBlending4.Name = "ctrlAlphaBlending4"
			Me.ctrlAlphaBlending4.Size = New Size(706, 122)
			Me.ctrlAlphaBlending4.TabIndex = 4
			' 
			' frmNavBarBlending
			' 
			Me.Appearance.Font = New Font("Tahoma", 8.25F)
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(8F, 17F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Margin = New Padding(4, 4, 4, 4)
			Me.Name = "frmNavBarBlending"
			Me.Size = New Size(1005, 659)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private imageList1 As ImageList
		Private imageList2 As ImageList
		Private ctrlAlphaBlending1 As ctrlAlphaBlending
		Private ctrlAlphaBlending2 As ctrlAlphaBlending
		Private ctrlAlphaBlending3 As ctrlAlphaBlending
		Private ctrlAlphaBlending4 As ctrlAlphaBlending
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
