Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win.Gauges.State

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class WidgetControl
		Inherits UserControl
		Private updateTimer As Timer = New Timer()
		Private Shared positiveColor As Color = Color.FromArgb(70, 158, 165)
		Private Shared negativeColor As Color = Color.FromArgb(165, 70, 113)
		Public Sub New()
			InitializeComponent()
			updateTimer.Interval = 1000
			AddHandler updateTimer.Tick, AddressOf OnTimerTick
			updateTimer.Start()
			OnTimerTick(Me, EventArgs.Empty)
		End Sub
		Public Property CompanyNameText() As String
			Get
				Return labelControl1.Text
			End Get
			Set(ByVal value As String)
				labelControl1.Text = value
			End Set
		End Property
		Private index As Integer = 0
		Private previousData As StockData
		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
			If IsDisposed Then
				updateTimer.Stop()
				Return
			End If
			Dim data As StockData = StockDataCreator.GetData(index)
			If index > 0 Then
				Dim d As Decimal = data.ClosePrice - previousData.ClosePrice
				Dim dq As Decimal = (d * 100) / data.ClosePrice
				labelControl5.Text = Math.Round(d, 2, MidpointRounding.ToEven).ToString().TrimEnd("0"c)
				stateIndicatorComponent1.StateIndex = If(previousData.ClosePrice - data.ClosePrice < 0, 0, 1)
				If stateIndicatorComponent1.StateIndex = 0 Then
					labelControl5.ForeColor = positiveColor
					labelControl2.Text = data.ClosePrice.ToString().TrimEnd("0"c) & "<br><color=70,158,165>" & Math.Round(dq, 2, MidpointRounding.ToEven).ToString().TrimEnd("0"c) & "%"c
				Else
					labelControl5.ForeColor = negativeColor
					labelControl2.Text = data.ClosePrice.ToString().TrimEnd("0"c) & "<br><color=165,70,113>" & Math.Round(dq, 2, MidpointRounding.ToEven).ToString().TrimEnd("0"c) & "%"c
				End If
			End If
			previousData = data
			index += 1
		End Sub
		Private Sub OnCustomDrawElement(ByVal sender As Object, ByVal e As DevExpress.XtraGauges.Core.Primitive.CustomDrawElementEventArgs) Handles stateIndicatorComponent1.CustomDrawElement
			e.Handled = True
			Dim indicator As StateIndicatorComponent = TryCast(sender, StateIndicatorComponent)
			Dim p1 As Point = Point.Empty
			Dim p2 As Point = Point.Empty
			Dim p3 As Point = Point.Empty
			Dim height As Integer = CInt(Fix(e.Info.BoundBox.Width * Math.Sqrt(3) / 2))
			p1.X = CInt(Fix(e.Info.BoundBox.Width / 2))
			p2.X = CInt(Fix(e.Info.BoundBox.Left))
			p3.X = CInt(Fix(e.Info.BoundBox.Right))
			Dim y As Integer = CInt(Fix((e.Info.BoundBox.Height - height) / 2))
			Dim stateColor As Color = Color.Empty
			If indicator.StateIndex = 0 Then
				p1.Y = y
				p3.Y = y +height
				p2.Y = p3.Y
				stateColor = positiveColor
			Else
				p1.Y = y + height
				p3.Y = y
				p2.Y = p3.Y
				stateColor = negativeColor
			End If
			e.Context.Graphics.FillPolygon(New SolidBrush(stateColor), New Point() { p1, p2, p3 })
		End Sub
	End Class
End Namespace
