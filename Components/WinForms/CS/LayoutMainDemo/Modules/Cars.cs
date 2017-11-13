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
	public partial class Cars : BaseTutorialControl {
		public Cars() {
			// This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog();
			InitializeComponent();
			InitData();
			
			// TODO: Add any initialization after the InitForm call

		}

		public override LayoutControl BaseLayout { get { return layoutControl1;} }
		protected override string FileMask { get { return "cars_";} }

		private void InitData() {
			layoutControl1.SetDefaultLayout();
			InitPanels();
			GetCarsData(null);
			dataNavigator1.DataSource = TutorialDataView;
			this.pictureEdit1.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Picture"));
			this.memoEdit1.DataBindings.Add(new Binding("Text", TutorialDataView, "Description"));
			this.textEdit1.DataBindings.Add(new Binding("Text", TutorialDataView, "Trademark"));
			this.textEdit2.DataBindings.Add(new Binding("Text", TutorialDataView, "Model"));
			this.imageComboBoxEdit1.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Category"));
			this.hyperLinkEdit1.DataBindings.Add(new Binding("Text", TutorialDataView, "Hyperlink"));
			this.calcEdit1.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Price"));
			this.dateEdit1.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Delivery Date"));
			this.checkEdit1.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Is In Stock"));
			this.textEdit3.DataBindings.Add(new Binding("Text", TutorialDataView, "HP"));
			this.textEdit4.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Liter"));
			this.spinEdit1.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Cyl"));
			this.spinEdit2.DataBindings.Add(new Binding("EditValue", TutorialDataView, "MPG Highway"));
			this.spinEdit3.DataBindings.Add(new Binding("EditValue", TutorialDataView, "MPG City"));
			this.spinEdit4.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Transmiss Speed Count"));
			this.checkEdit2.DataBindings.Add(new Binding("EditValue", TutorialDataView, "Transmiss Automatic"));
		}

		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			layoutControl1.BeginUpdate();
			calcEdit1.Enabled = dateEdit1.Enabled = checkEdit1.Checked;
			layoutControl1.EndUpdate();
		}
	}
}
