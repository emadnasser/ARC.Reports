using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.XtraSplashScreen;
using PhotoViewer.Data;
using DevExpress.XtraEditors.ColorWheel;

namespace PhotoViewer {
    public partial class MainForm : RibbonForm {
        internal int lockParentRibbonPageChanged = 0;
        public static Size HoverSkinImageSize = new Size(116, 86);
        public static Size SkinImageSize = new Size(58, 43);
        public MainForm() {
            InitializeComponent();
            mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
            InitSkins();
            SelectDefaultPage();
            LoadData();
            UpdateItemsEnabledState();
            UpdateAddToLibraryItem(biAddFolder);
            tabbedView.DocumentAdded += tabbedView_DocumentAdded;
            tabbedView.DocumentRemoved += tabbedView_DocumentRemoved;
            tabbedView.FloatDocuments.CollectionChanged += tabbedView_FloatDocumentsCollectionChanged;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            foreach(AlbumData album in ViewData.Albums)
                OpenAlbum(album);
            SplashScreenManager.CloseForm();
        }
        protected internal void UpdateSelectedPictureEdit(string fileName) {
            selectedPictureEdit.LoadAsync(fileName);
        }
        PhotoViewerData viewData;
        PhotoViewerDataController viewDataController;
        NavBarGroup lastSelectedGroup;
        protected PhotoViewerData ViewData {
            [System.Diagnostics.DebuggerStepThrough]
            get {
                if(viewData == null)
                    viewData = new PhotoViewerData();
                return viewData;
            }
        }
        protected PhotoViewerDataController DataController {
            [System.Diagnostics.DebuggerStepThrough]
            get {
                if(viewDataController == null)
                    viewDataController = new PhotoViewerDataController(ViewData);
                return viewDataController;
            }
        }
        protected AlbumData SelectedAlbum {
            get {
                AlbumData album = CustomizableLink == null ? null : CustomizableLink.Item.Tag as AlbumData;
                if(album == null)
                    album = albumGroup.SelectedLink == null ? null : (AlbumData)albumGroup.SelectedLink.Item.Tag;
                return album;
            }
        }
        void SaveData() {
            DataController.SaveData();
        }
        void LoadData() {
            DataController.LoadData();
            InitNavBar();
        }
        protected void UpdateData() { 
            UpdateData(false); 
        }
        protected internal void UpdateData(bool onlyAlbums) {
            SaveData();
            InitNavBar(onlyAlbums);
        }
        void InitSkins() {
            SkinHelper.InitSkinGallery(skinGalleryBarItem, true);
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
        }
        void InitNavBar() { 
            InitNavBar(false); 
        }
        void InitNavBar(bool onlyAlbums) {
            navBar.SelectedLink = null;
            foreach(NavBarGroup group in navBar.Groups) {
                if(onlyAlbums && group != albumGroup)
                    continue;
                for(int i = group.ItemLinks.Count - 1; i >= 0; i--) {
                    navBar.Items.Remove(group.ItemLinks[i].Item);
                }
            }
            navBar.BeginUpdate();
            try {
                foreach(AlbumData album in ViewData.Albums) {
                    NavBarItem item = CreateAlbumItem(album);
                    navBar.Items.Add(item);
                    albumGroup.ItemLinks.Add(item);
                }
                if(onlyAlbums)
                    return;
                foreach(PathData folder in ViewData.Folders) {
                    NavBarItem item = CreateFolderItem(folder);
                    if(item != null) {
                        navBar.Items.Add(item);
                        foldersGroup.ItemLinks.Add(item);
                    }
                }
                foreach(PathData file in ViewData.Others.Files) {
                    NavBarItem item = CreateFolderItem(file);
                    if(item != null) {
                        navBar.Items.Add(item);
                        othersGroup.ItemLinks.Add(item);
                    }
                }
            }
            finally { navBar.EndUpdate(); }
            if(navBar.Items.Count > 0)
                navBar.SelectedLink = navBar.Items[0].Links[0];
        }
        void SelectDefaultPage() {
            mainRibbon.SelectedPage = imagePage;
        }
        NavBarItem CreateFolderItem(PathData folder) {
            NavBarItem item = new NavBarItem();
            item.Caption = folder.Name;
            item.Hint = folder.Path;
            item.Tag = folder;
            item.LinkClicked += new NavBarLinkEventHandler(OnFolderLinkClicked);
            return item;
        }
        NavBarItem CreateAlbumItem(AlbumData album) {
            NavBarItem item = new NavBarItem();
            item.Caption = album.Name;
            item.Hint = album.Description;
            item.Tag = album;
            item.LinkClicked += new NavBarLinkEventHandler(OnAlbumLinkClicked);
            return item;
        }
        protected virtual void CreateThumbForFiles(List<string> files, string progressText) {
            ProgressForm pf = new ProgressForm();
            pf.ProgressControl.Maximum = files.Count;
            pf.ProgressControl.ProgressText = progressText;
            pf.Show(this);
            foreach(string fileName in files) {
                CreateThumbForFile(fileName);
                pf.ProgressControl.Value++;
                Application.DoEvents();
            }
            pf.Close();
        }
        protected virtual void CreateThumbForFile(string fileName) {
            Image img = ThumbnailHelper.Default.GetThumbnail(fileName, 208, DataController.ThumbPath);
            if(img != null)
                img.Dispose();
        }
        protected virtual void CreateThumbsForFolder(PathData folder) {
            CreateThumbForFiles(DataController.GetImagesInFolder(folder), "Processing folder");
        }
        void OnFolderLinkClicked(object sender, NavBarLinkEventArgs e) {
            if(e.Link.Group == othersGroup)
                OpenOthers(e.Link.Item.Tag as PathData);
            else OpenFolder(e.Link.Item.Tag as PathData);
        }
        void OnAlbumLinkClicked(object sender, NavBarLinkEventArgs e) {
            OpenAlbum(e.Link.Item.Tag as AlbumData);
        }
        void OnFormClosing(object sender, FormClosingEventArgs e) {
            SaveData();
        }
        void OnExitButtonClick(object sender, EventArgs e) {
            if(XtraMessageBox.Show(this, "Exit Application?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Close();
            }
        }
        void OnNewAlbumItemClick(object sender, ItemClickEventArgs e) {
            AddAlbum();
        }
        void OnAddFolderItemClick(object sender, ItemClickEventArgs e) {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                if(!DataController.IsFolderAdded(folderBrowserDialog1.SelectedPath)) {
                    PathData p = new PathData();
                    p.Name = Path.GetFileName(folderBrowserDialog1.SelectedPath);
                    p.Path = folderBrowserDialog1.SelectedPath;
                    ViewData.Folders.Add(p);
                    CreateThumbsForFolder(p);
                    UpdateData();
                    navBar.SelectedLink = GetLink(p);
                }
                UpdateAddToLibraryItem(e.Item);
            }
        }
        private NavBarItemLink GetLink(string fileName) {
            foreach(NavBarItemLink link in othersGroup.ItemLinks) {
                if(((PathData)link.Item.Tag).Path == fileName)
                    return link;
            }
            return null;
        }
        private NavBarItemLink GetLinkByTag(NavBarGroup group, object tag) {
            foreach(NavBarItemLink link in group.ItemLinks) {
                if(link.Item.Tag == tag)
                    return link;
            }
            return null;
        }
        private NavBarItemLink GetLink(AlbumData album) {
            return GetLinkByTag(albumGroup, album);
        }
        private NavBarItemLink GetLink(PathData path) {
            return GetLinkByTag(foldersGroup, path);
        }
        private void OnAddFileClick(object sender, ItemClickEventArgs e) {
            if(imageDialog.ShowDialog() == DialogResult.OK) {
                DataController.AddToOthers(imageDialog.FileNames, this);
                CreateThumbForFiles(new List<string>(imageDialog.FileNames), "Processing files");
                UpdateData();
                string lastFileName = ViewData.Others.Files[ViewData.Others.Files.Count - 1].Name;
                navBar.SelectedLink = GetLink(lastFileName);
            }
            UpdateAddToLibraryItem(e.Item);
        }
        void OnNavBarControl1SelectedLinkChanged(object sender, NavBarSelectedLinkChangedEventArgs e) {
            lastSelectedGroup = e.Group;
        }
        void OnNavBarControl1MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) 
                ShowContextMenu(e.Location);
        }
        void ShowContextMenu(Point pt) {
            NavBarHitInfo hi = navBar.GetViewInfo().CalcHitInfo(pt);
            if(hi.Link == null) {
                mainRibbon.Manager.SetPopupContextMenu(navBar, null);
                return;
            }
            customizableLinkCore = hi.Link;
            if(hi.Group == albumGroup)
                mainRibbon.Manager.SetPopupContextMenu(navBar, albumPopupMenu);
            if(hi.Group == foldersGroup)
                mainRibbon.Manager.SetPopupContextMenu(navBar, folderPopupMenu);
            if(hi.Group == othersGroup)
                mainRibbon.Manager.SetPopupContextMenu(navBar, null);
        }
        void OnAboutItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }
        void OnSaveImageItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "SaveImageItemClick", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnRibbonControlSelectedPageChanged(object sender, EventArgs e) {
            if(tabbedView.ActiveDocument != null) {
                GalleryForm galleryForm = tabbedView.ActiveDocument.Form as GalleryForm;
                if(galleryForm != null)
                    galleryForm.OnParentRibbonControlSelectedPageChanged();
            }
        }
        void OnAddToLibraryItemClick(object sender, ItemClickEventArgs e) {
            BarItem item = biAddToLibrary.Tag as BarItem;
            if(item != null)
                item.PerformClick();
        }
        void OnGenerateDataItemClick(object sender, ItemClickEventArgs e) {
            if(XtraMessageBox.Show(this, "Are you sure you want generate data? Current data will be lost.", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            GenerateSampleData();
        }
        void AddAlbum() {
            AlbumData newAlbum = DataController.AddNewAlbum(this);
            if(newAlbum != null) {
                UpdateData(true);
                navBar.SelectedLink = GetLink(newAlbum);
            }
        }
        void EditAlbum(AlbumData album) {
            AlbumPropertiesForm.EditAlbum(DataController, album, this);
            BaseDocument document = null;
            if(Documents.TryGetValue(album, out document)) {
                document.Caption = album.Name;
                tabbedView.Controller.Activate(document);
            }
            UpdateData(true);
        }
        void RemoveAlbum(AlbumData album) {
            if(DataController.RemoveAlbum(album, this)) {
                CloseAlbum(album);
                UpdateData();
            }
        }
        void RemoveFolder(PathData folder) {
            if(DataController.RemoveFolder(folder, this)) {
                CloseFolder(folder);
                UpdateData();
            }
        }
        void UpdateAlbumButtonsEnabledState() {
            biEditAlbum.Enabled = SelectedAlbum != null;
            biRemoveAlbum.Enabled = SelectedAlbum != null;
        }
        void UpdateSelectedPictureEdit(GalleryItemEventArgs e) {
            selectedPictureEdit.LoadAsync((string)e.Item.Tag);
        }
        private void UpdateItemsEnabledState() {
            UpdateAlbumButtonsEnabledState();
            UpdateCancelButtonEnabledState();
        }
        void UpdateAddToLibraryItem(BarItem item) {
            biAddToLibrary.Glyph = item.Glyph;
            biAddToLibrary.LargeGlyph = item.LargeGlyph;
            biAddToLibrary.SuperTip = item.SuperTip;
            biAddToLibrary.Hint = item.Hint;
            biAddToLibrary.Tag = item;
        }
        void GenerateSampleData() {
            ViewData.FirstRun = true;
            DataController.GenerateSampleData();
            UpdateData();
        }
        internal void UpdateCancelButtonEnabledState() {
            foreach(BaseDocument document in Documents.Values) {
                GalleryForm galleryForm = document.Form as GalleryForm;
                if(galleryForm != null)
                    galleryForm.UpdateCancelButtonEnabledState();
            }
        }
        void OnDateFilterSelectionChanged(object sender, EventArgs e) {
            foreach(BaseDocument document in Documents.Values) {
                GalleryForm galleryForm = document.Form as GalleryForm;
                if(galleryForm != null)
                    galleryForm.FilterGallery(dateFilter.AllowFilter, dateFilter.StartDate, dateFilter.EndDate);
            }
        }
        #region Documents
        IDictionary<object, BaseDocument> documentsCore = new Dictionary<object, BaseDocument>();
        public IDictionary<object, BaseDocument> Documents {
            get { return documentsCore; }
        }
        public void CloseAlbum(AlbumData album) {
            BaseDocument document = null;
            if(Documents.TryGetValue(album, out document)) {
                tabbedView.Controller.Close(document);
            }
        }
        public void CloseFolder(PathData folder) {
            BaseDocument document = null;
            if(Documents.TryGetValue(folder, out document)) {
                tabbedView.Controller.Close(document);
            }
        }
        public void OpenOthers(PathData path) {
            BaseDocument document = null;
            if(!Documents.TryGetValue(ViewData.Others, out document)) {
                AlbumGalleryForm albumForm = new AlbumGalleryForm(DataController, ViewData.Others);
                albumForm.MainForm = this;
                albumForm.MdiParent = this;
                albumForm.Show();
                if(tabbedView.Documents.TryGetValue(albumForm, out document)) {
                    document.Caption = ViewData.Others.Name;
                }
                albumForm.ScrollToFile(path.Path, true);
            }
            else tabbedView.Controller.Activate(document);
        }
        public void OpenAlbum(AlbumData album) {
            BaseDocument document = null;
            if(!Documents.TryGetValue(album, out document)) {
                AlbumGalleryForm albumForm = new AlbumGalleryForm(DataController, album);
                albumForm.MainForm = this;
                albumForm.MdiParent = this;
                albumForm.Show();
                if(tabbedView.Documents.TryGetValue(albumForm, out document)) {
                    document.Caption = album.Name;
                }
            }
            else tabbedView.Controller.Activate(document);
        }
        public void OpenFolder(PathData folder) {
            BaseDocument document = null;
            if(!Documents.TryGetValue(folder, out document)) {
                FolderGalleryForm folderForm = new FolderGalleryForm(DataController, folder);
                folderForm.MainForm = this;
                folderForm.MdiParent = this;
                folderForm.Show();
                if(tabbedView.Documents.TryGetValue(folderForm, out document)) {
                    document.Caption = folder.Name;
                }
            }
            else tabbedView.Controller.Activate(document);
        }
        void tabbedView_DocumentAdded(object sender, DocumentEventArgs e) {
            RegisterDocument(e.Document);
        }
        void tabbedView_DocumentRemoved(object sender, DocumentEventArgs e) {
            UnregisterDocument(e.Document);
        }
        void RegisterDocument(BaseDocument document) {
            AlbumGalleryForm albumForm = document.Form as AlbumGalleryForm;
            if(albumForm != null) Documents.Add(albumForm.Album, document);
            FolderGalleryForm folderForm = document.Form as FolderGalleryForm;
            if(folderForm != null) Documents.Add(folderForm.Folder, document);
        }
        void UnregisterDocument(BaseDocument document) {
            AlbumGalleryForm albumForm = document.Form as AlbumGalleryForm;
            if(albumForm != null) Documents.Remove(albumForm.Album);
            FolderGalleryForm folderForm = document.Form as FolderGalleryForm;
            if(folderForm != null) Documents.Remove(folderForm.Folder);
        }
        void tabbedView_FloatDocumentsCollectionChanged(DevExpress.XtraBars.Docking2010.Base.CollectionChangedEventArgs<BaseDocument> ea) {
            if(ea.ChangedType == DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementAdded)
                RegisterDocument(ea.Element);
            if(ea.ChangedType == DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementRemoved)
                UnregisterDocument(ea.Element);
        }
        #endregion Documents
        #region Album PopupMenu
        NavBarItemLink customizableLinkCore;
        protected NavBarItemLink CustomizableLink { 
            get { return customizableLinkCore; } 
        }
        void OnRemoveAlbumItemClick(object sender, ItemClickEventArgs e) {
            if(CustomizableLink == null)
                return;
            RemoveAlbum(CustomizableLink.Item.Tag as AlbumData);
        }
        void OnEditAlbumItemClick(object sender, ItemClickEventArgs e) {
            if(CustomizableLink == null)
                return;
            EditAlbum(CustomizableLink.Item.Tag as AlbumData);
        }
        void OnAlbumPopupMenuCloseUp(object sender, EventArgs e) {
            customizableLinkCore = null;
        }
        #endregion Album PopupMenu
        #region Folder PopupMenu
        void OnRemoveFolderItemClick(object sender, ItemClickEventArgs e) {
            if(CustomizableLink == null)
                return;
            PathData folder = (PathData)customizableLinkCore.Item.Tag;
            RemoveFolder(folder);
        }
        #endregion Folder PopupMenu
        GalleryForm viewForm;
        int lockVisibility = 0;
        internal void StartViewImages(GalleryForm form) {
            if(lockVisibility > 0) return;
            lockVisibility++;
            try {
                if(viewForm != null)
                    viewForm.CloseSelectedTabPage();
                viewForm = form;
                SuspendLayout();
                navBar.Visible = false;
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                ResumeLayout(true);
                tabbedView.DocumentGroupProperties.ShowTabHeader = false;
            }
            finally { lockVisibility--; }
        }
        internal void EndViewImages() {
            if(lockVisibility > 0) return;
            lockVisibility++;
            try {
                SuspendLayout();
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                navBar.Visible = true;
                ResumeLayout(true);
                tabbedView.DocumentGroupProperties.ShowTabHeader = true;
            }
            finally {
                viewForm = null;
                lockVisibility--; 
            }
        }

        private void bBColorMix_ItemClick(object sender, ItemClickEventArgs e) {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }
    }

    public class PhotoViewerSplashScreen : DemoSplashScreen {
        public PhotoViewerSplashScreen() {
            DemoText = "PhotoViewer";
            ProductText = "The XtraBars Suite";
        }
    }
}
