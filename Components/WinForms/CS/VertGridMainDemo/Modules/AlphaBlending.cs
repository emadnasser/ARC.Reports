using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraVerticalGrid.Demos {
	/// <summary>
	/// Summary description for AlphaBlending.
	/// </summary>
	public partial class AlphaBlending : TutorialControl {
		public AlphaBlending() {
			InitializeComponent();
		}
        public override VGridControlBase ExportControl { get { return vGridControl1; } }
		public override VGridControlBase ViewOptionsControl { get { return vGridControl1; } }
        DevExpress.XtraVerticalGrid.Design.XAppearances xs = new DevExpress.XtraVerticalGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + "\\DevExpress.XtraVerticalGrid.Appearances.xml");
		#region Init
		private void AlphaBlending_Load(object sender, System.EventArgs e) {
			InitData();
			InitStyles();
		}
		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Cars.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				vGridControl1.DataSource = dataSet.Tables[0].DefaultView;
			}
		}

		
		private void InitStyles() {
			lsStyles.Items.AddRange(xs.FormatNames);
			lsStyles.SelectedIndex = lsStyles.Items.Count > 3 ? 4 : 0;
			lsImages.SelectedIndex = 1;
		}
		#endregion
		#region Editing
		private void lsStyles_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(lsStyles.SelectedItem != null) 
				xs.LoadScheme(lsStyles.SelectedItem.ToString(), vGridControl1);
			RefreshAlphaBlending();
		}

		private void button1_Click(object sender, System.EventArgs e) {
			xtraVertGridBlending1.ShowDialog();
		}

		private Image GetImage(string s) {
			System.IO.Stream str = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraVerticalGrid.Demos.Images." + s + ".jpg");
			if(str != null)
				return Bitmap.FromStream(str);
			return null;
		}

		private void lsImages_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(lsImages.SelectedItem != null) 
				xtraVertGridBlending1.VertGridControl.BackgroundImage = GetImage(lsImages.SelectedItem.ToString());				
		}

		private void RefreshAlphaBlending() {
			xtraVertGridBlending1.RefreshStyles();
		}

		private void chAlphaBlending_CheckedChanged(object sender, System.EventArgs e) {
			xtraVertGridBlending1.Enabled = chAlphaBlending.Checked;		
			button1.Enabled = chAlphaBlending.Checked;
		}
		#endregion
	}
}
