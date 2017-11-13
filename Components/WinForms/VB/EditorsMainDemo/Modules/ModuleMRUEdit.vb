Imports System.Collections
Imports System.ComponentModel
' <mruEditSample>
Imports DevExpress.XtraEditors
' </mruEditSample>
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
' </ceShowCustomButtons>
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMRUEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleMRUEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "mruedit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleMRUEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(mruEditSample)
			InitValues()
		End Sub


		Private Sub InitValues()
			updateValues = True
			seMaxItemCount.Value = mruEditSample.Properties.MaxItemCount
			ceAllowRemoveItems.Checked = mruEditSample.Properties.AllowRemoveMRUItems
			ShowCustomButtons(ceShowCustomButtons.Checked)
			updateValues = False
		End Sub

		' <seMaxItemCount>
		Private Sub seMaxItemCount_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaxItemCount.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			mruEditSample.Properties.MaxItemCount = Convert.ToInt32(seMaxItemCount.Value)
		End Sub
		' </seMaxItemCount>

		' <mruEditSample>
		Private Sub mruEditSample_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles mruEditSample.ButtonClick
			Dim edit As MRUEdit = TryCast(sender, MRUEdit)
			If edit.Properties.Buttons.IndexOf(e.Button) <> edit.Properties.ActionButtonIndex Then
				Dim dlg As New OpenFileDialog()
				dlg.Filter = "All Files(*.*)|*.*"
				If dlg.ShowDialog() = DialogResult.OK Then
					edit.EditValue = (New System.IO.FileInfo(dlg.FileName)).Name
					edit.Properties.Items.Add(edit.Text)
				End If
			End If
		End Sub
		' </mruEditSample>

		' <ceAllowAdding>
		Private Sub mruEditSample_AddingMRUItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.AddingMRUItemEventArgs) Handles mruEditSample.AddingMRUItem
			e.Cancel = Not ceAllowAdding.Checked
		End Sub
		' </ceAllowAdding>

		' <ceShowCustomButtons>
		Private Sub ShowCustomButtons(ByVal show As Boolean)
			For Each button As EditorButton In mruEditSample.Properties.Buttons
				If button.Tag IsNot Nothing Then
					button.Visible = show
				End If
			Next button
		End Sub

		Private Sub ceShowCustomButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowCustomButtons.CheckedChanged
			ShowCustomButtons(ceShowCustomButtons.Checked)
		End Sub
		' </ceShowCustomButtons>

		Private Sub ceAllowRemoveItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowRemoveItems.CheckedChanged
			If updateValues Then
				Return
			End If
			mruEditSample.Properties.AllowRemoveMRUItems = ceAllowRemoveItems.Checked
		End Sub
	End Class
End Namespace

