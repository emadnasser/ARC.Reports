using System.Collections;
using System.Collections.Generic;
using Common.Win.ChartControl.Model;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Chart.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;

namespace Common.Win.ChartControl {
    [OnlineRepoLocation("http://goo.gl/Cp3vN")]
    [ListEditor(typeof(object), false)]
    public class XpandChartListEditor : ChartListEditor, ISelectionCriteria {
        readonly List<object> _selectedObjects = new List<object>();

        public XpandChartListEditor(IModelListView model)
            : base(model) {

        }
        public override IList GetSelectedObjects() {
            return _selectedObjects;
        }

        #region Implementation of ICustomSelectedObjects
        void ISelectionCriteria.AddSelectedObjects(IEnumerable<object> objects) {
            _selectedObjects.Clear();
            _selectedObjects.AddRange(objects);
            OnSelectionChanged();
        }

        CriteriaOperator ISelectionCriteria.SelectionCriteria { get; set; }
        #endregion
    }

}
