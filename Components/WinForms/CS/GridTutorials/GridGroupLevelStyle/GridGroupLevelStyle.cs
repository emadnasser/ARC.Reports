using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridGroupLevelStyle.
	/// </summary>
	public partial class GridGroupLevelStyle : TutorialControl {
		public GridGroupLevelStyle() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridGroupLevelStyle_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitGrid();
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

		private void InitGrid() {
			gridView1.ExpandAllGroups();
			spinEdit1.Value = gridView1.LevelIndent;
		}

		private Color ColorFromID(int index) {
			switch(index) {
				case 0: return Color.LightSkyBlue;
				case 1: return Color.LightCoral;
				case 2: return Color.LightGreen;
				case 3: return Color.Yellow;
				case 4: return Color.LightYellow;
				default: return Color.LightGray;
			}
		}

      //<gridControl1>
		private void gridView1_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e) {
			e.LevelAppearance.BackColor = ColorFromID(e.Level);
			if(e.Level == 1) e.LevelAppearance.ForeColor = Color.White;
		}
      //</gridControl1>

		private void gridView1_EndGrouping(object sender, System.EventArgs e) {
			gridView1.ExpandAllGroups();
		}

		private void spinEdit1_EditValueChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.SpinEdit spinEdit = sender as DevExpress.XtraEditors.SpinEdit;
			gridView1.LevelIndent = Convert.ToInt32(spinEdit1.Value);
		}

		public override bool ShowLookAndFeel { get { return false;} }
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
