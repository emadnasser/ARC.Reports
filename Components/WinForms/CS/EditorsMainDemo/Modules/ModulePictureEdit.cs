using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <comboBoxSizeMode>
using DevExpress.XtraEditors.Controls;
// </comboBoxSizeMode>
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevExpress.Utils;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModulePictureEdit : TutorialControl {
        public ModulePictureEdit() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModulePictureEdit.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.pictureEdit.xml";
            if(xtraTabControl1 != null)
                xtraTabControl1.SelectedPageChanged += OnSelectedPageChanged;
        }

        void OnSelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(xtraTabControl1 != null)
                xtraTabControl1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
            CalcLayoutControlBounds(layoutControl3);
        }

        bool updateValues = false;

        // <checkEditAllowMenu>
        private void checkEditAllowMenu_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            pictureEditSample.Properties.ShowMenu = checkEditAllowMenu.Checked;
        }
        // </checkEditAllowMenu>

        // <comboBoxSizeMode>
        private void comboBoxSizeMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            PictureSizeMode[] modes = new PictureSizeMode[] { 
				PictureSizeMode.Clip, 
				PictureSizeMode.Stretch, 
				PictureSizeMode.Zoom, 
				PictureSizeMode.StretchHorizontal, 
				PictureSizeMode.StretchVertical,
				PictureSizeMode.Squeeze};
            int selectedIndex = comboBoxSizeMode.SelectedIndex;
            pictureEditSample.Properties.SizeMode = modes[selectedIndex];
        }
        // </comboBoxSizeMode>

        // <comboBoxPictureAlignment>
        ContentAlignment[] aligns = new ContentAlignment[] { 
				ContentAlignment.TopLeft, 
				ContentAlignment.TopCenter, 
				ContentAlignment.TopRight, 
				ContentAlignment.MiddleLeft, 
				ContentAlignment.MiddleCenter, 
				ContentAlignment.MiddleRight, 
				ContentAlignment.BottomLeft, 
				ContentAlignment.BottomCenter, 
				ContentAlignment.BottomRight };
        private void comboBoxPictureAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            int selectedIndex = comboBoxPictureAlignment.SelectedIndex;
            pictureEditSample.Properties.PictureAlignment = aligns[selectedIndex];
        }
        // </comboBoxPictureAlignment>


        // <btnClearImage> <btnRestoreImage>
        Image savedImage = null;

        private void btnClearImage_Click(object sender, System.EventArgs e) {
            savedImage = pictureEditSample.Image;
            pictureEditSample.Image = null;
        }
        // </btnClearImage>

        private void btnRestoreImage_Click(object sender, System.EventArgs e) {
            if(pictureEditSample.Image == null)
                pictureEditSample.Image = savedImage;
        }
        // </btnRestoreImage>

        private void ModulePictureEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(pictureEditSample);
            foreach(InterpolationMode mode in Enum.GetValues(typeof(InterpolationMode))) 
                if(mode != InterpolationMode.Invalid)
                    icbInterpolationMode.Properties.Items.Add(new ImageComboBoxItem(mode.ToString(), mode, -1));
            icbShowZoomSubMenu.Properties.Items.AddEnum(typeof(DefaultBoolean));
            InitValues();
        }


        void InitValues() {
            updateValues = true;
            checkEditAllowMenu.Checked = pictureEditSample.Properties.ShowMenu;
            comboBoxSizeMode.EditValue = pictureEditSample.Properties.SizeMode.ToString();
            comboBoxPictureAlignment.EditValue = pictureEditSample.Properties.PictureAlignment.ToString();
            ceShowScrollBars.Checked = peScrollable.Properties.ShowScrollBars;
            ceAllowFocused.Checked = peScrollable.Properties.AllowFocused;
            cbAlignment.EditValue = peScrollable.Properties.PictureAlignment.ToString();
            seZoomPercent.Value = new decimal(peScrollable.Properties.ZoomPercent);
            ceAllowScroll.Checked = peScrollable.Properties.AllowScrollViaMouseDrag;
            icbInterpolationMode.EditValue = peScrollable.Properties.PictureInterpolationMode;
            icbShowZoomSubMenu.EditValue = peScrollable.Properties.ShowZoomSubMenu;
            ceShowCameraItem.Checked = peScrollable.Properties.ShowCameraMenuItem == CameraMenuItemVisibility.Always;
            updateValues = false;
            UpdateAllowScrollViaMouseDrag();
        }

        //<ceShowScrollBars>
        private void ceShowScrollBars_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            peScrollable.Properties.ShowScrollBars = ceShowScrollBars.Checked;
            UpdateAllowScrollViaMouseDrag();
        }
        //</ceShowScrollBars>
        void UpdateAllowScrollViaMouseDrag() {
            ceAllowScroll.Enabled = peScrollable.Properties.ShowScrollBars;
        }

        //<ceAllowFocused>
        private void ceAllowFocused_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.AllowFocused = ceAllowFocused.Checked;
        }
        //</ceAllowFocused>
        //<cbAlignment>
        private void cbAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            int selectedIndex = cbAlignment.SelectedIndex;
            peScrollable.Properties.PictureAlignment = aligns[selectedIndex];
        }
        //</cbAlignment>
        private void seZoomPercent_EditValueChanged(object sender, EventArgs e) {
            ztbZoomPercent.Value = (int)seZoomPercent.Value;
        }

        private void ztbZoomPercent_EditValueChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            seZoomPercent.Value = ztbZoomPercent.Value;
            peScrollable.Properties.ZoomPercent = ztbZoomPercent.Value;
        }
        //<ceAllowScroll>
        private void ceAllowScroll_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            peScrollable.Properties.AllowScrollViaMouseDrag = ceAllowScroll.Checked;
        }
        //</ceAllowScroll>
        //<icbInterpolationMode>
        private void icbInterpolationMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.PictureInterpolationMode = (InterpolationMode)icbInterpolationMode.EditValue;
        }

        private void peScrollable_ZoomPercentChanged(object sender, EventArgs e) {
            updateValues = true;
            try {
                seZoomPercent.Value = new decimal(peScrollable.Properties.ZoomPercent);
                ztbZoomPercent.Value = (int)peScrollable.Properties.ZoomPercent;
            } finally {
                updateValues = false;
            }
        }

        private void icbShowZoomSubMenu_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.ShowZoomSubMenu = (DefaultBoolean)icbShowZoomSubMenu.EditValue;
        }

        private void pictureEditSample_Properties_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            ContextItemClick(e);
        }

        private void peScrollable_Properties_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            ContextItemClick(e);
        }
        void ContextItemClick(ContextItemClickEventArgs e) {
            if(e.Item.Name == "itemDownload") {
                MessageBox.Show("'Download' item clicked");
            }
            else if(e.Item.Name == "itemRemove") {
                MessageBox.Show("'Remove' item clicked");
            }
            else if(e.Item.Name == "itemInfo") {
                MessageBox.Show("'Info' item clicked");
            }
        }

        private void ceShowCameraItem_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.ShowCameraMenuItem = ceShowCameraItem.Checked ? CameraMenuItemVisibility.Always : CameraMenuItemVisibility.Never;
        }
        private void pictureEditSample_Properties_ContextButtonValueChanged(object sender, ContextButtonValueEventArgs e) {
            if(e.Item.Name == "TrackBarContextButton") {
                pictureEditSample.Properties.ZoomPercent = Convert.ToDouble(e.Value);
            }
        }
        private void pictureEditSample_ZoomPercentChanged(object sender, EventArgs e) {
            (pictureEditSample.Properties.ContextButtons["TrackBarContextButton"] as TrackBarContextButton).Value = Convert.ToInt32(pictureEditSample.Properties.ZoomPercent);
        }

        private void OnMaskTypeChanged(object sender, EventArgs e) {
            switch(comboBoxEdit1.SelectedText) {
                case "Circle":
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Circle;
                    break;
                case "RoundedRect":
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.RoundedRect;
                    break;
                case "Custom":
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Custom;
                    break;
                default:
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.None;
                    break;
            }
            OnMaskTypeChanged(peMasked.Properties.OptionsMask.MaskType);
        }

        protected void OnMaskTypeChanged(PictureEditMaskType type) {
            comboBoxEdit2.Enabled = textEdit2.Enabled = textEdit1.Enabled = textEdit3.Enabled = (type != PictureEditMaskType.None);
            seRadius.Enabled = (type == PictureEditMaskType.RoundedRect);
            buttonEdit1.Enabled = (type == PictureEditMaskType.Custom);
        }
        protected int[] GetIntMassiveFromEditValue(object editValue) {
            if(editValue == null)
                return null;
            string[] vals = editValue.ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            int[] res = new int[vals.Length];
            for(int i = 0; i < vals.Length; i++) {
                res[i] = int.Parse(vals[i]);
            }
            return res;
        }
        private void OnMaskOffsetChanged(object sender, EventArgs e) {
            int[] val = GetIntMassiveFromEditValue(textEdit2.EditValue);
            if(val == null || val.Length != 2) return;
            this.peMasked.Properties.OptionsMask.Offset = new Point(val[0], val[1]);
        }
        private void OnMaskSizeChanged(object sender, EventArgs e) {
            int[] val = GetIntMassiveFromEditValue(textEdit1.EditValue);
            if(val == null || val.Length != 2) return;
            Size res = (val[0] <= 0 || val[1] <= 0) ? Size.Empty : new Size(val[0], val[1]);
            this.peMasked.Properties.OptionsMask.Size = res;
        }
        private void OnMaskMarginChanged(object sender, EventArgs e) {
            int[] val = GetIntMassiveFromEditValue(textEdit3.EditValue);
            if(val == null || val.Length != 4) return;
            this.peMasked.Properties.OptionsMask.Margin = new System.Windows.Forms.Padding(val[0], val[1], val[2], val[3]);
        }
        private void OnMaskRadiusChanged(object sender, EventArgs e) {
            this.peMasked.Properties.OptionsMask.RectCornerRadius = decimal.ToInt32(seRadius.Value);
        }
        private void OnMaskLayoutChanged(object sender, EventArgs e) {
            this.peMasked.Properties.OptionsMask.MaskLayoutMode = GetMaskLayoutType(this.comboBoxEdit2.SelectedIndex);
        }
        protected PictureEditMaskLayoutMode GetMaskLayoutType(int index) {
            switch(index){
                case 1: return PictureEditMaskLayoutMode.ZoomInside;
                case 2: return PictureEditMaskLayoutMode.Stretch;
                case 3: return PictureEditMaskLayoutMode.BottomCenter;
                case 4: return PictureEditMaskLayoutMode.BottomLeft;
                case 5: return PictureEditMaskLayoutMode.BottomRight;
                case 6: return PictureEditMaskLayoutMode.MiddleCenter;
                case 7: return PictureEditMaskLayoutMode.MiddleLeft;
                case 8: return PictureEditMaskLayoutMode.MiddleRight;
                case 9: return PictureEditMaskLayoutMode.TopCenter;
                case 10: return PictureEditMaskLayoutMode.TopLeft;
                case 11: return PictureEditMaskLayoutMode.TopRight;
                default: return PictureEditMaskLayoutMode.Default;
            }
        }
        private void buttonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BMP (*.bmp)|*.bmp|PNG (*.png)|*.png";
            dlg.Title = "Open";
            if(dlg.ShowDialog(this) == DialogResult.OK && dlg.FileName != null && dlg.FileName != string.Empty) {
                try {
                    this.peMasked.Properties.OptionsMask.CustomMask = Image.FromFile(dlg.FileName);
                    this.buttonEdit1.Text = dlg.FileName;
                }
                catch { }
            }
        }
    }
}

