Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI.WebControls
Imports DataAccess
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class DoughnutChart
    Inherits SimpleChartControlBase

    Public Property TopCenter() As Unit
    Private privateDataSourceLength As Integer
    Public Property DataSourceLength() As Integer
        Get
            Return privateDataSourceLength
        End Get
        Private Set(ByVal value As Integer)
            privateDataSourceLength = value
        End Set
    End Property
    Public Overrides Property ShowLegend() As Boolean
        Get
            Return LegendHolder.Visible
        End Get
        Set(ByVal value As Boolean)
            LegendHolder.Visible = value
        End Set
    End Property

    Protected Overrides ReadOnly Property WebChartControl() As WebChartControl
        Get
            Return ChartControl
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If TopCenter.IsEmpty Then
            TopCenter = Unit.Pixel(131)
        End If
    End Sub

    Protected Overrides Sub AfterSetData(ByVal data As IEnumerable(Of ChartData))
        DataSourceLength = data.Count()
    End Sub
End Class
