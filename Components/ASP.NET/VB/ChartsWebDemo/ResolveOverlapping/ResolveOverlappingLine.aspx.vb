Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ResolveOverlappingLine
	Inherits ChartBasePage
	Private ReadOnly Property Label() As PointSeriesLabel
		Get
			Return CType(WebChartControl.Series(0).Label, PointSeriesLabel)
		End Get
	End Property

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl
	End Function
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			spnIndent.MinValue = -10
			spnIndent.MaxValue = 10
			spnIndent.Value = Label.ResolveOverlappingMinIndent
			Dim strings() As String = {"None", "Default", "Hide Overlapped", "Justify Around Point", "Justify All Around Point"}
			ComboBoxHelper.PrepareComboBox(cbMode, strings)
			cbMode.SelectedIndex = CInt(Fix(Label.ResolveOverlappingMode))
			spnLineLength.MaxValue = 30
			spnLineLength.MinValue = 0
			spnLineLength.Value = Label.LineLength
			spnAngle.MaxValue = 360
			spnAngle.MinValue = -360
			spnAngle.Increment = 5
			spnAngle.Value = Label.Angle
		End If
	End Sub
	Protected Sub WebChartControl_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Label.ResolveOverlappingMinIndent = Convert.ToInt32(spnIndent.Number)
		Label.ResolveOverlappingMode = CType(cbMode.SelectedIndex, ResolveOverlappingMode)
		Label.LineLength = Convert.ToInt32(spnLineLength.Number)
		Label.Angle = Convert.ToInt32(spnAngle.Number)
	End Sub
End Class

