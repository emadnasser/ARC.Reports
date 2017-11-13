using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for AlphaBlending.
	/// </summary>
	public partial class AlphaBlending : TutorialControl {
		public AlphaBlending() {
			//
			// Required for Windows Form Designer support
			//
			CreateWaitDialog();
			InitializeComponent();
			InitNWindData();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        protected override bool AllowAppearanceGroup { get { return false; } }
		#region Init
		private void AlphaBlending_Load(object sender, System.EventArgs e) {
			gridControl1.ForceInitialize();
			InitStyles();
		}
		private GridControl CurrentGrid { get { return gridControl1; }}
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString);

            SetWaitDialogCaption(Properties.Resources.LoadingEmployees);
            oleDbDataAdapter.Fill(ds, "Employees");

            CurrentGrid.DataSource = ds.Tables["Employees"];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            ds.ReadXml(dataFileName);

            CurrentGrid.DataSource = ds.Tables["Employees"];
        }
		private void InitStyles() {
			cbeStyles.Properties.Items.AddRange(GridRibbonMenuManager.XAppearances.FormatNames);
			cbeStyles.EditValue = "Vagabond";
			cbeImages.SelectedIndex = 1;
		}
		#endregion
		#region Grid events
		private void advBandedGridView1_EndGrouping(object sender, System.EventArgs e) {
			advBandedGridView1.ExpandAllGroups();
		}
		#endregion
		#region Editing
		private void cbeStyles_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(cbeStyles.EditValue != null) 
				GridRibbonMenuManager.XAppearances.LoadScheme(cbeStyles.EditValue.ToString(), CurrentGrid.MainView);
			RefreshAlphaBlending();
		}

		private void btnEditAlphaBlending_Click(object sender, System.EventArgs e) {
			xtraGridBlending1.ShowDialog();
		}

		private Image GetImage(string s) {
			System.IO.Stream str = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraGrid.Demos.Images." + s + ".jpg");
			if(str != null)
				return Bitmap.FromStream(str);
			return null;
		}

		private void cbeImages_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(cbeImages.EditValue != null) 
				xtraGridBlending1.GridControl.BackgroundImage = GetImage(cbeImages.EditValue.ToString());
		}

		private void RefreshAlphaBlending() {
			if(xtraGridBlending1.Enabled)
				xtraGridBlending1.RefreshStyles();
		}

		private void chAlphaBlending_CheckedChanged(object sender, System.EventArgs e) {
			CheckEdit chb = sender as CheckEdit;
			xtraGridBlending1.Enabled = chb.Checked;
			btnEditAlphaBlending.Enabled = chb.Checked;
		}
		#endregion
	}
}
