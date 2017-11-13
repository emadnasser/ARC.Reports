
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class AnimationScale
        Inherits TutorialControl
        Private functions As New Dictionary(Of String, IEasingFunction)()
        Private modes As New Dictionary(Of String, EasingMode)()
        Public Sub New()
            InitializeComponent()
            InitData()
            AddHandler BackEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler ElasticEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler BounceEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler PowerEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler CubicEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler QuadraticEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler QuinticEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler SineEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler ExponentialEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler CircleEase.CheckedChanged, AddressOf ChangeEaseFunction
            AddHandler EaseFuction.SelectedIndexChanged, AddressOf ChangeEaseMode
        End Sub

        Private Sub InitData()
            functions.Add("BackEase", New BackEase())
            functions.Add("ElasticEase", New ElasticEase())
            functions.Add("PowerEase", New PowerEase(1))
            functions.Add("QuadraticEase", New QuadraticEase())
            functions.Add("QuinticEase", New QuinticEase())
            functions.Add("SineEase", New SineEase())
            functions.Add("ExponentialEase", New ExponentialEase())
            functions.Add("CircleEase", New CircleEase())
            functions.Add("BounceEase", New BounceEase())
            functions.Add("CubicEase", New CubicEase())
            modes.Add("EaseIn", EasingMode.EaseIn)
            modes.Add("EaseOut", EasingMode.EaseOut)
            modes.Add("EaseInOut", EasingMode.EaseInOut)
            For Each item As KeyValuePair(Of String, EasingMode) In modes
                EaseFuction.Properties.Items.Add(item.Key)
            Next item
            arcScaleComponent1.EnableAnimation = True
            linearScaleComponent1.EnableAnimation = True
            EaseFuction.SelectedIndex = 0
        End Sub
        Private Sub ChangeEaseMode(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleComponent1.EasingMode = modes(EaseFuction.SelectedItem.ToString())
            linearScaleComponent1.EasingMode = modes(EaseFuction.SelectedItem.ToString())
        End Sub
        Private Sub ChangeEaseFunction(ByVal sender As Object, ByVal e As EventArgs)
            Dim radioButton As RadioButton = TryCast(sender, RadioButton)
            If radioButton.Checked Then
                arcScaleComponent1.EasingFunction = functions((CType(sender, RadioButton)).Name)
                linearScaleComponent1.EasingFunction = functions((CType(sender, RadioButton)).Name)
            End If
        End Sub
#Region "Animation"
        Private animationLockCounterCore As Integer = 0
        Private timer As Timer
        Private random As New Random(DateTime.Now.Millisecond)

        Private ReadOnly Property IsAnimationLocked() As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            timer = New Timer()
            timer.Interval = 2000
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub
        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsAnimationLocked Then
                Return
            End If
            Dim activePage As LayoutGroup = tabbedControlGroup2.SelectedTabPage
            If (Not tabbedControlGroup2.Visible) OrElse activePage Is Nothing Then
                Return
            End If
            LockAnimation()
            Dim gauges As List(Of GaugeControl) = CollectChildGauges()
            For Each gauge As GaugeControl In gauges
                DoAnimation(gauge)
            Next gauge
            UnlockAnimation()
        End Sub
        Private Sub UnlockAnimation()
            animationLockCounterCore -= 1
        End Sub
        Private Sub LockAnimation()
            animationLockCounterCore += 1
        End Sub
        Private Sub DoAnimation(ByVal gauge As GaugeControl)
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
            Next gb
        End Sub
        Private Function CollectChildGauges() As List(Of GaugeControl)
            Dim result As New List(Of GaugeControl)()
            For Each item As Control In layoutControl1.Controls
                If TypeOf item Is GaugeControl Then
                    result.Add(CType(item, GaugeControl))
                End If
            Next item
            Return result
        End Function
        Private Function AnimateScaleValue(ByVal scale As IScale) As Single
            Dim r As New Random()
            Return r.Next(0, 100)
        End Function
        Private Function AnimateStringValue(ByVal dGauge As DigitalGauge) As String
            Dim value As Integer = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond
            Return value.ToString()
        End Function
#End Region
    End Class
End Namespace
