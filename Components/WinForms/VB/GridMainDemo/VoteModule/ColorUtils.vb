Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Drawing

Namespace DevExpress.VoteApp
	Public Class HSLColor
		Private Const scale As Double = 240.0
        Private hue_Renamed As Double = 1.0
        Private saturation_Renamed As Double = 1.0
        Private luminosity_Renamed As Double = 1.0
        Public Sub New()
		End Sub
		Public Sub New(ByVal color As Color)
			Me.New(color.R, color.G, color.B)
		End Sub
		Public Sub New(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer)
			SetRGB(red, green, blue)
		End Sub
		Public Sub New(ByVal hue As Double, ByVal saturation As Double, ByVal luminosity As Double)
			Me.Hue = hue
			Me.Saturation = saturation
			Me.Luminosity = luminosity
		End Sub
		Public Shared Function Darken(ByVal color As Color, ByVal amount As Double) As Color '0..1
			Dim hslColor As New HSLColor(color)
			hslColor.Luminosity *= amount
			Return hslColor
		End Function
		Public Shared Function Lighter(ByVal color As Color, ByVal amount As Double) As Color '1..2
			Dim hslColor As New HSLColor(color)
			hslColor.Luminosity *= amount
			Return hslColor
		End Function
		Public Property Hue() As Double
			Get
				Return hue_Renamed * scale
			End Get
			Set(ByVal value As Double)
				hue_Renamed = Check(value / scale)
			End Set
		End Property
		Public Property Saturation() As Double
			Get
				Return saturation_Renamed * scale
			End Get
			Set(ByVal value As Double)
				saturation_Renamed = Check(value / scale)
			End Set
		End Property
		Public Property Luminosity() As Double
			Get
				Return luminosity_Renamed * scale
			End Get
			Set(ByVal value As Double)
				luminosity_Renamed = Check(value / scale)
			End Set
		End Property
		Private Function Check(ByVal value As Double) As Double
			If value < 0.0 Then
				value = 0.0
			ElseIf value > 1.0 Then
				value = 1.0
			End If
			Return value
		End Function
		Public Sub SetRGB(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer)
			Dim hslColor As HSLColor = CType(Color.FromArgb(red, green, blue), HSLColor)
			Me.hue_Renamed = hslColor.hue_Renamed
			Me.saturation_Renamed = hslColor.saturation_Renamed
			Me.luminosity_Renamed = hslColor.luminosity_Renamed
		End Sub

		Public Overrides Function ToString() As String
			Return String.Format("H: {0:#0.##} S: {1:#0.##} L: {2:#0.##}", Hue, Saturation, Luminosity)
		End Function

		Public Shared Widening Operator CType(ByVal hslColor As HSLColor) As Color
			Dim r As Double = 0, g As Double = 0, b As Double = 0
			If hslColor.luminosity_Renamed <> 0 Then
				If hslColor.saturation_Renamed = 0 Then
					b = hslColor.luminosity_Renamed
					g = b
					r = g
				Else
					Dim temp2 As Double = GetTemp2(hslColor)
					Dim temp1 As Double = 2.0 * hslColor.luminosity_Renamed - temp2

                    r = GetColorComponent(temp1, temp2, hslColor.hue_Renamed + 1.0 / 3.0)
                    g = GetColorComponent(temp1, temp2, hslColor.hue_Renamed)
                    b = GetColorComponent(temp1, temp2, hslColor.hue_Renamed - 1.0 / 3.0)
                End If
			End If
			Return Color.FromArgb(CInt(Math.Truncate(255 * r)), CInt(Math.Truncate(255 * g)), CInt(Math.Truncate(255 * b)))
		End Operator

		Private Shared Function GetColorComponent(ByVal temp1 As Double, ByVal temp2 As Double, ByVal temp3 As Double) As Double
			temp3 = MoveIntoRange(temp3)
            If temp3 < 1.0 / 6.0 Then
                Return temp1 + (temp2 - temp1) * 6.0 * temp3
            ElseIf temp3 < 0.5 Then
                Return temp2
            ElseIf temp3 < 2.0 / 3.0 Then
                Return temp1 + ((temp2 - temp1) * ((2.0 / 3.0) - temp3) * 6.0)
            Else
                Return temp1
			End If
		End Function
		Private Shared Function MoveIntoRange(ByVal temp3 As Double) As Double
			If temp3 < 0.0 Then
				temp3 += 1.0
			ElseIf temp3 > 1.0 Then
				temp3 -= 1.0
			End If
			Return temp3
		End Function
		Private Shared Function GetTemp2(ByVal hslColor As HSLColor) As Double
			Dim temp2 As Double
			If hslColor.luminosity_Renamed < 0.5 Then
				temp2 = hslColor.luminosity_Renamed * (1.0 + hslColor.saturation_Renamed)
			Else
				temp2 = hslColor.luminosity_Renamed + hslColor.saturation_Renamed - (hslColor.luminosity_Renamed * hslColor.saturation_Renamed)
			End If
			Return temp2
		End Function

		Public Shared Widening Operator CType(ByVal color As Color) As HSLColor
			Dim hslColor As New HSLColor()
			hslColor.hue_Renamed = color.GetHue() / 360.0
			hslColor.luminosity_Renamed = color.GetBrightness()
			hslColor.saturation_Renamed = color.GetSaturation()
			Return hslColor
		End Operator

	End Class
End Namespace
