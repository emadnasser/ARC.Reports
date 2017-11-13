Imports Microsoft.VisualBasic
Imports DevExpress.Demos.FlagsGameCore
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos
	Public NotInheritable Class OverlayUtils
		Private Shared bingLogoOverlay_Renamed As MapOverlay
		Private Shared bingCopyrightOverlay_Renamed As MapOverlay
		Private Shared osmCopyrightOverlay_Renamed As MapOverlay
		Private Shared medalsOverlay_Renamed As MapOverlay

		Private Sub New()
		End Sub
		Public Shared ReadOnly Property BingLogoOverlay() As MapOverlay
			Get
				If bingLogoOverlay_Renamed Is Nothing Then
					bingLogoOverlay_Renamed = CreateBingLogoOverlay()
				End If
				Return bingLogoOverlay_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property BingCopyrightOverlay() As MapOverlay
			Get
				If bingCopyrightOverlay_Renamed Is Nothing Then
					bingCopyrightOverlay_Renamed = CreateBingCopyrightOverlay()
				End If
				Return bingCopyrightOverlay_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property OSMCopyrightOverlay() As MapOverlay
			Get
				If osmCopyrightOverlay_Renamed Is Nothing Then
					osmCopyrightOverlay_Renamed = CreateOSMCopyrightOverlay()
				End If
				Return osmCopyrightOverlay_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property MedalsOverlay() As MapOverlay
			Get
				If medalsOverlay_Renamed Is Nothing Then
					medalsOverlay_Renamed = CreateMedalsOverlay()
				End If
				Return medalsOverlay_Renamed
			End Get
		End Property

		Private Shared Function CreateBingLogoOverlay() As MapOverlay
			Dim overlay As New MapOverlay() With {.Alignment = ContentAlignment.BottomLeft, .Margin = New Padding(10, 0, 0, 10)}
			Dim logoItem As New MapOverlayImageItem() With {.Padding = New Padding(), .ImageUri = New Uri(DemoUtils.GetRelativePath("Images\BingLogo.png"))}
			overlay.Items.Add(logoItem)
			Return overlay
		End Function
		Private Shared Function CreateBingCopyrightOverlay() As MapOverlay
			Dim overlay As New MapOverlay() With {.Alignment = ContentAlignment.BottomRight, .Margin = New Padding(0, 0, 10, 10)}
			Dim copyrightItem As New MapOverlayTextItem() With {.Padding = New Padding(5), .Text = "Copyright © 2016 Microsoft and its suppliers. All rights reserved."}
			overlay.Items.Add(copyrightItem)
			Return overlay
		End Function
		Private Shared Function CreateOSMCopyrightOverlay() As MapOverlay
			Dim overlay As New MapOverlay() With {.Alignment = ContentAlignment.BottomRight, .Margin = New Padding(0, 0, 10, 10)}
			Dim copyrightItem As New MapOverlayTextItem() With {.Padding = New Padding(5), .Text = "© OpenStreetMap contributors"}
			overlay.Items.Add(copyrightItem)
			Return overlay
		End Function
		Private Shared Function CreateMedalsOverlay() As MapOverlay
			Dim overlay As New MapOverlay() With {.Alignment = ContentAlignment.TopCenter, .Margin = New Padding(10, 10, 10, 10)}
			Dim medalsItem As New MapOverlayTextItem() With {.Padding = New Padding(5), .Text = "2016 Summer Olympics Medal Result"}
			medalsItem.TextStyle.Font = New Font(AppearanceObject.DefaultFont.FontFamily, 16, FontStyle.Regular)
			overlay.Items.Add(medalsItem)
			Return overlay
		End Function
		Public Shared Function GetBingOverlays() As MapOverlay()
			Return New MapOverlay() { BingLogoOverlay, BingCopyrightOverlay }
		End Function
		Public Shared Function GetMedalsOverlay() As MapOverlay()
			Return New MapOverlay() { MedalsOverlay }
		End Function
		Public Shared Function GetClickedOverlayItem(ByVal hitInfo As MapHitInfo) As MapOverlayItemBase
			If hitInfo.InUIElement Then
				Dim overlayHitInfo As MapOverlayHitInfo = TryCast(hitInfo.UiHitInfo, MapOverlayHitInfo)
				If overlayHitInfo IsNot Nothing Then
					Return overlayHitInfo.OverlayItem
				End If
			End If
			Return Nothing
		End Function
	End Class

	Public MustInherit Class OverlayManagerBase
		Implements IDisposable
		Private fontsCollection_Renamed As Dictionary(Of String, Font)

		Protected ReadOnly Property FontsCollection() As Dictionary(Of String, Font)
			Get
				Return fontsCollection_Renamed
			End Get
		End Property

		Protected Sub New()
			Me.fontsCollection_Renamed = CreateFonts()
		End Sub

		Protected MustOverride Function CreateFonts() As Dictionary(Of String, Font)

		#Region "IDisposable implementation"
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				Dim keysCollection As IEnumerable(Of String) = New List(Of String)(Me.fontsCollection_Renamed.Keys)
				For Each key As String In keysCollection
					If fontsCollection_Renamed(key) IsNot Nothing Then
						Me.fontsCollection_Renamed(key).Dispose()
						Me.fontsCollection_Renamed(key) = Nothing
					End If
				Next key
			End If
		End Sub
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub
		#End Region
	End Class

	Public Class HotelPlansOverlayManager
		Inherits OverlayManagerBase
		Private overlay_Renamed As MapOverlay
		Private backImage_Renamed As MapOverlayImageItem
		Private hotelName_Renamed As MapOverlayTextItem

		Public ReadOnly Property Overlay() As MapOverlay
			Get
				Return overlay_Renamed
			End Get
		End Property
		Public ReadOnly Property BackImage() As MapOverlayImageItem
			Get
				Return backImage_Renamed
			End Get
		End Property
		Public ReadOnly Property HotelName() As MapOverlayTextItem
			Get
				Return hotelName_Renamed
			End Get
		End Property

		Public Sub New()
			CreateOverlay()
		End Sub

		Private Sub CreateOverlay()
			backImage_Renamed = New MapOverlayImageItem() With {.Padding = New Padding(5), .ImageUri = New Uri(DemoUtils.GetRelativePath("Images\BackButton.png"))}
			hotelName_Renamed = New MapOverlayTextItem() With {.Padding = New Padding(15)}
			hotelName_Renamed.TextStyle.Font = FontsCollection("back_text")
			overlay_Renamed = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(10, 10, 0, 0)}
			overlay_Renamed.BackgroundStyle.Fill = Color.Transparent
			overlay_Renamed.Items.AddRange(New MapOverlayItemBase() { backImage_Renamed, hotelName_Renamed })
		End Sub

		Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
			Dim collection As New Dictionary(Of String, Font)()
			collection.Add("back_text", New Font(AppearanceObject.DefaultFont.FontFamily, 20, FontStyle.Bold))
			Return collection
		End Function

		Public Function GetOverlays() As MapOverlay()
			Return New MapOverlay() { overlay_Renamed }
		End Function
	End Class

	Public Class BingServicesOverlayManager
		Inherits OverlayManagerBase
		Private overlay_Renamed As MapOverlay
		Private messageItem_Renamed As MapOverlayTextItem

		Public ReadOnly Property Overlay() As MapOverlay
			Get
				Return overlay_Renamed
			End Get
		End Property
		Public ReadOnly Property MessageItem() As MapOverlayTextItem
			Get
				Return messageItem_Renamed
			End Get
		End Property

		Public Sub New()
			CreateOverlay()
		End Sub

		Private Sub CreateOverlay()
			messageItem_Renamed = New MapOverlayTextItem() With {.Padding = New Padding(15, 10, 15, 10), .Text = "Click the map or use Search to find a location."}
			messageItem_Renamed.TextStyle.Font = FontsCollection("message")
			overlay_Renamed = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(10, 10, 0, 0)}
			overlay_Renamed.Items.Add(messageItem_Renamed)
		End Sub

		Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
			Dim collection As New Dictionary(Of String, Font)()
			collection.Add("message", New Font(AppearanceObject.DefaultFont.FontFamily, 20, FontStyle.Regular))
			Return collection
		End Function

		Public Function GetOverlays() As MapOverlay()
			Return New MapOverlay() { OverlayUtils.BingLogoOverlay, OverlayUtils.BingCopyrightOverlay, overlay_Renamed }
		End Function
	End Class

	Public Class PhotoGalleryOverlayManager
		Inherits OverlayManagerBase
		Private backIconOverlay_Renamed As MapOverlay
		Private placeOverlay_Renamed As MapOverlay
		Private navigationOverlay_Renamed As MapOverlay
		Private descriptionOverlay_Renamed As MapOverlay
		Private leftArrow As Image
		Private rightArrow As Image

		Public ReadOnly Property BackIconOverlay() As MapOverlay
			Get
				Return backIconOverlay_Renamed
			End Get
		End Property
		Public ReadOnly Property PlaceOverlay() As MapOverlay
			Get
				Return placeOverlay_Renamed
			End Get
		End Property
		Public ReadOnly Property NavigationOverlay() As MapOverlay
			Get
				Return navigationOverlay_Renamed
			End Get
		End Property
		Public ReadOnly Property DescriptionOverlay() As MapOverlay
			Get
				Return descriptionOverlay_Renamed
			End Get
		End Property

		Public ReadOnly Property BackIcon() As MapOverlayImageItem
			Get
				Return CType(backIconOverlay_Renamed.Items(0), MapOverlayImageItem)
			End Get
		End Property
		Public ReadOnly Property CityName() As MapOverlayTextItem
			Get
				Return CType(placeOverlay_Renamed.Items(0), MapOverlayTextItem)
			End Get
		End Property
		Public ReadOnly Property PlaceImage() As MapOverlayImageItem
			Get
				Return CType(placeOverlay_Renamed.Items(1), MapOverlayImageItem)
			End Get
		End Property
		Public ReadOnly Property PlacePrevImage() As MapOverlayImageItem
			Get
				Return CType(navigationOverlay_Renamed.Items(0), MapOverlayImageItem)
			End Get
		End Property
		Public ReadOnly Property PlaceNextImage() As MapOverlayImageItem
			Get
				Return CType(navigationOverlay_Renamed.Items(2), MapOverlayImageItem)
			End Get
		End Property
		Public ReadOnly Property PlaceName() As MapOverlayTextItem
			Get
				Return CType(navigationOverlay_Renamed.Items(1), MapOverlayTextItem)
			End Get
		End Property
		Public ReadOnly Property PlaceDescription() As MapOverlayTextItem
			Get
				Return CType(descriptionOverlay_Renamed.Items(0), MapOverlayTextItem)
			End Get
		End Property

		Public Sub New()
			Me.leftArrow = Image.FromFile(DemoUtils.GetRelativePath("Images\PhotoGallery\PrevPlace.png"))
			Me.rightArrow = Image.FromFile(DemoUtils.GetRelativePath("Images\PhotoGallery\NextPlace.png"))
			CreateOverlays()
		End Sub

		Private Sub CreateGalleryBackIconOverlay()
			backIconOverlay_Renamed = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(10, 10, 0, 0), .Padding = New Padding(5)}
			backIconOverlay_Renamed.BackgroundStyle.Fill = Color.Transparent
			Dim imageItem As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\BackButton.png"))}
			backIconOverlay_Renamed.Items.Add(imageItem)
		End Sub
		Private Sub CreateGalleryPlaceOverlay()
			placeOverlay_Renamed = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(0, 10, 10, 0)}
			Dim imageItem As New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .Padding = New Padding(20, 10, 20, 10)}
			Dim cityNameItem As New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .Padding = New Padding(0, 10, 0, 0)}
			cityNameItem.TextStyle.Font = FontsCollection("city")
			placeOverlay_Renamed.Items.AddRange(New MapOverlayItemBase() { cityNameItem, imageItem })
		End Sub
		Private Sub CreateGalleryNavigationOverlay()
			navigationOverlay_Renamed = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 10, 0), .Padding = New Padding(10)}
			Dim prevPlaceItem As New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopLeft, .Image = leftArrow}
			Dim placeNameItem As New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopLeft, .TextAlignment = ContentAlignment.MiddleCenter, .Size = New Size(242, 0), .Padding = New Padding(10, 0, 10, 0)}
			Dim nextPlaceItem As New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopLeft, .Image = rightArrow}
			placeNameItem.TextStyle.Font = FontsCollection("place")
			navigationOverlay_Renamed.Items.AddRange(New MapOverlayItemBase() { prevPlaceItem, placeNameItem, nextPlaceItem })
		End Sub
		Private Sub CreateGalleryDescriptionOverlay()
			descriptionOverlay_Renamed = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 10, 10, 0)}
			Dim descriptionItem As New MapOverlayTextItem() With {.Alignment = ContentAlignment.BottomCenter, .Padding = New Padding(10, 0, 10, 0), .Size = New Size(300, 0)}
			descriptionItem.TextStyle.Font = FontsCollection("desc")
			descriptionOverlay_Renamed.Items.Add(descriptionItem)
		End Sub
		Private Sub CreateOverlays()
			CreateGalleryBackIconOverlay()
			CreateGalleryPlaceOverlay()
			CreateGalleryNavigationOverlay()
			CreateGalleryDescriptionOverlay()
		End Sub

		Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
			Dim collection As New Dictionary(Of String, Font)()
			collection.Add("city", New Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Bold))
			collection.Add("place", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Bold))
			collection.Add("desc", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Regular))
			Return collection
		End Function
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If leftArrow IsNot Nothing Then
				leftArrow.Dispose()
				leftArrow = Nothing
			End If
			If rightArrow IsNot Nothing Then
				rightArrow.Dispose()
				rightArrow = Nothing
			End If
			MyBase.Dispose(disposing)
		End Sub

		Public Function GetOverlays() As MapOverlay()
			Return New MapOverlay() { OverlayUtils.BingLogoOverlay, OverlayUtils.BingCopyrightOverlay, backIconOverlay_Renamed, placeOverlay_Renamed, navigationOverlay_Renamed, descriptionOverlay_Renamed }
		End Function
		Public Sub RepaintImages(ByVal lookAndFeel As UserLookAndFeel)
			ColorHelper.UpdateColor(leftArrow, lookAndFeel)
			ColorHelper.UpdateColor(rightArrow, lookAndFeel)
		End Sub
	End Class

	Public Class MapElementsOverlayManager
		Inherits OverlayManagerBase
		Private imageOverlay As MapOverlay
		Private infoOverlay As MapOverlay
		Private imageItem As MapOverlayImageItem
		Private keys As New List(Of String) (New String() {"name", "id", "from", "to", "current_time", "flight_time", "speed", "altitude"})
		Private spacingMask As Dictionary(Of String, Boolean)
		Private itemsNames As Dictionary(Of String, String)
		Private textItems As Dictionary(Of String, MapOverlayTextItem)

		Public Sub New()
			textItems = New Dictionary(Of String, MapOverlayTextItem)()
			itemsNames = CreateNames()
			spacingMask = CreateSpacingMask()
			CreateOverlays()
		End Sub

		Private Function CreateNames() As Dictionary(Of String, String)
			Dim result As New Dictionary(Of String, String)()
			result.Add(keys(0), "Name")
			result.Add(keys(1), "Flight number")
			result.Add(keys(2), "From")
			result.Add(keys(3), "To")
			result.Add(keys(4), "Current time")
			result.Add(keys(5), "Flight time")
			result.Add(keys(6), "Speed")
			result.Add(keys(7), "Altitude")
			Return result
		End Function
		Private Function CreateSpacingMask() As Dictionary(Of String, Boolean)
			Dim result As New Dictionary(Of String, Boolean)()
			result.Add(keys(0), True)
			result.Add(keys(1), False)
			result.Add(keys(2), False)
			result.Add(keys(3), True)
			result.Add(keys(4), False)
			result.Add(keys(5), True)
			result.Add(keys(6), False)
			result.Add(keys(7), True)
			Return result
		End Function
		Private Sub CreateImageOverlay()
			imageOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(0, 10, 10, 0), .Padding = New Padding(10)}
			imageItem = New MapOverlayImageItem()
			imageOverlay.Items.Add(imageItem)
		End Sub
		Private Sub CreateInfoOverlay()
			infoOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 10, 0), .Padding = New Padding(10)}
			textItems.Clear()
			For Each key As String In keys
				Dim bottomPadding As Integer = If(spacingMask(key), 13, 3)
				Dim itemText As String = String.Format("{0}:", itemsNames(key))
				Dim labelItem As New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopLeft, .JoiningOrientation = Orientation.Vertical, .Size = New Size(105, 0), .Padding = New Padding(0, 3, 0, bottomPadding), .Text = itemText}
				labelItem.TextStyle.Font = FontsCollection("label")
				Dim valueItem As New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Size = New Size(120, 0), .Padding = New Padding(0, 3, 0, bottomPadding)}
				valueItem.TextStyle.Font = FontsCollection("value")
				textItems.Add(key, valueItem)
				infoOverlay.Items.AddRange(New MapOverlayItemBase() { labelItem, valueItem })
			Next key
		End Sub
		Private Sub CreateOverlays()
			CreateImageOverlay()
			CreateInfoOverlay()
		End Sub

		Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
			Dim collection As New Dictionary(Of String, Font)()
			collection.Add("label", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Regular))
			collection.Add("value", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Bold))
			Return collection
		End Function

		Public Function GetOverlays() As MapOverlay()
			Return New MapOverlay() { imageOverlay, infoOverlay, OverlayUtils.BingCopyrightOverlay, OverlayUtils.BingLogoOverlay }
		End Function
		Public Sub SetTextToItemByKey(ByVal key As String, ByVal text As String)
			If (Not textItems.ContainsKey(key)) Then
				Return
			End If
			textItems(key).Text = text
		End Sub
		Public Sub SetImage(ByVal image As Image)
			imageItem.Image = image
		End Sub
		Public Sub SetOverlaysVisibility(ByVal isVisible As Boolean)
			imageOverlay.Visible = isVisible
			infoOverlay.Visible = isVisible
		End Sub
	End Class

	Public Class FlagsGameOverlayManager
		Inherits OverlayManagerBase
		Private Shared ReadOnly HotTrackedColor As Color = Color.FromArgb(128, 135, 135, 135)
		Private Shared ReadOnly ChooseLevelBackgroundColor As Color = Color.FromArgb(32, Color.Gray)

		Private ReadOnly levelNames() As String
		Private ReadOnly levelDescriptions As Dictionary(Of String, String)
		Private levelItems As Dictionary(Of MapOverlayImageItem, MapOverlayTextItem)
		Private levelSelectorItems As Dictionary(Of MapOverlayTextItem, MapOverlayTextItem)
		Private selectedLevelItem As MapOverlayTextItem

		Private newGameOverlay, chooseLevelOverlay As MapOverlay
		Private startGameItem As MapOverlayTextItem
		Private levelDescItem As MapOverlayTextItem

		Private infoOverlay As MapOverlay
		Private infoTextItem As MapOverlayTextItem

		Private countryFlagOverlay As MapOverlay
		Private flagItem As MapOverlayImageItem
		Private countryName As MapOverlayTextItem

		Private skipCountryOverlay, showCountryOverlay As MapOverlay
		Private restartGameOverlay, finishGameOverlay As MapOverlay
		Private skipCountryItem, showCountryItem As MapOverlayTextItem
		Private restartGameItem, finishGameItem As MapOverlayTextItem

		Private statisticGameOverlay As MapOverlay
		Private scoreImage, timeImage As MapOverlayImageItem
		Private scoreLabel, timeLabel As MapOverlayTextItem
		Private scoreItem, winsItem, lossesItem, timeItem As MapOverlayTextItem

		Private gameOverOverlay, scoreOverOverlay As MapOverlay
		Private newGameItem, scoreOverItem As MapOverlayTextItem

		Public Sub New(ByVal levelNames() As String, ByVal levelDescriptions As Dictionary(Of String, String))
			Me.levelNames = levelNames
			Me.levelDescriptions = levelDescriptions
			CreateOverlays()
		End Sub

		Private Sub CreateOverlays()
			CreateNewGameOverlay()
			CreateChooseLevelOverlay()
			CreateCountryGameOverlay()
			CreateStatisticGameOverlay()
			CreateOperationGameOverlay()
			CreateScoreOverOverlay()
			CreateGameOverOverlay()
			CreateGameInfoOverlay()
		End Sub
		Private Sub CreateNewGameOverlay()
			newGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.MiddleCenter, .Padding = New Padding(30)}
			Dim titleText As New MapOverlayTextItem() With {.Text = "New Game", .Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(35, 0, 35, 12)}
			titleText.TextStyle.Font = FontsCollection("title")
			Dim infoText As New MapOverlayTextItem() With {.Text = "Choose your level", .Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(35, 0, 35, 130), .Size = New Size(470, 0)}
			infoText.TextStyle.Font = FontsCollection("note")
			levelDescItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Margin = New Padding(0, 30, 0, 30), .Size = New Size(500, 0)}
			levelDescItem.TextStyle.Font = FontsCollection("default")
			startGameItem = New MapOverlayTextItem() With {.Text = "START GAME", .Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(20, 10, 20, 10)}
			startGameItem.TextStyle.Font = FontsCollection("button")
			startGameItem.TextStyle.TextColor = Color.White
			startGameItem.BackgroundStyle.Fill = Color.FromArgb(&H74, &H9F, &HDF)
			startGameItem.HotTrackedStyle.Fill = Color.FromArgb(&HAF, &H74, &H9F, &HDF)
			newGameOverlay.Items.AddRange(New MapOverlayItemBase() { titleText, infoText, startGameItem, levelDescItem })
		End Sub
		Private Sub CreateChooseLevelOverlay()
			chooseLevelOverlay = New MapOverlay()
			levelItems = New Dictionary(Of MapOverlayImageItem, MapOverlayTextItem)()
			levelSelectorItems = New Dictionary(Of MapOverlayTextItem, MapOverlayTextItem)()
			For Each levelName As String In Me.levelNames
				Dim levelIconName As String = levelName.ToLower().Replace(" "c, "_"c)
				Dim iconItem As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\" & levelIconName & ".png")), .JoiningOrientation = Orientation.Horizontal, .Padding = New Padding(37, 20, 37, 20)}
				Dim nameItem As New MapOverlayTextItem() With {.Text = levelName.ToUpper(), .Size = New Size(80, 0), .Padding = New Padding(0, 20, 0, 20), .TextAlignment = ContentAlignment.BottomCenter}
				nameItem.TextStyle.Font = FontsCollection("level")
				nameItem.HotTrackedStyle.Fill = ChooseLevelBackgroundColor
				Dim selectorItem As New MapOverlayTextItem()
				selectorItem.HotTrackedStyle.Fill = ChooseLevelBackgroundColor
				Me.levelItems.Add(iconItem, nameItem)
				Me.levelSelectorItems.Add(nameItem, selectorItem)
			Next levelName
			chooseLevelOverlay.Items.AddRange(Me.levelItems.Keys)
			chooseLevelOverlay.Items.AddRange(Me.levelItems.Values)
			chooseLevelOverlay.Items.AddRange(Me.levelSelectorItems.Values)
		End Sub
		Private Sub CreateGameOverOverlay()
			gameOverOverlay = New MapOverlay() With {.Alignment = ContentAlignment.MiddleCenter, .JoiningOrientation = Orientation.Vertical, .Padding = New Padding(20)}
			Dim titleText As New MapOverlayTextItem() With {.Text = "GAME OVER", .Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(0, 0, 0, 15)}
			titleText.TextStyle.Font = FontsCollection("title")
			newGameItem = New MapOverlayTextItem() With {.Text = "NEW GAME", .Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(20, 10, 20, 10)}
			newGameItem.TextStyle.Font = FontsCollection("button")
			newGameItem.TextStyle.TextColor = Color.White
			newGameItem.BackgroundStyle.Fill = Color.FromArgb(&H40, &HAB, &H5B)
			newGameItem.HotTrackedStyle.Fill = Color.FromArgb(&HAF, &H40, &HAB, &H5B)
			gameOverOverlay.Items.AddRange(New MapOverlayItemBase() { newGameItem, titleText })
		End Sub
		Private Sub CreateScoreOverOverlay()
			scoreOverOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopCenter, .Margin = New Padding(0, 12, 0, 0), .Padding = New Padding(0, 15, 0, 5)}
			Dim scoreOverLabel As New MapOverlayTextItem() With {.Text = "SCORE:"}
			scoreOverLabel.TextStyle.Font = FontsCollection("score_over")
			scoreOverItem = New MapOverlayTextItem() With {.Padding = New Padding(10, 0, 0, 0)}
			scoreOverItem.TextStyle.Font = FontsCollection("score_over")
			scoreOverOverlay.Items.AddRange(New MapOverlayItemBase() { scoreOverLabel, scoreOverItem })
		End Sub
		Private Sub CreateCountryGameOverlay()
			countryFlagOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(12, 12, 0, 0)}
			countryName = New MapOverlayTextItem() With {.Alignment = ContentAlignment.BottomCenter, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(12, 0, 12, 15), .Size = New Size(150, 0)}
			countryName.TextStyle.Font = FontsCollection("bold")
			flagItem = New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopCenter, .Padding = New Padding(20)}
			countryFlagOverlay.Items.AddRange(New MapOverlayItemBase() { countryName, flagItem })
		End Sub
		Private Sub CreateStatisticGameOverlay()
			statisticGameOverlay = New MapOverlay() With {.JoiningOrientation = Orientation.Vertical, .Padding = New Padding(15, 3, 10, 3), .Margin = New Padding(0, 0, 0, 7)}
			scoreImage = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\score.png")), .Margin = New Padding(8, 12, 10, 12)}
			scoreLabel = New MapOverlayTextItem() With {.Text = "Score:", .Padding = New Padding(0, 10, 5, 10)}
			scoreLabel.TextStyle.Font = FontsCollection("default")
			scoreItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
			scoreItem.TextStyle.Font = FontsCollection("default")

			Dim winsImage As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\wins.png")), .Margin = New Padding(8, 12, 10, 12)}
			Dim winsLabel As New MapOverlayTextItem() With {.Text = "Wins:", .Padding = New Padding(0, 10, 5, 10)}
			winsLabel.TextStyle.Font = FontsCollection("default")
			winsItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
			winsItem.TextStyle.Font = FontsCollection("default")

			Dim lossesImage As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\loses.png")), .Margin = New Padding(8, 12, 10, 12)}
			Dim lossesLabel As New MapOverlayTextItem() With {.Text = "Losses:", .Padding = New Padding(0, 10, 5, 10)}
			lossesLabel.TextStyle.Font = FontsCollection("default")
			lossesItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
			lossesItem.TextStyle.Font = FontsCollection("default")

			timeImage = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\time.png")), .Margin = New Padding(8, 12, 10, 12)}
			timeLabel = New MapOverlayTextItem() With {.Text = "Time:", .Padding = New Padding(0, 10, 5, 10)}
			timeLabel.TextStyle.Font = FontsCollection("default")
			timeItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
			timeItem.TextStyle.Font = FontsCollection("default")
			statisticGameOverlay.Items.AddRange(New MapOverlayItemBase() { scoreImage, scoreLabel, scoreItem, winsImage, winsLabel, winsItem, lossesImage, lossesLabel, lossesItem, timeImage, timeLabel, timeItem })
		End Sub
		Private Sub CreateOperationGameOverlay()
			restartGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 12, 12, 0)}
			Dim restartIcon As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\restart.png")), .Margin = New Padding(10, 6, 7, 6)}
			restartGameItem = New MapOverlayTextItem() With {.Text = "RESTART GAME", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
			restartGameItem.TextStyle.Font = FontsCollection("nav_button")
			restartGameItem.HotTrackedStyle.Fill = HotTrackedColor
			restartGameOverlay.Items.AddRange(New MapOverlayItemBase() { restartIcon, restartGameItem })

			finishGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 12, 0)}
			Dim finishIcon As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\finish.png")), .Margin = New Padding(10, 6, 7, 6)}
			finishGameItem = New MapOverlayTextItem() With {.Text = "FINISH GAME", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
			finishGameItem.TextStyle.Font = FontsCollection("nav_button")
			finishGameItem.HotTrackedStyle.Fill = HotTrackedColor
			finishGameOverlay.Items.AddRange(New MapOverlayItemBase() { finishIcon, finishGameItem })

			skipCountryOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 12, 12, 0)}
			Dim skipIcon As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\skip.png")), .Margin = New Padding(10, 6, 7, 6)}
			skipCountryItem = New MapOverlayTextItem() With {.Text = "SKIP COUNTRY", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
			skipCountryItem.TextStyle.Font = FontsCollection("nav_button")
			skipCountryItem.HotTrackedStyle.Fill = HotTrackedColor
			skipCountryOverlay.Items.AddRange(New MapOverlayItemBase() { skipIcon, skipCountryItem })

			showCountryOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 12, 0)}
			Dim showIcon As New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\show.png")), .Margin = New Padding(10, 6, 7, 6)}
			showCountryItem = New MapOverlayTextItem() With {.Text = "SHOW COUNTRY", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
			showCountryItem.TextStyle.Font = FontsCollection("nav_button")
			showCountryItem.HotTrackedStyle.Fill = HotTrackedColor
			showCountryOverlay.Items.AddRange(New MapOverlayItemBase() { showIcon, showCountryItem })
		End Sub
		Private Sub CreateGameInfoOverlay()
			infoOverlay = New MapOverlay() With {.Margin = New Padding(0, 12, 0, 0)}
			infoTextItem = New MapOverlayTextItem() With {.TextAlignment = ContentAlignment.MiddleLeft, .Padding = New Padding(20), .Size = New Size(250, 0)}
			infoTextItem.TextStyle.Font = FontsCollection("info")
			infoOverlay.Items.Add(infoTextItem)
		End Sub
		Private Sub ScoreOverMode()
			statisticGameOverlay.Alignment = ContentAlignment.TopCenter
			timeImage.Visible = True
			timeLabel.Visible = True
			timeItem.Visible = True
			scoreImage.Visible = False
			scoreLabel.Visible = False
			scoreItem.Visible = False
		End Sub
		Private Sub ScoreGamingMode()
			statisticGameOverlay.Alignment = ContentAlignment.BottomCenter
			timeImage.Visible = False
			timeLabel.Visible = False
			timeItem.Visible = False
			scoreImage.Visible = True
			scoreLabel.Visible = True
			scoreItem.Visible = True
		End Sub
		Private Sub SetDefaultStyleLevelItems()
			For Each levelPair As KeyValuePair(Of MapOverlayImageItem, MapOverlayTextItem) In Me.levelItems
				ChangeSelectionOverlayItem(levelPair.Value, False)
			Next levelPair
		End Sub
		Private Sub ChangeSelectionOverlayItem(ByVal levelItem As MapOverlayTextItem, ByVal isSelect As Boolean)
			If isSelect Then
				Dim key As String = levelItem.Text.ToLower()
				Me.levelDescItem.Text = levelDescriptions(key)
				Me.selectedLevelItem = levelItem
			End If
			levelSelectorItems(levelItem).BackgroundStyle.Fill = If(isSelect, GetLevelColor(), ChooseLevelBackgroundColor)
		End Sub
		Private Sub RecalculateChooseLevelArrangement(ByVal overlayArrangement() As OverlayArrangement)
			Const itemsCount As Integer = 4
			Dim newGameRect As Rectangle = overlayArrangement(0).OverlayLayout
			overlayArrangement(1).OverlayLayout = Rectangle.FromLTRB(newGameRect.Left, newGameRect.Top + 120, newGameRect.Right, newGameRect.Top + 120 + 110)
			Dim itemsWidth As Double = overlayArrangement(1).ItemLayouts(itemsCount - 1).Right - overlayArrangement(1).ItemLayouts(0).Left
			Dim itemsOffset As Integer = CInt(Fix((newGameRect.Width - itemsWidth) / 2.0))
			For i As Integer = 0 To itemsCount - 1
				Dim iconRect As Rectangle = overlayArrangement(1).ItemLayouts(i)
				Dim textRect As Rectangle = overlayArrangement(1).ItemLayouts(i + itemsCount)
				iconRect = Rectangle.FromLTRB(iconRect.Left + itemsOffset, iconRect.Top, iconRect.Right + itemsOffset, iconRect.Bottom)
				textRect = Rectangle.FromLTRB(iconRect.Left, iconRect.Top, iconRect.Right, iconRect.Bottom + 25)
				overlayArrangement(1).ItemLayouts(i) = iconRect
				overlayArrangement(1).ItemLayouts(i + itemsCount) = textRect
				overlayArrangement(1).ItemLayouts(i + itemsCount * 2) = Rectangle.FromLTRB(textRect.Left, textRect.Bottom, textRect.Right, textRect.Bottom + 5)
			Next i
		End Sub
		Private Sub RecalculatScoreOverArrangement(ByVal overlayArrangement() As OverlayArrangement)
			Dim scoreRect As Rectangle = overlayArrangement(0).OverlayLayout
			Dim statisticRect As Rectangle = overlayArrangement(2).OverlayLayout
			overlayArrangement(0).OverlayLayout = Rectangle.FromLTRB(statisticRect.Left, scoreRect.Top, statisticRect.Right, scoreRect.Bottom)
			Dim itemsCount As Integer = overlayArrangement(0).ItemLayouts.Length
			Dim itemsWidth As Double = overlayArrangement(0).ItemLayouts(itemsCount - 1).Right - overlayArrangement(0).ItemLayouts(0).Left
			Dim itemsOffset As Integer = CInt(Fix((statisticRect.Width - itemsWidth) / 2.0))
			For i As Integer = 0 To itemsCount - 1
				Dim itemRect As Rectangle = overlayArrangement(0).ItemLayouts(i)
				overlayArrangement(0).ItemLayouts(i) = Rectangle.FromLTRB(itemRect.Left + itemsOffset, itemRect.Top, itemRect.Left + itemsOffset + itemRect.Width, itemRect.Bottom)
			Next i
		End Sub
		Private Sub RecalculateInfoArrangement(ByVal overlayArrangement() As OverlayArrangement)
			Dim countryRect As Rectangle = overlayArrangement(0).OverlayLayout
			Dim infoRect As Rectangle = overlayArrangement(1).OverlayLayout
			overlayArrangement(1).OverlayLayout = Rectangle.FromLTRB(infoRect.Left, countryRect.Top, infoRect.Right, countryRect.Bottom)
			Dim itemsHeight As Double = overlayArrangement(1).ItemLayouts(0).Height
			Dim itemsOffset As Integer = CInt(Fix((overlayArrangement(0).ItemLayouts(1).Height - itemsHeight) / 2.0))
			Dim itemRect As Rectangle = overlayArrangement(1).ItemLayouts(0)
			overlayArrangement(1).ItemLayouts(0) = Rectangle.FromLTRB(itemRect.Left, itemRect.Top + itemsOffset, itemRect.Right, itemRect.Top + itemsOffset + itemRect.Height)
		End Sub
		Private Function GetLevelColor() As Color
			Dim levelName As String = If(selectedLevelItem IsNot Nothing, selectedLevelItem.Text.ToLower(), String.Empty)
			If levelName = Me.levelNames(1) Then
				Return Color.FromArgb(&H40, &HAB, &H5B)
			End If
			If levelName = Me.levelNames(2) Then
				Return Color.FromArgb(&HFF, &HAE, &H00)
			End If
			If levelName = Me.levelNames(3) Then
				Return Color.FromArgb(&HFF, &H00, &H00)
			End If
			Return Color.FromArgb(&H74, &H9F, &HDF)
		End Function

		Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
			Dim collection As New Dictionary(Of String, Font)()
			collection.Add("title", New Font(AppearanceObject.DefaultFont.FontFamily, 23, FontStyle.Bold))
			collection.Add("note", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Regular))
			collection.Add("button", New Font(AppearanceObject.DefaultFont.FontFamily, 10, FontStyle.Bold))
			collection.Add("nav_button", New Font(AppearanceObject.DefaultFont.FontFamily, 9, FontStyle.Bold))
			collection.Add("score_over", New Font(AppearanceObject.DefaultFont.FontFamily, 17, FontStyle.Regular))
			collection.Add("default", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Regular))
			collection.Add("bold", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Bold))
			collection.Add("level", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Bold))
			collection.Add("info", New Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Regular))
			Return collection
		End Function

		Public Sub OverlaysArranged(ByVal overlayArrangement() As OverlayArrangement)
			If newGameOverlay.Visible AndAlso chooseLevelOverlay.Visible AndAlso overlayArrangement.Length >= 2 Then
				RecalculateChooseLevelArrangement(overlayArrangement)
			End If
			If statisticGameOverlay.Visible AndAlso scoreOverOverlay.Visible AndAlso overlayArrangement.Length >= 3 Then
				RecalculatScoreOverArrangement(overlayArrangement)
			End If
			If countryFlagOverlay.Visible AndAlso infoOverlay.Visible AndAlso overlayArrangement.Length >= 3 Then
				RecalculateInfoArrangement(overlayArrangement)
			End If
		End Sub
		Public Function GetOverlays() As MapOverlay()
			Return New MapOverlay() { newGameOverlay, chooseLevelOverlay, scoreOverOverlay, gameOverOverlay, countryFlagOverlay, infoOverlay, statisticGameOverlay, skipCountryOverlay, showCountryOverlay, restartGameOverlay, finishGameOverlay }
		End Function
		Public Sub HidePanels()
			newGameOverlay.Visible = False
			chooseLevelOverlay.Visible = False
			countryFlagOverlay.Visible = False
			statisticGameOverlay.Visible = False
			scoreOverOverlay.Visible = False
			gameOverOverlay.Visible = False
			skipCountryOverlay.Visible = False
			showCountryOverlay.Visible = False
			restartGameOverlay.Visible = False
			finishGameOverlay.Visible = False
			infoOverlay.Visible = False
		End Sub
		Public Sub ShowGameOverOverlay(ByVal time As String)
			HidePanels()
			ScoreOverMode()
			timeItem.Text = time
			scoreOverItem.Text = scoreItem.Text
			statisticGameOverlay.Visible = True
			scoreOverOverlay.Visible = True
			gameOverOverlay.Visible = True
		End Sub
		Public Sub ShowNewGameOverlay()
			HidePanels()
			newGameOverlay.Visible = True
			chooseLevelOverlay.Visible = True
		End Sub
		Public Sub ShowGameInfoOverlay()
			HidePanels()
			ScoreGamingMode()
			countryFlagOverlay.Visible = True
			statisticGameOverlay.Visible = True
			skipCountryOverlay.Visible = True
			showCountryOverlay.Visible = True
			restartGameOverlay.Visible = True
			finishGameOverlay.Visible = True
			infoOverlay.Visible = True
		End Sub


		Public Sub SetInfoMessage(ByVal text As String)
			infoTextItem.Text = text
		End Sub
		Public Sub SetScore(ByVal score As Double, ByVal wins As Integer, ByVal losses As Integer)
			Me.scoreItem.Text = score.ToString()
			Me.winsItem.Text = wins.ToString()
			Me.lossesItem.Text = losses.ToString()
		End Sub
		Public Sub SetCountry(ByVal flag As Image, ByVal name As String)
			Me.flagItem.Image = flag
			Me.countryName.Text = name
		End Sub
		Public Sub SetCountryNameVisibility(ByVal isVisible As Boolean)
			Me.countryName.Visible = isVisible
		End Sub
		Public Sub SetCountryOperationsVisibility(ByVal isVisible As Boolean)
			Me.skipCountryOverlay.Visible = isVisible
			Me.showCountryOverlay.Visible = isVisible
		End Sub
		Public Sub SelectDefaultLevel()
			SetDefaultStyleLevelItems()
			If Me.levelItems.Count > 0 Then
				ChangeSelectionOverlayItem(Me.levelItems.First().Value, True)
			End If
		End Sub
		Public Function GetSelectedLevel() As GameLevel
			Dim levelName As String = If(selectedLevelItem IsNot Nothing, selectedLevelItem.Text.ToLower(), String.Empty)
			If levelName = Me.levelNames(1) Then
				Return GameLevel.Middle
			End If
			If levelName = Me.levelNames(2) Then
				Return GameLevel.High
			End If
			If levelName = Me.levelNames(3) Then
				Return GameLevel.VeryHigh
			End If
			Return GameLevel.Easy
		End Function
		Public Function GetClickedAction(ByVal clickedItem As MapOverlayItemBase) As ClickedAction
			If clickedItem Is Me.skipCountryItem Then
				Return ClickedAction.SkipCountry
			End If
			If clickedItem Is Me.showCountryItem Then
				Return ClickedAction.ShowCountry
			End If
			If clickedItem Is Me.finishGameItem Then
				Return ClickedAction.FinishGame
			End If
			If clickedItem Is Me.startGameItem Then
				Return ClickedAction.StartGame
			End If
			If clickedItem Is Me.restartGameItem OrElse clickedItem Is Me.newGameItem Then
				Return ClickedAction.NewGame
			End If
			Dim levelPair As KeyValuePair(Of MapOverlayImageItem, MapOverlayTextItem) = Me.levelItems.FirstOrDefault(Function(x) x.Value.Equals(clickedItem) OrElse x.Key.Equals(clickedItem))
			If levelPair.Value IsNot Nothing Then
				SetDefaultStyleLevelItems()
				ChangeSelectionOverlayItem(levelPair.Value, True)
				Return ClickedAction.ChangeLevel
			End If
			Return ClickedAction.Unknown
		End Function
	End Class

	Public Enum ClickedAction
		Unknown
		ChangeLevel
		NewGame
		StartGame
		FinishGame
		SkipCountry
		ShowCountry
	End Enum
End Namespace
