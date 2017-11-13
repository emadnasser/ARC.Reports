using DevExpress.Diagram.Core;
using System.Linq;
using System.Text.RegularExpressions;
using DevExpress.Utils;
using System.Collections;
using System.Globalization;
using DevExpress.Diagram.Demos;
using DevExpress.Xpf.Diagram;

namespace DiagramDemo {
    public partial class OfficePlanModule : DiagramDemoModule {
        public readonly DiagramStencil OfficeStencil = new DiagramStencil("OfficeShapes", "Office Shapes");

        public OfficePlanModule() {
            InitializeComponent();
            InitializeOfficeStencil();
            diagramControl.Stencils = new DiagramStencilCollection(new[] { OfficeStencil }.Concat(DiagramToolboxRegistrator.Stencils));
            diagramControl.LoadDemoData("OfficePlan.xml");
        }
        void InitializeOfficeStencil() {
            const string directoryPath = "images/officeplan";
            var assembly = this.GetType().Assembly;
            var filePaths = AssemblyHelper.GetResources(assembly)
                .OfType<DictionaryEntry>()
                .Select(x => (string)x.Key)
                .Where(x => x.StartsWith(directoryPath));
            foreach(var filePath in filePaths.OrderBy(x => x)) {
                MatchEvaluator evaluator = new MatchEvaluator(match => match.Groups[2].Value);
                string fileName = Regex.Replace(filePath.Replace("%20", " "), string.Format("({0}/)([A-z0-9 ]*)(.svg)", directoryPath), evaluator);
                string shapeId = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(fileName);
                var stream = DiagramDemoFileHelper.GetResourceStream(filePath);
                var sd = ShapeDescription.CreateSvgShape(shapeId, shapeId, stream, false);
                OfficeStencil.RegisterShape(sd);
            }
        }
        void diagramControl_ItemInitializing(object sender, DevExpress.Xpf.Diagram.DiagramItemInitializingEventArgs e) {
            var shape = e.Item as DiagramShape;
            if(shape != null && OfficeStencil.ContainsShape(shape.Shape)) {
                shape.CanEdit = false;
            }
        }
    }
}
