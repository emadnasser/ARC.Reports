namespace DevExpress.XtraCharts.Demos {
    public partial class ChartDemoBase3D : ChartDemoBase {
        public ChartDemoBase3D() {
            InitializeComponent();
        }
        protected virtual void UpdateRotationAngles(Diagram3D diagram) {
        }
        protected bool IsFacetEnabled(Bar3DModel barModel) {
            return (barModel.Equals(Bar3DModel.Box) || barModel.Equals(Bar3DModel.Cylinder));
        }
        void btnDefaultAngles_Click(object sender, System.EventArgs e) {
            Diagram3D diagram = ChartControl.Diagram as Diagram3D;
            if (diagram == null)
                return;
            diagram.RotationType = RotationType.UseAngles;
            UpdateRotationAngles(diagram);
            diagram.RotationType = RotationType.UseMouseAdvanced;
        }
    }
}

