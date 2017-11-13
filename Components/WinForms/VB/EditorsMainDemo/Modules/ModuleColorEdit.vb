Imports System.Collections
Imports System.ComponentModel
' <icbColorAlignment>
Imports DevExpress.Utils
' <icbColorText>
Imports DevExpress.XtraEditors.Controls
' </icbColorText>
' </icbColorAlignment>


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleColorEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleColorEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "coloredit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleColorEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(colorEditSample)
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitComboBoxes()
			' <icbColorText>
			icbColorText.Properties.Items.AddEnum(GetType(ColorText))
			' </icbColorText>
			' <icbColorAlignment>
			icbColorAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
			' </icbColorAlignment>
		End Sub

		Private Sub InitValues()
			updateValues = True
			icbColorAlignment.EditValue = colorEditSample.Properties.ColorAlignment
			icbColorText.EditValue = colorEditSample.Properties.ColorText
			ceShowColorDialog.Checked = colorEditSample.Properties.ShowColorDialog
			ceAsInteger.Checked = colorEditSample.Properties.StoreColorAsInteger
			updateValues = False
		End Sub

		' <icbColorAlignment>
		Private Sub icbColorAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbColorAlignment.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.ColorAlignment = CType(icbColorAlignment.EditValue, HorzAlignment)
		End Sub
		' </icbColorAlignment>

		' <icbColorText>
		Private Sub icbColorText_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbColorText.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.ColorText = CType(icbColorText.EditValue, ColorText)
		End Sub
		' </icbColorText>

		' <ceShowColorDialog>
		Private Sub ceShowColorDialog_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowColorDialog.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.ShowColorDialog = ceShowColorDialog.Checked
		End Sub
		' </ceShowColorDialog>

		' <ceAsInteger>
		Private Sub ceIsInteger_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAsInteger.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			colorEditSample.Properties.StoreColorAsInteger = ceAsInteger.Checked
		End Sub
		' </ceAsInteger>

		Private Sub SetButtonEnabled(ByVal enabled As Boolean)
			seAdd.Enabled = enabled
			seClear.Enabled = Not enabled
		End Sub

		' <seAdd>
		' <seClear>
		Private Function GetColorArray(ByVal empty As Boolean) As Color()
			Dim rnd As New Random()
			Dim ret(colorEditSample.Properties.CustomColors.Length - 1) As Color
			For i As Integer = 0 To ret.Length - 1
				ret.SetValue((If(empty, Color.Empty, Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)))), i)
			Next i
			Return ret
		End Function
		' </seClear>

		Private Sub seAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles seAdd.Click
			colorEditSample.Properties.CustomColors = GetColorArray(False)
			SetButtonEnabled(False)
		End Sub
		' </seAdd>

		' <seClear>
		Private Sub seClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles seClear.Click
			colorEditSample.Properties.CustomColors = GetColorArray(True)
			SetButtonEnabled(True)
		End Sub
		' </seClear>
	End Class
End Namespace

