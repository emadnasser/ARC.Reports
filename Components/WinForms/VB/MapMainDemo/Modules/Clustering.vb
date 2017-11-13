Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Xml.Linq

Namespace DevExpress.XtraMap.Demos

	Partial Public Class Clustering
		Inherits MapTutorialControl
		Private Shared AttributeName As String = "Location"
		Private Shared DensityLegendHeader As String = "Tree density"
		Private Shared LocationLegendHeader As String = "Tree location"

		Private clusterer_Renamed As MapClustererBase
		Private ReadOnly Property Legend() As ColorListLegend
			Get
				Return CType(mapControl1.Legends(0), ColorListLegend)
			End Get
		End Property
		Private Property Clusterer() As MapClustererBase
			Get
				Return clusterer_Renamed
			End Get
			Set(ByVal value As MapClustererBase)
				If clusterer_Renamed Is value Then
					Return
				End If
				If clusterer_Renamed IsNot Nothing Then
					UnsubscribeEvents()
				End If
				clusterer_Renamed = value
				If clusterer_Renamed IsNot Nothing Then
					SubscribeEvents()
				End If
			End Set
		End Property

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetBingOverlays()
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapBingKind() As BingMapKind
			Get
				Return BingMapKind.Road
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapAlignment() As MiniMapAlignment
			Get
				Return MiniMapAlignment.TopLeft
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			AutoMergeRibbon = True
			InitializeComponent()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			ListSourceDataAdapter.DataSource = LoadFromXML()
			UpdateClusterer()
		End Sub
		Private Function CreateChoroplethColorizer() As MapColorizer
			Dim colorizer As New ChoroplethColorizer()
			colorizer.RangeStops.AddRange(New List(Of Double) (New Double() {1, 10, 50, 100, 500, 1000, 2000, 3000, 4000, 5000}))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H2f, &H3d, &H13)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H3d, &H4f, &H19)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H4c, &H64, &H1e)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H68, &H8a, &H2a)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H77, &H9e, &H30)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H8b, &Hb8, &H38)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&H9b, &Hcd, &H3e)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&Ha7, &Hdd, &H43)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&Hb7, &Hf2, &H49)))
			colorizer.ColorItems.Add(New ColorizerColorItem(Color.FromArgb(&Hca, &Hff, &H68)))
			colorizer.ValueProvider = New MapClusterValueProvider()
			Legend.Header = DensityLegendHeader
			Return colorizer
		End Function
		Private Function CreateKeyColorColorizer() As MapColorizer
			Dim colorizer As New KeyColorColorizer()
			colorizer.ItemKeyProvider = New AttributeItemKeyProvider() With {.AttributeName = AttributeName}
			colorizer.PredefinedColorSchema = PredefinedColorSchema.Palette
			Legend.Header = LocationLegendHeader
			Return colorizer
		End Function
		Private Function LoadFromXML() As List(Of TreeInfo)
			Dim trees As New List(Of TreeInfo)()
			Dim document As XDocument = DemoUtils.LoadXml("TreesCl.xml")
			If document IsNot Nothing Then
				For Each element As XElement In document.Element("RowSet").Elements()
					Dim location As String = element.Element("location").Value
					Dim genus As String = element.Element("genus").Value
					Dim latitude As Double = Convert.ToDouble(element.Element("lat").Value, CultureInfo.InvariantCulture)
					Dim longitude As Double = Convert.ToDouble(element.Element("lon").Value, CultureInfo.InvariantCulture)
					trees.Add(New TreeInfo() With {.Latitude = latitude, .Longitude = longitude, .Genus = genus, .Location = location})
				Next element
			End If
			Return trees
		End Function
		Private Function CreateClusterer() As MapClustererBase
			If chkDistanceBasedClustering.Checked Then
				Return New DistanceBasedClusterer()
			End If
			If chkMarkerClustering.Checked Then
				Return New MarkerClusterer()
			End If
			Return Nothing
		End Function
		Private Sub UpdateClusterer()
			Clusterer = CreateClusterer()
			ItemsLayer.Colorizer = If(chkClusteringByAttr.Checked, CreateKeyColorColorizer(), CreateChoroplethColorizer())
			If Clusterer IsNot Nothing Then
				Clusterer.GroupProvider = If(chkClusteringByAttr.Checked, CreateGroupProvider(), Nothing)
				If chkCustomFactory.Checked Then
					Clusterer.SetClusterItemFactory(New CustomClusterFactory())
				End If
			End If
			ListSourceDataAdapter.Clusterer = Clusterer
		End Sub
		Private Function CreateGroupProvider() As AttributeGroupProvider
			Return New AttributeGroupProvider() With {.AttributeName = AttributeName}
		End Function
		Private Sub SubscribeEvents()
			AddHandler Clusterer.Clustering, AddressOf Clusterer_OnClustering
			AddHandler Clusterer.Clustered, AddressOf Clusterer_OnClustered
		End Sub
		Private Sub UnsubscribeEvents()
			RemoveHandler Clusterer.Clustering, AddressOf Clusterer_OnClustering
			RemoveHandler Clusterer.Clustered, AddressOf Clusterer_OnClustered
		End Sub
		Private Sub Clusterer_OnClustered(ByVal sender As Object, ByVal e As ClusteredEventArgs)
			If SplashScreenManager.Default IsNot Nothing AndAlso SplashScreenManager.Default.IsSplashFormVisible Then
				SplashScreenManager.CloseDefaultWaitForm()
			End If
		End Sub
		Private Sub Clusterer_OnClustering(ByVal sender As Object, ByVal e As EventArgs)
			SplashScreenManager.ShowDefaultWaitForm(ParentForm, True, True, "", "Clustering...")
		End Sub
		Private Sub OnRibbonItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkClusteringByAttr.CheckedChanged, chkMarkerClustering.CheckedChanged, chkDistanceBasedClustering.CheckedChanged, chkWithoutClustering.CheckedChanged, chkCustomFactory.CheckedChanged, chkWitoutFactory.CheckedChanged, chkClusteringWitoutAttribute.CheckedChanged
			UpdateClusterer()
		End Sub
		Private Sub OnEditValueChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs) Handles repositoryItemTrackBar1.EditValueChanging
			If Clusterer IsNot Nothing Then
				Clusterer.StepInPixels = CInt(Fix(e.NewValue))
			End If
		End Sub
		Private Sub mapControl1_MapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs) Handles mapControl1.MapItemClick
			Dim groupItems As IList(Of MapItem) = e.Item.ClusteredItems
			If groupItems IsNot Nothing Then
				mapControl1.ZoomToFit(groupItems)
			End If
		End Sub
		Private Sub repositoryItemTrackBar1_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As XtraEditors.TrackBarValueToolTipEventArgs) Handles repositoryItemTrackBar1.BeforeShowValueToolTip
			Dim trackBar As TrackBarControl = TryCast(sender, TrackBarControl)
			If trackBar IsNot Nothing Then
				e.ShowArgs.ToolTip = String.Format("Step: {0} pixels", trackBar.EditValue)
			End If
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.AddRange(New RibbonPageGroup() { rpgClusteringMethod, rpgCustomClusterRepresentative, rpgGroupByAttributeValues, rpgAdditionalOptions })
			OptionsPage.Ribbon.Items.AddRange(New BarItem() { chkMarkerClustering, chkDistanceBasedClustering, chkWithoutClustering, chkCustomFactory, chkWitoutFactory, chkClusteringByAttr, chkClusteringWitoutAttribute })
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(-37.58, 143.8)
			MapControl.ZoomLevel = 12
		End Sub
	End Class
	Public Class TreeInfo
		Public Property Genus() As String
		Public Property Location() As String
		Public Property Latitude() As Double
		Public Property Longitude() As Double
		Public ReadOnly Property Type() As Integer
			Get
				Return CInt(Fix(MapItemType.Dot))
			End Get
		End Property
	End Class
	Public Class CustomClusterFactory
		Inherits DefaultClusterItemFactory
		Protected Overrides Function CreateItemInstance(ByVal obj As IList(Of MapItem)) As MapItem
			Return New MapCallout()
		End Function
	End Class
End Namespace
