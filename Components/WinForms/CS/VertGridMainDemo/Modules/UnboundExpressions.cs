using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Design;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.Data;
using DevExpress.XtraVerticalGrid.Events;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class UnboundExpressions : TutorialControl {
        const string
            NewRow = "New",
            TableGrid = "[Order Details]",
            TableLookUp = "Products";

        public UnboundExpressions() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\UnboundExpressions.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.UnboundExpressions.xml";
            InitNWindData();
            //<vGridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            
            rowTotal.Properties.UnboundExpression = "(1 - [Discount]) * [Quantity] * [UnitPrice]";
            rowTotal.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            rowTotal.Properties.ShowUnboundExpressionMenu = true;

            rowTotalAmount.Properties.UnboundExpression = "[Quantity] * [UnitPrice] - [rowTotal0]";
            rowTotalAmount.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            rowTotalAmount.Properties.ShowUnboundExpressionMenu = true;
            */
            //</vGridControl1>
            
            
        }
        public override VGridControlBase ExportControl { get { return this.vGridControl1; } }

        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + TableGrid, connectionString);
            SetWaitDialogCaption("Loading Order Details...");
            oleDbDataAdapter.Fill(ds, TableGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + TableLookUp, connectionString);
            SetWaitDialogCaption("Loading Products...");
            oleDbDataAdapter.Fill(ds, TableLookUp);

            vGridControl1.DataSource = ds.Tables[TableGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[TableLookUp];
        }

        //<addNewRow>
        void addNewRow_Click(object sender, EventArgs e) {
            EditorRow row = new EditorRow();
            row.Tag = NewRow;
            row.Properties.UnboundType = UnboundColumnType.Object;
            row.Properties.ShowUnboundExpressionMenu = true;
            this.vGridControl1.Rows[1].ChildRows.Add(row);
            this.vGridControl1.ShowUnboundExpressionEditor(row.Properties);
        }
        //</addNewRow>

        void vGridControl1_RowChanged(object sender, RowChangedEventArgs e) {
            if(e.ChangeType == RowChangeTypeEnum.UnboundExpression && object.Equals(e.Row.Tag, NewRow)) {
                e.Row.Properties.Caption = e.Row.Properties.UnboundExpression;
            }
        }
    }
}
