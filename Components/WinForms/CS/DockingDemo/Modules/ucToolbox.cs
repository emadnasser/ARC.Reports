using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraBars.Demos.DockingDemo {
    public partial class ucToolbox : UserControl {
        public ucToolbox() {
            InitializeComponent();
            NavBarGroup standardGroup = navBar.Groups.Add();
            standardGroup.Caption = "Standard";
            standardGroup.Name = "Standard";
            NavBarGroup devexpressGroup = navBar.Groups.Add();
            devexpressGroup.Caption = "DevExpress";
            devexpressGroup.Name = "DevExpress";
            devexpressGroup.Expanded = true;
            foreach(string key in toolboxImages.Images.Keys) {
                NavBarItem item = new NavBarItem();
                var caption =GetCaption(key);
                item.Caption = caption;
                item.Name = caption;
                item.SmallImageIndex = toolboxImages.Images.IndexOfKey(key);
                navBar.Items.Add(item);
                if(!key.Contains("DX"))
                    standardGroup.ItemLinks.Add(item);
                else
                    devexpressGroup.ItemLinks.Add(item);
            }
        }
        string GetCaption(string key) {
            return key.Substring(0, key.IndexOf('_'));
        }
    }
}
