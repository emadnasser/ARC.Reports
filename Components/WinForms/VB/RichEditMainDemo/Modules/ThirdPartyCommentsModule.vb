Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraSpellChecker.Parser
Imports DevExpress.XtraRichEdit.SpellChecker
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ThirdPartyCommentsModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
			Me.ribbonControl1.SelectedPage = Me.ribbonControl1.Pages("Review")
			AddHandler richEditControl.EmptyDocumentCreated, AddressOf OnRichEditControlEmptyDocumentCreated
			AddHandler richEditControl.DocumentLoaded, AddressOf OnRichEditControlDocumentLoaded
			UpdateAuthor(System.Security.Principal.WindowsIdentity.GetCurrent().Name)
			UpdateCommentVisibility()
			UpdateHighlightCommentedRange()
			UpdateCommentColor()
			richEditControl.ShowReviewingPaneForm()
			dockPanel2.Options.ShowCloseButton = False
			OpenXmlLoadHelper.Load("Comments.docx", richEditControl)
			CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property

		Private Sub OnRichEditControlEmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
			FillComboBoxEditAuthors()
		End Sub
		Private Sub OnRichEditControlDocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
			FillComboBoxEditAuthors()
		End Sub
		Private Sub FillComboBoxEditAuthors()
			Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = comboBoxEditAuthors.Properties
			properties.Items.Clear()
			properties.Items.Add(System.Security.Principal.WindowsIdentity.GetCurrent().Name)
			properties.Items.AddRange(richEditControl.Options.Comments.VisibleAuthors)
			comboBoxEditAuthors.SelectedIndex = 0
			UpdateAuthor(Me.comboBoxEditAuthors.EditValue.ToString())
			properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		End Sub
		Private Sub UpdateAuthor(ByVal author As String)
			richEditControl.Options.Comments.Author = author
		End Sub
		Private Sub UpdateHighlightCommentedRange()
			richEditControl.Options.Comments.HighlightCommentedRange = chkHighlightCommentedRange.Checked
		End Sub
		Private Sub UpdateCommentVisibility()
			Me.richEditControl.Options.Comments.Visibility = If(chkViewComments.Checked, RichEditCommentVisibility.Visible, RichEditCommentVisibility.Hidden)
		End Sub
		Private Sub UpdateCommentColor()
			If chkResetColor.Checked Then
				Me.richEditControl.Options.Comments.ResetColor()
			Else
				Me.richEditControl.Options.Comments.Color = colorEdit1.Color
			End If
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub
		Private Sub comboBoxEditAuthors_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditAuthors.EditValueChanged
			UpdateAuthor(Me.comboBoxEditAuthors.EditValue.ToString())
		End Sub

		Private Sub chkViewComments_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkViewComments.CheckedChanged
			UpdateCommentVisibility()
			chkHighlightCommentedRange.Enabled = Not chkViewComments.Checked
		End Sub

		Private Sub chkHighlightCommentedRange_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkHighlightCommentedRange.CheckedChanged
			UpdateHighlightCommentedRange()
		End Sub

		Private Sub colorEdit1_ColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorEdit1.EditValueChanged
			chkResetColor.Checked = False
			UpdateCommentColor()
		End Sub

		Private Sub chkResetColor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkResetColor.CheckedChanged
			UpdateCommentColor()
		End Sub
	End Class
End Namespace
