Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ResolveOverlappingAxisLabel
	Inherits ChartBasePage
	Private ReadOnly Property AxisLabel() As AxisLabel
		Get
			Return (CType(WebChartControl.Diagram, XYDiagram)).AxisX.Label
		End Get
	End Property
	Private Property ResolveOverlappingEnabled() As Boolean
		Get
			If AxisLabel IsNot Nothing Then
				Return AxisLabel.ResolveOverlappingOptions.AllowHide AndAlso AxisLabel.ResolveOverlappingOptions.AllowRotate AndAlso AxisLabel.ResolveOverlappingOptions.AllowStagger
			End If
			Return False
		End Get
		Set(ByVal value As Boolean)
			AxisLabel.ResolveOverlappingOptions.AllowHide = value
			AxisLabel.ResolveOverlappingOptions.AllowRotate = value
			AxisLabel.ResolveOverlappingOptions.AllowStagger = value
		End Set
	End Property

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl
	End Function
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxCheckBoxResolveOverlapping.Checked = ResolveOverlappingEnabled
			ASPxSpinEditIndent.MinValue = -10
			ASPxSpinEditIndent.MaxValue = 30
			ASPxSpinEditIndent.Value = AxisLabel.ResolveOverlappingOptions.MinIndent
		End If
		lblIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked
		ASPxSpinEditIndent.ClientEnabled = ASPxCheckBoxResolveOverlapping.Checked
	End Sub
	Protected Sub WebChartControl_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "custom" Then
			If ASPxCheckBoxResolveOverlapping.Checked Then
				ResolveOverlappingEnabled = True
			Else
				ResolveOverlappingEnabled = False
			End If
			AxisLabel.ResolveOverlappingOptions.MinIndent = Convert.ToInt32(ASPxSpinEditIndent.Number)
		End If
	End Sub
End Class

