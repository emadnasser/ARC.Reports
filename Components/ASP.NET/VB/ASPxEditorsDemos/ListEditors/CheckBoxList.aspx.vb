Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class ListEditors_CheckBoxList
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		checkBoxList.RepeatLayout = CType(System.Enum.Parse(GetType(RepeatLayout), cmbRepeatLayout.Text), RepeatLayout)
		checkBoxList.RepeatDirection = CType(System.Enum.Parse(GetType(RepeatDirection), cmbDirection.Text), RepeatDirection)
		checkBoxList.RepeatColumns = CInt(Fix(spnColumnCount.Number))
	End Sub
End Class
