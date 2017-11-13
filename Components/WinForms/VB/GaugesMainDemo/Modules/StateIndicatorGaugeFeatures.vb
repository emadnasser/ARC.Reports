Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Circular

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class StateIndicatorGaugeFeatures
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        #Region "StateIndicator Gauge"
        Private Sub StateIndicatorGaugeFeatures_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            smilesState.Value = stateIndicatorComponent3.StateIndex
            arrowsState.Value = stateIndicatorComponent2.StateIndex
            elLightsState.Value = stateIndicatorComponent1.StateIndex
            trafficLightState.Value = stateIndicatorComponent4.StateIndex

            AddHandler trafficLightState.EditValueChanged, AddressOf OnTrafficLightStateChanged
            AddHandler elLightsState.EditValueChanged, AddressOf OnElLightStateChanged
            AddHandler arrowsState.EditValueChanged, AddressOf OnArrowStateChanged
            AddHandler smilesState.EditValueChanged, AddressOf OnSmileStateChanged
            AddHandler currencyState.EditValueChanged, AddressOf OnCurrencyStateChanged
            AddHandler flagsState.EditValueChanged, AddressOf OnFlagStateChanged
        End Sub
        Private Sub OnFlagStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            stateIndicatorComponent6.StateIndex = flagsState.Value
        End Sub
        Private Sub OnCurrencyStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            stateIndicatorComponent5.StateIndex = currencyState.Value
        End Sub
        Private Sub OnTrafficLightStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            stateIndicatorComponent4.StateIndex = trafficLightState.Value
        End Sub
        Private Sub OnSmileStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            stateIndicatorComponent3.StateIndex = smilesState.Value
        End Sub
        Private Sub OnArrowStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            stateIndicatorComponent2.StateIndex = arrowsState.Value
        End Sub
        Private Sub OnElLightStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            stateIndicatorComponent1.StateIndex = elLightsState.Value
        End Sub
        #End Region
    End Class
End Namespace
