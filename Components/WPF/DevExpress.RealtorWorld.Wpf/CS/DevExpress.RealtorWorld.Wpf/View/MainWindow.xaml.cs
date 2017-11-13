using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core;
using DevExpress.RealtorWorld.Xpf.ViewModel;

namespace DevExpress.RealtorWorld.Xpf.View {
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWPF, this);
        }
    }
}
