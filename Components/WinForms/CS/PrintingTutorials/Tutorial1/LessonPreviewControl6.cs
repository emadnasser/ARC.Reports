using System;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.Windows.Forms;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl6 : LessonPreviewControl5 {
        public LessonPreviewControl6() {
        }

        protected override void DrawRow(BrickGraphics graph, int rowIndex) {
            base.DrawRow(graph, rowIndex);
            DrawRowIcon(graph, rowIndex);
        }

        private void DrawRowIcon(BrickGraphics graph, int rowIndex) {
            RectangleF bounds = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Icon);
            bounds.Y = rowIndex * bounds.Height;
            ImageBrick brick = graph.DrawImage(TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Icon, bounds);
            brick.SizeMode = ImageSizeMode.CenterImage;
        }
    }
}
