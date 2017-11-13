using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for CellMerging.
    /// </summary>
    public partial class CellMerging : TutorialControl {
        public CellMerging() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\CellMerging.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.CellMerging.xml";
            // TODO: Add any initialization after the InitForm call
        }
        private void CellMerging_Load(object sender, System.EventArgs e) {
            InitIssueListData(dsIssueList1);
            ceMerging.Checked = gridView1.OptionsView.AllowCellMerge;
        }
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView {
            get {
                return gridView1;
            }
        }
        protected override void InitXMLData(DataSet ds) {
            this.gridControl1.DataSource = ds.Tables["Items"];
            this.repositoryItemLookUpEdit1.DataSource = ds.Tables["Projects"];
            this.repositoryItemLookUpEdit2.DataSource = ds.Tables["Users"];
        }
        //<ceMerging>
        private void ceMerging_CheckedChanged(object sender, System.EventArgs e) {
            gridView1.OptionsView.AllowCellMerge = ceMerging.Checked;
        }
        //</ceMerging>
        //<simpleButton1>
        private void simpleButton1_Click(object sender, EventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }
        //</simpleButton1>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
