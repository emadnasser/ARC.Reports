Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Core.Model

Namespace DevExpress.XtraGauges.Demos
	Partial Public Class LogarithmicScaleGaugeFeatures
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub UpdateCircularScaleFeaturesPage(ByVal sender As Object, ByVal e As System.EventArgs)
			arcScaleComponent1.BeginUpdate()

			SetupBaseProperty(arcScaleComponent1, rangeTrack, scaleValueTrack)
            SetupLogarithmicProperty(arcScaleComponent1, customLogarithmicBaseCircularScale, logarithmicBaseCircularScale)
            arcScaleComponent1.EndUpdate()
        End Sub
        Protected Sub InitCircularScaleFeaturesPage()
            InitScaleFeaturesPage(arcScaleComponent1, rangeTrack, scaleValueTrack, logarithmicBaseCircularScale, customLogarithmicBaseCircularScale, AddressOf UpdateCircularScaleFeaturesPage)
        End Sub
		Private Sub InitControls()
			InitLinearScaleFeaturesPage()
			InitCircularScaleFeaturesPage()
		End Sub
		Private Sub LinearGaugeFeatures_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitControls()
		End Sub
		Private Sub UpdateLinearScaleFeaturesPage(ByVal sender As Object, ByVal e As System.EventArgs)
			linearScaleComponent1.BeginUpdate()
			SetupBaseProperty(linearScaleComponent1, rangeTrackLinear, valueTrack)
			SetupLogarithmicProperty(linearScaleComponent1, logarithmicBaseLinearScale, autoLogarithmicBaseLinearScale)
			linearScaleComponent1.EndUpdate()
		End Sub
		Protected Sub InitLinearScaleFeaturesPage()
			InitScaleFeaturesPage(linearScaleComponent1, rangeTrackLinear, valueTrack, autoLogarithmicBaseLinearScale, logarithmicBaseLinearScale, AddressOf UpdateLinearScaleFeaturesPage)
		End Sub
		Protected Sub SubscribeChanged(ByVal trackBar As TrackBarControl, ByVal handler As EventHandler)
			AddHandler trackBar.EditValueChanged, handler
		End Sub
		Protected Sub SubscribeChanged(ByVal combo As ComboBoxEdit, ByVal handler As EventHandler)
			AddHandler combo.SelectedIndexChanged, handler
		End Sub
		Protected Sub SubscribeChanged(ByVal text As TextEdit, ByVal handler As EventHandler)
			AddHandler text.EditValueChanged, handler
		End Sub
		Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type)
			Dim names() As String = System.Enum.GetNames(enumType)
			For Each name As String In names
				cbe.Properties.Items.Add(name)
			Next name
		End Sub
        Protected Sub InitScaleFeaturesPage(ByVal scale As IBaseScale, ByVal rangeTrack As RangeTrackBarControl, ByVal valueTrackBar As TrackBarControl, ByVal logarithmicBase As ComboBoxEdit, ByVal customLogarithmicBase As TextEdit, ByVal UpdateScaleFeaturesPage As EventHandler)
            rangeTrack.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(CInt(scale.MinValue), CInt(scale.MaxValue))
            valueTrackBar.Value = CInt(scale.Value)
            SubscribeChanged(rangeTrack, UpdateScaleFeaturesPage)
            SubscribeChanged(valueTrackBar, UpdateScaleFeaturesPage)
            FillCombo(logarithmicBase, GetType(LogarithmicBase))
            logarithmicBase.EditValue = scale.LogarithmicBase.ToString()
            customLogarithmicBase.Text = scale.CustomLogarithmicBase.ToString()
            SubscribeChanged(logarithmicBase, UpdateScaleFeaturesPage)
            SubscribeChanged(customLogarithmicBase, UpdateScaleFeaturesPage)
            UpdateScaleFeaturesPage(Nothing, Nothing)
        End Sub
        Protected Sub SetupLogarithmicProperty(ByVal scale As IBaseScale, ByVal customLogarithmicBaseCore As TextEdit, ByVal logarithmicBaseCore As ComboBoxEdit)
            scale.CustomLogarithmicBase = Single.Parse(customLogarithmicBaseCore.Text)
            If scale.IsLogarithmic Then
                scale.LogarithmicBase = CType(System.Enum.Parse(GetType(LogarithmicBase), CStr(logarithmicBaseCore.EditValue)), LogarithmicBase)
            End If
            If scale.LogarithmicBase <> LogarithmicBase.Custom Then
                customLogarithmicBaseCore.Enabled = False
                customLogarithmicBaseCore.Text = scale.CustomLogarithmicBase.ToString()
            Else
                customLogarithmicBaseCore.Enabled = True
            End If
        End Sub
		Protected Sub SetupBaseProperty(ByVal scale As IBaseScale, ByVal rangeTrack As RangeTrackBarControl, ByVal valueTrackBar As TrackBarControl)
			scale.MinValue = rangeTrack.Value.Minimum
			scale.MaxValue = rangeTrack.Value.Maximum
			scale.Value = scale.MinValue + Math.Abs(scale.ScaleLength * (CSng(valueTrackBar.Value) / CSng(valueTrackBar.Properties.Maximum)))
		End Sub
	End Class
End Namespace
