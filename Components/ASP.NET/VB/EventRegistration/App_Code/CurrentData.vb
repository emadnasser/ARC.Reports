Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.SessionState

Namespace EventRegistration

	Public NotInheritable Class CurrentData
		Private Sub New()
		End Sub
		Private Shared ReadOnly Property Session() As HttpSessionState
			Get
				Return HttpContext.Current.Session
			End Get
		End Property

		Public Shared ReadOnly Property Sessions() As SessionList
			Get
				If Session("Sessions") Is Nothing Then
					Session("Sessions") = (CType(HttpContext.Current.Application("Sessions"), SessionList)).CreateCopy()
				End If
				Return CType(Session("Sessions"), SessionList)
			End Get
		End Property
		Public Shared ReadOnly Property FeaturedSessions() As SessionList
			Get
				Return Sessions.GetFeaturedSessions()
			End Get
		End Property

		Public Shared ReadOnly Property FeaturedSessionsRotator() As FeaturedSessionsRotator
			Get
				If Session("FeaturedSessionsRotator") Is Nothing Then
					Session("FeaturedSessionsRotator") = New FeaturedSessionsRotator(FeaturedSessions)
				End If
				Return CType(Session("FeaturedSessionsRotator"), FeaturedSessionsRotator)
			End Get
		End Property

		Public Shared Property RegistrationInfo() As PersonalData
			Get
				If Session("RegistrationInfo") Is Nothing Then
					Session("RegistrationInfo") = New PersonalData()
				End If
				Return CType(Session("RegistrationInfo"), PersonalData)
			End Get
			Set(ByVal value As PersonalData)
				Session("RegistrationInfo") = value
			End Set
		End Property

		Public Shared Property SelectedDayIndex() As Integer
			Get
				If Session("SelectedDayIndex") Is Nothing Then
					Session("SelectedDayIndex") = 0
				End If
				Return CInt(Fix(Session("SelectedDayIndex")))
			End Get
			Set(ByVal value As Integer)
				Session("SelectedDayIndex") = value
			End Set
		End Property

		Public Shared Property RegistrationDate() As DateTime
			Get
				Return If(Session("RegistrationDate") Is Nothing, New DateTime(), CDate(Session("RegistrationDate")))
			End Get
			Set(ByVal value As DateTime)
				Session("RegistrationDate") = value
			End Set
		End Property

		Public Shared Property PrintingStatus() As String
			Get
				Return If(Session("PrintingStatus") Is Nothing, "Selected", CStr(Session("PrintingStatus")))
			End Get
			Set(ByVal value As String)
				Session("PrintingStatus") = value
			End Set
		End Property

	End Class

End Namespace
