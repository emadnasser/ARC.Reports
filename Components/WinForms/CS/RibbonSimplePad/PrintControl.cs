using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using System.Drawing.Printing;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Menu;
using System.Collections;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public partial class PrintControl : RibbonApplicationUserControl {
        public PrintControl() {
            InitializeComponent();
            splitContainer1.Panel1MinSize = layoutControlGroup1.MinSize.Width + 6;
            this.ddbOrientation.DropDownControl = CreateOrientationGallery();
            this.ddbMargins.DropDownControl = CreateMarginsGallery();
            this.ddbPaperSize.DropDownControl = CreatePageSizeGallery();
            this.ddbCollate.DropDownControl = CreateCollateGallery();
            this.ddbPrinter.DropDownControl = CreatePrintersGallery();
            this.ddbDuplex.DropDownControl = CreateDuplexGallery();
        }
        int GetZoomValue() {
            if(zoomTrackBarControl1.Value <= 40)
                return 10 + 90 * (zoomTrackBarControl1.Value - 0) / 40;
            else
                return 100 + 400 * (zoomTrackBarControl1.Value - 40) / 40;
        }
        int ZoomValueToValue(int zoomValue) {
            if(zoomValue < 100)
                return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 / 90));
            return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 / 400 + 40));
        }
        string rtfText;
        public string RtfText {
            get { return rtfText; }
            set { 
                rtfText = value;
                InitPrintingSystem();
            }
        }
        bool updatedZoom = false;
        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            if(updatedZoom) return;
            updatedZoom = true;
            try {
                zoomTextEdit.EditValue = GetZoomValue();
            }
            finally {
                updatedZoom = false;
            }
        }
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(Visible) {
                InitPrintingSystem();
            }
        }
        private void InitPrintingSystem() {
            RibbonForm frm = FindForm() as RibbonForm;
            BarManager manager = GetManager();
            ((GalleryDropDown)this.ddbOrientation.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbMargins.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPaperSize.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbCollate.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbPrinter.DropDownControl).Manager = manager;
            ((GalleryDropDown)this.ddbDuplex.DropDownControl).Manager = manager;
            PrintingSystem ps = new PrintingSystem();
            this.printControl1.PrintingSystem = ps;
            ps.StartPrint += new PrintDocumentEventHandler(OnStartPrint);
            Link link = new Link(ps);
            link.RtfReportHeader = RtfText;
            link.CreateDocument();
            this.printButton.Enabled = ps.Pages.Count > 0;
            this.pageButtonEdit.Enabled = ps.Pages.Count > 0;
            this.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of " + ps.Pages.Count;
            this.pageButtonEdit.EditValue = 1;
            UpdatePrintPageSettings();
        }
        BarManager GetManager() {
            BackstageViewControl bsvc = FindControl(this, typeof(BackstageViewControl)) as BackstageViewControl;
            if(bsvc == null || bsvc.Ribbon == null)
                return null;
            return bsvc.Ribbon.Manager;
        }
        Control FindControl(Control control, Type target) {
            Control current = control;
            while(current != null) {
                if(current.GetType() == target)
                    return current;
                current = current.Parent;
            }
            return null;
        }
        void OnStartPrint(object sender, PrintDocumentEventArgs e) {
            e.PrintDocument.PrinterSettings.Copies = (short)this.copySpinEdit.Value;
            Padding p = (Padding)this.ddbMargins.Tag;
            this.printControl1.PrintingSystem.PageSettings.TopMargin = (int)(p.Top * 3.9);
            this.printControl1.PrintingSystem.PageSettings.BottomMargin = (int)(p.Bottom * 3.9);
            this.printControl1.PrintingSystem.PageSettings.LeftMargin = (int)(p.Left * 3.9);
            this.printControl1.PrintingSystem.PageSettings.RightMargin = (int)(p.Right * 3.9);
            e.PrintDocument.PrinterSettings.Collate = (bool)this.ddbCollate.Tag;
            e.PrintDocument.PrinterSettings.Duplex = ((bool)this.ddbDuplex.Tag)? Duplex.Horizontal: Duplex.Simplex;
        }
        private void zoomTextEdit_EditValueChanged(object sender, EventArgs e) {
            try {
                int zoomValue = Int32.Parse((string)zoomTextEdit.EditValue.ToString());
                this.zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue);
                this.printControl1.Zoom = 0.01f * (int)zoomValue;
            }
            catch(Exception) { }
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
            } catch { }
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
                this.printControl1.PrintingSystem.PageSettings.Landscape = ((GalleryDropDown)ddbOrientation.DropDownControl).Gallery.Groups[0].Items[1].Checked;
            }
        }
		void UpdatePrintPageMargins(GalleryItem item) {
            if(item == null) return;
            this.ddbMargins.Image = item.Image;
            this.ddbMargins.Text = item.Caption;
            this.ddbMargins.Tag = item.Tag;
            Padding p = (Padding)item.Tag;
            if(this.printControl1.PrintingSystem != null) {
                this.printControl1.PrintingSystem.PageSettings.TopMargin = (int)(p.Top * 3.9);
                this.printControl1.PrintingSystem.PageSettings.BottomMargin = (int)(p.Bottom * 3.9);
                this.printControl1.PrintingSystem.PageSettings.LeftMargin = (int)(p.Left * 3.9);
                this.printControl1.PrintingSystem.PageSettings.RightMargin = (int)(p.Right * 3.9);
            }
        }
        void UpdatePrintPageSize(GalleryItem item) {
            if(item == null) return;
            this.ddbPaperSize.Image = item.Image;
            this.ddbPaperSize.Text = item.Caption;
            if(this.printControl1.PrintingSystem != null) {
                this.printControl1.PrintingSystem.PageSettings.PaperKind = (PaperKind)item.Tag;
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
        void UpdatePrintPageDuplex(GalleryItem item) {
            if(item == null) return;
            this.ddbDuplex.Text = item.Caption;
            this.ddbDuplex.Image = item.Image;
            this.ddbDuplex.Tag = item.Tag;
        }

        private void printButton_Click(object sender, EventArgs e) {
            ((PrintingSystem)this.printControl1.PrintingSystem).Print(this.ddbPrinter.Text);
        }

        private void pageButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            int pageIndex = (int)this.pageButtonEdit.EditValue;
            if(e.Button.Kind == ButtonPredefines.Left) {
                if(pageIndex > 1)
                    pageIndex--;
            }
            else if(e.Button.Kind == ButtonPredefines.Right) {
                if(pageIndex < this.printControl1.PrintingSystem.Pages.Count)
                    pageIndex ++;
            }
            this.pageButtonEdit.EditValue = pageIndex;
        }

        private void pageButtonEdit_EditValueChanging(object sender, ChangingEventArgs e) {
            try {
                int pageIndex = Int32.Parse(e.NewValue.ToString());
                if(pageIndex < 1)
                    pageIndex = 1;
                else if(pageIndex > this.printControl1.PrintingSystem.Pages.Count)
                    pageIndex = this.printControl1.PrintingSystem.Pages.Count;
                e.NewValue = pageIndex;
            }
            catch(Exception) {
                e.NewValue = 1;
            }
        }
        void UpdatePageButtonsEnabledState(int pageIndex) {
            this.pageButtonEdit.Properties.Buttons[0].Enabled = pageIndex != 1;
            this.pageButtonEdit.Properties.Buttons[1].Enabled = pageIndex != this.printControl1.PrintingSystem.Pages.Count;
        }
        private void pageButtonEdit_EditValueChanged(object sender, EventArgs e) {
            int pageIndex = (int)this.pageButtonEdit.EditValue;
            this.printControl1.SelectedPageIndex = pageIndex - 1;
            UpdatePageButtonsEnabledState(pageIndex);
        }

        private void printControl1_SelectedPageChanged(object sender, EventArgs e) {
            this.pageButtonEdit.EditValue = this.printControl1.SelectedPageIndex + 1;
        }
    }
}
