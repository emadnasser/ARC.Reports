Imports Microsoft.VisualBasic
Imports DevExpress.Demos.FlagsGameCore
Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos
	Partial Public Class MapOverlays
		Inherits MapTutorialControl
		Private Const SelectMessage As String = "Find the country whose flag is given on the left."
		Private Const WrongSelectMessage As String = "If your answer is correct, you will win points; otherwise, you will lose them."
		Private Const ForWinMessage As String = "Right answers are the key to success."
		Private Const ForEndGame As String = "To finish the game, either find all 177 countries or click the Finish Game button."
		Private Const AnswerAttributeName As String = "Answer"
		Private ReadOnly flagsDirectoryPath As String = DemoUtils.GetRelativeDirectoryPath("Images\Flags\Big")
		Private ReadOnly levelNames() As String = { "easy", "normal", "hard", "very hard" }

		Private gameCore As FlagsGameCore
		Private overlayManager_Renamed As FlagsGameOverlayManager
		Private consecutiveWins As Integer

		Private ReadOnly Property OverlayManager() As FlagsGameOverlayManager
			Get
				If overlayManager_Renamed Is Nothing Then
					overlayManager_Renamed = CreateOverlayManager()
				End If
				Return overlayManager_Renamed
			End Get
		End Property

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayManager.GetOverlays()
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ShapefileDataAdapter.FileUri = New Uri("file:\\" & DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute)
		End Sub

		Private Function CreateLevelDescriptions() As Dictionary(Of String, String)
			Dim result As New Dictionary(Of String, String)()
			result.Add(Me.levelNames(0), "Country flags and names are shown. An incorrectly selected country is not skipped. The Show Country button is hidden.")
			result.Add(Me.levelNames(1), "Country flags and names are shown. An incorrectly selected country is skipped. The Show Country button is hidden.")
			result.Add(Me.levelNames(2), "Only country flags are shown. An incorrectly selected country is skipped. The Show Country button is hidden.")
			result.Add(Me.levelNames(3), "Only country flags are shown. Country titles are not shown on the map. An incorrectly selected country is skipped. The Show Country button is hidden.")
			Return result
		End Function
		Private Sub ShapeItemsLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs) Handles ShapefileDataAdapter.ItemsLoaded
			Dim countriesNames As New List(Of String)()
			For Each item As MapItem In e.Items
				Dim countryName As String = GetCountryNameFromItem(item)
				If (Not String.IsNullOrEmpty(countryName)) Then
					countriesNames.Add(countryName)
				End If
			Next item
			CreateGameCore(countriesNames)
		End Sub
		Private Sub LayerDataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles FileLayer.DataLoaded
			MapInteractiveEnabling(False)
			OverlayManager.ShowNewGameOverlay()
		End Sub
		Private Sub MapControl_OverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs) Handles mapControl1.OverlaysArranged
			OverlayManager.OverlaysArranged(e.OverlayArrangements)
		End Sub

		Private Function CreateOverlayManager() As FlagsGameOverlayManager
			Dim manager As New FlagsGameOverlayManager(levelNames, CreateLevelDescriptions())
			manager.SelectDefaultLevel()
			Return manager
		End Function
		Private Sub CreateGameCore(ByVal countriesNames As List(Of String))
			Me.gameCore = New FlagsGameCore(countriesNames, flagsDirectoryPath)
			AddHandler Me.gameCore.ScoreChanged, AddressOf GameCoreScoreChanged
			AddHandler Me.gameCore.CountryChanged, AddressOf GameCoreCountryChanged
			AddHandler Me.gameCore.ChoiseAnswer, AddressOf GameCoreChoiseAnswer
			AddHandler Me.gameCore.GameOver, AddressOf GameCoreGameOver
		End Sub
		Private Sub SetLevelSettings(ByVal level As GameLevel)
			OverlayManager.SetCountryOperationsVisibility(level = GameLevel.Easy)
			OverlayManager.SetCountryNameVisibility(level = GameLevel.Easy OrElse level = GameLevel.Middle)
			FileLayer.ShapeTitlesVisibility = If(level <> GameLevel.VeryHigh, VisibilityMode.Auto, VisibilityMode.Hidden)
		End Sub
		Private Sub GameInit(ByVal level As GameLevel)
			Me.gameCore.StartGame(level)
			OverlayManager.ShowGameInfoOverlay()
			OverlayManager.SetInfoMessage(SelectMessage)
			ResetCountriesSelections(True)
			MapInteractiveEnabling(True)
			SetLevelSettings(level)
			MapControl.CenterPoint = New GeoPoint(33, 0)
			MapControl.ZoomLevel = 2.0
			consecutiveWins = 0
		End Sub
		Private Sub ResetCountriesSelections(ByVal isAll As Boolean)
			For Each item As MapItem In FileLayer.Data.Items
				Dim answerAttribute As MapItemAttribute = item.Attributes(AnswerAttributeName)
				If answerAttribute IsNot Nothing AndAlso (answerAttribute.Value.Equals("Try") OrElse isAll) Then
					item.Attributes.Remove(answerAttribute)
				End If
			Next item
		End Sub
		Private Sub SetCountryTrySelection(ByVal item As MapItem)
			Dim answerAttribute As MapItemAttribute = item.Attributes(AnswerAttributeName)
			If answerAttribute IsNot Nothing Then
				Return
			End If
			item.Attributes.Add(New MapItemAttribute() With {.Name = AnswerAttributeName, .Value = "Try"})
		End Sub
		Private Sub MapInteractiveEnabling(ByVal isEnabled As Boolean)
			FileLayer.EnableSelection = isEnabled
			FileLayer.EnableHighlighting = isEnabled
			MapControl.EnableScrolling = isEnabled
			MapControl.EnableZooming = isEnabled
			If (Not isEnabled) Then
				FileLayer.ShapeTitlesVisibility = VisibilityMode.Hidden
			End If
			If isEnabled Then
				AddHandler MapControl.MapItemClick, AddressOf mapControl1_MapItemClick
			Else
				RemoveHandler MapControl.MapItemClick, AddressOf mapControl1_MapItemClick
			End If
		End Sub
		Private Sub SetItemChoiseResult(ByVal item As MapItem, ByVal status As AnswerStatus)
			Select Case status
				Case AnswerStatus.Win
					item.Attributes.Add(New MapItemAttribute() With {.Name = AnswerAttributeName, .Value = "Right"})
					ResetCountriesSelections(False)
					consecutiveWins += 1
					OverlayManager.SetInfoMessage(If(consecutiveWins >= 3, ForEndGame, ForWinMessage))
				Case AnswerStatus.Lose
					item.Attributes.Add(New MapItemAttribute() With {.Name = AnswerAttributeName, .Value = "Wrong"})
					ResetCountriesSelections(False)
					consecutiveWins = 0
					OverlayManager.SetInfoMessage(WrongSelectMessage)
				Case AnswerStatus.WrongTry
					SetCountryTrySelection(item)
					consecutiveWins = 0
				Case AnswerStatus.ShowCountry
					MapControl.ZoomToFit(New List(Of MapItem) (New MapItem() {item}))
			End Select
		End Sub
		Private Function GetCountryItem(ByVal countryName As String) As MapItem
			For Each item As MapItem In FileLayer.Data.Items
				If GetCountryNameFromItem(item) = countryName Then
					Return item
				End If
			Next item
			Return Nothing
		End Function
		Private Function GetCountryNameFromItem(ByVal item As MapItem) As String
			Return If(item.Attributes("ADMIN") Is Nothing OrElse item.Attributes("ADMIN").Value Is Nothing, String.Empty, item.Attributes("ADMIN").Value.ToString())
		End Function
		Private Sub GameCoreScoreChanged(ByVal sender As Object, ByVal e As ScoreChangedAnswerEventArgs)
			OverlayManager.SetScore(e.Score, e.Wins, e.Losses)
		End Sub
		Private Sub GameCoreCountryChanged(ByVal sender As Object, ByVal e As CountryDataEventArgs)
			OverlayManager.SetCountry(e.Flag, e.Name)
		End Sub
		Private Sub GameCoreChoiseAnswer(ByVal sender As Object, ByVal e As ChoiseAnswerEventArgs)
			Dim countryItem As MapItem = GetCountryItem(e.CountryName)
			If countryItem IsNot Nothing Then
				SetItemChoiseResult(countryItem, e.Status)
			End If
		End Sub
		Private Sub GameCoreGameOver(ByVal sender As Object, ByVal e As GameOverEventArgs)
			MapInteractiveEnabling(False)
			OverlayManager.ShowGameOverOverlay(e.Time)
		End Sub
		Private Sub mapControl1_MapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs)
			Dim selectedCountryName As String = GetCountryNameFromItem(e.Item)
			Me.gameCore.TrySelectionCountry(selectedCountryName)
			FileLayer.SelectedItems.Clear()
		End Sub
		Private Sub mapControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles mapControl1.MouseUp
			If e.Button <> MouseButtons.Left Then
				Return
			End If
			Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
			Dim clickedItem As MapOverlayItemBase = OverlayUtils.GetClickedOverlayItem(hitInfo)
			If clickedItem Is Nothing Then
				Return
			End If
			Dim action As ClickedAction = OverlayManager.GetClickedAction(clickedItem)
			Select Case action
				Case ClickedAction.NewGame
					MapInteractiveEnabling(False)
					OverlayManager.ShowNewGameOverlay()
				Case ClickedAction.StartGame
					GameInit(OverlayManager.GetSelectedLevel())
				Case ClickedAction.FinishGame
					Me.gameCore.FinishGame()
				Case ClickedAction.ShowCountry
					Me.gameCore.ShowCountry()
				Case ClickedAction.SkipCountry
					Me.gameCore.SkipCountry()
			End Select
		End Sub
		Private Sub OnDispose(ByVal disposing As Boolean)
			If Me.overlayManager_Renamed IsNot Nothing Then
				Me.overlayManager_Renamed.Dispose()
				Me.overlayManager_Renamed = Nothing
			End If
			If Me.gameCore IsNot Nothing Then
				Me.gameCore.Dispose()
				Me.gameCore = Nothing
			End If
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			ChkShowMinimap.Enabled = False
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(33, 0)
			MapControl.ZoomLevel = 2
		End Sub
	End Class
End Namespace
