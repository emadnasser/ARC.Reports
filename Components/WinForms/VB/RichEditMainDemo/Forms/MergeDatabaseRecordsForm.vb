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
	Public Partial Class MergeDatabaseRecordsForm
		Inherits MergeFieldsFormBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
			MergeRecords = GetMergeRecords()
			MergeDestination = CType(Me.rgMergeTo.SelectedIndex, MergeDestination)
			Me.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()
		End Sub
		Private Function GetMergeRecords() As MergeRecords
			If Me.rgMergeRecords.SelectedIndex = 0 Then
				Return MergeRecords.Selected
			Else
				Return MergeRecords.All
			End If
		End Function
		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			Me.Close()
		End Sub
	End Class
End Namespace
