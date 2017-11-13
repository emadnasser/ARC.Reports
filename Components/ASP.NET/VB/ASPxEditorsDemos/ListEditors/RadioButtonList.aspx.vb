Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class ListEditors_RadioButtonList
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		radioButtonList.RepeatLayout = CType(System.Enum.Parse(GetType(RepeatLayout), cmbRepeatLayout.Text), RepeatLayout)
		radioButtonList.RepeatDirection = CType(System.Enum.Parse(GetType(RepeatDirection), cmbDirection.Text), RepeatDirection)
		radioButtonList.RepeatColumns = CInt(Fix(spnColumnCount.Number))
	End Sub
End Class
