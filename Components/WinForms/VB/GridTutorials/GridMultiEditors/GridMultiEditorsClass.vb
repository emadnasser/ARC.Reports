Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class GridMultiEditorsRecord
		Private fCategory As String
		Private fProduct1 As Object
		Private fProduct2 As Object
		Private fProduct3 As Object


		Public Sub New(ByVal fCategory As String, ByVal fProduct1 As Object, ByVal fProduct2 As Object, ByVal fProduct3 As Object)
			Me.fCategory = fCategory
			Me.fProduct1 = fProduct1
			Me.fProduct2 = fProduct2
			Me.fProduct3 = fProduct3
		End Sub

		Public ReadOnly Property Category() As String
			Get
				Return fCategory
			End Get
		End Property

		Public Property Product1() As Object
			Get
				Return fProduct1
			End Get
			Set
				fProduct1 = Value
			End Set
		End Property

		Public Property Product2() As Object
			Get
				Return fProduct2
			End Get
			Set
				fProduct2 = Value
			End Set
		End Property

		Public Property Product3() As Object
			Get
				Return fProduct3
			End Get
			Set
				fProduct3 = Value
			End Set
		End Property
	End Class
End Namespace
