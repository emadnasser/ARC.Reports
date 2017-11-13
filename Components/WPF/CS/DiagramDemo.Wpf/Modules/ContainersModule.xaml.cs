using System;
using System.Collections.Generic;
using System.Windows;

namespace DiagramDemo {
    public partial class ContainersModule : DiagramDemoModule {
        public ContainersModule() {
            InitializeComponent();
            diagramControl.LoadDemoData("Containers.xml");
            diagramControl.Loaded += (o, e) => diagramControl.AlignCanvas(HorizontalAlignment.Center, VerticalAlignment.Top);
        }
    }
}
