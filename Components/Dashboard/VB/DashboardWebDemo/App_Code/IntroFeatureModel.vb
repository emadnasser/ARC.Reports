Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace DevExpress.Web.Demos

	Public Class IntroFeatureModel
		Private _title As String
		Private _description As String
		Private _imageUrl As String

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
		Public Property ImageUrl() As String
			Get
				If _imageUrl Is Nothing Then
					Return ""
				End If
				Return _imageUrl
			End Get
			Set(ByVal value As String)
				_imageUrl = value
			End Set
		End Property

		<XmlElement> _
		Public Property Description() As String
			Get
				If _description Is Nothing Then
					Return ""
				End If
				Return _description
			End Get
			Set(ByVal value As String)
				If value IsNot Nothing Then
					value = value.Trim()
				End If
				_description = value
			End Set
		End Property

	End Class

End Namespace
