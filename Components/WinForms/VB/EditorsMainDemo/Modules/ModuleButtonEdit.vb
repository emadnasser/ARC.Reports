Imports System.Collections
Imports System.ComponentModel
' <comboBoxTextEditStyle>
Imports DevExpress.XtraEditors.Controls
' </comboBoxTextEditStyle>
Imports DevExpress.XtraTab
Imports DevExpress.XtraEditors
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleButtonEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleButtonEdit.vb;VB\EditorsMainDemo\Modules\ButtonProperties.vb"
			TutorialInfo.WhatsThisXMLFile = "buttonedit.xml"
		End Sub

		Private Sub ModuleButtonEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(buttonEditSample)
			InitValues()
			InitButtonProperties()
		End Sub

		Private updateValues As Boolean = False
		Private editorsNames() As String = {"Text Edit", "Button Edit", "Spin Edit", "Check Edit", "ComboBox Edit", "ImageComboBox Edit", "Date Edit", "Calc Edit", "Color Edit", "MemoEx Edit", "Image Edit", "Memo Edit", "Picture Edit", "ProgressBar Control", "LookUp Edit", "PopupContainer Edit", "Radio Group", "Time Edit", "HyperLink Edit", "MRU Edit"}

		Private Sub InitValues()
			updateValues = True
			comboBoxTextEditStyle.Text = buttonEditSample.Properties.TextEditStyle.ToString()
			SetCustomValue(0, buttonEdit1)
			updateValues = False
		End Sub

		Private Sub InitButtonProperties()
			For Each button As EditorButton In buttonEditSample.Properties.Buttons
				Dim page As New XtraTabPage()
				page.Text = String.Format("Button #{0}", buttonEditSample.Properties.Buttons.IndexOf(button) + 1)
				Dim pr As New ButtonProperties(button)
				pr.Dock = DockStyle.Fill
				page.Controls.Add(pr)
				xtraTabControlButtons.TabPages.Add(page)
			Next button
		End Sub

		' <comboBoxTextEditStyle>
		Private Sub comboBoxTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxTextEditStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim styles() As TextEditStyles = { TextEditStyles.Standard, TextEditStyles.HideTextEditor, TextEditStyles.DisableTextEditor }
			buttonEditSample.Properties.TextEditStyle = styles(comboBoxTextEditStyle.SelectedIndex)
		End Sub
		' </comboBoxTextEditStyle>

		' <buttonEdit1>
		Private Sub ShowEvent(ByVal eventString As String, ByVal button As EditorButton)
			meFiringEvents.Text = String.Format("{0}: {1}" & vbCrLf, eventString, button.Tag) & meFiringEvents.Text
		End Sub

		Private Sub buttonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit4.ButtonClick, buttonEdit3.ButtonClick, buttonEdit2.ButtonClick, buttonEdit1.ButtonClick
			ShowEvent("ButtonClick", e.Button)
		End Sub
		' </buttonEdit1>

		Private Sub buttonEdit_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit4.ButtonPressed, buttonEdit3.ButtonPressed, buttonEdit2.ButtonPressed
			ShowEvent("ButtonPressed", e.Button)
		End Sub

		' <buttonEdit1>
		Private Sub buttonEdit1_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.ButtonPressed
			buttonEdit_ButtonPressed(sender, e)
			Dim edit As ButtonEdit = TryCast(sender, ButtonEdit)
			Select Case edit.Properties.Buttons.IndexOf(e.Button)
				Case 0
					SetCustomValue(customIndex - 1, edit)
				Case 1
					SetCustomValue(customIndex + 1, edit)
			End Select
		End Sub

		Private customIndex As Integer = 0
		Private Sub SetCustomValue(ByVal index As Integer, ByVal edit As ButtonEdit)
			If index < 0 OrElse index > editorsNames.Length - 1 Then
				Return
			End If
			customIndex = index
			edit.EditValue = editorsNames(index)
			edit.Properties.Buttons(0).Enabled = index > 0
			edit.Properties.Buttons(1).Enabled = index < editorsNames.Length - 1
		End Sub
		' </buttonEdit1>

		Private Sub buttonEdit5_Properties_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonEdit5.Properties.Click
			meFiringEvents.Text = ""
		End Sub
	End Class
End Namespace

