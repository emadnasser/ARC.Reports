Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Base
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Core
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGauges.Demos
	Partial Public Class StyleManagerFeature
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			containers = New IGaugeContainer() { gControl1, gControl2, gControl3, gControl4 }
            layoutControl1.AllowCustomization = False
            AddHandler tabGroup.SelectedPageChanged, AddressOf tabGroup_SelectedPageChanged
		End Sub
		Private Sub tabGroup_SelectedPageChanged(ByVal sender As Object, ByVal e As LayoutTabPageChangedEventArgs)
			btnStyleChooser.Enabled = tabGroup.TabPages.IndexOf(e.Page) <> 3
		End Sub
		Private animationLockCounterCore As Integer = 0
		Private timer As Timer
		Private random As New Random(DateTime.Now.Millisecond)
		Private ReadOnly Property IsAnimationLocked() As Boolean
			Get
				Return animationLockCounterCore > 0
			End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            timer = New Timer()
            timer.Interval = 166
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub
        Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsAnimationLocked OrElse (Not Visible) Then
                Return
            End If
            LockAnimation()
            Dim gControls As IEnumerable(Of IGaugeContainer) = CollectChildGauges(layoutControl1)
            For Each gauge As IGaugeContainer In gControls
                DoAnimation(gauge)
            Next gauge
            UnlockAnimation()
        End Sub
        Sub UnlockAnimation()
            animationLockCounterCore -= 1
        End Sub
        Sub LockAnimation()
            animationLockCounterCore += 1
        End Sub
        Sub DoAnimation(ByVal gauge As IGaugeContainer)
            For Each gb As IGauge In gauge.Gauges
                Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
                If cGauge IsNot Nothing Then
                    For Each scale As IBaseScale In cGauge.Scales
                        scale.Value = AnimateScaleValue(scale)
                    Next scale
                End If
                Dim lGauge As ILinearGauge = TryCast(gb, ILinearGauge)
                If lGauge IsNot Nothing Then
                    For Each scale As IBaseScale In lGauge.Scales
                        scale.Value = AnimateScaleValue(scale)
                    Next scale
                End If
                Dim dGauge As IDigitalGauge = TryCast(gb, IDigitalGauge)
                If dGauge IsNot Nothing Then
                    dGauge.Text = AnimateStringValue(dGauge)
                End If
            Next gb
        End Sub
        Function AnimateScaleValue(ByVal scale As IBaseScale) As Single
            Dim deviation As Single = (CSng(random.NextDouble()) - scale.Percent)
            Return scale.Value + (scale.ScaleLength * 0.05F) * deviation
        End Function
        Function AnimateStringValue(ByVal gauge As IDigitalGauge) As String
            Return Convert.ToString(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond)
        End Function
        Function CollectChildGauges(ByVal parentControl As Control) As IEnumerable(Of IGaugeContainer)
            Dim result As List(Of IGaugeContainer) = New List(Of IGaugeContainer)()
            For Each control As Control In parentControl.Controls
                If TypeOf control Is IGaugeContainer Then
                    result.Add(TryCast(control, IGaugeContainer))
                ElseIf control.Controls.Count > 0 Then
                    result.AddRange(CollectChildGauges(control))
                End If
            Next control
            Return result
        End Function
		Private containers() As IGaugeContainer
        Sub ShowStyleManagerClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnStyleManager.Click
            LockAnimation()
            StyleManager.Show(containers(tabGroup.SelectedTabPageIndex))
            UnlockAnimation()
        End Sub
        Sub ShowStyleChooserClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnStyleChooser.Click
            LockAnimation()
            StyleChooser.Show(containers(tabGroup.SelectedTabPageIndex).Gauges(0))
            UnlockAnimation()
        End Sub
	End Class
End Namespace
