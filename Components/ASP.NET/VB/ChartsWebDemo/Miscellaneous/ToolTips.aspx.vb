Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ToolTips
	Inherits ChartBasePage
	Private Const selectPhotoCommand As String = "SELECT Employees.Photo FROM Employees WHERE Employees.LastName = """
	Private Const queryName As String = "seriesID"
	Private ReadOnly toolTipOpenModes() As String = { "On hover", "On click" }
	Private ReadOnly toolTipPositions() As String = { "Mouse", "Relative", "Free" }

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Request.QueryString(queryName) IsNot Nothing Then
			Dim seriesName As String = Convert.ToString(Request.QueryString(queryName))
			Dim dataView As DataView
			Using dataSource As New AccessDataSource(AccessDataSource1.DataFile, selectPhotoCommand & seriesName & """")
				dataSource.DataSourceMode = SqlDataSourceMode.DataSet
				dataView = CType(dataSource.Select(DataSourceSelectArguments.Empty), DataView)
			End Using
			Using stream As New MemoryStream(CType(dataView.Table.Rows(0).ItemArray(0), Byte()))
				Using photo As System.Drawing.Image = System.Drawing.Image.FromStream(stream)
					Dim toolTipImage As New Bitmap(74, 79)
					Using graphics As Graphics = Graphics.FromImage(toolTipImage)
						graphics.DrawImage(photo, New Rectangle(New Point(0, 0), New Size(74, 79)))
					End Using
					WriteBitmapToResponse(toolTipImage)
				End Using
			End Using
		End If
	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		ComboBoxHelper.PrepareComboBox(cbOpenMode, toolTipOpenModes)
		ComboBoxHelper.PrepareComboBox(cbPosition, toolTipPositions)
	End Sub

	Protected Sub WebChartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim chart As WebChartControl = TryCast(sender, WebChartControl)
		If chart IsNot Nothing Then
			For Each series As Series In chart.Series
				series.ToolTipImage.ImageUrl = "ToolTips.aspx?" & queryName & "=" & series.Name
			Next series
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Dim chart As WebChartControl = TryCast(sender, WebChartControl)
		If chart IsNot Nothing Then
			chart.ToolTipController.OpenMode = GetToolTipOpenMode(toolTipOpenModes(cbOpenMode.SelectedIndex))
			chart.ToolTipOptions.ToolTipPosition = GetToolTipPosition(toolTipPositions(cbPosition.SelectedIndex))
		End If
	End Sub
	Private Function GetToolTipPosition(ByVal position As String) As ToolTipPosition
		Select Case position
			Case "Relative"
				Return New ToolTipRelativePosition()
			Case "Free"
				Return New ToolTipFreePosition() With {.DockTarget = (CType(WebChartControl1.Diagram, XYDiagram2D)).DefaultPane, .OffsetX = 8, .OffsetY = 8}
			Case Else
				Return New ToolTipMousePosition()
		End Select
	End Function
	Private Function GetToolTipOpenMode(ByVal openMode As String) As ToolTipOpenMode
		Select Case openMode
			Case "On click"
				Return ToolTipOpenMode.OnClick
			Case Else
				Return ToolTipOpenMode.OnHover
		End Select
	End Function
	Private Sub WriteBitmapToResponse(ByVal bitmap As Bitmap)
		Dim ms As New MemoryStream()
		bitmap.Save(ms, ImageFormat.Bmp)
		Dim bytes() As Byte = ms.ToArray()
		ms.Close()
		Response.Buffer = True
		Response.Charset = ""
		Response.Cache.SetCacheability(HttpCacheability.NoCache)
		Response.ContentType = "image/bmp"
		Response.BinaryWrite(bytes)
		Try
			Response.Flush()
		Catch e1 As HttpException
		End Try
		Try
			Response.End()
		Catch e2 As ThreadAbortException
		End Try
	End Sub
End Class
