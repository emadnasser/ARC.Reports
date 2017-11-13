Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class GaugeContent
        Inherits XtraUserControl

        Private stateCore As ObjectState
        Private colorCore As Color
        Public Sub New()
            InitializeComponent()
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            InitGauge()
            stateCore = ObjectState.Normal
            colorCore = Color.Empty
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            RemoveHandler arcScaleComponent1.Animating, AddressOf OnAnimating
            RemoveHandler gaugeControl.MouseEnter, AddressOf GaugeControlMouseEnter
            RemoveHandler gaugeControl.MouseLeave, AddressOf GaugeControlMouseLeave
            RemoveHandler gaugeControl.GotFocus, AddressOf GaugeControlGotFocus
            RemoveHandler gaugeControl.LostFocus, AddressOf GaugeControlLostFocus
            timer.Stop()
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitGauge()
            arcScaleComponent1.EasingFunction = New CubicEase()
            arcScaleComponent1.EasingMode = EasingMode.EaseOut
            arcScaleComponent1.EnableAnimation = True
            AddHandler arcScaleComponent1.Animating, AddressOf OnAnimating
            AddHandler gaugeControl.MouseLeave, AddressOf GaugeControlMouseLeave
            AddHandler gaugeControl.GotFocus, AddressOf GaugeControlGotFocus
            AddHandler gaugeControl.LostFocus, AddressOf GaugeControlLostFocus
            AddHandler gaugeControl.MouseEnter, AddressOf GaugeControlMouseEnter
        End Sub
        Private Sub UpdateState()
            Invalidate()
            Update()
        End Sub
        Private Sub GaugeControlLostFocus(ByVal sender As Object, ByVal e As EventArgs)
            Selected = False
            UpdateState()
        End Sub
        Public ReadOnly Property Gauge() As GaugeControl
            Get
                Return gaugeControl
            End Get
        End Property
        Public Property Caption() As String
            Get
                Return labelControl1.Text
            End Get
            Set(ByVal value As String)
                labelControl1.Text = value
            End Set
        End Property

        Public Property Color() As Color
            Get
                Return gaugeControl.ColorScheme.Color
            End Get
            Set(ByVal value As Color)
                If (Not colorCore.IsEmpty) AndAlso Not colorCore.Equals(gaugeControl.ColorScheme.Color) Then
                    Return
                End If
                colorCore = value
                gaugeControl.ColorScheme.Color = colorCore
            End Set
        End Property
        Public Property Image() As Image
            Get
                Return imageIndicatorComponent.Image
            End Get
            Set(ByVal value As Image)
                imageIndicatorComponent.Image = value
            End Set
        End Property
        Private Sub GaugeControlGotFocus(ByVal sender As Object, ByVal e As EventArgs)
            Selected = True
            UpdateState()
        End Sub
        Private Sub GaugeControlMouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            Hot = True
            UpdateState()
        End Sub
        Private Sub GaugeControlMouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Hot = False
            UpdateState()
        End Sub
        Public Overridable Property Hot() As Boolean
            Get
                Return GetState(ObjectState.Hot)
            End Get
            Set(ByVal value As Boolean)
                SetState(ObjectState.Hot, value)
            End Set
        End Property
        Public Overridable Property Selected() As Boolean
            Get
                Return GetState(ObjectState.Selected)
            End Get
            Set(ByVal value As Boolean)
                SetState(ObjectState.Selected, value)
                Dim gaugesDashboard As GaugesDashboard = GetParent(Me.Parent)
                If Selected AndAlso gaugesDashboard IsNot Nothing Then
                    gaugesDashboard.UpdateColor(Color)
                End If
            End Set
        End Property
        Private Function GetParent(ByVal parent As Control) As GaugesDashboard
            If parent Is Nothing Then
                Return Nothing
            End If
            If TypeOf parent Is GaugesDashboard Then
                Return TryCast(parent, GaugesDashboard)
            End If
            Return GetParent(parent.Parent)
        End Function
        Private Sub SetState(ByVal state As ObjectState, ByVal value As Boolean)
            If value Then
                stateCore = stateCore Or state
            Else
                stateCore = stateCore And Not state
            End If
        End Sub
        Private Function GetState(ByVal state As ObjectState) As Boolean
            Return (stateCore And state) <> 0
        End Function
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            DrawBackground(e)
        End Sub
        Private Sub DrawBackground(ByVal e As PaintEventArgs)
            Dim rect As Rectangle = ClientRectangle
            rect.Height -= Padding.Vertical
            rect.X += Padding.Left
            rect.Y += Padding.Top - 10
            rect.Width -= Padding.Horizontal
            Dim skin As Skin = CommonSkins.GetSkin(LookAndFeel)
            Dim elementInfo As New SkinElementInfo(skin(CommonSkins.SkinLayoutItemBackground), rect)
            If Selected Then
                elementInfo.ImageIndex = 2
            End If
            If Hot Then
                elementInfo.ImageIndex = 1
            End If
            Using cache As New GraphicsCache(e.Graphics)
                ObjectPainter.DrawObject(cache, SkinElementPainter.Default, elementInfo)
            End Using
        End Sub
#Region "Animation"
        Private Sub OnAnimating(ByVal sender As Object, ByVal e As EventArgs)
            Dim ea As ValueChangedEventArgs = TryCast(e, ValueChangedEventArgs)
            If ea IsNot Nothing Then
                labelComponent1.Text = ea.Value.ToString("F0")
            End If
        End Sub
        Private animationLockCounterCore As Integer = 0
        Private timer As Timer
        Private random As New Random(Date.Now.Millisecond)

        Private ReadOnly Property IsAnimationLocked() As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            timer = New Timer()
            timer.Interval = (New Random()).Next(2000, 2400)
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub
        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If Not timer.Enabled Then
                Return
            End If
            If IsAnimationLocked Then
                Return
            End If
            LockAnimation()
            DoAnimation(gaugeControl)
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
            Next gb
        End Sub
        Private r As New Random(Date.Now.Millisecond)
        Private Function AnimateScaleValue(ByVal scale As IScale) As Single
            Return r.Next(0, 100)
        End Function
#End Region
    End Class
End Namespace
