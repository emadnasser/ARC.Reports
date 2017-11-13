Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraWizard.Demos
	Partial Public Class frmMain
		Inherits XtraForm
		Private finish As Boolean = False
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

		Private Sub wizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As WizardPageChangingEventArgs) Handles wizardControl1.SelectedPageChanging
			If e.PrevPage Is wpCardTemplate AndAlso e.Direction = Direction.Forward Then
				If ceSignature.Checked Then
					e.Page = wpSignature
				Else
					e.Page = wpPreview
				End If
			End If
			If e.PrevPage Is wpPreview AndAlso e.Direction = Direction.Backward Then
				If ceSignature.Checked Then
					e.Page = wpSignature
				Else
					e.Page = wpCardTemplate
				End If
			End If
			If e.Page Is wpPreview AndAlso e.Direction = Direction.Forward Then
				CreateCardPreview()
			End If
		End Sub

		Private Sub wizardControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As WizardPageChangedEventArgs) Handles wizardControl1.SelectedPageChanged
			If e.Page Is wpRecipientData Then
				teRecipientName.Focus()
			End If
			If e.Page Is wpSignature Then
				teYourName.Focus()
			End If
		End Sub

		Private Sub teRecipient_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles teEmail.TextChanged, teRecipientName.TextChanged
			wpRecipientData.AllowNext = teRecipientName.Text <> String.Empty AndAlso teEmail.Text <> String.Empty
		End Sub

		Private Sub teYourName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles teYourName.TextChanged
			wpSignature.AllowNext = teYourName.Text <> String.Empty
		End Sub

		Private Sub sbSkipSignature_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbSkipSignature.Click
			teYourName.Text = String.Empty
			ceSignature.Checked = False
			wizardControl1.SelectedPage = wpPreview
		End Sub

		Private Sub CreateCardPreview()
			meCard.Text = String.Format("Happy birthday, {0}!!!" & Constants.vbCrLf & "{1}", teRecipientName.Text, rgWishes.Properties.Items(rgWishes.SelectedIndex).Description)
			If ceSignature.Checked Then
				meCard.Text += String.Format(Constants.vbCrLf & Constants.vbCrLf & "{0}, {1}", cbeSignatureTemplate.Text, teYourName.Text)
			End If
		End Sub

        Private Sub sbSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbSend.Click
            Try
                System.Diagnostics.Process.Start(String.Format("mailto:{0}?subject={1}&body={2}", teEmail.Text, "Happy Birthday!", meCard.Text.Replace(vbNewLine, "%0A")))
            Catch
            End Try
        End Sub

		Private Sub wizardControl1_CancelClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles wizardControl1.CancelClick
			Me.Close()
		End Sub

		Private Sub wizardControl1_FinishClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles wizardControl1.FinishClick
			finish = True
			Me.Close()
		End Sub

		Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If finish Then
			Return
			End If
			If XtraMessageBox.Show(Me, "Do you want to exit the XtraWizard control demo?", "XtraWizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
				e.Cancel = True
			End If
		End Sub

		Private Sub teEmail_InvalidValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles teEmail.InvalidValue
			e.ErrorText = "Invalid email address"
		End Sub
	End Class
End Namespace
