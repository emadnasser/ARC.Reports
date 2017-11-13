Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.Web.Internal

Namespace DevExpress.Web.Demos
	Public NotInheritable Class ViewerSelectorState
		Public Const Key As String = "CurrentViewer"
		Public Const ModernViewer As String = "HTML5"
		Public Const ClassicViewer As String = "ASP"
		Public Const MobileViewer As String = "Mobile"

		Public Shared ReadOnly Items() As Item

		Private Sub New()
		End Sub
		Shared Sub New()
			Dim generateAspViewerUrlDelegate = New Func(Of Uri, String)(AddressOf GenerateAspViewerUrl)
			Dim generateHtml5ViewerUrlDelegate = New Func(Of Uri, String)(AddressOf GenerateHtml5ViewerUrl)
			Dim generateMobileViewerUrlDelegate = New Func(Of Uri, String)(AddressOf GenerateMobileViewerUrl)
			Items = New Item() { New Item(generateAspViewerUrlDelegate) With {.Name = "ASP", .Text = "ASP.NET Viewer", .CssClass = "viewer-selector-asp"}, New Item(generateHtml5ViewerUrlDelegate) With {.Name = "HTML5", .Text = "HTML JS Viewer", .CssClass = "viewer-selector-html5"}, New Item(generateMobileViewerUrlDelegate) With {.Name = "Mobile", .Text = "Mobile Viewer", .CssClass = "viewer-selector-html5"} }
		End Sub

		Public Shared Function GetByName(ByVal name As String) As Item
			Return Items.FirstOrDefault(Function(x) x.Name = name)
		End Function

		Private Shared Function GenerateAspViewerUrl(ByVal requestUrl As Uri) As String
			Dim builder = New UriBuilder(requestUrl)
			builder.Query = Key & "=" & ClassicViewer
			Return builder.ToString()
		End Function

		Private Shared Function GenerateHtml5ViewerUrl(ByVal requestUrl As Uri) As String
			Dim builder = New UriBuilder(requestUrl)
			builder.Query = ""
			Return builder.ToString()
		End Function

		Private Shared Function GenerateMobileViewerUrl(ByVal requestUrl As Uri) As String
			Dim builder = New UriBuilder(requestUrl)
			builder.Query = Key & "=" & MobileViewer
			Return builder.ToString()
		End Function

		Public Class Item
			Private ReadOnly generateUrl_Renamed As Func(Of Uri, String)

			Public Sub New(ByVal generateUrl As Func(Of Uri, String))
				Me.generateUrl_Renamed = generateUrl
			End Sub

			Public Function GenerateUrl(ByVal requestUri As Uri) As String
				Return generateUrl_Renamed(requestUri)
			End Function

			Public Property Name() As String
			Public Property Text() As String
			Public Property CssClass() As String
		End Class
	End Class
End Namespace
