using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using Common.Win;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp.Model;

[assembly: OnlineRepoLocation("http://goo.gl/Qms4C")]

namespace Common.Win.ColumnView.Model {

    public interface IModelListViewOptionsColumnView : IModelListView {
    }
    public interface IModelColumnViewColumnOptions : IModelNodeEnabled {

    }
    public interface IModelOptionsColumnView : IModelNodeEnabled {

    }
    [ModelAbstractClass]
    public interface IModelColumnOptionsColumnView : IModelColumn {

    }
    public interface IModelLayoutDesignStore : IModelNodeEnabled {
        [Browsable(false)]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        string LayoutStore { get; set; }
    }

}
