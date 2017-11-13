using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTabbedMdi;

namespace DevExpress.XtraBars.Demos.MDIDemo {
    /// <summary>
    /// Summary description for frmMain.
    /// </summary>
    public partial class frmMain : DevExpress.XtraEditors.XtraForm {
        public frmMain() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            colorEdit.EditValue = Color.Empty;
            ImageComboBoxItem[] piis = new ImageComboBoxItem[] {new ImageComboBoxItem("Clip", PictureSizeMode.Clip), new ImageComboBoxItem("Stretch", PictureSizeMode.Stretch), 
				new ImageComboBoxItem("Zoom", PictureSizeMode.Zoom), new ImageComboBoxItem("Squeeze", PictureSizeMode.Squeeze)};
            foreach(ImageComboBoxItem pii in piis)
                ((DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox)sizeMode.Edit).Items.Add(pii);
            InitBars();
            barManager1.GetController().Changed += new EventHandler(ChangedController);
            ips_Init();
            InitSkins();
            InitTabbedMDI();
            InitPictures();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitPictures() {
            CreateMDIPictureForm(Image.FromStream(typeof(frmMain).Assembly.GetManifestResourceStream("MDIDemo.Images.Audi_TT_Roadster.jpg")), "Audi TT.jpg", false);
            CreateMDIPictureForm(Image.FromStream(typeof(frmMain).Assembly.GetManifestResourceStream("MDIDemo.Images.BMW_760i_Sedan.jpg")), "BMW 760i.jpg", false);
        }

        const string imageFormName = "image";
        const string textFormName = "text";
        const string textRTFFormName = "rtf";
        Cursor currentCursor;
        string skinMask = "Skin: ";
        int oldActive = -2;
        int lockUpdate = 0;

        #region Skins

        void InitSkins() {
            barManager1.ForceInitialize();
            foreach(DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins) {
                BarButtonItem item = new BarButtonItem(barManager1, skinMask + cnt.SkinName);
                iPaintStyle.AddItem(item);
                item.ItemClick += new ItemClickEventHandler(OnSkinClick);
            }
        }
        void OnSkinClick(object sender, ItemClickEventArgs e) {
            string skinName = e.Item.Caption.Replace(skinMask, "");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);
            barManager1.GetController().PaintStyleName = "Skin";
            iPaintStyle.Caption = e.Item.Caption;
            iPaintStyle.Hint = iPaintStyle.Caption;
            iPaintStyle.ImageIndex = -1;
        }
        #endregion

        private void InitBars() {
            iDocName.Caption = (ActiveMDIForm != null) ? ActiveMDIForm.Tag.ToString() : " ";
            iFont.Enabled = IsActiveTextRTFForm;
            InitEdit();
            InitPicture();
            if(oldActive == NumActive) return;
            iClose.Enabled = mEdit.Enabled = ActiveMDIForm != null;
            iRotateBy90.Enabled = iHorizontalFlip.Enabled = iVerticalFlip.Enabled =
                iPictureAlignment.Enabled = sizeMode.Enabled = IsActiveImageForm;
            iSelectAll.Enabled = colorEdit.Enabled = IsActiveTextForm;

            for(int i = mEdit.ItemLinks.Count - 1; i >= 0; i--)
                mEdit.RemoveLink(mEdit.ItemLinks[i]);

            if(IsActiveImageForm) {
                iPicture.ImageIndex = 13;
                mEdit.AddItem(iHorizontalFlip);
                mEdit.AddItem(iVerticalFlip);
                mEdit.AddItem(iRotateBy90);
                mEdit.Caption = "Image &Edit";
            }
            if(IsActiveTextForm) {
                iPicture.ImageIndex = 14;
                mEdit.AddItem(iCut);
                mEdit.AddItem(iCopy);
                mEdit.AddItem(iPaste);
                mEdit.AddItem(iSelectAll).BeginGroup = true;
                mEdit.Caption = "Text &Edit";
            }

            if(ActiveMDIForm == null) {
                iPicture.ImageIndex = -1;
                mEdit.Caption = "&Edit";
            }

            oldActive = NumActive;
        }


        private void InitPicture() {
            lockUpdate++;
            if(ActivePictureEdit != null)
                sizeMode.EditValue = ActivePictureEdit.Properties.SizeMode;
            else sizeMode.EditValue = PictureSizeMode.Squeeze;
            lockUpdate--;
        }
        private void InitEdit() {
            RichTextBox rtb = ActiveRichTextBox;
            if(rtb != null) {
                iPaste.Enabled = rtb.CanPaste(DataFormats.GetFormat(0));
                iCut.Enabled = iCopy.Enabled = rtb.SelectedText != "";
                lockUpdate++;
                colorEdit.EditValue = rtb.SelectionColor;
                lockUpdate--;
            }
            else {
                iCut.Enabled = iCopy.Enabled = iPaste.Enabled = false;
            }
        }

