Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports DevExpress.CodeParser
Imports DevExpress.Utils
Imports DevExpress.Office.Internal
Imports DevExpress.Office.Utils
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.XtraRichEdit.Import
Imports DevExpress.XtraRichEdit.Internal
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.Commands

Imports System.Windows.Forms

Namespace RichEditDemo
    Partial Public Class SyntaxHighlighting
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.AutoCorrect.DetectUrls = False
            richEdit.Options.AutoCorrect.ReplaceTextAsYouType = False
            richEdit.Options.Behavior.PasteLineBreakSubstitution = LineBreakSubstitute.Paragraph
            Dim caps As DocumentCapabilitiesOptions = richEdit.Options.DocumentCapabilities
            caps.Bookmarks = DocumentCapability.Disabled
            caps.CharacterStyle = DocumentCapability.Disabled
            caps.HeadersFooters = DocumentCapability.Disabled
            caps.Hyperlinks = DocumentCapability.Disabled
            caps.InlinePictures = DocumentCapability.Disabled
            caps.Numbering.Bulleted = DocumentCapability.Disabled
            caps.Numbering.MultiLevel = DocumentCapability.Disabled
            caps.Numbering.Simple = DocumentCapability.Disabled
            caps.ParagraphFormatting = DocumentCapability.Disabled
            caps.ParagraphStyle = DocumentCapability.Disabled
            caps.Sections = DocumentCapability.Disabled
            caps.Tables = DocumentCapability.Disabled
            caps.TableStyle = DocumentCapability.Disabled
            caps.FloatingObjects = DocumentCapability.Disabled
            richEdit.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
            richEdit.Views.DraftView.AllowDisplayLineNumbers = True
            richEdit.Views.DraftView.Padding = New Padding(60, 4, 0, 0)

            richEdit.AddService(GetType(ISyntaxHighlightService), New SyntaxHighlightService(richEdit))
            Dim commandFactory As IRichEditCommandFactoryService = richEdit.GetService(Of IRichEditCommandFactoryService)()
            Dim newCommandFactory As New CustomRichEditCommandFactoryService(commandFactory)
            richEdit.RemoveService(GetType(IRichEditCommandFactoryService))
            richEdit.AddService(GetType(IRichEditCommandFactoryService), newCommandFactory)

            Dim importManager As IDocumentImportManagerService = richEdit.GetService(Of IDocumentImportManagerService)()
            importManager.UnregisterAllImporters()
            importManager.RegisterImporter(New PlainTextDocumentImporter())
            importManager.RegisterImporter(New SourcesCodeDocumentImporter())

            Dim exportManager As IDocumentExportManagerService = richEdit.GetService(Of IDocumentExportManagerService)()
            exportManager.UnregisterAllExporters()
            exportManager.RegisterExporter(New PlainTextDocumentExporter())
            exportManager.RegisterExporter(New SourcesCodeDocumentExporter())

            Dim codeModuleName As String = "SyntaxHighlighting"
            richEdit.Options.DocumentSaveOptions.CurrentFileName = CodeFileLoadHelper.GetCodeFileName(codeModuleName)
            CodeFileLoadHelper.Load(codeModuleName, richEdit)
        End Sub
        Private Sub richEdit_InitializeDocument(ByVal sender As Object, ByVal e As EventArgs)
            Dim document As Document = richEdit.Document
            document.BeginUpdate()
            Try
                document.DefaultCharacterProperties.FontName = "Courier New"
                document.DefaultCharacterProperties.FontSize = 10
                document.Sections(0).Page.Width = Units.InchesToDocumentsF(100)
                document.Sections(0).LineNumbering.CountBy = 1
                document.Sections(0).LineNumbering.RestartType = LineNumberingRestart.Continuous

                Dim tabSize As SizeF = richEdit.MeasureSingleLineString("    ", document.DefaultCharacterProperties)
                Dim tabs As TabInfoCollection = document.Paragraphs(0).BeginUpdateTabs(True)
                Try
                    For i As Integer = 1 To 30
                        Dim tab As New DevExpress.XtraRichEdit.API.Native.TabInfo()
                        tab.Position = i * tabSize.Width
                        tabs.Add(tab)
                    Next i
                Finally
                    document.Paragraphs(0).EndUpdateTabs(tabs)
                End Try
            Finally
                document.EndUpdate()
            End Try
        End Sub
        Private Sub richEdit_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            e.Menu = Nothing
        End Sub

        #Region "SyntaxHighlightService"
        Public Class SyntaxHighlightService
            Implements ISyntaxHighlightService

            #Region "Fields"
            Private ReadOnly editor As RichEditControl
            Private ReadOnly syntaxHighlightInfo As SyntaxHighlightInfo
            #End Region


            Public Sub New(ByVal editor As RichEditControl)
                Me.editor = editor
                Me.syntaxHighlightInfo = New SyntaxHighlightInfo()
            End Sub


            #Region "ISyntaxHighlightService Members"
            Private Sub ISyntaxHighlightService_ForceExecute() Implements ISyntaxHighlightService.ForceExecute
                Me.Execute()
            End Sub
            Private Sub ISyntaxHighlightService_Execute() Implements ISyntaxHighlightService.Execute
                Me.Execute()
            End Sub
            #End Region

            Private Sub Execute()
                Dim tokens As TokenCollection = Parse(editor.Text)
                HighlightSyntax(tokens)
            End Sub
            Private Function Parse(ByVal code As String) As TokenCollection
                If String.IsNullOrEmpty(code) Then
                    Return Nothing
                End If
                Dim tokenizer As ITokenCategoryHelper = CreateTokenizer()
                If tokenizer Is Nothing Then
                    Return New TokenCollection()
                End If
                Return tokenizer.GetTokens(code)
            End Function

            Private Function CreateTokenizer() As ITokenCategoryHelper
                Dim fileName As String = editor.Options.DocumentSaveOptions.CurrentFileName
                If String.IsNullOrEmpty(fileName) Then
                    Return Nothing
                End If
                Dim result As ITokenCategoryHelper = TokenCategoryHelperFactory.CreateHelperForFileExtensions(Path.GetExtension(fileName))
                If result IsNot Nothing Then
                    Return result
                Else
                    Return Nothing
                End If
            End Function

            Private Sub HighlightSyntax(ByVal tokens As TokenCollection)
                If tokens Is Nothing OrElse tokens.Count = 0 Then
                    Return
                End If
                Dim document As Document = editor.Document
                Dim cp As CharacterProperties = document.BeginUpdateCharacters(0, 1)

                Dim syntaxTokens As New List(Of SyntaxHighlightToken)(tokens.Count)
                For Each token As Token In tokens
                    HighlightCategorizedToken(CType(token, CategorizedToken), syntaxTokens)
                Next token
                document.ApplySyntaxHighlight(syntaxTokens)
                document.EndUpdateCharacters(cp)
            End Sub
            Private Sub HighlightCategorizedToken(ByVal token As CategorizedToken, ByVal syntaxTokens As List(Of SyntaxHighlightToken))
                Dim highlightProperties As SyntaxHighlightProperties = syntaxHighlightInfo.CalculateTokenCategoryHighlight(token.Category)
                Dim syntaxToken As SyntaxHighlightToken = SetTokenColor(token, highlightProperties, editor.ActiveView.BackColor)
                If syntaxToken IsNot Nothing Then
                    syntaxTokens.Add(syntaxToken)
                End If
            End Sub
            Private Function SetTokenColor(ByVal token As Token, ByVal foreColor As SyntaxHighlightProperties, ByVal backColor As Color) As SyntaxHighlightToken
                If editor.Document.Paragraphs.Count < token.Range.Start.Line Then
                    Return Nothing
                End If
                Dim paragraphStart As Integer = DocumentHelper.GetParagraphStart(editor.Document.Paragraphs(token.Range.Start.Line - 1))
                Dim tokenStart As Integer = paragraphStart + token.Range.Start.Offset - 1
                If token.Range.End.Line <> token.Range.Start.Line Then
                    paragraphStart = DocumentHelper.GetParagraphStart(editor.Document.Paragraphs(token.Range.End.Line - 1))
                End If

                Dim tokenEnd As Integer = paragraphStart + token.Range.End.Offset - 1
                System.Diagnostics.Debug.Assert(tokenEnd > tokenStart)
                Return New SyntaxHighlightToken(tokenStart, tokenEnd - tokenStart, foreColor)
            End Function
        End Class
        #End Region

        #Region "SyntaxHighlightInfo"
        Public Class SyntaxHighlightInfo
            Private ReadOnly properties As Dictionary(Of TokenCategory, SyntaxHighlightProperties)

            Public Sub New()
                Me.properties = New Dictionary(Of TokenCategory, SyntaxHighlightProperties)()
                Reset()
            End Sub
            Public Sub Reset()
                properties.Clear()
                Add(TokenCategory.Text, DXColor.Black)
                Add(TokenCategory.Keyword, DXColor.Blue)
                Add(TokenCategory.String, DXColor.Brown)
                Add(TokenCategory.Comment, DXColor.Green)
                Add(TokenCategory.Identifier, DXColor.Black)
                Add(TokenCategory.PreprocessorKeyword, DXColor.Blue)
                Add(TokenCategory.Number, DXColor.Red)
                Add(TokenCategory.Operator, DXColor.Black)
                Add(TokenCategory.Unknown, DXColor.Black)
                Add(TokenCategory.XmlComment, DXColor.Gray)

                Add(TokenCategory.CssComment, DXColor.Green)
                Add(TokenCategory.CssKeyword, DXColor.Brown)
                Add(TokenCategory.CssPropertyName, DXColor.Red)
                Add(TokenCategory.CssPropertyValue, DXColor.Blue)
                Add(TokenCategory.CssSelector, DXColor.Blue)
                Add(TokenCategory.CssStringValue, DXColor.Blue)

                Add(TokenCategory.HtmlAttributeName, DXColor.Red)
                Add(TokenCategory.HtmlAttributeValue, DXColor.Blue)
                Add(TokenCategory.HtmlComment, DXColor.Green)
                Add(TokenCategory.HtmlElementName, DXColor.Brown)
                Add(TokenCategory.HtmlEntity, DXColor.Gray)
                Add(TokenCategory.HtmlOperator, DXColor.Black)
                Add(TokenCategory.HtmlServerSideScript, DXColor.Black)
                Add(TokenCategory.HtmlString, DXColor.Blue)
                Add(TokenCategory.HtmlTagDelimiter, DXColor.Blue)
            End Sub
            Private Sub Add(ByVal category As TokenCategory, ByVal foreColor As Color)
                Dim item As New SyntaxHighlightProperties()
                item.ForeColor = foreColor
                properties.Add(category, item)
            End Sub

            Public Function CalculateTokenCategoryHighlight(ByVal category As TokenCategory) As SyntaxHighlightProperties
                Dim result As SyntaxHighlightProperties = Nothing
                If properties.TryGetValue(category, result) Then
                    Return result
                Else
                    Return properties(TokenCategory.Text)
                End If
            End Function
        End Class
        #End Region

        #Region "CustomRichEditCommandFactoryService"
        Public Class CustomRichEditCommandFactoryService
            Implements IRichEditCommandFactoryService

            Private ReadOnly service As IRichEditCommandFactoryService

            Public Sub New(ByVal service As IRichEditCommandFactoryService)
                Guard.ArgumentNotNull(service, "service")
                Me.service = service
            End Sub

            #Region "IRichEditCommandFactoryService Members"
            Private Function IRichEditCommandFactoryService_CreateCommand(ByVal id As RichEditCommandId) As RichEditCommand Implements IRichEditCommandFactoryService.CreateCommand
                If id.Equals(RichEditCommandId.InsertColumnBreak) OrElse id.Equals(RichEditCommandId.InsertLineBreak) OrElse id.Equals(RichEditCommandId.InsertPageBreak) Then
                    Return service.CreateCommand(RichEditCommandId.InsertParagraph)
                End If
                Return service.CreateCommand(id)
            End Function
            #End Region
        End Class
        #End Region


        Public NotInheritable Class SourceCodeDocumentFormat

            Private Sub New()
            End Sub

            Public Shared ReadOnly Id As New DocumentFormat(1325)
        End Class
        Public Class SourcesCodeDocumentImporter
            Inherits PlainTextDocumentImporter


            Friend Shared ReadOnly filter_Renamed As New FileDialogFilter("Source Files", New String() { "cs", "vb", "html", "htm", "js", "xml", "css" })
            Public Overrides ReadOnly Property Filter() As FileDialogFilter
                Get
                    Return filter_Renamed
                End Get
            End Property
            Public Overrides ReadOnly Property Format() As DocumentFormat
                Get
                    Return SourceCodeDocumentFormat.Id
                End Get
            End Property
        End Class
        Public Class SourcesCodeDocumentExporter
            Inherits PlainTextDocumentExporter

            Public Overrides ReadOnly Property Filter() As FileDialogFilter
                Get
                    Return SourcesCodeDocumentImporter.filter_Renamed
                End Get
            End Property
            Public Overrides ReadOnly Property Format() As DocumentFormat
                Get
                    Return SourceCodeDocumentFormat.Id
                End Get
            End Property
        End Class
    End Class
End Namespace
