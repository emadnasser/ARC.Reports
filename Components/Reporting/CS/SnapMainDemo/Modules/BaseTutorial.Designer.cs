using System;
using System.Collections.Generic;
using System.Linq;

namespace SnapDemos.Modules {
    public partial class BaseTutorial {
        private System.ComponentModel.IContainer components;

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTutorial));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraRichEdit.Model.BorderInfo borderInfo1 = new DevExpress.XtraRichEdit.Model.BorderInfo();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem1 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem1 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem1 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem1 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem1 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem1 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem1 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem1 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem1 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem1 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem1 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem1 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem1 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem2 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem2 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem2 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem2 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem2 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem2 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem2 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem2 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem2 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem2 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem2 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem2 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem2 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem2 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem2 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem2 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem2 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem2 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem2 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges3 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges4 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem3 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem3 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem3 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem3 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem3 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem3 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem3 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem3 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem3 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem3 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem3 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem3 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem3 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem3 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem3 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem3 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem3 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem3 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem3 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem3 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem3 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem3 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem3 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem3 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem3 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem3 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem3 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem3 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem3 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem3 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem3 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem3 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem3 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt3 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem3 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem3 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges5 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges6 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem4 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem4 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem4 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem4 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem4 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem4 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem4 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem4 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem4 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem4 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem4 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem4 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem4 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem4 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem4 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem4 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem4 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem4 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem4 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem4 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem4 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem4 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem4 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem4 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem4 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem4 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem4 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem4 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem4 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem4 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem4 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem4 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem4 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt4 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem4 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem4 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges7 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges8 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem5 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem5 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem5 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem5 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem5 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem5 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem5 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem5 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem5 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem5 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem5 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem5 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem5 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem5 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem5 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem5 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem5 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem5 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem5 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem5 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem5 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem5 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem5 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem5 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem5 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem5 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem5 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem5 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem5 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem5 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem5 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem5 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem5 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt5 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem5 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem5 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges9 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges10 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem6 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem6 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem6 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem6 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem6 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem6 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem6 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem6 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem6 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem6 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem6 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem6 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem6 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem6 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem6 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem6 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem6 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem6 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem6 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem6 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem6 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem6 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem6 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem6 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem6 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem6 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem6 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem6 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem6 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem6 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem6 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem6 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem6 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt6 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem6 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem6 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem1 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem2 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem3 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem4 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem5 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem6 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem7 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem8 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem9 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem10 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem11 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem12 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem13 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem14 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem15 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem16 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem17 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem18 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem19 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem20 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem21 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem22 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem23 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem24 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem25 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem26 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem27 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem28 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem29 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem30 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem31 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges11 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges12 = new DevExpress.Skins.SkinPaddingEdges();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup();
            this.galleryChangeStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem();
            this.snapControl1 = new DevExpress.Snap.SnapControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.commandBarItem1 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.commandBarItem2 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.repositoryItemRichEditFontSizeEdit2 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem();
            this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            this.capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
            this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            this.changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.insertPageBreakItem21 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem2();
            this.insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            this.insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            this.insertFloatingPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem();
            this.commandBarItem3 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem4 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem5 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem6 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem7 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.editPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.EditPageHeaderItem();
            this.editPageFooterItem1 = new DevExpress.XtraRichEdit.UI.EditPageFooterItem();
            this.insertPageNumberItem1 = new DevExpress.XtraRichEdit.UI.InsertPageNumberItem();
            this.insertPageCountItem1 = new DevExpress.XtraRichEdit.UI.InsertPageCountItem();
            this.insertTextBoxItem1 = new DevExpress.XtraRichEdit.UI.InsertTextBoxItem();
            this.insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            this.changeSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem();
            this.setNormalSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem();
            this.setNarrowSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem();
            this.setModerateSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem();
            this.setWideSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem();
            this.showPageMarginsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem();
            this.changeSectionPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem();
            this.setPortraitPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem();
            this.setLandscapePageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem();
            this.changeSectionPaperKindItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem();
            this.changeSectionColumnsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem();
            this.setSectionOneColumnItem1 = new DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem();
            this.setSectionTwoColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem();
            this.setSectionThreeColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem();
            this.showColumnsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem();
            this.insertBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertBreakItem();
            this.insertPageBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem();
            this.insertColumnBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertColumnBreakItem();
            this.insertSectionBreakNextPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem();
            this.insertSectionBreakEvenPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem();
            this.insertSectionBreakOddPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem();
            this.changeSectionLineNumberingItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem();
            this.setSectionLineNumberingNoneItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem();
            this.setSectionLineNumberingContinuousItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem();
            this.setSectionLineNumberingRestartNewPageItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem();
            this.setSectionLineNumberingRestartNewSectionItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem();
            this.toggleParagraphSuppressLineNumbersItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem();
            this.showLineNumberingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem();
            this.changePageColorItem1 = new DevExpress.XtraRichEdit.UI.ChangePageColorItem();
            this.switchToSimpleViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem();
            this.switchToDraftViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem();
            this.switchToPrintLayoutViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem();
            this.toggleShowHorizontalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem();
            this.toggleShowVerticalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem();
            this.zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            this.zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            this.snapBarToolbarsListItem1 = new DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem();
            this.commandBarCheckItem1 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleFieldHighlightingItem1 = new DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem();
            this.goToPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.GoToPageHeaderItem();
            this.goToPageFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToPageFooterItem();
            this.goToNextHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem();
            this.goToPreviousHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem();
            this.toggleLinkToPreviousItem1 = new DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem();
            this.toggleDifferentFirstPageItem1 = new DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem();
            this.toggleDifferentOddAndEvenPagesItem1 = new DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem();
            this.closePageHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem();
            this.toggleFirstRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstRowItem();
            this.toggleLastRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastRowItem();
            this.toggleBandedRowsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem();
            this.toggleFirstColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem();
            this.toggleLastColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastColumnItem();
            this.toggleBandedColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem();
            this.galleryChangeTableStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem();
            this.galleryChangeTableCellStyleItem1 = new DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem();
            this.changeTableBorderLineStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem();
            this.repositoryItemBorderLineStyle2 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            this.changeTableBorderLineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem();
            this.repositoryItemBorderLineWeight2 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            this.changeTableBorderColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem();
            this.changeTableBordersItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBordersItem();
            this.toggleTableCellsBottomBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem();
            this.toggleTableCellsTopBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem();
            this.toggleTableCellsLeftBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem();
            this.toggleTableCellsRightBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem();
            this.resetTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem();
            this.toggleTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem();
            this.toggleTableCellsOutsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem();
            this.toggleTableCellsInsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem();
            this.toggleTableCellsInsideHorizontalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem();
            this.toggleTableCellsInsideVerticalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem();
            this.toggleShowTableGridLinesItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem();
            this.changeTableCellsShadingItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem();
            this.selectTableElementsItem1 = new DevExpress.XtraRichEdit.UI.SelectTableElementsItem();
            this.selectTableCellItem1 = new DevExpress.XtraRichEdit.UI.SelectTableCellItem();
            this.selectTableColumnItem1 = new DevExpress.XtraRichEdit.UI.SelectTableColumnItem();
            this.selectTableRowItem1 = new DevExpress.XtraRichEdit.UI.SelectTableRowItem();
            this.selectTableItem1 = new DevExpress.XtraRichEdit.UI.SelectTableItem();
            this.showTablePropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem();
            this.deleteTableElementsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableElementsItem();
            this.showDeleteTableCellsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem();
            this.deleteTableColumnsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem();
            this.deleteTableRowsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableRowsItem();
            this.deleteTableItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableItem();
            this.insertTableRowAboveItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem();
            this.insertTableRowBelowItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem();
            this.insertTableColumnToLeftItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem();
            this.insertTableColumnToRightItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem();
            this.mergeTableCellsItem1 = new DevExpress.XtraRichEdit.UI.MergeTableCellsItem();
            this.showSplitTableCellsForm1 = new DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm();
            this.splitTableItem1 = new DevExpress.XtraRichEdit.UI.SplitTableItem();
            this.toggleTableAutoFitItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem();
            this.toggleTableAutoFitContentsItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem();
            this.toggleTableAutoFitWindowItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem();
            this.toggleTableFixedColumnWidthItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem();
            this.toggleTableCellsTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem();
            this.toggleTableCellsMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem();
            this.toggleTableCellsBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem();
            this.toggleTableCellsTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem();
            this.toggleTableCellsMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem();
            this.toggleTableCellsBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem();
            this.toggleTableCellsTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem();
            this.toggleTableCellsMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem();
            this.toggleTableCellsBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem();
            this.showTableOptionsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem();
            this.checkSpellingItem1 = new DevExpress.XtraRichEdit.UI.CheckSpellingItem();
            this.insertTableOfContentsItem1 = new DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem();
            this.updateTableOfContentsItem1 = new DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem();
            this.addParagraphsToTableOfContentItem1 = new DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem();
            this.setParagraphHeadingLevelItem1 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem2 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem3 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem4 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem5 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem6 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem7 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem8 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem9 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.setParagraphHeadingLevelItem10 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            this.insertCaptionPlaceholderItem1 = new DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem();
            this.insertFiguresCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems();
            this.insertTablesCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems();
            this.insertEquationsCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems();
            this.insertTableOfFiguresPlaceholderItem1 = new DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem();
            this.insertTableOfFiguresItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems();
            this.insertTableOfTablesItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems();
            this.insertTableOfEquationsItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems();
            this.updateTableOfFiguresItem1 = new DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem();
            this.changeFloatingObjectFillColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem();
            this.changeFloatingObjectOutlineColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem();
            this.changeFloatingObjectOutlineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem();
            this.repositoryItemFloatingObjectOutlineWeight2 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight();
            this.changeFloatingObjectTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem();
            this.setFloatingObjectSquareTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem();
            this.setFloatingObjectTightTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem();
            this.setFloatingObjectThroughTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem();
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem();
            this.setFloatingObjectBehindTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem();
            this.setFloatingObjectInFrontOfTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem();
            this.changeFloatingObjectAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem();
            this.setFloatingObjectTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem();
            this.setFloatingObjectTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem();
            this.setFloatingObjectTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem();
            this.setFloatingObjectMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem();
            this.setFloatingObjectMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem();
            this.setFloatingObjectMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem();
            this.setFloatingObjectBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem();
            this.setFloatingObjectBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem();
            this.setFloatingObjectBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem();
            this.floatingObjectBringForwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem();
            this.floatingObjectBringForwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem();
            this.floatingObjectBringToFrontItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem();
            this.floatingObjectBringInFrontOfTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem();
            this.floatingObjectSendBackwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem();
            this.floatingObjectSendBackwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem();
            this.floatingObjectSendToBackItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem();
            this.floatingObjectSendBehindTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem();
            this.themesGalleryBarItem1 = new DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem();
            this.commandBarCheckItem2 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem3 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem4 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem1 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem5 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem6 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem7 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem8 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem9 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.filterPopupButtonItem1 = new DevExpress.Snap.Extensions.UI.FilterPopupButtonItem();
            this.propertiesBarButtonItem1 = new DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem();
            this.commandBarSubItem2 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem10 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem11 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem3 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem12 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem13 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarItem8 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem9 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarSubItem4 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem14 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem15 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem16 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem17 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem18 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem19 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem20 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem5 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem21 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem22 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem6 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem23 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem24 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarSubItem7 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarCheckItem25 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem26 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem27 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem28 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem29 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem30 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem31 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarItem10 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem11 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem12 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeEditorRowLimitItem1 = new DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem();
            this.repositoryItemEditorRowLimitEdit2 = new DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit();
            this.createBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateBarBaseItem();
            this.commandBarGalleryDropDown36 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.createLineBaseItem1 = new DevExpress.XtraCharts.UI.CreateLineBaseItem();
            this.commandBarGalleryDropDown37 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.createPieBaseItem1 = new DevExpress.XtraCharts.UI.CreatePieBaseItem();
            this.commandBarGalleryDropDown38 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.createRotatedBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem();
            this.commandBarGalleryDropDown39 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.createAreaBaseItem1 = new DevExpress.XtraCharts.UI.CreateAreaBaseItem();
            this.commandBarGalleryDropDown40 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.createOtherSeriesTypesBaseItem1 = new DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem();
            this.commandBarGalleryDropDown41 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.changePaletteGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem();
            this.commandBarGalleryDropDown42 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.changeAppearanceGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem();
            this.runWizardChartItem1 = new DevExpress.XtraCharts.UI.RunWizardChartItem();
            this.mailMergeDataSourceItem1 = new DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem();
            this.commandBarCheckItem32 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.commandBarCheckItem33 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            this.mailMergeCurrentRecordItem1 = new DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem();
            this.repositoryItemMailMergeCurrentRecordEdit2 = new DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit();
            this.commandBarSubItem8 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            this.commandBarItem13 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem14 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.commandBarItem15 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            this.headerFooterToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory();
            this.headerFooterToolsDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage();
            this.headerFooterToolsDesignNavigationRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup();
            this.headerFooterToolsDesignOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup();
            this.headerFooterToolsDesignCloseRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup();
            this.tableToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory();
            this.tableDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableDesignRibbonPage();
            this.tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup();
            this.tableStylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup();
            this.tableCellStylesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup();
            this.tableDrawBordersRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup();
            this.tableLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage();
            this.tableTableRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup();
            this.tableRowsAndColumnsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup();
            this.tableMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup();
            this.tableCellSizeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup();
            this.tableAlignmentRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup();
            this.floatingPictureToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory();
            this.floatingPictureToolsFormatPage1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage();
            this.floatingPictureToolsShapeStylesPageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup();
            this.floatingPictureToolsArrangePageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup();
            this.dataToolsRibbonPageCategory1 = new DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory();
            this.appearanceRibbonPage1 = new DevExpress.Snap.Extensions.UI.AppearanceRibbonPage();
            this.themesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup();
            this.snMergeFieldToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage();
            this.dataShapingRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup();
            this.snMergeFieldPropertiesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup();
            this.groupToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage();
            this.groupingRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup();
            this.listToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.ListToolsRibbonPage();
            this.listHeaderAndFooterRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup();
            this.listCommandsRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup();
            this.listEditorRowLimitRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup();
            this.mailMergeRibbonPage1 = new DevExpress.Snap.Extensions.UI.MailMergeRibbonPage();
            this.mailMergeRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup();
            this.mailMergeCurrentRecordRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup();
            this.finishAndMergeRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            this.dataRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.DataRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraRichEdit.UI.HomeRibbonPage();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup();
            this.fontRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.FontRibbonPageGroup();
            this.paragraphRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup();
            this.editingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraRichEdit.UI.InsertRibbonPage();
            this.pagesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup();
            this.toolboxRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup();
            this.linksRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup();
            this.headerFooterRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup();
            this.textRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TextRibbonPageGroup();
            this.symbolsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup();
            this.pageLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage();
            this.pageSetupRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup();
            this.pageBackgroundRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ViewRibbonPage();
            this.documentViewsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup();
            this.showRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup();
            this.zoomRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup();
            this.viewRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup();
            this.viewFieldsRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup();
            this.reviewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReviewRibbonPage();
            this.documentProofingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup();
            this.referencesRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReferencesRibbonPage();
            this.tableOfContentsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup();
            this.captionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.repositoryItemBorderLineStyle1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            this.repositoryItemBorderLineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            this.repositoryItemFloatingObjectOutlineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight();
            this.repositoryItemEditorRowLimitEdit1 = new DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit();
            this.repositoryItemMailMergeCurrentRecordEdit1 = new DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit();
            this.commandBarGalleryDropDown29 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown30 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown31 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown32 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown33 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown34 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown35 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown22 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown23 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown24 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown25 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown26 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown27 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown28 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown15 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown16 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown17 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown18 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown19 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown20 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown21 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown8 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown9 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown10 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown11 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown12 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown13 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown14 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown3 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown4 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown5 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown6 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown7 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.fieldListDockPanel1 = new DevExpress.Snap.Extensions.UI.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.reportExplorerDockPanel1 = new DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel();
            this.reportExplorerDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.snapDocumentManager1 = new DevExpress.Snap.Extensions.SnapDocumentManager(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.snapBarController1 = new DevExpress.Snap.Extensions.SnapBarController();
            this.chartTypeRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup();
            this.createChartRibbonPage1 = new DevExpress.XtraCharts.UI.CreateChartRibbonPage();
            this.chartRibbonPageCategory1 = new DevExpress.XtraCharts.UI.ChartRibbonPageCategory();
            this.chartAppearanceRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup();
            this.chartWizardRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup();
            this.runDesignerChartItem1 = new DevExpress.XtraCharts.UI.RunDesignerChartItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditorRowLimitEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMailMergeCurrentRecordEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditorRowLimitEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMailMergeCurrentRecordEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.fieldListDockPanel1.SuspendLayout();
            this.reportExplorerDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // stylesRibbonPageGroup1
            // 
            this.stylesRibbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("stylesRibbonPageGroup1.Glyph")));
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeStyleItem1);
            this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            // 
            // galleryChangeStyleItem1
            // 
            // 
            // 
            // 
            this.galleryChangeStyleItem1.Gallery.ColumnCount = 10;
            this.galleryChangeStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeStyleItem1.Id = 376;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            // 
            // snapControl1
            // 
            this.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapControl1.EnableToolTips = true;
            this.snapControl1.Location = new System.Drawing.Point(0, 141);
            this.snapControl1.MenuManager = this.ribbonControl1;
            this.snapControl1.Name = "snapControl1";
            this.snapControl1.Options.Comments.Visibility = DevExpress.XtraRichEdit.RichEditCommentVisibility.Hidden;
            this.snapControl1.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never;
            this.snapControl1.Options.Fields.UpdateFieldsInTextBoxes = false;
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = null;
            this.snapControl1.Size = new System.Drawing.Size(922, 523);
            this.snapControl1.TabIndex = 0;
            this.snapControl1.Text = "snapControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.commandBarItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.undoItem1,
            this.redoItem1,
            this.commandBarItem2,
            this.pasteItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteSpecialItem1,
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.barButtonGroup2,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSuperscriptItem1,
            this.toggleFontSubscriptItem1,
            this.barButtonGroup3,
            this.changeFontColorItem1,
            this.changeFontBackColorItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.capitalizeEachWordCaseItem1,
            this.toggleTextCaseItem1,
            this.clearFormattingItem1,
            this.barButtonGroup4,
            this.toggleBulletedListItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.barButtonGroup5,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.barButtonGroup6,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.toggleShowWhitespaceItem1,
            this.barButtonGroup7,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.changeParagraphBackColorItem1,
            this.galleryChangeStyleItem1,
            this.findItem1,
            this.replaceItem1,
            this.insertPageBreakItem21,
            this.insertTableItem1,
            this.insertPictureItem1,
            this.insertFloatingPictureItem1,
            this.commandBarItem3,
            this.commandBarItem4,
            this.commandBarItem5,
            this.commandBarItem6,
            this.commandBarItem7,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1,
            this.editPageHeaderItem1,
            this.editPageFooterItem1,
            this.insertPageNumberItem1,
            this.insertPageCountItem1,
            this.insertTextBoxItem1,
            this.insertSymbolItem1,
            this.changeSectionPageMarginsItem1,
            this.setNormalSectionPageMarginsItem1,
            this.setNarrowSectionPageMarginsItem1,
            this.setModerateSectionPageMarginsItem1,
            this.setWideSectionPageMarginsItem1,
            this.showPageMarginsSetupFormItem1,
            this.changeSectionPageOrientationItem1,
            this.setPortraitPageOrientationItem1,
            this.setLandscapePageOrientationItem1,
            this.changeSectionPaperKindItem1,
            this.changeSectionColumnsItem1,
            this.setSectionOneColumnItem1,
            this.setSectionTwoColumnsItem1,
            this.setSectionThreeColumnsItem1,
            this.showColumnsSetupFormItem1,
            this.insertBreakItem1,
            this.insertPageBreakItem1,
            this.insertColumnBreakItem1,
            this.insertSectionBreakNextPageItem1,
            this.insertSectionBreakEvenPageItem1,
            this.insertSectionBreakOddPageItem1,
            this.changeSectionLineNumberingItem1,
            this.setSectionLineNumberingNoneItem1,
            this.setSectionLineNumberingContinuousItem1,
            this.setSectionLineNumberingRestartNewPageItem1,
            this.setSectionLineNumberingRestartNewSectionItem1,
            this.toggleParagraphSuppressLineNumbersItem1,
            this.showLineNumberingFormItem1,
            this.changePageColorItem1,
            this.switchToSimpleViewItem1,
            this.switchToDraftViewItem1,
            this.switchToPrintLayoutViewItem1,
            this.toggleShowHorizontalRulerItem1,
            this.toggleShowVerticalRulerItem1,
            this.zoomOutItem1,
            this.zoomInItem1,
            this.snapBarToolbarsListItem1,
            this.commandBarCheckItem1,
            this.showAllFieldCodesItem1,
            this.showAllFieldResultsItem1,
            this.toggleFieldHighlightingItem1,
            this.goToPageHeaderItem1,
            this.goToPageFooterItem1,
            this.goToNextHeaderFooterItem1,
            this.goToPreviousHeaderFooterItem1,
            this.toggleLinkToPreviousItem1,
            this.toggleDifferentFirstPageItem1,
            this.toggleDifferentOddAndEvenPagesItem1,
            this.closePageHeaderFooterItem1,
            this.toggleFirstRowItem1,
            this.toggleLastRowItem1,
            this.toggleBandedRowsItem1,
            this.toggleFirstColumnItem1,
            this.toggleLastColumnItem1,
            this.toggleBandedColumnItem1,
            this.galleryChangeTableStyleItem1,
            this.galleryChangeTableCellStyleItem1,
            this.changeTableBorderLineStyleItem1,
            this.changeTableBorderLineWeightItem1,
            this.changeTableBorderColorItem1,
            this.changeTableBordersItem1,
            this.toggleTableCellsBottomBorderItem1,
            this.toggleTableCellsTopBorderItem1,
            this.toggleTableCellsLeftBorderItem1,
            this.toggleTableCellsRightBorderItem1,
            this.resetTableCellsAllBordersItem1,
            this.toggleTableCellsAllBordersItem1,
            this.toggleTableCellsOutsideBorderItem1,
            this.toggleTableCellsInsideBorderItem1,
            this.toggleTableCellsInsideHorizontalBorderItem1,
            this.toggleTableCellsInsideVerticalBorderItem1,
            this.toggleShowTableGridLinesItem1,
            this.changeTableCellsShadingItem1,
            this.selectTableElementsItem1,
            this.selectTableCellItem1,
            this.selectTableColumnItem1,
            this.selectTableRowItem1,
            this.selectTableItem1,
            this.showTablePropertiesFormItem1,
            this.deleteTableElementsItem1,
            this.showDeleteTableCellsFormItem1,
            this.deleteTableColumnsItem1,
            this.deleteTableRowsItem1,
            this.deleteTableItem1,
            this.insertTableRowAboveItem1,
            this.insertTableRowBelowItem1,
            this.insertTableColumnToLeftItem1,
            this.insertTableColumnToRightItem1,
            this.mergeTableCellsItem1,
            this.showSplitTableCellsForm1,
            this.splitTableItem1,
            this.toggleTableAutoFitItem1,
            this.toggleTableAutoFitContentsItem1,
            this.toggleTableAutoFitWindowItem1,
            this.toggleTableFixedColumnWidthItem1,
            this.toggleTableCellsTopLeftAlignmentItem1,
            this.toggleTableCellsMiddleLeftAlignmentItem1,
            this.toggleTableCellsBottomLeftAlignmentItem1,
            this.toggleTableCellsTopCenterAlignmentItem1,
            this.toggleTableCellsMiddleCenterAlignmentItem1,
            this.toggleTableCellsBottomCenterAlignmentItem1,
            this.toggleTableCellsTopRightAlignmentItem1,
            this.toggleTableCellsMiddleRightAlignmentItem1,
            this.toggleTableCellsBottomRightAlignmentItem1,
            this.showTableOptionsFormItem1,
            this.checkSpellingItem1,
            this.insertTableOfContentsItem1,
            this.updateTableOfContentsItem1,
            this.addParagraphsToTableOfContentItem1,
            this.setParagraphHeadingLevelItem1,
            this.setParagraphHeadingLevelItem2,
            this.setParagraphHeadingLevelItem3,
            this.setParagraphHeadingLevelItem4,
            this.setParagraphHeadingLevelItem5,
            this.setParagraphHeadingLevelItem6,
            this.setParagraphHeadingLevelItem7,
            this.setParagraphHeadingLevelItem8,
            this.setParagraphHeadingLevelItem9,
            this.setParagraphHeadingLevelItem10,
            this.insertCaptionPlaceholderItem1,
            this.insertFiguresCaptionItems1,
            this.insertTablesCaptionItems1,
            this.insertEquationsCaptionItems1,
            this.insertTableOfFiguresPlaceholderItem1,
            this.insertTableOfFiguresItems1,
            this.insertTableOfTablesItems1,
            this.insertTableOfEquationsItems1,
            this.updateTableOfFiguresItem1,
            this.changeFloatingObjectFillColorItem1,
            this.changeFloatingObjectOutlineColorItem1,
            this.changeFloatingObjectOutlineWeightItem1,
            this.changeFloatingObjectTextWrapTypeItem1,
            this.setFloatingObjectSquareTextWrapTypeItem1,
            this.setFloatingObjectTightTextWrapTypeItem1,
            this.setFloatingObjectThroughTextWrapTypeItem1,
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1,
            this.setFloatingObjectBehindTextWrapTypeItem1,
            this.setFloatingObjectInFrontOfTextWrapTypeItem1,
            this.changeFloatingObjectAlignmentItem1,
            this.setFloatingObjectTopLeftAlignmentItem1,
            this.setFloatingObjectTopCenterAlignmentItem1,
            this.setFloatingObjectTopRightAlignmentItem1,
            this.setFloatingObjectMiddleLeftAlignmentItem1,
            this.setFloatingObjectMiddleCenterAlignmentItem1,
            this.setFloatingObjectMiddleRightAlignmentItem1,
            this.setFloatingObjectBottomLeftAlignmentItem1,
            this.setFloatingObjectBottomCenterAlignmentItem1,
            this.setFloatingObjectBottomRightAlignmentItem1,
            this.floatingObjectBringForwardSubItem1,
            this.floatingObjectBringForwardItem1,
            this.floatingObjectBringToFrontItem1,
            this.floatingObjectBringInFrontOfTextItem1,
            this.floatingObjectSendBackwardSubItem1,
            this.floatingObjectSendBackwardItem1,
            this.floatingObjectSendToBackItem1,
            this.floatingObjectSendBehindTextItem1,
            this.themesGalleryBarItem1,
            this.commandBarCheckItem2,
            this.commandBarCheckItem3,
            this.commandBarCheckItem4,
            this.commandBarSubItem1,
            this.commandBarCheckItem5,
            this.commandBarCheckItem6,
            this.commandBarCheckItem7,
            this.commandBarCheckItem8,
            this.commandBarCheckItem9,
            this.filterPopupButtonItem1,
            this.propertiesBarButtonItem1,
            this.commandBarSubItem2,
            this.commandBarCheckItem10,
            this.commandBarCheckItem11,
            this.commandBarSubItem3,
            this.commandBarCheckItem12,
            this.commandBarCheckItem13,
            this.commandBarItem8,
            this.commandBarItem9,
            this.commandBarSubItem4,
            this.commandBarCheckItem14,
            this.commandBarCheckItem15,
            this.commandBarCheckItem16,
            this.commandBarCheckItem17,
            this.commandBarCheckItem18,
            this.commandBarCheckItem19,
            this.commandBarCheckItem20,
            this.commandBarSubItem5,
            this.commandBarCheckItem21,
            this.commandBarCheckItem22,
            this.commandBarSubItem6,
            this.commandBarCheckItem23,
            this.commandBarCheckItem24,
            this.commandBarSubItem7,
            this.commandBarCheckItem25,
            this.commandBarCheckItem26,
            this.commandBarCheckItem27,
            this.commandBarCheckItem28,
            this.commandBarCheckItem29,
            this.commandBarCheckItem30,
            this.commandBarCheckItem31,
            this.commandBarItem10,
            this.commandBarItem11,
            this.commandBarItem12,
            this.barButtonGroup8,
            this.changeEditorRowLimitItem1,
            this.createBarBaseItem1,
            this.createLineBaseItem1,
            this.createPieBaseItem1,
            this.createRotatedBarBaseItem1,
            this.createAreaBaseItem1,
            this.createOtherSeriesTypesBaseItem1,
            this.changePaletteGalleryBaseItem1,
            this.changeAppearanceGalleryBaseItem1,
            this.runWizardChartItem1,
            this.mailMergeDataSourceItem1,
            this.commandBarCheckItem32,
            this.commandBarCheckItem33,
            this.mailMergeCurrentRecordItem1,
            this.commandBarSubItem8,
            this.commandBarItem13,
            this.commandBarItem14,
            this.commandBarItem15,
            this.runDesignerChartItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 617;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.headerFooterToolsRibbonPageCategory1,
            this.tableToolsRibbonPageCategory1,
            this.floatingPictureToolsRibbonPageCategory1,
            this.dataToolsRibbonPageCategory1,
            this.chartRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.insertRibbonPage1,
            this.pageLayoutRibbonPage1,
            this.viewRibbonPage1,
            this.reviewRibbonPage1,
            this.referencesRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.repositoryItemBorderLineStyle1,
            this.repositoryItemBorderLineWeight1,
            this.repositoryItemFloatingObjectOutlineWeight1,
            this.repositoryItemEditorRowLimitEdit1,
            this.repositoryItemMailMergeCurrentRecordEdit1,
            this.repositoryItemFontEdit2,
            this.repositoryItemRichEditFontSizeEdit2,
            this.repositoryItemBorderLineStyle2,
            this.repositoryItemBorderLineWeight2,
            this.repositoryItemFloatingObjectOutlineWeight2,
            this.repositoryItemEditorRowLimitEdit2,
            this.repositoryItemMailMergeCurrentRecordEdit2});
            this.ribbonControl1.Size = new System.Drawing.Size(1122, 141);
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Id = 314;
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Id = 315;
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Id = 316;
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Id = 317;
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // commandBarItem1
            // 
            this.commandBarItem1.Id = 318;
            this.commandBarItem1.Name = "commandBarItem1";
            this.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument;
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Id = 319;
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 320;
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 321;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // undoItem1
            // 
            this.undoItem1.Id = 322;
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Id = 323;
            this.redoItem1.Name = "redoItem1";
            // 
            // commandBarItem2
            // 
            this.commandBarItem2.Id = 324;
            this.commandBarItem2.Name = "commandBarItem2";
            this.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource;
            // 
            // pasteItem1
            // 
            this.pasteItem1.Id = 332;
            this.pasteItem1.Name = "pasteItem1";
            // 
            // cutItem1
            // 
            this.cutItem1.Id = 333;
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Id = 334;
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteSpecialItem1
            // 
            this.pasteSpecialItem1.Id = 335;
            this.pasteSpecialItem1.Name = "pasteSpecialItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = 325;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeIncreaseItem1);
            this.barButtonGroup1.ItemLinks.Add(this.fontSizeDecreaseItem1);
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit2;
            this.changeFontNameItem1.EditWidth = 130;
            this.changeFontNameItem1.Id = 336;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEdit2
            // 
            this.repositoryItemFontEdit2.AutoHeight = false;
            this.repositoryItemFontEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit2;
            this.changeFontSizeItem1.Id = 337;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemRichEditFontSizeEdit2
            // 
            this.repositoryItemRichEditFontSizeEdit2.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit2.Control = this.snapControl1;
            this.repositoryItemRichEditFontSizeEdit2.Name = "repositoryItemRichEditFontSizeEdit2";
            // 
            // fontSizeIncreaseItem1
            // 
            this.fontSizeIncreaseItem1.Id = 338;
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            // 
            // fontSizeDecreaseItem1
            // 
            this.fontSizeDecreaseItem1.Id = 339;
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Id = 326;
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontBoldItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontItalicItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleUnderlineItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontDoubleStrikeoutItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSuperscriptItem1);
            this.barButtonGroup2.ItemLinks.Add(this.toggleFontSubscriptItem1);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}";
            // 
            // toggleFontBoldItem1
            // 
            this.toggleFontBoldItem1.Id = 340;
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            // 
            // toggleFontItalicItem1
            // 
            this.toggleFontItalicItem1.Id = 341;
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            // 
            // toggleFontUnderlineItem1
            // 
            this.toggleFontUnderlineItem1.Id = 342;
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            this.toggleFontDoubleUnderlineItem1.Id = 343;
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            // 
            // toggleFontStrikeoutItem1
            // 
            this.toggleFontStrikeoutItem1.Id = 344;
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            // 
            // toggleFontDoubleStrikeoutItem1
            // 
            this.toggleFontDoubleStrikeoutItem1.Id = 345;
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            // 
            // toggleFontSuperscriptItem1
            // 
            this.toggleFontSuperscriptItem1.Id = 346;
            this.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            // 
            // toggleFontSubscriptItem1
            // 
            this.toggleFontSubscriptItem1.Id = 347;
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Id = 327;
            this.barButtonGroup3.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup3.ItemLinks.Add(this.changeFontBackColorItem1);
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Id = 348;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // changeFontBackColorItem1
            // 
            this.changeFontBackColorItem1.Id = 349;
            this.changeFontBackColorItem1.Name = "changeFontBackColorItem1";
            // 
            // changeTextCaseItem1
            // 
            this.changeTextCaseItem1.Id = 350;
            this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.capitalizeEachWordCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)});
            this.changeTextCaseItem1.Name = "changeTextCaseItem1";
            // 
            // makeTextUpperCaseItem1
            // 
            this.makeTextUpperCaseItem1.Id = 351;
            this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            // 
            // makeTextLowerCaseItem1
            // 
            this.makeTextLowerCaseItem1.Id = 352;
            this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            // 
            // capitalizeEachWordCaseItem1
            // 
            this.capitalizeEachWordCaseItem1.Id = 353;
            this.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
            // 
            // toggleTextCaseItem1
            // 
            this.toggleTextCaseItem1.Id = 354;
            this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            // 
            // clearFormattingItem1
            // 
            this.clearFormattingItem1.Id = 355;
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Id = 328;
            this.barButtonGroup4.ItemLinks.Add(this.toggleBulletedListItem1);
            this.barButtonGroup4.ItemLinks.Add(this.toggleNumberingListItem1);
            this.barButtonGroup4.ItemLinks.Add(this.toggleMultiLevelListItem1);
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // toggleBulletedListItem1
            // 
            this.toggleBulletedListItem1.Id = 356;
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            // 
            // toggleNumberingListItem1
            // 
            this.toggleNumberingListItem1.Id = 357;
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            // 
            // toggleMultiLevelListItem1
            // 
            this.toggleMultiLevelListItem1.Id = 358;
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            // 
            // barButtonGroup5
            // 
            this.barButtonGroup5.Id = 329;
            this.barButtonGroup5.ItemLinks.Add(this.decreaseIndentItem1);
            this.barButtonGroup5.ItemLinks.Add(this.increaseIndentItem1);
            this.barButtonGroup5.ItemLinks.Add(this.toggleShowWhitespaceItem1);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}";
            // 
            // decreaseIndentItem1
            // 
            this.decreaseIndentItem1.Id = 359;
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            // 
            // increaseIndentItem1
            // 
            this.increaseIndentItem1.Id = 360;
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            // 
            // toggleShowWhitespaceItem1
            // 
            this.toggleShowWhitespaceItem1.Id = 365;
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            // 
            // barButtonGroup6
            // 
            this.barButtonGroup6.Id = 330;
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentLeftItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentCenterItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentRightItem1);
            this.barButtonGroup6.ItemLinks.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}";
            // 
            // toggleParagraphAlignmentLeftItem1
            // 
            this.toggleParagraphAlignmentLeftItem1.Id = 361;
            this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            // 
            // toggleParagraphAlignmentCenterItem1
            // 
            this.toggleParagraphAlignmentCenterItem1.Id = 362;
            this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            // 
            // toggleParagraphAlignmentRightItem1
            // 
            this.toggleParagraphAlignmentRightItem1.Id = 363;
            this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            // 
            // toggleParagraphAlignmentJustifyItem1
            // 
            this.toggleParagraphAlignmentJustifyItem1.Id = 364;
            this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            // 
            // barButtonGroup7
            // 
            this.barButtonGroup7.Id = 331;
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphLineSpacingItem1);
            this.barButtonGroup7.ItemLinks.Add(this.changeParagraphBackColorItem1);
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}";
            // 
            // changeParagraphLineSpacingItem1
            // 
            this.changeParagraphLineSpacingItem1.Id = 366;
            this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)});
            this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            // 
            // setSingleParagraphSpacingItem1
            // 
            this.setSingleParagraphSpacingItem1.Id = 367;
            this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            // 
            // setSesquialteralParagraphSpacingItem1
            // 
            this.setSesquialteralParagraphSpacingItem1.Id = 368;
            this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            // 
            // setDoubleParagraphSpacingItem1
            // 
            this.setDoubleParagraphSpacingItem1.Id = 369;
            this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            // 
            // showLineSpacingFormItem1
            // 
            this.showLineSpacingFormItem1.Id = 370;
            this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            // 
            // addSpacingBeforeParagraphItem1
            // 
            this.addSpacingBeforeParagraphItem1.Id = 371;
            this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            // 
            // removeSpacingBeforeParagraphItem1
            // 
            this.removeSpacingBeforeParagraphItem1.Id = 372;
            this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            // 
            // addSpacingAfterParagraphItem1
            // 
            this.addSpacingAfterParagraphItem1.Id = 373;
            this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            // 
            // removeSpacingAfterParagraphItem1
            // 
            this.removeSpacingAfterParagraphItem1.Id = 374;
            this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            // 
            // changeParagraphBackColorItem1
            // 
            this.changeParagraphBackColorItem1.Id = 375;
            this.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            // 
            // findItem1
            // 
            this.findItem1.Id = 377;
            this.findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            this.replaceItem1.Id = 378;
            this.replaceItem1.Name = "replaceItem1";
            // 
            // insertPageBreakItem21
            // 
            this.insertPageBreakItem21.Id = 379;
            this.insertPageBreakItem21.Name = "insertPageBreakItem21";
            // 
            // insertTableItem1
            // 
            this.insertTableItem1.Id = 380;
            this.insertTableItem1.Name = "insertTableItem1";
            // 
            // insertPictureItem1
            // 
            this.insertPictureItem1.Id = 381;
            this.insertPictureItem1.Name = "insertPictureItem1";
            // 
            // insertFloatingPictureItem1
            // 
            this.insertFloatingPictureItem1.Id = 382;
            this.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1";
            // 
            // commandBarItem3
            // 
            this.commandBarItem3.Id = 383;
            this.commandBarItem3.Name = "commandBarItem3";
            this.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode;
            // 
            // commandBarItem4
            // 
            this.commandBarItem4.Id = 384;
            this.commandBarItem4.Name = "commandBarItem4";
            this.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox;
            // 
            // commandBarItem5
            // 
            this.commandBarItem5.Id = 385;
            this.commandBarItem5.Name = "commandBarItem5";
            this.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart;
            // 
            // commandBarItem6
            // 
            this.commandBarItem6.Id = 386;
            this.commandBarItem6.Name = "commandBarItem6";
            this.commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSparkline;
            // 
            // commandBarItem7
            // 
            this.commandBarItem7.Id = 387;
            this.commandBarItem7.Name = "commandBarItem7";
            this.commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertIndex;
            // 
            // insertBookmarkItem1
            // 
            this.insertBookmarkItem1.Id = 388;
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            // 
            // insertHyperlinkItem1
            // 
            this.insertHyperlinkItem1.Id = 389;
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            // 
            // editPageHeaderItem1
            // 
            this.editPageHeaderItem1.Id = 390;
            this.editPageHeaderItem1.Name = "editPageHeaderItem1";
            // 
            // editPageFooterItem1
            // 
            this.editPageFooterItem1.Id = 391;
            this.editPageFooterItem1.Name = "editPageFooterItem1";
            // 
            // insertPageNumberItem1
            // 
            this.insertPageNumberItem1.Id = 392;
            this.insertPageNumberItem1.Name = "insertPageNumberItem1";
            // 
            // insertPageCountItem1
            // 
            this.insertPageCountItem1.Id = 393;
            this.insertPageCountItem1.Name = "insertPageCountItem1";
            // 
            // insertTextBoxItem1
            // 
            this.insertTextBoxItem1.Id = 394;
            this.insertTextBoxItem1.Name = "insertTextBoxItem1";
            // 
            // insertSymbolItem1
            // 
            this.insertSymbolItem1.Id = 395;
            this.insertSymbolItem1.Name = "insertSymbolItem1";
            // 
            // changeSectionPageMarginsItem1
            // 
            this.changeSectionPageMarginsItem1.Id = 396;
            this.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setNormalSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setNarrowSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setModerateSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setWideSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showPageMarginsSetupFormItem1, true)});
            this.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1";
            // 
            // setNormalSectionPageMarginsItem1
            // 
            this.setNormalSectionPageMarginsItem1.Id = 397;
            this.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1";
            // 
            // setNarrowSectionPageMarginsItem1
            // 
            this.setNarrowSectionPageMarginsItem1.Id = 398;
            this.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1";
            // 
            // setModerateSectionPageMarginsItem1
            // 
            this.setModerateSectionPageMarginsItem1.Id = 399;
            this.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1";
            // 
            // setWideSectionPageMarginsItem1
            // 
            this.setWideSectionPageMarginsItem1.Id = 400;
            this.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1";
            // 
            // showPageMarginsSetupFormItem1
            // 
            this.showPageMarginsSetupFormItem1.Id = 401;
            this.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1";
            // 
            // changeSectionPageOrientationItem1
            // 
            this.changeSectionPageOrientationItem1.Id = 402;
            this.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setPortraitPageOrientationItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setLandscapePageOrientationItem1)});
            this.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1";
            // 
            // setPortraitPageOrientationItem1
            // 
            this.setPortraitPageOrientationItem1.Id = 403;
            this.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1";
            // 
            // setLandscapePageOrientationItem1
            // 
            this.setLandscapePageOrientationItem1.Id = 404;
            this.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1";
            // 
            // changeSectionPaperKindItem1
            // 
            this.changeSectionPaperKindItem1.Id = 405;
            this.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1";
            // 
            // changeSectionColumnsItem1
            // 
            this.changeSectionColumnsItem1.Id = 406;
            this.changeSectionColumnsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionOneColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionTwoColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionThreeColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showColumnsSetupFormItem1, true)});
            this.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1";
            // 
            // setSectionOneColumnItem1
            // 
            this.setSectionOneColumnItem1.Id = 407;
            this.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1";
            // 
            // setSectionTwoColumnsItem1
            // 
            this.setSectionTwoColumnsItem1.Id = 408;
            this.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1";
            // 
            // setSectionThreeColumnsItem1
            // 
            this.setSectionThreeColumnsItem1.Id = 409;
            this.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1";
            // 
            // showColumnsSetupFormItem1
            // 
            this.showColumnsSetupFormItem1.Id = 410;
            this.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1";
            // 
            // insertBreakItem1
            // 
            this.insertBreakItem1.Id = 411;
            this.insertBreakItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertPageBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertColumnBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakNextPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakEvenPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertSectionBreakOddPageItem1)});
            this.insertBreakItem1.Name = "insertBreakItem1";
            // 
            // insertPageBreakItem1
            // 
            this.insertPageBreakItem1.Id = 412;
            this.insertPageBreakItem1.Name = "insertPageBreakItem1";
            // 
            // insertColumnBreakItem1
            // 
            this.insertColumnBreakItem1.Id = 413;
            this.insertColumnBreakItem1.Name = "insertColumnBreakItem1";
            // 
            // insertSectionBreakNextPageItem1
            // 
            this.insertSectionBreakNextPageItem1.Id = 414;
            this.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1";
            // 
            // insertSectionBreakEvenPageItem1
            // 
            this.insertSectionBreakEvenPageItem1.Id = 415;
            this.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1";
            // 
            // insertSectionBreakOddPageItem1
            // 
            this.insertSectionBreakOddPageItem1.Id = 416;
            this.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1";
            // 
            // changeSectionLineNumberingItem1
            // 
            this.changeSectionLineNumberingItem1.Id = 417;
            this.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingNoneItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingContinuousItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingRestartNewPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSectionLineNumberingRestartNewSectionItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphSuppressLineNumbersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineNumberingFormItem1, true)});
            this.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1";
            // 
            // setSectionLineNumberingNoneItem1
            // 
            this.setSectionLineNumberingNoneItem1.Id = 418;
            this.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1";
            // 
            // setSectionLineNumberingContinuousItem1
            // 
            this.setSectionLineNumberingContinuousItem1.Id = 419;
            this.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1";
            // 
            // setSectionLineNumberingRestartNewPageItem1
            // 
            this.setSectionLineNumberingRestartNewPageItem1.Id = 420;
            this.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1";
            // 
            // setSectionLineNumberingRestartNewSectionItem1
            // 
            this.setSectionLineNumberingRestartNewSectionItem1.Id = 421;
            this.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1";
            // 
            // toggleParagraphSuppressLineNumbersItem1
            // 
            this.toggleParagraphSuppressLineNumbersItem1.Id = 422;
            this.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1";
            // 
            // showLineNumberingFormItem1
            // 
            this.showLineNumberingFormItem1.Id = 423;
            this.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1";
            // 
            // changePageColorItem1
            // 
            this.changePageColorItem1.Id = 424;
            this.changePageColorItem1.Name = "changePageColorItem1";
            // 
            // switchToSimpleViewItem1
            // 
            this.switchToSimpleViewItem1.Id = 425;
            this.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1";
            // 
            // switchToDraftViewItem1
            // 
            this.switchToDraftViewItem1.Id = 426;
            this.switchToDraftViewItem1.Name = "switchToDraftViewItem1";
            // 
            // switchToPrintLayoutViewItem1
            // 
            this.switchToPrintLayoutViewItem1.Id = 427;
            this.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1";
            // 
            // toggleShowHorizontalRulerItem1
            // 
            this.toggleShowHorizontalRulerItem1.Id = 428;
            this.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1";
            // 
            // toggleShowVerticalRulerItem1
            // 
            this.toggleShowVerticalRulerItem1.Id = 429;
            this.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1";
            // 
            // zoomOutItem1
            // 
            this.zoomOutItem1.Id = 430;
            this.zoomOutItem1.Name = "zoomOutItem1";
            // 
            // zoomInItem1
            // 
            this.zoomInItem1.Id = 431;
            this.zoomInItem1.Name = "zoomInItem1";
            // 
            // snapBarToolbarsListItem1
            // 
            this.snapBarToolbarsListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("snapBarToolbarsListItem1.Glyph")));
            this.snapBarToolbarsListItem1.Hint = "Show or hide the Data Explorer and Report Explorer windows.";
            this.snapBarToolbarsListItem1.Id = 432;
            this.snapBarToolbarsListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("snapBarToolbarsListItem1.LargeGlyph")));
            this.snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1";
            this.snapBarToolbarsListItem1.ShowCustomizationItem = false;
            this.snapBarToolbarsListItem1.ShowDockPanels = true;
            this.snapBarToolbarsListItem1.ShowToolbars = false;
            // 
            // commandBarCheckItem1
            // 
            this.commandBarCheckItem1.Id = 433;
            this.commandBarCheckItem1.Name = "commandBarCheckItem1";
            this.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement;
            // 
            // showAllFieldCodesItem1
            // 
            this.showAllFieldCodesItem1.Id = 434;
            this.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            this.showAllFieldResultsItem1.Id = 435;
            this.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleFieldHighlightingItem1
            // 
            this.toggleFieldHighlightingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFieldHighlightingItem1.Glyph")));
            this.toggleFieldHighlightingItem1.Id = 436;
            this.toggleFieldHighlightingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFieldHighlightingItem1.LargeGlyph")));
            this.toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1";
            // 
            // goToPageHeaderItem1
            // 
            this.goToPageHeaderItem1.Id = 437;
            this.goToPageHeaderItem1.Name = "goToPageHeaderItem1";
            // 
            // goToPageFooterItem1
            // 
            this.goToPageFooterItem1.Id = 438;
            this.goToPageFooterItem1.Name = "goToPageFooterItem1";
            // 
            // goToNextHeaderFooterItem1
            // 
            this.goToNextHeaderFooterItem1.Id = 439;
            this.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1";
            // 
            // goToPreviousHeaderFooterItem1
            // 
            this.goToPreviousHeaderFooterItem1.Id = 440;
            this.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1";
            // 
            // toggleLinkToPreviousItem1
            // 
            this.toggleLinkToPreviousItem1.Id = 441;
            this.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1";
            // 
            // toggleDifferentFirstPageItem1
            // 
            this.toggleDifferentFirstPageItem1.Id = 442;
            this.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1";
            // 
            // toggleDifferentOddAndEvenPagesItem1
            // 
            this.toggleDifferentOddAndEvenPagesItem1.Id = 443;
            this.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1";
            // 
            // closePageHeaderFooterItem1
            // 
            this.closePageHeaderFooterItem1.Id = 444;
            this.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1";
            // 
            // toggleFirstRowItem1
            // 
            this.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleFirstRowItem1.Id = 445;
            this.toggleFirstRowItem1.Name = "toggleFirstRowItem1";
            // 
            // toggleLastRowItem1
            // 
            this.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleLastRowItem1.Id = 446;
            this.toggleLastRowItem1.Name = "toggleLastRowItem1";
            // 
            // toggleBandedRowsItem1
            // 
            this.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleBandedRowsItem1.Id = 447;
            this.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1";
            // 
            // toggleFirstColumnItem1
            // 
            this.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleFirstColumnItem1.Id = 448;
            this.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1";
            // 
            // toggleLastColumnItem1
            // 
            this.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleLastColumnItem1.Id = 449;
            this.toggleLastColumnItem1.Name = "toggleLastColumnItem1";
            // 
            // toggleBandedColumnItem1
            // 
            this.toggleBandedColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.toggleBandedColumnItem1.Id = 450;
            this.toggleBandedColumnItem1.Name = "toggleBandedColumnItem1";
            // 
            // galleryChangeTableStyleItem1
            // 
            this.galleryChangeTableStyleItem1.CurrentItem = null;
            this.galleryChangeTableStyleItem1.CurrentItemStyle = null;
            this.galleryChangeTableStyleItem1.CurrentStyle = null;
            this.galleryChangeTableStyleItem1.DeleteItemLink = null;
            // 
            // 
            // 
            this.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3;
            this.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.galleryChangeTableStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeTableStyleItem1.Id = 451;
            this.galleryChangeTableStyleItem1.ModifyItemLink = null;
            this.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1";
            this.galleryChangeTableStyleItem1.NewItemLink = null;
            this.galleryChangeTableStyleItem1.PopupGallery = null;
            // 
            // galleryChangeTableCellStyleItem1
            // 
            this.galleryChangeTableCellStyleItem1.CurrentCellStyle = null;
            this.galleryChangeTableCellStyleItem1.CurrentItem = null;
            this.galleryChangeTableCellStyleItem1.CurrentItemCellStyle = null;
            this.galleryChangeTableCellStyleItem1.DeleteItemLink = null;
            // 
            // 
            // 
            this.galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3;
            this.galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.galleryChangeTableCellStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeTableCellStyleItem1.Id = 452;
            this.galleryChangeTableCellStyleItem1.ModifyItemLink = null;
            this.galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1";
            this.galleryChangeTableCellStyleItem1.NewItemLink = null;
            this.galleryChangeTableCellStyleItem1.PopupGallery = null;
            // 
            // changeTableBorderLineStyleItem1
            // 
            this.changeTableBorderLineStyleItem1.Edit = this.repositoryItemBorderLineStyle2;
            borderInfo1.Frame = false;
            borderInfo1.Offset = 0;
            borderInfo1.Shadow = false;
            borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single;
            borderInfo1.Width = 10;
            this.changeTableBorderLineStyleItem1.EditValue = borderInfo1;
            this.changeTableBorderLineStyleItem1.EditWidth = 130;
            this.changeTableBorderLineStyleItem1.Id = 453;
            this.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1";
            // 
            // repositoryItemBorderLineStyle2
            // 
            this.repositoryItemBorderLineStyle2.AutoHeight = false;
            this.repositoryItemBorderLineStyle2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineStyle2.Control = this.snapControl1;
            this.repositoryItemBorderLineStyle2.Name = "repositoryItemBorderLineStyle2";
            // 
            // changeTableBorderLineWeightItem1
            // 
            this.changeTableBorderLineWeightItem1.Edit = this.repositoryItemBorderLineWeight2;
            this.changeTableBorderLineWeightItem1.EditValue = 20;
            this.changeTableBorderLineWeightItem1.EditWidth = 130;
            this.changeTableBorderLineWeightItem1.Id = 454;
            this.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1";
            // 
            // repositoryItemBorderLineWeight2
            // 
            this.repositoryItemBorderLineWeight2.AutoHeight = false;
            this.repositoryItemBorderLineWeight2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineWeight2.Control = this.snapControl1;
            this.repositoryItemBorderLineWeight2.Name = "repositoryItemBorderLineWeight2";
            // 
            // changeTableBorderColorItem1
            // 
            this.changeTableBorderColorItem1.Id = 455;
            this.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1";
            // 
            // changeTableBordersItem1
            // 
            this.changeTableBordersItem1.Id = 456;
            this.changeTableBordersItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsBottomBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsTopBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsLeftBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsRightBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.resetTableCellsAllBordersItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsOutsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideHorizontalBorderItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableCellsInsideVerticalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowTableGridLinesItem1, true)});
            this.changeTableBordersItem1.Name = "changeTableBordersItem1";
            // 
            // toggleTableCellsBottomBorderItem1
            // 
            this.toggleTableCellsBottomBorderItem1.Id = 457;
            this.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1";
            // 
            // toggleTableCellsTopBorderItem1
            // 
            this.toggleTableCellsTopBorderItem1.Id = 458;
            this.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1";
            // 
            // toggleTableCellsLeftBorderItem1
            // 
            this.toggleTableCellsLeftBorderItem1.Id = 459;
            this.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1";
            // 
            // toggleTableCellsRightBorderItem1
            // 
            this.toggleTableCellsRightBorderItem1.Id = 460;
            this.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1";
            // 
            // resetTableCellsAllBordersItem1
            // 
            this.resetTableCellsAllBordersItem1.Id = 461;
            this.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1";
            // 
            // toggleTableCellsAllBordersItem1
            // 
            this.toggleTableCellsAllBordersItem1.Id = 462;
            this.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1";
            // 
            // toggleTableCellsOutsideBorderItem1
            // 
            this.toggleTableCellsOutsideBorderItem1.Id = 463;
            this.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1";
            // 
            // toggleTableCellsInsideBorderItem1
            // 
            this.toggleTableCellsInsideBorderItem1.Id = 464;
            this.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1";
            // 
            // toggleTableCellsInsideHorizontalBorderItem1
            // 
            this.toggleTableCellsInsideHorizontalBorderItem1.Id = 465;
            this.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1";
            // 
            // toggleTableCellsInsideVerticalBorderItem1
            // 
            this.toggleTableCellsInsideVerticalBorderItem1.Id = 466;
            this.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1";
            // 
            // toggleShowTableGridLinesItem1
            // 
            this.toggleShowTableGridLinesItem1.Id = 467;
            this.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1";
            // 
            // changeTableCellsShadingItem1
            // 
            this.changeTableCellsShadingItem1.Id = 468;
            this.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1";
            // 
            // selectTableElementsItem1
            // 
            this.selectTableElementsItem1.Id = 469;
            this.selectTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableCellItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableRowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.selectTableItem1)});
            this.selectTableElementsItem1.Name = "selectTableElementsItem1";
            // 
            // selectTableCellItem1
            // 
            this.selectTableCellItem1.Id = 470;
            this.selectTableCellItem1.Name = "selectTableCellItem1";
            // 
            // selectTableColumnItem1
            // 
            this.selectTableColumnItem1.Id = 471;
            this.selectTableColumnItem1.Name = "selectTableColumnItem1";
            // 
            // selectTableRowItem1
            // 
            this.selectTableRowItem1.Id = 472;
            this.selectTableRowItem1.Name = "selectTableRowItem1";
            // 
            // selectTableItem1
            // 
            this.selectTableItem1.Id = 473;
            this.selectTableItem1.Name = "selectTableItem1";
            // 
            // showTablePropertiesFormItem1
            // 
            this.showTablePropertiesFormItem1.Id = 474;
            this.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1";
            // 
            // deleteTableElementsItem1
            // 
            this.deleteTableElementsItem1.Id = 475;
            this.deleteTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showDeleteTableCellsFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableRowsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteTableItem1)});
            this.deleteTableElementsItem1.Name = "deleteTableElementsItem1";
            // 
            // showDeleteTableCellsFormItem1
            // 
            this.showDeleteTableCellsFormItem1.Id = 476;
            this.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1";
            // 
            // deleteTableColumnsItem1
            // 
            this.deleteTableColumnsItem1.Id = 477;
            this.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1";
            // 
            // deleteTableRowsItem1
            // 
            this.deleteTableRowsItem1.Id = 478;
            this.deleteTableRowsItem1.Name = "deleteTableRowsItem1";
            // 
            // deleteTableItem1
            // 
            this.deleteTableItem1.Id = 479;
            this.deleteTableItem1.Name = "deleteTableItem1";
            // 
            // insertTableRowAboveItem1
            // 
            this.insertTableRowAboveItem1.Id = 480;
            this.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1";
            // 
            // insertTableRowBelowItem1
            // 
            this.insertTableRowBelowItem1.Id = 481;
            this.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1";
            // 
            // insertTableColumnToLeftItem1
            // 
            this.insertTableColumnToLeftItem1.Id = 482;
            this.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1";
            // 
            // insertTableColumnToRightItem1
            // 
            this.insertTableColumnToRightItem1.Id = 483;
            this.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1";
            // 
            // mergeTableCellsItem1
            // 
            this.mergeTableCellsItem1.Id = 484;
            this.mergeTableCellsItem1.Name = "mergeTableCellsItem1";
            // 
            // showSplitTableCellsForm1
            // 
            this.showSplitTableCellsForm1.Id = 485;
            this.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1";
            // 
            // splitTableItem1
            // 
            this.splitTableItem1.Id = 486;
            this.splitTableItem1.Name = "splitTableItem1";
            // 
            // toggleTableAutoFitItem1
            // 
            this.toggleTableAutoFitItem1.Id = 487;
            this.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitContentsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableAutoFitWindowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTableFixedColumnWidthItem1)});
            this.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1";
            // 
            // toggleTableAutoFitContentsItem1
            // 
            this.toggleTableAutoFitContentsItem1.Id = 488;
            this.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1";
            // 
            // toggleTableAutoFitWindowItem1
            // 
            this.toggleTableAutoFitWindowItem1.Id = 489;
            this.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1";
            // 
            // toggleTableFixedColumnWidthItem1
            // 
            this.toggleTableFixedColumnWidthItem1.Id = 490;
            this.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1";
            // 
            // toggleTableCellsTopLeftAlignmentItem1
            // 
            this.toggleTableCellsTopLeftAlignmentItem1.Id = 491;
            this.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1";
            // 
            // toggleTableCellsMiddleLeftAlignmentItem1
            // 
            this.toggleTableCellsMiddleLeftAlignmentItem1.Id = 492;
            this.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1";
            // 
            // toggleTableCellsBottomLeftAlignmentItem1
            // 
            this.toggleTableCellsBottomLeftAlignmentItem1.Id = 493;
            this.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1";
            // 
            // toggleTableCellsTopCenterAlignmentItem1
            // 
            this.toggleTableCellsTopCenterAlignmentItem1.Id = 494;
            this.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1";
            // 
            // toggleTableCellsMiddleCenterAlignmentItem1
            // 
            this.toggleTableCellsMiddleCenterAlignmentItem1.Id = 495;
            this.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1";
            // 
            // toggleTableCellsBottomCenterAlignmentItem1
            // 
            this.toggleTableCellsBottomCenterAlignmentItem1.Id = 496;
            this.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1";
            // 
            // toggleTableCellsTopRightAlignmentItem1
            // 
            this.toggleTableCellsTopRightAlignmentItem1.Id = 497;
            this.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1";
            // 
            // toggleTableCellsMiddleRightAlignmentItem1
            // 
            this.toggleTableCellsMiddleRightAlignmentItem1.Id = 498;
            this.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1";
            // 
            // toggleTableCellsBottomRightAlignmentItem1
            // 
            this.toggleTableCellsBottomRightAlignmentItem1.Id = 499;
            this.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1";
            // 
            // showTableOptionsFormItem1
            // 
            this.showTableOptionsFormItem1.Id = 500;
            this.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1";
            // 
            // checkSpellingItem1
            // 
            this.checkSpellingItem1.Id = 501;
            this.checkSpellingItem1.Name = "checkSpellingItem1";
            // 
            // insertTableOfContentsItem1
            // 
            this.insertTableOfContentsItem1.Id = 502;
            this.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1";
            // 
            // updateTableOfContentsItem1
            // 
            this.updateTableOfContentsItem1.Id = 503;
            this.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1";
            // 
            // addParagraphsToTableOfContentItem1
            // 
            this.addParagraphsToTableOfContentItem1.Id = 504;
            this.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.setParagraphHeadingLevelItem10)});
            this.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1";
            // 
            // setParagraphHeadingLevelItem1
            // 
            this.setParagraphHeadingLevelItem1.Id = 505;
            this.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1";
            this.setParagraphHeadingLevelItem1.OutlineLevel = 0;
            // 
            // setParagraphHeadingLevelItem2
            // 
            this.setParagraphHeadingLevelItem2.Id = 506;
            this.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2";
            this.setParagraphHeadingLevelItem2.OutlineLevel = 1;
            // 
            // setParagraphHeadingLevelItem3
            // 
            this.setParagraphHeadingLevelItem3.Id = 507;
            this.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3";
            this.setParagraphHeadingLevelItem3.OutlineLevel = 2;
            // 
            // setParagraphHeadingLevelItem4
            // 
            this.setParagraphHeadingLevelItem4.Id = 508;
            this.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4";
            this.setParagraphHeadingLevelItem4.OutlineLevel = 3;
            // 
            // setParagraphHeadingLevelItem5
            // 
            this.setParagraphHeadingLevelItem5.Id = 509;
            this.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5";
            this.setParagraphHeadingLevelItem5.OutlineLevel = 4;
            // 
            // setParagraphHeadingLevelItem6
            // 
            this.setParagraphHeadingLevelItem6.Id = 510;
            this.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6";
            this.setParagraphHeadingLevelItem6.OutlineLevel = 5;
            // 
            // setParagraphHeadingLevelItem7
            // 
            this.setParagraphHeadingLevelItem7.Id = 511;
            this.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7";
            this.setParagraphHeadingLevelItem7.OutlineLevel = 6;
            // 
            // setParagraphHeadingLevelItem8
            // 
            this.setParagraphHeadingLevelItem8.Id = 512;
            this.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8";
            this.setParagraphHeadingLevelItem8.OutlineLevel = 7;
            // 
            // setParagraphHeadingLevelItem9
            // 
            this.setParagraphHeadingLevelItem9.Id = 513;
            this.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9";
            this.setParagraphHeadingLevelItem9.OutlineLevel = 8;
            // 
            // setParagraphHeadingLevelItem10
            // 
            this.setParagraphHeadingLevelItem10.Id = 514;
            this.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10";
            this.setParagraphHeadingLevelItem10.OutlineLevel = 9;
            // 
            // insertCaptionPlaceholderItem1
            // 
            this.insertCaptionPlaceholderItem1.Id = 515;
            this.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertFiguresCaptionItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTablesCaptionItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertEquationsCaptionItems1)});
            this.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1";
            // 
            // insertFiguresCaptionItems1
            // 
            this.insertFiguresCaptionItems1.Id = 516;
            this.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1";
            // 
            // insertTablesCaptionItems1
            // 
            this.insertTablesCaptionItems1.Id = 517;
            this.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1";
            // 
            // insertEquationsCaptionItems1
            // 
            this.insertEquationsCaptionItems1.Id = 518;
            this.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1";
            // 
            // insertTableOfFiguresPlaceholderItem1
            // 
            this.insertTableOfFiguresPlaceholderItem1.Id = 519;
            this.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTableOfFiguresItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTableOfTablesItems1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertTableOfEquationsItems1)});
            this.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1";
            // 
            // insertTableOfFiguresItems1
            // 
            this.insertTableOfFiguresItems1.Id = 520;
            this.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1";
            // 
            // insertTableOfTablesItems1
            // 
            this.insertTableOfTablesItems1.Id = 521;
            this.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1";
            // 
            // insertTableOfEquationsItems1
            // 
            this.insertTableOfEquationsItems1.Id = 522;
            this.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1";
            // 
            // updateTableOfFiguresItem1
            // 
            this.updateTableOfFiguresItem1.Id = 523;
            this.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1";
            // 
            // changeFloatingObjectFillColorItem1
            // 
            this.changeFloatingObjectFillColorItem1.Id = 524;
            this.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1";
            // 
            // changeFloatingObjectOutlineColorItem1
            // 
            this.changeFloatingObjectOutlineColorItem1.Id = 525;
            this.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1";
            // 
            // changeFloatingObjectOutlineWeightItem1
            // 
            this.changeFloatingObjectOutlineWeightItem1.Edit = this.repositoryItemFloatingObjectOutlineWeight2;
            this.changeFloatingObjectOutlineWeightItem1.EditValue = 20;
            this.changeFloatingObjectOutlineWeightItem1.EditWidth = 130;
            this.changeFloatingObjectOutlineWeightItem1.Id = 526;
            this.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1";
            // 
            // repositoryItemFloatingObjectOutlineWeight2
            // 
            this.repositoryItemFloatingObjectOutlineWeight2.AutoHeight = false;
            this.repositoryItemFloatingObjectOutlineWeight2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFloatingObjectOutlineWeight2.Control = this.snapControl1;
            this.repositoryItemFloatingObjectOutlineWeight2.Name = "repositoryItemFloatingObjectOutlineWeight2";
            // 
            // changeFloatingObjectTextWrapTypeItem1
            // 
            this.changeFloatingObjectTextWrapTypeItem1.Id = 527;
            this.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectSquareTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTightTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectThroughTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopAndBottomTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBehindTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectInFrontOfTextWrapTypeItem1)});
            this.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1";
            // 
            // setFloatingObjectSquareTextWrapTypeItem1
            // 
            this.setFloatingObjectSquareTextWrapTypeItem1.Id = 528;
            this.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1";
            // 
            // setFloatingObjectTightTextWrapTypeItem1
            // 
            this.setFloatingObjectTightTextWrapTypeItem1.Id = 529;
            this.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1";
            // 
            // setFloatingObjectThroughTextWrapTypeItem1
            // 
            this.setFloatingObjectThroughTextWrapTypeItem1.Id = 530;
            this.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1";
            // 
            // setFloatingObjectTopAndBottomTextWrapTypeItem1
            // 
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 531;
            this.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1";
            // 
            // setFloatingObjectBehindTextWrapTypeItem1
            // 
            this.setFloatingObjectBehindTextWrapTypeItem1.Id = 532;
            this.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1";
            // 
            // setFloatingObjectInFrontOfTextWrapTypeItem1
            // 
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 533;
            this.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1";
            // 
            // changeFloatingObjectAlignmentItem1
            // 
            this.changeFloatingObjectAlignmentItem1.Id = 534;
            this.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectTopRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectMiddleRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setFloatingObjectBottomRightAlignmentItem1)});
            this.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1";
            // 
            // setFloatingObjectTopLeftAlignmentItem1
            // 
            this.setFloatingObjectTopLeftAlignmentItem1.Id = 535;
            this.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1";
            // 
            // setFloatingObjectTopCenterAlignmentItem1
            // 
            this.setFloatingObjectTopCenterAlignmentItem1.Id = 536;
            this.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1";
            // 
            // setFloatingObjectTopRightAlignmentItem1
            // 
            this.setFloatingObjectTopRightAlignmentItem1.Id = 537;
            this.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1";
            // 
            // setFloatingObjectMiddleLeftAlignmentItem1
            // 
            this.setFloatingObjectMiddleLeftAlignmentItem1.Id = 538;
            this.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1";
            // 
            // setFloatingObjectMiddleCenterAlignmentItem1
            // 
            this.setFloatingObjectMiddleCenterAlignmentItem1.Id = 539;
            this.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1";
            // 
            // setFloatingObjectMiddleRightAlignmentItem1
            // 
            this.setFloatingObjectMiddleRightAlignmentItem1.Id = 540;
            this.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1";
            // 
            // setFloatingObjectBottomLeftAlignmentItem1
            // 
            this.setFloatingObjectBottomLeftAlignmentItem1.Id = 541;
            this.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1";
            // 
            // setFloatingObjectBottomCenterAlignmentItem1
            // 
            this.setFloatingObjectBottomCenterAlignmentItem1.Id = 542;
            this.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1";
            // 
            // setFloatingObjectBottomRightAlignmentItem1
            // 
            this.setFloatingObjectBottomRightAlignmentItem1.Id = 543;
            this.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1";
            // 
            // floatingObjectBringForwardSubItem1
            // 
            this.floatingObjectBringForwardSubItem1.Id = 544;
            this.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringForwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringToFrontItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectBringInFrontOfTextItem1)});
            this.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1";
            // 
            // floatingObjectBringForwardItem1
            // 
            this.floatingObjectBringForwardItem1.Id = 545;
            this.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1";
            // 
            // floatingObjectBringToFrontItem1
            // 
            this.floatingObjectBringToFrontItem1.Id = 546;
            this.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1";
            // 
            // floatingObjectBringInFrontOfTextItem1
            // 
            this.floatingObjectBringInFrontOfTextItem1.Id = 547;
            this.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1";
            // 
            // floatingObjectSendBackwardSubItem1
            // 
            this.floatingObjectSendBackwardSubItem1.Id = 548;
            this.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendBackwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendToBackItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatingObjectSendBehindTextItem1)});
            this.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1";
            // 
            // floatingObjectSendBackwardItem1
            // 
            this.floatingObjectSendBackwardItem1.Id = 549;
            this.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1";
            // 
            // floatingObjectSendToBackItem1
            // 
            this.floatingObjectSendToBackItem1.Id = 550;
            this.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1";
            // 
            // floatingObjectSendBehindTextItem1
            // 
            this.floatingObjectSendBehindTextItem1.Id = 551;
            this.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1";
            // 
            // themesGalleryBarItem1
            // 
            // 
            // 
            // 
            this.themesGalleryBarItem1.Gallery.ColumnCount = 7;
            this.themesGalleryBarItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.themesGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
            this.themesGalleryBarItem1.Gallery.RowCount = 1;
            this.themesGalleryBarItem1.Id = 552;
            this.themesGalleryBarItem1.Name = "themesGalleryBarItem1";
            // 
            // commandBarCheckItem2
            // 
            this.commandBarCheckItem2.Id = 553;
            this.commandBarCheckItem2.Name = "commandBarCheckItem2";
            this.commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField;
            // 
            // commandBarCheckItem3
            // 
            this.commandBarCheckItem3.Id = 554;
            this.commandBarCheckItem3.Name = "commandBarCheckItem3";
            this.commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending;
            // 
            // commandBarCheckItem4
            // 
            this.commandBarCheckItem4.Id = 555;
            this.commandBarCheckItem4.Name = "commandBarCheckItem4";
            this.commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending;
            // 
            // commandBarSubItem1
            // 
            this.commandBarSubItem1.Id = 556;
            this.commandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem9)});
            this.commandBarSubItem1.Name = "commandBarSubItem1";
            this.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField;
            // 
            // commandBarCheckItem5
            // 
            this.commandBarCheckItem5.Id = 557;
            this.commandBarCheckItem5.Name = "commandBarCheckItem5";
            this.commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount;
            // 
            // commandBarCheckItem6
            // 
            this.commandBarCheckItem6.Id = 558;
            this.commandBarCheckItem6.Name = "commandBarCheckItem6";
            this.commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum;
            // 
            // commandBarCheckItem7
            // 
            this.commandBarCheckItem7.Id = 559;
            this.commandBarCheckItem7.Name = "commandBarCheckItem7";
            this.commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage;
            // 
            // commandBarCheckItem8
            // 
            this.commandBarCheckItem8.Id = 560;
            this.commandBarCheckItem8.Name = "commandBarCheckItem8";
            this.commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax;
            // 
            // commandBarCheckItem9
            // 
            this.commandBarCheckItem9.Id = 561;
            this.commandBarCheckItem9.Name = "commandBarCheckItem9";
            this.commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin;
            // 
            // filterPopupButtonItem1
            // 
            this.filterPopupButtonItem1.ActAsDropDown = true;
            this.filterPopupButtonItem1.Id = 562;
            this.filterPopupButtonItem1.Name = "filterPopupButtonItem1";
            // 
            // propertiesBarButtonItem1
            // 
            this.propertiesBarButtonItem1.ActAsDropDown = true;
            this.propertiesBarButtonItem1.Id = 563;
            this.propertiesBarButtonItem1.Name = "propertiesBarButtonItem1";
            this.propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarSubItem2
            // 
            this.commandBarSubItem2.Id = 564;
            this.commandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem11)});
            this.commandBarSubItem2.Name = "commandBarSubItem2";
            this.commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader;
            // 
            // commandBarCheckItem10
            // 
            this.commandBarCheckItem10.Id = 565;
            this.commandBarCheckItem10.Name = "commandBarCheckItem10";
            this.commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader;
            // 
            // commandBarCheckItem11
            // 
            this.commandBarCheckItem11.Id = 566;
            this.commandBarCheckItem11.Name = "commandBarCheckItem11";
            this.commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader;
            // 
            // commandBarSubItem3
            // 
            this.commandBarSubItem3.Id = 567;
            this.commandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem13)});
            this.commandBarSubItem3.Name = "commandBarSubItem3";
            this.commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter;
            // 
            // commandBarCheckItem12
            // 
            this.commandBarCheckItem12.Id = 568;
            this.commandBarCheckItem12.Name = "commandBarCheckItem12";
            this.commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter;
            // 
            // commandBarCheckItem13
            // 
            this.commandBarCheckItem13.Id = 569;
            this.commandBarCheckItem13.Name = "commandBarCheckItem13";
            this.commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter;
            // 
            // commandBarItem8
            // 
            this.commandBarItem8.Id = 570;
            this.commandBarItem8.Name = "commandBarItem8";
            this.commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection;
            // 
            // commandBarItem9
            // 
            this.commandBarItem9.Id = 571;
            this.commandBarItem9.Name = "commandBarItem9";
            this.commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm;
            // 
            // commandBarSubItem4
            // 
            this.commandBarSubItem4.Id = 572;
            this.commandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem20)});
            this.commandBarSubItem4.Name = "commandBarSubItem4";
            this.commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator;
            // 
            // commandBarCheckItem14
            // 
            this.commandBarCheckItem14.Id = 573;
            this.commandBarCheckItem14.Name = "commandBarCheckItem14";
            this.commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator;
            // 
            // commandBarCheckItem15
            // 
            this.commandBarCheckItem15.Id = 574;
            this.commandBarCheckItem15.Name = "commandBarCheckItem15";
            this.commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator;
            // 
            // commandBarCheckItem16
            // 
            this.commandBarCheckItem16.Id = 575;
            this.commandBarCheckItem16.Name = "commandBarCheckItem16";
            this.commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator;
            // 
            // commandBarCheckItem17
            // 
            this.commandBarCheckItem17.Id = 576;
            this.commandBarCheckItem17.Name = "commandBarCheckItem17";
            this.commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator;
            // 
            // commandBarCheckItem18
            // 
            this.commandBarCheckItem18.Id = 577;
            this.commandBarCheckItem18.Name = "commandBarCheckItem18";
            this.commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator;
            // 
            // commandBarCheckItem19
            // 
            this.commandBarCheckItem19.Id = 578;
            this.commandBarCheckItem19.Name = "commandBarCheckItem19";
            this.commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator;
            // 
            // commandBarCheckItem20
            // 
            this.commandBarCheckItem20.Id = 579;
            this.commandBarCheckItem20.Name = "commandBarCheckItem20";
            this.commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator;
            // 
            // commandBarSubItem5
            // 
            this.commandBarSubItem5.Id = 581;
            this.commandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem21),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem22)});
            this.commandBarSubItem5.Name = "commandBarSubItem5";
            this.commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader;
            // 
            // commandBarCheckItem21
            // 
            this.commandBarCheckItem21.Id = 582;
            this.commandBarCheckItem21.Name = "commandBarCheckItem21";
            this.commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader;
            // 
            // commandBarCheckItem22
            // 
            this.commandBarCheckItem22.Id = 583;
            this.commandBarCheckItem22.Name = "commandBarCheckItem22";
            this.commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader;
            // 
            // commandBarSubItem6
            // 
            this.commandBarSubItem6.Id = 584;
            this.commandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem24)});
            this.commandBarSubItem6.Name = "commandBarSubItem6";
            this.commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter;
            // 
            // commandBarCheckItem23
            // 
            this.commandBarCheckItem23.Id = 585;
            this.commandBarCheckItem23.Name = "commandBarCheckItem23";
            this.commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter;
            // 
            // commandBarCheckItem24
            // 
            this.commandBarCheckItem24.Id = 586;
            this.commandBarCheckItem24.Name = "commandBarCheckItem24";
            this.commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter;
            // 
            // commandBarSubItem7
            // 
            this.commandBarSubItem7.Id = 587;
            this.commandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem26),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem28),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem29),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem30),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarCheckItem31)});
            this.commandBarSubItem7.Name = "commandBarSubItem7";
            this.commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator;
            // 
            // commandBarCheckItem25
            // 
            this.commandBarCheckItem25.Id = 588;
            this.commandBarCheckItem25.Name = "commandBarCheckItem25";
            this.commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator;
            // 
            // commandBarCheckItem26
            // 
            this.commandBarCheckItem26.Id = 589;
            this.commandBarCheckItem26.Name = "commandBarCheckItem26";
            this.commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator;
            // 
            // commandBarCheckItem27
            // 
            this.commandBarCheckItem27.Id = 590;
            this.commandBarCheckItem27.Name = "commandBarCheckItem27";
            this.commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator;
            // 
            // commandBarCheckItem28
            // 
            this.commandBarCheckItem28.Id = 591;
            this.commandBarCheckItem28.Name = "commandBarCheckItem28";
            this.commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator;
            // 
            // commandBarCheckItem29
            // 
            this.commandBarCheckItem29.Id = 592;
            this.commandBarCheckItem29.Name = "commandBarCheckItem29";
            this.commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator;
            // 
            // commandBarCheckItem30
            // 
            this.commandBarCheckItem30.Id = 593;
            this.commandBarCheckItem30.Name = "commandBarCheckItem30";
            this.commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator;
            // 
            // commandBarCheckItem31
            // 
            this.commandBarCheckItem31.Id = 594;
            this.commandBarCheckItem31.Name = "commandBarCheckItem31";
            this.commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator;
            // 
            // commandBarItem10
            // 
            this.commandBarItem10.Id = 595;
            this.commandBarItem10.Name = "commandBarItem10";
            this.commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList;
            // 
            // commandBarItem11
            // 
            this.commandBarItem11.Id = 596;
            this.commandBarItem11.Name = "commandBarItem11";
            this.commandBarItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs;
            // 
            // commandBarItem12
            // 
            this.commandBarItem12.Id = 597;
            this.commandBarItem12.Name = "commandBarItem12";
            this.commandBarItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList;
            // 
            // barButtonGroup8
            // 
            this.barButtonGroup8.Id = 580;
            this.barButtonGroup8.ItemLinks.Add(this.changeEditorRowLimitItem1);
            this.barButtonGroup8.Name = "barButtonGroup8";
            this.barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // changeEditorRowLimitItem1
            // 
            this.changeEditorRowLimitItem1.Edit = this.repositoryItemEditorRowLimitEdit2;
            this.changeEditorRowLimitItem1.EditWidth = 90;
            this.changeEditorRowLimitItem1.Id = 598;
            this.changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1";
            // 
            // repositoryItemEditorRowLimitEdit2
            // 
            this.repositoryItemEditorRowLimitEdit2.AutoHeight = false;
            this.repositoryItemEditorRowLimitEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemEditorRowLimitEdit2.Control = this.snapControl1;
            this.repositoryItemEditorRowLimitEdit2.Name = "repositoryItemEditorRowLimitEdit2";
            // 
            // createBarBaseItem1
            // 
            this.createBarBaseItem1.DropDownControl = this.commandBarGalleryDropDown36;
            this.createBarBaseItem1.Id = 599;
            this.createBarBaseItem1.Name = "createBarBaseItem1";
            // 
            // commandBarGalleryDropDown36
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown36.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown36.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem1,
            createFullStackedBarChartItem1,
            createSideBySideFullStackedBarChartItem1,
            createSideBySideStackedBarChartItem1,
            createStackedBarChartItem1});
            chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem1,
            createFullStackedBar3DChartItem1,
            createManhattanBarChartItem1,
            createSideBySideFullStackedBar3DChartItem1,
            createSideBySideStackedBar3DChartItem1,
            createStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem1,
            createCylinderFullStackedBar3DChartItem1,
            createCylinderManhattanBarChartItem1,
            createCylinderSideBySideFullStackedBar3DChartItem1,
            createCylinderSideBySideStackedBar3DChartItem1,
            createCylinderStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem1,
            createConeFullStackedBar3DChartItem1,
            createConeManhattanBarChartItem1,
            createConeSideBySideFullStackedBar3DChartItem1,
            createConeSideBySideStackedBar3DChartItem1,
            createConeStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem1,
            createPyramidFullStackedBar3DChartItem1,
            createPyramidManhattanBarChartItem1,
            createPyramidSideBySideFullStackedBar3DChartItem1,
            createPyramidSideBySideStackedBar3DChartItem1,
            createPyramidStackedBar3DChartItem1});
            this.commandBarGalleryDropDown36.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn1,
            chartControlCommandGalleryItemGroup3DColumn1,
            chartControlCommandGalleryItemGroupCylinderColumn1,
            chartControlCommandGalleryItemGroupConeColumn1,
            chartControlCommandGalleryItemGroupPyramidColumn1});
            this.commandBarGalleryDropDown36.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown36.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown36.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown36.Name = "commandBarGalleryDropDown36";
            this.commandBarGalleryDropDown36.Ribbon = this.ribbonControl1;
            // 
            // createLineBaseItem1
            // 
            this.createLineBaseItem1.DropDownControl = this.commandBarGalleryDropDown37;
            this.createLineBaseItem1.Id = 600;
            this.createLineBaseItem1.Name = "createLineBaseItem1";
            // 
            // commandBarGalleryDropDown37
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown37.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown37.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem1,
            createFullStackedLineChartItem1,
            createScatterLineChartItem1,
            createSplineChartItem1,
            createStackedLineChartItem1,
            createStepLineChartItem1});
            chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem1,
            createFullStackedLine3DChartItem1,
            createSpline3DChartItem1,
            createStackedLine3DChartItem1,
            createStepLine3DChartItem1});
            this.commandBarGalleryDropDown37.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine1,
            chartControlCommandGalleryItemGroup3DLine1});
            this.commandBarGalleryDropDown37.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown37.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown37.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown37.Name = "commandBarGalleryDropDown37";
            this.commandBarGalleryDropDown37.Ribbon = this.ribbonControl1;
            // 
            // createPieBaseItem1
            // 
            this.createPieBaseItem1.DropDownControl = this.commandBarGalleryDropDown38;
            this.createPieBaseItem1.Id = 601;
            this.createPieBaseItem1.Name = "createPieBaseItem1";
            // 
            // commandBarGalleryDropDown38
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown38.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown38.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem1,
            createDoughnutChartItem1});
            chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem1,
            createDoughnut3DChartItem1});
            this.commandBarGalleryDropDown38.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie1,
            chartControlCommandGalleryItemGroup3DPie1});
            this.commandBarGalleryDropDown38.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown38.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown38.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown38.Name = "commandBarGalleryDropDown38";
            this.commandBarGalleryDropDown38.Ribbon = this.ribbonControl1;
            // 
            // createRotatedBarBaseItem1
            // 
            this.createRotatedBarBaseItem1.DropDownControl = this.commandBarGalleryDropDown39;
            this.createRotatedBarBaseItem1.Id = 602;
            this.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1";
            // 
            // commandBarGalleryDropDown39
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown39.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown39.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem1,
            createRotatedFullStackedBarChartItem1,
            createRotatedSideBySideFullStackedBarChartItem1,
            createRotatedSideBySideStackedBarChartItem1,
            createRotatedStackedBarChartItem1});
            this.commandBarGalleryDropDown39.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar1});
            this.commandBarGalleryDropDown39.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown39.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown39.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown39.Name = "commandBarGalleryDropDown39";
            this.commandBarGalleryDropDown39.Ribbon = this.ribbonControl1;
            // 
            // createAreaBaseItem1
            // 
            this.createAreaBaseItem1.DropDownControl = this.commandBarGalleryDropDown40;
            this.createAreaBaseItem1.Id = 603;
            this.createAreaBaseItem1.Name = "createAreaBaseItem1";
            // 
            // commandBarGalleryDropDown40
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown40.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown40.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem1,
            createFullStackedAreaChartItem1,
            createFullStackedSplineAreaChartItem1,
            createSplineAreaChartItem1,
            createStackedAreaChartItem1,
            createStackedSplineAreaChartItem1,
            createStepAreaChartItem1});
            chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem1,
            createFullStackedArea3DChartItem1,
            createFullStackedSplineArea3DChartItem1,
            createSplineArea3DChartItem1,
            createStackedArea3DChartItem1,
            createStackedSplineArea3DChartItem1,
            createStepArea3DChartItem1});
            this.commandBarGalleryDropDown40.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea1,
            chartControlCommandGalleryItemGroup3DArea1});
            this.commandBarGalleryDropDown40.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown40.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown40.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown40.Name = "commandBarGalleryDropDown40";
            this.commandBarGalleryDropDown40.Ribbon = this.ribbonControl1;
            // 
            // createOtherSeriesTypesBaseItem1
            // 
            this.createOtherSeriesTypesBaseItem1.DropDownControl = this.commandBarGalleryDropDown41;
            this.createOtherSeriesTypesBaseItem1.Id = 604;
            this.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1";
            // 
            // commandBarGalleryDropDown41
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown41.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown41.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroupPoint1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem1,
            createBubbleChartItem1});
            chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem1,
            createFunnel3DChartItem1});
            chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem1,
            createCandleStickChartItem1});
            chartControlCommandGalleryItemGroupRadar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem1,
            createRadarLineChartItem1,
            createRadarAreaChartItem1});
            chartControlCommandGalleryItemGroupPolar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem1,
            createPolarLineChartItem1,
            createPolarAreaChartItem1});
            chartControlCommandGalleryItemGroupRange1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem1,
            createSideBySideRangeBarChartItem1,
            createRangeAreaChartItem1,
            createRangeArea3DChartItem1});
            chartControlCommandGalleryItemGroupGantt1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem1,
            createSideBySideGanttChartItem1});
            this.commandBarGalleryDropDown41.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint1,
            chartControlCommandGalleryItemGroupFunnel1,
            chartControlCommandGalleryItemGroupFinancial1,
            chartControlCommandGalleryItemGroupRadar1,
            chartControlCommandGalleryItemGroupPolar1,
            chartControlCommandGalleryItemGroupRange1,
            chartControlCommandGalleryItemGroupGantt1});
            this.commandBarGalleryDropDown41.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown41.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown41.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown41.Name = "commandBarGalleryDropDown41";
            this.commandBarGalleryDropDown41.Ribbon = this.ribbonControl1;
            // 
            // changePaletteGalleryBaseItem1
            // 
            this.changePaletteGalleryBaseItem1.DropDownControl = this.commandBarGalleryDropDown42;
            this.changePaletteGalleryBaseItem1.Id = 605;
            this.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1";
            // 
            // commandBarGalleryDropDown42
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown42.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown42.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown42.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown42.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown42.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown42.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            this.commandBarGalleryDropDown42.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -3;
            skinPaddingEdges2.Top = -3;
            this.commandBarGalleryDropDown42.Gallery.ItemTextPadding = skinPaddingEdges2;
            this.commandBarGalleryDropDown42.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown42.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown42.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown42.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown42.Name = "commandBarGalleryDropDown42";
            this.commandBarGalleryDropDown42.Ribbon = this.ribbonControl1;
            // 
            // changeAppearanceGalleryBaseItem1
            // 
            // 
            // 
            // 
            this.changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7;
            this.changeAppearanceGalleryBaseItem1.Gallery.ImageSize = new System.Drawing.Size(80, 50);
            this.changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4;
            this.changeAppearanceGalleryBaseItem1.Id = 606;
            this.changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1";
            // 
            // runWizardChartItem1
            // 
            this.runWizardChartItem1.Id = 607;
            this.runWizardChartItem1.Name = "runWizardChartItem1";
            // 
            // mailMergeDataSourceItem1
            // 
            this.mailMergeDataSourceItem1.Id = 608;
            this.mailMergeDataSourceItem1.Name = "mailMergeDataSourceItem1";
            // 
            // commandBarCheckItem32
            // 
            this.commandBarCheckItem32.Id = 609;
            this.commandBarCheckItem32.Name = "commandBarCheckItem32";
            this.commandBarCheckItem32.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters;
            // 
            // commandBarCheckItem33
            // 
            this.commandBarCheckItem33.Id = 610;
            this.commandBarCheckItem33.Name = "commandBarCheckItem33";
            this.commandBarCheckItem33.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting;
            // 
            // mailMergeCurrentRecordItem1
            // 
            this.mailMergeCurrentRecordItem1.Description = resources.GetString("mailMergeCurrentRecordItem1.Description");
            this.mailMergeCurrentRecordItem1.Edit = this.repositoryItemMailMergeCurrentRecordEdit2;
            this.mailMergeCurrentRecordItem1.EditWidth = 90;
            this.mailMergeCurrentRecordItem1.Id = 611;
            this.mailMergeCurrentRecordItem1.Name = "mailMergeCurrentRecordItem1";
            // 
            // repositoryItemMailMergeCurrentRecordEdit2
            // 
            this.repositoryItemMailMergeCurrentRecordEdit2.AutoHeight = false;
            this.repositoryItemMailMergeCurrentRecordEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit2.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, null, true)});
            this.repositoryItemMailMergeCurrentRecordEdit2.Name = "repositoryItemMailMergeCurrentRecordEdit2";
            // 
            // commandBarSubItem8
            // 
            this.commandBarSubItem8.Id = 612;
            this.commandBarSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.commandBarItem15)});
            this.commandBarSubItem8.Name = "commandBarSubItem8";
            this.commandBarSubItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.commandBarSubItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FinishAndMerge;
            // 
            // commandBarItem13
            // 
            this.commandBarItem13.Id = 613;
            this.commandBarItem13.Name = "commandBarItem13";
            this.commandBarItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergeExportDocument;
            // 
            // commandBarItem14
            // 
            this.commandBarItem14.Id = 614;
            this.commandBarItem14.Name = "commandBarItem14";
            this.commandBarItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrint;
            // 
            // commandBarItem15
            // 
            this.commandBarItem15.Id = 615;
            this.commandBarItem15.Name = "commandBarItem15";
            this.commandBarItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrintPreview;
            // 
            // headerFooterToolsRibbonPageCategory1
            // 
            this.headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(176)))), ((int)(((byte)(35)))));
            this.headerFooterToolsRibbonPageCategory1.Control = this.snapControl1;
            this.headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1";
            this.headerFooterToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.headerFooterToolsDesignRibbonPage1});
            // 
            // headerFooterToolsDesignRibbonPage1
            // 
            this.headerFooterToolsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.headerFooterToolsDesignNavigationRibbonPageGroup1,
            this.headerFooterToolsDesignOptionsRibbonPageGroup1,
            this.headerFooterToolsDesignCloseRibbonPageGroup1});
            this.headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1";
            // 
            // headerFooterToolsDesignNavigationRibbonPageGroup1
            // 
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToPageHeaderItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToPageFooterItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToNextHeaderFooterItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.goToPreviousHeaderFooterItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(this.toggleLinkToPreviousItem1);
            this.headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1";
            // 
            // headerFooterToolsDesignOptionsRibbonPageGroup1
            // 
            this.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleDifferentFirstPageItem1);
            this.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleDifferentOddAndEvenPagesItem1);
            this.headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1";
            // 
            // headerFooterToolsDesignCloseRibbonPageGroup1
            // 
            this.headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(this.closePageHeaderFooterItem1);
            this.headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1";
            // 
            // tableToolsRibbonPageCategory1
            // 
            this.tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(20)))));
            this.tableToolsRibbonPageCategory1.Control = this.snapControl1;
            this.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1";
            this.tableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tableDesignRibbonPage1,
            this.tableLayoutRibbonPage1});
            // 
            // tableDesignRibbonPage1
            // 
            this.tableDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tableStyleOptionsRibbonPageGroup1,
            this.tableStylesRibbonPageGroup1,
            this.tableCellStylesRibbonPageGroup1,
            this.tableDrawBordersRibbonPageGroup1});
            this.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1";
            // 
            // tableStyleOptionsRibbonPageGroup1
            // 
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleFirstRowItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleLastRowItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleBandedRowsItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleFirstColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleLastColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.toggleBandedColumnItem1);
            this.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            // 
            // tableStylesRibbonPageGroup1
            // 
            this.tableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeTableStyleItem1);
            this.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            // 
            // tableCellStylesRibbonPageGroup1
            // 
            this.tableCellStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeTableCellStyleItem1);
            this.tableCellStylesRibbonPageGroup1.Name = "tableCellStylesRibbonPageGroup1";
            // 
            // tableDrawBordersRibbonPageGroup1
            // 
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderLineStyleItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderLineWeightItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBorderColorItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableBordersItem1);
            this.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(this.changeTableCellsShadingItem1);
            this.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1";
            // 
            // tableLayoutRibbonPage1
            // 
            this.tableLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tableTableRibbonPageGroup1,
            this.tableRowsAndColumnsRibbonPageGroup1,
            this.tableMergeRibbonPageGroup1,
            this.tableCellSizeRibbonPageGroup1,
            this.tableAlignmentRibbonPageGroup1});
            this.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1";
            // 
            // tableTableRibbonPageGroup1
            // 
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.selectTableElementsItem1);
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.toggleShowTableGridLinesItem1);
            this.tableTableRibbonPageGroup1.ItemLinks.Add(this.showTablePropertiesFormItem1);
            this.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1";
            // 
            // tableRowsAndColumnsRibbonPageGroup1
            // 
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.deleteTableElementsItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableRowAboveItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableRowBelowItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableColumnToLeftItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(this.insertTableColumnToRightItem1);
            this.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1";
            // 
            // tableMergeRibbonPageGroup1
            // 
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.mergeTableCellsItem1);
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.showSplitTableCellsForm1);
            this.tableMergeRibbonPageGroup1.ItemLinks.Add(this.splitTableItem1);
            this.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1";
            // 
            // tableCellSizeRibbonPageGroup1
            // 
            this.tableCellSizeRibbonPageGroup1.AllowTextClipping = false;
            this.tableCellSizeRibbonPageGroup1.ItemLinks.Add(this.toggleTableAutoFitItem1);
            this.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1";
            // 
            // tableAlignmentRibbonPageGroup1
            // 
            this.tableAlignmentRibbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("tableAlignmentRibbonPageGroup1.Glyph")));
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.tableAlignmentRibbonPageGroup1.ItemLinks.Add(this.showTableOptionsFormItem1);
            this.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1";
            // 
            // floatingPictureToolsRibbonPageCategory1
            // 
            this.floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.floatingPictureToolsRibbonPageCategory1.Control = this.snapControl1;
            this.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1";
            this.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.floatingPictureToolsFormatPage1});
            // 
            // floatingPictureToolsFormatPage1
            // 
            this.floatingPictureToolsFormatPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.floatingPictureToolsShapeStylesPageGroup1,
            this.floatingPictureToolsArrangePageGroup1});
            this.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1";
            // 
            // floatingPictureToolsShapeStylesPageGroup1
            // 
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectFillColorItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectOutlineColorItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(this.changeFloatingObjectOutlineWeightItem1);
            this.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1";
            // 
            // floatingPictureToolsArrangePageGroup1
            // 
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.changeFloatingObjectTextWrapTypeItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.changeFloatingObjectAlignmentItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.floatingObjectBringForwardSubItem1);
            this.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(this.floatingObjectSendBackwardSubItem1);
            this.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1";
            // 
            // dataToolsRibbonPageCategory1
            // 
            this.dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(207)))));
            this.dataToolsRibbonPageCategory1.Control = this.snapControl1;
            this.dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1";
            this.dataToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.appearanceRibbonPage1,
            this.snMergeFieldToolsRibbonPage1,
            this.groupToolsRibbonPage1,
            this.listToolsRibbonPage1,
            this.mailMergeRibbonPage1});
            // 
            // appearanceRibbonPage1
            // 
            this.appearanceRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.themesRibbonPageGroup1});
            this.appearanceRibbonPage1.Name = "appearanceRibbonPage1";
            // 
            // themesRibbonPageGroup1
            // 
            this.themesRibbonPageGroup1.ItemLinks.Add(this.themesGalleryBarItem1);
            this.themesRibbonPageGroup1.Name = "themesRibbonPageGroup1";
            // 
            // snMergeFieldToolsRibbonPage1
            // 
            this.snMergeFieldToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.dataShapingRibbonPageGroup1,
            this.snMergeFieldPropertiesRibbonPageGroup1});
            this.snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1";
            // 
            // dataShapingRibbonPageGroup1
            // 
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem2);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem3);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem4);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem1);
            this.dataShapingRibbonPageGroup1.ItemLinks.Add(this.filterPopupButtonItem1);
            this.dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1";
            // 
            // snMergeFieldPropertiesRibbonPageGroup1
            // 
            this.snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(this.propertiesBarButtonItem1);
            this.snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1";
            // 
            // groupToolsRibbonPage1
            // 
            this.groupToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupingRibbonPageGroup1});
            this.groupToolsRibbonPage1.Name = "groupToolsRibbonPage1";
            // 
            // groupingRibbonPageGroup1
            // 
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem2);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem3);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarItem8);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarItem9);
            this.groupingRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem4);
            this.groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1";
            // 
            // listToolsRibbonPage1
            // 
            this.listToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.listHeaderAndFooterRibbonPageGroup1,
            this.listCommandsRibbonPageGroup1,
            this.listEditorRowLimitRibbonPageGroup1});
            this.listToolsRibbonPage1.Name = "listToolsRibbonPage1";
            // 
            // listHeaderAndFooterRibbonPageGroup1
            // 
            this.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem5);
            this.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem6);
            this.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem7);
            this.listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1";
            // 
            // listCommandsRibbonPageGroup1
            // 
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarItem10);
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarItem11);
            this.listCommandsRibbonPageGroup1.ItemLinks.Add(this.commandBarItem12);
            this.listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1";
            // 
            // listEditorRowLimitRibbonPageGroup1
            // 
            this.listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup8);
            this.listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1";
            // 
            // mailMergeRibbonPage1
            // 
            this.mailMergeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeRibbonPageGroup1,
            this.mailMergeCurrentRecordRibbonPageGroup1,
            this.finishAndMergeRibbonPageGroup1});
            this.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1";
            // 
            // mailMergeRibbonPageGroup1
            // 
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.mailMergeDataSourceItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem32);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem33);
            this.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1";
            // 
            // mailMergeCurrentRecordRibbonPageGroup1
            // 
            this.mailMergeCurrentRecordRibbonPageGroup1.ItemLinks.Add(this.mailMergeCurrentRecordItem1);
            this.mailMergeCurrentRecordRibbonPageGroup1.Name = "mailMergeCurrentRecordRibbonPageGroup1";
            // 
            // finishAndMergeRibbonPageGroup1
            // 
            this.finishAndMergeRibbonPageGroup1.ItemLinks.Add(this.commandBarSubItem8);
            this.finishAndMergeRibbonPageGroup1.Name = "finishAndMergeRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.dataRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.undoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.redoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileNewItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileOpenItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveAsItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.commandBarItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.quickPrintItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // dataRibbonPageGroup1
            // 
            this.dataRibbonPageGroup1.ItemLinks.Add(this.commandBarItem2);
            this.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.clipboardRibbonPageGroup1,
            this.fontRibbonPageGroup1,
            this.paragraphRibbonPageGroup1,
            this.stylesRibbonPageGroup1,
            this.editingRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation1.Group = this.stylesRibbonPageGroup1;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
            // 
            // clipboardRibbonPageGroup1
            // 
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.pasteItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.cutItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.copyItem1);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.pasteSpecialItem1);
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            // 
            // fontRibbonPageGroup1
            // 
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.changeTextCaseItem1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.clearFormattingItem1);
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            // 
            // paragraphRibbonPageGroup1
            // 
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
            this.paragraphRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
            this.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1";
            // 
            // editingRibbonPageGroup1
            // 
            this.editingRibbonPageGroup1.ItemLinks.Add(this.findItem1);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.replaceItem1);
            this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            // 
            // insertRibbonPage1
            // 
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pagesRibbonPageGroup1,
            this.tablesRibbonPageGroup1,
            this.illustrationsRibbonPageGroup1,
            this.toolboxRibbonPageGroup1,
            this.linksRibbonPageGroup1,
            this.headerFooterRibbonPageGroup1,
            this.textRibbonPageGroup1,
            this.symbolsRibbonPageGroup1});
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            // 
            // pagesRibbonPageGroup1
            // 
            this.pagesRibbonPageGroup1.AllowTextClipping = false;
            this.pagesRibbonPageGroup1.ItemLinks.Add(this.insertPageBreakItem21);
            this.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1";
            // 
            // tablesRibbonPageGroup1
            // 
            this.tablesRibbonPageGroup1.AllowTextClipping = false;
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.insertTableItem1);
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // illustrationsRibbonPageGroup1
            // 
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertPictureItem1);
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertFloatingPictureItem1);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            // 
            // toolboxRibbonPageGroup1
            // 
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem3);
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem4);
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem5);
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem6);
            this.toolboxRibbonPageGroup1.ItemLinks.Add(this.commandBarItem7);
            this.toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1";
            // 
            // linksRibbonPageGroup1
            // 
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertBookmarkItem1);
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertHyperlinkItem1);
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // headerFooterRibbonPageGroup1
            // 
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.editPageHeaderItem1);
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.editPageFooterItem1);
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.insertPageNumberItem1);
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.insertPageCountItem1);
            this.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1";
            // 
            // textRibbonPageGroup1
            // 
            this.textRibbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("textRibbonPageGroup1.Glyph")));
            this.textRibbonPageGroup1.ItemLinks.Add(this.insertTextBoxItem1);
            this.textRibbonPageGroup1.Name = "textRibbonPageGroup1";
            // 
            // symbolsRibbonPageGroup1
            // 
            this.symbolsRibbonPageGroup1.AllowTextClipping = false;
            this.symbolsRibbonPageGroup1.ItemLinks.Add(this.insertSymbolItem1);
            this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
            // 
            // pageLayoutRibbonPage1
            // 
            this.pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageSetupRibbonPageGroup1,
            this.pageBackgroundRibbonPageGroup1});
            this.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
            // 
            // pageSetupRibbonPageGroup1
            // 
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionPageMarginsItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionPageOrientationItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionPaperKindItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionColumnsItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.insertBreakItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.changeSectionLineNumberingItem1);
            this.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
            // 
            // pageBackgroundRibbonPageGroup1
            // 
            this.pageBackgroundRibbonPageGroup1.AllowTextClipping = false;
            this.pageBackgroundRibbonPageGroup1.ItemLinks.Add(this.changePageColorItem1);
            this.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.documentViewsRibbonPageGroup1,
            this.showRibbonPageGroup1,
            this.zoomRibbonPageGroup1,
            this.viewRibbonPageGroup1,
            this.viewFieldsRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // documentViewsRibbonPageGroup1
            // 
            this.documentViewsRibbonPageGroup1.ItemLinks.Add(this.switchToSimpleViewItem1);
            this.documentViewsRibbonPageGroup1.ItemLinks.Add(this.switchToDraftViewItem1);
            this.documentViewsRibbonPageGroup1.ItemLinks.Add(this.switchToPrintLayoutViewItem1);
            this.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1";
            // 
            // showRibbonPageGroup1
            // 
            this.showRibbonPageGroup1.ItemLinks.Add(this.toggleShowHorizontalRulerItem1);
            this.showRibbonPageGroup1.ItemLinks.Add(this.toggleShowVerticalRulerItem1);
            this.showRibbonPageGroup1.Name = "showRibbonPageGroup1";
            // 
            // zoomRibbonPageGroup1
            // 
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.zoomOutItem1);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.zoomInItem1);
            this.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
            // 
            // viewRibbonPageGroup1
            // 
            this.viewRibbonPageGroup1.ItemLinks.Add(this.snapBarToolbarsListItem1);
            this.viewRibbonPageGroup1.ItemLinks.Add(this.commandBarCheckItem1);
            this.viewRibbonPageGroup1.Name = "viewRibbonPageGroup1";
            // 
            // viewFieldsRibbonPageGroup1
            // 
            this.viewFieldsRibbonPageGroup1.ItemLinks.Add(this.showAllFieldCodesItem1);
            this.viewFieldsRibbonPageGroup1.ItemLinks.Add(this.showAllFieldResultsItem1);
            this.viewFieldsRibbonPageGroup1.ItemLinks.Add(this.toggleFieldHighlightingItem1);
            this.viewFieldsRibbonPageGroup1.Name = "viewFieldsRibbonPageGroup1";
            // 
            // reviewRibbonPage1
            // 
            this.reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.documentProofingRibbonPageGroup1});
            this.reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // documentProofingRibbonPageGroup1
            // 
            this.documentProofingRibbonPageGroup1.ItemLinks.Add(this.checkSpellingItem1);
            this.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1";
            // 
            // referencesRibbonPage1
            // 
            this.referencesRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tableOfContentsRibbonPageGroup1,
            this.captionsRibbonPageGroup1});
            this.referencesRibbonPage1.Name = "referencesRibbonPage1";
            // 
            // tableOfContentsRibbonPageGroup1
            // 
            this.tableOfContentsRibbonPageGroup1.ItemLinks.Add(this.insertTableOfContentsItem1);
            this.tableOfContentsRibbonPageGroup1.ItemLinks.Add(this.updateTableOfContentsItem1);
            this.tableOfContentsRibbonPageGroup1.ItemLinks.Add(this.addParagraphsToTableOfContentItem1);
            this.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1";
            // 
            // captionsRibbonPageGroup1
            // 
            this.captionsRibbonPageGroup1.ItemLinks.Add(this.insertCaptionPlaceholderItem1);
            this.captionsRibbonPageGroup1.ItemLinks.Add(this.insertTableOfFiguresPlaceholderItem1);
            this.captionsRibbonPageGroup1.ItemLinks.Add(this.updateTableOfFiguresItem1);
            this.captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.snapControl1;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // repositoryItemBorderLineStyle1
            // 
            this.repositoryItemBorderLineStyle1.AutoHeight = false;
            this.repositoryItemBorderLineStyle1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineStyle1.Control = this.snapControl1;
            this.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1";
            // 
            // repositoryItemBorderLineWeight1
            // 
            this.repositoryItemBorderLineWeight1.AutoHeight = false;
            this.repositoryItemBorderLineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineWeight1.Control = this.snapControl1;
            this.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1";
            // 
            // repositoryItemFloatingObjectOutlineWeight1
            // 
            this.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = false;
            this.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFloatingObjectOutlineWeight1.Control = this.snapControl1;
            this.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1";
            // 
            // repositoryItemEditorRowLimitEdit1
            // 
            this.repositoryItemEditorRowLimitEdit1.AutoHeight = false;
            this.repositoryItemEditorRowLimitEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemEditorRowLimitEdit1.Control = this.snapControl1;
            this.repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1";
            // 
            // repositoryItemMailMergeCurrentRecordEdit1
            // 
            this.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = false;
            this.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, null, true)});
            this.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1";
            // 
            // commandBarGalleryDropDown29
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown29.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown29.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DColumn2.Caption = "2-D Column";
            createBarChartItem2.Caption = "Clustered Column";
            createBarChartItem2.Description = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createBarChartItem2.Hint = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createFullStackedBarChartItem2.Caption = "100% Stacked Column";
            createFullStackedBarChartItem2.Description = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createFullStackedBarChartItem2.Hint = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createSideBySideFullStackedBarChartItem2.Caption = "Clustered 100% Stacked Column";
            createSideBySideFullStackedBarChartItem2.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideFullStackedBarChartItem2.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideStackedBarChartItem2.Caption = "Clustered Stacked Column";
            createSideBySideStackedBarChartItem2.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createSideBySideStackedBarChartItem2.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createStackedBarChartItem2.Caption = "Stacked Column";
            createStackedBarChartItem2.Description = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            createStackedBarChartItem2.Hint = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            chartControlCommandGalleryItemGroup2DColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem2,
            createFullStackedBarChartItem2,
            createSideBySideFullStackedBarChartItem2,
            createSideBySideStackedBarChartItem2,
            createStackedBarChartItem2});
            chartControlCommandGalleryItemGroup3DColumn2.Caption = "3-D Column";
            createBar3DChartItem2.Caption = "3-D Clustered Column";
            createBar3DChartItem2.Description = "Compare values across categories and display clustered columns in 3-D format.";
            createBar3DChartItem2.Hint = "Compare values across categories and display clustered columns in 3-D format.";
            createFullStackedBar3DChartItem2.Caption = "100% Stacked Column in 3-D";
            createFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createManhattanBarChartItem2.Caption = "3-D Column";
            createManhattanBarChartItem2.Description = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createManhattanBarChartItem2.Hint = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Column in 3-D";
            createSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Column in 3-D";
            createSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createStackedBar3DChartItem2.Caption = "Stacked Column in 3-D";
            createStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            createStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            chartControlCommandGalleryItemGroup3DColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem2,
            createFullStackedBar3DChartItem2,
            createManhattanBarChartItem2,
            createSideBySideFullStackedBar3DChartItem2,
            createSideBySideStackedBar3DChartItem2,
            createStackedBar3DChartItem2});
            chartControlCommandGalleryItemGroupCylinderColumn2.Caption = "Cylinder";
            createCylinderBar3DChartItem2.Caption = "Clustered Cylinder";
            createCylinderBar3DChartItem2.Description = "Compare values across categories.";
            createCylinderBar3DChartItem2.Hint = "Compare values across categories.";
            createCylinderFullStackedBar3DChartItem2.Caption = "100% Stacked Cylinder";
            createCylinderFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories.";
            createCylinderFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories.";
            createCylinderManhattanBarChartItem2.Caption = "3-D Cylinder";
            createCylinderManhattanBarChartItem2.Description = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderManhattanBarChartItem2.Hint = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Cylinder";
            createCylinderSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Cylinder";
            createCylinderSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderStackedBar3DChartItem2.Caption = "Stacked Cylinder";
            createCylinderStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories.";
            createCylinderStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupCylinderColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem2,
            createCylinderFullStackedBar3DChartItem2,
            createCylinderManhattanBarChartItem2,
            createCylinderSideBySideFullStackedBar3DChartItem2,
            createCylinderSideBySideStackedBar3DChartItem2,
            createCylinderStackedBar3DChartItem2});
            chartControlCommandGalleryItemGroupConeColumn2.Caption = "Cone";
            createConeBar3DChartItem2.Caption = "Clustered Cone";
            createConeBar3DChartItem2.Description = "Compare values across categories.";
            createConeBar3DChartItem2.Hint = "Compare values across categories.";
            createConeFullStackedBar3DChartItem2.Caption = "100% Stacked Cone";
            createConeFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories.";
            createConeFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories.";
            createConeManhattanBarChartItem2.Caption = "3-D Cone";
            createConeManhattanBarChartItem2.Description = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeManhattanBarChartItem2.Hint = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Cone";
            createConeSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Cone";
            createConeSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeStackedBar3DChartItem2.Caption = "Stacked Cone";
            createConeStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories.";
            createConeStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupConeColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem2,
            createConeFullStackedBar3DChartItem2,
            createConeManhattanBarChartItem2,
            createConeSideBySideFullStackedBar3DChartItem2,
            createConeSideBySideStackedBar3DChartItem2,
            createConeStackedBar3DChartItem2});
            chartControlCommandGalleryItemGroupPyramidColumn2.Caption = "Pyramid";
            createPyramidBar3DChartItem2.Caption = "Clustered Pyramid";
            createPyramidBar3DChartItem2.Description = "Compare values across categories.";
            createPyramidBar3DChartItem2.Hint = "Compare values across categories.";
            createPyramidFullStackedBar3DChartItem2.Caption = "100% Stacked Pyramid";
            createPyramidFullStackedBar3DChartItem2.Description = "Compare the percentage each value contributes to a total across categories.";
            createPyramidFullStackedBar3DChartItem2.Hint = "Compare the percentage each value contributes to a total across categories.";
            createPyramidManhattanBarChartItem2.Caption = "3-D Pyramid";
            createPyramidManhattanBarChartItem2.Description = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidManhattanBarChartItem2.Hint = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidSideBySideFullStackedBar3DChartItem2.Caption = "Clustered 100% Stacked Pyramid";
            createPyramidSideBySideFullStackedBar3DChartItem2.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideFullStackedBar3DChartItem2.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem2.Caption = "Clustered Stacked Pyramid";
            createPyramidSideBySideStackedBar3DChartItem2.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem2.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidStackedBar3DChartItem2.Caption = "Stacked Pyramid";
            createPyramidStackedBar3DChartItem2.Description = "Compare the contribution of each value to a total across categories.";
            createPyramidStackedBar3DChartItem2.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupPyramidColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem2,
            createPyramidFullStackedBar3DChartItem2,
            createPyramidManhattanBarChartItem2,
            createPyramidSideBySideFullStackedBar3DChartItem2,
            createPyramidSideBySideStackedBar3DChartItem2,
            createPyramidStackedBar3DChartItem2});
            this.commandBarGalleryDropDown29.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn2,
            chartControlCommandGalleryItemGroup3DColumn2,
            chartControlCommandGalleryItemGroupCylinderColumn2,
            chartControlCommandGalleryItemGroupConeColumn2,
            chartControlCommandGalleryItemGroupPyramidColumn2});
            this.commandBarGalleryDropDown29.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown29.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown29.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown29.Name = "commandBarGalleryDropDown29";
            this.commandBarGalleryDropDown29.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown30
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown30.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown30.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DLine2.Caption = "2-D Line";
            createLineChartItem2.Caption = "Line";
            createLineChartItem2.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createLineChartItem2.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createFullStackedLineChartItem2.Caption = "100% Stacked Line";
            createFullStackedLineChartItem2.Description = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createFullStackedLineChartItem2.Hint = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createScatterLineChartItem2.Caption = "Scatter Line";
            createScatterLineChartItem2.Description = "Represent series points in the same order that they have in the collection.";
            createScatterLineChartItem2.Hint = "Represent series points in the same order that they have in the collection.";
            createSplineChartItem2.Caption = "Spline";
            createSplineChartItem2.Description = "Plot a fitted curve through each data point in a series.";
            createSplineChartItem2.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLineChartItem2.Caption = "Stacked Line";
            createStackedLineChartItem2.Description = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStackedLineChartItem2.Hint = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStepLineChartItem2.Caption = "Step Line";
            createStepLineChartItem2.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLineChartItem2.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup2DLine2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem2,
            createFullStackedLineChartItem2,
            createScatterLineChartItem2,
            createSplineChartItem2,
            createStackedLineChartItem2,
            createStepLineChartItem2});
            chartControlCommandGalleryItemGroup3DLine2.Caption = "3-D Line";
            createLine3DChartItem2.Caption = "3-D Line";
            createLine3DChartItem2.Description = "Display each row or column of data as a 3-D ribbon on three axes.";
            createLine3DChartItem2.Hint = "Display each row or column of data as a 3-D ribbon on three axes.";
            createFullStackedLine3DChartItem2.Caption = "100% Stacked Line in 3-D";
            createFullStackedLine3DChartItem2.Description = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createFullStackedLine3DChartItem2.Hint = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createSpline3DChartItem2.Caption = "3-D Spline";
            createSpline3DChartItem2.Description = "Plot a fitted curve through each data point in a series.";
            createSpline3DChartItem2.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLine3DChartItem2.Caption = "Stacked Line in 3-D";
            createStackedLine3DChartItem2.Description = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStackedLine3DChartItem2.Hint = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStepLine3DChartItem2.Caption = "Step Line in 3-D";
            createStepLine3DChartItem2.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLine3DChartItem2.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DLine2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem2,
            createFullStackedLine3DChartItem2,
            createSpline3DChartItem2,
            createStackedLine3DChartItem2,
            createStepLine3DChartItem2});
            this.commandBarGalleryDropDown30.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine2,
            chartControlCommandGalleryItemGroup3DLine2});
            this.commandBarGalleryDropDown30.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown30.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown30.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown30.Name = "commandBarGalleryDropDown30";
            this.commandBarGalleryDropDown30.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown31
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown31.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown31.Gallery.ColumnCount = 2;
            chartControlCommandGalleryItemGroup2DPie2.Caption = "2-D Pie";
            createPieChartItem2.Caption = "Pie";
            createPieChartItem2.Description = resources.GetString("createPieChartItem2.Description");
            createPieChartItem2.Hint = resources.GetString("createPieChartItem2.Hint");
            createDoughnutChartItem2.Caption = "Doughnut";
            createDoughnutChartItem2.Description = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            createDoughnutChartItem2.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            chartControlCommandGalleryItemGroup2DPie2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem2,
            createDoughnutChartItem2});
            chartControlCommandGalleryItemGroup3DPie2.Caption = "3-D Pie";
            createPie3DChartItem2.Caption = "Pie in 3-D";
            createPie3DChartItem2.Description = "Display the contribution of each value to a total.";
            createPie3DChartItem2.Hint = "Display the contribution of each value to a total.";
            createDoughnut3DChartItem2.Caption = "Doughnut in 3-D";
            createDoughnut3DChartItem2.Description = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            createDoughnut3DChartItem2.Hint = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            chartControlCommandGalleryItemGroup3DPie2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem2,
            createDoughnut3DChartItem2});
            this.commandBarGalleryDropDown31.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie2,
            chartControlCommandGalleryItemGroup3DPie2});
            this.commandBarGalleryDropDown31.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown31.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown31.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown31.Name = "commandBarGalleryDropDown31";
            this.commandBarGalleryDropDown31.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown32
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown32.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown32.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DBar2.Caption = "2-D Bar";
            createRotatedBarChartItem2.Caption = "Bar";
            createRotatedBarChartItem2.Description = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedBarChartItem2.Hint = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedFullStackedBarChartItem2.Caption = "100% Stacked Bar";
            createRotatedFullStackedBarChartItem2.Description = resources.GetString("createRotatedFullStackedBarChartItem2.Description");
            createRotatedFullStackedBarChartItem2.Hint = resources.GetString("createRotatedFullStackedBarChartItem2.Hint");
            createRotatedSideBySideFullStackedBarChartItem2.Caption = "Clustered 100% Stacked Bar";
            createRotatedSideBySideFullStackedBarChartItem2.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideFullStackedBarChartItem2.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem2.Caption = "Clustered Stacked Bar";
            createRotatedSideBySideStackedBarChartItem2.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem2.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedStackedBarChartItem2.Caption = "Stacked Bar";
            createRotatedStackedBarChartItem2.Description = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            createRotatedStackedBarChartItem2.Hint = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            chartControlCommandGalleryItemGroup2DBar2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem2,
            createRotatedFullStackedBarChartItem2,
            createRotatedSideBySideFullStackedBarChartItem2,
            createRotatedSideBySideStackedBarChartItem2,
            createRotatedStackedBarChartItem2});
            this.commandBarGalleryDropDown32.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar2});
            this.commandBarGalleryDropDown32.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown32.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown32.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown32.Name = "commandBarGalleryDropDown32";
            this.commandBarGalleryDropDown32.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown33
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown33.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown33.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DArea2.Caption = "2-D Area";
            createAreaChartItem2.Caption = "Area";
            createAreaChartItem2.Description = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createAreaChartItem2.Hint = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createFullStackedAreaChartItem2.Caption = "100% Stacked Area";
            createFullStackedAreaChartItem2.Description = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedAreaChartItem2.Hint = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedSplineAreaChartItem2.Caption = "100% Stacked Spline Area";
            createFullStackedSplineAreaChartItem2.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createFullStackedSplineAreaChartItem2.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createSplineAreaChartItem2.Caption = "Spline Area";
            createSplineAreaChartItem2.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createSplineAreaChartItem2.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createStackedAreaChartItem2.Caption = "Stacked Area";
            createStackedAreaChartItem2.Description = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedAreaChartItem2.Hint = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedSplineAreaChartItem2.Caption = "Stacked Spline Area";
            createStackedSplineAreaChartItem2.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStackedSplineAreaChartItem2.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStepAreaChartItem2.Caption = "Step Area";
            createStepAreaChartItem2.Description = "Show how much values have changed for different points of the same series.";
            createStepAreaChartItem2.Hint = "Show how much values have changed for different points of the same series.";
            chartControlCommandGalleryItemGroup2DArea2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem2,
            createFullStackedAreaChartItem2,
            createFullStackedSplineAreaChartItem2,
            createSplineAreaChartItem2,
            createStackedAreaChartItem2,
            createStackedSplineAreaChartItem2,
            createStepAreaChartItem2});
            chartControlCommandGalleryItemGroup3DArea2.Caption = "3-D Area";
            createArea3DChartItem2.Caption = "3-D Area";
            createArea3DChartItem2.Description = resources.GetString("createArea3DChartItem2.Description");
            createArea3DChartItem2.Hint = resources.GetString("createArea3DChartItem2.Hint");
            createFullStackedArea3DChartItem2.Caption = "100% Stacked Area in 3-D";
            createFullStackedArea3DChartItem2.Description = resources.GetString("createFullStackedArea3DChartItem2.Description");
            createFullStackedArea3DChartItem2.Hint = resources.GetString("createFullStackedArea3DChartItem2.Hint");
            createFullStackedSplineArea3DChartItem2.Caption = "100% Stacked Spline Area in 3-D";
            createFullStackedSplineArea3DChartItem2.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createFullStackedSplineArea3DChartItem2.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createSplineArea3DChartItem2.Caption = "Spline Area in 3-D";
            createSplineArea3DChartItem2.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createSplineArea3DChartItem2.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createStackedArea3DChartItem2.Caption = "Stacked Area in 3-D";
            createStackedArea3DChartItem2.Description = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedArea3DChartItem2.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedSplineArea3DChartItem2.Caption = "Stacked Spline Area in 3-D";
            createStackedSplineArea3DChartItem2.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStackedSplineArea3DChartItem2.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStepArea3DChartItem2.Caption = "Step Area in 3-D";
            createStepArea3DChartItem2.Description = "Show to what extent values have changed for different points in the same series.";
            createStepArea3DChartItem2.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DArea2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem2,
            createFullStackedArea3DChartItem2,
            createFullStackedSplineArea3DChartItem2,
            createSplineArea3DChartItem2,
            createStackedArea3DChartItem2,
            createStackedSplineArea3DChartItem2,
            createStepArea3DChartItem2});
            this.commandBarGalleryDropDown33.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea2,
            chartControlCommandGalleryItemGroup3DArea2});
            this.commandBarGalleryDropDown33.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown33.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown33.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown33.Name = "commandBarGalleryDropDown33";
            this.commandBarGalleryDropDown33.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown34
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown34.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown34.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroupPoint2.Caption = "Point";
            createPointChartItem2.Caption = "Point";
            createPointChartItem2.Description = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createPointChartItem2.Hint = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createBubbleChartItem2.Caption = "Bubble";
            createBubbleChartItem2.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            createBubbleChartItem2.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            chartControlCommandGalleryItemGroupPoint2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem2,
            createBubbleChartItem2});
            chartControlCommandGalleryItemGroupFunnel2.Caption = "Funnel";
            createFunnelChartItem2.Caption = "Funnel";
            createFunnelChartItem2.Description = resources.GetString("createFunnelChartItem2.Description");
            createFunnelChartItem2.Hint = resources.GetString("createFunnelChartItem2.Hint");
            createFunnel3DChartItem2.Caption = "3-D Funnel";
            createFunnel3DChartItem2.Description = resources.GetString("createFunnel3DChartItem2.Description");
            createFunnel3DChartItem2.Hint = resources.GetString("createFunnel3DChartItem2.Hint");
            chartControlCommandGalleryItemGroupFunnel2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem2,
            createFunnel3DChartItem2});
            chartControlCommandGalleryItemGroupFinancial2.Caption = "Financial";
            createStockChartItem2.Caption = "Stock";
            createStockChartItem2.Description = resources.GetString("createStockChartItem2.Description");
            createStockChartItem2.Hint = resources.GetString("createStockChartItem2.Hint");
            createCandleStickChartItem2.Caption = "Candle Stick";
            createCandleStickChartItem2.Description = resources.GetString("createCandleStickChartItem2.Description");
            createCandleStickChartItem2.Hint = resources.GetString("createCandleStickChartItem2.Hint");
            chartControlCommandGalleryItemGroupFinancial2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem2,
            createCandleStickChartItem2});
            chartControlCommandGalleryItemGroupRadar2.Caption = "Radar";
            createRadarPointChartItem2.Caption = "Radar Point";
            createRadarPointChartItem2.Description = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarPointChartItem2.Hint = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem2.Caption = "Radar Line";
            createRadarLineChartItem2.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem2.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarAreaChartItem2.Caption = "Radar Area";
            createRadarAreaChartItem2.Description = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            createRadarAreaChartItem2.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            chartControlCommandGalleryItemGroupRadar2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem2,
            createRadarLineChartItem2,
            createRadarAreaChartItem2});
            chartControlCommandGalleryItemGroupPolar2.Caption = "Polar";
            createPolarPointChartItem2.Caption = "Polar Point";
            createPolarPointChartItem2.Description = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarPointChartItem2.Hint = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarLineChartItem2.Caption = "Polar Line";
            createPolarLineChartItem2.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarLineChartItem2.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarAreaChartItem2.Caption = "Polar Area";
            createPolarAreaChartItem2.Description = "Display series as filled area on a circular diagram on the basis of angles.";
            createPolarAreaChartItem2.Hint = "Display series as filled area on a circular diagram on the basis of angles.";
            chartControlCommandGalleryItemGroupPolar2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem2,
            createPolarLineChartItem2,
            createPolarAreaChartItem2});
            chartControlCommandGalleryItemGroupRange2.Caption = "Range";
            createRangeBarChartItem2.Caption = "Range Column";
            createRangeBarChartItem2.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createRangeBarChartItem2.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createSideBySideRangeBarChartItem2.Caption = "Clustered Range Column";
            createSideBySideRangeBarChartItem2.Description = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createSideBySideRangeBarChartItem2.Hint = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createRangeAreaChartItem2.Caption = "Range Area";
            createRangeAreaChartItem2.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeAreaChartItem2.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem2.Caption = "Range Area in 3-D";
            createRangeArea3DChartItem2.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem2.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            chartControlCommandGalleryItemGroupRange2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem2,
            createSideBySideRangeBarChartItem2,
            createRangeAreaChartItem2,
            createRangeArea3DChartItem2});
            chartControlCommandGalleryItemGroupGantt2.Caption = "Gantt";
            createGanttChartItem2.Caption = "Gantt";
            createGanttChartItem2.Description = "Track different activities during the time frame.";
            createGanttChartItem2.Hint = "Track different activities during the time frame.";
            createSideBySideGanttChartItem2.Caption = "Clustered Gantt";
            createSideBySideGanttChartItem2.Description = resources.GetString("createSideBySideGanttChartItem2.Description");
            createSideBySideGanttChartItem2.Hint = resources.GetString("createSideBySideGanttChartItem2.Hint");
            chartControlCommandGalleryItemGroupGantt2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem2,
            createSideBySideGanttChartItem2});
            this.commandBarGalleryDropDown34.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint2,
            chartControlCommandGalleryItemGroupFunnel2,
            chartControlCommandGalleryItemGroupFinancial2,
            chartControlCommandGalleryItemGroupRadar2,
            chartControlCommandGalleryItemGroupPolar2,
            chartControlCommandGalleryItemGroupRange2,
            chartControlCommandGalleryItemGroupGantt2});
            this.commandBarGalleryDropDown34.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown34.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown34.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown34.Name = "commandBarGalleryDropDown34";
            this.commandBarGalleryDropDown34.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown35
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown35.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown35.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown35.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown35.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown35.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown35.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges3.Bottom = -3;
            skinPaddingEdges3.Top = -3;
            this.commandBarGalleryDropDown35.Gallery.ItemImagePadding = skinPaddingEdges3;
            skinPaddingEdges4.Bottom = -3;
            skinPaddingEdges4.Top = -3;
            this.commandBarGalleryDropDown35.Gallery.ItemTextPadding = skinPaddingEdges4;
            this.commandBarGalleryDropDown35.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown35.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown35.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown35.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown35.Name = "commandBarGalleryDropDown35";
            this.commandBarGalleryDropDown35.Ribbon = this.ribbonControl1;
            // 
            // commandBarGalleryDropDown22
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown22.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown22.Gallery.ColumnCount = 4;
            createBarChartItem3.Caption = "Clustered Column";
            createBarChartItem3.Description = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createBarChartItem3.Hint = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createFullStackedBarChartItem3.Caption = "100% Stacked Column";
            createFullStackedBarChartItem3.Description = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createFullStackedBarChartItem3.Hint = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createSideBySideFullStackedBarChartItem3.Caption = "Clustered 100% Stacked Column";
            createSideBySideFullStackedBarChartItem3.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideFullStackedBarChartItem3.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideStackedBarChartItem3.Caption = "Clustered Stacked Column";
            createSideBySideStackedBarChartItem3.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createSideBySideStackedBarChartItem3.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createStackedBarChartItem3.Caption = "Stacked Column";
            createStackedBarChartItem3.Description = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            createStackedBarChartItem3.Hint = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            chartControlCommandGalleryItemGroup2DColumn3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem3,
            createFullStackedBarChartItem3,
            createSideBySideFullStackedBarChartItem3,
            createSideBySideStackedBarChartItem3,
            createStackedBarChartItem3});
            createBar3DChartItem3.Caption = "3-D Clustered Column";
            createBar3DChartItem3.Description = "Compare values across categories and display clustered columns in 3-D format.";
            createBar3DChartItem3.Hint = "Compare values across categories and display clustered columns in 3-D format.";
            createFullStackedBar3DChartItem3.Caption = "100% Stacked Column in 3-D";
            createFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createManhattanBarChartItem3.Caption = "3-D Column";
            createManhattanBarChartItem3.Description = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createManhattanBarChartItem3.Hint = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Column in 3-D";
            createSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Column in 3-D";
            createSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createStackedBar3DChartItem3.Caption = "Stacked Column in 3-D";
            createStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            createStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            chartControlCommandGalleryItemGroup3DColumn3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem3,
            createFullStackedBar3DChartItem3,
            createManhattanBarChartItem3,
            createSideBySideFullStackedBar3DChartItem3,
            createSideBySideStackedBar3DChartItem3,
            createStackedBar3DChartItem3});
            createCylinderBar3DChartItem3.Caption = "Clustered Cylinder";
            createCylinderBar3DChartItem3.Description = "Compare values across categories.";
            createCylinderBar3DChartItem3.Hint = "Compare values across categories.";
            createCylinderFullStackedBar3DChartItem3.Caption = "100% Stacked Cylinder";
            createCylinderFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories.";
            createCylinderFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories.";
            createCylinderManhattanBarChartItem3.Caption = "3-D Cylinder";
            createCylinderManhattanBarChartItem3.Description = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderManhattanBarChartItem3.Hint = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Cylinder";
            createCylinderSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Cylinder";
            createCylinderSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderStackedBar3DChartItem3.Caption = "Stacked Cylinder";
            createCylinderStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories.";
            createCylinderStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupCylinderColumn3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem3,
            createCylinderFullStackedBar3DChartItem3,
            createCylinderManhattanBarChartItem3,
            createCylinderSideBySideFullStackedBar3DChartItem3,
            createCylinderSideBySideStackedBar3DChartItem3,
            createCylinderStackedBar3DChartItem3});
            createConeBar3DChartItem3.Caption = "Clustered Cone";
            createConeBar3DChartItem3.Description = "Compare values across categories.";
            createConeBar3DChartItem3.Hint = "Compare values across categories.";
            createConeFullStackedBar3DChartItem3.Caption = "100% Stacked Cone";
            createConeFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories.";
            createConeFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories.";
            createConeManhattanBarChartItem3.Caption = "3-D Cone";
            createConeManhattanBarChartItem3.Description = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeManhattanBarChartItem3.Hint = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Cone";
            createConeSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Cone";
            createConeSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeStackedBar3DChartItem3.Caption = "Stacked Cone";
            createConeStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories.";
            createConeStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupConeColumn3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem3,
            createConeFullStackedBar3DChartItem3,
            createConeManhattanBarChartItem3,
            createConeSideBySideFullStackedBar3DChartItem3,
            createConeSideBySideStackedBar3DChartItem3,
            createConeStackedBar3DChartItem3});
            createPyramidBar3DChartItem3.Caption = "Clustered Pyramid";
            createPyramidBar3DChartItem3.Description = "Compare values across categories.";
            createPyramidBar3DChartItem3.Hint = "Compare values across categories.";
            createPyramidFullStackedBar3DChartItem3.Caption = "100% Stacked Pyramid";
            createPyramidFullStackedBar3DChartItem3.Description = "Compare the percentage each value contributes to a total across categories.";
            createPyramidFullStackedBar3DChartItem3.Hint = "Compare the percentage each value contributes to a total across categories.";
            createPyramidManhattanBarChartItem3.Caption = "3-D Pyramid";
            createPyramidManhattanBarChartItem3.Description = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidManhattanBarChartItem3.Hint = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidSideBySideFullStackedBar3DChartItem3.Caption = "Clustered 100% Stacked Pyramid";
            createPyramidSideBySideFullStackedBar3DChartItem3.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideFullStackedBar3DChartItem3.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem3.Caption = "Clustered Stacked Pyramid";
            createPyramidSideBySideStackedBar3DChartItem3.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem3.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidStackedBar3DChartItem3.Caption = "Stacked Pyramid";
            createPyramidStackedBar3DChartItem3.Description = "Compare the contribution of each value to a total across categories.";
            createPyramidStackedBar3DChartItem3.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupPyramidColumn3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem3,
            createPyramidFullStackedBar3DChartItem3,
            createPyramidManhattanBarChartItem3,
            createPyramidSideBySideFullStackedBar3DChartItem3,
            createPyramidSideBySideStackedBar3DChartItem3,
            createPyramidStackedBar3DChartItem3});
            this.commandBarGalleryDropDown22.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn3,
            chartControlCommandGalleryItemGroup3DColumn3,
            chartControlCommandGalleryItemGroupCylinderColumn3,
            chartControlCommandGalleryItemGroupConeColumn3,
            chartControlCommandGalleryItemGroupPyramidColumn3});
            this.commandBarGalleryDropDown22.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown22.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown22.Manager = null;
            this.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22";
            // 
            // commandBarGalleryDropDown23
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown23.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown23.Gallery.ColumnCount = 3;
            createLineChartItem3.Caption = "Line";
            createLineChartItem3.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createLineChartItem3.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createFullStackedLineChartItem3.Caption = "100% Stacked Line";
            createFullStackedLineChartItem3.Description = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createFullStackedLineChartItem3.Hint = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createScatterLineChartItem3.Caption = "Scatter Line";
            createScatterLineChartItem3.Description = "Represent series points in the same order that they have in the collection.";
            createScatterLineChartItem3.Hint = "Represent series points in the same order that they have in the collection.";
            createSplineChartItem3.Caption = "Spline";
            createSplineChartItem3.Description = "Plot a fitted curve through each data point in a series.";
            createSplineChartItem3.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLineChartItem3.Caption = "Stacked Line";
            createStackedLineChartItem3.Description = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStackedLineChartItem3.Hint = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStepLineChartItem3.Caption = "Step Line";
            createStepLineChartItem3.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLineChartItem3.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup2DLine3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem3,
            createFullStackedLineChartItem3,
            createScatterLineChartItem3,
            createSplineChartItem3,
            createStackedLineChartItem3,
            createStepLineChartItem3});
            createLine3DChartItem3.Caption = "3-D Line";
            createLine3DChartItem3.Description = "Display each row or column of data as a 3-D ribbon on three axes.";
            createLine3DChartItem3.Hint = "Display each row or column of data as a 3-D ribbon on three axes.";
            createFullStackedLine3DChartItem3.Caption = "100% Stacked Line in 3-D";
            createFullStackedLine3DChartItem3.Description = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createFullStackedLine3DChartItem3.Hint = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createSpline3DChartItem3.Caption = "3-D Spline";
            createSpline3DChartItem3.Description = "Plot a fitted curve through each data point in a series.";
            createSpline3DChartItem3.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLine3DChartItem3.Caption = "Stacked Line in 3-D";
            createStackedLine3DChartItem3.Description = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStackedLine3DChartItem3.Hint = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStepLine3DChartItem3.Caption = "Step Line in 3-D";
            createStepLine3DChartItem3.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLine3DChartItem3.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DLine3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem3,
            createFullStackedLine3DChartItem3,
            createSpline3DChartItem3,
            createStackedLine3DChartItem3,
            createStepLine3DChartItem3});
            this.commandBarGalleryDropDown23.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine3,
            chartControlCommandGalleryItemGroup3DLine3});
            this.commandBarGalleryDropDown23.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown23.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown23.Manager = null;
            this.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23";
            // 
            // commandBarGalleryDropDown24
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown24.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown24.Gallery.ColumnCount = 2;
            createPieChartItem3.Caption = "Pie";
            createPieChartItem3.Description = resources.GetString("createPieChartItem3.Description");
            createPieChartItem3.Hint = resources.GetString("createPieChartItem3.Hint");
            createDoughnutChartItem3.Caption = "Doughnut";
            createDoughnutChartItem3.Description = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            createDoughnutChartItem3.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            chartControlCommandGalleryItemGroup2DPie3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem3,
            createDoughnutChartItem3});
            createPie3DChartItem3.Caption = "Pie in 3-D";
            createPie3DChartItem3.Description = "Display the contribution of each value to a total.";
            createPie3DChartItem3.Hint = "Display the contribution of each value to a total.";
            createDoughnut3DChartItem3.Caption = "Doughnut in 3-D";
            createDoughnut3DChartItem3.Description = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            createDoughnut3DChartItem3.Hint = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            chartControlCommandGalleryItemGroup3DPie3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem3,
            createDoughnut3DChartItem3});
            this.commandBarGalleryDropDown24.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie3,
            chartControlCommandGalleryItemGroup3DPie3});
            this.commandBarGalleryDropDown24.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown24.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown24.Manager = null;
            this.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24";
            // 
            // commandBarGalleryDropDown25
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown25.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown25.Gallery.ColumnCount = 3;
            createRotatedBarChartItem3.Caption = "Bar";
            createRotatedBarChartItem3.Description = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedBarChartItem3.Hint = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedFullStackedBarChartItem3.Caption = "100% Stacked Bar";
            createRotatedFullStackedBarChartItem3.Description = resources.GetString("createRotatedFullStackedBarChartItem3.Description");
            createRotatedFullStackedBarChartItem3.Hint = resources.GetString("createRotatedFullStackedBarChartItem3.Hint");
            createRotatedSideBySideFullStackedBarChartItem3.Caption = "Clustered 100% Stacked Bar";
            createRotatedSideBySideFullStackedBarChartItem3.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideFullStackedBarChartItem3.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem3.Caption = "Clustered Stacked Bar";
            createRotatedSideBySideStackedBarChartItem3.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem3.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedStackedBarChartItem3.Caption = "Stacked Bar";
            createRotatedStackedBarChartItem3.Description = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            createRotatedStackedBarChartItem3.Hint = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            chartControlCommandGalleryItemGroup2DBar3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem3,
            createRotatedFullStackedBarChartItem3,
            createRotatedSideBySideFullStackedBarChartItem3,
            createRotatedSideBySideStackedBarChartItem3,
            createRotatedStackedBarChartItem3});
            this.commandBarGalleryDropDown25.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar3});
            this.commandBarGalleryDropDown25.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown25.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown25.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown25.Manager = null;
            this.commandBarGalleryDropDown25.Name = "commandBarGalleryDropDown25";
            // 
            // commandBarGalleryDropDown26
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown26.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown26.Gallery.ColumnCount = 4;
            createAreaChartItem3.Caption = "Area";
            createAreaChartItem3.Description = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createAreaChartItem3.Hint = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createFullStackedAreaChartItem3.Caption = "100% Stacked Area";
            createFullStackedAreaChartItem3.Description = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedAreaChartItem3.Hint = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedSplineAreaChartItem3.Caption = "100% Stacked Spline Area";
            createFullStackedSplineAreaChartItem3.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createFullStackedSplineAreaChartItem3.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createSplineAreaChartItem3.Caption = "Spline Area";
            createSplineAreaChartItem3.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createSplineAreaChartItem3.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createStackedAreaChartItem3.Caption = "Stacked Area";
            createStackedAreaChartItem3.Description = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedAreaChartItem3.Hint = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedSplineAreaChartItem3.Caption = "Stacked Spline Area";
            createStackedSplineAreaChartItem3.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStackedSplineAreaChartItem3.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStepAreaChartItem3.Caption = "Step Area";
            createStepAreaChartItem3.Description = "Show how much values have changed for different points of the same series.";
            createStepAreaChartItem3.Hint = "Show how much values have changed for different points of the same series.";
            chartControlCommandGalleryItemGroup2DArea3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem3,
            createFullStackedAreaChartItem3,
            createFullStackedSplineAreaChartItem3,
            createSplineAreaChartItem3,
            createStackedAreaChartItem3,
            createStackedSplineAreaChartItem3,
            createStepAreaChartItem3});
            createArea3DChartItem3.Caption = "3-D Area";
            createArea3DChartItem3.Description = resources.GetString("createArea3DChartItem3.Description");
            createArea3DChartItem3.Hint = resources.GetString("createArea3DChartItem3.Hint");
            createFullStackedArea3DChartItem3.Caption = "100% Stacked Area in 3-D";
            createFullStackedArea3DChartItem3.Description = resources.GetString("createFullStackedArea3DChartItem3.Description");
            createFullStackedArea3DChartItem3.Hint = resources.GetString("createFullStackedArea3DChartItem3.Hint");
            createFullStackedSplineArea3DChartItem3.Caption = "100% Stacked Spline Area in 3-D";
            createFullStackedSplineArea3DChartItem3.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createFullStackedSplineArea3DChartItem3.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createSplineArea3DChartItem3.Caption = "Spline Area in 3-D";
            createSplineArea3DChartItem3.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createSplineArea3DChartItem3.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createStackedArea3DChartItem3.Caption = "Stacked Area in 3-D";
            createStackedArea3DChartItem3.Description = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedArea3DChartItem3.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedSplineArea3DChartItem3.Caption = "Stacked Spline Area in 3-D";
            createStackedSplineArea3DChartItem3.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStackedSplineArea3DChartItem3.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStepArea3DChartItem3.Caption = "Step Area in 3-D";
            createStepArea3DChartItem3.Description = "Show to what extent values have changed for different points in the same series.";
            createStepArea3DChartItem3.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DArea3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem3,
            createFullStackedArea3DChartItem3,
            createFullStackedSplineArea3DChartItem3,
            createSplineArea3DChartItem3,
            createStackedArea3DChartItem3,
            createStackedSplineArea3DChartItem3,
            createStepArea3DChartItem3});
            this.commandBarGalleryDropDown26.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea3,
            chartControlCommandGalleryItemGroup3DArea3});
            this.commandBarGalleryDropDown26.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown26.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown26.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown26.Manager = null;
            this.commandBarGalleryDropDown26.Name = "commandBarGalleryDropDown26";
            // 
            // commandBarGalleryDropDown27
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown27.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown27.Gallery.ColumnCount = 4;
            createPointChartItem3.Caption = "Point";
            createPointChartItem3.Description = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createPointChartItem3.Hint = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createBubbleChartItem3.Caption = "Bubble";
            createBubbleChartItem3.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            createBubbleChartItem3.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            chartControlCommandGalleryItemGroupPoint3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem3,
            createBubbleChartItem3});
            createFunnelChartItem3.Caption = "Funnel";
            createFunnelChartItem3.Description = resources.GetString("createFunnelChartItem3.Description");
            createFunnelChartItem3.Hint = resources.GetString("createFunnelChartItem3.Hint");
            createFunnel3DChartItem3.Caption = "3-D Funnel";
            createFunnel3DChartItem3.Description = resources.GetString("createFunnel3DChartItem3.Description");
            createFunnel3DChartItem3.Hint = resources.GetString("createFunnel3DChartItem3.Hint");
            chartControlCommandGalleryItemGroupFunnel3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem3,
            createFunnel3DChartItem3});
            createStockChartItem3.Caption = "Stock";
            createStockChartItem3.Description = resources.GetString("createStockChartItem3.Description");
            createStockChartItem3.Hint = resources.GetString("createStockChartItem3.Hint");
            createCandleStickChartItem3.Caption = "Candle Stick";
            createCandleStickChartItem3.Description = resources.GetString("createCandleStickChartItem3.Description");
            createCandleStickChartItem3.Hint = resources.GetString("createCandleStickChartItem3.Hint");
            chartControlCommandGalleryItemGroupFinancial3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem3,
            createCandleStickChartItem3});
            createRadarPointChartItem3.Caption = "Radar Point";
            createRadarPointChartItem3.Description = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarPointChartItem3.Hint = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem3.Caption = "Radar Line";
            createRadarLineChartItem3.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem3.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarAreaChartItem3.Caption = "Radar Area";
            createRadarAreaChartItem3.Description = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            createRadarAreaChartItem3.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            chartControlCommandGalleryItemGroupRadar3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem3,
            createRadarLineChartItem3,
            createRadarAreaChartItem3});
            createPolarPointChartItem3.Caption = "Polar Point";
            createPolarPointChartItem3.Description = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarPointChartItem3.Hint = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarLineChartItem3.Caption = "Polar Line";
            createPolarLineChartItem3.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarLineChartItem3.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarAreaChartItem3.Caption = "Polar Area";
            createPolarAreaChartItem3.Description = "Display series as filled area on a circular diagram on the basis of angles.";
            createPolarAreaChartItem3.Hint = "Display series as filled area on a circular diagram on the basis of angles.";
            chartControlCommandGalleryItemGroupPolar3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem3,
            createPolarLineChartItem3,
            createPolarAreaChartItem3});
            createRangeBarChartItem3.Caption = "Range Column";
            createRangeBarChartItem3.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createRangeBarChartItem3.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createSideBySideRangeBarChartItem3.Caption = "Clustered Range Column";
            createSideBySideRangeBarChartItem3.Description = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createSideBySideRangeBarChartItem3.Hint = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createRangeAreaChartItem3.Caption = "Range Area";
            createRangeAreaChartItem3.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeAreaChartItem3.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem3.Caption = "Range Area in 3-D";
            createRangeArea3DChartItem3.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem3.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            chartControlCommandGalleryItemGroupRange3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem3,
            createSideBySideRangeBarChartItem3,
            createRangeAreaChartItem3,
            createRangeArea3DChartItem3});
            createGanttChartItem3.Caption = "Gantt";
            createGanttChartItem3.Description = "Track different activities during the time frame.";
            createGanttChartItem3.Hint = "Track different activities during the time frame.";
            createSideBySideGanttChartItem3.Caption = "Clustered Gantt";
            createSideBySideGanttChartItem3.Description = resources.GetString("createSideBySideGanttChartItem3.Description");
            createSideBySideGanttChartItem3.Hint = resources.GetString("createSideBySideGanttChartItem3.Hint");
            chartControlCommandGalleryItemGroupGantt3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem3,
            createSideBySideGanttChartItem3});
            this.commandBarGalleryDropDown27.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint3,
            chartControlCommandGalleryItemGroupFunnel3,
            chartControlCommandGalleryItemGroupFinancial3,
            chartControlCommandGalleryItemGroupRadar3,
            chartControlCommandGalleryItemGroupPolar3,
            chartControlCommandGalleryItemGroupRange3,
            chartControlCommandGalleryItemGroupGantt3});
            this.commandBarGalleryDropDown27.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown27.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown27.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown27.Manager = null;
            this.commandBarGalleryDropDown27.Name = "commandBarGalleryDropDown27";
            // 
            // commandBarGalleryDropDown28
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown28.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown28.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown28.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown28.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown28.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown28.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges5.Bottom = -3;
            skinPaddingEdges5.Top = -3;
            this.commandBarGalleryDropDown28.Gallery.ItemImagePadding = skinPaddingEdges5;
            skinPaddingEdges6.Bottom = -3;
            skinPaddingEdges6.Top = -3;
            this.commandBarGalleryDropDown28.Gallery.ItemTextPadding = skinPaddingEdges6;
            this.commandBarGalleryDropDown28.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown28.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown28.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown28.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown28.Manager = null;
            this.commandBarGalleryDropDown28.Name = "commandBarGalleryDropDown28";
            // 
            // commandBarGalleryDropDown15
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown15.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown15.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DColumn4.Caption = "2-D Column";
            createBarChartItem4.Caption = "Clustered Column";
            createBarChartItem4.Description = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createBarChartItem4.Hint = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createFullStackedBarChartItem4.Caption = "100% Stacked Column";
            createFullStackedBarChartItem4.Description = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createFullStackedBarChartItem4.Hint = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createSideBySideFullStackedBarChartItem4.Caption = "Clustered 100% Stacked Column";
            createSideBySideFullStackedBarChartItem4.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideFullStackedBarChartItem4.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideStackedBarChartItem4.Caption = "Clustered Stacked Column";
            createSideBySideStackedBarChartItem4.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createSideBySideStackedBarChartItem4.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createStackedBarChartItem4.Caption = "Stacked Column";
            createStackedBarChartItem4.Description = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            createStackedBarChartItem4.Hint = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            chartControlCommandGalleryItemGroup2DColumn4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem4,
            createFullStackedBarChartItem4,
            createSideBySideFullStackedBarChartItem4,
            createSideBySideStackedBarChartItem4,
            createStackedBarChartItem4});
            chartControlCommandGalleryItemGroup3DColumn4.Caption = "3-D Column";
            createBar3DChartItem4.Caption = "3-D Clustered Column";
            createBar3DChartItem4.Description = "Compare values across categories and display clustered columns in 3-D format.";
            createBar3DChartItem4.Hint = "Compare values across categories and display clustered columns in 3-D format.";
            createFullStackedBar3DChartItem4.Caption = "100% Stacked Column in 3-D";
            createFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createManhattanBarChartItem4.Caption = "3-D Column";
            createManhattanBarChartItem4.Description = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createManhattanBarChartItem4.Hint = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Column in 3-D";
            createSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Column in 3-D";
            createSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createStackedBar3DChartItem4.Caption = "Stacked Column in 3-D";
            createStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            createStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            chartControlCommandGalleryItemGroup3DColumn4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem4,
            createFullStackedBar3DChartItem4,
            createManhattanBarChartItem4,
            createSideBySideFullStackedBar3DChartItem4,
            createSideBySideStackedBar3DChartItem4,
            createStackedBar3DChartItem4});
            chartControlCommandGalleryItemGroupCylinderColumn4.Caption = "Cylinder";
            createCylinderBar3DChartItem4.Caption = "Clustered Cylinder";
            createCylinderBar3DChartItem4.Description = "Compare values across categories.";
            createCylinderBar3DChartItem4.Hint = "Compare values across categories.";
            createCylinderFullStackedBar3DChartItem4.Caption = "100% Stacked Cylinder";
            createCylinderFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories.";
            createCylinderFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories.";
            createCylinderManhattanBarChartItem4.Caption = "3-D Cylinder";
            createCylinderManhattanBarChartItem4.Description = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderManhattanBarChartItem4.Hint = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Cylinder";
            createCylinderSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Cylinder";
            createCylinderSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderStackedBar3DChartItem4.Caption = "Stacked Cylinder";
            createCylinderStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories.";
            createCylinderStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupCylinderColumn4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem4,
            createCylinderFullStackedBar3DChartItem4,
            createCylinderManhattanBarChartItem4,
            createCylinderSideBySideFullStackedBar3DChartItem4,
            createCylinderSideBySideStackedBar3DChartItem4,
            createCylinderStackedBar3DChartItem4});
            chartControlCommandGalleryItemGroupConeColumn4.Caption = "Cone";
            createConeBar3DChartItem4.Caption = "Clustered Cone";
            createConeBar3DChartItem4.Description = "Compare values across categories.";
            createConeBar3DChartItem4.Hint = "Compare values across categories.";
            createConeFullStackedBar3DChartItem4.Caption = "100% Stacked Cone";
            createConeFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories.";
            createConeFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories.";
            createConeManhattanBarChartItem4.Caption = "3-D Cone";
            createConeManhattanBarChartItem4.Description = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeManhattanBarChartItem4.Hint = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Cone";
            createConeSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Cone";
            createConeSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeStackedBar3DChartItem4.Caption = "Stacked Cone";
            createConeStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories.";
            createConeStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupConeColumn4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem4,
            createConeFullStackedBar3DChartItem4,
            createConeManhattanBarChartItem4,
            createConeSideBySideFullStackedBar3DChartItem4,
            createConeSideBySideStackedBar3DChartItem4,
            createConeStackedBar3DChartItem4});
            chartControlCommandGalleryItemGroupPyramidColumn4.Caption = "Pyramid";
            createPyramidBar3DChartItem4.Caption = "Clustered Pyramid";
            createPyramidBar3DChartItem4.Description = "Compare values across categories.";
            createPyramidBar3DChartItem4.Hint = "Compare values across categories.";
            createPyramidFullStackedBar3DChartItem4.Caption = "100% Stacked Pyramid";
            createPyramidFullStackedBar3DChartItem4.Description = "Compare the percentage each value contributes to a total across categories.";
            createPyramidFullStackedBar3DChartItem4.Hint = "Compare the percentage each value contributes to a total across categories.";
            createPyramidManhattanBarChartItem4.Caption = "3-D Pyramid";
            createPyramidManhattanBarChartItem4.Description = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidManhattanBarChartItem4.Hint = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidSideBySideFullStackedBar3DChartItem4.Caption = "Clustered 100% Stacked Pyramid";
            createPyramidSideBySideFullStackedBar3DChartItem4.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideFullStackedBar3DChartItem4.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem4.Caption = "Clustered Stacked Pyramid";
            createPyramidSideBySideStackedBar3DChartItem4.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem4.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidStackedBar3DChartItem4.Caption = "Stacked Pyramid";
            createPyramidStackedBar3DChartItem4.Description = "Compare the contribution of each value to a total across categories.";
            createPyramidStackedBar3DChartItem4.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupPyramidColumn4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem4,
            createPyramidFullStackedBar3DChartItem4,
            createPyramidManhattanBarChartItem4,
            createPyramidSideBySideFullStackedBar3DChartItem4,
            createPyramidSideBySideStackedBar3DChartItem4,
            createPyramidStackedBar3DChartItem4});
            this.commandBarGalleryDropDown15.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn4,
            chartControlCommandGalleryItemGroup3DColumn4,
            chartControlCommandGalleryItemGroupCylinderColumn4,
            chartControlCommandGalleryItemGroupConeColumn4,
            chartControlCommandGalleryItemGroupPyramidColumn4});
            this.commandBarGalleryDropDown15.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown15.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown15.Manager = null;
            this.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15";
            // 
            // commandBarGalleryDropDown16
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown16.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown16.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DLine4.Caption = "2-D Line";
            createLineChartItem4.Caption = "Line";
            createLineChartItem4.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createLineChartItem4.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createFullStackedLineChartItem4.Caption = "100% Stacked Line";
            createFullStackedLineChartItem4.Description = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createFullStackedLineChartItem4.Hint = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createScatterLineChartItem4.Caption = "Scatter Line";
            createScatterLineChartItem4.Description = "Represent series points in the same order that they have in the collection.";
            createScatterLineChartItem4.Hint = "Represent series points in the same order that they have in the collection.";
            createSplineChartItem4.Caption = "Spline";
            createSplineChartItem4.Description = "Plot a fitted curve through each data point in a series.";
            createSplineChartItem4.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLineChartItem4.Caption = "Stacked Line";
            createStackedLineChartItem4.Description = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStackedLineChartItem4.Hint = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStepLineChartItem4.Caption = "Step Line";
            createStepLineChartItem4.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLineChartItem4.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup2DLine4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem4,
            createFullStackedLineChartItem4,
            createScatterLineChartItem4,
            createSplineChartItem4,
            createStackedLineChartItem4,
            createStepLineChartItem4});
            chartControlCommandGalleryItemGroup3DLine4.Caption = "3-D Line";
            createLine3DChartItem4.Caption = "3-D Line";
            createLine3DChartItem4.Description = "Display each row or column of data as a 3-D ribbon on three axes.";
            createLine3DChartItem4.Hint = "Display each row or column of data as a 3-D ribbon on three axes.";
            createFullStackedLine3DChartItem4.Caption = "100% Stacked Line in 3-D";
            createFullStackedLine3DChartItem4.Description = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createFullStackedLine3DChartItem4.Hint = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createSpline3DChartItem4.Caption = "3-D Spline";
            createSpline3DChartItem4.Description = "Plot a fitted curve through each data point in a series.";
            createSpline3DChartItem4.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLine3DChartItem4.Caption = "Stacked Line in 3-D";
            createStackedLine3DChartItem4.Description = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStackedLine3DChartItem4.Hint = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStepLine3DChartItem4.Caption = "Step Line in 3-D";
            createStepLine3DChartItem4.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLine3DChartItem4.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DLine4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem4,
            createFullStackedLine3DChartItem4,
            createSpline3DChartItem4,
            createStackedLine3DChartItem4,
            createStepLine3DChartItem4});
            this.commandBarGalleryDropDown16.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine4,
            chartControlCommandGalleryItemGroup3DLine4});
            this.commandBarGalleryDropDown16.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown16.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown16.Manager = null;
            this.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16";
            // 
            // commandBarGalleryDropDown17
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown17.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown17.Gallery.ColumnCount = 2;
            chartControlCommandGalleryItemGroup2DPie4.Caption = "2-D Pie";
            createPieChartItem4.Caption = "Pie";
            createPieChartItem4.Description = resources.GetString("createPieChartItem4.Description");
            createPieChartItem4.Hint = resources.GetString("createPieChartItem4.Hint");
            createDoughnutChartItem4.Caption = "Doughnut";
            createDoughnutChartItem4.Description = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            createDoughnutChartItem4.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            chartControlCommandGalleryItemGroup2DPie4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem4,
            createDoughnutChartItem4});
            chartControlCommandGalleryItemGroup3DPie4.Caption = "3-D Pie";
            createPie3DChartItem4.Caption = "Pie in 3-D";
            createPie3DChartItem4.Description = "Display the contribution of each value to a total.";
            createPie3DChartItem4.Hint = "Display the contribution of each value to a total.";
            createDoughnut3DChartItem4.Caption = "Doughnut in 3-D";
            createDoughnut3DChartItem4.Description = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            createDoughnut3DChartItem4.Hint = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            chartControlCommandGalleryItemGroup3DPie4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem4,
            createDoughnut3DChartItem4});
            this.commandBarGalleryDropDown17.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie4,
            chartControlCommandGalleryItemGroup3DPie4});
            this.commandBarGalleryDropDown17.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown17.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown17.Manager = null;
            this.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17";
            // 
            // commandBarGalleryDropDown18
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown18.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown18.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DBar4.Caption = "2-D Bar";
            createRotatedBarChartItem4.Caption = "Bar";
            createRotatedBarChartItem4.Description = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedBarChartItem4.Hint = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedFullStackedBarChartItem4.Caption = "100% Stacked Bar";
            createRotatedFullStackedBarChartItem4.Description = resources.GetString("createRotatedFullStackedBarChartItem4.Description");
            createRotatedFullStackedBarChartItem4.Hint = resources.GetString("createRotatedFullStackedBarChartItem4.Hint");
            createRotatedSideBySideFullStackedBarChartItem4.Caption = "Clustered 100% Stacked Bar";
            createRotatedSideBySideFullStackedBarChartItem4.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideFullStackedBarChartItem4.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem4.Caption = "Clustered Stacked Bar";
            createRotatedSideBySideStackedBarChartItem4.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem4.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedStackedBarChartItem4.Caption = "Stacked Bar";
            createRotatedStackedBarChartItem4.Description = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            createRotatedStackedBarChartItem4.Hint = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            chartControlCommandGalleryItemGroup2DBar4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem4,
            createRotatedFullStackedBarChartItem4,
            createRotatedSideBySideFullStackedBarChartItem4,
            createRotatedSideBySideStackedBarChartItem4,
            createRotatedStackedBarChartItem4});
            this.commandBarGalleryDropDown18.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar4});
            this.commandBarGalleryDropDown18.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown18.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown18.Manager = null;
            this.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18";
            // 
            // commandBarGalleryDropDown19
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown19.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown19.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DArea4.Caption = "2-D Area";
            createAreaChartItem4.Caption = "Area";
            createAreaChartItem4.Description = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createAreaChartItem4.Hint = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createFullStackedAreaChartItem4.Caption = "100% Stacked Area";
            createFullStackedAreaChartItem4.Description = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedAreaChartItem4.Hint = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedSplineAreaChartItem4.Caption = "100% Stacked Spline Area";
            createFullStackedSplineAreaChartItem4.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createFullStackedSplineAreaChartItem4.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createSplineAreaChartItem4.Caption = "Spline Area";
            createSplineAreaChartItem4.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createSplineAreaChartItem4.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createStackedAreaChartItem4.Caption = "Stacked Area";
            createStackedAreaChartItem4.Description = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedAreaChartItem4.Hint = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedSplineAreaChartItem4.Caption = "Stacked Spline Area";
            createStackedSplineAreaChartItem4.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStackedSplineAreaChartItem4.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStepAreaChartItem4.Caption = "Step Area";
            createStepAreaChartItem4.Description = "Show how much values have changed for different points of the same series.";
            createStepAreaChartItem4.Hint = "Show how much values have changed for different points of the same series.";
            chartControlCommandGalleryItemGroup2DArea4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem4,
            createFullStackedAreaChartItem4,
            createFullStackedSplineAreaChartItem4,
            createSplineAreaChartItem4,
            createStackedAreaChartItem4,
            createStackedSplineAreaChartItem4,
            createStepAreaChartItem4});
            chartControlCommandGalleryItemGroup3DArea4.Caption = "3-D Area";
            createArea3DChartItem4.Caption = "3-D Area";
            createArea3DChartItem4.Description = resources.GetString("createArea3DChartItem4.Description");
            createArea3DChartItem4.Hint = resources.GetString("createArea3DChartItem4.Hint");
            createFullStackedArea3DChartItem4.Caption = "100% Stacked Area in 3-D";
            createFullStackedArea3DChartItem4.Description = resources.GetString("createFullStackedArea3DChartItem4.Description");
            createFullStackedArea3DChartItem4.Hint = resources.GetString("createFullStackedArea3DChartItem4.Hint");
            createFullStackedSplineArea3DChartItem4.Caption = "100% Stacked Spline Area in 3-D";
            createFullStackedSplineArea3DChartItem4.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createFullStackedSplineArea3DChartItem4.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createSplineArea3DChartItem4.Caption = "Spline Area in 3-D";
            createSplineArea3DChartItem4.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createSplineArea3DChartItem4.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createStackedArea3DChartItem4.Caption = "Stacked Area in 3-D";
            createStackedArea3DChartItem4.Description = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedArea3DChartItem4.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedSplineArea3DChartItem4.Caption = "Stacked Spline Area in 3-D";
            createStackedSplineArea3DChartItem4.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStackedSplineArea3DChartItem4.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStepArea3DChartItem4.Caption = "Step Area in 3-D";
            createStepArea3DChartItem4.Description = "Show to what extent values have changed for different points in the same series.";
            createStepArea3DChartItem4.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DArea4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem4,
            createFullStackedArea3DChartItem4,
            createFullStackedSplineArea3DChartItem4,
            createSplineArea3DChartItem4,
            createStackedArea3DChartItem4,
            createStackedSplineArea3DChartItem4,
            createStepArea3DChartItem4});
            this.commandBarGalleryDropDown19.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea4,
            chartControlCommandGalleryItemGroup3DArea4});
            this.commandBarGalleryDropDown19.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown19.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown19.Manager = null;
            this.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19";
            // 
            // commandBarGalleryDropDown20
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown20.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown20.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroupPoint4.Caption = "Point";
            createPointChartItem4.Caption = "Point";
            createPointChartItem4.Description = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createPointChartItem4.Hint = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createBubbleChartItem4.Caption = "Bubble";
            createBubbleChartItem4.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            createBubbleChartItem4.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            chartControlCommandGalleryItemGroupPoint4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem4,
            createBubbleChartItem4});
            chartControlCommandGalleryItemGroupFunnel4.Caption = "Funnel";
            createFunnelChartItem4.Caption = "Funnel";
            createFunnelChartItem4.Description = resources.GetString("createFunnelChartItem4.Description");
            createFunnelChartItem4.Hint = resources.GetString("createFunnelChartItem4.Hint");
            createFunnel3DChartItem4.Caption = "3-D Funnel";
            createFunnel3DChartItem4.Description = resources.GetString("createFunnel3DChartItem4.Description");
            createFunnel3DChartItem4.Hint = resources.GetString("createFunnel3DChartItem4.Hint");
            chartControlCommandGalleryItemGroupFunnel4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem4,
            createFunnel3DChartItem4});
            chartControlCommandGalleryItemGroupFinancial4.Caption = "Financial";
            createStockChartItem4.Caption = "Stock";
            createStockChartItem4.Description = resources.GetString("createStockChartItem4.Description");
            createStockChartItem4.Hint = resources.GetString("createStockChartItem4.Hint");
            createCandleStickChartItem4.Caption = "Candle Stick";
            createCandleStickChartItem4.Description = resources.GetString("createCandleStickChartItem4.Description");
            createCandleStickChartItem4.Hint = resources.GetString("createCandleStickChartItem4.Hint");
            chartControlCommandGalleryItemGroupFinancial4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem4,
            createCandleStickChartItem4});
            chartControlCommandGalleryItemGroupRadar4.Caption = "Radar";
            createRadarPointChartItem4.Caption = "Radar Point";
            createRadarPointChartItem4.Description = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarPointChartItem4.Hint = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem4.Caption = "Radar Line";
            createRadarLineChartItem4.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem4.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarAreaChartItem4.Caption = "Radar Area";
            createRadarAreaChartItem4.Description = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            createRadarAreaChartItem4.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            chartControlCommandGalleryItemGroupRadar4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem4,
            createRadarLineChartItem4,
            createRadarAreaChartItem4});
            chartControlCommandGalleryItemGroupPolar4.Caption = "Polar";
            createPolarPointChartItem4.Caption = "Polar Point";
            createPolarPointChartItem4.Description = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarPointChartItem4.Hint = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarLineChartItem4.Caption = "Polar Line";
            createPolarLineChartItem4.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarLineChartItem4.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarAreaChartItem4.Caption = "Polar Area";
            createPolarAreaChartItem4.Description = "Display series as filled area on a circular diagram on the basis of angles.";
            createPolarAreaChartItem4.Hint = "Display series as filled area on a circular diagram on the basis of angles.";
            chartControlCommandGalleryItemGroupPolar4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem4,
            createPolarLineChartItem4,
            createPolarAreaChartItem4});
            chartControlCommandGalleryItemGroupRange4.Caption = "Range";
            createRangeBarChartItem4.Caption = "Range Column";
            createRangeBarChartItem4.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createRangeBarChartItem4.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createSideBySideRangeBarChartItem4.Caption = "Clustered Range Column";
            createSideBySideRangeBarChartItem4.Description = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createSideBySideRangeBarChartItem4.Hint = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createRangeAreaChartItem4.Caption = "Range Area";
            createRangeAreaChartItem4.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeAreaChartItem4.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem4.Caption = "Range Area in 3-D";
            createRangeArea3DChartItem4.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem4.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            chartControlCommandGalleryItemGroupRange4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem4,
            createSideBySideRangeBarChartItem4,
            createRangeAreaChartItem4,
            createRangeArea3DChartItem4});
            chartControlCommandGalleryItemGroupGantt4.Caption = "Gantt";
            createGanttChartItem4.Caption = "Gantt";
            createGanttChartItem4.Description = "Track different activities during the time frame.";
            createGanttChartItem4.Hint = "Track different activities during the time frame.";
            createSideBySideGanttChartItem4.Caption = "Clustered Gantt";
            createSideBySideGanttChartItem4.Description = resources.GetString("createSideBySideGanttChartItem4.Description");
            createSideBySideGanttChartItem4.Hint = resources.GetString("createSideBySideGanttChartItem4.Hint");
            chartControlCommandGalleryItemGroupGantt4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem4,
            createSideBySideGanttChartItem4});
            this.commandBarGalleryDropDown20.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint4,
            chartControlCommandGalleryItemGroupFunnel4,
            chartControlCommandGalleryItemGroupFinancial4,
            chartControlCommandGalleryItemGroupRadar4,
            chartControlCommandGalleryItemGroupPolar4,
            chartControlCommandGalleryItemGroupRange4,
            chartControlCommandGalleryItemGroupGantt4});
            this.commandBarGalleryDropDown20.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown20.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown20.Manager = null;
            this.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20";
            // 
            // commandBarGalleryDropDown21
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown21.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown21.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown21.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown21.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges7.Bottom = -3;
            skinPaddingEdges7.Top = -3;
            this.commandBarGalleryDropDown21.Gallery.ItemImagePadding = skinPaddingEdges7;
            skinPaddingEdges8.Bottom = -3;
            skinPaddingEdges8.Top = -3;
            this.commandBarGalleryDropDown21.Gallery.ItemTextPadding = skinPaddingEdges8;
            this.commandBarGalleryDropDown21.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown21.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown21.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown21.Manager = null;
            this.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21";
            // 
            // commandBarGalleryDropDown8
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown8.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown8.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DColumn5.Caption = "2-D Column";
            createBarChartItem5.Caption = "Clustered Column";
            createBarChartItem5.Description = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createBarChartItem5.Hint = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.\r\n    ";
            createFullStackedBarChartItem5.Caption = "100% Stacked Column";
            createFullStackedBarChartItem5.Description = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createFullStackedBarChartItem5.Hint = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.\r\n    ";
            createSideBySideFullStackedBarChartItem5.Caption = "Clustered 100% Stacked Column";
            createSideBySideFullStackedBarChartItem5.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideFullStackedBarChartItem5.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideStackedBarChartItem5.Caption = "Clustered Stacked Column";
            createSideBySideStackedBarChartItem5.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createSideBySideStackedBarChartItem5.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createStackedBarChartItem5.Caption = "Stacked Column";
            createStackedBarChartItem5.Description = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            createStackedBarChartItem5.Hint = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".\r\n    ";
            chartControlCommandGalleryItemGroup2DColumn5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem5,
            createFullStackedBarChartItem5,
            createSideBySideFullStackedBarChartItem5,
            createSideBySideStackedBarChartItem5,
            createStackedBarChartItem5});
            chartControlCommandGalleryItemGroup3DColumn5.Caption = "3-D Column";
            createBar3DChartItem5.Caption = "3-D Clustered Column";
            createBar3DChartItem5.Description = "Compare values across categories and display clustered columns in 3-D format.";
            createBar3DChartItem5.Hint = "Compare values across categories and display clustered columns in 3-D format.";
            createFullStackedBar3DChartItem5.Caption = "100% Stacked Column in 3-D";
            createFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createManhattanBarChartItem5.Caption = "3-D Column";
            createManhattanBarChartItem5.Description = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createManhattanBarChartItem5.Hint = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.\r\n    ";
            createSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Column in 3-D";
            createSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Column in 3-D";
            createSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createStackedBar3DChartItem5.Caption = "Stacked Column in 3-D";
            createStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            createStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            chartControlCommandGalleryItemGroup3DColumn5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem5,
            createFullStackedBar3DChartItem5,
            createManhattanBarChartItem5,
            createSideBySideFullStackedBar3DChartItem5,
            createSideBySideStackedBar3DChartItem5,
            createStackedBar3DChartItem5});
            chartControlCommandGalleryItemGroupCylinderColumn5.Caption = "Cylinder";
            createCylinderBar3DChartItem5.Caption = "Clustered Cylinder";
            createCylinderBar3DChartItem5.Description = "Compare values across categories.";
            createCylinderBar3DChartItem5.Hint = "Compare values across categories.";
            createCylinderFullStackedBar3DChartItem5.Caption = "100% Stacked Cylinder";
            createCylinderFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories.";
            createCylinderFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories.";
            createCylinderManhattanBarChartItem5.Caption = "3-D Cylinder";
            createCylinderManhattanBarChartItem5.Description = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderManhattanBarChartItem5.Hint = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Cylinder";
            createCylinderSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Cylinder";
            createCylinderSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderStackedBar3DChartItem5.Caption = "Stacked Cylinder";
            createCylinderStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories.";
            createCylinderStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupCylinderColumn5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem5,
            createCylinderFullStackedBar3DChartItem5,
            createCylinderManhattanBarChartItem5,
            createCylinderSideBySideFullStackedBar3DChartItem5,
            createCylinderSideBySideStackedBar3DChartItem5,
            createCylinderStackedBar3DChartItem5});
            chartControlCommandGalleryItemGroupConeColumn5.Caption = "Cone";
            createConeBar3DChartItem5.Caption = "Clustered Cone";
            createConeBar3DChartItem5.Description = "Compare values across categories.";
            createConeBar3DChartItem5.Hint = "Compare values across categories.";
            createConeFullStackedBar3DChartItem5.Caption = "100% Stacked Cone";
            createConeFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories.";
            createConeFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories.";
            createConeManhattanBarChartItem5.Caption = "3-D Cone";
            createConeManhattanBarChartItem5.Description = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeManhattanBarChartItem5.Hint = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Cone";
            createConeSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Cone";
            createConeSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeStackedBar3DChartItem5.Caption = "Stacked Cone";
            createConeStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories.";
            createConeStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupConeColumn5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem5,
            createConeFullStackedBar3DChartItem5,
            createConeManhattanBarChartItem5,
            createConeSideBySideFullStackedBar3DChartItem5,
            createConeSideBySideStackedBar3DChartItem5,
            createConeStackedBar3DChartItem5});
            chartControlCommandGalleryItemGroupPyramidColumn5.Caption = "Pyramid";
            createPyramidBar3DChartItem5.Caption = "Clustered Pyramid";
            createPyramidBar3DChartItem5.Description = "Compare values across categories.";
            createPyramidBar3DChartItem5.Hint = "Compare values across categories.";
            createPyramidFullStackedBar3DChartItem5.Caption = "100% Stacked Pyramid";
            createPyramidFullStackedBar3DChartItem5.Description = "Compare the percentage each value contributes to a total across categories.";
            createPyramidFullStackedBar3DChartItem5.Hint = "Compare the percentage each value contributes to a total across categories.";
            createPyramidManhattanBarChartItem5.Caption = "3-D Pyramid";
            createPyramidManhattanBarChartItem5.Description = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidManhattanBarChartItem5.Hint = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidSideBySideFullStackedBar3DChartItem5.Caption = "Clustered 100% Stacked Pyramid";
            createPyramidSideBySideFullStackedBar3DChartItem5.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideFullStackedBar3DChartItem5.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem5.Caption = "Clustered Stacked Pyramid";
            createPyramidSideBySideStackedBar3DChartItem5.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem5.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidStackedBar3DChartItem5.Caption = "Stacked Pyramid";
            createPyramidStackedBar3DChartItem5.Description = "Compare the contribution of each value to a total across categories.";
            createPyramidStackedBar3DChartItem5.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupPyramidColumn5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem5,
            createPyramidFullStackedBar3DChartItem5,
            createPyramidManhattanBarChartItem5,
            createPyramidSideBySideFullStackedBar3DChartItem5,
            createPyramidSideBySideStackedBar3DChartItem5,
            createPyramidStackedBar3DChartItem5});
            this.commandBarGalleryDropDown8.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn5,
            chartControlCommandGalleryItemGroup3DColumn5,
            chartControlCommandGalleryItemGroupCylinderColumn5,
            chartControlCommandGalleryItemGroupConeColumn5,
            chartControlCommandGalleryItemGroupPyramidColumn5});
            this.commandBarGalleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown8.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown8.Manager = null;
            this.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8";
            // 
            // commandBarGalleryDropDown9
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown9.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown9.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DLine5.Caption = "2-D Line";
            createLineChartItem5.Caption = "Line";
            createLineChartItem5.Description = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createLineChartItem5.Hint = "Display trend overtime (dates, years) or ordered categories. Useful when there ar" +
    "e many data points and the order is important.";
            createFullStackedLineChartItem5.Caption = "100% Stacked Line";
            createFullStackedLineChartItem5.Description = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createFullStackedLineChartItem5.Hint = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.";
            createScatterLineChartItem5.Caption = "Scatter Line";
            createScatterLineChartItem5.Description = "Represent series points in the same order that they have in the collection.";
            createScatterLineChartItem5.Hint = "Represent series points in the same order that they have in the collection.";
            createSplineChartItem5.Caption = "Spline";
            createSplineChartItem5.Description = "Plot a fitted curve through each data point in a series.";
            createSplineChartItem5.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLineChartItem5.Caption = "Stacked Line";
            createStackedLineChartItem5.Description = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStackedLineChartItem5.Hint = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.";
            createStepLineChartItem5.Caption = "Step Line";
            createStepLineChartItem5.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLineChartItem5.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup2DLine5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem5,
            createFullStackedLineChartItem5,
            createScatterLineChartItem5,
            createSplineChartItem5,
            createStackedLineChartItem5,
            createStepLineChartItem5});
            chartControlCommandGalleryItemGroup3DLine5.Caption = "3-D Line";
            createLine3DChartItem5.Caption = "3-D Line";
            createLine3DChartItem5.Description = "Display each row or column of data as a 3-D ribbon on three axes.";
            createLine3DChartItem5.Hint = "Display each row or column of data as a 3-D ribbon on three axes.";
            createFullStackedLine3DChartItem5.Caption = "100% Stacked Line in 3-D";
            createFullStackedLine3DChartItem5.Description = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createFullStackedLine3DChartItem5.Hint = "Display all series stacked and is useful when it is necessary to compare how much" +
    " each series adds to the total aggregate value for specific arguments (as percen" +
    "ts).";
            createSpline3DChartItem5.Caption = "3-D Spline";
            createSpline3DChartItem5.Description = "Plot a fitted curve through each data point in a series.";
            createSpline3DChartItem5.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLine3DChartItem5.Caption = "Stacked Line in 3-D";
            createStackedLine3DChartItem5.Description = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStackedLine3DChartItem5.Hint = "Display all points from different series in a stacked manner and is useful when i" +
    "t is necessary to compare how much each series adds to the total aggregate value" +
    " for specific arguments.";
            createStepLine3DChartItem5.Caption = "Step Line in 3-D";
            createStepLine3DChartItem5.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLine3DChartItem5.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DLine5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem5,
            createFullStackedLine3DChartItem5,
            createSpline3DChartItem5,
            createStackedLine3DChartItem5,
            createStepLine3DChartItem5});
            this.commandBarGalleryDropDown9.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine5,
            chartControlCommandGalleryItemGroup3DLine5});
            this.commandBarGalleryDropDown9.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown9.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown9.Manager = null;
            this.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9";
            // 
            // commandBarGalleryDropDown10
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown10.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown10.Gallery.ColumnCount = 2;
            chartControlCommandGalleryItemGroup2DPie5.Caption = "2-D Pie";
            createPieChartItem5.Caption = "Pie";
            createPieChartItem5.Description = resources.GetString("createPieChartItem5.Description");
            createPieChartItem5.Hint = resources.GetString("createPieChartItem5.Hint");
            createDoughnutChartItem5.Caption = "Doughnut";
            createDoughnutChartItem5.Description = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            createDoughnutChartItem5.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            chartControlCommandGalleryItemGroup2DPie5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem5,
            createDoughnutChartItem5});
            chartControlCommandGalleryItemGroup3DPie5.Caption = "3-D Pie";
            createPie3DChartItem5.Caption = "Pie in 3-D";
            createPie3DChartItem5.Description = "Display the contribution of each value to a total.";
            createPie3DChartItem5.Hint = "Display the contribution of each value to a total.";
            createDoughnut3DChartItem5.Caption = "Doughnut in 3-D";
            createDoughnut3DChartItem5.Description = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            createDoughnut3DChartItem5.Hint = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            chartControlCommandGalleryItemGroup3DPie5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem5,
            createDoughnut3DChartItem5});
            this.commandBarGalleryDropDown10.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie5,
            chartControlCommandGalleryItemGroup3DPie5});
            this.commandBarGalleryDropDown10.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown10.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown10.Manager = null;
            this.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10";
            // 
            // commandBarGalleryDropDown11
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown11.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown11.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DBar5.Caption = "2-D Bar";
            createRotatedBarChartItem5.Caption = "Bar";
            createRotatedBarChartItem5.Description = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedBarChartItem5.Hint = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.\r\n    ";
            createRotatedFullStackedBarChartItem5.Caption = "100% Stacked Bar";
            createRotatedFullStackedBarChartItem5.Description = resources.GetString("createRotatedFullStackedBarChartItem5.Description");
            createRotatedFullStackedBarChartItem5.Hint = resources.GetString("createRotatedFullStackedBarChartItem5.Hint");
            createRotatedSideBySideFullStackedBarChartItem5.Caption = "Clustered 100% Stacked Bar";
            createRotatedSideBySideFullStackedBarChartItem5.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideFullStackedBarChartItem5.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem5.Caption = "Clustered Stacked Bar";
            createRotatedSideBySideStackedBarChartItem5.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem5.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedStackedBarChartItem5.Caption = "Stacked Bar";
            createRotatedStackedBarChartItem5.Description = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            createRotatedStackedBarChartItem5.Hint = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            chartControlCommandGalleryItemGroup2DBar5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem5,
            createRotatedFullStackedBarChartItem5,
            createRotatedSideBySideFullStackedBarChartItem5,
            createRotatedSideBySideStackedBarChartItem5,
            createRotatedStackedBarChartItem5});
            this.commandBarGalleryDropDown11.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar5});
            this.commandBarGalleryDropDown11.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown11.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown11.Manager = null;
            this.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11";
            // 
            // commandBarGalleryDropDown12
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown12.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown12.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DArea5.Caption = "2-D Area";
            createAreaChartItem5.Caption = "Area";
            createAreaChartItem5.Description = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createAreaChartItem5.Hint = "Insert an area chart.\r\n\r\nArea charts emphasize differences between several sets o" +
    "f data over a period of time.\r\n    ";
            createFullStackedAreaChartItem5.Caption = "100% Stacked Area";
            createFullStackedAreaChartItem5.Description = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedAreaChartItem5.Hint = "Display the trend of the percentage each value contributes over time or categorie" +
    "s.\r\n\r\nUse it to emphasize the trend in the proportion of each series.\r\n    ";
            createFullStackedSplineAreaChartItem5.Caption = "100% Stacked Spline Area";
            createFullStackedSplineAreaChartItem5.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createFullStackedSplineAreaChartItem5.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createSplineAreaChartItem5.Caption = "Spline Area";
            createSplineAreaChartItem5.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createSplineAreaChartItem5.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createStackedAreaChartItem5.Caption = "Stacked Area";
            createStackedAreaChartItem5.Description = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedAreaChartItem5.Hint = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.\r\n    ";
            createStackedSplineAreaChartItem5.Caption = "Stacked Spline Area";
            createStackedSplineAreaChartItem5.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStackedSplineAreaChartItem5.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStepAreaChartItem5.Caption = "Step Area";
            createStepAreaChartItem5.Description = "Show how much values have changed for different points of the same series.";
            createStepAreaChartItem5.Hint = "Show how much values have changed for different points of the same series.";
            chartControlCommandGalleryItemGroup2DArea5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem5,
            createFullStackedAreaChartItem5,
            createFullStackedSplineAreaChartItem5,
            createSplineAreaChartItem5,
            createStackedAreaChartItem5,
            createStackedSplineAreaChartItem5,
            createStepAreaChartItem5});
            chartControlCommandGalleryItemGroup3DArea5.Caption = "3-D Area";
            createArea3DChartItem5.Caption = "3-D Area";
            createArea3DChartItem5.Description = resources.GetString("createArea3DChartItem5.Description");
            createArea3DChartItem5.Hint = resources.GetString("createArea3DChartItem5.Hint");
            createFullStackedArea3DChartItem5.Caption = "100% Stacked Area in 3-D";
            createFullStackedArea3DChartItem5.Description = resources.GetString("createFullStackedArea3DChartItem5.Description");
            createFullStackedArea3DChartItem5.Hint = resources.GetString("createFullStackedArea3DChartItem5.Hint");
            createFullStackedSplineArea3DChartItem5.Caption = "100% Stacked Spline Area in 3-D";
            createFullStackedSplineArea3DChartItem5.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createFullStackedSplineArea3DChartItem5.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createSplineArea3DChartItem5.Caption = "Spline Area in 3-D";
            createSplineArea3DChartItem5.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createSplineArea3DChartItem5.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createStackedArea3DChartItem5.Caption = "Stacked Area in 3-D";
            createStackedArea3DChartItem5.Description = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedArea3DChartItem5.Hint = "Display series as areas on a diagram, so that the value of each data point is agg" +
    "regated with the underlying data points\' values.";
            createStackedSplineArea3DChartItem5.Caption = "Stacked Spline Area in 3-D";
            createStackedSplineArea3DChartItem5.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStackedSplineArea3DChartItem5.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStepArea3DChartItem5.Caption = "Step Area in 3-D";
            createStepArea3DChartItem5.Description = "Show to what extent values have changed for different points in the same series.";
            createStepArea3DChartItem5.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DArea5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem5,
            createFullStackedArea3DChartItem5,
            createFullStackedSplineArea3DChartItem5,
            createSplineArea3DChartItem5,
            createStackedArea3DChartItem5,
            createStackedSplineArea3DChartItem5,
            createStepArea3DChartItem5});
            this.commandBarGalleryDropDown12.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea5,
            chartControlCommandGalleryItemGroup3DArea5});
            this.commandBarGalleryDropDown12.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown12.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown12.Manager = null;
            this.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12";
            // 
            // commandBarGalleryDropDown13
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown13.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown13.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroupPoint5.Caption = "Point";
            createPointChartItem5.Caption = "Point";
            createPointChartItem5.Description = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createPointChartItem5.Hint = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createBubbleChartItem5.Caption = "Bubble";
            createBubbleChartItem5.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            createBubbleChartItem5.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            chartControlCommandGalleryItemGroupPoint5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem5,
            createBubbleChartItem5});
            chartControlCommandGalleryItemGroupFunnel5.Caption = "Funnel";
            createFunnelChartItem5.Caption = "Funnel";
            createFunnelChartItem5.Description = resources.GetString("createFunnelChartItem5.Description");
            createFunnelChartItem5.Hint = resources.GetString("createFunnelChartItem5.Hint");
            createFunnel3DChartItem5.Caption = "3-D Funnel";
            createFunnel3DChartItem5.Description = resources.GetString("createFunnel3DChartItem5.Description");
            createFunnel3DChartItem5.Hint = resources.GetString("createFunnel3DChartItem5.Hint");
            chartControlCommandGalleryItemGroupFunnel5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem5,
            createFunnel3DChartItem5});
            chartControlCommandGalleryItemGroupFinancial5.Caption = "Financial";
            createStockChartItem5.Caption = "Stock";
            createStockChartItem5.Description = resources.GetString("createStockChartItem5.Description");
            createStockChartItem5.Hint = resources.GetString("createStockChartItem5.Hint");
            createCandleStickChartItem5.Caption = "Candle Stick";
            createCandleStickChartItem5.Description = resources.GetString("createCandleStickChartItem5.Description");
            createCandleStickChartItem5.Hint = resources.GetString("createCandleStickChartItem5.Hint");
            chartControlCommandGalleryItemGroupFinancial5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem5,
            createCandleStickChartItem5});
            chartControlCommandGalleryItemGroupRadar5.Caption = "Radar";
            createRadarPointChartItem5.Caption = "Radar Point";
            createRadarPointChartItem5.Description = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarPointChartItem5.Hint = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem5.Caption = "Radar Line";
            createRadarLineChartItem5.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem5.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarAreaChartItem5.Caption = "Radar Area";
            createRadarAreaChartItem5.Description = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            createRadarAreaChartItem5.Hint = "Display series as filled area on a circular grid that has multiple axes along whi" +
    "ch data can be plotted.";
            chartControlCommandGalleryItemGroupRadar5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem5,
            createRadarLineChartItem5,
            createRadarAreaChartItem5});
            chartControlCommandGalleryItemGroupPolar5.Caption = "Polar";
            createPolarPointChartItem5.Caption = "Polar Point";
            createPolarPointChartItem5.Description = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarPointChartItem5.Hint = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarLineChartItem5.Caption = "Polar Line";
            createPolarLineChartItem5.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarLineChartItem5.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarAreaChartItem5.Caption = "Polar Area";
            createPolarAreaChartItem5.Description = "Display series as filled area on a circular diagram on the basis of angles.";
            createPolarAreaChartItem5.Hint = "Display series as filled area on a circular diagram on the basis of angles.";
            chartControlCommandGalleryItemGroupPolar5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem5,
            createPolarLineChartItem5,
            createPolarAreaChartItem5});
            chartControlCommandGalleryItemGroupRange5.Caption = "Range";
            createRangeBarChartItem5.Caption = "Range Column";
            createRangeBarChartItem5.Description = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createRangeBarChartItem5.Hint = "Display vertical columns along the Y-axis (the axis of values). Each column repre" +
    "sents a range of data for each argument value.";
            createSideBySideRangeBarChartItem5.Caption = "Clustered Range Column";
            createSideBySideRangeBarChartItem5.Description = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createSideBySideRangeBarChartItem5.Hint = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createRangeAreaChartItem5.Caption = "Range Area";
            createRangeAreaChartItem5.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeAreaChartItem5.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem5.Caption = "Range Area in 3-D";
            createRangeArea3DChartItem5.Description = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            createRangeArea3DChartItem5.Hint = "Display series as filled areas on a diagram, with two data points that define min" +
    "imum and maximum limits.\r\n\r\nUse it when you need to accentuate the delta between" +
    " start and end values.\r\n    ";
            chartControlCommandGalleryItemGroupRange5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem5,
            createSideBySideRangeBarChartItem5,
            createRangeAreaChartItem5,
            createRangeArea3DChartItem5});
            chartControlCommandGalleryItemGroupGantt5.Caption = "Gantt";
            createGanttChartItem5.Caption = "Gantt";
            createGanttChartItem5.Description = "Track different activities during the time frame.";
            createGanttChartItem5.Hint = "Track different activities during the time frame.";
            createSideBySideGanttChartItem5.Caption = "Clustered Gantt";
            createSideBySideGanttChartItem5.Description = resources.GetString("createSideBySideGanttChartItem5.Description");
            createSideBySideGanttChartItem5.Hint = resources.GetString("createSideBySideGanttChartItem5.Hint");
            chartControlCommandGalleryItemGroupGantt5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem5,
            createSideBySideGanttChartItem5});
            this.commandBarGalleryDropDown13.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint5,
            chartControlCommandGalleryItemGroupFunnel5,
            chartControlCommandGalleryItemGroupFinancial5,
            chartControlCommandGalleryItemGroupRadar5,
            chartControlCommandGalleryItemGroupPolar5,
            chartControlCommandGalleryItemGroupRange5,
            chartControlCommandGalleryItemGroupGantt5});
            this.commandBarGalleryDropDown13.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown13.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown13.Manager = null;
            this.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13";
            // 
            // commandBarGalleryDropDown14
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown14.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown14.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown14.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges9.Bottom = -3;
            skinPaddingEdges9.Top = -3;
            this.commandBarGalleryDropDown14.Gallery.ItemImagePadding = skinPaddingEdges9;
            skinPaddingEdges10.Bottom = -3;
            skinPaddingEdges10.Top = -3;
            this.commandBarGalleryDropDown14.Gallery.ItemTextPadding = skinPaddingEdges10;
            this.commandBarGalleryDropDown14.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown14.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown14.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown14.Manager = null;
            this.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14";
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown1.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DColumn6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem6,
            createFullStackedBarChartItem6,
            createSideBySideFullStackedBarChartItem6,
            createSideBySideStackedBarChartItem6,
            createStackedBarChartItem6});
            chartControlCommandGalleryItemGroup3DColumn6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem6,
            createFullStackedBar3DChartItem6,
            createManhattanBarChartItem6,
            createSideBySideFullStackedBar3DChartItem6,
            createSideBySideStackedBar3DChartItem6,
            createStackedBar3DChartItem6});
            chartControlCommandGalleryItemGroupCylinderColumn6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem6,
            createCylinderFullStackedBar3DChartItem6,
            createCylinderManhattanBarChartItem6,
            createCylinderSideBySideFullStackedBar3DChartItem6,
            createCylinderSideBySideStackedBar3DChartItem6,
            createCylinderStackedBar3DChartItem6});
            chartControlCommandGalleryItemGroupConeColumn6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem6,
            createConeFullStackedBar3DChartItem6,
            createConeManhattanBarChartItem6,
            createConeSideBySideFullStackedBar3DChartItem6,
            createConeSideBySideStackedBar3DChartItem6,
            createConeStackedBar3DChartItem6});
            chartControlCommandGalleryItemGroupPyramidColumn6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem6,
            createPyramidFullStackedBar3DChartItem6,
            createPyramidManhattanBarChartItem6,
            createPyramidSideBySideFullStackedBar3DChartItem6,
            createPyramidSideBySideStackedBar3DChartItem6,
            createPyramidStackedBar3DChartItem6});
            this.commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn6,
            chartControlCommandGalleryItemGroup3DColumn6,
            chartControlCommandGalleryItemGroupCylinderColumn6,
            chartControlCommandGalleryItemGroupConeColumn6,
            chartControlCommandGalleryItemGroupPyramidColumn6});
            this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown1.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown1.Manager = null;
            this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown2.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DLine6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem6,
            createFullStackedLineChartItem6,
            createScatterLineChartItem6,
            createSplineChartItem6,
            createStackedLineChartItem6,
            createStepLineChartItem6});
            chartControlCommandGalleryItemGroup3DLine6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem6,
            createFullStackedLine3DChartItem6,
            createSpline3DChartItem6,
            createStackedLine3DChartItem6,
            createStepLine3DChartItem6});
            this.commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine6,
            chartControlCommandGalleryItemGroup3DLine6});
            this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown2.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown2.Manager = null;
            this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            // 
            // commandBarGalleryDropDown3
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown3.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown3.Gallery.ColumnCount = 2;
            chartControlCommandGalleryItemGroup2DPie6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem6,
            createDoughnutChartItem6});
            chartControlCommandGalleryItemGroup3DPie6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem6,
            createDoughnut3DChartItem6});
            this.commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie6,
            chartControlCommandGalleryItemGroup3DPie6});
            this.commandBarGalleryDropDown3.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown3.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown3.Manager = null;
            this.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
            // 
            // commandBarGalleryDropDown4
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown4.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown4.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DBar6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem6,
            createRotatedFullStackedBarChartItem6,
            createRotatedSideBySideFullStackedBarChartItem6,
            createRotatedSideBySideStackedBarChartItem6,
            createRotatedStackedBarChartItem6});
            this.commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar6});
            this.commandBarGalleryDropDown4.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown4.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown4.Manager = null;
            this.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
            // 
            // commandBarGalleryDropDown5
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown5.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown5.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DArea6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem6,
            createFullStackedAreaChartItem6,
            createFullStackedSplineAreaChartItem6,
            createSplineAreaChartItem6,
            createStackedAreaChartItem6,
            createStackedSplineAreaChartItem6,
            createStepAreaChartItem6});
            chartControlCommandGalleryItemGroup3DArea6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem6,
            createFullStackedArea3DChartItem6,
            createFullStackedSplineArea3DChartItem6,
            createSplineArea3DChartItem6,
            createStackedArea3DChartItem6,
            createStackedSplineArea3DChartItem6,
            createStepArea3DChartItem6});
            this.commandBarGalleryDropDown5.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea6,
            chartControlCommandGalleryItemGroup3DArea6});
            this.commandBarGalleryDropDown5.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown5.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown5.Manager = null;
            this.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
            // 
            // commandBarGalleryDropDown6
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown6.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown6.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroupPoint6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem6,
            createBubbleChartItem6});
            chartControlCommandGalleryItemGroupFunnel6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem6,
            createFunnel3DChartItem6});
            chartControlCommandGalleryItemGroupFinancial6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem6,
            createCandleStickChartItem6});
            chartControlCommandGalleryItemGroupRadar6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem6,
            createRadarLineChartItem6,
            createRadarAreaChartItem6});
            chartControlCommandGalleryItemGroupPolar6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem6,
            createPolarLineChartItem6,
            createPolarAreaChartItem6});
            chartControlCommandGalleryItemGroupRange6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem6,
            createSideBySideRangeBarChartItem6,
            createRangeAreaChartItem6,
            createRangeArea3DChartItem6});
            chartControlCommandGalleryItemGroupGantt6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem6,
            createSideBySideGanttChartItem6});
            this.commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint6,
            chartControlCommandGalleryItemGroupFunnel6,
            chartControlCommandGalleryItemGroupFinancial6,
            chartControlCommandGalleryItemGroupRadar6,
            chartControlCommandGalleryItemGroupPolar6,
            chartControlCommandGalleryItemGroupRange6,
            chartControlCommandGalleryItemGroupGantt6});
            this.commandBarGalleryDropDown6.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown6.Gallery.RowCount = 7;
            this.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown6.Manager = null;
            this.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
            // 
            // commandBarGalleryDropDown7
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown7.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.ColumnCount = 1;
            changePaletteGalleryItem1.Caption = "Apex";
            changePaletteGalleryItem1.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem1.Image")));
            changePaletteGalleryItem1.Tag = "Apex";
            changePaletteGalleryItem2.Caption = "Aspect";
            changePaletteGalleryItem2.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem2.Image")));
            changePaletteGalleryItem2.Tag = "Aspect";
            changePaletteGalleryItem3.Caption = "Black and White";
            changePaletteGalleryItem3.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem3.Image")));
            changePaletteGalleryItem3.Tag = "Black and White";
            changePaletteGalleryItem4.Caption = "Chameleon";
            changePaletteGalleryItem4.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem4.Image")));
            changePaletteGalleryItem4.Tag = "Chameleon";
            changePaletteGalleryItem5.Caption = "Civic";
            changePaletteGalleryItem5.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem5.Image")));
            changePaletteGalleryItem5.Tag = "Civic";
            changePaletteGalleryItem6.Caption = "Concourse";
            changePaletteGalleryItem6.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem6.Image")));
            changePaletteGalleryItem6.Tag = "Concourse";
            changePaletteGalleryItem7.Caption = "Default";
            changePaletteGalleryItem7.Checked = true;
            changePaletteGalleryItem7.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem7.Image")));
            changePaletteGalleryItem7.Tag = "Default";
            changePaletteGalleryItem8.Caption = "Equity";
            changePaletteGalleryItem8.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem8.Image")));
            changePaletteGalleryItem8.Tag = "Equity";
            changePaletteGalleryItem9.Caption = "Flow";
            changePaletteGalleryItem9.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem9.Image")));
            changePaletteGalleryItem9.Tag = "Flow";
            changePaletteGalleryItem10.Caption = "Foundry";
            changePaletteGalleryItem10.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem10.Image")));
            changePaletteGalleryItem10.Tag = "Foundry";
            changePaletteGalleryItem11.Caption = "Grayscale";
            changePaletteGalleryItem11.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem11.Image")));
            changePaletteGalleryItem11.Tag = "Grayscale";
            changePaletteGalleryItem12.Caption = "In A Fog";
            changePaletteGalleryItem12.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem12.Image")));
            changePaletteGalleryItem12.Tag = "In A Fog";
            changePaletteGalleryItem13.Caption = "Median";
            changePaletteGalleryItem13.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem13.Image")));
            changePaletteGalleryItem13.Tag = "Median";
            changePaletteGalleryItem14.Caption = "Metro";
            changePaletteGalleryItem14.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem14.Image")));
            changePaletteGalleryItem14.Tag = "Metro";
            changePaletteGalleryItem15.Caption = "Module";
            changePaletteGalleryItem15.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem15.Image")));
            changePaletteGalleryItem15.Tag = "Module";
            changePaletteGalleryItem16.Caption = "Nature Colors";
            changePaletteGalleryItem16.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem16.Image")));
            changePaletteGalleryItem16.Tag = "Nature Colors";
            changePaletteGalleryItem17.Caption = "Northern Lights";
            changePaletteGalleryItem17.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem17.Image")));
            changePaletteGalleryItem17.Tag = "Northern Lights";
            changePaletteGalleryItem18.Caption = "Office";
            changePaletteGalleryItem18.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem18.Image")));
            changePaletteGalleryItem18.Tag = "Office";
            changePaletteGalleryItem19.Caption = "Opulent";
            changePaletteGalleryItem19.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem19.Image")));
            changePaletteGalleryItem19.Tag = "Opulent";
            changePaletteGalleryItem20.Caption = "Oriel";
            changePaletteGalleryItem20.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem20.Image")));
            changePaletteGalleryItem20.Tag = "Oriel";
            changePaletteGalleryItem21.Caption = "Origin";
            changePaletteGalleryItem21.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem21.Image")));
            changePaletteGalleryItem21.Tag = "Origin";
            changePaletteGalleryItem22.Caption = "Paper";
            changePaletteGalleryItem22.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem22.Image")));
            changePaletteGalleryItem22.Tag = "Paper";
            changePaletteGalleryItem23.Caption = "Pastel Kit";
            changePaletteGalleryItem23.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem23.Image")));
            changePaletteGalleryItem23.Tag = "Pastel Kit";
            changePaletteGalleryItem24.Caption = "Solstice";
            changePaletteGalleryItem24.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem24.Image")));
            changePaletteGalleryItem24.Tag = "Solstice";
            changePaletteGalleryItem25.Caption = "Technic";
            changePaletteGalleryItem25.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem25.Image")));
            changePaletteGalleryItem25.Tag = "Technic";
            changePaletteGalleryItem26.Caption = "Terracotta Pie";
            changePaletteGalleryItem26.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem26.Image")));
            changePaletteGalleryItem26.Tag = "Terracotta Pie";
            changePaletteGalleryItem27.Caption = "The Mixed";
            changePaletteGalleryItem27.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem27.Image")));
            changePaletteGalleryItem27.Tag = "Mixed";
            changePaletteGalleryItem28.Caption = "The Trees";
            changePaletteGalleryItem28.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem28.Image")));
            changePaletteGalleryItem28.Tag = "The Trees";
            changePaletteGalleryItem29.Caption = "Trek";
            changePaletteGalleryItem29.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem29.Image")));
            changePaletteGalleryItem29.Tag = "Trek";
            changePaletteGalleryItem30.Caption = "Urban";
            changePaletteGalleryItem30.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem30.Image")));
            changePaletteGalleryItem30.Tag = "Urban";
            changePaletteGalleryItem31.Caption = "Verve";
            changePaletteGalleryItem31.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem31.Image")));
            changePaletteGalleryItem31.Tag = "Verve";
            galleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            changePaletteGalleryItem1,
            changePaletteGalleryItem2,
            changePaletteGalleryItem3,
            changePaletteGalleryItem4,
            changePaletteGalleryItem5,
            changePaletteGalleryItem6,
            changePaletteGalleryItem7,
            changePaletteGalleryItem8,
            changePaletteGalleryItem9,
            changePaletteGalleryItem10,
            changePaletteGalleryItem11,
            changePaletteGalleryItem12,
            changePaletteGalleryItem13,
            changePaletteGalleryItem14,
            changePaletteGalleryItem15,
            changePaletteGalleryItem16,
            changePaletteGalleryItem17,
            changePaletteGalleryItem18,
            changePaletteGalleryItem19,
            changePaletteGalleryItem20,
            changePaletteGalleryItem21,
            changePaletteGalleryItem22,
            changePaletteGalleryItem23,
            changePaletteGalleryItem24,
            changePaletteGalleryItem25,
            changePaletteGalleryItem26,
            changePaletteGalleryItem27,
            changePaletteGalleryItem28,
            changePaletteGalleryItem29,
            changePaletteGalleryItem30,
            changePaletteGalleryItem31});
            this.commandBarGalleryDropDown7.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup4});
            this.commandBarGalleryDropDown7.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges11.Bottom = -3;
            skinPaddingEdges11.Top = -3;
            this.commandBarGalleryDropDown7.Gallery.ItemImagePadding = skinPaddingEdges11;
            skinPaddingEdges12.Bottom = -3;
            skinPaddingEdges12.Top = -3;
            this.commandBarGalleryDropDown7.Gallery.ItemTextPadding = skinPaddingEdges12;
            this.commandBarGalleryDropDown7.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown7.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown7.Manager = null;
            this.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.snapDockManager1.SnapControl = this.snapControl1;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer1.Controls.Add(this.reportExplorerDockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("ec84028d-fae9-41e9-bbdd-ab7d0b1dac6a");
            this.panelContainer1.Location = new System.Drawing.Point(922, 141);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 523);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("5c850da2-ed26-4e09-b1e1-da019019a60d");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 261);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 262);
            this.fieldListDockPanel1.SnapControl = this.snapControl1;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(192, 235);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            this.reportExplorerDockPanel1.Controls.Add(this.reportExplorerDockPanel1_Container);
            this.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.reportExplorerDockPanel1.ID = new System.Guid("a5a1f29d-7234-46dd-ae96-25f04498abfe");
            this.reportExplorerDockPanel1.Location = new System.Drawing.Point(0, 262);
            this.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            this.reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(200, 261);
            this.reportExplorerDockPanel1.Size = new System.Drawing.Size(200, 261);
            this.reportExplorerDockPanel1.SnapControl = this.snapControl1;
            // 
            // reportExplorerDockPanel1_Container
            // 
            this.reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            this.reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(192, 234);
            this.reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // snapDocumentManager1
            // 
            this.snapDocumentManager1.ClientControl = this.snapControl1;
            this.snapDocumentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.snapDocumentManager1.View = this.noDocumentsView1;
            this.snapDocumentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1});
            // 
            // snapBarController1
            // 
            this.snapBarController1.BarItems.Add(this.fileNewItem1);
            this.snapBarController1.BarItems.Add(this.fileOpenItem1);
            this.snapBarController1.BarItems.Add(this.fileSaveItem1);
            this.snapBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem1);
            this.snapBarController1.BarItems.Add(this.quickPrintItem1);
            this.snapBarController1.BarItems.Add(this.printItem1);
            this.snapBarController1.BarItems.Add(this.printPreviewItem1);
            this.snapBarController1.BarItems.Add(this.undoItem1);
            this.snapBarController1.BarItems.Add(this.redoItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem2);
            this.snapBarController1.BarItems.Add(this.pasteItem1);
            this.snapBarController1.BarItems.Add(this.cutItem1);
            this.snapBarController1.BarItems.Add(this.copyItem1);
            this.snapBarController1.BarItems.Add(this.pasteSpecialItem1);
            this.snapBarController1.BarItems.Add(this.changeFontNameItem1);
            this.snapBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.snapBarController1.BarItems.Add(this.fontSizeIncreaseItem1);
            this.snapBarController1.BarItems.Add(this.fontSizeDecreaseItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontBoldItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontItalicItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontUnderlineItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontSuperscriptItem1);
            this.snapBarController1.BarItems.Add(this.toggleFontSubscriptItem1);
            this.snapBarController1.BarItems.Add(this.changeFontColorItem1);
            this.snapBarController1.BarItems.Add(this.changeFontBackColorItem1);
            this.snapBarController1.BarItems.Add(this.changeTextCaseItem1);
            this.snapBarController1.BarItems.Add(this.makeTextUpperCaseItem1);
            this.snapBarController1.BarItems.Add(this.makeTextLowerCaseItem1);
            this.snapBarController1.BarItems.Add(this.capitalizeEachWordCaseItem1);
            this.snapBarController1.BarItems.Add(this.toggleTextCaseItem1);
            this.snapBarController1.BarItems.Add(this.clearFormattingItem1);
            this.snapBarController1.BarItems.Add(this.toggleBulletedListItem1);
            this.snapBarController1.BarItems.Add(this.toggleNumberingListItem1);
            this.snapBarController1.BarItems.Add(this.toggleMultiLevelListItem1);
            this.snapBarController1.BarItems.Add(this.decreaseIndentItem1);
            this.snapBarController1.BarItems.Add(this.increaseIndentItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.snapBarController1.BarItems.Add(this.changeParagraphLineSpacingItem1);
            this.snapBarController1.BarItems.Add(this.setSingleParagraphSpacingItem1);
            this.snapBarController1.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
            this.snapBarController1.BarItems.Add(this.setDoubleParagraphSpacingItem1);
            this.snapBarController1.BarItems.Add(this.showLineSpacingFormItem1);
            this.snapBarController1.BarItems.Add(this.addSpacingBeforeParagraphItem1);
            this.snapBarController1.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
            this.snapBarController1.BarItems.Add(this.addSpacingAfterParagraphItem1);
            this.snapBarController1.BarItems.Add(this.removeSpacingAfterParagraphItem1);
            this.snapBarController1.BarItems.Add(this.changeParagraphBackColorItem1);
            this.snapBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.snapBarController1.BarItems.Add(this.findItem1);
            this.snapBarController1.BarItems.Add(this.replaceItem1);
            this.snapBarController1.BarItems.Add(this.insertPageBreakItem21);
            this.snapBarController1.BarItems.Add(this.insertTableItem1);
            this.snapBarController1.BarItems.Add(this.insertPictureItem1);
            this.snapBarController1.BarItems.Add(this.insertFloatingPictureItem1);
            this.snapBarController1.BarItems.Add(this.commandBarItem3);
            this.snapBarController1.BarItems.Add(this.commandBarItem4);
            this.snapBarController1.BarItems.Add(this.commandBarItem5);
            this.snapBarController1.BarItems.Add(this.commandBarItem6);
            this.snapBarController1.BarItems.Add(this.commandBarItem7);
            this.snapBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.snapBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.snapBarController1.BarItems.Add(this.editPageHeaderItem1);
            this.snapBarController1.BarItems.Add(this.editPageFooterItem1);
            this.snapBarController1.BarItems.Add(this.insertPageNumberItem1);
            this.snapBarController1.BarItems.Add(this.insertPageCountItem1);
            this.snapBarController1.BarItems.Add(this.insertTextBoxItem1);
            this.snapBarController1.BarItems.Add(this.insertSymbolItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setNormalSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setNarrowSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setModerateSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.setWideSectionPageMarginsItem1);
            this.snapBarController1.BarItems.Add(this.showPageMarginsSetupFormItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionPageOrientationItem1);
            this.snapBarController1.BarItems.Add(this.setPortraitPageOrientationItem1);
            this.snapBarController1.BarItems.Add(this.setLandscapePageOrientationItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionPaperKindItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionColumnsItem1);
            this.snapBarController1.BarItems.Add(this.setSectionOneColumnItem1);
            this.snapBarController1.BarItems.Add(this.setSectionTwoColumnsItem1);
            this.snapBarController1.BarItems.Add(this.setSectionThreeColumnsItem1);
            this.snapBarController1.BarItems.Add(this.showColumnsSetupFormItem1);
            this.snapBarController1.BarItems.Add(this.insertBreakItem1);
            this.snapBarController1.BarItems.Add(this.insertPageBreakItem1);
            this.snapBarController1.BarItems.Add(this.insertColumnBreakItem1);
            this.snapBarController1.BarItems.Add(this.insertSectionBreakNextPageItem1);
            this.snapBarController1.BarItems.Add(this.insertSectionBreakEvenPageItem1);
            this.snapBarController1.BarItems.Add(this.insertSectionBreakOddPageItem1);
            this.snapBarController1.BarItems.Add(this.changeSectionLineNumberingItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingNoneItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingContinuousItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingRestartNewPageItem1);
            this.snapBarController1.BarItems.Add(this.setSectionLineNumberingRestartNewSectionItem1);
            this.snapBarController1.BarItems.Add(this.toggleParagraphSuppressLineNumbersItem1);
            this.snapBarController1.BarItems.Add(this.showLineNumberingFormItem1);
            this.snapBarController1.BarItems.Add(this.changePageColorItem1);
            this.snapBarController1.BarItems.Add(this.switchToSimpleViewItem1);
            this.snapBarController1.BarItems.Add(this.switchToDraftViewItem1);
            this.snapBarController1.BarItems.Add(this.switchToPrintLayoutViewItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowHorizontalRulerItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowVerticalRulerItem1);
            this.snapBarController1.BarItems.Add(this.zoomOutItem1);
            this.snapBarController1.BarItems.Add(this.zoomInItem1);
            this.snapBarController1.BarItems.Add(this.snapBarToolbarsListItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem1);
            this.snapBarController1.BarItems.Add(this.showAllFieldCodesItem1);
            this.snapBarController1.BarItems.Add(this.showAllFieldResultsItem1);
            this.snapBarController1.BarItems.Add(this.toggleFieldHighlightingItem1);
            this.snapBarController1.BarItems.Add(this.goToPageHeaderItem1);
            this.snapBarController1.BarItems.Add(this.goToPageFooterItem1);
            this.snapBarController1.BarItems.Add(this.goToNextHeaderFooterItem1);
            this.snapBarController1.BarItems.Add(this.goToPreviousHeaderFooterItem1);
            this.snapBarController1.BarItems.Add(this.toggleLinkToPreviousItem1);
            this.snapBarController1.BarItems.Add(this.toggleDifferentFirstPageItem1);
            this.snapBarController1.BarItems.Add(this.toggleDifferentOddAndEvenPagesItem1);
            this.snapBarController1.BarItems.Add(this.closePageHeaderFooterItem1);
            this.snapBarController1.BarItems.Add(this.toggleFirstRowItem1);
            this.snapBarController1.BarItems.Add(this.toggleLastRowItem1);
            this.snapBarController1.BarItems.Add(this.toggleBandedRowsItem1);
            this.snapBarController1.BarItems.Add(this.toggleFirstColumnItem1);
            this.snapBarController1.BarItems.Add(this.toggleLastColumnItem1);
            this.snapBarController1.BarItems.Add(this.toggleBandedColumnItem1);
            this.snapBarController1.BarItems.Add(this.galleryChangeTableStyleItem1);
            this.snapBarController1.BarItems.Add(this.galleryChangeTableCellStyleItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBorderLineStyleItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBorderLineWeightItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBorderColorItem1);
            this.snapBarController1.BarItems.Add(this.changeTableBordersItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsLeftBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsRightBorderItem1);
            this.snapBarController1.BarItems.Add(this.resetTableCellsAllBordersItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsAllBordersItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsOutsideBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsInsideBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsInsideHorizontalBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsInsideVerticalBorderItem1);
            this.snapBarController1.BarItems.Add(this.toggleShowTableGridLinesItem1);
            this.snapBarController1.BarItems.Add(this.changeTableCellsShadingItem1);
            this.snapBarController1.BarItems.Add(this.selectTableElementsItem1);
            this.snapBarController1.BarItems.Add(this.selectTableCellItem1);
            this.snapBarController1.BarItems.Add(this.selectTableColumnItem1);
            this.snapBarController1.BarItems.Add(this.selectTableRowItem1);
            this.snapBarController1.BarItems.Add(this.selectTableItem1);
            this.snapBarController1.BarItems.Add(this.showTablePropertiesFormItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableElementsItem1);
            this.snapBarController1.BarItems.Add(this.showDeleteTableCellsFormItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableColumnsItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableRowsItem1);
            this.snapBarController1.BarItems.Add(this.deleteTableItem1);
            this.snapBarController1.BarItems.Add(this.insertTableRowAboveItem1);
            this.snapBarController1.BarItems.Add(this.insertTableRowBelowItem1);
            this.snapBarController1.BarItems.Add(this.insertTableColumnToLeftItem1);
            this.snapBarController1.BarItems.Add(this.insertTableColumnToRightItem1);
            this.snapBarController1.BarItems.Add(this.mergeTableCellsItem1);
            this.snapBarController1.BarItems.Add(this.showSplitTableCellsForm1);
            this.snapBarController1.BarItems.Add(this.splitTableItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableAutoFitItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableAutoFitContentsItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableAutoFitWindowItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableFixedColumnWidthItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsMiddleLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsMiddleCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsTopRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsMiddleRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.toggleTableCellsBottomRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.showTableOptionsFormItem1);
            this.snapBarController1.BarItems.Add(this.checkSpellingItem1);
            this.snapBarController1.BarItems.Add(this.insertTableOfContentsItem1);
            this.snapBarController1.BarItems.Add(this.updateTableOfContentsItem1);
            this.snapBarController1.BarItems.Add(this.addParagraphsToTableOfContentItem1);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem1);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem2);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem3);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem4);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem5);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem6);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem7);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem8);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem9);
            this.snapBarController1.BarItems.Add(this.setParagraphHeadingLevelItem10);
            this.snapBarController1.BarItems.Add(this.insertCaptionPlaceholderItem1);
            this.snapBarController1.BarItems.Add(this.insertFiguresCaptionItems1);
            this.snapBarController1.BarItems.Add(this.insertTablesCaptionItems1);
            this.snapBarController1.BarItems.Add(this.insertEquationsCaptionItems1);
            this.snapBarController1.BarItems.Add(this.insertTableOfFiguresPlaceholderItem1);
            this.snapBarController1.BarItems.Add(this.insertTableOfFiguresItems1);
            this.snapBarController1.BarItems.Add(this.insertTableOfTablesItems1);
            this.snapBarController1.BarItems.Add(this.insertTableOfEquationsItems1);
            this.snapBarController1.BarItems.Add(this.updateTableOfFiguresItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectFillColorItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectOutlineColorItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectOutlineWeightItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectSquareTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTightTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectThroughTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopAndBottomTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBehindTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectInFrontOfTextWrapTypeItem1);
            this.snapBarController1.BarItems.Add(this.changeFloatingObjectAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectTopRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectMiddleLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectMiddleCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectMiddleRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBottomLeftAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBottomCenterAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.setFloatingObjectBottomRightAlignmentItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringForwardSubItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringForwardItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringToFrontItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectBringInFrontOfTextItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendBackwardSubItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendBackwardItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendToBackItem1);
            this.snapBarController1.BarItems.Add(this.floatingObjectSendBehindTextItem1);
            this.snapBarController1.BarItems.Add(this.themesGalleryBarItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem2);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem3);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem4);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem5);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem6);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem7);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem8);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem9);
            this.snapBarController1.BarItems.Add(this.filterPopupButtonItem1);
            this.snapBarController1.BarItems.Add(this.propertiesBarButtonItem1);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem2);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem10);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem11);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem3);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem12);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem13);
            this.snapBarController1.BarItems.Add(this.commandBarItem8);
            this.snapBarController1.BarItems.Add(this.commandBarItem9);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem4);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem14);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem15);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem16);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem17);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem18);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem19);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem20);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem5);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem21);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem22);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem6);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem23);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem24);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem7);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem25);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem26);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem27);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem28);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem29);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem30);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem31);
            this.snapBarController1.BarItems.Add(this.commandBarItem10);
            this.snapBarController1.BarItems.Add(this.commandBarItem11);
            this.snapBarController1.BarItems.Add(this.commandBarItem12);
            this.snapBarController1.BarItems.Add(this.changeEditorRowLimitItem1);
            this.snapBarController1.BarItems.Add(this.createBarBaseItem1);
            this.snapBarController1.BarItems.Add(this.createLineBaseItem1);
            this.snapBarController1.BarItems.Add(this.createPieBaseItem1);
            this.snapBarController1.BarItems.Add(this.createRotatedBarBaseItem1);
            this.snapBarController1.BarItems.Add(this.createAreaBaseItem1);
            this.snapBarController1.BarItems.Add(this.createOtherSeriesTypesBaseItem1);
            this.snapBarController1.BarItems.Add(this.changePaletteGalleryBaseItem1);
            this.snapBarController1.BarItems.Add(this.changeAppearanceGalleryBaseItem1);
            this.snapBarController1.BarItems.Add(this.runWizardChartItem1);
            this.snapBarController1.BarItems.Add(this.mailMergeDataSourceItem1);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem32);
            this.snapBarController1.BarItems.Add(this.commandBarCheckItem33);
            this.snapBarController1.BarItems.Add(this.mailMergeCurrentRecordItem1);
            this.snapBarController1.BarItems.Add(this.commandBarSubItem8);
            this.snapBarController1.BarItems.Add(this.commandBarItem13);
            this.snapBarController1.BarItems.Add(this.commandBarItem14);
            this.snapBarController1.BarItems.Add(this.commandBarItem15);
            this.snapBarController1.BarItems.Add(this.runDesignerChartItem1);
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.headerFooterToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.tableToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.floatingPictureToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.dataToolsRibbonPageCategory1));
            this.snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(this.chartRibbonPageCategory1));
            this.snapBarController1.Control = this.snapControl1;
            this.snapBarController1.RibbonControl = this.ribbonControl1;
            this.snapBarController1.SnapDockManager = this.snapDockManager1;
            // 
            // chartTypeRibbonPageGroup1
            // 
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createBarBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createLineBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createPieBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createRotatedBarBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createAreaBaseItem1);
            this.chartTypeRibbonPageGroup1.ItemLinks.Add(this.createOtherSeriesTypesBaseItem1);
            this.chartTypeRibbonPageGroup1.Name = "chartTypeRibbonPageGroup1";
            // 
            // createChartRibbonPage1
            // 
            this.createChartRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartTypeRibbonPageGroup1,
            this.chartAppearanceRibbonPageGroup1,
            this.chartWizardRibbonPageGroup1});
            this.createChartRibbonPage1.Name = "createChartRibbonPage1";
            // 
            // chartRibbonPageCategory1
            // 
            this.chartRibbonPageCategory1.Control = null;
            this.chartRibbonPageCategory1.Name = "chartRibbonPageCategory1";
            this.chartRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.createChartRibbonPage1});
            // 
            // chartAppearanceRibbonPageGroup1
            // 
            this.chartAppearanceRibbonPageGroup1.ItemLinks.Add(this.changePaletteGalleryBaseItem1);
            this.chartAppearanceRibbonPageGroup1.ItemLinks.Add(this.changeAppearanceGalleryBaseItem1);
            this.chartAppearanceRibbonPageGroup1.Name = "chartAppearanceRibbonPageGroup1";
            // 
            // chartWizardRibbonPageGroup1
            // 
            this.chartWizardRibbonPageGroup1.AllowMinimize = false;
            this.chartWizardRibbonPageGroup1.ItemLinks.Add(this.runDesignerChartItem1);
            this.chartWizardRibbonPageGroup1.Name = "chartWizardRibbonPageGroup1";
            // 
            // runDesignerChartItem1
            // 
            this.runDesignerChartItem1.Id = 616;
            this.runDesignerChartItem1.Name = "runDesignerChartItem1";
            // 
            // BaseTutorial
            // 
            this.Controls.Add(this.snapControl1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BaseTutorial";
            this.Size = new System.Drawing.Size(1122, 664);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditorRowLimitEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMailMergeCurrentRecordEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditorRowLimitEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMailMergeCurrentRecordEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.fieldListDockPanel1.ResumeLayout(false);
            this.reportExplorerDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public DevExpress.Snap.SnapControl snapControl1;
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.Snap.Extensions.UI.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel reportExplorerDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer reportExplorerDockPanel1_Container;
        private DevExpress.Snap.Extensions.SnapDocumentManager snapDocumentManager1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown2;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown3;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown4;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown5;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown6;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown7;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown8;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown9;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown10;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown11;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown12;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown13;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown14;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown15;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown16;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown17;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown18;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown19;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown20;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown21;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown22;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown23;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown24;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown25;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown26;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown27;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown28;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle repositoryItemBorderLineStyle1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight repositoryItemBorderLineWeight1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight repositoryItemFloatingObjectOutlineWeight1;
        private DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit repositoryItemEditorRowLimitEdit1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown29;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown30;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown31;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown32;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown33;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown34;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown35;
        private DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit repositoryItemMailMergeCurrentRecordEdit1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem2;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteSpecialItem pasteSpecialItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit2;
        private DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit2;
        private DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem toggleFontSuperscriptItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem toggleFontSubscriptItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem changeFontBackColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTextCaseItem changeTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem makeTextUpperCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem makeTextLowerCaseItem1;
        private DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem capitalizeEachWordCaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTextCaseItem toggleTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup5;
        private DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup6;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup7;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem showLineSpacingFormItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem changeParagraphBackColorItem1;
        private DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem galleryChangeStyleItem1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageBreakItem2 insertPageBreakItem21;
        private DevExpress.XtraRichEdit.UI.InsertTableItem insertTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertPictureItem insertPictureItem1;
        private DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem insertFloatingPictureItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem3;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem4;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem5;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem6;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem7;
        private DevExpress.XtraRichEdit.UI.InsertBookmarkItem insertBookmarkItem1;
        private DevExpress.XtraRichEdit.UI.InsertHyperlinkItem insertHyperlinkItem1;
        private DevExpress.XtraRichEdit.UI.EditPageHeaderItem editPageHeaderItem1;
        private DevExpress.XtraRichEdit.UI.EditPageFooterItem editPageFooterItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageNumberItem insertPageNumberItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageCountItem insertPageCountItem1;
        private DevExpress.XtraRichEdit.UI.InsertTextBoxItem insertTextBoxItem1;
        private DevExpress.XtraRichEdit.UI.InsertSymbolItem insertSymbolItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem changeSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem setNormalSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem setNarrowSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem setModerateSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem setWideSectionPageMarginsItem1;
        private DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem showPageMarginsSetupFormItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem changeSectionPageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem setPortraitPageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem setLandscapePageOrientationItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem changeSectionPaperKindItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem changeSectionColumnsItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem setSectionOneColumnItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem setSectionTwoColumnsItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem setSectionThreeColumnsItem1;
        private DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem showColumnsSetupFormItem1;
        private DevExpress.XtraRichEdit.UI.InsertBreakItem insertBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageBreakItem insertPageBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertColumnBreakItem insertColumnBreakItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem insertSectionBreakNextPageItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem insertSectionBreakEvenPageItem1;
        private DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem insertSectionBreakOddPageItem1;
        private DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem changeSectionLineNumberingItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem setSectionLineNumberingNoneItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem setSectionLineNumberingContinuousItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem setSectionLineNumberingRestartNewPageItem1;
        private DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem setSectionLineNumberingRestartNewSectionItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem toggleParagraphSuppressLineNumbersItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem showLineNumberingFormItem1;
        private DevExpress.XtraRichEdit.UI.ChangePageColorItem changePageColorItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem switchToSimpleViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem switchToDraftViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem switchToPrintLayoutViewItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem toggleShowHorizontalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem toggleShowVerticalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
        private DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
        private DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem snapBarToolbarsListItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
        private DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem toggleFieldHighlightingItem1;
        private DevExpress.XtraRichEdit.UI.GoToPageHeaderItem goToPageHeaderItem1;
        private DevExpress.XtraRichEdit.UI.GoToPageFooterItem goToPageFooterItem1;
        private DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem goToNextHeaderFooterItem1;
        private DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem goToPreviousHeaderFooterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem toggleLinkToPreviousItem1;
        private DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem toggleDifferentFirstPageItem1;
        private DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem toggleDifferentOddAndEvenPagesItem1;
        private DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem closePageHeaderFooterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFirstRowItem toggleFirstRowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleLastRowItem toggleLastRowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem toggleBandedRowsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem toggleFirstColumnItem1;
        private DevExpress.XtraRichEdit.UI.ToggleLastColumnItem toggleLastColumnItem1;
        private DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem toggleBandedColumnItem1;
        private DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem galleryChangeTableStyleItem1;
        private DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem galleryChangeTableCellStyleItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem changeTableBorderLineStyleItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle repositoryItemBorderLineStyle2;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem changeTableBorderLineWeightItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight repositoryItemBorderLineWeight2;
        private DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem changeTableBorderColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableBordersItem changeTableBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem toggleTableCellsBottomBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem toggleTableCellsTopBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem toggleTableCellsLeftBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem toggleTableCellsRightBorderItem1;
        private DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem resetTableCellsAllBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem toggleTableCellsAllBordersItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem toggleTableCellsOutsideBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem toggleTableCellsInsideBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem toggleTableCellsInsideHorizontalBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem toggleTableCellsInsideVerticalBorderItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem toggleShowTableGridLinesItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem changeTableCellsShadingItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableElementsItem selectTableElementsItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableCellItem selectTableCellItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableColumnItem selectTableColumnItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableRowItem selectTableRowItem1;
        private DevExpress.XtraRichEdit.UI.SelectTableItem selectTableItem1;
        private DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem showTablePropertiesFormItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableElementsItem deleteTableElementsItem1;
        private DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem showDeleteTableCellsFormItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem deleteTableColumnsItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableRowsItem deleteTableRowsItem1;
        private DevExpress.XtraRichEdit.UI.DeleteTableItem deleteTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem insertTableRowAboveItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem insertTableRowBelowItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem insertTableColumnToLeftItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem insertTableColumnToRightItem1;
        private DevExpress.XtraRichEdit.UI.MergeTableCellsItem mergeTableCellsItem1;
        private DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm showSplitTableCellsForm1;
        private DevExpress.XtraRichEdit.UI.SplitTableItem splitTableItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem toggleTableAutoFitItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem toggleTableAutoFitContentsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem toggleTableAutoFitWindowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem toggleTableFixedColumnWidthItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem toggleTableCellsTopLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem toggleTableCellsMiddleLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem toggleTableCellsBottomLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem toggleTableCellsTopCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem toggleTableCellsMiddleCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem toggleTableCellsBottomCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem toggleTableCellsTopRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem toggleTableCellsMiddleRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem toggleTableCellsBottomRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem showTableOptionsFormItem1;
        private DevExpress.XtraRichEdit.UI.CheckSpellingItem checkSpellingItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem insertTableOfContentsItem1;
        private DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem updateTableOfContentsItem1;
        private DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem addParagraphsToTableOfContentItem1;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem1;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem2;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem3;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem4;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem5;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem6;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem7;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem8;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem9;
        private DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem10;
        private DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem insertCaptionPlaceholderItem1;
        private DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems insertFiguresCaptionItems1;
        private DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems insertTablesCaptionItems1;
        private DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems insertEquationsCaptionItems1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem insertTableOfFiguresPlaceholderItem1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems insertTableOfFiguresItems1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems insertTableOfTablesItems1;
        private DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems insertTableOfEquationsItems1;
        private DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem updateTableOfFiguresItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem changeFloatingObjectFillColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem changeFloatingObjectOutlineColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem changeFloatingObjectOutlineWeightItem1;
        private DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight repositoryItemFloatingObjectOutlineWeight2;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem changeFloatingObjectTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem setFloatingObjectSquareTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem setFloatingObjectTightTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem setFloatingObjectThroughTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem setFloatingObjectTopAndBottomTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem setFloatingObjectBehindTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem setFloatingObjectInFrontOfTextWrapTypeItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem changeFloatingObjectAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem setFloatingObjectTopLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem setFloatingObjectTopCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem setFloatingObjectTopRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem setFloatingObjectMiddleLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem setFloatingObjectMiddleCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem setFloatingObjectMiddleRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem setFloatingObjectBottomLeftAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem setFloatingObjectBottomCenterAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem setFloatingObjectBottomRightAlignmentItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem floatingObjectBringForwardSubItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem floatingObjectBringForwardItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem floatingObjectBringToFrontItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem floatingObjectBringInFrontOfTextItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem floatingObjectSendBackwardSubItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem floatingObjectSendBackwardItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem floatingObjectSendToBackItem1;
        private DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem floatingObjectSendBehindTextItem1;
        private DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem themesGalleryBarItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem2;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem3;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem4;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem5;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem6;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem7;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem8;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem9;
        private DevExpress.Snap.Extensions.UI.FilterPopupButtonItem filterPopupButtonItem1;
        private DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem propertiesBarButtonItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem2;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem10;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem11;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem3;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem12;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem13;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem8;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem9;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem4;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem14;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem15;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem16;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem17;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem18;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem19;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem20;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem5;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem21;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem22;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem6;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem23;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem24;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem7;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem25;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem26;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem27;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem28;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem29;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem30;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem31;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem10;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem11;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem12;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup8;
        private DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem changeEditorRowLimitItem1;
        private DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit repositoryItemEditorRowLimitEdit2;
        private DevExpress.XtraCharts.UI.CreateBarBaseItem createBarBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown36;
        private DevExpress.XtraCharts.UI.CreateLineBaseItem createLineBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown37;
        private DevExpress.XtraCharts.UI.CreatePieBaseItem createPieBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown38;
        private DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem createRotatedBarBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown39;
        private DevExpress.XtraCharts.UI.CreateAreaBaseItem createAreaBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown40;
        private DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem createOtherSeriesTypesBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown41;
        private DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem changePaletteGalleryBaseItem1;
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown42;
        private DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem changeAppearanceGalleryBaseItem1;
        private DevExpress.XtraCharts.UI.RunWizardChartItem runWizardChartItem1;
        private DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem mailMergeDataSourceItem1;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem32;
        private DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem33;
        private DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem mailMergeCurrentRecordItem1;
        private DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit repositoryItemMailMergeCurrentRecordEdit2;
        private DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem8;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem13;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem14;
        private DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem15;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory headerFooterToolsRibbonPageCategory1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage headerFooterToolsDesignRibbonPage1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup headerFooterToolsDesignNavigationRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup headerFooterToolsDesignOptionsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup headerFooterToolsDesignCloseRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory tableToolsRibbonPageCategory1;
        private DevExpress.XtraRichEdit.UI.TableDesignRibbonPage tableDesignRibbonPage1;
        private DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup tableCellStylesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup tableDrawBordersRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage tableLayoutRibbonPage1;
        private DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup tableTableRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup tableRowsAndColumnsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup tableMergeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup tableCellSizeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup tableAlignmentRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory floatingPictureToolsRibbonPageCategory1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage floatingPictureToolsFormatPage1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup floatingPictureToolsShapeStylesPageGroup1;
        private DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup floatingPictureToolsArrangePageGroup1;
        private DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory dataToolsRibbonPageCategory1;
        private DevExpress.Snap.Extensions.UI.AppearanceRibbonPage appearanceRibbonPage1;
        private DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup themesRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage snMergeFieldToolsRibbonPage1;
        private DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup dataShapingRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup snMergeFieldPropertiesRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage groupToolsRibbonPage1;
        private DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup groupingRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ListToolsRibbonPage listToolsRibbonPage1;
        private DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup listHeaderAndFooterRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup listCommandsRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup listEditorRowLimitRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.MailMergeRibbonPage mailMergeRibbonPage1;
        private DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup mailMergeRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup mailMergeCurrentRecordRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup finishAndMergeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HomeRibbonPage homeRibbonPage1;
        private DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup clipboardRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.FontRibbonPageGroup fontRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup paragraphRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup stylesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup editingRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.InsertRibbonPage insertRibbonPage1;
        private DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup pagesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup tablesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup toolboxRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup linksRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup headerFooterRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TextRibbonPageGroup textRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup symbolsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage pageLayoutRibbonPage1;
        private DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup pageSetupRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup pageBackgroundRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ViewRibbonPage viewRibbonPage1;
        private DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup documentViewsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup showRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup zoomRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup viewRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup viewFieldsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ReviewRibbonPage reviewRibbonPage1;
        private DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup documentProofingRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.ReferencesRibbonPage referencesRibbonPage1;
        private DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup tableOfContentsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup captionsRibbonPageGroup1;
        private DevExpress.Snap.Extensions.SnapBarController snapBarController1;
        private DevExpress.XtraRichEdit.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private DevExpress.Snap.Extensions.UI.DataRibbonPageGroup dataRibbonPageGroup1;
        private DevExpress.XtraCharts.UI.RunDesignerChartItem runDesignerChartItem1;
        private DevExpress.XtraCharts.UI.ChartRibbonPageCategory chartRibbonPageCategory1;
        private DevExpress.XtraCharts.UI.CreateChartRibbonPage createChartRibbonPage1;
        private DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup chartTypeRibbonPageGroup1;
        private DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup chartAppearanceRibbonPageGroup1;
        private DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup chartWizardRibbonPageGroup1;
    }
}
