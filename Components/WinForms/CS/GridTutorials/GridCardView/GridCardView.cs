using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridCardView.
	/// </summary>
	public partial class GridCardView : TutorialControl {
		public GridCardView() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Init
		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Cars.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				gridControl1.DataSource = dataSet.Tables[0].DefaultView;
			}
		}

		private void InitViewLayout() {
			string LayoutFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Layouts\\cars_CardView.xml");
			if(LayoutFileName != "") {
				InitEditors();
				cardView1.RestoreLayoutFromXml(LayoutFileName, null);
			}
		}

		private void InitEditors() {
			RepositoryItemPictureEdit itemPictureEdit = new RepositoryItemPictureEdit();
			RepositoryItemSpinEdit itemSpinEdit = new RepositoryItemSpinEdit();
			RepositoryItemMemoExEdit itemMemoExEdit = new RepositoryItemMemoExEdit();
			RepositoryItemImageComboBox itemImageComboBox = new RepositoryItemImageComboBox();
			itemPictureEdit.Name = "repositoryItemPictureEdit1";
			itemSpinEdit.Name = "repositoryItemSpinEdit1";
			itemMemoExEdit.Name = "repositoryItemMemoExEdit1";
			itemImageComboBox.Name = "repositoryItemImageComboBox1";
			itemImageComboBox.Items.AddRange(new object[] {
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", -1),
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", -1),
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", -1)});
			itemMemoExEdit.PopupFormSize = new Size(300, 150);
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
																												  itemPictureEdit, itemSpinEdit, itemMemoExEdit, itemImageComboBox});
		}
		#endregion
		private void GridCardView_Load(object sender, System.EventArgs e) {
			InitData();
			InitViewLayout();
		}
	}
}
