Imports Microsoft.VisualBasic
Imports System

Partial Public Class RangeBarSeries
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		WebChartControl1.Series(0).DataSource = SourceOfEnergy.GetEuropeBrentPrices()
		WebChartControl1.Series(1).DataSource = SourceOfEnergy.GetOkWtiPrices()
	End Sub
End Class
