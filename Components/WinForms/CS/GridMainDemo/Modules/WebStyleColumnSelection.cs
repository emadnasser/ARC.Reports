using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class WebStyleColumnSelection : TutorialControl {
        bool initData = false;
        public WebStyleColumnSelection() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\WebStyleColumnSelection.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.WebStyleColumnSelection.xml";
            InitNWindData();
            InitEditors();
            InitData();
        }
        public override BaseView ExportView { get { return gridView1; } }
        protected override void InitMDBData(string connectionString) {
            string tblGrid = "[Order Details]", tblLookUp = "Products";
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingOrderDetails);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingProducts);
            oleDbDataAdapter.Fill(ds, tblLookUp);

            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        void InitEditors() {
            foreach(DefaultBoolean val in Enum.GetValues(typeof(DefaultBoolean))) {
                icbShowCheckBoxSelectorInGroupRow.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowCheckBoxSelectorInHeader.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowCheckBoxSelectorInPrintExport.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
            }
        }
        void InitData() {
            initData = true;
            try {
                icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow;
                icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader;
                icbShowCheckBoxSelectorInPrintExport.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport;
                cePrintSelectedRowsOnly.Checked = gridView1.OptionsPrint.PrintSelectedRowsOnly;
            } finally { }
            initData = false;
        }

        //<icbShowCheckBoxSelectorInGroupRow>
        private void icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(object sender, EventArgs e) {
            if(initData) return;
            gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = (DefaultBoolean)icbShowCheckBoxSelectorInGroupRow.EditValue;
        }
        //</icbShowCheckBoxSelectorInGroupRow>

        //<icbShowCheckBoxSelectorInHeader>
        private void icbShowCheckBoxSelectorInColumnHeader_SelectedIndexChanged(object sender, EventArgs e) {
            if(initData) return;
            gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = (DefaultBoolean)icbShowCheckBoxSelectorInHeader.EditValue;
        }
        //</icbShowCheckBoxSelectorInHeader>

        //<icbShowCheckBoxSelectorInPrintExport>
        private void icbShowCheckBoxSelectorInPrintExport_SelectedIndexChanged(object sender, EventArgs e) {
            if(initData) return;
            gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = (DefaultBoolean)icbShowCheckBoxSelectorInPrintExport.EditValue;
        }
        //</icbShowCheckBoxSelectorInPrintExport>

        //<cePrintSelectedRowsOnly>
        private void cePrintSelectedRowsOnly_CheckedChanged(object sender, EventArgs e) {
            if(initData) return;
            gridView1.OptionsPrint.PrintSelectedRowsOnly = cePrintSelectedRowsOnly.Checked;
        }
        //</cePrintSelectedRowsOnly>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
