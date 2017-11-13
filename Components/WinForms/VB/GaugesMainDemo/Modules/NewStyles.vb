Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraTab
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraGauges.Base

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class GaugesNewStyles
        Inherits TutorialControl

        Private animationLockCounterCore As Integer = 0
        Private timer As Timer
        Private Rnd As New Random(DateTime.Now.Millisecond)

        ReadOnly Property IsAnimationLocked() As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler Load, AddressOf OnFormLoad
        End Sub
        Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            timer = New Timer()
            timer.Interval = 166
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub
        Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsAnimationLocked Then
                Return
            End If
            Dim activePage As XtraTabPage = xtraTabControl1.SelectedTabPage
            If (Not xtraTabControl1.Visible) OrElse activePage Is Nothing Then
                Return
            End If
            LockAnimation()
            Dim gauges As List(Of GaugeControl) = CollectChildGauges(activePage)
            For Each gauge As GaugeControl In gauges
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
        Sub DoAnimation(ByVal gauge As GaugeControl)
            For Each gb As IGauge In gauge.Gauges
                Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
                If cGauge IsNot Nothing Then
                    For Each scale As IScale In cGauge.Scales
                        scale.Value = AnimateScaleValue(scale)
                    Next scale
                End If
                Dim lGauge As ILinearGauge = TryCast(gb, ILinearGauge)
                If lGauge IsNot Nothing Then
                    For Each scale As IScale In lGauge.Scales
                        scale.Value = AnimateScaleValue(scale)
                    Next scale
                End If
                Dim dGauge As DigitalGauge = TryCast(gb, DigitalGauge)
                If dGauge IsNot Nothing Then
                    dGauge.Text = AnimateStringValue(dGauge)
                End If
            Next gb
        End Sub
        Function CollectChildGauges(ByVal parentControl As Control) As List(Of GaugeControl)
            Dim result As List(Of GaugeControl) = New List(Of GaugeControl)()
            For Each control As Control In parentControl.Controls
                If TypeOf control Is GaugeControl Then
                    result.Add(TryCast(control, GaugeControl))
                ElseIf control.Controls.Count > 0 Then
                    result.AddRange(CollectChildGauges(control))
                End If
            Next control
            Return result
        End Function
        Function AnimateScaleValue(ByVal scale As IScale) As Single
            Dim deviation As Single = (CSng(Rnd.NextDouble()) - (TryCast(scale, IConvertibleScale)).Percent)
            Return scale.Value + (scale.ScaleLength * 0.025F) * deviation
        End Function
        Function AnimateStringValue(ByVal dGauge As DigitalGauge) As String
            Dim value As Integer = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond
            Return value.ToString()
        End Function
    End Class
End Namespace
