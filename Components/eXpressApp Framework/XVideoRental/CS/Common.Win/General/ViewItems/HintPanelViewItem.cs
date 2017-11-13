using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using Common.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Utils.Frames;

[assembly: OnlineRepoLocation("http://goo.gl/IJlBz")]
[assembly: OnlineRepoLocation("http://goo.gl/IE3tK")]
[assembly: OnlineRepoLocation("http://goo.gl/yMNwd")]

namespace Common.Win.General.ViewItems {
    [ViewItem(typeof(IModelHintPanel))]
    public class HintPanelViewItem : ViewItem {
        readonly IModelHintPanel _model;

        public HintPanelViewItem(IModelHintPanel modelHintPanel, Type objectType)
            : base(objectType, modelHintPanel.Id) {
            _model = modelHintPanel;
        }
        #region Overrides of ViewItem
        protected override object CreateControlCore() {
            return new NotePanel8_1 { Text = _model.Text };
        }
        #endregion
        public IModelHintPanel Model {
            get { return _model; }
        }
    }

    public interface IModelHintPanel : IModelViewItem {
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        string Text { get; set; }
    }
}
