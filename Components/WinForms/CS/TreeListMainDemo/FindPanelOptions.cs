using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;
using DevExpress.XtraTreeList.Columns;
using System.Collections;
using DevExpress.XtraTreeList.ViewInfo;

namespace DevExpress.XtraTreeList.Demos {
    public partial class FindPanelOptions : XtraForm {
        TreeList treeList;
        public FindPanelOptions(TreeList treeList) {
            this.treeList = treeList;
            InitializeComponent();
            Init(TreeList.VisibleColumns);
        }
        protected TreeList TreeList { get { return treeList; } }
        void Init(VisibleColumnsList findFilterColumns) {
            InitFindFilterColumns(findFilterColumns);
            ceHighlightFindResults.Checked = TreeList.OptionsFind.HighlightFindResults;
            ceShowCloseButton.Checked = TreeList.OptionsFind.ShowCloseButton;
            ceShowClearButton.Checked = TreeList.OptionsFind.ShowClearButton;
            ceShowFindButton.Checked = TreeList.OptionsFind.ShowFindButton;
            seFindDelay.Value = TreeList.OptionsFind.FindDelay;
            cbFindFilterColumns.EditValue = TreeList.OptionsFind.FindFilterColumns;
            cbFindMode.EditValue = TreeList.OptionsFind.FindMode;

            foreach(FindMode mode in Enum.GetValues(typeof(FindMode)))
                cbFindMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FindMode>.GetTitle(mode), mode, -1));
        }
        void InitFindFilterColumns(VisibleColumnsList findFilterColumns) {
            cbFindFilterColumns.Properties.Items.Add(new ImageComboBoxItem("*", "*"));
            for(int i = 0; i < findFilterColumns.Count; i++) {
                string captions = findFilterColumns[i].GetCaption();
                string fieldNames = findFilterColumns[i].FieldName;
                for(int j = i; j < findFilterColumns.Count; j++) {
                    if(j != i) {
                        captions += string.Format(";{0}", findFilterColumns[j].GetCaption());
                        fieldNames += string.Format(";{0}", findFilterColumns[j].FieldName);
                    }
                    cbFindFilterColumns.Properties.Items.Add(new ImageComboBoxItem(captions, fieldNames));
                }
            }
        }
        void Apply() {
            TreeList.OptionsFind.HighlightFindResults = ceHighlightFindResults.Checked;
            TreeList.OptionsFind.ShowCloseButton = ceShowCloseButton.Checked;
            TreeList.OptionsFind.ShowClearButton = ceShowClearButton.Checked;
            TreeList.OptionsFind.ShowFindButton = ceShowFindButton.Checked;
            TreeList.OptionsFind.FindFilterColumns = string.Format("{0}", cbFindFilterColumns.EditValue);
            TreeList.OptionsFind.FindMode = (FindMode)cbFindMode.EditValue;
            TreeList.OptionsFind.FindDelay = Convert.ToInt32(seFindDelay.Value);
        }
        void btnApply_Click(object sender, EventArgs e) {
            Apply();
        }
    }
}
