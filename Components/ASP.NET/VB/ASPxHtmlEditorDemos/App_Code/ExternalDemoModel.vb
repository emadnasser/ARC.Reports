Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Xml.Serialization

Namespace DevExpress.Web.Demos

	Public Class ExternalDemoModel
		Private _imageUrl As String
		Private _url As String
		Private _title As String

		<XmlAttribute> _
		Public Property ImageUrl() As String
			Get
				Return _imageUrl
			End Get
			Set(ByVal value As String)
				_imageUrl = value
			End Set
		End Property

		<XmlAttribute> _
		Public Property Url() As String
			Get
				Return _url
			End Get
			Set(ByVal value As String)
				_url = value
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
