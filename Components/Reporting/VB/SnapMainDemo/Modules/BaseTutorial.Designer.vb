Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace SnapDemos.Modules
	Partial Public Class BaseTutorial
		Private components As System.ComponentModel.IContainer

		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(BaseTutorial))
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup3 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim borderInfo1 As New DevExpress.XtraRichEdit.Model.BorderInfo()
			Dim chartControlCommandGalleryItemGroup2DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem1 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem1 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem1 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem1 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem1 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem1 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem1 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim skinPaddingEdges1 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges2 As New DevExpress.Skins.SkinPaddingEdges()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
			Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject7 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject8 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim chartControlCommandGalleryItemGroup2DColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem2 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem2 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem2 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem2 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem2 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem2 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem2 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem2 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem2 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem2 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem2 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem2 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem2 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem2 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem2 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem2 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem2 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem2 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem2 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim skinPaddingEdges3 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges4 As New DevExpress.Skins.SkinPaddingEdges()
			Dim chartControlCommandGalleryItemGroup2DColumn3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem3 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem3 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem3 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem3 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem3 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem3 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem3 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem3 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem3 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem3 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem3 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem3 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem3 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem3 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem3 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem3 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem3 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem3 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem3 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem3 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem3 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem3 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem3 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem3 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem3 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem3 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem3 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem3 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem3 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem3 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem3 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem3 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem3 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt3 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem3 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem3 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim skinPaddingEdges5 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges6 As New DevExpress.Skins.SkinPaddingEdges()
			Dim chartControlCommandGalleryItemGroup2DColumn4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem4 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem4 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem4 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem4 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem4 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem4 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem4 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem4 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem4 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem4 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem4 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem4 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem4 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem4 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem4 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem4 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem4 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem4 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem4 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem4 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem4 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem4 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem4 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem4 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem4 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem4 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem4 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem4 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem4 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem4 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem4 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem4 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem4 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt4 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem4 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem4 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim skinPaddingEdges7 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges8 As New DevExpress.Skins.SkinPaddingEdges()
			Dim chartControlCommandGalleryItemGroup2DColumn5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem5 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem5 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem5 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem5 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem5 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem5 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem5 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem5 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem5 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem5 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem5 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem5 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem5 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem5 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem5 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem5 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem5 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem5 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem5 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem5 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem5 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem5 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem5 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem5 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem5 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem5 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem5 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem5 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem5 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem5 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem5 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem5 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem5 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt5 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem5 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem5 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim skinPaddingEdges9 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges10 As New DevExpress.Skins.SkinPaddingEdges()
			Dim chartControlCommandGalleryItemGroup2DColumn6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
			Dim createBarChartItem6 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
			Dim createFullStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
			Dim createSideBySideFullStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
			Dim createSideBySideStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
			Dim createStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup3DColumn6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
			Dim createBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
			Dim createFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
			Dim createManhattanBarChartItem6 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
			Dim createSideBySideFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
			Dim createSideBySideStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
			Dim createStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupCylinderColumn6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
			Dim createCylinderBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
			Dim createCylinderFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
			Dim createCylinderManhattanBarChartItem6 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
			Dim createCylinderSideBySideFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
			Dim createCylinderSideBySideStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
			Dim createCylinderStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupConeColumn6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
			Dim createConeBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
			Dim createConeFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
			Dim createConeManhattanBarChartItem6 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
			Dim createConeSideBySideFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
			Dim createConeSideBySideStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
			Dim createConeStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroupPyramidColumn6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
			Dim createPyramidBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
			Dim createPyramidFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
			Dim createPyramidManhattanBarChartItem6 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
			Dim createPyramidSideBySideFullStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
			Dim createPyramidSideBySideStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
			Dim createPyramidStackedBar3DChartItem6 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DLine6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
			Dim createLineChartItem6 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
			Dim createFullStackedLineChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
			Dim createScatterLineChartItem6 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
			Dim createSplineChartItem6 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
			Dim createStackedLineChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
			Dim createStepLineChartItem6 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
			Dim chartControlCommandGalleryItemGroup3DLine6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
			Dim createLine3DChartItem6 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
			Dim createFullStackedLine3DChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
			Dim createSpline3DChartItem6 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
			Dim createStackedLine3DChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
			Dim createStepLine3DChartItem6 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DPie6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
			Dim createPieChartItem6 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
			Dim createDoughnutChartItem6 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
			Dim chartControlCommandGalleryItemGroup3DPie6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
			Dim createPie3DChartItem6 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
			Dim createDoughnut3DChartItem6 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
			Dim chartControlCommandGalleryItemGroup2DBar6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
			Dim createRotatedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
			Dim createRotatedFullStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
			Dim createRotatedSideBySideFullStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
			Dim createRotatedSideBySideStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
			Dim createRotatedStackedBarChartItem6 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
			Dim chartControlCommandGalleryItemGroup2DArea6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
			Dim createAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
			Dim createFullStackedAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
			Dim createFullStackedSplineAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
			Dim createSplineAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
			Dim createStackedAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
			Dim createStackedSplineAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
			Dim createStepAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
			Dim chartControlCommandGalleryItemGroup3DArea6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
			Dim createArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
			Dim createFullStackedArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
			Dim createFullStackedSplineArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
			Dim createSplineArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
			Dim createStackedArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
			Dim createStackedSplineArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
			Dim createStepArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupPoint6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
			Dim createPointChartItem6 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
			Dim createBubbleChartItem6 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
			Dim chartControlCommandGalleryItemGroupFunnel6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
			Dim createFunnelChartItem6 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
			Dim createFunnel3DChartItem6 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
			Dim chartControlCommandGalleryItemGroupFinancial6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
			Dim createStockChartItem6 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
			Dim createCandleStickChartItem6 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
			Dim chartControlCommandGalleryItemGroupRadar6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
			Dim createRadarPointChartItem6 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
			Dim createRadarLineChartItem6 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
			Dim createRadarAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupPolar6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
			Dim createPolarPointChartItem6 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
			Dim createPolarLineChartItem6 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
			Dim createPolarAreaChartItem6 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
			Dim chartControlCommandGalleryItemGroupRange6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
			Dim createRangeBarChartItem6 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
			Dim createSideBySideRangeBarChartItem6 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
			Dim createRangeAreaChartItem6 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
			Dim createRangeArea3DChartItem6 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
			Dim chartControlCommandGalleryItemGroupGantt6 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
			Dim createGanttChartItem6 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
			Dim createSideBySideGanttChartItem6 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
			Dim galleryItemGroup4 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim changePaletteGalleryItem1 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem2 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem3 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem4 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem5 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem6 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem7 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem8 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem9 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem10 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem11 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem12 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem13 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem14 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem15 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem16 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem17 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem18 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem19 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem20 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem21 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem22 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem23 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem24 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem25 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem26 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem27 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem28 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem29 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem30 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim changePaletteGalleryItem31 As New DevExpress.XtraCharts.UI.ChangePaletteGalleryItem()
			Dim skinPaddingEdges11 As New DevExpress.Skins.SkinPaddingEdges()
			Dim skinPaddingEdges12 As New DevExpress.Skins.SkinPaddingEdges()
			Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
			Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
			Me.snapControl1 = New DevExpress.Snap.SnapControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.commandBarItem2 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
			Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
			Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
			Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
			Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
			Me.repositoryItemFontEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
			Me.repositoryItemRichEditFontSizeEdit2 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
			Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
			Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
			Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
			Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
			Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
			Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
			Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
			Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
			Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
			Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
			Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
			Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
			Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
			Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
			Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
			Me.capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
			Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
			Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
			Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
			Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
			Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
			Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
			Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
			Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
			Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
			Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
			Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
			Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
			Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
			Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
			Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
			Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
			Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
			Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
			Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
			Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
			Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
			Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
			Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
			Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
			Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
			Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
			Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
			Me.insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
			Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
			Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
			Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
			Me.commandBarItem3 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem5 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem6 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem7 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
			Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
			Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
			Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
			Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
			Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
			Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
			Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
			Me.changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
			Me.setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
			Me.setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
			Me.setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
			Me.setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
			Me.showPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
			Me.changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
			Me.setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
			Me.setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
			Me.changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
			Me.changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
			Me.setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
			Me.setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
			Me.setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
			Me.showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
			Me.insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
			Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
			Me.insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
			Me.insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
			Me.insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
			Me.insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
			Me.changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
			Me.setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
			Me.setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
			Me.setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
			Me.setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
			Me.toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
			Me.showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
			Me.changePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
			Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
			Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
			Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
			Me.toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
			Me.toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
			Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
			Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
			Me.snapBarToolbarsListItem1 = New DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem()
			Me.commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
			Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
			Me.toggleFieldHighlightingItem1 = New DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem()
			Me.goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
			Me.goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
			Me.goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
			Me.goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
			Me.toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
			Me.toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
			Me.toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
			Me.closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
			Me.toggleFirstRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstRowItem()
			Me.toggleLastRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastRowItem()
			Me.toggleBandedRowsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem()
			Me.toggleFirstColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem()
			Me.toggleLastColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastColumnItem()
			Me.toggleBandedColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem()
			Me.galleryChangeTableStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem()
			Me.galleryChangeTableCellStyleItem1 = New DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem()
			Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
			Me.repositoryItemBorderLineStyle2 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
			Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
			Me.repositoryItemBorderLineWeight2 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
			Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
			Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
			Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
			Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
			Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
			Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
			Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
			Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
			Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
			Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
			Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
			Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
			Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
			Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
			Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
			Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
			Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
			Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
			Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
			Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
			Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
			Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
			Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
			Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
			Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
			Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
			Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
			Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
			Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
			Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
			Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
			Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
			Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
			Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
			Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
			Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
			Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
			Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
			Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
			Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
			Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
			Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
			Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
			Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
			Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
			Me.showTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
			Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
			Me.insertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
			Me.updateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
			Me.addParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
			Me.setParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.setParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
			Me.insertCaptionPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem()
			Me.insertFiguresCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems()
			Me.insertTablesCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems()
			Me.insertEquationsCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems()
			Me.insertTableOfFiguresPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem()
			Me.insertTableOfFiguresItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems()
			Me.insertTableOfTablesItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems()
			Me.insertTableOfEquationsItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems()
			Me.updateTableOfFiguresItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem()
			Me.changeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
			Me.changeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
			Me.changeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
			Me.repositoryItemFloatingObjectOutlineWeight2 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
			Me.changeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
			Me.setFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
			Me.setFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
			Me.setFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
			Me.setFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
			Me.setFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
			Me.setFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
			Me.changeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
			Me.setFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
			Me.setFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
			Me.setFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
			Me.setFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
			Me.setFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
			Me.setFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
			Me.setFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
			Me.setFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
			Me.setFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
			Me.floatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
			Me.floatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
			Me.floatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
			Me.floatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
			Me.floatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
			Me.floatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
			Me.floatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
			Me.floatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
			Me.themesGalleryBarItem1 = New DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem()
			Me.commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem3 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem4 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarSubItem1 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem5 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem6 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem7 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem8 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem9 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.filterPopupButtonItem1 = New DevExpress.Snap.Extensions.UI.FilterPopupButtonItem()
			Me.propertiesBarButtonItem1 = New DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem()
			Me.commandBarSubItem2 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem10 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem11 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarSubItem3 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem12 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem13 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarItem8 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem9 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarSubItem4 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem14 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem15 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem16 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem17 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem18 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem19 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem20 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarSubItem5 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem21 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem22 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarSubItem6 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem23 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem24 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarSubItem7 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem25 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem26 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem27 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem28 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem29 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem30 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem31 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarItem10 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem11 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem12 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeEditorRowLimitItem1 = New DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem()
			Me.repositoryItemEditorRowLimitEdit2 = New DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit()
			Me.createBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
			Me.commandBarGalleryDropDown36 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
			Me.commandBarGalleryDropDown37 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createPieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
			Me.commandBarGalleryDropDown38 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
			Me.commandBarGalleryDropDown39 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
			Me.commandBarGalleryDropDown40 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.createOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
			Me.commandBarGalleryDropDown41 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.changePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
			Me.commandBarGalleryDropDown42 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.changeAppearanceGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem()
			Me.runWizardChartItem1 = New DevExpress.XtraCharts.UI.RunWizardChartItem()
			Me.mailMergeDataSourceItem1 = New DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem()
			Me.commandBarCheckItem32 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem33 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.mailMergeCurrentRecordItem1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem()
			Me.repositoryItemMailMergeCurrentRecordEdit2 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
			Me.commandBarSubItem8 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarItem13 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem14 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem15 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.headerFooterToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory()
			Me.headerFooterToolsDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage()
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup()
			Me.headerFooterToolsDesignOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup()
			Me.headerFooterToolsDesignCloseRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup()
			Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
			Me.tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
			Me.tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup()
			Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
			Me.tableCellStylesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup()
			Me.tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
			Me.tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
			Me.tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
			Me.tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
			Me.tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
			Me.tableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
			Me.tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
			Me.floatingPictureToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory()
			Me.floatingPictureToolsFormatPage1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage()
			Me.floatingPictureToolsShapeStylesPageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup()
			Me.floatingPictureToolsArrangePageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup()
			Me.dataToolsRibbonPageCategory1 = New DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory()
			Me.appearanceRibbonPage1 = New DevExpress.Snap.Extensions.UI.AppearanceRibbonPage()
			Me.themesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup()
			Me.snMergeFieldToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage()
			Me.dataShapingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup()
			Me.snMergeFieldPropertiesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup()
			Me.groupToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage()
			Me.groupingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup()
			Me.listToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.ListToolsRibbonPage()
			Me.listHeaderAndFooterRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup()
			Me.listCommandsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup()
			Me.listEditorRowLimitRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup()
			Me.mailMergeRibbonPage1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPage()
			Me.mailMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup()
			Me.mailMergeCurrentRecordRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup()
			Me.finishAndMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup()
			Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			Me.dataRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataRibbonPageGroup()
			Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
			Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
			Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
			Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
			Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
			Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
			Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
			Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
			Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
			Me.toolboxRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup()
			Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
			Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
			Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
			Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
			Me.pageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
			Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
			Me.pageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
			Me.viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
			Me.documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
			Me.showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
			Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
			Me.viewRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup()
			Me.viewFieldsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup()
			Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
			Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
			Me.referencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
			Me.tableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
			Me.captionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
			Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
			Me.repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
			Me.repositoryItemEditorRowLimitEdit1 = New DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit()
			Me.repositoryItemMailMergeCurrentRecordEdit1 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
			Me.commandBarGalleryDropDown29 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown30 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown31 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown32 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown33 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown34 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown35 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown22 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown23 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown24 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown25 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown26 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown27 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown28 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown15 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown16 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown17 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown18 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown19 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown20 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown21 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown13 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown14 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
			Me.snapDockManager1 = New DevExpress.Snap.Extensions.SnapDockManager(Me.components)
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.fieldListDockPanel1 = New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
			Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.reportExplorerDockPanel1 = New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
			Me.reportExplorerDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.snapDocumentManager1 = New DevExpress.Snap.Extensions.SnapDocumentManager(Me.components)
			Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
			Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
			Me.chartTypeRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup()
			Me.createChartRibbonPage1 = New DevExpress.XtraCharts.UI.CreateChartRibbonPage()
			Me.chartRibbonPageCategory1 = New DevExpress.XtraCharts.UI.ChartRibbonPageCategory()
			Me.chartAppearanceRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup()
			Me.chartWizardRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup()
			Me.runDesignerChartItem1 = New DevExpress.XtraCharts.UI.RunDesignerChartItem()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemBorderLineStyle2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemBorderLineWeight2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFloatingObjectOutlineWeight2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemEditorRowLimitEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown36, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown37, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown38, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown39, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown40, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown41, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown42, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMailMergeCurrentRecordEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown29, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown30, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown31, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown32, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown33, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown34, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown35, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown22, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown23, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown24, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown25, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown26, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown27, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown28, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.fieldListDockPanel1.SuspendLayout()
			Me.reportExplorerDockPanel1.SuspendLayout()
			CType(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' stylesRibbonPageGroup1
			' 
			Me.stylesRibbonPageGroup1.Glyph = (CType(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image))
			Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
			Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
			' 
			' galleryChangeStyleItem1
			' 
			' 
			' 
			' 
			Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
			Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryChangeStyleItem1.Id = 376
			Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
			' 
			' snapControl1
			' 
			Me.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.snapControl1.EnableToolTips = True
			Me.snapControl1.Location = New System.Drawing.Point(0, 141)
			Me.snapControl1.MenuManager = Me.ribbonControl1
			Me.snapControl1.Name = "snapControl1"
			Me.snapControl1.Options.Comments.Visibility = DevExpress.XtraRichEdit.RichEditCommentVisibility.Hidden
			Me.snapControl1.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
			Me.snapControl1.Options.Fields.UpdateFieldsInTextBoxes = False
			Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
			Me.snapControl1.Size = New System.Drawing.Size(922, 523)
			Me.snapControl1.TabIndex = 0
			Me.snapControl1.Text = "snapControl1"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.commandBarItem2, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem21, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.commandBarItem3, Me.commandBarItem4, Me.commandBarItem5, Me.commandBarItem6, Me.commandBarItem7, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertPageBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.changePageColorItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.snapBarToolbarsListItem1, Me.commandBarCheckItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleFieldHighlightingItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToNextHeaderFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.toggleFirstRowItem1, Me.toggleLastRowItem1, Me.toggleBandedRowsItem1, Me.toggleFirstColumnItem1, Me.toggleLastColumnItem1, Me.toggleBandedColumnItem1, Me.galleryChangeTableStyleItem1, Me.galleryChangeTableCellStyleItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableCellsShadingItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.showTableOptionsFormItem1, Me.checkSpellingItem1, Me.insertTableOfContentsItem1, Me.updateTableOfContentsItem1, Me.addParagraphsToTableOfContentItem1, Me.setParagraphHeadingLevelItem1, Me.setParagraphHeadingLevelItem2, Me.setParagraphHeadingLevelItem3, Me.setParagraphHeadingLevelItem4, Me.setParagraphHeadingLevelItem5, Me.setParagraphHeadingLevelItem6, Me.setParagraphHeadingLevelItem7, Me.setParagraphHeadingLevelItem8, Me.setParagraphHeadingLevelItem9, Me.setParagraphHeadingLevelItem10, Me.insertCaptionPlaceholderItem1, Me.insertFiguresCaptionItems1, Me.insertTablesCaptionItems1, Me.insertEquationsCaptionItems1, Me.insertTableOfFiguresPlaceholderItem1, Me.insertTableOfFiguresItems1, Me.insertTableOfTablesItems1, Me.insertTableOfEquationsItems1, Me.updateTableOfFiguresItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1, Me.themesGalleryBarItem1, Me.commandBarCheckItem2, Me.commandBarCheckItem3, Me.commandBarCheckItem4, Me.commandBarSubItem1, Me.commandBarCheckItem5, Me.commandBarCheckItem6, Me.commandBarCheckItem7, Me.commandBarCheckItem8, Me.commandBarCheckItem9, Me.filterPopupButtonItem1, Me.propertiesBarButtonItem1, Me.commandBarSubItem2, Me.commandBarCheckItem10, Me.commandBarCheckItem11, Me.commandBarSubItem3, Me.commandBarCheckItem12, Me.commandBarCheckItem13, Me.commandBarItem8, Me.commandBarItem9, Me.commandBarSubItem4, Me.commandBarCheckItem14, Me.commandBarCheckItem15, Me.commandBarCheckItem16, Me.commandBarCheckItem17, Me.commandBarCheckItem18, Me.commandBarCheckItem19, Me.commandBarCheckItem20, Me.commandBarSubItem5, Me.commandBarCheckItem21, Me.commandBarCheckItem22, Me.commandBarSubItem6, Me.commandBarCheckItem23, Me.commandBarCheckItem24, Me.commandBarSubItem7, Me.commandBarCheckItem25, Me.commandBarCheckItem26, Me.commandBarCheckItem27, Me.commandBarCheckItem28, Me.commandBarCheckItem29, Me.commandBarCheckItem30, Me.commandBarCheckItem31, Me.commandBarItem10, Me.commandBarItem11, Me.commandBarItem12, Me.barButtonGroup8, Me.changeEditorRowLimitItem1, Me.createBarBaseItem1, Me.createLineBaseItem1, Me.createPieBaseItem1, Me.createRotatedBarBaseItem1, Me.createAreaBaseItem1, Me.createOtherSeriesTypesBaseItem1, Me.changePaletteGalleryBaseItem1, Me.changeAppearanceGalleryBaseItem1, Me.runWizardChartItem1, Me.mailMergeDataSourceItem1, Me.commandBarCheckItem32, Me.commandBarCheckItem33, Me.mailMergeCurrentRecordItem1, Me.commandBarSubItem8, Me.commandBarItem13, Me.commandBarItem14, Me.commandBarItem15, Me.runDesignerChartItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 617
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.headerFooterToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.floatingPictureToolsRibbonPageCategory1, Me.dataToolsRibbonPageCategory1, Me.chartRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.viewRibbonPage1, Me.reviewRibbonPage1, Me.referencesRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1, Me.repositoryItemEditorRowLimitEdit1, Me.repositoryItemMailMergeCurrentRecordEdit1, Me.repositoryItemFontEdit2, Me.repositoryItemRichEditFontSizeEdit2, Me.repositoryItemBorderLineStyle2, Me.repositoryItemBorderLineWeight2, Me.repositoryItemFloatingObjectOutlineWeight2, Me.repositoryItemEditorRowLimitEdit2, Me.repositoryItemMailMergeCurrentRecordEdit2})
			Me.ribbonControl1.Size = New System.Drawing.Size(1122, 141)
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Id = 314
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Id = 315
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Id = 316
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Id = 317
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' commandBarItem1
			' 
			Me.commandBarItem1.Id = 318
			Me.commandBarItem1.Name = "commandBarItem1"
			Me.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Id = 319
			Me.quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Id = 320
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Id = 321
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' undoItem1
			' 
			Me.undoItem1.Id = 322
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Id = 323
			Me.redoItem1.Name = "redoItem1"
			' 
			' commandBarItem2
			' 
			Me.commandBarItem2.Id = 324
			Me.commandBarItem2.Name = "commandBarItem2"
			Me.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource
			' 
			' pasteItem1
			' 
			Me.pasteItem1.Id = 332
			Me.pasteItem1.Name = "pasteItem1"
			' 
			' cutItem1
			' 
			Me.cutItem1.Id = 333
			Me.cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			Me.copyItem1.Id = 334
			Me.copyItem1.Name = "copyItem1"
			' 
			' pasteSpecialItem1
			' 
			Me.pasteSpecialItem1.Id = 335
			Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
			' 
			' barButtonGroup1
			' 
			Me.barButtonGroup1.Id = 325
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
			Me.barButtonGroup1.Name = "barButtonGroup1"
			Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit2
			Me.changeFontNameItem1.EditWidth = 130
			Me.changeFontNameItem1.Id = 336
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			' 
			' repositoryItemFontEdit2
			' 
			Me.repositoryItemFontEdit2.AutoHeight = False
			Me.repositoryItemFontEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit2
			Me.changeFontSizeItem1.Id = 337
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' repositoryItemRichEditFontSizeEdit2
			' 
			Me.repositoryItemRichEditFontSizeEdit2.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit2.Control = Me.snapControl1
			Me.repositoryItemRichEditFontSizeEdit2.Name = "repositoryItemRichEditFontSizeEdit2"
			' 
			' fontSizeIncreaseItem1
			' 
			Me.fontSizeIncreaseItem1.Id = 338
			Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
			' 
			' fontSizeDecreaseItem1
			' 
			Me.fontSizeDecreaseItem1.Id = 339
			Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
			' 
			' barButtonGroup2
			' 
			Me.barButtonGroup2.Id = 326
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
			Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
			Me.barButtonGroup2.Name = "barButtonGroup2"
			Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
			' 
			' toggleFontBoldItem1
			' 
			Me.toggleFontBoldItem1.Id = 340
			Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
			' 
			' toggleFontItalicItem1
			' 
			Me.toggleFontItalicItem1.Id = 341
			Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
			' 
			' toggleFontUnderlineItem1
			' 
			Me.toggleFontUnderlineItem1.Id = 342
			Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
			' 
			' toggleFontDoubleUnderlineItem1
			' 
			Me.toggleFontDoubleUnderlineItem1.Id = 343
			Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
			' 
			' toggleFontStrikeoutItem1
			' 
			Me.toggleFontStrikeoutItem1.Id = 344
			Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
			' 
			' toggleFontDoubleStrikeoutItem1
			' 
			Me.toggleFontDoubleStrikeoutItem1.Id = 345
			Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
			' 
			' toggleFontSuperscriptItem1
			' 
			Me.toggleFontSuperscriptItem1.Id = 346
			Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
			' 
			' toggleFontSubscriptItem1
			' 
			Me.toggleFontSubscriptItem1.Id = 347
			Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
			' 
			' barButtonGroup3
			' 
			Me.barButtonGroup3.Id = 327
			Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
			Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
			Me.barButtonGroup3.Name = "barButtonGroup3"
			Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Id = 348
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' changeFontBackColorItem1
			' 
			Me.changeFontBackColorItem1.Id = 349
			Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
			' 
			' changeTextCaseItem1
			' 
			Me.changeTextCaseItem1.Id = 350
			Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
			Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
			' 
			' makeTextUpperCaseItem1
			' 
			Me.makeTextUpperCaseItem1.Id = 351
			Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
			' 
			' makeTextLowerCaseItem1
			' 
			Me.makeTextLowerCaseItem1.Id = 352
			Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
			' 
			' capitalizeEachWordCaseItem1
			' 
			Me.capitalizeEachWordCaseItem1.Id = 353
			Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
			' 
			' toggleTextCaseItem1
			' 
			Me.toggleTextCaseItem1.Id = 354
			Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
			' 
			' clearFormattingItem1
			' 
			Me.clearFormattingItem1.Id = 355
			Me.clearFormattingItem1.Name = "clearFormattingItem1"
			' 
			' barButtonGroup4
			' 
			Me.barButtonGroup4.Id = 328
			Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
			Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
			Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
			Me.barButtonGroup4.Name = "barButtonGroup4"
			Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
			' 
			' toggleBulletedListItem1
			' 
			Me.toggleBulletedListItem1.Id = 356
			Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
			' 
			' toggleNumberingListItem1
			' 
			Me.toggleNumberingListItem1.Id = 357
			Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
			' 
			' toggleMultiLevelListItem1
			' 
			Me.toggleMultiLevelListItem1.Id = 358
			Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
			' 
			' barButtonGroup5
			' 
			Me.barButtonGroup5.Id = 329
			Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
			Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
			Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
			Me.barButtonGroup5.Name = "barButtonGroup5"
			Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
			' 
			' decreaseIndentItem1
			' 
			Me.decreaseIndentItem1.Id = 359
			Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
			' 
			' increaseIndentItem1
			' 
			Me.increaseIndentItem1.Id = 360
			Me.increaseIndentItem1.Name = "increaseIndentItem1"
			' 
			' toggleShowWhitespaceItem1
			' 
			Me.toggleShowWhitespaceItem1.Id = 365
			Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
			' 
			' barButtonGroup6
			' 
			Me.barButtonGroup6.Id = 330
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
			Me.barButtonGroup6.Name = "barButtonGroup6"
			Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
			' 
			' toggleParagraphAlignmentLeftItem1
			' 
			Me.toggleParagraphAlignmentLeftItem1.Id = 361
			Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
			' 
			' toggleParagraphAlignmentCenterItem1
			' 
			Me.toggleParagraphAlignmentCenterItem1.Id = 362
			Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
			' 
			' toggleParagraphAlignmentRightItem1
			' 
			Me.toggleParagraphAlignmentRightItem1.Id = 363
			Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
			' 
			' toggleParagraphAlignmentJustifyItem1
			' 
			Me.toggleParagraphAlignmentJustifyItem1.Id = 364
			Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
			' 
			' barButtonGroup7
			' 
			Me.barButtonGroup7.Id = 331
			Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
			Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
			Me.barButtonGroup7.Name = "barButtonGroup7"
			Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
			' 
			' changeParagraphLineSpacingItem1
			' 
			Me.changeParagraphLineSpacingItem1.Id = 366
			Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
			Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
			' 
			' setSingleParagraphSpacingItem1
			' 
			Me.setSingleParagraphSpacingItem1.Id = 367
			Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
			' 
			' setSesquialteralParagraphSpacingItem1
			' 
			Me.setSesquialteralParagraphSpacingItem1.Id = 368
			Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
			' 
			' setDoubleParagraphSpacingItem1
			' 
			Me.setDoubleParagraphSpacingItem1.Id = 369
			Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
			' 
			' showLineSpacingFormItem1
			' 
			Me.showLineSpacingFormItem1.Id = 370
			Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
			' 
			' addSpacingBeforeParagraphItem1
			' 
			Me.addSpacingBeforeParagraphItem1.Id = 371
			Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
			' 
			' removeSpacingBeforeParagraphItem1
			' 
			Me.removeSpacingBeforeParagraphItem1.Id = 372
			Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
			' 
			' addSpacingAfterParagraphItem1
			' 
			Me.addSpacingAfterParagraphItem1.Id = 373
			Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
			' 
			' removeSpacingAfterParagraphItem1
			' 
			Me.removeSpacingAfterParagraphItem1.Id = 374
			Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
			' 
			' changeParagraphBackColorItem1
			' 
			Me.changeParagraphBackColorItem1.Id = 375
			Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
			' 
			' findItem1
			' 
			Me.findItem1.Id = 377
			Me.findItem1.Name = "findItem1"
			' 
			' replaceItem1
			' 
			Me.replaceItem1.Id = 378
			Me.replaceItem1.Name = "replaceItem1"
			' 
			' insertPageBreakItem21
			' 
			Me.insertPageBreakItem21.Id = 379
			Me.insertPageBreakItem21.Name = "insertPageBreakItem21"
			' 
			' insertTableItem1
			' 
			Me.insertTableItem1.Id = 380
			Me.insertTableItem1.Name = "insertTableItem1"
			' 
			' insertPictureItem1
			' 
			Me.insertPictureItem1.Id = 381
			Me.insertPictureItem1.Name = "insertPictureItem1"
			' 
			' insertFloatingPictureItem1
			' 
			Me.insertFloatingPictureItem1.Id = 382
			Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
			' 
			' commandBarItem3
			' 
			Me.commandBarItem3.Id = 383
			Me.commandBarItem3.Name = "commandBarItem3"
			Me.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode
			' 
			' commandBarItem4
			' 
			Me.commandBarItem4.Id = 384
			Me.commandBarItem4.Name = "commandBarItem4"
			Me.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox
			' 
			' commandBarItem5
			' 
			Me.commandBarItem5.Id = 385
			Me.commandBarItem5.Name = "commandBarItem5"
			Me.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart
			' 
			' commandBarItem6
			' 
			Me.commandBarItem6.Id = 386
			Me.commandBarItem6.Name = "commandBarItem6"
			Me.commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSparkline
			' 
			' commandBarItem7
			' 
			Me.commandBarItem7.Id = 387
			Me.commandBarItem7.Name = "commandBarItem7"
			Me.commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertIndex
			' 
			' insertBookmarkItem1
			' 
			Me.insertBookmarkItem1.Id = 388
			Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
			' 
			' insertHyperlinkItem1
			' 
			Me.insertHyperlinkItem1.Id = 389
			Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
			' 
			' editPageHeaderItem1
			' 
			Me.editPageHeaderItem1.Id = 390
			Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
			' 
			' editPageFooterItem1
			' 
			Me.editPageFooterItem1.Id = 391
			Me.editPageFooterItem1.Name = "editPageFooterItem1"
			' 
			' insertPageNumberItem1
			' 
			Me.insertPageNumberItem1.Id = 392
			Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
			' 
			' insertPageCountItem1
			' 
			Me.insertPageCountItem1.Id = 393
			Me.insertPageCountItem1.Name = "insertPageCountItem1"
			' 
			' insertTextBoxItem1
			' 
			Me.insertTextBoxItem1.Id = 394
			Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
			' 
			' insertSymbolItem1
			' 
			Me.insertSymbolItem1.Id = 395
			Me.insertSymbolItem1.Name = "insertSymbolItem1"
			' 
			' changeSectionPageMarginsItem1
			' 
			Me.changeSectionPageMarginsItem1.Id = 396
			Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1, True)})
			Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
			' 
			' setNormalSectionPageMarginsItem1
			' 
			Me.setNormalSectionPageMarginsItem1.Id = 397
			Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
			' 
			' setNarrowSectionPageMarginsItem1
			' 
			Me.setNarrowSectionPageMarginsItem1.Id = 398
			Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
			' 
			' setModerateSectionPageMarginsItem1
			' 
			Me.setModerateSectionPageMarginsItem1.Id = 399
			Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
			' 
			' setWideSectionPageMarginsItem1
			' 
			Me.setWideSectionPageMarginsItem1.Id = 400
			Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
			' 
			' showPageMarginsSetupFormItem1
			' 
			Me.showPageMarginsSetupFormItem1.Id = 401
			Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
			' 
			' changeSectionPageOrientationItem1
			' 
			Me.changeSectionPageOrientationItem1.Id = 402
			Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1)})
			Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
			' 
			' setPortraitPageOrientationItem1
			' 
			Me.setPortraitPageOrientationItem1.Id = 403
			Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
			' 
			' setLandscapePageOrientationItem1
			' 
			Me.setLandscapePageOrientationItem1.Id = 404
			Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
			' 
			' changeSectionPaperKindItem1
			' 
			Me.changeSectionPaperKindItem1.Id = 405
			Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
			' 
			' changeSectionColumnsItem1
			' 
			Me.changeSectionColumnsItem1.Id = 406
			Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1, True)})
			Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
			' 
			' setSectionOneColumnItem1
			' 
			Me.setSectionOneColumnItem1.Id = 407
			Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
			' 
			' setSectionTwoColumnsItem1
			' 
			Me.setSectionTwoColumnsItem1.Id = 408
			Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
			' 
			' setSectionThreeColumnsItem1
			' 
			Me.setSectionThreeColumnsItem1.Id = 409
			Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
			' 
			' showColumnsSetupFormItem1
			' 
			Me.showColumnsSetupFormItem1.Id = 410
			Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
			' 
			' insertBreakItem1
			' 
			Me.insertBreakItem1.Id = 411
			Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1)})
			Me.insertBreakItem1.Name = "insertBreakItem1"
			' 
			' insertPageBreakItem1
			' 
			Me.insertPageBreakItem1.Id = 412
			Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
			' 
			' insertColumnBreakItem1
			' 
			Me.insertColumnBreakItem1.Id = 413
			Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
			' 
			' insertSectionBreakNextPageItem1
			' 
			Me.insertSectionBreakNextPageItem1.Id = 414
			Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
			' 
			' insertSectionBreakEvenPageItem1
			' 
			Me.insertSectionBreakEvenPageItem1.Id = 415
			Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
			' 
			' insertSectionBreakOddPageItem1
			' 
			Me.insertSectionBreakOddPageItem1.Id = 416
			Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
			' 
			' changeSectionLineNumberingItem1
			' 
			Me.changeSectionLineNumberingItem1.Id = 417
			Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1, True)})
			Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
			' 
			' setSectionLineNumberingNoneItem1
			' 
			Me.setSectionLineNumberingNoneItem1.Id = 418
			Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
			' 
			' setSectionLineNumberingContinuousItem1
			' 
			Me.setSectionLineNumberingContinuousItem1.Id = 419
			Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
			' 
			' setSectionLineNumberingRestartNewPageItem1
			' 
			Me.setSectionLineNumberingRestartNewPageItem1.Id = 420
			Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
			' 
			' setSectionLineNumberingRestartNewSectionItem1
			' 
			Me.setSectionLineNumberingRestartNewSectionItem1.Id = 421
			Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
			' 
			' toggleParagraphSuppressLineNumbersItem1
			' 
			Me.toggleParagraphSuppressLineNumbersItem1.Id = 422
			Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
			' 
			' showLineNumberingFormItem1
			' 
			Me.showLineNumberingFormItem1.Id = 423
			Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
			' 
			' changePageColorItem1
			' 
			Me.changePageColorItem1.Id = 424
			Me.changePageColorItem1.Name = "changePageColorItem1"
			' 
			' switchToSimpleViewItem1
			' 
			Me.switchToSimpleViewItem1.Id = 425
			Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
			' 
			' switchToDraftViewItem1
			' 
			Me.switchToDraftViewItem1.Id = 426
			Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
			' 
			' switchToPrintLayoutViewItem1
			' 
			Me.switchToPrintLayoutViewItem1.Id = 427
			Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
			' 
			' toggleShowHorizontalRulerItem1
			' 
			Me.toggleShowHorizontalRulerItem1.Id = 428
			Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
			' 
			' toggleShowVerticalRulerItem1
			' 
			Me.toggleShowVerticalRulerItem1.Id = 429
			Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
			' 
			' zoomOutItem1
			' 
			Me.zoomOutItem1.Id = 430
			Me.zoomOutItem1.Name = "zoomOutItem1"
			' 
			' zoomInItem1
			' 
			Me.zoomInItem1.Id = 431
			Me.zoomInItem1.Name = "zoomInItem1"
			' 
			' snapBarToolbarsListItem1
			' 
			Me.snapBarToolbarsListItem1.Glyph = (CType(resources.GetObject("snapBarToolbarsListItem1.Glyph"), System.Drawing.Image))
			Me.snapBarToolbarsListItem1.Hint = "Show or hide the Data Explorer and Report Explorer windows."
			Me.snapBarToolbarsListItem1.Id = 432
			Me.snapBarToolbarsListItem1.LargeGlyph = (CType(resources.GetObject("snapBarToolbarsListItem1.LargeGlyph"), System.Drawing.Image))
			Me.snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1"
			Me.snapBarToolbarsListItem1.ShowCustomizationItem = False
			Me.snapBarToolbarsListItem1.ShowDockPanels = True
			Me.snapBarToolbarsListItem1.ShowToolbars = False
			' 
			' commandBarCheckItem1
			' 
			Me.commandBarCheckItem1.Id = 433
			Me.commandBarCheckItem1.Name = "commandBarCheckItem1"
			Me.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement
			' 
			' showAllFieldCodesItem1
			' 
			Me.showAllFieldCodesItem1.Id = 434
			Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
			' 
			' showAllFieldResultsItem1
			' 
			Me.showAllFieldResultsItem1.Id = 435
			Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
			' 
			' toggleFieldHighlightingItem1
			' 
			Me.toggleFieldHighlightingItem1.Glyph = (CType(resources.GetObject("toggleFieldHighlightingItem1.Glyph"), System.Drawing.Image))
			Me.toggleFieldHighlightingItem1.Id = 436
			Me.toggleFieldHighlightingItem1.LargeGlyph = (CType(resources.GetObject("toggleFieldHighlightingItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1"
			' 
			' goToPageHeaderItem1
			' 
			Me.goToPageHeaderItem1.Id = 437
			Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
			' 
			' goToPageFooterItem1
			' 
			Me.goToPageFooterItem1.Id = 438
			Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
			' 
			' goToNextHeaderFooterItem1
			' 
			Me.goToNextHeaderFooterItem1.Id = 439
			Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
			' 
			' goToPreviousHeaderFooterItem1
			' 
			Me.goToPreviousHeaderFooterItem1.Id = 440
			Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
			' 
			' toggleLinkToPreviousItem1
			' 
			Me.toggleLinkToPreviousItem1.Id = 441
			Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
			' 
			' toggleDifferentFirstPageItem1
			' 
			Me.toggleDifferentFirstPageItem1.Id = 442
			Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
			' 
			' toggleDifferentOddAndEvenPagesItem1
			' 
			Me.toggleDifferentOddAndEvenPagesItem1.Id = 443
			Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
			' 
			' closePageHeaderFooterItem1
			' 
			Me.closePageHeaderFooterItem1.Id = 444
			Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
			' 
			' toggleFirstRowItem1
			' 
			Me.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.toggleFirstRowItem1.Id = 445
			Me.toggleFirstRowItem1.Name = "toggleFirstRowItem1"
			' 
			' toggleLastRowItem1
			' 
			Me.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.toggleLastRowItem1.Id = 446
			Me.toggleLastRowItem1.Name = "toggleLastRowItem1"
			' 
			' toggleBandedRowsItem1
			' 
			Me.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.toggleBandedRowsItem1.Id = 447
			Me.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
			' 
			' toggleFirstColumnItem1
			' 
			Me.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.toggleFirstColumnItem1.Id = 448
			Me.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
			' 
			' toggleLastColumnItem1
			' 
			Me.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.toggleLastColumnItem1.Id = 449
			Me.toggleLastColumnItem1.Name = "toggleLastColumnItem1"
			' 
			' toggleBandedColumnItem1
			' 
			Me.toggleBandedColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.toggleBandedColumnItem1.Id = 450
			Me.toggleBandedColumnItem1.Name = "toggleBandedColumnItem1"
			' 
			' galleryChangeTableStyleItem1
			' 
			Me.galleryChangeTableStyleItem1.CurrentItem = Nothing
			Me.galleryChangeTableStyleItem1.CurrentItemStyle = Nothing
			Me.galleryChangeTableStyleItem1.CurrentStyle = Nothing
			Me.galleryChangeTableStyleItem1.DeleteItemLink = Nothing
			' 
			' 
			' 
			Me.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
			Me.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.galleryChangeTableStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryChangeTableStyleItem1.Id = 451
			Me.galleryChangeTableStyleItem1.ModifyItemLink = Nothing
			Me.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
			Me.galleryChangeTableStyleItem1.NewItemLink = Nothing
			Me.galleryChangeTableStyleItem1.PopupGallery = Nothing
			' 
			' galleryChangeTableCellStyleItem1
			' 
			Me.galleryChangeTableCellStyleItem1.CurrentCellStyle = Nothing
			Me.galleryChangeTableCellStyleItem1.CurrentItem = Nothing
			Me.galleryChangeTableCellStyleItem1.CurrentItemCellStyle = Nothing
			Me.galleryChangeTableCellStyleItem1.DeleteItemLink = Nothing
			' 
			' 
			' 
			Me.galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3
			Me.galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup3})
			Me.galleryChangeTableCellStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryChangeTableCellStyleItem1.Id = 452
			Me.galleryChangeTableCellStyleItem1.ModifyItemLink = Nothing
			Me.galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1"
			Me.galleryChangeTableCellStyleItem1.NewItemLink = Nothing
			Me.galleryChangeTableCellStyleItem1.PopupGallery = Nothing
			' 
			' changeTableBorderLineStyleItem1
			' 
			Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle2
			borderInfo1.Frame = False
			borderInfo1.Offset = 0
			borderInfo1.Shadow = False
			borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single
			borderInfo1.Width = 10
			Me.changeTableBorderLineStyleItem1.EditValue = borderInfo1
			Me.changeTableBorderLineStyleItem1.EditWidth = 130
			Me.changeTableBorderLineStyleItem1.Id = 453
			Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
			' 
			' repositoryItemBorderLineStyle2
			' 
			Me.repositoryItemBorderLineStyle2.AutoHeight = False
			Me.repositoryItemBorderLineStyle2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemBorderLineStyle2.Control = Me.snapControl1
			Me.repositoryItemBorderLineStyle2.Name = "repositoryItemBorderLineStyle2"
			' 
			' changeTableBorderLineWeightItem1
			' 
			Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight2
			Me.changeTableBorderLineWeightItem1.EditValue = 20
			Me.changeTableBorderLineWeightItem1.EditWidth = 130
			Me.changeTableBorderLineWeightItem1.Id = 454
			Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
			' 
			' repositoryItemBorderLineWeight2
			' 
			Me.repositoryItemBorderLineWeight2.AutoHeight = False
			Me.repositoryItemBorderLineWeight2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemBorderLineWeight2.Control = Me.snapControl1
			Me.repositoryItemBorderLineWeight2.Name = "repositoryItemBorderLineWeight2"
			' 
			' changeTableBorderColorItem1
			' 
			Me.changeTableBorderColorItem1.Id = 455
			Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
			' 
			' changeTableBordersItem1
			' 
			Me.changeTableBordersItem1.Id = 456
			Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1, True)})
			Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
			' 
			' toggleTableCellsBottomBorderItem1
			' 
			Me.toggleTableCellsBottomBorderItem1.Id = 457
			Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
			' 
			' toggleTableCellsTopBorderItem1
			' 
			Me.toggleTableCellsTopBorderItem1.Id = 458
			Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
			' 
			' toggleTableCellsLeftBorderItem1
			' 
			Me.toggleTableCellsLeftBorderItem1.Id = 459
			Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
			' 
			' toggleTableCellsRightBorderItem1
			' 
			Me.toggleTableCellsRightBorderItem1.Id = 460
			Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
			' 
			' resetTableCellsAllBordersItem1
			' 
			Me.resetTableCellsAllBordersItem1.Id = 461
			Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
			' 
			' toggleTableCellsAllBordersItem1
			' 
			Me.toggleTableCellsAllBordersItem1.Id = 462
			Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
			' 
			' toggleTableCellsOutsideBorderItem1
			' 
			Me.toggleTableCellsOutsideBorderItem1.Id = 463
			Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
			' 
			' toggleTableCellsInsideBorderItem1
			' 
			Me.toggleTableCellsInsideBorderItem1.Id = 464
			Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
			' 
			' toggleTableCellsInsideHorizontalBorderItem1
			' 
			Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 465
			Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
			' 
			' toggleTableCellsInsideVerticalBorderItem1
			' 
			Me.toggleTableCellsInsideVerticalBorderItem1.Id = 466
			Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
			' 
			' toggleShowTableGridLinesItem1
			' 
			Me.toggleShowTableGridLinesItem1.Id = 467
			Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
			' 
			' changeTableCellsShadingItem1
			' 
			Me.changeTableCellsShadingItem1.Id = 468
			Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
			' 
			' selectTableElementsItem1
			' 
			Me.selectTableElementsItem1.Id = 469
			Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)})
			Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
			' 
			' selectTableCellItem1
			' 
			Me.selectTableCellItem1.Id = 470
			Me.selectTableCellItem1.Name = "selectTableCellItem1"
			' 
			' selectTableColumnItem1
			' 
			Me.selectTableColumnItem1.Id = 471
			Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
			' 
			' selectTableRowItem1
			' 
			Me.selectTableRowItem1.Id = 472
			Me.selectTableRowItem1.Name = "selectTableRowItem1"
			' 
			' selectTableItem1
			' 
			Me.selectTableItem1.Id = 473
			Me.selectTableItem1.Name = "selectTableItem1"
			' 
			' showTablePropertiesFormItem1
			' 
			Me.showTablePropertiesFormItem1.Id = 474
			Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
			' 
			' deleteTableElementsItem1
			' 
			Me.deleteTableElementsItem1.Id = 475
			Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)})
			Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
			' 
			' showDeleteTableCellsFormItem1
			' 
			Me.showDeleteTableCellsFormItem1.Id = 476
			Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
			' 
			' deleteTableColumnsItem1
			' 
			Me.deleteTableColumnsItem1.Id = 477
			Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
			' 
			' deleteTableRowsItem1
			' 
			Me.deleteTableRowsItem1.Id = 478
			Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
			' 
			' deleteTableItem1
			' 
			Me.deleteTableItem1.Id = 479
			Me.deleteTableItem1.Name = "deleteTableItem1"
			' 
			' insertTableRowAboveItem1
			' 
			Me.insertTableRowAboveItem1.Id = 480
			Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
			' 
			' insertTableRowBelowItem1
			' 
			Me.insertTableRowBelowItem1.Id = 481
			Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
			' 
			' insertTableColumnToLeftItem1
			' 
			Me.insertTableColumnToLeftItem1.Id = 482
			Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
			' 
			' insertTableColumnToRightItem1
			' 
			Me.insertTableColumnToRightItem1.Id = 483
			Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
			' 
			' mergeTableCellsItem1
			' 
			Me.mergeTableCellsItem1.Id = 484
			Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
			' 
			' showSplitTableCellsForm1
			' 
			Me.showSplitTableCellsForm1.Id = 485
			Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
			' 
			' splitTableItem1
			' 
			Me.splitTableItem1.Id = 486
			Me.splitTableItem1.Name = "splitTableItem1"
			' 
			' toggleTableAutoFitItem1
			' 
			Me.toggleTableAutoFitItem1.Id = 487
			Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)})
			Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
			' 
			' toggleTableAutoFitContentsItem1
			' 
			Me.toggleTableAutoFitContentsItem1.Id = 488
			Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
			' 
			' toggleTableAutoFitWindowItem1
			' 
			Me.toggleTableAutoFitWindowItem1.Id = 489
			Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
			' 
			' toggleTableFixedColumnWidthItem1
			' 
			Me.toggleTableFixedColumnWidthItem1.Id = 490
			Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
			' 
			' toggleTableCellsTopLeftAlignmentItem1
			' 
			Me.toggleTableCellsTopLeftAlignmentItem1.Id = 491
			Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
			' 
			' toggleTableCellsMiddleLeftAlignmentItem1
			' 
			Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 492
			Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
			' 
			' toggleTableCellsBottomLeftAlignmentItem1
			' 
			Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 493
			Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
			' 
			' toggleTableCellsTopCenterAlignmentItem1
			' 
			Me.toggleTableCellsTopCenterAlignmentItem1.Id = 494
			Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
			' 
			' toggleTableCellsMiddleCenterAlignmentItem1
			' 
			Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 495
			Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
			' 
			' toggleTableCellsBottomCenterAlignmentItem1
			' 
			Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 496
			Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
			' 
			' toggleTableCellsTopRightAlignmentItem1
			' 
			Me.toggleTableCellsTopRightAlignmentItem1.Id = 497
			Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
			' 
			' toggleTableCellsMiddleRightAlignmentItem1
			' 
			Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 498
			Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
			' 
			' toggleTableCellsBottomRightAlignmentItem1
			' 
			Me.toggleTableCellsBottomRightAlignmentItem1.Id = 499
			Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
			' 
			' showTableOptionsFormItem1
			' 
			Me.showTableOptionsFormItem1.Id = 500
			Me.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
			' 
			' checkSpellingItem1
			' 
			Me.checkSpellingItem1.Id = 501
			Me.checkSpellingItem1.Name = "checkSpellingItem1"
			' 
			' insertTableOfContentsItem1
			' 
			Me.insertTableOfContentsItem1.Id = 502
			Me.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
			' 
			' updateTableOfContentsItem1
			' 
			Me.updateTableOfContentsItem1.Id = 503
			Me.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
			' 
			' addParagraphsToTableOfContentItem1
			' 
			Me.addParagraphsToTableOfContentItem1.Id = 504
			Me.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem10)})
			Me.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
			' 
			' setParagraphHeadingLevelItem1
			' 
			Me.setParagraphHeadingLevelItem1.Id = 505
			Me.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
			Me.setParagraphHeadingLevelItem1.OutlineLevel = 0
			' 
			' setParagraphHeadingLevelItem2
			' 
			Me.setParagraphHeadingLevelItem2.Id = 506
			Me.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
			Me.setParagraphHeadingLevelItem2.OutlineLevel = 1
			' 
			' setParagraphHeadingLevelItem3
			' 
			Me.setParagraphHeadingLevelItem3.Id = 507
			Me.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
			Me.setParagraphHeadingLevelItem3.OutlineLevel = 2
			' 
			' setParagraphHeadingLevelItem4
			' 
			Me.setParagraphHeadingLevelItem4.Id = 508
			Me.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
			Me.setParagraphHeadingLevelItem4.OutlineLevel = 3
			' 
			' setParagraphHeadingLevelItem5
			' 
			Me.setParagraphHeadingLevelItem5.Id = 509
			Me.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
			Me.setParagraphHeadingLevelItem5.OutlineLevel = 4
			' 
			' setParagraphHeadingLevelItem6
			' 
			Me.setParagraphHeadingLevelItem6.Id = 510
			Me.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
			Me.setParagraphHeadingLevelItem6.OutlineLevel = 5
			' 
			' setParagraphHeadingLevelItem7
			' 
			Me.setParagraphHeadingLevelItem7.Id = 511
			Me.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
			Me.setParagraphHeadingLevelItem7.OutlineLevel = 6
			' 
			' setParagraphHeadingLevelItem8
			' 
			Me.setParagraphHeadingLevelItem8.Id = 512
			Me.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
			Me.setParagraphHeadingLevelItem8.OutlineLevel = 7
			' 
			' setParagraphHeadingLevelItem9
			' 
			Me.setParagraphHeadingLevelItem9.Id = 513
			Me.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
			Me.setParagraphHeadingLevelItem9.OutlineLevel = 8
			' 
			' setParagraphHeadingLevelItem10
			' 
			Me.setParagraphHeadingLevelItem10.Id = 514
			Me.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
			Me.setParagraphHeadingLevelItem10.OutlineLevel = 9
			' 
			' insertCaptionPlaceholderItem1
			' 
			Me.insertCaptionPlaceholderItem1.Id = 515
			Me.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.insertFiguresCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTablesCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertEquationsCaptionItems1)})
			Me.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1"
			' 
			' insertFiguresCaptionItems1
			' 
			Me.insertFiguresCaptionItems1.Id = 516
			Me.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1"
			' 
			' insertTablesCaptionItems1
			' 
			Me.insertTablesCaptionItems1.Id = 517
			Me.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1"
			' 
			' insertEquationsCaptionItems1
			' 
			Me.insertEquationsCaptionItems1.Id = 518
			Me.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1"
			' 
			' insertTableOfFiguresPlaceholderItem1
			' 
			Me.insertTableOfFiguresPlaceholderItem1.Id = 519
			Me.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfFiguresItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfTablesItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfEquationsItems1)})
			Me.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1"
			' 
			' insertTableOfFiguresItems1
			' 
			Me.insertTableOfFiguresItems1.Id = 520
			Me.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1"
			' 
			' insertTableOfTablesItems1
			' 
			Me.insertTableOfTablesItems1.Id = 521
			Me.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1"
			' 
			' insertTableOfEquationsItems1
			' 
			Me.insertTableOfEquationsItems1.Id = 522
			Me.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1"
			' 
			' updateTableOfFiguresItem1
			' 
			Me.updateTableOfFiguresItem1.Id = 523
			Me.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1"
			' 
			' changeFloatingObjectFillColorItem1
			' 
			Me.changeFloatingObjectFillColorItem1.Id = 524
			Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
			' 
			' changeFloatingObjectOutlineColorItem1
			' 
			Me.changeFloatingObjectOutlineColorItem1.Id = 525
			Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
			' 
			' changeFloatingObjectOutlineWeightItem1
			' 
			Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight2
			Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
			Me.changeFloatingObjectOutlineWeightItem1.EditWidth = 130
			Me.changeFloatingObjectOutlineWeightItem1.Id = 526
			Me.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
			' 
			' repositoryItemFloatingObjectOutlineWeight2
			' 
			Me.repositoryItemFloatingObjectOutlineWeight2.AutoHeight = False
			Me.repositoryItemFloatingObjectOutlineWeight2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFloatingObjectOutlineWeight2.Control = Me.snapControl1
			Me.repositoryItemFloatingObjectOutlineWeight2.Name = "repositoryItemFloatingObjectOutlineWeight2"
			' 
			' changeFloatingObjectTextWrapTypeItem1
			' 
			Me.changeFloatingObjectTextWrapTypeItem1.Id = 527
			Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)})
			Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
			' 
			' setFloatingObjectSquareTextWrapTypeItem1
			' 
			Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 528
			Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
			' 
			' setFloatingObjectTightTextWrapTypeItem1
			' 
			Me.setFloatingObjectTightTextWrapTypeItem1.Id = 529
			Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
			' 
			' setFloatingObjectThroughTextWrapTypeItem1
			' 
			Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 530
			Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
			' 
			' setFloatingObjectTopAndBottomTextWrapTypeItem1
			' 
			Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 531
			Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
			' 
			' setFloatingObjectBehindTextWrapTypeItem1
			' 
			Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 532
			Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
			' 
			' setFloatingObjectInFrontOfTextWrapTypeItem1
			' 
			Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 533
			Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
			' 
			' changeFloatingObjectAlignmentItem1
			' 
			Me.changeFloatingObjectAlignmentItem1.Id = 534
			Me.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomRightAlignmentItem1)})
			Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
			' 
			' setFloatingObjectTopLeftAlignmentItem1
			' 
			Me.setFloatingObjectTopLeftAlignmentItem1.Id = 535
			Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
			' 
			' setFloatingObjectTopCenterAlignmentItem1
			' 
			Me.setFloatingObjectTopCenterAlignmentItem1.Id = 536
			Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
			' 
			' setFloatingObjectTopRightAlignmentItem1
			' 
			Me.setFloatingObjectTopRightAlignmentItem1.Id = 537
			Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
			' 
			' setFloatingObjectMiddleLeftAlignmentItem1
			' 
			Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 538
			Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
			' 
			' setFloatingObjectMiddleCenterAlignmentItem1
			' 
			Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 539
			Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
			' 
			' setFloatingObjectMiddleRightAlignmentItem1
			' 
			Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 540
			Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
			' 
			' setFloatingObjectBottomLeftAlignmentItem1
			' 
			Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 541
			Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
			' 
			' setFloatingObjectBottomCenterAlignmentItem1
			' 
			Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 542
			Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
			' 
			' setFloatingObjectBottomRightAlignmentItem1
			' 
			Me.setFloatingObjectBottomRightAlignmentItem1.Id = 543
			Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
			' 
			' floatingObjectBringForwardSubItem1
			' 
			Me.floatingObjectBringForwardSubItem1.Id = 544
			Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1)})
			Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
			' 
			' floatingObjectBringForwardItem1
			' 
			Me.floatingObjectBringForwardItem1.Id = 545
			Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
			' 
			' floatingObjectBringToFrontItem1
			' 
			Me.floatingObjectBringToFrontItem1.Id = 546
			Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
			' 
			' floatingObjectBringInFrontOfTextItem1
			' 
			Me.floatingObjectBringInFrontOfTextItem1.Id = 547
			Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
			' 
			' floatingObjectSendBackwardSubItem1
			' 
			Me.floatingObjectSendBackwardSubItem1.Id = 548
			Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1)})
			Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
			' 
			' floatingObjectSendBackwardItem1
			' 
			Me.floatingObjectSendBackwardItem1.Id = 549
			Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
			' 
			' floatingObjectSendToBackItem1
			' 
			Me.floatingObjectSendToBackItem1.Id = 550
			Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
			' 
			' floatingObjectSendBehindTextItem1
			' 
			Me.floatingObjectSendBehindTextItem1.Id = 551
			Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
			' 
			' themesGalleryBarItem1
			' 
			' 
			' 
			' 
			Me.themesGalleryBarItem1.Gallery.ColumnCount = 7
			Me.themesGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.themesGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
			Me.themesGalleryBarItem1.Gallery.RowCount = 1
			Me.themesGalleryBarItem1.Id = 552
			Me.themesGalleryBarItem1.Name = "themesGalleryBarItem1"
			' 
			' commandBarCheckItem2
			' 
			Me.commandBarCheckItem2.Id = 553
			Me.commandBarCheckItem2.Name = "commandBarCheckItem2"
			Me.commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField
			' 
			' commandBarCheckItem3
			' 
			Me.commandBarCheckItem3.Id = 554
			Me.commandBarCheckItem3.Name = "commandBarCheckItem3"
			Me.commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending
			' 
			' commandBarCheckItem4
			' 
			Me.commandBarCheckItem4.Id = 555
			Me.commandBarCheckItem4.Name = "commandBarCheckItem4"
			Me.commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending
			' 
			' commandBarSubItem1
			' 
			Me.commandBarSubItem1.Id = 556
			Me.commandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem9)})
			Me.commandBarSubItem1.Name = "commandBarSubItem1"
			Me.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField
			' 
			' commandBarCheckItem5
			' 
			Me.commandBarCheckItem5.Id = 557
			Me.commandBarCheckItem5.Name = "commandBarCheckItem5"
			Me.commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount
			' 
			' commandBarCheckItem6
			' 
			Me.commandBarCheckItem6.Id = 558
			Me.commandBarCheckItem6.Name = "commandBarCheckItem6"
			Me.commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum
			' 
			' commandBarCheckItem7
			' 
			Me.commandBarCheckItem7.Id = 559
			Me.commandBarCheckItem7.Name = "commandBarCheckItem7"
			Me.commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage
			' 
			' commandBarCheckItem8
			' 
			Me.commandBarCheckItem8.Id = 560
			Me.commandBarCheckItem8.Name = "commandBarCheckItem8"
			Me.commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax
			' 
			' commandBarCheckItem9
			' 
			Me.commandBarCheckItem9.Id = 561
			Me.commandBarCheckItem9.Name = "commandBarCheckItem9"
			Me.commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin
			' 
			' filterPopupButtonItem1
			' 
			Me.filterPopupButtonItem1.ActAsDropDown = True
			Me.filterPopupButtonItem1.Id = 562
			Me.filterPopupButtonItem1.Name = "filterPopupButtonItem1"
			' 
			' propertiesBarButtonItem1
			' 
			Me.propertiesBarButtonItem1.ActAsDropDown = True
			Me.propertiesBarButtonItem1.Id = 563
			Me.propertiesBarButtonItem1.Name = "propertiesBarButtonItem1"
			Me.propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' commandBarSubItem2
			' 
			Me.commandBarSubItem2.Id = 564
			Me.commandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem11)})
			Me.commandBarSubItem2.Name = "commandBarSubItem2"
			Me.commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader
			' 
			' commandBarCheckItem10
			' 
			Me.commandBarCheckItem10.Id = 565
			Me.commandBarCheckItem10.Name = "commandBarCheckItem10"
			Me.commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader
			' 
			' commandBarCheckItem11
			' 
			Me.commandBarCheckItem11.Id = 566
			Me.commandBarCheckItem11.Name = "commandBarCheckItem11"
			Me.commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader
			' 
			' commandBarSubItem3
			' 
			Me.commandBarSubItem3.Id = 567
			Me.commandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem13)})
			Me.commandBarSubItem3.Name = "commandBarSubItem3"
			Me.commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter
			' 
			' commandBarCheckItem12
			' 
			Me.commandBarCheckItem12.Id = 568
			Me.commandBarCheckItem12.Name = "commandBarCheckItem12"
			Me.commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter
			' 
			' commandBarCheckItem13
			' 
			Me.commandBarCheckItem13.Id = 569
			Me.commandBarCheckItem13.Name = "commandBarCheckItem13"
			Me.commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter
			' 
			' commandBarItem8
			' 
			Me.commandBarItem8.Id = 570
			Me.commandBarItem8.Name = "commandBarItem8"
			Me.commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection
			' 
			' commandBarItem9
			' 
			Me.commandBarItem9.Id = 571
			Me.commandBarItem9.Name = "commandBarItem9"
			Me.commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm
			' 
			' commandBarSubItem4
			' 
			Me.commandBarSubItem4.Id = 572
			Me.commandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem20)})
			Me.commandBarSubItem4.Name = "commandBarSubItem4"
			Me.commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator
			' 
			' commandBarCheckItem14
			' 
			Me.commandBarCheckItem14.Id = 573
			Me.commandBarCheckItem14.Name = "commandBarCheckItem14"
			Me.commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator
			' 
			' commandBarCheckItem15
			' 
			Me.commandBarCheckItem15.Id = 574
			Me.commandBarCheckItem15.Name = "commandBarCheckItem15"
			Me.commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator
			' 
			' commandBarCheckItem16
			' 
			Me.commandBarCheckItem16.Id = 575
			Me.commandBarCheckItem16.Name = "commandBarCheckItem16"
			Me.commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator
			' 
			' commandBarCheckItem17
			' 
			Me.commandBarCheckItem17.Id = 576
			Me.commandBarCheckItem17.Name = "commandBarCheckItem17"
			Me.commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator
			' 
			' commandBarCheckItem18
			' 
			Me.commandBarCheckItem18.Id = 577
			Me.commandBarCheckItem18.Name = "commandBarCheckItem18"
			Me.commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator
			' 
			' commandBarCheckItem19
			' 
			Me.commandBarCheckItem19.Id = 578
			Me.commandBarCheckItem19.Name = "commandBarCheckItem19"
			Me.commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator
			' 
			' commandBarCheckItem20
			' 
			Me.commandBarCheckItem20.Id = 579
			Me.commandBarCheckItem20.Name = "commandBarCheckItem20"
			Me.commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator
			' 
			' commandBarSubItem5
			' 
			Me.commandBarSubItem5.Id = 581
			Me.commandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem22)})
			Me.commandBarSubItem5.Name = "commandBarSubItem5"
			Me.commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader
			' 
			' commandBarCheckItem21
			' 
			Me.commandBarCheckItem21.Id = 582
			Me.commandBarCheckItem21.Name = "commandBarCheckItem21"
			Me.commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader
			' 
			' commandBarCheckItem22
			' 
			Me.commandBarCheckItem22.Id = 583
			Me.commandBarCheckItem22.Name = "commandBarCheckItem22"
			Me.commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader
			' 
			' commandBarSubItem6
			' 
			Me.commandBarSubItem6.Id = 584
			Me.commandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem24)})
			Me.commandBarSubItem6.Name = "commandBarSubItem6"
			Me.commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter
			' 
			' commandBarCheckItem23
			' 
			Me.commandBarCheckItem23.Id = 585
			Me.commandBarCheckItem23.Name = "commandBarCheckItem23"
			Me.commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter
			' 
			' commandBarCheckItem24
			' 
			Me.commandBarCheckItem24.Id = 586
			Me.commandBarCheckItem24.Name = "commandBarCheckItem24"
			Me.commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter
			' 
			' commandBarSubItem7
			' 
			Me.commandBarSubItem7.Id = 587
			Me.commandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem31)})
			Me.commandBarSubItem7.Name = "commandBarSubItem7"
			Me.commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator
			' 
			' commandBarCheckItem25
			' 
			Me.commandBarCheckItem25.Id = 588
			Me.commandBarCheckItem25.Name = "commandBarCheckItem25"
			Me.commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator
			' 
			' commandBarCheckItem26
			' 
			Me.commandBarCheckItem26.Id = 589
			Me.commandBarCheckItem26.Name = "commandBarCheckItem26"
			Me.commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator
			' 
			' commandBarCheckItem27
			' 
			Me.commandBarCheckItem27.Id = 590
			Me.commandBarCheckItem27.Name = "commandBarCheckItem27"
			Me.commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator
			' 
			' commandBarCheckItem28
			' 
			Me.commandBarCheckItem28.Id = 591
			Me.commandBarCheckItem28.Name = "commandBarCheckItem28"
			Me.commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator
			' 
			' commandBarCheckItem29
			' 
			Me.commandBarCheckItem29.Id = 592
			Me.commandBarCheckItem29.Name = "commandBarCheckItem29"
			Me.commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator
			' 
			' commandBarCheckItem30
			' 
			Me.commandBarCheckItem30.Id = 593
			Me.commandBarCheckItem30.Name = "commandBarCheckItem30"
			Me.commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator
			' 
			' commandBarCheckItem31
			' 
			Me.commandBarCheckItem31.Id = 594
			Me.commandBarCheckItem31.Name = "commandBarCheckItem31"
			Me.commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator
			' 
			' commandBarItem10
			' 
			Me.commandBarItem10.Id = 595
			Me.commandBarItem10.Name = "commandBarItem10"
			Me.commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList
			' 
			' commandBarItem11
			' 
			Me.commandBarItem11.Id = 596
			Me.commandBarItem11.Name = "commandBarItem11"
			Me.commandBarItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs
			' 
			' commandBarItem12
			' 
			Me.commandBarItem12.Id = 597
			Me.commandBarItem12.Name = "commandBarItem12"
			Me.commandBarItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList
			' 
			' barButtonGroup8
			' 
			Me.barButtonGroup8.Id = 580
			Me.barButtonGroup8.ItemLinks.Add(Me.changeEditorRowLimitItem1)
			Me.barButtonGroup8.Name = "barButtonGroup8"
			Me.barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
			' 
			' changeEditorRowLimitItem1
			' 
			Me.changeEditorRowLimitItem1.Edit = Me.repositoryItemEditorRowLimitEdit2
			Me.changeEditorRowLimitItem1.EditWidth = 90
			Me.changeEditorRowLimitItem1.Id = 598
			Me.changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1"
			' 
			' repositoryItemEditorRowLimitEdit2
			' 
			Me.repositoryItemEditorRowLimitEdit2.AutoHeight = False
			Me.repositoryItemEditorRowLimitEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemEditorRowLimitEdit2.Control = Me.snapControl1
			Me.repositoryItemEditorRowLimitEdit2.Name = "repositoryItemEditorRowLimitEdit2"
			' 
			' createBarBaseItem1
			' 
			Me.createBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown36
			Me.createBarBaseItem1.Id = 599
			Me.createBarBaseItem1.Name = "createBarBaseItem1"
			' 
			' commandBarGalleryDropDown36
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown36.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown36.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem1, createFullStackedBarChartItem1, createSideBySideFullStackedBarChartItem1, createSideBySideStackedBarChartItem1, createStackedBarChartItem1})
			chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem1, createFullStackedBar3DChartItem1, createManhattanBarChartItem1, createSideBySideFullStackedBar3DChartItem1, createSideBySideStackedBar3DChartItem1, createStackedBar3DChartItem1})
			chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem1, createCylinderFullStackedBar3DChartItem1, createCylinderManhattanBarChartItem1, createCylinderSideBySideFullStackedBar3DChartItem1, createCylinderSideBySideStackedBar3DChartItem1, createCylinderStackedBar3DChartItem1})
			chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem1, createConeFullStackedBar3DChartItem1, createConeManhattanBarChartItem1, createConeSideBySideFullStackedBar3DChartItem1, createConeSideBySideStackedBar3DChartItem1, createConeStackedBar3DChartItem1})
			chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem1, createPyramidFullStackedBar3DChartItem1, createPyramidManhattanBarChartItem1, createPyramidSideBySideFullStackedBar3DChartItem1, createPyramidSideBySideStackedBar3DChartItem1, createPyramidStackedBar3DChartItem1})
			Me.commandBarGalleryDropDown36.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn1, chartControlCommandGalleryItemGroup3DColumn1, chartControlCommandGalleryItemGroupCylinderColumn1, chartControlCommandGalleryItemGroupConeColumn1, chartControlCommandGalleryItemGroupPyramidColumn1})
			Me.commandBarGalleryDropDown36.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown36.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown36.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown36.Name = "commandBarGalleryDropDown36"
			Me.commandBarGalleryDropDown36.Ribbon = Me.ribbonControl1
			' 
			' createLineBaseItem1
			' 
			Me.createLineBaseItem1.DropDownControl = Me.commandBarGalleryDropDown37
			Me.createLineBaseItem1.Id = 600
			Me.createLineBaseItem1.Name = "createLineBaseItem1"
			' 
			' commandBarGalleryDropDown37
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown37.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown37.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem1, createFullStackedLineChartItem1, createScatterLineChartItem1, createSplineChartItem1, createStackedLineChartItem1, createStepLineChartItem1})
			chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem1, createFullStackedLine3DChartItem1, createSpline3DChartItem1, createStackedLine3DChartItem1, createStepLine3DChartItem1})
			Me.commandBarGalleryDropDown37.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine1, chartControlCommandGalleryItemGroup3DLine1})
			Me.commandBarGalleryDropDown37.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown37.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown37.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown37.Name = "commandBarGalleryDropDown37"
			Me.commandBarGalleryDropDown37.Ribbon = Me.ribbonControl1
			' 
			' createPieBaseItem1
			' 
			Me.createPieBaseItem1.DropDownControl = Me.commandBarGalleryDropDown38
			Me.createPieBaseItem1.Id = 601
			Me.createPieBaseItem1.Name = "createPieBaseItem1"
			' 
			' commandBarGalleryDropDown38
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown38.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown38.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem1, createDoughnutChartItem1})
			chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem1, createDoughnut3DChartItem1})
			Me.commandBarGalleryDropDown38.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie1, chartControlCommandGalleryItemGroup3DPie1})
			Me.commandBarGalleryDropDown38.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown38.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown38.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown38.Name = "commandBarGalleryDropDown38"
			Me.commandBarGalleryDropDown38.Ribbon = Me.ribbonControl1
			' 
			' createRotatedBarBaseItem1
			' 
			Me.createRotatedBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown39
			Me.createRotatedBarBaseItem1.Id = 602
			Me.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1"
			' 
			' commandBarGalleryDropDown39
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown39.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown39.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem1, createRotatedFullStackedBarChartItem1, createRotatedSideBySideFullStackedBarChartItem1, createRotatedSideBySideStackedBarChartItem1, createRotatedStackedBarChartItem1})
			Me.commandBarGalleryDropDown39.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar1})
			Me.commandBarGalleryDropDown39.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown39.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown39.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown39.Name = "commandBarGalleryDropDown39"
			Me.commandBarGalleryDropDown39.Ribbon = Me.ribbonControl1
			' 
			' createAreaBaseItem1
			' 
			Me.createAreaBaseItem1.DropDownControl = Me.commandBarGalleryDropDown40
			Me.createAreaBaseItem1.Id = 603
			Me.createAreaBaseItem1.Name = "createAreaBaseItem1"
			' 
			' commandBarGalleryDropDown40
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown40.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown40.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem1, createFullStackedAreaChartItem1, createFullStackedSplineAreaChartItem1, createSplineAreaChartItem1, createStackedAreaChartItem1, createStackedSplineAreaChartItem1, createStepAreaChartItem1})
			chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem1, createFullStackedArea3DChartItem1, createFullStackedSplineArea3DChartItem1, createSplineArea3DChartItem1, createStackedArea3DChartItem1, createStackedSplineArea3DChartItem1, createStepArea3DChartItem1})
			Me.commandBarGalleryDropDown40.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea1, chartControlCommandGalleryItemGroup3DArea1})
			Me.commandBarGalleryDropDown40.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown40.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown40.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown40.Name = "commandBarGalleryDropDown40"
			Me.commandBarGalleryDropDown40.Ribbon = Me.ribbonControl1
			' 
			' createOtherSeriesTypesBaseItem1
			' 
			Me.createOtherSeriesTypesBaseItem1.DropDownControl = Me.commandBarGalleryDropDown41
			Me.createOtherSeriesTypesBaseItem1.Id = 604
			Me.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1"
			' 
			' commandBarGalleryDropDown41
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown41.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown41.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem1, createBubbleChartItem1})
			chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem1, createFunnel3DChartItem1})
			chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem1, createCandleStickChartItem1})
			chartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem1, createRadarLineChartItem1, createRadarAreaChartItem1})
			chartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem1, createPolarLineChartItem1, createPolarAreaChartItem1})
			chartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem1, createSideBySideRangeBarChartItem1, createRangeAreaChartItem1, createRangeArea3DChartItem1})
			chartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem1, createSideBySideGanttChartItem1})
			Me.commandBarGalleryDropDown41.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint1, chartControlCommandGalleryItemGroupFunnel1, chartControlCommandGalleryItemGroupFinancial1, chartControlCommandGalleryItemGroupRadar1, chartControlCommandGalleryItemGroupPolar1, chartControlCommandGalleryItemGroupRange1, chartControlCommandGalleryItemGroupGantt1})
			Me.commandBarGalleryDropDown41.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown41.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown41.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown41.Name = "commandBarGalleryDropDown41"
			Me.commandBarGalleryDropDown41.Ribbon = Me.ribbonControl1
			' 
			' changePaletteGalleryBaseItem1
			' 
			Me.changePaletteGalleryBaseItem1.DropDownControl = Me.commandBarGalleryDropDown42
			Me.changePaletteGalleryBaseItem1.Id = 605
			Me.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1"
			' 
			' commandBarGalleryDropDown42
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown42.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown42.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown42.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown42.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown42.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges1.Bottom = -3
			skinPaddingEdges1.Top = -3
			Me.commandBarGalleryDropDown42.Gallery.ItemImagePadding = skinPaddingEdges1
			skinPaddingEdges2.Bottom = -3
			skinPaddingEdges2.Top = -3
			Me.commandBarGalleryDropDown42.Gallery.ItemTextPadding = skinPaddingEdges2
			Me.commandBarGalleryDropDown42.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown42.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown42.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown42.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown42.Name = "commandBarGalleryDropDown42"
			Me.commandBarGalleryDropDown42.Ribbon = Me.ribbonControl1
			' 
			' changeAppearanceGalleryBaseItem1
			' 
			' 
			' 
			' 
			Me.changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7
			Me.changeAppearanceGalleryBaseItem1.Gallery.ImageSize = New System.Drawing.Size(80, 50)
			Me.changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4
			Me.changeAppearanceGalleryBaseItem1.Id = 606
			Me.changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1"
			' 
			' runWizardChartItem1
			' 
			Me.runWizardChartItem1.Id = 607
			Me.runWizardChartItem1.Name = "runWizardChartItem1"
			' 
			' mailMergeDataSourceItem1
			' 
			Me.mailMergeDataSourceItem1.Id = 608
			Me.mailMergeDataSourceItem1.Name = "mailMergeDataSourceItem1"
			' 
			' commandBarCheckItem32
			' 
			Me.commandBarCheckItem32.Id = 609
			Me.commandBarCheckItem32.Name = "commandBarCheckItem32"
			Me.commandBarCheckItem32.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters
			' 
			' commandBarCheckItem33
			' 
			Me.commandBarCheckItem33.Id = 610
			Me.commandBarCheckItem33.Name = "commandBarCheckItem33"
			Me.commandBarCheckItem33.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting
			' 
			' mailMergeCurrentRecordItem1
			' 
			Me.mailMergeCurrentRecordItem1.Description = resources.GetString("mailMergeCurrentRecordItem1.Description")
			Me.mailMergeCurrentRecordItem1.Edit = Me.repositoryItemMailMergeCurrentRecordEdit2
			Me.mailMergeCurrentRecordItem1.EditWidth = 90
			Me.mailMergeCurrentRecordItem1.Id = 611
			Me.mailMergeCurrentRecordItem1.Name = "mailMergeCurrentRecordItem1"
			' 
			' repositoryItemMailMergeCurrentRecordEdit2
			' 
			Me.repositoryItemMailMergeCurrentRecordEdit2.AutoHeight = False
			Me.repositoryItemMailMergeCurrentRecordEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, Nothing, True)})
			Me.repositoryItemMailMergeCurrentRecordEdit2.Name = "repositoryItemMailMergeCurrentRecordEdit2"
			' 
			' commandBarSubItem8
			' 
			Me.commandBarSubItem8.Id = 612
			Me.commandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem15)})
			Me.commandBarSubItem8.Name = "commandBarSubItem8"
			Me.commandBarSubItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarSubItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FinishAndMerge
			' 
			' commandBarItem13
			' 
			Me.commandBarItem13.Id = 613
			Me.commandBarItem13.Name = "commandBarItem13"
			Me.commandBarItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergeExportDocument
			' 
			' commandBarItem14
			' 
			Me.commandBarItem14.Id = 614
			Me.commandBarItem14.Name = "commandBarItem14"
			Me.commandBarItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrint
			' 
			' commandBarItem15
			' 
			Me.commandBarItem15.Id = 615
			Me.commandBarItem15.Name = "commandBarItem15"
			Me.commandBarItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrintPreview
			' 
			' headerFooterToolsRibbonPageCategory1
			' 
			Me.headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(38))))), (CInt(Fix((CByte(176))))), (CInt(Fix((CByte(35))))))
			Me.headerFooterToolsRibbonPageCategory1.Control = Me.snapControl1
			Me.headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1"
			Me.headerFooterToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.headerFooterToolsDesignRibbonPage1})
			' 
			' headerFooterToolsDesignRibbonPage1
			' 
			Me.headerFooterToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.headerFooterToolsDesignNavigationRibbonPageGroup1, Me.headerFooterToolsDesignOptionsRibbonPageGroup1, Me.headerFooterToolsDesignCloseRibbonPageGroup1})
			Me.headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1"
			' 
			' headerFooterToolsDesignNavigationRibbonPageGroup1
			' 
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageHeaderItem1)
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageFooterItem1)
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToNextHeaderFooterItem1)
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPreviousHeaderFooterItem1)
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.toggleLinkToPreviousItem1)
			Me.headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1"
			' 
			' headerFooterToolsDesignOptionsRibbonPageGroup1
			' 
			Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentFirstPageItem1)
			Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentOddAndEvenPagesItem1)
			Me.headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1"
			' 
			' headerFooterToolsDesignCloseRibbonPageGroup1
			' 
			Me.headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(Me.closePageHeaderFooterItem1)
			Me.headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1"
			' 
			' tableToolsRibbonPageCategory1
			' 
			Me.tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(233))))), (CInt(Fix((CByte(20))))))
			Me.tableToolsRibbonPageCategory1.Control = Me.snapControl1
			Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
			Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
			' 
			' tableDesignRibbonPage1
			' 
			Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1, Me.tableCellStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
			Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
			' 
			' tableStyleOptionsRibbonPageGroup1
			' 
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleFirstRowItem1)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleLastRowItem1)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleBandedRowsItem1)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleFirstColumnItem1)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleLastColumnItem1)
			Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleBandedColumnItem1)
			Me.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
			' 
			' tableStylesRibbonPageGroup1
			' 
			Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeTableStyleItem1)
			Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
			' 
			' tableCellStylesRibbonPageGroup1
			' 
			Me.tableCellStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeTableCellStyleItem1)
			Me.tableCellStylesRibbonPageGroup1.Name = "tableCellStylesRibbonPageGroup1"
			' 
			' tableDrawBordersRibbonPageGroup1
			' 
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1)
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1)
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1)
			Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
			' 
			' tableLayoutRibbonPage1
			' 
			Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableCellSizeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
			Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
			' 
			' tableTableRibbonPageGroup1
			' 
			Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1)
			Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1)
			Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1)
			Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
			' 
			' tableRowsAndColumnsRibbonPageGroup1
			' 
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
			' 
			' tableMergeRibbonPageGroup1
			' 
			Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1)
			Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1)
			Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1)
			Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
			' 
			' tableCellSizeRibbonPageGroup1
			' 
			Me.tableCellSizeRibbonPageGroup1.AllowTextClipping = False
			Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1)
			Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
			' 
			' tableAlignmentRibbonPageGroup1
			' 
			Me.tableAlignmentRibbonPageGroup1.Glyph = (CType(resources.GetObject("tableAlignmentRibbonPageGroup1.Glyph"), System.Drawing.Image))
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.showTableOptionsFormItem1)
			Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
			' 
			' floatingPictureToolsRibbonPageCategory1
			' 
			Me.floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(201))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(119))))))
			Me.floatingPictureToolsRibbonPageCategory1.Control = Me.snapControl1
			Me.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1"
			Me.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.floatingPictureToolsFormatPage1})
			' 
			' floatingPictureToolsFormatPage1
			' 
			Me.floatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.floatingPictureToolsShapeStylesPageGroup1, Me.floatingPictureToolsArrangePageGroup1})
			Me.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1"
			' 
			' floatingPictureToolsShapeStylesPageGroup1
			' 
			Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectFillColorItem1)
			Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineColorItem1)
			Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineWeightItem1)
			Me.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1"
			' 
			' floatingPictureToolsArrangePageGroup1
			' 
			Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectTextWrapTypeItem1)
			Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectAlignmentItem1)
			Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectBringForwardSubItem1)
			Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectSendBackwardSubItem1)
			Me.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
			' 
			' dataToolsRibbonPageCategory1
			' 
			Me.dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(31))))), (CInt(Fix((CByte(166))))), (CInt(Fix((CByte(207))))))
			Me.dataToolsRibbonPageCategory1.Control = Me.snapControl1
			Me.dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1"
			Me.dataToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.appearanceRibbonPage1, Me.snMergeFieldToolsRibbonPage1, Me.groupToolsRibbonPage1, Me.listToolsRibbonPage1, Me.mailMergeRibbonPage1})
			' 
			' appearanceRibbonPage1
			' 
			Me.appearanceRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.themesRibbonPageGroup1})
			Me.appearanceRibbonPage1.Name = "appearanceRibbonPage1"
			' 
			' themesRibbonPageGroup1
			' 
			Me.themesRibbonPageGroup1.ItemLinks.Add(Me.themesGalleryBarItem1)
			Me.themesRibbonPageGroup1.Name = "themesRibbonPageGroup1"
			' 
			' snMergeFieldToolsRibbonPage1
			' 
			Me.snMergeFieldToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.dataShapingRibbonPageGroup1, Me.snMergeFieldPropertiesRibbonPageGroup1})
			Me.snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1"
			' 
			' dataShapingRibbonPageGroup1
			' 
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem2)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem3)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem4)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem1)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.filterPopupButtonItem1)
			Me.dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1"
			' 
			' snMergeFieldPropertiesRibbonPageGroup1
			' 
			Me.snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(Me.propertiesBarButtonItem1)
			Me.snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1"
			' 
			' groupToolsRibbonPage1
			' 
			Me.groupToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.groupingRibbonPageGroup1})
			Me.groupToolsRibbonPage1.Name = "groupToolsRibbonPage1"
			' 
			' groupingRibbonPageGroup1
			' 
			Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem2)
			Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem3)
			Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem8)
			Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem9)
			Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem4)
			Me.groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1"
			' 
			' listToolsRibbonPage1
			' 
			Me.listToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.listHeaderAndFooterRibbonPageGroup1, Me.listCommandsRibbonPageGroup1, Me.listEditorRowLimitRibbonPageGroup1})
			Me.listToolsRibbonPage1.Name = "listToolsRibbonPage1"
			' 
			' listHeaderAndFooterRibbonPageGroup1
			' 
			Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem5)
			Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem6)
			Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem7)
			Me.listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1"
			' 
			' listCommandsRibbonPageGroup1
			' 
			Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem10)
			Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem11)
			Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem12)
			Me.listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1"
			' 
			' listEditorRowLimitRibbonPageGroup1
			' 
			Me.listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup8)
			Me.listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1"
			' 
			' mailMergeRibbonPage1
			' 
			Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1, Me.mailMergeCurrentRecordRibbonPageGroup1, Me.finishAndMergeRibbonPageGroup1})
			Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
			' 
			' mailMergeRibbonPageGroup1
			' 
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.mailMergeDataSourceItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem32)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem33)
			Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
			' 
			' mailMergeCurrentRecordRibbonPageGroup1
			' 
			Me.mailMergeCurrentRecordRibbonPageGroup1.ItemLinks.Add(Me.mailMergeCurrentRecordItem1)
			Me.mailMergeCurrentRecordRibbonPageGroup1.Name = "mailMergeCurrentRecordRibbonPageGroup1"
			' 
			' finishAndMergeRibbonPageGroup1
			' 
			Me.finishAndMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem8)
			Me.finishAndMergeRibbonPageGroup1.Name = "finishAndMergeRibbonPageGroup1"
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.dataRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			' 
			' dataRibbonPageGroup1
			' 
			Me.dataRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem2)
			Me.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1"
			' 
			' homeRibbonPage1
			' 
			Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
			Me.homeRibbonPage1.Name = "homeRibbonPage1"
			reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
			reduceOperation1.Group = Me.stylesRibbonPageGroup1
			reduceOperation1.ItemLinkIndex = 0
			reduceOperation1.ItemLinksCount = 0
			reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
			Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
			' 
			' clipboardRibbonPageGroup1
			' 
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
			Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
			' 
			' fontRibbonPageGroup1
			' 
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
			Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
			' 
			' paragraphRibbonPageGroup1
			' 
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
			Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
			' 
			' editingRibbonPageGroup1
			' 
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
			Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
			' 
			' insertRibbonPage1
			' 
			Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.toolboxRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
			Me.insertRibbonPage1.Name = "insertRibbonPage1"
			' 
			' pagesRibbonPageGroup1
			' 
			Me.pagesRibbonPageGroup1.AllowTextClipping = False
			Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem21)
			Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
			' 
			' tablesRibbonPageGroup1
			' 
			Me.tablesRibbonPageGroup1.AllowTextClipping = False
			Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
			Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
			' 
			' illustrationsRibbonPageGroup1
			' 
			Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
			Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
			Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
			' 
			' toolboxRibbonPageGroup1
			' 
			Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem3)
			Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem4)
			Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem5)
			Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem6)
			Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem7)
			Me.toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1"
			' 
			' linksRibbonPageGroup1
			' 
			Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
			Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
			Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
			' 
			' headerFooterRibbonPageGroup1
			' 
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
			Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
			' 
			' textRibbonPageGroup1
			' 
			Me.textRibbonPageGroup1.Glyph = (CType(resources.GetObject("textRibbonPageGroup1.Glyph"), System.Drawing.Image))
			Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1)
			Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
			' 
			' symbolsRibbonPageGroup1
			' 
			Me.symbolsRibbonPageGroup1.AllowTextClipping = False
			Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1)
			Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
			' 
			' pageLayoutRibbonPage1
			' 
			Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pageSetupRibbonPageGroup1, Me.pageBackgroundRibbonPageGroup1})
			Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
			' 
			' pageSetupRibbonPageGroup1
			' 
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageMarginsItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageOrientationItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPaperKindItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionColumnsItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.insertBreakItem1)
			Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionLineNumberingItem1)
			Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
			' 
			' pageBackgroundRibbonPageGroup1
			' 
			Me.pageBackgroundRibbonPageGroup1.AllowTextClipping = False
			Me.pageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.changePageColorItem1)
			Me.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1"
			' 
			' viewRibbonPage1
			' 
			Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentViewsRibbonPageGroup1, Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.viewRibbonPageGroup1, Me.viewFieldsRibbonPageGroup1})
			Me.viewRibbonPage1.Name = "viewRibbonPage1"
			' 
			' documentViewsRibbonPageGroup1
			' 
			Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToSimpleViewItem1)
			Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToDraftViewItem1)
			Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToPrintLayoutViewItem1)
			Me.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1"
			' 
			' showRibbonPageGroup1
			' 
			Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowHorizontalRulerItem1)
			Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowVerticalRulerItem1)
			Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
			' 
			' zoomRibbonPageGroup1
			' 
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomOutItem1)
			Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomInItem1)
			Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
			' 
			' viewRibbonPageGroup1
			' 
			Me.viewRibbonPageGroup1.ItemLinks.Add(Me.snapBarToolbarsListItem1)
			Me.viewRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem1)
			Me.viewRibbonPageGroup1.Name = "viewRibbonPageGroup1"
			' 
			' viewFieldsRibbonPageGroup1
			' 
			Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
			Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
			Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.toggleFieldHighlightingItem1)
			Me.viewFieldsRibbonPageGroup1.Name = "viewFieldsRibbonPageGroup1"
			' 
			' reviewRibbonPage1
			' 
			Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentProofingRibbonPageGroup1})
			Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
			' 
			' documentProofingRibbonPageGroup1
			' 
			Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1)
			Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
			' 
			' referencesRibbonPage1
			' 
			Me.referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableOfContentsRibbonPageGroup1, Me.captionsRibbonPageGroup1})
			Me.referencesRibbonPage1.Name = "referencesRibbonPage1"
			' 
			' tableOfContentsRibbonPageGroup1
			' 
			Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfContentsItem1)
			Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfContentsItem1)
			Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.addParagraphsToTableOfContentItem1)
			Me.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
			' 
			' captionsRibbonPageGroup1
			' 
			Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertCaptionPlaceholderItem1)
			Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfFiguresPlaceholderItem1)
			Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfFiguresItem1)
			Me.captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1"
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' repositoryItemRichEditFontSizeEdit1
			' 
			Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit1.Control = Me.snapControl1
			Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
			' 
			' repositoryItemBorderLineStyle1
			' 
			Me.repositoryItemBorderLineStyle1.AutoHeight = False
			Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemBorderLineStyle1.Control = Me.snapControl1
			Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
			' 
			' repositoryItemBorderLineWeight1
			' 
			Me.repositoryItemBorderLineWeight1.AutoHeight = False
			Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemBorderLineWeight1.Control = Me.snapControl1
			Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
			' 
			' repositoryItemFloatingObjectOutlineWeight1
			' 
			Me.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
			Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.snapControl1
			Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
			' 
			' repositoryItemEditorRowLimitEdit1
			' 
			Me.repositoryItemEditorRowLimitEdit1.AutoHeight = False
			Me.repositoryItemEditorRowLimitEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemEditorRowLimitEdit1.Control = Me.snapControl1
			Me.repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1"
			' 
			' repositoryItemMailMergeCurrentRecordEdit1
			' 
			Me.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = False
			Me.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, Nothing, True)})
			Me.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1"
			' 
			' commandBarGalleryDropDown29
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown29.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown29.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DColumn2.Caption = "2-D Column"
			createBarChartItem2.Caption = "Clustered Column"
			createBarChartItem2.Description = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createBarChartItem2.Hint = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem2.Caption = "100% Stacked Column"
			createFullStackedBarChartItem2.Description = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem2.Hint = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBarChartItem2.Caption = "Clustered 100% Stacked Column"
			createSideBySideFullStackedBarChartItem2.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideFullStackedBarChartItem2.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideStackedBarChartItem2.Caption = "Clustered Stacked Column"
			createSideBySideStackedBarChartItem2.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createSideBySideStackedBarChartItem2.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createStackedBarChartItem2.Caption = "Stacked Column"
			createStackedBarChartItem2.Description = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			createStackedBarChartItem2.Hint = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroup2DColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem2, createFullStackedBarChartItem2, createSideBySideFullStackedBarChartItem2, createSideBySideStackedBarChartItem2, createStackedBarChartItem2})
			chartControlCommandGalleryItemGroup3DColumn2.Caption = "3-D Column"
			createBar3DChartItem2.Caption = "3-D Clustered Column"
			createBar3DChartItem2.Description = "Compare values across categories and display clustered columns in 3-D format."
			createBar3DChartItem2.Hint = "Compare values across categories and display clustered columns in 3-D format."
			createFullStackedBar3DChartItem2.Caption = "100% Stacked Column in 3-D"
			createFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createManhattanBarChartItem2.Caption = "3-D Column"
			createManhattanBarChartItem2.Description = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createManhattanBarChartItem2.Hint = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Column in 3-D"
			createSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Column in 3-D"
			createSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createStackedBar3DChartItem2.Caption = "Stacked Column in 3-D"
			createStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			createStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			chartControlCommandGalleryItemGroup3DColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem2, createFullStackedBar3DChartItem2, createManhattanBarChartItem2, createSideBySideFullStackedBar3DChartItem2, createSideBySideStackedBar3DChartItem2, createStackedBar3DChartItem2})
			chartControlCommandGalleryItemGroupCylinderColumn2.Caption = "Cylinder"
			createCylinderBar3DChartItem2.Caption = "Clustered Cylinder"
			createCylinderBar3DChartItem2.Description = "Compare values across categories."
			createCylinderBar3DChartItem2.Hint = "Compare values across categories."
			createCylinderFullStackedBar3DChartItem2.Caption = "100% Stacked Cylinder"
			createCylinderFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories."
			createCylinderFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories."
			createCylinderManhattanBarChartItem2.Caption = "3-D Cylinder"
			createCylinderManhattanBarChartItem2.Description = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderManhattanBarChartItem2.Hint = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Cylinder"
			createCylinderSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Cylinder"
			createCylinderSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderStackedBar3DChartItem2.Caption = "Stacked Cylinder"
			createCylinderStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories."
			createCylinderStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupCylinderColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem2, createCylinderFullStackedBar3DChartItem2, createCylinderManhattanBarChartItem2, createCylinderSideBySideFullStackedBar3DChartItem2, createCylinderSideBySideStackedBar3DChartItem2, createCylinderStackedBar3DChartItem2})
			chartControlCommandGalleryItemGroupConeColumn2.Caption = "Cone"
			createConeBar3DChartItem2.Caption = "Clustered Cone"
			createConeBar3DChartItem2.Description = "Compare values across categories."
			createConeBar3DChartItem2.Hint = "Compare values across categories."
			createConeFullStackedBar3DChartItem2.Caption = "100% Stacked Cone"
			createConeFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories."
			createConeFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories."
			createConeManhattanBarChartItem2.Caption = "3-D Cone"
			createConeManhattanBarChartItem2.Description = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeManhattanBarChartItem2.Hint = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Cone"
			createConeSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Cone"
			createConeSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeStackedBar3DChartItem2.Caption = "Stacked Cone"
			createConeStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories."
			createConeStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupConeColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem2, createConeFullStackedBar3DChartItem2, createConeManhattanBarChartItem2, createConeSideBySideFullStackedBar3DChartItem2, createConeSideBySideStackedBar3DChartItem2, createConeStackedBar3DChartItem2})
			chartControlCommandGalleryItemGroupPyramidColumn2.Caption = "Pyramid"
			createPyramidBar3DChartItem2.Caption = "Clustered Pyramid"
			createPyramidBar3DChartItem2.Description = "Compare values across categories."
			createPyramidBar3DChartItem2.Hint = "Compare values across categories."
			createPyramidFullStackedBar3DChartItem2.Caption = "100% Stacked Pyramid"
			createPyramidFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories."
			createPyramidFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories."
			createPyramidManhattanBarChartItem2.Caption = "3-D Pyramid"
			createPyramidManhattanBarChartItem2.Description = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidManhattanBarChartItem2.Hint = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Pyramid"
			createPyramidSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Pyramid"
			createPyramidSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidStackedBar3DChartItem2.Caption = "Stacked Pyramid"
			createPyramidStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories."
			createPyramidStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupPyramidColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem2, createPyramidFullStackedBar3DChartItem2, createPyramidManhattanBarChartItem2, createPyramidSideBySideFullStackedBar3DChartItem2, createPyramidSideBySideStackedBar3DChartItem2, createPyramidStackedBar3DChartItem2})
			Me.commandBarGalleryDropDown29.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn2, chartControlCommandGalleryItemGroup3DColumn2, chartControlCommandGalleryItemGroupCylinderColumn2, chartControlCommandGalleryItemGroupConeColumn2, chartControlCommandGalleryItemGroupPyramidColumn2})
			Me.commandBarGalleryDropDown29.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown29.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown29.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown29.Name = "commandBarGalleryDropDown29"
			Me.commandBarGalleryDropDown29.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown30
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown30.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown30.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DLine2.Caption = "2-D Line"
			createLineChartItem2.Caption = "Line"
			createLineChartItem2.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createLineChartItem2.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createFullStackedLineChartItem2.Caption = "100% Stacked Line"
			createFullStackedLineChartItem2.Description = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createFullStackedLineChartItem2.Hint = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createScatterLineChartItem2.Caption = "Scatter Line"
			createScatterLineChartItem2.Description = "Represent series points in the same order that they have in the collection."
			createScatterLineChartItem2.Hint = "Represent series points in the same order that they have in the collection."
			createSplineChartItem2.Caption = "Spline"
			createSplineChartItem2.Description = "Plot a fitted curve through each data point in a series."
			createSplineChartItem2.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLineChartItem2.Caption = "Stacked Line"
			createStackedLineChartItem2.Description = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStackedLineChartItem2.Hint = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStepLineChartItem2.Caption = "Step Line"
			createStepLineChartItem2.Description = "Show to what extent values have changed for different points in the same series."
			createStepLineChartItem2.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup2DLine2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem2, createFullStackedLineChartItem2, createScatterLineChartItem2, createSplineChartItem2, createStackedLineChartItem2, createStepLineChartItem2})
			chartControlCommandGalleryItemGroup3DLine2.Caption = "3-D Line"
			createLine3DChartItem2.Caption = "3-D Line"
			createLine3DChartItem2.Description = "Display each row or column of data as a 3-D ribbon on three axes."
			createLine3DChartItem2.Hint = "Display each row or column of data as a 3-D ribbon on three axes."
			createFullStackedLine3DChartItem2.Caption = "100% Stacked Line in 3-D"
			createFullStackedLine3DChartItem2.Description = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createFullStackedLine3DChartItem2.Hint = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createSpline3DChartItem2.Caption = "3-D Spline"
			createSpline3DChartItem2.Description = "Plot a fitted curve through each data point in a series."
			createSpline3DChartItem2.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLine3DChartItem2.Caption = "Stacked Line in 3-D"
			createStackedLine3DChartItem2.Description = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStackedLine3DChartItem2.Hint = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStepLine3DChartItem2.Caption = "Step Line in 3-D"
			createStepLine3DChartItem2.Description = "Show to what extent values have changed for different points in the same series."
			createStepLine3DChartItem2.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DLine2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem2, createFullStackedLine3DChartItem2, createSpline3DChartItem2, createStackedLine3DChartItem2, createStepLine3DChartItem2})
			Me.commandBarGalleryDropDown30.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine2, chartControlCommandGalleryItemGroup3DLine2})
			Me.commandBarGalleryDropDown30.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown30.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown30.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown30.Name = "commandBarGalleryDropDown30"
			Me.commandBarGalleryDropDown30.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown31
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown31.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown31.Gallery.ColumnCount = 2
			chartControlCommandGalleryItemGroup2DPie2.Caption = "2-D Pie"
			createPieChartItem2.Caption = "Pie"
			createPieChartItem2.Description = resources.GetString("createPieChartItem2.Description")
			createPieChartItem2.Hint = resources.GetString("createPieChartItem2.Hint")
			createDoughnutChartItem2.Caption = "Doughnut"
			createDoughnutChartItem2.Description = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			createDoughnutChartItem2.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			chartControlCommandGalleryItemGroup2DPie2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem2, createDoughnutChartItem2})
			chartControlCommandGalleryItemGroup3DPie2.Caption = "3-D Pie"
			createPie3DChartItem2.Caption = "Pie in 3-D"
			createPie3DChartItem2.Description = "Display the contribution of each value to a total."
			createPie3DChartItem2.Hint = "Display the contribution of each value to a total."
			createDoughnut3DChartItem2.Caption = "Doughnut in 3-D"
			createDoughnut3DChartItem2.Description = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			createDoughnut3DChartItem2.Hint = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			chartControlCommandGalleryItemGroup3DPie2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem2, createDoughnut3DChartItem2})
			Me.commandBarGalleryDropDown31.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie2, chartControlCommandGalleryItemGroup3DPie2})
			Me.commandBarGalleryDropDown31.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown31.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown31.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown31.Name = "commandBarGalleryDropDown31"
			Me.commandBarGalleryDropDown31.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown32
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown32.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown32.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DBar2.Caption = "2-D Bar"
			createRotatedBarChartItem2.Caption = "Bar"
			createRotatedBarChartItem2.Description = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedBarChartItem2.Hint = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedFullStackedBarChartItem2.Caption = "100% Stacked Bar"
			createRotatedFullStackedBarChartItem2.Description = resources.GetString("createRotatedFullStackedBarChartItem2.Description")
			createRotatedFullStackedBarChartItem2.Hint = resources.GetString("createRotatedFullStackedBarChartItem2.Hint")
			createRotatedSideBySideFullStackedBarChartItem2.Caption = "Clustered 100% Stacked Bar"
			createRotatedSideBySideFullStackedBarChartItem2.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideFullStackedBarChartItem2.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem2.Caption = "Clustered Stacked Bar"
			createRotatedSideBySideStackedBarChartItem2.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem2.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedStackedBarChartItem2.Caption = "Stacked Bar"
			createRotatedStackedBarChartItem2.Description = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			createRotatedStackedBarChartItem2.Hint = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			chartControlCommandGalleryItemGroup2DBar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem2, createRotatedFullStackedBarChartItem2, createRotatedSideBySideFullStackedBarChartItem2, createRotatedSideBySideStackedBarChartItem2, createRotatedStackedBarChartItem2})
			Me.commandBarGalleryDropDown32.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar2})
			Me.commandBarGalleryDropDown32.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown32.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown32.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown32.Name = "commandBarGalleryDropDown32"
			Me.commandBarGalleryDropDown32.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown33
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown33.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown33.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DArea2.Caption = "2-D Area"
			createAreaChartItem2.Caption = "Area"
			createAreaChartItem2.Description = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createAreaChartItem2.Hint = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem2.Caption = "100% Stacked Area"
			createFullStackedAreaChartItem2.Description = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem2.Hint = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedSplineAreaChartItem2.Caption = "100% Stacked Spline Area"
			createFullStackedSplineAreaChartItem2.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createFullStackedSplineAreaChartItem2.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createSplineAreaChartItem2.Caption = "Spline Area"
			createSplineAreaChartItem2.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createSplineAreaChartItem2.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createStackedAreaChartItem2.Caption = "Stacked Area"
			createStackedAreaChartItem2.Description = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedAreaChartItem2.Hint = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedSplineAreaChartItem2.Caption = "Stacked Spline Area"
			createStackedSplineAreaChartItem2.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStackedSplineAreaChartItem2.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStepAreaChartItem2.Caption = "Step Area"
			createStepAreaChartItem2.Description = "Show how much values have changed for different points of the same series."
			createStepAreaChartItem2.Hint = "Show how much values have changed for different points of the same series."
			chartControlCommandGalleryItemGroup2DArea2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem2, createFullStackedAreaChartItem2, createFullStackedSplineAreaChartItem2, createSplineAreaChartItem2, createStackedAreaChartItem2, createStackedSplineAreaChartItem2, createStepAreaChartItem2})
			chartControlCommandGalleryItemGroup3DArea2.Caption = "3-D Area"
			createArea3DChartItem2.Caption = "3-D Area"
			createArea3DChartItem2.Description = resources.GetString("createArea3DChartItem2.Description")
			createArea3DChartItem2.Hint = resources.GetString("createArea3DChartItem2.Hint")
			createFullStackedArea3DChartItem2.Caption = "100% Stacked Area in 3-D"
			createFullStackedArea3DChartItem2.Description = resources.GetString("createFullStackedArea3DChartItem2.Description")
			createFullStackedArea3DChartItem2.Hint = resources.GetString("createFullStackedArea3DChartItem2.Hint")
			createFullStackedSplineArea3DChartItem2.Caption = "100% Stacked Spline Area in 3-D"
			createFullStackedSplineArea3DChartItem2.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createFullStackedSplineArea3DChartItem2.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createSplineArea3DChartItem2.Caption = "Spline Area in 3-D"
			createSplineArea3DChartItem2.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createSplineArea3DChartItem2.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createStackedArea3DChartItem2.Caption = "Stacked Area in 3-D"
			createStackedArea3DChartItem2.Description = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedArea3DChartItem2.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedSplineArea3DChartItem2.Caption = "Stacked Spline Area in 3-D"
			createStackedSplineArea3DChartItem2.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStackedSplineArea3DChartItem2.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStepArea3DChartItem2.Caption = "Step Area in 3-D"
			createStepArea3DChartItem2.Description = "Show to what extent values have changed for different points in the same series."
			createStepArea3DChartItem2.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DArea2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem2, createFullStackedArea3DChartItem2, createFullStackedSplineArea3DChartItem2, createSplineArea3DChartItem2, createStackedArea3DChartItem2, createStackedSplineArea3DChartItem2, createStepArea3DChartItem2})
			Me.commandBarGalleryDropDown33.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea2, chartControlCommandGalleryItemGroup3DArea2})
			Me.commandBarGalleryDropDown33.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown33.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown33.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown33.Name = "commandBarGalleryDropDown33"
			Me.commandBarGalleryDropDown33.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown34
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown34.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown34.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroupPoint2.Caption = "Point"
			createPointChartItem2.Caption = "Point"
			createPointChartItem2.Description = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createPointChartItem2.Hint = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createBubbleChartItem2.Caption = "Bubble"
			createBubbleChartItem2.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			createBubbleChartItem2.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			chartControlCommandGalleryItemGroupPoint2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem2, createBubbleChartItem2})
			chartControlCommandGalleryItemGroupFunnel2.Caption = "Funnel"
			createFunnelChartItem2.Caption = "Funnel"
			createFunnelChartItem2.Description = resources.GetString("createFunnelChartItem2.Description")
			createFunnelChartItem2.Hint = resources.GetString("createFunnelChartItem2.Hint")
			createFunnel3DChartItem2.Caption = "3-D Funnel"
			createFunnel3DChartItem2.Description = resources.GetString("createFunnel3DChartItem2.Description")
			createFunnel3DChartItem2.Hint = resources.GetString("createFunnel3DChartItem2.Hint")
			chartControlCommandGalleryItemGroupFunnel2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem2, createFunnel3DChartItem2})
			chartControlCommandGalleryItemGroupFinancial2.Caption = "Financial"
			createStockChartItem2.Caption = "Stock"
			createStockChartItem2.Description = resources.GetString("createStockChartItem2.Description")
			createStockChartItem2.Hint = resources.GetString("createStockChartItem2.Hint")
			createCandleStickChartItem2.Caption = "Candle Stick"
			createCandleStickChartItem2.Description = resources.GetString("createCandleStickChartItem2.Description")
			createCandleStickChartItem2.Hint = resources.GetString("createCandleStickChartItem2.Hint")
			chartControlCommandGalleryItemGroupFinancial2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem2, createCandleStickChartItem2})
			chartControlCommandGalleryItemGroupRadar2.Caption = "Radar"
			createRadarPointChartItem2.Caption = "Radar Point"
			createRadarPointChartItem2.Description = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarPointChartItem2.Hint = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem2.Caption = "Radar Line"
			createRadarLineChartItem2.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem2.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarAreaChartItem2.Caption = "Radar Area"
			createRadarAreaChartItem2.Description = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			createRadarAreaChartItem2.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			chartControlCommandGalleryItemGroupRadar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem2, createRadarLineChartItem2, createRadarAreaChartItem2})
			chartControlCommandGalleryItemGroupPolar2.Caption = "Polar"
			createPolarPointChartItem2.Caption = "Polar Point"
			createPolarPointChartItem2.Description = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarPointChartItem2.Hint = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarLineChartItem2.Caption = "Polar Line"
			createPolarLineChartItem2.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarLineChartItem2.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarAreaChartItem2.Caption = "Polar Area"
			createPolarAreaChartItem2.Description = "Display series as filled area on a circular diagram on the basis of angles."
			createPolarAreaChartItem2.Hint = "Display series as filled area on a circular diagram on the basis of angles."
			chartControlCommandGalleryItemGroupPolar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem2, createPolarLineChartItem2, createPolarAreaChartItem2})
			chartControlCommandGalleryItemGroupRange2.Caption = "Range"
			createRangeBarChartItem2.Caption = "Range Column"
			createRangeBarChartItem2.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createRangeBarChartItem2.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createSideBySideRangeBarChartItem2.Caption = "Clustered Range Column"
			createSideBySideRangeBarChartItem2.Description = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createSideBySideRangeBarChartItem2.Hint = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createRangeAreaChartItem2.Caption = "Range Area"
			createRangeAreaChartItem2.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeAreaChartItem2.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem2.Caption = "Range Area in 3-D"
			createRangeArea3DChartItem2.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem2.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroupRange2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem2, createSideBySideRangeBarChartItem2, createRangeAreaChartItem2, createRangeArea3DChartItem2})
			chartControlCommandGalleryItemGroupGantt2.Caption = "Gantt"
			createGanttChartItem2.Caption = "Gantt"
			createGanttChartItem2.Description = "Track different activities during the time frame."
			createGanttChartItem2.Hint = "Track different activities during the time frame."
			createSideBySideGanttChartItem2.Caption = "Clustered Gantt"
			createSideBySideGanttChartItem2.Description = resources.GetString("createSideBySideGanttChartItem2.Description")
			createSideBySideGanttChartItem2.Hint = resources.GetString("createSideBySideGanttChartItem2.Hint")
			chartControlCommandGalleryItemGroupGantt2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem2, createSideBySideGanttChartItem2})
			Me.commandBarGalleryDropDown34.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint2, chartControlCommandGalleryItemGroupFunnel2, chartControlCommandGalleryItemGroupFinancial2, chartControlCommandGalleryItemGroupRadar2, chartControlCommandGalleryItemGroupPolar2, chartControlCommandGalleryItemGroupRange2, chartControlCommandGalleryItemGroupGantt2})
			Me.commandBarGalleryDropDown34.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown34.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown34.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown34.Name = "commandBarGalleryDropDown34"
			Me.commandBarGalleryDropDown34.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown35
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown35.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown35.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown35.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown35.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown35.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges3.Bottom = -3
			skinPaddingEdges3.Top = -3
			Me.commandBarGalleryDropDown35.Gallery.ItemImagePadding = skinPaddingEdges3
			skinPaddingEdges4.Bottom = -3
			skinPaddingEdges4.Top = -3
			Me.commandBarGalleryDropDown35.Gallery.ItemTextPadding = skinPaddingEdges4
			Me.commandBarGalleryDropDown35.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown35.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown35.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown35.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown35.Name = "commandBarGalleryDropDown35"
			Me.commandBarGalleryDropDown35.Ribbon = Me.ribbonControl1
			' 
			' commandBarGalleryDropDown22
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown22.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown22.Gallery.ColumnCount = 4
			createBarChartItem3.Caption = "Clustered Column"
			createBarChartItem3.Description = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createBarChartItem3.Hint = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem3.Caption = "100% Stacked Column"
			createFullStackedBarChartItem3.Description = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem3.Hint = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBarChartItem3.Caption = "Clustered 100% Stacked Column"
			createSideBySideFullStackedBarChartItem3.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideFullStackedBarChartItem3.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideStackedBarChartItem3.Caption = "Clustered Stacked Column"
			createSideBySideStackedBarChartItem3.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createSideBySideStackedBarChartItem3.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createStackedBarChartItem3.Caption = "Stacked Column"
			createStackedBarChartItem3.Description = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			createStackedBarChartItem3.Hint = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroup2DColumn3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem3, createFullStackedBarChartItem3, createSideBySideFullStackedBarChartItem3, createSideBySideStackedBarChartItem3, createStackedBarChartItem3})
			createBar3DChartItem3.Caption = "3-D Clustered Column"
			createBar3DChartItem3.Description = "Compare values across categories and display clustered columns in 3-D format."
			createBar3DChartItem3.Hint = "Compare values across categories and display clustered columns in 3-D format."
			createFullStackedBar3DChartItem3.Caption = "100% Stacked Column in 3-D"
			createFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createManhattanBarChartItem3.Caption = "3-D Column"
			createManhattanBarChartItem3.Description = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createManhattanBarChartItem3.Hint = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Column in 3-D"
			createSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Column in 3-D"
			createSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createStackedBar3DChartItem3.Caption = "Stacked Column in 3-D"
			createStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			createStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			chartControlCommandGalleryItemGroup3DColumn3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem3, createFullStackedBar3DChartItem3, createManhattanBarChartItem3, createSideBySideFullStackedBar3DChartItem3, createSideBySideStackedBar3DChartItem3, createStackedBar3DChartItem3})
			createCylinderBar3DChartItem3.Caption = "Clustered Cylinder"
			createCylinderBar3DChartItem3.Description = "Compare values across categories."
			createCylinderBar3DChartItem3.Hint = "Compare values across categories."
			createCylinderFullStackedBar3DChartItem3.Caption = "100% Stacked Cylinder"
			createCylinderFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories."
			createCylinderFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories."
			createCylinderManhattanBarChartItem3.Caption = "3-D Cylinder"
			createCylinderManhattanBarChartItem3.Description = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderManhattanBarChartItem3.Hint = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Cylinder"
			createCylinderSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Cylinder"
			createCylinderSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderStackedBar3DChartItem3.Caption = "Stacked Cylinder"
			createCylinderStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories."
			createCylinderStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupCylinderColumn3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem3, createCylinderFullStackedBar3DChartItem3, createCylinderManhattanBarChartItem3, createCylinderSideBySideFullStackedBar3DChartItem3, createCylinderSideBySideStackedBar3DChartItem3, createCylinderStackedBar3DChartItem3})
			createConeBar3DChartItem3.Caption = "Clustered Cone"
			createConeBar3DChartItem3.Description = "Compare values across categories."
			createConeBar3DChartItem3.Hint = "Compare values across categories."
			createConeFullStackedBar3DChartItem3.Caption = "100% Stacked Cone"
			createConeFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories."
			createConeFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories."
			createConeManhattanBarChartItem3.Caption = "3-D Cone"
			createConeManhattanBarChartItem3.Description = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeManhattanBarChartItem3.Hint = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Cone"
			createConeSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Cone"
			createConeSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeStackedBar3DChartItem3.Caption = "Stacked Cone"
			createConeStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories."
			createConeStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupConeColumn3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem3, createConeFullStackedBar3DChartItem3, createConeManhattanBarChartItem3, createConeSideBySideFullStackedBar3DChartItem3, createConeSideBySideStackedBar3DChartItem3, createConeStackedBar3DChartItem3})
			createPyramidBar3DChartItem3.Caption = "Clustered Pyramid"
			createPyramidBar3DChartItem3.Description = "Compare values across categories."
			createPyramidBar3DChartItem3.Hint = "Compare values across categories."
			createPyramidFullStackedBar3DChartItem3.Caption = "100% Stacked Pyramid"
			createPyramidFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories."
			createPyramidFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories."
			createPyramidManhattanBarChartItem3.Caption = "3-D Pyramid"
			createPyramidManhattanBarChartItem3.Description = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidManhattanBarChartItem3.Hint = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Pyramid"
			createPyramidSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Pyramid"
			createPyramidSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidStackedBar3DChartItem3.Caption = "Stacked Pyramid"
			createPyramidStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories."
			createPyramidStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupPyramidColumn3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem3, createPyramidFullStackedBar3DChartItem3, createPyramidManhattanBarChartItem3, createPyramidSideBySideFullStackedBar3DChartItem3, createPyramidSideBySideStackedBar3DChartItem3, createPyramidStackedBar3DChartItem3})
			Me.commandBarGalleryDropDown22.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn3, chartControlCommandGalleryItemGroup3DColumn3, chartControlCommandGalleryItemGroupCylinderColumn3, chartControlCommandGalleryItemGroupConeColumn3, chartControlCommandGalleryItemGroupPyramidColumn3})
			Me.commandBarGalleryDropDown22.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown22.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown22.Manager = Nothing
			Me.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22"
			' 
			' commandBarGalleryDropDown23
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown23.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown23.Gallery.ColumnCount = 3
			createLineChartItem3.Caption = "Line"
			createLineChartItem3.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createLineChartItem3.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createFullStackedLineChartItem3.Caption = "100% Stacked Line"
			createFullStackedLineChartItem3.Description = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createFullStackedLineChartItem3.Hint = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createScatterLineChartItem3.Caption = "Scatter Line"
			createScatterLineChartItem3.Description = "Represent series points in the same order that they have in the collection."
			createScatterLineChartItem3.Hint = "Represent series points in the same order that they have in the collection."
			createSplineChartItem3.Caption = "Spline"
			createSplineChartItem3.Description = "Plot a fitted curve through each data point in a series."
			createSplineChartItem3.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLineChartItem3.Caption = "Stacked Line"
			createStackedLineChartItem3.Description = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStackedLineChartItem3.Hint = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStepLineChartItem3.Caption = "Step Line"
			createStepLineChartItem3.Description = "Show to what extent values have changed for different points in the same series."
			createStepLineChartItem3.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup2DLine3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem3, createFullStackedLineChartItem3, createScatterLineChartItem3, createSplineChartItem3, createStackedLineChartItem3, createStepLineChartItem3})
			createLine3DChartItem3.Caption = "3-D Line"
			createLine3DChartItem3.Description = "Display each row or column of data as a 3-D ribbon on three axes."
			createLine3DChartItem3.Hint = "Display each row or column of data as a 3-D ribbon on three axes."
			createFullStackedLine3DChartItem3.Caption = "100% Stacked Line in 3-D"
			createFullStackedLine3DChartItem3.Description = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createFullStackedLine3DChartItem3.Hint = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createSpline3DChartItem3.Caption = "3-D Spline"
			createSpline3DChartItem3.Description = "Plot a fitted curve through each data point in a series."
			createSpline3DChartItem3.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLine3DChartItem3.Caption = "Stacked Line in 3-D"
			createStackedLine3DChartItem3.Description = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStackedLine3DChartItem3.Hint = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStepLine3DChartItem3.Caption = "Step Line in 3-D"
			createStepLine3DChartItem3.Description = "Show to what extent values have changed for different points in the same series."
			createStepLine3DChartItem3.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DLine3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem3, createFullStackedLine3DChartItem3, createSpline3DChartItem3, createStackedLine3DChartItem3, createStepLine3DChartItem3})
			Me.commandBarGalleryDropDown23.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine3, chartControlCommandGalleryItemGroup3DLine3})
			Me.commandBarGalleryDropDown23.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown23.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown23.Manager = Nothing
			Me.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23"
			' 
			' commandBarGalleryDropDown24
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown24.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown24.Gallery.ColumnCount = 2
			createPieChartItem3.Caption = "Pie"
			createPieChartItem3.Description = resources.GetString("createPieChartItem3.Description")
			createPieChartItem3.Hint = resources.GetString("createPieChartItem3.Hint")
			createDoughnutChartItem3.Caption = "Doughnut"
			createDoughnutChartItem3.Description = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			createDoughnutChartItem3.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			chartControlCommandGalleryItemGroup2DPie3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem3, createDoughnutChartItem3})
			createPie3DChartItem3.Caption = "Pie in 3-D"
			createPie3DChartItem3.Description = "Display the contribution of each value to a total."
			createPie3DChartItem3.Hint = "Display the contribution of each value to a total."
			createDoughnut3DChartItem3.Caption = "Doughnut in 3-D"
			createDoughnut3DChartItem3.Description = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			createDoughnut3DChartItem3.Hint = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			chartControlCommandGalleryItemGroup3DPie3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem3, createDoughnut3DChartItem3})
			Me.commandBarGalleryDropDown24.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie3, chartControlCommandGalleryItemGroup3DPie3})
			Me.commandBarGalleryDropDown24.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown24.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown24.Manager = Nothing
			Me.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24"
			' 
			' commandBarGalleryDropDown25
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown25.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown25.Gallery.ColumnCount = 3
			createRotatedBarChartItem3.Caption = "Bar"
			createRotatedBarChartItem3.Description = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedBarChartItem3.Hint = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedFullStackedBarChartItem3.Caption = "100% Stacked Bar"
			createRotatedFullStackedBarChartItem3.Description = resources.GetString("createRotatedFullStackedBarChartItem3.Description")
			createRotatedFullStackedBarChartItem3.Hint = resources.GetString("createRotatedFullStackedBarChartItem3.Hint")
			createRotatedSideBySideFullStackedBarChartItem3.Caption = "Clustered 100% Stacked Bar"
			createRotatedSideBySideFullStackedBarChartItem3.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideFullStackedBarChartItem3.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem3.Caption = "Clustered Stacked Bar"
			createRotatedSideBySideStackedBarChartItem3.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem3.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedStackedBarChartItem3.Caption = "Stacked Bar"
			createRotatedStackedBarChartItem3.Description = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			createRotatedStackedBarChartItem3.Hint = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			chartControlCommandGalleryItemGroup2DBar3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem3, createRotatedFullStackedBarChartItem3, createRotatedSideBySideFullStackedBarChartItem3, createRotatedSideBySideStackedBarChartItem3, createRotatedStackedBarChartItem3})
			Me.commandBarGalleryDropDown25.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar3})
			Me.commandBarGalleryDropDown25.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown25.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown25.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown25.Manager = Nothing
			Me.commandBarGalleryDropDown25.Name = "commandBarGalleryDropDown25"
			' 
			' commandBarGalleryDropDown26
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown26.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown26.Gallery.ColumnCount = 4
			createAreaChartItem3.Caption = "Area"
			createAreaChartItem3.Description = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createAreaChartItem3.Hint = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem3.Caption = "100% Stacked Area"
			createFullStackedAreaChartItem3.Description = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem3.Hint = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedSplineAreaChartItem3.Caption = "100% Stacked Spline Area"
			createFullStackedSplineAreaChartItem3.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createFullStackedSplineAreaChartItem3.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createSplineAreaChartItem3.Caption = "Spline Area"
			createSplineAreaChartItem3.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createSplineAreaChartItem3.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createStackedAreaChartItem3.Caption = "Stacked Area"
			createStackedAreaChartItem3.Description = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedAreaChartItem3.Hint = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedSplineAreaChartItem3.Caption = "Stacked Spline Area"
			createStackedSplineAreaChartItem3.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStackedSplineAreaChartItem3.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStepAreaChartItem3.Caption = "Step Area"
			createStepAreaChartItem3.Description = "Show how much values have changed for different points of the same series."
			createStepAreaChartItem3.Hint = "Show how much values have changed for different points of the same series."
			chartControlCommandGalleryItemGroup2DArea3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem3, createFullStackedAreaChartItem3, createFullStackedSplineAreaChartItem3, createSplineAreaChartItem3, createStackedAreaChartItem3, createStackedSplineAreaChartItem3, createStepAreaChartItem3})
			createArea3DChartItem3.Caption = "3-D Area"
			createArea3DChartItem3.Description = resources.GetString("createArea3DChartItem3.Description")
			createArea3DChartItem3.Hint = resources.GetString("createArea3DChartItem3.Hint")
			createFullStackedArea3DChartItem3.Caption = "100% Stacked Area in 3-D"
			createFullStackedArea3DChartItem3.Description = resources.GetString("createFullStackedArea3DChartItem3.Description")
			createFullStackedArea3DChartItem3.Hint = resources.GetString("createFullStackedArea3DChartItem3.Hint")
			createFullStackedSplineArea3DChartItem3.Caption = "100% Stacked Spline Area in 3-D"
			createFullStackedSplineArea3DChartItem3.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createFullStackedSplineArea3DChartItem3.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createSplineArea3DChartItem3.Caption = "Spline Area in 3-D"
			createSplineArea3DChartItem3.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createSplineArea3DChartItem3.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createStackedArea3DChartItem3.Caption = "Stacked Area in 3-D"
			createStackedArea3DChartItem3.Description = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedArea3DChartItem3.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedSplineArea3DChartItem3.Caption = "Stacked Spline Area in 3-D"
			createStackedSplineArea3DChartItem3.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStackedSplineArea3DChartItem3.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStepArea3DChartItem3.Caption = "Step Area in 3-D"
			createStepArea3DChartItem3.Description = "Show to what extent values have changed for different points in the same series."
			createStepArea3DChartItem3.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DArea3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem3, createFullStackedArea3DChartItem3, createFullStackedSplineArea3DChartItem3, createSplineArea3DChartItem3, createStackedArea3DChartItem3, createStackedSplineArea3DChartItem3, createStepArea3DChartItem3})
			Me.commandBarGalleryDropDown26.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea3, chartControlCommandGalleryItemGroup3DArea3})
			Me.commandBarGalleryDropDown26.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown26.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown26.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown26.Manager = Nothing
			Me.commandBarGalleryDropDown26.Name = "commandBarGalleryDropDown26"
			' 
			' commandBarGalleryDropDown27
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown27.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown27.Gallery.ColumnCount = 4
			createPointChartItem3.Caption = "Point"
			createPointChartItem3.Description = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createPointChartItem3.Hint = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createBubbleChartItem3.Caption = "Bubble"
			createBubbleChartItem3.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			createBubbleChartItem3.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			chartControlCommandGalleryItemGroupPoint3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem3, createBubbleChartItem3})
			createFunnelChartItem3.Caption = "Funnel"
			createFunnelChartItem3.Description = resources.GetString("createFunnelChartItem3.Description")
			createFunnelChartItem3.Hint = resources.GetString("createFunnelChartItem3.Hint")
			createFunnel3DChartItem3.Caption = "3-D Funnel"
			createFunnel3DChartItem3.Description = resources.GetString("createFunnel3DChartItem3.Description")
			createFunnel3DChartItem3.Hint = resources.GetString("createFunnel3DChartItem3.Hint")
			chartControlCommandGalleryItemGroupFunnel3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem3, createFunnel3DChartItem3})
			createStockChartItem3.Caption = "Stock"
			createStockChartItem3.Description = resources.GetString("createStockChartItem3.Description")
			createStockChartItem3.Hint = resources.GetString("createStockChartItem3.Hint")
			createCandleStickChartItem3.Caption = "Candle Stick"
			createCandleStickChartItem3.Description = resources.GetString("createCandleStickChartItem3.Description")
			createCandleStickChartItem3.Hint = resources.GetString("createCandleStickChartItem3.Hint")
			chartControlCommandGalleryItemGroupFinancial3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem3, createCandleStickChartItem3})
			createRadarPointChartItem3.Caption = "Radar Point"
			createRadarPointChartItem3.Description = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarPointChartItem3.Hint = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem3.Caption = "Radar Line"
			createRadarLineChartItem3.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem3.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarAreaChartItem3.Caption = "Radar Area"
			createRadarAreaChartItem3.Description = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			createRadarAreaChartItem3.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			chartControlCommandGalleryItemGroupRadar3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem3, createRadarLineChartItem3, createRadarAreaChartItem3})
			createPolarPointChartItem3.Caption = "Polar Point"
			createPolarPointChartItem3.Description = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarPointChartItem3.Hint = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarLineChartItem3.Caption = "Polar Line"
			createPolarLineChartItem3.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarLineChartItem3.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarAreaChartItem3.Caption = "Polar Area"
			createPolarAreaChartItem3.Description = "Display series as filled area on a circular diagram on the basis of angles."
			createPolarAreaChartItem3.Hint = "Display series as filled area on a circular diagram on the basis of angles."
			chartControlCommandGalleryItemGroupPolar3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem3, createPolarLineChartItem3, createPolarAreaChartItem3})
			createRangeBarChartItem3.Caption = "Range Column"
			createRangeBarChartItem3.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createRangeBarChartItem3.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createSideBySideRangeBarChartItem3.Caption = "Clustered Range Column"
			createSideBySideRangeBarChartItem3.Description = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createSideBySideRangeBarChartItem3.Hint = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createRangeAreaChartItem3.Caption = "Range Area"
			createRangeAreaChartItem3.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeAreaChartItem3.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem3.Caption = "Range Area in 3-D"
			createRangeArea3DChartItem3.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem3.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroupRange3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem3, createSideBySideRangeBarChartItem3, createRangeAreaChartItem3, createRangeArea3DChartItem3})
			createGanttChartItem3.Caption = "Gantt"
			createGanttChartItem3.Description = "Track different activities during the time frame."
			createGanttChartItem3.Hint = "Track different activities during the time frame."
			createSideBySideGanttChartItem3.Caption = "Clustered Gantt"
			createSideBySideGanttChartItem3.Description = resources.GetString("createSideBySideGanttChartItem3.Description")
			createSideBySideGanttChartItem3.Hint = resources.GetString("createSideBySideGanttChartItem3.Hint")
			chartControlCommandGalleryItemGroupGantt3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem3, createSideBySideGanttChartItem3})
			Me.commandBarGalleryDropDown27.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint3, chartControlCommandGalleryItemGroupFunnel3, chartControlCommandGalleryItemGroupFinancial3, chartControlCommandGalleryItemGroupRadar3, chartControlCommandGalleryItemGroupPolar3, chartControlCommandGalleryItemGroupRange3, chartControlCommandGalleryItemGroupGantt3})
			Me.commandBarGalleryDropDown27.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown27.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown27.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown27.Manager = Nothing
			Me.commandBarGalleryDropDown27.Name = "commandBarGalleryDropDown27"
			' 
			' commandBarGalleryDropDown28
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown28.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown28.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown28.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown28.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown28.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges5.Bottom = -3
			skinPaddingEdges5.Top = -3
			Me.commandBarGalleryDropDown28.Gallery.ItemImagePadding = skinPaddingEdges5
			skinPaddingEdges6.Bottom = -3
			skinPaddingEdges6.Top = -3
			Me.commandBarGalleryDropDown28.Gallery.ItemTextPadding = skinPaddingEdges6
			Me.commandBarGalleryDropDown28.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown28.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown28.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown28.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown28.Manager = Nothing
			Me.commandBarGalleryDropDown28.Name = "commandBarGalleryDropDown28"
			' 
			' commandBarGalleryDropDown15
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown15.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown15.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DColumn4.Caption = "2-D Column"
			createBarChartItem4.Caption = "Clustered Column"
			createBarChartItem4.Description = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createBarChartItem4.Hint = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem4.Caption = "100% Stacked Column"
			createFullStackedBarChartItem4.Description = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem4.Hint = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBarChartItem4.Caption = "Clustered 100% Stacked Column"
			createSideBySideFullStackedBarChartItem4.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideFullStackedBarChartItem4.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideStackedBarChartItem4.Caption = "Clustered Stacked Column"
			createSideBySideStackedBarChartItem4.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createSideBySideStackedBarChartItem4.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createStackedBarChartItem4.Caption = "Stacked Column"
			createStackedBarChartItem4.Description = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			createStackedBarChartItem4.Hint = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroup2DColumn4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem4, createFullStackedBarChartItem4, createSideBySideFullStackedBarChartItem4, createSideBySideStackedBarChartItem4, createStackedBarChartItem4})
			chartControlCommandGalleryItemGroup3DColumn4.Caption = "3-D Column"
			createBar3DChartItem4.Caption = "3-D Clustered Column"
			createBar3DChartItem4.Description = "Compare values across categories and display clustered columns in 3-D format."
			createBar3DChartItem4.Hint = "Compare values across categories and display clustered columns in 3-D format."
			createFullStackedBar3DChartItem4.Caption = "100% Stacked Column in 3-D"
			createFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createManhattanBarChartItem4.Caption = "3-D Column"
			createManhattanBarChartItem4.Description = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createManhattanBarChartItem4.Hint = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Column in 3-D"
			createSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Column in 3-D"
			createSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createStackedBar3DChartItem4.Caption = "Stacked Column in 3-D"
			createStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			createStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			chartControlCommandGalleryItemGroup3DColumn4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem4, createFullStackedBar3DChartItem4, createManhattanBarChartItem4, createSideBySideFullStackedBar3DChartItem4, createSideBySideStackedBar3DChartItem4, createStackedBar3DChartItem4})
			chartControlCommandGalleryItemGroupCylinderColumn4.Caption = "Cylinder"
			createCylinderBar3DChartItem4.Caption = "Clustered Cylinder"
			createCylinderBar3DChartItem4.Description = "Compare values across categories."
			createCylinderBar3DChartItem4.Hint = "Compare values across categories."
			createCylinderFullStackedBar3DChartItem4.Caption = "100% Stacked Cylinder"
			createCylinderFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories."
			createCylinderFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories."
			createCylinderManhattanBarChartItem4.Caption = "3-D Cylinder"
			createCylinderManhattanBarChartItem4.Description = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderManhattanBarChartItem4.Hint = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Cylinder"
			createCylinderSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Cylinder"
			createCylinderSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderStackedBar3DChartItem4.Caption = "Stacked Cylinder"
			createCylinderStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories."
			createCylinderStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupCylinderColumn4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem4, createCylinderFullStackedBar3DChartItem4, createCylinderManhattanBarChartItem4, createCylinderSideBySideFullStackedBar3DChartItem4, createCylinderSideBySideStackedBar3DChartItem4, createCylinderStackedBar3DChartItem4})
			chartControlCommandGalleryItemGroupConeColumn4.Caption = "Cone"
			createConeBar3DChartItem4.Caption = "Clustered Cone"
			createConeBar3DChartItem4.Description = "Compare values across categories."
			createConeBar3DChartItem4.Hint = "Compare values across categories."
			createConeFullStackedBar3DChartItem4.Caption = "100% Stacked Cone"
			createConeFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories."
			createConeFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories."
			createConeManhattanBarChartItem4.Caption = "3-D Cone"
			createConeManhattanBarChartItem4.Description = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeManhattanBarChartItem4.Hint = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Cone"
			createConeSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Cone"
			createConeSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeStackedBar3DChartItem4.Caption = "Stacked Cone"
			createConeStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories."
			createConeStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupConeColumn4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem4, createConeFullStackedBar3DChartItem4, createConeManhattanBarChartItem4, createConeSideBySideFullStackedBar3DChartItem4, createConeSideBySideStackedBar3DChartItem4, createConeStackedBar3DChartItem4})
			chartControlCommandGalleryItemGroupPyramidColumn4.Caption = "Pyramid"
			createPyramidBar3DChartItem4.Caption = "Clustered Pyramid"
			createPyramidBar3DChartItem4.Description = "Compare values across categories."
			createPyramidBar3DChartItem4.Hint = "Compare values across categories."
			createPyramidFullStackedBar3DChartItem4.Caption = "100% Stacked Pyramid"
			createPyramidFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories."
			createPyramidFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories."
			createPyramidManhattanBarChartItem4.Caption = "3-D Pyramid"
			createPyramidManhattanBarChartItem4.Description = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidManhattanBarChartItem4.Hint = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Pyramid"
			createPyramidSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Pyramid"
			createPyramidSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidStackedBar3DChartItem4.Caption = "Stacked Pyramid"
			createPyramidStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories."
			createPyramidStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupPyramidColumn4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem4, createPyramidFullStackedBar3DChartItem4, createPyramidManhattanBarChartItem4, createPyramidSideBySideFullStackedBar3DChartItem4, createPyramidSideBySideStackedBar3DChartItem4, createPyramidStackedBar3DChartItem4})
			Me.commandBarGalleryDropDown15.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn4, chartControlCommandGalleryItemGroup3DColumn4, chartControlCommandGalleryItemGroupCylinderColumn4, chartControlCommandGalleryItemGroupConeColumn4, chartControlCommandGalleryItemGroupPyramidColumn4})
			Me.commandBarGalleryDropDown15.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown15.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown15.Manager = Nothing
			Me.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15"
			' 
			' commandBarGalleryDropDown16
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown16.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown16.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DLine4.Caption = "2-D Line"
			createLineChartItem4.Caption = "Line"
			createLineChartItem4.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createLineChartItem4.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createFullStackedLineChartItem4.Caption = "100% Stacked Line"
			createFullStackedLineChartItem4.Description = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createFullStackedLineChartItem4.Hint = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createScatterLineChartItem4.Caption = "Scatter Line"
			createScatterLineChartItem4.Description = "Represent series points in the same order that they have in the collection."
			createScatterLineChartItem4.Hint = "Represent series points in the same order that they have in the collection."
			createSplineChartItem4.Caption = "Spline"
			createSplineChartItem4.Description = "Plot a fitted curve through each data point in a series."
			createSplineChartItem4.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLineChartItem4.Caption = "Stacked Line"
			createStackedLineChartItem4.Description = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStackedLineChartItem4.Hint = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStepLineChartItem4.Caption = "Step Line"
			createStepLineChartItem4.Description = "Show to what extent values have changed for different points in the same series."
			createStepLineChartItem4.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup2DLine4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem4, createFullStackedLineChartItem4, createScatterLineChartItem4, createSplineChartItem4, createStackedLineChartItem4, createStepLineChartItem4})
			chartControlCommandGalleryItemGroup3DLine4.Caption = "3-D Line"
			createLine3DChartItem4.Caption = "3-D Line"
			createLine3DChartItem4.Description = "Display each row or column of data as a 3-D ribbon on three axes."
			createLine3DChartItem4.Hint = "Display each row or column of data as a 3-D ribbon on three axes."
			createFullStackedLine3DChartItem4.Caption = "100% Stacked Line in 3-D"
			createFullStackedLine3DChartItem4.Description = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createFullStackedLine3DChartItem4.Hint = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createSpline3DChartItem4.Caption = "3-D Spline"
			createSpline3DChartItem4.Description = "Plot a fitted curve through each data point in a series."
			createSpline3DChartItem4.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLine3DChartItem4.Caption = "Stacked Line in 3-D"
			createStackedLine3DChartItem4.Description = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStackedLine3DChartItem4.Hint = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStepLine3DChartItem4.Caption = "Step Line in 3-D"
			createStepLine3DChartItem4.Description = "Show to what extent values have changed for different points in the same series."
			createStepLine3DChartItem4.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DLine4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem4, createFullStackedLine3DChartItem4, createSpline3DChartItem4, createStackedLine3DChartItem4, createStepLine3DChartItem4})
			Me.commandBarGalleryDropDown16.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine4, chartControlCommandGalleryItemGroup3DLine4})
			Me.commandBarGalleryDropDown16.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown16.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown16.Manager = Nothing
			Me.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16"
			' 
			' commandBarGalleryDropDown17
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown17.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown17.Gallery.ColumnCount = 2
			chartControlCommandGalleryItemGroup2DPie4.Caption = "2-D Pie"
			createPieChartItem4.Caption = "Pie"
			createPieChartItem4.Description = resources.GetString("createPieChartItem4.Description")
			createPieChartItem4.Hint = resources.GetString("createPieChartItem4.Hint")
			createDoughnutChartItem4.Caption = "Doughnut"
			createDoughnutChartItem4.Description = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			createDoughnutChartItem4.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			chartControlCommandGalleryItemGroup2DPie4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem4, createDoughnutChartItem4})
			chartControlCommandGalleryItemGroup3DPie4.Caption = "3-D Pie"
			createPie3DChartItem4.Caption = "Pie in 3-D"
			createPie3DChartItem4.Description = "Display the contribution of each value to a total."
			createPie3DChartItem4.Hint = "Display the contribution of each value to a total."
			createDoughnut3DChartItem4.Caption = "Doughnut in 3-D"
			createDoughnut3DChartItem4.Description = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			createDoughnut3DChartItem4.Hint = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			chartControlCommandGalleryItemGroup3DPie4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem4, createDoughnut3DChartItem4})
			Me.commandBarGalleryDropDown17.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie4, chartControlCommandGalleryItemGroup3DPie4})
			Me.commandBarGalleryDropDown17.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown17.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown17.Manager = Nothing
			Me.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17"
			' 
			' commandBarGalleryDropDown18
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown18.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown18.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DBar4.Caption = "2-D Bar"
			createRotatedBarChartItem4.Caption = "Bar"
			createRotatedBarChartItem4.Description = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedBarChartItem4.Hint = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedFullStackedBarChartItem4.Caption = "100% Stacked Bar"
			createRotatedFullStackedBarChartItem4.Description = resources.GetString("createRotatedFullStackedBarChartItem4.Description")
			createRotatedFullStackedBarChartItem4.Hint = resources.GetString("createRotatedFullStackedBarChartItem4.Hint")
			createRotatedSideBySideFullStackedBarChartItem4.Caption = "Clustered 100% Stacked Bar"
			createRotatedSideBySideFullStackedBarChartItem4.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideFullStackedBarChartItem4.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem4.Caption = "Clustered Stacked Bar"
			createRotatedSideBySideStackedBarChartItem4.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem4.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedStackedBarChartItem4.Caption = "Stacked Bar"
			createRotatedStackedBarChartItem4.Description = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			createRotatedStackedBarChartItem4.Hint = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			chartControlCommandGalleryItemGroup2DBar4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem4, createRotatedFullStackedBarChartItem4, createRotatedSideBySideFullStackedBarChartItem4, createRotatedSideBySideStackedBarChartItem4, createRotatedStackedBarChartItem4})
			Me.commandBarGalleryDropDown18.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar4})
			Me.commandBarGalleryDropDown18.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown18.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown18.Manager = Nothing
			Me.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18"
			' 
			' commandBarGalleryDropDown19
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown19.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown19.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DArea4.Caption = "2-D Area"
			createAreaChartItem4.Caption = "Area"
			createAreaChartItem4.Description = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createAreaChartItem4.Hint = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem4.Caption = "100% Stacked Area"
			createFullStackedAreaChartItem4.Description = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem4.Hint = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedSplineAreaChartItem4.Caption = "100% Stacked Spline Area"
			createFullStackedSplineAreaChartItem4.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createFullStackedSplineAreaChartItem4.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createSplineAreaChartItem4.Caption = "Spline Area"
			createSplineAreaChartItem4.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createSplineAreaChartItem4.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createStackedAreaChartItem4.Caption = "Stacked Area"
			createStackedAreaChartItem4.Description = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedAreaChartItem4.Hint = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedSplineAreaChartItem4.Caption = "Stacked Spline Area"
			createStackedSplineAreaChartItem4.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStackedSplineAreaChartItem4.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStepAreaChartItem4.Caption = "Step Area"
			createStepAreaChartItem4.Description = "Show how much values have changed for different points of the same series."
			createStepAreaChartItem4.Hint = "Show how much values have changed for different points of the same series."
			chartControlCommandGalleryItemGroup2DArea4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem4, createFullStackedAreaChartItem4, createFullStackedSplineAreaChartItem4, createSplineAreaChartItem4, createStackedAreaChartItem4, createStackedSplineAreaChartItem4, createStepAreaChartItem4})
			chartControlCommandGalleryItemGroup3DArea4.Caption = "3-D Area"
			createArea3DChartItem4.Caption = "3-D Area"
			createArea3DChartItem4.Description = resources.GetString("createArea3DChartItem4.Description")
			createArea3DChartItem4.Hint = resources.GetString("createArea3DChartItem4.Hint")
			createFullStackedArea3DChartItem4.Caption = "100% Stacked Area in 3-D"
			createFullStackedArea3DChartItem4.Description = resources.GetString("createFullStackedArea3DChartItem4.Description")
			createFullStackedArea3DChartItem4.Hint = resources.GetString("createFullStackedArea3DChartItem4.Hint")
			createFullStackedSplineArea3DChartItem4.Caption = "100% Stacked Spline Area in 3-D"
			createFullStackedSplineArea3DChartItem4.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createFullStackedSplineArea3DChartItem4.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createSplineArea3DChartItem4.Caption = "Spline Area in 3-D"
			createSplineArea3DChartItem4.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createSplineArea3DChartItem4.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createStackedArea3DChartItem4.Caption = "Stacked Area in 3-D"
			createStackedArea3DChartItem4.Description = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedArea3DChartItem4.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedSplineArea3DChartItem4.Caption = "Stacked Spline Area in 3-D"
			createStackedSplineArea3DChartItem4.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStackedSplineArea3DChartItem4.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStepArea3DChartItem4.Caption = "Step Area in 3-D"
			createStepArea3DChartItem4.Description = "Show to what extent values have changed for different points in the same series."
			createStepArea3DChartItem4.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DArea4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem4, createFullStackedArea3DChartItem4, createFullStackedSplineArea3DChartItem4, createSplineArea3DChartItem4, createStackedArea3DChartItem4, createStackedSplineArea3DChartItem4, createStepArea3DChartItem4})
			Me.commandBarGalleryDropDown19.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea4, chartControlCommandGalleryItemGroup3DArea4})
			Me.commandBarGalleryDropDown19.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown19.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown19.Manager = Nothing
			Me.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19"
			' 
			' commandBarGalleryDropDown20
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown20.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown20.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroupPoint4.Caption = "Point"
			createPointChartItem4.Caption = "Point"
			createPointChartItem4.Description = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createPointChartItem4.Hint = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createBubbleChartItem4.Caption = "Bubble"
			createBubbleChartItem4.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			createBubbleChartItem4.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			chartControlCommandGalleryItemGroupPoint4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem4, createBubbleChartItem4})
			chartControlCommandGalleryItemGroupFunnel4.Caption = "Funnel"
			createFunnelChartItem4.Caption = "Funnel"
			createFunnelChartItem4.Description = resources.GetString("createFunnelChartItem4.Description")
			createFunnelChartItem4.Hint = resources.GetString("createFunnelChartItem4.Hint")
			createFunnel3DChartItem4.Caption = "3-D Funnel"
			createFunnel3DChartItem4.Description = resources.GetString("createFunnel3DChartItem4.Description")
			createFunnel3DChartItem4.Hint = resources.GetString("createFunnel3DChartItem4.Hint")
			chartControlCommandGalleryItemGroupFunnel4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem4, createFunnel3DChartItem4})
			chartControlCommandGalleryItemGroupFinancial4.Caption = "Financial"
			createStockChartItem4.Caption = "Stock"
			createStockChartItem4.Description = resources.GetString("createStockChartItem4.Description")
			createStockChartItem4.Hint = resources.GetString("createStockChartItem4.Hint")
			createCandleStickChartItem4.Caption = "Candle Stick"
			createCandleStickChartItem4.Description = resources.GetString("createCandleStickChartItem4.Description")
			createCandleStickChartItem4.Hint = resources.GetString("createCandleStickChartItem4.Hint")
			chartControlCommandGalleryItemGroupFinancial4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem4, createCandleStickChartItem4})
			chartControlCommandGalleryItemGroupRadar4.Caption = "Radar"
			createRadarPointChartItem4.Caption = "Radar Point"
			createRadarPointChartItem4.Description = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarPointChartItem4.Hint = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem4.Caption = "Radar Line"
			createRadarLineChartItem4.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem4.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarAreaChartItem4.Caption = "Radar Area"
			createRadarAreaChartItem4.Description = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			createRadarAreaChartItem4.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			chartControlCommandGalleryItemGroupRadar4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem4, createRadarLineChartItem4, createRadarAreaChartItem4})
			chartControlCommandGalleryItemGroupPolar4.Caption = "Polar"
			createPolarPointChartItem4.Caption = "Polar Point"
			createPolarPointChartItem4.Description = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarPointChartItem4.Hint = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarLineChartItem4.Caption = "Polar Line"
			createPolarLineChartItem4.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarLineChartItem4.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarAreaChartItem4.Caption = "Polar Area"
			createPolarAreaChartItem4.Description = "Display series as filled area on a circular diagram on the basis of angles."
			createPolarAreaChartItem4.Hint = "Display series as filled area on a circular diagram on the basis of angles."
			chartControlCommandGalleryItemGroupPolar4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem4, createPolarLineChartItem4, createPolarAreaChartItem4})
			chartControlCommandGalleryItemGroupRange4.Caption = "Range"
			createRangeBarChartItem4.Caption = "Range Column"
			createRangeBarChartItem4.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createRangeBarChartItem4.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createSideBySideRangeBarChartItem4.Caption = "Clustered Range Column"
			createSideBySideRangeBarChartItem4.Description = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createSideBySideRangeBarChartItem4.Hint = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createRangeAreaChartItem4.Caption = "Range Area"
			createRangeAreaChartItem4.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeAreaChartItem4.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem4.Caption = "Range Area in 3-D"
			createRangeArea3DChartItem4.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem4.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroupRange4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem4, createSideBySideRangeBarChartItem4, createRangeAreaChartItem4, createRangeArea3DChartItem4})
			chartControlCommandGalleryItemGroupGantt4.Caption = "Gantt"
			createGanttChartItem4.Caption = "Gantt"
			createGanttChartItem4.Description = "Track different activities during the time frame."
			createGanttChartItem4.Hint = "Track different activities during the time frame."
			createSideBySideGanttChartItem4.Caption = "Clustered Gantt"
			createSideBySideGanttChartItem4.Description = resources.GetString("createSideBySideGanttChartItem4.Description")
			createSideBySideGanttChartItem4.Hint = resources.GetString("createSideBySideGanttChartItem4.Hint")
			chartControlCommandGalleryItemGroupGantt4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem4, createSideBySideGanttChartItem4})
			Me.commandBarGalleryDropDown20.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint4, chartControlCommandGalleryItemGroupFunnel4, chartControlCommandGalleryItemGroupFinancial4, chartControlCommandGalleryItemGroupRadar4, chartControlCommandGalleryItemGroupPolar4, chartControlCommandGalleryItemGroupRange4, chartControlCommandGalleryItemGroupGantt4})
			Me.commandBarGalleryDropDown20.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown20.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown20.Manager = Nothing
			Me.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20"
			' 
			' commandBarGalleryDropDown21
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown21.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown21.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown21.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges7.Bottom = -3
			skinPaddingEdges7.Top = -3
			Me.commandBarGalleryDropDown21.Gallery.ItemImagePadding = skinPaddingEdges7
			skinPaddingEdges8.Bottom = -3
			skinPaddingEdges8.Top = -3
			Me.commandBarGalleryDropDown21.Gallery.ItemTextPadding = skinPaddingEdges8
			Me.commandBarGalleryDropDown21.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown21.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown21.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown21.Manager = Nothing
			Me.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21"
			' 
			' commandBarGalleryDropDown8
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown8.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DColumn5.Caption = "2-D Column"
			createBarChartItem5.Caption = "Clustered Column"
			createBarChartItem5.Description = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createBarChartItem5.Hint = "Compare values across categories by using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem5.Caption = "100% Stacked Column"
			createFullStackedBarChartItem5.Description = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createFullStackedBarChartItem5.Hint = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the proportion of each data " & "series." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBarChartItem5.Caption = "Clustered 100% Stacked Column"
			createSideBySideFullStackedBarChartItem5.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideFullStackedBarChartItem5.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types, so that you can stack different columns, and combine them into groups ac" & "ross the same axis value."
			createSideBySideStackedBarChartItem5.Caption = "Clustered Stacked Column"
			createSideBySideStackedBarChartItem5.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createSideBySideStackedBarChartItem5.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s, so that you can stack different columns, and combine them into groups across " & "the same axis value."
			createStackedBarChartItem5.Caption = "Stacked Column"
			createStackedBarChartItem5.Description = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			createStackedBarChartItem5.Hint = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroup2DColumn5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem5, createFullStackedBarChartItem5, createSideBySideFullStackedBarChartItem5, createSideBySideStackedBarChartItem5, createStackedBarChartItem5})
			chartControlCommandGalleryItemGroup3DColumn5.Caption = "3-D Column"
			createBar3DChartItem5.Caption = "3-D Clustered Column"
			createBar3DChartItem5.Description = "Compare values across categories and display clustered columns in 3-D format."
			createBar3DChartItem5.Hint = "Compare values across categories and display clustered columns in 3-D format."
			createFullStackedBar3DChartItem5.Caption = "100% Stacked Column in 3-D"
			createFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories and di" & "splay 100% stacked columns in 3-D format."
			createManhattanBarChartItem5.Caption = "3-D Column"
			createManhattanBarChartItem5.Description = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createManhattanBarChartItem5.Hint = "Compare values across categories and across series on three axes." & Constants.vbCrLf & Constants.vbCrLf & "Use it when " & "the categories and series are equally important." & Constants.vbCrLf & "    "
			createSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Column in 3-D"
			createSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" & " types in 3-D format, so that you can stack different columns, and combine them " & "into groups across the same axis value."
			createSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Column in 3-D"
			createSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" & "s in 3-D format, so that you can stack different columns, and combine them into " & "groups across the same axis value."
			createStackedBar3DChartItem5.Caption = "Stacked Column in 3-D"
			createStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			createStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
			chartControlCommandGalleryItemGroup3DColumn5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem5, createFullStackedBar3DChartItem5, createManhattanBarChartItem5, createSideBySideFullStackedBar3DChartItem5, createSideBySideStackedBar3DChartItem5, createStackedBar3DChartItem5})
			chartControlCommandGalleryItemGroupCylinderColumn5.Caption = "Cylinder"
			createCylinderBar3DChartItem5.Caption = "Clustered Cylinder"
			createCylinderBar3DChartItem5.Description = "Compare values across categories."
			createCylinderBar3DChartItem5.Hint = "Compare values across categories."
			createCylinderFullStackedBar3DChartItem5.Caption = "100% Stacked Cylinder"
			createCylinderFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories."
			createCylinderFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories."
			createCylinderManhattanBarChartItem5.Caption = "3-D Cylinder"
			createCylinderManhattanBarChartItem5.Description = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderManhattanBarChartItem5.Hint = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
			createCylinderSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Cylinder"
			createCylinderSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" & "hart types, so that you can stack different cylinders, and combine them into gro" & "ups across the same axis value."
			createCylinderSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Cylinder"
			createCylinderSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " & "types, so that you can stack different cylinders, and combine them into groups a" & "cross the same axis value."
			createCylinderStackedBar3DChartItem5.Caption = "Stacked Cylinder"
			createCylinderStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories."
			createCylinderStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupCylinderColumn5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem5, createCylinderFullStackedBar3DChartItem5, createCylinderManhattanBarChartItem5, createCylinderSideBySideFullStackedBar3DChartItem5, createCylinderSideBySideStackedBar3DChartItem5, createCylinderStackedBar3DChartItem5})
			chartControlCommandGalleryItemGroupConeColumn5.Caption = "Cone"
			createConeBar3DChartItem5.Caption = "Clustered Cone"
			createConeBar3DChartItem5.Description = "Compare values across categories."
			createConeBar3DChartItem5.Hint = "Compare values across categories."
			createConeFullStackedBar3DChartItem5.Caption = "100% Stacked Cone"
			createConeFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories."
			createConeFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories."
			createConeManhattanBarChartItem5.Caption = "3-D Cone"
			createConeManhattanBarChartItem5.Description = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeManhattanBarChartItem5.Hint = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
			createConeSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Cone"
			createConeSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" & "es, so that you can stack different cones, and combine them into groups across t" & "he same axis value."
			createConeSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Cone"
			createConeSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" & "o that you can stack different cones, and combine them into groups across the sa" & "me axis value."
			createConeStackedBar3DChartItem5.Caption = "Stacked Cone"
			createConeStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories."
			createConeStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupConeColumn5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem5, createConeFullStackedBar3DChartItem5, createConeManhattanBarChartItem5, createConeSideBySideFullStackedBar3DChartItem5, createConeSideBySideStackedBar3DChartItem5, createConeStackedBar3DChartItem5})
			chartControlCommandGalleryItemGroupPyramidColumn5.Caption = "Pyramid"
			createPyramidBar3DChartItem5.Caption = "Clustered Pyramid"
			createPyramidBar3DChartItem5.Description = "Compare values across categories."
			createPyramidBar3DChartItem5.Hint = "Compare values across categories."
			createPyramidFullStackedBar3DChartItem5.Caption = "100% Stacked Pyramid"
			createPyramidFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories."
			createPyramidFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories."
			createPyramidManhattanBarChartItem5.Caption = "3-D Pyramid"
			createPyramidManhattanBarChartItem5.Description = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidManhattanBarChartItem5.Hint = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
			createPyramidSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Pyramid"
			createPyramidSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" & "rt types, so that you can stack different pyramids, and combine them into groups" & " across the same axis value."
			createPyramidSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Pyramid"
			createPyramidSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" & "pes, so that you can stack different pyramids, and combine them into groups acro" & "ss the same axis value."
			createPyramidStackedBar3DChartItem5.Caption = "Stacked Pyramid"
			createPyramidStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories."
			createPyramidStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories."
			chartControlCommandGalleryItemGroupPyramidColumn5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem5, createPyramidFullStackedBar3DChartItem5, createPyramidManhattanBarChartItem5, createPyramidSideBySideFullStackedBar3DChartItem5, createPyramidSideBySideStackedBar3DChartItem5, createPyramidStackedBar3DChartItem5})
			Me.commandBarGalleryDropDown8.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn5, chartControlCommandGalleryItemGroup3DColumn5, chartControlCommandGalleryItemGroupCylinderColumn5, chartControlCommandGalleryItemGroupConeColumn5, chartControlCommandGalleryItemGroupPyramidColumn5})
			Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown8.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown8.Manager = Nothing
			Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
			' 
			' commandBarGalleryDropDown9
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown9.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown9.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DLine5.Caption = "2-D Line"
			createLineChartItem5.Caption = "Line"
			createLineChartItem5.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createLineChartItem5.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" & "e many data points and the order is important."
			createFullStackedLineChartItem5.Caption = "100% Stacked Line"
			createFullStackedLineChartItem5.Description = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createFullStackedLineChartItem5.Hint = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories."
			createScatterLineChartItem5.Caption = "Scatter Line"
			createScatterLineChartItem5.Description = "Represent series points in the same order that they have in the collection."
			createScatterLineChartItem5.Hint = "Represent series points in the same order that they have in the collection."
			createSplineChartItem5.Caption = "Spline"
			createSplineChartItem5.Description = "Plot a fitted curve through each data point in a series."
			createSplineChartItem5.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLineChartItem5.Caption = "Stacked Line"
			createStackedLineChartItem5.Description = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStackedLineChartItem5.Hint = "Display the trend of the contribution of each value over time or ordered categori" & "es."
			createStepLineChartItem5.Caption = "Step Line"
			createStepLineChartItem5.Description = "Show to what extent values have changed for different points in the same series."
			createStepLineChartItem5.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup2DLine5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem5, createFullStackedLineChartItem5, createScatterLineChartItem5, createSplineChartItem5, createStackedLineChartItem5, createStepLineChartItem5})
			chartControlCommandGalleryItemGroup3DLine5.Caption = "3-D Line"
			createLine3DChartItem5.Caption = "3-D Line"
			createLine3DChartItem5.Description = "Display each row or column of data as a 3-D ribbon on three axes."
			createLine3DChartItem5.Hint = "Display each row or column of data as a 3-D ribbon on three axes."
			createFullStackedLine3DChartItem5.Caption = "100% Stacked Line in 3-D"
			createFullStackedLine3DChartItem5.Description = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createFullStackedLine3DChartItem5.Hint = "Display all series stacked and is useful when it is necessary to compare how much" & " each series adds to the total aggregate value for specific arguments (as percen" & "ts)."
			createSpline3DChartItem5.Caption = "3-D Spline"
			createSpline3DChartItem5.Description = "Plot a fitted curve through each data point in a series."
			createSpline3DChartItem5.Hint = "Plot a fitted curve through each data point in a series."
			createStackedLine3DChartItem5.Caption = "Stacked Line in 3-D"
			createStackedLine3DChartItem5.Description = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStackedLine3DChartItem5.Hint = "Display all points from different series in a stacked manner and is useful when i" & "t is necessary to compare how much each series adds to the total aggregate value" & " for specific arguments."
			createStepLine3DChartItem5.Caption = "Step Line in 3-D"
			createStepLine3DChartItem5.Description = "Show to what extent values have changed for different points in the same series."
			createStepLine3DChartItem5.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DLine5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem5, createFullStackedLine3DChartItem5, createSpline3DChartItem5, createStackedLine3DChartItem5, createStepLine3DChartItem5})
			Me.commandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine5, chartControlCommandGalleryItemGroup3DLine5})
			Me.commandBarGalleryDropDown9.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown9.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown9.Manager = Nothing
			Me.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9"
			' 
			' commandBarGalleryDropDown10
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown10.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown10.Gallery.ColumnCount = 2
			chartControlCommandGalleryItemGroup2DPie5.Caption = "2-D Pie"
			createPieChartItem5.Caption = "Pie"
			createPieChartItem5.Description = resources.GetString("createPieChartItem5.Description")
			createPieChartItem5.Hint = resources.GetString("createPieChartItem5.Hint")
			createDoughnutChartItem5.Caption = "Doughnut"
			createDoughnutChartItem5.Description = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			createDoughnutChartItem5.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
			chartControlCommandGalleryItemGroup2DPie5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem5, createDoughnutChartItem5})
			chartControlCommandGalleryItemGroup3DPie5.Caption = "3-D Pie"
			createPie3DChartItem5.Caption = "Pie in 3-D"
			createPie3DChartItem5.Description = "Display the contribution of each value to a total."
			createPie3DChartItem5.Hint = "Display the contribution of each value to a total."
			createDoughnut3DChartItem5.Caption = "Doughnut in 3-D"
			createDoughnut3DChartItem5.Description = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			createDoughnut3DChartItem5.Hint = "Compare the percentage values of different point arguments in the same series, an" & "d illustrate these values as easy to understand pie slices, but with a hole in i" & "ts center."
			chartControlCommandGalleryItemGroup3DPie5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem5, createDoughnut3DChartItem5})
			Me.commandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie5, chartControlCommandGalleryItemGroup3DPie5})
			Me.commandBarGalleryDropDown10.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown10.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown10.Manager = Nothing
			Me.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10"
			' 
			' commandBarGalleryDropDown11
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown11.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown11.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DBar5.Caption = "2-D Bar"
			createRotatedBarChartItem5.Caption = "Bar"
			createRotatedBarChartItem5.Description = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedBarChartItem5.Hint = "Insert a bar chart." & Constants.vbCrLf & Constants.vbCrLf & "Bar charts are the best chart type for comparing multiple " & "values." & Constants.vbCrLf & "    "
			createRotatedFullStackedBarChartItem5.Caption = "100% Stacked Bar"
			createRotatedFullStackedBarChartItem5.Description = resources.GetString("createRotatedFullStackedBarChartItem5.Description")
			createRotatedFullStackedBarChartItem5.Hint = resources.GetString("createRotatedFullStackedBarChartItem5.Hint")
			createRotatedSideBySideFullStackedBarChartItem5.Caption = "Clustered 100% Stacked Bar"
			createRotatedSideBySideFullStackedBarChartItem5.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideFullStackedBarChartItem5.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" & ", so you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem5.Caption = "Clustered Stacked Bar"
			createRotatedSideBySideStackedBarChartItem5.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedSideBySideStackedBarChartItem5.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " & "that you can stack different bars, and combine them into groups across the same " & "axis value."
			createRotatedStackedBarChartItem5.Caption = "Stacked Bar"
			createRotatedStackedBarChartItem5.Description = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			createRotatedStackedBarChartItem5.Hint = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles."
			chartControlCommandGalleryItemGroup2DBar5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem5, createRotatedFullStackedBarChartItem5, createRotatedSideBySideFullStackedBarChartItem5, createRotatedSideBySideStackedBarChartItem5, createRotatedStackedBarChartItem5})
			Me.commandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar5})
			Me.commandBarGalleryDropDown11.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown11.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown11.Manager = Nothing
			Me.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11"
			' 
			' commandBarGalleryDropDown12
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown12.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown12.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DArea5.Caption = "2-D Area"
			createAreaChartItem5.Caption = "Area"
			createAreaChartItem5.Description = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createAreaChartItem5.Hint = "Insert an area chart." & Constants.vbCrLf & Constants.vbCrLf & "Area charts emphasize differences between several sets o" & "f data over a period of time." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem5.Caption = "100% Stacked Area"
			createFullStackedAreaChartItem5.Description = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedAreaChartItem5.Hint = "Display the trend of the percentage each value contributes over time or categorie" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series." & Constants.vbCrLf & "    "
			createFullStackedSplineAreaChartItem5.Caption = "100% Stacked Spline Area"
			createFullStackedSplineAreaChartItem5.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createFullStackedSplineAreaChartItem5.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" & "int in a series."
			createSplineAreaChartItem5.Caption = "Spline Area"
			createSplineAreaChartItem5.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createSplineAreaChartItem5.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" & " series."
			createStackedAreaChartItem5.Caption = "Stacked Area"
			createStackedAreaChartItem5.Description = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedAreaChartItem5.Hint = "Display the trend of the contribution of each value over time or categories." & Constants.vbCrLf & Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category." & Constants.vbCrLf & "    "
			createStackedSplineAreaChartItem5.Caption = "Stacked Spline Area"
			createStackedSplineAreaChartItem5.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStackedSplineAreaChartItem5.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" & "int in a series."
			createStepAreaChartItem5.Caption = "Step Area"
			createStepAreaChartItem5.Description = "Show how much values have changed for different points of the same series."
			createStepAreaChartItem5.Hint = "Show how much values have changed for different points of the same series."
			chartControlCommandGalleryItemGroup2DArea5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem5, createFullStackedAreaChartItem5, createFullStackedSplineAreaChartItem5, createSplineAreaChartItem5, createStackedAreaChartItem5, createStackedSplineAreaChartItem5, createStepAreaChartItem5})
			chartControlCommandGalleryItemGroup3DArea5.Caption = "3-D Area"
			createArea3DChartItem5.Caption = "3-D Area"
			createArea3DChartItem5.Description = resources.GetString("createArea3DChartItem5.Description")
			createArea3DChartItem5.Hint = resources.GetString("createArea3DChartItem5.Hint")
			createFullStackedArea3DChartItem5.Caption = "100% Stacked Area in 3-D"
			createFullStackedArea3DChartItem5.Description = resources.GetString("createFullStackedArea3DChartItem5.Description")
			createFullStackedArea3DChartItem5.Hint = resources.GetString("createFullStackedArea3DChartItem5.Hint")
			createFullStackedSplineArea3DChartItem5.Caption = "100% Stacked Spline Area in 3-D"
			createFullStackedSplineArea3DChartItem5.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createFullStackedSplineArea3DChartItem5.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " & "each data point in a series."
			createSplineArea3DChartItem5.Caption = "Spline Area in 3-D"
			createSplineArea3DChartItem5.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createSplineArea3DChartItem5.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " & "in a series."
			createStackedArea3DChartItem5.Caption = "Stacked Area in 3-D"
			createStackedArea3DChartItem5.Description = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedArea3DChartItem5.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" & "regated with the underlying data points' values."
			createStackedSplineArea3DChartItem5.Caption = "Stacked Spline Area in 3-D"
			createStackedSplineArea3DChartItem5.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStackedSplineArea3DChartItem5.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " & "data point in a series."
			createStepArea3DChartItem5.Caption = "Step Area in 3-D"
			createStepArea3DChartItem5.Description = "Show to what extent values have changed for different points in the same series."
			createStepArea3DChartItem5.Hint = "Show to what extent values have changed for different points in the same series."
			chartControlCommandGalleryItemGroup3DArea5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem5, createFullStackedArea3DChartItem5, createFullStackedSplineArea3DChartItem5, createSplineArea3DChartItem5, createStackedArea3DChartItem5, createStackedSplineArea3DChartItem5, createStepArea3DChartItem5})
			Me.commandBarGalleryDropDown12.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea5, chartControlCommandGalleryItemGroup3DArea5})
			Me.commandBarGalleryDropDown12.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown12.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown12.Manager = Nothing
			Me.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12"
			' 
			' commandBarGalleryDropDown13
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown13.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown13.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroupPoint5.Caption = "Point"
			createPointChartItem5.Caption = "Point"
			createPointChartItem5.Description = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createPointChartItem5.Hint = "Use it when it's necessary to show stand-alone data points on the same chart plot" & "."
			createBubbleChartItem5.Caption = "Bubble"
			createBubbleChartItem5.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			createBubbleChartItem5.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" & "ird value determines the size of the bubble marker."
			chartControlCommandGalleryItemGroupPoint5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem5, createBubbleChartItem5})
			chartControlCommandGalleryItemGroupFunnel5.Caption = "Funnel"
			createFunnelChartItem5.Caption = "Funnel"
			createFunnelChartItem5.Description = resources.GetString("createFunnelChartItem5.Description")
			createFunnelChartItem5.Hint = resources.GetString("createFunnelChartItem5.Hint")
			createFunnel3DChartItem5.Caption = "3-D Funnel"
			createFunnel3DChartItem5.Description = resources.GetString("createFunnel3DChartItem5.Description")
			createFunnel3DChartItem5.Hint = resources.GetString("createFunnel3DChartItem5.Hint")
			chartControlCommandGalleryItemGroupFunnel5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem5, createFunnel3DChartItem5})
			chartControlCommandGalleryItemGroupFinancial5.Caption = "Financial"
			createStockChartItem5.Caption = "Stock"
			createStockChartItem5.Description = resources.GetString("createStockChartItem5.Description")
			createStockChartItem5.Hint = resources.GetString("createStockChartItem5.Hint")
			createCandleStickChartItem5.Caption = "Candle Stick"
			createCandleStickChartItem5.Description = resources.GetString("createCandleStickChartItem5.Description")
			createCandleStickChartItem5.Hint = resources.GetString("createCandleStickChartItem5.Hint")
			chartControlCommandGalleryItemGroupFinancial5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem5, createCandleStickChartItem5})
			chartControlCommandGalleryItemGroupRadar5.Caption = "Radar"
			createRadarPointChartItem5.Caption = "Radar Point"
			createRadarPointChartItem5.Description = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarPointChartItem5.Hint = "Show points from two or more different series on the same points arguments on a c" & "ircular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem5.Caption = "Radar Line"
			createRadarLineChartItem5.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarLineChartItem5.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular grid that has multiple axes along which data can be plotted."
			createRadarAreaChartItem5.Caption = "Radar Area"
			createRadarAreaChartItem5.Description = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			createRadarAreaChartItem5.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" & "ch data can be plotted."
			chartControlCommandGalleryItemGroupRadar5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem5, createRadarLineChartItem5, createRadarAreaChartItem5})
			chartControlCommandGalleryItemGroupPolar5.Caption = "Polar"
			createPolarPointChartItem5.Caption = "Polar Point"
			createPolarPointChartItem5.Description = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarPointChartItem5.Hint = "Show points from two or more different series on the same circular diagram on the" & " basis of angles."
			createPolarLineChartItem5.Caption = "Polar Line"
			createPolarLineChartItem5.Description = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarLineChartItem5.Hint = "Show trends for several series and compare their values for the same points argum" & "ents on a circular diagram on the basis of angles."
			createPolarAreaChartItem5.Caption = "Polar Area"
			createPolarAreaChartItem5.Description = "Display series as filled area on a circular diagram on the basis of angles."
			createPolarAreaChartItem5.Hint = "Display series as filled area on a circular diagram on the basis of angles."
			chartControlCommandGalleryItemGroupPolar5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem5, createPolarLineChartItem5, createPolarAreaChartItem5})
			chartControlCommandGalleryItemGroupRange5.Caption = "Range"
			createRangeBarChartItem5.Caption = "Range Column"
			createRangeBarChartItem5.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createRangeBarChartItem5.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" & "sents a range of data for each argument value."
			createSideBySideRangeBarChartItem5.Caption = "Clustered Range Column"
			createSideBySideRangeBarChartItem5.Description = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createSideBySideRangeBarChartItem5.Hint = "Show activity columns from different series grouped by their arguments. Each colu" & "mn represents a range of data with two values for each argument value."
			createRangeAreaChartItem5.Caption = "Range Area"
			createRangeAreaChartItem5.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeAreaChartItem5.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem5.Caption = "Range Area in 3-D"
			createRangeArea3DChartItem5.Description = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			createRangeArea3DChartItem5.Hint = "Display series as filled areas on a diagram, with two data points that define min" & "imum and maximum limits." & Constants.vbCrLf & Constants.vbCrLf & "Use it when you need to accentuate the delta between" & " start and end values." & Constants.vbCrLf & "    "
			chartControlCommandGalleryItemGroupRange5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem5, createSideBySideRangeBarChartItem5, createRangeAreaChartItem5, createRangeArea3DChartItem5})
			chartControlCommandGalleryItemGroupGantt5.Caption = "Gantt"
			createGanttChartItem5.Caption = "Gantt"
			createGanttChartItem5.Description = "Track different activities during the time frame."
			createGanttChartItem5.Hint = "Track different activities during the time frame."
			createSideBySideGanttChartItem5.Caption = "Clustered Gantt"
			createSideBySideGanttChartItem5.Description = resources.GetString("createSideBySideGanttChartItem5.Description")
			createSideBySideGanttChartItem5.Hint = resources.GetString("createSideBySideGanttChartItem5.Hint")
			chartControlCommandGalleryItemGroupGantt5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem5, createSideBySideGanttChartItem5})
			Me.commandBarGalleryDropDown13.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint5, chartControlCommandGalleryItemGroupFunnel5, chartControlCommandGalleryItemGroupFinancial5, chartControlCommandGalleryItemGroupRadar5, chartControlCommandGalleryItemGroupPolar5, chartControlCommandGalleryItemGroupRange5, chartControlCommandGalleryItemGroupGantt5})
			Me.commandBarGalleryDropDown13.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown13.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown13.Manager = Nothing
			Me.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13"
			' 
			' commandBarGalleryDropDown14
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown14.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown14.Gallery.ColumnCount = 1
			Me.commandBarGalleryDropDown14.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges9.Bottom = -3
			skinPaddingEdges9.Top = -3
			Me.commandBarGalleryDropDown14.Gallery.ItemImagePadding = skinPaddingEdges9
			skinPaddingEdges10.Bottom = -3
			skinPaddingEdges10.Top = -3
			Me.commandBarGalleryDropDown14.Gallery.ItemTextPadding = skinPaddingEdges10
			Me.commandBarGalleryDropDown14.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown14.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown14.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown14.Manager = Nothing
			Me.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14"
			' 
			' commandBarGalleryDropDown1
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DColumn6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem6, createFullStackedBarChartItem6, createSideBySideFullStackedBarChartItem6, createSideBySideStackedBarChartItem6, createStackedBarChartItem6})
			chartControlCommandGalleryItemGroup3DColumn6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem6, createFullStackedBar3DChartItem6, createManhattanBarChartItem6, createSideBySideFullStackedBar3DChartItem6, createSideBySideStackedBar3DChartItem6, createStackedBar3DChartItem6})
			chartControlCommandGalleryItemGroupCylinderColumn6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem6, createCylinderFullStackedBar3DChartItem6, createCylinderManhattanBarChartItem6, createCylinderSideBySideFullStackedBar3DChartItem6, createCylinderSideBySideStackedBar3DChartItem6, createCylinderStackedBar3DChartItem6})
			chartControlCommandGalleryItemGroupConeColumn6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem6, createConeFullStackedBar3DChartItem6, createConeManhattanBarChartItem6, createConeSideBySideFullStackedBar3DChartItem6, createConeSideBySideStackedBar3DChartItem6, createConeStackedBar3DChartItem6})
			chartControlCommandGalleryItemGroupPyramidColumn6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem6, createPyramidFullStackedBar3DChartItem6, createPyramidManhattanBarChartItem6, createPyramidSideBySideFullStackedBar3DChartItem6, createPyramidSideBySideStackedBar3DChartItem6, createPyramidStackedBar3DChartItem6})
			Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn6, chartControlCommandGalleryItemGroup3DColumn6, chartControlCommandGalleryItemGroupCylinderColumn6, chartControlCommandGalleryItemGroupConeColumn6, chartControlCommandGalleryItemGroupPyramidColumn6})
			Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown1.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown1.Manager = Nothing
			Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
			' 
			' commandBarGalleryDropDown2
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown2.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DLine6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem6, createFullStackedLineChartItem6, createScatterLineChartItem6, createSplineChartItem6, createStackedLineChartItem6, createStepLineChartItem6})
			chartControlCommandGalleryItemGroup3DLine6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem6, createFullStackedLine3DChartItem6, createSpline3DChartItem6, createStackedLine3DChartItem6, createStepLine3DChartItem6})
			Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine6, chartControlCommandGalleryItemGroup3DLine6})
			Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown2.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown2.Manager = Nothing
			Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
			' 
			' commandBarGalleryDropDown3
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown3.Gallery.ColumnCount = 2
			chartControlCommandGalleryItemGroup2DPie6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem6, createDoughnutChartItem6})
			chartControlCommandGalleryItemGroup3DPie6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem6, createDoughnut3DChartItem6})
			Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie6, chartControlCommandGalleryItemGroup3DPie6})
			Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown3.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown3.Manager = Nothing
			Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
			' 
			' commandBarGalleryDropDown4
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown4.Gallery.ColumnCount = 3
			chartControlCommandGalleryItemGroup2DBar6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem6, createRotatedFullStackedBarChartItem6, createRotatedSideBySideFullStackedBarChartItem6, createRotatedSideBySideStackedBarChartItem6, createRotatedStackedBarChartItem6})
			Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar6})
			Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown4.Gallery.RowCount = 2
			Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown4.Manager = Nothing
			Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
			' 
			' commandBarGalleryDropDown5
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroup2DArea6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem6, createFullStackedAreaChartItem6, createFullStackedSplineAreaChartItem6, createSplineAreaChartItem6, createStackedAreaChartItem6, createStackedSplineAreaChartItem6, createStepAreaChartItem6})
			chartControlCommandGalleryItemGroup3DArea6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem6, createFullStackedArea3DChartItem6, createFullStackedSplineArea3DChartItem6, createSplineArea3DChartItem6, createStackedArea3DChartItem6, createStackedSplineArea3DChartItem6, createStepArea3DChartItem6})
			Me.commandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea6, chartControlCommandGalleryItemGroup3DArea6})
			Me.commandBarGalleryDropDown5.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown5.Gallery.RowCount = 4
			Me.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown5.Manager = Nothing
			Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
			' 
			' commandBarGalleryDropDown6
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown6.Gallery.ColumnCount = 4
			chartControlCommandGalleryItemGroupPoint6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem6, createBubbleChartItem6})
			chartControlCommandGalleryItemGroupFunnel6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem6, createFunnel3DChartItem6})
			chartControlCommandGalleryItemGroupFinancial6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem6, createCandleStickChartItem6})
			chartControlCommandGalleryItemGroupRadar6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem6, createRadarLineChartItem6, createRadarAreaChartItem6})
			chartControlCommandGalleryItemGroupPolar6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem6, createPolarLineChartItem6, createPolarAreaChartItem6})
			chartControlCommandGalleryItemGroupRange6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem6, createSideBySideRangeBarChartItem6, createRangeAreaChartItem6, createRangeArea3DChartItem6})
			chartControlCommandGalleryItemGroupGantt6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem6, createSideBySideGanttChartItem6})
			Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint6, chartControlCommandGalleryItemGroupFunnel6, chartControlCommandGalleryItemGroupFinancial6, chartControlCommandGalleryItemGroupRadar6, chartControlCommandGalleryItemGroupPolar6, chartControlCommandGalleryItemGroupRange6, chartControlCommandGalleryItemGroupGantt6})
			Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.commandBarGalleryDropDown6.Gallery.RowCount = 7
			Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown6.Manager = Nothing
			Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
			' 
			' commandBarGalleryDropDown7
			' 
			' 
			' 
			' 
			Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.commandBarGalleryDropDown7.Gallery.ColumnCount = 1
			changePaletteGalleryItem1.Caption = "Apex"
			changePaletteGalleryItem1.Image = (CType(resources.GetObject("changePaletteGalleryItem1.Image"), System.Drawing.Image))
			changePaletteGalleryItem1.Tag = "Apex"
			changePaletteGalleryItem2.Caption = "Aspect"
			changePaletteGalleryItem2.Image = (CType(resources.GetObject("changePaletteGalleryItem2.Image"), System.Drawing.Image))
			changePaletteGalleryItem2.Tag = "Aspect"
			changePaletteGalleryItem3.Caption = "Black and White"
			changePaletteGalleryItem3.Image = (CType(resources.GetObject("changePaletteGalleryItem3.Image"), System.Drawing.Image))
			changePaletteGalleryItem3.Tag = "Black and White"
			changePaletteGalleryItem4.Caption = "Chameleon"
			changePaletteGalleryItem4.Image = (CType(resources.GetObject("changePaletteGalleryItem4.Image"), System.Drawing.Image))
			changePaletteGalleryItem4.Tag = "Chameleon"
			changePaletteGalleryItem5.Caption = "Civic"
			changePaletteGalleryItem5.Image = (CType(resources.GetObject("changePaletteGalleryItem5.Image"), System.Drawing.Image))
			changePaletteGalleryItem5.Tag = "Civic"
			changePaletteGalleryItem6.Caption = "Concourse"
			changePaletteGalleryItem6.Image = (CType(resources.GetObject("changePaletteGalleryItem6.Image"), System.Drawing.Image))
			changePaletteGalleryItem6.Tag = "Concourse"
			changePaletteGalleryItem7.Caption = "Default"
			changePaletteGalleryItem7.Checked = True
			changePaletteGalleryItem7.Image = (CType(resources.GetObject("changePaletteGalleryItem7.Image"), System.Drawing.Image))
			changePaletteGalleryItem7.Tag = "Default"
			changePaletteGalleryItem8.Caption = "Equity"
			changePaletteGalleryItem8.Image = (CType(resources.GetObject("changePaletteGalleryItem8.Image"), System.Drawing.Image))
			changePaletteGalleryItem8.Tag = "Equity"
			changePaletteGalleryItem9.Caption = "Flow"
			changePaletteGalleryItem9.Image = (CType(resources.GetObject("changePaletteGalleryItem9.Image"), System.Drawing.Image))
			changePaletteGalleryItem9.Tag = "Flow"
			changePaletteGalleryItem10.Caption = "Foundry"
			changePaletteGalleryItem10.Image = (CType(resources.GetObject("changePaletteGalleryItem10.Image"), System.Drawing.Image))
			changePaletteGalleryItem10.Tag = "Foundry"
			changePaletteGalleryItem11.Caption = "Grayscale"
			changePaletteGalleryItem11.Image = (CType(resources.GetObject("changePaletteGalleryItem11.Image"), System.Drawing.Image))
			changePaletteGalleryItem11.Tag = "Grayscale"
			changePaletteGalleryItem12.Caption = "In A Fog"
			changePaletteGalleryItem12.Image = (CType(resources.GetObject("changePaletteGalleryItem12.Image"), System.Drawing.Image))
			changePaletteGalleryItem12.Tag = "In A Fog"
			changePaletteGalleryItem13.Caption = "Median"
			changePaletteGalleryItem13.Image = (CType(resources.GetObject("changePaletteGalleryItem13.Image"), System.Drawing.Image))
			changePaletteGalleryItem13.Tag = "Median"
			changePaletteGalleryItem14.Caption = "Metro"
			changePaletteGalleryItem14.Image = (CType(resources.GetObject("changePaletteGalleryItem14.Image"), System.Drawing.Image))
			changePaletteGalleryItem14.Tag = "Metro"
			changePaletteGalleryItem15.Caption = "Module"
			changePaletteGalleryItem15.Image = (CType(resources.GetObject("changePaletteGalleryItem15.Image"), System.Drawing.Image))
			changePaletteGalleryItem15.Tag = "Module"
			changePaletteGalleryItem16.Caption = "Nature Colors"
			changePaletteGalleryItem16.Image = (CType(resources.GetObject("changePaletteGalleryItem16.Image"), System.Drawing.Image))
			changePaletteGalleryItem16.Tag = "Nature Colors"
			changePaletteGalleryItem17.Caption = "Northern Lights"
			changePaletteGalleryItem17.Image = (CType(resources.GetObject("changePaletteGalleryItem17.Image"), System.Drawing.Image))
			changePaletteGalleryItem17.Tag = "Northern Lights"
			changePaletteGalleryItem18.Caption = "Office"
			changePaletteGalleryItem18.Image = (CType(resources.GetObject("changePaletteGalleryItem18.Image"), System.Drawing.Image))
			changePaletteGalleryItem18.Tag = "Office"
			changePaletteGalleryItem19.Caption = "Opulent"
			changePaletteGalleryItem19.Image = (CType(resources.GetObject("changePaletteGalleryItem19.Image"), System.Drawing.Image))
			changePaletteGalleryItem19.Tag = "Opulent"
			changePaletteGalleryItem20.Caption = "Oriel"
			changePaletteGalleryItem20.Image = (CType(resources.GetObject("changePaletteGalleryItem20.Image"), System.Drawing.Image))
			changePaletteGalleryItem20.Tag = "Oriel"
			changePaletteGalleryItem21.Caption = "Origin"
			changePaletteGalleryItem21.Image = (CType(resources.GetObject("changePaletteGalleryItem21.Image"), System.Drawing.Image))
			changePaletteGalleryItem21.Tag = "Origin"
			changePaletteGalleryItem22.Caption = "Paper"
			changePaletteGalleryItem22.Image = (CType(resources.GetObject("changePaletteGalleryItem22.Image"), System.Drawing.Image))
			changePaletteGalleryItem22.Tag = "Paper"
			changePaletteGalleryItem23.Caption = "Pastel Kit"
			changePaletteGalleryItem23.Image = (CType(resources.GetObject("changePaletteGalleryItem23.Image"), System.Drawing.Image))
			changePaletteGalleryItem23.Tag = "Pastel Kit"
			changePaletteGalleryItem24.Caption = "Solstice"
			changePaletteGalleryItem24.Image = (CType(resources.GetObject("changePaletteGalleryItem24.Image"), System.Drawing.Image))
			changePaletteGalleryItem24.Tag = "Solstice"
			changePaletteGalleryItem25.Caption = "Technic"
			changePaletteGalleryItem25.Image = (CType(resources.GetObject("changePaletteGalleryItem25.Image"), System.Drawing.Image))
			changePaletteGalleryItem25.Tag = "Technic"
			changePaletteGalleryItem26.Caption = "Terracotta Pie"
			changePaletteGalleryItem26.Image = (CType(resources.GetObject("changePaletteGalleryItem26.Image"), System.Drawing.Image))
			changePaletteGalleryItem26.Tag = "Terracotta Pie"
			changePaletteGalleryItem27.Caption = "The Mixed"
			changePaletteGalleryItem27.Image = (CType(resources.GetObject("changePaletteGalleryItem27.Image"), System.Drawing.Image))
			changePaletteGalleryItem27.Tag = "Mixed"
			changePaletteGalleryItem28.Caption = "The Trees"
			changePaletteGalleryItem28.Image = (CType(resources.GetObject("changePaletteGalleryItem28.Image"), System.Drawing.Image))
			changePaletteGalleryItem28.Tag = "The Trees"
			changePaletteGalleryItem29.Caption = "Trek"
			changePaletteGalleryItem29.Image = (CType(resources.GetObject("changePaletteGalleryItem29.Image"), System.Drawing.Image))
			changePaletteGalleryItem29.Tag = "Trek"
			changePaletteGalleryItem30.Caption = "Urban"
			changePaletteGalleryItem30.Image = (CType(resources.GetObject("changePaletteGalleryItem30.Image"), System.Drawing.Image))
			changePaletteGalleryItem30.Tag = "Urban"
			changePaletteGalleryItem31.Caption = "Verve"
			changePaletteGalleryItem31.Image = (CType(resources.GetObject("changePaletteGalleryItem31.Image"), System.Drawing.Image))
			changePaletteGalleryItem31.Tag = "Verve"
			galleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { changePaletteGalleryItem1, changePaletteGalleryItem2, changePaletteGalleryItem3, changePaletteGalleryItem4, changePaletteGalleryItem5, changePaletteGalleryItem6, changePaletteGalleryItem7, changePaletteGalleryItem8, changePaletteGalleryItem9, changePaletteGalleryItem10, changePaletteGalleryItem11, changePaletteGalleryItem12, changePaletteGalleryItem13, changePaletteGalleryItem14, changePaletteGalleryItem15, changePaletteGalleryItem16, changePaletteGalleryItem17, changePaletteGalleryItem18, changePaletteGalleryItem19, changePaletteGalleryItem20, changePaletteGalleryItem21, changePaletteGalleryItem22, changePaletteGalleryItem23, changePaletteGalleryItem24, changePaletteGalleryItem25, changePaletteGalleryItem26, changePaletteGalleryItem27, changePaletteGalleryItem28, changePaletteGalleryItem29, changePaletteGalleryItem30, changePaletteGalleryItem31})
			Me.commandBarGalleryDropDown7.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup4})
			Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(160, 10)
			Me.commandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
			Me.commandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
			skinPaddingEdges11.Bottom = -3
			skinPaddingEdges11.Top = -3
			Me.commandBarGalleryDropDown7.Gallery.ItemImagePadding = skinPaddingEdges11
			skinPaddingEdges12.Bottom = -3
			skinPaddingEdges12.Top = -3
			Me.commandBarGalleryDropDown7.Gallery.ItemTextPadding = skinPaddingEdges12
			Me.commandBarGalleryDropDown7.Gallery.RowCount = 10
			Me.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
			Me.commandBarGalleryDropDown7.Gallery.ShowItemText = True
			Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.commandBarGalleryDropDown7.Manager = Nothing
			Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
			' 
			' snapDockManager1
			' 
			Me.snapDockManager1.Form = Me
			Me.snapDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.snapDockManager1.SnapControl = Me.snapControl1
			Me.snapDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
			Me.panelContainer1.Controls.Add(Me.reportExplorerDockPanel1)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.panelContainer1.ID = New System.Guid("ec84028d-fae9-41e9-bbdd-ab7d0b1dac6a")
			Me.panelContainer1.Location = New System.Drawing.Point(922, 141)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.panelContainer1.Size = New System.Drawing.Size(200, 523)
			Me.panelContainer1.Text = "panelContainer1"
			' 
			' fieldListDockPanel1
			' 
			Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
			Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.fieldListDockPanel1.ID = New System.Guid("5c850da2-ed26-4e09-b1e1-da019019a60d")
			Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
			Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 261)
			Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 262)
			Me.fieldListDockPanel1.SnapControl = Me.snapControl1
			' 
			' fieldListDockPanel1_Container
			' 
			Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
			Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(192, 235)
			Me.fieldListDockPanel1_Container.TabIndex = 0
			' 
			' reportExplorerDockPanel1
			' 
			Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
			Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.reportExplorerDockPanel1.ID = New System.Guid("a5a1f29d-7234-46dd-ae96-25f04498abfe")
			Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(0, 262)
			Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
			Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 261)
			Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(200, 261)
			Me.reportExplorerDockPanel1.SnapControl = Me.snapControl1
			' 
			' reportExplorerDockPanel1_Container
			' 
			Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
			Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(192, 234)
			Me.reportExplorerDockPanel1_Container.TabIndex = 0
			' 
			' snapDocumentManager1
			' 
			Me.snapDocumentManager1.ClientControl = Me.snapControl1
			Me.snapDocumentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False
			Me.snapDocumentManager1.View = Me.noDocumentsView1
			Me.snapDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1})
			' 
			' snapBarController1
			' 
			Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
			Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem1)
			Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.snapBarController1.BarItems.Add(Me.printItem1)
			Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.snapBarController1.BarItems.Add(Me.undoItem1)
			Me.snapBarController1.BarItems.Add(Me.redoItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem2)
			Me.snapBarController1.BarItems.Add(Me.pasteItem1)
			Me.snapBarController1.BarItems.Add(Me.cutItem1)
			Me.snapBarController1.BarItems.Add(Me.copyItem1)
			Me.snapBarController1.BarItems.Add(Me.pasteSpecialItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFontNameItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFontSizeItem1)
			Me.snapBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
			Me.snapBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontBoldItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontItalicItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFontColorItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFontBackColorItem1)
			Me.snapBarController1.BarItems.Add(Me.changeTextCaseItem1)
			Me.snapBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
			Me.snapBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
			Me.snapBarController1.BarItems.Add(Me.capitalizeEachWordCaseItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTextCaseItem1)
			Me.snapBarController1.BarItems.Add(Me.clearFormattingItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleBulletedListItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleNumberingListItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
			Me.snapBarController1.BarItems.Add(Me.decreaseIndentItem1)
			Me.snapBarController1.BarItems.Add(Me.increaseIndentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
			Me.snapBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
			Me.snapBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
			Me.snapBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
			Me.snapBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
			Me.snapBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
			Me.snapBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
			Me.snapBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
			Me.snapBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
			Me.snapBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
			Me.snapBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
			Me.snapBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
			Me.snapBarController1.BarItems.Add(Me.findItem1)
			Me.snapBarController1.BarItems.Add(Me.replaceItem1)
			Me.snapBarController1.BarItems.Add(Me.insertPageBreakItem21)
			Me.snapBarController1.BarItems.Add(Me.insertTableItem1)
			Me.snapBarController1.BarItems.Add(Me.insertPictureItem1)
			Me.snapBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem3)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem4)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem5)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem6)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem7)
			Me.snapBarController1.BarItems.Add(Me.insertBookmarkItem1)
			Me.snapBarController1.BarItems.Add(Me.insertHyperlinkItem1)
			Me.snapBarController1.BarItems.Add(Me.editPageHeaderItem1)
			Me.snapBarController1.BarItems.Add(Me.editPageFooterItem1)
			Me.snapBarController1.BarItems.Add(Me.insertPageNumberItem1)
			Me.snapBarController1.BarItems.Add(Me.insertPageCountItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTextBoxItem1)
			Me.snapBarController1.BarItems.Add(Me.insertSymbolItem1)
			Me.snapBarController1.BarItems.Add(Me.changeSectionPageMarginsItem1)
			Me.snapBarController1.BarItems.Add(Me.setNormalSectionPageMarginsItem1)
			Me.snapBarController1.BarItems.Add(Me.setNarrowSectionPageMarginsItem1)
			Me.snapBarController1.BarItems.Add(Me.setModerateSectionPageMarginsItem1)
			Me.snapBarController1.BarItems.Add(Me.setWideSectionPageMarginsItem1)
			Me.snapBarController1.BarItems.Add(Me.showPageMarginsSetupFormItem1)
			Me.snapBarController1.BarItems.Add(Me.changeSectionPageOrientationItem1)
			Me.snapBarController1.BarItems.Add(Me.setPortraitPageOrientationItem1)
			Me.snapBarController1.BarItems.Add(Me.setLandscapePageOrientationItem1)
			Me.snapBarController1.BarItems.Add(Me.changeSectionPaperKindItem1)
			Me.snapBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
			Me.snapBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
			Me.snapBarController1.BarItems.Add(Me.insertBreakItem1)
			Me.snapBarController1.BarItems.Add(Me.insertPageBreakItem1)
			Me.snapBarController1.BarItems.Add(Me.insertColumnBreakItem1)
			Me.snapBarController1.BarItems.Add(Me.insertSectionBreakNextPageItem1)
			Me.snapBarController1.BarItems.Add(Me.insertSectionBreakEvenPageItem1)
			Me.snapBarController1.BarItems.Add(Me.insertSectionBreakOddPageItem1)
			Me.snapBarController1.BarItems.Add(Me.changeSectionLineNumberingItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingNoneItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingContinuousItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewPageItem1)
			Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewSectionItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleParagraphSuppressLineNumbersItem1)
			Me.snapBarController1.BarItems.Add(Me.showLineNumberingFormItem1)
			Me.snapBarController1.BarItems.Add(Me.changePageColorItem1)
			Me.snapBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
			Me.snapBarController1.BarItems.Add(Me.switchToDraftViewItem1)
			Me.snapBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleShowHorizontalRulerItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleShowVerticalRulerItem1)
			Me.snapBarController1.BarItems.Add(Me.zoomOutItem1)
			Me.snapBarController1.BarItems.Add(Me.zoomInItem1)
			Me.snapBarController1.BarItems.Add(Me.snapBarToolbarsListItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem1)
			Me.snapBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
			Me.snapBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFieldHighlightingItem1)
			Me.snapBarController1.BarItems.Add(Me.goToPageHeaderItem1)
			Me.snapBarController1.BarItems.Add(Me.goToPageFooterItem1)
			Me.snapBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
			Me.snapBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
			Me.snapBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFirstRowItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleLastRowItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleBandedRowsItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleFirstColumnItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleLastColumnItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleBandedColumnItem1)
			Me.snapBarController1.BarItems.Add(Me.galleryChangeTableStyleItem1)
			Me.snapBarController1.BarItems.Add(Me.galleryChangeTableCellStyleItem1)
			Me.snapBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
			Me.snapBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
			Me.snapBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
			Me.snapBarController1.BarItems.Add(Me.changeTableBordersItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
			Me.snapBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
			Me.snapBarController1.BarItems.Add(Me.selectTableElementsItem1)
			Me.snapBarController1.BarItems.Add(Me.selectTableCellItem1)
			Me.snapBarController1.BarItems.Add(Me.selectTableColumnItem1)
			Me.snapBarController1.BarItems.Add(Me.selectTableRowItem1)
			Me.snapBarController1.BarItems.Add(Me.selectTableItem1)
			Me.snapBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
			Me.snapBarController1.BarItems.Add(Me.deleteTableElementsItem1)
			Me.snapBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
			Me.snapBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
			Me.snapBarController1.BarItems.Add(Me.deleteTableRowsItem1)
			Me.snapBarController1.BarItems.Add(Me.deleteTableItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
			Me.snapBarController1.BarItems.Add(Me.mergeTableCellsItem1)
			Me.snapBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
			Me.snapBarController1.BarItems.Add(Me.splitTableItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.showTableOptionsFormItem1)
			Me.snapBarController1.BarItems.Add(Me.checkSpellingItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTableOfContentsItem1)
			Me.snapBarController1.BarItems.Add(Me.updateTableOfContentsItem1)
			Me.snapBarController1.BarItems.Add(Me.addParagraphsToTableOfContentItem1)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem1)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem2)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem3)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem4)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem5)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem6)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem7)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem8)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem9)
			Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem10)
			Me.snapBarController1.BarItems.Add(Me.insertCaptionPlaceholderItem1)
			Me.snapBarController1.BarItems.Add(Me.insertFiguresCaptionItems1)
			Me.snapBarController1.BarItems.Add(Me.insertTablesCaptionItems1)
			Me.snapBarController1.BarItems.Add(Me.insertEquationsCaptionItems1)
			Me.snapBarController1.BarItems.Add(Me.insertTableOfFiguresPlaceholderItem1)
			Me.snapBarController1.BarItems.Add(Me.insertTableOfFiguresItems1)
			Me.snapBarController1.BarItems.Add(Me.insertTableOfTablesItems1)
			Me.snapBarController1.BarItems.Add(Me.insertTableOfEquationsItems1)
			Me.snapBarController1.BarItems.Add(Me.updateTableOfFiguresItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectFillColorItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectOutlineColorItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectOutlineWeightItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectSquareTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTightTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectThroughTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBehindTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
			Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopLeftAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopCenterAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopRightAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleLeftAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleCenterAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleRightAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomLeftAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomCenterAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomRightAlignmentItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectBringForwardSubItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectBringForwardItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectBringToFrontItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectBringInFrontOfTextItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBackwardSubItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBackwardItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectSendToBackItem1)
			Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBehindTextItem1)
			Me.snapBarController1.BarItems.Add(Me.themesGalleryBarItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem2)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem3)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem4)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem5)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem6)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem7)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem8)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem9)
			Me.snapBarController1.BarItems.Add(Me.filterPopupButtonItem1)
			Me.snapBarController1.BarItems.Add(Me.propertiesBarButtonItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem2)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem10)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem11)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem3)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem12)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem13)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem8)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem9)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem4)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem14)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem15)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem16)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem17)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem18)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem19)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem20)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem5)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem21)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem22)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem6)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem23)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem24)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem7)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem25)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem26)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem27)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem28)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem29)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem30)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem31)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem10)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem11)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem12)
			Me.snapBarController1.BarItems.Add(Me.changeEditorRowLimitItem1)
			Me.snapBarController1.BarItems.Add(Me.createBarBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.createLineBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.createPieBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.createRotatedBarBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.createAreaBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.createOtherSeriesTypesBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.changePaletteGalleryBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.changeAppearanceGalleryBaseItem1)
			Me.snapBarController1.BarItems.Add(Me.runWizardChartItem1)
			Me.snapBarController1.BarItems.Add(Me.mailMergeDataSourceItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem32)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem33)
			Me.snapBarController1.BarItems.Add(Me.mailMergeCurrentRecordItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem8)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem13)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem14)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem15)
			Me.snapBarController1.BarItems.Add(Me.runDesignerChartItem1)
			Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.headerFooterToolsRibbonPageCategory1))
			Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.tableToolsRibbonPageCategory1))
			Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.floatingPictureToolsRibbonPageCategory1))
			Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.dataToolsRibbonPageCategory1))
			Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.chartRibbonPageCategory1))
			Me.snapBarController1.Control = Me.snapControl1
			Me.snapBarController1.RibbonControl = Me.ribbonControl1
			Me.snapBarController1.SnapDockManager = Me.snapDockManager1
			' 
			' chartTypeRibbonPageGroup1
			' 
			Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createBarBaseItem1)
			Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createLineBaseItem1)
			Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createPieBaseItem1)
			Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createRotatedBarBaseItem1)
			Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createAreaBaseItem1)
			Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createOtherSeriesTypesBaseItem1)
			Me.chartTypeRibbonPageGroup1.Name = "chartTypeRibbonPageGroup1"
			' 
			' createChartRibbonPage1
			' 
			Me.createChartRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartTypeRibbonPageGroup1, Me.chartAppearanceRibbonPageGroup1, Me.chartWizardRibbonPageGroup1})
			Me.createChartRibbonPage1.Name = "createChartRibbonPage1"
			' 
			' chartRibbonPageCategory1
			' 
			Me.chartRibbonPageCategory1.Control = Nothing
			Me.chartRibbonPageCategory1.Name = "chartRibbonPageCategory1"
			Me.chartRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.createChartRibbonPage1})
			' 
			' chartAppearanceRibbonPageGroup1
			' 
			Me.chartAppearanceRibbonPageGroup1.ItemLinks.Add(Me.changePaletteGalleryBaseItem1)
			Me.chartAppearanceRibbonPageGroup1.ItemLinks.Add(Me.changeAppearanceGalleryBaseItem1)
			Me.chartAppearanceRibbonPageGroup1.Name = "chartAppearanceRibbonPageGroup1"
			' 
			' chartWizardRibbonPageGroup1
			' 
			Me.chartWizardRibbonPageGroup1.AllowMinimize = False
			Me.chartWizardRibbonPageGroup1.ItemLinks.Add(Me.runDesignerChartItem1)
			Me.chartWizardRibbonPageGroup1.Name = "chartWizardRibbonPageGroup1"
			' 
			' runDesignerChartItem1
			' 
			Me.runDesignerChartItem1.Id = 616
			Me.runDesignerChartItem1.Name = "runDesignerChartItem1"
			' 
			' BaseTutorial
			' 
			Me.Controls.Add(Me.snapControl1)
			Me.Controls.Add(Me.panelContainer1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "BaseTutorial"
			Me.Size = New System.Drawing.Size(1122, 664)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditFontSizeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemBorderLineStyle2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemBorderLineWeight2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFloatingObjectOutlineWeight2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemEditorRowLimitEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown36, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown37, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown38, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown39, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown40, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown41, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown42, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMailMergeCurrentRecordEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown29, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown30, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown31, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown32, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown33, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown34, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown35, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown22, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown23, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown24, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown25, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown26, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown27, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown28, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.fieldListDockPanel1.ResumeLayout(False)
			Me.reportExplorerDockPanel1.ResumeLayout(False)
			CType(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Public snapControl1 As DevExpress.Snap.SnapControl
		Private snapDockManager1 As DevExpress.Snap.Extensions.SnapDockManager
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private fieldListDockPanel1 As DevExpress.Snap.Extensions.UI.FieldListDockPanel
		Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private reportExplorerDockPanel1 As DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel
		Private reportExplorerDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private snapDocumentManager1 As DevExpress.Snap.Extensions.SnapDocumentManager
		Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
		Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown9 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown10 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown11 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown12 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown13 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown14 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown15 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown16 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown17 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown18 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown19 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown20 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown21 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown22 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown23 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown24 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown25 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown26 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown27 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown28 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
		Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
		Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
		Private repositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
		Private repositoryItemEditorRowLimitEdit1 As DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit
		Private commandBarGalleryDropDown29 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown30 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown31 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown32 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown33 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown34 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private commandBarGalleryDropDown35 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private repositoryItemMailMergeCurrentRecordEdit1 As DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private commandBarItem2 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
		Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
		Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
		Private repositoryItemFontEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
		Private repositoryItemRichEditFontSizeEdit2 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
		Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
		Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
		Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
		Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
		Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
		Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
		Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
		Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
		Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
		Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
		Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
		Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
		Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
		Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
		Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
		Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
		Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
		Private capitalizeEachWordCaseItem1 As DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem
		Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
		Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
		Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
		Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
		Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
		Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
		Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
		Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
		Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
		Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
		Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
		Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
		Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
		Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
		Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
		Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
		Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
		Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
		Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
		Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
		Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
		Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
		Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
		Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
		Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
		Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
		Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
		Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
		Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
		Private insertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2
		Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
		Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
		Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
		Private commandBarItem3 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem4 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem5 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem6 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem7 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
		Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
		Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
		Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
		Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
		Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
		Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
		Private changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
		Private setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
		Private setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
		Private setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
		Private setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
		Private showPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
		Private changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
		Private setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
		Private setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
		Private changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
		Private changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
		Private setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
		Private setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
		Private setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
		Private showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
		Private insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
		Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
		Private insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
		Private insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
		Private insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
		Private insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
		Private changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
		Private setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
		Private setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
		Private setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
		Private setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
		Private toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
		Private showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
		Private changePageColorItem1 As DevExpress.XtraRichEdit.UI.ChangePageColorItem
		Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
		Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
		Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
		Private toggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
		Private toggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
		Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
		Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
		Private snapBarToolbarsListItem1 As DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem
		Private commandBarCheckItem1 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
		Private toggleFieldHighlightingItem1 As DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem
		Private goToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
		Private goToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
		Private goToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
		Private goToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
		Private toggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
		Private toggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
		Private toggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
		Private closePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
		Private toggleFirstRowItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstRowItem
		Private toggleLastRowItem1 As DevExpress.XtraRichEdit.UI.ToggleLastRowItem
		Private toggleBandedRowsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem
		Private toggleFirstColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem
		Private toggleLastColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleLastColumnItem
		Private toggleBandedColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem
		Private galleryChangeTableStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem
		Private galleryChangeTableCellStyleItem1 As DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem
		Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
		Private repositoryItemBorderLineStyle2 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
		Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
		Private repositoryItemBorderLineWeight2 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
		Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
		Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
		Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
		Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
		Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
		Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
		Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
		Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
		Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
		Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
		Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
		Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
		Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
		Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
		Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
		Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
		Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
		Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
		Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
		Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
		Private deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
		Private showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
		Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
		Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
		Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
		Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
		Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
		Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
		Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
		Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
		Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
		Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
		Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
		Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
		Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
		Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
		Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
		Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
		Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
		Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
		Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
		Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
		Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
		Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
		Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
		Private showTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
		Private checkSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem
		Private insertTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem
		Private updateTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem
		Private addParagraphsToTableOfContentItem1 As DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem
		Private setParagraphHeadingLevelItem1 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem2 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem3 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem4 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem5 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem6 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem7 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem8 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem9 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem10 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
		Private insertCaptionPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem
		Private insertFiguresCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems
		Private insertTablesCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems
		Private insertEquationsCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems
		Private insertTableOfFiguresPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem
		Private insertTableOfFiguresItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems
		Private insertTableOfTablesItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems
		Private insertTableOfEquationsItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems
		Private updateTableOfFiguresItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem
		Private changeFloatingObjectFillColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
		Private changeFloatingObjectOutlineColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
		Private changeFloatingObjectOutlineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
		Private repositoryItemFloatingObjectOutlineWeight2 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
		Private changeFloatingObjectTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
		Private setFloatingObjectSquareTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
		Private setFloatingObjectTightTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
		Private setFloatingObjectThroughTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
		Private setFloatingObjectTopAndBottomTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
		Private setFloatingObjectBehindTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
		Private setFloatingObjectInFrontOfTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
		Private changeFloatingObjectAlignmentItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
		Private setFloatingObjectTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
		Private setFloatingObjectTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
		Private setFloatingObjectTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
		Private setFloatingObjectMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
		Private setFloatingObjectMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
		Private setFloatingObjectMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
		Private setFloatingObjectBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
		Private setFloatingObjectBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
		Private setFloatingObjectBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
		Private floatingObjectBringForwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem
		Private floatingObjectBringForwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem
		Private floatingObjectBringToFrontItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem
		Private floatingObjectBringInFrontOfTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
		Private floatingObjectSendBackwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
		Private floatingObjectSendBackwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem
		Private floatingObjectSendToBackItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem
		Private floatingObjectSendBehindTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem
		Private themesGalleryBarItem1 As DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem
		Private commandBarCheckItem2 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem3 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem4 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarSubItem1 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem5 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem6 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem7 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem8 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem9 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private filterPopupButtonItem1 As DevExpress.Snap.Extensions.UI.FilterPopupButtonItem
		Private propertiesBarButtonItem1 As DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem
		Private commandBarSubItem2 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem10 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem11 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarSubItem3 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem12 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem13 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarItem8 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem9 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarSubItem4 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem14 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem15 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem16 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem17 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem18 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem19 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem20 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarSubItem5 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem21 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem22 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarSubItem6 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem23 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem24 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarSubItem7 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem25 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem26 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem27 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem28 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem29 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem30 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem31 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarItem10 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem11 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem12 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup
		Private changeEditorRowLimitItem1 As DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem
		Private repositoryItemEditorRowLimitEdit2 As DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit
		Private createBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
		Private commandBarGalleryDropDown36 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
		Private commandBarGalleryDropDown37 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createPieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
		Private commandBarGalleryDropDown38 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
		Private commandBarGalleryDropDown39 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
		Private commandBarGalleryDropDown40 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private createOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
		Private commandBarGalleryDropDown41 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private changePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
		Private commandBarGalleryDropDown42 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
		Private changeAppearanceGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem
		Private runWizardChartItem1 As DevExpress.XtraCharts.UI.RunWizardChartItem
		Private mailMergeDataSourceItem1 As DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem
		Private commandBarCheckItem32 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem33 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private mailMergeCurrentRecordItem1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem
		Private repositoryItemMailMergeCurrentRecordEdit2 As DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
		Private commandBarSubItem8 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarItem13 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem14 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem15 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private headerFooterToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory
		Private headerFooterToolsDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage
		Private headerFooterToolsDesignNavigationRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup
		Private headerFooterToolsDesignOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup
		Private headerFooterToolsDesignCloseRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup
		Private tableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
		Private tableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
		Private tableStyleOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup
		Private tableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
		Private tableCellStylesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup
		Private tableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
		Private tableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
		Private tableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
		Private tableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
		Private tableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
		Private tableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
		Private tableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
		Private floatingPictureToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
		Private floatingPictureToolsFormatPage1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage
		Private floatingPictureToolsShapeStylesPageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
		Private floatingPictureToolsArrangePageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
		Private dataToolsRibbonPageCategory1 As DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory
		Private appearanceRibbonPage1 As DevExpress.Snap.Extensions.UI.AppearanceRibbonPage
		Private themesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup
		Private snMergeFieldToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage
		Private dataShapingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup
		Private snMergeFieldPropertiesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup
		Private groupToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage
		Private groupingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup
		Private listToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.ListToolsRibbonPage
		Private listHeaderAndFooterRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup
		Private listCommandsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup
		Private listEditorRowLimitRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup
		Private mailMergeRibbonPage1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPage
		Private mailMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup
		Private mailMergeCurrentRecordRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup
		Private finishAndMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup
		Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
		Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
		Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
		Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
		Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
		Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
		Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
		Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
		Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
		Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
		Private toolboxRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup
		Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
		Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
		Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
		Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
		Private pageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
		Private pageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
		Private pageBackgroundRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup
		Private viewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
		Private documentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
		Private showRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
		Private zoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
		Private viewRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup
		Private viewFieldsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup
		Private reviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage
		Private documentProofingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup
		Private referencesRibbonPage1 As DevExpress.XtraRichEdit.UI.ReferencesRibbonPage
		Private tableOfContentsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup
		Private captionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup
		Private snapBarController1 As DevExpress.Snap.Extensions.SnapBarController
		Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
		Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
		Private dataRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataRibbonPageGroup
		Private runDesignerChartItem1 As DevExpress.XtraCharts.UI.RunDesignerChartItem
		Private chartRibbonPageCategory1 As DevExpress.XtraCharts.UI.ChartRibbonPageCategory
		Private createChartRibbonPage1 As DevExpress.XtraCharts.UI.CreateChartRibbonPage
		Private chartTypeRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup
		Private chartAppearanceRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup
		Private chartWizardRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup
	End Class
End Namespace
