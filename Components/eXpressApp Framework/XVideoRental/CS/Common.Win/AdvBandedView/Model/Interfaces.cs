using System.ComponentModel;
using Common.Win;
using Common.Win.ColumnView.Model;
using Common.Win.Common;
using Common.Win.General;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Persistent.Base;
[assembly: OnlineRepoLocation("http://goo.gl/g8XJS")]
namespace Common.Win.AdvBandedView.Model {

    public interface IModelGridBands : IModelNode, IModelList<IModelGridBand> {
    }

    public interface IModelGridBand : IModelNode {
        IModelGridBands GridBands { get; }
    }

    public interface IModelOptionsAdvBandedView : IModelOptionsColumnView {
        IModelGridBands GridBands { get; }
    }

    public interface IModelOptionsColumnAdvBandedView : IModelColumnViewColumnOptions {
    }

    public interface IModelAdvBandedGridBandOptions : IModelNode {
    }

    [ModelAbstractClass]
    public interface IModelGridBandOptions : IModelGridBand {
        IModelAdvBandedGridBandOptions Options { get; }
    }

    [ModelAbstractClass]
    public interface IModelColumnOptionsAdvBandedView : IModelColumnOptionsColumnView {
        [ModelBrowsable(typeof(AdvBandedEditorVisibilityCalculator))]
        IModelOptionsColumnAdvBandedView OptionsColumnAdvBandedView { get; }
        [DataSourceProperty("ListViewBands")]
        [Category("eXpand")]
        [ModelBrowsable(typeof(AdvBandedEditorVisibilityCalculator))]
        IModelGridBand GridBand { get; set; }

        [Browsable(false)]
        IModelList<IModelGridBand> ListViewBands { get; }
    }

    [DomainLogic(typeof(IModelColumnOptionsAdvBandedView))]
    public class MasterDetailRuleDomainLogic {
        public static IModelList<IModelGridBand> Get_ListViewBands(IModelColumnOptionsAdvBandedView modelColumnOptionsAdvBandedView) {
            var viewBands = ((IModelListViewOptionsAdvBandedView)modelColumnOptionsAdvBandedView.ParentView).OptionsAdvBandedView.GridBands;
            return new CalculatedModelNodeList<IModelGridBand>(viewBands.GetItems<IModelGridBand>(band => band.GridBands));
        }
    }

    [ModelAbstractClass]
    public interface IModelListViewOptionsAdvBandedView : IModelListViewOptionsColumnView {
        [ModelBrowsable(typeof(AdvBandedEditorVisibilityCalculator))]
        IModelOptionsAdvBandedView OptionsAdvBandedView { get; }
    }

    public class AdvBandedEditorVisibilityCalculator : EditorTypeVisibilityCalculator {
        public override bool IsVisible(IModelNode node, string propertyName) {
            return typeof(GridListEditor).IsAssignableFrom(EditorType(node)) && node.GetParent<IModelListView>().BandsLayout.Enable;
        }

    }

}
