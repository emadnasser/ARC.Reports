using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials.Controls;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Taskbar;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using DevExpress.Utils.Colors;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.XtraEditors.Popup;
using System.Collections.Generic;
using DevExpress.Utils.Helpers;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm {
        public static string FileNames = "RibbonMRUFiles.ini";
        public static string FolderNames = "RibbonMRUFolders.ini";
        public frmMain() {
            InitializeComponent();
            CreateColorPopup(popupControlContainer1);
            InitSkinGallery();
            InitFontGallery();
            InitColorGallery();
            InitEditors();
            InitSchemeCombo();
            InitPrint();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            SplashScreenManager.CloseForm(false);
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
        }
        private void InitSchemeCombo() {
            foreach(RibbonControlColorScheme value in Enum.GetValues(typeof(RibbonControlColorScheme))) {
                if(value == RibbonControlColorScheme.Yellow) continue;
                repositoryItemComboBox1.Items.Add(value);
            }
            beScheme.EditValue = RibbonControlColorScheme.Default;
        }

        int documentIndex = 0;
        PopupColor pc;
        frmFind dlgFind = null;
        frmReplace dlgReplace = null;
        GalleryItem fCurrentFontItem, fCurrentColorItem;
        string DocumentName { get { return string.Format("New Document {0}", documentIndex); } }

        void CreateNewDocument() {
            CreateNewDocument(null);
        }
        void InitEditors() {
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("MacOffice", RibbonControlStyle.MacOffice, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("TabletOffice", RibbonControlStyle.TabletOffice, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("OfficeUniversal", RibbonControlStyle.OfficeUniversal, -1));
            biStyle.EditValue = ribbonControl1.RibbonStyle;
        }
        public void ShowHideFormatCategory() {
            RibbonPageCategory selectionCategory = Ribbon.PageCategories[0] as RibbonPageCategory;
            if(selectionCategory == null) return;
            if(CurrentRichTextBox == null)
                selectionCategory.Visible = false;
            else
                selectionCategory.Visible = CurrentRichTextBox.SelectionLength != 0;
            if(selectionCategory.Visible) Ribbon.SelectedPage = selectionCategory.Pages[0];
        }
        void CreateNewDocument(string fileName) {
            documentIndex++;
            frmPad pad = new frmPad();
            if(fileName != null)
                pad.LoadDocument(fileName);
            else
                pad.DocName = DocumentName;
            pad.MdiParent = this;
            pad.Closed += new EventHandler(Pad_Closed);
            pad.ShowPopupMenu += new EventHandler(Pad_ShowPopupMenu);
            pad.ShowMiniToolbar += new EventHandler(pad_ShowMiniToolbar);
            pad.Show();
            InitNewDocument(pad.RTBMain);
        }

        void pad_ShowMiniToolbar(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(((RichTextBox)sender).SelectedText))
                return;
            ShowSelectionMiniToolbar();
        }

        void Pad_Closed(object sender, EventArgs e) {
            CloseFind();
        }
        void Pad_ShowPopupMenu(object sender, EventArgs e) {
            pmMain.RibbonToolbar = selectionMiniToolbar;
            pmMain.ShowPopup(Control.MousePosition);
        }
        void CloseFind() {
            if(dlgFind != null && dlgFind.RichText != CurrentRichTextBox) {
                dlgFind.Close();
                dlgFind = null;
            }
            if(dlgReplace != null && dlgReplace.RichText != CurrentRichTextBox) {
                dlgReplace.Close();
                dlgReplace = null;
            }
        }

        private void CreateColorPopup(PopupControlContainer container) {
            pc = new PopupColor(container, this);
        }
        #region Init
        private void frmMain_Activated(object sender, System.EventArgs e) {
            InitPaste();
        }
        public void UpdateText() {
            ribbonControl1.ApplicationCaption = "Ribbon Simple Pad";
            ribbonControl1.ApplicationDocumentCaption = CurrentDocName + (CurrentModified ? "*" : "");
            //Text = string.Format("Ribbon Simple Pad ({0})", CurrentDocName);
            siDocName.Caption = string.Format("  {0}", CurrentDocName);
        }
        void ChangeActiveForm() {
            UpdateText();
            InitCurrentDocument(CurrentRichTextBox);
            rtPad_SelectionChanged(CurrentRichTextBox, EventArgs.Empty);
            CloseFind();
        }
        private void xtraTabbedMdiManager1_FloatMDIChildActivated(object sender, EventArgs e) {
            ChangeActiveForm();
        }
        private void xtraTabbedMdiManager1_FloatMDIChildDeactivated(object sender, EventArgs e) {
            BeginInvoke(new MethodInvoker(ChangeActiveForm));
        }
        private void frmMain_MdiChildActivate(object sender, System.EventArgs e) {
            ChangeActiveForm();
        }
        void rtPad_SelectionChanged(object sender, System.EventArgs e) {
            ShowHideFormatCategory();
            RichTextBox rtPad = sender as RichTextBox;
            InitFormat();
            int line = 0, col = 0;

            if(rtPad != null) {
                InitEdit(rtPad.SelectionLength > 0);
                line = rtPad.GetLineFromCharIndex(rtPad.SelectionStart) + 1;
                col = rtPad.SelectionStart + 1;
            }
            else {
                InitEdit(false);
            }
            siPosition.Caption = string.Format("   Line: {0}  Position: {1}   ", line, col);
            CurrentFontChanged();
        }

        protected virtual void ShowSelectionMiniToolbar() {
            Point pt = Control.MousePosition;
            pt.Offset(0, -11);
            selectionMiniToolbar.Alignment = ContentAlignment.TopRight;
            selectionMiniToolbar.PopupMenu = null;
            selectionMiniToolbar.Show(pt);
        }
        void rtPad_TextChanged(object sender, System.EventArgs e) {
            if(CurrentForm == null) return;
            CurrentForm.Modified = true;
            InitCurrentDocument(CurrentRichTextBox);
        }

        protected void InitFormat() {
            iBold.Enabled = SelectFont != null;
            iItalic.Enabled = SelectFont != null;
            iUnderline.Enabled = SelectFont != null;
            iFont.Enabled = SelectFont != null;
            iFontColor.Enabled = SelectFont != null;
            if(SelectFont != null) {
                iBold.Down = SelectFont.Bold;
                iItalic.Down = SelectFont.Italic;
                iUnderline.Down = SelectFont.Underline;
            }
            bool enabled = CurrentRichTextBox != null;
            iProtected.Enabled = enabled;
            iBullets.Enabled = enabled;
            iAlignLeft.Enabled = enabled;
            iAlignRight.Enabled = enabled;
            iCenter.Enabled = enabled;
            rgbiFont.Enabled = enabled;
            rgbiFontColor.Enabled = enabled;
            ribbonPageGroup9.ShowCaptionButton = enabled;
            rpgFont.ShowCaptionButton = enabled;
            rpgFontColor.ShowCaptionButton = enabled;
            if(!enabled) ClearFormats();
            if(CurrentRichTextBox != null) {
                iProtected.Down = CurrentRichTextBox.SelectionProtected;
                iBullets.Down = CurrentRichTextBox.SelectionBullet;
                switch(CurrentRichTextBox.SelectionAlignment) {
                    case HorizontalAlignment.Left:
                        iAlignLeft.Down = true;
                        break;
                    case HorizontalAlignment.Center:
                        iCenter.Down = true;
                        break;
                    case HorizontalAlignment.Right:
                        iAlignRight.Down = true;
                        break;
                }
            }
        }

        void ClearFormats() {
            iBold.Down = false;
            iItalic.Down = false;
            iUnderline.Down = false;
            iProtected.Down = false;
            iBullets.Down = false;
            iAlignLeft.Down = false;
            iAlignRight.Down = false;
            iCenter.Down = false;
        }

        protected void InitPaste() {
            bool enabledPase = CurrentRichTextBox != null && CurrentRichTextBox.CanPaste(DataFormats.GetFormat(0));
            iPaste.Enabled = enabledPase;
            sbiPaste.Enabled = enabledPase;
        }

        void InitUndo() {
            iUndo.Enabled = CurrentRichTextBox != null ? CurrentRichTextBox.CanUndo : false;
            iLargeUndo.Enabled = iUndo.Enabled;
        }
        protected void InitEdit(bool enabled) {
            iCut.Enabled = enabled;
            iCopy.Enabled = enabled;
            iClear.Enabled = enabled;
            iSelectAll.Enabled = CurrentRichTextBox != null ? CurrentRichTextBox.CanSelect : false;
            InitUndo();
        }

        void InitNewDocument(RichTextBox rtbControl) {
            rtbControl.SelectionChanged += new System.EventHandler(this.rtPad_SelectionChanged);
            rtbControl.TextChanged += new System.EventHandler(this.rtPad_TextChanged);
        }

        void InitCurrentDocument(RichTextBox rtbControl) {
            bool enabled = rtbControl != null;
            iSaveAs.Enabled = enabled;
            iClose.Enabled = enabled;
            iPrint.Enabled = enabled;
            sbiSave.Enabled = enabled;
            sbiFind.Enabled = enabled;
            iFind.Enabled = enabled;
            iReplace.Enabled = enabled;
            iSave.Enabled = CurrentModified;
            SetModifiedCaption();
            InitPaste();
            InitFormat();
        }

        void SetModifiedCaption() {
            if(CurrentForm == null) {
                siModified.Caption = "";
                return;
            }
            siModified.Caption = CurrentModified ? "   Modified   " : "";
        }
        #endregion
        #region Properties
        frmPad CurrentForm {
            get {
                if(this.ActiveMdiChild == null) return null;
                if(xtraTabbedMdiManager1.ActiveFloatForm != null)
                    return xtraTabbedMdiManager1.ActiveFloatForm as frmPad;
                return this.ActiveMdiChild as frmPad;
            }
        }

        public RichTextBox CurrentRichTextBox {
            get {
                if(CurrentForm == null) return null;
                return CurrentForm.RTBMain;
            }
        }

        string CurrentDocName {
            get {
                if(CurrentForm == null) return "";
                return CurrentForm.DocName;
            }
        }

        bool CurrentModified {
            get {
                if(CurrentForm == null) return false;
                return CurrentForm.Modified;
            }
        }
        #endregion
        #region File
        void idNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            CreateNewDocument();
        }

        void iClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentForm != null) CurrentForm.Close();
        }

        void OpenFile() {
            OpenFileFolder(string.Empty);
        }

        public void OpenFile(string name) {
            CreateNewDocument(name);
			AddToMostRecentFiles(name, arMRUList);
            AddToMostRecentFiles(name, null);
            AddToMostRecentFolders(name, null);
        }
        private void AddToMostRecentFiles(string name, MRUArrayList arMRUList) {
			if(arMRUList != null) arMRUList.InsertElement(name);            
			RecentPinItem pinItem = new RecentPinItem() { Caption = GetFileName(name), Description = name, PinButtonChecked = false };
            if(CheckForOverlap(pinItem, recentTabItem1.TabPanel.Items)) return;
            recentTabItem1.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem1.TabPanel), pinItem);
        }

        bool CheckForOverlap(RecentPinItem pinItem, RecentItemCollection recentItemCollection) {
            foreach(RecentItemBase item in recentItemCollection) {
                RecentPinItem pItem = item as RecentPinItem;
                if(pItem != null && pinItem.Caption == pItem.Caption && pinItem.Description == pItem.Description)
                    return true;
            }
            return false;
        }
        private void AddToMostRecentFolders(string name, MRUArrayList arMRUList) {
            if (arMRUList != null){
                name = Path.GetFullPath(name);
                arMRUList.InsertElement(Path.GetDirectoryName(name));
            }
			name = Path.GetDirectoryName(Path.GetFullPath(name)); 
            RecentPinItem pinItem = new RecentPinItem() { Caption = GetFileName(name), Description = name, PinButtonChecked = false };
            if(CheckForOverlap(pinItem, recentTabItem2.TabPanel.Items)) return;
            RecentPinItem pinItem_ = new RecentPinItem() { Caption = GetFileName(name), Description = name, PinButtonChecked = false };
            recentTabItem2.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem2.TabPanel), pinItem);
            recentTabItem3.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem3.TabPanel), pinItem_);
        }

        void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            OpenFile();
        }

        private void iPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Note that you can use the XtraPrinting Library to print the contents of the standard RichTextBox control.\r\nFor more information, see the main XtraPrinting demo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void iSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Save();
        }
        void iSaveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SaveAs();
        }
        void Save() {
            if(CurrentForm == null) return;
            if(CurrentForm.NewDocument) {
                SaveAs();
            }
            else {
                CurrentRichTextBox.SaveFile(CurrentDocName, RichTextBoxStreamType.RichText);
                CurrentForm.Modified = false;
            }
            SetModifiedCaption();
        }
        void SaveAs() { 
            SaveAs(string.Empty);
        }
        void SaveAs(string path) {
            if(CurrentForm != null) {
                string s = CurrentForm.SaveAs(path);
                if(s != string.Empty) {
					AddToMostRecentFiles(s, arMRUList);
                    AddToMostRecentFiles(s, null);
                    AddToMostRecentFolders(s, null);
                }
                UpdateText();
            }
        }
        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }
        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
        }
        private void ribbonPageGroup1_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            OpenFile();
        }

        private void ribbonPageGroup9_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            SaveAs();
        }
        #endregion
        #region Format
        private FontStyle rtPadFontStyle() {
            FontStyle fs = new FontStyle();
            if(iBold.Down) fs |= FontStyle.Bold;
            if(iItalic.Down) fs |= FontStyle.Italic;
            if(iUnderline.Down) fs |= FontStyle.Underline;
            return fs;
        }

        private void iBullets_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectionBullet = iBullets.Down;
            InitUndo();
        }

        private void iFontStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectionFont = new Font(SelectFont, rtPadFontStyle());
        }

        private void iProtected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectionProtected = iProtected.Down;
        }

        private void iAlign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            if(iAlignLeft.Down)
                CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            if(iCenter.Down)
                CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            if(iAlignRight.Down)
                CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            InitUndo();
        }


        protected Font SelectFont {
            get {
                if(CurrentRichTextBox != null)
                    return CurrentRichTextBox.SelectionFont;
                return null;
            }
        }
        void ShowFontDialog() {
            if(CurrentRichTextBox == null) return;
            Font dialogFont = null;
            if(SelectFont != null)
                dialogFont = (Font)SelectFont.Clone();
            else dialogFont = CurrentRichTextBox.Font;
            XtraFontDialog dlg = new XtraFontDialog(dialogFont);
            if(dlg.ShowDialog() == DialogResult.OK) {
                CurrentRichTextBox.SelectionFont = dlg.ResultFont;
                beiFontSize.EditValue = dlg.ResultFont.Size;
            }
        }
        private void iFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ShowFontDialog();
        }
        private void iFontColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectionColor = ((IPopupColorPickEdit)pc).Color;
        }
        #endregion
        #region Edit
        private void iUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.Undo();
            CurrentForm.Modified = CurrentRichTextBox.CanUndo;
            SetModifiedCaption();
            InitUndo();
            InitFormat();
        }

        private void iCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.Cut();
            InitPaste();
        }

        private void iCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.Copy();
            InitPaste();
        }

        private void iPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.Paste();
        }

        private void iClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectedRtf = "";
        }

        private void iSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectAll();
        }
        private void ribbonPageGroup2_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            pmMain.ShowPopup(ribbonControl1.Manager, MousePosition);
        }
        #endregion
        #region SkinGallery
        void InitSkinGallery() {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        #endregion
        #region FontGallery
        Image GetFontImage(int width, int height, string fontName, int fontSize) {
            Rectangle rect = new Rectangle(0, 0, width, height);
            Image fontImage = new Bitmap(width, height);
            try {
                using(Font fontSample = new Font(fontName, fontSize)) {
                    Graphics g = Graphics.FromImage(fontImage);
                    g.FillRectangle(Brushes.White, rect);
                    using(StringFormat fs = new StringFormat()) {
                        fs.Alignment = StringAlignment.Center;
                        fs.LineAlignment = StringAlignment.Center;
                        //g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        g.DrawString("Aa", fontSample, Brushes.Black, rect, fs);
                        g.Dispose();
                    }
                }
            }
            catch { }
            return fontImage;
        }
        void InitFont(GalleryItemGroup groupDropDown, GalleryItemGroup galleryGroup) {
            FontFamily[] fonts = FontFamily.Families;
            for(int i = 0; i < fonts.Length; i++) {
                if(!FontFamily.Families[i].IsStyleAvailable(FontStyle.Regular)) continue;
                string fontName = fonts[i].Name;
                GalleryItem item = new GalleryItem();
                item.Caption = fontName;
                item.Image = GetFontImage(40, 40, fontName, 16);
                item.HoverImage = item.Image;
                item.Description = fontName;
                item.Hint = fontName;
                try {
                    item.Tag = new Font(fontName, 9);
                    if(DevExpress.Utils.ControlUtils.IsSymbolFont((Font)item.Tag)) {
                        item.Tag = new Font(DevExpress.Utils.AppearanceObject.DefaultFont.FontFamily, 9);
                        item.Description += " (Symbol Font)";
                    }
                }
                catch {
                    continue;
                }
                groupDropDown.Items.Add(item);
                galleryGroup.Items.Add(item);
            }
        }
        void InitFontGallery() {
            gddFont.Gallery.BeginUpdate();
            rgbiFont.Gallery.BeginUpdate();
            try {
                InitFont(gddFont.Gallery.Groups[0], rgbiFont.Gallery.Groups[0]);
            }
            finally {
                gddFont.Gallery.EndUpdate();
                rgbiFont.Gallery.EndUpdate();
            }
            beiFontSize.EditValue = 8;
        }
        void SetFont(string fontName, GalleryItem item) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectionFont = new Font(fontName, Convert.ToInt32(beiFontSize.EditValue), rtPadFontStyle());
            if(item != null) CurrentFontItem = item;
        }
        private void gddFont_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetFont(e.Item.Caption, e.Item);
        }
        private void rpgFont_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            ShowFontDialog();
        }
        private void rgbiFont_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetFont(e.Item.Caption, e.Item);
        }
        private void gddFont_Gallery_CustomDrawItemText(object sender, GalleryItemCustomDrawEventArgs e) {
            DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo itemInfo = e.ItemInfo as DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo;
            itemInfo.PaintAppearance.ItemDescriptionAppearance.Normal.DrawString(e.Cache, e.Item.Description, itemInfo.DescriptionBounds);
            AppearanceObject app = itemInfo.PaintAppearance.ItemCaptionAppearance.Normal.Clone() as AppearanceObject;
            app.Font = (Font)e.Item.Tag;
            try {
                e.Cache.Graphics.DrawString(e.Item.Caption, app.Font, app.GetForeBrush(e.Cache), itemInfo.CaptionBounds);
            }
            catch { }
            e.Handled = true;
        }
        #endregion
        #region ColorGallery
        void InitColorGallery() {
            gddFontColor.BeginUpdate();
            foreach(Color color in DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.WebColors) {
                if(color == Color.Transparent) continue;
                GalleryItem item = new GalleryItem();
                item.Caption = color.Name;
                item.Tag = color;
                item.Hint = color.Name;
                gddFontColor.Gallery.Groups[0].Items.Add(item);
                rgbiFontColor.Gallery.Groups[0].Items.Add(item);
            }
            foreach(Color color in DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.SystemColors) {
                GalleryItem item = new GalleryItem();
                item.Caption = color.Name;
                item.Tag = color;
                gddFontColor.Gallery.Groups[1].Items.Add(item);
            }
            gddFontColor.EndUpdate();
        }
        private void gddFontColor_Gallery_CustomDrawItemImage(object sender, GalleryItemCustomDrawEventArgs e) {
            Color clr = (Color)e.Item.Tag;
            using(Brush brush = new SolidBrush(clr)) {
                e.Cache.FillRectangle(brush, e.Bounds);
                e.Handled = true;
            }
        }
        void SetResultColor(Color color, GalleryItem item) {
            if(CurrentRichTextBox == null) return;
            CurrentRichTextBox.SelectionColor = color;
            if(item != null) CurrentColorItem = item;
        }
        private void gddFontColor_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetResultColor((Color)e.Item.Tag, e.Item);
        }
        private void rpgFontColor_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            if(CurrentRichTextBox == null) return;
            if(pc == null)
                CreateColorPopup(popupControlContainer1);
            popupControlContainer1.ShowPopup(ribbonControl1.Manager, MousePosition);
        }

        private void rgbiFontColor_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetResultColor((Color)e.Item.Tag, e.Item);
        }
        #endregion

        private void iFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            if(dlgReplace != null) dlgReplace.Close();
            if(dlgFind != null) dlgFind.Close();
            dlgFind = new frmFind(CurrentRichTextBox, Bounds);
            AddOwnedForm(dlgFind);
            dlgFind.Show();
        }

        private void iReplace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(CurrentRichTextBox == null) return;
            if(dlgReplace != null) dlgReplace.Close();
            if(dlgFind != null) dlgFind.Close();
            dlgReplace = new frmReplace(CurrentRichTextBox, Bounds);
            AddOwnedForm(dlgReplace);
            dlgReplace.Show();
        }

        private void iWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                Process process = new Process();
                process.StartInfo.FileName = "http://www.devexpress.com";
                process.StartInfo.Verb = "Open";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
            catch { }
        }

        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }

        string TextByCaption(string caption) {
            return caption.Replace("&", "");
        }

        private void frmMain_Load(object sender, System.EventArgs e) {
            InitMostRecentFiles();
			arMRUList = new MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images[0], imageCollection3.Images[1]);
            arMRUList.LabelClicked += new EventHandler(OnMRUFileLabelClicked);
            InitMostRecentFiles(arMRUList);
            ribbonControl1.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = ribbonControl1;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;
            CreateNewDocument();
            barEditItem1.EditValue = (Bitmap)DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraBars.Demos.RibbonSimplePad.online.gif", typeof(frmMain).Assembly);
        }

        private void InitMostRecentFiles(MRUArrayList arMRUList) {
            string fileName = Application.StartupPath + "\\" + MRUArrayList.MRUFileName;
            arMRUList.Init(fileName, "Document1.rtf");

        }
        #region GalleryItemsChecked

        GalleryItem GetColorItemByColor(Color color, BaseGallery gallery) {
            foreach(GalleryItemGroup galleryGroup in gallery.Groups)
                foreach(GalleryItem item in galleryGroup.Items)
                    if(item.Caption == color.Name)
                        return item;
            return null;
        }
        GalleryItem GetFontItemByFont(string fontName, BaseGallery gallery) {
            foreach(GalleryItemGroup galleryGroup in gallery.Groups)
                foreach(GalleryItem item in galleryGroup.Items)
                    if(item.Caption == fontName)
                        return item;
            return null;
        }
        GalleryItem CurrentFontItem {
            get { return fCurrentFontItem; }
            set {
                if(fCurrentFontItem == value) return;
                if(fCurrentFontItem != null) fCurrentFontItem.Checked = false;
                fCurrentFontItem = value;
                if(fCurrentFontItem != null) {
                    fCurrentFontItem.Checked = true;
                    MakeFontVisible(fCurrentFontItem);
                }
            }
        }
        void MakeFontVisible(GalleryItem item) {
            gddFont.Gallery.MakeVisible(fCurrentFontItem);
            rgbiFont.Gallery.MakeVisible(fCurrentFontItem);
        }
        GalleryItem CurrentColorItem {
            get { return fCurrentColorItem; }
            set {
                if(fCurrentColorItem == value) return;
                if(fCurrentColorItem != null) fCurrentColorItem.Checked = false;
                fCurrentColorItem = value;
                if(fCurrentColorItem != null) {
                    fCurrentColorItem.Checked = true;
                    MakeColorVisible(fCurrentColorItem);
                }
            }
        }
        void MakeColorVisible(GalleryItem item) {
            gddFontColor.Gallery.MakeVisible(fCurrentColorItem);
            rgbiFontColor.Gallery.MakeVisible(fCurrentColorItem);
        }
        void CurrentFontChanged() {
            if(CurrentRichTextBox == null || CurrentRichTextBox.SelectionFont == null) return;
            CurrentFontItem = GetFontItemByFont(CurrentRichTextBox.SelectionFont.Name, rgbiFont.Gallery);
            CurrentColorItem = GetColorItemByColor(CurrentRichTextBox.SelectionColor, rgbiFontColor.Gallery);
        }
        private void gddFont_Popup(object sender, System.EventArgs e) {
            MakeFontVisible(CurrentFontItem);
            if(CurrentRichTextBox == null || CurrentRichTextBox.SelectionFont == null) return;
            beiFontSize.EditValue = CurrentRichTextBox.SelectionFont.Size;
        }

        private void gddFontColor_Popup(object sender, System.EventArgs e) {
            MakeColorVisible(CurrentColorItem);
        }
        #endregion
        #region MostRecentFiles
        MRUArrayList arMRUList = null;

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            SaveMostRecentFiles(recentTabItem1.TabPanel.Items, Application.StartupPath + "\\" + FileNames);
            SaveMostRecentFiles(recentTabItem2.TabPanel.Items, Application.StartupPath + "\\" + FolderNames);
        }
        void InitMostRecentFiles() {
            string fileName = Application.StartupPath + "\\" + MRUArrayList.MRUFileName;
            string folderName = Application.StartupPath + "\\" + MRUArrayList.MRUFolderName;
            InitFiles(fileName, "Document1.rtf", true);
            InitFiles(folderName, Application.StartupPath, false);
        }

        public void InitFiles(string fileName, string defaultItem, bool isFile) {
            if(!System.IO.File.Exists(fileName)) {
                StartInitFiles(isFile);
                EndInitFiles(isFile);
                //InsertElement(defaultItem, isFile);
                return;
            }
            System.IO.StreamReader sr = System.IO.File.OpenText(fileName);
            List<string> list = new List<string>();
            for(string s = sr.ReadLine(); s != null; s = sr.ReadLine())
                list.Add(s);
            for(int i = 0; i < list.Count; i++) {
                InsertElement(list[i], isFile);
            }
            sr.Close();
            if(!isFile) CreateButtonBrowse();
        }

        int FindFirstUnCheckedIntemIndex(RecentPanelBase recentPanelBase) {
            for(int i = 0; i < recentPanelBase.Items.Count; i++) {
                RecentPinItem pinItem = recentPanelBase.Items[i] as RecentPinItem;
                if(pinItem == null) continue;
                if(!pinItem.PinButtonChecked) return i;
            }
            return 0;
        }
        void InsertElement(object obj, bool isFile) {
            string[] names = obj.ToString().Split(',');
            string name = names[0];
            bool checkedLabel = false;
            if(names.Length > 1) checkedLabel = names[1].ToLower().Equals("true");
            if(isFile) {
                RecentPinItem pinItem = new RecentPinItem() { Caption = GetFileName(name), Description = name, PinButtonChecked = checkedLabel};
                recentTabItem1.TabPanel.Items.Add(pinItem);
            }
            else {
                RecentPinItem pinItem = new RecentPinItem() { Caption = GetFileName(name), Description = name, PinButtonChecked = checkedLabel};
                RecentPinItem pinItem_ = new RecentPinItem() { Caption = GetFileName(name), Description = name, PinButtonChecked = checkedLabel };
                recentTabItem2.TabPanel.Items.Add(pinItem);
                recentTabItem3.TabPanel.Items.Add(pinItem_);
            }
        }
        void CreateButtonBrowse() {
            RecentHyperlinkItem hyperlinkBrowse = new RecentHyperlinkItem() { Caption = "Browse..."/*, Link = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) */};
            recentTabItem2.TabPanel.Items.Add(hyperlinkBrowse);
            hyperlinkBrowse.ItemClick += hyperlinkBrowse_ItemClick;
            RecentHyperlinkItem hyperlinkBrowse1 = new RecentHyperlinkItem() { Caption = "Browse..."/*, Link = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) */};
            recentTabItem3.TabPanel.Items.Add(hyperlinkBrowse1);
            hyperlinkBrowse1.ItemClick += hyperlinkBrowse_ItemClick;
        }

        void hyperlinkBrowse_ItemClick(object sender, RecentItemEventArgs e) {
            SaveAs();
        }
        private void EndInitFiles(bool isFile) {
            if(isFile) InitDefaultFiles();
            else InitDefaultFolders();
            if(!isFile) CreateButtonBrowse();
        }
        private void StartInitFiles(bool isFile) {
            if(!isFile) InitStartDefaultFolders();
        }
        private void InitStartDefaultFolders() {
            RecentPinItem desktop = new RecentPinItem() { Caption = "Desktop", Description = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), PinButtonChecked = true, ShowDescription = false };
            RecentPinItem desktop_ = new RecentPinItem() { Caption = "Desktop", Description = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), PinButtonChecked = true, ShowDescription = false };
            recentTabItem2.TabPanel.Items.Add(desktop);
            recentTabItem3.TabPanel.Items.Add(desktop_);
            RecentSeparatorItem separator = new RecentSeparatorItem();
            RecentSeparatorItem separator_ = new RecentSeparatorItem();
            recentTabItem2.TabPanel.Items.Add(separator);
            recentTabItem3.TabPanel.Items.Add(separator_);
        }
        private void InitDefaultFolders() {
            RecentPinItem item1 = new RecentPinItem() { Caption = "MyDocuments", Description = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() };
            RecentPinItem item1_ = new RecentPinItem() { Caption = "MyDocuments", Description = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() };
            recentTabItem2.TabPanel.Items.Add(item1);
            recentTabItem3.TabPanel.Items.Add(item1_);

            RecentPinItem item7 = new RecentPinItem() { Caption = "Saved HTML Articles", Description = "D:\\Personal\\Saved HTML Articles" };
            RecentPinItem item7_ = new RecentPinItem() { Caption = "Saved HTML Articles", Description = "D:\\Personal\\Saved HTML Articles" };
            recentTabItem2.TabPanel.Items.Add(item7);
            recentTabItem3.TabPanel.Items.Add(item7_);

            RecentPinItem item3 = new RecentPinItem() { Caption = "Tutorials", Description = "C:\\Program Files x86\\DevExpress 15.2\\Tutorials" };
            RecentPinItem item3_ = new RecentPinItem() { Caption = "Tutorials", Description = "C:\\Program Files x86\\DevExpress 15.2\\Tutorials" };
            recentTabItem2.TabPanel.Items.Add(item3);
            recentTabItem3.TabPanel.Items.Add(item3_);

            RecentPinItem item2 = new RecentPinItem() { Caption = "Products", Description = "C:\\DevExpress\\Products" };
            RecentPinItem item2_ = new RecentPinItem() { Caption = "Products", Description = "C:\\DevExpress\\Products" };
            recentTabItem2.TabPanel.Items.Add(item2);
            recentTabItem3.TabPanel.Items.Add(item2_);

            RecentPinItem item8 = new RecentPinItem() { Caption = "Win Forms", Description = "C:\\DevExpress\\Products\\Win Forms" };
            RecentPinItem item8_ = new RecentPinItem() { Caption = "Win Forms", Description = "C:\\DevExpress\\Products\\Win Forms" };
            recentTabItem2.TabPanel.Items.Add(item8);
            recentTabItem3.TabPanel.Items.Add(item8_);

            RecentPinItem item9 = new RecentPinItem() { Caption = "Controls", Description = "C:\\DevExpress\\Products\\Win Forms\\Controls" };
            RecentPinItem item9_ = new RecentPinItem() { Caption = "Controls", Description = "C:\\DevExpress\\Products\\Win Forms\\Controls" };
            recentTabItem2.TabPanel.Items.Add(item9);
            recentTabItem3.TabPanel.Items.Add(item9_);
        }
        private void InitDefaultFiles() {
            RecentPinItem item1 = new RecentPinItem() { Caption = "Windows 10 GuideLines.doc", Description = "D:\\Personal\\Saved HTML Articles" };
            recentTabItem1.TabPanel.Items.Add(item1);
            RecentPinItem item2 = new RecentPinItem() { Caption = "Web Site Usability.doc", Description = "C:\\Users\\Default\\Documents" };
            recentTabItem1.TabPanel.Items.Add(item2);
            RecentPinItem item3 = new RecentPinItem() { Caption = "Getting Started.pdf", Description = "C:\\Program Files x86\\DevExpress 15.2\\Tutorials" };
            recentTabItem1.TabPanel.Items.Add(item3);
            RecentPinItem item4 = new RecentPinItem() { Caption = "Office 2013 features.docx", Description = "C:\\DevExpress\\Products\\Win Forms" };
            recentTabItem1.TabPanel.Items.Add(item4);
            RecentPinItem item5 = new RecentPinItem() { Caption = "WinForms Webinar.pdf", Description = "C:\\DevExpress\\Webinars" };
            recentTabItem1.TabPanel.Items.Add(item5);
        }
        string GetFileName(object obj) {
            FileInfo fi = new FileInfo(obj.ToString());
            return fi.Name;
        }
        void recentControlOpen_ItemClick(object sender, RecentItemEventArgs e) {
            RecentPinItem recentItem = e.Item as RecentPinItem;
            if(recentItem != null) ribbonControl1.HideApplicationButtonContentControl();
            if(recentTabItem1.TabPanel.Items.Contains(e.Item) && recentItem != null) 
                OpenFileCore(recentItem.Description);
            else if(recentTabItem2.TabPanel.Items.Contains(e.Item)) {
                if(recentItem != null)
                    OpenFileFolder(recentItem.Description);
            }
        }
        private void OpenFileFolder(string p) {
            OpenFileDialog dlg = new OpenFileDialog();
            if(p!= string.Empty) dlg.InitialDirectory = p;
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf";
            dlg.Title = "Open";
            if(dlg.ShowDialog(this) == DialogResult.OK) {
                OpenFile(dlg.FileName);
            }
        }
        private void recentControlSave_ItemClick(object sender, RecentItemEventArgs e) {
            ribbonControl1.HideApplicationButtonContentControl();
            RecentPinItem recentItem = e.Item as RecentPinItem;
            if(recentTabItem3.TabPanel.Items.Contains(e.Item)) {
                if(recentItem != null)
                    SaveAs(recentItem.Description);
            }
        }
        private void recentControlExport_ItemClick(object sender, Ribbon.RecentItemEventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export";
            if(!(e.Item is RecentPinItem)) return;
            string caption = (e.Item as RecentPinItem).Caption;
            if(caption.Contains("PDF"))
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            else if(caption.Contains("HTML"))
                saveFileDialog.Filter = "HTML files (*.html)|*.html";
            else if(caption.Contains("MHT"))
                saveFileDialog.Filter = "MHT files (*.mht)|*.mht";
            else if(caption.Contains("RTF"))
                saveFileDialog.Filter = "RTF files (*.rtf)|*.rtf";
            else if(caption.Contains("XLS"))
                saveFileDialog.Filter = "XLS files (*.xls)|*.xls";
            else if(caption.Contains("XLSX"))
                saveFileDialog.Filter = "XLSX files (*.xls)|*.xls";
            else if(caption.Contains("CSV"))
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            else if(caption.Contains("Text File"))
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            else if(caption.Contains("Image"))
                saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|Jpeg files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png|Tiff files (*.tiff)|*.tiff|EMF files (*.emf)|.emf|WMF files (*.wmf)|*.wmf";
            saveFileDialog.Filter += "|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            if(saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            PrintingSystem ps = new PrintingSystem();
            Link link = new Link(ps);
            link.RtfReportHeader = CurrentRichTextBox.Rtf;//RtfText;
            link.CreateDocument();
            if(caption.Contains("PDF"))
                ps.ExportToPdf(saveFileDialog.FileName);
            else if(caption.Contains("HTML"))
                ps.ExportToHtml(saveFileDialog.FileName);
            else if(caption.Contains("MHT"))
                ps.ExportToMht(saveFileDialog.FileName);
            else if(caption.Contains("RTF"))
                ps.ExportToRtf(saveFileDialog.FileName);
            else if(caption.Contains("XLS"))
                ps.ExportToXls(saveFileDialog.FileName);
            else if(caption.Contains("XLSX"))
                ps.ExportToXlsx(saveFileDialog.FileName);
            else if(caption.Contains("CSV"))
                ps.ExportToCsv(saveFileDialog.FileName);
            else if(caption.Contains("Text File"))
                ps.ExportToText(saveFileDialog.FileName);
            else if(caption.Contains("Image")) {
                ImageFormat fmt = ImageFormat.Bmp;
                switch(saveFileDialog.FilterIndex) {
                    case 0: fmt = ImageFormat.Bmp; break;
                    case 1: fmt = ImageFormat.Gif; break;
                    case 2: fmt = ImageFormat.Jpeg; break;
                    case 3: fmt = ImageFormat.Png; break;
                    case 4: fmt = ImageFormat.Tiff; break;
                    case 5: fmt = ImageFormat.Emf; break;
                    case 6: fmt = ImageFormat.Wmf; break;
                }
                ps.ExportToImage(saveFileDialog.FileName, fmt);
            }
        }
        void OpenFileCore(string path) {
            ribbonControl1.DeactivateKeyboardNavigation();
            pmAppMain.HidePopup();
            this.Refresh();
            if(System.IO.File.Exists(path)) {
                OpenFile(path);
                backstageViewControl1.Ribbon.HideApplicationButtonContentControl();
            }
            else MessageBox.Show(string.Format("ItemClick {0}", path.ToString()));
        }
        void SaveMostRecentFiles(RecentItemCollection files, string fileName) {
            try {
                System.IO.StreamWriter sw = System.IO.File.CreateText(fileName);
                for(int i = 0; i < files.Count; i++) {
                    RecentPinItem pinItem = files[i] as RecentPinItem;
                    if(pinItem == null ) continue;
                    sw.WriteLine(string.Format("{0},{1}", pinItem.Description != string.Empty ? pinItem.Description : pinItem.Caption, pinItem.PinButtonChecked.ToString()));
                }
                sw.Close();
            }
            catch { }
        }
        void OnMRUFileLabelClicked(object sender, EventArgs e) {
            ribbonControl1.DeactivateKeyboardNavigation();
            pmAppMain.HidePopup();
            this.Refresh();
            OpenFile(sender.ToString());
        }

        #endregion

        private void ribbonControl1_ApplicationButtonDoubleClick(object sender, EventArgs e) {
            if(ribbonControl1.RibbonStyle == RibbonControlStyle.Office2007)
                this.Close();
        }

        private void barEditItem1_ItemPress(object sender, ItemClickEventArgs e) {
            System.Diagnostics.Process.Start("http://www.devexpress.com");
        }

        private void biStyle_EditValueChanged(object sender, EventArgs e) {
            RibbonControlStyle style = (RibbonControlStyle)biStyle.EditValue;
            ribbonControl1.RibbonStyle = style;
            if(style == RibbonControlStyle.Office2010 || style == RibbonControlStyle.MacOffice || style == RibbonControlStyle.Office2013 || style == RibbonControlStyle.TabletOffice || style == RibbonControlStyle.OfficeUniversal) {
                ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            }
            else {
                ribbonControl1.ApplicationButtonDropDownControl = pmAppMain;
            }
            if(style == RibbonControlStyle.TabletOffice || style == RibbonControlStyle.OfficeUniversal) {
                this.barToggleSwitchItem1.Visibility = BarItemVisibility.Always;
            }
            else {
                this.barToggleSwitchItem1.Visibility = BarItemVisibility.Never;
            }
            UpdateLookAndFeel();
        }
        void UpdateLookAndFeel() {
            string skinName;
            RibbonControlStyle style = ribbonControl1.RibbonStyle;
            switch(style) {
                case RibbonControlStyle.Default:
                case RibbonControlStyle.Office2007:
                    skinName = "Office 2007 Blue";
                    break;
                case RibbonControlStyle.Office2013:
                case RibbonControlStyle.TabletOffice:
                case RibbonControlStyle.OfficeUniversal:
                    skinName = "Office 2013";
                    break;
                case RibbonControlStyle.Office2010:
                case RibbonControlStyle.MacOffice:
                default:
                    skinName = "Office 2010 Blue";
                    break;
            }
            UserLookAndFeel.Default.SetSkinStyle(skinName);
        }
        private void sbExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void beiFontSize_EditValueChanged(object sender, EventArgs e) {
            if(CurrentRichTextBox == null) return;
            Font font = CurrentRichTextBox.SelectionFont;
            if(font == null) {
                font = AppearanceObject.DefaultFont;
            }
            CurrentRichTextBox.SelectionFont = new Font(font.FontFamily, Convert.ToSingle(beiFontSize.EditValue), font.Style);
        }

        private void bvTabPrint_SelectedChanged(object sender, BackstageViewItemEventArgs e) {
            if(e.Item == bvTabPrint) {
                InitPrintingSystem();
                //this.printControl2.RTF = CurrentRichTextBox != null ? CurrentRichTextBox.Rtf : "";
            }
        }

        private void ribbonControl1_BeforeApplicationButtonContentControlShow(object sender, EventArgs e) {
            InitPrintingSystem();
            //this.printControl2.RtfText = CurrentRichTextBox == null ? "" : CurrentRichTextBox.Rtf;
            //this.exportControl1.RtfText = CurrentRichTextBox == null ? "" : CurrentRichTextBox.Rtf;
        }

        private void bvItemSave_ItemClick(object sender, BackstageViewItemEventArgs e) {
            Save();
        }

        private void bvItemSaveAs_ItemClick(object sender, BackstageViewItemEventArgs e) {
            SaveAs();
        }

        private void bvItemOpen_ItemClick(object sender, BackstageViewItemEventArgs e) {
            OpenFile();
        }

        private void bvItemClose_ItemClick(object sender, BackstageViewItemEventArgs e) {
            if(xtraTabbedMdiManager1.SelectedPage != null)
                xtraTabbedMdiManager1.SelectedPage.MdiChild.Close();
        }

        private void bvItemExit_ItemClick(object sender, BackstageViewItemEventArgs e) {
            Close();
        }
        private void beScheme_EditValueChanged(object sender, EventArgs e) {
            ribbonControl1.ColorScheme = ((RibbonControlColorScheme)beScheme.EditValue);
        }
        void ribbonControl1_ResetLayout(object sender, ResetLayoutEventArgs e) {
            ShowHideFormatCategory();
        }
        void OnNewDocThumbButtonClick(object sender, ThumbButtonClickEventArgs e) {
            CreateNewDocument();
        }
        void OnPrevThumbButtonClick(object sender, ThumbButtonClickEventArgs e) {
            Form mdiChild = GetPrevMdiChild();
            if(mdiChild != null)
                ActivateMdiChild(mdiChild);
        }
        void OnNextDocThumbButtonClick(object sender, ThumbButtonClickEventArgs e) {
            Form mdiChild = GetNextMdiChild();
            if(mdiChild != null)
                ActivateMdiChild(mdiChild);
        }
        void OnExitThumbButtonClick(object sender, ThumbButtonClickEventArgs e) {
            Close();
        }
        Form GetNextMdiChild() {
            if(ActiveMdiChild == null || MdiChildren.Length < 2)
                return null;
            int pos = Array.IndexOf(MdiChildren, ActiveMdiChild);
            return pos == MdiChildren.Length - 1 ? MdiChildren[0] : MdiChildren[pos + 1];
        }
        Form GetPrevMdiChild() {
            if(ActiveMdiChild == null || MdiChildren.Length < 2)
                return null;
            int pos = Array.IndexOf(MdiChildren, ActiveMdiChild);
            return pos == 0 ? MdiChildren[MdiChildren.Length - 1] : MdiChildren[pos - 1];
        }
        void OnTabbedMdiManagerPageCollectionChanged(object sender, XtraTabbedMdi.MdiTabPageEventArgs e) {
            UpdateThumbnailButtons();
        }
        void UpdateThumbnailButtons() {
            thumbButtonNext.Enabled = thumbButtonPrev.Enabled = MdiChildren.Length > 1;
        }

        private void bbColorMix_ItemClick(object sender, ItemClickEventArgs e) {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }
        
        #region Print processing
        void InitPrintingSystem() {
            RibbonForm frm = FindForm() as RibbonForm;
            BarManager manager = ribbonControl1.Manager;
            ((GalleryDropDown)this.ddbOrientation.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbMargins.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPaperSize.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbCollate.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPrinter.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbDuplex.DropDownControl).Manager = manager;
            PrintingSystem ps = new PrintingSystem();
            this.printControl2.PrintingSystem = ps;
            ps.StartPrint += new PrintDocumentEventHandler(OnStartPrint);
            Link link = new Link(ps);
            if(CurrentRichTextBox != null)
                link.RtfReportHeader = CurrentRichTextBox.Rtf;
            link.CreateDocument();
            this.printButton.Enabled = ps.Pages.Count > 0;
            this.pageButtonEdit.Enabled = ps.Pages.Count > 0;
            this.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of " + ps.Pages.Count;
            this.pageButtonEdit.EditValue = 1;
            UpdatePrintPageSettings();
        }
        void printButton_Click(object sender, EventArgs e) {
            ((PrintingSystem)this.printControl2.PrintingSystem).Print(this.ddbPrinter.Text);
        }
        void OnStartPrint(object sender, PrintDocumentEventArgs e) {
            e.PrintDocument.PrinterSettings.Copies = (short)this.copySpinEdit.Value;
            Padding p = (Padding)this.ddbMargins.Tag;
            this.printControl2.PrintingSystem.PageSettings.TopMargin = (int)(p.Top * 3.9);
            this.printControl2.PrintingSystem.PageSettings.BottomMargin = (int)(p.Bottom * 3.9);
            this.printControl2.PrintingSystem.PageSettings.LeftMargin = (int)(p.Left * 3.9);
            this.printControl2.PrintingSystem.PageSettings.RightMargin = (int)(p.Right * 3.9);
            e.PrintDocument.PrinterSettings.Collate = (bool)this.ddbCollate.Tag;
            e.PrintDocument.PrinterSettings.Duplex = ((bool)this.ddbDuplex.Tag) ? Duplex.Horizontal : Duplex.Simplex;
        }
        void InitPrint() {
            this.ddbOrientation.DropDownControl = CreateOrientationGallery();
            this.ddbMargins.DropDownControl = CreateMarginsGallery();
            this.ddbPaperSize.DropDownControl = CreatePageSizeGallery();
            this.ddbCollate.DropDownControl = CreateCollateGallery();
            this.ddbPrinter.DropDownControl = CreatePrintersGallery();
            this.ddbDuplex.DropDownControl = CreateDuplexGallery();
        }
        GalleryDropDown CreateListBoxGallery() {
            GalleryDropDown res = new GalleryDropDown();
            res.Gallery.FixedImageSize = false;
            res.Gallery.ShowItemText = true;
            res.Gallery.ColumnCount = 1;
            res.Gallery.CheckDrawMode = CheckDrawMode.OnlyImage;
            res.Gallery.ShowGroupCaption = false;
            res.Gallery.AutoSize = GallerySizeMode.Vertical;
            res.Gallery.SizeMode = GallerySizeMode.None;
            res.Gallery.ShowScrollBar = ShowScrollBar.Hide;
            res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio;
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            res.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            res.Gallery.Groups.Add(new GalleryItemGroup());
            res.Gallery.StretchItems = true;

            return res;
        }
        GalleryDropDown CreateOrientationGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem portraitItem = new GalleryItem();
            portraitItem.Image = Properties.Resources.PageOrientationPortrait;
            portraitItem.Caption = "Portrait Orientation";
            GalleryItem landscapeItem = new GalleryItem();
            landscapeItem.Image = Properties.Resources.PageOrientationLandscape;
            landscapeItem.Caption = "Landscape Orientation";
            res.Gallery.Groups[0].Items.Add(portraitItem);
            res.Gallery.Groups[0].Items.Add(landscapeItem);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnOrientationGalleryItemCheckedChanged);
            portraitItem.Checked = true;
            return res;
        }
        GalleryDropDown CreateMarginsGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem normal = new GalleryItem();
            normal.Image = Properties.Resources.PageMarginsNormal;
            normal.Caption = "Normal";
            normal.Description = "Top:\t25 mm\tBottom:\t25 mm\nLeft:\t25 mm\tRight:\t25 mm";
            normal.Tag = new Padding(25, 25, 25, 25);
            GalleryItem narrow = new GalleryItem();
            narrow.Image = Properties.Resources.PageMarginsNarrow;
            narrow.Caption = "Narrow";
            narrow.Description = "Top:\t12 mm\tBottom:\t12 mm\nLeft:\t12 mm\tRight:\t12 mm";
            narrow.Tag = new Padding(12, 12, 12, 12);
            GalleryItem moderate = new GalleryItem();
            moderate.Image = Properties.Resources.PageMarginsModerate;
            moderate.Caption = "Moderate";
            moderate.Description = "Top:\t25 mm\tBottom:\t25 mm\nLeft:\t19 mm\tRight:\t19 mm";
            moderate.Tag = new Padding(19, 25, 19, 25);
            GalleryItem wide = new GalleryItem();
            wide.Image = Properties.Resources.PageMarginsWide;
            wide.Caption = "Wide";
            wide.Description = "Top:\t25 mm\tBottom:\t25 mm\nLeft:\t50 mm\tRight:\t50 mm";
            wide.Tag = new Padding(50, 25, 50, 25);
            res.Gallery.Groups[0].Items.Add(normal);
            res.Gallery.Groups[0].Items.Add(narrow);
            res.Gallery.Groups[0].Items.Add(moderate);
            res.Gallery.Groups[0].Items.Add(wide);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnMarginsGalleryItemCheckedChanged);
            normal.Checked = true;
            return res;
        }
        GalleryDropDown CreatePageSizeGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem letter = new GalleryItem();
            letter.Image = Properties.Resources.PaperKind_Letter;
            letter.Caption = "Letter";
            letter.Description = "215 mm x 279 mm";
            letter.Tag = PaperKind.Letter;
            GalleryItem tabloid = new GalleryItem();
            tabloid.Image = Properties.Resources.PaperKind_Tabloid;
            tabloid.Caption = "Tabloid";
            tabloid.Description = "279 mm x 431 mm";
            tabloid.Tag = PaperKind.Tabloid;
            GalleryItem legal = new GalleryItem();
            legal.Image = Properties.Resources.PaperKind_Legal;
            legal.Caption = "Legal";
            legal.Description = "215 mm x 355 mm";
            legal.Tag = PaperKind.Legal;
            GalleryItem executive = new GalleryItem();
            executive.Image = Properties.Resources.PaperKind_Executive;
            executive.Caption = "Executive";
            executive.Description = "184 mm x 266 mm";
            executive.Tag = PaperKind.Executive;
            GalleryItem a3 = new GalleryItem();
            a3.Image = Properties.Resources.PaperKind_A3;
            a3.Caption = "A3";
            a3.Description = "296 mm x 420 mm";
            a3.Tag = PaperKind.A3;
            GalleryItem a4 = new GalleryItem();
            a4.Image = Properties.Resources.PaperKind_A4;
            a4.Caption = "A4";
            a4.Description = "210 mm x 296 mm";
            a4.Tag = PaperKind.A4;
            GalleryItem a5 = new GalleryItem();
            a5.Image = Properties.Resources.PaperKind_A5;
            a5.Caption = "A5";
            a5.Description = "148 mm x 210 mm";
            a5.Tag = PaperKind.A5;
            GalleryItem a6 = new GalleryItem();
            a6.Image = Properties.Resources.PaperKind_A6;
            a6.Caption = "A6";
            a6.Description = "105 mm x 148 mm";
            a6.Tag = PaperKind.A6;
            res.Gallery.Groups[0].Items.Add(letter);
            res.Gallery.Groups[0].Items.Add(tabloid);
            res.Gallery.Groups[0].Items.Add(legal);
            res.Gallery.Groups[0].Items.Add(executive);
            res.Gallery.Groups[0].Items.Add(a3);
            res.Gallery.Groups[0].Items.Add(a4);
            res.Gallery.Groups[0].Items.Add(a5);
            res.Gallery.Groups[0].Items.Add(a6);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnPaperSizeGalleryItemCheckedChanged);
            a4.Checked = true;
            return res;
        }
        GalleryDropDown CreateCollateGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem collated = new GalleryItem();
            collated.Image = Properties.Resources.MultiplePagesLarge;
            collated.Caption = "Collated";
            collated.Description = "1,2,3   1,2,3  1,2,3";
            collated.Tag = true;
            GalleryItem uncollated = new GalleryItem();
            uncollated.Image = Properties.Resources.MultiplePagesLarge;
            uncollated.Caption = "Uncollated";
            uncollated.Description = "1,1,1  2,2,2  3,3,3";
            uncollated.Tag = false;
            res.Gallery.Groups[0].Items.Add(collated);
            res.Gallery.Groups[0].Items.Add(uncollated);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnCollateGalleryItemCheckedChanged);
            collated.Checked = true;
            return res;
        }
        GalleryDropDown CreateDuplexGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            GalleryItem oneSided = new GalleryItem();
            oneSided.Image = Properties.Resources.MultiplePagesLarge;
            oneSided.Caption = "Print One Sided";
            oneSided.Description = "Only print on one side of the page";
            oneSided.Tag = false;
            GalleryItem twoSided = new GalleryItem();
            twoSided.Image = Properties.Resources.MultiplePagesLarge;
            twoSided.Caption = "Manually Print on Both Sides";
            twoSided.Description = "Reload paper when prompted to print the second side";
            twoSided.Tag = false;
            res.Gallery.Groups[0].Items.Add(oneSided);
            res.Gallery.Groups[0].Items.Add(twoSided);
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnDuplexGalleryItemCheckedChanged);
            oneSided.Checked = true;
            return res;
        }
        void OnDuplexGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdatePrintPageDuplex(e.Item);
        }
        GalleryDropDown CreatePrintersGallery() {
            GalleryDropDown res = CreateListBoxGallery();
            PrinterSettings ps = new PrinterSettings();
            GalleryItem defaultPrinter = null;
            try {
                foreach(string str in PrinterSettings.InstalledPrinters) {
                    GalleryItem item = new GalleryItem();
                    item.Image = Properties.Resources.PrintDirectLarge;
                    item.Caption = str;
                    res.Gallery.Groups[0].Items.Add(item);
                    ps.PrinterName = str;
                    if(ps.IsDefaultPrinter)
                        defaultPrinter = item;
                }
            }
            catch { }
            res.Gallery.ItemCheckedChanged += new GalleryItemEventHandler(OnPrinterGalleryItemCheckedChanged);
            if(defaultPrinter != null)
                defaultPrinter.Checked = true;
            return res;
        }
        void OnMarginsGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdatePrintPageMargins(e.Item);
        }
        void OnPrinterGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdatePrintPagePrinters(e.Item);
        }
        void OnCollateGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdatePrintPageCollate(e.Item);
        }
        void OnPaperSizeGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdatePrintPageSize(e.Item);
        }
        void OnOrientationGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdatePrintPageOrientation(e.Item);
        }
        public void UpdatePrintPageSettings() {
            if(ddbOrientation.DropDownControl != null) {
                UpdatePrintPageOrientation(((GalleryDropDown)ddbOrientation.DropDownControl).Gallery.GetCheckedItem());
            }
            if(ddbMargins.DropDownControl != null) {
                UpdatePrintPageMargins(((GalleryDropDown)ddbMargins.DropDownControl).Gallery.GetCheckedItem());
            }
            if(ddbPaperSize.DropDownControl != null) {
                UpdatePrintPageSize(((GalleryDropDown)ddbPaperSize.DropDownControl).Gallery.GetCheckedItem());
            }
            if(ddbCollate.DropDownControl != null) {
                UpdatePrintPageCollate(((GalleryDropDown)ddbCollate.DropDownControl).Gallery.GetCheckedItem());
            }
            if(ddbPrinter.DropDownControl != null) {
                UpdatePrintPagePrinters(((GalleryDropDown)ddbPrinter.DropDownControl).Gallery.GetCheckedItem());
            }
            if(ddbDuplex.DropDownControl != null) {
                UpdatePrintPageDuplex(((GalleryDropDown)ddbDuplex.DropDownControl).Gallery.GetCheckedItem());
            }
        }
        void UpdatePrintPageOrientation(GalleryItem item) {
            if(item == null) return;
            ddbOrientation.Text = item.Caption;
            ddbOrientation.Image = item.Image;
            if(ddbOrientation.DropDownControl != null) {
                this.printControl2.PrintingSystem.PageSettings.Landscape = ((GalleryDropDown)ddbOrientation.DropDownControl).Gallery.Groups[0].Items[1].Checked;
            }
        }
        void UpdatePrintPageMargins(GalleryItem item) {
            if(item == null) return;
            this.ddbMargins.Image = item.Image;
            this.ddbMargins.Text = item.Caption;
            this.ddbMargins.Tag = item.Tag;
            Padding p = (Padding)item.Tag;
            if(this.printControl2.PrintingSystem != null) {
                this.printControl2.PrintingSystem.PageSettings.TopMargin = (int)(p.Top * 3.9);
                this.printControl2.PrintingSystem.PageSettings.BottomMargin = (int)(p.Bottom * 3.9);
                this.printControl2.PrintingSystem.PageSettings.LeftMargin = (int)(p.Left * 3.9);
                this.printControl2.PrintingSystem.PageSettings.RightMargin = (int)(p.Right * 3.9);
            }
        }
        void UpdatePrintPageSize(GalleryItem item) {
            if(item == null) return;
            this.ddbPaperSize.Image = item.Image;
            this.ddbPaperSize.Text = item.Caption;
            if(this.printControl2.PrintingSystem != null) {
                this.printControl2.PrintingSystem.PageSettings.PaperKind = (PaperKind)item.Tag;
            }
        }
        void UpdatePrintPageCollate(GalleryItem item) {
            if(item == null) return;
            this.ddbCollate.Image = item.Image;
            this.ddbCollate.Text = item.Caption;
            this.ddbCollate.Tag = item.Tag;
        }
        void UpdatePrintPagePrinters(GalleryItem item) {
            if(item == null) return;
            this.ddbPrinter.Text = item.Caption;
            this.ddbPrinter.Image = item.Image;
        }

        void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            if(updatedZoom) return;
            updatedZoom = true;
            try {
                zoomTextEdit.EditValue = GetZoomValue();
            } finally {
                updatedZoom = false;
            }
        }
        int GetZoomValue() {
            if(zoomTrackBarControl1.Value <= 40)
                return 10 + 90 * (zoomTrackBarControl1.Value - 0) / 40;
            else
                return 100 + 400 * (zoomTrackBarControl1.Value - 40) / 40;
        }
        bool updatedZoom = false;

        void zoomTextEdit_EditValueChanged(object sender, EventArgs e) {
            try {
                int zoomValue = Int32.Parse((string)zoomTextEdit.EditValue.ToString());
                this.zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue);
                this.printControl2.Zoom = 0.01f * (int)zoomValue;
            } catch(Exception) { }
        }
        int ZoomValueToValue(int zoomValue) {
            if(zoomValue < 100)
                return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 / 90));
            return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 / 400 + 40));
        }

        void pageButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e) {
            int pageIndex = (int)this.pageButtonEdit.EditValue;
            if(e.Button.Kind == ButtonPredefines.Left) {
                if(pageIndex > 1)
                    pageIndex--;
            } else if(e.Button.Kind == ButtonPredefines.Right) {
                if(pageIndex < this.printControl2.PrintingSystem.Pages.Count)
                    pageIndex++;
            }
            this.pageButtonEdit.EditValue = pageIndex;
        }

        void pageButtonEdit_EditValueChanging(object sender, ChangingEventArgs e) {
            try {
                int pageIndex = Int32.Parse(e.NewValue.ToString());
                if(pageIndex < 1)
                    pageIndex = 1;
                else if(pageIndex > this.printControl2.PrintingSystem.Pages.Count)
                    pageIndex = this.printControl2.PrintingSystem.Pages.Count;
                e.NewValue = pageIndex;
            } catch(Exception) {
                e.NewValue = 1;
            }
        }

        void UpdatePageButtonsEnabledState(int pageIndex) {
            this.pageButtonEdit.Properties.Buttons[0].Enabled = pageIndex != 1;
            this.pageButtonEdit.Properties.Buttons[1].Enabled = pageIndex != this.printControl2.PrintingSystem.Pages.Count;
        }

        void pageButtonEdit_EditValueChanged(object sender, EventArgs e) {
            int pageIndex = (int)this.pageButtonEdit.EditValue;
            this.printControl2.SelectedPageIndex = pageIndex - 1;
            UpdatePageButtonsEnabledState(pageIndex);
        }

        void printControl2_SelectedPageChanged(object sender, EventArgs e) {
            this.pageButtonEdit.EditValue = this.printControl2.SelectedPageIndex + 1;
        }

        void UpdatePrintPageDuplex(GalleryItem item) {
            if(item == null) return;
            this.ddbDuplex.Text = item.Caption;
            this.ddbDuplex.Image = item.Image;
            this.ddbDuplex.Tag = item.Tag;
        }
        #endregion
    }

    public class RibbonSimplePadSplashScreen : DemoSplashScreen {
        public RibbonSimplePadSplashScreen() {
            DemoText = "RibbonSimplePad";
            ProductText = "The XtraBars Suite";
        }
    }
}
