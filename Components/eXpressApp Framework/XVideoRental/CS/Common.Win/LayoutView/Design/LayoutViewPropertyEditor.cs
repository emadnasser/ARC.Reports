using Common.Win;
using Common.Win.ColumnView.Design;
using DevExpress.ExpressApp.Model;
using DevExpress.LookAndFeel;

[assembly: OnlineRepoLocation("http://goo.gl/2qzWs")]

namespace Common.Win.LayoutView.Design {
    public class LayoutViewPropertyEditor : ColumnViewPropertyEditor<LayoutViewListEditor> {
        protected override ColumnViewDesignerForm GetViewDesignerForm(IModelListView listView) {
            return new LayoutViewDesignerForm(UserLookAndFeel.Default, listView.Application.Title);
        }

        protected override LayoutViewListEditor GetGridDesignerEditor(IModelListView listView) {
            return new LayoutViewListEditor(listView);
        }
    }
}
