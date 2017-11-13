using System;
using DevExpress.XtraReports.UI;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace XtraReportsDemos.CrossBandControls {
	public partial class Report : XtraReport {
        bool drawZBelowTheTable;

		public Report() {
			InitializeComponent();
            Name = ReportNames.CrossBands;
            DisplayName = ReportNames.CrossBands;
            BeforePrint += Report_BeforePrint;
		}

        void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            drawZBelowTheTable = (bool)Parameters["DrawZBelowTheTableParameter"].Value;
            SetFillEmptySpace();
        }

        public void SetFillEmptySpace() {
            if(drawZBelowTheTable) {
                GroupFooter1.PrintAtBottom = false;
                FillEmptySpace += report_FillEmptySpace;
            }
            else {
                GroupFooter1.PrintAtBottom = true;
                FillEmptySpace -= report_FillEmptySpace;
            }
        }

        private void report_FillEmptySpace(object sender, BandEventArgs e) {
            if(!drawZBelowTheTable) {
                FillEmptySpace -= report_FillEmptySpace;
                return;
            }
            int bandHeight = GraphicsUnitConverter.Convert(e.Band.Height, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi());
            if(bandHeight <= 30)
                return;
            Size size = new Size(612, bandHeight - 30);
            Size sizeInPixels = XRConvert.Convert(size, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel);
            Bitmap zBitmap = new Bitmap(sizeInPixels.Width, sizeInPixels.Height);
            Graphics gr = Graphics.FromImage(zBitmap);
            using(Pen pen = new Pen(Color.FromArgb(205, 205, 205), 4)) {
                Point[] points = new Point[] { 
                    new Point(0, 4),
                    new Point(sizeInPixels.Width, 4),
                    new Point(0, sizeInPixels.Height - 4),
                    new Point(sizeInPixels.Width, sizeInPixels.Height - 4)
                };
                gr.DrawLines(pen, points);
            }
            XRPictureBox pictureBox = new XRPictureBox();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Size = size;
            pictureBox.Location = new Point(19, 15);
            pictureBox.Image = zBitmap;
            e.Band.Controls.Add(pictureBox);
        }
	}
}
