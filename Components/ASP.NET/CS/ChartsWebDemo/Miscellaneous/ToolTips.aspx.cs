using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ToolTips : ChartBasePage {
    const string selectPhotoCommand = "SELECT Employees.Photo FROM Employees WHERE Employees.LastName = \"";
    const string queryName = "seriesID";
    readonly string[] toolTipOpenModes = new string[] { "On hover", "On click" };
    readonly string[] toolTipPositions = new string[] { "Mouse", "Relative", "Free" };

    protected void Page_Load(object sender, EventArgs e) {
        if (Request.QueryString[queryName] != null) {
            string seriesName = Convert.ToString(Request.QueryString[queryName]);
            DataView dataView;
            using (AccessDataSource dataSource = new AccessDataSource(AccessDataSource1.DataFile, selectPhotoCommand + seriesName + "\"")) {
                dataSource.DataSourceMode = SqlDataSourceMode.DataSet;
                dataView = (DataView)dataSource.Select(DataSourceSelectArguments.Empty);
            }
            using (MemoryStream stream = new MemoryStream((byte[])dataView.Table.Rows[0].ItemArray[0])) {
                using (System.Drawing.Image photo = System.Drawing.Image.FromStream(stream)) {
                    Bitmap toolTipImage = new Bitmap(74, 79);
                    using (Graphics graphics = Graphics.FromImage(toolTipImage))
                        graphics.DrawImage(photo, new Rectangle(new Point(0, 0), new Size(74, 79)));
                    WriteBitmapToResponse(toolTipImage);
                }
            }
        }
    }

    protected void Page_Init(object sender, EventArgs e) {
        ComboBoxHelper.PrepareComboBox(cbOpenMode, toolTipOpenModes);
        ComboBoxHelper.PrepareComboBox(cbPosition, toolTipPositions);
    }

    protected void WebChartControl1_BoundDataChanged(object sender, EventArgs e) {
        WebChartControl chart = sender as WebChartControl;
        if (chart != null)
            foreach (Series series in chart.Series)
                series.ToolTipImage.ImageUrl = @"ToolTips.aspx?" + queryName + "=" + series.Name;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        WebChartControl chart = sender as WebChartControl;
        if (chart != null) {
            chart.ToolTipController.OpenMode = GetToolTipOpenMode(toolTipOpenModes[cbOpenMode.SelectedIndex]);
            chart.ToolTipOptions.ToolTipPosition = GetToolTipPosition(toolTipPositions[cbPosition.SelectedIndex]);
        }
    }
    ToolTipPosition GetToolTipPosition(string position) {
        switch (position) {
            case "Relative":
                return new ToolTipRelativePosition();
            case "Free":
                return new ToolTipFreePosition() { 
                    DockTarget = ((XYDiagram2D)WebChartControl1.Diagram).DefaultPane,
                    OffsetX = 8,
                    OffsetY = 8
                };
            case "Mouse":
            default:
                return new ToolTipMousePosition();
        }
    }
    ToolTipOpenMode GetToolTipOpenMode(string openMode) {
        switch (openMode) {
            case "On click":
                return ToolTipOpenMode.OnClick;
            case "On hover":
            default:
                return ToolTipOpenMode.OnHover;
        }
    }
    void WriteBitmapToResponse(Bitmap bitmap) {
        MemoryStream ms = new MemoryStream();
        bitmap.Save(ms, ImageFormat.Bmp);
        byte[] bytes = ms.ToArray();
        ms.Close();
        Response.Buffer = true;
        Response.Charset = "";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = "image/bmp";
        Response.BinaryWrite(bytes);
        try {
            Response.Flush();
        }
        catch (HttpException) { }
        try {
            Response.End();
        }
        catch (ThreadAbortException) { }
    }
}
