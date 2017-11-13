Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Web.UI

Namespace DevExpress.Web.Demos

	Public Class ThemeGroupModel
		Inherits ThemeModelBase
		Private _themes As New List(Of ThemeModel)()
		Private _float As String

		<XmlElement(ElementName := "Theme")> _
		Public ReadOnly Property Themes() As List(Of ThemeModel)
			Get
				Return _themes
			End Get
		End Property

		<XmlAttribute> _
		Public Property Float() As String
			Get
				Return _float
			End Get
			Set(ByVal value As String)
				_float = value
			End Set
		End Property
	End Class

End Namespace
