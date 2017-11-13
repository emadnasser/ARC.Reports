Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Win.Gauges.State

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucCardWidget
		Inherits UserControl
		Private updateTimer As New Timer()
		Public Sub New()
			InitializeComponent()
		End Sub
		Private privatePrice As Decimal
		Public Property Price() As Decimal
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Decimal)
				privatePrice = value
			End Set
		End Property
		Private privatePPrice As Double
		Public Property PPrice() As Double
			Get
				Return privatePPrice
			End Get
			Set(ByVal value As Double)
				privatePPrice = value
			End Set
		End Property
		Private privateDelta As Double
		Public Property Delta() As Double
			Get
				Return privateDelta
			End Get
			Set(ByVal value As Double)
				privateDelta = value
			End Set
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			labelControl1.StateIndex = If(Delta > 0, 0, 1)
			If labelControl1.StateIndex = 0 Then
				labelControl1.Text = Price.ToString("C1") & "<br><color=63,136,48>" & PPrice.ToString("P") & "<br><color=63,136,48><size=+8>" & Delta.ToString("F2")
			Else
				labelControl1.Text = Price.ToString("C1") & "<br><color=214,5,5>" & PPrice.ToString("P") & "<br><color=214,5,5><size=+8>" & Delta.ToString("F2")
			End If
		End Sub
	End Class
	Public Class OverviewLabel
		Inherits LabelControl
		Private Shared positiveColor As Color = Color.FromArgb(63, 136, 48)
		Private Shared negativeColor As Color = Color.FromArgb(214, 5, 5)
		Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
			MyBase.OnTextChanged(e)
			labelControlAppearanceObject = Nothing
		End Sub
		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)
			labelControlAppearanceObject = Nothing
		End Sub
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			If IsDesignMode Then
				Return
			End If
			Using gc As New GraphicsCache(e.Graphics)
				gc.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
				Dim ap = GetFitAppearance(gc)
				Dim rect = ClientRectangle
				'rect.Y -=3;
				rect.Height -= Padding.Bottom
				StringPainter.Default.DrawString(gc, ap, Text, rect, ap.TextOptions, Me)
				DrawStateIndicator(e, CInt(Fix(ap.Font.Size)) + 9)
			End Using
		End Sub
		Private Sub DrawStateIndicator(ByVal e As PaintEventArgs, ByVal height As Integer)
			Dim p1 As Point = Point.Empty
			Dim p2 As Point = Point.Empty
			Dim p3 As Point = Point.Empty
			Dim width As Integer = CInt(Fix(2 * height / Math.Sqrt(3)))
			p1.X = ClientRectangle.Left + Padding.Left + width \ 2
			p2.X = ClientRectangle.Left + Padding.Left
			p3.X = ClientRectangle.Left + Padding.Left + width
			Dim y As Integer = ClientRectangle.Bottom - Padding.Bottom
			y -= 5
			Dim stateColor As Color = Color.Empty
			If StateIndex = 0 Then
				p1.Y = y - height
				p3.Y = y
				p2.Y = p3.Y
				stateColor = positiveColor
			Else
				p1.Y = y
				p3.Y = y - height
				p2.Y = p3.Y
				stateColor = negativeColor
			End If
			e.Graphics.FillPolygon(New SolidBrush(stateColor), New Point() { p1, p2, p3 })
		End Sub
		Private privateStateIndex As Integer
		Public Property StateIndex() As Integer
			Get
				Return privateStateIndex
			End Get
			Set(ByVal value As Integer)
				privateStateIndex = value
			End Set
		End Property
		Private info As New StringInfo()
		Private labelControlAppearanceObject As LabelControlAppearanceObject
		Private Function GetFitAppearance(ByVal gc As GraphicsCache) As LabelControlAppearanceObject
			If labelControlAppearanceObject IsNot Nothing Then
				Return labelControlAppearanceObject
			End If
			Dim obj As New LabelControlAppearanceObject()
			obj.Assign(ViewInfo.PaintAppearance)
			obj.Font = New Font(obj.Font.FontFamily, 30)
			info = StringPainter.Default.Calculate(gc.Graphics, obj, obj.TextOptions, Text, New Rectangle(0, 0, 500, 550), gc.Paint, Me)
			Do While info.Bounds.Height > Me.ClientRectangle.Height - Padding.Bottom
				If obj.Font.Size = 1 Then
					Exit Do
				End If
				obj.Font = New Font(obj.Font.FontFamily, obj.Font.Size - 0.5f)
				info = StringPainter.Default.Calculate(gc.Graphics, obj, obj.TextOptions, Text, New Rectangle(0, 0, 500, 550), gc.Paint, Me)
			Loop
			If ClientRectangle.Width < info.Bounds.Width Then
				Width = info.Bounds.Width
			End If
			labelControlAppearanceObject = obj
			Return obj
		End Function
	End Class
End Namespace
