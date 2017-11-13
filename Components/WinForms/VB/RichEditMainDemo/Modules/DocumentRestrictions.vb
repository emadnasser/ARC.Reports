Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraRichEdit.Demos
	#Region "DocumentRestrictionsModule"
	Partial Public Class DocumentRestrictionsModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl

		Public Sub New()
			InitializeComponent()
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
			richEditControl.Focus()
        End Sub

#Region "Properties"
        Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property
        Public ReadOnly Property IsHideDisabled() As Boolean
            Get
                Return edtHideDisabled.Checked
            End Get
        End Property
        Public ReadOnly Property IsReloadDocument() As Boolean
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property CurrentFileName() As String
            Get
                Return richEditControl.Options.DocumentSaveOptions.CurrentFileName
            End Get
        End Property
#End Region

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub

		#Region "Hendlers"
		Private Sub OnAllowCharacterFormatting(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowCharacterFormatting.CheckedChanged
			richEditControl.Options.DocumentCapabilities.CharacterFormatting = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowCharacterStyle(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowCharacterStyle.CheckedChanged
			richEditControl.Options.DocumentCapabilities.CharacterStyle = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowParagraph(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowParagraph.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Paragraphs = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowParagraphPraperties(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowParagraphPraperties.CheckedChanged
			richEditControl.Options.DocumentCapabilities.ParagraphFormatting = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowParagraphStyle(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowParagraphStyle.CheckedChanged
			richEditControl.Options.DocumentCapabilities.ParagraphStyle = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowParagraphTabs(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowParagraphTabs.CheckedChanged
			richEditControl.Options.DocumentCapabilities.ParagraphTabs = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowHyperlinks(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowHyperlinks.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Hyperlinks = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowBookmarks(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowBookmarks.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Bookmarks = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowBulletNumbering(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowBulletNumbering.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Numbering.Bulleted = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowSimpleNumbering(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowSimpleNumbering.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Numbering.Simple = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowMultiLevelNumbering(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowMultiLevelNumbering.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Numbering.MultiLevel = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowPicture(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowPicture.CheckedChanged
			richEditControl.Options.DocumentCapabilities.InlinePictures = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowSymbolTabs(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowSymbolTabs.CheckedChanged
			richEditControl.Options.DocumentCapabilities.TabSymbol = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowSections(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowSections.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Sections = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		Private Sub OnAllowHeadersFooters(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowHeadersFooters.CheckedChanged
			richEditControl.Options.DocumentCapabilities.HeadersFooters = GetOptionValue(sender)
			ReloadDocument()
		End Sub
        Private Sub OnApplyRestrictions(ByVal sender As Object, ByVal e As EventArgs)
            ReloadDocument()
        End Sub
		Private Sub OnEdtAllowTables(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowTables.CheckedChanged
			richEditControl.Options.DocumentCapabilities.Tables = GetOptionValue(sender)
			ReloadDocument()
		End Sub
		#End Region

		Private Sub ReloadDocument()
			If IsReloadDocument AndAlso (Not String.IsNullOrEmpty(CurrentFileName)) Then
				richEditControl.LoadDocument(CurrentFileName)
			End If
		End Sub
		Private Function GetOptionValue(ByVal sender As Object) As DocumentCapability
			If (CType(sender, CheckEdit)).Checked Then
				Return DocumentCapability.Enabled
			End If
			If IsHideDisabled Then
				Return DocumentCapability.Hidden
			End If
			Return DocumentCapability.Disabled
		End Function
		Public Function UpdateBarItemVisibility(ByVal capabilityCheckBoxChecked As Boolean) As DocumentCapability
			If capabilityCheckBoxChecked Then
				Return DocumentCapability.Enabled
			End If
			If (IsHideDisabled) Then
				Return DocumentCapability.Hidden
			Else
				Return DocumentCapability.Disabled
			End If
		End Function
		Private Sub edtHideDisabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtHideDisabled.CheckedChanged
			richEditControl.BeginUpdate()
			Try
				richEditControl.Options.DocumentCapabilities.CharacterFormatting = UpdateBarItemVisibility(Me.edtAllowCharacterFormatting.Checked)
				richEditControl.Options.DocumentCapabilities.CharacterStyle = UpdateBarItemVisibility(Me.edtAllowCharacterStyle.Checked)
				richEditControl.Options.DocumentCapabilities.Paragraphs = UpdateBarItemVisibility(Me.edtAllowParagraph.Checked)
				richEditControl.Options.DocumentCapabilities.ParagraphFormatting = UpdateBarItemVisibility(Me.edtAllowParagraphPraperties.Checked)
				richEditControl.Options.DocumentCapabilities.ParagraphStyle = UpdateBarItemVisibility(Me.edtAllowParagraphStyle.Checked)
				richEditControl.Options.DocumentCapabilities.ParagraphTabs = UpdateBarItemVisibility(Me.edtAllowParagraphTabs.Checked)
				richEditControl.Options.DocumentCapabilities.Hyperlinks = UpdateBarItemVisibility(Me.edtAllowHyperlinks.Checked)
				richEditControl.Options.DocumentCapabilities.Bookmarks = UpdateBarItemVisibility(Me.edtAllowBookmarks.Checked)
				richEditControl.Options.DocumentCapabilities.Numbering.Bulleted = UpdateBarItemVisibility(Me.edtAllowBulletNumbering.Checked)
				richEditControl.Options.DocumentCapabilities.Numbering.Simple = UpdateBarItemVisibility(Me.edtAllowSimpleNumbering.Checked)
				richEditControl.Options.DocumentCapabilities.Numbering.MultiLevel = UpdateBarItemVisibility(Me.edtAllowMultiLevelNumbering.Checked)
				richEditControl.Options.DocumentCapabilities.InlinePictures = UpdateBarItemVisibility(Me.edtAllowPicture.Checked)
				richEditControl.Options.DocumentCapabilities.TabSymbol = UpdateBarItemVisibility(Me.edtAllowSymbolTabs.Checked)
				richEditControl.Options.DocumentCapabilities.Sections = UpdateBarItemVisibility(Me.edtAllowSections.Checked)
				richEditControl.Options.DocumentCapabilities.HeadersFooters = UpdateBarItemVisibility(Me.edtAllowHeadersFooters.Checked)
				richEditControl.Options.DocumentCapabilities.Tables = UpdateBarItemVisibility(Me.edtAllowTables.Checked)
				ReloadDocument()
			Finally
				richEditControl.EndUpdate()
			End Try
		End Sub
	End Class
	#End Region
End Namespace
