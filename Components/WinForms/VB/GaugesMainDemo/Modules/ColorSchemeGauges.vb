Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Win

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class ColorSchemeGauges
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            gaugesDashboard1.ColorPicker = colorPickControl
        End Sub
        Private Sub ColorPickControlResultColorChanged(ByVal sender As Object, ByVal e As XtraEditors.InnerColorPickControlSelectedColorChangedEventArgs) Handles colorPickControl.ResultColorChanged
            Dim activeGauge As GaugeControl = GetActiveGauge()
            If activeGauge IsNot Nothing Then
                activeGauge.ColorScheme.Color = e.NewColor
                gaugesDashboard1.UpdateColor(e.NewColor)
            End If
        End Sub
        Private Function GetActiveGauge() As GaugeControl
            If TypeOf ActiveControl Is GaugesDashboard Then
                Return (TryCast(ActiveControl, GaugesDashboard)).ActiveGauge
            End If
            Return Nothing
        End Function
    End Class
End Namespace
