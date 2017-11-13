Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class Features_DateTimeEditing
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		dateEdit.TimeSectionProperties.Visible = chkShowTimeSection.Checked
		dateEdit.UseMaskBehavior = chkMaskBehavior.Checked
		dateEdit.EditFormatString = GetFormatString(cbDateEditFormatString.Value)
		dateEdit.DisplayFormatString = GetFormatString(cbDateDisplayFormatString.Value)

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
	End Sub

	Protected Function GetFormatString(ByVal value As Object) As String
		Return If(value Is Nothing, String.Empty, value.ToString())
	End Function
End Class
