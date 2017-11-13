using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleToolTipController : TutorialControl {
        public ModuleToolTipController() {
            InitializeComponent();
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
        string[] titleStyleToolTip = new string[] { "ToolTip Controller component", "<b>ToolTip <i>Controller  </i>component"};
        string[] textStyleToolTip = new string[] {
            "Enables you to customize the appearance and behavior of hints displayed for controls or their elements.", 
            "Enables<size=8> you to <size=14>customize <size=8>the appearance and behavior of <u>hints</u> displayed for controls or their elements."};
        string[] footerStyleToolTip = new string[] { "To learn more, see the help documentation", 
            "<color=Blue>To learn more, see the <u>help documentation"};

        private void ModuleToolTipController_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbSample);
            lbSample.Top += 5;
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbSampleManual);
            lbSampleManual.Top += 5;
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(lbStyleSample);
            lbStyleSample.Top += 5;
            InitValues();
            InitToolTips();
        }

        void InitToolTips() {
        }


        void InitValues() {
            updateValues = true;
            toolTipControllerContentProperties1.Init(toolTipController1, lbSample, "This tooltip is automatically displayed\r\nwhen the mouse hovers over the control.", "Auto-popup tooltip.", false);
            toolTipControllerContentProperties2.Init(toolTipController1, lbSampleManual, "This tooltip is displayed using the ShowHint method.", "Manually-popup tooltip.", true);
            seAutoPopDelay.Value = toolTipController1.AutoPopDelay;
            seInitialDelay.Value = toolTipController1.InitialDelay;
            seRoundRadius.Value = toolTipController1.RoundRadius;
            ceRounded.Checked = toolTipController1.Rounded;
            ceShowBeak.Checked = toolTipController1.ShowBeak;
            ceShowShadow.Checked = toolTipController1.ShowShadow;
            propertyGrid1.SelectedObject = new DevExpress.Utils.Design.FilterObject(toolTipController1.Appearance, new string[] { "BackColor", "BackColor2", "BorderColor", "GradientMode", "Font", "ForeColor", "TextOptions" });
            propertyGrid2.SelectedObject = new DevExpress.Utils.Design.FilterObject(toolTipController1.AppearanceTitle, new string[] { "Font", "ForeColor", "TextOptions" });
            Array arr = Enum.GetValues(typeof(ToolTipType));
            foreach(ToolTipType type in arr) {
                if(type == ToolTipType.Default) continue;
                icbType.Properties.Items.Add(new ImageComboBoxItem(type.ToString(), type, -1));
            }
            icbType.EditValue = toolTipStyleController.ToolTipType;
            chAllowHTML.Checked = toolTipStyleController.AllowHtmlText;
            SetStyleTooltip();
            updateValues = false;
        }

        private void seAutoPopDelay_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.AutoPopDelay = Convert.ToInt32(seAutoPopDelay.Value);
        }

        private void seInitialDelay_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.InitialDelay = Convert.ToInt32(seInitialDelay.Value);
        }

        private void seRoundRadius_EditValueChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.RoundRadius = Convert.ToInt32(seRoundRadius.Value);
        }

        private void ceRounded_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.Rounded = ceRounded.Checked;
        }

        private void ceShowBeak_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.ShowBeak = ceShowBeak.Checked;
        }

        private void ceShowShadow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            toolTipController1.ShowShadow = ceShowShadow.Checked;
        }

        private void pceToolTipLocation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
            pceToolTipLocation.Properties.PopupFormMinSize = toolTipLocationControl.Size;
            pceToolTipLocation.Properties.PopupSizeable = false;
        }

        private void pceToolTipLocation_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e) {
            e.DisplayText = toolTipLocationControl.ToolTipLocationName;
        }

        private void toolTipLocationControl_ToolTipLocationChanged(object sender, System.EventArgs e) {
            pceToolTipLocation.Refresh();
            ToolTipControllerShowEventArgs args = toolTipController1.CreateShowArgs();
            args.ToolTip = "Test";
            args.IconType = ToolTipIconType.Information;
            args.ImageIndex = -1;
            args.IconSize = ToolTipIconSize.Small;
            toolTipController1.ShowHint(args, lbSample);
        }

        private void lbSampleManual_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            ToolTipControllerShowEventArgs args = toolTipControllerContentProperties2.CreateShowArgs();
            toolTipController1.ShowHint(args, lbSampleManual.PointToScreen(new Point(e.X, e.Y)));
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            toolTipController1.HideHint();
        }

        protected override void DoHide() {
            toolTipController1.HideHint();
        }

        private void icbType_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            toolTipStyleController.ToolTipType = (ToolTipType)icbType.EditValue;
            SetStyleTooltip();
        }

        private void chAllowHTML_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            toolTipStyleController.AllowHtmlText = chAllowHTML.Checked;
            SetStyleTooltip();
        }

        void SetStyleTooltip() {
            int index = toolTipStyleController.AllowHtmlText ? 1 : 0;
            if(toolTipStyleController.ToolTipType == ToolTipType.SuperTip) {
                DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
                DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
                toolTipItem.Text = textStyleToolTip[index];
                toolTipItem.Image = global::DevExpress.XtraEditors.Demos.Properties.Resources.note_32x32;
                superToolTip.Items.AddTitle(titleStyleToolTip[index]);
                superToolTip.Items.Add(toolTipItem);
                superToolTip.Items.AddSeparator();
                superToolTip.Items.AddTitle(footerStyleToolTip[index]);
                toolTipStyleController.SetSuperTip(lbStyleSample, superToolTip);
            }
            else {
                toolTipStyleController.SetToolTip(lbStyleSample, textStyleToolTip[index]);
                toolTipStyleController.SetTitle(lbStyleSample, titleStyleToolTip[index]);
                toolTipStyleController.SetToolTipIconType(lbStyleSample, ToolTipIconType.Information);
            }
        }
    }
}

