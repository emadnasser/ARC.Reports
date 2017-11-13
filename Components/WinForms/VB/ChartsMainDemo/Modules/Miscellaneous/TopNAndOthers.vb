Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class TopNAndOthersDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl

		Private ReadOnly Property Options() As TopNOptions
			Get
				Return If(ChartControl.Series.Count > 0, ChartControl.Series(0).TopNOptions, Nothing)
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxMode.SelectedIndexChanged
			If Options Is Nothing Then
				Return
			End If
			Dim mode As TopNMode = CType(comboBoxMode.SelectedIndex, TopNMode)
			Options.Mode = mode
			labelValue.Text = CStr(comboBoxMode.SelectedItem) & ":"
			txtValue.Properties.BeginInit()
			Select Case mode
				Case TopNMode.Count
					txtValue.Properties.IsFloatValue = False
					txtValue.Properties.MinValue = 1
					txtValue.Properties.MaxValue = 20
					txtValue.Properties.Increment = 1
					txtValue.Properties.Mask.EditMask = "f0"
					txtValue.EditValue = Options.Count
				Case TopNMode.ThresholdValue
					txtValue.Properties.IsFloatValue = True
					txtValue.Properties.MinValue = 2000
					txtValue.Properties.MaxValue = 20000
					txtValue.Properties.Increment = 500
					txtValue.Properties.Mask.EditMask = "f0"
					txtValue.EditValue = Options.ThresholdValue
				Case TopNMode.ThresholdPercent
					txtValue.Properties.IsFloatValue = True
					txtValue.Properties.MinValue = New Decimal(1.5)
					txtValue.Properties.MaxValue = 100
					txtValue.Properties.Increment = New Decimal(0.1)
					txtValue.Properties.Mask.EditMask = "f1"
					txtValue.EditValue = Options.ThresholdPercent
				Case Else
					txtValue.Enabled = False
			End Select
			txtValue.Properties.EndInit()
		End Sub
		Private Sub txtValue_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtValue.EditValueChanged
			If Options IsNot Nothing Then
				Select Case Options.Mode
					Case TopNMode.Count
						Options.Count = Convert.ToInt32(txtValue.EditValue)
					Case TopNMode.ThresholdValue
						Options.ThresholdValue = Convert.ToDouble(txtValue.EditValue)
					Case TopNMode.ThresholdPercent
						Options.ThresholdPercent = Convert.ToDouble(txtValue.EditValue)
				End Select
			End If
		End Sub
		Private Sub checkEditShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowOthers.CheckedChanged
			If Options Is Nothing Then
				Return
			End If
			Options.ShowOthers = checkEditShowOthers.Checked
			If Options.ShowOthers Then
				labelOthersArgument.Enabled = True
				txtOthersArgument.Enabled = True
				If String.IsNullOrEmpty(Options.OthersArgument) Then
					txtOthersArgument.EditValue = "Others"
				Else
					txtOthersArgument.EditValue = Options.OthersArgument
				End If
			Else
				labelOthersArgument.Enabled = False
				txtOthersArgument.Enabled = False
			End If
		End Sub
		Private Sub txtOthersArgument_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtOthersArgument.EditValueChanged
			If Options IsNot Nothing Then
				Options.OthersArgument = CStr(txtOthersArgument.EditValue)
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			chart.DataSource = dS21.Countries
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
			comboBoxMode.SelectedIndex = 0
			If chart.Series.Count > 0 Then
				checkEditShowOthers.Checked = chart.Series(0).TopNOptions.ShowOthers
			End If
			ShowLabels = True
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Options IsNot Nothing Then
				comboBoxMode.SelectedIndex = CInt(Fix(Options.Mode))
				checkEditShowOthers.Checked = Options.ShowOthers
				txtOthersArgument.EditValue = Options.OthersArgument
			End If
		End Sub
	End Class
End Namespace
