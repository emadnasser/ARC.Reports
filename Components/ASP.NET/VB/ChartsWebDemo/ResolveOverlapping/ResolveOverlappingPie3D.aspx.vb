Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ResolveOverlappingPie3D
	Inherits ChartBasePage
	Private ReadOnly Property Label() As SeriesLabelBase
		Get
			Return WebChartControl.Series(0).Label
		End Get
	End Property

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl
	End Function
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxCheckBoxResolveOverlapping.Checked = Label.ResolveOverlappingMode <> ResolveOverlappingMode.None
			ASPxSpinEditIndent.MinValue = -10
			ASPxSpinEditIndent.MaxValue = 10
			ASPxSpinEditIndent.Value = Label.ResolveOverlappingMinIndent
		End If
		lblIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked
		ASPxSpinEditIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked
	End Sub
	Protected Sub WebChartControl_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "custom" Then
			If ASPxCheckBoxResolveOverlapping.Checked Then
				Label.ResolveOverlappingMode = ResolveOverlappingMode.Default
			Else
				Label.ResolveOverlappingMode = ResolveOverlappingMode.None
			End If
			Label.ResolveOverlappingMinIndent = Convert.ToInt32(ASPxSpinEditIndent.Number)
		End If
	End Sub
End Class

