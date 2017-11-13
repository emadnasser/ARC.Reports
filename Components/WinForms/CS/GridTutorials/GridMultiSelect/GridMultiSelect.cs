using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridMultiSelect.
	/// </summary>
	public partial class GridMultiSelect : TutorialControl {
		public GridMultiSelect() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridMultiSelect_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitGrid();
		}

        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }

		private void InitGrid() {
			checkEdit1.Checked = true;
			gridView1.SelectRange(1, 4);
		}

      //<checkEdit1>
		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			if(checkEdit1.Checked) { 
				gridView1.OptionsSelection.MultiSelect = true;
				ShowSelection();
			}
			else { 
				gridView1.OptionsSelection.MultiSelect = false;
				lbSelectedRowsCount.Text = "-1";
				lbSelectedRows.Text = "MultiSelect is Disabled.";
			}
		}
      //</checkEdit1>

      //<gridControl1>
		private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
			ShowSelection();
		}
      //</gridControl1>

		public static string ArrayToString(int[] arr) {
			string s = "";
			if(arr == null)
				s = "Empty...";
			else {
				foreach(int i in arr) 
					s += (s == "" ? "" : ";") + i.ToString();
				s += ".";
			}
			return s;
		}

      //<gridControl1>
		private void ShowSelection() {
			lbSelectedRowsCount.Text = gridView1.SelectedRowsCount.ToString();
			lbSelectedRows.Text = ArrayToString(gridView1.GetSelectedRows());
		}
      //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
