using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class Layout : DevExpress.XtraVerticalGrid.Demos.PropertiesBase {
        public Layout() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\Layout.cs;";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.Layout.xml";
            // TODO: Add any initialization after the InitializeComponent call
        }

        int noteHeight = 120;
        //<groupBox1>
        private void radioButtonLayoutStyle_CheckedChanged(object sender, System.EventArgs e) {
            if(radioButton1.Checked) {
                CurrentGrid.LayoutStyle = LayoutViewStyle.BandsView;
                if(IsLayoutGrid) checkBox1.Checked = false;
            }
            if(radioButton2.Checked) CurrentGrid.LayoutStyle = LayoutViewStyle.SingleRecordView;
            if(radioButton3.Checked) CurrentGrid.LayoutStyle = LayoutViewStyle.MultiRecordView;
        }
        //</groupBox1>
        //<groupBox3>
        private void radioButtonButtonMode_CheckedChanged(object sender, System.EventArgs e) {
            if(radioButton6.Checked) CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            if(radioButton7.Checked) CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRow;
            if(radioButton8.Checked) CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell;
            if(radioButton9.Checked) CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRecord;
            if(radioButton10.Checked) CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowOnlyInEditor;
        }
        //</groupBox3>
        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit ch = sender as DevExpress.XtraEditors.CheckEdit;
            if(ch.Checked) {
                EditorRowDescription.Properties.RowEdit = repositoryItemMemoExEdit1;
                EditorRowAutomaticTransmission.Properties.RowEdit = repositoryItemRadioGroup1;
                EditorRowDescription.Height = -1;
            }
            else {
                EditorRowDescription.Properties.RowEdit = repositoryItemMemoEdit1;
                EditorRowAutomaticTransmission.Properties.RowEdit = repositoryItemImageComboBox2;
                EditorRowDescription.Height = noteHeight;
            }
        }
        //</checkBox1>
        //<checkBox2>
        private void checkBox2_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit ch = sender as DevExpress.XtraEditors.CheckEdit;
            CurrentGrid.TreeButtonStyle = ch.Checked ? DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView : DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
        }
        //</checkBox2>
        protected override void AdjustmentGrid() {
            base.AdjustmentGrid();
            switch(CurrentGrid.LayoutStyle) {
                case LayoutViewStyle.BandsView:
                    radioButton1.Checked = true;
                    break;
                case LayoutViewStyle.SingleRecordView:
                    radioButton2.Checked = true;
                    break;
                case LayoutViewStyle.MultiRecordView:
                    radioButton3.Checked = true;
                    break;
            }
            switch(CurrentGrid.ShowButtonMode) {
                case ShowButtonModeEnum.ShowAlways:
                    radioButton6.Checked = true;
                    break;
                case ShowButtonModeEnum.ShowForFocusedRow:
                    radioButton7.Checked = true;
                    break;
                case ShowButtonModeEnum.ShowForFocusedCell:
                    radioButton8.Checked = true;
                    break;
                case ShowButtonModeEnum.ShowForFocusedRecord:
                    radioButton9.Checked = true;
                    break;
                case ShowButtonModeEnum.ShowOnlyInEditor:
                    radioButton10.Checked = true;
                    break;
            }
            checkBox1.Enabled = IsLayoutGrid;
            checkBox2.Checked = CurrentGrid.TreeButtonStyle == DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
        }
    }
}

