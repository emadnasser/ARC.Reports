using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class UnboundField : TutorialControl {
        BaseRow firstNameRow,
            lastNameRow,
            UnboundRow;

        public UnboundField() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\UnboundField.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.UnboundField.xml";
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
        }
        //<cbNameOrder>
        /*
        ~vGridControl1.CustomUnboundData += new DevExpress.XtraVerticalGrid.Events.CustomDataEventHandler(vGridControl1_CustomUnboundData);
         */
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            UnboundRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            UnboundRow.Properties.UnboundType = DevExpress.Data.UnboundColumnType.String;
            firstNameRow = vGridControl1.Rows.GetRowByFieldName("First Name", true);
            lastNameRow = vGridControl1.Rows.GetRowByFieldName("Last Name", true);
            firstNameRow.ParentRow.ChildRows.Insert(UnboundRow, 0);
            ConfigureUnboundFieldCaption();
        }
        
        void ConfigureUnboundFieldCaption() {
            UnboundRow.Properties.Caption = cbNameOrder.SelectedItem.ToString();
        }

        private void vGridControl1_CustomUnboundData(object sender, DevExpress.XtraVerticalGrid.Events.CustomDataEventArgs e) {
            if(!e.IsGetData)
                return;
            e.Value = GetText(e.ListSourceRowIndex);
        }
        //</cbNameOrder>
        private void cbFirst_SelectedIndexChanged(object sender, EventArgs e) {
            ConfigureUnboundFieldCaption();
            vGridControl1.Refresh();
        }
        //<cbNameOrder>
        string GetText(int sourceIndex) {
            string result = "";
            switch(cbNameOrder.SelectedIndex) {
                case 0:
                    result = vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString() + " " + vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString();
                    break;
                case 1:
                    result = vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString() + " " + vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString();
                    break;
                case 2:
                    result = vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString();
                    break;
                case 3:
                    result = vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString();
                    break;
                case 4:
                    break;
                default:
                    throw new Exception();
            }
            return result;
        }
        //</cbNameOrder>
    }
}
