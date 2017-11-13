Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Configuration
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Internal
Imports System.Drawing

Namespace DevExpress.Web.Demos

	Public Class SourceCodePage
		Public Title As String = ""
		Public Code As String = ""
		Public Expanded As Boolean = False

		Public Sub New(ByVal title As String, ByVal code As String, ByVal expanded As Boolean)
			Me.Title = title
			Me.Code = code
			Me.Expanded = expanded
		End Sub
	End Class

	Public Class FeaturedDemoInfo
		Public Property Title() As String
		Public Property Description() As String
		Public Property NavigateUrl() As String
		Public Property ImageUrl() As String
	End Class

	Public Class ProductInfo
		Public Property Title() As String
		Public Property Description() As String
		Public Property NavigateUrl() As String
		Public Property ImageUrl() As String
	End Class

	Public NotInheritable Class Utils
		Private Const CurrentDemoKey As String = "DXCurrentDemo", CurrentThemeCookieKeyPrefix As String = "DXCurrentTheme", CurrentBaseColorCookieKey As String = "DXCurrentBaseColor", CurrentFontCookieKey As String = "DXCurrentFont", TunableThemeCookieKey As String = "DXTunableTheme", DefaultTheme As String = "Metropolis", BogusDemoTitle As String = "Delivered!", IsAccessibilityDemoKey As String = "IsAccessibilityDemo"

		Private Shared ReadOnly sourceCodeCache As New Dictionary(Of DemoModel, IEnumerable(Of SourceCodePage))()
		Private Shared ReadOnly sourceCodeCacheLock As Object = New Object()

		Private Shared _codeLanguage As String

		Private Sub New()
		End Sub
		Private Shared ReadOnly Property Context() As HttpContext
			Get
				Return HttpContext.Current
			End Get
		End Property

		Private Shared ReadOnly Property Request() As HttpRequest
			Get
				Return Context.Request
			End Get
		End Property

		Public Shared ReadOnly Property IsMvc() As Boolean
			Get
				Return DemosModel.Current.IsMvc
			End Get
		End Property
		Public Shared ReadOnly Property IsIncludeThirdPartyClientLibraries() As Boolean
			Get
				Dim resources = DevExpress.Web.Internal.ConfigurationSettings.Resources
				Return resources IsNot Nothing AndAlso resources.Contains(ResourcesType.ThirdParty)
			End Get
		End Property

		Public Shared ReadOnly Property CurrentDemo() As DemoModel
			Get
				Return CType(Context.Items(CurrentDemoKey), DemoModel)
			End Get
		End Property
		Public Shared ReadOnly Property RootProduct() As DemoProductModel
			Get
				Return DemosModel.Instance.SortedDemoProducts.Find(Function(p) p.IsRootDemo)
			End Get
		End Property
		Public Shared ReadOnly Property CurrentDemoNodeName() As String
			Get
				If IsOverview AndAlso CurrentOverview.Group Is Nothing Then
					Return String.Format("{0}_{1}", CurrentOverview.Product.Key, CurrentOverview.Key)
				End If
				If CurrentDemoPage IsNot Nothing Then
					Return String.Format("{0}_{1}_{2}", CurrentDemoPage.Product.Key, CurrentDemoPage.Group.Key, CurrentDemoPage.Key)
				End If
				If CurrentDemo IsNot Nothing Then
					Return CurrentDemo.Product.Key
				End If
				Return Nothing
			End Get
		End Property

		Public Shared ReadOnly Property CurrentDemoTitleHtml() As String
			Get
				Return GetDemoTitleHtml(CurrentDemo)
			End Get
		End Property

		Public Shared ReadOnly Property CurrentIntro() As IntroPageModel
			Get
				If TypeOf CurrentDemo Is IntroPageModel OrElse CurrentDemo Is Nothing Then
					Return CType(CurrentDemo, IntroPageModel)
				End If
				Return CurrentDemo.Product.Intro
			End Get
		End Property
		Public Shared ReadOnly Property CurrentOverview() As OverviewPageModel
			Get
				If TypeOf CurrentDemo Is OverviewPageModel OrElse CurrentDemo Is Nothing Then
					Return CType(CurrentDemo, OverviewPageModel)
				End If
				Return CurrentDemo.Product.Overview
			End Get
		End Property
		Public Shared ReadOnly Property CurrentDemoPage() As DemoPageModel
			Get
				Return TryCast(CurrentDemo, DemoPageModel)
			End Get
		End Property

		Public Shared ReadOnly Property CurrentThemeCookieKey() As String
			Get
				Return CurrentThemeCookieKeyPrefix
			End Get
		End Property
		Public Shared ReadOnly Property IsLargeTheme() As Boolean
			Get
				Return ThemesProvider.IsLargeTheme(CurrentTheme)
			End Get
		End Property
		Public Shared ReadOnly Property CurrentTheme() As String
			Get
				If CanChangeTheme AndAlso Request.Cookies(CurrentThemeCookieKey) IsNot Nothing Then
					Return HttpUtility.UrlDecode(Request.Cookies(CurrentThemeCookieKey).Value)
				End If
				Return DefaultTheme
			End Get
		End Property
		Public Shared ReadOnly Property CurrentBaseColor() As String
			Get
				If Request.Cookies(CurrentBaseColorCookieKey) IsNot Nothing Then
					Return HttpUtility.UrlDecode(Request.Cookies(CurrentBaseColorCookieKey).Value)
				End If
				Return CurrentThemeDefaultBaseColor
			End Get
		End Property
		Private Shared Sub SetCurrentBaseColorCookie(ByVal value As String)
			Context.Response.Cookies(CurrentBaseColorCookieKey).Value = value
		End Sub
		Public Shared ReadOnly Property CurrentFont() As String
			Get
				If Request.Cookies(CurrentFontCookieKey) IsNot Nothing Then
					Return HttpUtility.UrlDecode(Request.Cookies(CurrentFontCookieKey).Value)
				End If
				Return CurrentThemeDefaultFont
			End Get
		End Property
		Private Shared Sub SetCurrentFontCookie(ByVal value As String)
			Context.Response.Cookies(CurrentFontCookieKey).Value = value
		End Sub
		Public Shared ReadOnly Property CurrentThemeTitle() As String
			Get
				Dim theme = CurrentTheme
				Dim themeModel = ThemesModel.Current.Groups.SelectMany(Function(g) g.Themes).FirstOrDefault(Function(t) t.Name Is theme)
				Return If(themeModel IsNot Nothing, themeModel.Title, theme)
			End Get
		End Property
		Private Shared Property TunableTheme() As String
			Get
				If Request.Cookies(TunableThemeCookieKey) IsNot Nothing Then
					Return HttpUtility.UrlDecode(Request.Cookies(TunableThemeCookieKey).Value)
				End If
				Return CurrentTheme
			End Get
			Set(ByVal value As String)
				Context.Response.Cookies(TunableThemeCookieKey).Value = value
			End Set
		End Property
		Public Shared ReadOnly Property IsIntro() As Boolean
			Get
				Return TypeOf Utils.CurrentDemo Is IntroPageModel
			End Get
		End Property
		Public Shared ReadOnly Property IsOverview() As Boolean
			Get
				Return TypeOf Utils.CurrentDemo Is OverviewPageModel
			End Get
		End Property
		Public Shared ReadOnly Property IsBogusDemo() As Boolean
			Get
				Return If(CurrentDemo IsNot Nothing, CurrentDemo.Title = BogusDemoTitle, False)
			End Get
		End Property

		Public Shared Function GetDemoTitleHtml(ByVal demo As DemoModel) As String
			Dim result As String = String.Empty
			If TypeOf demo Is DemoPageModel Then
				result = String.Format("{0} - {1}", (CType(demo, DemoPageModel)).Group.Title, demo.Title)
			End If
			If String.IsNullOrEmpty(result) Then
				result = demo.Title
			ElseIf result.Length > 60 Then
				result = demo.Title
			End If
			Return HttpUtility.HtmlEncode(result)
		End Function

		Public Shared ReadOnly Property CodeLanguage() As String
			Get
				If _codeLanguage Is Nothing Then
					Try
						Using _file As FileStream = File.OpenRead(Context.Server.MapPath("~/Site.master"))
						Using reader As TextReader = New StreamReader(_file)
							Dim line As String = reader.ReadLine()
							Dim match As Match = Regex.Match(line, "language=""([^""]+)", RegexOptions.IgnoreCase)
							If match.Success Then
								_codeLanguage = match.Groups(1).Value.ToUpper()
							End If
						End Using
						End Using
					Catch
					End Try
					If String.IsNullOrEmpty(_codeLanguage) Then
						_codeLanguage = "C#"
					End If
				End If
				Return _codeLanguage
			End Get
		End Property

		Public Shared Function GetCurrentSourceCodePages() As IEnumerable(Of SourceCodePage)
			Return GetSourceCodePages(TryCast(CurrentDemo, DemoPageModel))
		End Function

		Public Shared Function GetSourceCodePages(ByVal demo As DemoPageModel) As IEnumerable(Of SourceCodePage)
			SyncLock sourceCodeCacheLock
				If (Not sourceCodeCache.ContainsKey(demo)) Then
					sourceCodeCache(demo) = CreateSourceCodePages(demo)
				End If
				Return sourceCodeCache(demo)
			End SyncLock
		End Function

		Private Shared Function CreateSourceCodePages(ByVal demo As DemoPageModel) As IEnumerable(Of SourceCodePage)
			Dim result As New List(Of SourceCodePage)()
			If IsMvc Then
				For Each fileName As String In demo.SourceFiles
					If fileName.StartsWith("~/Models/") Then
						AddSourceCodePage(result, String.Format("Model ({0})", Path.GetFileNameWithoutExtension(fileName)), fileName, False)
					End If
				Next fileName
				Dim controllerUrl As String = String.Format("~/Controllers/{0}/{0}Controller.{1}.cs", demo.Group.Key, demo.Key)
				AddSourceCodePage(result, "Controller", controllerUrl, True, False)
				Dim commonControllerUrl As String = String.Format("~/Controllers/{0}Controller.cs", demo.Group.Key)
				AddSourceCodePage(result, "Controller (common)", commonControllerUrl, False)
				Dim viewUrl As String = String.Format("~/Views/{0}/{1}.cshtml", demo.Group.Key, demo.Key)
				AddSourceCodePage(result, "View", viewUrl, True, False)
				For Each fileName As String In demo.SourceFiles
					If fileName.StartsWith("~/Views/") Then
						AddSourceCodePage(result, String.Format("View ({0})", Path.GetFileNameWithoutExtension(fileName)), fileName, True)
					ElseIf fileName.StartsWith("~/Code/") Then
						AddSourceCodePage(result, String.Format("{0}", Path.GetFileName(fileName)), fileName, True)
					ElseIf (Not fileName.StartsWith("~/Models/")) Then
						AddSourceCodePage(result, Path.GetFileName(fileName), fileName, False)
					End If
				Next fileName
			Else
				Dim baseUrl As String = GenerateDemoUrl(demo)

				Dim highlightedTagNames(-1) As String
				If (Not IsOverview) Then
					highlightedTagNames = demo.Group.GetHighlightedTagNames(). Concat(demo.GetHighlightedTagNames()). Concat(demo.Product.GetHighlightedTagNames()).ToArray()
				End If
				AddSourceCodePage(result, "ASPX", baseUrl, True, True, highlightedTagNames)
				If HasCodeFile(baseUrl) Then
					AddSourceCodePage(result, "C#", baseUrl & ".cs", CodeLanguage = "C#", True)
					AddSourceCodePage(result, "VB", baseUrl & ".vb", CodeLanguage = "VB")
				End If
				For Each fileName As String In demo.SourceFiles
					AddSourceCodePage(result, Path.GetFileName(fileName), fileName, False, True, highlightedTagNames)
				Next fileName
			End If
			Return result
		End Function

		Private Shared Sub AddSourceCodePage(ByVal list As List(Of SourceCodePage), ByVal title As String, ByVal url As String, ByVal expanded As Boolean)
			AddSourceCodePage(list, title, url, expanded, True, New String(){})
		End Sub
		Private Shared Sub AddSourceCodePage(ByVal list As List(Of SourceCodePage), ByVal title As String, ByVal url As String, ByVal expanded As Boolean, ByVal showIfError As Boolean)
			AddSourceCodePage(list, title, url, expanded, showIfError, New String(){})
		End Sub
		Private Shared Sub AddSourceCodePage(ByVal list As List(Of SourceCodePage), ByVal title As String, ByVal url As String, ByVal expanded As Boolean, ByVal showIfError As Boolean, ByVal highlightedTagNames() As String)
			Dim content As String = String.Empty
			Try
				content = GetHighlightedFileContent(url, highlightedTagNames)
			Catch
				content = If(showIfError, "Error rendering source code", String.Empty)
			End Try
			If (Not String.IsNullOrEmpty(content)) Then
				list.Add(New SourceCodePage(title, content, expanded))
			End If
		End Sub
		Private Shared Function HasCodeFile(ByVal url As String) As Boolean
			Dim filePath As String = GetHighlightedFilePath(url)
			If (Not File.Exists(filePath)) Then
				Return False
			End If
			Dim text As String = File.ReadAllText(filePath)
			Return Regex.IsMatch(text, "<[^>]*\bCodeFile\s*=\s*""[\w\.]+\""[^>]*>")
		End Function
		Private Shared Function GetHighlightedFileContent(ByVal virtualPath As String, ByVal highlightedTagNames() As String) As String
			Dim filePath As String = GetHighlightedFilePath(virtualPath)
			Dim text As String = File.ReadAllText(filePath)
			Return CodeFormatter.GetFormattedCode(Path.GetExtension(filePath), text, IsMvc, highlightedTagNames)
		End Function
		Private Shared Function GetHighlightedFilePath(ByVal virtualPath As String) As String
			Dim result As String = New DirectoryInfo(Context.Server.MapPath("~/")).FullName
			result = Path.Combine(result, ".Source")
			result = Path.Combine(result, virtualPath.Substring(2))
			If File.Exists(result) Then
				Return result
			End If

			result = Context.Server.MapPath(virtualPath)
			If (Not File.Exists(result)) Then
				result = CorrectSourceFilePath(result)
			End If
			Return result
		End Function

		Private Shared Function CorrectSourceFilePath(ByVal filePath As String) As String
			Dim csPathItem As String = String.Format("{0}cs{0}", Path.DirectorySeparatorChar)
			Dim vbPathItem As String = String.Format("{0}vb{0}", Path.DirectorySeparatorChar)
			filePath = filePath.ToLower()
			If filePath.EndsWith(".cs") Then
				Return filePath.Replace(vbPathItem, csPathItem)
			End If
			If filePath.EndsWith(".vb") Then
				Return filePath.Replace(csPathItem, vbPathItem)
			End If
			Return filePath
		End Function

		Public Shared Function GetVersionText() As String
			Dim parts() As String = AssemblyInfo.Version.Split("."c)
			Return String.Format("v{0} vol {1}.{2}", 2000 + Integer.Parse(parts(0)), parts(1), parts(2))
		End Function

		Public Shared Function GetVersionSuffix() As String
			Return AssemblyInfo.Version.Replace(".", "_")
		End Function

		Public Shared Sub RegisterCurrentWebFormsDemo(ByVal page As Page)
			Dim path As String = page.AppRelativeVirtualPath.ToLower().Replace("~/", "").Replace(".aspx", "")
			Dim parts() As String = path.Split("/"c)
			If parts.Length < 1 Then
				Throw New ArgumentException("Invalid demo URL")
			End If

			Dim groupKey As String = ""
			Dim demoKey As String = ""

			If parts.Length > 1 Then
				groupKey = parts(0)
				demoKey = parts(1)
			Else
				demoKey = parts(0)
			End If

			RegisterCurrentDemo(groupKey, demoKey)
		End Sub

		Public Shared Sub RegisterCurrentMvcDemoOnCallback()
			Dim controllerName As String = Request.RequestContext.RouteData.Values("controller").ToString()
			Dim actionName As String = String.Empty

			Dim demoUriParts() As String = Request.UrlReferrer.Segments
			Dim controllerNamePartIndex = demoUriParts.FindIndex(Function(part) part.Trim("/"c) = controllerName)

			If controllerNamePartIndex > -1 AndAlso Request.AppRelativeCurrentExecutionFilePath.Contains(controllerName) Then
				If demoUriParts.Length > controllerNamePartIndex + 1 Then
					actionName = demoUriParts(controllerNamePartIndex + 1)
				Else
					' overview demo
					actionName = controllerName
					controllerName = String.Empty
				End If
			End If

			RegisterCurrentMvcDemo(controllerName,If((Not String.IsNullOrEmpty(actionName)), actionName, "Index"))
		End Sub
		Public Shared Sub RegisterCurrentMvcDemo(ByVal controllerName As String, ByVal actionName As String)
			RegisterCurrentDemo(controllerName, actionName)
		End Sub
		Public Shared Function IsIntroPage(ByVal groupKey As String, ByVal demoKey As String) As Boolean
			If IsMvc Then
				Return groupKey.Equals("Home", StringComparison.InvariantCultureIgnoreCase) AndAlso demoKey.Equals("Index", StringComparison.InvariantCultureIgnoreCase)
			End If
			Return demoKey.Equals("default", StringComparison.InvariantCultureIgnoreCase)
		End Function
		Public Shared Function IsOverviewPage(ByVal demoKey As String) As Boolean
			Return demoKey.Equals("overview", StringComparison.InvariantCultureIgnoreCase)
		End Function
		Private Shared Sub RegisterCurrentDemo(ByVal groupKey As String, ByVal demoKey As String)
			Dim demo As DemoModel = Nothing
			If IsIntroPage(groupKey, demoKey) Then
				demo = DemosModel.Current.Intro
			ElseIf IsOverviewPage(demoKey) AndAlso String.IsNullOrEmpty(groupKey) Then
				demo = DemosModel.Current.Overview
			ElseIf IsErrorPage(demoKey) Then
				demo = CreateErrorPageDemoModel()
			Else
				Dim group As DemoGroupModel = DemosModel.Current.FindGroup(groupKey)
				If group IsNot Nothing Then
					demo = group.FindDemo(demoKey)
				End If
			End If

			If demo Is Nothing Then
				demo = CreateBogusDemoModel()
			End If

			Context.Items(CurrentDemoKey) = demo
			DevExpress.Web.Internal.DemoUtils.RegisterDemo(DemosModel.Current.Key, groupKey, demoKey)
		End Sub

		Private Shared Function CreateBogusDemoModel() As DemoPageModel
			Dim group As New DemoGroupModel()
			group.Title = "ASP.NET"

			Dim result As New DemoPageModel()
			result.Group = group
			result.HideSourceCode = True
			result.Title = BogusDemoTitle

			Return result
		End Function

		Private Shared Function CreateErrorPageDemoModel() As DemoPageModel
			Dim result As DemoPageModel = New DemoPageModel With {.IsErrorPage = True, .Product = DemosModel.Current, .Group = New DemoGroupModel()}
			Return result
		End Function

		Public Shared Function GetCurrentDemoPageTitle() As String
			Dim builder As New StringBuilder()
			If CurrentDemo.IsErrorPage Then
				builder.Append("Error Page - ")
				builder.Append(DemosModel.Current.GetSeoTitle())
				If (Not DemosModel.Current.IsRootDemo) Then
					builder.Append(" Demo")
				End If
			ElseIf TypeOf CurrentDemo Is IntroPageModel Then
				builder.Append(CurrentDemo.SeoTitle)
			ElseIf TypeOf CurrentDemo Is DemoPageModel Then
				Dim product As String = DemosModel.Current.GetSeoTitle()
				Dim demoGroup As DemoGroupModel = (CType(CurrentDemo, DemoPageModel)).Group
				Dim group As String = If(demoGroup IsNot Nothing, demoGroup.SeoTitle, Nothing)

				builder.Append(CurrentDemo.GetSeoTitle())
				builder.Append(" - ")
				builder.Append(If(String.IsNullOrEmpty(group), product, group))
				builder.Append(" Demo")
			End If
			builder.Append(" | DevExpress")
			Return builder.ToString()
		End Function

		Public Shared Function GetDemoNavigationTitle() As String
			Dim result As String = Utils.CurrentDemo.Product.NavItemTitle
			If Utils.CurrentDemoPage.Group IsNot Nothing Then
				result &= " - " & Utils.CurrentDemoPage.Group.Title
			End If
			Return result
		End Function

		Public Shared Sub RegisterCssLink(ByVal page As Page, ByVal url As String)
			RegisterCssLink(page, url, Nothing)
		End Sub

		Public Shared Function GetDescriptionTitle() As String
			If Utils.CurrentOverview IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Utils.CurrentOverview.DescriptionTitle)) Then
				Return Utils.CurrentOverview.DescriptionTitle
			End If
			Return String.Format("About the {0}",If(Utils.CurrentDemoPage.Group Is Nothing, Utils.CurrentDemo.Product.NavItemTitle, Utils.CurrentDemoPage.Group.Title))
		End Function

		Public Shared Sub RegisterCssLink(ByVal page As Page, ByVal url As String, ByVal clientId As String)
			If IsMvc Then
				Throw New NotImplementedException()
			End If
			Dim link As New HtmlLink()
			page.Header.Controls.Add(link)
			link.EnableViewState = False
			link.Attributes("type") = "text/css"
			link.Attributes("rel") = "stylesheet"
			If (Not String.IsNullOrEmpty(clientId)) Then
				link.Attributes("id") = clientId
			End If
			link.Href = url
		End Sub

		Public Shared Function GenerateDemoUrl(ByVal demo As DemoModel) As String
			If (Not String.IsNullOrEmpty(demo.HighlightedLink)) Then
				Return demo.HighlightedLink
			End If
			Dim str As New StringBuilder()
			If demo.Product.IsCurrent Then
				str.Append("~/")
			Else
				Dim url = HttpContext.Current.Request.Url.AbsolutePath
				Dim productUrl = "/" & CurrentDemo.Product.Url
				url = url.Substring(0, url.IndexOf(productUrl, StringComparison.InvariantCultureIgnoreCase) + 1)
				str.AppendFormat("{0}{1}/", url, demo.Product.Url)
			End If

			Dim demoGroup As DemoGroupModel = If(TypeOf demo Is DemoPageModel, (CType(demo, DemoPageModel)).Group, Nothing)
			If demoGroup IsNot Nothing AndAlso (Not String.IsNullOrEmpty(demoGroup.Key)) Then
				str.Append(demoGroup.Key)
				str.Append("/")
			End If
			If (Not IsMvc) OrElse (Not String.Equals("Index", demo.Key)) Then
				str.Append(demo.Key)
			End If
			If (Not IsMvc) Then
				str.Append(".aspx")
			End If
			Return str.ToString()
		End Function

		Public Shared Function GenerateFeaturedDemos() As List(Of FeaturedDemoInfo)
			Dim result = New List(Of FeaturedDemoInfo)()
			For Each demo In DemosModel.Current.HighlightedDemos
				result.Add(New FeaturedDemoInfo With {.Title = demo.GetHighlightedTitle(), .ImageUrl = demo.HighlightedImageUrl, .NavigateUrl = GenerateDemoUrl(demo), .Description = demo.HighlightedDescription})
			Next demo
			If Utils.CurrentIntro IsNot Nothing Then
				For Each demo In Utils.CurrentIntro.ExternalDemos
					result.Add(New FeaturedDemoInfo With {.Title = demo.Title, .ImageUrl = demo.ImageUrl, .NavigateUrl = demo.Url})
				Next demo
			End If
			Return result
		End Function
		Public Shared Function GenerateProductDemos(ByVal highlited As Boolean) As List(Of ProductInfo)
			Dim result = New List(Of ProductInfo)()
			For Each item In DemosModel.Instance.SortedDemoProducts.Where(Function(p) (Not p.HideNavItem) AndAlso (Not p.IsRootDemo) AndAlso p.IntegrationHighlighted = highlited)
				result.Add(New ProductInfo() With {.NavigateUrl = GenerateDemoUrl(item.Intro), .ImageUrl = item.IntegrationImageUrl, .Description = item.IntegrationDescription, .Title = item.NavItemTitle})
			Next item
			Return result
		End Function
		Public Shared Sub EnsureRequestValidationMode()
			Try
				If Environment.Version.Major >= 4 Then
					Dim type As Type = GetType(WebControl).Assembly.GetType("System.Web.Configuration.RuntimeConfig")
					Dim getConfig As MethodInfo = type.GetMethod("GetConfig", BindingFlags.Static Or BindingFlags.NonPublic, Nothing, New Type() { }, Nothing)
					Dim runtimeConfig As Object = getConfig.Invoke(Nothing, Nothing)
					Dim getSection As MethodInfo = type.GetMethod("GetSection", BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, New Type() { GetType(String), GetType(Type) }, Nothing)
					Dim httpRuntimeSection As HttpRuntimeSection = CType(getSection.Invoke(runtimeConfig, New Object() { "system.web/httpRuntime", GetType(HttpRuntimeSection) }), HttpRuntimeSection)
					Dim bReadOnly As FieldInfo = GetType(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance Or BindingFlags.NonPublic)
					bReadOnly.SetValue(httpRuntimeSection, False)

					Dim pi As PropertyInfo = GetType(HttpRuntimeSection).GetProperty("RequestValidationMode")
					If pi IsNot Nothing Then
						Dim version As Version = CType(pi.GetValue(httpRuntimeSection, Nothing), Version)
						Dim RequiredRequestValidationMode As New Version(2, 0)
						If version IsNot Nothing AndAlso (Not Version.Equals(version, RequiredRequestValidationMode)) Then
							pi.SetValue(httpRuntimeSection, RequiredRequestValidationMode, Nothing)
						End If
					End If
					bReadOnly.SetValue(httpRuntimeSection, True)
				End If
			Catch
			End Try
		End Sub

		Private Shared _isSiteMode? As Boolean
		Public Shared ReadOnly Property IsSiteMode() As Boolean
			Get
				If (Not _isSiteMode.HasValue) Then
					_isSiteMode = ConfigurationManager.AppSettings("SiteMode").Equals("true", StringComparison.InvariantCultureIgnoreCase)
				End If
				Return _isSiteMode.Value
			End Get
		End Property

		Public Shared Function GetReadOnlyMessageHtml() As String
			Return String.Format("<b>Data modifications are not allowed in the online demo.</b><br />" & "If you need to test data editing functionality, please install " & "{0} on your machine and run the demo locally.", DemosModel.Current.Title)
		End Function
		Public Shared Function GetReadOnlyMessageText() As String
			Return String.Format("Data modifications are not allowed in the online demo." & Constants.vbLf & "If you need to test data editing functionality, please install " & Constants.vbLf & "{0} on your machine and run the demo locally.", DemosModel.Current.Title)
		End Function

		Public Shared Sub AssertNotReadOnly()
			If (Not IsSiteMode) Then
				Return
			End If
			Throw New DemoException(GetReadOnlyMessageHtml())
		End Sub
		Public Shared Sub AssertNotReadOnlyText()
			If (Not IsSiteMode) Then
				Return
			End If
			Throw New DemoException(GetReadOnlyMessageText())
		End Sub
		Public Shared ReadOnly Property CanChangeTheme() As Boolean
			Get
				Return (Not IsIntro) AndAlso (Not IsIE6()) AndAlso DemosModel.Current.SupportsTheming
			End Get
		End Property
		Public Shared ReadOnly Property CanChangeBaseColor() As Boolean
			Get
				Return ThemesModel.Current.Groups.Where(Function(g) g.Themes.Where(Function(t) t.Name = CurrentTheme AndAlso (Not String.IsNullOrEmpty(t.BaseColor))).Count() <> 0).Count() > 0
			End Get
		End Property
		Public Shared ReadOnly Property CanApplyThemeParameters() As Boolean
			Get
				Return DemosModel.Current.SupportsThemeParameters AndAlso ((Not String.IsNullOrEmpty(CurrentThemeDefaultFont)) OrElse (Not String.IsNullOrEmpty(CurrentThemeDefaultBaseColor)))
			End Get
		End Property
		Public Shared ReadOnly Property CurrentThemeDefaultFont() As String
			Get
				Return CurrentThemeModel.Font
			End Get
		End Property
		Public Shared ReadOnly Property CurrentThemeDefaultFontSize() As String
			Get
				Return CurrentThemeModel.FontSize
			End Get
		End Property
		Public Shared ReadOnly Property CurrentThemeDefaultBaseColor() As String
			Get
				Return CurrentThemeModel.BaseColor
			End Get
		End Property

		Private Shared ReadOnly Property CurrentThemeModel() As ThemeModel
			Get
				Return ThemesModel.Current.Groups.SelectMany(Function(g) g.Themes).FirstOrDefault(Function(t) t.Name = CurrentTheme)
			End Get
		End Property
		Public Shared ReadOnly Property CustomFonts() As String()
			Get
				Return New String() { CurrentThemeDefaultFont, CurrentThemeDefaultFontSize & " " & "'Asap', normal", CurrentThemeDefaultFontSize & " " & "'Arima Madurai', normal", CurrentThemeDefaultFontSize & " " & "'Comfortaa', normal" }
			End Get
		End Property
		Public Shared Function GetFontFamiliesDataSource() As Object
			Return CustomFonts.Select(Function(f) New With {Key .Text = GetShortFontName(f), Key .Value = f})
		End Function
		Private Shared Function GetShortFontName(ByVal fullName As String) As String
			If String.IsNullOrWhiteSpace(fullName) Then
				Return fullName
			End If
			Return fullName.Substring(fullName.IndexOf(" "c) + 1, fullName.IndexOf(","c) - fullName.IndexOf(" "c) - 1).Trim("'"c)
		End Function
		Public Shared ReadOnly Property CustomBaseColors() As String()
			Get
				Return New String() { CurrentThemeDefaultBaseColor, "#4796CE", "#35B86B", "#CE5B47", "#F7A233", "#9F47CE", "#5C57C9", "#CE4776" }
			End Get
		End Property
		Public Shared Sub ResolveThemeParametes()
			If (Not CanChangeTheme) OrElse (Not DemosModel.Current.SupportsThemeParameters) Then
				Return
			End If

			Dim baseColor As String = CurrentBaseColor
			Dim font As String = CurrentFont

			If IsThemeChanged OrElse (Not String.IsNullOrEmpty(baseColor)) AndAlso (Not CustomBaseColors.Contains(baseColor)) OrElse baseColor = CurrentThemeDefaultBaseColor Then
				baseColor = String.Empty
				SetCurrentBaseColorCookie(baseColor)
			End If
			If IsThemeChanged OrElse (Not String.IsNullOrEmpty(font)) AndAlso (Not CustomFonts.Contains(font)) OrElse font = CurrentThemeDefaultFont Then
				font = String.Empty
				SetCurrentFontCookie(font)
			End If

			TunableTheme = CurrentTheme
			ASPxWebControl.GlobalThemeBaseColor = baseColor
			ASPxWebControl.GlobalThemeFont = font
		End Sub
		Public Shared Sub ResetThemeParameters()
			ASPxWebControl.GlobalThemeBaseColor = Nothing
			ASPxWebControl.GlobalThemeFont = Nothing
		End Sub
		Private Shared ReadOnly Property IsThemeChanged() As Boolean
			Get
				Return CurrentTheme <> TunableTheme
			End Get
		End Property
		Public Shared Function GetAccessibilityRoleAttribute(ByVal role As String) As String
			If IsAccessibilityDemo Then
				Return "role=""" & role & """"
			End If
			Return String.Empty
		End Function

		Public Shared ReadOnly Property IsAccessibilityDemo() As Boolean
			Get
				If Request Is Nothing Then
					Return False
				End If
				Dim demoUrl As String = Request.Url.AbsolutePath.ToLower()
				Return demoUrl.IndexOf("compliance") <> -1 OrElse (demoUrl.IndexOf("accessibility") <> -1 AndAlso demoUrl.IndexOf("linkedcontrols") <> -1)
			End Get
		End Property

		Public Shared Sub InjectDescriptionMeta(ByVal parent As Control)
			If String.IsNullOrEmpty(Utils.CurrentDemo.MetaDescription) Then
				Return
			End If

			Dim page As Page = TryCast(parent, Page)
			Dim header As HtmlHead = If((page IsNot Nothing AndAlso page.Header IsNot Nothing), page.Header, RenderUtils.FindHead(parent))
			If header IsNot Nothing Then
				Dim metaControl As New LiteralControl(String.Format("<meta name=""description"" content=""{0}"" />", Utils.CurrentDemo.MetaDescription))
				header.Controls.AddAt(0, metaControl)
			End If
		End Sub

		Public Shared Function IsIE6() As Boolean
			Return RenderUtils.Browser.IsIE AndAlso RenderUtils.Browser.Version < 7
		End Function

		Public Shared Function IsIE9() As Boolean
			Return RenderUtils.Browser.IsIE AndAlso RenderUtils.Browser.Version > 8
		End Function

		Public Shared Function IsIE10() As Boolean
			Return RenderUtils.Browser.IsIE AndAlso RenderUtils.Browser.Version > 9
		End Function

		Public Shared Function EncodeUrl(ByVal url As String) As String
			Return Uri.EscapeUriString(url.Trim())
		End Function

		Public Shared Function FormatSize(ByVal value As Object) As String
			Dim amount As Double = Convert.ToDouble(value)
			Dim unit As String = "KB"
			If amount <> 0 Then
				If amount <= 1024 Then
					amount = 1
				Else
					amount /= 1024
				End If

				If amount > 1024 Then
					amount /= 1024
					unit = "MB"
				End If
				If amount > 1024 Then
					amount /= 1024
					unit = "GB"
				End If
			End If
			Return String.Format("{0:#,0} {1}", Math.Round(amount, MidpointRounding.AwayFromZero), unit)
		End Function

		Private Shared Function IsErrorPage(ByVal demoKey As String) As Boolean
			Return demoKey.Equals("Error404", StringComparison.OrdinalIgnoreCase) OrElse demoKey.Equals("Error500", StringComparison.OrdinalIgnoreCase)
		End Function
	End Class
	Public NotInheritable Class SearchUtils
		Private Shared ReadOnly separators() As String = { " ", ",", "/", "\", "-", "+" }

		Private Shared _requestExclusions() As String
		Private Shared _prefixes() As String
		Private Shared _postfixes() As String
		Private Shared _synonyms()() As String

		Private Sub New()
		End Sub
		Private Shared ReadOnly Property WordsExclusions() As String()
			Get
				If _requestExclusions Is Nothing Then
					_requestExclusions = DemosModel.Instance.Search.Exclusions.Words.Split(separators, StringSplitOptions.RemoveEmptyEntries)
				End If
				Return _requestExclusions
			End Get
		End Property
		Private Shared ReadOnly Property PrefixesExclusions() As String()
			Get
				If _prefixes Is Nothing Then
					_prefixes = DemosModel.Instance.Search.Exclusions.Prefixes.Split(separators, StringSplitOptions.RemoveEmptyEntries)
				End If
				Return _prefixes
			End Get
		End Property
		Private Shared ReadOnly Property PostfixesExclusions() As String()
			Get
				If _postfixes Is Nothing Then
					_postfixes = DemosModel.Instance.Search.Exclusions.Postfixes.Split(separators, StringSplitOptions.RemoveEmptyEntries)
				End If
				Return _postfixes
			End Get
		End Property
		Private Shared ReadOnly Property Synonyms() As String()()
			Get
				If _synonyms Is Nothing Then
					_synonyms = DemosModel.Instance.Search.Synonyms.Groups.Select(Function(s) s.Split(separators, StringSplitOptions.RemoveEmptyEntries)).ToArray()
				End If
				Return _synonyms
			End Get
		End Property

		Public Shared Function DoSearch(ByVal request As String) As List(Of SearchResult)
			Dim results = New List(Of SearchResult)()
			If (Not String.IsNullOrEmpty(request)) Then
				Dim requests = SplitRequests(request)
				Try
					Dim products = DemosModel.Instance.SortedDemoProducts.Where(Function(dp) (Not dp.IsRootDemo) AndAlso (dp Is DemosModel.Current OrElse ((Not dp.HideNavItem) AndAlso Utils.IsSiteMode)))
					For Each product In products
						results.AddRange(DoSearch(requests, product))
					Next product
				Catch
				End Try
				results = results.OrderByDescending(Function(sr) sr.Rank).ThenBy(Function(sr) sr.Product.OrderIndex).ToList()
			End If
			Return results
		End Function
		Public Shared Function GetKeywordsRankList(ByVal model As ModelBase) As Dictionary(Of String, Integer)
			Dim textRanks As New List(Of TextRank)() From {New TextRank(model.Keywords, 3)}

			Dim product = TryCast(model, DemoProductModel)
			Dim group = TryCast(model, DemoGroupModel)
			Dim demo = TryCast(model, DemoPageModel)
			Dim overview = TryCast(model, OverviewPageModel)

			If product IsNot Nothing Then
				textRanks.Add(New TextRank(product.NavItemTitle, 5))
				textRanks.Add(New TextRank(product.Key, 3))
				textRanks.Add(New TextRank(product.Title, 3))
				textRanks.Add(New TextRank(product.SeoTitle, 2))
			ElseIf group IsNot Nothing Then
				textRanks.Add(New TextRank(group.Title, 5))
				textRanks.Add(New TextRank(group.Key, 3))
				textRanks.Add(New TextRank(group.SeoTitle, 2))
			ElseIf demo IsNot Nothing Then
				If overview IsNot Nothing Then
					If overview.Group IsNot Nothing Then
						textRanks.Add(New TextRank(overview.Group.Title, 7))
					ElseIf overview.Product IsNot Nothing Then
						textRanks.Add(New TextRank(overview.Product.Title, 15))
					End If
				Else
					textRanks.Add(New TextRank(demo.Title, 5))
				End If
				textRanks.Add(New TextRank(demo.Key, 3))
				textRanks.Add(New TextRank(demo.SeoTitle, 2))
				textRanks.Add(New TextRank(demo.Links, 2))
			End If
			Return GetKeywordsRankList(textRanks)
		End Function

		Private Shared Function CalculateRank(ByVal requests As List(Of String()), ByVal demo As DemoPageModel) As Integer
			Dim resultRank As Integer = 0
			Dim keywordRank As Integer = 0
			For Each request In requests
				Dim requestRank As Integer = -1
				If CalculateRank(request, demo.KeywordsRankList, keywordRank) Then
					requestRank += keywordRank
				End If
				If demo.Group IsNot Nothing AndAlso CalculateRank(request, demo.Group.KeywordsRankList, keywordRank) Then
					requestRank += keywordRank
				End If
				If CalculateRank(request, demo.Product.KeywordsRankList, keywordRank) Then
					requestRank += keywordRank
				End If
				If requestRank = -1 AndAlso WordsExclusions.Any(Function(re) re.Equals(request(0), StringComparison.InvariantCultureIgnoreCase)) Then
					requestRank = 0
				End If

				If requestRank > -1 Then
					resultRank += requestRank
				Else
					Return -1
				End If
			Next request
			Return resultRank
		End Function
		Private Shared Function CalculateRank(ByVal synonyms() As String, ByVal keywordsRankList As Dictionary(Of String, Integer), <System.Runtime.InteropServices.Out()> ByRef rank As Integer) As Boolean
			Dim keyword = keywordsRankList.Keys.FirstOrDefault(Function(k) MatchWord(synonyms(0), k))
			rank = If(keyword IsNot Nothing, keywordsRankList(keyword), -1)
			If rank = -1 Then
				For Each syn In synonyms.Skip(1)
					keyword = keywordsRankList.Keys.FirstOrDefault(Function(k) MatchWord(syn, k))
					rank += If(keyword IsNot Nothing, keywordsRankList(keyword), -1)
					If rank > -1 Then
						Exit For
					End If
				Next syn
			End If
			Return rank > -1
		End Function
		Private Shared Function DoSearch(ByVal requests As List(Of String()), ByVal product As DemoProductModel) As IEnumerable(Of SearchResult)
			Dim results = New List(Of SearchResult)()
			If product.Overview IsNot Nothing Then
				results.AddRange(GetRes(requests, product.Overview, String.Format("{0}", HighlightOccurences(product.Overview.Title, requests)), product.Overview.Product.Title.ToUpper()))
			End If
			For Each group In product.Groups
				If group.Overview IsNot Nothing Then
					results.AddRange(GetRes(requests, group.Overview, String.Format("{0} ({1})", HighlightOccurences(group.Overview.Title, requests), HighlightOccurences(group.Overview.Group.Title, requests)), group.Overview.Product.Title.ToUpper()))
				End If
				For Each demo In group.Demos
					results.AddRange(GetRes(requests, demo, String.Format("{0} ({1})", HighlightOccurences(demo.Title, requests), HighlightOccurences(demo.Group.Title, requests)), demo.Product.Title.ToUpper()))
				Next demo
			Next group
			Return results
		End Function
		Private Shared Function GetRes(ByVal requests As List(Of String()), ByVal demo As DemoPageModel, ByVal text As String, ByVal productText As String) As IEnumerable(Of SearchResult)
			Dim results = New List(Of SearchResult)()
			Dim rank = CalculateRank(requests, demo)
			If rank > -1 Then
				Dim sr = New SearchResult(demo, rank)
				sr.Text = text
				sr.ProductText = productText
				results.Add(sr)
			End If
			Return results
		End Function

		Private Shared Function HighlightOccurences(ByVal text As String, ByVal requests As List(Of String())) As String
			Dim validRequest = New Regex("[0-9a-zA-Z]{2,}", RegexOptions.IgnoreCase)
			For Each request In requests.SelectMany(Function(r) r)
				If validRequest.IsMatch(request) Then
					Dim re As New Regex("([a-zA-Z0-9]*" & request & "[a-zA-Z0-9]*)", RegexOptions.IgnoreCase)
					text = re.Replace(text, "<b>$0</b>")
				End If
			Next request
			Return text
		End Function

		Private Shared Function SplitRequests(ByVal request As String) As List(Of String())
			Dim words = request.Split(separators, StringSplitOptions.RemoveEmptyEntries)
			Dim result = New List(Of String())()
			For Each word In words
				Dim resultWord = PrepareWord(word)
				Dim synonymList = Synonyms.FirstOrDefault(Function(list) list.Any(Function(s) MatchWord(resultWord, s)))
				Dim wordSynonyms = New List(Of String)() From {resultWord}
				If synonymList IsNot Nothing Then
					wordSynonyms.AddRange(synonymList.Where(Function(s) (Not MatchWord(resultWord, s))))
				End If
				result.Add(wordSynonyms.Distinct().ToArray())
			Next word
			Return result
		End Function
		Private Shared Function PrepareWord(ByVal word As String) As String
			For Each prefix In PrefixesExclusions
				If word.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase) AndAlso word.Length > prefix.Length Then
					word = word.Remove(0, prefix.Length)
				End If
			Next prefix
			For Each postfix In PostfixesExclusions
				If word.EndsWith(postfix, StringComparison.InvariantCultureIgnoreCase) AndAlso word.Length > postfix.Length Then
					word = word.Substring(0, word.Length - postfix.Length)
				End If
			Next postfix
			Return word
		End Function
		Private Shared Function MatchWord(ByVal request As String, ByVal word As String) As Boolean
			Return word.IndexOf(request, StringComparison.InvariantCultureIgnoreCase) > -1
		End Function
		Friend Shared Function GetKeywordsList(ParamArray ByVal words() As String) As String()
			Return words.SelectMany(Function(w) w.Split(separators, StringSplitOptions.RemoveEmptyEntries)).Distinct().ToArray()
		End Function

		Private Shared Function GetKeywordsRankList(ByVal textRanks As List(Of TextRank)) As Dictionary(Of String, Integer)
			Dim result = New Dictionary(Of String, Integer)()
			For Each textRank In textRanks
				Dim words = textRank.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
				For Each word In words
					Dim rankWord = PrepareWord(word)
					If (Not result.ContainsKey(rankWord)) Then
						result(rankWord) = textRank.Rank
					End If
				Next word
			Next textRank
			Return result.OrderByDescending(Function(keyValuePair) keyValuePair.Value).ToDictionary(Function(keyValuePair) keyValuePair.Key, Function(keyValuePair) keyValuePair.Value)
		End Function
	End Class


	Public Class TextRank
		Public Sub New(ByVal text As String, ByVal rank As Integer)
			Me.Text = text
			Me.Rank = rank
		End Sub
		Public Property Text() As String
		Public Property Rank() As Integer
	End Class

	Public Class ErrorMessageModel
		Public Property Title() As String
		Public Property NavigateUrl() As String
	End Class

	Public Class SearchResult
		Implements IComparable(Of SearchResult)
		Public Sub New(ByVal demo As DemoModel, ByVal rank As Integer)
			Me.Demo = demo
			Me.Rank = rank
			Product = demo.Product
			If TypeOf demo Is DemoPageModel Then
				Group = (TryCast(demo, DemoPageModel)).Group
			End If
		End Sub

		Public Property Product() As DemoProductModel
		Public Property Demo() As DemoModel
		Public Property Group() As DemoGroupModel
		Public Property Text() As String
		Public Property ProductText() As String

		Public Rank As Integer = 0

		#Region "IComparable<SearchResult> Members"

		Public Function CompareTo(ByVal other As SearchResult) As Integer Implements IComparable(Of SearchResult).CompareTo
			Return other.Rank.CompareTo(Rank)
		End Function

		#End Region
	End Class
	Public Class DemoException
		Inherits Exception
		Public Sub New(ByVal message As String)
			MyBase.New(message)
		End Sub
	End Class
End Namespace
