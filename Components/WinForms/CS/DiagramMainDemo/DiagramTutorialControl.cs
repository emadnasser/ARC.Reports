using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDiagram.Utils;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DiagramTutorialControl : DiagramTutorialControlBase {
        protected override RibbonControl Ribbon {
            get { return containerControl == null ? null : containerControl.Controls.OfType<RibbonControl>().FirstOrDefault(); }
        }

        public DiagramTutorialControl() {
            InitializeComponent();
            Diagram.CreateDocking();
            Diagram.CreateRibbon();
        }
    }
}
