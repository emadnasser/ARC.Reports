using Common.Win;
using Common.Win.ColumnView.Design;
using DevExpress.Utils.Design;
using DevExpress.XtraGrid.Views.Layout.Designer;

[assembly: OnlineRepoLocation("http://goo.gl/ZXphE")]

namespace Common.Win.LayoutView.Design {
    public class LayoutViewDesigner : ColumnViewDesigner {
        protected override void CreateGroups() {
            base.CreateGroups();
            
            var designerItem = new DesignerItem("Layout", "Customize the current view's layout and preview its data.", typeof(LayoutViewCustomizer), GetDefaultLargeImage(4), GetDefaultSmallImage(4), null);
            var designerGroup = new DesignerGroup("Layout", "Customize the current view's layout and preview its data.", GetDefaultLargeImage(4)){
                designerItem
            };
            Groups.Add(designerGroup);
        }
    }
}
