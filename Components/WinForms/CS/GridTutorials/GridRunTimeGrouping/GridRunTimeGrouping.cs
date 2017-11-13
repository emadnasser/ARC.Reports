using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridRunTimeGrouping.
	/// </summary>
	public partial class GridRunTimeGrouping : TutorialControl {
		public GridRunTimeGrouping() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridRunTimeGrouping_Load(object sender, System.EventArgs e) {
			gridControl1.ForceInitialize();
			InitData();
			InitGroupedColumns();
			gridView1.ExpandAllGroups();
		}

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\cars.xml");
			if(DBFileName != "") {
				DataSet ds = new DataSet();
				ds.ReadXml(DBFileName);
				gridControl1.DataSource = ds.Tables[0];
			}
		}

		private void InitGroupedColumns() {
			for(int i = gridView1.Columns.Count - 1; i >= 0; i--) {
				DevExpress.XtraEditors.CheckEdit checkEdit =
					new DevExpress.XtraEditors.CheckEdit();
                checkEdit.Text = gridView1.Columns[i].GetTextCaption();
				checkEdit.Checked = gridView1.Columns[i].GroupIndex != -1;
				checkEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
				checkEdit.Dock = System.Windows.Forms.DockStyle.Top;
				checkEdit.Properties.FullFocusRect = true;
				checkEdit.TabIndex = gridView1.Columns[i].AbsoluteIndex;
				checkEdit.CheckedChanged += new EventHandler(checkEditCheckedChanged);
				panel1.Controls.Add(checkEdit);
			}
		}

      //<panel1>
		private void checkEditCheckedChanged(object sender, EventArgs e) {
			DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
			int checkEditIndex = checkEdit.TabIndex;

			gridView1.BeginSort();

			if(checkEdit.Checked)
				gridView1.Columns[checkEditIndex].GroupIndex = gridView1.SortInfo.GroupCount;
			else {
				gridView1.Columns[checkEditIndex].GroupIndex = -1;
				gridView1.Columns[checkEditIndex].VisibleIndex = checkEditIndex;
			}

			gridView1.EndSort();
			gridView1.ExpandAllGroups();
         //</panel1>

			foreach(Control ctrl in panel1.Controls) {
				checkEdit = ctrl as DevExpress.XtraEditors.CheckEdit;
				
				if(gridView1.SortInfo.GroupCount >= panel1.Controls.Count - 1) {
					if(!checkEdit.Checked) checkEdit.Enabled = false;
				} else { 
					if(!checkEdit.Enabled) checkEdit.Enabled = true;
				}
			}
      //<panel1>
		}
      //</panel1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
