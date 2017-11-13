Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Docs.Text
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.Docs.Demos
	Partial Public Class NumberToWords
		Inherits TutorialControlBase
		#Region "Fields"
		Private numberCultures As List(Of NumberCultureDescription)
		Private cardinalNumbers As INumberInWordsProvider
		Private ordinalNumbers As INumberInWordsProvider
		Private currentNumber As Long
		#End Region

		Public Sub New()
			InitializeComponent()
			SetMinMaxValues()
			numberCultures = CreateNumberCultures()
			cardinalNumbers = NumberInWords.Cardinal
			ordinalNumbers = NumberInWords.Ordinal
			PrepareTreeList()
		End Sub

		Private Sub spinEdit1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numberSpinEdit.ValueChanged
			currentNumber = CLng(Fix(numberSpinEdit.Value))
			ApplyNumber()
		End Sub

		#Region "CreateNumberCultures"
		Private Shared Function CreateNumberCultures() As List(Of NumberCultureDescription)
			Dim result As New List(Of NumberCultureDescription)()
			result.Add(New NumberCultureDescription(NumberCulture.English, "English"))
			result.Add(New NumberCultureDescription(NumberCulture.English_UnitedKingdom, "English(United Kingdom)"))
			result.Add(New NumberCultureDescription(NumberCulture.French, "French(Français)"))
			result.Add(New NumberCultureDescription(NumberCulture.German, "German(Deutsch)"))
			result.Add(New NumberCultureDescription(NumberCulture.Greek, "Greek(Ελληνικά)"))
			result.Add(New NumberCultureDescription(NumberCulture.Hindi, "Hindi(हिन्दी)"))
			result.Add(New NumberCultureDescription(NumberCulture.Italian, "Italian(Italiano)"))
			result.Add(New NumberCultureDescription(NumberCulture.Portuguese, "Portuguese(Português)"))
			result.Add(New NumberCultureDescription(NumberCulture.Russian, "Russian(Русский)"))
			result.Add(New NumberCultureDescription(NumberCulture.Spanish, "Spanish(Español)"))
			result.Add(New NumberCultureDescription(NumberCulture.Swedish, "Swedish(Svensk)"))
			result.Add(New NumberCultureDescription(NumberCulture.Thai, "Thai(ไทย)"))
			result.Add(New NumberCultureDescription(NumberCulture.Turkish, "Turkish(Türkçe)"))
			result.Add(New NumberCultureDescription(NumberCulture.Ukrainian, "Ukrainian(Український)"))
			Return result
		End Function
		#End Region

		Private Sub SetMinMaxValues()
			Me.numberSpinEdit.Properties.MinValue = 0
			Me.numberSpinEdit.Properties.MaxValue = Long.MaxValue
		End Sub

		Private Function GetTextualRepresentation(ByVal provider As INumberInWordsProvider, ByVal numberCulture As NumberCulture, ByVal value As Long) As String
			Dim result As String
			Try
				result = provider.ConvertToText(value, numberCulture)
			Catch
				result = String.Empty
			End Try
			Return result
		End Function

		Private Sub PrepareTreeListColumns()
			Dim column As TreeListColumn = resultTreeList.Columns.Add()
			column.Caption = "Culture"
			column.OptionsColumn.FixedWidth = True
			column.Width = 150
			column.VisibleIndex = 0
			column = resultTreeList.Columns.Add()
			column.Caption = "Value"
			column.VisibleIndex = 1
		End Sub

		Private Sub PrepareTreeListNodes()
			For Each item As NumberCultureDescription In numberCultures
				Dim rootListNode As TreeListNode = Nothing
				Dim firstLevelNode As TreeListNode = resultTreeList.AppendNode(New Object() { item.Name }, rootListNode)
				Dim secondLevelNode As TreeListNode = resultTreeList.AppendNode(New Object() { "Cardinal", GetTextualRepresentation(cardinalNumbers, item.Id, currentNumber) }, firstLevelNode)
				item.CardinalNodeId = secondLevelNode.Id
				secondLevelNode = resultTreeList.AppendNode(New Object() { "Ordinal", GetTextualRepresentation(ordinalNumbers, item.Id, currentNumber) }, firstLevelNode)
				item.OrdinalNodeId = secondLevelNode.Id
			Next item
		End Sub

		Private Sub PrepareTreeList()
			currentNumber = Convert.ToInt32(numberSpinEdit.Value)

			resultTreeList.BeginUpdate()
			Try
				PrepareTreeListColumns()
				PrepareTreeListNodes()
				resultTreeList.ExpandAll()
			Finally
				resultTreeList.EndUpdate()
			End Try
		End Sub

		Private Sub ApplyValue(ByVal provider As INumberInWordsProvider, ByVal itemId As NumberCulture, ByVal nodeId As Integer, ByVal value As Long)
			If nodeId >= 0 Then
				Dim node As TreeListNode = resultTreeList.FindNodeByID(nodeId)
				If node IsNot Nothing Then
					node("Value") = GetTextualRepresentation(provider, itemId, value)
				End If
			End If
		End Sub

		Private Sub ApplyNumber()
			resultTreeList.BeginUpdate()
			Try
				For Each item As NumberCultureDescription In numberCultures
					ApplyValue(cardinalNumbers, item.Id, item.CardinalNodeId, currentNumber)
					ApplyValue(ordinalNumbers, item.Id, item.OrdinalNodeId, currentNumber)
				Next item
			Finally
				resultTreeList.EndUpdate()
			End Try
		End Sub
	End Class

	Public Class NumberCultureDescription
		Private privateId As NumberCulture
		Public Property Id() As NumberCulture
			Get
				Return privateId
			End Get
			Set(ByVal value As NumberCulture)
				privateId = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateCardinalNodeId As Integer
		Public Property CardinalNodeId() As Integer
			Get
				Return privateCardinalNodeId
			End Get
			Set(ByVal value As Integer)
				privateCardinalNodeId = value
			End Set
		End Property
		Private privateOrdinalNodeId As Integer
		Public Property OrdinalNodeId() As Integer
			Get
				Return privateOrdinalNodeId
			End Get
			Set(ByVal value As Integer)
				privateOrdinalNodeId = value
			End Set
		End Property
		Public Sub New(ByVal id As NumberCulture, ByVal name As String)
			Id = id
			Name = name
			CardinalNodeId = -1
			OrdinalNodeId = -1
		End Sub
	End Class
End Namespace
