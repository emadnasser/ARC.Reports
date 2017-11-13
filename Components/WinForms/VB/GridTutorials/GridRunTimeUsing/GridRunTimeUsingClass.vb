Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class ColorMaker
		Private startColor, endColor As Color

		Friend Sub New()
			startColor = SystemColors.ControlDark
			endColor = SystemColors.Window
		End Sub

		Friend Sub New(ByVal StartColor As Color, ByVal EndColor As Color)
			Me.startColor = StartColor
			Me.endColor = EndColor
		End Sub

		Friend Function ProduceColor(ByVal Brightness As Integer) As Color
			Dim c As Color
			Dim r, g, b, a As Integer

			If Brightness > 100 Then
				Brightness = 100
			End If

			If Brightness < 0 Then
				Brightness = 0
			End If

            r = startColor.R + (endColor.R - startColor.R) * Brightness \ 100
            g = startColor.G + (endColor.G - startColor.G) * Brightness \ 100
            b = startColor.B + (endColor.B - startColor.B) * Brightness \ 100
            a = startColor.A + (endColor.A - startColor.A) * Brightness \ 100

			c = Color.FromArgb(a, r, g, b)

			Return c
		End Function
	End Class
End Namespace
