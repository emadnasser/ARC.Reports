Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Collections.Generic

Namespace DevExpress.Web.Demos

	Public Class DemoGroupModel
		Inherits DemoModelBase
		Private _demos As New List(Of DemoPageModel)()
		Private _overview As OverviewPageModel

		<XmlElement(Type := GetType(DemoPageModel), ElementName := "Demo")> _
		Public ReadOnly Property Demos() As List(Of DemoPageModel)
			Get
				Return _demos
			End Get
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

		Public Function FindDemo(ByVal key As String) As DemoModel
			key = key.ToLower()
			For Each demo As DemoModel In Demos
				If key = demo.Key.ToLower() Then
					Return demo
				End If
			Next demo
			If Overview IsNot Nothing AndAlso key = Overview.Key.ToLower() Then
				Return Overview
			End If
			Return Nothing
		End Function

		Public Function GetAllDemos() As List(Of DemoPageModel)
			Dim result As New List(Of DemoPageModel)()
			If Overview IsNot Nothing Then
				Dim overviewDemo As DemoPageModel = TryCast(Overview, DemoPageModel)
				overviewDemo.Key = Overview.Key
				result.Add(overviewDemo)
			End If
			result.AddRange(Demos)
			Return result
		End Function

		Public Property Product() As DemoProductModel
	End Class

End Namespace
