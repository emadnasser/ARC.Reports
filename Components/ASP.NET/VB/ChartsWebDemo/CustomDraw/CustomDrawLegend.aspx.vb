Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts

Partial Public Class CustomDrawLegend
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub WebChartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
		Const selectCommand As String = "SELECT Employees.Photo FROM Employees WHERE Employees.LastName = """
		Dim dataView As DataView
		Using dataSource As New AccessDataSource(AccessDataSource1.DataFile, selectCommand & e.Series.Name & """")
			dataSource.DataSourceMode = SqlDataSourceMode.DataSet
			dataView = CType(dataSource.Select(DataSourceSelectArguments.Empty), DataView)
		End Using
		Using stream As New MemoryStream(CType(dataView.Table.Rows(0).ItemArray(0), Byte()))
			Using photo As System.Drawing.Image = System.Drawing.Image.FromStream(stream)
				Dim legendImage As New Bitmap(74, 79)
				Using graphics As Graphics = Graphics.FromImage(legendImage)
					graphics.FillRectangle(New LinearGradientBrush(New Rectangle(New Point(), legendImage.Size), e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, LinearGradientMode.BackwardDiagonal), New Rectangle(New Point(), legendImage.Size))
					graphics.DrawImage(photo, New Rectangle(New Point(5, 5), New Size(64, 68)))
				End Using
				e.LegendMarkerImage = legendImage
				e.DisposeLegendMarkerImage = True
			End Using
		End Using
	End Sub
End Class
