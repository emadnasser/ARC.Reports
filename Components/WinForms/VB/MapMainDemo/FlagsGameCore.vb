Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.Demos.FlagsGameCore
	Public Enum GameLevel
		Easy = 0
		Middle = 1
		High = 2
		VeryHigh = 3
	End Enum
	Public Enum AnswerStatus
		Win
		Lose
		WrongTry
		ShowCountry
	End Enum

	Public Class CountryDataEventArgs
		Inherits EventArgs
		Public Property Flag() As Image
		Public Property Name() As String
	End Class

	Public Class ChoiseAnswerEventArgs
		Inherits EventArgs
		Public Property Status() As AnswerStatus
		Public Property ScoreDelta() As Double
		Public Property CountryName() As String
	End Class

	Public Class ScoreChangedAnswerEventArgs
		Inherits EventArgs
		Public Property Score() As Double
		Public Property Wins() As Integer
		Public Property Losses() As Integer
	End Class

	Public Class GameOverEventArgs
		Inherits EventArgs
		Public Property Time() As String
	End Class

	Public Class FlagsGameCore
		Implements IDisposable
		Private Shared ReadOnly FlagExtension As String = ".png"
		Private Shared ReadOnly rand As New Random(DateTime.Now.Millisecond)
		Private ReadOnly flagsDirectory As String
		Private ReadOnly actualCountries As List(Of String)
		Private unusedCountries As List(Of String)
		Private countriesFlags As Dictionary(Of String, Image)
		Private gameLevel As GameLevel = GameLevel.Easy
		Private startGameTime As DateTime
		Private finishGameTime As DateTime
		Private currentCountry As String
		Private isGameActive_Renamed As Boolean
		Private wins As Integer
		Private losses As Integer
		Private score As Double

		Private ReadOnly Property GamingTicks() As Long
			Get
				Return If(isGameActive_Renamed, (DateTime.Now.Subtract(startGameTime)).Ticks, (finishGameTime.Subtract(startGameTime)).Ticks)
			End Get
		End Property
		Public ReadOnly Property IsGameActive() As Boolean
			Get
				Return isGameActive_Renamed
			End Get
		End Property
		Public ReadOnly Property CurrentCountryName() As String
			Get
				Return currentCountry
			End Get
		End Property

		Public Event GameOver As EventHandler(Of GameOverEventArgs)
		Public Event ScoreChanged As EventHandler(Of ScoreChangedAnswerEventArgs)
		Public Event CountryChanged As EventHandler(Of CountryDataEventArgs)
		Public Event ChoiseAnswer As EventHandler(Of ChoiseAnswerEventArgs)

		Public Sub New(ByVal countriesList As List(Of String), ByVal flagsDirectory As String)
			Me.actualCountries = countriesList
			Me.flagsDirectory = flagsDirectory
			Me.countriesFlags = New Dictionary(Of String, Image)()
		End Sub

		Private Sub RaiseEventGameOver()
			If GameOverEvent IsNot Nothing Then
				Dim gameOverData As New GameOverEventArgs() With {.Time = GetGameTime()}
				RaiseEvent GameOver(Me, gameOverData)
			End If
		End Sub
		Private Sub RaiseEventScoreChanged()
			If ScoreChangedEvent IsNot Nothing Then
				Dim scoreData As New ScoreChangedAnswerEventArgs() With {.Score = score, .Wins = wins, .Losses = losses}
				RaiseEvent ScoreChanged(Me, scoreData)
			End If
		End Sub
		Private Sub RaiseEventCountryChanged(ByVal flag As Image, ByVal countryName As String)
			If CountryChangedEvent IsNot Nothing Then
				Dim countryData As New CountryDataEventArgs() With {.Flag = flag, .Name = countryName}
				RaiseEvent CountryChanged(Me, countryData)
			End If
		End Sub
		Private Sub RaiseEventChoiseAnswer(ByVal status As AnswerStatus, ByVal countryName As String, ByVal scoreDelta As Double)
			If ChoiseAnswerEvent IsNot Nothing Then
				Dim answerData As New ChoiseAnswerEventArgs() With {.Status = status, .CountryName = countryName, .ScoreDelta = scoreDelta}
				RaiseEvent ChoiseAnswer(Me, answerData)
			End If
		End Sub
		Private Function GetCountryFlag(ByVal countryName As String) As Image
			Dim flagPath As String = Path.Combine(flagsDirectory, countryName.Replace(" "c, "_"c) & FlagExtension)
			If (Not Me.countriesFlags.ContainsKey(countryName)) Then
				Dim flagImage As Image = Image.FromFile(flagPath)
				Me.countriesFlags.Add(countryName, flagImage)
			End If
			Return Me.countriesFlags(countryName)
		End Function
		Private Sub NextCountry()
			If unusedCountries.Count > 0 Then
				Dim index As Integer = rand.Next(unusedCountries.Count)
				Dim countryName As String = Me.unusedCountries(index)
				Me.unusedCountries.Remove(countryName)
				Me.currentCountry = countryName
				RaiseEventCountryChanged(GetCountryFlag(countryName), countryName)
			Else
				FinishGame()
			End If
		End Sub
		Private Sub RightChoice(ByVal countryName As String)
			Dim stepScore As Integer = GetScoreStep()
			Me.wins += 1
			Me.score += stepScore
			RaiseEventChoiseAnswer(AnswerStatus.Win, countryName, stepScore)
		End Sub
		Private Sub WrongChoice(ByVal countryName As String)
			Dim stepScore As Integer = GetScoreStep()
			Me.losses += 1
			Me.score -= stepScore
			RaiseEventChoiseAnswer(AnswerStatus.Lose, countryName, -stepScore)
		End Sub
		Private Sub WrongTry(ByVal countryName As String)
			Dim stepScore As Integer = 1
			Me.score -= stepScore
			RaiseEventChoiseAnswer(AnswerStatus.WrongTry, countryName, -stepScore)
		End Sub
		Private Function GetScoreStep() As Integer
			Return 10 + 5 * CInt(Fix(gameLevel))
		End Function
		Private Function GetGameTime() As String
			Dim time As New DateTime(GamingTicks)
			Dim isPrinting As Boolean = False
			Dim timeString As String = ""
			If isPrinting OrElse time.Hour > 0 Then
				timeString &= time.ToString("HH", CultureInfo.InvariantCulture) & "H "
				isPrinting = True
			End If
			If isPrinting OrElse time.Minute > 0 Then
				timeString &= time.ToString("mm", CultureInfo.InvariantCulture) & "m "
				isPrinting = True
			End If
			If isPrinting OrElse time.Second > 0 Then
				timeString &= time.ToString("ss", CultureInfo.InvariantCulture) & "s "
				isPrinting = True
			End If
			timeString &= time.ToString("ff", CultureInfo.InvariantCulture) & "ms "
			Return timeString
		End Function

		Public Sub StartGame(ByVal level As GameLevel)
			Me.gameLevel = level
			Me.unusedCountries = New List(Of String)(actualCountries)
			Me.currentCountry = ""
			Me.wins = 0
			Me.losses = 0
			Me.score = 0
			Me.isGameActive_Renamed = True
			Me.startGameTime = DateTime.Now
			RaiseEventScoreChanged()
			NextCountry()
		End Sub
		Public Sub StartGame()
			StartGame(GameLevel.Easy)
		End Sub
		Public Sub FinishGame()
			Me.finishGameTime = DateTime.Now
			Me.isGameActive_Renamed = False
			RaiseEventGameOver()
		End Sub
		Public Function TrySelectionCountry(ByVal countryName As String) As Boolean
			If (Not Me.isGameActive_Renamed) Then
				Return False
			End If
			Dim isCorrectSelection As Boolean = countryName = Me.currentCountry
			If isCorrectSelection Then
				RightChoice(Me.currentCountry)
				NextCountry()
			ElseIf gameLevel <> GameLevel.Easy Then
				WrongChoice(Me.currentCountry)
				NextCountry()
			Else
				WrongTry(countryName)
			End If
			RaiseEventScoreChanged()
			Return isCorrectSelection
		End Function
		Public Sub SkipCountry()
			If (Not isGameActive_Renamed) Then
				Return
			End If
			WrongChoice(Me.currentCountry)
			RaiseEventScoreChanged()
			NextCountry()
		End Sub
		Public Sub ShowCountry()
			If (Not isGameActive_Renamed) Then
				Return
			End If
			Dim stepScore As Double = 0.5
			Me.score -= stepScore
			RaiseEventChoiseAnswer(AnswerStatus.ShowCountry, currentCountry, -stepScore)
			RaiseEventScoreChanged()
		End Sub
		#Region "IDisposable implementation"
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				Dim keysCollection As IEnumerable(Of String) = New List(Of String)(Me.countriesFlags.Keys)
				For Each key As String In keysCollection
					If countriesFlags(key) IsNot Nothing Then
						Me.countriesFlags(key).Dispose()
						Me.countriesFlags(key) = Nothing
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
End Namespace
