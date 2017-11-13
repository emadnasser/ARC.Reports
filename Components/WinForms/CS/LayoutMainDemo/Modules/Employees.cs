using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraLayout.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class Employees : BaseTutorialControl {
		public Employees() {
			// This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog();
			InitializeComponent();
			InitData();
			// TODO: Add any initialization after the InitForm call

		}

		private void InitData() {
			layoutControl1.SetDefaultLayout();
			InitPanels();
			this.pictureEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsEmployees1, "Employees.Photo"));
			lookUpEdit1.Properties.DataSource = GetNWindData(dsEmployees1, "Employees");
		}

		public override LayoutControl BaseLayout { get { return layoutControl1;} }
		protected override string FileMask { get { return "nwind_";} }
	}
}