        private void RefreshForm(bool b) {
            if(b) {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                Refresh();
            }
            else
                Cursor.Current = currentCursor;
        }

        private int NumActive {
            get {
                if(IsActiveTextForm) return 1;
                if(IsActiveImageForm) return 0;
                return -1;
            }
        }
        private Form ActiveMDIForm {
            get { return this.ActiveMdiChild; }
        }

        private bool GetIsImageForm(Form form) {
            return form != null && form.AccessibleName == imageFormName;
        }
        private bool IsActiveImageForm {
            get { return GetIsImageForm(ActiveMDIForm); }
        }

        private bool IsActiveTextForm {
            get { return (ActiveMDIForm != null && ActiveMDIForm.AccessibleName == textFormName); }
        }

        private bool IsActiveTextRTFForm {
            get { return (IsActiveTextForm && ActiveMDIForm.AccessibleDescription == textRTFFormName); }
        }

        private PictureEdit GetPictureEdit(Form form) {
            if(GetIsImageForm(form))
                return (PictureEdit)form.Controls[0];
            else
                return null;
        }
        private DevExpress.XtraEditors.PictureEdit ActivePictureEdit {
            get {
                return GetPictureEdit(ActiveMDIForm);
            }
        }

        private RichTextBox ActiveRichTextBox {
            get {
                if(IsActiveTextForm)
                    return (RichTextBox)ActiveMDIForm.Controls[0];
                return null;
            }
        }

