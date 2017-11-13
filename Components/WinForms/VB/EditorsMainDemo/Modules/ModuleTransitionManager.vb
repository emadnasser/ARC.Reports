Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
' <cbTransitionType>
Imports DevExpress.Utils.Animation
' </cbTransitionType>
Imports System.Reflection
' <cbEasingMode>
Imports DevExpress.Data.Utils
' </cbEasingMode>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTransitionManager
		Inherits TutorialControl
		' <cbEasingFunction>
		Private EasingFunction() As String = { "BackEase", "ElasticEase", "PowerEase", "QuadraticEase", "SineEase", "ExponentialEase", "CircleEase", "BounceEase", "CubicEase" }
		' </cbEasingFunction>
		Private delay As Timer
		Private isLock As Boolean
		Private functions As New Dictionary(Of String, IEasingFunction)()
		Public Sub New()
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleTransitionManager.cs"
            TutorialInfo.WhatsThisXMLFile = "transitionManager.xml"
			Init()
			InitTransitionParameters()
			InitEasyFunctions()
		End Sub
        Private Sub Init()
            ' <cbEasingMode>
            cbEasingMode.Properties.Items.AddEnum(GetType(DevExpress.Data.Utils.EasingMode))
            cbEasingMode.SelectedIndex = 0
            ' </cbEasingMode>
            ' <cbShowWaitIndicator>
            cbShowWaitIndicator.Properties.Items.AddEnum(GetType(DevExpress.Utils.DefaultBoolean))
            cbShowWaitIndicator.SelectedIndex = 2
            ' </cbShowWaitIndicator>
            ' <cbTransitionType>
            cbTransitionType.Properties.Items.AddEnum(GetType(Transitions))
            cbTransitionType.SelectedIndex = 0
            ' </cbTransitionType>
            ' <cbEasingFunction>
            cbEasingFunction.Properties.Items.AddRange(EasingFunction)
            cbEasingFunction.SelectedIndex = 0
            ' </cbEasingFunction>
            delay = New Timer()
            delay.Interval = 1000
            AddHandler delay.Tick, AddressOf delay_Tick
            pictureEdit.Image = New Bitmap(pictureEdit.Width, pictureEdit.Height)
            AddHandler pictureEdit.ImageChanged, AddressOf pictureEdit_ImageChanged
            AddHandler transitionManager.CustomTransition, AddressOf transitionManager_CustomTransition
        End Sub
        ' <cbEasingFunction>
		Private Sub InitEasyFunctions()
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
		End Sub
        ' </cbEasingFunction>
		Private Sub InitTransitionParameters()
			isLock = True
			' <checkVertical>
			checkVertical.Enabled = EnableParametrs("Vertical")
			' </checkVertical>
			' <checkInward>
			checkInward.Enabled = EnableParametrs("Inward")
			' </checkInward>
			' <checkUnCover>            
			checkUnCover.Enabled = EnableParametrs("UnCover")
			' </checkUnCover>       
			' <seStripeCount>
			seStripeCount.Enabled = EnableParametrs("StripeCount")
			' </seStripeCount>
			' <ceBackground>
			ceBackground.Enabled = EnableParametrs("Background")
			' </ceBackground>
			' <cbEffectOptions>
			cbEffectOptions.Enabled = EnableParametrs("EffectOptions")
			' </cbEffectOptions>
			ResetTransitionParameters()
			isLock = False
		End Sub
		Private Sub ResetTransitionParameters()
			' <checkUnCover>            
			' <checkInward>
			' <checkVertical>
			checkUnCover.Checked = False
			checkInward.Checked = checkUnCover.Checked
			checkVertical.Checked = checkInward.Checked
			' </checkUnCover>            
			' </checkInward>
			' </checkVertical>
			' <seFrameInterval>
			' <seFrameCount>
			' <seStripeCount>
			seFrameInterval.Value = 0
			seFrameCount.Value = seFrameInterval.Value
			seStripeCount.Value = seFrameCount.Value
			' </seFrameInterval>
			' </seFrameCount>
			' </seStripeCount>
			' <ceBackground>
			ceBackground.Color = Color.Empty
			' </ceBackground>
			' <cbEffectOptions>
			cbEffectOptions.Properties.Items.Clear()
			Dim info As PropertyInfo = CType(AnimationParameters, Object).GetType().GetProperty("EffectOptions")
			If info IsNot Nothing Then
				cbEffectOptions.Properties.Items.AddEnum(info.PropertyType)
                cbEffectOptions.SelectedIndex = 0
			End If
			' </cbEffectOptions>
		End Sub
		Private ReadOnly Property AnimationParameters() As IAnimationParameters
			Get
				If Transition Is Nothing Then
					Return Nothing
				End If
				Return Transition.TransitionType.Parameters
			End Get
		End Property
		Private ReadOnly Property Transition() As ITransition
			Get
				Return transitionManager.Transitions(pictureEdit)
			End Get
		End Property
		' <cbEasingFunction>
		Private Sub transitionManager_CustomTransition(ByVal transition As ITransition, ByVal e As CustomTransitionEventArgs)
			If transition.Control Is pictureEdit Then
				e.EasingFunction = functions(cbEasingFunction.Text)
			End If
		End Sub
		' </cbEasingFunction>
		Private Sub delay_Tick(ByVal sender As Object, ByVal e As EventArgs)
			pictureEdit.Image = galleryControl.Gallery.GetCheckedItem().Image
			delay.Stop()
		End Sub
		Private Sub pictureEdit_ImageChanged(ByVal sender As Object, ByVal e As EventArgs)
			transitionManager.EndTransition()
		End Sub
		Private Sub galleryControlGallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.Ribbon.GalleryItemEventArgs) Handles galleryControl.Gallery.ItemCheckedChanged
			If Not e.Item.Checked Then
				Return
			End If
            transitionManager.StartTransition(pictureEdit)
            delay.Stop()
            If Transition.ShowWaitingIndicator <> Utils.DefaultBoolean.False Then
                delay.Interval = 1000
            Else
                delay.Interval = 1
            End If
            delay.Start()
        End Sub
		' <checkUnCover>
		' <seFrameInterval>
		' <seFrameCount>
		' <cbEffectOptions>
		' <checkInward>
		' <checkVertical>
		' <seStripeCount>
		' <ceBackground>
		Private Function EnableParametrs(ByVal propertyName As String) As Boolean
			Dim info As PropertyInfo = CType(AnimationParameters, Object).GetType().GetProperty(propertyName)
			Return info IsNot Nothing
		End Function
		' </ceBackground>
		' </seStripeCount>
		' </checkVertical>
		' </checkInward>
		' </cbEffectOptions>
		' </seFrameCount>
		' </seFrameInterval>
		' </checkUnCover>
		' <cbShowWaitIndicator>
		Private Sub cbShowWaitIndicator_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbShowWaitIndicator.SelectedIndexChanged
			' <skip>
			If isLock Then
				Return
			End If
			' </skip>
			Transition.ShowWaitingIndicator = CType(cbShowWaitIndicator.SelectedIndex, DevExpress.Utils.DefaultBoolean)
		End Sub
		' </cbShowWaitIndicator>
		' <cbEasingMode>
		Private Sub cbEasingMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEasingMode.SelectedIndexChanged
			' <skip>
			If isLock Then
				Return
			End If
			' </skip>
			Transition.EasingMode = CType(cbEasingMode.SelectedIndex, DevExpress.Data.Utils.EasingMode)
		End Sub
		' </cbEasingMode>
		' <cbTransitionType>
		Private Sub cbTransitionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTransitionType.SelectedIndexChanged
			' <skip>
			If isLock Then
				Return
			End If
			' </skip>
			Transition.TransitionType = CreateInstance(CType(cbTransitionType.SelectedIndex, Transitions))
			InitTransitionParameters()
		End Sub
		' </cbTransitionType>
		' <seFrameInterval>
		Private Sub seFrameInterval_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seFrameInterval.ValueChanged
			TransitionParameterChange("FrameInterval", CType(seFrameInterval.Value, Integer?))
		End Sub
		' </seFrameInterval>
		' <seFrameCount>
		Private Sub seFrameCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seFrameCount.ValueChanged
			TransitionParameterChange("FrameCount", CType(seFrameCount.Value, Integer?))
		End Sub
		' </seFrameCount>
		' <cbEffectOptions>
		Private Sub cbEffectOptions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEffectOptions.SelectedIndexChanged
			TransitionParameterChange("EffectOptions", cbEffectOptions.SelectedIndex)
		End Sub
		' </cbEffectOptions>
		' <ceBackground>
		Private Sub ceBackground_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceBackground.EditValueChanged
			TransitionParameterChange("Background", ceBackground.Color)
		End Sub
		' </ceBackground>
		' <seStripeCount>
		Private Sub seStripeCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seStripeCount.ValueChanged
			TransitionParameterChange("StripeCount", CInt(Fix(seStripeCount.Value)))
		End Sub
		' </seStripeCount>
		' <checkVertical>
		Private Sub checkVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkVertical.CheckedChanged
			TransitionParameterChange("Vertical", checkVertical.Checked)
		End Sub
		' </checkVertical>
		' <checkInward>
		Private Sub checkInward_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkInward.CheckedChanged
			TransitionParameterChange("Inward", checkInward.Checked)
		End Sub
		' </checkInward>
		' <checkUnCover>
		Private Sub checkUnCover_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkUnCover.CheckedChanged
			TransitionParameterChange("UnCover", checkUnCover.Checked)
		End Sub
		' <seFrameInterval>
		' <seFrameCount>
		' <cbEffectOptions>
		' <checkInward>
		' <checkVertical>
		' <seStripeCount>
		' <ceBackground>
		Private Sub TransitionParameterChange(ByVal paramName As String, ByVal value As Object)
			SetTransitionParameter(AnimationParameters, paramName, value)
		End Sub
		Private Sub SetTransitionParameter(ByVal parameters As IAnimationParameters, ByVal propertyName As String, ByVal value As Object)
			' <skip>
			If isLock OrElse parameters Is Nothing Then
				Return
			End If
			' </skip>
			Dim info As PropertyInfo = CType(parameters, Object).GetType().GetProperty(propertyName)
			If info Is Nothing Then
				Return
			End If
			info.SetValue(parameters, value, Nothing)
		End Sub
		' </ceBackground>
		' </seStripeCount>
		' </checkVertical>
		' </checkInward>
		' </cbEffectOptions>
		' </seFrameCount>
		' </seFrameInterval>
		' </checkUnCover>
		Private Function CreateInstance(ByVal transition As Transitions) As BaseTransition
			Select Case transition
				Case Transitions.Dissolve
					Return New DissolveTransition()
				Case Transitions.Fade
					Return New FadeTransition()
				Case Transitions.Shape
					Return New ShapeTransition()
				Case Transitions.Clock
					Return New ClockTransition()
				Case Transitions.SlideFade
					Return New SlideFadeTransition()
				Case Transitions.Cover
					Return New CoverTransition()
				Case Transitions.Comb
					Return New CombTransition()
				Case Else
					Return New PushTransition()
			End Select
		End Function
	End Class
End Namespace
