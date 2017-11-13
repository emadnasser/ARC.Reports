Imports System
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.Editors

Namespace RichEditDemo
    Partial Public Class DocumentRestrictions
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("TextWithImages.rtf", richEdit)
        End Sub

        Public ReadOnly Property IsReloadDocument() As Boolean
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property IsHideDisabled() As Boolean
            Get
                Return edtHideDisabled.IsChecked.Value
            End Get
        End Property
        Public ReadOnly Property CurrentFileName() As String
            Get
                Return richEdit.Options.DocumentSaveOptions.CurrentFileName
            End Get
        End Property

        Protected Overrides Sub RaiseModuleAppear()
            MyBase.RaiseModuleAppear()
            richEdit.Options.DocumentCapabilities.CharacterFormatting = DevExpress.XtraRichEdit.DocumentCapability.Default
        End Sub

        Private Sub ReloadDocument()
            If IsReloadDocument AndAlso (Not String.IsNullOrEmpty(CurrentFileName)) Then
                richEdit.LoadDocument(CurrentFileName)
            End If
        End Sub
        Private Function GetOptionValue(ByVal sender As Object) As DocumentCapability
            If DirectCast(sender, CheckEdit).IsChecked.Value Then
                Return DocumentCapability.Enabled
            End If
            If IsHideDisabled Then
                Return DocumentCapability.Hidden
            End If
            Return DocumentCapability.Disabled
        End Function
        Public Function UpdateBarItemVisibility(ByVal capabilityCheckBoxChecked? As Boolean) As DocumentCapability
            If (Not capabilityCheckBoxChecked.HasValue) OrElse capabilityCheckBoxChecked.Value Then
                Return DocumentCapability.Enabled
            End If
            Return If(IsHideDisabled, DocumentCapability.Hidden, DocumentCapability.Disabled)
        End Function

        Private Sub characterFormatting_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.CharacterFormatting = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub characterStyle_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.CharacterStyle = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub paragraphInsertNew_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Paragraphs = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub paragraphFormatting_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.ParagraphFormatting = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub paragraphStyle_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.ParagraphStyle = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub paragraphTabs_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.ParagraphTabs = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub numberingBulleted_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Numbering.Bulleted = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub numberingMultilevel_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Numbering.MultiLevel = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub numberingSimple_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Numbering.Simple = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub contentPictures_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.InlinePictures = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub contentTabs_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.TabSymbol = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub contentFloatingObjects_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.FloatingObjects = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub hyperlinks_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Hyperlinks = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub bookmarks_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Bookmarks = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub sections_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Sections = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub headersFooters_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.HeadersFooters = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub tables_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.DocumentCapabilities.Tables = GetOptionValue(sender)
            ReloadDocument()
        End Sub
        Private Sub edtHideDisabled_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.BeginUpdate()
            Try
                Dim options As DocumentCapabilitiesOptions = richEdit.Options.DocumentCapabilities
                options.CharacterFormatting = UpdateBarItemVisibility(Me.edtAllowCharacterFormatting.IsChecked)
                options.CharacterStyle = UpdateBarItemVisibility(Me.edtAllowCharacterStyle.IsChecked)
                options.Paragraphs = UpdateBarItemVisibility(Me.edtAllowParagraph.IsChecked)
                options.ParagraphFormatting = UpdateBarItemVisibility(Me.edtAllowParagraphPraperties.IsChecked)
                options.ParagraphStyle = UpdateBarItemVisibility(Me.edtAllowParagraphStyle.IsChecked)
                options.ParagraphTabs = UpdateBarItemVisibility(Me.edtAllowParagraphTabs.IsChecked)
                options.Hyperlinks = UpdateBarItemVisibility(Me.edtAllowHyperlinks.IsChecked)
                options.Bookmarks = UpdateBarItemVisibility(Me.edtAllowBookmarks.IsChecked)
                options.Numbering.Bulleted = UpdateBarItemVisibility(Me.edtAllowBulletNumbering.IsChecked)
                options.Numbering.Simple = UpdateBarItemVisibility(Me.edtAllowSimpleNumbering.IsChecked)
                options.Numbering.MultiLevel = UpdateBarItemVisibility(Me.edtAllowMultiLevelNumbering.IsChecked)
                options.InlinePictures = UpdateBarItemVisibility(Me.edtAllowPicture.IsChecked)
                options.TabSymbol = UpdateBarItemVisibility(Me.edtAllowTabSymbol.IsChecked)
                options.Sections = UpdateBarItemVisibility(Me.edtAllowSections.IsChecked)
                options.HeadersFooters = UpdateBarItemVisibility(Me.edtAllowHeadersFooters.IsChecked)
                options.Tables = UpdateBarItemVisibility(Me.edtAllowTables.IsChecked)
                ReloadDocument()
            Finally
                richEdit.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
