Imports System
Imports System.Collections.Generic

Namespace DevExpress.DemoData.Models
    Partial Public Class Employee
        Public Property EmployeeID() As Long
        Public Property LastName() As String
        Public Property FirstName() As String
        Public Property Title() As String
        Public Property TitleOfCourtesy() As String
        Public Property BirthDate() As Date?
        Public Property HireDate() As Date?
        Public Property Address() As String
        Public Property City() As String
        Public Property Region() As String
        Public Property PostalCode() As String
        Public Property Country() As String
        Public Property HomePhone() As String
        Public Property Extension() As String
        Public Property Photo() As Byte()
        Public Property Notes() As String
        Public Property ReportsTo() As Long?
        Public Property Email() As String

        Public ReadOnly Property PageHeader() As String
            Get
                Return (FirstName & " " & LastName).ToUpper()
            End Get
        End Property
        Public ReadOnly Property PageContent() As String
            Get
                Return FirstName & " " & LastName & " was born on " & DateToString(BirthDate) & ". Now lives at " & City & ", " & Country & ". " & TitleOfCourtesy & " " & LastName & " holds a position of " & Title & " our " & Region & " deparment, (" & City & " " & Country & "). Joined our company on " & DateToString(HireDate) & "."
            End Get
        End Property
        Private Function DateToString(ByVal [date]? As Date) As String
            If [date] Is Nothing Then
                Return Nothing
            End If
            Dim Months() As String = { "January", "February", "Marth", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
            Return [date].Value.Day & "th of " & Months([date].Value.Month - 1) & " in " & [date].Value.Year
        End Function

    End Class
End Namespace
