using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
// <icbHeaderClickMode>
// <icbSearchMode>
using DevExpress.XtraEditors.Controls;
// </icbSearchMode>
// </icbHeaderClickMode>

namespace DevExpress.XtraEditors.Demos {
    public partial class LookUpProperties : UserControl {
        public LookUpProperties(LookUpEdit lookUp) {
            InitializeComponent();
            InitComboBoxes();
            InitLookUp(lookUp);
        }

        RepositoryItemLookUpEdit lookUpProperties;
        bool updateValues = false;

        public void InitLookUp(LookUpEdit lookUp) {
            this.lookUpProperties = lookUp.Properties;
            updateValues = true;
            seColumnIndex.Properties.MaxValue = lookUpProperties.Columns.Count - 1;
            seColumnIndex.Enabled = seColumnIndex.Properties.MaxValue > 0;
            lbDisplay.Text = lookUpProperties.DisplayMember;
            lbValue.Text = lookUpProperties.ValueMember;
            seColumnIndex.Value = lookUpProperties.AutoSearchColumnIndex;
            icbSearchMode.EditValue = lookUpProperties.SearchMode;
            icbHeaderClickMode.EditValue = lookUpProperties.HeaderClickMode;
            ceCaseSensitiveSearch.Checked = lookUpProperties.CaseSensitiveSearch;
            seItemHeight.Value = lookUpProperties.DropDownItemHeight;
            teNullText.Text = lookUpProperties.NullText;
            ceHotTrack.Checked = lookUpProperties.HotTrackItems;
            ceShowFooter.Checked = lookUpProperties.ShowFooter;
            ceShowHeader.Checked = lookUpProperties.ShowHeader;
            ceShowLines.Checked = lookUpProperties.ShowLines;
            updateValues = false;
        }
        void InitComboBoxes() {
            // <icbHeaderClickMode>
            icbHeaderClickMode.Properties.Items.AddEnum(typeof(HeaderClickMode));
            // </icbHeaderClickMode>
            // <icbSearchMode>
            icbSearchMode.Properties.Items.AddEnum(typeof(SearchMode));
            // </icbSearchMode>
        }

        private void LookUpProperties_Load(object sender, System.EventArgs e) {
        }

        // <seColumnIndex>
        private void seColumnIndex_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.AutoSearchColumnIndex = Convert.ToInt32(seColumnIndex.Value);
        }
        // </seColumnIndex>

        // <icbHeaderClickMode>
        private void icbHeaderClickMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.HeaderClickMode = (HeaderClickMode)icbHeaderClickMode.EditValue;
        }
        // </icbHeaderClickMode>

        // <icbSearchMode>
        private void icbSearchMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.SearchMode = (SearchMode)icbSearchMode.EditValue;
        }
        // </icbSearchMode>

        // <ceCaseSensitiveSearch>
        private void ceCaseSensitiveSearch_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.CaseSensitiveSearch = ceCaseSensitiveSearch.Checked;
        }
        // </ceCaseSensitiveSearch>

        // <seItemHeight>
        private void seItemHeight_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.DropDownItemHeight = Convert.ToInt32(seItemHeight.Value);
        }
        // </seItemHeight>

        // <teNullText>
        private void teNullText_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.NullText = teNullText.Text;
        }
        // </teNullText>

        // <ceHotTrack>
        private void ceHotTrack_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.HotTrackItems = ceHotTrack.Checked;
        }
        // </ceHotTrack>

        // <ceShowFooter>
        private void ceShowFooter_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.ShowFooter = ceShowFooter.Checked;
        }
        // </ceShowFooter>

        // <ceShowHeader>
        private void ceShowHeader_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.ShowHeader = ceShowHeader.Checked;
        }
        // </ceShowHeader>

        // <ceShowLines>
        private void ceShowLines_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.ShowLines = ceShowLines.Checked;
        }
        // </ceShowLines>
    }
}
