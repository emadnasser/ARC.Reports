using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Blending;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
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
	}
    public class VertGridTutorialMenu : DevExpress.DXperience.Demos.LookAndFeelMenu {
        public VertGridTutorialMenu(BarManager manager, DefaultLookAndFeel lookAndFeel, string about) : base(manager, lookAndFeel, about) { }
        protected override string ProductName { get { return "XtraVerticalGrid"; } }
        protected override void biProductWebPage_Click(object sender, ItemClickEventArgs e) {
            System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraVerticalGrid/");
        }
        protected override void miAboutProduct_Click(object sender, ItemClickEventArgs e) {
            VGridControlBase.About();
        }
    }
}
