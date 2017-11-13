using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class ucFindOptions : XtraUserControl {
        GridView view = null;
        public ucFindOptions() {
            InitializeComponent();
            InitEditors();
        }
        bool updateValues = false;
        public void InitData(GridView view, List<ImageComboBoxItem> findFilterColumns) {
            this.view = view;
            cbFindFilterColumns.Properties.Items.AddRange(findFilterColumns);
            updateValues = true;
            ceAllowFindFilter.Checked = view.OptionsFind.AllowFindPanel;
            ceAlwaysVisible.Checked = view.OptionsFind.AlwaysVisible;
            ceClearFind.Checked = view.OptionsFind.ClearFindOnClose;
            ceHighlightFindResults.Checked = view.OptionsFind.HighlightFindResults;
            ceShowCloseButton.Checked = view.OptionsFind.ShowCloseButton;
            seFindDelay.Value = view.OptionsFind.FindDelay;
            cbFindFilterColumns.EditValue = view.OptionsFind.FindFilterColumns;
            icbFindMode.EditValue = view.OptionsFind.FindMode;
            ceShowClearButton.Checked = view.OptionsFind.ShowClearButton;
            ceShowFindButton.Checked = view.OptionsFind.ShowClearButton;
            ceSearchInPreview.Checked = view.OptionsFind.SearchInPreview;
            updateValues = false;
            InitValues();
        }
        void InitEditors() {
            foreach(FindMode mode in Enum.GetValues(typeof(FindMode)))
                icbFindMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FindMode>.GetTitle(mode), mode, -1));
        }
        public int MinHeight {
            get {
                return layoutControl1.Root.MinSize.Height;
            }
        }
        void InitValues() {
            ceAlwaysVisible.Enabled = view.OptionsFind.AllowFindPanel;
            if(!view.OptionsFind.AllowFindPanel) {
                ceAlwaysVisible.Checked = false;
                view.HideFindPanel();
            }
            else {
                view.ShowFindPanel();
            }
            ceShowCloseButton.Enabled = !view.OptionsFind.AlwaysVisible;
        }
        //<ceAllowFindFilter>
        private void ceAllowFindFilter_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.AllowFindPanel = ceAllowFindFilter.Checked;
            InitValues();
        }
        //</ceAllowFindFilter>
        //<ceAlwaysVisible>
        private void ceAlwaysVisible_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.AlwaysVisible = ceAlwaysVisible.Checked;
            InitValues();
        }
        //</ceAlwaysVisible>

        //<ceClearFind>
        private void ceClearFind_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.ClearFindOnClose = ceClearFind.Checked;
        }
        //</ceClearFind>

        //<ceHighlightFindResults>
        private void ceHighlightFindResults_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.HighlightFindResults = ceHighlightFindResults.Checked;
        }
        //</ceHighlightFindResults>

        //<ceShowCloseButton>
        private void ceShowCloseButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.ShowCloseButton = ceShowCloseButton.Checked;
        }
        //</ceShowCloseButton>

        //<seFindDelay>
        private void seFindDelay_EditValueChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.FindDelay = Convert.ToInt32(seFindDelay.Value);
        }
        //</seFindDelay>
        //<cbFindFilterColumns>
        private void cbFindFilterColumns_EditValueChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.FindFilterColumns = string.Format("{0}", cbFindFilterColumns.EditValue);
            RefreshFindFilter();
        }
        
        void RefreshFindFilter() {
            string findText = view.FindFilterText;
            view.ApplyFindFilter(string.Empty);
            view.ApplyFindFilter(findText);
        }
        //</cbFindFilterColumns>
        //<icbFindMode>
        private void icbFindMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.FindMode = (FindMode)icbFindMode.EditValue;
        }
        //</icbFindMode>
        //<ceShowClearButton>
        private void ceShowClearButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.ShowClearButton = ceShowClearButton.Checked;
        }
        //</ceShowClearButton>

        //<ceShowFindButton>
        private void ceShowFindButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsFind.ShowFindButton = ceShowFindButton.Checked;
        }
        //</ceShowFindButton>

        //<ceSearchInPreview>
        private void ceSearchInPreview_CheckedChanged(object sender, EventArgs e) {
            if(updateValues || view == null) return;
            view.OptionsView.ShowPreview = ceSearchInPreview.Checked;
            view.OptionsFind.SearchInPreview = ceSearchInPreview.Checked;
        }
        //</ceSearchInPreview>
    }
}
