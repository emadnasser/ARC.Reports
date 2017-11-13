Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class LegendItemsDemo
		Inherits ChartDemoBase2D
		Private photos As New Dictionary(Of String, Image)()
		Private selectedSeries As Series

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chart_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs) Handles chart.CustomDrawSeries
			Dim isSelected As Boolean = selectedSeries IsNot Nothing AndAlso e.Series.Name = selectedSeries.Name
			Dim image As New Bitmap(74, 79)
			Using graphics As Graphics = Graphics.FromImage(image)
				If isSelected Then
					graphics.FillRectangle(New HatchBrush(HatchStyle.DarkUpwardDiagonal, e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2), New Rectangle(New Point(), image.Size))
				Else
					graphics.FillRectangle(New LinearGradientBrush(New Rectangle(New Point(), image.Size), e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, LinearGradientMode.BackwardDiagonal), New Rectangle(New Point(), image.Size))
				End If
				If photos.ContainsKey(e.Series.Name) Then
					graphics.DrawImage(photos(e.Series.Name), New Rectangle(New Point(5, 5), New Size(64, 68)))
				End If
			End Using
			e.LegendMarkerImage = image
			e.DisposeLegendMarkerImage = True
			If isSelected AndAlso TypeOf e.SeriesDrawOptions Is BarDrawOptions Then
				CType(e.SeriesDrawOptions, BarDrawOptions).FillStyle.FillMode = FillMode.Hatch
				CType((CType(e.SeriesDrawOptions, BarDrawOptions)).FillStyle.Options, HatchFillOptions).HatchStyle = HatchStyle.DarkUpwardDiagonal
			End If
		End Sub
		Private Sub chart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chart.ObjectHotTracked
			selectedSeries = If(e.HitInfo.InSeries, CType(e.HitInfo.Series, Series), Nothing)
			chart.Invalidate()
		End Sub
		Private Sub chart_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles chart.MouseLeave
			selectedSeries = Nothing
		End Sub
		Private Sub InitializePhotos()
			Dim imageBytes() As Byte
			For Each row As DataRow In dS51.Employees.Rows
				imageBytes = CType(row.ItemArray(4), Byte())
				Dim lastName As String = row.ItemArray(2).ToString()
				Using stream As New MemoryStream(imageBytes)
					If (Not photos.ContainsKey(lastName)) Then
						photos.Add(lastName, Image.FromStream(stream))
					End If
				End Using
			Next row
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			chart.DataSource = dS51.Employees
			Dim path As String = Utils.GetRelativePath("nwind.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			chart.DataAdapter = oleDbDataAdapter1
			Try
				oleDbDataAdapter1.Fill(dS51)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
			InitializePhotos()
		End Sub
	End Class
End Namespace
