Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class AnnotationLayoutDemo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim textAnnotation1 As New DevExpress.XtraCharts.TextAnnotation()
			Dim seriesPointAnchorPoint1 As New DevExpress.XtraCharts.SeriesPointAnchorPoint()
			Dim relativePosition1 As New DevExpress.XtraCharts.RelativePosition()
			Dim textAnnotation2 As New DevExpress.XtraCharts.TextAnnotation()
			Dim seriesPointAnchorPoint2 As New DevExpress.XtraCharts.SeriesPointAnchorPoint()
			Dim relativePosition2 As New DevExpress.XtraCharts.RelativePosition()
			Dim imageAnnotation1 As New DevExpress.XtraCharts.ImageAnnotation()
			Dim chartAnchorPoint1 As New DevExpress.XtraCharts.ChartAnchorPoint()
			Dim relativePosition3 As New DevExpress.XtraCharts.RelativePosition()
			Dim textAnnotation3 As New DevExpress.XtraCharts.TextAnnotation()
			Dim paneAnchorPoint1 As New DevExpress.XtraCharts.PaneAnchorPoint()
			Dim relativePosition4 As New DevExpress.XtraCharts.RelativePosition()
			Dim textAnnotation4 As New DevExpress.XtraCharts.TextAnnotation()
			Dim paneAnchorPoint2 As New DevExpress.XtraCharts.PaneAnchorPoint()
			Dim relativePosition5 As New DevExpress.XtraCharts.RelativePosition()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim strip1 As New DevExpress.XtraCharts.Strip()
			Dim strip2 As New DevExpress.XtraCharts.Strip()
			Dim strip3 As New DevExpress.XtraCharts.Strip()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(2.466424R, New Object() { (CObj(-28.2R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2.486035R, New Object() { (CObj(-25.4R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(2.505635R, New Object() { (CObj(-23.4R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(2.525235R, New Object() { (CObj(-22.4R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(2.544851R, New Object() { (CObj(-21R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(2.564458R, New Object() { (CObj(-19.7R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(2.584058R, New Object() { (CObj(-15.9R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(2.603669R, New Object() { (CObj(-15.3R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(2.623269R, New Object() { (CObj(-15.3R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(2.64288R, New Object() { (CObj(-18.9R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(2.66249R, New Object() { (CObj(-21.1R))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(2.682092R, New Object() { (CObj(-23.2R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(2.701703R, New Object() { (CObj(-26.9R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(2.721314R, New Object() { (CObj(-30.8R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(2.760537R, New Object() { (CObj(-43.8R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(2.780148R, New Object() { (CObj(-45.7R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(2.79976R, New Object() { (CObj(-49.1R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(2.819371R, New Object() { (CObj(-51.5R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(2.838982R, New Object() { (CObj(-55.5R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(2.858594R, New Object() { (CObj(-57.5R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(2.878205R, New Object() { (CObj(-61R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(2.897816R, New Object() { (CObj(-61.1R))})
			Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(2.917428R, New Object() { (CObj(-64.5R))})
			Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(2.937039R, New Object() { (CObj(-64.9R))})
			Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(2.976262R, New Object() { (CObj(-67.8R))})
			Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(3.035084R, New Object() { (CObj(-69.3R))})
			Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(3.074307R, New Object() { (CObj(-70.4R))})
			Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(3.093918R, New Object() { (CObj(-71.3R))})
			Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(3.11353R, New Object() { (CObj(-71.9R))})
			Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(3.191964R, New Object() { (CObj(-75R))})
			Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(3.211575R, New Object() { (CObj(-76R))}, 30)
			Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(3.231186R, New Object() { (CObj(-74.7R))})
			Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(3.250786R, New Object() { (CObj(-71.6R))})
			Dim seriesPoint34 As New DevExpress.XtraCharts.SeriesPoint(3.270398R, New Object() { (CObj(-67.2R))})
			Dim seriesPoint35 As New DevExpress.XtraCharts.SeriesPoint(3.289998R, New Object() { (CObj(-63.7R))})
			Dim seriesPoint36 As New DevExpress.XtraCharts.SeriesPoint(3.309609R, New Object() { (CObj(-59.5R))})
			Dim seriesPoint37 As New DevExpress.XtraCharts.SeriesPoint(3.329209R, New Object() { (CObj(-53R))})
			Dim seriesPoint38 As New DevExpress.XtraCharts.SeriesPoint(3.34882R, New Object() { (CObj(-47.7R))})
			Dim seriesPoint39 As New DevExpress.XtraCharts.SeriesPoint(3.368421R, New Object() { (CObj(-44.3R))})
			Dim seriesPoint40 As New DevExpress.XtraCharts.SeriesPoint(3.388032R, New Object() { (CObj(-42R))})
			Dim seriesPoint41 As New DevExpress.XtraCharts.SeriesPoint(3.407632R, New Object() { (CObj(-36R))})
			Dim seriesPoint42 As New DevExpress.XtraCharts.SeriesPoint(3.427243R, New Object() { (CObj(-32.6R))})
			Dim seriesPoint43 As New DevExpress.XtraCharts.SeriesPoint(3.446843R, New Object() { (CObj(-29.8R))})
			Dim seriesPoint44 As New DevExpress.XtraCharts.SeriesPoint(3.466274R, New Object() { (CObj(-27R))})
			Dim seriesPoint45 As New DevExpress.XtraCharts.SeriesPoint(3.505486R, New Object() { (CObj(-22.3R))})
			Dim seriesPoint46 As New DevExpress.XtraCharts.SeriesPoint(3.544708R, New Object() { (CObj(-19.5R))})
			Dim seriesPoint47 As New DevExpress.XtraCharts.SeriesPoint(3.56432R, New Object() { (CObj(-17.1R))})
			Dim seriesPoint48 As New DevExpress.XtraCharts.SeriesPoint(3.603531R, New Object() { (CObj(-15.1R))})
			Dim seriesPoint49 As New DevExpress.XtraCharts.SeriesPoint(3.623142R, New Object() { (CObj(-14.8R))})
			Dim seriesPoint50 As New DevExpress.XtraCharts.SeriesPoint(3.642742R, New Object() { (CObj(-19.2R))})
			Dim seriesPoint51 As New DevExpress.XtraCharts.SeriesPoint(3.662343R, New Object() { (CObj(-19.5R))})
			Dim seriesPoint52 As New DevExpress.XtraCharts.SeriesPoint(3.681954R, New Object() { (CObj(-22.4R))})
			Dim seriesPoint53 As New DevExpress.XtraCharts.SeriesPoint(3.701565R, New Object() { (CObj(-26.1R))})
			Dim seriesPoint54 As New DevExpress.XtraCharts.SeriesPoint(3.721177R, New Object() { (CObj(-32.1R))})
			Dim seriesPoint55 As New DevExpress.XtraCharts.SeriesPoint(3.740788R, New Object() { (CObj(-39.2R))})
			Dim seriesPoint56 As New DevExpress.XtraCharts.SeriesPoint(3.760399R, New Object() { (CObj(-45.2R))})
			Dim seriesPoint57 As New DevExpress.XtraCharts.SeriesPoint(3.78001R, New Object() { (CObj(-46.6R))})
			Dim seriesPoint58 As New DevExpress.XtraCharts.SeriesPoint(3.799622R, New Object() { (CObj(-49.9R))})
			Dim seriesPoint59 As New DevExpress.XtraCharts.SeriesPoint(3.819233R, New Object() { (CObj(-55.2R))})
			Dim seriesPoint60 As New DevExpress.XtraCharts.SeriesPoint(3.838844R, New Object() { (CObj(-58.4R))})
			Dim seriesPoint61 As New DevExpress.XtraCharts.SeriesPoint(3.858456R, New Object() { (CObj(-60.1R))})
			Dim seriesPoint62 As New DevExpress.XtraCharts.SeriesPoint(3.878068R, New Object() { (CObj(-60.2R))})
			Dim seriesPoint63 As New DevExpress.XtraCharts.SeriesPoint(3.897678R, New Object() { (CObj(-60.8R))})
			Dim seriesPoint64 As New DevExpress.XtraCharts.SeriesPoint(3.91729R, New Object() { (CObj(-63.9R))})
			Dim seriesPoint65 As New DevExpress.XtraCharts.SeriesPoint(3.936901R, New Object() { (CObj(-65.1R))})
			Dim seriesPoint66 As New DevExpress.XtraCharts.SeriesPoint(3.956512R, New Object() { (CObj(-66.3R))})
			Dim seriesPoint67 As New DevExpress.XtraCharts.SeriesPoint(3.976124R, New Object() { (CObj(-68.7R))})
			Dim seriesPoint68 As New DevExpress.XtraCharts.SeriesPoint(3.995735R, New Object() { (CObj(-65.5R))})
			Dim seriesPoint69 As New DevExpress.XtraCharts.SeriesPoint(4.015346R, New Object() { (CObj(-66R))})
			Dim seriesPoint70 As New DevExpress.XtraCharts.SeriesPoint(4.034958R, New Object() { (CObj(-67.5R))})
			Dim seriesPoint71 As New DevExpress.XtraCharts.SeriesPoint(4.054569R, New Object() { (CObj(-67.4R))})
			Dim seriesPoint72 As New DevExpress.XtraCharts.SeriesPoint(4.07418R, New Object() { (CObj(-69.1R))})
			Dim seriesPoint73 As New DevExpress.XtraCharts.SeriesPoint(4.093792R, New Object() { (CObj(-71.2R))})
			Dim seriesPoint74 As New DevExpress.XtraCharts.SeriesPoint(4.113403R, New Object() { (CObj(-71.1R))})
			Dim seriesPoint75 As New DevExpress.XtraCharts.SeriesPoint(4.133014R, New Object() { (CObj(-72.6R))})
			Dim seriesPoint76 As New DevExpress.XtraCharts.SeriesPoint(4.152626R, New Object() { (CObj(-72.5R))})
			Dim seriesPoint77 As New DevExpress.XtraCharts.SeriesPoint(4.172237R, New Object() { (CObj(-73.9R))})
			Dim seriesPoint78 As New DevExpress.XtraCharts.SeriesPoint(4.21146R, New Object() { (CObj(-73.5R))})
			Dim seriesPoint79 As New DevExpress.XtraCharts.SeriesPoint(4.231071R, New Object() { (CObj(-74.8R))})
			Dim seriesPoint80 As New DevExpress.XtraCharts.SeriesPoint(4.250684R, New Object() { (CObj(-71.7R))})
			Dim seriesPoint81 As New DevExpress.XtraCharts.SeriesPoint(4.270294R, New Object() { (CObj(-64.6R))})
			Dim seriesPoint82 As New DevExpress.XtraCharts.SeriesPoint(4.289895R, New Object() { (CObj(-61.8R))})
			Dim seriesPoint83 As New DevExpress.XtraCharts.SeriesPoint(4.309505R, New Object() { (CObj(-52.9R))})
			Dim seriesPoint84 As New DevExpress.XtraCharts.SeriesPoint(4.370569R, New Object() { (CObj(-43.7R))})
			Dim seriesPoint85 As New DevExpress.XtraCharts.SeriesPoint(4.387928R, New Object() { (CObj(-39.3R))})
			Dim seriesPoint86 As New DevExpress.XtraCharts.SeriesPoint(4.427139R, New Object() { (CObj(-33.3R))})
			Dim seriesPoint87 As New DevExpress.XtraCharts.SeriesPoint(4.446739R, New Object() { (CObj(-32.6R))})
			Dim seriesPoint88 As New DevExpress.XtraCharts.SeriesPoint(4.46617R, New Object() { (CObj(-30.9R))})
			Dim seriesPoint89 As New DevExpress.XtraCharts.SeriesPoint(4.52737R, New Object() { (CObj(-23.6R))})
			Dim seriesPoint90 As New DevExpress.XtraCharts.SeriesPoint(4.544582R, New Object() { (CObj(-20.3R))})
			Dim seriesPoint91 As New DevExpress.XtraCharts.SeriesPoint(4.564193R, New Object() { (CObj(-16.1R))})
			Dim seriesPoint92 As New DevExpress.XtraCharts.SeriesPoint(4.583793R, New Object() { (CObj(-14.6R))}, 91)
			Dim seriesPoint93 As New DevExpress.XtraCharts.SeriesPoint(4.603404R, New Object() { (CObj(-15.7R))})
			Dim seriesPoint94 As New DevExpress.XtraCharts.SeriesPoint(4.623004R, New Object() { (CObj(-15.5R))})
			Dim seriesPoint95 As New DevExpress.XtraCharts.SeriesPoint(4.642616R, New Object() { (CObj(-15.7R))})
			Dim seriesPoint96 As New DevExpress.XtraCharts.SeriesPoint(4.662216R, New Object() { (CObj(-20.6R))})
			Dim seriesPoint97 As New DevExpress.XtraCharts.SeriesPoint(4.681816R, New Object() { (CObj(-21.5R))})
			Dim seriesPoint98 As New DevExpress.XtraCharts.SeriesPoint(4.701427R, New Object() { (CObj(-26.4R))})
			Dim seriesPoint99 As New DevExpress.XtraCharts.SeriesPoint(4.721039R, New Object() { (CObj(-31.7R))})
			Dim seriesPoint100 As New DevExpress.XtraCharts.SeriesPoint(4.74065R, New Object() { (CObj(-39.4R))})
			Dim seriesPoint101 As New DevExpress.XtraCharts.SeriesPoint(4.760261R, New Object() { (CObj(-45.1R))})
			Dim seriesPoint102 As New DevExpress.XtraCharts.SeriesPoint(4.782272R, New Object() { (CObj(-49R))})
			Dim seriesPoint103 As New DevExpress.XtraCharts.SeriesPoint(4.799484R, New Object() { (CObj(-50.2R))})
			Dim seriesPoint104 As New DevExpress.XtraCharts.SeriesPoint(4.819095R, New Object() { (CObj(-54.5R))})
			Dim seriesPoint105 As New DevExpress.XtraCharts.SeriesPoint(4.838706R, New Object() { (CObj(-57.9R))})
			Dim seriesPoint106 As New DevExpress.XtraCharts.SeriesPoint(4.858318R, New Object() { (CObj(-59.2R))})
			Dim seriesPoint107 As New DevExpress.XtraCharts.SeriesPoint(4.877929R, New Object() { (CObj(-63.4R))})
			Dim seriesPoint108 As New DevExpress.XtraCharts.SeriesPoint(4.89754R, New Object() { (CObj(-62.9R))})
			Dim seriesPoint109 As New DevExpress.XtraCharts.SeriesPoint(4.917152R, New Object() { (CObj(-60.9R))})
			Dim seriesPoint110 As New DevExpress.XtraCharts.SeriesPoint(4.936763R, New Object() { (CObj(-63.6R))})
			Dim seriesPoint111 As New DevExpress.XtraCharts.SeriesPoint(4.95874R, New Object() { (CObj(-63.2R))})
			Dim seriesPoint112 As New DevExpress.XtraCharts.SeriesPoint(4.975986R, New Object() { (CObj(-68.8R))})
			Dim seriesPoint113 As New DevExpress.XtraCharts.SeriesPoint(4.995586R, New Object() { (CObj(-67.5R))})
			Dim splineSeriesView1 As New DevExpress.XtraCharts.SplineSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.cheMoving = New DevExpress.XtraEditors.CheckEdit()
			Me.cheResizing = New DevExpress.XtraEditors.CheckEdit()
			Me.cheRotation = New DevExpress.XtraEditors.CheckEdit()
			Me.cheAnchoring = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(textAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(seriesPointAnchorPoint1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(textAnnotation2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(seriesPointAnchorPoint2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(imageAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(textAnnotation3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(textAnnotation4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheMoving.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheResizing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheRotation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheAnchoring.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.cheAnchoring)
			Me.panel.Controls.Add(Me.cheRotation)
			Me.panel.Controls.Add(Me.cheResizing)
			Me.panel.Controls.Add(Me.cheMoving)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cheMoving, 0)
			Me.panel.Controls.SetChildIndex(Me.cheResizing, 0)
			Me.panel.Controls.SetChildIndex(Me.cheRotation, 0)
			Me.panel.Controls.SetChildIndex(Me.cheAnchoring, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			seriesPointAnchorPoint1.SeriesID = 0
			seriesPointAnchorPoint1.SeriesPointID = 30
			textAnnotation1.AnchorPoint = seriesPointAnchorPoint1
			textAnnotation1.Name = "Minimum"
			textAnnotation1.RuntimeMoving = True
			textAnnotation1.RuntimeResizing = True
			textAnnotation1.RuntimeRotation = True
			relativePosition1.Angle = -247.14073911843772R
			relativePosition1.ConnectorLength = 57.961257982868766R
			textAnnotation1.ShapePosition = relativePosition1
			textAnnotation1.Text = "Minimum: -76"
			seriesPointAnchorPoint2.SeriesID = 0
			seriesPointAnchorPoint2.SeriesPointID = 91
			textAnnotation2.AnchorPoint = seriesPointAnchorPoint2
			textAnnotation2.Name = "Maximum"
			textAnnotation2.RuntimeMoving = True
			textAnnotation2.RuntimeResizing = True
			textAnnotation2.RuntimeRotation = True
			relativePosition2.Angle = -320.98616184697175R
			relativePosition2.ConnectorLength = 37.148312257092805R
			textAnnotation2.ShapePosition = relativePosition2
			textAnnotation2.Text = "Maximum: -14.6"
			chartAnchorPoint1.X = 103
			chartAnchorPoint1.Y = 65
			imageAnnotation1.AnchorPoint = chartAnchorPoint1
			imageAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
			imageAnnotation1.Image.Image = My.Resources.Mars
			imageAnnotation1.Name = "Mars"
			imageAnnotation1.RuntimeAnchoring = True
			imageAnnotation1.RuntimeMoving = True
			imageAnnotation1.RuntimeResizing = True
			imageAnnotation1.RuntimeRotation = True
			relativePosition3.Angle = 0R
			relativePosition3.ConnectorLength = 0R
			imageAnnotation1.ShapePosition = relativePosition3
			paneAnchorPoint1.AxisXCoordinate.AxisValueSerializable = "2.5632"
			paneAnchorPoint1.AxisYCoordinate.AxisValueSerializable = "-54.0941176470588"
			textAnnotation3.AnchorPoint = paneAnchorPoint1
			textAnnotation3.Name = "Day"
			textAnnotation3.RuntimeAnchoring = True
			textAnnotation3.RuntimeMoving = True
			textAnnotation3.RuntimeResizing = True
			textAnnotation3.RuntimeRotation = True
			relativePosition4.Angle = 0R
			relativePosition4.ConnectorLength = 0R
			textAnnotation3.ShapePosition = relativePosition4
			textAnnotation3.Text = "Day"
			paneAnchorPoint2.AxisXCoordinate.AxisValueSerializable = "2.984"
			paneAnchorPoint2.AxisYCoordinate.AxisValueSerializable = "-35.0020761245675"
			textAnnotation4.AnchorPoint = paneAnchorPoint2
			textAnnotation4.Name = "Night"
			textAnnotation4.RuntimeAnchoring = True
			textAnnotation4.RuntimeMoving = True
			textAnnotation4.RuntimeResizing = True
			textAnnotation4.RuntimeRotation = True
			relativePosition5.Angle = 0R
			relativePosition5.ConnectorLength = 0R
			textAnnotation4.ShapePosition = relativePosition5
			textAnnotation4.Text = "Night"
			Me.chart.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() { textAnnotation1, textAnnotation2, imageAnnotation1, textAnnotation3, textAnnotation4})
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			strip1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))))
			strip1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
			strip1.MaxLimit.AxisValueSerializable = "3.216"
			strip1.MinLimit.AxisValueSerializable = "2.748"
			strip1.Name = "Night1"
			strip1.ShowInLegend = False
			strip2.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))))
			strip2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
			strip2.MaxLimit.AxisValueSerializable = "4.216"
			strip2.MinLimit.AxisValueSerializable = "3.748"
			strip2.Name = "Night2"
			strip2.ShowInLegend = False
			strip3.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(80))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))))
			strip3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
			strip3.MaxLimit.AxisValueSerializable = "5.216"
			strip3.MinLimit.AxisValueSerializable = "4.748"
			strip3.Name = "Night3"
			strip3.ShowInLegend = False
			xyDiagram1.AxisX.Strips.AddRange(New DevExpress.XtraCharts.Strip() { strip1, strip2, strip3})
			xyDiagram1.AxisX.Title.Text = "Sol"
			xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "3.9"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "2.4"
			xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0R
			xyDiagram1.AxisX.WholeRange.Auto = False
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "5.05"
			xyDiagram1.AxisX.WholeRange.MinValueSerializable = "2.4"
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram1.AxisY.Title.Text = "Temperature, in degrees Celsius"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.EnableAxisXScrolling = True
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.Label = pointSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Mars Ambient Temperature"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42, seriesPoint43, seriesPoint44, seriesPoint45, seriesPoint46, seriesPoint47, seriesPoint48, seriesPoint49, seriesPoint50, seriesPoint51, seriesPoint52, seriesPoint53, seriesPoint54, seriesPoint55, seriesPoint56, seriesPoint57, seriesPoint58, seriesPoint59, seriesPoint60, seriesPoint61, seriesPoint62, seriesPoint63, seriesPoint64, seriesPoint65, seriesPoint66, seriesPoint67, seriesPoint68, seriesPoint69, seriesPoint70, seriesPoint71, seriesPoint72, seriesPoint73, seriesPoint74, seriesPoint75, seriesPoint76, seriesPoint77, seriesPoint78, seriesPoint79, seriesPoint80, seriesPoint81, seriesPoint82, seriesPoint83, seriesPoint84, seriesPoint85, seriesPoint86, seriesPoint87, seriesPoint88, seriesPoint89, seriesPoint90, seriesPoint91, seriesPoint92, seriesPoint93, seriesPoint94, seriesPoint95, seriesPoint96, seriesPoint97, seriesPoint98, seriesPoint99, seriesPoint100, seriesPoint101, seriesPoint102, seriesPoint103, seriesPoint104, seriesPoint105, seriesPoint106, seriesPoint107, seriesPoint108, seriesPoint109, seriesPoint110, seriesPoint111, seriesPoint112, seriesPoint113})
			series1.SeriesID = 0
			splineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.View = splineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Mars Pathfinder Temperature Data"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www-k12.atmos.washington.edu/k12"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' cheMoving
			' 
			Me.cheMoving.EditValue = True
			Me.cheMoving.Location = New System.Drawing.Point(12, 9)
			Me.cheMoving.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.cheMoving.Name = "cheMoving"
			Me.cheMoving.Properties.AutoWidth = True
			Me.cheMoving.Properties.Caption = "Allow Moving"
			Me.cheMoving.Size = New System.Drawing.Size(84, 19)
			Me.cheMoving.TabIndex = 2
'			Me.cheMoving.CheckedChanged += New System.EventHandler(Me.cheMoving_CheckedChanged);
			' 
			' cheResizing
			' 
			Me.cheResizing.EditValue = True
			Me.cheResizing.Location = New System.Drawing.Point(106, 8)
			Me.cheResizing.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.cheResizing.Name = "cheResizing"
			Me.cheResizing.Properties.AutoWidth = True
			Me.cheResizing.Properties.Caption = "Allow Resizing"
			Me.cheResizing.Size = New System.Drawing.Size(89, 19)
			Me.cheResizing.TabIndex = 3
'			Me.cheResizing.CheckedChanged += New System.EventHandler(Me.cheResizing_CheckedChanged);
			' 
			' cheRotation
			' 
			Me.cheRotation.EditValue = True
			Me.cheRotation.Location = New System.Drawing.Point(205, 8)
			Me.cheRotation.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.cheRotation.Name = "cheRotation"
			Me.cheRotation.Properties.AutoWidth = True
			Me.cheRotation.Properties.Caption = "Allow Rotation"
			Me.cheRotation.Size = New System.Drawing.Size(91, 19)
			Me.cheRotation.TabIndex = 4
'			Me.cheRotation.CheckedChanged += New System.EventHandler(Me.cheRotation_CheckedChanged);
			' 
			' cheAnchoring
			' 
			Me.cheAnchoring.EditValue = True
			Me.cheAnchoring.Location = New System.Drawing.Point(306, 8)
			Me.cheAnchoring.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.cheAnchoring.Name = "cheAnchoring"
			Me.cheAnchoring.Properties.AutoWidth = True
			Me.cheAnchoring.Properties.Caption = "Allow Anchoring"
			Me.cheAnchoring.Size = New System.Drawing.Size(98, 19)
			Me.cheAnchoring.TabIndex = 5
'			Me.cheAnchoring.CheckedChanged += New System.EventHandler(Me.cheAnchoring_CheckedChanged);
			' 
			' AnnotationLayoutDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "AnnotationLayoutDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(seriesPointAnchorPoint1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(textAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(seriesPointAnchorPoint2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(textAnnotation2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(imageAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(textAnnotation3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(textAnnotation4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheMoving.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheResizing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheRotation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheAnchoring.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Protected WithEvents cheMoving As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents cheRotation As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents cheResizing As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents cheAnchoring As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
