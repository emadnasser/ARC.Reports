using Common.Win;
using Common.Win.ColumnView.Model;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp.Model;
using DevExpress.XtraGrid.Columns;

[assembly: OnlineRepoLocation("http://goo.gl/KsbW2")]

namespace Common.Win.LayoutView.Model {
    public class LayoutViewModelAdapterController : ColumnViewModelAdapterController {

        protected override void ExtendInterfaces(ModelInterfaceExtenders extenders) {

            extenders.Add<IModelListView, IModelListViewOptionsLayoutView>();
            extenders.Add<IModelColumn, IModelColumnOptionsLayoutView>();

            var builder = new InterfaceBuilder(extenders);
            var assembly = BuildAssembly(builder, typeof(XafLayoutView), typeof(LayoutViewColumn));


            builder.ExtendInteface<IModelOptionsLayoutView, XafLayoutView>(assembly);
            builder.ExtendInteface<IModelOptionsColumnLayoutView, LayoutViewColumn>(assembly);
        }

    }

}
