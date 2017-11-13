using DevExpress.Spreadsheet.Charts;
using DevExpress.XtraSpreadsheet.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxDemo {
    public class ToolboxDataKey {
        public ToolboxDataKey(SpreadsheetCommandId id, ChartType type) {
            Id = id;
            ChartType = type;
        }
        public SpreadsheetCommandId Id { get; private set; }
        public ChartType ChartType { get; private set; }
    }
    public static class ToolboxData {
        static Dictionary<ToolboxDataKey, string> chartColumnData = GetChartColumnData();
        static Dictionary<ToolboxDataKey, string> chartBarData = GetChartBarData();
        static Dictionary<ToolboxDataKey, string> chartAreaData = GetChartAreaData();
        static Dictionary<ToolboxDataKey, string> GetChartColumnData() {
            Dictionary<ToolboxDataKey, string> data = new Dictionary<ToolboxDataKey, string>();
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnClustered2D, ChartType.ColumnClustered)] = "2D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnPercentStacked2D, ChartType.ColumnFullStacked)] = "2D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnStacked2D, ChartType.ColumnStacked)] = "2D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumn3D, ChartType.Column3DStandard)] = "3D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnClustered3D, ChartType.Column3DClustered)] = "3D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnPercentStacked3D, ChartType.Column3DFullStacked)] = "3D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnStacked3D, ChartType.Column3DStacked)] = "3D Column";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinder, ChartType.Column3DStandardCylinder)] = "Cylinder";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinderClustered, ChartType.Column3DClusteredCylinder)] = "Cylinder";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinderPercentStacked, ChartType.Column3DFullStackedCylinder)] = "Cylinder";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinderStacked, ChartType.Column3DStackedCylinder)] = "Cylinder";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartCone, ChartType.Column3DStandardCone)] = "Cone";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartConeClustered, ChartType.Column3DClusteredCone)] = "Cone";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartConePercentStacked, ChartType.Column3DFullStackedCone)] = "Cone";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartConeStacked, ChartType.Column3DStackedCone)] = "Cone";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramid, ChartType.Column3DStandardPyramid)] = "Pyramid";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramidClustered, ChartType.Column3DClusteredPyramid)] = "Pyramid";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramidPercentStacked, ChartType.Column3DFullStackedPyramid)] = "Pyramid";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramidStacked, ChartType.Column3DStackedPyramid)] = "Pyramid";
            return data;
        }
        static Dictionary<ToolboxDataKey, string> GetChartBarData() {
            Dictionary<ToolboxDataKey, string> data = new Dictionary<ToolboxDataKey, string>();
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartBarPercentStacked2D, ChartType.BarFullStacked)] = "2D Bar";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartBarClustered2D, ChartType.BarClustered)] = "2D Bar";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartBarStacked2D, ChartType.BarStacked)] = "2D Bar";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartBarPercentStacked3D, ChartType.Bar3DFullStacked)] = "3D Bar";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartBarClustered3D, ChartType.Bar3DClustered)] = "3D Bar";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartBarStacked3D, ChartType.Bar3DStacked)] = "3D Bar";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartHorizontalCylinderClustered, ChartType.Bar3DClusteredCylinder)] = "Cylinder";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartHorizontalCylinderPercentStacked, ChartType.Bar3DFullStackedCylinder)] = "Cylinder";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartHorizontalCylinderStacked, ChartType.Bar3DStackedCylinder)] = "Cylinder";
            return data;
        }
        static Dictionary<ToolboxDataKey, string> GetChartAreaData() {
            Dictionary<ToolboxDataKey, string> data = new Dictionary<ToolboxDataKey, string>();
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartArea, ChartType.Area)] = "2D Area";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartPercentStackedArea, ChartType.AreaFullStacked)] = "2D Area";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartStackedArea, ChartType.AreaStacked)] = "2D Area";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartArea3D, ChartType.Area3D)] = "3D Area";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartPercentStackedArea3D, ChartType.Area3DFullStacked)] = "3D Area";
            data[new ToolboxDataKey(SpreadsheetCommandId.InsertChartStackedArea3D, ChartType.Area3DStacked)] = "3D Area";
            return data;
        }
        public static Dictionary<ToolboxDataKey, string> ChartColumn { get { return chartColumnData; } }
        public static Dictionary<ToolboxDataKey, string> ChartBar { get { return chartBarData; } }
        public static Dictionary<ToolboxDataKey, string> ChartArea { get { return chartAreaData; } }
    }
}
