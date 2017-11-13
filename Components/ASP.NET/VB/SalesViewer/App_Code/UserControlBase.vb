Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DataAccess
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Public Interface IRangeControl
    Function GetStartDate() As Date
    Function GetEndDate() As Date
End Interface

Public Class UserControlBase
    Inherits UserControl

    Protected Function GetSalesStartDate() As Date
        Return (TryCast(Page, BasePage)).SalesStartDate
    End Function
    Protected Function GetSalesEndDate() As Date
        Return (TryCast(Page, BasePage)).SalesEndDate
    End Function
    Protected ReadOnly Property SalesProvider() As SalesProvider
        Get
            Return (TryCast(Page, BasePage)).SalesProvider
        End Get
    End Property
End Class

Public MustInherit Class ChartControlBase
    Inherits UserControlBase

    Public Property Title() As String

    Protected MustOverride ReadOnly Property WebChartControl() As WebChartControl

    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)
        PaletteHelper.LoadCommonPalette(WebChartControl)
    End Sub
End Class

Public MustInherit Class SimpleChartControlBase
    Inherits ChartControlBase

    Public Property SubTitle() As String

    Public Property Width() As Unit
        Get
            Return WebChartControl.Width
        End Get
        Set(ByVal value As Unit)
            WebChartControl.Width = value
        End Set
    End Property
    Public Property Height() As Unit
        Get
            Return WebChartControl.Height
        End Get
        Set(ByVal value As Unit)
            WebChartControl.Height = value
        End Set
    End Property
    Public Overridable Property ShowLegend() As Boolean
    Protected Property ChartData() As ChartData()

    Public Sub SetData(ByVal data As IEnumerable(Of ChartData))
        ChartData = data.ToArray()
        WebChartControl.DataSource = data
        WebChartControl.DataBind()
        AfterSetData(data)
    End Sub

    Protected Overridable Sub AfterSetData(ByVal data As IEnumerable(Of ChartData))
    End Sub

    Public Function GetPointName(ByVal index As Integer) As String
        If ChartData IsNot Nothing AndAlso index >= 0 AndAlso index < ChartData.Length Then
            Return ChartData(index).PointName
        End If
        Return ""
    End Function
End Class

Public MustInherit Class VerticalChartControlBase
    Inherits ChartControlBase

    Public Property CurrentValue() As Double
    Public Property PreviousValue() As Double
    Public Property CustomPeriodValue() As Double
    Public Property CurrentSeriesName() As String
    Public Property PreviousSeriesName() As String
    Public Event RangeSelectionChanged As EventHandler(Of EventArgs)

    Public MustOverride Sub SetChartData(ByVal current As List(Of ChartData), ByVal previous As List(Of ChartData))
    Public MustOverride Function GetSelectedDate() As Date
    Protected Sub RaiseRangeSelectionChanged()
        RaiseEvent RangeSelectionChanged(Me, New EventArgs())
    End Sub
End Class
