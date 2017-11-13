Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class ExportControl
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
			Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.exportGallery = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			Me.backstageViewLabel1 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.exportGallery, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.exportGallery.SuspendLayout()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.IsSplitterFixed = True
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.exportGallery)
			Me.splitContainer1.Panel1.Controls.Add(Me.backstageViewLabel1)
			Me.splitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(20)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
			Me.splitContainer1.Size = New System.Drawing.Size(680, 507)
			Me.splitContainer1.SplitterDistance = 337
			Me.splitContainer1.TabIndex = 0
			' 
			' exportGallery
			' 
			Me.exportGallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.exportGallery.Controls.Add(Me.galleryControlClient1)
			Me.exportGallery.DesignGalleryGroupIndex = 0
			Me.exportGallery.DesignGalleryItemIndex = 0
			Me.exportGallery.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' galleryControlGallery1
			' 
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

            Me.exportGallery.Gallery.AutoFitColumns = False
			Me.exportGallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None
			Me.exportGallery.Gallery.BackColor = System.Drawing.Color.Transparent
			Me.exportGallery.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.OnlyImage
			Me.exportGallery.Gallery.ColumnCount = 1
			Me.exportGallery.Gallery.FixedImageSize = False
			galleryItemGroup1.Caption = "Group1"
			galleryItem1.Caption = "PDF File"
			galleryItem1.Description = "Adobe Portable Document Format"
            galleryItem1.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportPdfLarge
			galleryItem2.Caption = "HTML File"
			galleryItem2.Description = "Web Page"
            galleryItem2.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportHtmLarge
			galleryItem3.Caption = "MHT File"
			galleryItem3.Description = "Single File Web Page"
            galleryItem3.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportMhtLarge
			galleryItem4.Caption = "RTF File"
			galleryItem4.Description = "Rich Text Format"
            galleryItem4.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportRtfLarge
			galleryItem5.Caption = "XLS File"
			galleryItem5.Description = "Microsoft Excel 2000-2003 Workbook"
            galleryItem5.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportXlsLarge
			galleryItem6.Caption = "XLSX File"
			galleryItem6.Description = "Microsoft Excel 2007 Workbook"
            galleryItem6.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportXlsxLarge
			galleryItem7.Caption = "CSV File"
			galleryItem7.Description = "Comma-Separated Values Text"
            galleryItem7.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportCsvLarge
			galleryItem8.Caption = "Text File"
			galleryItem8.Description = "Plain Text"
            galleryItem8.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportTxtLarge
			galleryItem9.Caption = "Image File"
			galleryItem9.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            galleryItem9.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.ExportGraphicLarge
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9})
			Me.exportGallery.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.exportGallery.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.exportGallery.Gallery.ShowGroupCaption = False
			Me.exportGallery.Gallery.ShowItemText = True
			Me.exportGallery.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.exportGallery.Gallery.StretchItems = True
'			Me.exportGallery.Gallery.ItemClick += New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(Me.galleryControlGallery1_ItemClick);
			Me.exportGallery.Location = New System.Drawing.Point(20, 56)
			Me.exportGallery.Name = "exportGallery"
			Me.exportGallery.Size = New System.Drawing.Size(297, 431)
			Me.exportGallery.TabIndex = 1
			Me.exportGallery.Text = "galleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.exportGallery
			Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
			Me.galleryControlClient1.Size = New System.Drawing.Size(278, 429)
			' 
			' backstageViewLabel1
			' 
			Me.backstageViewLabel1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.backstageViewLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.backstageViewLabel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.backstageViewLabel1.LineVisible = True
			Me.backstageViewLabel1.Location = New System.Drawing.Point(20, 20)
			Me.backstageViewLabel1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.backstageViewLabel1.Name = "backstageViewLabel1"
			Me.backstageViewLabel1.ShowLineShadow = False
			Me.backstageViewLabel1.Size = New System.Drawing.Size(297, 36)
			Me.backstageViewLabel1.TabIndex = 0
			Me.backstageViewLabel1.Text = "Export"
			' 
			' labelControl4
			' 
			Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Left
			Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
			Me.labelControl4.LineVisible = True
			Me.labelControl4.Location = New System.Drawing.Point(0, 0)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(4, 507)
			Me.labelControl4.TabIndex = 4
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.Title = "Export..."
			' 
			' ExportControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "ExportControl"
			Me.Size = New System.Drawing.Size(680, 507)
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.exportGallery, System.ComponentModel.ISupportInitialize).EndInit()
			Me.exportGallery.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private backstageViewLabel1 As BackstageViewLabel
		Private WithEvents exportGallery As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
