using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.ApplicationUI.Demos.VisualEffects {
    public partial class ModuleBadges : TutorialControl {
        DevExpress.Utils.VisualEffects.Badge badge;
        public ModuleBadges() {
            InitializeComponent();
            InitControls();
            InitBadge();
        }
        private void InitControls() {            
            cbTargetElement.EditValue = targetElement1.Name;
            cbTargetElement.Properties.Items.AddRange(new object[] { targetElement1.Name, targetElement2.Name });
            ieLocation.EditValue = ContentAlignment.TopRight;
            ieLocation.Properties.Items.AddEnum(typeof(ContentAlignment));            
        }
        private void InitBadge() {
            adornerUIManager1.BeginUpdate();
            badge = new DevExpress.Utils.VisualEffects.Badge();
            SetBadgeTargetElement(cbTargetElement.Text);
            badge.Visible = ceVisible.Checked;            
            badge.Properties.AllowGlyphSkinning = GetDefaultBoolean(cbAllowGlyphSkinning.Checked);
            badge.Properties.AllowImage = GetDefaultBoolean(cbAllowImage.Checked);
            badge.Properties.StretchImage = GetDefaultBoolean(cbStretchImage.Checked);
            badge.Properties.Location = (ContentAlignment)ieLocation.EditValue;
            badge.Properties.Text = teText.Text;
            SetBadgeOffset();
            SetBadgeImage();
            badge.Properties.TextMargin = new System.Windows.Forms.Padding(3);
            badge.Properties.ImageStretchMargins = new System.Windows.Forms.Padding(14);
            adornerUIManager1.Elements.Add(badge);
            adornerUIManager1.EndUpdate();
        }        
        private DefaultBoolean GetDefaultBoolean(bool value) {
            return value ? DefaultBoolean.True : DefaultBoolean.False;
        }
        private void SetBadgeImage() {
            if(badge.Properties.AllowGlyphSkinning != DefaultBoolean.False)
                badge.Properties.Image = imageList1.Images[ieImage.SelectedIndex];
            else
                badge.Properties.Image = imageList2.Images[ieImage.SelectedIndex];
        }
        private void ieImage_SelectedIndexChanged(object sender, EventArgs e) {
            SetBadgeImage();
        }        
        private void SetBadgeTargetElement(string name) {
            if(name == targetElement1.Name)
                badge.TargetElement = targetElement1;
            if(name == targetElement2.Name)
                badge.TargetElement = targetElement2;
        }
        private void cbTargetElement_SelectedIndexChanged(object sender, EventArgs e) {
            SetBadgeTargetElement(cbTargetElement.Text);
        }
        private void ceVisible_CheckedChanged(object sender, EventArgs e) {
            badge.Visible = ceVisible.Checked;
        }
        private void cbAllowGlyphSkinning_CheckedChanged(object sender, EventArgs e) {
            badge.Properties.AllowGlyphSkinning = GetDefaultBoolean(cbAllowGlyphSkinning.Checked);
            if(badge.Properties.AllowGlyphSkinning == DefaultBoolean.False)
                ieImage.Properties.SmallImages = imageList2;
            else
                ieImage.Properties.SmallImages = imageList1;
            SetBadgeImage();
        }
        private void cbAllowImage_CheckedChanged(object sender, EventArgs e) {
            badge.Properties.AllowImage = GetDefaultBoolean(cbAllowImage.Checked);
        }
        private void cbStretchImage_CheckedChanged(object sender, EventArgs e) {
            badge.Properties.StretchImage = GetDefaultBoolean(cbStretchImage.Checked);
        }
        private void SetBadgeOffset() {
            badge.Properties.Offset = new Point(Convert.ToInt32(seXOffset.Value), Convert.ToInt32(seYOffset.Value));
        }
        private void seYOffset_EditValueChanged(object sender, EventArgs e) {
            SetBadgeOffset();
        }
        private void seXOffset_EditValueChanged(object sender, EventArgs e) {
            SetBadgeOffset();
        }
        private void teText_EditValueChanged(object sender, EventArgs e) {
            badge.Properties.Text = teText.Text;
        }
        private void ceTextColor_EditValueChanged(object sender, EventArgs e) {
            badge.Appearance.ForeColor = ceTextColor.Color;
        }
        private void ceImageColor_EditValueChanged(object sender, EventArgs e) {
            badge.Appearance.BackColor = ceImageColor.Color;
        }
        private void ieLocation_SelectedIndexChanged(object sender, EventArgs e) {
            badge.Properties.Location = (ContentAlignment)ieLocation.EditValue;
        }
    }
}
