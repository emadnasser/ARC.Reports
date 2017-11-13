using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DevExpress.XtraLayout.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class MasterDetail : BaseTutorialControl {
		public MasterDetail() {
			// This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog();
			InitializeComponent();
			layoutControl1.SetDefaultLayout();
			InitPanels();
			InitData();
			pictureEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCategories1, "Categories.Picture"));

			// TODO: Add any initialization after the InitForm call

		}

		public override LayoutControl BaseLayout { get { return layoutControl1;} }
		protected override string FileMask { get { return "md_";} }

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\nwind.mdb");
			if(DBFileName != "") {
				string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
				OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT * FROM Categories", con);
				OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT * FROM Products", con);
				OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT * FROM [Order Details]", con);
				OleDbDataAdapter oleDBAdapter4 = new OleDbDataAdapter("SELECT * FROM Suppliers", con);
				
				SetWaitDialogCaption("Loading Categories...");
				oleDBAdapter1.Fill(dsCategories1.Categories);
		    
				SetWaitDialogCaption("Loading Products...");
				oleDBAdapter2.Fill(dsCategories1.Products);
				
				SetWaitDialogCaption("Loading Order Details...");
				oleDBAdapter3.Fill(dsCategories1.Order_Details);

				SetWaitDialogCaption("Loading Suppliers...");
				oleDBAdapter4.Fill(dsCategories1.Suppliers);
				
			}
		}

		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			layoutControl1.BeginUpdate();
			textEdit2.Enabled = textEdit4.Enabled = lookUpEdit1.Enabled = calcEdit1.Enabled = spinEdit1.Enabled = spinEdit2.Enabled = spinEdit3.Enabled = !checkEdit1.Checked;
			layoutControl1.EndUpdate();
		}

		private void Detail_Validated(object sender, System.EventArgs e) {
			((CurrencyManager)this.BindingContext[this.dataNavigator3.DataSource, this.dataNavigator3.DataMember]).EndCurrentEdit();
		}
	}
}
