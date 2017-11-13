using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views {
    class BottomPanel : ContentControl {
        public BottomPanel() {
            this.SizeChanged += SizeChange;
        }
        ContentPresenter leftColumn;
        ContentPresenter cetralColumn;
        ContentPresenter rightColumn;
        double windowSize = 750d;
        protected override void OnApplyTemplate() {
            base.OnApplyTemplate();
            leftColumn = (ContentPresenter)GetTemplateChild("leftColumn");
            cetralColumn = (ContentPresenter)GetTemplateChild("centralColumn");
            rightColumn = (ContentPresenter)GetTemplateChild("rightColumn");
        }
        void SizeChange(object sender, SizeChangedEventArgs e) {
            if(e.NewSize.Width < windowSize) {
                Grid.SetColumn(cetralColumn, 0);
            }
            if(e.NewSize.Width > windowSize) {
                Grid.SetColumn(cetralColumn, 1);
            }
        }
        #region prop
        public object LeftColumn {
            get { return (int)GetValue(LeftColumnProperty); }
            set { SetValue(LeftColumnProperty, value); }
        }
        public object CentralColumn {
            get { return (int)GetValue(CentralColumnProperty); }
            set { SetValue(CentralColumnProperty, value); }
        }
        public object RightColumn {
            get { return (int)GetValue(RightColumnProperty); }
            set { SetValue(RightColumnProperty, value); }
        }
        #endregion
        #region static
        public static readonly DependencyProperty LeftColumnProperty =
            DependencyProperty.Register("LeftColumn", typeof(object), typeof(BottomPanel), new PropertyMetadata(null));
        public static readonly DependencyProperty CentralColumnProperty =
            DependencyProperty.Register("CentralColumn", typeof(object), typeof(BottomPanel), new PropertyMetadata(null));
        public static readonly DependencyProperty RightColumnProperty =
            DependencyProperty.Register("RightColumn", typeof(object), typeof(BottomPanel), new PropertyMetadata(null));
        #endregion

    }
}
