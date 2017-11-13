using System;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl2 : LessonPreviewControl1 {
        public LessonPreviewControl2() {
        }

        protected override void CreateReportHeaderArea(object sender, CreateAreaEventArgs e) {
            const float CaptionHeight = 66f;
            e.Graph.Font = new Font("Tahoma", 18f);
            e.Graph.BorderWidth = 0f;
            e.Graph.StringFormat = e.Graph.StringFormat
                .ChangeLineAlignment(StringAlignment.Center)
                .ChangeAlignment(StringAlignment.Center);
            e.Graph.DrawString(DocumentCaption, new RectangleF(PointF.Empty, new SizeF(e.Graph.ClientPageSize.Width, CaptionHeight)));
        }
    }
}
