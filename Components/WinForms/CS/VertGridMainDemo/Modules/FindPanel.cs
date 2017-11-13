using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraVerticalGrid.Rows;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class FindPanel : TutorialControl {
        public FindPanel() {
            InitializeComponent();
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            cheHighlightFindResults.Checked = vGridControl1.OptionsFind.HighlightFindResults;
            cheClearFindOnClose.Checked = vGridControl1.OptionsFind.ClearFindOnClose;
            cheShowCloseButton.Checked = vGridControl1.OptionsFind.ShowCloseButton;
            cheShowClearButton.Checked = vGridControl1.OptionsFind.ShowClearButton;
            cheShowFindButton.Checked = vGridControl1.OptionsFind.ShowFindButton;
            cbFindDelay.EditValue = vGridControl1.OptionsFind.FindDelay;

            cbVisibility.Properties.Items.AddEnum<FindPanelVisibility>();
            cbVisibility.EditValue = vGridControl1.OptionsFind.Visibility;

            cbFindMode.Properties.Items.AddEnum<FindMode>();
            cbFindMode.EditValue = vGridControl1.OptionsFind.FindMode;

            cbFindFilterColumns.Properties.Items.AddRange(GetFindFilterColumnItems(vGridControl1));
        }

        

        void cheHighlightFindResults_CheckedChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.HighlightFindResults = GetBoolValue(sender);
        }
        void cheClearFindOnClose_CheckedChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.ClearFindOnClose = GetBoolValue(sender);
        }
        void cheShowCloseButton_CheckedChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.ShowCloseButton = GetBoolValue(sender);
        }
        void cheShowClearButton_CheckedChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.ShowClearButton = GetBoolValue(sender);
        }
        void cheShowFindButton_CheckedChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.ShowFindButton = GetBoolValue(sender);
        }
        void cbFindDelay_EditValueChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.FindDelay = GetInteger(sender);
        }
        void cbVisibility_EditValueChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.Visibility = GetEnum<FindPanelVisibility>(sender);
        }
        void cbFindMode_EditValueChanged(object sender, EventArgs e) {
            vGridControl1.OptionsFind.FindMode = GetEnum<FindMode>(sender);
        }
        void cbFindFilterColumns_EditValueChanged(object sender, EventArgs e) {
            CheckedComboBoxEdit edit = (CheckedComboBoxEdit)sender;
            string findFilterColumnsText = edit.Text.Replace(", ", ";");
            if (findFilterColumnsText != "*")
                findFilterColumnsText = findFilterColumnsText.Replace("*;", "");
            vGridControl1.OptionsFind.FindFilterColumns = findFilterColumnsText;
        }

        CheckedListBoxItem[] GetFindFilterColumnItems(VGridControlBase vGrid) {
            List<CheckedListBoxItem> items = new List<CheckedListBoxItem>();
            items.Add(new CheckedListBoxItem("*", "*", CheckState.Checked));
            foreach(BaseRow row in vGrid.VisibleRows) {
                foreach (RowProperties properties in row.GetRowProperties()) {
                    if (properties.Bindable)
                        items.Add(new CheckedListBoxItem(properties.FieldName, properties.Caption));
                }
            }
            return items.ToArray();
        }
        T GetEnum<T>(object sender) {
            return (T)((ImageComboBoxEdit)sender).EditValue;
        }
        int GetInteger(object sender) {
            return Convert.ToInt32(((BaseEdit)sender).EditValue);
        }
        bool GetBoolValue(object sender) {
            return ((CheckEdit)sender).Checked;
        }
    }
}
