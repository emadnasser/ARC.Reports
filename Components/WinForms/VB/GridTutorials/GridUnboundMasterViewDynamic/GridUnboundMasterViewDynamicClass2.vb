Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class GridUnboundMasterViewDynamicRecords
		Inherits ArrayList
		Implements DevExpress.Data.IRelationList
		Public Sub New()
			Add(New GridUnboundMasterViewDynamicMainRecord(1, "John", "Smith"))
			Add(New GridUnboundMasterViewDynamicMainRecord(2, "Mike", "Jones"))
			Add(New GridUnboundMasterViewDynamicMainRecord(3, "Helene", "Andersson"))
			Add(New GridUnboundMasterViewDynamicMainRecord(4, "Nick", "Sandberg"))
			Add(New GridUnboundMasterViewDynamicMainRecord(5, "Joe", "Black"))
		End Sub
		Private cr As GridUnboundMasterViewDynamicChildRecords = New GridUnboundMasterViewDynamicChildRecords()
		'IRelationList
		Private Function GetRelationName(ByVal index As Integer, ByVal relationIndex As Integer) As String Implements IRelationList.GetRelationName
			If (relationIndex = 0) Then
				Return "Sons"
			Else
				Return "Daughters"
			End If
		End Function

		Private ReadOnly Property RelationCount() As Integer Implements IRelationList.RelationCount
			Get
				Return 2
			End Get
		End Property

		Private Function GetDetailList(ByVal index As Integer, ByVal relationIndex As Integer) As IList Implements IRelationList.GetDetailList
			Return cr.GetSubset(Me(index).ID, relationIndex)
		End Function

		Private Function IsMasterRowEmpty(ByVal index As Integer, ByVal relationIndex As Integer) As Boolean Implements IRelationList.IsMasterRowEmpty
			Return cr.Childs(Me(index).ID, relationIndex)
		End Function
		'IRelationList

		Public Overridable Shadows ReadOnly Default Property Item(ByVal index As Integer) As GridUnboundMasterViewDynamicMainRecord
			Get
				Return CType(MyBase.Item(index), GridUnboundMasterViewDynamicMainRecord)
			End Get
		End Property
	End Class
	Public Class GridUnboundMasterViewDynamicMainRecord

		Private fID As Integer
		Private fFirstName As String
		Private fLastName As String

		Public ReadOnly Property ID() As Integer
			Get
				Return fID
			End Get
		End Property

		Public Property FirstName() As String
			Get
				Return fFirstName
			End Get
			Set
				fFirstName = Value
			End Set
		End Property

		Public Property LastName() As String
			Get
				Return fLastName
			End Get
			Set
				fLastName = Value
			End Set
		End Property

		Public Sub New(ByVal fID As Integer, ByVal fFirstName As String, ByVal fLastName As String)
			Me.fID = fID
			Me.fFirstName = fFirstName
			Me.fLastName = fLastName
		End Sub

	End Class
	Public Class GridUnboundMasterViewDynamicChildRecords
		Inherits ArrayList
		Public Sub New()
			Add(New GridUnboundMasterViewDynamicChildRecord("Tom", 12, True, 1))
			Add(New GridUnboundMasterViewDynamicChildRecord("Susan", 13, False, 1))
			Add(New GridUnboundMasterViewDynamicChildRecord("Louis", 14, True, 1))
			Add(New GridUnboundMasterViewDynamicChildRecord("Irene", 5, False, 2))
			Add(New GridUnboundMasterViewDynamicChildRecord("Martha", 10, False, 2))
			Add(New GridUnboundMasterViewDynamicChildRecord("Samuel", 7, True, 3))
			Add(New GridUnboundMasterViewDynamicChildRecord("Louisa", 17, False, 3))
			Add(New GridUnboundMasterViewDynamicChildRecord("Mark", 8, True, 4))
			Add(New GridUnboundMasterViewDynamicChildRecord("Sadie", 4, False, 3))
		End Sub

		Public Overridable Shadows ReadOnly Default Property Item(ByVal index As Integer) As GridUnboundMasterViewDynamicChildRecord
			Get
				Return CType(MyBase.Item(index), GridUnboundMasterViewDynamicChildRecord)
			End Get
		End Property

		Public Function GetSubset(ByVal index As Integer, ByVal relationIndex As Integer) As IList
			Dim list As IList = New System.Collections.ArrayList()
			Dim i As Integer = 0
			Do While i < Me.Count
				If Me(i).ParentID = index Then
					If Me(i).IsSon() AndAlso relationIndex = 0 Then
						list.Add(Me(i))
					End If
					If (Not Me(i).IsSon()) AndAlso relationIndex = 1 Then
						list.Add(Me(i))
					End If
				End If
				i += 1
			Loop
			Return list
		End Function
		Public Function Childs(ByVal index As Integer, ByVal relationIndex As Integer) As Boolean
			Dim i As Integer = 0
			Do While i < Me.Count
				If Me(i).ParentID = index Then
					If Me(i).IsSon() AndAlso relationIndex = 0 Then
						Return False
					End If
					If (Not Me(i).IsSon()) AndAlso relationIndex = 1 Then
						Return False
					End If
				End If
				i += 1
			Loop
			Return True
		End Function
	End Class
	Public Class GridUnboundMasterViewDynamicChildRecord
		Private fAge As Integer
		Private fName As String
		Private fIsSon As Boolean
		Private fParentID As Integer

		Public Function IsSon() As Boolean
			Return fIsSon
		End Function

		Public Property Age() As Integer
			Get
				Return fAge
			End Get
			Set
				fAge = Value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return fName
			End Get
			Set
				fName = Value
			End Set
		End Property
		Public ReadOnly Property ParentID() As Integer
			Get
				Return fParentID
			End Get
		End Property
		Public Sub New(ByVal fName As String, ByVal fAge As Integer, ByVal fIsSon As Boolean, ByVal fParentID As Integer)
			Me.fName = fName
			Me.fAge = fAge
			Me.fIsSon = fIsSon
			Me.fParentID = fParentID
		End Sub
	End Class
End Namespace
