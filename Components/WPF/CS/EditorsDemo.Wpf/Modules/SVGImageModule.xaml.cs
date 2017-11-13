using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Editors;
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

namespace EditorsDemo {
    public partial class SVGImageModule {
        public SVGImageModule() {
            InitializeComponent();
        }

        void cmbGlyphSizesEditValueChanged(object sender, EditValueChangedEventArgs e) {
            editor.EditValue = 1;
        }
    }

}
