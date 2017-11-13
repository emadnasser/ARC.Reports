using System;
using DevExpress.XtraPrinting;
using System.Drawing;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl8 : LessonPreviewControl7 {
        public LessonPreviewControl8() {
            link.CreateMarginalHeaderArea += CreateMarginalHeaderArea;
        }

        protected override void DrawTable(BrickGraphics graph) {
            const int RowsCount = 60;
            for(int i = 0; i < RowsCount; i++)
                DrawRow(graph, i);
        }

        void CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e) {
            const string PageNumberFormat = "Page {0} of {1}";

            RectangleF dateTimeBounds = new RectangleF(0, 0, 0, e.Graph.Font.Height);

            PageInfoBrick pageNumberBrick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, PageNumberFormat, Color.Black, dateTimeBounds, BorderSide.None);
            pageNumberBrick.Alignment = BrickAlignment.Far;
            pageNumberBrick.AutoWidth = true;

            PageInfoBrick dateTimeBrick = e.Graph.DrawPageInfo(PageInfo.DateTime, string.Empty, e.Graph.ForeColor, dateTimeBounds, BorderSide.None);
            dateTimeBrick.Alignment = BrickAlignment.Near;
            dateTimeBrick.AutoWidth = true;
        }
    }
}
