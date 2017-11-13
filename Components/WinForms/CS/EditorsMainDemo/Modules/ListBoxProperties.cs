using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
// <icbAlignment>
// <icbSelectionMode>
// <icbSortOrder>
using DevExpress.XtraEditors.Controls;
// </icbSortOrder>
// </icbSelectionMode>
using DevExpress.Utils;
// </icbAlignment>

namespace DevExpress.XtraEditors.Demos {
    public partial class ListBoxProperties : UserControl {
        CheckedListBoxControl CheckedListBox { get { return listBox as CheckedListBoxControl; } }
        ImageListBoxControl ImageListBox { get { return listBox as ImageListBoxControl; } }
        ListBoxControl ListBox { get { return listBox as ListBoxControl; } }
        public ListBoxProperties(BaseListBoxControl listBox) {
            InitializeComponent();
            InitComboBoxes();
            InitListBox(listBox);
            InitSearchControlProperties();
        }

        BaseListBoxControl listBox;
        bool updateValues = false;
        readonly object searchControlPropertyChanged = new object();
        public event PropertyChangedEventHandler SearchControlPropertyChanged {
            add { Events.AddHandler(searchControlPropertyChanged, value); }
            remove { Events.RemoveHandler(searchControlPropertyChanged, value); }
        }
        // <ceAllowAutoApply>      
        // <ceShowSearchButton>        
        // <ceShowClearButton>
        // <ceShowMRUButton>
        // <tbFindDelay>
        // <cbFilterCondition>
        // <cbShowDefaultButtonsMode>
        // <searchControlSample>
        protected void RaiseSearchControlPropertyChanged(string propertyName, object value) {
            PropertyChangedEventHandler handler = (PropertyChangedEventHandler)Events[searchControlPropertyChanged];
            if(handler != null)
                handler(this, new PropertyValueChangedEventArgs(propertyName, value));
        }
        // </ceAllowAutoApply>      
        // </ceShowSearchButton>        
        // </ceShowClearButton>
        // </ceShowMRUButton>
        // </tbFindDelay>
        // </cbFilterCondition>
        // </cbShowDefaultButtonsMode>
        // </searchControlSample>
        public void InitListBox(BaseListBoxControl listBox) {
            this.listBox = listBox;
            updateValues = true;
            icbSelectionMode.EditValue = listBox.SelectionMode;
            icbSortOrder.EditValue = listBox.SortOrder;
            icbHighlightedItemStyle.EditValue = listBox.HighlightedItemStyle;
            icbHotTrackSelectMode.EditValue = listBox.HotTrackSelectMode;
            seColumnWidth.Value = listBox.ColumnWidth;
            ceHotTrack.Checked = listBox.HotTrackItems;
            ceMultiColumn.Checked = listBox.MultiColumn;
            seColumnWidth.Enabled = listBox.MultiColumn;
            // <icbSelectionMode>
            icbSelectionMode.Enabled = CheckedListBox == null;
            // </icbSelectionMode>
            if(ImageListBox != null) icbAlignment.EditValue = ImageListBox.GlyphAlignment;
            if(CheckedListBox != null) ceCheckOnClick.Checked = CheckedListBox.CheckOnClick;
            groupControlSearch.Visible = (ListBox != null && ceTurnSearch.Checked);
            ceTurnSearch.Enabled = ListBox != null;
            groupControlChecked.Visible = CheckedListBox != null;
            groupControlImage.Visible = ImageListBox != null;
            icbSortOrder.Enabled = listBox.DataSource == null;
            ceHotTrack.Enabled = AllowHotTrack;
            ceIncrementalSearch.Checked = listBox.IncrementalSearch;
            UpdateHotTrackSelectModeEnabled();
            updateValues = false;
        }
        void InitSearchControlProperties() {
            if(listBox is ListBoxControl) {
                ceTurnSearch.Checked = true;
                // <ceAllowAutoApply>
                ceAllowAutoApply.Checked = true;
                // </ceAllowAutoApply>
                // <ceShowSearchButton>
                ceShowSearchButton.Checked = true;
                // </ceShowSearchButton>
                // <ceShowClearButton>
                ceShowClearButton.Checked = true;
                // </ceShowClearButton>
                // <ceShowMRUButton>
                ceShowMRUButton.Checked = false;
                // </ceShowMRUButton>
                // <cbFilterCondition>
                cbFilterCondition.Properties.Items.AddEnum(typeof(DevExpress.Data.Filtering.FilterCondition));
                cbFilterCondition.SelectedIndex = (int)DevExpress.Data.Filtering.FilterCondition.Default;
                // </cbFilterCondition>
                // <tbFindDelay>
                tbFindDelay.Value = 1000;
                // </tbFindDelay>
                // <cbShowDefaultButtonsMode>
                cbShowDefaultButtonsMode.Properties.Items.AddEnum(typeof(Repository.ShowDefaultButtonsMode));
                cbShowDefaultButtonsMode.SelectedIndex = (int)Repository.ShowDefaultButtonsMode.Default;
                // </cbShowDefaultButtonsMode>
            }
        }
        void UpdateHotTrackSelectModeEnabled() {
            icbHotTrackSelectMode.Enabled = listBox.HighlightedItemStyle == HighlightStyle.Skinned &&
                listBox.HotTrackItems;
        }
        void InitComboBoxes() {
            // <icbSelectionMode>
            icbSelectionMode.Properties.Items.AddEnum(typeof(SelectionMode));
            // </icbSelectionMode>
            // <icbSortOrder>
            icbSortOrder.Properties.Items.AddEnum(typeof(SortOrder));
            // </icbSortOrder>
            // <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(typeof(HorzAlignment));
            // </icbAlignment>
            // <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(typeof(HighlightStyle));
            // </icbHighlightedItemStyle>
            // <icbHotTrackSelectMode>
            icbHotTrackSelectMode.Properties.Items.AddEnum(typeof(HotTrackSelectMode));
            // </icbHotTrackSelectMode>
        }

