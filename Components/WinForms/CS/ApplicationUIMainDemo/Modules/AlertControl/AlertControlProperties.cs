using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars;

namespace DevExpress.ApplicationUI.Demos {
    public partial class AlertControlProperties : XtraUserControl {
        AlertControl aControl;
        PopupMenu menu;
        public event EventHandler AllowHtmlTextChanged;
        bool initValues = false;
        public AlertControlProperties() {
            InitializeComponent();
            InitProperties();
        }

        void InitProperties() {
            icbControlBoxPosition.Properties.Items.AddEnum(typeof(AlertFormControlBoxPosition));
            icbFormDisplaySpeed.Properties.Items.AddEnum(typeof(AlertFormDisplaySpeed));
            icbFormLocation.Properties.Items.AddEnum(typeof(AlertFormLocation));
            icbShowingEffect.Properties.Items.AddEnum(typeof(AlertFormShowingEffect));
        }
        public void InitValues(AlertControl control) {
            initValues = true;
            this.aControl = control;
            this.menu = control.PopupMenu;
            seAutoFormDelay.EditValue = aControl.AutoFormDelay;
            icbControlBoxPosition.EditValue = aControl.ControlBoxPosition;
            icbFormDisplaySpeed.EditValue = aControl.FormDisplaySpeed;
            icbFormLocation.EditValue = aControl.FormLocation;
            icbShowingEffect.EditValue = aControl.FormShowingEffect;
            ceAllowHtmlText.Checked = aControl.AllowHtmlText;
            ceShowCloseButton.Checked = aControl.ShowCloseButton;
            ceShowPinButton.Checked = aControl.ShowPinButton;
            ceShowTooltips.Checked = aControl.ShowToolTips;
            ceShowPopupMenu.Checked = menu != null;
            ceAutoHeight.Checked = aControl.AutoHeight;
            seFormMaxCount.Value = aControl.FormMaxCount;
            foreach(AlertButton btn in aControl.Buttons) {
                ccbeButtons.Properties.Items.Add(btn.Name, btn.Name, btn.Visible ? CheckState.Checked : CheckState.Unchecked, true);
            }
            initValues = false;
            RaiseAllowHtmlTextChanged();
        }

        //<seAutoFormDelay>
        private void seAutoFormDelay_EditValueChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value);
        }
        //</seAutoFormDelay>

        //<icbControlBoxPosition>
        private void icbControlBoxPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.ControlBoxPosition = (AlertFormControlBoxPosition)icbControlBoxPosition.EditValue;
        }
        //</icbControlBoxPosition>

        //<icbFormDisplaySpeed>
        private void icbFormDisplaySpeed_SelectedIndexChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.FormDisplaySpeed = (AlertFormDisplaySpeed)icbFormDisplaySpeed.EditValue;
        }
        //</icbFormDisplaySpeed>

        //<icbFormLocation>
        private void icbFormLocation_SelectedIndexChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.FormLocation = (AlertFormLocation)icbFormLocation.EditValue;
        }
        //</icbFormLocation>

        //<ceAllowHtmlText>
        private void ceAllowHtmlText_CheckedChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.AllowHtmlText = ceAllowHtmlText.Checked;
            RaiseAllowHtmlTextChanged();
        }
        //</ceAllowHtmlText>

        void RaiseAllowHtmlTextChanged() {
            if(AllowHtmlTextChanged != null) AllowHtmlTextChanged(this, EventArgs.Empty);
        }

        //<ceShowCloseButton>
        private void ceShowCloseButton_CheckedChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.ShowCloseButton = ceShowCloseButton.Checked;
        }
        //</ceShowCloseButton>

        //<ceShowPinButton>
        private void ceShowPinButton_CheckedChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.ShowPinButton = ceShowPinButton.Checked;
        }
        //</ceShowPinButton>

        //<ceShowPopupMenu>
        private void ceShowPopupMenu_CheckedChanged(object sender, EventArgs e) {
            if(initValues) return;
            if(ceShowPopupMenu.Checked)
                aControl.PopupMenu = menu;
            else aControl.PopupMenu = null;
        }
        //</ceShowPopupMenu>

        //<ceShowTooltips>
        private void ceShowTooltips_CheckedChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.ShowToolTips = ceShowTooltips.Checked;
        }
        //</ceShowTooltips>

        //<ccbeButtons>
        private void ccbeButtons_EditValueChanged(object sender, EventArgs e) {
            if(initValues || aControl == null) return;
            foreach(AlertButton btn in aControl.Buttons) 
                btn.Visible = ccbeButtons.Text.IndexOf(btn.Name) >= 0;    
        }
        //</ccbeButtons>
        private void ceAutoHeight_CheckedChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.AutoHeight = ceAutoHeight.Checked;
        }

        private void icbShowingEffect_SelectedIndexChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.FormShowingEffect = (AlertFormShowingEffect)icbShowingEffect.EditValue;
        }

        private void seFormMaxCount_EditValueChanged(object sender, EventArgs e) {
            if(initValues) return;
            aControl.FormMaxCount = (int)seFormMaxCount.Value;
        }
        public bool AutoCloseFormOnClick { get { return ceAutoClose.Checked; } }
    }
}
