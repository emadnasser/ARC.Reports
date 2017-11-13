Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Docs.Text

Partial Public Class Miscellaneous_NumberInWords
	Inherits System.Web.UI.Page
	#Region "Fields"
	Private Const cultureNodeName As String = "Culture"
	Private Const valueNodeName As String = "Value"
	Private Shared numberCultures As List(Of DevExpress.Docs.Demo.NumberCultureDescription) = CreateNumberCultures()
	Private Shared cardinalNumbers As INumberInWordsProvider = Nothing
	Private Shared ordinalNumbers As INumberInWordsProvider = Nothing
	#End Region

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If cardinalNumbers Is Nothing Then
			cardinalNumbers = NumberInWords.Cardinal
		End If
		If ordinalNumbers Is Nothing Then
			ordinalNumbers = NumberInWords.Ordinal
		End If
		PrepareTreeList(Convert.ToInt32(spnNumber.Value))
	End Sub

	Private Sub PrepareTreeList(ByVal value As Integer)
		For Each item As DevExpress.Docs.Demo.NumberCultureDescription In numberCultures
			Dim key As Integer = CInt(Fix(item.Id)) * 10
			Dim firstLevelNode As TreeListNode = tlResult.AppendNode(key)
			firstLevelNode(cultureNodeName) = item.Name
			Dim secondLevelNode As TreeListNode = tlResult.AppendNode(key + 1, firstLevelNode)
			secondLevelNode(cultureNodeName) = "Cardinal"
			secondLevelNode(valueNodeName) = GetTextualRepresentation(cardinalNumbers, item.Id, value)
			secondLevelNode = tlResult.AppendNode(key + 2, firstLevelNode)
			secondLevelNode(cultureNodeName) = "Ordinal"
			secondLevelNode(valueNodeName) = GetTextualRepresentation(ordinalNumbers, item.Id, value)
		Next item
		tlResult.ExpandAll()
	End Sub

	Protected Sub tlResult_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs)
	End Sub

	#Region "CreateNumberCultures"
	Private Shared Function CreateNumberCultures() As List(Of DevExpress.Docs.Demo.NumberCultureDescription)
		Dim result As New List(Of DevExpress.Docs.Demo.NumberCultureDescription)()
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.English, "English"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Roman, "Roman"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.French, "French(Français)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.German, "German(Deutsch)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Italian, "Italian(Italiano)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Russian, "Russian(Русский)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Swedish, "Swedish(Svensk)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Turkish, "Turkish(Türkçe)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Greek, "Greek(Ελληνικά)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Spanish, "Spanish(Español)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Portuguese, "Portuguese(Português)"))
		result.Add(New DevExpress.Docs.Demo.NumberCultureDescription(NumberCulture.Ukrainian, "Ukrainian(Український)"))
		Return result
	End Function
	#End Region

	Private Function GetTextualRepresentation(ByVal provider As INumberInWordsProvider, ByVal numberCulture As NumberCulture, ByVal value As Integer) As String
		Dim result As String
		Try
			result = provider.ConvertToText(value, numberCulture)
		Catch
			result = String.Empty
		End Try
		Return result
	End Function
End Class

Namespace DevExpress.Docs.Demo
	Public Class NumberCultureDescription
		Public Property Id() As NumberCulture
		Public Property Name() As String
		Public Sub New(ByVal id As NumberCulture, ByVal name As String)
			Id = id
			Name = name
		End Sub
	End Class
End Namespace
