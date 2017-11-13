Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class TagPropertyDemo
		Inherits ChartDemoBase2D
		Private WithEvents chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property
		Public Overrides ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chart.CustomDrawSeriesPoint
			e.LegendText = CStr((CType(e.SeriesPoint.Tag, DataRowView))("OfficialName"))
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chart.BoundDataChanged
			ChartControl.Animate()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
			Dim path As String = Utils.GetRelativePath("countriesDB.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(Me.oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""countriesDB.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Try
				Me.oleDbDataAdapter1.Fill(Me.dS21)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
			chart.DataSource = dS21.Countries
		End Sub
	End Class
End Namespace
