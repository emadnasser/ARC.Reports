Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class CustomizableDistances
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomizableDistances))
			Me.imageList2 = New ImageList(Me.components)
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.navBarGroup10 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem10 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem11 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem12 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup11 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem13 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem14 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem16 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup12 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.imageList1 = New ImageList(Me.components)
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.pnlHint = New DevExpress.Utils.Frames.NotePanel()
			Me.distanceChanger3 = New DevExpress.XtraNavBar.Demos.DistanceChanger()
			Me.distanceChanger2 = New DevExpress.XtraNavBar.Demos.DistanceChanger()
			Me.distanceChanger1 = New DevExpress.XtraNavBar.Demos.DistanceChanger()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarControl1.SuspendLayout()
			Me.navBarGroupControlContainer3.SuspendLayout()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.panel1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Padding = New Padding(3, 3, 3, 3)
			Me.contentPanel_Renamed.Size = New Size(597, 538)
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
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.Appearance.GroupHeader.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeader.Options.UseFont = True
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer3)
			Me.navBarControl1.ExplorerBarGroupInterval = 10
			Me.navBarControl1.ExplorerBarGroupOuterIndent = 5
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup10, Me.navBarGroup11, Me.navBarGroup12})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem7, Me.navBarItem8, Me.navBarItem9, Me.navBarItem10, Me.navBarItem11, Me.navBarItem12, Me.navBarItem13, Me.navBarItem14, Me.navBarItem16})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.LinkInterval = 0
			Me.navBarControl1.Location = New Point(4, 5)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
			Me.navBarControl1.Size = New Size(172, 525)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.TabIndex = 2
			Me.navBarControl1.Text = "navBarControl1"
			Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "System Tasks"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem8), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem9)})
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Caption = "View system information"
			Me.navBarItem7.Name = "navBarItem7"
			Me.navBarItem7.SmallImageIndex = 0
			' 
			' navBarItem8
			' 
			Me.navBarItem8.Caption = "Add or remove programs"
			Me.navBarItem8.Name = "navBarItem8"
			Me.navBarItem8.SmallImageIndex = 2
			' 
			' navBarItem9
			' 
			Me.navBarItem9.Caption = "Change settings"
			Me.navBarItem9.Name = "navBarItem9"
			Me.navBarItem9.SmallImageIndex = 3
			' 
			' navBarGroupControlContainer3
			' 
			Me.navBarGroupControlContainer3.Controls.Add(Me.label3)
			Me.navBarGroupControlContainer3.Controls.Add(Me.label2)
			Me.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3"
			Me.navBarGroupControlContainer3.Size = New Size(160, 76)
			Me.navBarGroupControlContainer3.TabIndex = 0
			' 
			' label3
			' 
			Me.label3.Appearance.BackColor = Color.Transparent
			Me.label3.Appearance.Font = New Font("Microsoft Sans Serif", 8.25F)
			Me.label3.Location = New Point(12, 28)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(66, 13)
			Me.label3.TabIndex = 1
			Me.label3.Text = "System Folder"
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = Color.Transparent
			Me.label2.Appearance.Font = New Font("Tahoma", 8F, FontStyle.Bold)
			Me.label2.Location = New Point(12, 8)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(75, 13)
			Me.label2.TabIndex = 0
			Me.label2.Text = "My computer"
			' 
			' navBarGroup10
			' 
			Me.navBarGroup10.Caption = "Other Places"
			Me.navBarGroup10.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup10.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem10), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem11), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem12)})
			Me.navBarGroup10.LargeImage = (CType(resources.GetObject("navBarGroup10.LargeImage"), Image))
			Me.navBarGroup10.Name = "navBarGroup10"
			' 
			' navBarItem10
			' 
			Me.navBarItem10.Caption = "My Network Places"
			Me.navBarItem10.Name = "navBarItem10"
			Me.navBarItem10.SmallImageIndex = 1
			' 
			' navBarItem11
			' 
			Me.navBarItem11.Caption = "My Documents"
			Me.navBarItem11.Name = "navBarItem11"
			Me.navBarItem11.SmallImageIndex = 4
			' 
			' navBarItem12
			' 
			Me.navBarItem12.Caption = "Control Panel"
			Me.navBarItem12.Name = "navBarItem12"
			Me.navBarItem12.SmallImageIndex = 3
			' 
			' navBarGroup11
			' 
			Me.navBarGroup11.Caption = "Disks"
			Me.navBarGroup11.Expanded = True
			Me.navBarGroup11.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.navBarGroup11.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem13), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem14), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem16)})
			Me.navBarGroup11.Name = "navBarGroup11"
			' 
			' navBarItem13
			' 
			Me.navBarItem13.Caption = "Floppy (A:)"
			Me.navBarItem13.LargeImageIndex = 0
			Me.navBarItem13.Name = "navBarItem13"
			' 
			' navBarItem14
			' 
			Me.navBarItem14.Caption = "System (C:)"
			Me.navBarItem14.LargeImageIndex = 1
			Me.navBarItem14.Name = "navBarItem14"
			' 
			' navBarItem16
			' 
			Me.navBarItem16.Caption = "CD Drive (E:)"
			Me.navBarItem16.LargeImageIndex = 2
			Me.navBarItem16.Name = "navBarItem16"
			' 
			' navBarGroup12
			' 
			Me.navBarGroup12.Caption = "Details"
			Me.navBarGroup12.ControlContainer = Me.navBarGroupControlContainer3
			Me.navBarGroup12.Expanded = True
			Me.navBarGroup12.GroupClientHeight = 77
			Me.navBarGroup12.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup12.Name = "navBarGroup12"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel1.Controls.Add(Me.pnlHint)
			Me.panel1.Controls.Add(Me.distanceChanger3)
			Me.panel1.Controls.Add(Me.distanceChanger2)
			Me.panel1.Controls.Add(Me.distanceChanger1)
			Me.panel1.Location = New Point(180, 5)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(413, 525)
			Me.panel1.TabIndex = 3
			' 
			' pnlHint
			' 
			Me.pnlHint.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.pnlHint.ForeColor = Color.Black
			Me.pnlHint.Location = New Point(10, 198)
			Me.pnlHint.MaxRows = 20
			Me.pnlHint.Name = "pnlHint"
			Me.pnlHint.Size = New Size(393, 22)
			Me.pnlHint.TabIndex = 3
			Me.pnlHint.TabStop = False
			' 
			' distanceChanger3
			' 
			Me.distanceChanger3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.distanceChanger3.Caption = "Link Interval:"
			Me.distanceChanger3.Location = New Point(6, 130)
			Me.distanceChanger3.Margin = New Padding(3, 4, 3, 4)
			Me.distanceChanger3.Name = "distanceChanger3"
			Me.distanceChanger3.Size = New Size(401, 56)
			Me.distanceChanger3.TabIndex = 2
			Me.distanceChanger3.Value = 0
			' 
			' distanceChanger2
			' 
			Me.distanceChanger2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.distanceChanger2.Caption = "Bar Group Outer Indent:"
			Me.distanceChanger2.Location = New Point(6, 70)
			Me.distanceChanger2.Margin = New Padding(3, 4, 3, 4)
			Me.distanceChanger2.Name = "distanceChanger2"
			Me.distanceChanger2.Size = New Size(401, 56)
			Me.distanceChanger2.TabIndex = 1
			Me.distanceChanger2.Value = 0
			' 
			' distanceChanger1
			' 
			Me.distanceChanger1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.distanceChanger1.Caption = "Bar Group Interval:"
			Me.distanceChanger1.Location = New Point(6, 10)
			Me.distanceChanger1.Margin = New Padding(3, 4, 3, 4)
			Me.distanceChanger1.Maximum = 60
			Me.distanceChanger1.Minimum = 10
			Me.distanceChanger1.Name = "distanceChanger1"
			Me.distanceChanger1.Size = New Size(401, 56)
			Me.distanceChanger1.TabIndex = 0
			Me.distanceChanger1.Value = 10
			' 
			' CustomizableDistances
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "CustomizableDistances"
			Me.Size = New Size(597, 538)
'			Me.Load += New System.EventHandler(Me.CustomizableDistances_Load)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarControl1.ResumeLayout(False)
			Me.navBarGroupControlContainer3.ResumeLayout(False)
			Me.navBarGroupControlContainer3.PerformLayout()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private imageList2 As ImageList
		Private navBarGroup10 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup11 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup12 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem8 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem9 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem10 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem11 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem12 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem13 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem14 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem16 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private imageList1 As ImageList
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private distanceChanger1 As DevExpress.XtraNavBar.Demos.DistanceChanger
		Private distanceChanger2 As DevExpress.XtraNavBar.Demos.DistanceChanger
		Private distanceChanger3 As DevExpress.XtraNavBar.Demos.DistanceChanger
		Private pnlHint As DevExpress.Utils.Frames.NotePanel
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
