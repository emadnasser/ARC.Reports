using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridCalcRowHeight.
	/// </summary>
	public partial class GridCalcRowHeight : TutorialControl {
		public GridCalcRowHeight() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridCalcRowHeight_Load(object sender, System.EventArgs e) {
			InitData();
			radioGroup1.SelectedIndex = 1;
		}

		private void InitData() {
			DataSet ds = new DataSet();
			System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GridTutorials.GridCalcRowHeight.Employees.xml");
			ds.ReadXml(stream);
			stream.Close();
			gridControl1.DataSource = ds.Tables[0];
		}

      //<radioGroup1>
		private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
			gridView1.OptionsView.RowAutoHeight = radioGroup1.EditValue.Equals(1);
			gridView1.LayoutChanged();
		}
      
		private void gridView1_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e) {
			if(radioGroup1.EditValue == null) return;
			if(e.RowHandle >= 0 && radioGroup1.EditValue.Equals(0))
				e.RowHeight = (int)gridView1.GetDataRow(e.RowHandle)["RowHeight"];
		}
      //</radioGroup1>
	}
}
