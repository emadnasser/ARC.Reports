using System;
using System.Collections;
using System.ComponentModel;
//using System.Drawing;
using DevExpress.Tutorials;
using System.Windows.Forms;
// <comboAlign>
using DevExpress.Utils;
// </comboAlign>
// <checkEditRadioGroup>
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Text;
using DevExpress.XtraLayout;
// </checkEditRadioGroup>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleCheckEdit : TutorialControl {
        public ModuleCheckEdit() {
            InitializeComponent();
            UpdateCheckStates();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleCheckEdit.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.checkEdit.xml";
            if(xtraTabControl1 != null) {
                xtraTabControl1.SelectedPageChanged += OnSelectedPageChanged;
                xtraTabControl1.VisibleChanged += OnTabControlVisibleChanged;
            }
        }

        bool updateValues = false;

        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        void OnTabControlVisibleChanged(object sender, EventArgs e) {
            CalcContentCore();
        }
        void OnSelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void CalcContentCore() {
            if(!Visible || !IsHandleCreated) return;
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
        }
        
        // <btnToggleState>
        private void btnToggleState_Click(object sender, System.EventArgs e) {
            checkEditSample.Checked = !checkEditSample.Checked;
        }
        // </btnToggleState>

        // <checkEditAllowGrayed>
        private void checkEditAllowGrayed_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkEditSample.Properties.AllowGrayed = checkEditAllowGrayed.Checked;
            UpdateCheckStates();
        }
        // </checkEditAllowGrayed>

        // <comboCheckState>
        private void comboCheckState_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            CheckState[] states = new CheckState[] { 
				CheckState.Checked, 
				CheckState.Unchecked, 
				CheckState.Indeterminate };
            checkEditSample.CheckState = states[comboCheckState.SelectedIndex];
        }
        // </comboCheckState>

        // <comboAlign>
        private void comboAlign_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            HorzAlignment[] alignments = new HorzAlignment[] { 
				HorzAlignment.Near, 
				HorzAlignment.Center, 
				HorzAlignment.Far };
            int selectedIndex = comboAlign.SelectedIndex;
            checkEditSample.Properties.GlyphAlignment = alignments[selectedIndex];
            checkEditSample.Properties.Appearance.TextOptions.HAlignment = alignments[selectedIndex];
        }
        // </comboAlign>

        private void CreateEditors() {
            int checkEditCount = 10;
            int checkEditDistance = checkEditSample.Font.Height + 10;
            for(int i = 0; i < checkEditCount; i++) {
                DevExpress.XtraEditors.CheckEdit newCheckEdit = new DevExpress.XtraEditors.CheckEdit();
                newCheckEdit.Text = "Check edit " + (i + 1).ToString();
                LayoutControlItem item = layoutControlGroup7.AddItem(string.Empty, newCheckEdit);
                item.TextVisible = false;
            }
        }

        // <checkEditRadioGroup>
        private void checkEditRadioGroup_CheckedChanged(object sender, System.EventArgs e) {
            if(checkEditRadioGroup.Checked)
                SetCheckEditsRadioIndex(0);
            else
                SetCheckEditsRadioIndex(-1);
            checkEditApplyRadioStyle.Checked = checkEditRadioGroup.Checked;
        }
        private void SetCheckEditsRadioIndex(int radioIndex) {
            ArrayList checkEdits = GetCheckEditControls();
            foreach(DevExpress.XtraEditors.CheckEdit editor in checkEdits) {
                editor.Checked = false;
                editor.Properties.RadioGroupIndex = radioIndex;
            }
        }
        // </checkEditRadioGroup>

        // <checkEditApplyRadioStyle>
        private void checkEditApplyRadioStyle_CheckedChanged(object sender, System.EventArgs e) {
            if(checkEditApplyRadioStyle.Checked)
                SetCheckEditsStyle(CheckStyles.Radio);
            else
                SetCheckEditsStyle(CheckStyles.Standard);
        }
        private void SetCheckEditsStyle(CheckStyles style) {
            ArrayList checkEdits = GetCheckEditControls();
            foreach(DevExpress.XtraEditors.CheckEdit editor in checkEdits)
                editor.Properties.CheckStyle = style;
        }
        // </checkEditApplyRadioStyle>


        // <btnRemoveEditors> <checkEditRadioGroup> <checkEditApplyRadioStyle>
        private ArrayList GetCheckEditControls() {
            ArrayList checkEdits = new ArrayList();
            foreach(LayoutControlItem item in layoutControlGroup7.Items) {
                if(item.Control is DevExpress.XtraEditors.CheckEdit)
                    checkEdits.Add(item.Control);
            }
            return checkEdits;
        }
        // </btnRemoveEditors> </checkEditRadioGroup> </checkEditApplyRadioStyle>

        private void TutorialModuleCheckEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(checkEditSample);
            CreateEditors();
            InitValues();
            SetCheckBoxText();
        }


        void InitValues() {
            updateValues = true;
            checkEditAllowGrayed.Checked = checkEditSample.Properties.AllowGrayed;
            comboCheckState.EditValue = checkEditSample.CheckState.ToString();
            checkEditSample.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            comboAlign.EditValue = checkEditSample.Properties.Appearance.TextOptions.HAlignment.ToString();
            ceAllowHTMLString.Checked = checkEditSample.Properties.AllowHtmlDraw == DefaultBoolean.True;
            updateValues = false;
        }

        // <popupCustomImages>
        private void btnApplyImagesOK_Click(object sender, System.EventArgs e) {
            checkEditSample.Properties.PictureChecked = pictureChecked.Image;
            checkEditSample.Properties.PictureGrayed = pictureGrayed.Image;
            checkEditSample.Properties.PictureUnchecked = pictureUnchecked.Image;
            checkEditSample.Properties.CheckStyle = CheckStyles.UserDefined;
            editorStyleSwitcher.Text = checkEditSample.Properties.CheckStyle.ToString();
            popupCustomImages.ClosePopup();
        }

        private void btnApplyImagesCancel_Click(object sender, System.EventArgs e) {
            popupCustomImages.ClosePopup();
        }
        // </popupCustomImages>

        // <editorStyleSwitcher>
        private void editorStyleSwitcher_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            ArrayList checkStyles = new ArrayList();
            checkStyles.AddRange(new CheckStyles[] { 
				CheckStyles.Standard, CheckStyles.Radio, 
				CheckStyles.Style1, CheckStyles.Style2, 
				CheckStyles.Style3, CheckStyles.Style4, 
				CheckStyles.Style5, CheckStyles.Style6, 
				CheckStyles.Style7, CheckStyles.Style8, 
				CheckStyles.Style9, CheckStyles.Style10, 
				CheckStyles.Style11, CheckStyles.Style12, 
				CheckStyles.Style13, CheckStyles.Style14, 
				CheckStyles.Style15, CheckStyles.Style16 });
            int currentStyleIndex = checkStyles.IndexOf(checkEditSample.Properties.CheckStyle);
            currentStyleIndex++;
            if(currentStyleIndex == checkStyles.Count)
                currentStyleIndex = 0;
            checkEditSample.Properties.CheckStyle = (CheckStyles)checkStyles[currentStyleIndex];
            editorStyleSwitcher.Text = checkEditSample.Properties.CheckStyle.ToString();
        }
        // </editorStyleSwitcher>

        private void checkEditSample_CheckStateChanged(object sender, System.EventArgs e) {
            foreach(string item in comboCheckState.Properties.Items) {
                if(checkEditSample.CheckState.ToString().EndsWith(item)) {
                    comboCheckState.Text = item;
                    break;
                }
            }
        }
        //<checkEditAllowMnemonics>
        string checkEditText = "<Color=Blue>{0}Sample<Color=Black> <b>check</b><br>box <image=#info_16x16>";
        void SetCheckBoxText() {
            string prefix = checkEditAllowMnemonics.Checked ? "&" : string.Empty;
            if(ceAllowHTMLString.Checked)
                checkEditSample.Text = string.Format(checkEditText, prefix);
            else checkEditSample.Text = string.Format(StringPainter.Default.RemoveFormat(checkEditText), prefix);
        }

        private void checkEditAllowMnemonics_CheckedChanged(object sender, System.EventArgs e) {
            SetCheckBoxText();
        }
        //</checkEditAllowMnemonics>
        //<ceAllowHTMLString>
        private void ceAllowHTMLString_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            checkEditSample.Properties.AllowHtmlDraw = ceAllowHTMLString.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            SetCheckBoxText();
        }
        //</ceAllowHTMLString>
        void UpdateCheckStates() {
            comboCheckState.Enabled = checkEditSample.Properties.AllowGrayed;
            btnToggleState.Enabled = !checkEditSample.Properties.AllowGrayed;
        }
    }
}

