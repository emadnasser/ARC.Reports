using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.ViewInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class Multiselect : TutorialControl {
        public Multiselect() {
            InitializeComponent();
            Design.XViews.ConfigureDemoView(vGridControl1);
            cbMultiselectMode.Properties.Items.AddEnum<MultiSelectMode>();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            cheMultiselect.Checked = true;
            cbMultiselectMode.EditValue = vGridControl1.OptionsSelectionAndFocus.MultiSelectMode;
        }
        bool GetBoolValue(object sender) {
            return ((CheckEdit)sender).Checked;
        }
        T GetEnum<T>(object sender) {
            return (T)((ImageComboBoxEdit)sender).EditValue;
        }
        void cheMultiselectCheckedChanged(object sender, EventArgs e) {
            bool value = GetBoolValue(sender);
            vGridControl1.OptionsSelectionAndFocus.MultiSelect = value;
            cbMultiselectMode.Enabled = value;
        }
        void cbMultiselectModeSelectedIndexChanged(object sender, EventArgs e) {
            vGridControl1.OptionsSelectionAndFocus.MultiSelectMode = GetEnum<MultiSelectMode>(sender);
        }
        Random rnd = new Random();
        void sbSelectSomeElementsClick(object sender, EventArgs e) {
            vGridControl1.ClearSelection();
            int iterationCount = -1;
            switch(vGridControl1.OptionsSelectionAndFocus.MultiSelectMode) {
                case MultiSelectMode.RecordSelect:
                    iterationCount = rnd.Next(1, vGridControl1.RecordCount);
                    break;
                case MultiSelectMode.RowSelect:
                    iterationCount = rnd.Next(1, vGridControl1.ViewInfo.RowsViewInfo.Count);
                    break;
                case MultiSelectMode.CellSelect:
                    iterationCount = rnd.Next(1, vGridControl1.ViewInfo.RowsViewInfo.Count * vGridControl1.RecordCount);
                    break;
            }
            for(int i = 0; i < iterationCount; i++) {
                int record = rnd.Next(0, vGridControl1.RecordCount);
                int rowIndex = rnd.Next(0, vGridControl1.ViewInfo.RowsViewInfo.Count);
                BaseRow row = vGridControl1.ViewInfo.RowsViewInfo.Cast<BaseRowViewInfo>().ToArray()[rowIndex].Row;
                int cell = rnd.Next(0, row.RowPropertiesCount);
                switch(vGridControl1.OptionsSelectionAndFocus.MultiSelectMode) {
                    case MultiSelectMode.RecordSelect: vGridControl1.SelectRecord(record); break;
                    case MultiSelectMode.RowSelect: vGridControl1.SelectRow(row); break;
                    case MultiSelectMode.CellSelect: vGridControl1.SelectCell(record, row, cell); break;
                }
            }
        }
    }
}
