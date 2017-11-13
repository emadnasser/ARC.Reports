using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Blending;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	public class TutorialControl : DevExpress.Tutorials.ModuleBase {
		public virtual bool ShowLookAndFeel { get { return true; } }
        public virtual bool SetNewWhatsThisPadding { get { return false; } }
		public override void StartWhatsThis() {
			TutorialsInfo.CloseCustomizationForm(this);
            if(SetNewWhatsThisPadding) {
                this.Padding = new Padding(8);
                this.Refresh();
            }
		}
        public override void EndWhatsThis() {
            if(SetNewWhatsThisPadding) 
                this.Padding = new Padding(0);
        }
		protected override void SetControlManager(Control ctrl, BarManager manager) {
			DevExpress.XtraGrid.GridControl grid = ctrl as DevExpress.XtraGrid.GridControl;
			if(grid != null) grid.MenuManager = manager;
		}
        public static bool Is64BitOS {
            get {
                return false;
                //return DevExpress.Utils.OSVersionHelper.Is64BitOS();
            }
        }
        #region InitData
        protected virtual void InitNWindData() {
            string DBFileName = string.Empty;
            if(Is64BitOS) {
                DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.xml");
                if(DBFileName != string.Empty) {
                    InitXMLData(DBFileName);
                }
            }
            else {
                DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
                if(DBFileName != string.Empty) {
                    InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName);
                }
            }
        }
        protected virtual void InitMDBData(string connectionString) {
        }
        protected virtual void InitXMLData(string dataFileName) {
        }
        #endregion
	}
    public class GridTutorialMenu : DevExpress.DXperience.Demos.LookAndFeelMenu {
        public GridTutorialMenu(BarManager manager, DefaultLookAndFeel lookAndFeel, string about) : base(manager, lookAndFeel, about) { }
        protected override string ProductName { get { return "XtraGrid"; } }
        protected override void biProductWebPage_Click(object sender, ItemClickEventArgs e) {
            System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraGrid/");
        }
        protected override void miAboutProduct_Click(object sender, ItemClickEventArgs e) {
            GridControl.About();
        }
    }
	public class InitHelper {
		public static void InitAdvBandedView(GridControl grid) {
			InitData(grid);
			InitViewLayout(grid);
		}
		private static void InitData(GridControl grid) {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Cars.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				grid.DataSource = dataSet.Tables[0].DefaultView;
			}
		}

		private static void InitViewLayout(GridControl grid) {
			string LayoutFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Layouts\\cars_AdvBandedView.xml");
			if(LayoutFileName != "") {
				InitEditors(grid);
				grid.MainView.RestoreLayoutFromXml(LayoutFileName, null);
			}
		}

		private static void InitEditors(GridControl grid) {
			RepositoryItemPictureEdit itemPictureEdit = new RepositoryItemPictureEdit();
			RepositoryItemRadioGroup itemRadioGroup = new RepositoryItemRadioGroup();
			RepositoryItemSpinEdit itemSpinEdit = new RepositoryItemSpinEdit();
			RepositoryItemCalcEdit itemCalcEdit = new RepositoryItemCalcEdit();
			RepositoryItemImageComboBox itemImageComboBox = new RepositoryItemImageComboBox();
			itemPictureEdit.Name = "repositoryItemPictureEdit1";
			itemSpinEdit.Name = "repositoryItemSpinEdit1";
			itemCalcEdit.Name = "repositoryItemCalcEdit1";
			itemRadioGroup.Name = "repositoryItemRadioGroup1";
			itemImageComboBox.Name = "repositoryItemImageComboBox1";
			itemSpinEdit.IsFloatValue = false;
			itemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			itemImageComboBox.Items.AddRange(new object[] {
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", -1),
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", -1),
															  new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", -1)});
			itemRadioGroup.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
																								   new DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"),
																								   new DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")});
			grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
																									 itemPictureEdit, itemRadioGroup, itemSpinEdit, itemCalcEdit, itemImageComboBox});
		}
	}
}
