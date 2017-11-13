Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Styles
Imports DevExpress.XtraGauges.Presets.Styles
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraLayout
Imports DevExpress.XtraGauges.Presets.Localization

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class GaugeStylesXPF
        Inherits TutorialControl
        Private radioButton As New List(Of RadioButton)()
        Public Sub New()
            InitializeComponent()
            ApplyLocalization()
            AddHandler Clever.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Classic.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler YellowSubmarine.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Future.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler iStyle.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler MagicLight.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Eco.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Progressive.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Smart.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Cosmic.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Red.CheckedChanged, AddressOf OnThemeRadioButtonCheckedChanged
            AddHandler Circular.Shown, AddressOf ApplySelectStyle
            AddHandler Linear.Shown, AddressOf ApplySelectStyle
            AddHandler Digital.Shown, AddressOf ApplySelectStyle
        End Sub
        Private Sub ApplyLocalization()
            Clever.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeClever)
            Classic.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeClassic)
            Future.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeFuture)
            MagicLight.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeMagicLight)
            iStyle.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeiStyle)
            Eco.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeEco)
            Cosmic.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeCosmic)
            Smart.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeSmart)
            Progressive.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeProgressive)
            YellowSubmarine.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeYellowSubmarine)
            Red.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeRed)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            For Each item As Control In layoutControl1.Controls
                If TypeOf item Is RadioButton Then
                    radioButton.Add(CType(item, RadioButton))
                End If
            Next item
            timer = New Timer()
            timer.Interval = 166
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub
        Private Sub ApplySelectStyle(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As RadioButton In radioButton
                If (CType(item, RadioButton)).Checked Then
                    OnThemeRadioButtonCheckedChanged(CType(item, RadioButton), New EventArgs())
                End If
            Next item
        End Sub
        Private Sub OnThemeRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim radioButton As RadioButton = TryCast(sender, RadioButton)
            Dim key As StyleCollectionKey
            If radioButton.Checked Then
                key = New StyleCollectionKey(tabbedControlGroup2.SelectedTabPage.Name)
                key.Tag = CStr(tabbedControlGroup2.SelectedTabPage.Tag)
                key.Name = radioButton.Text.Replace(" ", "")
                Dim styleCollection As StyleCollection = StyleLoader.Load(key)
                styleCollection.Apply(CircularGauge1)
                If styleCollection Is Nothing Then
                    Return
                End If
                Select Case tabbedControlGroup2.SelectedTabPage.Name
                    Case "Circular"
                        styleCollection.Apply(CircularGauge1)
                    Case "Digital"
                        styleCollection.Apply(digitalGauge1)
                    Case "Linear"
                        styleCollection.Apply(linearGauge1)
                End Select
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
                Dim dGauge As DigitalGauge = TryCast(gb, DigitalGauge)
                If dGauge IsNot Nothing Then
                    dGauge.Text = AnimateStringValue(dGauge)
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
            Dim deviation As Single = (CSng(random.NextDouble()) - (TryCast(scale, IConvertibleScale)).Percent)
            Return scale.Value + (scale.ScaleLength * 0.025F) * deviation
        End Function
        Private Function AnimateStringValue(ByVal dGauge As DigitalGauge) As String
            Dim value As Integer = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond
            Return value.ToString()
        End Function

#End Region
    End Class
End Namespace
