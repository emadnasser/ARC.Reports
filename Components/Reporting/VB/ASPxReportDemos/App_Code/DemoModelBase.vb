Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Xml.Serialization

Namespace DevExpress.Web.Demos

	Public Class DemoModelBase
		Inherits ModelBase
		Private _key As String
		Private _title As String
		Private _seoTitle As String
		Private _isNew As Boolean
		Private _isPreview As Boolean
		Private _isUpdated As Boolean

		<XmlAttribute> _
		Public Overridable Property Key() As String
			Get
				If _key Is Nothing Then
					Return ""
				End If
				Return _key
			End Get
			Set(ByVal value As String)
				_key = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property Title() As String
			Get
				If _title Is Nothing Then
					Return ""
				End If
				Return _title
			End Get
			Set(ByVal value As String)
				_title = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property SeoTitle() As String
			Get
				If _seoTitle Is Nothing Then
					Return ""
				End If
				Return _seoTitle
			End Get
			Set(ByVal value As String)
				_seoTitle = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property IsNew() As Boolean
			Get
				Return _isNew
			End Get
			Set(ByVal value As Boolean)
				_isNew = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property IsPreview() As Boolean
			Get
				Return _isPreview
			End Get
			Set(ByVal value As Boolean)
				_isPreview = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property IsUpdated() As Boolean
			Get
				Return _isUpdated
			End Get
			Set(ByVal value As Boolean)
				_isUpdated = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return Title
		End Function
	End Class

	Public Class ModelBase
		Private _keywords As String
		Private _keywordsRankList As Dictionary(Of String, Integer)
		<XmlAttribute> _
		Public Property HighlightedTagNames() As String

		<XmlElement> _
		Public Property Keywords() As String
			Get
				If _keywords Is Nothing Then
					Return ""
				End If
				Return _keywords
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_keywords = value
			End Set
		End Property

		<XmlIgnore> _
		Public ReadOnly Property KeywordsRankList() As Dictionary(Of String, Integer)
			Get
				If _keywordsRankList Is Nothing Then
					_keywordsRankList = SearchUtils.GetKeywordsRankList(Me)
				End If
				Return _keywordsRankList
			End Get
		End Property

		Public Function GetHighlightedTagNames() As String()
			If (Not String.IsNullOrEmpty(HighlightedTagNames)) Then
				Return HighlightedTagNames.Split()
			End If
			Return New String(){}
		End Function
	End Class

End Namespace
