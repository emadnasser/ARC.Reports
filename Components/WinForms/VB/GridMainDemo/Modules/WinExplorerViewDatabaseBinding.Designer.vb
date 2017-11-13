Namespace DevExpress.XtraGrid.Demos
    Partial Public Class WinExplorerViewDatabaseBinding
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
            Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem10 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem11 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem12 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem13 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem14 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges3 As New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges4 As New DevExpress.Skins.SkinPaddingEdges()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(WinExplorerViewDatabaseBinding))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.rgbiViewStyles = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.bsSortBy = New DevExpress.XtraBars.BarSubItem()
            Me.bcAscending = New DevExpress.XtraBars.BarCheckItem()
            Me.bcDescending = New DevExpress.XtraBars.BarCheckItem()
            Me.bcSortNone = New DevExpress.XtraBars.BarCheckItem()
            Me.bsGroupBy = New DevExpress.XtraBars.BarSubItem()
            Me.bcTrademark = New DevExpress.XtraBars.BarCheckItem()
            Me.bcCategory = New DevExpress.XtraBars.BarCheckItem()
            Me.bcTransmissionType = New DevExpress.XtraBars.BarCheckItem()
            Me.bcBodyStyle = New DevExpress.XtraBars.BarCheckItem()
            Me.bcGroupNone = New DevExpress.XtraBars.BarCheckItem()
            Me.bcItemCheckBoxes = New DevExpress.XtraBars.BarCheckItem()
            Me.bcGroupCaptionButton = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem5 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem6 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem7 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem8 = New DevExpress.XtraBars.BarCheckItem()
            Me.bcGroupCheckBoxes = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.bsAnimationType = New DevExpress.XtraBars.BarSubItem()
            Me.bcAnimationNone = New DevExpress.XtraBars.BarCheckItem()
            Me.bcExpandAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.bcPushAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.bcSegmentedAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.bcSlideAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.bcGroupCheckBoxes = New DevExpress.XtraBars.BarCheckItem()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.winExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 142)
            Me.gridControl1.MainView = Me.winExplorerView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(784, 290)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView1})
            ' 
            ' winExplorerView1
            ' 
            Me.winExplorerView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colName})
            Me.winExplorerView1.GridControl = Me.gridControl1
            Me.winExplorerView1.Name = "winExplorerView1"
            Me.winExplorerView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide
            Me.winExplorerView1.OptionsImageLoad.AsyncLoad = True
            Me.winExplorerView1.OptionsImageLoad.CacheThumbnails = False
            Me.winExplorerView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = False
            Me.winExplorerView1.OptionsSelection.AllowMarqueeSelection = True
            Me.winExplorerView1.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click
            Me.winExplorerView1.OptionsSelection.MultiSelect = True
            Me.winExplorerView1.OptionsView.ShowExpandCollapseButtons = True
            Me.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.rgbiViewStyles, Me.bsSortBy, Me.bcAscending, Me.bcDescending, Me.bcSortNone, Me.bsGroupBy, Me.bcItemCheckBoxes, Me.bcGroupCaptionButton, Me.bcTrademark, Me.bcCategory, Me.bcTransmissionType, Me.bcGroupNone, Me.barCheckItem5, Me.barCheckItem6, Me.barCheckItem7, Me.barCheckItem8, Me.bcBodyStyle, Me.bcGroupCheckBoxes, Me.barCheckItem1, Me.bsAnimationType, Me.bcAnimationNone, Me.bcExpandAnimation, Me.bcPushAnimation, Me.bcSlideAnimation, Me.bcSegmentedAnimation})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 24
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(784, 142)
            ' 
            ' rgbiViewStyles
            ' 
            Me.rgbiViewStyles.Caption = "ribbonGalleryBarItem1"
            ' 
            ' 
            ' 
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyles.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyles.Gallery.ColumnCount = 3
            Me.rgbiViewStyles.Gallery.DrawImageBackground = False
            galleryItemGroup2.Caption = "Group1"
            galleryItem8.Caption = "Extra large icons"
            galleryItem8.Image = My.Resources.ExtraLarge
            galleryItem9.Caption = "Large icons"
            galleryItem9.Checked = True
            galleryItem9.Image = My.Resources.Large
            galleryItem10.Caption = "Medium icons"
            galleryItem10.Image = My.Resources.Medium
            galleryItem11.Caption = "Small icons"
            galleryItem11.Image = My.Resources.Small
            galleryItem12.Caption = "List"
            galleryItem12.Image = My.Resources.List
            galleryItem13.Caption = "Tiles"
            galleryItem13.Image = My.Resources.Tiles
            galleryItem14.Caption = "Content"
            galleryItem14.Image = My.Resources.Content
            galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem8, galleryItem9, galleryItem10, galleryItem11, galleryItem12, galleryItem13, galleryItem14})
            Me.rgbiViewStyles.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup2})
            Me.rgbiViewStyles.Gallery.ImageSize = New System.Drawing.Size(18, 18)
            Me.rgbiViewStyles.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.rgbiViewStyles.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges3.Bottom = -3
            skinPaddingEdges3.Top = -3
            Me.rgbiViewStyles.Gallery.ItemImagePadding = skinPaddingEdges3
            skinPaddingEdges4.Bottom = -1
            skinPaddingEdges4.Top = -1
            Me.rgbiViewStyles.Gallery.ItemTextPadding = skinPaddingEdges4
            Me.rgbiViewStyles.Gallery.ShowItemText = True
            Me.rgbiViewStyles.Id = 1
            Me.rgbiViewStyles.Name = "rgbiViewStyles"
            ' 
            ' bsSortBy
            ' 
            Me.bsSortBy.Caption = "Sort by"
            Me.bsSortBy.Glyph = (CType(resources.GetObject("bsSortBy.Glyph"), System.Drawing.Image))
            Me.bsSortBy.Id = 2
            Me.bsSortBy.LargeGlyph = (CType(resources.GetObject("bsSortBy.LargeGlyph"), System.Drawing.Image))
            Me.bsSortBy.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcAscending),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcDescending),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcSortNone)
            })
            Me.bsSortBy.Name = "bsSortBy"
            ' 
            ' bcAscending
            ' 
            Me.bcAscending.Caption = "Ascending"
            Me.bcAscending.GroupIndex = 2
            Me.bcAscending.Id = 3
            Me.bcAscending.Name = "bcAscending"
            ' 
            ' bcDescending
            ' 
            Me.bcDescending.Caption = "Descending"
            Me.bcDescending.GroupIndex = 2
            Me.bcDescending.Id = 4
            Me.bcDescending.Name = "bcDescending"
            ' 
            ' bcSortNone
            ' 
            Me.bcSortNone.Caption = "None"
            Me.bcSortNone.GroupIndex = 2
            Me.bcSortNone.Id = 5
            Me.bcSortNone.Name = "bcSortNone"
            ' 
            ' bsGroupBy
            ' 
            Me.bsGroupBy.Caption = "Group by"
            Me.bsGroupBy.Glyph = (CType(resources.GetObject("bsGroupBy.Glyph"), System.Drawing.Image))
            Me.bsGroupBy.Id = 6
            Me.bsGroupBy.LargeGlyph = (CType(resources.GetObject("bsGroupBy.LargeGlyph"), System.Drawing.Image))
            Me.bsGroupBy.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcTrademark),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcCategory),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcTransmissionType),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcBodyStyle),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcGroupNone)
            })
            Me.bsGroupBy.Name = "bsGroupBy"
            ' 
            ' bcTrademark
            ' 
            Me.bcTrademark.Caption = "Trademark"
            Me.bcTrademark.GroupIndex = 1
            Me.bcTrademark.Id = 9
            Me.bcTrademark.Name = "bcTrademark"
            ' 
            ' bcCategory
            ' 
            Me.bcCategory.Caption = "Category"
            Me.bcCategory.Checked = True
            Me.bcCategory.GroupIndex = 1
            Me.bcCategory.Id = 10
            Me.bcCategory.Name = "bcCategory"
            ' 
            ' bcTransmissionType
            ' 
            Me.bcTransmissionType.Caption = "Transmission type"
            Me.bcTransmissionType.GroupIndex = 1
            Me.bcTransmissionType.Id = 11
            Me.bcTransmissionType.Name = "bcTransmissionType"
            ' 
            ' bcBodyStyle
            ' 
            Me.bcBodyStyle.Caption = "Body style"
            Me.bcBodyStyle.GroupIndex = 1
            Me.bcBodyStyle.Id = 18
            Me.bcBodyStyle.Name = "bcBodyStyle"
            ' 
            ' bcGroupNone
            ' 
            Me.bcGroupNone.Caption = "None"
            Me.bcGroupNone.GroupIndex = 1
            Me.bcGroupNone.Id = 12
            Me.bcGroupNone.Name = "bcGroupNone"
            ' 
            ' bcItemCheckBoxes
            ' 
            Me.bcItemCheckBoxes.Caption = "Item check boxes"
            Me.bcItemCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.bcItemCheckBoxes.Id = 7
            Me.bcItemCheckBoxes.Name = "bcItemCheckBoxes"
            ' 
            ' bcGroupCaptionButton
            ' 
            Me.bcGroupCaptionButton.Caption = "Group caption buttons"
            Me.bcGroupCaptionButton.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.bcGroupCaptionButton.Checked = True
            Me.bcGroupCaptionButton.Id = 8
            Me.bcGroupCaptionButton.Name = "bcGroupCaptionButton"
            ' 
            ' barCheckItem5
            ' 
            Me.barCheckItem5.Caption = "barCheckItem5"
            Me.barCheckItem5.Id = 13
            Me.barCheckItem5.Name = "barCheckItem5"
            ' 
            ' barCheckItem6
            ' 
            Me.barCheckItem6.Caption = "barCheckItem6"
            Me.barCheckItem6.Id = 14
            Me.barCheckItem6.Name = "barCheckItem6"
            ' 
            ' barCheckItem7
            ' 
            Me.barCheckItem7.Caption = "barCheckItem7"
            Me.barCheckItem7.Id = 15
            Me.barCheckItem7.Name = "barCheckItem7"
            ' 
            ' barCheckItem8
            ' 
            Me.barCheckItem8.Caption = "barCheckItem8"
            Me.barCheckItem8.Id = 16
            Me.barCheckItem8.Name = "barCheckItem8"
            ' 
            ' bcGroupCheckBoxes
            ' 
            Me.bcGroupCheckBoxes.Caption = "Group check boxes"
            Me.bcGroupCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.bcGroupCheckBoxes.Id = 19
            Me.bcGroupCheckBoxes.Name = "bcGroupCheckBoxes"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "Random show"
            Me.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.Id = 21
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' bsAnimationType
            ' 
            Me.bsAnimationType.Caption = "Animation type"
            Me.bsAnimationType.Id = 23
            Me.bsAnimationType.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcAnimationNone),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcExpandAnimation),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcPushAnimation),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcSegmentedAnimation),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bcSlideAnimation)
            })
            Me.bsAnimationType.Name = "bsAnimationType"
            ' 
            ' bcAnimationNone
            ' 
            Me.bcAnimationNone.Caption = "None"
            Me.bcAnimationNone.GroupIndex = 4
            Me.bcAnimationNone.Id = 24
            Me.bcAnimationNone.Name = "bcAnimationNone"
            ' 
            ' bcExpandAnimation
            ' 
            Me.bcExpandAnimation.Caption = "Expand"
            Me.bcExpandAnimation.GroupIndex = 4
            Me.bcExpandAnimation.Id = 25
            Me.bcExpandAnimation.Name = "bcExpandAnimation"
            ' 
            ' bcPushAnimation
            ' 
            Me.bcPushAnimation.Caption = "Push"
            Me.bcPushAnimation.GroupIndex = 4
            Me.bcPushAnimation.Id = 26
            Me.bcPushAnimation.Name = "bcPushAnimation"
            ' 
            ' bcSegmentedAnimation
            ' 
            Me.bcSegmentedAnimation.Caption = "Segmented fade"
            Me.bcSegmentedAnimation.GroupIndex = 4
            Me.bcSegmentedAnimation.Id = 28
            Me.bcSegmentedAnimation.Name = "bcSegmentedAnimation"
            ' 
            ' bcSlideAnimation
            ' 
            Me.bcSlideAnimation.Caption = "Slide"
            Me.bcSlideAnimation.Checked = True
            Me.bcSlideAnimation.GroupIndex = 4
            Me.bcSlideAnimation.Id = 27
            Me.bcSlideAnimation.Name = "bcSlideAnimation"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup4})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "WinExplorer View"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.rgbiViewStyles)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Layout"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.bsSortBy)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.bsGroupBy)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Current view"
            ' 
            ' ribbonPageGroup3
            ' 
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bcItemCheckBoxes)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bcGroupCaptionButton)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bcGroupCheckBoxes)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Show hide"
            ' 
            ' bcGroupCheckBoxes
            ' 
            Me.bcGroupCheckBoxes.Caption = "Group check boxes"
            Me.bcGroupCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.bcGroupCheckBoxes.Id = 19
            Me.bcGroupCheckBoxes.Name = "bcGroupCheckBoxes"
            ' 
            ' ribbonPageGroup4
            ' 
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.bsAnimationType)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.barCheckItem1)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Options image load"
            ' 
            ' WinExplorerViewDatabaseBinding
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "WinExplorerViewDatabaseBinding"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.winExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl1 As GridControl
        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents rgbiViewStyles As XtraBars.RibbonGalleryBarItem
        Private bsSortBy As XtraBars.BarSubItem
        Private WithEvents bcAscending As XtraBars.BarCheckItem
        Private WithEvents bcDescending As XtraBars.BarCheckItem
        Private WithEvents bcSortNone As XtraBars.BarCheckItem
        Private bsGroupBy As XtraBars.BarSubItem
        Private WithEvents bcItemCheckBoxes As XtraBars.BarCheckItem
        Private WithEvents bcGroupCaptionButton As XtraBars.BarCheckItem
        Private winExplorerView1 As Views.WinExplorer.WinExplorerView
        Private WithEvents bcTrademark As XtraBars.BarCheckItem
        Private WithEvents bcCategory As XtraBars.BarCheckItem
        Private WithEvents bcTransmissionType As XtraBars.BarCheckItem
        Private WithEvents bcGroupNone As XtraBars.BarCheckItem
        Private barCheckItem5 As XtraBars.BarCheckItem
        Private barCheckItem6 As XtraBars.BarCheckItem
        Private barCheckItem7 As XtraBars.BarCheckItem
        Private barCheckItem8 As XtraBars.BarCheckItem
        Private bsAnimationType As XtraBars.BarSubItem
        Private WithEvents bcAnimationNone As XtraBars.BarCheckItem
        Private WithEvents bcSlideAnimation As XtraBars.BarCheckItem
        Private WithEvents bcExpandAnimation As XtraBars.BarCheckItem
        Private WithEvents bcPushAnimation As XtraBars.BarCheckItem
        Private WithEvents bcSegmentedAnimation As XtraBars.BarCheckItem
        Private colID As Columns.GridColumn
        Private colName As Columns.GridColumn
        Private WithEvents bcBodyStyle As XtraBars.BarCheckItem
        Private WithEvents bcGroupCheckBoxes As XtraBars.BarCheckItem
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents barCheckItem1 As XtraBars.BarCheckItem
    End Class
End Namespace
