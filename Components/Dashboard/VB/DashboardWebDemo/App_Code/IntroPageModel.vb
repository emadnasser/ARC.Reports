Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace DevExpress.Web.Demos

	Public Class IntroPageModel
		Inherits DemoModel
		Private _bannerTitle As String
		Private _bannerText As String
		Private _bannerImageUrl As String
		Private _bannerUrl As String
		Private _descriptionTitle As String
		Private _descriptionFooter As String
		Private _externalDemos As New List(Of ExternalDemoModel)()

		<XmlIgnore> _
		Public Overrides Property Key() As String
			Get
				Return If(Utils.IsMvc, "Index", "Default")
			End Get
			Set(ByVal value As String)
			End Set
		End Property

		<XmlElement> _
		Public Property BannerTitle() As String
			Get
				If _bannerTitle Is Nothing Then
					Return ""
				End If
				Return _bannerTitle
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_bannerTitle = value
			End Set
		End Property

		<XmlElement> _
		Public Property BannerText() As String
			Get
				If _bannerText Is Nothing Then
					Return ""
				End If
				Return _bannerText
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_bannerText = value
			End Set
		End Property

		<XmlElement> _
		Public Property BannerImageUrl() As String
			Get
				If _bannerImageUrl Is Nothing Then
					Return ""
				End If
				Return _bannerImageUrl
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_bannerImageUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property BannerUrl() As String
			Get
				If _bannerUrl Is Nothing Then
					Return ""
				End If
				Return _bannerUrl
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_bannerUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property DescriptionTitle() As String
			Get
				If _descriptionTitle Is Nothing Then
					Return ""
				End If
				Return _descriptionTitle
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_descriptionTitle = value
			End Set
		End Property

		' Html is allowed here
		<XmlElement> _
		Public Property DescriptionFooter() As String
			Get
				If _descriptionFooter Is Nothing Then
					Return ""
				End If
				Return _descriptionFooter
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_descriptionFooter = value
			End Set
		End Property

		<XmlElement("ExternalDemo")> _
		Public ReadOnly Property ExternalDemos() As List(Of ExternalDemoModel)
			Get
				Return _externalDemos
			End Get
		End Property

	End Class

End Namespace
