using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridStyleCondition.
    /// </summary>
    public partial class GridStyleCondition : TutorialControl {
        public GridStyleCondition() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridStyleCondition_Load(object sender, System.EventArgs e) {
            InitNWindData();
            ConditionsAdjustment();
        }

        string tblName = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, connectionString);
            oleDbDataAdapter.Fill(ds, tblName);
            gridControl1.DataSource = ds.Tables[tblName];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblName];
        }

        //<gridControl1>
        private void ConditionsAdjustment() {
            StyleFormatCondition cn;
            cn = new StyleFormatCondition(FormatConditionEnum.LessOrEqual, gridView1.Columns["UnitPrice"], null, 18);
            cn.Appearance.BackColor = Color.Yellow;
            gridView1.FormatConditions.Add(cn);
            cn = new StyleFormatCondition(FormatConditionEnum.GreaterOrEqual, gridView1.Columns["UnitPrice"], null, 40);
            cn.Appearance.BackColor = Color.Red;
            cn.Appearance.ForeColor = Color.White;
            gridView1.FormatConditions.Add(cn);
            //</gridControl1>
            cn = new StyleFormatCondition(FormatConditionEnum.Equal, gridView1.Columns["Discontinued"], null, false);
            cn.ApplyToRow = true;
            cn.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
            gridView1.FormatConditions.Add(cn);
            cn = new StyleFormatCondition(FormatConditionEnum.Equal, gridView1.Columns["Discontinued"], null, true);
            cn.ApplyToRow = true;
            cn.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
            cn.Appearance.ForeColor = SystemColors.ControlDark;
            gridView1.FormatConditions.Add(cn);
            //<gridControl1>
            gridView1.BestFitColumns();
        }
        //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
