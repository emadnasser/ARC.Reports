Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class HelpControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			Me.backstageViewLabel1 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.copyrightLabel = New DevExpress.XtraEditors.LabelControl()
			Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.serialNumberLabel = New DevExpress.XtraEditors.LabelControl()
			Me.versionLabel = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciVersion = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciSerial = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciVisit = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.backstageViewLabel2 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl1.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciVersion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciSerial, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciVisit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
			Me.splitContainer1.IsSplitterFixed = True
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.galleryControl1)
			Me.splitContainer1.Panel1.Controls.Add(Me.backstageViewLabel1)
			Me.splitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(20)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.panel1)
			Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
			Me.splitContainer1.Size = New System.Drawing.Size(825, 616)
			Me.splitContainer1.SplitterDistance = 400
			Me.splitContainer1.TabIndex = 0
			' 
			' galleryControl1
			' 
			Me.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.galleryControl1.DesignGalleryGroupIndex = 0
			Me.galleryControl1.DesignGalleryItemIndex = 0
			Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Top
			' 
			' galleryControlGallery1
			' 
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

            Me.galleryControl1.Gallery.AutoFitColumns = False
			Me.galleryControl1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
			Me.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent
			Me.galleryControl1.Gallery.ColumnCount = 1
			Me.galleryControl1.Gallery.DistanceItemImageToText = 20
			Me.galleryControl1.Gallery.DrawImageBackground = False
			Me.galleryControl1.Gallery.FixedImageSize = False
			galleryItemGroup1.Caption = "Group1"
			galleryItem1.Caption = "DevExpress Online Help"
			galleryItem1.Description = "Get help using DevExpress components."
            galleryItem1.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Online_Help
			galleryItem2.Caption = "Getting Started "
			galleryItem2.Description = "See what's new and find resources to help you learn " & Constants.vbCrLf & "the basics quickly."
            galleryItem2.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Code_Central
			galleryItem3.Caption = "Contact Us"
			galleryItem3.Description = "Let us know if you need help or how we can make " & Constants.vbCrLf & "our components better"
            galleryItem3.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Contact_Us
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3})
			Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.galleryControl1.Gallery.ShowGroupCaption = False
			Me.galleryControl1.Gallery.ShowItemText = True
			Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
			Me.galleryControl1.Location = New System.Drawing.Point(20, 52)
			Me.galleryControl1.Name = "galleryControl1"
			Me.galleryControl1.Size = New System.Drawing.Size(360, 153)
			Me.galleryControl1.TabIndex = 1
			Me.galleryControl1.Text = "galleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.galleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
			Me.galleryControlClient1.Size = New System.Drawing.Size(358, 151)
			' 
			' backstageViewLabel1
			' 
			Me.backstageViewLabel1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.backstageViewLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.backstageViewLabel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.backstageViewLabel1.LineVisible = True
			Me.backstageViewLabel1.Location = New System.Drawing.Point(20, 20)
			Me.backstageViewLabel1.Name = "backstageViewLabel1"
			Me.backstageViewLabel1.ShowLineShadow = False
			Me.backstageViewLabel1.Size = New System.Drawing.Size(360, 32)
			Me.backstageViewLabel1.TabIndex = 0
			Me.backstageViewLabel1.Text = "Support"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.layoutControl1)
			Me.panel1.Controls.Add(Me.backstageViewLabel2)
			Me.panel1.Controls.Add(Me.pictureEdit1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(4, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Padding = New System.Windows.Forms.Padding(24, 20, 20, 20)
			Me.panel1.Size = New System.Drawing.Size(417, 616)
			Me.panel1.TabIndex = 3
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.copyrightLabel)
			Me.layoutControl1.Controls.Add(Me.hyperLinkEdit1)
			Me.layoutControl1.Controls.Add(Me.serialNumberLabel)
			Me.layoutControl1.Controls.Add(Me.versionLabel)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(24, 207)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(373, 389)
			Me.layoutControl1.TabIndex = 2
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' copyrightLabel
			' 
			Me.copyrightLabel.Location = New System.Drawing.Point(12, 68)
			Me.copyrightLabel.Name = "copyrightLabel"
			Me.copyrightLabel.Size = New System.Drawing.Size(231, 26)
			Me.copyrightLabel.StyleController = Me.layoutControl1
			Me.copyrightLabel.TabIndex = 7
			Me.copyrightLabel.Text = "Copyright (c) 2000-2011 Developer Express inc." & Constants.vbCrLf & "ALL RIGHTS RESERVED."
			' 
			' hyperLinkEdit1
			' 
			Me.hyperLinkEdit1.EditValue = "www.devexpress.com"
			Me.hyperLinkEdit1.Location = New System.Drawing.Point(93, 46)
			Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
			Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.hyperLinkEdit1.Size = New System.Drawing.Size(268, 18)
			Me.hyperLinkEdit1.StyleController = Me.layoutControl1
			Me.hyperLinkEdit1.TabIndex = 6
			' 
			' serialNumberLabel
			' 
			Me.serialNumberLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.serialNumberLabel.Location = New System.Drawing.Point(93, 29)
			Me.serialNumberLabel.Name = "serialNumberLabel"
			Me.serialNumberLabel.Size = New System.Drawing.Size(268, 13)
			Me.serialNumberLabel.StyleController = Me.layoutControl1
			Me.serialNumberLabel.TabIndex = 5
			Me.serialNumberLabel.Text = "0000-0000-0000-0000"
			' 
			' versionLabel
			' 
			Me.versionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.versionLabel.Location = New System.Drawing.Point(93, 12)
			Me.versionLabel.Name = "versionLabel"
			Me.versionLabel.Size = New System.Drawing.Size(268, 13)
			Me.versionLabel.StyleController = Me.layoutControl1
			Me.versionLabel.TabIndex = 4
			Me.versionLabel.Text = "11.1.0.0"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciVersion, Me.lciSerial, Me.lciVisit, Me.layoutControlItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(373, 389)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' lciVersion
			' 
			Me.lciVersion.Control = Me.versionLabel
			Me.lciVersion.CustomizationFormText = "Version:"
			Me.lciVersion.Location = New System.Drawing.Point(0, 0)
			Me.lciVersion.Name = "lciVersion"
			Me.lciVersion.Size = New System.Drawing.Size(353, 17)
			Me.lciVersion.Text = "Version:"
			Me.lciVersion.TextSize = New System.Drawing.Size(77, 13)
			' 
			' lciSerial
			' 
			Me.lciSerial.Control = Me.serialNumberLabel
			Me.lciSerial.CustomizationFormText = "Serial number:"
			Me.lciSerial.Location = New System.Drawing.Point(0, 17)
			Me.lciSerial.Name = "lciSerial"
			Me.lciSerial.Size = New System.Drawing.Size(353, 17)
			Me.lciSerial.Text = "Serial number:"
			Me.lciSerial.TextSize = New System.Drawing.Size(77, 13)
			' 
			' lciVisit
			' 
			Me.lciVisit.Control = Me.hyperLinkEdit1
			Me.lciVisit.CustomizationFormText = "Visit as online at"
			Me.lciVisit.Location = New System.Drawing.Point(0, 34)
			Me.lciVisit.Name = "lciVisit"
			Me.lciVisit.Size = New System.Drawing.Size(353, 22)
			Me.lciVisit.Text = "Visit as online at"
			Me.lciVisit.TextSize = New System.Drawing.Size(77, 13)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.copyrightLabel
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 56)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(353, 313)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' backstageViewLabel2
			' 
			Me.backstageViewLabel2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.backstageViewLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.backstageViewLabel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.backstageViewLabel2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.backstageViewLabel2.LineVisible = True
			Me.backstageViewLabel2.Location = New System.Drawing.Point(24, 174)
			Me.backstageViewLabel2.Name = "backstageViewLabel2"
			Me.backstageViewLabel2.ShowLineShadow = False
			Me.backstageViewLabel2.Size = New System.Drawing.Size(373, 33)
			Me.backstageViewLabel2.TabIndex = 1
			Me.backstageViewLabel2.Text = "About XtraBars"
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureEdit1.EditValue = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.XtraBars
			Me.pictureEdit1.Location = New System.Drawing.Point(24, 20)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Properties.AllowFocused = False
			Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pictureEdit1.Size = New System.Drawing.Size(373, 154)
			Me.pictureEdit1.TabIndex = 0
			' 
			' labelControl4
			' 
			Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Left
			Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
			Me.labelControl4.LineVisible = True
			Me.labelControl4.Location = New System.Drawing.Point(0, 0)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(4, 616)
			Me.labelControl4.TabIndex = 4
			' 
			' HelpControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "HelpControl"
			Me.Size = New System.Drawing.Size(825, 616)
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel1.PerformLayout()
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciVersion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciSerial, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciVisit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private backstageViewLabel1 As BackstageViewLabel
		Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private backstageViewLabel2 As BackstageViewLabel
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private versionLabel As DevExpress.XtraEditors.LabelControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private lciVersion As DevExpress.XtraLayout.LayoutControlItem
		Private serialNumberLabel As DevExpress.XtraEditors.LabelControl
		Private lciSerial As DevExpress.XtraLayout.LayoutControlItem
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private lciVisit As DevExpress.XtraLayout.LayoutControlItem
		Private copyrightLabel As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private panel1 As System.Windows.Forms.Panel
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