        // <icbSelectionMode>
        // <ceHotTrack>
        bool AllowHotTrack { get { return listBox.SelectionMode.ToString().IndexOf("Multi") == -1; } }
        // </ceHotTrack>
        private void icbSelectionMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.SelectionMode = (SelectionMode)icbSelectionMode.EditValue;
            // <ceHotTrack>
            ceHotTrack.Enabled = AllowHotTrack;
            // </ceHotTrack>
        }
        // </icbSelectionMode>

        // <icbSortOrder>
        private void icbSortOrder_SelectedIndexChanged(object sender, System.EventArgs e) {
            // </skip>
            if(updateValues) return;
            // </skip>
            listBox.SortOrder = (SortOrder)icbSortOrder.EditValue;
        }
        // </icbSortOrder>

        // <seColumnWidth>
        private void seColumnWidth_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.ColumnWidth = Convert.ToInt32(seColumnWidth.Value);
        }
        // </seColumnWidth>

        // <ceHotTrack>
        private void ceHotTrack_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.HotTrackItems = ceHotTrack.Checked;
            // <skip>
            UpdateHotTrackSelectModeEnabled();
            // </skip>
        }
        // </ceHotTrack>

        // <ceMultiColumn>
        private void ceMultiColumn_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.MultiColumn = ceMultiColumn.Checked;
            // <seColumnWidth>
            seColumnWidth.Enabled = listBox.MultiColumn;
            // </seColumnWidth>
        }
        // </ceMultiColumn>

        // <icbAlignment>
        private void icbAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            if(ImageListBox == null) return;
            ImageListBox.GlyphAlignment = (HorzAlignment)icbAlignment.EditValue;
        }
        // </icbAlignment>

        // <ceCheckOnClick>
        private void ceCheckOnClick_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            if(CheckedListBox == null) return;
            CheckedListBox.CheckOnClick = ceCheckOnClick.Checked;
        }
        // </ceCheckOnClick>

        // <icbHighlightedItemStyle>
        private void icbHighlightedItemStyle_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.HighlightedItemStyle = (HighlightStyle)icbHighlightedItemStyle.EditValue;
            // <skip>
            UpdateHotTrackSelectModeEnabled();
            // </skip>
        }
        // </icbHighlightedItemStyle>

        // <icbHotTrackSelectMode>
        private void icbHotTrackSelectMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.HotTrackSelectMode = (HotTrackSelectMode)icbHotTrackSelectMode.EditValue;
        }
        // </icbHotTrackSelectMode>
        // <ceIncrementalSearch>
        private void ceIncrementalSearch_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBox.IncrementalSearch = ceIncrementalSearch.Checked;
        }
        // </ceIncrementalSearch>
        // <ceAllowAutoApply>
        private void ceAllowAutoApply_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("AllowAutoApply", ceAllowAutoApply.Checked);
        }
        // </ceAllowAutoApply>
        // <ceShowSearchButton>
        private void ceShowSearchButton_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowSearchButton", ceShowSearchButton.Checked);
        }
        // </ceShowSearchButton>
        // <ceShowClearButton>
        private void ceShowClearButton_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowClearButton", ceShowClearButton.Checked);
        }
        // </ceShowClearButton>
        // <ceShowMRUButton>
        private void ceShowMRUButton_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowMRUButton", ceShowMRUButton.Checked);
        }
        // </ceShowMRUButton>
        // <tbFindDelay>
        private void tbFindDelay_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("FindDelay", tbFindDelay.Value);
        }
        // </tbFindDelay>
        // <cbFilterCondition>
        private void cbFilterCondition_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("FilterCondition", cbFilterCondition.EditValue);
        }
        // </cbFilterCondition>
        // <searchControlSample>
        private void ceTurnSearch_CheckedChanged(object sender, EventArgs e) {
            RaiseSearchControlPropertyChanged("TurnSearch", ceTurnSearch.Checked);
            // <skip>
            groupControlSearch.Visible = ceTurnSearch.Checked;
            // </skip>
        }
        // </searchControlSample>
        // <cbShowDefaultButtonsMode>
        private void cbShowDefaultButtonsMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowDefaultButtonsMode", cbShowDefaultButtonsMode.EditValue);
        }
        // </cbShowDefaultButtonsMode>
    }
    public class PropertyValueChangedEventArgs : PropertyChangedEventArgs {
        object value;
        public PropertyValueChangedEventArgs(string propertyName, object value)
            : base(propertyName) {
            this.value = value;
        }
        public object Value { get { return value; } }
    }
}
