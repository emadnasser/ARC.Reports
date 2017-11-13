using System;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.ComponentModel;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl1 : XtraPrintingDemos.PreviewControl {
        protected const string DocumentCaption = "Product List";
        protected readonly Link link = new Link();

        Container components;

        public LessonPreviewControl1() {
            InitializeComponent();
            this.link.CreateReportHeaderArea += CreateReportHeaderArea;
        }

        protected virtual void CreateReportHeaderArea(object sender, CreateAreaEventArgs e) {
            e.Graph.BorderWidth = 0f;
            SizeF size = e.Graph.MeasureString(DocumentCaption);
            e.Graph.DrawString(DocumentCaption, new RectangleF(PointF.Empty, size));
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
        }
        #endregion
        public override void Activate() {
            if(link != null) link.CreateDocument(printingSystem);
        }
    }
}
