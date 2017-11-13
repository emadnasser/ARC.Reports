Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts.Web

Partial Public Class TrendIndicators
	Inherits ChartBasePage
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
