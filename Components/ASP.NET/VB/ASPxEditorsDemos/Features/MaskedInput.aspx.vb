Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Features_MaskedInput
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		txtZip.MaskSettings.PromptChar = cmbPromtChar.SelectedItem.Value.ToString().Chars(0)
		dateEdit.EditFormatString = cmbDateType.SelectedItem.Value.ToString()
		dateEdit.Value = DateTime.Now
	End Sub
End Class
