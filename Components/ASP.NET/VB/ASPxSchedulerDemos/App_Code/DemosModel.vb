Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Collections.Generic
Imports System.IO
Imports System.Web
Imports System.Linq
Imports System.Configuration
Imports System

Namespace DevExpress.Web.Demos

	<XmlRoot("Demos")> _
	Public Class DemosModel
		Private Shared _instance As DemosModel
		Private Shared _current As DemoProductModel
		Private _globalHeader As New GlobalHeaderModel()

		Private Shared ReadOnly _instanceLock As Object = New Object()
		Private Shared ReadOnly _currentLock As Object = New Object()

		Private _expandAllDemosAtFirstTime As Boolean
		Private _disableTextWrap As Boolean

		Public Shared ReadOnly Property Instance() As DemosModel
			Get
				SyncLock _instanceLock
					If _instance Is Nothing Then
						Using stream As Stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/Demos.xml"))
							Dim serializer As New XmlSerializer(GetType(DemosModel))
							_instance = CType(serializer.Deserialize(stream), DemosModel)
						End Using
						For Each demoProduct In _instance.DemoProducts
							For Each group In demoProduct.Groups
								For Each demo In group.GetAllDemos()
									demo.Group = group
									demo.Product = demoProduct
								Next demo
								group.Product = demoProduct
							Next group
							If demoProduct.Intro IsNot Nothing Then
								demoProduct.Intro.Product = demoProduct
							End If
							If demoProduct.Overview IsNot Nothing Then
								demoProduct.Overview.Product = demoProduct
							End If
						Next demoProduct
					End If
					Return _instance
				End SyncLock
			End Get
		End Property
		Public Shared ReadOnly Property Current() As DemoProductModel
			Get
				SyncLock _currentLock
					If _current Is Nothing Then
						_current = Instance.DemoProducts.FirstOrDefault(Function(dp) dp.Key = ConfigurationManager.AppSettings("DemoProduct"))
					End If
					If _current Is Nothing Then
						Throw New Exception("The current demo is not found")
					End If
					Return _current
				End SyncLock
			End Get
		End Property

		Private _demoProducts As New List(Of DemoProductModel)()
		Private _sortedDemoProducts As List(Of DemoProductModel)
		Private _search As SearchModel

		<XmlElement("DemoProduct")> _
		Public ReadOnly Property DemoProducts() As List(Of DemoProductModel)
			Get
				Return _demoProducts
			End Get
		End Property

		<XmlIgnore> _
		Public ReadOnly Property SortedDemoProducts() As List(Of DemoProductModel)
			Get
				If _sortedDemoProducts Is Nothing Then
					_sortedDemoProducts = _demoProducts.OrderBy(Function(p) p.OrderIndex).ToList()
				End If
				Return _sortedDemoProducts
			End Get
		End Property

		<XmlElement("Search")> _
		Public Property Search() As SearchModel
			Get
				Return _search
			End Get
			Set(ByVal value As SearchModel)
				_search = value
			End Set
		End Property
		<XmlElement("GlobalHeader")> _
		Public Property GlobalHeader() As GlobalHeaderModel
			Get
				Return _globalHeader
			End Get
			Set(ByVal value As GlobalHeaderModel)
				_globalHeader = value
			End Set
		End Property
		<XmlAttribute> _
		Public Property ExpandAllDemosAtFirstTime() As Boolean
			Get
				Return _expandAllDemosAtFirstTime
			End Get
			Set(ByVal value As Boolean)
				_expandAllDemosAtFirstTime = value
			End Set
		End Property
		<XmlAttribute> _
		Public Property DisableTextWrap() As Boolean
			Get
				Return _disableTextWrap
			End Get
			Set(ByVal value As Boolean)
				_disableTextWrap = value
			End Set
		End Property
	End Class
	Public Class GlobalHeaderModel
		Private _logoPlatformSubject As String = "ASP.NET AJAX"
		Private _logoPlatformDescription As String = "WHEN THE WEB MEANS BUSINESS"
		<XmlAttribute> _
		Public Property LogoPlatformSubject() As String
			Get
				Return _logoPlatformSubject
			End Get
			Set(ByVal value As String)
				_logoPlatformSubject = value
			End Set
		End Property
		<XmlAttribute> _
		Public Property LogoPlatformDescription() As String
			Get
				Return _logoPlatformDescription
			End Get
			Set(ByVal value As String)
				_logoPlatformDescription = value
			End Set
		End Property
	End Class
	Public Class DemoProductModel
		Inherits ModelBase
		Private _isMvc As Boolean
		Private _isMvcRazor As Boolean
		Private _isRootDemo As Boolean
		Private _isPreview As Boolean
		Private _isNew As Boolean
		Private _key As String
		Private _url As String
		Private _title As String
		Private _seoTitle As String
		Private _navItemTitle As String
		Private _supportsTheming As Boolean = True
		Private _supportsThemeParameters As Boolean = True
		Private _hideNavItem As Boolean = False
		Private _groups As New List(Of DemoGroupModel)()
		Private _intro As IntroPageModel
		Private _overview As OverviewPageModel

		Private _orderIndex As Integer = 1000
		Private _integrationHighlighted As Boolean = False
		Private _integrationImageUrl As String
		Private _integrationDescription As String

		Private _downloadUrl As String
		Private _buyUrl As String
		Private _docUrl As String

		Private _highlighledDemos As List(Of DemoPageModel)

		<XmlAttribute> _
		Public Property IsMvc() As Boolean
			Get
				Return _isMvc
			End Get
			Set(ByVal value As Boolean)
				_isMvc = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property IsMvcRazor() As Boolean
			Get
				Return _isMvcRazor
			End Get
			Set(ByVal value As Boolean)
				_isMvcRazor = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property IsRootDemo() As Boolean
			Get
				Return _isRootDemo
			End Get
			Set(ByVal value As Boolean)
				_isRootDemo = value
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
		Public Property IsNew() As Boolean
			Get
				Return _isNew
			End Get
			Set(ByVal value As Boolean)
				_isNew = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property HideNavItem() As Boolean
			Get
				Return _hideNavItem
			End Get
			Set(ByVal value As Boolean)
				_hideNavItem = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property Key() As String
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
		Public Property Url() As String
			Get
				If _url Is Nothing Then
					Throw New Exception("URL is not defined")
				End If
				Return _url
			End Get
			Set(ByVal value As String)
				_url = value
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
		Public Property NavItemTitle() As String
			Get
				If _navItemTitle Is Nothing Then
					Return ""
				End If
				Return _navItemTitle
			End Get
			Set(ByVal value As String)
				_navItemTitle = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property OrderIndex() As Integer
			Get
				Return _orderIndex
			End Get
			Set(ByVal value As Integer)
				_orderIndex = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property IntegrationHighlighted() As Boolean
			Get
				Return _integrationHighlighted
			End Get
			Set(ByVal value As Boolean)
				_integrationHighlighted = value
			End Set
		End Property

		<XmlElement> _
		Public Property DownloadUrl() As String
			Get
				If _downloadUrl Is Nothing Then
					Return ""
				End If
				Return _downloadUrl
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_downloadUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property BuyUrl() As String
			Get
				If _buyUrl Is Nothing Then
					Return ""
				End If
				Return _buyUrl
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_buyUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property DocUrl() As String
			Get
				If _docUrl Is Nothing Then
					Return ""
				End If
				Return _docUrl
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_docUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property IntegrationImageUrl() As String
			Get
				Return _integrationImageUrl
			End Get
			Set(ByVal value As String)
				_integrationImageUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property IntegrationDescription() As String
			Get
				Return _integrationDescription
			End Get
			Set(ByVal value As String)
				_integrationDescription = value
			End Set
		End Property

		<XmlElement("DemoGroup")> _
		Public ReadOnly Property Groups() As List(Of DemoGroupModel)
			Get
				Return _groups
			End Get
		End Property

		<XmlAttribute> _
		Public Property SupportsTheming() As Boolean
			Get
				Return _supportsTheming
			End Get
			Set(ByVal value As Boolean)
				_supportsTheming = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property SupportsThemeParameters() As Boolean
			Get
				Return _supportsThemeParameters
			End Get
			Set(ByVal value As Boolean)
				_supportsThemeParameters = value
			End Set
		End Property

		<XmlIgnore> _
		Public ReadOnly Property HighlightedDemos() As List(Of DemoPageModel)
			Get
				If _highlighledDemos Is Nothing Then
					_highlighledDemos = CreateHighlightedDemos()
				End If
				Return _highlighledDemos
			End Get
		End Property

		<XmlElement(Type := GetType(IntroPageModel), ElementName := "Intro")> _
		Public Property Intro() As IntroPageModel
			Get
				Return _intro
			End Get
			Set(ByVal value As IntroPageModel)
				_intro = value
			End Set
		End Property

		<XmlElement(Type := GetType(OverviewPageModel), ElementName := "Overview")> _
		Public Property Overview() As OverviewPageModel
			Get
				Return _overview
			End Get
			Set(ByVal value As OverviewPageModel)
				_overview = value
			End Set
		End Property

		<XmlIgnore> _
		Public ReadOnly Property IsCurrent() As Boolean
			Get
				Return Me Is DemosModel.Current
			End Get
		End Property

		Public Function FindGroup(ByVal key As String) As DemoGroupModel
			key = key.ToLower()
			For Each group As DemoGroupModel In Groups
				If key = group.Key.ToLower() Then
					Return group
				End If
			Next group
			Return Nothing
		End Function

		Private Function CreateHighlightedDemos() As List(Of DemoPageModel)
			Dim result As New List(Of DemoPageModel)()
			For Each group As DemoGroupModel In Groups
				For Each demo As DemoPageModel In group.Demos
					If demo.HighlightedIndex > -1 Then
						result.Add(demo)
					End If
				Next demo
			Next group
			result.Sort(AddressOf CompareHighlightedDemos)
			Return result
		End Function

		Private Function CompareHighlightedDemos(ByVal x As DemoModel, ByVal y As DemoModel) As Integer
			Return Comparer(Of Integer).Default.Compare(x.HighlightedIndex, y.HighlightedIndex)
		End Function

		Public Function GetSeoTitle() As String
			If (Not String.IsNullOrEmpty(SeoTitle)) Then
				Return SeoTitle
			End If
			Return Title
		End Function
	End Class
	Public Class SearchModel
		Private _synonyms As SynonymsSearchModel
		Private _exclusions As ExclusionsSearchModel

		<XmlElement> _
		Public Property Synonyms() As SynonymsSearchModel
			Get
				Return _synonyms
			End Get
			Set(ByVal value As SynonymsSearchModel)
				_synonyms = value
			End Set
		End Property

		<XmlElement> _
		Public Property Exclusions() As ExclusionsSearchModel
			Get
				Return _exclusions
			End Get
			Set(ByVal value As ExclusionsSearchModel)
				_exclusions = value
			End Set
		End Property
	End Class
	Public Class ExclusionsSearchModel
		Private _words As String
		Private _prefixes As String
		Private _postfixes As String

		<XmlElement> _
		Public Property Words() As String
			Get
				Return _words
			End Get
			Set(ByVal value As String)
				_words = value
			End Set
		End Property
		<XmlElement> _
		Public Property Prefixes() As String
			Get
				Return _prefixes
			End Get
			Set(ByVal value As String)
				_prefixes = value
			End Set
		End Property
		<XmlElement> _
		Public Property Postfixes() As String
			Get
				Return _postfixes
			End Get
			Set(ByVal value As String)
				_postfixes = value
			End Set
		End Property
	End Class
	Public Class SynonymsSearchModel
		Private _groups As New List(Of String)()

		<XmlElement("Group")> _
		Public Property Groups() As List(Of String)
			Get
				Return _groups
			End Get
			Set(ByVal value As List(Of String))
				_groups = value
			End Set
		End Property
	End Class
End Namespace
