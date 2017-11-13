using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials  {
	/// <summary>
	/// Summary description for GridColumnCustomization.
	/// </summary>
	public partial class GridColumnCustomization : TutorialControl {
		public GridColumnCustomization() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        bool show = false;

		private void GridColumnCustomization_Load(object sender, System.EventArgs e) {
			InitData();
			InitCustomization();
		}

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Contacts.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				gridControl1.DataSource = dataSet.Tables[0].DefaultView;
			}
		}

		private void InitCustomization() {
			checkEdit1.Checked = advBandedGridView1.OptionsCustomization.AllowChangeColumnParent;
			checkEdit2.Checked = advBandedGridView1.OptionsCustomization.AllowChangeBandParent;
			checkEdit3.Checked = advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm;
			show = true;
			ShowColumnSelector();
		}

      //<simpleButton1>
		private void simpleButton1_Click(object sender, System.EventArgs e) {
			show = !show;
			ShowColumnSelector();
		}

		
		private void ShowColumnSelector() { ShowColumnSelector(true); }
		private void ShowColumnSelector(bool showForm) {
			if(show) {
				simpleButton1.Text = "Hide Columns &Selector";
				if(showForm) advBandedGridView1.ColumnsCustomization();
			} else {
				simpleButton1.Text = "Show Columns &Selector";
				if(showForm) advBandedGridView1.DestroyCustomization();
			}
		}

		private void advBandedGridView1_ShowCustomizationForm(object sender, System.EventArgs e) {
			show = true;
			ShowColumnSelector(false);
		}

		private void advBandedGridView1_HideCustomizationForm(object sender, System.EventArgs e) {
			show = false;
			ShowColumnSelector(false);
		}
      //</simpleButton1>

		//<checkEdit1>
		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit; 
			advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = edit.Checked;
		}
		//</checkEdit1>

      //<checkEdit2>
		private void checkEdit2_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit; 
			advBandedGridView1.OptionsCustomization.AllowChangeBandParent = edit.Checked;
		}
      //</checkEdit2>

      //<checkEdit3>
		private void checkEdit3_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit; 
			advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = edit.Checked;
		}
      //</checkEdit3>

		public override void StartWhatsThis() {
			show = false;
			ShowColumnSelector();
		}
	}
}