        private void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png|Text Files |*.txt;*.rtf";
            dlg.Title = "Open";
            if(dlg.ShowDialog() == DialogResult.OK) {
                RefreshForm(true);
                switch(dlg.FilterIndex) {
                    case 2:
                        CreateMDITextForm(dlg.FileName);
                        break;
                    default:
                        Image img = null;
                        try {
                            img = Image.FromFile(dlg.FileName);
                        }
                        catch { }
                        if(img != null)
                            CreateMDIPictureForm(img, dlg.FileName, true);
                        else
                            MessageBox.Show("Wrong picture format...", "Error");
                        break;
                }
                RefreshForm(false);
            }
        }

        void UpdateMdiPictureFormPreview(XtraMdiTabPage page, Image img) {
            if(page == null)
                return;
            Image preview = null;
            const int previewHeight = 32;
            const int previewWidthMax = 64;
            //int previewHeight = this.imageList3.ImageSize.Height;
            if(img != null && img.Height > 0 && previewHeight > 0) {
                int previewWidth = previewHeight * img.Width / img.Height;
                if(previewWidth > 0) {
                    if(previewWidth > previewWidthMax)
                        previewWidth = previewWidthMax;
                    preview = new Bitmap(img, previewWidth, previewHeight);
                }
            }
            page.Image = preview;
        }

        private void CreateMDIPictureForm(Image img, string s, bool isFile) {
            Form frm = new XtraForm();
            frm.Text = isFile ? new System.IO.FileInfo(s).Name : s;
            frm.Tag = s;
            frm.AccessibleName = imageFormName;
            DevExpress.XtraEditors.PictureEdit pi = new DevExpress.XtraEditors.PictureEdit();
            pi.Dock = DockStyle.Fill;
            pi.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            pi.Properties.ShowMenu = false;
            pi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pi.Image = img;
            pi.MouseUp += new MouseEventHandler(ImageMouseUp);
            if(!IsTabbedMdi)
                frm.ClientSize = new Size(img.Width, img.Height);

            frm.Controls.Add(pi);
            frm.MdiParent = this;
            frm.Show();
        }

        private void RTBSelectionChanged(object sender, EventArgs e) {
            InitEdit();
        }

        private void RTBMouseUp(object sender, MouseEventArgs e) {
            if(IsActiveTextForm && sender.Equals(ActiveRichTextBox))
                if((e.Button & MouseButtons.Right) != 0 && ActiveMDIForm.ClientRectangle.Contains(e.X, e.Y))
                    popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void ImageMouseUp(object sender, MouseEventArgs e) {
            if(IsActiveImageForm && sender.Equals(ActivePictureEdit))
                if((e.Button & MouseButtons.Right) != 0 && ActiveMDIForm.ClientRectangle.Contains(e.X, e.Y))
                    popupMenu2.ShowPopup(Control.MousePosition);
        }

        private void CreateMDITextForm(string s) {
            Form frm = new XtraForm();
            frm.Text = new System.IO.FileInfo(s).Name;
            frm.Tag = s;
            frm.AccessibleName = textFormName;
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rtb.HideSelection = false;
            rtb.SelectionChanged += new EventHandler(RTBSelectionChanged);
            rtb.MouseUp += new MouseEventHandler(RTBMouseUp);
            try {
                rtb.LoadFile(s);
                frm.AccessibleDescription = textRTFFormName;
            }
            catch {
                rtb.LoadFile(s, RichTextBoxStreamType.PlainText);
            }

            frm.Controls.Add(rtb);
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_MdiChildActivate(object sender, System.EventArgs e) {
            InitBars();
        }

        private void iClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(ActiveMDIForm != null)
                ActiveMDIForm.Close();
        }

        private void FlipRotate(RotateFlipType type) {
            if(IsActiveImageForm) {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

                Image image = ActivePictureEdit.Image.Clone() as Image;
                image.RotateFlip(type);
                ActivePictureEdit.Image = image;

                UpdateMdiPictureFormPreview(this.xtraTabbedMdiManager1.SelectedPage, image);

                Cursor.Current = currentCursor;
            }
        }

        private void iHorizontalFlip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            FlipRotate(RotateFlipType.RotateNoneFlipX);
        }

        private void iVerticalFlip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            FlipRotate(RotateFlipType.RotateNoneFlipY);
        }

        private void iRotateBy90_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            FlipRotate(RotateFlipType.Rotate90FlipNone);
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }

        void PictureAlignmentChanged(object sender, EventArgs e) {
            if(ActivePictureEdit != null)
                ActivePictureEdit.Properties.PictureAlignment = alignmentControl1.Alignment;
        }

        void popupControlContainer1_Popup(object sender, System.EventArgs e) {
            if(ActivePictureEdit == null) return;
            alignmentControl1.Alignment = ActivePictureEdit.Properties.PictureAlignment;
        }

        private void iCascade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void iTileHorizontal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void iTileVertical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void iWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "http://www.devexpress.com";
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        private void iCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(ActiveRichTextBox != null)
                ActiveRichTextBox.Cut();
        }

        private void iCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(ActiveRichTextBox != null)
                ActiveRichTextBox.Copy();
        }

        private void iPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(ActiveRichTextBox != null)
                ActiveRichTextBox.Paste();
        }

        private void iSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(ActiveRichTextBox != null)
                ActiveRichTextBox.SelectAll();
        }

        private void iFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RichTextBox rtb = ActiveRichTextBox;
            if(rtb == null || !IsActiveTextRTFForm) return;
            FontDialog dlg = new FontDialog();
            dlg.Font = (Font)rtb.SelectionFont.Clone();
            dlg.ShowColor = true;
            dlg.Color = rtb.SelectionColor;
            if(dlg.ShowDialog() == DialogResult.OK) {
                rtb.SelectionFont = (Font)dlg.Font.Clone();
                rtb.SelectionColor = dlg.Color;
                InitEdit();
            }
        }

        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }

        private void colorEdit_EditValueChanged(object sender, System.EventArgs e) {
            RichTextBox rtb = ActiveRichTextBox;
            if(rtb == null || lockUpdate != 0) return;
            rtb.SelectionColor = (Color)colorEdit.EditValue;
        }

        private void sizeMode_EditValueChanged(object sender, System.EventArgs e) {
            if(ActivePictureEdit == null || lockUpdate != 0) return;
            ActivePictureEdit.Properties.SizeMode = (PictureSizeMode)sizeMode.EditValue;
        }

        private void ips_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            barManager1.GetController().PaintStyleName = e.Item.Description;
            InitPaintStyle(e.Item);
            barManager1.GetController().ResetStyleDefaults();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle();
        }

        private void InitPaintStyle(BarItem item) {
            if(item == null) return;
            iPaintStyle.ImageIndex = item.ImageIndex;
            iPaintStyle.Caption = item.Caption;
            iPaintStyle.Hint = item.Description;
        }

        private void ips_Init() {
            BarItem item = null;
            for(int i = 0; i < barManager1.Items.Count; i++)
                if(barManager1.Items[i].Description == barManager1.GetController().PaintStyleName)
                    item = barManager1.Items[i];
            InitPaintStyle(item);
        }

        private void ChangedController(object sender, EventArgs e) {
            string paintStyleName = barManager1.GetController().PaintStyleName;
            if("Office2000OfficeXPWindowsXP".IndexOf(paintStyleName) >= 0)
                barManager1.Images = imageList2;
            else barManager1.Images = imageList1;
        }

        bool IsTabbedMdi { get { return biTabbedMDI.Down; } }

        void InitTabbedMDI() {
            xtraTabbedMdiManager1.MdiParent = IsTabbedMdi ? this : null;
            iCascade.Visibility = iTileHorizontal.Visibility = iTileVertical.Visibility = IsTabbedMdi ? BarItemVisibility.Never : BarItemVisibility.Always;
        }

        private void biTabbedMDI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            InitTabbedMDI();
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e) {
            PictureEdit pictureEdit = GetPictureEdit(e.Page.MdiChild);
            Image image = (pictureEdit == null) ? null : pictureEdit.Image;
            UpdateMdiPictureFormPreview(e.Page, image);
        }
    }
}
