Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class MergeSimpleDataForm
		Inherits MergeFieldsFormBase
		Private startIndex_Renamed As Integer = 0
		Private endIndex_Renamed As Integer = -1

		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property StartIndex() As Integer
			Get
				Return Math.Min(startIndex_Renamed, endIndex_Renamed)
			End Get
		End Property
		Public ReadOnly Property EndIndex() As Integer
			Get
				Return Math.Max(startIndex_Renamed, endIndex_Renamed)
			End Get
		End Property

		Private Function GetMergeRecords() As MergeRecords
			Select Case Me.rgMergeRecords.SelectedIndex
				Case 0
					Return MergeRecords.All
				Case 1
					Return MergeRecords.Current
				Case 2
					Return MergeRecords.FromInterval
				Case Else
					Return MergeRecords.All

			End Select
		End Function
		Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
			MergeDestination = CType(Me.rgMergeTo.SelectedIndex, MergeDestination)
			MergeRecords = GetMergeRecords()
			If (Not Int32.TryParse(Me.txtFrom.Text, Me.startIndex_Renamed)) Then
				Me.startIndex_Renamed = 0
			End If
			If (Not Int32.TryParse(Me.txtTo.Text, Me.endIndex_Renamed)) Then
				Me.endIndex_Renamed = -1
			End If
			Me.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()
		End Sub
		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			Me.Close()
		End Sub
		Private Sub rgMergeRecords_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgMergeRecords.SelectedIndexChanged
			Dim isIntervalSelected As Boolean = rgMergeRecords.SelectedIndex = 2
			txtFrom.Enabled = isIntervalSelected
			txtTo.Enabled = isIntervalSelected
		End Sub
	End Class
End Namespace
