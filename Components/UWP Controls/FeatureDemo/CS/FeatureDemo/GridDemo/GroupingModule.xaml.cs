using DevExpress.Data;
using DevExpress.Data.Native;
using DevExpress.UI.Xaml.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace GridDemo {
    public sealed partial class GroupingModule : GridDemoUserControl {
        public GroupingModule() {
            this.InitializeComponent();
            grid.Loaded += gridLoaded;
        }
        protected internal override GridControl Grid { get { return grid; } }
        void gridLoaded(object sender, RoutedEventArgs e) {
            grid.Loaded -= gridLoaded;
            grid.ExpandGroupRow(-1);
            grid.ExpandGroupRow(-2);
        }
    }
}
