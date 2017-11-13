Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class DateTime_DateEditor
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		dateEdit.TimeSectionProperties.Visible = chkShowTimeSection.Checked
		dateEdit.UseMaskBehavior = chkMaskBehavior.Checked
		dateEdit.EditFormatString = GetFormatString(cbDateEditFormatString.Value)
		dateEdit.DisplayFormatString = GetFormatString(cbDateDisplayFormatString.Value)
	End Sub
	Protected Function GetFormatString(ByVal value As Object) As String
		Return If(value Is Nothing, String.Empty, value.ToString())
	End Function
End Class
