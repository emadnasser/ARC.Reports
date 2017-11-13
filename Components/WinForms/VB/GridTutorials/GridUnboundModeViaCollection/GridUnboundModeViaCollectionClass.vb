Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class GridUnboundModeViaCollectionRecord
		Private fID As Integer
		Private fProductName As String
		Private fCategory As String
		Private fDiscontinued As Boolean
		Private fUnitPrice As Double

		Public Sub New(ByVal fID As Integer, ByVal fProductName As String, ByVal fCategory As String, ByVal fDiscontinued As Boolean, ByVal fUnitPrice As Double)
			Me.fID = fID
			Me.fProductName = fProductName
			Me.fCategory = fCategory
			Me.fDiscontinued = fDiscontinued
			Me.fUnitPrice = fUnitPrice
		End Sub

		Public ReadOnly Property ID() As Integer
			Get
				Return fID
			End Get
		End Property

		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set
				fProductName = Value
			End Set
		End Property

		Public Property Category() As String
			Get
				Return fCategory
			End Get
			Set
				fCategory = Value
			End Set
		End Property

		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set
				fDiscontinued = Value
			End Set
		End Property

		Public Property UnitPrice() As Double
			Get
				Return fUnitPrice
			End Get
			Set
				fUnitPrice = Value
			End Set
		End Property
	End Class
End Namespace
