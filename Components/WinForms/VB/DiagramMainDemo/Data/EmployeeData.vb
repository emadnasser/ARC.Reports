Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Xml.Serialization

Namespace DevExpress.Diagram.Demos
    <XmlRoot("Employees")>
    Public Class EmployeesWithPhotoData
        Inherits List(Of Employee)

    End Class
    Public Class Employee
        Public Property Id() As Integer
        Public Property ParentId() As Integer
        Public Property FirstName() As String
        Public Property MiddleName() As String
        Public Property LastName() As String
        Public ReadOnly Property FullName() As String
            Get
                Return FirstName & " " & LastName
            End Get
        End Property
        Public Property JobTitle() As String
        Public Property GroupName() As String
        Public Property Phone() As String
        Public Property EmailAddress() As String
        Public Property AddressLine1() As String
        Public Property City() As String
        Public Property StateProvinceName() As String
        Public Property PostalCode() As String
        Public Property CountryRegionName() As String
        Public Property BirthDate() As Date
        Public Property HireDate() As Date
        Public Property Gender() As String
        Public Property MaritalStatus() As String
        Public Property Title() As String
        Public Property CroppedImageData() As Byte()
        Public Property ImageData() As Byte()
        Public Overrides Function ToString() As String
            Return FirstName & " " & LastName
        End Function
    End Class
    Public NotInheritable Class EmployeesData

        Private Sub New()
        End Sub
        Public Shared ReadOnly Employees As EmployeesWithPhotoData

        Shared Sub New()
            Using stream = DiagramDemoFileHelper.GetDataStream("EmployeesWithPhoto.xml")
                Dim serializer = New XmlSerializer(GetType(EmployeesWithPhotoData))
                Employees = DirectCast(serializer.Deserialize(stream), EmployeesWithPhotoData)
            End Using
        End Sub
    End Class
End Namespace
