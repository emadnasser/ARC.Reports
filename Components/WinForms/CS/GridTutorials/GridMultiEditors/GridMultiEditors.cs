using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridMultiEditors.
	/// </summary>
	public partial class GridMultiEditors : TutorialControl {
		public GridMultiEditors() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridMultiEditors_Load(object sender, System.EventArgs e) {
			InitData();
		}
		
		private void InitData() {
			GridMultiEditorsRecord[] records = new GridMultiEditorsRecord[9];
			records[0] = new GridMultiEditorsRecord("Product Name", "Chai", "Teatime Chocolate Biscuits", "Ipoh Coffee");
			records[1] = new GridMultiEditorsRecord("Category", "1", "2", "1");
			records[2] = new GridMultiEditorsRecord("Supplier", "Exotic Liquids", "Specialty Biscuits, Ltd.", "Leka Trading");
			records[3] = new GridMultiEditorsRecord("Quantity Per Unit", "10 boxes x 20 bags", "10 boxes x 12 pieces", "16 - 500 g tins");
			records[4] = new GridMultiEditorsRecord("Unit Price", 18.00, 9.20, 46.00);
			records[5] = new GridMultiEditorsRecord("Units in Stock", 39, 25, 17);
			records[6] = new GridMultiEditorsRecord("Discontinued", true, false, true);
			records[7] = new GridMultiEditorsRecord("Last Order", new DateTime(2004, 12, 14), new DateTime(2003, 7, 20), new DateTime(2002, 1, 7));
			records[8] = new GridMultiEditorsRecord("Relevance", 70, 90, 50);

			gridControl1.DataSource = records;
		}

      //<gridControl1>
		private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
			if(e.Column.FieldName != "Category") {
				switch(e.RowHandle) {
					case 1: 
						e.RepositoryItem = repositoryItemImageComboBox1;
						break;
					case 2: 
						e.RepositoryItem = repositoryItemComboBox1;
						break;
					case 4: 
						e.RepositoryItem = repositoryItemCalcEdit1;
						break;
					case 5: 
						e.RepositoryItem = repositoryItemSpinEdit1;
						break;
					case 6: 
						e.RepositoryItem = repositoryItemCheckEdit1;
						break;
					case 7: 
						e.RepositoryItem = repositoryItemDateEdit1;
						break;
					case 8: 
						e.RepositoryItem = repositoryItemProgressBar1;
						break;
				}
			}
		}
      //</gridControl1>

		private void gridView1_RowCellDefaultAlignment(object sender, DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs e) {
			if(e.Column.FieldName != "Category") 
				if(e.RowHandle == 4 || e.RowHandle == 5) 
					e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far;
		}
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
