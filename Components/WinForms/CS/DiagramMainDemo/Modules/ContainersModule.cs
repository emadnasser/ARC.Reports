using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraDiagram.Demos;
using DevExpress.DXperience.Demos;
using DevExpress.Diagram.Core;
using DevExpress.Utils;

namespace DevExpress.XtraDiagram.Demos {
    public partial class ContainersModule : DiagramTutorialControl {
        public ContainersModule() {
            InitializeComponent();
            diagramControl.OptionsView.PropertiesPanelVisibility = PropertiesPanelVisibility.Collapsed;
            LoadDocument("Containers.xml");
            diagramControl.SizeChanged += OnSizeChangedHandler;
        }
        void OnSizeChangedHandler(object sender, EventArgs e) {
            var diagramControl = (DiagramControl)sender;
            diagramControl.SizeChanged -= OnSizeChangedHandler;
            diagramControl.FitToWidth();
            diagramControl.AlignCanvas(HorzAlignment.Center, VertAlignment.Top);
        }
    }
}
