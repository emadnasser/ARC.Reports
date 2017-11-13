Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTimeSpanEdit
		Inherits TutorialControl
		Private ReadOnly Property TimeSpanEdit() As TimeSpanEdit
			Get
				Return timeSpanEdit_Renamed
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleTimeSpanEdit.vb"
            TutorialInfo.WhatsThisXMLFile = "timespanedit.xml"
		End Sub
		Private Sub OnModuleLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			SetDisplayFormat()
			ShowValue()
		End Sub
		Private Sub OnTimeSpanEditEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles timeSpanEdit_Renamed.EditValueChanged
			ShowValue()
		End Sub
		Private Sub ShowValue()
            Dim result As String = String.Empty
            If TimeSpanEdit.EditValue IsNot Nothing Then
                result = TimeSpanEdit.EditValue.ToString()
            End If
            lbValue.Text = result
        End Sub
		' <cbEditFormat>
		Private Sub OnEditFormatChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEditFormat.SelectedIndexChanged
			SetEditFormat()
		End Sub
		Private Sub SetEditFormat()
			Dim formats() As String = { "", "dd.HH:mm:ss", "dd.HH:mm", "HH:mm:ss", "HH:mm", "mm:ss", "dd", "HH", "mm", "ss" }
			Dim index As Integer = cbEditFormat.SelectedIndex
			TimeSpanEdit.Properties.Mask.MaskType = Mask.MaskType.Custom
			TimeSpanEdit.Properties.Mask.EditMask = formats(index)
            teEditFormatString.Text = formats(index)
		End Sub
		' </cbEditFormat>
		' <cbDisplayFormat>
		Private Sub OnDisplayFormatChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDisplayFormat.SelectedIndexChanged
			SetDisplayFormat()
		End Sub
		Private Sub SetDisplayFormat()
			Dim formats() As String = { "", "{0:dd}.{0:hh}:{0:mm}:{0:ss}", "{0:dd}.{0:hh}:{0:mm}", "{0:hh}:{0:mm}:{0:ss}", "{0:hh}:{0:mm}", "{0:mm}:{0:ss}", "{0:dd} days", "{0:hh} hours", "{0:mm} minutes", "{0:ss} seconds" }
			Dim index As Integer = cbDisplayFormat.SelectedIndex
			TimeSpanEdit.Properties.DisplayFormat.FormatType = Utils.FormatType.Custom
			TimeSpanEdit.Properties.DisplayFormat.FormatString = formats(index)
            teDisplayFormatString.Text = formats(index)
		End Sub
		' </cbDisplayFormat>
		' <seMaxDays>
		Private Sub OnMaxDaysValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seMaxDays.EditValueChanged
			TimeSpanEdit.Properties.MaxDays = CInt(Fix(seMaxDays.Value))
		End Sub
		' </seMaxDays>
		' <seMaxHours>
		Private Sub OnMaxHoursValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seMaxHours.EditValueChanged
			TimeSpanEdit.Properties.MaxHours = CInt(Fix(seMaxHours.Value))
		End Sub
		' </seMaxHours>
		' <seMaxMinutes>
		Private Sub OnMaxMinutesValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seMaxMinutes.EditValueChanged
			TimeSpanEdit.Properties.MaxMinutes = CInt(Fix(seMaxMinutes.Value))
		End Sub
		' </seMaxMinutes>
		' <seMaxSeconds>
		Private Sub OnMaxSecondsValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seMaxSeconds.EditValueChanged
			TimeSpanEdit.Properties.MaxSeconds = CInt(Fix(seMaxSeconds.Value))
		End Sub
		' </seMaxSeconds>
		' <ceAllowEditDays>
		Private Sub OnAllowEditDaysChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowEditDays.CheckedChanged
			TimeSpanEdit.Properties.AllowEditDays = Not TimeSpanEdit.Properties.AllowEditDays
		End Sub
		' </ceAllowEditDays>
		' <ceAllowEditHours>
		Private Sub OnAllowEditHoursChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowEditHours.CheckedChanged
			TimeSpanEdit.Properties.AllowEditHours = Not TimeSpanEdit.Properties.AllowEditHours
		End Sub
		' </ceAllowEditHours>
		' <ceAllowEditMinutes>
		Private Sub OnAllowEditMinutesChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowEditMinutes.CheckedChanged
			TimeSpanEdit.Properties.AllowEditMinutes = Not TimeSpanEdit.Properties.AllowEditMinutes
		End Sub
		' </ceAllowEditMinutes>
		' <ceAllowEditSeconds>
		Private Sub OnAllowEditSecondsChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowEditSeconds.CheckedChanged
			TimeSpanEdit.Properties.AllowEditSeconds = Not TimeSpanEdit.Properties.AllowEditSeconds
		End Sub
		' </ceAllowEditSeconds>
		' <ceReadOnly>
		Private Sub OnReadOnlyChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceReadOnly.CheckedChanged
			TimeSpanEdit.Properties.ReadOnly = Not TimeSpanEdit.Properties.ReadOnly
			cbEditFormat.Enabled = Not cbEditFormat.Enabled
		End Sub
		' </ceReadOnly>
	End Class
End Namespace
