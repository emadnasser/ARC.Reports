Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class CustomDraw
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomDraw))
			Me.imageList1 = New ImageList(Me.components)
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox3 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox4 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox5 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox6 = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panelControl1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Size = New Size(675, 388)
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
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "My Documents"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2)})
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
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Other Places"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Desktop"
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 0
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "My Computer"
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImageIndex = 1
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "My Network Places"
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 2
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.Appearance.GroupHeader.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeader.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeaderActive.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeaderActive.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseFont = True
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.GroupHeaderPressed.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeaderPressed.Options.UseFont = True
			Me.navBarControl1.Appearance.ItemDisabled.BackColor = SystemColors.Window
			Me.navBarControl1.Appearance.ItemDisabled.Options.UseBackColor = True
			Me.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Appearance.ItemHotTracked.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Underline)
			Me.navBarControl1.Appearance.ItemHotTracked.Options.UseFont = True
			Me.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Appearance.ItemPressed.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Underline)
			Me.navBarControl1.Appearance.ItemPressed.Options.UseFont = True
			Me.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = True
			Me.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.navBarControl1.Dock = DockStyle.Left
			Me.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
			Me.navBarControl1.ExplorerBarGroupInterval = 10
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(6, 6)
			Me.navBarControl1.Margin = New Padding(4)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 229
			Me.navBarControl1.Size = New Size(229, 376)
			Me.navBarControl1.SmallImages = Me.imageList1
			Me.navBarControl1.TabIndex = 21
			Me.navBarControl1.Text = "navBarControl1"
			Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.UltraFlatExplorerBarViewInfoRegistrator()
'			Me.navBarControl1.CustomDrawGroupCaption += New DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(Me.navBarControl1_CustomDrawGroupCaption)
'			Me.navBarControl1.CustomDrawLink += New DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(Me.navBarControl1_CustomDrawLink)
'			Me.navBarControl1.CustomDrawGroupClientBackground += New DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(Me.navBarControl1_CustomDrawGroupClientBackground)
'			Me.navBarControl1.CustomDrawGroupClientForeground += New DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(Me.navBarControl1_CustomDrawGroupClientForeground)
'			Me.navBarControl1.CustomDrawBackground += New DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(Me.navBarControl1_CustomDrawBackground)
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "Details"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.Name = "navBarGroup3"
'			Me.navBarGroup3.CalcGroupClientHeight += New DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventHandler(Me.navBarGroup3_CalcGroupClientHeight)
			' 
			' checkBox1
			' 
			Me.checkBox1.EditValue = True
			Me.checkBox1.Location = New Point(31, 4)
			Me.checkBox1.Margin = New Padding(4)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "CustomDrawBackground"
			Me.checkBox1.Size = New Size(283, 20)
			Me.checkBox1.TabIndex = 23
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox2
			' 
			Me.checkBox2.EditValue = True
			Me.checkBox2.Location = New Point(31, 36)
			Me.checkBox2.Margin = New Padding(4)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Properties.Caption = "CustomDrawGroupCaption"
			Me.checkBox2.Size = New Size(283, 20)
			Me.checkBox2.TabIndex = 24
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox3
			' 
			Me.checkBox3.EditValue = True
			Me.checkBox3.Location = New Point(31, 67)
			Me.checkBox3.Margin = New Padding(4)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Properties.Caption = "CustomDrawGroupClientBackground"
			Me.checkBox3.Size = New Size(283, 20)
			Me.checkBox3.TabIndex = 25
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox4
			' 
			Me.checkBox4.EditValue = True
			Me.checkBox4.Location = New Point(31, 99)
			Me.checkBox4.Margin = New Padding(4)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Properties.Caption = "CustomDrawGroupClientForeground"
			Me.checkBox4.Size = New Size(283, 20)
			Me.checkBox4.TabIndex = 26
'			Me.checkBox4.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox5
			' 
			Me.checkBox5.EditValue = True
			Me.checkBox5.Location = New Point(31, 130)
			Me.checkBox5.Margin = New Padding(4)
			Me.checkBox5.Name = "checkBox5"
			Me.checkBox5.Properties.Caption = "CustomDrawLink"
			Me.checkBox5.Size = New Size(283, 20)
			Me.checkBox5.TabIndex = 27
'			Me.checkBox5.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox6
			' 
			Me.checkBox6.EditValue = True
			Me.checkBox6.Location = New Point(31, 161)
			Me.checkBox6.Margin = New Padding(4)
			Me.checkBox6.Name = "checkBox6"
			Me.checkBox6.Properties.Caption = "CalcGroupClientHeight"
			Me.checkBox6.Size = New Size(283, 20)
			Me.checkBox6.TabIndex = 28
'			Me.checkBox6.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.checkBox1)
			Me.panelControl1.Controls.Add(Me.checkBox2)
			Me.panelControl1.Controls.Add(Me.checkBox6)
			Me.panelControl1.Controls.Add(Me.checkBox3)
			Me.panelControl1.Controls.Add(Me.checkBox5)
			Me.panelControl1.Controls.Add(Me.checkBox4)
			Me.panelControl1.Dock = DockStyle.Fill
			Me.panelControl1.Location = New Point(235, 6)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(434, 376)
			Me.panelControl1.TabIndex = 29
			' 
			' CustomDraw
			' 
			Me.Appearance.Font = New Font("Tahoma", 8.25F)
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(8F, 17F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Margin = New Padding(4)
			Me.Name = "CustomDraw"
			Me.Size = New Size(675, 388)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private imageList1 As ImageList
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private WithEvents navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox4 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox5 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox6 As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As XtraEditors.PanelControl

	End Class
End Namespace
