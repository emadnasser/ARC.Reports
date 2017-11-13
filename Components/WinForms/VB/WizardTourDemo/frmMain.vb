Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraWizard

Namespace DevExpress.XtraWizard.Demos
	Partial Public Class frmMain
		Inherits XtraForm
		Private progressTimer As Timer = Nothing
		Private ltTimer As Int32 = 0
		Private finish As Boolean = False

		Public Sub New()
			Me.New(True, WizardStyle.Wizard97)
		End Sub

        Public Sub New(ByVal allowAnimation As Boolean, ByVal style As WizardStyle)
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("AppIcon.ico", GetType(frmMain).Assembly)
            wizardControl1.AllowTransitionAnimation = allowAnimation
            wizardControl1.WizardStyle = style
            memoEdit1.Text = Info.LongText
        End Sub

		Private Sub wizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles wizardControl1.SelectedPageChanging
			If e.Page Is wpLongText Then
				e.Page.AllowNext = ceLongText.Checked
				CreateLongTextTimer()
			End If
            If e.PrevPage Is wpQuestion AndAlso e.Direction = Direction.Forward Then
                If ceYesAnswer.Checked Then
                    e.Page = wpProgress
                End If
            End If
            If e.PrevPage Is wpProgress AndAlso e.Direction = Direction.Backward Then
                e.Page = wpQuestion
            End If
			If e.Page Is wpProgress Then
				CreateProgressTimer()
			End If
			If e.PrevPage Is wpProgress Then
				RemoveHandler progressTimer.Tick, AddressOf progressTimer_Tick
				progressTimer.Dispose()
				progressTimer = Nothing
				progressBarControl1.Position = 0
				lbProgress.Visible = False
			End If
			If e.Page Is completionWizardPage1 Then
				If teRobotTest.Text.ToLower() = "devexpress123" Then
					completionWizardPage1.Text = "Congratulations – You've Passed All the Way Through!"
					If lbcPlay.SelectedIndex > -1 Then
						completionWizardPage1.FinishText = String.Format("Thank you for completing this XtraWizard feature tour! We can now conclusively state that you are very patient, definitely not a robot, a quick reader, and a fan of {0} just like we are.", GetArtistName(lbcPlay.SelectedValue))
					Else
						completionWizardPage1.FinishText = "Thank you for completing this XtraWizard feature tour! We can now conclusively state that you are very patient, a quick reader and definitely not a robot."
					End If
				Else
					completionWizardPage1.Text = "Sorry, No Robots Allowed"
					completionWizardPage1.FinishText = "We are very sorry, but no robots are allowed to continue this wizard. Please click Finish to exit."
				End If
			End If
		End Sub

		Private Function GetArtistName(ByVal value As Object) As String
			If value Is Nothing Then
			Return String.Empty
			End If
			Return value.ToString().Substring(0, value.ToString().IndexOf("-") - 1)
		End Function

		Private Sub wizardControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As WizardPageChangedEventArgs) Handles wizardControl1.SelectedPageChanged
			If e.Page Is wpRobotTest Then
				teRobotTest.Focus()
			End If
			If e.Page Is wpNoAnswer Then
				lbcCancel.Top = e.Page.Height - 29
			End If
		End Sub

		Private Function GetLongTextTime() As Int32
            Return (System.Environment.TickCount - ltTimer) \ 1000
		End Function

		Private Sub CreateLongTextTimer()
			If ltTimer = 0 Then
				ltTimer = System.Environment.TickCount
			End If
		End Sub

		Private Sub CreateProgressTimer()
			If progressTimer IsNot Nothing Then
			Return
			End If
			wpProgress.AllowNext = False
			progressTimer = New Timer()
			progressTimer.Interval = 40
			AddHandler progressTimer.Tick, AddressOf progressTimer_Tick
			progressTimer.Start()
		End Sub

		Private Sub progressTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			progressBarControl1.Position += 1
			If progressBarControl1.Position >= 100 Then
				progressTimer.Stop()
				lbProgress.Visible = True
				wpProgress.AllowNext = True
			End If
		End Sub

		Private Sub ceLongText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceLongText.CheckedChanged
			Dim ce As CheckEdit = TryCast(sender, CheckEdit)
			wpLongText.AllowNext = ce.Checked
		End Sub

		Private Sub wizardControl1_NextClick(ByVal sender As Object, ByVal e As WizardCommandButtonClickEventArgs) Handles wizardControl1.NextClick
			If e.Page Is wpLongText AndAlso GetLongTextTime() < 60 Then
				If XtraMessageBox.Show(Me, String.Format("Are you sure that {0} seconds was enough time for you to read all that text?", GetLongTextTime()), "Long Text Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
					ltTimer = -1
				Else
					e.Handled = True
				End If
			End If
		End Sub

		Private Sub sbPlay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbPlay.Click
			XtraMessageBox.Show(Me, String.Format("Sorry, but we don’t have that song in our library..." & Constants.vbCrLf & "But we agree with you that ""{0}"" is an excellent choice.", lbcPlay.SelectedValue), "XtraWizard", MessageBoxButtons.OK, MessageBoxIcon.Information)
			wizardControl1.SelectedPage = wpLongText
		End Sub

		Private Sub lbcPlay_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbcPlay.SelectedIndexChanged
			sbPlay.Enabled = lbcPlay.SelectedIndex > -1
		End Sub

		Private Sub wizardControl1_FinishClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles wizardControl1.FinishClick
			finish = True
			Me.Close()
		End Sub

		Private Sub wizardControl1_CancelClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles wizardControl1.CancelClick
			Me.Close()
		End Sub

		Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If finish Then
			Return
			End If
			If XtraMessageBox.Show(Me, "Do you want to exit the XtraWizard feature tour?", "XtraWizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
				e.Cancel = True
			End If
		End Sub
	End Class
End Namespace
