using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridOptions.
	/// </summary>
	public partial class GridOptions : TutorialControl {
		public GridOptions() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Init
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
		#endregion
		private void GridOptions_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitOptions(gridView1.OptionsView, checkedListBoxControl1);
			InitOptions(gridView1.OptionsBehavior, checkedListBoxControl2);
		}

		private void InitOptions(object options, DevExpress.XtraEditors.CheckedListBoxControl checkedListBox) {
			ArrayList arr = DevExpress.Utils.SetOptions.GetOptionNames(options);
			for(int i = 0; i < arr.Count; i++)
				checkedListBox.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem
					(arr[i], DevExpress.Utils.SetOptions.OptionValueByString(arr[i].ToString(), options)));
		}

      //<checkedListBoxControl1>
		private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
			bool optionSet = e.State == CheckState.Checked ? true : false;
			string option = checkedListBoxControl1.GetDisplayItemValue(e.Index).ToString();
			DevExpress.Utils.SetOptions.SetOptionValueByString(option, gridView1.OptionsView, optionSet);
		}
      //</checkedListBoxControl1>

      //<checkedListBoxControl2>
		private void checkedListBoxControl2_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
			bool optionSet = e.State == CheckState.Checked ? true : false;
			string option = checkedListBoxControl2.GetDisplayItemValue(e.Index).ToString();
			DevExpress.Utils.SetOptions.SetOptionValueByString(option, gridView1.OptionsBehavior, optionSet);
		}
      //</checkedListBoxControl2>

		private void gridView1_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
			e.PreviewText = string.Format("{0}\r\n{1}", gridView1.GetRowCellDisplayText(e.RowHandle, gridColumn2), gridView1.GetRowCellDisplayText(e.RowHandle, gridColumn3));
		}
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
