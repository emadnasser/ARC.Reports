using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using PhotoViewer.Data;

namespace PhotoViewer {
    public abstract partial class GalleryForm : RibbonForm {
        public static Size HoverSkinImageSize = new Size(116, 86);
        public static Size SkinImageSize = new Size(58, 43);
        public GalleryForm(PhotoViewerDataController controller) {
            this.controller = controller;
            controller.DataChanged += controller_DataChanged;
            InitializeComponent();
            InitFilters();
        }
        MainForm mainFormCore;
        public MainForm MainForm {
            get { return mainFormCore; }
            set { mainFormCore = value; }
        }
        internal void UpdateCancelButtonEnabledState() {
            ImageCollectionViewer viewer = controlPresenter.SelectedControl as ImageCollectionViewer;
            biCancel.Enabled = viewer != null && viewer.IsImageFilterd();
        }
        internal void FilterGallery(bool allowFilter, DateTime start, DateTime end) {
            gallery.Gallery.BeginUpdate();
            try {
                List<GalleryItem> items = gallery.Gallery.GetAllItems();
                foreach(GalleryItem item in items) {
                    DateTime date = File.GetCreationTime((string)item.Tag);
                    item.Visible = !allowFilter || (date >= start && date <= end);
                }
            }
            finally { gallery.Gallery.EndUpdate(); }
        }
        protected override void OnClosed(EventArgs e) {
            controller.DataChanged -= controller_DataChanged;
            base.OnClosed(e);
        }
        void controller_DataChanged(object sender, EventArgs e) {
            UpdateGalleryContent(true);
        }
        protected abstract void UpdateGalleryContent(bool forceProcess);
        protected readonly PhotoViewerDataController controller;
        GalleryItem rightClickItemCore;
        List<GalleryItem> markedItemsCore = new List<GalleryItem>();
        protected List<GalleryItem> MarkedItems {
            get { return markedItemsCore; }
        }
        protected GalleryItem RightClickItem {
            get { return rightClickItemCore; }
        }
        protected virtual void InitFilters() {
            Size imageSize = global::PhotoViewer.Properties.Resources.FilterSample.Size;
            imageSize.Width = (int)(imageSize.Width * 0.5);
            imageSize.Height = (int)(imageSize.Height * 0.5);
            filtersGallery.Gallery.ImageSize = imageSize;
            filtersGallery.Gallery.HoverImages = filtersGallery.Gallery.Images = FilterHelper.GetFiltersSamples(global::PhotoViewer.Properties.Resources.FilterSample);
            foreach(FilterInfo fInfo in FilterHelper.Filters) {
                filtersGallery.Gallery.Groups[0].Items.Add(CreateFilterGalleryItem(fInfo));
            }
        }
        GalleryItem CreateFilterGalleryItem(FilterInfo info) {
            GalleryItem item = new GalleryItem();
            item.HoverImageIndex = item.ImageIndex = FilterHelper.Filters.IndexOf(info);
            item.Caption = info.Name;
            item.Tag = info;
            item.Hint = info.Name;
            return item;
        }
        protected GalleryItem CreatePhotoGalleryItem(string fileName) {
            GalleryItem item = new GalleryItem();
            item.Caption = Path.GetFileName(fileName);
            item.Hint = fileName;
            item.Image = ThumbnailHelper.Default.GetThumbnail(fileName, 208, controller.ThumbPath);
            item.Tag = fileName;
            return item;
        }
        void OnNewAlbumItemClick(object sender, ItemClickEventArgs e) { }
        void OnMainGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdateImageButtonsEnabledState();
            MainForm.UpdateSelectedPictureEdit((string)e.Item.Tag);
        }
        void OnMainGalleryMouseDown(object sender, MouseEventArgs e) {
            RibbonHitInfo hi = gallery.CalcHitInfo(e.Location);
            if(e.Button == MouseButtons.Right) {
                rightClickItemCore = hi.GalleryItem;
                childRibbon.Manager.SetPopupContextMenu(gallery, galleryItemMenu);
                return;
            }
        }
        void OnMarkItemClick(object sender, ItemClickEventArgs e) {
            List<GalleryItem> items = gallery.Gallery.GetCheckedItems();
            MarkItems(items);
            gallery.Refresh();
        }
        void OnSelectionGalleryCustomDrawItemImage(object sender, GalleryItemCustomDrawEventArgs e) {
            if(!MarkedItems.Contains(e.Item))
                return;
            e.Cache.Graphics.DrawImage(e.Item.Image, ((GalleryItemViewInfo)e.ItemInfo).ImageContentBounds);
            DrawMarkedIconInSelection(e.Cache, ((GalleryItemViewInfo)e.ItemInfo).ImageClientBounds);
            e.Handled = true;
        }
        void OnMainGalleryCustomDrawItemImage(object sender, GalleryItemCustomDrawEventArgs e) {
            if(!MarkedItems.Contains(e.Item))
                return;
            e.Cache.Graphics.DrawImage(e.Item.Image, ((GalleryItemViewInfo)e.ItemInfo).ImageContentBounds);
            DrawMarkedIcon(e.Cache, ((GalleryItemViewInfo)e.ItemInfo).ImageContentBounds);
            e.Handled = true;
        }
        void OnUnmarkAllItemClick(object sender, ItemClickEventArgs e) {
            UnmarkItems();
            gallery.Refresh();
        }
        void OnUnmarkItemClick(object sender, ItemClickEventArgs e) {
            List<GalleryItem> items = gallery.Gallery.GetCheckedItems();
            UnmarkItems(items);
            gallery.Refresh();
        }
        void OnAddToAlbumButtonShowDropDownControl(object sender, ShowDropDownControlEventArgs e) {

        }
        void OnViewSelectedImagesItemClick(object sender, ItemClickEventArgs e) {
            string[] files = GetSelectedItems();
            if(files.Length == 0) {
                XtraMessageBox.Show(this, "None of images selected.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tabName = files.Length > 1 ? "Collection" : Path.GetFileName(files[0]);
            ViewSelectedImages(tabName, "", files);
        }
        void OnAboutItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }
        List<Image> GetCheckedImages() {
            List<GalleryItem> items = gallery.Gallery.GetCheckedItems();
            List<Image> images = new List<Image>(items.Count);
            foreach(GalleryItem item in items) {
                images.Add(Image.FromFile((string)item.Tag));
            }
            return images;
        }
        void OnPrintItemClick(object sender, ItemClickEventArgs e) {
            List<Image> images = GetCheckedImages();
            PrintingSystem ps = new PrintingSystem();

            ps.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5;
            ps.PageSettings.Landscape = true;
            ps.PageSettings.LeftMargin = 0;
            ps.PageSettings.RightMargin = 0;
            ps.PageSettings.TopMargin = 0;
            ps.PageSettings.BottomMargin = 0;

            BrickGraphics gr = ps.Graph;
            ps.Begin();


            float offsetY = 0;
            foreach(Image image in images) {
                ImageBrick imageBrick = new ImageBrick();
                imageBrick.Image = image;
                imageBrick.BorderWidth = 0;
                imageBrick.BorderStyle = BrickBorderStyle.Inset;
                imageBrick.Sides = BorderSide.All;

                imageBrick.SizeMode = ImageSizeMode.Squeeze;
                gr.DrawBrick(imageBrick, new RectangleF(new PointF(0, offsetY), ps.PageSettings.UsablePageSizeInPixels));
                offsetY += ps.PageSettings.UsablePageSizeInPixels.Height;
            }
            ps.End();

            new PrintTool(ps).ShowPreviewDialog();
        }
        void OnExportItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own export dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnEmailItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can make preparations for e-mail.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnUploadItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own upload settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnCollageItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnSlideShowItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnFilmItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal void OnParentRibbonControlSelectedPageChanged() {
            if(MainForm.lockParentRibbonPageChanged > 0) return;
            if(MainForm.Ribbon.SelectedPage.Text != childRibbon.SelectedPage.Text) {
                MainForm.lockParentRibbonPageChanged++;
                HideViewCategory();
                CloseSelectedTabPage();
                MainForm.lockParentRibbonPageChanged--;
            }
        }
        void OnMainTabSelectedPageChanged(object sender, EventArgs e) {
            if(controlPresenter.SelectedControl != libraryPanel)
                ShowViewCategory();
            else
                HideViewCategory();
        }
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if(MdiParent == null) {
                MainForm.lockParentRibbonPageChanged++;
                HideViewCategory();
                CloseSelectedTabPage();
                MainForm.lockParentRibbonPageChanged--;
            }
        }
        void OnCloseImageItemClick(object sender, ItemClickEventArgs e) {
            CloseSelectedTabPage();
        }
        void OnSaveImageItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "SaveImageItemClick", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnCancelFilterItemClick(object sender, ItemClickEventArgs e) {
            ImageCollectionViewer imageCollectionViewer = controlPresenter.SelectedControl as ImageCollectionViewer;
            if(imageCollectionViewer == null)
                return;
            imageCollectionViewer.CancelFilters();
            UpdateCancelButtonEnabledState();
        }
        void UpdateAlbumsMenu() {
            for(int i = this.albumsPopupMenu.ItemLinks.Count - 1; i >= 0; i--) {
                BarItemLink link = this.albumsPopupMenu.ItemLinks[i];
                link.Item.ItemClick -= new ItemClickEventHandler(OnAddToAlbumItemClick);
                childRibbon.Manager.Items.Remove(link.Item);
            }
            albumsPopupMenu.ItemLinks.Clear();
            foreach(AlbumData album in controller.GetAlbums()) 
                albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(album));
            BarItemLink newAlbumLink = albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(null));
            newAlbumLink.BeginGroup = true;
        }
        BarItem CreateAddToAlbumItem(AlbumData album) {
            BarButtonItem item = new BarButtonItem(childRibbon.Manager, album != null ? album.Name : "New album...");
            item.ItemClick += new ItemClickEventHandler(OnAddToAlbumItemClick);
            item.Tag = album;
            return item;
        }
        void OnAddToAlbumItemClick(object sender, ItemClickEventArgs e) {
            string[] paths = GetSelectedItems();
            controller.AddToAlbum(paths, e.Item.Tag as AlbumData, this);
        }
        protected string[] GetSelectedItems() {
            return GetSelectedItems(gallery.Gallery.GetCheckedItems());
        }
        protected string[] GetSelectedItems(List<GalleryItem> items) {
            return Array.ConvertAll(items.ToArray(), GetPathConverter());
        }
        Converter<GalleryItem, string> GetPathConverter() {
            return new Converter<GalleryItem, string>(GetPath);
        }
        string GetPath(GalleryItem item) {
            return item.Tag as string;
        }
        void OnAddToAlbumItemPress(object sender, ItemClickEventArgs e) {
            UpdateAlbumsMenu();
        }
        void OnFiltersGalleryInitDropDown(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.AllowHoverImages = false;
            e.PopupGallery.ImageSize = global::PhotoViewer.Properties.Resources.FilterSample.Size;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ItemImageLocation = Locations.Top;
            e.PopupGallery.SynchWithInRibbonGallery = true;
        }
        void OnFilterGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            ImageCollectionViewer imageCollectionViewer = controlPresenter.SelectedControl as ImageCollectionViewer;
            if(imageCollectionViewer == null || !e.Item.Checked)
                return;
            imageCollectionViewer.SetFilter((FilterInfo)e.Item.Tag);
        }
        void OnMainGalleryDoubleClick(object sender, GalleryItemClickEventArgs e) {
            e.Item.Checked = true;
            string fileName = ((string)e.Item.Tag);
            ViewSelectedImages(Path.GetFileName(fileName), fileName, new string[] { fileName });
        }
        void OnFilterByMarkedCheckedChanged(object sender, ItemClickEventArgs e) {
            FilterByMarked(biFilterByMarked.Checked);
        }
        void OnRemoveFromAlbumItemClick(object sender, ItemClickEventArgs e) {
            List<GalleryItem> items = gallery.Gallery.GetCheckedItems();
            if(items.Count == 0)
                return;
            RemoveImagesCore(items);
        }
        protected abstract void RemoveImagesCore(List<GalleryItem> images);
        protected void ScrollToFolder(PathData path, bool bAnimated) {
            gallery.Gallery.ScrollTo(GetGalleryGroupByTag(path), bAnimated);
        }
        protected internal void ScrollToFile(string fileName, bool bAnimated) {
            gallery.Gallery.ScrollTo(GetGalleryItemByTag(fileName), bAnimated);
        }
        protected void ScrollToAlbum(AlbumData album, bool bAnimated) {
            gallery.Gallery.ScrollTo(GetGalleryGroupByTag(album), bAnimated);
        }
        void MarkItems(List<GalleryItem> items) {
            foreach(GalleryItem item in items) {
                if(!MarkedItems.Contains(item)) {
                    MarkedItems.Add(item);
                }
            }
        }
        void UnmarkItems(List<GalleryItem> items) {
            foreach(GalleryItem item in items) {
                MarkedItems.Remove(item);
            }
        }
        void UnmarkItems() {
            MarkedItems.Clear();
        }
        protected void ClearGalleryAndImages() {
            gallery.Gallery.Groups.Clear();
            foreach(GalleryItemGroup group in gallery.Gallery.Groups) {
                if(group.CaptionControl != null) {
                    group.CaptionControl.Dispose();
                    group.CaptionControl = null;
                    foreach(GalleryItem item in group.Items) {
                        if(item.Image != null) {
                            item.Image.Dispose();
                            item.Image = null;
                        }
                        PathData pData = item.Tag as PathData;
                        pData.Image = null;
                    }
                }
            }
        }
        GalleryItemGroup GetGalleryGroupByTag(object tag) {
            foreach(GalleryItemGroup group in gallery.Gallery.Groups) {
                if(group.Tag == tag)
                    return group;
            }
            return null;
        }
        GalleryItem GetGalleryItemByTag(object tag) {
            foreach(GalleryItemGroup group in gallery.Gallery.Groups) {
                foreach(GalleryItem item in group.Items) {
                    if(item.Tag == tag)
                        return item;
                }
            }
            return null;
        }
        void ClearGalleryItemsCheckState(GalleryControl gallery) {
            foreach(GalleryItemGroup group in gallery.Gallery.Groups) {
                foreach(GalleryItem item in group.Items) {
                    item.Checked = false;
                }
            }
        }
        RectangleF InflateClip(GraphicsCache cache) {
            RectangleF clipBounds = cache.Graphics.ClipBounds;
            RectangleF rect = cache.Graphics.ClipBounds;
            rect.Inflate(50, 50);
            cache.Graphics.SetClip(rect);
            return clipBounds;
        }
        void DrawMarkedIcon(GraphicsCache cache, Rectangle bounds) {
            RectangleF oldClipBounds = InflateClip(cache);
            cache.Graphics.DrawImage(global::PhotoViewer.Properties.Resources.ItemMarked_32x32, new Rectangle(bounds.Right - 26, bounds.Bottom - 26, 32, 32));
            cache.Graphics.SetClip(oldClipBounds);
        }
        void DrawMarkedIconInSelection(GraphicsCache cache, Rectangle bounds) {
            RectangleF oldClipBounds = InflateClip(cache);
            cache.Graphics.DrawImage(global::PhotoViewer.Properties.Resources.ItemMarked_16x16, new Rectangle(bounds.Right - 10, bounds.Bottom - 10, 16, 16));
            cache.Graphics.SetClip(oldClipBounds);
        }
        RibbonPage parentPage;
        RibbonPageCategory parentCategory;
        void ShowViewCategory() {
            if(controlPresenter.SelectedControl.Tag != null)
                return;
            ribbonStatusBar1.Visible = false;
            viewPageCategory.Visible = true;
            collectionOriginalPage.Visible = false;
            RibbonPage ribbonPage = (RibbonPage)((ICloneable)collectionOriginalPage).Clone();
            ribbonPage.Visible = true;
            ribbonPage.Text = controlPresenter.SelectedControl.Text;
            viewPageCategory.Pages.Add(ribbonPage);
            ribbonPage.Tag = controlPresenter.SelectedControl;
            controlPresenter.SelectedControl.Tag = ribbonPage;
            childRibbon.SelectedPage = ribbonPage;
            MainForm frm = MdiParent as MainForm;
            if(frm != null) {
                parentCategory = frm.Ribbon.PageCategories[viewPageCategory.Text];
                if(parentCategory != null) {
                    parentCategory.Visible = true;
                    RibbonPage mergedPage = parentCategory.MergedPages[collectionOriginalPage.Text];
                    if(mergedPage != null) 
                        mergedPage.Visible = false;
                    parentPage = (RibbonPage)((ICloneable)collectionOriginalPage).Clone();
                    parentPage.Visible = true;
                    parentPage.Text = controlPresenter.SelectedControl.Text;
                    parentCategory.Pages.Add(parentPage);
                    frm.Ribbon.SelectedPage = parentPage;
                }
            }
        }
        void HideViewCategory() {
            MainForm.lockParentRibbonPageChanged++;
            ribbonStatusBar1.Visible = true;
            if(parentCategory != null && parentCategory.Pages.Count == 1)
                parentCategory.Visible = false;
            if(viewPageCategory.Pages.Count == 1)
                viewPageCategory.Visible = false;
            MainForm.lockParentRibbonPageChanged--;
        }
        internal void CloseSelectedTabPage() {
            Control page = controlPresenter.SelectedControl;
            if(page == libraryPanel)
                page = controlPresenter.Controls[controlPresenter.Controls.Count - 1];
            if(page == libraryPanel)
                return;
            MainForm.lockParentRibbonPageChanged++;
            controlPresenter.Controls.Remove(page);
            RibbonPage ribbonPage = (RibbonPage)page.Tag;
            ribbonPage.Category.Pages.Remove(ribbonPage);
            ribbonPage.Dispose();
            if(parentCategory != null && parentPage != null) {
                parentCategory.Pages.Remove(parentPage);
                parentPage.Dispose();
            }
            MainForm.lockParentRibbonPageChanged--;
            MainForm.EndViewImages();
        }
        void ViewSelectedImages(string tabName, string toolTip, string[] files) {
            MainForm.StartViewImages(this);
            ImageCollectionViewer imageCollectionViewer = new ImageCollectionViewer(files, controller.ThumbPath);
            imageCollectionViewer.SetMenuManager(MainForm.Ribbon.Manager);
            imageCollectionViewer.Text = tabName;
            imageCollectionViewer.Dock = DockStyle.Fill;
            imageCollectionViewer.SetFilter(GetSelectedFilter());
            controlPresenter.Controls.Add(imageCollectionViewer);
            controlPresenter.SelectedControl = imageCollectionViewer;
        }
        FilterInfo GetSelectedFilter() {
            foreach(GalleryItemGroup group in filtersGallery.Gallery.Groups) {
                foreach(GalleryItem item in group.Items) {
                    if(item.Checked)
                        return (FilterInfo)item.Tag;
                }
            }
            return null;
        }
        void UpdateImageButtonsEnabledState() {
            bool hasFiles = GetSelectedItems().Length > 0;
            biView.Enabled = hasFiles;
            biRemoveFilesFromLibrary.Enabled = hasFiles;
            biAddToAlbum.Enabled = hasFiles;
            biMark.Enabled = hasFiles;
            biCollage.Enabled = hasFiles;
            biSlideShow.Enabled = hasFiles;
            biFilm.Enabled = hasFiles;
            biExportFolder.Enabled = hasFiles;
            biEmail.Enabled = hasFiles;
            biUpload.Enabled = hasFiles;
            biPrint.Enabled = hasFiles;
            biUnmark.Enabled = hasFiles;
            biUnmarkAll.Enabled = hasFiles;
        }
        protected void UpdateItemsEnabledState() {
            UpdateImageButtonsEnabledState();
            UpdateCancelButtonEnabledState();
        }
        void FilterByMarked(bool filterByMarked) {
            gallery.Gallery.BeginUpdate();
            try {
                foreach(GalleryItemGroup group in gallery.Gallery.Groups) {
                    foreach(GalleryItem item in group.Items) {
                        item.Visible = !filterByMarked || MarkedItems.Contains(item);
                    }
                }
            }
            finally {
                gallery.Gallery.EndUpdate();
            }
        }
        void OnSelectAllMarkedItemClick(object sender, ItemClickEventArgs e) {
            foreach(GalleryItem item in MarkedItems) {
                bool unselectOtherItems = MarkedItems.IndexOf(item) == 0;
                gallery.Gallery.SetItemCheck(item, true, unselectOtherItems);
            }
        }
        void filtersGallery_Gallery_PopupClose(object sender, InplaceGalleryEventArgs e) {
            List<GalleryItem> items = e.Item.Gallery.GetCheckedItems();
            if(items.Count > 0)
                e.Item.Gallery.MakeVisible(items[0]);
        }
        void galleryControlGallery1_MarqueeSelectionCompleted(object sender, GallerySelectionEventArgs e) {
            Point pt = Control.MousePosition;
            pt.Y -= 11;
            this.ribbonMiniToolbar1.Show(pt);
        }

        private void repositoryItemZoomTrackBar1_ValueChanged(object sender, EventArgs e) {
            ZoomTrackBarControl control = (ZoomTrackBarControl)sender;
            gallery.Gallery.ImageSize = new Size(control.Value, control.Value);
        }
    }
}
