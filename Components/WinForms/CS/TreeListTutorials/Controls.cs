using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Blending;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
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
			TreeList treeList = ctrl as TreeList;
			if(treeList != null) treeList.MenuManager = manager;
		}
	}
    public class TreeListTutorialMenu : DevExpress.DXperience.Demos.LookAndFeelMenu {
        public TreeListTutorialMenu(BarManager manager, DefaultLookAndFeel lookAndFeel, string about) : base(manager, lookAndFeel, about) { }
        protected override string ProductName { get { return "XtraTreeList"; } }
        protected override void biProductWebPage_Click(object sender, ItemClickEventArgs e) {
            System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraTreeList/");
        }
        protected override void miAboutProduct_Click(object sender, ItemClickEventArgs e) {
            TreeList.About();
        }
    }
}
