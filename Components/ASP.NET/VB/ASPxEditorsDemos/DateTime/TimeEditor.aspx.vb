Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class DateTime_TimeEditor
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim values As Array = System.Enum.GetValues(GetType(EditFormat))
			For Each value As Object In values
				cbTimeEditFormat.Items.Add(System.Enum.GetName(GetType(EditFormat), CInt(Fix(value))))
			Next value
			cbTimeEditFormat.Value = EditFormat.Custom.ToString()
		End If
		Dim currentTimeEditFormat As EditFormat = CType(cbTimeEditFormat.SelectedIndex, EditFormat)

		If System.Enum.Equals(currentTimeEditFormat, EditFormat.Custom) Then
			cbTimeEditFormatString.ClientEnabled = True
			timeEdit.EditFormatString = GetFormatString(cbTimeEditFormatString.Value)
		Else
			cbTimeEditFormatString.SelectedIndex = 0
			cbTimeEditFormatString.ClientEnabled = False
			timeEdit.EditFormatString = String.Empty
			timeEdit.EditFormat = currentTimeEditFormat
		End If

		timeEdit.DisplayFormatString = GetFormatString(cbTimeDisplayFormatString.Value)
		timeEdit.AllowNull = chkTimeAllowNull.Checked
	End Sub

	Protected Function GetFormatString(ByVal value As Object) As String
		Return If(value Is Nothing, String.Empty, value.ToString())
	End Function
End Class
