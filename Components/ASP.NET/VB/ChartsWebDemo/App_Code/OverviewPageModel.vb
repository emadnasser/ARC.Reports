Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Collections.Generic
Imports System.Web

Namespace DevExpress.Web.Demos

	Public Class OverviewPageModel
		Inherits DemoPageModel
		Private _keyFeatures As New List(Of KeyFeatureModel)()
		Private _descriptionTitle As String

		<XmlIgnore> _
		Public Overrides Property Key() As String
			Get
				Return "Overview"
			End Get
			Set(ByVal value As String)
			End Set
		End Property
		<XmlElement("KeyFeature")> _
		Public Property KeyFeatures() As List(Of KeyFeatureModel)
			Get
				Return _keyFeatures
			End Get
			Set(ByVal value As List(Of KeyFeatureModel))
				_keyFeatures = value
			End Set
		End Property
		<XmlElement("DescriptionTitle")> _
		Public Property DescriptionTitle() As String
			Get
				Return _descriptionTitle
			End Get
			Set(ByVal value As String)
				_descriptionTitle = value
			End Set
		End Property
	End Class
	Public Class KeyFeatureModel
		Private _name As String
		Private _demoUrl As String
		Private _description As String

		<XmlAttribute> _
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				_name = value
			End Set
		End Property
		<XmlAttribute> _
		Public Property DemoUrl() As String
			Get
				Return _demoUrl
			End Get
			Set(ByVal value As String)
				_demoUrl = value
			End Set
		End Property
		<XmlElement> _
		Public Property Description() As String
			Get
				Return _description
			End Get
			Set(ByVal value As String)
				_description = value
			End Set
		End Property
		Public Function GetNameHtml() As String
			Return If((Not String.IsNullOrEmpty(DemoUrl)), String.Format("<a href='{0}'>{1}</a>", VirtualPathUtility.ToAbsolute(DemoUrl), Name), Name)
		End Function
	End Class
End Namespace
