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
using System.Text.RegularExpressions;
using DevExpress.Utils;
using System.Collections;
using System.Globalization;

namespace DevExpress.XtraDiagram.Demos {
    public partial class CustomShapesModule : DiagramTutorialControl {
        public readonly DiagramStencil OfficeStencil = new DiagramStencil("OfficeShapes", "Office Shapes");

        public CustomShapesModule() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            diagramControl.ItemInitializing += DiagramControlItemInitializing;
            InitializeOfficeStencil();
            diagramControl.OptionsBehavior.Stencils = new DiagramStencilCollection(new[] { OfficeStencil }.Concat(DiagramToolboxRegistrator.Stencils));
            LoadDocument("OfficePlan.xml");
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
                var stream = AssemblyHelper.GetResourceStream(assembly, filePath, true);
                var sd = DevExpress.Diagram.Core.ShapeDescription.CreateSvgShape(shapeId, shapeId, stream, false);
                OfficeStencil.RegisterShape(sd);
            }
        }
        void DiagramControlItemInitializing(object sender, DiagramItemInitializingEventArgs e) {
            var shape = e.Item as DiagramShape;
            if(shape != null && OfficeStencil.ContainsShape(shape.Shape)) {
                shape.CanEdit = false;
            }
        }
    }
}
