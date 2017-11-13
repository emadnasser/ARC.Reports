Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Map
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraMap.Demos

	Partial Public Class ImportExport
		Inherits MapTutorialControl
		Private Const PoliticalToolTipPattern As String = "{NAME}"
		Private Const GdpToolTipPattern As String = "{NAME}: ${GDP_MD_EST:#,0}M"
		Private Const PopulationToolTipPattern As String = "{NAME}: {POP_EST:#,##0,,}M"

		Private politicalColorizer_Renamed As ChoroplethColorizer
		Private gdpColorizer_Renamed As ChoroplethColorizer
		Private populationColorizer_Renamed As ChoroplethColorizer
		Private gdpLegend_Renamed As ColorScaleLegend
		Private populationLegend_Renamed As ColorListLegend
		Private legendAlignment As LegendAlignment

		Private ReadOnly Property PoliticalColorizer() As ChoroplethColorizer
			Get
				If politicalColorizer_Renamed Is Nothing Then
					politicalColorizer_Renamed = CreatePoliticalColorizer()
				End If
				Return politicalColorizer_Renamed
			End Get
		End Property
		Private ReadOnly Property GdpColorizer() As ChoroplethColorizer
			Get
				If gdpColorizer_Renamed Is Nothing Then
					gdpColorizer_Renamed = CreateGDPColorizer()
				End If
				Return gdpColorizer_Renamed
			End Get
		End Property
		Private ReadOnly Property PopulationColorizer() As ChoroplethColorizer
			Get
				If populationColorizer_Renamed Is Nothing Then
					populationColorizer_Renamed = CreatePopulationColorizer()
				End If
				Return populationColorizer_Renamed
			End Get
		End Property
		Private ReadOnly Property GdpLegend() As ColorScaleLegend
			Get
				If gdpLegend_Renamed Is Nothing Then
					gdpLegend_Renamed = CreateGDPLegend()
				End If
				Return gdpLegend_Renamed
			End Get
		End Property
		Private ReadOnly Property PopulationLegend() As ColorListLegend
			Get
				If populationLegend_Renamed Is Nothing Then
					populationLegend_Renamed = CreatePopulationLegend()
				End If
				Return populationLegend_Renamed
			End Get
		End Property
		Private Property Legend() As ItemsLayerLegend
			Get
				Return If(MapControl.Legends.Count > 0, CType(MapControl.Legends(0), ItemsLayerLegend), Nothing)
			End Get
			Set(ByVal value As ItemsLayerLegend)
				If MapControl.Legends.Count > 0 Then
					MapControl.Legends.RemoveAt(0)
				End If
				If value IsNot Nothing Then
					MapControl.Legends.Add(value)
				End If
			End Set
		End Property

		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ShapefileDataAdapter.FileUri = New Uri("file:\\" & DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute)
			chkGDP.Checked = True
			AutoMergeRibbon = True
		End Sub

		Private Function CreatePoliticalColorizer() As ChoroplethColorizer
			Dim colorizer As New ChoroplethColorizer()
			colorizer.RangeStops.AddRange(New List(Of Double) (New Double() {0, 9}))
			colorizer.PredefinedColorSchema = PredefinedColorSchema.Palette
			colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "MAP_COLOR"}
			colorizer.ApproximateColors = True
			Return colorizer
		End Function
		Private Function CreateGDPColorizer() As ChoroplethColorizer
			Dim colorizer As New ChoroplethColorizer()
			colorizer.RangeStops.AddRange(New List(Of Double) (New Double() {0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000}))
			Dim colors As New List(Of Color) (New Color() {Color.FromArgb(&H5F, &H8B, &H95), Color.FromArgb(&H79, &H96, &H89), Color.FromArgb(&HA2, &HA8, &H75), Color.FromArgb(&HCE, &HBB, &H5F), Color.FromArgb(&HF2, &HCB, &H4E), Color.FromArgb(&HF1, &HC1, &H49), Color.FromArgb(&HE5, &HA8, &H4D), Color.FromArgb(&HD6, &H86, &H4E), Color.FromArgb(&HC5, &H64, &H50), Color.FromArgb(&HBA, &H4D, &H51)})
			colorizer.ColorItems.AddRange(GetColorItems(colors))
			colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}
			colorizer.ApproximateColors = True
			Return colorizer
		End Function
		Private Function GetColorItems(ByVal colors As List(Of Color)) As GenericColorizerItemCollection(Of ColorizerColorItem)
			Dim result As New GenericColorizerItemCollection(Of ColorizerColorItem)()
			result.BeginUpdate()
			Try
				For Each color As Color In colors
					result.Add(New ColorizerColorItem(color))
				Next color
			Finally
				result.EndUpdate()
			End Try
			Return result
		End Function
		Private Function CreateGDPLegend() As ColorScaleLegend
			Dim legend As New ColorScaleLegend()
			legend.Header = "GDP by Countries"
			legend.Description = "In US dollars"
			legend.RangeStopsFormat = "0,B"
			legend.Layer = FileLayer
			Return legend
		End Function
		Private Function CreatePopulationColorizer() As ChoroplethColorizer
			Dim colorizer As New ChoroplethColorizer()
			colorizer.RangeStops.AddRange(New List(Of Double) (New Double() {0, 1000000, 2000000, 5000000, 10000000, 25000000, 50000000, 100000000, 1000000000, 1500000000}))
			colorizer.PredefinedColorSchema = PredefinedColorSchema.Gradient
			colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "POP_EST"}
			colorizer.ApproximateColors = True
			Return colorizer
		End Function
		Private Function CreatePopulationLegend() As ColorListLegend
			Dim legend As New ColorListLegend()
			legend.RangeStopsFormat = "0,,M"
			legend.Header = ""
			legend.Description = ""
			legend.Layer = FileLayer
			Return legend
		End Function
		Private Sub UpdateMapColorizer(ByVal colorizer As MapColorizer, ByVal toolTipPattern As String)
			FileLayer.Colorizer = colorizer
			FileLayer.ToolTipPattern = toolTipPattern
			UpdateLegendAligment()
		End Sub
		Private Sub UpdateMapLegend(ByVal legend As ItemsLayerLegend)
			Me.Legend = legend
		End Sub
		Private Sub MapMode_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkPolitical.CheckedChanged, chkGDP.CheckedChanged, chkPopulation.CheckedChanged
			If chkPolitical.Checked Then
				UpdateMapLegend(Nothing)
				UpdateMapColorizer(PoliticalColorizer, PoliticalToolTipPattern)
			ElseIf chkGDP.Checked Then
				UpdateMapLegend(GdpLegend)
				UpdateMapColorizer(GdpColorizer, GdpToolTipPattern)
			Else
				UpdateMapLegend(PopulationLegend)
				UpdateMapColorizer(PopulationColorizer, PopulationToolTipPattern)
			End If
			bbLegendAlignment.Enabled = FileLayer.Colorizer IsNot PoliticalColorizer
		End Sub
		Private Function GetLegendAlignment(ByVal value As String) As LegendAlignment
			Dim alignment As LegendAlignment
			System.Enum.TryParse(Of LegendAlignment)(value, alignment)
			Return alignment
		End Function
		Private Sub UpdateLegendAligment()
			Dim choroplethColorizer As ChoroplethColorizer = TryCast(FileLayer.Colorizer, ChoroplethColorizer)
			If choroplethColorizer IsNot Nothing AndAlso Legend IsNot Nothing Then
				Legend.Alignment = legendAlignment
			End If
		End Sub
		Private Sub Export_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick, barButtonItem2.ItemClick, barButtonItem3.ItemClick
			btnExportShape.Caption = "Export Shapes To " & e.Item.Caption
			btnExportShape.Tag = e.Item.Tag
		End Sub
		Private Sub btnExportShape_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles btnExportShape.ItemClick
			Dim format As String = CStr(btnExportShape.Tag)
			saveFileDialog1.Filter = String.Format("{0} files (*.{1})|*.{1}", format.ToUpper(), format)
			saveFileDialog1.FileName = String.Empty
			If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			Select Case format
				Case "shp"
					FileLayer.ExportToShp(saveFileDialog1.FileName, New ShpExportOptions() With {.ExportToDbf = True, .ShapeType = ShapeType.Polygon})
				Case "kml"
					FileLayer.ExportToKml(saveFileDialog1.FileName)
				Case "svg"
					FileLayer.ExportToSvg(saveFileDialog1.FileName)
			End Select
			XtraMessageBox.Show(ParentForm, String.Format("Shapes succesfully exported to {0} file", saveFileDialog1.FileName), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
		Private Sub ddLegendAligment_GalleryItemClick(ByVal sender As Object, ByVal e As XtraBars.Ribbon.GalleryItemClickEventArgs) Handles ddLegendAligment.GalleryItemClick
			Me.legendAlignment = GetLegendAlignment(e.Item.Caption)
			UpdateLegendAligment()
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.AddRange(New RibbonPageGroup() { rpgMapKind, rpgLegendAlignment, rpgExport })
			OptionsPage.Ribbon.Items.AddRange(New BarItem() { chkGDP, chkPolitical, chkPopulation, bbLegendAlignment })
			ddLegendAligment.Ribbon = OptionsPage.Ribbon
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(45, 0)
			MapControl.ZoomLevel = 1.8
		End Sub
		Protected Overrides Function CreateMiniMapLayer() As MiniMapLayerBase
			Dim adapter As New ShapefileDataAdapter() With {.FileUri = New Uri("file:\\" & DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute)}
			Return New MiniMapVectorItemsLayer() With {.Data = adapter}
		End Function
	End Class
End Namespace
