Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraGauges.Demos
    Friend Class TravelingLine
        Inherits TutorialControl
        Private Shared specChars() As Char = {"."c, "'"c, ","c}

        Private visibleSymbolsCount As Integer = 0
        Private substringStartIndex As Integer = 0
        Private fullTextToShow As String = ""

        Public Sub New()
            InitializeComponent()
            Init()
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
            UpdateText()
        End Sub
        Private Sub OnDirectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDirection.SelectedIndexChanged
            Init()
        End Sub
        Sub OnTravelingTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles travelingText.EditValueChanged
            Init()
        End Sub
        Sub OnTravelingSpeedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles travelingSpeed.ValueChanged
            Init()
        End Sub
        Private Function IsSpecialCharacter(ByVal character As Char) As Boolean
            Return Array.IndexOf(specChars, character) <> -1
        End Function
        Protected Sub Init()
            timer1.Stop()
            timer1.Interval = 500 \ (travelingSpeed.Value + 1)
            timer1.Start()
            If digitalGauge1.DigitCount > 0 Then
                fullTextToShow = New String(" "c, digitalGauge1.DigitCount) + travelingText.Text + New String(" "c, digitalGauge1.DigitCount)
            End If
            visibleSymbolsCount = digitalGauge1.DigitCount
            If cbDirection.SelectedIndex = 0 Then
                substringStartIndex = 0
            Else
                substringStartIndex = fullTextToShow.Length - visibleSymbolsCount
            End If
        End Sub
        Protected Sub UpdateText()
            Dim additionalSymbolsCount As Integer = Array.FindAll(fullTextToShow.Substring(substringStartIndex, visibleSymbolsCount).ToCharArray(), AddressOf IsSpecialCharacter).Length
            digitalGauge1.Text = fullTextToShow.Substring(substringStartIndex, visibleSymbolsCount + additionalSymbolsCount)
            If cbDirection.SelectedIndex = 0 Then
                substringStartIndex += 1
            Else
                substringStartIndex -= 1
            End If
            If substringStartIndex < 0 Then
                substringStartIndex = fullTextToShow.Length - visibleSymbolsCount
            ElseIf substringStartIndex > fullTextToShow.Length - visibleSymbolsCount Then
                substringStartIndex = 0
            End If
            If IsSpecialCharacter(fullTextToShow.Chars(substringStartIndex)) Then
                If cbDirection.SelectedIndex = 0 Then
                    substringStartIndex += 1
                Else
                    substringStartIndex -= 1
                End If
            End If
        End Sub
    End Class
End Namespace
