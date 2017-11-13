using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;

public partial class CustomDrawLegend : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void WebChartControl1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
        const string selectCommand = "SELECT Employees.Photo FROM Employees WHERE Employees.LastName = \"";
        DataView dataView;
        using (AccessDataSource dataSource = new AccessDataSource(AccessDataSource1.DataFile, selectCommand + e.Series.Name + "\"")) {
            dataSource.DataSourceMode = SqlDataSourceMode.DataSet;
            dataView = (DataView)dataSource.Select(DataSourceSelectArguments.Empty);
        }
        using (MemoryStream stream = new MemoryStream((byte[])dataView.Table.Rows[0].ItemArray[0])) {
            using (System.Drawing.Image photo = System.Drawing.Image.FromStream(stream)) {
                Bitmap legendImage = new Bitmap(74, 79);
                using (Graphics graphics = Graphics.FromImage(legendImage)) {
                    graphics.FillRectangle(new LinearGradientBrush(new Rectangle(new Point(), legendImage.Size),
                        e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, LinearGradientMode.BackwardDiagonal),
                        new Rectangle(new Point(), legendImage.Size));
                    graphics.DrawImage(photo, new Rectangle(new Point(5, 5), new Size(64, 68)));
                }
                e.LegendMarkerImage = legendImage;
                e.DisposeLegendMarkerImage = true;
            }
        }
    }
}
