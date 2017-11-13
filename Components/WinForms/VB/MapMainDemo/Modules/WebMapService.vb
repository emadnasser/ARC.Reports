Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos
	Partial Public Class WebMapService
		Inherits MapTutorialControl
		Private Shared ReadOnly SelectionColor As Color = Color.FromArgb(128, 135, 135, 135)
		Private Shared ReadOnly HotTrackedColor As Color = Color.FromArgb(62, Color.Gray)
		Private Shared ReadOnly ItemMargin As New Padding(2)

		Private selectionLocked As Boolean = False
		Private ReadOnly menu_Renamed As New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(10)}
		Private ReadOnly Property Menu() As MapOverlay
			Get
				Return menu_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return New MapOverlay() { OverlayUtils.OSMCopyrightOverlay, Menu }
			End Get
		End Property

		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			AutoMergeRibbon = True
		End Sub

		Private Function CreateMenuItem(ByVal layer As WmsLayer) As LayerOverlayMenuItem
			Dim layerItem As New LayerOverlayMenuItem(layer.Name) With {.Padding = New Padding(10), .Margin = ItemMargin, .Text = layer.Name, .JoiningOrientation = Orientation.Vertical}
			CType(editWebMapSevice.Edit, RepositoryItemComboBox).Items.Add(layerItem)
			layerItem.HotTrackedStyle.Fill = HotTrackedColor
			Return layerItem
		End Function
		Private Function CreateHeader() As MapOverlayTextItem
			Dim header As New MapOverlayTextItem() With {.Padding = New Padding(10, 10, 10, 20), .Text = "Available layers", .JoiningOrientation = Orientation.Vertical}
			header.TextStyle.Font = New Font("Arial", 14)
			Return header
		End Function
		Private Sub OnOverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs) Handles mapControl1.OverlaysArranged
			Dim overlays() As OverlayArrangement = e.OverlayArrangements
			Dim menu As OverlayArrangement = overlays(1)
			For i As Integer = 1 To menu.ItemLayouts.Length - 1
				Dim itemRect As Rectangle = menu.ItemLayouts(i)
				menu.ItemLayouts(i) = New Rectangle(itemRect.Location, New Size(menu.OverlayLayout.Width - ItemMargin.Size.Width, itemRect.Height))
			Next i
		End Sub
		Private Sub OnResponseCapabilities(ByVal sender As Object, ByVal e As CapabilitiesResponsedEventArgs) Handles Provider.ResponseCapabilities
			GenerateMenu(e.Layers)
			SetOverlayMenuSelection(TryCast(Menu.Items(1), LayerOverlayMenuItem))
		End Sub
		Private Sub OnMapControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles mapControl1.MouseUp
			Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
			Dim clickedItem As LayerOverlayMenuItem = TryCast(OverlayUtils.GetClickedOverlayItem(hitInfo), LayerOverlayMenuItem)
			If clickedItem Is Nothing Then
				Return
			End If
			ResetMenuItemsBackground()
			SetOverlayMenuSelection(clickedItem)
		End Sub
		Private Sub SetOverlayMenuSelection(ByVal clickedItem As LayerOverlayMenuItem)
			selectionLocked = True
			clickedItem.BackgroundStyle.Fill = SelectionColor
			Provider.ActiveLayerName = clickedItem.LayerName
			editWebMapSevice.EditValue = clickedItem
			selectionLocked = False
		End Sub
		Private Sub GenerateMenu(ByVal layers As WmsLayerCollection)
			Menu.Items.Clear()
			Menu.Items.Add(CreateHeader())
			For Each layer As WmsLayer In layers
				Menu.Items.Add(CreateMenuItem(layer))
			Next layer
		End Sub
		Private Sub ResetMenuItemsBackground()
			For Each item As MapOverlayItemBase In Menu.Items
				Dim layerItem As LayerOverlayMenuItem = TryCast(item, LayerOverlayMenuItem)
				If layerItem IsNot Nothing Then
					layerItem.BackgroundStyle.Fill = Color.Transparent
				End If
			Next item
		End Sub
		Private Sub editWebMapSevice_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles editWebMapSevice.EditValueChanged
			If (Not selectionLocked) Then
				ResetMenuItemsBackground()
				SetOverlayMenuSelection(TryCast((CType(sender, BarEditItem)).EditValue, LayerOverlayMenuItem))
			End If
		End Sub
		Private Function FindOverlayItem(ByVal layerName As String) As LayerOverlayMenuItem
			For Each item As MapOverlayTextItem In Menu.Items
				Dim findItem As LayerOverlayMenuItem = TryCast(item, LayerOverlayMenuItem)
				If findItem IsNot Nothing AndAlso findItem.LayerName = layerName Then
					Return findItem
				End If
			Next item
			Return Nothing
		End Function
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(34.5, -91.5)
			MapControl.ZoomLevel = 4
		End Sub
	End Class

	Public Class LayerOverlayMenuItem
		Inherits MapOverlayTextItem
		Private ReadOnly layerName_Renamed As String
		Public ReadOnly Property LayerName() As String
			Get
				Return layerName_Renamed
			End Get
		End Property

		Public Sub New(ByVal name As String)
			Me.layerName_Renamed = name
		End Sub

		Public Overrides Function ToString() As String
			Return layerName_Renamed
		End Function
	End Class
End Namespace
