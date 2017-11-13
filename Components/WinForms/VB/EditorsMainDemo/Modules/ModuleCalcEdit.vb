Imports System.Collections
Imports System.ComponentModel
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
' </ceShowCustomButtons>
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleCalcEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleCalcEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "calcedit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleCalcEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(calcEditSample)
			InitValues()
		End Sub

		Private Sub InitValues()
			updateValues = True
			sePrecision.Value = calcEditSample.Properties.Precision
			ceShowCloseButton.Checked = calcEditSample.Properties.ShowCloseButton
			ShowCustomButtons(ceShowCustomButtons.Checked)
			updateValues = False
		End Sub

		' <sePrecision>
		Private Sub sePrecision_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sePrecision.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			calcEditSample.Properties.Precision = Convert.ToInt32(sePrecision.Value)
		End Sub
		' </sePrecision>

		' <ceShowCloseButton>
		Private Sub ceShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowCloseButton.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			calcEditSample.Properties.ShowCloseButton = ceShowCloseButton.Checked
		End Sub
		' </ceShowCloseButton>

		' <calcEditSample>
		Private Sub calcEditSample_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles calcEditSample.ButtonClick
			If e.Button.Tag Is Nothing Then
				Return
			End If
			Select Case e.Button.Tag.ToString()
				Case "involution2"
					Try
						calcEditSample.Value *= calcEditSample.Value
					Catch ex As Exception
						DevExpress.XtraEditors.XtraMessageBox.Show(Me.FindForm(), ex.Message, "Error")
					End Try
				Case "clear"
					calcEditSample.Value = 0

			End Select
		End Sub
		' </calcEditSample>

		' <ceShowCustomButtons>
		Private Sub ceShowCustomButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowCustomButtons.CheckedChanged
			ShowCustomButtons(ceShowCustomButtons.Checked)
		End Sub

		Private Sub ShowCustomButtons(ByVal show As Boolean)
			For Each button As EditorButton In calcEditSample.Properties.Buttons
				If button.Tag IsNot Nothing Then
					button.Visible = show
				End If
			Next button
		End Sub
		' </ceShowCustomButtons>
	End Class
End Namespace

