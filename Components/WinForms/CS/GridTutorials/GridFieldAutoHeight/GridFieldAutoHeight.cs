using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridFieldAutoHeight.
	/// </summary>
	public partial class GridFieldAutoHeight : TutorialControl {
		public GridFieldAutoHeight() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

      //<radioGroup1>
		private void GridFieldAutoHeight_Load(object sender, System.EventArgs e) {
         //</radioGroup1>
			InitData();
			cardView1.FocusedRowHandle = 15;
			//<radioGroup1>
         radioGroup1.Properties.Items[0].Value = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
			radioGroup1.Properties.Items[1].Value = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
			radioGroup1.Properties.Items[2].Value = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
			radioGroup1.EditValue = radioGroup1.Properties.Items[2].Value;
		}
      //</radioGroup1>

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\DXProducts.xml");
			if(DBFileName != "") {
				DataSet ds = new DataSet();
				ds.ReadXml(DBFileName);
				gridControl1.DataSource = ds.Tables[0];
			}
		}

      //<radioGroup1>
		private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
			cardView1.VertScrollVisibility = (DevExpress.XtraGrid.Views.Base.ScrollVisibility)radioGroup1.EditValue;
		}
      //</radioGroup1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
