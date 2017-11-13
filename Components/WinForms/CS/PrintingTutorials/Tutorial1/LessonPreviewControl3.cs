using System;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl3 : LessonPreviewControl2 {
        protected const float NameColumnWidth = 300;
        protected const float PriceColumnWidth = 75;
        protected const float DiscontinuedColumnWidth = 100;
        protected const float IconColumnWidth = 50;
        protected readonly Color borderColor = Color.FromArgb(189, 177, 183);

        public LessonPreviewControl3() {
            this.link.CreateDetailArea += CreateDetailArea;
        }

        protected void CreateDetailArea(object sender, CreateAreaEventArgs e) {
            SetGraphStylesForRow(e.Graph);
            DrawTable(e.Graph);
        }

        protected virtual void DrawTable(BrickGraphics graph) {
            DrawRow(graph, 0);
        }

        protected virtual void DrawRow(BrickGraphics graph, int rowIndex) {
            if(rowIndex % 2 == 0) graph.BackColor = Color.LightBlue;
            else graph.BackColor = Color.White;
            DrawRowName(graph, rowIndex);
        }

        protected void DrawRowName(BrickGraphics graph, int rowIndex) {
            RectangleF bounds = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Name);
            bounds.Y = rowIndex * bounds.Height;
            TextBrick brick = graph.DrawString(TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Name, bounds);
            const int LeftPadding = 4;
            brick.Padding = new PaddingInfo(LeftPadding, brick.Padding.Right, brick.Padding.Top, brick.Padding.Bottom);
        }

        void SetGraphStylesForRow(BrickGraphics graph) {
            graph.Font = new Font("Arial", 9f);
            graph.BorderColor = borderColor;
            graph.BorderWidth = 1f;
            graph.StringFormat = graph.StringFormat.ChangeAlignment(StringAlignment.Near);
        }
    }
}
