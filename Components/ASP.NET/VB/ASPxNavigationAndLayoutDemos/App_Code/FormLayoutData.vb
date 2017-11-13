Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Enum Gender
	Male = 0
	Female = 1
End Enum
Public Class Person
	Public Property FirstName() As String
	Public Property LastName() As String
	Public Property Gender() As Gender
	Public Property BirthDate() As DateTime?
	Public Property Country() As String
	Public Property Address() As String
	Public Property PhoneNumber() As String
End Class
