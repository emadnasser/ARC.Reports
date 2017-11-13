Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports System.Collections
Imports System.Linq
Imports DevExpress.XtraMap.Native
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Globalization
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraMap.Demos
	Partial Public Class BubbleCharts
		Inherits MapTutorialControl
		Private table As DataTable

		Private ReadOnly Property SizeLegend() As SizeLegend
			Get
				Return CType(mapControl1.Legends(0), SizeLegend)
			End Get
		End Property
		Private ReadOnly Property ColorLegend() As ColorScaleLegend
			Get
				Return CType(mapControl1.Legends(1), ColorScaleLegend)
			End Get
		End Property
		Private ReadOnly Property Colorizer() As KeyColorColorizer
			Get
				Return CType(ItemsLayer.Colorizer, KeyColorColorizer)
			End Get
		End Property
		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetBingOverlays()
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapAlignment() As MiniMapAlignment
			Get
				Return MiniMapAlignment.TopRight
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapBingKind() As BingMapKind
			Get
				Return BingMapKind.Hybrid
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Colorizer.ItemKeyProvider = New BubbleGroupKeyProvider()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			SetData()
			Me.barEditItem2.EditValue = New TrackBarRange(65, 96)
			AutoMergeRibbon = True
			AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
		End Sub

		Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetDecadeFiltersStyle(Colorizer)
		End Sub
		Private Sub SetData()
			table = CreateDataSet()
			Dim min As Double = 6.5
			Dim max As Double = 9.6
			UpdateFilter(min, max)
			UpdateColorLegend()
			BubbleChartDataAdapter.DataSource = table
		End Sub
		Private Function CreateDataSet() As DataTable
			Dim ds As New DataSet()
			Dim path As String = DemoUtils.GetRelativePath("Earthquakes.xml")
			ds.ReadXml(path)
			Dim table As DataTable = ds.Tables(0)
			table.Locale = CultureInfo.InvariantCulture
			table.Columns.Add("Type", GetType(Integer))
			table.Columns("Type").Expression = "(yr - 1960) / 10 - 0.49"
			table.Columns.Add("Date", GetType(DateTime))
			table.Columns("Date").Expression = DemoUtils.ComplexDateExpression
			Return table
		End Function
		Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barEditItem1.EditValueChanged
			Dim value As String = (CType(sender, BarEditItem)).EditValue.ToString()
			UpdateMarkerType(BubbleChartDataAdapter, value)
		End Sub
		Private Sub UpdateMarkerType(ByVal data As BubbleChartDataAdapter, ByVal value As String)
			Select Case value
				Case "Circle"
					data.MarkerType = MarkerType.Circle
				Case "Cross"
					data.MarkerType = MarkerType.Cross
				Case "Diamond"
					data.MarkerType = MarkerType.Diamond
				Case "Hexagon"
					data.MarkerType = MarkerType.Hexagon
				Case "InvertedTriangle"
					data.MarkerType = MarkerType.InvertedTriangle
				Case "Pentagon"
					data.MarkerType = MarkerType.Pentagon
				Case "Plus"
					data.MarkerType = MarkerType.Plus
				Case "Square"
					data.MarkerType = MarkerType.Square
				Case "Star5"
					data.MarkerType = MarkerType.Star5
				Case "Star6"
					data.MarkerType = MarkerType.Star6
				Case "Star8"
					data.MarkerType = MarkerType.Star8
				Case "Triangle"
					data.MarkerType = MarkerType.Triangle
			End Select
		End Sub
		Private Sub repositoryItemRangeTrackBar1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemRangeTrackBar1.EditValueChanged
			MapControl.SuspendRender()
			Dim range As TrackBarRange = (CType(sender, RangeTrackBarControl)).Value
			UpdateFilter(0.1 * range.Minimum, 0.1 * range.Maximum)
			MapControl.ResumeRender()
		End Sub
		Private Sub barCheckItem_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barCheckItem1.CheckedChanged, barCheckItem2.CheckedChanged, barCheckItem3.CheckedChanged, barCheckItem4.CheckedChanged
			If barEditItem2.EditValue Is Nothing Then
				Return
			End If
			MapControl.SuspendRender()
			Dim range As TrackBarRange = CType(barEditItem2.EditValue, TrackBarRange)
			UpdateFilter(0.1 * range.Minimum, 0.1 * range.Maximum)
			UpdateColorLegend()
			MapControl.ResumeRender()
		End Sub
		Private Sub UpdateColorLegend()
			ColorLegend.CustomItems.Clear()
			SetDecadeFiltersStyle(Colorizer)
			GetCheckedColorItems(Colorizer)
		End Sub
		Private Sub SetDecadeFiltersStyle(ByVal colorizer As KeyColorColorizer)
			Dim color1 As Color = If(barCheckItem1.Checked, colorizer.Colors(0), DefaultAppearance.BackColor)
			barCheckItem1.ItemAppearance.Normal.BackColor = color1
			barCheckItem1.ItemAppearance.Hovered.BackColor = color1
			barCheckItem1.ItemAppearance.Pressed.BackColor = color1
			Dim color2 As Color = If(barCheckItem2.Checked, colorizer.Colors(1), DefaultAppearance.BackColor)
			barCheckItem2.ItemAppearance.Normal.BackColor = color2
			barCheckItem2.ItemAppearance.Hovered.BackColor = color2
			barCheckItem2.ItemAppearance.Pressed.BackColor = color2
			Dim color3 As Color = If(barCheckItem3.Checked, colorizer.Colors(2), DefaultAppearance.BackColor)
			barCheckItem3.ItemAppearance.Normal.BackColor = color3
			barCheckItem3.ItemAppearance.Hovered.BackColor = color3
			barCheckItem3.ItemAppearance.Pressed.BackColor = color3
			Dim color4 As Color = If(barCheckItem4.Checked, colorizer.Colors(3), DefaultAppearance.BackColor)
			barCheckItem4.ItemAppearance.Normal.BackColor = color4
			barCheckItem4.ItemAppearance.Hovered.BackColor = color4
			barCheckItem4.ItemAppearance.Pressed.BackColor = color4
		End Sub
		Private Sub GetCheckedColorItems(ByVal colorizer As KeyColorColorizer)
			If barCheckItem1.Checked Then
				Dim keyItem As ColorizerKeyItem = colorizer.Keys(0)
				ColorLegend.CustomItems.Add(New ColorLegendItem() With {.Color = colorizer.Colors(0), .Text = keyItem.Name})
			End If
			If barCheckItem2.Checked Then
				Dim keyItem As ColorizerKeyItem = colorizer.Keys(1)
				ColorLegend.CustomItems.Add(New ColorLegendItem() With {.Color = colorizer.Colors(1), .Text = keyItem.Name})
			End If
			If barCheckItem3.Checked Then
				Dim keyItem As ColorizerKeyItem = colorizer.Keys(2)
				ColorLegend.CustomItems.Add(New ColorLegendItem() With {.Color = colorizer.Colors(2), .Text = keyItem.Name})
			End If
			If barCheckItem4.Checked Then
				Dim keyItem As ColorizerKeyItem = colorizer.Keys(3)
				ColorLegend.CustomItems.Add(New ColorLegendItem() With {.Color = colorizer.Colors(3), .Text = keyItem.Name})
			End If
		End Sub
		Private Sub UpdateFilter(ByVal minMagnitude As Double, ByVal maxMagnitude As Double)
			If table Is Nothing Then
				Return
			End If
			Dim magnitudeFilter As String = GetMagnitudeFilter(minMagnitude, maxMagnitude)
			Dim yearFilter As String = GetYearFilterString()
			Dim filter As String = String.Format(CultureInfo.InvariantCulture, "({0}) AND ({1})", magnitudeFilter, yearFilter)
			table.DefaultView.RowFilter = filter
		End Sub
		Private Function GetMagnitudeFilter(ByVal min As Double, ByVal max As Double) As String
			Return String.Format(CultureInfo.InvariantCulture, "mag >= {0} AND mag <= {1}", min, max)
		End Function
		Private Function GetYearFilterString() As String
			Dim filter As String = ""
			Dim baseStr As String = "(yr >= {0} AND yr < {1}) OR "

			If barCheckItem1.Checked Then
				filter = String.Concat(filter, String.Format(baseStr, 1960, 1970))
			End If
			If barCheckItem2.Checked Then
				filter = String.Concat(filter, String.Format(baseStr, 1970, 1980))
			End If
			If barCheckItem3.Checked Then
				filter = String.Concat(filter, String.Format(baseStr, 1980, 1990))
			End If
			If barCheckItem4.Checked Then
				filter = String.Concat(filter, String.Format(baseStr, 1990, 2000))
			End If
			If filter.Length > 0 Then
				filter = filter.Remove(filter.Length - 4, 4)
			End If
			Return If((filter.Length > 0), filter, "FALSE")
		End Function
		Private Sub OnDispose(ByVal disposing As Boolean)
			If Me.table IsNot Nothing Then
				Me.table.Dispose()
				Me.table = Nothing
			End If
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.AddRange(New RibbonPageGroup() { rpgDecadeFilter, rpgMagniduteFilter, rpgMarkerKind })
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint()
			MapControl.ZoomLevel = 2
		End Sub
	End Class
	Public Class BubbleGroupKeyProvider
		Implements IColorizerItemKeyProvider
		Private Function GetItemKey(ByVal item As Object) As Object Implements IColorizerItemKeyProvider.GetItemKey
			Dim bubble As MapBubble = TryCast(item, MapBubble)
			Return If(bubble IsNot Nothing, bubble.Group.ToString(), Nothing)
		End Function
	End Class
End Namespace
