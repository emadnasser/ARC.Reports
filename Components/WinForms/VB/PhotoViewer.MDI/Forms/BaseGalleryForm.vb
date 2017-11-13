Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports PhotoViewer.Data

Namespace PhotoViewer
	Public MustInherit Partial Class GalleryForm
		Inherits RibbonForm
		Public Shared HoverSkinImageSize As Size = New Size(116, 86)
		Public Shared SkinImageSize As Size = New Size(58, 43)
		Public Sub New(ByVal controller As PhotoViewerDataController)
			Me.controller = controller
			AddHandler controller.DataChanged, AddressOf controller_DataChanged
            InitializeComponent()
            AddHandler controlPresenter.SelectedControlChanged, AddressOf OnMainTabSelectedPageChanged
            InitFilters()
		End Sub
		Private mainFormCore As MainForm
		Public Property MainForm() As MainForm
			Get
				Return mainFormCore
			End Get
			Set(ByVal value As MainForm)
				mainFormCore = value
			End Set
		End Property
		Friend Sub UpdateCancelButtonEnabledState()
			Dim viewer As ImageCollectionViewer = TryCast(controlPresenter.SelectedControl, ImageCollectionViewer)
			biCancel.Enabled = viewer IsNot Nothing AndAlso viewer.IsImageFilterd()
		End Sub
		Friend Sub FilterGallery(ByVal allowFilter As Boolean, ByVal start As DateTime, ByVal [end] As DateTime)
			gallery.Gallery.BeginUpdate()
			Try
				Dim items As List(Of GalleryItem) = gallery.Gallery.GetAllItems()
				For Each item As GalleryItem In items
					Dim [date] As DateTime = File.GetCreationTime(CStr(item.Tag))
					item.Visible = (Not allowFilter) OrElse ([date] >= start AndAlso [date] <= [end])
				Next item
			Finally
				gallery.Gallery.EndUpdate()
			End Try
		End Sub
		Protected Overrides Sub OnClosed(ByVal e As EventArgs)
			RemoveHandler controller.DataChanged, AddressOf controller_DataChanged
			MyBase.OnClosed(e)
		End Sub
		Private Sub controller_DataChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateGalleryContent(True)
		End Sub
		Protected MustOverride Sub UpdateGalleryContent(ByVal forceProcess As Boolean)
		Protected ReadOnly controller As PhotoViewerDataController
		Private rightClickItemCore As GalleryItem
		Private markedItemsCore As List(Of GalleryItem) = New List(Of GalleryItem)()
		Protected ReadOnly Property MarkedItems() As List(Of GalleryItem)
			Get
				Return markedItemsCore
			End Get
		End Property
		Protected ReadOnly Property RightClickItem() As GalleryItem
			Get
				Return rightClickItemCore
			End Get
		End Property
		Protected Overridable Sub InitFilters()
			Dim imageSize As Size = My.Resources.FilterSample.Size
			imageSize.Width = CInt(Fix(imageSize.Width * 0.5))
			imageSize.Height = CInt(Fix(imageSize.Height * 0.5))
			filtersGallery.Gallery.ImageSize = imageSize
			filtersGallery.Gallery.Images = FilterHelper.GetFiltersSamples(My.Resources.FilterSample)
			filtersGallery.Gallery.HoverImages = filtersGallery.Gallery.Images
			For Each fInfo As FilterInfo In FilterHelper.Filters
				filtersGallery.Gallery.Groups(0).Items.Add(CreateFilterGalleryItem(fInfo))
			Next fInfo
		End Sub
		Private Function CreateFilterGalleryItem(ByVal info As FilterInfo) As GalleryItem
			Dim item As GalleryItem = New GalleryItem()
			item.ImageIndex = FilterHelper.Filters.IndexOf(info)
			item.HoverImageIndex = item.ImageIndex
			item.Caption = info.Name
			item.Tag = info
			item.Hint = info.Name
			Return item
		End Function
		Protected Function CreatePhotoGalleryItem(ByVal fileName As String) As GalleryItem
			Dim item As GalleryItem = New GalleryItem()
			item.Caption = Path.GetFileName(fileName)
			item.Hint = fileName
			item.Image = ThumbnailHelper.Default.GetThumbnail(fileName, 208, controller.ThumbPath)
			item.Tag = fileName
			Return item
		End Function
		Private Sub OnNewAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
		End Sub
		Private Sub OnMainGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs) Handles gallery.Gallery.ItemCheckedChanged
			UpdateImageButtonsEnabledState()
			MainForm.UpdateSelectedPictureEdit(CStr(e.Item.Tag))
		End Sub
		Private Sub OnMainGalleryMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gallery.MouseDown
			Dim hi As RibbonHitInfo = gallery.CalcHitInfo(e.Location)
				If e.Button = MouseButtons.Right Then
					rightClickItemCore = hi.GalleryItem
					childRibbon.Manager.SetPopupContextMenu(gallery, galleryItemMenu)
					Return
            End If
		End Sub
		Private Sub OnMarkItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biMark.ItemClick
			Dim items As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
			MarkItems(items)
			gallery.Refresh()
		End Sub
		Private Sub OnSelectionGalleryCustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
			If (Not MarkedItems.Contains(e.Item)) Then
				Return
			End If
			e.Cache.Graphics.DrawImage(e.Item.Image, (CType(e.ItemInfo, GalleryItemViewInfo)).ImageContentBounds)
			DrawMarkedIconInSelection(e.Cache, (CType(e.ItemInfo, GalleryItemViewInfo)).ImageClientBounds)
			e.Handled = True
		End Sub
		Private Sub OnMainGalleryCustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs) Handles gallery.Gallery.CustomDrawItemImage
			If (Not MarkedItems.Contains(e.Item)) Then
				Return
			End If
			e.Cache.Graphics.DrawImage(e.Item.Image, (CType(e.ItemInfo, GalleryItemViewInfo)).ImageContentBounds)
			DrawMarkedIcon(e.Cache, (CType(e.ItemInfo, GalleryItemViewInfo)).ImageContentBounds)
			e.Handled = True
		End Sub
		Private Sub OnUnmarkAllItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biUnmarkAll.ItemClick
			UnmarkItems()
			gallery.Refresh()
		End Sub
		Private Sub OnUnmarkItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biUnmark.ItemClick
			Dim items As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
			UnmarkItems(items)
			gallery.Refresh()
		End Sub
		Private Sub OnAddToAlbumButtonShowDropDownControl(ByVal sender As Object, ByVal e As ShowDropDownControlEventArgs)

		End Sub
		Private Sub OnViewSelectedImagesItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biView.ItemClick
			Dim files() As String = GetSelectedItems()
			If files.Length = 0 Then
				XtraMessageBox.Show(Me, "None of images selected.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
            Dim tabName As String
            If files.Length > 1 Then tabName = "Collection" Else tabName = Path.GetFileName(files(0))
            ViewSelectedImages(tabName, "", files)
        End Sub
		Private Sub OnAboutItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            BarManager.About()
        End Sub
		Private Function GetCheckedImages() As List(Of Image)
			Dim items As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
			Dim images As List(Of Image) = New List(Of Image)(items.Count)
			For Each item As GalleryItem In items
				images.Add(Image.FromFile(CStr(item.Tag)))
			Next item
			Return images
		End Function
		Private Sub OnPrintItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biPrint.ItemClick
			Dim images As List(Of Image) = GetCheckedImages()
			Dim ps As PrintingSystem = New PrintingSystem()

			ps.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5
			ps.PageSettings.Landscape = True
			ps.PageSettings.LeftMargin = 0
			ps.PageSettings.RightMargin = 0
			ps.PageSettings.TopMargin = 0
			ps.PageSettings.BottomMargin = 0

			Dim gr As BrickGraphics = ps.Graph
			ps.Begin()


			Dim offsetY As Single = 0
			For Each image As Image In images
				Dim imageBrick As ImageBrick = New ImageBrick()
				imageBrick.Image = image
				imageBrick.BorderWidth = 0
				imageBrick.BorderStyle = BrickBorderStyle.Inset
				imageBrick.Sides = BorderSide.All

				imageBrick.SizeMode = ImageSizeMode.Squeeze
				gr.DrawBrick(imageBrick, New RectangleF(New PointF(0, offsetY), ps.PageSettings.UsablePageSizeInPixels))
				offsetY += ps.PageSettings.UsablePageSizeInPixels.Height
			Next image
			ps.End()

			CType(New PrintTool(ps), PrintTool).ShowPreviewDialog()
		End Sub
		Private Sub OnExportItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biExportFolder.ItemClick
			XtraMessageBox.Show(Me, "Here you can show your own export dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub OnEmailItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biEmail.ItemClick
			XtraMessageBox.Show(Me, "Here you can make preparations for e-mail.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub OnUploadItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biUpload.ItemClick
			XtraMessageBox.Show(Me, "Here you can show your own upload settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub OnCollageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biCollage.ItemClick
			XtraMessageBox.Show(Me, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub OnSlideShowItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biSlideShow.ItemClick
			XtraMessageBox.Show(Me, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub OnFilmItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biFilm.ItemClick
			XtraMessageBox.Show(Me, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Friend Sub OnParentRibbonControlSelectedPageChanged()
            If MainForm.lockParentRibbonPageChanged > 0 Then
                Return
            End If
            If Not Object.Equals(MainForm.Ribbon.SelectedPage.Text, childRibbon.SelectedPage.Text) Then
                MainForm.lockParentRibbonPageChanged += 1
                HideViewCategory()
                CloseSelectedTabPage()
                MainForm.lockParentRibbonPageChanged -= 1
            End If
        End Sub
        Private Sub OnMainTabSelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
            If controlPresenter.SelectedControl IsNot libraryPanel Then
                ShowViewCategory()
            Else
                HideViewCategory()
            End If
        End Sub
        Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
            MyBase.OnParentChanged(e)
            If Not Disposing And MdiParent Is Nothing Then
                MainForm.lockParentRibbonPageChanged += 1
                HideViewCategory()
                CloseSelectedTabPage()
                MainForm.lockParentRibbonPageChanged -= 1
            End If
        End Sub
		Private Sub OnCloseImageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biClose.ItemClick
			CloseSelectedTabPage()
		End Sub
		Private Sub OnSaveImageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biSaveImage.ItemClick
			XtraMessageBox.Show(Me, "SaveImageItemClick", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub OnCancelFilterItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biCancel.ItemClick
			Dim imageCollectionViewer As ImageCollectionViewer = TryCast(controlPresenter.SelectedControl, ImageCollectionViewer)
			If imageCollectionViewer Is Nothing Then
				Return
			End If
			imageCollectionViewer.CancelFilters()
			UpdateCancelButtonEnabledState()
		End Sub
		Private Sub UpdateAlbumsMenu()
			For i As Integer = Me.albumsPopupMenu.ItemLinks.Count - 1 To 0 Step -1
				Dim link As BarItemLink = Me.albumsPopupMenu.ItemLinks(i)
				RemoveHandler link.Item.ItemClick, AddressOf OnAddToAlbumItemClick
				childRibbon.Manager.Items.Remove(link.Item)
			Next i
			albumsPopupMenu.ItemLinks.Clear()
			For Each album As AlbumData In controller.GetAlbums()
				albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(album))
			Next album
			Dim newAlbumLink As BarItemLink = albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(Nothing))
			newAlbumLink.BeginGroup = True
		End Sub
        Private Function CreateAddToAlbumItem(ByVal album As AlbumData) As BarItem
            Dim caption As String
            If album IsNot Nothing Then caption = album.Name Else caption = "New album..."
            Dim item As BarButtonItem = New BarButtonItem(childRibbon.Manager, caption)
            AddHandler item.ItemClick, AddressOf OnAddToAlbumItemClick
            item.Tag = album
            Return item
        End Function
		Private Sub OnAddToAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim paths() As String = GetSelectedItems()
			controller.AddToAlbum(paths, TryCast(e.Item.Tag, AlbumData), Me)
		End Sub
		Protected Function GetSelectedItems() As String()
			Return GetSelectedItems(gallery.Gallery.GetCheckedItems())
		End Function
		Protected Function GetSelectedItems(ByVal items As List(Of GalleryItem)) As String()
			Return Array.ConvertAll(items.ToArray(), GetPathConverter())
		End Function
		Private Function GetPathConverter() As Converter(Of GalleryItem, String)
			Return New Converter(Of GalleryItem, String)(AddressOf GetPath)
		End Function
		Private Function GetPath(ByVal item As GalleryItem) As String
			Return TryCast(item.Tag, String)
		End Function
		Private Sub OnAddToAlbumItemPress(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biAddToAlbum.ItemPress
			UpdateAlbumsMenu()
		End Sub
		Private Sub OnFiltersGalleryInitDropDown(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs) Handles filtersGallery.Gallery.InitDropDownGallery
			e.PopupGallery.AllowHoverImages = False
			e.PopupGallery.ImageSize = My.Resources.FilterSample.Size
			e.PopupGallery.ShowItemText = True
			e.PopupGallery.ItemImageLocation = Locations.Top
			e.PopupGallery.SynchWithInRibbonGallery = True
		End Sub
		Private Sub OnFilterGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs) Handles filtersGallery.GalleryItemCheckedChanged
			Dim imageCollectionViewer As ImageCollectionViewer = TryCast(controlPresenter.SelectedControl, ImageCollectionViewer)
			If imageCollectionViewer Is Nothing OrElse (Not e.Item.Checked) Then
				Return
			End If
			imageCollectionViewer.SetFilter(CType(e.Item.Tag, FilterInfo))
		End Sub
		Private Sub OnMainGalleryDoubleClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles gallery.Gallery.ItemDoubleClick
			e.Item.Checked = True
			Dim fileName As String = (CStr(e.Item.Tag))
            ViewSelectedImages(Path.GetFileName(fileName), fileName, New String() {fileName})
		End Sub
		Private Sub OnFilterByMarkedCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biFilterByMarked.CheckedChanged
			FilterByMarked(biFilterByMarked.Checked)
		End Sub
		Private Sub OnRemoveFromAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biRemoveFromAlbum.ItemClick
			Dim items As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
			If items.Count = 0 Then
				Return
			End If
			RemoveImagesCore(items)
		End Sub
		Protected MustOverride Sub RemoveImagesCore(ByVal images As List(Of GalleryItem))
		Protected Sub ScrollToFolder(ByVal path As PathData, ByVal bAnimated As Boolean)
			gallery.Gallery.ScrollTo(GetGalleryGroupByTag(path), bAnimated)
		End Sub
		Protected Friend Sub ScrollToFile(ByVal fileName As String, ByVal bAnimated As Boolean)
			gallery.Gallery.ScrollTo(GetGalleryItemByTag(fileName), bAnimated)
		End Sub
		Protected Sub ScrollToAlbum(ByVal album As AlbumData, ByVal bAnimated As Boolean)
			gallery.Gallery.ScrollTo(GetGalleryGroupByTag(album), bAnimated)
		End Sub
		Private Sub MarkItems(ByVal items As List(Of GalleryItem))
			For Each item As GalleryItem In items
				If (Not MarkedItems.Contains(item)) Then
					MarkedItems.Add(item)
				End If
			Next item
		End Sub
		Private Sub UnmarkItems(ByVal items As List(Of GalleryItem))
			For Each item As GalleryItem In items
				MarkedItems.Remove(item)
			Next item
		End Sub
		Private Sub UnmarkItems()
			MarkedItems.Clear()
		End Sub
		Protected Sub ClearGalleryAndImages()
			gallery.Gallery.Groups.Clear()
			For Each group As GalleryItemGroup In gallery.Gallery.Groups
				If group.CaptionControl IsNot Nothing Then
					group.CaptionControl.Dispose()
					group.CaptionControl = Nothing
					For Each item As GalleryItem In group.Items
						If item.Image IsNot Nothing Then
							item.Image.Dispose()
							item.Image = Nothing
						End If
						Dim pData As PathData = TryCast(item.Tag, PathData)
						pData.Image = Nothing
					Next item
				End If
			Next group
		End Sub
		Private Function GetGalleryGroupByTag(ByVal tag As Object) As GalleryItemGroup
			For Each group As GalleryItemGroup In gallery.Gallery.Groups
				If group.Tag Is tag Then
					Return group
				End If
			Next group
			Return Nothing
		End Function
		Private Function GetGalleryItemByTag(ByVal tag As Object) As GalleryItem
			For Each group As GalleryItemGroup In gallery.Gallery.Groups
				For Each item As GalleryItem In group.Items
					If item.Tag Is tag Then
						Return item
					End If
				Next item
			Next group
			Return Nothing
		End Function
		Private Sub ClearGalleryItemsCheckState(ByVal gallery As GalleryControl)
			For Each group As GalleryItemGroup In gallery.Gallery.Groups
				For Each item As GalleryItem In group.Items
					item.Checked = False
				Next item
			Next group
		End Sub
		Private Function InflateClip(ByVal cache As GraphicsCache) As RectangleF
			Dim clipBounds As RectangleF = cache.Graphics.ClipBounds
			Dim rect As RectangleF = cache.Graphics.ClipBounds
			rect.Inflate(50, 50)
			cache.Graphics.SetClip(rect)
			Return clipBounds
		End Function
		Private Sub DrawMarkedIcon(ByVal cache As GraphicsCache, ByVal bounds As Rectangle)
			Dim oldClipBounds As RectangleF = InflateClip(cache)
			cache.Graphics.DrawImage(My.Resources.ItemMarked_32x32, New Rectangle(bounds.Right - 26, bounds.Bottom - 26, 32, 32))
			cache.Graphics.SetClip(oldClipBounds)
		End Sub
		Private Sub DrawMarkedIconInSelection(ByVal cache As GraphicsCache, ByVal bounds As Rectangle)
			Dim oldClipBounds As RectangleF = InflateClip(cache)
			cache.Graphics.DrawImage(My.Resources.ItemMarked_16x16, New Rectangle(bounds.Right - 10, bounds.Bottom - 10, 16, 16))
			cache.Graphics.SetClip(oldClipBounds)
		End Sub
		Private parentPage As RibbonPage
		Private parentCategory As RibbonPageCategory
		Private Sub ShowViewCategory()
			If controlPresenter.SelectedControl.Tag IsNot Nothing Then
				Return
			End If
            Me.ribbonStatusBar1.Visible = False
			viewPageCategory.Visible = True
			collectionOriginalPage.Visible = False
			Dim ribbonPage As RibbonPage = CType((CType(collectionOriginalPage, ICloneable)).Clone(), RibbonPage)
			ribbonPage.Visible = True
			ribbonPage.Text = controlPresenter.SelectedControl.Text
			viewPageCategory.Pages.Add(ribbonPage)
			ribbonPage.Tag = controlPresenter.SelectedControl
			controlPresenter.SelectedControl.Tag = ribbonPage
			childRibbon.SelectedPage = ribbonPage
			Dim frm As MainForm = TryCast(MdiParent, MainForm)
			If frm IsNot Nothing Then
				parentCategory = frm.Ribbon.PageCategories(viewPageCategory.Text)
				If parentCategory IsNot Nothing Then
					parentCategory.Visible = True
                    Dim mergedPage As RibbonPage = parentCategory.MergedPages(collectionOriginalPage.Text)
                    If mergedPage IsNot Nothing Then
                        mergedPage.Visible = False
                    End If
					parentPage = CType((CType(collectionOriginalPage, ICloneable)).Clone(), RibbonPage)
					parentPage.Visible = True
					parentPage.Text = controlPresenter.SelectedControl.Text
					parentCategory.Pages.Add(parentPage)
					frm.Ribbon.SelectedPage = parentPage
				End If
			End If
		End Sub
        Private Sub HideViewCategory()
            MainForm.lockParentRibbonPageChanged += 1
            Me.ribbonStatusBar1.Visible = True
            If parentCategory IsNot Nothing AndAlso parentCategory.Pages.Count = 1 Then
                parentCategory.Visible = False
            End If
            If viewPageCategory.Pages.Count = 1 Then
                viewPageCategory.Visible = False
            End If
            MainForm.lockParentRibbonPageChanged -= 1
        End Sub
        Friend Sub CloseSelectedTabPage()
            Dim page As Control = controlPresenter.SelectedControl
            If page Is libraryPanel Then
                page = controlPresenter.Controls(controlPresenter.Controls.Count - 1)
            End If
            If page Is libraryPanel Then
                Return
            End If
            MainForm.lockParentRibbonPageChanged += 1
            controlPresenter.Controls.Remove(page)
            Dim ribbonPage As RibbonPage = CType(page.Tag, RibbonPage)
            ribbonPage.Category.Pages.Remove(ribbonPage)
            ribbonPage.Dispose()
            If parentCategory IsNot Nothing AndAlso parentPage IsNot Nothing Then
                parentCategory.Pages.Remove(parentPage)
                parentPage.Dispose()
            End If
            MainForm.lockParentRibbonPageChanged -= 1
            MainForm.EndViewImages()
        End Sub
        Private Sub ViewSelectedImages(ByVal tabName As String, ByVal toolTip As String, ByVal files() As String)
            MainForm.StartViewImages(Me)
            Dim imageCollectionViewer As ImageCollectionViewer = New ImageCollectionViewer(files, controller.ThumbPath)
            imageCollectionViewer.SetMenuManager(MainForm.Ribbon.Manager)
            imageCollectionViewer.Text = tabName
            imageCollectionViewer.Dock = DockStyle.Fill
            imageCollectionViewer.SetFilter(GetSelectedFilter())
            controlPresenter.Controls.Add(imageCollectionViewer)
            controlPresenter.SelectedControl = imageCollectionViewer
        End Sub
		Private Function GetSelectedFilter() As FilterInfo
			For Each group As GalleryItemGroup In filtersGallery.Gallery.Groups
				For Each item As GalleryItem In group.Items
					If item.Checked Then
						Return CType(item.Tag, FilterInfo)
					End If
				Next item
			Next group
			Return Nothing
		End Function
		Private Sub UpdateImageButtonsEnabledState()
			Dim hasFiles As Boolean = GetSelectedItems().Length > 0
			biView.Enabled = hasFiles
			biRemoveFilesFromLibrary.Enabled = hasFiles
			biAddToAlbum.Enabled = hasFiles
			biMark.Enabled = hasFiles
			biCollage.Enabled = hasFiles
			biSlideShow.Enabled = hasFiles
			biFilm.Enabled = hasFiles
			biExportFolder.Enabled = hasFiles
			biEmail.Enabled = hasFiles
			biUpload.Enabled = hasFiles
			biPrint.Enabled = hasFiles
			biUnmark.Enabled = hasFiles
			biUnmarkAll.Enabled = hasFiles
		End Sub
		Protected Sub UpdateItemsEnabledState()
			UpdateImageButtonsEnabledState()
			UpdateCancelButtonEnabledState()
		End Sub
		Private Sub FilterByMarked(ByVal filterByMarked As Boolean)
			gallery.Gallery.BeginUpdate()
			Try
				For Each group As GalleryItemGroup In gallery.Gallery.Groups
					For Each item As GalleryItem In group.Items
						item.Visible = (Not filterByMarked) OrElse MarkedItems.Contains(item)
					Next item
				Next group
			Finally
				gallery.Gallery.EndUpdate()
			End Try
		End Sub
		Private Sub OnSelectAllMarkedItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biSelectAllMarked.ItemClick
			For Each item As GalleryItem In MarkedItems
				Dim unselectOtherItems As Boolean = MarkedItems.IndexOf(item) = 0
				gallery.Gallery.SetItemCheck(item, True, unselectOtherItems)
			Next item
		End Sub
        Private Sub filtersGallery_Gallery_PopupClose(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs) Handles filtersGallery.Gallery.PopupClose
            Dim items As List(Of GalleryItem) = e.Item.Gallery.GetCheckedItems()
            If items.Count > 0 Then
                e.Item.Gallery.MakeVisible(items(0))
            End If
        End Sub
		Private Sub galleryControlGallery1_MarqueeSelectionCompleted(ByVal sender As Object, ByVal e As GallerySelectionEventArgs) Handles gallery.Gallery.MarqueeSelectionCompleted
			Dim pt As Point = Control.MousePosition
			pt.Y -= 11
			Me.ribbonMiniToolbar1.Show(pt)
		End Sub

        Private Sub repositoryItemZoomTrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles repositoryItemZoomTrackBar1.ValueChanged
            Dim control As ZoomTrackBarControl = CType(sender, ZoomTrackBarControl)
            gallery.Gallery.ImageSize = New Size(control.Value, control.Value)
        End Sub
    End Class
End Namespace
