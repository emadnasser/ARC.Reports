Imports System
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web.UI.WebControls
Imports DataAccess
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Native
Imports System.Linq
Imports System.Collections.Generic

Partial Public Class Chart
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim startDate As Date = Date.Parse(Request.QueryString("start"))
        Dim endDate As Date = Date.Parse(Request.QueryString("end"))

        RangeChartControl.Width = Unit.Parse(Request.QueryString("w").ToString())
        RangeChartControl.Height = Unit.Parse(Request.QueryString("h").ToString())

        RangeChartControl.DataSource = SalesProvider.GetRangeChartData(startDate, endDate).ToList()
        RangeChartControl.DataBind()
        Response.ContentType = "image/png"
        Response.Clear()

        Using stream As New MemoryStream()
            DirectCast(RangeChartControl, IChartContainer).Chart.ExportToImage(stream, ImageFormat.Png)
            stream.Position = 0
            stream.CopyTo(Response.OutputStream)
        End Using
    End Sub
End Class
