using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class LookUpProperties : UserControl {
        public LookUpProperties()
            : this(null) {
        }
        public LookUpProperties(GridLookUpEdit lookUp) {
            InitializeComponent();
            InitComboBoxes();
            InitLookUp(lookUp);
        }

        RepositoryItemGridLookUpEdit lookUpProperties;
        bool updateValues = false;
        public void InitLookUp(GridLookUpEdit lookUp) {
            if(lookUp == null) return;
            this.lookUpProperties = lookUp.Properties;
            updateValues = true;
            lbDisplay.Text = lookUpProperties.DisplayMember;
            lbValue.Text = lookUpProperties.ValueMember;
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle;
            ceAutoComplete.Checked = lookUpProperties.AutoComplete;
            ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup;
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable;
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter;
            ceShowAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow;
            ceShowColumnHeaders.Checked = View.OptionsView.ShowColumnHeaders;
            ceShowIndicator.Checked = View.OptionsView.ShowIndicator;
            ceShowHorzLines.Checked = View.OptionsView.ShowHorizontalLines != DefaultBoolean.False;
            ceShowVerticalLines.Checked = View.OptionsView.ShowVerticalLines != DefaultBoolean.False;
            ceEnableAppearanceEvenRow.Checked = View.OptionsView.EnableAppearanceEvenRow;
            ceEnableAppearanceOddRow.Checked = View.OptionsView.EnableAppearanceOddRow;
            EnableProperties();
            updateValues = false;
        }
        GridView View {
            get {
                GridView view = lookUpProperties.View as GridView;
                return view;
            }
        }
        void InitComboBoxes() {
            foreach(TextEditStyles style in Enum.GetValues(typeof(TextEditStyles)))
                icbTextEditStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<TextEditStyles>.GetTitle(style), style, -1));
        }
        void EnableProperties() {
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter;
        }

        private void LookUpProperties_Load(object sender, System.EventArgs e) {
        }

        //<icbTextEditStyle>
        private void icbTextEditStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.TextEditStyle = (TextEditStyles)icbTextEditStyle.EditValue;
        }
        //</icbTextEditStyle>

        //<ceImmediatePopup>
        private void ceImmediatePopup_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked;
        }
        //</ceImmediatePopup>

        //<cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.PopupSizeable = cePopupSizeable.Checked;
        }
        //</cePopupSizeable>

        //<ceShowPopupFooter>
        private void ceShowPopupFooter_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ShowFooter = ceShowPopupFooter.Checked;
            EnableProperties();
        }
        //</ceShowPopupFooter>

        //<ceShowAutoFilterRow>
        private void ceShowAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked;
        }
        //</ceShowAutoFilterRow>

        //<ceShowColumnHeaders>
        private void ceShowColumnHeaders_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowColumnHeaders = ceShowColumnHeaders.Checked;
        }
        //</ceShowColumnHeaders>

        //<ceShowIndicator>
        private void ceShowIndicator_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowIndicator = ceShowIndicator.Checked;
        }
        //</ceShowIndicator>

        //<ceShowHorzLines>
        private void ceShowHorzLines_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowHorizontalLines = ceShowHorzLines.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowHorzLines>

        //<ceShowVerticalLines>
        private void ceShowVerticalLines_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowVerticalLines = ceShowVerticalLines.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowVerticalLines>

        //<ceEnableAppearanceEvenRow>
        private void ceEnableAppearanceEvenRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked;
        }
        //</ceEnableAppearanceEvenRow>

        //<ceEnableAppearanceOddRow>
        private void ceEnableAppearanceOddRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked;
        }
        //</ceEnableAppearanceOddRow>

        //<ceAutoComplete>
        private void ceAutoComplete_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.AutoComplete = ceAutoComplete.Checked;
        }
        //</ceAutoComplete>

    }
}
