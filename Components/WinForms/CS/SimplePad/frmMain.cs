using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;

namespace DevExpress.XtraBars.Demos.SimplePad {
    public partial class frmMain : DevExpress.XtraEditors.XtraForm {
        frmFind dlgFind;
        frmReplace dlgReplace;
        bool modified;
        bool open;
        const string docNameDefault = "document1.rtf";
        string docName;
        Cursor currentCursor;
        ColorPopup cp;
        string skinMask = "Skin: ";
        bool skinProcessing = false;
        public frmMain() {
            InitializeComponent();
            InitOpen();
            this.rtPad.SelectionChanged += new System.EventHandler(this.rtPad_SelectionChanged);
            rtPadClear();
            iSave.Enabled = false;
            Modified = false;
            barManager1.GetController().Changed += new EventHandler(ChangedController);

            CreateColorPopup(popupControlContainer1);
            barManager1.GetController().AppearancesBar.SubMenu.Menu.Image = pictureBox1.Image;
            barManager1.GetController().AppearancesBar.SubMenu.SideStrip.BackColor = Color.FromArgb(90, SystemColors.Control);
            SetMenuBackColor();
            iNew_ItemClick(iNew, null);
            ips_Init();
            InitSkins();
            UserLookAndFeel.Default.StyleChanged += new EventHandler(delegate { SetMenuBackColor(); });
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("SimplePad.AppIcon.ico", typeof(frmMain).Assembly);
        }
        void SetMenuBackColor() {
            barManager1.GetController().AppearancesBar.SubMenu.Menu.BackColor = FrameHelper.IsDarkSkin(UserLookAndFeel.Default) ?
                Color.FromArgb(150, Color.Black) : Color.FromArgb(50, Color.White);
        }
        
        private void CreateColorPopup(PopupControlContainer container) {
            cp = new ColorPopup(container, iFontColor, rtPad);
        }
        #region Skins

        void InitSkins() {
            barManager1.ForceInitialize();
            if(barManager1.GetController().PaintStyleName == "Skin")
                iPaintStyle.Caption = skinMask + DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
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

        private FontStyle rtPadFontStyle() {
            FontStyle fs = new FontStyle();
            if(iBold.Down)
                fs |= FontStyle.Bold;
            if(iItalic.Down)
                fs |= FontStyle.Italic;
            if(iUnderline.Down)
                fs |= FontStyle.Underline;
            return fs;
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(e.Item.Category == barManager1.Categories["Format"])
                iUndo.Enabled = Modified;
        }

        private void iBullets_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.SelectionBullet = iBullets.Down;
        }

        protected string DocName {
            get { return docName; }
            set {
                if(value != docName) {
                    docName = value;
                    if(Open)
                        sDocName.Caption = docName;
                    else
                        sDocName.Caption = "";
                }
            }
        }

        protected bool Open {
            get { return open; }
            set {
                if(value != open) {
                    open = value;
                    InitOpen();
                    rtPad.HideSelection = !open;
                }
            }
        }

        protected bool Modified {
            get { return modified; }
            set {
                if(value != modified) {
                    modified = value;
                    iSave.Enabled = modified;
                    if(modified)
                        sModifier.Caption = "Modified";
                    else {
                        sModifier.Caption = " ";
                        iUndo.Enabled = false;
                    }
                }
            }
        }

        protected void InitOpen() {
            mEdit.Enabled = mFormat.Enabled = iSaveAs.Enabled = iClose.Enabled = iPrint.Enabled = Open;
            BarManagerCategory cat = barManager1.Categories["Edit"];
            foreach(BarItem item in barManager1.Items) {
                if(item.Category == cat)
                    item.Enabled = Open;
            }
            cat = barManager1.Categories["Format"];
            foreach(BarItem item in barManager1.Items) {
                if(item.Category == cat)
                    item.Enabled = Open;
            }
            iEdit.Enabled = rtPad.Enabled = Open;
            InitPaste();
        }

        protected void InitFormat() {
            iBold.Down = SelectFont.Bold;
            iItalic.Down = SelectFont.Italic;
            iUnderline.Down = SelectFont.Underline;
            iProtected.Down = rtPad.SelectionProtected;
            iBullets.Down = rtPad.SelectionBullet;
            switch(rtPad.SelectionAlignment) {
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

        protected void InitPaste() {
            iPaste.Enabled = rtPad.CanPaste(DataFormats.GetFormat(0)) && Open;
        }

        protected void InitEdit(bool b) {
            iCut.Enabled = b;
            iCopy.Enabled = b;
            iClear.Enabled = b;
            iUndo.Enabled = rtPad.CanUndo;
            iSelectAll.Enabled = rtPad.CanSelect;
        }

        private void rtPad_SelectionChanged(object sender, System.EventArgs e) {
            InitFormat();
            InitEdit(rtPad.SelectionLength > 0);
            int line = rtPad.GetLineFromCharIndex(rtPad.SelectionStart) + 1;
            int col = rtPad.SelectionStart + 1;

            sPosition.Caption = "Line: " + line.ToString() + "  Position: " + col.ToString();
        }

        private void iFontStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.SelectionFont = new Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle());
        }

        private void iProtected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.SelectionProtected = iProtected.Down;
        }

