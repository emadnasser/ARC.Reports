Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraEditors.Demos
    Partial Public Class ModuleProgressPanel
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleProgressPanel.vb"
            TutorialInfo.WhatsThisXMLFile = "progressPanel.xml"
        End Sub
        ' <comboBoxAnimationType>
        Private Sub comboBoxAnimationType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAnimationType.SelectedIndexChanged
            Select Case CStr(comboBoxAnimationType.SelectedItem)
                Case ("Default")
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Default
                Case ("Line")
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line
                Case ("Ring")
                    progressPanelSample.WaitAnimationType = WaitingAnimatorType.Ring
            End Select
            ' <skip>
            spinElementCount.Enabled = (progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default)
            spinAcceleration.Enabled = (progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default)
            spinSpeed.Enabled = (progressPanelSample.WaitAnimationType <> WaitingAnimatorType.Default)
            spinLineHeight.Enabled = (progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line)
            comboBoxLineElementType.Enabled = (progressPanelSample.WaitAnimationType = WaitingAnimatorType.Line)
            spinRingDiameter.Enabled = (progressPanelSample.WaitAnimationType = WaitingAnimatorType.Ring)
            ' </skip>
        End Sub
        ' </comboBoxAnimationType>

        ' <spinElementCount>
        Private Sub spinElementCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinElementCount.EditValueChanged
            progressPanelSample.AnimationElementCount = CInt((spinElementCount.Value))
        End Sub
        ' </spinElementCount>

        ' <spinAcceleration>
        Private Sub spinAcceleration_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinAcceleration.EditValueChanged
            progressPanelSample.AnimationAcceleration = CSng(spinAcceleration.Value)
        End Sub
        ' </spinAcceleration>

        ' <spinSpeed>
        Private Sub spinSpeed_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinSpeed.EditValueChanged
            progressPanelSample.AnimationSpeed = CSng(spinSpeed.Value)
        End Sub
        ' </spinSpeed>

        ' <spinLineHeight>
        Private Sub spinLineHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinLineHeight.EditValueChanged
            progressPanelSample.LineAnimationElementHeight = CInt((spinLineHeight.Value))
        End Sub
        ' </spinLineHeight>

        ' <comboBoxLineElementType>
        Private Sub comboBoxLineElementType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxLineElementType.SelectedIndexChanged
            Select Case CStr(comboBoxLineElementType.SelectedItem)
                Case ("Circle")
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Circle
                Case ("Rectangle")
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Rectangle
                Case ("Triangle")
                    progressPanelSample.LineAnimationElementType = LineAnimationElementType.Triangle
            End Select
        End Sub
        ' </comboBoxLineElementType>

        ' <spinRingDiameter>
        Private Sub spinRingDiameter_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinRingDiameter.EditValueChanged
            progressPanelSample.RingAnimationDiameter = CInt((spinRingDiameter.Value))
        End Sub
        ' </spinRingDiameter>

        ' <colorEditElementColor>
        Private Sub colorEditElementColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorEditElementColor.EditValueChanged
            progressPanelSample.Appearance.ForeColor = colorEditElementColor.Color
        End Sub
        ' </colorEditElementColor>

        ' <spinFrameCount>
        Private Sub spinFrameCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinFrameCount.EditValueChanged
            progressPanelSample.FrameCount = CInt((spinFrameCount.Value))
        End Sub
        ' </spinFrameCount>

        ' <spinFrameInterval>
        Private Sub spinFrameInterval_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinFrameInterval.EditValueChanged
            progressPanelSample.FrameInterval = CInt((spinFrameInterval.Value))
        End Sub
        ' </spinFrameInterval>
    End Class
End Namespace
