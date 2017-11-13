Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class ToolTipsDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Private toolTipMousePosition As New ToolTipMousePosition()
		Private toolTipRelativePosition As New ToolTipRelativePosition()
		Private toolTipFreePosition As New ToolTipFreePosition()
		Private isFirstLoading As Boolean = True

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			toolTipFreePosition.DockTarget = (CType(chart.Diagram, XYDiagram2D)).DefaultPane
			toolTipFreePosition.DockCorner = ToolTipDockCorner.TopLeft
			toolTipFreePosition.OffsetX = 10
			toolTipFreePosition.OffsetY = 10
			chart.DataSource = GDPofG7.GetDataByMember()
		End Sub

		Private Sub cbToolTipPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbToolTipPosition.SelectedIndexChanged
			Select Case cbToolTipPosition.SelectedIndex
				Case 0
					chart.ToolTipOptions.ToolTipPosition = toolTipMousePosition
					defaultToolTipController.DefaultController.ShowBeak = True
				Case 1
					chart.ToolTipOptions.ToolTipPosition = toolTipRelativePosition
					defaultToolTipController.DefaultController.ShowBeak = True
				Case 2
					chart.ToolTipOptions.ToolTipPosition = toolTipFreePosition
					defaultToolTipController.DefaultController.ShowBeak = False
			End Select
		End Sub
		Private Sub defaultToolTipController_DefaultController_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles defaultToolTipController.DefaultController.BeforeShow
			Dim controller As ToolTipController = TryCast(sender, ToolTipController)
			Dim seriesPoint As SeriesPoint = TryCast(controller.ActiveObject, SeriesPoint)
			If seriesPoint IsNot Nothing Then
				Dim g7Member As G7Member = TryCast(seriesPoint.Tag, G7Member)
				Dim chartTitle As String = g7Member.CountryName & " GDP History"
				e.ToolTipImage = CreateChart(g7Member.GDPs, chartTitle, GetColorFromPaletteByNumber(g7Member.ColorNumberInPalette))
				e.ToolTip = ""
			End If
		End Sub
		Private Function GetColorFromPaletteByNumber(ByVal colorNumber As Integer) As Color
			Dim entries() As PaletteEntry = chart.GetPaletteEntries(8)
			Return entries(colorNumber).Color
		End Function
		Private Function CreateChart(ByVal toolTipChartDataSource As List(Of GDP), ByVal chartTitleText As String, ByVal seriesColor As Color) As Image
			Dim chart As New ChartControl()
			chart.BorderOptions.Visibility = DefaultBoolean.False
			chart.Series.Add(New Series("GDP Dynamic", ViewType.Line))
			chart.DataSource = toolTipChartDataSource
			chart.Series(0).ValueDataMembers.AddRange("Product")
			chart.Series(0).ArgumentDataMember = "Year"
			chart.Series(0).LabelsVisibility = DefaultBoolean.False
			chart.Series(0).View.Color = seriesColor
			chart.Series(0).ArgumentScaleType = ScaleType.Numerical
			chart.Legend.Visibility = DefaultBoolean.False
			Dim xyDiagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
			Dim chartTitle As New ChartTitle() With {.Text = chartTitleText, .Font = New Font("Tahoma", 12)}
			xyDiagram.AxisY.WholeRange.AlwaysShowZeroLevel = False
			chart.Titles.Add(chartTitle)
			Dim chartAsImage As Image
			Using stream As New MemoryStream()
				chart.ExportToImage(stream, ImageFormat.Png)
				chartAsImage = New Bitmap(stream)
			End Using
			Return chartAsImage
		End Function

		Protected Overrides Sub DoHide()
			MyBase.DoHide()
			RemoveHandler defaultToolTipController.DefaultController.BeforeShow, AddressOf defaultToolTipController_DefaultController_BeforeShow
			defaultToolTipController.DefaultController.Rounded = False
			defaultToolTipController.DefaultController.ShowBeak = False
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			If (Not isFirstLoading) Then
				defaultToolTipController.DefaultController.Rounded = True
				defaultToolTipController.DefaultController.ShowBeak = True
				AddHandler defaultToolTipController.DefaultController.BeforeShow, AddressOf defaultToolTipController_DefaultController_BeforeShow
			Else
				isFirstLoading = False
			End If
		End Sub
	End Class
End Namespace
