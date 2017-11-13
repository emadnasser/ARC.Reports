using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.CustomDraw {
	public partial class LegendItemsDemo : ChartDemoBase2D {
        Dictionary<string, Image> photos = new Dictionary<string, Image>();
        Series selectedSeries;

        public override ChartControl ChartControl { get { return this.chart; } }

        public LegendItemsDemo() {
			InitializeComponent();
		}

        void chart_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            bool isSelected = selectedSeries != null && e.Series.Name == selectedSeries.Name;
            Bitmap image = new Bitmap(74, 79);
            using (Graphics graphics = Graphics.FromImage(image)) {
                if (isSelected)
                    graphics.FillRectangle(new HatchBrush(HatchStyle.DarkUpwardDiagonal, e.LegendDrawOptions.Color,
                        e.LegendDrawOptions.ActualColor2), new Rectangle(new Point(), image.Size));
                else
                    graphics.FillRectangle(new LinearGradientBrush(new Rectangle(new Point(), image.Size),
                        e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, LinearGradientMode.BackwardDiagonal),
                        new Rectangle(new Point(), image.Size));
                if (photos.ContainsKey(e.Series.Name))
                    graphics.DrawImage(photos[e.Series.Name], new Rectangle(new Point(5, 5), new Size(64, 68)));
            }
            e.LegendMarkerImage = image;
            e.DisposeLegendMarkerImage = true;
            if (isSelected && e.SeriesDrawOptions is BarDrawOptions) {
                ((BarDrawOptions)e.SeriesDrawOptions).FillStyle.FillMode = FillMode.Hatch;
                ((HatchFillOptions)((BarDrawOptions)e.SeriesDrawOptions).FillStyle.Options).HatchStyle = HatchStyle.DarkUpwardDiagonal;
            }
        }
        void chart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            selectedSeries = e.HitInfo.InSeries ? (Series)e.HitInfo.Series : null;
            chart.Invalidate();
        }
        void chart_MouseLeave(object sender, EventArgs e) {
            selectedSeries = null;
        }
        void InitializePhotos() {
            byte[] imageBytes;
            foreach (DataRow row in dS51.Employees.Rows) {
                imageBytes = (byte[])row.ItemArray[4];
                string lastName = row.ItemArray[2].ToString();
                using (MemoryStream stream = new MemoryStream(imageBytes))
                    if (!photos.ContainsKey(lastName))
                        photos.Add(lastName, Image.FromStream(stream));
            }
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            chart.DataSource = dS51.Employees;
            string path = Utils.GetRelativePath("nwind.mdb");
            if (path.Length > 0)
                Utils.SetConnectionString(oleDbConnection1, path);
            else {
                XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            chart.DataAdapter = oleDbDataAdapter1;
            try {
                oleDbDataAdapter1.Fill(dS51);
            }
            catch (OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InitializePhotos();
        }
    }
}
