Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Imports System.Xml.Serialization
Imports DevExpress.Web.Internal
Imports System.Linq
Imports System.Runtime.Serialization

Namespace DevExpress.Web.Demos
	Public Class DemoPageModel
		Inherits DemoModel
		Private _group As DemoGroupModel
		Private _seeAlsoLinks As New List(Of SeeAlsoLinkModel)()
		Private _highlightedDescription As String = String.Empty

		<XmlIgnore> _
		Public Property Group() As DemoGroupModel
			Get
				Return _group
			End Get
			Friend Set(ByVal value As DemoGroupModel)
				_group = value
			End Set
		End Property

		<XmlElement("SeeAlso")> _
		Public Property SeeAlsoLinks() As List(Of SeeAlsoLinkModel)
			Get
				Return _seeAlsoLinks
			End Get
			Set(ByVal value As List(Of SeeAlsoLinkModel))
				_seeAlsoLinks = value
			End Set
		End Property

		<XmlElement("HighlightedDescription")> _
		Public Property HighlightedDescription() As String
			Get
				Return _highlightedDescription
			End Get
			Set(ByVal value As String)
				_highlightedDescription = value
			End Set
		End Property
	End Class


	Public Class DemoModel
		Inherits DemoModelBase
		Private _description As String
		Private _links As String
		Private _metaDescription As String
		Private _hideSourceCode As Boolean
		Private _sourceFiles As New List(Of String)()

		Private _highlightedIndex As Integer = -1
		Private _highlightedImageUrl As String
		Private _highlightedTitle As String
		Private _highlightedLink As String
		Private isErrorPage_Renamed As Boolean = False

		Private _product As DemoProductModel
		Private _descriptionProcessed As Boolean
		Private _linksProcessed As Boolean

		<XmlIgnore> _
		Public Property Product() As DemoProductModel
			Get
				Return _product
			End Get
			Friend Set(ByVal value As DemoProductModel)
				_product = value
			End Set
		End Property

		<XmlIgnore> _
		Public Property IsErrorPage() As Boolean
			Get
				Return isErrorPage_Renamed
			End Get
			Set(ByVal value As Boolean)
				isErrorPage_Renamed = value
			End Set
		End Property

		<XmlAttribute> _
		Public Overridable Property HideSourceCode() As Boolean
			Get
				Return _hideSourceCode
			End Get
			Set(ByVal value As Boolean)
				_hideSourceCode = value
			End Set
		End Property

		' Html is allowed here
		<XmlElement> _
		Public Property Description() As String
			Get
				If (Not _descriptionProcessed) Then
					ParseLinks()
					_description = ProcessDescription(_description)
					_descriptionProcessed = True
				End If
				Return ProcessPageControlTags(_description)
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_description = value
			End Set
		End Property
		<XmlIgnore> _
		Public ReadOnly Property Links() As String
			Get
				If (Not _linksProcessed) Then
					ParseLinks()
				End If
				Return _links
			End Get
		End Property
		<XmlElement> _
		Public Property MetaDescription() As String
			Get
				If _metaDescription Is Nothing Then
					Return ""
				End If
				Return _metaDescription
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_metaDescription = value
			End Set
		End Property

		<XmlElement("SourceFile")> _
		Public ReadOnly Property SourceFiles() As List(Of String)
			Get
				Return _sourceFiles
			End Get
		End Property

		<XmlAttribute> _
		Public Property HighlightedIndex() As Integer
			Get
				Return _highlightedIndex
			End Get
			Set(ByVal value As Integer)
				_highlightedIndex = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property HighlightedImageUrl() As String
			Get
				If _highlightedImageUrl Is Nothing Then
					Return ""
				End If
				Return _highlightedImageUrl
			End Get
			Set(ByVal value As String)
				_highlightedImageUrl = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property HighlightedTitle() As String
			Get
				If _highlightedTitle Is Nothing Then
					Return ""
				End If
				Return _highlightedTitle
			End Get
			Set(ByVal value As String)
				_highlightedTitle = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property HighlightedLink() As String
			Get
				Return _highlightedLink
			End Get
			Set(ByVal value As String)
				_highlightedLink = value
			End Set
		End Property

		Public Function GetHighlightedTitle() As String
			If (Not String.IsNullOrEmpty(HighlightedTitle)) Then
				Return HighlightedTitle
			End If
			Return Title
		End Function

		Private Shared Function ProcessDescription(ByVal text As String) As String
			If text Is Nothing Then
				text = ""
			End If
			text = Regex.Replace(text, "<code\s+lang=([^>]+)>(.*?)</code>", AddressOf DescriptionCodeReplacer, RegexOptions.Singleline)
			text = Regex.Replace(text, "<helplink([^>]*)>(.*?)</helplink>", AddressOf DescriptionHelpLinkReplacer, RegexOptions.Singleline)
			Return text
		End Function

		Private Shared Function ProcessPageControlTags(ByVal text As String) As String
			If text Is Nothing Then
				text = ""
			End If
			Return If(text.Contains("<pageControl>"), Regex.Replace(text, "<pageControl>(.*?)</pageControl>", AddressOf DescriptionPageControlReplacer, RegexOptions.Singleline), text)
		End Function

		Private Function ParseLinks(ByVal text As String) As String
			If text Is Nothing Then
				Return String.Empty
			End If
			Dim groupName = "content"
			Dim pattern As String = String.Format("(<helplink([^>]*)>)(?<{0}>.+?)(</helplink>)", groupName)
			Dim regex As New Regex(pattern)
			Dim matches = regex.Matches(text)
			Dim result = New List(Of String)()
			For Each match As Match In matches
				Dim group = match.Groups(groupName)
				If group.Success Then
					result.Add(group.Value)
				End If
			Next match
			Return String.Join(" ", result.Distinct())
		End Function

		Private Sub ParseLinks()
			_links = ParseLinks(_description)
			_linksProcessed = True
		End Sub

		Private Shared Function DescriptionCodeReplacer(ByVal match As Match) As String
			Dim lang As String = match.Groups(1).Value.Trim(""""c, "'"c)
			Dim code As String = match.Groups(2).Value
			Dim result As String = "<code>" & CodeFormatter.GetFormattedCode(CodeFormatter.ParseLanguage(lang), code, Utils.IsMvc, New String(){}) & "<br /></code>"
			Return If(Utils.IsOverview, String.Format("<div class='{0}'>{1}</div>", "CodeBlock", result), result)
		End Function
		Private Shared Function DescriptionHelpLinkReplacer(ByVal match As Match) As String
			Dim attributes As New Dictionary(Of String, String)()
			Dim reg = New Regex("(\S+)=[""']?((?:.(?![""']?\s+(?:\S+)=|[>""']))+.)[""']?")
			Dim attrMatches = reg.Matches(match.Groups(1).Value)
			For Each am As Match In attrMatches
				attributes(am.Groups(1).Value) = am.Groups(2).Value
			Next am
			If (Not attributes.ContainsKey("href")) Then
				attributes("href") = "http://help.devexpress.com/"
			End If
			Return String.Format("<a href=""{0}"" class=""{1}"">{2}</a>", attributes("href"), "helplink", match.Groups(2).Value)
		End Function
		Private Shared Function DescriptionPageControlReplacer(ByVal match As Match) As String
			Dim tabPages As MatchCollection = Regex.Matches(match.Value, "<tabPage\s+text=([^>]+)>(.*?)</tabPage>", RegexOptions.Singleline)
			If tabPages.Count = 0 Then
				Return match.Groups(1).Value
			End If
			Dim pageControl As New ASPxPageControl()
			pageControl.ID = "OverviewPageControl"
			pageControl.CssClass = "DemoPageControl"
			pageControl.EnableTabScrolling = True
			pageControl.TabAlign = TabAlign.Justify
			pageControl.EnableTheming = False
			pageControl.ActiveTabIndex = 0
			pageControl.EnableViewState = False
			pageControl.Width = Unit.Percentage(100)
			For Each tabPage As Match In tabPages
				Dim text As String = tabPage.Groups(1).Value.Trim(""""c, "'"c)
				Dim tab = pageControl.TabPages.Add(text, text)
				tab.Controls.Add(RenderUtils.CreateLiteralControl(tabPage.Groups(2).Value))
			Next tabPage
			Return RenderUtils.GetRenderResult(pageControl)
		End Function

		Public Function GetSeoTitle() As String
			If (Not String.IsNullOrEmpty(SeoTitle)) Then
				Return SeoTitle
			End If
			Return Title
		End Function

	End Class

	Public Class SeeAlsoLinkModel
		Private _src As String
		Private _title As String

		<XmlAttribute> _
		Public Property Url() As String
			Get
				Return _src
			End Get
			Set(ByVal value As String)
				_src = value
			End Set
		End Property
		<XmlAttribute> _
		Public Property Title() As String
			Get
				Return _title
			End Get
			Set(ByVal value As String)
				_title = value
			End Set
		End Property
	End Class

End Namespace
