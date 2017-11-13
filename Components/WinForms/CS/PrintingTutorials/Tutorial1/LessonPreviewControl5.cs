using System;
using DevExpress.XtraPrinting;
using System.Drawing;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl5 : LessonPreviewControl4 {
        public LessonPreviewControl5() {
        }

        protected override void DrawRow(BrickGraphics graph, int rowIndex) {
            base.DrawRow(graph, rowIndex);
            DrawRowDiscontinued(graph, rowIndex);
        }

        protected void DrawRowDiscontinued(BrickGraphics graph, int rowIndex) {
            RectangleF bounds = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Discontinued);
            bounds.Y = rowIndex * bounds.Height;
            graph.DrawCheckBox(bounds, TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Discontinued);
        }
    }
}
