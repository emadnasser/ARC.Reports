Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Core.Model

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class LinearGaugeFeatures
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Sub LinearGaugeFeatures_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitControls()
        End Sub
        Sub InitControls()
            InitScaleFeaturesPage()
            InitRangeBarFeaturesPage()
            InitStateIndicatorFeaturesPage()
            InitOtherFeaturesPage()
        End Sub
        Sub UpdateOtherFeaturesPage(ByVal sender As Object, ByVal e As EventArgs)
            linearScaleComponent6.Value = linearScaleComponent6.MinValue + linearScaleComponent6.ScaleLength * (CSng(trackBarControl1.Value) / CSng(trackBarControl1.Properties.Maximum))
            linearScaleComponent6.Labels(0).TextOrientation = CType(System.Enum.Parse(GetType(LabelOrientation), CStr(lblOrientation.EditValue)), LabelOrientation)
            linearScaleComponent6.Labels(0).Position = New DevExpress.XtraGauges.Core.Base.PointF2D(CSng(horzLblPos.Value), CSng(vertLblPos.Value))
        End Sub
        Sub UpdateStateIndicatorFeaturesPage(ByVal sender As Object, ByVal e As System.EventArgs)
            linearScaleComponent5.Value = stateValTrack.Value
        End Sub
        Sub UpdateRangeBarFeaturesPage(ByVal sender As Object, ByVal e As System.EventArgs)
            linearScaleComponent4.Value = rbValue.Value
            linearScaleRangeBarComponent1.BeginUpdate()
            linearScaleRangeBarComponent1.AnchorValue = rbStartValue.Value
            linearScaleRangeBarComponent1.StartOffset = rbStartExtent.Value
            linearScaleRangeBarComponent1.EndOffset = rbEndExtent.Value
            linearScaleRangeBarComponent1.EndUpdate()

            linearScaleMarkerComponent1.BeginUpdate()
            linearScaleMarkerComponent1.ShapeOffset = markerOffset.Value
            linearScaleMarkerComponent1.ShapeType = CType(System.Enum.Parse(GetType(MarkerPointerShapeType), CStr(markerShape.EditValue)), MarkerPointerShapeType)
            linearScaleMarkerComponent1.EndUpdate()
        End Sub
        Sub UpdateScaleFeaturesPage(ByVal sender As Object, ByVal e As System.EventArgs)
            linearScaleComponent1.BeginUpdate()

            linearScaleComponent1.MinValue = rangeTrackLinear.Value.Minimum
            linearScaleComponent1.MaxValue = rangeTrackLinear.Value.Maximum
            linearScaleComponent1.Value = linearScaleComponent1.MinValue + linearScaleComponent1.ScaleLength * (CSng(valueTrack.Value) / CSng(valueTrack.Properties.Maximum))
            linearScaleComponent1.MinorTickCount = tickmarksCountTrack.Value
            linearScaleComponent1.MajorTickCount = labelsCountTrack.Value
            linearScaleComponent1.MajorTickmark.TextOffset = textExtentTrack.Value

            linearScaleComponent1.MajorTickmark.TextOrientation = CType(System.Enum.Parse(GetType(LabelOrientation), CStr(labelsOrientation.EditValue)), LabelOrientation)

            linearScaleComponent1.MinorTickmark.ShapeOffset = tickOffset.Value
            linearScaleComponent1.MajorTickmark.ShapeOffset = lblTickOffset.Value
            linearScaleComponent1.EndUpdate()
        End Sub
        Protected Sub SubscribeChanged(ByVal trackBar As TrackBarControl, ByVal handler As EventHandler)
            AddHandler trackBar.EditValueChanged, handler
        End Sub
        Protected Sub SubscribeChanged(ByVal combo As ComboBoxEdit, ByVal handler As EventHandler)
            AddHandler combo.SelectedIndexChanged, handler
        End Sub
        Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type)
            Dim names As String() = System.Enum.GetNames(enumType)
            For Each name As String In names
                cbe.Properties.Items.Add(name)
            Next name
        End Sub
        Protected Sub FillCombo(ByVal cbe As ComboBoxEdit, ByVal enumType As Type, ByVal filter As String)
            Dim names As String() = System.Enum.GetNames(enumType)
            For Each name As String In names
                If name.StartsWith(filter) Then
                    cbe.Properties.Items.Add(name)
                End If
            Next name
        End Sub
        Protected Sub InitStateIndicatorFeaturesPage()
            stateValTrack.Value = CInt(Fix(linearScaleComponent5.Value))
            SubscribeChanged(stateValTrack, AddressOf UpdateStateIndicatorFeaturesPage)
        End Sub
        Protected Sub InitRangeBarFeaturesPage()
            rbValue.Value = CInt(Fix(linearScaleComponent4.Value))
            rbStartValue.Value = CInt(Fix(linearScaleRangeBarComponent1.AnchorValue))
            rbStartExtent.Value = CInt(Fix(linearScaleRangeBarComponent1.StartOffset))
            rbEndExtent.Value = CInt(Fix(linearScaleRangeBarComponent1.EndOffset))

            FillCombo(markerShape, GetType(MarkerPointerShapeType))
            markerShape.EditValue = linearScaleMarkerComponent1.ShapeType.ToString()
            markerOffset.Value = CInt(Fix(linearScaleMarkerComponent1.ShapeOffset))

            SubscribeChanged(rbValue, AddressOf UpdateRangeBarFeaturesPage)
            SubscribeChanged(rbStartValue, AddressOf UpdateRangeBarFeaturesPage)
            SubscribeChanged(rbStartExtent, AddressOf UpdateRangeBarFeaturesPage)
            SubscribeChanged(rbEndExtent, AddressOf UpdateRangeBarFeaturesPage)
            AddHandler markerOffset.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
            AddHandler markerShape.EditValueChanged, AddressOf UpdateRangeBarFeaturesPage
        End Sub
        Protected Sub InitScaleFeaturesPage()
            rangeTrackLinear.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(CInt(Fix(linearScaleComponent1.MinValue)), CInt(Fix(linearScaleComponent1.MaxValue)))
            valueTrack.Value = CInt(Fix(linearScaleComponent1.Value))
            tickmarksCountTrack.Value = linearScaleComponent1.MinorTickCount
            labelsCountTrack.Value = linearScaleComponent1.MajorTickCount
            textExtentTrack.Value = CInt(Fix(linearScaleComponent1.MajorTickmark.TextOffset))
            tickOffset.Value = CInt(Fix(linearScaleComponent1.MinorTickmark.ShapeOffset))
            lblTickOffset.Value = CInt(Fix(linearScaleComponent1.MajorTickmark.ShapeOffset))
            '
            SubscribeChanged(rangeTrackLinear, AddressOf UpdateScaleFeaturesPage)
            SubscribeChanged(valueTrack, AddressOf UpdateScaleFeaturesPage)
            SubscribeChanged(tickmarksCountTrack, AddressOf UpdateScaleFeaturesPage)
            SubscribeChanged(labelsCountTrack, AddressOf UpdateScaleFeaturesPage)
            SubscribeChanged(textExtentTrack, AddressOf UpdateScaleFeaturesPage)
            SubscribeChanged(tickOffset, AddressOf UpdateScaleFeaturesPage)
            SubscribeChanged(lblTickOffset, AddressOf UpdateScaleFeaturesPage)
           
            FillCombo(labelsOrientation, GetType(LabelOrientation))
            labelsOrientation.Properties.Items.Remove(LabelOrientation.Radial.ToString())
            labelsOrientation.Properties.Items.Remove(LabelOrientation.Tangent.ToString())
            labelsOrientation.EditValue = linearScaleComponent1.MajorTickmark.TextOrientation.ToString()

            SubscribeChanged(labelsOrientation, AddressOf UpdateScaleFeaturesPage)
            UpdateScaleFeaturesPage(Nothing, Nothing)
        End Sub
        Protected Sub InitOtherFeaturesPage()
            horzLblPos.EditValue = linearScaleComponent6.Labels(0).Position.X
            vertLblPos.EditValue = linearScaleComponent6.Labels(0).Position.Y
            FillCombo(lblOrientation, GetType(LabelOrientation))
            lblOrientation.EditValue = linearScaleComponent6.Labels(0).TextOrientation.ToString()
            lblOrientation.Properties.Items.Remove(LabelOrientation.Radial.ToString())
            lblOrientation.Properties.Items.Remove(LabelOrientation.Tangent.ToString())

            AddHandler horzLblPos.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler vertLblPos.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler trackBarControl1.EditValueChanged, AddressOf UpdateOtherFeaturesPage
            AddHandler lblOrientation.EditValueChanged, AddressOf UpdateOtherFeaturesPage
        End Sub
    End Class
End Namespace
