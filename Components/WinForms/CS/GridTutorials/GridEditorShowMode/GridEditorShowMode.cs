using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridEditorShowMode.
	/// </summary>
	public partial class GridEditorShowMode : TutorialControl {
		public GridEditorShowMode() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			InitEditors();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        bool updateValues = false;
		private void GridEditorShowMode_Load(object sender, System.EventArgs e) {
			InitNWindData();
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
        		
		void InitEditors() {
            imageComboBoxEdit1.Properties.Items.AddEnum(typeof(DevExpress.Utils.EditorShowMode));
            imageComboBoxEdit2.Properties.Items.AddEnum(typeof(DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum)); 
			updateValues = true;
			imageComboBoxEdit1.EditValue = gridView1.OptionsBehavior.EditorShowMode;
			imageComboBoxEdit2.EditValue = gridView1.OptionsView.ShowButtonMode;
			checkEdit1.EditValue = gridView1.OptionsBehavior.Editable;
			UpdateEnableMode();
			updateValues = false;
		}

		void UpdateEnableMode() {
			imageComboBoxEdit1.Enabled = 
			imageComboBoxEdit2.Enabled = gridView1.OptionsBehavior.Editable;
		}

        //<checkEdit1>
		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			if(updateValues) return;
			DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
			gridView1.OptionsBehavior.Editable = checkEdit.Checked;
			UpdateEnableMode();
		}
        //</checkEdit1>

        //<imageComboBoxEdit1>
		private void imageComboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(updateValues) return;
			DevExpress.XtraEditors.ImageComboBoxEdit edit = sender as DevExpress.XtraEditors.ImageComboBoxEdit;
			gridView1.OptionsBehavior.EditorShowMode = (DevExpress.Utils.EditorShowMode)edit.EditValue;
		}
        //</imageComboBoxEdit1>

        //<imageComboBoxEdit2>
		private void imageComboBoxEdit2_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(updateValues) return;
			DevExpress.XtraEditors.ImageComboBoxEdit edit = sender as DevExpress.XtraEditors.ImageComboBoxEdit;
            gridView1.OptionsView.ShowButtonMode = (DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum)edit.EditValue;
		}
        //</imageComboBoxEdit2>
	}
}
