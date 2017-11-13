Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleChartRangeControlClients
		Inherits TutorialControl
		Private Const seriesCount As Integer = 3
		Private Const pointCount As Integer = 50
		Private Const valueLevelThreshold As Double = 100
		Private Const argumentColumn As String = "Argument"
		Private Const valueColumn As String = "Value"
		Private Const seriesColumn As String = "Series"

		Private ReadOnly numericDataSource As DataTable
		Private ReadOnly dateTimeDataSource As DataTable
		Private ReadOnly baseDate As DateTime

		Public Sub New()
			InitializeComponent()
			TutorialInfo.AboutFile = Nothing
			TutorialInfo.Description = ""
			TutorialInfo.TutorialName = "Chart Range Control Clients Tutorial"
			TutorialInfo.WhatsThisCodeFile = ""
			TutorialInfo.WhatsThisXMLFile = ""
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleChartRangeControlClients.vb"
            TutorialInfo.WhatsThisXMLFile = "chartRangeControlClients.xml"

			Me.numericDataSource = New DataTable()
			Me.dateTimeDataSource = New DataTable()
			Me.baseDate = DateTime.Now

			SetClientDateSource(dateTimeClient, dateTimeDataSource, GetType(DateTime))
			SetClientDateSource(numericClient, numericDataSource, GetType(Double))

			radioGroupView.SelectedIndex = 1

			InitPalettes()

			checkEditNumericAuto.Checked = True
			checkEditDateTimeAuto.Checked = True

			FillDateTimeComboBox(comboBoxDateTimeGridAlignment)
			FillDateTimeComboBox(comboBoxDateTimeSnapAlignment)
		End Sub

		Private Sub FillDateTimeComboBox(ByVal comboBox As ComboBoxEdit)
			comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Day)
			comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Week)
			comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Month)
		End Sub
		Private Function GetArgumentByIndex(ByVal argumentType As Type, ByVal index As Integer) As Object
			If argumentType Is GetType(DateTime) Then
				Return baseDate.AddDays(index * 7)
			End If
			Return CDbl(index * 10000)
		End Function
		Private Sub SetClientDateSource(ByVal client As ChartRangeControlClientBase, ByVal dataSource As DataTable, ByVal argumentType As Type)
			dataSource.Columns.Add(seriesColumn, GetType(String))
			dataSource.Columns.Add(argumentColumn, argumentType)
			dataSource.Columns.Add(valueColumn, GetType(Double))

            Dim rand As New Random(CInt(Fix(DateTime.Now.Millisecond)))

			Dim valueLevel As Double = valueLevelThreshold * seriesCount

			For seriesIndex As Integer = 0 To seriesCount - 1
				For pointIndex As Integer = 0 To pointCount - 1
					dataSource.Rows.Add("Series " & seriesIndex.ToString(), GetArgumentByIndex(argumentType, pointIndex), rand.NextDouble() * valueLevelThreshold + valueLevel)
				Next pointIndex
				valueLevel -= valueLevelThreshold
			Next seriesIndex

			client.DataProvider.SeriesDataMember = seriesColumn
			client.DataProvider.ArgumentDataMember = argumentColumn
			client.DataProvider.ValueDataMember = valueColumn
			client.DataProvider.DataSource = dataSource
		End Sub
		Private Sub InitPalettes()
			For Each paletteName As String In ChartRangeControlClientBase.PredefinedPalettes
				comboBoxPalette.Properties.Items.Add(paletteName)
			Next paletteName

			comboBoxPalette.SelectedItem = numericClient.PaletteName
		End Sub
		Private Sub SetTrackBarRange(ByVal trackBar As TrackBarControl, ByVal min As Integer, ByVal max As Integer)
			trackBar.Properties.BeginUpdate()
			trackBar.Properties.Minimum = 0
			trackBar.Properties.Maximum = Integer.MaxValue
			trackBar.Value = min
			trackBar.Properties.Minimum = min
			trackBar.Properties.Maximum = max
			trackBar.Properties.EndUpdate()
		End Sub
		Private Sub SetSpacingTrackBarRange(ByVal trackBar As TrackBarControl, ByVal alignment As RangeControlDateTimeGridAlignment)
			Select Case alignment
				Case RangeControlDateTimeGridAlignment.Day
					SetTrackBarRange(trackBar, 40, 60)
				Case RangeControlDateTimeGridAlignment.Week
					SetTrackBarRange(trackBar, 6, 12)
				Case Else
					SetTrackBarRange(trackBar, 2, 6)
			End Select
		End Sub

		' <radioGroupView>
		Private Sub radioGroupView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroupView.SelectedIndexChanged
			Dim viewType As Integer = CInt(Fix(radioGroupView.SelectedIndex))

			Dim clientView As ChartRangeControlClientView = Nothing

			Select Case viewType
				Case 0
					clientView = New LineChartRangeControlClientView()
				Case Else
					clientView = New AreaChartRangeControlClientView()
			End Select

			dateTimeClient.DataProvider.TemplateView = clientView
			numericClient.DataProvider.TemplateView = clientView
		End Sub
		' </radioGroupView>
		' <comboBoxPalette>
		Private Sub comboBoxPalette_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxPalette.SelectedIndexChanged
			Dim paletteName As String = CStr(comboBoxPalette.SelectedItem)
			numericClient.PaletteName = paletteName
			dateTimeClient.PaletteName = paletteName
		End Sub
		' </comboBoxPalette>
		' <checkEditNumericAuto>
		Private Sub checkEditNumericAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditNumericAuto.CheckedChanged
			Dim gridOptions As NumericChartRangeControlClientGridOptions = numericClient.GridOptions

			gridOptions.Auto = checkEditNumericAuto.Checked

			trackBarNumericGridSpacing.Enabled = Not gridOptions.Auto
			trackBarNumericSnapSpacing.Enabled = Not gridOptions.Auto

			If (Not gridOptions.Auto) Then
				trackBarNumericGridSpacing.Value = CInt(Fix(gridOptions.GridSpacing))
				trackBarNumericSnapSpacing.Value = CInt(Fix(gridOptions.SnapSpacing))
			End If
		End Sub
		' </checkEditNumericAuto>
		' <checkEditDateTimeAuto>
		Private Sub checkEditDateTimeAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditDateTimeAuto.CheckedChanged
			Dim gridOptions As DateTimeChartRangeControlClientGridOptions = dateTimeClient.GridOptions

			gridOptions.Auto = checkEditDateTimeAuto.Checked

			trackBarDateTimeGridSpacing.Enabled = Not gridOptions.Auto
			trackBarDateTimeSnapSpacing.Enabled = Not gridOptions.Auto
			comboBoxDateTimeGridAlignment.Enabled = Not gridOptions.Auto
			comboBoxDateTimeSnapAlignment.Enabled = Not gridOptions.Auto

			If (Not gridOptions.Auto) Then
				comboBoxDateTimeGridAlignment.SelectedItem = gridOptions.GridAlignment
				comboBoxDateTimeSnapAlignment.SelectedItem = gridOptions.SnapAlignment
				trackBarDateTimeSnapSpacing.Value = CInt(Fix(gridOptions.SnapSpacing))
				trackBarDateTimeGridSpacing.Value = CInt(Fix(gridOptions.GridSpacing))
			End If
		End Sub
		' </checkEditDateTimeAuto>
		' <trackBarNumericGridSpacing>
		Private Sub trackBarNumericGridSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarNumericGridSpacing.EditValueChanged
			numericClient.GridOptions.GridSpacing = CDbl(trackBarNumericGridSpacing.Value)
		End Sub
		' </trackBarNumericGridSpacing>
		' <trackBarNumericSnapSpacing>
		Private Sub trackBarNumericSnapSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarNumericSnapSpacing.EditValueChanged
			numericClient.GridOptions.SnapSpacing = CDbl(trackBarNumericSnapSpacing.Value)
		End Sub
		' </trackBarNumericSnapSpacing>
		' <trackBarDateTimeGridSpacing>
		Private Sub trackBarDateTimeGridSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarDateTimeGridSpacing.EditValueChanged
			dateTimeClient.GridOptions.GridSpacing = CDbl(trackBarDateTimeGridSpacing.Value)
		End Sub
		' </trackBarDateTimeGridSpacing>
		' <trackBarDateTimeSnapSpacing>
		Private Sub trackBarDateTimeSnapSpacing_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarDateTimeSnapSpacing.EditValueChanged
			dateTimeClient.GridOptions.SnapSpacing = CDbl(trackBarDateTimeSnapSpacing.Value)
		End Sub
		' </trackBarDateTimeSnapSpacing>
		' <comboBoxDateTimeGridAlignment>
		Private Sub comboBoxDateTimeGridAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxDateTimeGridAlignment.SelectedIndexChanged
			Dim alignment As RangeControlDateTimeGridAlignment = CType(comboBoxDateTimeGridAlignment.SelectedItem, RangeControlDateTimeGridAlignment)
			dateTimeClient.GridOptions.GridAlignment = alignment
			SetSpacingTrackBarRange(trackBarDateTimeGridSpacing, alignment)
		End Sub
		' </comboBoxDateTimeGridAlignment>
		' <comboBoxDateTimeSnapAlignment>
		Private Sub comboBoxDateTimeSnapAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxDateTimeSnapAlignment.SelectedIndexChanged
			Dim alignment As RangeControlDateTimeGridAlignment = CType(comboBoxDateTimeSnapAlignment.SelectedItem, RangeControlDateTimeGridAlignment)
			dateTimeClient.GridOptions.SnapAlignment = alignment
			SetSpacingTrackBarRange(trackBarDateTimeSnapSpacing, alignment)
		End Sub
		' </comboBoxDateTimeSnapAlignment>

		Private Sub trackBarNumeric_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles trackBarNumericSnapSpacing.EditValueChanging, trackBarNumericGridSpacing.EditValueChanging
			e.NewValue = Math.Round(Convert.ToDouble(e.NewValue) / 10000.0) * 10000.0
		End Sub
	End Class
End Namespace
