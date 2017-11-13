using System.ComponentModel;
using Common.Win;
using DevExpress.ExpressApp.Model;

[assembly: OnlineRepoLocation("http://goo.gl/ZvdkP")]

namespace Common.Win.ModelAdapter {

    public interface IModelNodeEnabled : IModelNode {
        [DefaultValue(true)]
        [Category("Activation")]
        bool NodeEnabled { get; set; }

    }
}
