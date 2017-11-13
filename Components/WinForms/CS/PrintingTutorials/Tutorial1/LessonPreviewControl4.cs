using System;
using DevExpress.XtraPrinting;
using System.Drawing;
using DevExpress.Utils;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl4 : LessonPreviewControl3 {
        public LessonPreviewControl4() {
        }

        protected override void DrawRow(BrickGraphics graph, int rowIndex) {
            base.DrawRow(graph, rowIndex);
            DrawRowPrice(graph, rowIndex);
        }

        protected void DrawRowPrice(BrickGraphics graph, int rowIndex) {
            RectangleF bounds = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Price);
            bounds.Y = rowIndex * bounds.Height;
            TextBrick brick = graph.DrawString(TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Price.ToString("c"), bounds);
            brick.HorzAlignment = HorzAlignment.Center;
        }
    }
}
