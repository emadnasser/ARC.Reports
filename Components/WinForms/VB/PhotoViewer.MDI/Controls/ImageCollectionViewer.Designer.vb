Imports Microsoft.VisualBasic
Imports System
Namespace PhotoViewer
	Partial Public Class ImageCollectionViewer
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
            Me.components = New System.ComponentModel.Container
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup
            Me.gallery = New DevExpress.XtraBars.Ribbon.GalleryControl
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel
            Me.controlContainer2 = New DevExpress.XtraBars.Docking.ControlContainer
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit
            CType(Me.gallery, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gallery.SuspendLayout()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gallery
            '
            Me.gallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gallery.Controls.Add(Me.galleryControlClient1)
            Me.gallery.DesignGalleryGroupIndex = 0
            Me.gallery.DesignGalleryItemIndex = 0
            Me.gallery.Dock = System.Windows.Forms.DockStyle.Fill
            '
            'GalleryControlGallery1
            '
            Me.gallery.Gallery.AutoFitColumns = False
            Me.gallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None
            Me.gallery.Gallery.ColumnCount = 1
            Me.gallery.Gallery.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.gallery.Gallery.FirstItemVertAlignment = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAlignment.Center
            GalleryItemGroup1.Caption = "Group1"
            Me.gallery.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.gallery.Gallery.ImageSize = New System.Drawing.Size(50, 50)
            Me.gallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.gallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomOutside
            Me.gallery.Gallery.LastItemVertAlignment = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAlignment.Center
            Me.gallery.Gallery.Orientation = System.Windows.Forms.Orientation.Horizontal
            Me.gallery.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth
            Me.gallery.Gallery.ShowGroupCaption = False
            Me.gallery.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.gallery.Location = New System.Drawing.Point(0, 0)
            Me.gallery.Name = "gallery"
            Me.gallery.Size = New System.Drawing.Size(897, 94)
            Me.gallery.TabIndex = 0
            Me.gallery.Text = "galleryControl1"
            '
            'galleryControlClient1
            '
            Me.galleryControlClient1.GalleryControl = Me.gallery
            Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
            Me.galleryControlClient1.Size = New System.Drawing.Size(895, 92)
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel1.ID = New System.Guid("8388944d-b625-4ad1-a842-9ec8e9162c48")
            Me.dockPanel1.Location = New System.Drawing.Point(2, 481)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 121)
            Me.dockPanel1.Size = New System.Drawing.Size(905, 121)
            Me.dockPanel1.Text = "Collection"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.gallery)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(897, 94)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.controlContainer2)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel2.ID = New System.Guid("4cef1247-ed86-4f03-b4f4-38a36c8cf705")
            Me.dockPanel2.Location = New System.Drawing.Point(2, 2)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Options.ShowCloseButton = False
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(295, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(295, 479)
            Me.dockPanel2.Text = "Filter params"
            '
            'controlContainer2
            '
            Me.controlContainer2.Location = New System.Drawing.Point(4, 23)
            Me.controlContainer2.Name = "controlContainer2"
            Me.controlContainer2.Size = New System.Drawing.Size(287, 452)
            Me.controlContainer2.TabIndex = 0
            '
            'pictureEdit
            '
            Me.pictureEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureEdit.Location = New System.Drawing.Point(297, 2)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Properties.AllowFocused = False
            Me.pictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit.Properties.Padding = New System.Windows.Forms.Padding(12)
            Me.pictureEdit.Properties.ShowScrollBars = True
            Me.pictureEdit.Size = New System.Drawing.Size(610, 479)
            Me.pictureEdit.TabIndex = 1
            '
            'ImageCollectionViewer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pictureEdit)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Name = "ImageCollectionViewer"
            Me.Padding = New System.Windows.Forms.Padding(2)
            Me.Size = New System.Drawing.Size(909, 604)
            CType(Me.gallery, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gallery.ResumeLayout(False)
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents gallery As DevExpress.XtraBars.Ribbon.GalleryControl
		Private dockManager As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private controlContainer2 As DevExpress.XtraBars.Docking.ControlContainer
		Private WithEvents pictureEdit As DevExpress.XtraEditors.PictureEdit
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient

	End Class
End Namespace
