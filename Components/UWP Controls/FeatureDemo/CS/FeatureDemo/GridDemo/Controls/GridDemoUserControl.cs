using DevExpress.UI.Xaml.Grid;
using FeatureDemo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Display;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace GridDemo {
    public abstract class GridDemoUserControl : DemoModuleView {
        public double MinGridWidth { get { return Grid.VisibleColumns.Sum(column => column.FixedWidth ? column.Width : column.MinWidth); }}
        protected internal abstract GridControl Grid { get; }
        public virtual void OnNavigatingFrom() {
            SizeChanged -= GridDemoUserControl_SizeChanged;
            Grid.EndGrouping -= Grid_EndGrouping;
        }
        public virtual void OnNavigatedTo() {
            SizeChanged += GridDemoUserControl_SizeChanged;
            Grid.EndGrouping += Grid_EndGrouping;
            UpdateAutoWidth();
        }

        void Grid_EndGrouping(object sender, EventArgs e) {
            UpdateAutoWidth();
        }
        void GridDemoUserControl_SizeChanged(object sender, Windows.UI.Xaml.SizeChangedEventArgs e) {
            UpdateAutoWidth();
        }
        void UpdateAutoWidth() {
            if(NeedChangeAutoWidth)
                Grid.AutoWidth = Grid.ActualWidth > MinGridWidth;
        }
        protected virtual bool NeedChangeAutoWidth { get { return true; } }
    }
}
