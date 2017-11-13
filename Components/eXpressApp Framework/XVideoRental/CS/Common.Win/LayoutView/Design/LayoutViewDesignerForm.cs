using Common.Win;
using Common.Win.ColumnView.Design;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Design;

[assembly: OnlineRepoLocation("http://goo.gl/bKWCt")]

namespace Common.Win.LayoutView.Design {
    public class LayoutViewDesignerForm : ColumnViewDesignerForm {
        public LayoutViewDesignerForm(UserLookAndFeel userLookAndFeel, string title)
            : base(userLookAndFeel, title) {
        }

        protected override BaseDesigner GetActiveDesigner() {
            return new LayoutViewDesigner();
        }
    }
}
