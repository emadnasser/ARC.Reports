using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Common {
    public class SearchControl : Control {
        #region Depndency Properties
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(SearchControl), new PropertyMetadata(null,
                (d, e) => ((SearchControl)d).OnFilterTextChanged(e)));
        public static readonly DependencyProperty SourceFilterCriteriaProperty =
            DependencyProperty.Register("SourceFilterCriteria", typeof(object), typeof(SearchControl), new PropertyMetadata(null,
                (d, e) => ((SearchControl)d).OnSourceFilterCriteriaChanged(e)));
        public static readonly DependencyProperty CriteriaParserProperty =
            DependencyProperty.Register("CriteriaParser", typeof(Func<string, CriteriaOperator>), typeof(SearchControl), new PropertyMetadata(null,
                (d, e) => ((SearchControl)d).OnCriteriaParserChanged(e)));
        public static readonly DependencyProperty ResultFilterCriteriaProperty =
            DependencyProperty.Register("ResultFilterCriteria", typeof(object), typeof(SearchControl), new PropertyMetadata(null));
        #endregion

        public SearchControl() {
            DefaultStyleKey = typeof(SearchControl);
        }

        public string FilterText { get { return (string)GetValue(FilterTextProperty); } set { SetValue(FilterTextProperty, value); } }
        public CriteriaOperator SourceFilterCriteria { get { return (CriteriaOperator)GetValue(SourceFilterCriteriaProperty); } set { SetValue(SourceFilterCriteriaProperty, value); } }
        public Func<string, CriteriaOperator> CriteriaParser { get { return (Func<string, CriteriaOperator>)GetValue(CriteriaParserProperty); } set { SetValue(CriteriaParserProperty, value); } }
        public CriteriaOperator ResultFilterCriteria { get { return (CriteriaOperator)GetValue(ResultFilterCriteriaProperty); } private set { SetValue(ResultFilterCriteriaProperty, value); } }

        void OnFilterTextChanged(DependencyPropertyChangedEventArgs e) { UpdateResultFilterCriteria(); }
        void OnCriteriaParserChanged(DependencyPropertyChangedEventArgs e) { UpdateResultFilterCriteria(); }
        void OnSourceFilterCriteriaChanged(DependencyPropertyChangedEventArgs e) { UpdateResultFilterCriteria(); }
        void UpdateResultFilterCriteria() {
            CriteriaOperator filter = CriteriaParser == null || FilterText == null ? null : CriteriaParser(FilterText);
            bool filterisNull = (object)filter == null;
            bool sourceFilterCriteriaIsNull = (object)SourceFilterCriteria == null;
            if(!filterisNull && !sourceFilterCriteriaIsNull)
                ResultFilterCriteria = new GroupOperator(GroupOperatorType.And, filter, SourceFilterCriteria);
            else if(!filterisNull)
                ResultFilterCriteria = filter;
            else if(!sourceFilterCriteriaIsNull)
                ResultFilterCriteria = SourceFilterCriteria;
            else
                ResultFilterCriteria = null;
        }
    }
}
