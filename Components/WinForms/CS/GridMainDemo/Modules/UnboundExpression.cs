using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos {
    public partial class UnboundExpression : TutorialControl {
        public UnboundExpression() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\UnboundExpression.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.UnboundExpression.xml";
            //<gridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.

            ~Discount Amount column:
            gridColumn7.OptionsColumn.AllowEdit = false;
            gridColumn7.ShowUnboundExpressionMenu = true;
            gridColumn7.UnboundExpression = "[UnitPrice] * [Quantity] - [Total]";
            gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;

            ~Total column:
            gridColumn6.OptionsColumn.AllowEdit = false;
            gridColumn6.ShowUnboundExpressionMenu = true;
            gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])";
            gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            */
            //</gridControl1>
        }

        private void UnboundExpression_Load(object sender, EventArgs e) {
            InitNWindData();
            InitCombo();
            gridView1.ExpandAllGroups();
        }

        private void InitCombo() {
            foreach(GridColumn column in gridView1.Columns)
                if(column.ShowUnboundExpressionMenu)
                    imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(column.GetTextCaption(), column, column.ImageIndex));
            imageComboBoxEdit1.SelectedIndex = 0;
        }

        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
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
        public override BaseView ExportView { get { return gridControl1.MainView; } }
        //<simpleButton1>
        private void simpleButton1_Click(object sender, EventArgs e) {
            GridColumn column = imageComboBoxEdit1.EditValue as GridColumn;
            if(column == null) return;
            gridView1.ShowUnboundExpressionEditor(column);
        }
        //</simpleButton1>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
