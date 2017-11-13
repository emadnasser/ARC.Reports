using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class TreeMapTutorialControl : TutorialControlBase, IDXMenuManager {
        public TreeMapTutorialControl() {
            this.AutoMergeRibbon = true;
            this.SuspendLayout();
            this.Name = "TreeMapTutorialControl";
            this.Size = new Size(500, 500);
            this.ResumeLayout(false);
        }

        public override bool AutoMergeRibbon { get { return true; } set { } }
        public virtual TreeMapControl TreeMapControl { get { return null; } }
        public IDXMenuManager MenuManager { get; set; }

        IDXMenuManager IDXMenuManager.Clone(Form newForm) { return this; }
        void IDXMenuManager.DisposeManager() { }
        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, MenuManager, control, pos);
        }
    }
}
