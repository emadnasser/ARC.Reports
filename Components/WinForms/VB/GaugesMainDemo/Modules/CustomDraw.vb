Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Primitive
Imports DevExpress.XtraGauges.Core.Base
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos
	Partial Public Class CustomDrawFeature
		Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            ceAllowCustomDraw.Checked = True
            '
            AddHandler arcScale.CustomDrawElement, AddressOf Scale_CustomDrawElement
            AddHandler linearScale.CustomDrawElement, AddressOf Scale_CustomDrawElement
            AddHandler arcScaleNeedle.CustomDrawElement, AddressOf arcScaleNeedle_CustomDrawElement
            AddHandler arcScaleBackgroundLayer.CustomDrawElement, AddressOf arcScaleBackgroundLayer_CustomDrawElement
            AddHandler linearScaleLevel.CustomDrawElement, AddressOf linearScaleLevel_CustomDrawElement
            AddHandler linearScaleBackgroundLayer.CustomDrawElement, AddressOf linearScaleBackgroundLayer_CustomDrawElement
        End Sub

        Property IsDisposing As Boolean

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            IsDisposing = True
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
                timer.Stop()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private handleCustomDraw As Boolean = False
		Private Sub ceAllowCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowCustomDraw.CheckedChanged
			handleCustomDraw = ceAllowCustomDraw.Checked
			arcScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage)
			linearScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage)
		End Sub
		#Region "CustomDraw"
		Private Sub Scale_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
			If (Not handleCustomDraw) Then
				Return
			End If
			e.Handled = True
		End Sub
		Private pen As New Pen(Color.Black, 2f)
		Private Sub linearScaleLevel_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
			If (Not handleCustomDraw) Then
				Return
			End If
			For i As Integer = 0 To 4
				e.Context.Graphics.DrawLine(Pens.DarkGray, 60, 75 + i * 25, 190, 75 + i * 25)
			Next i
			Dim pos As Single = 75 + CSng(Math.Round(linearScale.Percent * 8f)) * 12.5f
			e.Context.Graphics.FillEllipse(Brushes.Black, 102, pos - 8, 19, 16)
			e.Context.Graphics.DrawLine(pen, 120, pos - 45, 120, pos)
			e.Context.Graphics.FillEllipse(Brushes.Black, 127, pos - 20.5f, 19, 16)
			e.Context.Graphics.DrawLine(pen, 145, pos - 45, 145, pos-12.5f)
			e.Context.Graphics.DrawLine(pen, 120, pos - 44, 145, pos - 44)
			e.Context.Graphics.DrawLine(pen, 120, pos - 36, 145, pos - 36)
			e.Handled = True
		End Sub
		Private Sub linearScaleBackgroundLayer_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
			If (Not handleCustomDraw) Then
				Return
			End If
			e.Handled = True
		End Sub
		Private Sub arcScaleBackgroundLayer_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
			If (Not handleCustomDraw) Then
				Return
			End If
			Dim bounds As RectangleF = RectangleF.Inflate(e.Info.BoundBox, -15, -15)
			e.Context.Graphics.FillEllipse(Brushes.Black, bounds)
			bounds.Inflate(-2, -2)
			e.Context.Graphics.SetClip(New RectangleF(bounds.Left + bounds.Width * 0.5f, bounds.Top, bounds.Width * 0.5f, bounds.Height))
			e.Context.Graphics.FillEllipse(Brushes.White, bounds)
			e.Context.Graphics.ResetClip()
			e.Context.Graphics.FillEllipse(Brushes.White, New RectangleF(bounds.Left + bounds.Width * 0.25f, bounds.Top, bounds.Width * 0.5f, bounds.Height * 0.5f))
			e.Context.Graphics.FillEllipse(Brushes.Black, New RectangleF(bounds.Left + bounds.Width * 0.25f, bounds.Top + bounds.Height * 0.5f, bounds.Width * 0.5f, bounds.Height * 0.5f))
			e.Handled = True
		End Sub
		Private Sub arcScaleNeedle_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
			If (Not handleCustomDraw) Then
				Return
			End If
			e.Context.Graphics.FillEllipse(Brushes.White, New RectangleF(50, 112.5f, 25, 25))
			e.Context.Graphics.FillEllipse(Brushes.Black, New RectangleF(175, 112.5f, 25, 25))
			e.Handled = True
		End Sub
		#End Region ' CustomDraw
		#Region "Animation"
        Private animationLockCounterCore As Integer = 0
		Private timer As Timer
        Private random As New Random(DateTime.Now.Millisecond)
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            timer = New Timer()
            timer.Interval = 350
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub
        Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If animationLockCounterCore > 0 OrElse (Not Visible) OrElse IsDisposed OrElse IsDisposed Then
                Return
            End If
            If arcScale.IsDisposing OrElse linearScale.IsDisposing Then
                Return
            End If
            animationLockCounterCore += 1
            arcScale.Value = AnimateScaleValue(arcScale, 0.05F)
            linearScale.Value = AnimateScaleValue(linearScale, 0.75F)
            animationLockCounterCore -= 1
        End Sub
        Function AnimateScaleValue(ByVal scale As IBaseScale, ByVal factor As Single) As Single
            Dim deviation As Single = (CSng(random.NextDouble()) - scale.Percent)
            Return scale.Value + (scale.ScaleLength * factor) * deviation
        End Function
		#End Region ' Animation
	End Class
End Namespace
