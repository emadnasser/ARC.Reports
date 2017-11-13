Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class Menu_Features
	Inherits Page
	Private ReadOnly Property CurrentRepeatDirection() As RepeatDirection
		Get
			Return CType(System.Enum.Parse(GetType(RepeatDirection), ddlRepeatDirection.SelectedItem.Value.ToString()), RepeatDirection)
		End Get
	End Property

	Protected Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs)
		SetProperties()
	End Sub

	Protected Sub ddlRepeatDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		SetProperties()
	End Sub

	Protected Sub SetProperties()
		Dim result As Integer = 0

		lblColumnCountError.Visible = (Not Integer.TryParse(tbColumnCount.Text, result)) OrElse result < 0
		If (Not lblColumnCountError.Visible) Then
			 smpMain.ColumnCount = CByte(result)
		End If

		lblMaximumDisplayLevelsError.Visible = (Not Integer.TryParse(tbMaximumDisplayLevels.Text, result)) OrElse result < 0
		If (Not lblMaximumDisplayLevelsError.Visible) Then
			smpMain.MaximumDisplayLevels = result
		End If

		smpMain.RepeatDirection = CurrentRepeatDirection
	End Sub
End Class
