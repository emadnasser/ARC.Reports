using DevExpress.Xpf.DemoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridDemo {
    [CodeFile("ModuleResources/FixedRowsViewModel.(cs)")]
    [CodeFile("ModuleResources/FixedRowsResources.xaml")]
    [CodeFile("ModuleResources/FixedRowsConverters.(cs)")]
    public partial class FixedRows : GridDemoModule {
        public FixedRows() {
            InitializeComponent();
        }
    }
}