        private void iAlign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(iAlignLeft.Down)
                rtPad.SelectionAlignment = HorizontalAlignment.Left;
            if(iCenter.Down)
                rtPad.SelectionAlignment = HorizontalAlignment.Center;
            if(iAlignRight.Down)
                rtPad.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void iNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(SaveQuestion()) {
                Open = true;
                DocName = docNameDefault;
                rtPadClear();
                Modified = false;
                rtPad.SelectionLength = 0;
            }
        }

        private void iClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(SaveQuestion()) {
                DocName = " ";
                rtPadClear();
                Open = false;
                Modified = false;
            }
        }

        protected void rtPadClear() {
            RefreshForm(true);
            rtPad.SelectionBullet = false;
            rtPad.SelectionProtected = false;
            rtPad.Clear();
            rtPad.ClearUndo();
            iUndo.Enabled = false;
            rtPad.Focus();
            rtPad_SelectionChanged(null, null);
            RefreshForm(false);
        }

        protected Font SelectFont {
            get {
                if(rtPad.SelectionFont != null)
                    return rtPad.SelectionFont;
                return rtPad.Font;
            }
        }
        protected void RefreshForm(bool b) {
            if(b) {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                Refresh();
            }
            else {
                Cursor.Current = currentCursor;
            }
        }
        private void iOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(SaveQuestion()) {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Rich Text Files (*.rtf)|*.rtf";
                dlg.Title = "Open";
                if(dlg.ShowDialog() == DialogResult.OK) {
                    Open = true;
                    RefreshForm(true);
                    try {
                        rtPad.LoadFile(dlg.FileName);
                    }
                    catch(Exception) {
                        XtraMessageBox.Show("Sorry, this file cannot be opened.", "Simple Pad");
                        return;
                    }
                    DocName = dlg.FileName;
                    Modified = false;
                    RefreshForm(false);
                }
            }
        }

        private void iPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Note that you can use the XtraPrinting Library to print the contents of the standard RichTextBox control.\r\nFor more information, see the main XtraPrinting demo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rtPad_TextChanged(object sender, System.EventArgs e) {
            Modified = true;
        }

        private void iSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(DocName == docNameDefault) {
                iSaveAs_ItemClick(this, e);
            }
            else {
                if(Modified) {
                    RefreshForm(true);
                    rtPad.SaveFile(DocName, RichTextBoxStreamType.RichText);
                    Modified = false;
                    RefreshForm(false);
                }
            }
        }
        private void iSaveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf";
            dlg.Title = "Save As";
            if(dlg.ShowDialog() == DialogResult.OK) {
                RefreshForm(true);
                rtPad.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
                DocName = dlg.FileName;
                Modified = false;
                RefreshForm(false);
            }
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }

        private void iUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.Undo();
            Modified = rtPad.CanUndo;
            iUndo.Enabled = rtPad.CanUndo;
            InitFormat();
        }

        private void iCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.Cut();
            InitPaste();
        }

        private void iCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.Copy();
            InitPaste();
        }

        private void iPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.Paste();
        }

        private void iClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.SelectedRtf = "";
        }

        private void iSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.SelectAll();
        }

        private void iFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(dlgReplace != null) dlgReplace.Close();
            if(dlgFind != null) dlgFind.Close();
            dlgFind = new frmFind(rtPad, Bounds);
            AddOwnedForm(dlgFind);
            dlgFind.Show();
        }

        private void iReplace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(dlgReplace != null) dlgReplace.Close();
            if(dlgFind != null) dlgFind.Close();
            dlgReplace = new frmReplace(rtPad, Bounds);
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

        private void iFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            FontDialog dlg = new FontDialog();
            dlg.Font = (Font)SelectFont.Clone();
            dlg.ShowColor = true;
            dlg.Color = rtPad.SelectionColor;
            if(dlg.ShowDialog() == DialogResult.OK) {
                rtPad.SelectionFont = (Font)dlg.Font.Clone();
                rtPad.SelectionColor = dlg.Color;
            }
        }

        protected bool SaveQuestion() {
            if(Modified) {
                switch(DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save the changes you made to " + DocName + "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.Yes:
                        iSaveAs_ItemClick(null, null);
                        break;
                }
            }
            return true;
        }

        private void rtPad_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
            if((e.Button & MouseButtons.Right) != 0 && rtPad.ClientRectangle.Contains(e.X, e.Y))
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void iFontColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            rtPad.SelectionColor = cp.ResultColor;
        }

        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = !SaveQuestion();
        }

        private void frmMain_Activated(object sender, System.EventArgs e) {
            InitPaste();
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
            if(skinProcessing) return;
            string paintStyleName = barManager1.GetController().PaintStyleName;
            if("Office2000OfficeXPWindowsXP".IndexOf(paintStyleName) >= 0)
                barManager1.Images = imageList2;
            else barManager1.Images = imageList1;
            if("DefaultSkin".IndexOf(paintStyleName) >= 0)
                DevExpress.Skins.SkinManager.EnableFormSkins();
            else DevExpress.Skins.SkinManager.DisableFormSkins();
            skinProcessing = true;
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            skinProcessing = false;
        }

        private Rectangle CaptionTransform(Graphics g, Rectangle r) {
            g.RotateTransform(-90);
            r.X = r.X - r.Height + 5;
            r.Width = r.Height;
            return r;
        }

        private void item_PaintMenuBar(object sender, DevExpress.XtraBars.BarCustomDrawEventArgs e) {
            Rectangle r = e.Bounds;
            r.Inflate(1, 1);
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(r, Color.DarkBlue, Color.White, -90);
            e.Graphics.FillRectangle(brush, e.Bounds);
            r = CaptionTransform(e.Graphics, e.Bounds);
            Font f = new Font("Arial", 11, FontStyle.Bold);
            string caption = "XtraBars";
            e.Graphics.DrawString(caption, f, Brushes.Black, r);
            r.X -= 1; r.Y -= 1;
            e.Graphics.DrawString(caption, f, Brushes.White, r);
            e.Graphics.ResetTransform();
            e.Handled = true;
        }
    }
}
