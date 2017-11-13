Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class TopNOptions
	Inherits ChartBasePage
	Private Const optionsKey As String = "Options"
	Private Const labelVisibleKey As String = "LabelVisible"
	Private Const minValueKey As String = "Min"
	Private Const maxValueKey As String = "Max"
	Private Const valueKey As String = "Value"

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property Options() As DevExpress.XtraCharts.TopNOptions
		Get
			Return Series.TopNOptions
		End Get
	End Property
	Private ReadOnly Property Label() As SeriesLabelBase
		Get
			Return Series.Label
		End Get
	End Property

	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
	Private Sub SaveState()
		Session(optionsKey) = Options
		Session(labelVisibleKey) = Series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
	End Sub
	Private Sub LoadState()
		Dim options = CType(Session(optionsKey), DevExpress.XtraCharts.TopNOptions)
		If options IsNot Nothing Then
			Me.Options.Assign(options)
		End If
		Series.LabelsVisibility = If(CBool(Session(labelVisibleKey)), DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			LoadState()
		Else
			cbMode.Value = Options.Mode
			SaveState()
			UpdateControls()
		End If
		UpdateEnabledState()
		UpdateValueLabel()
	End Sub
	Protected Sub seEditValueInit(ByVal sender As Object, ByVal e As EventArgs)
		Dim spinEdit As ASPxSpinEdit = TryCast(sender, ASPxSpinEdit)
		If spinEdit IsNot Nothing AndAlso IsPostBack Then
			spinEdit.MinValue = Convert.ToDecimal(Session(minValueKey))
			spinEdit.MaxValue = Convert.ToDecimal(Session(maxValueKey))
		End If
	End Sub

	Protected Sub callbackPanel_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		Select Case e.Parameter
			Case "Mode"
				Options.Mode = CType(ComboBoxHelper.GetSelectedItem(cbMode, GetType(TopNMode)), TopNMode)
			Case "Value"
				If editValueHiddenField.Contains(valueKey) Then
					Dim value As Object = editValueHiddenField.Get(valueKey)
					Select Case Options.Mode
						Case TopNMode.Count
							Options.Count = Convert.ToInt32(value)
						Case TopNMode.ThresholdValue
							Options.ThresholdValue = Convert.ToDouble(value)
						Case TopNMode.ThresholdPercent
							Options.ThresholdPercent = Convert.ToDouble(value)
					End Select
				End If
			Case "ShowOthers"
				Options.ShowOthers = cbShowOthers.Checked
			Case "OthersArgument"
				Options.OthersArgument = CStr(txtOthersArgument.Value)
			Case "Label"
				Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		End Select
		SaveState()
		UpdateControls()
		UpdateEnabledState()
	End Sub
	Private Sub UpdateControls()
		Select Case Options.Mode
			Case TopNMode.Count
				editValue.NumberType = DevExpress.Web.SpinEditNumberType.Integer
				editValue.Value = Options.Count
				editValue.MinValue = 1
				editValue.MaxValue = 20
				editValue.Increment = 1
			Case TopNMode.ThresholdValue
				editValue.NumberType = DevExpress.Web.SpinEditNumberType.Float
				editValue.Value = Options.ThresholdValue
				editValue.MinValue = 2000
				editValue.MaxValue = 20000
				editValue.Increment = 500
			Case TopNMode.ThresholdPercent
				editValue.NumberType = DevExpress.Web.SpinEditNumberType.Float
				editValue.Value = Options.ThresholdPercent
				editValue.MinValue = New Decimal(1.5)
				editValue.MaxValue = 100
				editValue.Increment = New Decimal(0.1)
			Case Else
				lblValue.Enabled = False
				editValue.Enabled = False
				Return
		End Select
		Session(minValueKey) = editValue.MinValue
		Session(maxValueKey) = editValue.MaxValue
		cbShowOthers.Checked = Options.ShowOthers
		txtOthersArgument.Value = If(String.IsNullOrEmpty(Options.OthersArgument), "Others", Options.OthersArgument)
		cbShowLabels.Checked = Series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
	End Sub
	Private Sub UpdateEnabledState()
		lblOthersArgument.ClientEnabled = Options.ShowOthers
		txtOthersArgument.ClientEnabled = Options.ShowOthers
	End Sub
	Private Sub UpdateValueLabel()
		lblValue.Text = cbMode.Text & ":"
	End Sub
End Class
