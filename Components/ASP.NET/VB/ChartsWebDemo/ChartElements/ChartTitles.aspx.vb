Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.XtraCharts

Partial Public Class Miscellaneous_ChartTitles
	Inherits ChartBasePage
	Private Const selectedTitleIndexKey As String = "SelectedTitleIndex"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim random As New Random()
			For i As Integer = 0 To 39
				WebChartControl1.Series(0).Points.Add(New SeriesPoint(i, New Double() { random.NextDouble() + 1}))
			Next i
			Dim selectedTitleIndex As Integer = 0
			Page.Session(selectedTitleIndexKey) = selectedTitleIndex
			cmbAlignment.SelectedIndex = CInt(Fix(WebChartControl1.Titles(selectedTitleIndex).Alignment))
			cmbDock.SelectedIndex = CInt(Fix(WebChartControl1.Titles(selectedTitleIndex).Dock))
			mmoText.Text = WebChartControl1.Titles(selectedTitleIndex).Text
			chbWordWrap.Checked = WebChartControl1.Titles(selectedTitleIndex).WordWrap
			WebChartControl1.SetObjectSelection(WebChartControl1.Titles(selectedTitleIndex))
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		Dim parametrs() As String = e.Parameter.Split("|"c)
		Dim selectedTitleIndex As Integer
		If parametrs.Length > 0 AndAlso parametrs(0) = "ChartTitle" Then
			selectedTitleIndex = Integer.Parse(parametrs(1))
			Page.Session(selectedTitleIndexKey) = selectedTitleIndex
			WebChartControl1.Titles(selectedTitleIndex).Alignment = CType(Integer.Parse(parametrs(2)), StringAlignment)
			WebChartControl1.Titles(selectedTitleIndex).Dock = CType(Integer.Parse(parametrs(3)), ChartTitleDockStyle)
			WebChartControl1.Titles(selectedTitleIndex).Lines = parametrs(4).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
			WebChartControl1.Titles(selectedTitleIndex).WordWrap = Boolean.Parse(parametrs(5))
		End If
		selectedTitleIndex = CInt(Fix(Page.Session(selectedTitleIndexKey)))
		If selectedTitleIndex > -1 Then
			WebChartControl1.SetObjectSelection(WebChartControl1.Titles(selectedTitleIndex))
		End If
	End Sub
	Protected Sub WebChartControl1_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
		Dim selectedTitle As ChartTitle = TryCast(e.Object, ChartTitle)
		If selectedTitle Is Nothing Then
			e.Cancel = True
		End If
		For i As Integer = 0 To WebChartControl1.Titles.Count - 1
			If selectedTitle Is WebChartControl1.Titles(i) Then
				Page.Session(selectedTitleIndexKey) = i
				Exit For
			End If
		Next i
	End Sub
	Protected Sub WebChartControl1_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
		Dim selectedTitleIndexValue As Object = Page.Session(selectedTitleIndexKey)
		If selectedTitleIndexValue IsNot Nothing Then
			Dim selectedTitleIndex As Integer = CInt(Fix(selectedTitleIndexValue))
			If selectedTitleIndex > -1 Then
				e.Properties.Add("cp_wordwrap", WebChartControl1.Titles(selectedTitleIndex).WordWrap)
			End If
		End If
	End Sub
End Class
