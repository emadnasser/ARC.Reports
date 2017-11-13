Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.XtraSpreadsheet.Commands
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ToolboxDemo
    Public Class ToolboxDataKey
        Public Sub New(ByVal id As SpreadsheetCommandId, ByVal type As ChartType)
            Me.Id = id
            ChartType = type
        End Sub
        Private privateId As SpreadsheetCommandId
        Public Property Id() As SpreadsheetCommandId
            Get
                Return privateId
            End Get
            Private Set(ByVal value As SpreadsheetCommandId)
                privateId = value
            End Set
        End Property
        Private privateChartType As ChartType
        Public Property ChartType() As ChartType
            Get
                Return privateChartType
            End Get
            Private Set(ByVal value As ChartType)
                privateChartType = value
            End Set
        End Property
    End Class
    Public NotInheritable Class ToolboxData

        Private Sub New()
        End Sub

        Private Shared chartColumnData As Dictionary(Of ToolboxDataKey, String) = GetChartColumnData()
        Private Shared chartBarData As Dictionary(Of ToolboxDataKey, String) = GetChartBarData()
        Private Shared chartAreaData As Dictionary(Of ToolboxDataKey, String) = GetChartAreaData()
        Private Shared Function GetChartColumnData() As Dictionary(Of ToolboxDataKey, String)
            Dim data As New Dictionary(Of ToolboxDataKey, String)()
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnClustered2D, ChartType.ColumnClustered)) = "2D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnPercentStacked2D, ChartType.ColumnFullStacked)) = "2D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnStacked2D, ChartType.ColumnStacked)) = "2D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumn3D, ChartType.Column3DStandard)) = "3D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnClustered3D, ChartType.Column3DClustered)) = "3D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnPercentStacked3D, ChartType.Column3DFullStacked)) = "3D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartColumnStacked3D, ChartType.Column3DStacked)) = "3D Column"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinder, ChartType.Column3DStandardCylinder)) = "Cylinder"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinderClustered, ChartType.Column3DClusteredCylinder)) = "Cylinder"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinderPercentStacked, ChartType.Column3DFullStackedCylinder)) = "Cylinder"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartCylinderStacked, ChartType.Column3DStackedCylinder)) = "Cylinder"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartCone, ChartType.Column3DStandardCone)) = "Cone"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartConeClustered, ChartType.Column3DClusteredCone)) = "Cone"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartConePercentStacked, ChartType.Column3DFullStackedCone)) = "Cone"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartConeStacked, ChartType.Column3DStackedCone)) = "Cone"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramid, ChartType.Column3DStandardPyramid)) = "Pyramid"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramidClustered, ChartType.Column3DClusteredPyramid)) = "Pyramid"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramidPercentStacked, ChartType.Column3DFullStackedPyramid)) = "Pyramid"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartPyramidStacked, ChartType.Column3DStackedPyramid)) = "Pyramid"
            Return data
        End Function
        Private Shared Function GetChartBarData() As Dictionary(Of ToolboxDataKey, String)
            Dim data As New Dictionary(Of ToolboxDataKey, String)()
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartBarPercentStacked2D, ChartType.BarFullStacked)) = "2D Bar"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartBarClustered2D, ChartType.BarClustered)) = "2D Bar"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartBarStacked2D, ChartType.BarStacked)) = "2D Bar"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartBarPercentStacked3D, ChartType.Bar3DFullStacked)) = "3D Bar"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartBarClustered3D, ChartType.Bar3DClustered)) = "3D Bar"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartBarStacked3D, ChartType.Bar3DStacked)) = "3D Bar"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartHorizontalCylinderClustered, ChartType.Bar3DClusteredCylinder)) = "Cylinder"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartHorizontalCylinderPercentStacked, ChartType.Bar3DFullStackedCylinder)) = "Cylinder"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartHorizontalCylinderStacked, ChartType.Bar3DStackedCylinder)) = "Cylinder"
            Return data
        End Function
        Private Shared Function GetChartAreaData() As Dictionary(Of ToolboxDataKey, String)
            Dim data As New Dictionary(Of ToolboxDataKey, String)()
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartArea, ChartType.Area)) = "2D Area"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartPercentStackedArea, ChartType.AreaFullStacked)) = "2D Area"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartStackedArea, ChartType.AreaStacked)) = "2D Area"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartArea3D, ChartType.Area3D)) = "3D Area"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartPercentStackedArea3D, ChartType.Area3DFullStacked)) = "3D Area"
            data(New ToolboxDataKey(SpreadsheetCommandId.InsertChartStackedArea3D, ChartType.Area3DStacked)) = "3D Area"
            Return data
        End Function
        Public Shared ReadOnly Property ChartColumn() As Dictionary(Of ToolboxDataKey, String)
            Get
                Return chartColumnData
            End Get
        End Property
        Public Shared ReadOnly Property ChartBar() As Dictionary(Of ToolboxDataKey, String)
            Get
                Return chartBarData
            End Get
        End Property
        Public Shared ReadOnly Property ChartArea() As Dictionary(Of ToolboxDataKey, String)
            Get
                Return chartAreaData
            End Get
        End Property
    End Class
End Namespace
